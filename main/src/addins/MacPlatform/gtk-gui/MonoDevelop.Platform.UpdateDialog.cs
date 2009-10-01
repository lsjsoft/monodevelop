// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Platform {
    
    
    internal partial class UpdateDialog {
        
        private Gtk.Alignment alignment1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.Label infoLabel;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.VBox productBox;
        
        private Gtk.CheckButton checkAutomaticallyCheck;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Platform.UpdateDialog
            this.Name = "MonoDevelop.Platform.UpdateDialog";
            this.Title = Mono.Unix.Catalog.GetString("MonoDevelop Updater");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Internal child MonoDevelop.Platform.UpdateDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.alignment1 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment1.Name = "alignment1";
            // Container child alignment1.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            this.vbox2.BorderWidth = ((uint)(6));
            // Container child vbox2.Gtk.Box+BoxChild
            this.infoLabel = new Gtk.Label();
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Xalign = 0F;
            this.infoLabel.LabelProp = Mono.Unix.Catalog.GetString("The following updates are available. After downloading,\nplease close MonoDevelop before installing them.");
            this.infoLabel.Wrap = true;
            this.vbox2.Add(this.infoLabel);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.infoLabel]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            Gtk.Viewport w3 = new Gtk.Viewport();
            w3.ShadowType = ((Gtk.ShadowType)(0));
            // Container child GtkViewport.Gtk.Container+ContainerChild
            this.productBox = new Gtk.VBox();
            this.productBox.Name = "productBox";
            this.productBox.Spacing = 12;
            w3.Add(this.productBox);
            this.scrolledwindow1.Add(w3);
            this.vbox2.Add(this.scrolledwindow1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox2[this.scrolledwindow1]));
            w6.Position = 1;
            // Container child vbox2.Gtk.Box+BoxChild
            this.checkAutomaticallyCheck = new Gtk.CheckButton();
            this.checkAutomaticallyCheck.CanFocus = true;
            this.checkAutomaticallyCheck.Name = "checkAutomaticallyCheck";
            this.checkAutomaticallyCheck.Label = Mono.Unix.Catalog.GetString("Check for updates automatically");
            this.checkAutomaticallyCheck.DrawIndicator = true;
            this.checkAutomaticallyCheck.UseUnderline = true;
            this.vbox2.Add(this.checkAutomaticallyCheck);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox2[this.checkAutomaticallyCheck]));
            w7.Position = 2;
            w7.Expand = false;
            w7.Fill = false;
            this.alignment1.Add(this.vbox2);
            w1.Add(this.alignment1);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(w1[this.alignment1]));
            w9.Position = 0;
            // Internal child MonoDevelop.Platform.UpdateDialog.ActionArea
            Gtk.HButtonBox w10 = this.ActionArea;
            w10.Name = "dialog1_ActionArea";
            w10.Spacing = 10;
            w10.BorderWidth = ((uint)(5));
            w10.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-close";
            this.AddActionWidget(this.buttonOk, -7);
            Gtk.ButtonBox.ButtonBoxChild w11 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonOk]));
            w11.Expand = false;
            w11.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 450;
            this.DefaultHeight = 335;
            this.Show();
        }
    }
}
