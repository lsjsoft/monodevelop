// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide {
    
    
    public partial class OverridesImplementsDialog {
        
        private Gtk.VBox vbox2;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TreeView treeview;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Button buttonSelectAll;
        
        private Gtk.Button buttonUnselectAll;
        
        private Gtk.HSeparator hseparator1;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.OverridesImplementsDialog
            this.Name = "MonoDevelop.Ide.OverridesImplementsDialog";
            this.Title = "";
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            this.HasSeparator = false;
            // Internal child MonoDevelop.Ide.OverridesImplementsDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.treeview = new Gtk.TreeView();
            this.treeview.CanFocus = true;
            this.treeview.Name = "treeview";
            this.treeview.HeadersClickable = true;
            this.GtkScrolledWindow.Add(this.treeview);
            this.vbox2.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
            w3.Position = 0;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonSelectAll = new Gtk.Button();
            this.buttonSelectAll.CanFocus = true;
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.UseUnderline = true;
            this.buttonSelectAll.Label = Mono.Unix.Catalog.GetString("Select All");
            this.hbox1.Add(this.buttonSelectAll);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonSelectAll]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonUnselectAll = new Gtk.Button();
            this.buttonUnselectAll.CanFocus = true;
            this.buttonUnselectAll.Name = "buttonUnselectAll";
            this.buttonUnselectAll.UseUnderline = true;
            this.buttonUnselectAll.Label = Mono.Unix.Catalog.GetString("Unselect All");
            this.hbox1.Add(this.buttonUnselectAll);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonUnselectAll]));
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hseparator1 = new Gtk.HSeparator();
            this.hseparator1.Name = "hseparator1";
            this.vbox2.Add(this.hseparator1);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox2[this.hseparator1]));
            w7.Position = 3;
            w7.Expand = false;
            w7.Fill = false;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w8.Position = 0;
            // Internal child MonoDevelop.Ide.OverridesImplementsDialog.ActionArea
            Gtk.HButtonBox w9 = this.ActionArea;
            w9.Name = "dialog1_ActionArea";
            w9.Spacing = 6;
            w9.BorderWidth = ((uint)(5));
            w9.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w10 = ((Gtk.ButtonBox.ButtonBoxChild)(w9[this.buttonCancel]));
            w10.Expand = false;
            w10.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w11 = ((Gtk.ButtonBox.ButtonBoxChild)(w9[this.buttonOk]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 595;
            this.DefaultHeight = 469;
            this.Show();
        }
    }
}
