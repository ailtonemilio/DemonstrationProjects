using System;
using System.Diagnostics;
using System.Drawing; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAddEditOutGate : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditOutGate));
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var ToggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState4 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState5 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState6 = new Bunifu.ToggleSwitch.ToggleState();
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties17 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties18 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties19 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties20 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties21 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties22 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties23 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties24 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties25 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties26 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties27 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties28 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            bookingNumberBunifuTextBox = new BunifuTextBox();
            dateDateTimePicker = new DateTimePicker();
            timeDateTimePicker = new DateTimePicker();
            Label5 = new Label();
            Label11 = new Label();
            Label12 = new Label();
            Label16 = new Label();
            fromComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            Label6 = new Label();
            releaseTableLayoutPanel = new TableLayoutPanel();
            Label27 = new Label();
            sealNumberBunifuTextBox2 = new BunifuTextBox();
            toBunifuDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            Panel1 = new Panel();
            Panel2 = new Panel();
            ediPanel = new Panel();
            Label20 = new Label();
            sendEDILabel = new Label();
            _sendEDIBunifuToggleSwitch = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            _sendEDIBunifuToggleSwitch.OnValuechange += new EventHandler(sendEDIBunifuToggleSwitch_OnValuechange);
            holdBunifuToggleSwitch1 = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            Label22 = new Label();
            _saveBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _saveBunifuButton.Click += new EventHandler(saveBunifuButton_Click);
            _noBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _noBunifuButton.Click += new EventHandler(noBunifuButton_Click);
            TableLayoutPanel8 = new TableLayoutPanel();
            carrierBunifuDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            Label18 = new Label();
            TableLayoutPanel9 = new TableLayoutPanel();
            truckNumberBunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            Label19 = new Label();
            TableLayoutPanel7 = new TableLayoutPanel();
            Label17 = new Label();
            commentsRichTextBox = new RichTextBox();
            TableLayoutPanel5 = new TableLayoutPanel();
            TableLayoutPanel3 = new TableLayoutPanel();
            TableLayoutPanel2 = new TableLayoutPanel();
            sizeBunifuDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            Label3 = new Label();
            TableLayoutPanel4 = new TableLayoutPanel();
            Label21 = new Label();
            statusBunifuDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            damagesDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            TableLayoutPanel1 = new TableLayoutPanel();
            containerBunifuTextBox = new BunifuTextBox();
            availablePictureBox = new PictureBox();
            shippingLineBunifuDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            Label14 = new Label();
            Label15 = new Label();
            Label4 = new Label();
            TableLayoutPanel11 = new TableLayoutPanel();
            TableLayoutPanel6 = new TableLayoutPanel();
            Label2 = new Label();
            Label1 = new Label();
            Label8 = new Label();
            Label7 = new Label();
            maxWeightBunifuTextBox = new BunifuTextBox();
            tareWeightBunifuTextBox = new BunifuTextBox();
            Label10 = new Label();
            cargoBunifuTextBox1 = new BunifuTextBox();
            Label9 = new Label();
            titleLabel = new CustomizedControlsLibrary.ShapedLabel();
            releaseTableLayoutPanel.SuspendLayout();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            ediPanel.SuspendLayout();
            TableLayoutPanel8.SuspendLayout();
            TableLayoutPanel9.SuspendLayout();
            TableLayoutPanel7.SuspendLayout();
            TableLayoutPanel5.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            TableLayoutPanel4.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)availablePictureBox).BeginInit();
            TableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // bookingNumberBunifuTextBox
            // 
            bookingNumberBunifuTextBox.AcceptsReturn = false;
            bookingNumberBunifuTextBox.AcceptsTab = false;
            bookingNumberBunifuTextBox.AnimationSpeed = 200;
            bookingNumberBunifuTextBox.AutoCompleteMode = AutoCompleteMode.None;
            bookingNumberBunifuTextBox.AutoCompleteSource = AutoCompleteSource.None;
            bookingNumberBunifuTextBox.BackColor = Color.Transparent;
            bookingNumberBunifuTextBox.BackgroundImage = (Image)resources.GetObject("bookingNumberBunifuTextBox.BackgroundImage");
            bookingNumberBunifuTextBox.BorderColorActive = Color.LightSeaGreen;
            bookingNumberBunifuTextBox.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            bookingNumberBunifuTextBox.BorderColorHover = Color.LightSeaGreen;
            bookingNumberBunifuTextBox.BorderColorIdle = Color.Gray;
            bookingNumberBunifuTextBox.BorderRadius = 1;
            bookingNumberBunifuTextBox.BorderThickness = 1;
            bookingNumberBunifuTextBox.CharacterCasing = CharacterCasing.Upper;
            bookingNumberBunifuTextBox.Cursor = Cursors.IBeam;
            bookingNumberBunifuTextBox.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            bookingNumberBunifuTextBox.DefaultText = "";
            bookingNumberBunifuTextBox.FillColor = Color.White;
            bookingNumberBunifuTextBox.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            bookingNumberBunifuTextBox.HideSelection = true;
            bookingNumberBunifuTextBox.IconLeft = null;
            bookingNumberBunifuTextBox.IconLeftCursor = Cursors.IBeam;
            bookingNumberBunifuTextBox.IconPadding = 10;
            bookingNumberBunifuTextBox.IconRight = null;
            bookingNumberBunifuTextBox.IconRightCursor = Cursors.IBeam;
            bookingNumberBunifuTextBox.Lines = new string[0];
            bookingNumberBunifuTextBox.Location = new Point(166, 3);
            bookingNumberBunifuTextBox.MaxLength = 32767;
            bookingNumberBunifuTextBox.MinimumSize = new Size(100, 35);
            bookingNumberBunifuTextBox.Modified = false;
            bookingNumberBunifuTextBox.Multiline = false;
            bookingNumberBunifuTextBox.Name = "bookingNumberBunifuTextBox";
            StateProperties1.BorderColor = Color.LightSeaGreen;
            StateProperties1.FillColor = Color.Empty;
            StateProperties1.ForeColor = Color.Empty;
            StateProperties1.PlaceholderForeColor = Color.Empty;
            bookingNumberBunifuTextBox.OnActiveState = StateProperties1;
            StateProperties2.BorderColor = Color.Empty;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.Empty;
            StateProperties2.PlaceholderForeColor = Color.Silver;
            bookingNumberBunifuTextBox.OnDisabledState = StateProperties2;
            StateProperties3.BorderColor = Color.LightSeaGreen;
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            bookingNumberBunifuTextBox.OnHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Gray;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.PlaceholderForeColor = Color.Empty;
            bookingNumberBunifuTextBox.OnIdleState = StateProperties4;
            bookingNumberBunifuTextBox.PasswordChar = '\0';
            bookingNumberBunifuTextBox.PlaceholderForeColor = Color.Silver;
            bookingNumberBunifuTextBox.PlaceholderText = "";
            bookingNumberBunifuTextBox.ReadOnly = false;
            bookingNumberBunifuTextBox.ScrollBars = ScrollBars.None;
            bookingNumberBunifuTextBox.SelectedText = "";
            bookingNumberBunifuTextBox.SelectionLength = 0;
            bookingNumberBunifuTextBox.SelectionStart = 0;
            bookingNumberBunifuTextBox.ShortcutsEnabled = true;
            bookingNumberBunifuTextBox.Size = new Size(218, 35);
            bookingNumberBunifuTextBox.Style = _Style.Bunifu;
            bookingNumberBunifuTextBox.TabIndex = 12;
            bookingNumberBunifuTextBox.TextAlign = HorizontalAlignment.Left;
            bookingNumberBunifuTextBox.TextMarginBottom = 0;
            bookingNumberBunifuTextBox.TextMarginLeft = 5;
            bookingNumberBunifuTextBox.TextMarginTop = 0;
            bookingNumberBunifuTextBox.TextPlaceholder = "";
            bookingNumberBunifuTextBox.UseSystemPasswordChar = false;
            bookingNumberBunifuTextBox.WordWrap = true;
            // 
            // dateDateTimePicker
            // 
            dateDateTimePicker.CalendarFont = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            dateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            dateDateTimePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            dateDateTimePicker.Format = DateTimePickerFormat.Custom;
            dateDateTimePicker.Location = new Point(836, 3);
            dateDateTimePicker.MinimumSize = new Size(110, 35);
            dateDateTimePicker.Name = "dateDateTimePicker";
            dateDateTimePicker.Size = new Size(153, 35);
            dateDateTimePicker.TabIndex = 72;
            // 
            // timeDateTimePicker
            // 
            timeDateTimePicker.CalendarFont = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            timeDateTimePicker.CustomFormat = "HH:mm";
            timeDateTimePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            timeDateTimePicker.Format = DateTimePickerFormat.Custom;
            timeDateTimePicker.Location = new Point(836, 43);
            timeDateTimePicker.MinimumSize = new Size(110, 35);
            timeDateTimePicker.Name = "timeDateTimePicker";
            timeDateTimePicker.ShowUpDown = true;
            timeDateTimePicker.Size = new Size(110, 35);
            timeDateTimePicker.TabIndex = 71;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Dock = DockStyle.Fill;
            Label5.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(673, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(157, 40);
            Label5.TabIndex = 6;
            Label5.Text = "Out Gate Date:";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Dock = DockStyle.Fill;
            Label11.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.Location = new Point(673, 40);
            Label11.Name = "Label11";
            Label11.Size = new Size(157, 44);
            Label11.TabIndex = 7;
            Label11.Text = "Out Gate Time:";
            Label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Dock = DockStyle.Fill;
            Label12.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.Location = new Point(3, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(153, 40);
            Label12.TabIndex = 4;
            Label12.Text = "From Yard:";
            Label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Dock = DockStyle.Fill;
            Label16.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.Location = new Point(3, 40);
            Label16.Name = "Label16";
            Label16.Size = new Size(153, 44);
            Label16.TabIndex = 5;
            Label16.Text = "To Terminal:";
            Label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fromComboBox
            // 
            fromComboBox.BackColor = Color.White;
            fromComboBox.BorderRadius = 3;
            fromComboBox.Color = Color.Teal;
            fromComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            fromComboBox.DisabledColor = Color.Gray;
            fromComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            fromComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            fromComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fromComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            fromComboBox.FillDropDown = false;
            fromComboBox.FillIndicator = true;
            fromComboBox.FlatStyle = FlatStyle.Flat;
            fromComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            fromComboBox.ForeColor = SystemColors.ControlDarkDark;
            fromComboBox.FormattingEnabled = true;
            fromComboBox.Icon = null;
            fromComboBox.IndicatorColor = Color.Teal;
            fromComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            fromComboBox.ItemBackColor = Color.White;
            fromComboBox.ItemBorderColor = Color.White;
            fromComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            fromComboBox.ItemHeight = 28;
            fromComboBox.ItemHighLightColor = Color.Gray;
            fromComboBox.Location = new Point(162, 3);
            fromComboBox.MaxDropDownItems = 50;
            fromComboBox.Name = "fromComboBox";
            fromComboBox.Size = new Size(465, 34);
            fromComboBox.TabIndex = 105;
            fromComboBox.Text = null;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Dock = DockStyle.Fill;
            Label6.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.Location = new Point(3, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(157, 39);
            Label6.TabIndex = 8;
            Label6.Text = "Booking Number:";
            Label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // releaseTableLayoutPanel
            // 
            releaseTableLayoutPanel.ColumnCount = 4;
            releaseTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.09246f));
            releaseTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.90754f));
            releaseTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175.0f));
            releaseTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 265.0f));
            releaseTableLayoutPanel.Controls.Add(Label6, 0, 0);
            releaseTableLayoutPanel.Controls.Add(bookingNumberBunifuTextBox, 1, 0);
            releaseTableLayoutPanel.Controls.Add(Label27, 2, 0);
            releaseTableLayoutPanel.Controls.Add(sealNumberBunifuTextBox2, 3, 0);
            releaseTableLayoutPanel.Location = new Point(1, 1);
            releaseTableLayoutPanel.Margin = new Padding(0);
            releaseTableLayoutPanel.Name = "releaseTableLayoutPanel";
            releaseTableLayoutPanel.RowCount = 1;
            releaseTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            releaseTableLayoutPanel.Size = new Size(828, 39);
            releaseTableLayoutPanel.TabIndex = 10;
            // 
            // Label27
            // 
            Label27.AutoSize = true;
            Label27.Dock = DockStyle.Fill;
            Label27.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label27.Location = new Point(390, 0);
            Label27.Name = "Label27";
            Label27.Size = new Size(169, 39);
            Label27.TabIndex = 110;
            Label27.Text = "Seal Number:";
            Label27.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sealNumberBunifuTextBox2
            // 
            sealNumberBunifuTextBox2.AcceptsReturn = false;
            sealNumberBunifuTextBox2.AcceptsTab = false;
            sealNumberBunifuTextBox2.AnimationSpeed = 200;
            sealNumberBunifuTextBox2.AutoCompleteMode = AutoCompleteMode.None;
            sealNumberBunifuTextBox2.AutoCompleteSource = AutoCompleteSource.None;
            sealNumberBunifuTextBox2.BackColor = Color.Transparent;
            sealNumberBunifuTextBox2.BackgroundImage = (Image)resources.GetObject("sealNumberBunifuTextBox2.BackgroundImage");
            sealNumberBunifuTextBox2.BorderColorActive = Color.LightSeaGreen;
            sealNumberBunifuTextBox2.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            sealNumberBunifuTextBox2.BorderColorHover = Color.LightSeaGreen;
            sealNumberBunifuTextBox2.BorderColorIdle = Color.Gray;
            sealNumberBunifuTextBox2.BorderRadius = 1;
            sealNumberBunifuTextBox2.BorderThickness = 1;
            sealNumberBunifuTextBox2.CharacterCasing = CharacterCasing.Upper;
            sealNumberBunifuTextBox2.Cursor = Cursors.IBeam;
            sealNumberBunifuTextBox2.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            sealNumberBunifuTextBox2.DefaultText = "";
            sealNumberBunifuTextBox2.FillColor = Color.White;
            sealNumberBunifuTextBox2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            sealNumberBunifuTextBox2.HideSelection = true;
            sealNumberBunifuTextBox2.IconLeft = null;
            sealNumberBunifuTextBox2.IconLeftCursor = Cursors.IBeam;
            sealNumberBunifuTextBox2.IconPadding = 10;
            sealNumberBunifuTextBox2.IconRight = null;
            sealNumberBunifuTextBox2.IconRightCursor = Cursors.IBeam;
            sealNumberBunifuTextBox2.Lines = new string[0];
            sealNumberBunifuTextBox2.Location = new Point(565, 3);
            sealNumberBunifuTextBox2.MaxLength = 32767;
            sealNumberBunifuTextBox2.MinimumSize = new Size(100, 35);
            sealNumberBunifuTextBox2.Modified = false;
            sealNumberBunifuTextBox2.Multiline = false;
            sealNumberBunifuTextBox2.Name = "sealNumberBunifuTextBox2";
            StateProperties5.BorderColor = Color.LightSeaGreen;
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            sealNumberBunifuTextBox2.OnActiveState = StateProperties5;
            StateProperties6.BorderColor = Color.Empty;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Silver;
            sealNumberBunifuTextBox2.OnDisabledState = StateProperties6;
            StateProperties7.BorderColor = Color.LightSeaGreen;
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            sealNumberBunifuTextBox2.OnHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Gray;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties8.PlaceholderForeColor = Color.Empty;
            sealNumberBunifuTextBox2.OnIdleState = StateProperties8;
            sealNumberBunifuTextBox2.PasswordChar = '\0';
            sealNumberBunifuTextBox2.PlaceholderForeColor = Color.Silver;
            sealNumberBunifuTextBox2.PlaceholderText = "";
            sealNumberBunifuTextBox2.ReadOnly = false;
            sealNumberBunifuTextBox2.ScrollBars = ScrollBars.None;
            sealNumberBunifuTextBox2.SelectedText = "";
            sealNumberBunifuTextBox2.SelectionLength = 0;
            sealNumberBunifuTextBox2.SelectionStart = 0;
            sealNumberBunifuTextBox2.ShortcutsEnabled = true;
            sealNumberBunifuTextBox2.Size = new Size(224, 35);
            sealNumberBunifuTextBox2.Style = _Style.Bunifu;
            sealNumberBunifuTextBox2.TabIndex = 111;
            sealNumberBunifuTextBox2.TextAlign = HorizontalAlignment.Left;
            sealNumberBunifuTextBox2.TextMarginBottom = 0;
            sealNumberBunifuTextBox2.TextMarginLeft = 5;
            sealNumberBunifuTextBox2.TextMarginTop = 0;
            sealNumberBunifuTextBox2.TextPlaceholder = "";
            sealNumberBunifuTextBox2.UseSystemPasswordChar = false;
            sealNumberBunifuTextBox2.WordWrap = true;
            // 
            // toBunifuDropdown
            // 
            toBunifuDropdown.BackColor = Color.White;
            toBunifuDropdown.BorderRadius = 3;
            toBunifuDropdown.Color = Color.Teal;
            toBunifuDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            toBunifuDropdown.DisabledColor = Color.Gray;
            toBunifuDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            toBunifuDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            toBunifuDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            toBunifuDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            toBunifuDropdown.FillDropDown = false;
            toBunifuDropdown.FillIndicator = true;
            toBunifuDropdown.FlatStyle = FlatStyle.Flat;
            toBunifuDropdown.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            toBunifuDropdown.ForeColor = SystemColors.ControlDarkDark;
            toBunifuDropdown.FormattingEnabled = true;
            toBunifuDropdown.Icon = null;
            toBunifuDropdown.IndicatorColor = Color.Teal;
            toBunifuDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            toBunifuDropdown.ItemBackColor = Color.White;
            toBunifuDropdown.ItemBorderColor = Color.White;
            toBunifuDropdown.ItemForeColor = SystemColors.ControlDarkDark;
            toBunifuDropdown.ItemHeight = 28;
            toBunifuDropdown.ItemHighLightColor = Color.Gray;
            toBunifuDropdown.Location = new Point(162, 43);
            toBunifuDropdown.MaxDropDownItems = 50;
            toBunifuDropdown.Name = "toBunifuDropdown";
            toBunifuDropdown.Size = new Size(465, 34);
            toBunifuDropdown.TabIndex = 106;
            toBunifuDropdown.Text = null;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(Panel2);
            Panel1.Controls.Add(_saveBunifuButton);
            Panel1.Controls.Add(_noBunifuButton);
            Panel1.Controls.Add(TableLayoutPanel8);
            Panel1.Controls.Add(TableLayoutPanel7);
            Panel1.Controls.Add(TableLayoutPanel5);
            Panel1.Controls.Add(TableLayoutPanel3);
            Panel1.Controls.Add(TableLayoutPanel2);
            Panel1.Dock = DockStyle.Bottom;
            Panel1.Location = new Point(0, 63);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1294, 734);
            Panel1.TabIndex = 82;
            // 
            // Panel2
            // 
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(ediPanel);
            Panel2.Controls.Add(holdBunifuToggleSwitch1);
            Panel2.Controls.Add(Label22);
            Panel2.Location = new Point(940, 24);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(311, 100);
            Panel2.TabIndex = 78;
            // 
            // ediPanel
            // 
            ediPanel.Controls.Add(Label20);
            ediPanel.Controls.Add(sendEDILabel);
            ediPanel.Controls.Add(_sendEDIBunifuToggleSwitch);
            ediPanel.Location = new Point(66, 3);
            ediPanel.Name = "ediPanel";
            ediPanel.Size = new Size(244, 47);
            ediPanel.TabIndex = 79;
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label20.Location = new Point(3, 0);
            Label20.Name = "Label20";
            Label20.Size = new Size(75, 21);
            Label20.TabIndex = 73;
            Label20.Text = "Send EDI:";
            Label20.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sendEDILabel
            // 
            sendEDILabel.AutoSize = true;
            sendEDILabel.Font = new Font("Segoe UI Semibold", 7.854546f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            sendEDILabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            sendEDILabel.Location = new Point(96, 26);
            sendEDILabel.Name = "sendEDILabel";
            sendEDILabel.Size = new Size(117, 13);
            sendEDILabel.TabIndex = 74;
            sendEDILabel.Text = "(EDI will NOT be sent)";
            // 
            // sendEDIBunifuToggleSwitch
            // 
            _sendEDIBunifuToggleSwitch.Animation = 5;
            _sendEDIBunifuToggleSwitch.BackColor = Color.Transparent;
            _sendEDIBunifuToggleSwitch.BackgroundImage = (Image)resources.GetObject("sendEDIBunifuToggleSwitch.BackgroundImage");
            _sendEDIBunifuToggleSwitch.Cursor = Cursors.Hand;
            _sendEDIBunifuToggleSwitch.Location = new Point(94, 3);
            _sendEDIBunifuToggleSwitch.Name = "_sendEDIBunifuToggleSwitch";
            _sendEDIBunifuToggleSwitch.Size = new Size(35, 20);
            _sendEDIBunifuToggleSwitch.TabIndex = 72;
            ToggleState1.BackColor = Color.Empty;
            ToggleState1.BackColorInner = Color.Empty;
            ToggleState1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(236)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(140)));
            ToggleState1.BorderColorInner = Color.Empty;
            ToggleState1.BorderRadius = 1;
            ToggleState1.BorderRadiusInner = 1;
            ToggleState1.BorderThickness = 1;
            ToggleState1.BorderThicknessInner = 1;
            _sendEDIBunifuToggleSwitch.ToggleStateDisabled = ToggleState1;
            ToggleState2.BackColor = Color.DarkGray;
            ToggleState2.BackColorInner = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            ToggleState2.BorderColor = Color.DarkGray;
            ToggleState2.BorderColorInner = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            ToggleState2.BorderRadius = 17;
            ToggleState2.BorderRadiusInner = 15;
            ToggleState2.BorderThickness = 1;
            ToggleState2.BorderThicknessInner = 1;
            _sendEDIBunifuToggleSwitch.ToggleStateOff = ToggleState2;
            ToggleState3.BackColor = Color.Teal;
            ToggleState3.BackColorInner = Color.White;
            ToggleState3.BorderColor = Color.Teal;
            ToggleState3.BorderColorInner = Color.White;
            ToggleState3.BorderRadius = 17;
            ToggleState3.BorderRadiusInner = 15;
            ToggleState3.BorderThickness = 1;
            ToggleState3.BorderThicknessInner = 1;
            _sendEDIBunifuToggleSwitch.ToggleStateOn = ToggleState3;
            _sendEDIBunifuToggleSwitch.Value = false;
            // 
            // holdBunifuToggleSwitch1
            // 
            holdBunifuToggleSwitch1.Animation = 5;
            holdBunifuToggleSwitch1.BackColor = Color.Transparent;
            holdBunifuToggleSwitch1.BackgroundImage = (Image)resources.GetObject("holdBunifuToggleSwitch1.BackgroundImage");
            holdBunifuToggleSwitch1.Cursor = Cursors.Hand;
            holdBunifuToggleSwitch1.Location = new Point(160, 56);
            holdBunifuToggleSwitch1.Name = "holdBunifuToggleSwitch1";
            holdBunifuToggleSwitch1.Size = new Size(35, 20);
            holdBunifuToggleSwitch1.TabIndex = 76;
            ToggleState4.BackColor = Color.Empty;
            ToggleState4.BackColorInner = Color.Empty;
            ToggleState4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(236)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(140)));
            ToggleState4.BorderColorInner = Color.Empty;
            ToggleState4.BorderRadius = 1;
            ToggleState4.BorderRadiusInner = 1;
            ToggleState4.BorderThickness = 1;
            ToggleState4.BorderThicknessInner = 1;
            holdBunifuToggleSwitch1.ToggleStateDisabled = ToggleState4;
            ToggleState5.BackColor = Color.DarkGray;
            ToggleState5.BackColorInner = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            ToggleState5.BorderColor = Color.DarkGray;
            ToggleState5.BorderColorInner = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            ToggleState5.BorderRadius = 17;
            ToggleState5.BorderRadiusInner = 15;
            ToggleState5.BorderThickness = 1;
            ToggleState5.BorderThicknessInner = 1;
            holdBunifuToggleSwitch1.ToggleStateOff = ToggleState5;
            ToggleState6.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState6.BackColorInner = Color.White;
            ToggleState6.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState6.BorderColorInner = Color.White;
            ToggleState6.BorderRadius = 17;
            ToggleState6.BorderRadiusInner = 15;
            ToggleState6.BorderThickness = 1;
            ToggleState6.BorderThicknessInner = 1;
            holdBunifuToggleSwitch1.ToggleStateOn = ToggleState6;
            holdBunifuToggleSwitch1.Value = false;
            // 
            // Label22
            // 
            Label22.AutoSize = true;
            Label22.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label22.Location = new Point(7, 51);
            Label22.Name = "Label22";
            Label22.Size = new Size(109, 21);
            Label22.TabIndex = 75;
            Label22.Text = "Hold Out Gate";
            Label22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // saveBunifuButton
            // 
            _saveBunifuButton.AllowToggling = false;
            _saveBunifuButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _saveBunifuButton.AnimationSpeed = 200;
            _saveBunifuButton.AutoGenerateColors = false;
            _saveBunifuButton.BackColor = Color.Transparent;
            _saveBunifuButton.BackColor1 = Color.Teal;
            _saveBunifuButton.BackgroundImage = (Image)resources.GetObject("saveBunifuButton.BackgroundImage");
            _saveBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _saveBunifuButton.ButtonText = "SAVE";
            _saveBunifuButton.ButtonTextMarginLeft = 0;
            _saveBunifuButton.ColorContrastOnClick = 45;
            _saveBunifuButton.ColorContrastOnHover = 45;
            _saveBunifuButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _saveBunifuButton.CustomizableEdges = BorderEdges1;
            _saveBunifuButton.DialogResult = DialogResult.None;
            _saveBunifuButton.DisabledBorderColor = Color.Empty;
            _saveBunifuButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _saveBunifuButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _saveBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _saveBunifuButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _saveBunifuButton.ForeColor = Color.White;
            _saveBunifuButton.IconLeftCursor = Cursors.Hand;
            _saveBunifuButton.IconMarginLeft = 11;
            _saveBunifuButton.IconPadding = 10;
            _saveBunifuButton.IconRightCursor = Cursors.Hand;
            _saveBunifuButton.IdleBorderColor = Color.Teal;
            _saveBunifuButton.IdleBorderRadius = 3;
            _saveBunifuButton.IdleBorderThickness = 1;
            _saveBunifuButton.IdleFillColor = Color.Teal;
            _saveBunifuButton.IdleIconLeftImage = null;
            _saveBunifuButton.IdleIconRightImage = null;
            _saveBunifuButton.IndicateFocus = true;
            _saveBunifuButton.Location = new Point(908, 665);
            _saveBunifuButton.Name = "_saveBunifuButton";
            StateProperties9.BorderColor = Color.MediumTurquoise;
            StateProperties9.BorderRadius = 3;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.MediumTurquoise;
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            _saveBunifuButton.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.Teal;
            StateProperties10.BorderRadius = 3;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.Teal;
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            _saveBunifuButton.OnPressedState = StateProperties10;
            _saveBunifuButton.Size = new Size(131, 44);
            _saveBunifuButton.TabIndex = 70;
            _saveBunifuButton.TextAlign = ContentAlignment.MiddleCenter;
            _saveBunifuButton.TextMarginLeft = 0;
            _saveBunifuButton.UseDefaultRadiusAndThickness = true;
            // 
            // noBunifuButton
            // 
            _noBunifuButton.AllowToggling = false;
            _noBunifuButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _noBunifuButton.AnimationSpeed = 200;
            _noBunifuButton.AutoGenerateColors = false;
            _noBunifuButton.BackColor = Color.Transparent;
            _noBunifuButton.BackColor1 = Color.White;
            _noBunifuButton.BackgroundImage = (Image)resources.GetObject("noBunifuButton.BackgroundImage");
            _noBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _noBunifuButton.ButtonText = "CANCEL";
            _noBunifuButton.ButtonTextMarginLeft = 0;
            _noBunifuButton.ColorContrastOnClick = 45;
            _noBunifuButton.ColorContrastOnHover = 45;
            _noBunifuButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _noBunifuButton.CustomizableEdges = BorderEdges2;
            _noBunifuButton.DialogResult = DialogResult.None;
            _noBunifuButton.DisabledBorderColor = Color.Empty;
            _noBunifuButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _noBunifuButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _noBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _noBunifuButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _noBunifuButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _noBunifuButton.IconLeftCursor = Cursors.Hand;
            _noBunifuButton.IconMarginLeft = 11;
            _noBunifuButton.IconPadding = 10;
            _noBunifuButton.IconRightCursor = Cursors.Hand;
            _noBunifuButton.IdleBorderColor = Color.Gray;
            _noBunifuButton.IdleBorderRadius = 3;
            _noBunifuButton.IdleBorderThickness = 1;
            _noBunifuButton.IdleFillColor = Color.White;
            _noBunifuButton.IdleIconLeftImage = null;
            _noBunifuButton.IdleIconRightImage = null;
            _noBunifuButton.IndicateFocus = true;
            _noBunifuButton.Location = new Point(1058, 665);
            _noBunifuButton.Name = "_noBunifuButton";
            StateProperties11.BorderColor = Color.DarkGray;
            StateProperties11.BorderRadius = 3;
            StateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties11.BorderThickness = 1;
            StateProperties11.FillColor = Color.DarkGray;
            StateProperties11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties11.IconLeftImage = null;
            StateProperties11.IconRightImage = null;
            _noBunifuButton.onHoverState = StateProperties11;
            StateProperties12.BorderColor = Color.Gray;
            StateProperties12.BorderRadius = 3;
            StateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties12.BorderThickness = 1;
            StateProperties12.FillColor = Color.White;
            StateProperties12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties12.IconLeftImage = null;
            StateProperties12.IconRightImage = null;
            _noBunifuButton.OnPressedState = StateProperties12;
            _noBunifuButton.Size = new Size(135, 44);
            _noBunifuButton.TabIndex = 65;
            _noBunifuButton.TextAlign = ContentAlignment.MiddleCenter;
            _noBunifuButton.TextMarginLeft = 0;
            _noBunifuButton.UseDefaultRadiusAndThickness = true;
            // 
            // TableLayoutPanel8
            // 
            TableLayoutPanel8.Anchor = AnchorStyles.None;
            TableLayoutPanel8.ColumnCount = 3;
            TableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.10204f));
            TableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.89796f));
            TableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 525.0f));
            TableLayoutPanel8.Controls.Add(carrierBunifuDropdown, 1, 0);
            TableLayoutPanel8.Controls.Add(Label18, 0, 0);
            TableLayoutPanel8.Controls.Add(TableLayoutPanel9, 2, 0);
            TableLayoutPanel8.Location = new Point(90, 230);
            TableLayoutPanel8.Name = "TableLayoutPanel8";
            TableLayoutPanel8.RowCount = 1;
            TableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel8.Size = new Size(1065, 41);
            TableLayoutPanel8.TabIndex = 13;
            // 
            // carrierBunifuDropdown
            // 
            carrierBunifuDropdown.BackColor = Color.White;
            carrierBunifuDropdown.BorderRadius = 3;
            carrierBunifuDropdown.Color = Color.Teal;
            carrierBunifuDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            carrierBunifuDropdown.DisabledColor = Color.Gray;
            carrierBunifuDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            carrierBunifuDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            carrierBunifuDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            carrierBunifuDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            carrierBunifuDropdown.FillDropDown = false;
            carrierBunifuDropdown.FillIndicator = true;
            carrierBunifuDropdown.FlatStyle = FlatStyle.Flat;
            carrierBunifuDropdown.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            carrierBunifuDropdown.ForeColor = SystemColors.ControlDarkDark;
            carrierBunifuDropdown.FormattingEnabled = true;
            carrierBunifuDropdown.Icon = null;
            carrierBunifuDropdown.IndicatorColor = Color.Teal;
            carrierBunifuDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            carrierBunifuDropdown.ItemBackColor = Color.White;
            carrierBunifuDropdown.ItemBorderColor = Color.White;
            carrierBunifuDropdown.ItemForeColor = SystemColors.ControlDarkDark;
            carrierBunifuDropdown.ItemHeight = 28;
            carrierBunifuDropdown.ItemHighLightColor = Color.Gray;
            carrierBunifuDropdown.Location = new Point(165, 3);
            carrierBunifuDropdown.MaxDropDownItems = 50;
            carrierBunifuDropdown.Name = "carrierBunifuDropdown";
            carrierBunifuDropdown.Size = new Size(371, 34);
            carrierBunifuDropdown.TabIndex = 106;
            carrierBunifuDropdown.Text = null;
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Dock = DockStyle.Fill;
            Label18.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.Location = new Point(3, 0);
            Label18.Name = "Label18";
            Label18.Size = new Size(156, 41);
            Label18.TabIndex = 8;
            Label18.Text = "Carrier:";
            Label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel9
            // 
            TableLayoutPanel9.ColumnCount = 2;
            TableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.31441f));
            TableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.68559f));
            TableLayoutPanel9.Controls.Add(truckNumberBunifuDropdown1, 0, 0);
            TableLayoutPanel9.Controls.Add(Label19, 0, 0);
            TableLayoutPanel9.Location = new Point(539, 0);
            TableLayoutPanel9.Margin = new Padding(0);
            TableLayoutPanel9.Name = "TableLayoutPanel9";
            TableLayoutPanel9.RowCount = 1;
            TableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel9.Size = new Size(458, 41);
            TableLayoutPanel9.TabIndex = 10;
            // 
            // truckNumberBunifuDropdown1
            // 
            truckNumberBunifuDropdown1.BackColor = Color.White;
            truckNumberBunifuDropdown1.BorderRadius = 3;
            truckNumberBunifuDropdown1.Color = Color.Teal;
            truckNumberBunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            truckNumberBunifuDropdown1.DisabledColor = Color.Gray;
            truckNumberBunifuDropdown1.DrawMode = DrawMode.OwnerDrawFixed;
            truckNumberBunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            truckNumberBunifuDropdown1.DropDownStyle = ComboBoxStyle.DropDownList;
            truckNumberBunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            truckNumberBunifuDropdown1.FillDropDown = false;
            truckNumberBunifuDropdown1.FillIndicator = true;
            truckNumberBunifuDropdown1.FlatStyle = FlatStyle.Flat;
            truckNumberBunifuDropdown1.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            truckNumberBunifuDropdown1.ForeColor = SystemColors.ControlDarkDark;
            truckNumberBunifuDropdown1.FormattingEnabled = true;
            truckNumberBunifuDropdown1.Icon = null;
            truckNumberBunifuDropdown1.IndicatorColor = Color.Teal;
            truckNumberBunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            truckNumberBunifuDropdown1.ItemBackColor = Color.White;
            truckNumberBunifuDropdown1.ItemBorderColor = Color.White;
            truckNumberBunifuDropdown1.ItemForeColor = SystemColors.ControlDarkDark;
            truckNumberBunifuDropdown1.ItemHeight = 28;
            truckNumberBunifuDropdown1.ItemHighLightColor = Color.Gray;
            truckNumberBunifuDropdown1.Items.AddRange(new object[] { "N/A" });
            truckNumberBunifuDropdown1.Location = new Point(151, 3);
            truckNumberBunifuDropdown1.MaxDropDownItems = 50;
            truckNumberBunifuDropdown1.Name = "truckNumberBunifuDropdown1";
            truckNumberBunifuDropdown1.Size = new Size(205, 34);
            truckNumberBunifuDropdown1.TabIndex = 109;
            truckNumberBunifuDropdown1.Text = null;
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.Dock = DockStyle.Fill;
            Label19.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label19.Location = new Point(3, 0);
            Label19.Name = "Label19";
            Label19.Size = new Size(142, 41);
            Label19.TabIndex = 8;
            Label19.Text = "Truck Number:";
            Label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel7
            // 
            TableLayoutPanel7.Anchor = AnchorStyles.None;
            TableLayoutPanel7.ColumnCount = 2;
            TableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.33803f));
            TableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.66197f));
            TableLayoutPanel7.Controls.Add(Label17, 0, 0);
            TableLayoutPanel7.Controls.Add(commentsRichTextBox, 1, 0);
            TableLayoutPanel7.Location = new Point(85, 543);
            TableLayoutPanel7.Name = "TableLayoutPanel7";
            TableLayoutPanel7.RowCount = 1;
            TableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 97.0f));
            TableLayoutPanel7.Size = new Size(1065, 97);
            TableLayoutPanel7.TabIndex = 12;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Dock = DockStyle.Fill;
            Label17.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.Location = new Point(3, 0);
            Label17.Name = "Label17";
            Label17.Size = new Size(168, 97);
            Label17.TabIndex = 8;
            Label17.Text = "Comments:";
            Label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // commentsRichTextBox
            // 
            commentsRichTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            commentsRichTextBox.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            commentsRichTextBox.Location = new Point(177, 3);
            commentsRichTextBox.MaxLength = 255;
            commentsRichTextBox.Name = "commentsRichTextBox";
            commentsRichTextBox.Size = new Size(654, 91);
            commentsRichTextBox.TabIndex = 9;
            commentsRichTextBox.Text = "";
            // 
            // TableLayoutPanel5
            // 
            TableLayoutPanel5.Anchor = AnchorStyles.None;
            TableLayoutPanel5.ColumnCount = 4;
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.83489f));
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.16512f));
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 163.0f));
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 231.0f));
            TableLayoutPanel5.Controls.Add(dateDateTimePicker, 3, 0);
            TableLayoutPanel5.Controls.Add(timeDateTimePicker, 3, 1);
            TableLayoutPanel5.Controls.Add(Label5, 2, 0);
            TableLayoutPanel5.Controls.Add(Label11, 2, 1);
            TableLayoutPanel5.Controls.Add(Label12, 0, 0);
            TableLayoutPanel5.Controls.Add(Label16, 0, 1);
            TableLayoutPanel5.Controls.Add(fromComboBox, 1, 0);
            TableLayoutPanel5.Controls.Add(toBunifuDropdown, 1, 1);
            TableLayoutPanel5.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel5.Location = new Point(96, 131);
            TableLayoutPanel5.Name = "TableLayoutPanel5";
            TableLayoutPanel5.RowCount = 2;
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 48.80952f));
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 51.19048f));
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel5.Size = new Size(1065, 84);
            TableLayoutPanel5.TabIndex = 11;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.Anchor = AnchorStyles.None;
            TableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel3.ColumnCount = 1;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.72515f));
            TableLayoutPanel3.Controls.Add(releaseTableLayoutPanel, 0, 0);
            TableLayoutPanel3.Location = new Point(86, 70);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel3.Size = new Size(830, 41);
            TableLayoutPanel3.TabIndex = 9;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.Anchor = AnchorStyles.None;
            TableLayoutPanel2.ColumnCount = 2;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.4559f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.5441f));
            TableLayoutPanel2.Controls.Add(sizeBunifuDropdown, 1, 3);
            TableLayoutPanel2.Controls.Add(Label3, 0, 3);
            TableLayoutPanel2.Controls.Add(TableLayoutPanel4, 1, 2);
            TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 1, 1);
            TableLayoutPanel2.Controls.Add(shippingLineBunifuDropdown, 1, 0);
            TableLayoutPanel2.Controls.Add(Label14, 0, 2);
            TableLayoutPanel2.Controls.Add(Label15, 0, 1);
            TableLayoutPanel2.Controls.Add(Label4, 0, 0);
            TableLayoutPanel2.Controls.Add(TableLayoutPanel11, 1, 5);
            TableLayoutPanel2.Controls.Add(TableLayoutPanel6, 1, 4);
            TableLayoutPanel2.Controls.Add(Label9, 0, 4);
            TableLayoutPanel2.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel2.Location = new Point(74, 286);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 6;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.13147f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.73307f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.93626f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.33466f));
            TableLayoutPanel2.Size = new Size(1087, 251);
            TableLayoutPanel2.TabIndex = 1;
            // 
            // sizeBunifuDropdown
            // 
            sizeBunifuDropdown.BackColor = Color.White;
            sizeBunifuDropdown.BorderRadius = 3;
            sizeBunifuDropdown.Color = Color.Teal;
            sizeBunifuDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            sizeBunifuDropdown.DisabledColor = Color.Gray;
            sizeBunifuDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            sizeBunifuDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            sizeBunifuDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            sizeBunifuDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            sizeBunifuDropdown.FillDropDown = false;
            sizeBunifuDropdown.FillIndicator = true;
            sizeBunifuDropdown.FlatStyle = FlatStyle.Flat;
            sizeBunifuDropdown.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            sizeBunifuDropdown.ForeColor = SystemColors.ControlDarkDark;
            sizeBunifuDropdown.FormattingEnabled = true;
            sizeBunifuDropdown.Icon = null;
            sizeBunifuDropdown.IndicatorColor = Color.Teal;
            sizeBunifuDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            sizeBunifuDropdown.ItemBackColor = Color.White;
            sizeBunifuDropdown.ItemBorderColor = Color.White;
            sizeBunifuDropdown.ItemForeColor = SystemColors.ControlDarkDark;
            sizeBunifuDropdown.ItemHeight = 28;
            sizeBunifuDropdown.ItemHighLightColor = Color.Gray;
            sizeBunifuDropdown.Items.AddRange(new object[] { "20 FT", "40 FT", "40 FT High Cube", "53 FT" });
            sizeBunifuDropdown.Location = new Point(192, 130);
            sizeBunifuDropdown.MaxDropDownItems = 50;
            sizeBunifuDropdown.Name = "sizeBunifuDropdown";
            sizeBunifuDropdown.Size = new Size(224, 34);
            sizeBunifuDropdown.TabIndex = 108;
            sizeBunifuDropdown.Text = null;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Dock = DockStyle.Fill;
            Label3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(3, 127);
            Label3.Name = "Label3";
            Label3.Size = new Size(183, 42);
            Label3.TabIndex = 109;
            Label3.Text = "Size:";
            Label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel4
            // 
            TableLayoutPanel4.ColumnCount = 3;
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.20513f));
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.79487f));
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 376.0f));
            TableLayoutPanel4.Controls.Add(Label21, 1, 0);
            TableLayoutPanel4.Controls.Add(statusBunifuDropdown, 0, 0);
            TableLayoutPanel4.Controls.Add(damagesDropdown, 2, 0);
            TableLayoutPanel4.Location = new Point(189, 84);
            TableLayoutPanel4.Margin = new Padding(0);
            TableLayoutPanel4.Name = "TableLayoutPanel4";
            TableLayoutPanel4.RowCount = 1;
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel4.Size = new Size(887, 40);
            TableLayoutPanel4.TabIndex = 75;
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.Dock = DockStyle.Fill;
            Label21.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label21.Location = new Point(402, 0);
            Label21.Name = "Label21";
            Label21.Size = new Size(105, 40);
            Label21.TabIndex = 107;
            Label21.Text = "Damages:";
            Label21.TextAlign = ContentAlignment.MiddleRight;
            // 
            // statusBunifuDropdown
            // 
            statusBunifuDropdown.BackColor = Color.White;
            statusBunifuDropdown.BorderRadius = 3;
            statusBunifuDropdown.Color = Color.Teal;
            statusBunifuDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            statusBunifuDropdown.DisabledColor = Color.Gray;
            statusBunifuDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            statusBunifuDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            statusBunifuDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            statusBunifuDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            statusBunifuDropdown.FillDropDown = false;
            statusBunifuDropdown.FillIndicator = true;
            statusBunifuDropdown.FlatStyle = FlatStyle.Flat;
            statusBunifuDropdown.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            statusBunifuDropdown.ForeColor = SystemColors.ControlDarkDark;
            statusBunifuDropdown.FormattingEnabled = true;
            statusBunifuDropdown.Icon = null;
            statusBunifuDropdown.IndicatorColor = Color.Teal;
            statusBunifuDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            statusBunifuDropdown.ItemBackColor = Color.White;
            statusBunifuDropdown.ItemBorderColor = Color.White;
            statusBunifuDropdown.ItemForeColor = SystemColors.ControlDarkDark;
            statusBunifuDropdown.ItemHeight = 28;
            statusBunifuDropdown.ItemHighLightColor = Color.Gray;
            statusBunifuDropdown.Items.AddRange(new object[] { "Empty", "Partial", "Loaded" });
            statusBunifuDropdown.Location = new Point(3, 3);
            statusBunifuDropdown.MaxDropDownItems = 50;
            statusBunifuDropdown.Name = "statusBunifuDropdown";
            statusBunifuDropdown.Size = new Size(371, 34);
            statusBunifuDropdown.TabIndex = 106;
            statusBunifuDropdown.Text = null;
            // 
            // damagesDropdown
            // 
            damagesDropdown.BackColor = Color.White;
            damagesDropdown.BorderRadius = 3;
            damagesDropdown.Color = Color.Teal;
            damagesDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            damagesDropdown.DisabledColor = Color.Gray;
            damagesDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            damagesDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            damagesDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            damagesDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            damagesDropdown.FillDropDown = false;
            damagesDropdown.FillIndicator = true;
            damagesDropdown.FlatStyle = FlatStyle.Flat;
            damagesDropdown.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            damagesDropdown.ForeColor = SystemColors.ControlDarkDark;
            damagesDropdown.FormattingEnabled = true;
            damagesDropdown.Icon = null;
            damagesDropdown.IndicatorColor = Color.Teal;
            damagesDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            damagesDropdown.ItemBackColor = Color.White;
            damagesDropdown.ItemBorderColor = Color.White;
            damagesDropdown.ItemForeColor = SystemColors.ControlDarkDark;
            damagesDropdown.ItemHeight = 28;
            damagesDropdown.ItemHighLightColor = Color.Gray;
            damagesDropdown.Items.AddRange(new object[] { "None", "Hole", "Bent", "Broken", "Cut", "Pushed In (Dent)", "Pushed Out (Bulge)", "Missing" });
            damagesDropdown.Location = new Point(513, 3);
            damagesDropdown.MaxDropDownItems = 50;
            damagesDropdown.Name = "damagesDropdown";
            damagesDropdown.Size = new Size(327, 34);
            damagesDropdown.TabIndex = 108;
            damagesDropdown.Text = null;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.39008f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.60992f));
            TableLayoutPanel1.Controls.Add(containerBunifuTextBox, 0, 0);
            TableLayoutPanel1.Controls.Add(availablePictureBox, 1, 0);
            TableLayoutPanel1.Location = new Point(189, 42);
            TableLayoutPanel1.Margin = new Padding(0);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new Size(887, 40);
            TableLayoutPanel1.TabIndex = 72;
            // 
            // containerBunifuTextBox
            // 
            containerBunifuTextBox.AcceptsReturn = false;
            containerBunifuTextBox.AcceptsTab = false;
            containerBunifuTextBox.AnimationSpeed = 200;
            containerBunifuTextBox.AutoCompleteMode = AutoCompleteMode.None;
            containerBunifuTextBox.AutoCompleteSource = AutoCompleteSource.None;
            containerBunifuTextBox.BackColor = Color.Transparent;
            containerBunifuTextBox.BackgroundImage = (Image)resources.GetObject("containerBunifuTextBox.BackgroundImage");
            containerBunifuTextBox.BorderColorActive = Color.LightSeaGreen;
            containerBunifuTextBox.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            containerBunifuTextBox.BorderColorHover = Color.LightSeaGreen;
            containerBunifuTextBox.BorderColorIdle = Color.Gray;
            containerBunifuTextBox.BorderRadius = 1;
            containerBunifuTextBox.BorderThickness = 1;
            containerBunifuTextBox.CharacterCasing = CharacterCasing.Upper;
            containerBunifuTextBox.Cursor = Cursors.IBeam;
            containerBunifuTextBox.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            containerBunifuTextBox.DefaultText = "";
            containerBunifuTextBox.FillColor = Color.White;
            containerBunifuTextBox.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            containerBunifuTextBox.HideSelection = true;
            containerBunifuTextBox.IconLeft = null;
            containerBunifuTextBox.IconLeftCursor = Cursors.IBeam;
            containerBunifuTextBox.IconPadding = 10;
            containerBunifuTextBox.IconRight = null;
            containerBunifuTextBox.IconRightCursor = Cursors.IBeam;
            containerBunifuTextBox.Lines = new string[0];
            containerBunifuTextBox.Location = new Point(1, 1);
            containerBunifuTextBox.Margin = new Padding(1);
            containerBunifuTextBox.MaxLength = 32767;
            containerBunifuTextBox.MinimumSize = new Size(100, 35);
            containerBunifuTextBox.Modified = false;
            containerBunifuTextBox.Multiline = false;
            containerBunifuTextBox.Name = "containerBunifuTextBox";
            StateProperties13.BorderColor = Color.LightSeaGreen;
            StateProperties13.FillColor = Color.Empty;
            StateProperties13.ForeColor = Color.Empty;
            StateProperties13.PlaceholderForeColor = Color.Empty;
            containerBunifuTextBox.OnActiveState = StateProperties13;
            StateProperties14.BorderColor = Color.Empty;
            StateProperties14.FillColor = Color.White;
            StateProperties14.ForeColor = Color.Empty;
            StateProperties14.PlaceholderForeColor = Color.Silver;
            containerBunifuTextBox.OnDisabledState = StateProperties14;
            StateProperties15.BorderColor = Color.LightSeaGreen;
            StateProperties15.FillColor = Color.Empty;
            StateProperties15.ForeColor = Color.Empty;
            StateProperties15.PlaceholderForeColor = Color.Empty;
            containerBunifuTextBox.OnHoverState = StateProperties15;
            StateProperties16.BorderColor = Color.Gray;
            StateProperties16.FillColor = Color.White;
            StateProperties16.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties16.PlaceholderForeColor = Color.Empty;
            containerBunifuTextBox.OnIdleState = StateProperties16;
            containerBunifuTextBox.PasswordChar = '\0';
            containerBunifuTextBox.PlaceholderForeColor = Color.Silver;
            containerBunifuTextBox.PlaceholderText = "";
            containerBunifuTextBox.ReadOnly = false;
            containerBunifuTextBox.ScrollBars = ScrollBars.None;
            containerBunifuTextBox.SelectedText = "";
            containerBunifuTextBox.SelectionLength = 0;
            containerBunifuTextBox.SelectionStart = 0;
            containerBunifuTextBox.ShortcutsEnabled = true;
            containerBunifuTextBox.Size = new Size(373, 35);
            containerBunifuTextBox.Style = _Style.Bunifu;
            containerBunifuTextBox.TabIndex = 71;
            containerBunifuTextBox.TextAlign = HorizontalAlignment.Left;
            containerBunifuTextBox.TextMarginBottom = 0;
            containerBunifuTextBox.TextMarginLeft = 5;
            containerBunifuTextBox.TextMarginTop = 0;
            containerBunifuTextBox.TextPlaceholder = "";
            containerBunifuTextBox.UseSystemPasswordChar = false;
            containerBunifuTextBox.WordWrap = true;
            // 
            // availablePictureBox
            // 
            availablePictureBox.Image = My.Resources.Resources.icon_available;
            availablePictureBox.Location = new Point(377, 1);
            availablePictureBox.Margin = new Padding(1);
            availablePictureBox.Name = "availablePictureBox";
            availablePictureBox.Size = new Size(35, 33);
            availablePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            availablePictureBox.TabIndex = 71;
            availablePictureBox.TabStop = false;
            availablePictureBox.Visible = false;
            // 
            // shippingLineBunifuDropdown
            // 
            shippingLineBunifuDropdown.BackColor = Color.White;
            shippingLineBunifuDropdown.BorderRadius = 3;
            shippingLineBunifuDropdown.Color = Color.Teal;
            shippingLineBunifuDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            shippingLineBunifuDropdown.DisabledColor = Color.Gray;
            shippingLineBunifuDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            shippingLineBunifuDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            shippingLineBunifuDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            shippingLineBunifuDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            shippingLineBunifuDropdown.FillDropDown = false;
            shippingLineBunifuDropdown.FillIndicator = true;
            shippingLineBunifuDropdown.FlatStyle = FlatStyle.Flat;
            shippingLineBunifuDropdown.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            shippingLineBunifuDropdown.ForeColor = SystemColors.ControlDarkDark;
            shippingLineBunifuDropdown.FormattingEnabled = true;
            shippingLineBunifuDropdown.Icon = null;
            shippingLineBunifuDropdown.IndicatorColor = Color.Teal;
            shippingLineBunifuDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            shippingLineBunifuDropdown.ItemBackColor = Color.White;
            shippingLineBunifuDropdown.ItemBorderColor = Color.White;
            shippingLineBunifuDropdown.ItemForeColor = SystemColors.ControlDarkDark;
            shippingLineBunifuDropdown.ItemHeight = 28;
            shippingLineBunifuDropdown.ItemHighLightColor = Color.Gray;
            shippingLineBunifuDropdown.Location = new Point(192, 3);
            shippingLineBunifuDropdown.MaxDropDownItems = 50;
            shippingLineBunifuDropdown.Name = "shippingLineBunifuDropdown";
            shippingLineBunifuDropdown.Size = new Size(371, 34);
            shippingLineBunifuDropdown.TabIndex = 107;
            shippingLineBunifuDropdown.Text = null;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Dock = DockStyle.Fill;
            Label14.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.Location = new Point(3, 84);
            Label14.Name = "Label14";
            Label14.Size = new Size(183, 43);
            Label14.TabIndex = 3;
            Label14.Text = "Status:";
            Label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Dock = DockStyle.Fill;
            Label15.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.Location = new Point(3, 42);
            Label15.Name = "Label15";
            Label15.Size = new Size(183, 42);
            Label15.TabIndex = 0;
            Label15.Text = "Container Number:";
            Label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Dock = DockStyle.Fill;
            Label4.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(3, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(183, 42);
            Label4.TabIndex = 4;
            Label4.Text = "Shipping Line:";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel11
            // 
            TableLayoutPanel11.ColumnCount = 5;
            TableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.45299f));
            TableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.54701f));
            TableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186.0f));
            TableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 153.0f));
            TableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 221.0f));
            TableLayoutPanel11.Dock = DockStyle.Fill;
            TableLayoutPanel11.Location = new Point(189, 209);
            TableLayoutPanel11.Margin = new Padding(0);
            TableLayoutPanel11.Name = "TableLayoutPanel11";
            TableLayoutPanel11.RowCount = 1;
            TableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel11.Size = new Size(898, 42);
            TableLayoutPanel11.TabIndex = 79;
            // 
            // TableLayoutPanel6
            // 
            TableLayoutPanel6.ColumnCount = 8;
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.87755f));
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.12245f));
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188.0f));
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124.0f));
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51.0f));
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147.0f));
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 143.0f));
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78.0f));
            TableLayoutPanel6.Controls.Add(Label2, 7, 0);
            TableLayoutPanel6.Controls.Add(Label1, 5, 0);
            TableLayoutPanel6.Controls.Add(Label8, 4, 0);
            TableLayoutPanel6.Controls.Add(Label7, 1, 0);
            TableLayoutPanel6.Controls.Add(maxWeightBunifuTextBox, 0, 0);
            TableLayoutPanel6.Controls.Add(tareWeightBunifuTextBox, 3, 0);
            TableLayoutPanel6.Controls.Add(Label10, 2, 0);
            TableLayoutPanel6.Controls.Add(cargoBunifuTextBox1, 6, 0);
            TableLayoutPanel6.Dock = DockStyle.Fill;
            TableLayoutPanel6.Location = new Point(189, 169);
            TableLayoutPanel6.Margin = new Padding(0);
            TableLayoutPanel6.Name = "TableLayoutPanel6";
            TableLayoutPanel6.RowCount = 1;
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel6.Size = new Size(898, 40);
            TableLayoutPanel6.TabIndex = 12;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(819, 0);
            Label2.Margin = new Padding(0);
            Label2.Name = "Label2";
            Label2.Size = new Size(32, 21);
            Label2.TabIndex = 77;
            Label2.Text = "MT";
            Label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Dock = DockStyle.Fill;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(532, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(141, 40);
            Label1.TabIndex = 80;
            Label1.Text = "Cargo Weight:";
            Label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Dock = DockStyle.Fill;
            Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(478, 0);
            Label8.Margin = new Padding(0);
            Label8.Name = "Label8";
            Label8.Size = new Size(51, 40);
            Label8.TabIndex = 72;
            Label8.Text = "MT";
            Label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Dock = DockStyle.Fill;
            Label7.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(115, 0);
            Label7.Margin = new Padding(0);
            Label7.Name = "Label7";
            Label7.Size = new Size(51, 40);
            Label7.TabIndex = 71;
            Label7.Text = "MT";
            Label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // maxWeightBunifuTextBox
            // 
            maxWeightBunifuTextBox.AcceptsReturn = false;
            maxWeightBunifuTextBox.AcceptsTab = false;
            maxWeightBunifuTextBox.AnimationSpeed = 200;
            maxWeightBunifuTextBox.AutoCompleteMode = AutoCompleteMode.None;
            maxWeightBunifuTextBox.AutoCompleteSource = AutoCompleteSource.None;
            maxWeightBunifuTextBox.BackColor = Color.Transparent;
            maxWeightBunifuTextBox.BackgroundImage = (Image)resources.GetObject("maxWeightBunifuTextBox.BackgroundImage");
            maxWeightBunifuTextBox.BorderColorActive = Color.LightSeaGreen;
            maxWeightBunifuTextBox.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            maxWeightBunifuTextBox.BorderColorHover = Color.LightSeaGreen;
            maxWeightBunifuTextBox.BorderColorIdle = Color.Gray;
            maxWeightBunifuTextBox.BorderRadius = 1;
            maxWeightBunifuTextBox.BorderThickness = 1;
            maxWeightBunifuTextBox.CharacterCasing = CharacterCasing.Upper;
            maxWeightBunifuTextBox.Cursor = Cursors.IBeam;
            maxWeightBunifuTextBox.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            maxWeightBunifuTextBox.DefaultText = "";
            maxWeightBunifuTextBox.FillColor = Color.White;
            maxWeightBunifuTextBox.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            maxWeightBunifuTextBox.HideSelection = true;
            maxWeightBunifuTextBox.IconLeft = null;
            maxWeightBunifuTextBox.IconLeftCursor = Cursors.IBeam;
            maxWeightBunifuTextBox.IconPadding = 10;
            maxWeightBunifuTextBox.IconRight = null;
            maxWeightBunifuTextBox.IconRightCursor = Cursors.IBeam;
            maxWeightBunifuTextBox.Lines = new string[0];
            maxWeightBunifuTextBox.Location = new Point(3, 3);
            maxWeightBunifuTextBox.MaxLength = 32767;
            maxWeightBunifuTextBox.MinimumSize = new Size(100, 35);
            maxWeightBunifuTextBox.Modified = false;
            maxWeightBunifuTextBox.Multiline = false;
            maxWeightBunifuTextBox.Name = "maxWeightBunifuTextBox";
            StateProperties17.BorderColor = Color.LightSeaGreen;
            StateProperties17.FillColor = Color.Empty;
            StateProperties17.ForeColor = Color.Empty;
            StateProperties17.PlaceholderForeColor = Color.Empty;
            maxWeightBunifuTextBox.OnActiveState = StateProperties17;
            StateProperties18.BorderColor = Color.Empty;
            StateProperties18.FillColor = Color.White;
            StateProperties18.ForeColor = Color.Empty;
            StateProperties18.PlaceholderForeColor = Color.Silver;
            maxWeightBunifuTextBox.OnDisabledState = StateProperties18;
            StateProperties19.BorderColor = Color.LightSeaGreen;
            StateProperties19.FillColor = Color.Empty;
            StateProperties19.ForeColor = Color.Empty;
            StateProperties19.PlaceholderForeColor = Color.Empty;
            maxWeightBunifuTextBox.OnHoverState = StateProperties19;
            StateProperties20.BorderColor = Color.Gray;
            StateProperties20.FillColor = Color.White;
            StateProperties20.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties20.PlaceholderForeColor = Color.Empty;
            maxWeightBunifuTextBox.OnIdleState = StateProperties20;
            maxWeightBunifuTextBox.PasswordChar = '\0';
            maxWeightBunifuTextBox.PlaceholderForeColor = Color.Silver;
            maxWeightBunifuTextBox.PlaceholderText = "";
            maxWeightBunifuTextBox.ReadOnly = false;
            maxWeightBunifuTextBox.ScrollBars = ScrollBars.None;
            maxWeightBunifuTextBox.SelectedText = "";
            maxWeightBunifuTextBox.SelectionLength = 0;
            maxWeightBunifuTextBox.SelectionStart = 0;
            maxWeightBunifuTextBox.ShortcutsEnabled = true;
            maxWeightBunifuTextBox.Size = new Size(109, 35);
            maxWeightBunifuTextBox.Style = _Style.Bunifu;
            maxWeightBunifuTextBox.TabIndex = 12;
            maxWeightBunifuTextBox.TextAlign = HorizontalAlignment.Left;
            maxWeightBunifuTextBox.TextMarginBottom = 0;
            maxWeightBunifuTextBox.TextMarginLeft = 5;
            maxWeightBunifuTextBox.TextMarginTop = 0;
            maxWeightBunifuTextBox.TextPlaceholder = "";
            maxWeightBunifuTextBox.UseSystemPasswordChar = false;
            maxWeightBunifuTextBox.WordWrap = true;
            // 
            // tareWeightBunifuTextBox
            // 
            tareWeightBunifuTextBox.AcceptsReturn = false;
            tareWeightBunifuTextBox.AcceptsTab = false;
            tareWeightBunifuTextBox.AnimationSpeed = 200;
            tareWeightBunifuTextBox.AutoCompleteMode = AutoCompleteMode.None;
            tareWeightBunifuTextBox.AutoCompleteSource = AutoCompleteSource.None;
            tareWeightBunifuTextBox.BackColor = Color.Transparent;
            tareWeightBunifuTextBox.BackgroundImage = (Image)resources.GetObject("tareWeightBunifuTextBox.BackgroundImage");
            tareWeightBunifuTextBox.BorderColorActive = Color.LightSeaGreen;
            tareWeightBunifuTextBox.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            tareWeightBunifuTextBox.BorderColorHover = Color.LightSeaGreen;
            tareWeightBunifuTextBox.BorderColorIdle = Color.Gray;
            tareWeightBunifuTextBox.BorderRadius = 1;
            tareWeightBunifuTextBox.BorderThickness = 1;
            tareWeightBunifuTextBox.CharacterCasing = CharacterCasing.Upper;
            tareWeightBunifuTextBox.Cursor = Cursors.IBeam;
            tareWeightBunifuTextBox.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            tareWeightBunifuTextBox.DefaultText = "";
            tareWeightBunifuTextBox.FillColor = Color.White;
            tareWeightBunifuTextBox.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            tareWeightBunifuTextBox.HideSelection = true;
            tareWeightBunifuTextBox.IconLeft = null;
            tareWeightBunifuTextBox.IconLeftCursor = Cursors.IBeam;
            tareWeightBunifuTextBox.IconPadding = 10;
            tareWeightBunifuTextBox.IconRight = null;
            tareWeightBunifuTextBox.IconRightCursor = Cursors.IBeam;
            tareWeightBunifuTextBox.Lines = new string[0];
            tareWeightBunifuTextBox.Location = new Point(357, 3);
            tareWeightBunifuTextBox.MaxLength = 32767;
            tareWeightBunifuTextBox.MinimumSize = new Size(100, 35);
            tareWeightBunifuTextBox.Modified = false;
            tareWeightBunifuTextBox.Multiline = false;
            tareWeightBunifuTextBox.Name = "tareWeightBunifuTextBox";
            StateProperties21.BorderColor = Color.LightSeaGreen;
            StateProperties21.FillColor = Color.Empty;
            StateProperties21.ForeColor = Color.Empty;
            StateProperties21.PlaceholderForeColor = Color.Empty;
            tareWeightBunifuTextBox.OnActiveState = StateProperties21;
            StateProperties22.BorderColor = Color.Empty;
            StateProperties22.FillColor = Color.White;
            StateProperties22.ForeColor = Color.Empty;
            StateProperties22.PlaceholderForeColor = Color.Silver;
            tareWeightBunifuTextBox.OnDisabledState = StateProperties22;
            StateProperties23.BorderColor = Color.LightSeaGreen;
            StateProperties23.FillColor = Color.Empty;
            StateProperties23.ForeColor = Color.Empty;
            StateProperties23.PlaceholderForeColor = Color.Empty;
            tareWeightBunifuTextBox.OnHoverState = StateProperties23;
            StateProperties24.BorderColor = Color.Gray;
            StateProperties24.FillColor = Color.White;
            StateProperties24.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties24.PlaceholderForeColor = Color.Empty;
            tareWeightBunifuTextBox.OnIdleState = StateProperties24;
            tareWeightBunifuTextBox.PasswordChar = '\0';
            tareWeightBunifuTextBox.PlaceholderForeColor = Color.Silver;
            tareWeightBunifuTextBox.PlaceholderText = "";
            tareWeightBunifuTextBox.ReadOnly = false;
            tareWeightBunifuTextBox.ScrollBars = ScrollBars.None;
            tareWeightBunifuTextBox.SelectedText = "";
            tareWeightBunifuTextBox.SelectionLength = 0;
            tareWeightBunifuTextBox.SelectionStart = 0;
            tareWeightBunifuTextBox.ShortcutsEnabled = true;
            tareWeightBunifuTextBox.Size = new Size(118, 35);
            tareWeightBunifuTextBox.Style = _Style.Bunifu;
            tareWeightBunifuTextBox.TabIndex = 71;
            tareWeightBunifuTextBox.TextAlign = HorizontalAlignment.Left;
            tareWeightBunifuTextBox.TextMarginBottom = 0;
            tareWeightBunifuTextBox.TextMarginLeft = 5;
            tareWeightBunifuTextBox.TextMarginTop = 0;
            tareWeightBunifuTextBox.TextPlaceholder = "";
            tareWeightBunifuTextBox.UseSystemPasswordChar = false;
            tareWeightBunifuTextBox.WordWrap = true;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Dock = DockStyle.Fill;
            Label10.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.Location = new Point(169, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(182, 40);
            Label10.TabIndex = 9;
            Label10.Text = "TARE Weight:";
            Label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cargoBunifuTextBox1
            // 
            cargoBunifuTextBox1.AcceptsReturn = false;
            cargoBunifuTextBox1.AcceptsTab = false;
            cargoBunifuTextBox1.AnimationSpeed = 200;
            cargoBunifuTextBox1.AutoCompleteMode = AutoCompleteMode.None;
            cargoBunifuTextBox1.AutoCompleteSource = AutoCompleteSource.None;
            cargoBunifuTextBox1.BackColor = Color.Transparent;
            cargoBunifuTextBox1.BackgroundImage = (Image)resources.GetObject("cargoBunifuTextBox1.BackgroundImage");
            cargoBunifuTextBox1.BorderColorActive = Color.LightSeaGreen;
            cargoBunifuTextBox1.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            cargoBunifuTextBox1.BorderColorHover = Color.LightSeaGreen;
            cargoBunifuTextBox1.BorderColorIdle = Color.Gray;
            cargoBunifuTextBox1.BorderRadius = 1;
            cargoBunifuTextBox1.BorderThickness = 1;
            cargoBunifuTextBox1.CharacterCasing = CharacterCasing.Upper;
            cargoBunifuTextBox1.Cursor = Cursors.IBeam;
            cargoBunifuTextBox1.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            cargoBunifuTextBox1.DefaultText = "";
            cargoBunifuTextBox1.FillColor = Color.White;
            cargoBunifuTextBox1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            cargoBunifuTextBox1.HideSelection = true;
            cargoBunifuTextBox1.IconLeft = null;
            cargoBunifuTextBox1.IconLeftCursor = Cursors.IBeam;
            cargoBunifuTextBox1.IconPadding = 10;
            cargoBunifuTextBox1.IconRight = null;
            cargoBunifuTextBox1.IconRightCursor = Cursors.IBeam;
            cargoBunifuTextBox1.Lines = new string[0];
            cargoBunifuTextBox1.Location = new Point(679, 3);
            cargoBunifuTextBox1.MaxLength = 32767;
            cargoBunifuTextBox1.MinimumSize = new Size(100, 35);
            cargoBunifuTextBox1.Modified = false;
            cargoBunifuTextBox1.Multiline = false;
            cargoBunifuTextBox1.Name = "cargoBunifuTextBox1";
            StateProperties25.BorderColor = Color.LightSeaGreen;
            StateProperties25.FillColor = Color.Empty;
            StateProperties25.ForeColor = Color.Empty;
            StateProperties25.PlaceholderForeColor = Color.Empty;
            cargoBunifuTextBox1.OnActiveState = StateProperties25;
            StateProperties26.BorderColor = Color.Empty;
            StateProperties26.FillColor = Color.White;
            StateProperties26.ForeColor = Color.Empty;
            StateProperties26.PlaceholderForeColor = Color.Silver;
            cargoBunifuTextBox1.OnDisabledState = StateProperties26;
            StateProperties27.BorderColor = Color.LightSeaGreen;
            StateProperties27.FillColor = Color.Empty;
            StateProperties27.ForeColor = Color.Empty;
            StateProperties27.PlaceholderForeColor = Color.Empty;
            cargoBunifuTextBox1.OnHoverState = StateProperties27;
            StateProperties28.BorderColor = Color.Gray;
            StateProperties28.FillColor = Color.White;
            StateProperties28.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties28.PlaceholderForeColor = Color.Empty;
            cargoBunifuTextBox1.OnIdleState = StateProperties28;
            cargoBunifuTextBox1.PasswordChar = '\0';
            cargoBunifuTextBox1.PlaceholderForeColor = Color.Silver;
            cargoBunifuTextBox1.PlaceholderText = "";
            cargoBunifuTextBox1.ReadOnly = false;
            cargoBunifuTextBox1.ScrollBars = ScrollBars.None;
            cargoBunifuTextBox1.SelectedText = "";
            cargoBunifuTextBox1.SelectionLength = 0;
            cargoBunifuTextBox1.SelectionStart = 0;
            cargoBunifuTextBox1.ShortcutsEnabled = true;
            cargoBunifuTextBox1.Size = new Size(131, 35);
            cargoBunifuTextBox1.Style = _Style.Bunifu;
            cargoBunifuTextBox1.TabIndex = 79;
            cargoBunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            cargoBunifuTextBox1.TextMarginBottom = 0;
            cargoBunifuTextBox1.TextMarginLeft = 5;
            cargoBunifuTextBox1.TextMarginTop = 0;
            cargoBunifuTextBox1.TextPlaceholder = "";
            cargoBunifuTextBox1.UseSystemPasswordChar = false;
            cargoBunifuTextBox1.WordWrap = true;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Dock = DockStyle.Fill;
            Label9.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.Location = new Point(3, 169);
            Label9.Name = "Label9";
            Label9.Size = new Size(183, 40);
            Label9.TabIndex = 108;
            Label9.Text = "Max Gross Weight:";
            Label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            titleLabel.BorderColor = Color.White;
            titleLabel.Edge = 30;
            titleLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(340, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Padding = new Padding(0, 5, 0, 0);
            titleLabel.Size = new Size(612, 69);
            titleLabel.TabIndex = 83;
            titleLabel.Text = "Edit Record - Out Gate";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmAddEditOutGate
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1294, 797);
            ControlBox = false;
            Controls.Add(Panel1);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddEditOutGate";
            releaseTableLayoutPanel.ResumeLayout(false);
            releaseTableLayoutPanel.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ediPanel.ResumeLayout(false);
            ediPanel.PerformLayout();
            TableLayoutPanel8.ResumeLayout(false);
            TableLayoutPanel8.PerformLayout();
            TableLayoutPanel9.ResumeLayout(false);
            TableLayoutPanel9.PerformLayout();
            TableLayoutPanel7.ResumeLayout(false);
            TableLayoutPanel7.PerformLayout();
            TableLayoutPanel5.ResumeLayout(false);
            TableLayoutPanel5.PerformLayout();
            TableLayoutPanel3.ResumeLayout(false);
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            TableLayoutPanel4.ResumeLayout(false);
            TableLayoutPanel4.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)availablePictureBox).EndInit();
            TableLayoutPanel6.ResumeLayout(false);
            TableLayoutPanel6.PerformLayout();
            Load += new EventHandler(FrmAddEditOutGate_Load);
            ResumeLayout(false);
        }

        internal BunifuTextBox bookingNumberBunifuTextBox;
        internal DateTimePicker dateDateTimePicker;
        internal DateTimePicker timeDateTimePicker;
        internal Label Label5;
        internal Label Label11;
        internal Label Label12;
        internal Label Label16;
        internal Bunifu.UI.WinForms.BunifuDropdown fromComboBox;
        internal Label Label6;
        internal TableLayoutPanel releaseTableLayoutPanel;
        internal Bunifu.UI.WinForms.BunifuDropdown toBunifuDropdown;
        internal Panel Panel1;
        internal Panel Panel2;
        internal Bunifu.ToggleSwitch.BunifuToggleSwitch holdBunifuToggleSwitch1;
        internal Label Label20;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch _sendEDIBunifuToggleSwitch;

        internal Bunifu.ToggleSwitch.BunifuToggleSwitch sendEDIBunifuToggleSwitch
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sendEDIBunifuToggleSwitch;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sendEDIBunifuToggleSwitch != null)
                {
                    _sendEDIBunifuToggleSwitch.OnValuechange -= sendEDIBunifuToggleSwitch_OnValuechange;
                }

                _sendEDIBunifuToggleSwitch = value;
                if (_sendEDIBunifuToggleSwitch != null)
                {
                    _sendEDIBunifuToggleSwitch.OnValuechange += sendEDIBunifuToggleSwitch_OnValuechange;
                }
            }
        }

        internal Label sendEDILabel;
        internal Label Label22;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _saveBunifuButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton saveBunifuButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _saveBunifuButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_saveBunifuButton != null)
                {
                    _saveBunifuButton.Click -= saveBunifuButton_Click;
                }

                _saveBunifuButton = value;
                if (_saveBunifuButton != null)
                {
                    _saveBunifuButton.Click += saveBunifuButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _noBunifuButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton noBunifuButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _noBunifuButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_noBunifuButton != null)
                {
                    _noBunifuButton.Click -= noBunifuButton_Click;
                }

                _noBunifuButton = value;
                if (_noBunifuButton != null)
                {
                    _noBunifuButton.Click += noBunifuButton_Click;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel8;
        internal Bunifu.UI.WinForms.BunifuDropdown carrierBunifuDropdown;
        internal Label Label18;
        internal TableLayoutPanel TableLayoutPanel9;
        internal Bunifu.UI.WinForms.BunifuDropdown truckNumberBunifuDropdown1;
        internal Label Label19;
        internal TableLayoutPanel TableLayoutPanel7;
        internal Label Label17;
        internal RichTextBox commentsRichTextBox;
        internal TableLayoutPanel TableLayoutPanel5;
        internal TableLayoutPanel TableLayoutPanel3;
        internal TableLayoutPanel TableLayoutPanel2;
        internal Label Label3;
        internal TableLayoutPanel TableLayoutPanel4;
        internal Label Label21;
        internal Bunifu.UI.WinForms.BunifuDropdown statusBunifuDropdown;
        internal Bunifu.UI.WinForms.BunifuDropdown damagesDropdown;
        internal TableLayoutPanel TableLayoutPanel1;
        internal BunifuTextBox containerBunifuTextBox;
        internal PictureBox availablePictureBox;
        internal Bunifu.UI.WinForms.BunifuDropdown shippingLineBunifuDropdown;
        internal Label Label14;
        internal Label Label15;
        internal Label Label4;
        internal TableLayoutPanel TableLayoutPanel11;
        internal TableLayoutPanel TableLayoutPanel6;
        internal Label Label2;
        internal Label Label1;
        internal Label Label8;
        internal Label Label7;
        internal BunifuTextBox maxWeightBunifuTextBox;
        internal BunifuTextBox tareWeightBunifuTextBox;
        internal Label Label10;
        internal BunifuTextBox cargoBunifuTextBox1;
        internal Label Label9;
        internal Label Label27;
        internal BunifuTextBox sealNumberBunifuTextBox2;
        internal Bunifu.UI.WinForms.BunifuDropdown sizeBunifuDropdown;
        internal CustomizedControlsLibrary.ShapedLabel titleLabel;
        internal Panel ediPanel;
    }
}