
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.AddinAuthoring
{
	public partial class AddinFeatureWidget
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.VBox boxLibraryType;

		private global::Gtk.Label labelExtensibleApp;

		private global::Gtk.Label label2;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.VBox vbox3;

		private global::Gtk.RadioButton radiobuttonLibrary;

		private global::Gtk.RadioButton radiobuttonAddin;

		private global::Gtk.HBox boxRepo;

		private global::Gtk.Label label3;

		private global::MonoDevelop.AddinAuthoring.RegistrySelector regSelector;

		private global::Gtk.HSeparator hseparator;

		private global::Gtk.Label labelAddinInfo;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.Table tableNames;

		private global::Gtk.ComboBoxEntry comboNs;

		private global::Gtk.Entry entryId;

		private global::Gtk.Entry entryName;

		private global::Gtk.Label label7;

		private global::Gtk.Label label9;

		private global::Gtk.Label labelName;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.AddinAuthoring.AddinFeatureWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.AddinAuthoring.AddinFeatureWidget";
			// Container child MonoDevelop.AddinAuthoring.AddinFeatureWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.boxLibraryType = new global::Gtk.VBox ();
			this.boxLibraryType.Name = "boxLibraryType";
			this.boxLibraryType.Spacing = 6;
			// Container child boxLibraryType.Gtk.Box+BoxChild
			this.labelExtensibleApp = new global::Gtk.Label ();
			this.labelExtensibleApp.Name = "labelExtensibleApp";
			this.labelExtensibleApp.Xalign = 0f;
			this.labelExtensibleApp.LabelProp = global::Mono.Addins.AddinManager.CurrentLocalizer.GetString ("Allow the application to be extended by add-ins.");
			this.boxLibraryType.Add (this.labelExtensibleApp);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.boxLibraryType[this.labelExtensibleApp]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child boxLibraryType.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0f;
			this.label2.LabelProp = global::Mono.Addins.AddinManager.CurrentLocalizer.GetString ("Which kind of library you want to create?");
			this.boxLibraryType.Add (this.label2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.boxLibraryType[this.label2]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child boxLibraryType.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment1.Name = "alignment1";
			this.alignment1.LeftPadding = ((uint)(12));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.radiobuttonLibrary = new global::Gtk.RadioButton (global::Mono.Addins.AddinManager.CurrentLocalizer.GetString ("A library which can be extended by add-ins"));
			this.radiobuttonLibrary.CanFocus = true;
			this.radiobuttonLibrary.Name = "radiobuttonLibrary";
			this.radiobuttonLibrary.DrawIndicator = true;
			this.radiobuttonLibrary.UseUnderline = true;
			this.radiobuttonLibrary.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.vbox3.Add (this.radiobuttonLibrary);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.radiobuttonLibrary]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.radiobuttonAddin = new global::Gtk.RadioButton (global::Mono.Addins.AddinManager.CurrentLocalizer.GetString ("An Add-in"));
			this.radiobuttonAddin.CanFocus = true;
			this.radiobuttonAddin.Name = "radiobuttonAddin";
			this.radiobuttonAddin.DrawIndicator = true;
			this.radiobuttonAddin.UseUnderline = true;
			this.radiobuttonAddin.Group = this.radiobuttonLibrary.Group;
			this.vbox3.Add (this.radiobuttonAddin);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.radiobuttonAddin]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.alignment1.Add (this.vbox3);
			this.boxLibraryType.Add (this.alignment1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.boxLibraryType[this.alignment1]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox2.Add (this.boxLibraryType);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.boxLibraryType]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.boxRepo = new global::Gtk.HBox ();
			this.boxRepo.Name = "boxRepo";
			this.boxRepo.Spacing = 6;
			// Container child boxRepo.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0f;
			this.label3.LabelProp = global::Mono.Addins.AddinManager.CurrentLocalizer.GetString ("Extended Application:");
			this.boxRepo.Add (this.label3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.boxRepo[this.label3]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child boxRepo.Gtk.Box+BoxChild
			this.regSelector = new global::MonoDevelop.AddinAuthoring.RegistrySelector ();
			this.regSelector.Events = ((global::Gdk.EventMask)(256));
			this.regSelector.Name = "regSelector";
			this.boxRepo.Add (this.regSelector);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.boxRepo[this.regSelector]));
			w9.Position = 1;
			this.vbox2.Add (this.boxRepo);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.boxRepo]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator = new global::Gtk.HSeparator ();
			this.hseparator.Name = "hseparator";
			this.vbox2.Add (this.hseparator);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelAddinInfo = new global::Gtk.Label ();
			this.labelAddinInfo.Name = "labelAddinInfo";
			this.labelAddinInfo.Xalign = 0f;
			this.labelAddinInfo.LabelProp = global::Mono.Addins.AddinManager.CurrentLocalizer.GetString ("Add-in module information:");
			this.vbox2.Add (this.labelAddinInfo);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.labelAddinInfo]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment3.Name = "alignment3";
			this.alignment3.LeftPadding = ((uint)(24));
			// Container child alignment3.Gtk.Container+ContainerChild
			this.tableNames = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.tableNames.Name = "tableNames";
			this.tableNames.RowSpacing = ((uint)(6));
			this.tableNames.ColumnSpacing = ((uint)(6));
			// Container child tableNames.Gtk.Table+TableChild
			this.comboNs = global::Gtk.ComboBoxEntry.NewText ();
			this.comboNs.Name = "comboNs";
			this.tableNames.Add (this.comboNs);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.tableNames[this.comboNs]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableNames.Gtk.Table+TableChild
			this.entryId = new global::Gtk.Entry ();
			this.entryId.CanFocus = true;
			this.entryId.Name = "entryId";
			this.entryId.IsEditable = true;
			this.entryId.InvisibleChar = '●';
			this.tableNames.Add (this.entryId);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.tableNames[this.entryId]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableNames.Gtk.Table+TableChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.tableNames.Add (this.entryName);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.tableNames[this.entryName]));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableNames.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0f;
			this.label7.LabelProp = global::Mono.Addins.AddinManager.CurrentLocalizer.GetString ("Namespace:");
			this.tableNames.Add (this.label7);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.tableNames[this.label7]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableNames.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0f;
			this.label9.LabelProp = global::Mono.Addins.AddinManager.CurrentLocalizer.GetString ("Identifier:");
			this.tableNames.Add (this.label9);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.tableNames[this.label9]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableNames.Gtk.Table+TableChild
			this.labelName = new global::Gtk.Label ();
			this.labelName.Name = "labelName";
			this.labelName.Xalign = 0f;
			this.labelName.LabelProp = global::Mono.Addins.AddinManager.CurrentLocalizer.GetString ("Display name:");
			this.tableNames.Add (this.labelName);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.tableNames[this.labelName]));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			this.alignment3.Add (this.tableNames);
			this.vbox2.Add (this.alignment3);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment3]));
			w20.Position = 4;
			w20.Expand = false;
			w20.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.labelExtensibleApp.Hide ();
			this.Show ();
			this.radiobuttonLibrary.Toggled += new global::System.EventHandler (this.OnRadiobuttonLibraryToggled);
			this.regSelector.Changed += new global::System.EventHandler (this.OnRegSelectorChanged);
			this.entryName.Changed += new global::System.EventHandler (this.OnEntryNameChanged);
			this.entryId.Changed += new global::System.EventHandler (this.OnEntryIdChanged);
			this.comboNs.Changed += new global::System.EventHandler (this.OnComboNsChanged);
		}
	}
}
