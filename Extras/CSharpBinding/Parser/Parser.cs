// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Andrea Paatz" email="andrea@icsharpcode.net"/>
//     <version value="$version"/>
// </file>
using System;
using System.IO;
using System.Drawing;
using System.Collections;
using MonoDevelop.Core;
using MonoDevelop.Projects.Parser;
using MonoDevelop.Projects;
using CSharpBinding.Parser.SharpDevelopTree;
using ICSharpCode.NRefactory.Parser;

namespace CSharpBinding.Parser
{
	public class TParser : MonoDevelop.Projects.Parser.IParser
	{
		///<summary>IParser Interface</summary> 
		string[] lexerTags;
		public string[] LexerTags {
			get {
				return lexerTags;
			}
			set {
				lexerTags = value;
			}
		}
		
		public IExpressionFinder CreateExpressionFinder(string fileName)
		{
			return new ExpressionFinder(fileName);
		}
		
		public bool CanParse(string fileName)
		{
			return System.IO.Path.GetExtension(fileName).ToUpper() == ".CS";
		}
		
		void RetrieveRegions(CompilationUnit cu, SpecialTracker tracker)
		{
			for (int i = 0; i < tracker.CurrentSpecials.Count; ++i) {
				PreProcessingDirective directive = tracker.CurrentSpecials[i] as PreProcessingDirective;
				if (directive != null) {
					if (directive.Cmd == "#region") {
						int deep = 1; 
						for (int j = i + 1; j < tracker.CurrentSpecials.Count; ++j) {
							PreProcessingDirective nextDirective = tracker.CurrentSpecials[j] as PreProcessingDirective;
							if (nextDirective != null) {
								switch (nextDirective.Cmd) {
									case "#region":
										++deep;
										break;
									case "#endregion":
										--deep;
										if (deep == 0) {
											cu.FoldingRegions.Add(new FoldingRegion(directive.Arg.Trim(), new DefaultRegion(directive.StartPosition, new Point(nextDirective.EndPosition.X - 2, nextDirective.EndPosition.Y))));
											goto end;
										}
										break;
								}
							}
						}
						end: ;
					}
				}
			}
		}
		
		public ICompilationUnitBase Parse(string fileName)
		{
			using (ICSharpCode.NRefactory.Parser.IParser p = ICSharpCode.NRefactory.Parser.ParserFactory.CreateParser (SupportedLanguage.CSharp, new StreamReader(fileName))) {
            	return Parse (p, fileName);
            }
		}
		
		public ICompilationUnitBase Parse(string fileName, string fileContent)
		{
			using (ICSharpCode.NRefactory.Parser.IParser p = ICSharpCode.NRefactory.Parser.ParserFactory.CreateParser (SupportedLanguage.CSharp, new StringReader(fileContent))) {
            	return Parse (p, fileName);
            }
		}
		
		ICompilationUnit Parse (ICSharpCode.NRefactory.Parser.IParser p, string fileName)
		{
        	p.Lexer.SpecialCommentTags = lexerTags;
            p.ParseMethodBodies = false;
            p.Parse ();
            
            CSharpVisitor visitor = new CSharpVisitor();
			visitor.Visit(p.CompilationUnit, null);
			visitor.Cu.ErrorsDuringCompile = p.Errors.count > 0;
			visitor.Cu.Tag = p.CompilationUnit;
			// FIXME: track api changes
			//visitor.Cu.ErrorInformation = p.Errors.ErrorInformation;
			RetrieveRegions (visitor.Cu, p.Lexer.SpecialTracker);
			foreach (IClass c in visitor.Cu.Classes)
				c.Region.FileName = fileName;
			AddCommentTags (visitor.Cu, p.Lexer.TagComments);
            return visitor.Cu;
      	}

      	void AddCommentTags(ICompilationUnit cu, System.Collections.Generic.List<ICSharpCode.NRefactory.Parser.TagComment> tagComments)
      	{
	    	foreach (ICSharpCode.NRefactory.Parser.TagComment tagComment in tagComments) {	  		
    	  		DefaultRegion tagRegion = new DefaultRegion (tagComment.StartPosition.Y, tagComment.StartPosition.X, tagComment.EndPosition.Y, tagComment.EndPosition.X);
                Tag tag = new Tag (tagComment.Tag, tagRegion);
                tag.CommentString = tagComment.CommentText;
                cu.TagComments.Add (tag);
            }
      	}

		
		public LanguageItemCollection CtrlSpace(IParserContext parserContext, int caretLine, int caretColumn, string fileName)
		{
			return new Resolver (parserContext).CtrlSpace (caretLine, caretColumn, fileName);
		}

		public LanguageItemCollection IsAsResolve (IParserContext parserContext, string expression, int caretLineNumber, int caretColumn, string fileName, string fileContent)
		{
			return new Resolver (parserContext).IsAsResolve (expression, caretLineNumber, caretColumn, fileName, fileContent);
		}
		
		public ResolveResult Resolve (IParserContext parserContext, string expression, int caretLineNumber, int caretColumn, string fileName, string fileContent)
		{
			return new Resolver (parserContext).Resolve (expression, caretLineNumber, caretColumn, fileName, fileContent);
		}
	
		public ILanguageItem ResolveIdentifier (IParserContext parserContext, string id, int caretLineNumber, int caretColumn, string fileName, string fileContent)
		{
			return new Resolver (parserContext).ResolveIdentifier (parserContext, id, caretLineNumber, caretColumn, fileName, fileContent);
		}
		
		///////// IParser Interface END
	}
}
