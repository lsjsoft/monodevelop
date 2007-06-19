//
// RecentFileStorage.cs
//
// Implementation of Recent File Storage according to 
// "Recent File Storage Specification v0.2" from freedesktop.org.
//
// http://standards.freedesktop.org/recent-file-spec/recent-file-spec-0.2.html
//
// Author:
//   Mike Krüger <mkrueger@novell.com>
//
// Copyright (C) 2007 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Xml;

namespace Freedesktop.RecentFiles
{
	/// <summary>
	/// Implementation of Recent File Storage according to 
	/// "Recent File Storage Specification v0.2" from freedesktop.org.
	///
	/// http://standards.freedesktop.org/recent-file-spec/recent-file-spec-0.2.html
	/// </summary>
	public sealed class RecentFileStorage
	{
		const int MaxRecentItemsCount = 500; // max. items according to the spec.
		const string FileName = ".recently-used";
		static readonly string RecentFileFullPath = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.Personal), FileName);
				
		FileSystemWatcher watcher;
        ReaderWriterLock readerWriterLock = new ReaderWriterLock();
		
		public RecentFileStorage()
		{
			watcher = new FileSystemWatcher (Environment.GetFolderPath (Environment.SpecialFolder.Personal));
			watcher.Filter = FileName;
			watcher.Created += new FileSystemEventHandler (FileChanged);
			watcher.Changed += new FileSystemEventHandler (FileChanged);
			watcher.Deleted += new FileSystemEventHandler (FileChanged);
			watcher.Renamed += delegate {
				OnRecentFilesChanged (EventArgs.Empty);
			};
			watcher.EnableRaisingEvents = true;
		}
		
		void FileChanged (object sender, FileSystemEventArgs e)
		{
			OnRecentFilesChanged (EventArgs.Empty);
		}
		
		int lockLevel = 0;
		bool IsLocked {
			get {
				return lockLevel > 0;
			}
		}
		void ObtainLock ()
		{
			lockLevel++;
			if (lockLevel == 1) {
				watcher.EnableRaisingEvents = false;
				readerWriterLock.AcquireWriterLock (5000);
			}
		}
		
		void ReleaseLock ()
		{
			if (!IsLocked)
				throw new InvalidOperationException ("not locked.");
			lockLevel--;
			if (lockLevel == 0) {
				readerWriterLock.ReleaseWriterLock ();
				watcher.EnableRaisingEvents = true;
			}
		}
		
		delegate bool RecentItemPredicate (RecentItem item);
		delegate void RecentItemOperation (RecentItem item);
		void FilterOut (RecentItemPredicate pred)
		{
			ObtainLock ();
			try {
				bool filteredSomething = false;
				List<RecentItem> store = ReadStore ();
				for (int i = 0; i < store.Count; ++i) {
					if (pred (store[i])) {
						store.RemoveAt (i);
						filteredSomething = true;
						--i;
						continue;
					}
				}
				if (filteredSomething) 
					WriteStore (store);				
			} finally {
				ReleaseLock ();
			}
		}
		void RunOperation (bool writeBack, RecentItemOperation operation)
		{
			ObtainLock ();
			try {
				List<RecentItem> store = ReadStore ();
				for (int i = 0; i < store.Count; ++i) 
					operation (store[i]);
				if (writeBack) 
					WriteStore (store);
			} finally {
				ReleaseLock ();
			}
		}
		
		public void ClearGroup (string group)
		{
			FilterOut (delegate(RecentItem item) {
				return item.IsInGroup (group);
			});
		}
		
		public void RemoveMissingFiles (string group)
		{
			FilterOut (delegate(RecentItem item) {
				return item.IsInGroup (group) &&
					   item.Uri.IsFile &&
					   !File.Exists (item.Uri.LocalPath);
			});
		}
		
		public void RemoveItem (Uri uri)
		{
			if (uri == null)
				return;
			FilterOut (delegate(RecentItem item) {
				return item.Uri != null && item.Uri.Equals (uri);
			});
		}
		
		public void RemoveItem (RecentItem item)
		{
			if (item != null)
				RemoveItem (item.Uri);
		}
		
		public void RenameItem (Uri oldUri, Uri newUri)
		{
			if (oldUri == null || newUri == null)
				return;
			RunOperation (true, delegate(RecentItem item) {
				if (item.Uri == null)
					return;
				if (item.Uri.Equals (oldUri)) {
					item.Uri = new Uri (newUri.ToString ());
					item.NewTimeStamp ();
				}
			});
		}
		
		public RecentItem[] GetItemsInGroup (string group)
		{
			List<RecentItem> result = new List<RecentItem> ();
			RunOperation (false, delegate(RecentItem item) {
				if (item.IsInGroup (group)) 
					result.Add (item);
			});
			result.Sort ();
			return result.ToArray ();
		}
		
		void CheckLimit (string group, int limit)
		{
			Debug.Assert (IsLocked);
			RecentItem[] items = GetItemsInGroup (group);
			for (int i = limit; i < items.Length; i++)
				this.RemoveItem (items[i]);
		}
		
		public void AddWithLimit (RecentItem item, string group, int limit)
		{
			ObtainLock ();
			try {
				RemoveItem (item.Uri);
				
				List<RecentItem> store = ReadStore ();
				store.Add (item);
				WriteStore (store);
				
				CheckLimit (group, limit);
			} finally {
				ReleaseLock ();
			}
		}
		
		List<RecentItem> ReadStore ()
		{
			Debug.Assert (IsLocked);
			List<RecentItem> result = new List<RecentItem> ();
			if (!File.Exists (RecentFileStorage.RecentFileFullPath))
				return result;
			XmlTextReader reader = new XmlTextReader (RecentFileStorage.RecentFileFullPath);
			try {
				while (true) {
					bool read = false;
					try {
						// seems to crash on empty files ?
						read = reader.Read ();
					} catch (Exception) { 
						read = false; 
					}
					if (!read)
						break;
					if (reader.IsStartElement () && reader.LocalName == RecentItem.Node)
						result.Add (RecentItem.Read (reader));
				}
			} finally {
				if (reader != null)
					reader.Close ();
			}
			return result;
		}
		
		void WriteStore (List<RecentItem> items)
		{
			Debug.Assert (IsLocked);
			items.Sort ();
			if (items.Count > MaxRecentItemsCount)
				items.RemoveRange (MaxRecentItemsCount, items.Count - MaxRecentItemsCount);
			XmlTextWriter writer = new XmlTextWriter (RecentFileStorage.RecentFileFullPath, System.Text.Encoding.UTF8);
			try {
				writer.Formatting = Formatting.Indented;
				writer.WriteStartDocument();
				writer.WriteStartElement ("RecentFiles");
				if (items != null) 
					foreach (RecentItem item in items)
						item.Write (writer);
				writer.WriteEndElement (); // RecentFiles
			} finally {
				writer.Close ();
				OnRecentFilesChanged (EventArgs.Empty);
			}
		}
		
		void OnRecentFilesChanged (EventArgs e)
		{
			if (this.RecentFilesChanged != null)
				this.RecentFilesChanged (this, e);
		}
		
		public event EventHandler RecentFilesChanged;
	}
}
