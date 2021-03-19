using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmEditAddress : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditAddress));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            ImageList1 = new ImageList(components);
            ImageList2 = new ImageList(components);
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(Button4_Click);
            Panel1 = new Panel();
            TableLayoutPanel1 = new TableLayoutPanel();
            Label6 = new Label();
            address2Label1 = new Label();
            address1TextBox2 = new TextBox();
            locationDescription1TextBox1 = new TextBox();
            _country1ComboBox1 = new ComboBox();
            _country1ComboBox1.SelectedIndexChanged += new EventHandler(country1ComboBox1_SelectedIndexChanged);
            Label3 = new Label();
            Label = new Label();
            Panel2 = new Panel();
            _btnEditRegionCity = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnEditRegionCity.Click += new EventHandler(btnEditRegionCity_Click);
            _btnAddRegionCity = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddRegionCity.Click += new EventHandler(btnAddRegionCity_Click);
            cboCity = new ComboBox();
            Label5 = new Label();
            postal1TextBox1 = new TextBox();
            Label30 = new Label();
            phone1TextBox = new TextBox();
            Label31 = new Label();
            fax1TextBox = new TextBox();
            Label7 = new Label();
            BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            _BunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _BunifuButton1.Click += new EventHandler(BunifuButton1_Click);
            Panel1.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "blueBall.png");
            // 
            // ImageList2
            // 
            ImageList2.ImageStream = (ImageListStreamer)resources.GetObject("ImageList2.ImageStream");
            ImageList2.TransparentColor = Color.Transparent;
            ImageList2.Images.SetKeyName(0, "redBall.png");
            // 
            // cancelButton
            // 
            _cancelButton.AllowToggling = false;
            _cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _cancelButton.AnimationSpeed = 200;
            _cancelButton.AutoGenerateColors = false;
            _cancelButton.BackColor = Color.Transparent;
            _cancelButton.BackColor1 = Color.White;
            _cancelButton.BackgroundImage = (Image)resources.GetObject("cancelButton.BackgroundImage");
            _cancelButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _cancelButton.ButtonText = "×";
            _cancelButton.ButtonTextMarginLeft = 0;
            _cancelButton.ColorContrastOnClick = 45;
            _cancelButton.ColorContrastOnHover = 45;
            _cancelButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _cancelButton.CustomizableEdges = BorderEdges1;
            _cancelButton.DialogResult = DialogResult.None;
            _cancelButton.DisabledBorderColor = Color.Empty;
            _cancelButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _cancelButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _cancelButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _cancelButton.Font = new Font("Adobe Fan Heiti Std B", 15.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _cancelButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _cancelButton.IconLeftCursor = Cursors.Hand;
            _cancelButton.IconMarginLeft = 11;
            _cancelButton.IconPadding = 10;
            _cancelButton.IconRightCursor = Cursors.Hand;
            _cancelButton.IdleBorderColor = Color.White;
            _cancelButton.IdleBorderRadius = 20;
            _cancelButton.IdleBorderThickness = 1;
            _cancelButton.IdleFillColor = Color.White;
            _cancelButton.IdleIconLeftImage = null;
            _cancelButton.IdleIconRightImage = null;
            _cancelButton.IndicateFocus = true;
            _cancelButton.Location = new Point(714, 2);
            _cancelButton.Name = "_cancelButton";
            StateProperties1.BorderColor = Color.DarkGray;
            StateProperties1.BorderRadius = 20;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.DarkGray;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.IndianRed;
            StateProperties2.BorderRadius = 20;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.IndianRed;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties2;
            _cancelButton.Size = new Size(26, 23);
            _cancelButton.TabIndex = 71;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.GhostWhite;
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(TableLayoutPanel1);
            Panel1.Location = new Point(27, 56);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(681, 132);
            Panel1.TabIndex = 37;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.BackColor = Color.White;
            TableLayoutPanel1.ColumnCount = 4;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.90217f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.09783f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 158.0f));
            TableLayoutPanel1.Controls.Add(Label6, 0, 0);
            TableLayoutPanel1.Controls.Add(address2Label1, 0, 3);
            TableLayoutPanel1.Controls.Add(address1TextBox2, 1, 2);
            TableLayoutPanel1.Controls.Add(locationDescription1TextBox1, 1, 3);
            TableLayoutPanel1.Controls.Add(_country1ComboBox1, 1, 0);
            TableLayoutPanel1.Controls.Add(Label3, 0, 1);
            TableLayoutPanel1.Controls.Add(Label, 0, 2);
            TableLayoutPanel1.Controls.Add(Panel2, 1, 1);
            TableLayoutPanel1.Controls.Add(Label5, 2, 0);
            TableLayoutPanel1.Controls.Add(postal1TextBox1, 3, 0);
            TableLayoutPanel1.Controls.Add(Label30, 2, 1);
            TableLayoutPanel1.Controls.Add(phone1TextBox, 3, 1);
            TableLayoutPanel1.Controls.Add(Label31, 2, 2);
            TableLayoutPanel1.Controls.Add(fax1TextBox, 3, 2);
            TableLayoutPanel1.Dock = DockStyle.Fill;
            TableLayoutPanel1.Location = new Point(0, 0);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 4;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.15385f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.07692f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel1.Size = new Size(679, 130);
            TableLayoutPanel1.TabIndex = 5;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.Location = new Point(3, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(68, 20);
            Label6.TabIndex = 14;
            Label6.Text = "Country:";
            Label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // address2Label1
            // 
            address2Label1.AutoSize = true;
            address2Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            address2Label1.Location = new Point(3, 96);
            address2Label1.Name = "address2Label1";
            address2Label1.Size = new Size(93, 20);
            address2Label1.TabIndex = 21;
            address2Label1.Text = "Description:";
            address2Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // address1TextBox2
            // 
            address1TextBox2.Anchor = AnchorStyles.Left;
            address1TextBox2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            address1TextBox2.Location = new Point(113, 69);
            address1TextBox2.Name = "address1TextBox2";
            address1TextBox2.Size = new Size(261, 26);
            address1TextBox2.TabIndex = 3;
            // 
            // locationDescription1TextBox1
            // 
            locationDescription1TextBox1.Anchor = AnchorStyles.Left;
            locationDescription1TextBox1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            locationDescription1TextBox1.Location = new Point(113, 100);
            locationDescription1TextBox1.Name = "locationDescription1TextBox1";
            locationDescription1TextBox1.Size = new Size(224, 26);
            locationDescription1TextBox1.TabIndex = 3;
            // 
            // country1ComboBox1
            // 
            _country1ComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            _country1ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            _country1ComboBox1.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _country1ComboBox1.FormattingEnabled = true;
            _country1ComboBox1.Location = new Point(113, 3);
            _country1ComboBox1.Name = "_country1ComboBox1";
            _country1ComboBox1.Size = new Size(261, 28);
            _country1ComboBox1.TabIndex = 1;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(3, 32);
            Label3.Name = "Label3";
            Label3.Size = new Size(39, 20);
            Label3.TabIndex = 2;
            Label3.Text = "City:";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label.Location = new Point(3, 66);
            Label.Name = "Label";
            Label.Size = new Size(72, 20);
            Label.TabIndex = 0;
            Label.Text = "Address:";
            Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Panel2
            // 
            Panel2.Controls.Add(_btnEditRegionCity);
            Panel2.Controls.Add(_btnAddRegionCity);
            Panel2.Controls.Add(cboCity);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(110, 32);
            Panel2.Margin = new Padding(0);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(300, 34);
            Panel2.TabIndex = 22;
            // 
            // btnEditRegionCity
            // 
            _btnEditRegionCity.AllowToggling = false;
            _btnEditRegionCity.AnimationSpeed = 200;
            _btnEditRegionCity.AutoGenerateColors = false;
            _btnEditRegionCity.BackColor = Color.Transparent;
            _btnEditRegionCity.BackColor1 = Color.White;
            _btnEditRegionCity.BackgroundImage = (Image)resources.GetObject("btnEditRegionCity.BackgroundImage");
            _btnEditRegionCity.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnEditRegionCity.ButtonText = "";
            _btnEditRegionCity.ButtonTextMarginLeft = 0;
            _btnEditRegionCity.ColorContrastOnClick = 45;
            _btnEditRegionCity.ColorContrastOnHover = 45;
            _btnEditRegionCity.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnEditRegionCity.CustomizableEdges = BorderEdges2;
            _btnEditRegionCity.DialogResult = DialogResult.None;
            _btnEditRegionCity.DisabledBorderColor = Color.Empty;
            _btnEditRegionCity.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnEditRegionCity.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnEditRegionCity.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnEditRegionCity.Font = new Font("Segoe UI Semibold", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnEditRegionCity.ForeColor = Color.White;
            _btnEditRegionCity.IconLeftCursor = Cursors.Hand;
            _btnEditRegionCity.IconMarginLeft = 1;
            _btnEditRegionCity.IconPadding = 1;
            _btnEditRegionCity.IconRightCursor = Cursors.Hand;
            _btnEditRegionCity.IdleBorderColor = Color.White;
            _btnEditRegionCity.IdleBorderRadius = 15;
            _btnEditRegionCity.IdleBorderThickness = 1;
            _btnEditRegionCity.IdleFillColor = Color.White;
            _btnEditRegionCity.IdleIconLeftImage = My.Resources.Resources.pencil;
            _btnEditRegionCity.IdleIconRightImage = null;
            _btnEditRegionCity.IndicateFocus = true;
            _btnEditRegionCity.Location = new Point(268, 16);
            _btnEditRegionCity.Name = "_btnEditRegionCity";
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties3.BorderRadius = 15;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _btnEditRegionCity.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.White;
            StateProperties4.BorderRadius = 15;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _btnEditRegionCity.OnPressedState = StateProperties4;
            _btnEditRegionCity.Size = new Size(17, 17);
            _btnEditRegionCity.TabIndex = 80;
            _btnEditRegionCity.TextAlign = ContentAlignment.MiddleCenter;
            _btnEditRegionCity.TextMarginLeft = 0;
            _btnEditRegionCity.UseDefaultRadiusAndThickness = true;
            // 
            // btnAddRegionCity
            // 
            _btnAddRegionCity.AllowToggling = false;
            _btnAddRegionCity.AnimationSpeed = 200;
            _btnAddRegionCity.AutoGenerateColors = false;
            _btnAddRegionCity.BackColor = Color.Transparent;
            _btnAddRegionCity.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddRegionCity.BackgroundImage = (Image)resources.GetObject("btnAddRegionCity.BackgroundImage");
            _btnAddRegionCity.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddRegionCity.ButtonText = "";
            _btnAddRegionCity.ButtonTextMarginLeft = 0;
            _btnAddRegionCity.ColorContrastOnClick = 45;
            _btnAddRegionCity.ColorContrastOnHover = 45;
            _btnAddRegionCity.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _btnAddRegionCity.CustomizableEdges = BorderEdges3;
            _btnAddRegionCity.DialogResult = DialogResult.None;
            _btnAddRegionCity.DisabledBorderColor = Color.Empty;
            _btnAddRegionCity.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddRegionCity.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddRegionCity.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddRegionCity.Font = new Font("Segoe UI Semibold", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddRegionCity.ForeColor = Color.White;
            _btnAddRegionCity.IconLeftCursor = Cursors.Hand;
            _btnAddRegionCity.IconMarginLeft = 5;
            _btnAddRegionCity.IconPadding = 5;
            _btnAddRegionCity.IconRightCursor = Cursors.Hand;
            _btnAddRegionCity.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddRegionCity.IdleBorderRadius = 15;
            _btnAddRegionCity.IdleBorderThickness = 1;
            _btnAddRegionCity.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddRegionCity.IdleIconLeftImage = My.Resources.Resources.addWhite;
            _btnAddRegionCity.IdleIconRightImage = null;
            _btnAddRegionCity.IndicateFocus = true;
            _btnAddRegionCity.Location = new Point(267, 0);
            _btnAddRegionCity.Name = "_btnAddRegionCity";
            StateProperties5.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties5.BorderRadius = 15;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _btnAddRegionCity.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties6.BorderRadius = 15;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _btnAddRegionCity.OnPressedState = StateProperties6;
            _btnAddRegionCity.Size = new Size(17, 17);
            _btnAddRegionCity.TabIndex = 81;
            _btnAddRegionCity.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddRegionCity.TextMarginLeft = 0;
            _btnAddRegionCity.UseDefaultRadiusAndThickness = true;
            // 
            // cboCity
            // 
            cboCity.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCity.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboCity.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboCity.FormattingEnabled = true;
            cboCity.Location = new Point(1, 2);
            cboCity.Name = "cboCity";
            cboCity.Size = new Size(264, 28);
            cboCity.TabIndex = 2;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(413, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(99, 20);
            Label5.TabIndex = 17;
            Label5.Text = "Postal Code:";
            Label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // postal1TextBox1
            // 
            postal1TextBox1.Anchor = AnchorStyles.Left;
            postal1TextBox1.CharacterCasing = CharacterCasing.Upper;
            postal1TextBox1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            postal1TextBox1.Location = new Point(523, 3);
            postal1TextBox1.Name = "postal1TextBox1";
            postal1TextBox1.Size = new Size(146, 26);
            postal1TextBox1.TabIndex = 5;
            // 
            // Label30
            // 
            Label30.AutoSize = true;
            Label30.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label30.Location = new Point(413, 32);
            Label30.Name = "Label30";
            Label30.Size = new Size(59, 20);
            Label30.TabIndex = 0;
            Label30.Text = "Phone:";
            Label30.TextAlign = ContentAlignment.MiddleRight;
            // 
            // phone1TextBox
            // 
            phone1TextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            phone1TextBox.Location = new Point(523, 35);
            phone1TextBox.MaxLength = 20;
            phone1TextBox.Name = "phone1TextBox";
            phone1TextBox.Size = new Size(146, 26);
            phone1TextBox.TabIndex = 6;
            // 
            // Label31
            // 
            Label31.AutoSize = true;
            Label31.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label31.Location = new Point(413, 66);
            Label31.Name = "Label31";
            Label31.Size = new Size(39, 20);
            Label31.TabIndex = 0;
            Label31.Text = "Fax:";
            Label31.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fax1TextBox
            // 
            fax1TextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            fax1TextBox.Location = new Point(523, 69);
            fax1TextBox.MaxLength = 20;
            fax1TextBox.Name = "fax1TextBox";
            fax1TextBox.Size = new Size(145, 26);
            fax1TextBox.TabIndex = 7;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Semibold", 15.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label7.Location = new Point(15, 14);
            Label7.Name = "Label7";
            Label7.Size = new Size(133, 30);
            Label7.TabIndex = 36;
            Label7.Text = "Edit Address";
            // 
            // BunifuElipse1
            // 
            BunifuElipse1.ElipseRadius = 15;
            BunifuElipse1.TargetControl = this;
            // 
            // BunifuButton1
            // 
            _BunifuButton1.AllowToggling = false;
            _BunifuButton1.AnimationSpeed = 200;
            _BunifuButton1.AutoGenerateColors = false;
            _BunifuButton1.BackColor = Color.Transparent;
            _BunifuButton1.BackColor1 = Color.Teal;
            _BunifuButton1.BackgroundImage = (Image)resources.GetObject("BunifuButton1.BackgroundImage");
            _BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _BunifuButton1.ButtonText = "Save";
            _BunifuButton1.ButtonTextMarginLeft = 0;
            _BunifuButton1.ColorContrastOnClick = 45;
            _BunifuButton1.ColorContrastOnHover = 45;
            _BunifuButton1.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _BunifuButton1.CustomizableEdges = BorderEdges4;
            _BunifuButton1.DialogResult = DialogResult.None;
            _BunifuButton1.DisabledBorderColor = Color.Empty;
            _BunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _BunifuButton1.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _BunifuButton1.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _BunifuButton1.ForeColor = Color.White;
            _BunifuButton1.IconLeftCursor = Cursors.Hand;
            _BunifuButton1.IconMarginLeft = 11;
            _BunifuButton1.IconPadding = 10;
            _BunifuButton1.IconRightCursor = Cursors.Hand;
            _BunifuButton1.IdleBorderColor = Color.Teal;
            _BunifuButton1.IdleBorderRadius = 3;
            _BunifuButton1.IdleBorderThickness = 1;
            _BunifuButton1.IdleFillColor = Color.Teal;
            _BunifuButton1.IdleIconLeftImage = null;
            _BunifuButton1.IdleIconRightImage = null;
            _BunifuButton1.IndicateFocus = true;
            _BunifuButton1.Location = new Point(324, 220);
            _BunifuButton1.Name = "_BunifuButton1";
            StateProperties7.BorderColor = Color.MediumTurquoise;
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.MediumTurquoise;
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _BunifuButton1.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Teal;
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.Teal;
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _BunifuButton1.OnPressedState = StateProperties8;
            _BunifuButton1.Size = new Size(90, 31);
            _BunifuButton1.TabIndex = 70;
            _BunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            _BunifuButton1.TextMarginLeft = 0;
            _BunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // FrmEditAddress
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(740, 267);
            Controls.Add(_BunifuButton1);
            Controls.Add(_cancelButton);
            Controls.Add(Label7);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditAddress";
            StartPosition = FormStartPosition.CenterScreen;
            Panel1.ResumeLayout(false);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            Panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        internal ImageList ImageList1;
        internal ImageList ImageList2;
        internal Panel Panel1;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Label address2Label1;
        private ComboBox _country1ComboBox1;

        internal ComboBox country1ComboBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _country1ComboBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_country1ComboBox1 != null)
                {
                    _country1ComboBox1.SelectedIndexChanged -= country1ComboBox1_SelectedIndexChanged;
                }

                _country1ComboBox1 = value;
                if (_country1ComboBox1 != null)
                {
                    _country1ComboBox1.SelectedIndexChanged += country1ComboBox1_SelectedIndexChanged;
                }
            }
        }

        internal Label Label6;
        internal Label Label3;
        internal TextBox postal1TextBox1;
        internal Label Label5;
        internal Label Label;
        internal Label Label30;
        internal TextBox phone1TextBox;
        internal TextBox address1TextBox2;
        internal Label Label31;
        internal TextBox fax1TextBox;
        internal TextBox locationDescription1TextBox1;
        internal Label Label7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _cancelButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton cancelButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cancelButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cancelButton != null)
                {
                    _cancelButton.Click -= Button4_Click;
                }

                _cancelButton = value;
                if (_cancelButton != null)
                {
                    _cancelButton.Click += Button4_Click;
                }
            }
        }

        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        internal ComboBox cboCity;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _BunifuButton1;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuButton1 != null)
                {
                    _BunifuButton1.Click -= BunifuButton1_Click;
                }

                _BunifuButton1 = value;
                if (_BunifuButton1 != null)
                {
                    _BunifuButton1.Click += BunifuButton1_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddRegionCity;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddRegionCity
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddRegionCity;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddRegionCity != null)
                {
                    _btnAddRegionCity.Click -= btnAddRegionCity_Click;
                }

                _btnAddRegionCity = value;
                if (_btnAddRegionCity != null)
                {
                    _btnAddRegionCity.Click += btnAddRegionCity_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnEditRegionCity;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEditRegionCity
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnEditRegionCity;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnEditRegionCity != null)
                {
                    _btnEditRegionCity.Click -= btnEditRegionCity_Click;
                }

                _btnEditRegionCity = value;
                if (_btnEditRegionCity != null)
                {
                    _btnEditRegionCity.Click += btnEditRegionCity_Click;
                }
            }
        }

        internal Panel Panel2;
    }
}