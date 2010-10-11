// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.Fixed fixed5;
    
    private Gtk.Table table1;
    
    private Gtk.Button buttonStartHost;
    
    private Gtk.CheckButton checkbuttonFriendlyFire;
    
    private Gtk.CheckButton checkbuttonMedicMode;
    
    private Gtk.ComboBox comboboxGameType;
    
    private Gtk.HBox hbox3;
    
    private Gtk.ComboBoxEntry comboboxentryArduinoPorts;
    
    private Gtk.Image imageTransceiverStatus;
    
    private Gtk.Label label11;
    
    private Gtk.Label label12;
    
    private Gtk.Label label14;
    
    private Gtk.Label labelGameTime;
    
    private Gtk.Label labelGameType;
    
    private Gtk.Label labelMega;
    
    private Gtk.Label labelReloads;
    
    private Gtk.Label labelSheild;
    
    private Gtk.Label labelTags;
    
    private Gtk.Label labelTransceiver;
    
    private Gtk.SpinButton spinbuttonGameTime;
    
    private Gtk.SpinButton spinbuttonMega;
    
    private Gtk.SpinButton spinbuttonNumberOfTeams;
    
    private Gtk.SpinButton spinbuttonReloads;
    
    private Gtk.SpinButton spinbuttonSheild;
    
    private Gtk.SpinButton spinbuttonTags;
    
    private Gtk.Image image337;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("Lazer Tag Host");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.fixed5 = new Gtk.Fixed();
        this.fixed5.Name = "fixed5";
        this.fixed5.HasWindow = false;
        // Container child fixed5.Gtk.Fixed+FixedChild
        this.table1 = new Gtk.Table(((uint)(11)), ((uint)(2)), true);
        this.table1.Name = "table1";
        this.table1.RowSpacing = ((uint)(6));
        this.table1.ColumnSpacing = ((uint)(20));
        // Container child table1.Gtk.Table+TableChild
        this.buttonStartHost = new Gtk.Button();
        this.buttonStartHost.Sensitive = false;
        this.buttonStartHost.CanFocus = true;
        this.buttonStartHost.Name = "buttonStartHost";
        this.buttonStartHost.UseUnderline = true;
        // Container child buttonStartHost.Gtk.Container+ContainerChild
        Gtk.Alignment w1 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
        // Container child GtkAlignment.Gtk.Container+ContainerChild
        Gtk.HBox w2 = new Gtk.HBox();
        w2.Spacing = 2;
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Image w3 = new Gtk.Image();
        w3.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-apply", Gtk.IconSize.Menu, 16);
        w2.Add(w3);
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Label w5 = new Gtk.Label();
        w5.LabelProp = Mono.Unix.Catalog.GetString("_Start");
        w5.UseUnderline = true;
        w2.Add(w5);
        w1.Add(w2);
        this.buttonStartHost.Add(w1);
        this.table1.Add(this.buttonStartHost);
        Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table1[this.buttonStartHost]));
        w9.TopAttach = ((uint)(10));
        w9.BottomAttach = ((uint)(11));
        w9.LeftAttach = ((uint)(1));
        w9.RightAttach = ((uint)(2));
        w9.XOptions = ((Gtk.AttachOptions)(4));
        w9.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.checkbuttonFriendlyFire = new Gtk.CheckButton();
        this.checkbuttonFriendlyFire.CanFocus = true;
        this.checkbuttonFriendlyFire.Name = "checkbuttonFriendlyFire";
        this.checkbuttonFriendlyFire.Label = "";
        this.checkbuttonFriendlyFire.DrawIndicator = true;
        this.checkbuttonFriendlyFire.UseUnderline = true;
        this.table1.Add(this.checkbuttonFriendlyFire);
        Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.table1[this.checkbuttonFriendlyFire]));
        w10.TopAttach = ((uint)(7));
        w10.BottomAttach = ((uint)(8));
        w10.LeftAttach = ((uint)(1));
        w10.RightAttach = ((uint)(2));
        w10.XOptions = ((Gtk.AttachOptions)(4));
        w10.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.checkbuttonMedicMode = new Gtk.CheckButton();
        this.checkbuttonMedicMode.CanFocus = true;
        this.checkbuttonMedicMode.Name = "checkbuttonMedicMode";
        this.checkbuttonMedicMode.Label = "";
        this.checkbuttonMedicMode.DrawIndicator = true;
        this.checkbuttonMedicMode.UseUnderline = true;
        this.table1.Add(this.checkbuttonMedicMode);
        Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.table1[this.checkbuttonMedicMode]));
        w11.TopAttach = ((uint)(8));
        w11.BottomAttach = ((uint)(9));
        w11.LeftAttach = ((uint)(1));
        w11.RightAttach = ((uint)(2));
        w11.XOptions = ((Gtk.AttachOptions)(4));
        w11.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.comboboxGameType = Gtk.ComboBox.NewText();
        this.comboboxGameType.AppendText(Mono.Unix.Catalog.GetString("Custom Laser Tag (Solo)"));
        this.comboboxGameType.AppendText(Mono.Unix.Catalog.GetString("Own The Zone (Solo)"));
        this.comboboxGameType.AppendText(Mono.Unix.Catalog.GetString("2-Team Customized Lazer Tag"));
        this.comboboxGameType.AppendText(Mono.Unix.Catalog.GetString("3-Team Customized Lazer Tag"));
        this.comboboxGameType.AppendText(Mono.Unix.Catalog.GetString("Hide And Seek"));
        this.comboboxGameType.AppendText(Mono.Unix.Catalog.GetString("Hunt The Prey"));
        this.comboboxGameType.AppendText(Mono.Unix.Catalog.GetString("2-Team Kings"));
        this.comboboxGameType.AppendText(Mono.Unix.Catalog.GetString("3-Team Kings"));
        this.comboboxGameType.AppendText(Mono.Unix.Catalog.GetString("2-Team Own The Zone"));
        this.comboboxGameType.AppendText(Mono.Unix.Catalog.GetString("3-Team Own The Zone"));
        this.comboboxGameType.Name = "comboboxGameType";
        this.comboboxGameType.Active = 0;
        this.table1.Add(this.comboboxGameType);
        Gtk.Table.TableChild w12 = ((Gtk.Table.TableChild)(this.table1[this.comboboxGameType]));
        w12.TopAttach = ((uint)(1));
        w12.BottomAttach = ((uint)(2));
        w12.LeftAttach = ((uint)(1));
        w12.RightAttach = ((uint)(2));
        w12.XOptions = ((Gtk.AttachOptions)(4));
        w12.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.hbox3 = new Gtk.HBox();
        this.hbox3.Name = "hbox3";
        this.hbox3.Spacing = 6;
        // Container child hbox3.Gtk.Box+BoxChild
        this.comboboxentryArduinoPorts = Gtk.ComboBoxEntry.NewText();
        this.comboboxentryArduinoPorts.Name = "comboboxentryArduinoPorts";
        this.hbox3.Add(this.comboboxentryArduinoPorts);
        Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox3[this.comboboxentryArduinoPorts]));
        w13.Position = 0;
        w13.Expand = false;
        w13.Fill = false;
        // Container child hbox3.Gtk.Box+BoxChild
        this.imageTransceiverStatus = new Gtk.Image();
        this.imageTransceiverStatus.Name = "imageTransceiverStatus";
        this.imageTransceiverStatus.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-error", Gtk.IconSize.Menu, 16);
        this.hbox3.Add(this.imageTransceiverStatus);
        Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hbox3[this.imageTransceiverStatus]));
        w14.Position = 1;
        w14.Expand = false;
        w14.Fill = false;
        this.table1.Add(this.hbox3);
        Gtk.Table.TableChild w15 = ((Gtk.Table.TableChild)(this.table1[this.hbox3]));
        w15.LeftAttach = ((uint)(1));
        w15.RightAttach = ((uint)(2));
        w15.XOptions = ((Gtk.AttachOptions)(4));
        w15.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.label11 = new Gtk.Label();
        this.label11.Name = "label11";
        this.label11.LabelProp = Mono.Unix.Catalog.GetString("Friendly Fire");
        this.table1.Add(this.label11);
        Gtk.Table.TableChild w16 = ((Gtk.Table.TableChild)(this.table1[this.label11]));
        w16.TopAttach = ((uint)(7));
        w16.BottomAttach = ((uint)(8));
        w16.XOptions = ((Gtk.AttachOptions)(4));
        w16.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.label12 = new Gtk.Label();
        this.label12.Name = "label12";
        this.label12.LabelProp = Mono.Unix.Catalog.GetString("Medic Mode");
        this.table1.Add(this.label12);
        Gtk.Table.TableChild w17 = ((Gtk.Table.TableChild)(this.table1[this.label12]));
        w17.TopAttach = ((uint)(8));
        w17.BottomAttach = ((uint)(9));
        w17.XOptions = ((Gtk.AttachOptions)(4));
        w17.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.label14 = new Gtk.Label();
        this.label14.Name = "label14";
        this.label14.LabelProp = Mono.Unix.Catalog.GetString("Number Of Teams");
        this.table1.Add(this.label14);
        Gtk.Table.TableChild w18 = ((Gtk.Table.TableChild)(this.table1[this.label14]));
        w18.TopAttach = ((uint)(9));
        w18.BottomAttach = ((uint)(10));
        w18.XOptions = ((Gtk.AttachOptions)(4));
        w18.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.labelGameTime = new Gtk.Label();
        this.labelGameTime.Name = "labelGameTime";
        this.labelGameTime.LabelProp = Mono.Unix.Catalog.GetString("Game Time");
        this.table1.Add(this.labelGameTime);
        Gtk.Table.TableChild w19 = ((Gtk.Table.TableChild)(this.table1[this.labelGameTime]));
        w19.TopAttach = ((uint)(2));
        w19.BottomAttach = ((uint)(3));
        w19.XOptions = ((Gtk.AttachOptions)(4));
        w19.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.labelGameType = new Gtk.Label();
        this.labelGameType.Name = "labelGameType";
        this.labelGameType.LabelProp = Mono.Unix.Catalog.GetString("Game Type");
        this.table1.Add(this.labelGameType);
        Gtk.Table.TableChild w20 = ((Gtk.Table.TableChild)(this.table1[this.labelGameType]));
        w20.TopAttach = ((uint)(1));
        w20.BottomAttach = ((uint)(2));
        w20.XOptions = ((Gtk.AttachOptions)(4));
        w20.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.labelMega = new Gtk.Label();
        this.labelMega.Name = "labelMega";
        this.labelMega.LabelProp = Mono.Unix.Catalog.GetString("Mega");
        this.table1.Add(this.labelMega);
        Gtk.Table.TableChild w21 = ((Gtk.Table.TableChild)(this.table1[this.labelMega]));
        w21.TopAttach = ((uint)(6));
        w21.BottomAttach = ((uint)(7));
        w21.XOptions = ((Gtk.AttachOptions)(4));
        w21.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.labelReloads = new Gtk.Label();
        this.labelReloads.Name = "labelReloads";
        this.labelReloads.LabelProp = Mono.Unix.Catalog.GetString("Reloads");
        this.table1.Add(this.labelReloads);
        Gtk.Table.TableChild w22 = ((Gtk.Table.TableChild)(this.table1[this.labelReloads]));
        w22.TopAttach = ((uint)(3));
        w22.BottomAttach = ((uint)(4));
        w22.XOptions = ((Gtk.AttachOptions)(4));
        w22.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.labelSheild = new Gtk.Label();
        this.labelSheild.Name = "labelSheild";
        this.labelSheild.LabelProp = Mono.Unix.Catalog.GetString("Sheild");
        this.table1.Add(this.labelSheild);
        Gtk.Table.TableChild w23 = ((Gtk.Table.TableChild)(this.table1[this.labelSheild]));
        w23.TopAttach = ((uint)(5));
        w23.BottomAttach = ((uint)(6));
        w23.XOptions = ((Gtk.AttachOptions)(4));
        w23.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.labelTags = new Gtk.Label();
        this.labelTags.Name = "labelTags";
        this.labelTags.LabelProp = Mono.Unix.Catalog.GetString("Tags");
        this.table1.Add(this.labelTags);
        Gtk.Table.TableChild w24 = ((Gtk.Table.TableChild)(this.table1[this.labelTags]));
        w24.TopAttach = ((uint)(4));
        w24.BottomAttach = ((uint)(5));
        w24.XOptions = ((Gtk.AttachOptions)(4));
        w24.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.labelTransceiver = new Gtk.Label();
        this.labelTransceiver.Name = "labelTransceiver";
        this.labelTransceiver.LabelProp = Mono.Unix.Catalog.GetString("Transceiver");
        this.table1.Add(this.labelTransceiver);
        Gtk.Table.TableChild w25 = ((Gtk.Table.TableChild)(this.table1[this.labelTransceiver]));
        w25.XOptions = ((Gtk.AttachOptions)(4));
        w25.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.spinbuttonGameTime = new Gtk.SpinButton(0, 99, 1);
        this.spinbuttonGameTime.CanFocus = true;
        this.spinbuttonGameTime.Name = "spinbuttonGameTime";
        this.spinbuttonGameTime.Adjustment.PageIncrement = 10;
        this.spinbuttonGameTime.ClimbRate = 1;
        this.spinbuttonGameTime.Numeric = true;
        this.spinbuttonGameTime.Value = 10;
        this.table1.Add(this.spinbuttonGameTime);
        Gtk.Table.TableChild w26 = ((Gtk.Table.TableChild)(this.table1[this.spinbuttonGameTime]));
        w26.TopAttach = ((uint)(2));
        w26.BottomAttach = ((uint)(3));
        w26.LeftAttach = ((uint)(1));
        w26.RightAttach = ((uint)(2));
        w26.XOptions = ((Gtk.AttachOptions)(4));
        w26.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.spinbuttonMega = new Gtk.SpinButton(0, 100, 1);
        this.spinbuttonMega.CanFocus = true;
        this.spinbuttonMega.Name = "spinbuttonMega";
        this.spinbuttonMega.Adjustment.PageIncrement = 10;
        this.spinbuttonMega.ClimbRate = 1;
        this.spinbuttonMega.Numeric = true;
        this.spinbuttonMega.Value = 10;
        this.table1.Add(this.spinbuttonMega);
        Gtk.Table.TableChild w27 = ((Gtk.Table.TableChild)(this.table1[this.spinbuttonMega]));
        w27.TopAttach = ((uint)(6));
        w27.BottomAttach = ((uint)(7));
        w27.LeftAttach = ((uint)(1));
        w27.RightAttach = ((uint)(2));
        w27.XOptions = ((Gtk.AttachOptions)(4));
        w27.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.spinbuttonNumberOfTeams = new Gtk.SpinButton(1, 3, 1);
        this.spinbuttonNumberOfTeams.Sensitive = false;
        this.spinbuttonNumberOfTeams.CanFocus = true;
        this.spinbuttonNumberOfTeams.Name = "spinbuttonNumberOfTeams";
        this.spinbuttonNumberOfTeams.Adjustment.PageIncrement = 10;
        this.spinbuttonNumberOfTeams.ClimbRate = 1;
        this.spinbuttonNumberOfTeams.Numeric = true;
        this.spinbuttonNumberOfTeams.Value = 1;
        this.table1.Add(this.spinbuttonNumberOfTeams);
        Gtk.Table.TableChild w28 = ((Gtk.Table.TableChild)(this.table1[this.spinbuttonNumberOfTeams]));
        w28.TopAttach = ((uint)(9));
        w28.BottomAttach = ((uint)(10));
        w28.LeftAttach = ((uint)(1));
        w28.RightAttach = ((uint)(2));
        w28.XOptions = ((Gtk.AttachOptions)(4));
        w28.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.spinbuttonReloads = new Gtk.SpinButton(0, 100, 1);
        this.spinbuttonReloads.CanFocus = true;
        this.spinbuttonReloads.Name = "spinbuttonReloads";
        this.spinbuttonReloads.Adjustment.PageIncrement = 10;
        this.spinbuttonReloads.ClimbRate = 1;
        this.spinbuttonReloads.Numeric = true;
        this.spinbuttonReloads.Value = 100;
        this.table1.Add(this.spinbuttonReloads);
        Gtk.Table.TableChild w29 = ((Gtk.Table.TableChild)(this.table1[this.spinbuttonReloads]));
        w29.TopAttach = ((uint)(3));
        w29.BottomAttach = ((uint)(4));
        w29.LeftAttach = ((uint)(1));
        w29.RightAttach = ((uint)(2));
        w29.XOptions = ((Gtk.AttachOptions)(4));
        w29.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.spinbuttonSheild = new Gtk.SpinButton(0, 99, 1);
        this.spinbuttonSheild.CanFocus = true;
        this.spinbuttonSheild.Name = "spinbuttonSheild";
        this.spinbuttonSheild.Adjustment.PageIncrement = 10;
        this.spinbuttonSheild.ClimbRate = 1;
        this.spinbuttonSheild.Numeric = true;
        this.spinbuttonSheild.Value = 30;
        this.table1.Add(this.spinbuttonSheild);
        Gtk.Table.TableChild w30 = ((Gtk.Table.TableChild)(this.table1[this.spinbuttonSheild]));
        w30.TopAttach = ((uint)(5));
        w30.BottomAttach = ((uint)(6));
        w30.LeftAttach = ((uint)(1));
        w30.RightAttach = ((uint)(2));
        w30.XOptions = ((Gtk.AttachOptions)(4));
        w30.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table1.Gtk.Table+TableChild
        this.spinbuttonTags = new Gtk.SpinButton(0, 99, 1);
        this.spinbuttonTags.CanFocus = true;
        this.spinbuttonTags.Name = "spinbuttonTags";
        this.spinbuttonTags.Adjustment.PageIncrement = 10;
        this.spinbuttonTags.ClimbRate = 1;
        this.spinbuttonTags.Numeric = true;
        this.spinbuttonTags.Value = 10;
        this.table1.Add(this.spinbuttonTags);
        Gtk.Table.TableChild w31 = ((Gtk.Table.TableChild)(this.table1[this.spinbuttonTags]));
        w31.TopAttach = ((uint)(4));
        w31.BottomAttach = ((uint)(5));
        w31.LeftAttach = ((uint)(1));
        w31.RightAttach = ((uint)(2));
        w31.XOptions = ((Gtk.AttachOptions)(4));
        w31.YOptions = ((Gtk.AttachOptions)(4));
        this.fixed5.Add(this.table1);
        Gtk.Fixed.FixedChild w32 = ((Gtk.Fixed.FixedChild)(this.fixed5[this.table1]));
        w32.X = 6;
        w32.Y = 84;
        // Container child fixed5.Gtk.Fixed+FixedChild
        this.image337 = new Gtk.Image();
        this.image337.Name = "image337";
        this.image337.Pixbuf = Gdk.Pixbuf.LoadFromResource("LazerTagHostUI.Title.png");
        this.fixed5.Add(this.image337);
        Gtk.Fixed.FixedChild w33 = ((Gtk.Fixed.FixedChild)(this.fixed5[this.image337]));
        w33.X = 12;
        w33.Y = 7;
        this.Add(this.fixed5);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 506;
        this.DefaultHeight = 516;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.comboboxentryArduinoPorts.Changed += new System.EventHandler(this.TransceiverChanged);
        this.comboboxentryArduinoPorts.EditingDone += new System.EventHandler(this.TransceiverChanged);
        this.comboboxGameType.Changed += new System.EventHandler(this.GameTypeChanged);
        this.buttonStartHost.Clicked += new System.EventHandler(this.StartGameType);
    }
}