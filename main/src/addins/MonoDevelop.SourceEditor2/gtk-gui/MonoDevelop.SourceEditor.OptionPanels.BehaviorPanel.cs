// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.SourceEditor.OptionPanels {
    
    
    public partial class BehaviorPanel {
        
        private Gtk.VBox vbox1;
        
        private Gtk.Label GtkLabel5;
        
        private Gtk.Alignment alignment3;
        
        private Gtk.VBox vbox4;
        
        private Gtk.CheckButton autoInsertTemplateCheckbutton;
        
        private Gtk.CheckButton autoInsertBraceCheckbutton;
        
        private Gtk.CheckButton removeTrailingWhitespacesCheckbutton;
        
        private Gtk.Label GtkLabel6;
        
        private Gtk.Alignment GtkAlignment;
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label label1;
        
        private Gtk.ComboBox indentationCombobox;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Label label3;
        
        private Gtk.SpinButton indentAndTabSizeSpinbutton;
        
        private Gtk.CheckButton convertTabsToSpacesCheckbutton;
        
        private Gtk.CheckButton tabAsReindentCheckbutton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.SourceEditor.OptionPanels.BehaviorPanel
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.SourceEditor.OptionPanels.BehaviorPanel";
            // Container child MonoDevelop.SourceEditor.OptionPanels.BehaviorPanel.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.GtkLabel5 = new Gtk.Label();
            this.GtkLabel5.Name = "GtkLabel5";
            this.GtkLabel5.Xalign = 0F;
            this.GtkLabel5.LabelProp = Mono.Unix.Catalog.GetString("<b>Automatic behaviors</b>");
            this.GtkLabel5.UseMarkup = true;
            this.vbox1.Add(this.GtkLabel5);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkLabel5]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.alignment3 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment3.Name = "alignment3";
            this.alignment3.LeftPadding = ((uint)(12));
            // Container child alignment3.Gtk.Container+ContainerChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            // Container child vbox4.Gtk.Box+BoxChild
            this.autoInsertTemplateCheckbutton = new Gtk.CheckButton();
            this.autoInsertTemplateCheckbutton.CanFocus = true;
            this.autoInsertTemplateCheckbutton.Name = "autoInsertTemplateCheckbutton";
            this.autoInsertTemplateCheckbutton.Label = Mono.Unix.Catalog.GetString("_Expand templates");
            this.autoInsertTemplateCheckbutton.DrawIndicator = true;
            this.autoInsertTemplateCheckbutton.UseUnderline = true;
            this.vbox4.Add(this.autoInsertTemplateCheckbutton);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox4[this.autoInsertTemplateCheckbutton]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.autoInsertBraceCheckbutton = new Gtk.CheckButton();
            this.autoInsertBraceCheckbutton.CanFocus = true;
            this.autoInsertBraceCheckbutton.Name = "autoInsertBraceCheckbutton";
            this.autoInsertBraceCheckbutton.Label = Mono.Unix.Catalog.GetString("_Insert matching brace");
            this.autoInsertBraceCheckbutton.DrawIndicator = true;
            this.autoInsertBraceCheckbutton.UseUnderline = true;
            this.vbox4.Add(this.autoInsertBraceCheckbutton);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox4[this.autoInsertBraceCheckbutton]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.removeTrailingWhitespacesCheckbutton = new Gtk.CheckButton();
            this.removeTrailingWhitespacesCheckbutton.CanFocus = true;
            this.removeTrailingWhitespacesCheckbutton.Name = "removeTrailingWhitespacesCheckbutton";
            this.removeTrailingWhitespacesCheckbutton.Label = Mono.Unix.Catalog.GetString("_Remove trailing whitespace");
            this.removeTrailingWhitespacesCheckbutton.DrawIndicator = true;
            this.removeTrailingWhitespacesCheckbutton.UseUnderline = true;
            this.vbox4.Add(this.removeTrailingWhitespacesCheckbutton);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox4[this.removeTrailingWhitespacesCheckbutton]));
            w4.Position = 2;
            w4.Expand = false;
            w4.Fill = false;
            this.alignment3.Add(this.vbox4);
            this.vbox1.Add(this.alignment3);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox1[this.alignment3]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.GtkLabel6 = new Gtk.Label();
            this.GtkLabel6.Name = "GtkLabel6";
            this.GtkLabel6.Xalign = 0F;
            this.GtkLabel6.LabelProp = Mono.Unix.Catalog.GetString("<b>Indentation</b>");
            this.GtkLabel6.UseMarkup = true;
            this.vbox1.Add(this.GtkLabel6);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkLabel6]));
            w7.Position = 2;
            w7.Expand = false;
            w7.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.GtkAlignment = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment.Name = "GtkAlignment";
            this.GtkAlignment.LeftPadding = ((uint)(12));
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("_Indentation mode:");
            this.label1.UseUnderline = true;
            this.hbox1.Add(this.label1);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
            w8.Position = 0;
            w8.Expand = false;
            w8.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.indentationCombobox = Gtk.ComboBox.NewText();
            this.indentationCombobox.Name = "indentationCombobox";
            this.hbox1.Add(this.indentationCombobox);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox1[this.indentationCombobox]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("_Tab width:");
            this.label3.UseUnderline = true;
            this.hbox2.Add(this.label3);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox2[this.label3]));
            w11.Position = 0;
            w11.Expand = false;
            w11.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.indentAndTabSizeSpinbutton = new Gtk.SpinButton(0, 100, 1);
            this.indentAndTabSizeSpinbutton.CanFocus = true;
            this.indentAndTabSizeSpinbutton.Name = "indentAndTabSizeSpinbutton";
            this.indentAndTabSizeSpinbutton.Adjustment.PageIncrement = 10;
            this.indentAndTabSizeSpinbutton.ClimbRate = 1;
            this.indentAndTabSizeSpinbutton.Numeric = true;
            this.hbox2.Add(this.indentAndTabSizeSpinbutton);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.hbox2[this.indentAndTabSizeSpinbutton]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            this.vbox2.Add(this.hbox2);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
            w13.Position = 1;
            w13.Expand = false;
            w13.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.convertTabsToSpacesCheckbutton = new Gtk.CheckButton();
            this.convertTabsToSpacesCheckbutton.CanFocus = true;
            this.convertTabsToSpacesCheckbutton.Name = "convertTabsToSpacesCheckbutton";
            this.convertTabsToSpacesCheckbutton.Label = Mono.Unix.Catalog.GetString("_Convert tabs to spaces");
            this.convertTabsToSpacesCheckbutton.DrawIndicator = true;
            this.convertTabsToSpacesCheckbutton.UseUnderline = true;
            this.vbox2.Add(this.convertTabsToSpacesCheckbutton);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox2[this.convertTabsToSpacesCheckbutton]));
            w14.Position = 2;
            w14.Expand = false;
            w14.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.tabAsReindentCheckbutton = new Gtk.CheckButton();
            this.tabAsReindentCheckbutton.CanFocus = true;
            this.tabAsReindentCheckbutton.Name = "tabAsReindentCheckbutton";
            this.tabAsReindentCheckbutton.Label = Mono.Unix.Catalog.GetString("Interpret tab _keystroke as reindent command");
            this.tabAsReindentCheckbutton.DrawIndicator = true;
            this.tabAsReindentCheckbutton.UseUnderline = true;
            this.vbox2.Add(this.tabAsReindentCheckbutton);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox2[this.tabAsReindentCheckbutton]));
            w15.Position = 3;
            w15.Expand = false;
            w15.Fill = false;
            this.GtkAlignment.Add(this.vbox2);
            this.vbox1.Add(this.GtkAlignment);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkAlignment]));
            w17.Position = 3;
            w17.Expand = false;
            w17.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
