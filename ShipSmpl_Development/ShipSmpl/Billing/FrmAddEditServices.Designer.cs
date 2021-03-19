using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAddEditServices : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditServices));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var Animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            var ToggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            _Label8 = new Label();
            _Label8.Click += new EventHandler(Label8_Click);
            _servTypeDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            _servTypeDropdown.SelectedIndexChanged += new EventHandler(servTypeDropdown_SelectedIndexChanged);
            truckNameDropdown6 = new Bunifu.UI.WinForms.BunifuDropdown();
            Label3 = new Label();
            Label4 = new Label();
            buttonsPanel = new TableLayoutPanel();
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(cancelButton_Click);
            _saveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _saveButton.Click += new EventHandler(saveButton_Click);
            Label1 = new Label();
            Label2 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            ratePages = new Bunifu.UI.WinForms.BunifuPages();
            drayageTab = new TabPage();
            transfersRadioButton = new Bunifu.UI.WinForms.BunifuRadioButton();
            Label13 = new Label();
            deadCallRadioButton = new Bunifu.UI.WinForms.BunifuRadioButton();
            Label22 = new Label();
            rateNumericUpDown = new NumericUpDown();
            singleLoadsRadioButton2 = new Bunifu.UI.WinForms.BunifuRadioButton();
            Label5 = new Label();
            singleEmptyRadioButton = new Bunifu.UI.WinForms.BunifuRadioButton();
            Label19 = new Label();
            Label18 = new Label();
            multLoadRadioButton = new Bunifu.UI.WinForms.BunifuRadioButton();
            Label7 = new Label();
            multipleEmtyRadioButton = new Bunifu.UI.WinForms.BunifuRadioButton();
            toDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            Label12 = new Label();
            Label14 = new Label();
            fromDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            Label11 = new Label();
            Label21 = new Label();
            fscTab = new TabPage();
            _toDateToggleSwitch = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            _toDateToggleSwitch.OnValuechange += new EventHandler(toDateToggleSwitch_OnValuechange);
            toDatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            Label20 = new Label();
            fromDatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            Label16 = new Label();
            rateFSCUpDown = new NumericUpDown();
            percentLabel = new Label();
            Label15 = new Label();
            TabPage1 = new TabPage();
            _endDateCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            _endDateCheckbox.OnChange += new EventHandler(endDateCheckbox_OnChange);
            Panel4 = new Panel();
            rvRateTypeDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            Label30 = new Label();
            _diffRateRadioButton = new Bunifu.UI.WinForms.BunifuRadioButton();
            _diffRateRadioButton.CheckedChanged += new EventHandler(diffRateRadioButton_Click);
            Label28 = new Label();
            _sameRateRadioButton = new Bunifu.UI.WinForms.BunifuRadioButton();
            _sameRateRadioButton.CheckedChanged += new EventHandler(BunifuRadioButton3_Click);
            Label33 = new Label();
            Panel1 = new Panel();
            wkdayPanel = new Panel();
            _wkDayCutoffCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            _wkDayCutoffCheckbox.OnChange += new EventHandler(wkDayCutoffCheckbox_OnChange);
            Label23 = new Label();
            wkDayCutOfftimePicker = new DateTimePicker();
            _wkDayDayRateFeeday = new NumericUpDown();
            _wkDayDayRateFeeday.ValueChanged += new EventHandler(wkDayDayRateFeeday_ValueChanged);
            wkDayNightRateUpDown = new NumericUpDown();
            beforeLabel = new Label();
            Label17 = new Label();
            Label6 = new Label();
            wkEndPanel = new Panel();
            _wkEndCutOffCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            _wkEndCutOffCheckbox.OnChange += new EventHandler(wkEndCutOffCheckbox_OnChange);
            Label24 = new Label();
            wkEndCutOffTimePicker = new DateTimePicker();
            _wkEndsDayNumericUpDown = new NumericUpDown();
            _wkEndsDayNumericUpDown.ValueChanged += new EventHandler(wkEndsDayNumericUpDown_ValueChanged);
            wkEndNightNumericUpDown = new NumericUpDown();
            Label27 = new Label();
            Label25 = new Label();
            Label26 = new Label();
            toRVDatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            fromRVDatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            Label29 = new Label();
            Label31 = new Label();
            Label32 = new Label();
            portsRvDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeBtn_Click);
            buttonsPanel.SuspendLayout();
            ratePages.SuspendLayout();
            drayageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rateNumericUpDown).BeginInit();
            fscTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rateFSCUpDown).BeginInit();
            TabPage1.SuspendLayout();
            Panel4.SuspendLayout();
            Panel1.SuspendLayout();
            wkdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_wkDayDayRateFeeday).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wkDayNightRateUpDown).BeginInit();
            wkEndPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_wkEndsDayNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wkEndNightNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // Label8
            // 
            _Label8.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _Label8.Dock = DockStyle.Top;
            _Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label8.ForeColor = Color.White;
            _Label8.Location = new Point(0, 0);
            _Label8.Name = "_Label8";
            _Label8.Size = new Size(717, 41);
            _Label8.TabIndex = 149;
            _Label8.Text = "Create Service Rate";
            _Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // servTypeDropdown
            // 
            _servTypeDropdown.Anchor = AnchorStyles.None;
            _servTypeDropdown.BackColor = Color.White;
            _servTypeDropdown.BorderRadius = 3;
            _servTypeDropdown.Color = Color.Teal;
            _servTypeDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _servTypeDropdown.DisabledColor = Color.Gray;
            _servTypeDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            _servTypeDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            _servTypeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            _servTypeDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _servTypeDropdown.FillDropDown = false;
            _servTypeDropdown.FillIndicator = true;
            _servTypeDropdown.FlatStyle = FlatStyle.Flat;
            _servTypeDropdown.Font = new Font("Arial", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _servTypeDropdown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _servTypeDropdown.FormattingEnabled = true;
            _servTypeDropdown.Icon = null;
            _servTypeDropdown.IndicatorColor = Color.Teal;
            _servTypeDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _servTypeDropdown.ItemBackColor = Color.White;
            _servTypeDropdown.ItemBorderColor = Color.White;
            _servTypeDropdown.ItemForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _servTypeDropdown.ItemHeight = 27;
            _servTypeDropdown.ItemHighLightColor = Color.Gray;
            _servTypeDropdown.Items.AddRange(new object[] { "Drayage", "FSC", "TEF" });
            _servTypeDropdown.Location = new Point(215, 101);
            _servTypeDropdown.MaxDropDownItems = 50;
            _servTypeDropdown.Name = "_servTypeDropdown";
            _servTypeDropdown.Size = new Size(257, 33);
            _servTypeDropdown.TabIndex = 143;
            _servTypeDropdown.Text = null;
            // 
            // truckNameDropdown6
            // 
            truckNameDropdown6.Anchor = AnchorStyles.None;
            truckNameDropdown6.BackColor = Color.White;
            truckNameDropdown6.BorderRadius = 3;
            truckNameDropdown6.Color = Color.Teal;
            truckNameDropdown6.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            truckNameDropdown6.DisabledColor = Color.Gray;
            truckNameDropdown6.DrawMode = DrawMode.OwnerDrawFixed;
            truckNameDropdown6.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            truckNameDropdown6.DropDownStyle = ComboBoxStyle.DropDownList;
            truckNameDropdown6.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            truckNameDropdown6.FillDropDown = false;
            truckNameDropdown6.FillIndicator = true;
            truckNameDropdown6.FlatStyle = FlatStyle.Flat;
            truckNameDropdown6.Font = new Font("Arial", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            truckNameDropdown6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            truckNameDropdown6.FormattingEnabled = true;
            truckNameDropdown6.Icon = null;
            truckNameDropdown6.IndicatorColor = Color.Teal;
            truckNameDropdown6.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            truckNameDropdown6.ItemBackColor = Color.White;
            truckNameDropdown6.ItemBorderColor = Color.White;
            truckNameDropdown6.ItemForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            truckNameDropdown6.ItemHeight = 27;
            truckNameDropdown6.ItemHighLightColor = Color.Gray;
            truckNameDropdown6.Location = new Point(215, 140);
            truckNameDropdown6.MaxDropDownItems = 50;
            truckNameDropdown6.Name = "truckNameDropdown6";
            truckNameDropdown6.Size = new Size(458, 33);
            truckNameDropdown6.TabIndex = 123;
            truckNameDropdown6.Text = null;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.None;
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(40, 141);
            Label3.Margin = new Padding(0);
            Label3.Name = "Label3";
            Label3.Size = new Size(172, 25);
            Label3.TabIndex = 122;
            Label3.Text = "Trucking Company:";
            Label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.None;
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label4.Location = new Point(92, 106);
            Label4.Margin = new Padding(0);
            Label4.Name = "Label4";
            Label4.Size = new Size(120, 25);
            Label4.TabIndex = 141;
            Label4.Text = "Service Type:";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.None;
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Controls.Add(_cancelButton, 1, 0);
            buttonsPanel.Controls.Add(_saveButton, 0, 0);
            buttonsPanel.Location = new Point(496, 525);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(182, 39);
            buttonsPanel.TabIndex = 138;
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
            _cancelButton.ButtonText = "Cancel";
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
            _cancelButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _cancelButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _cancelButton.IconLeftCursor = Cursors.Hand;
            _cancelButton.IconMarginLeft = 11;
            _cancelButton.IconPadding = 10;
            _cancelButton.IconRightCursor = Cursors.Hand;
            _cancelButton.IdleBorderColor = Color.Gray;
            _cancelButton.IdleBorderRadius = 3;
            _cancelButton.IdleBorderThickness = 1;
            _cancelButton.IdleFillColor = Color.White;
            _cancelButton.IdleIconLeftImage = null;
            _cancelButton.IdleIconRightImage = null;
            _cancelButton.IndicateFocus = true;
            _cancelButton.Location = new Point(98, 3);
            _cancelButton.Name = "_cancelButton";
            StateProperties1.BorderColor = Color.DarkGray;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.DarkGray;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.IndianRed;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.IndianRed;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties2;
            _cancelButton.Size = new Size(81, 33);
            _cancelButton.TabIndex = 137;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // saveButton
            // 
            _saveButton.AllowToggling = false;
            _saveButton.AnimationSpeed = 200;
            _saveButton.AutoGenerateColors = false;
            _saveButton.BackColor = Color.Transparent;
            _saveButton.BackColor1 = Color.Teal;
            _saveButton.BackgroundImage = (Image)resources.GetObject("saveButton.BackgroundImage");
            _saveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _saveButton.ButtonText = "Save";
            _saveButton.ButtonTextMarginLeft = 0;
            _saveButton.ColorContrastOnClick = 45;
            _saveButton.ColorContrastOnHover = 45;
            _saveButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _saveButton.CustomizableEdges = BorderEdges2;
            _saveButton.DialogResult = DialogResult.None;
            _saveButton.DisabledBorderColor = Color.Empty;
            _saveButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _saveButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _saveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _saveButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _saveButton.ForeColor = Color.White;
            _saveButton.IconLeftCursor = Cursors.Hand;
            _saveButton.IconMarginLeft = 11;
            _saveButton.IconPadding = 10;
            _saveButton.IconRightCursor = Cursors.Hand;
            _saveButton.IdleBorderColor = Color.Teal;
            _saveButton.IdleBorderRadius = 3;
            _saveButton.IdleBorderThickness = 1;
            _saveButton.IdleFillColor = Color.Teal;
            _saveButton.IdleIconLeftImage = null;
            _saveButton.IdleIconRightImage = null;
            _saveButton.IndicateFocus = true;
            _saveButton.Location = new Point(3, 3);
            _saveButton.Name = "_saveButton";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _saveButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _saveButton.OnPressedState = StateProperties4;
            _saveButton.Size = new Size(85, 33);
            _saveButton.TabIndex = 136;
            _saveButton.TextAlign = ContentAlignment.MiddleCenter;
            _saveButton.TextMarginLeft = 0;
            _saveButton.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.None;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.Silver;
            Label1.Location = new Point(26, 60);
            Label1.Margin = new Padding(0);
            Label1.Name = "Label1";
            Label1.Size = new Size(644, 25);
            Label1.TabIndex = 153;
            Label1.Text = "_______________________________________________________________________________";
            Label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.None;
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label2.Location = new Point(40, 166);
            Label2.Margin = new Padding(0);
            Label2.Name = "Label2";
            Label2.Size = new Size(59, 25);
            Label2.TabIndex = 154;
            Label2.Text = "Rates";
            Label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.None;
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label9.Location = new Point(26, 51);
            Label9.Margin = new Padding(0);
            Label9.Name = "Label9";
            Label9.Size = new Size(174, 25);
            Label9.TabIndex = 155;
            Label9.Text = "Carrier and Service";
            Label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.None;
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = Color.Silver;
            Label10.Location = new Point(38, 178);
            Label10.Margin = new Padding(0);
            Label10.Name = "Label10";
            Label10.Size = new Size(644, 25);
            Label10.TabIndex = 156;
            Label10.Text = "_______________________________________________________________________________";
            Label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ratePages
            // 
            ratePages.Alignment = TabAlignment.Bottom;
            ratePages.AllowTransitions = true;
            ratePages.Anchor = AnchorStyles.None;
            ratePages.Controls.Add(drayageTab);
            ratePages.Controls.Add(fscTab);
            ratePages.Controls.Add(TabPage1);
            ratePages.Location = new Point(12, 199);
            ratePages.Multiline = true;
            ratePages.Name = "ratePages";
            ratePages.Page = fscTab;
            ratePages.PageIndex = 1;
            ratePages.PageName = "fscTab";
            ratePages.PageTitle = "FSC";
            ratePages.SelectedIndex = 0;
            ratePages.Size = new Size(693, 334);
            ratePages.TabIndex = 165;
            ratePages.TabStop = false;
            Animation1.AnimateOnlyDifferences = true;
            Animation1.BlindCoeff = (PointF)resources.GetObject("Animation1.BlindCoeff");
            Animation1.LeafCoeff = 0f;
            Animation1.MaxTime = 0f;
            Animation1.MinTime = 0f;
            Animation1.MosaicCoeff = (PointF)resources.GetObject("Animation1.MosaicCoeff");
            Animation1.MosaicShift = (PointF)resources.GetObject("Animation1.MosaicShift");
            Animation1.MosaicSize = 1;
            Animation1.Padding = new Padding(100, 50, 100, 150);
            Animation1.RotateCoeff = 0f;
            Animation1.RotateLimit = 0f;
            Animation1.ScaleCoeff = (PointF)resources.GetObject("Animation1.ScaleCoeff");
            Animation1.SlideCoeff = (PointF)resources.GetObject("Animation1.SlideCoeff");
            Animation1.TimeCoeff = 0f;
            Animation1.TransparencyCoeff = 0f;
            ratePages.Transition = Animation1;
            ratePages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // drayageTab
            // 
            drayageTab.BackColor = Color.White;
            drayageTab.Controls.Add(transfersRadioButton);
            drayageTab.Controls.Add(Label13);
            drayageTab.Controls.Add(deadCallRadioButton);
            drayageTab.Controls.Add(Label22);
            drayageTab.Controls.Add(rateNumericUpDown);
            drayageTab.Controls.Add(singleLoadsRadioButton2);
            drayageTab.Controls.Add(Label5);
            drayageTab.Controls.Add(singleEmptyRadioButton);
            drayageTab.Controls.Add(Label19);
            drayageTab.Controls.Add(Label18);
            drayageTab.Controls.Add(multLoadRadioButton);
            drayageTab.Controls.Add(Label7);
            drayageTab.Controls.Add(multipleEmtyRadioButton);
            drayageTab.Controls.Add(toDropdown);
            drayageTab.Controls.Add(Label12);
            drayageTab.Controls.Add(Label14);
            drayageTab.Controls.Add(fromDropdown);
            drayageTab.Controls.Add(Label11);
            drayageTab.Controls.Add(Label21);
            drayageTab.Location = new Point(4, 4);
            drayageTab.Name = "drayageTab";
            drayageTab.Padding = new Padding(3);
            drayageTab.Size = new Size(685, 308);
            drayageTab.TabIndex = 1;
            drayageTab.Text = "Drayage";
            // 
            // transfersRadioButton
            // 
            transfersRadioButton.Checked = false;
            transfersRadioButton.Location = new Point(485, 55);
            transfersRadioButton.Name = "transfersRadioButton";
            transfersRadioButton.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            transfersRadioButton.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            transfersRadioButton.Size = new Size(22, 22);
            transfersRadioButton.TabIndex = 185;
            transfersRadioButton.Tag = "Load Rate";
            transfersRadioButton.Text = null;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label13.Location = new Point(504, 52);
            Label13.Margin = new Padding(0);
            Label13.Name = "Label13";
            Label13.Size = new Size(87, 25);
            Label13.TabIndex = 186;
            Label13.Text = "Transfers";
            Label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deadCallRadioButton
            // 
            deadCallRadioButton.Checked = false;
            deadCallRadioButton.Location = new Point(485, 28);
            deadCallRadioButton.Name = "deadCallRadioButton";
            deadCallRadioButton.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            deadCallRadioButton.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            deadCallRadioButton.Size = new Size(22, 22);
            deadCallRadioButton.TabIndex = 183;
            deadCallRadioButton.Tag = "Load Rate";
            deadCallRadioButton.Text = null;
            // 
            // Label22
            // 
            Label22.AutoSize = true;
            Label22.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label22.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label22.Location = new Point(504, 25);
            Label22.Margin = new Padding(0);
            Label22.Name = "Label22";
            Label22.Size = new Size(101, 25);
            Label22.TabIndex = 184;
            Label22.Text = "Dead Calls";
            Label22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rateNumericUpDown
            // 
            rateNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            rateNumericUpDown.DecimalPlaces = 2;
            rateNumericUpDown.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            rateNumericUpDown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            rateNumericUpDown.Location = new Point(128, 160);
            rateNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            rateNumericUpDown.Name = "rateNumericUpDown";
            rateNumericUpDown.Size = new Size(118, 35);
            rateNumericUpDown.TabIndex = 182;
            rateNumericUpDown.TextAlign = HorizontalAlignment.Center;
            rateNumericUpDown.ThousandsSeparator = true;
            // 
            // singleLoadsRadioButton2
            // 
            singleLoadsRadioButton2.Checked = false;
            singleLoadsRadioButton2.Location = new Point(315, 55);
            singleLoadsRadioButton2.Name = "singleLoadsRadioButton2";
            singleLoadsRadioButton2.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            singleLoadsRadioButton2.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            singleLoadsRadioButton2.Size = new Size(22, 22);
            singleLoadsRadioButton2.TabIndex = 179;
            singleLoadsRadioButton2.Tag = "Load Rate";
            singleLoadsRadioButton2.Text = null;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label5.Location = new Point(334, 52);
            Label5.Margin = new Padding(0);
            Label5.Name = "Label5";
            Label5.Size = new Size(110, 25);
            Label5.TabIndex = 180;
            Label5.Text = "Single Load";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // singleEmptyRadioButton
            // 
            singleEmptyRadioButton.Checked = false;
            singleEmptyRadioButton.Location = new Point(132, 52);
            singleEmptyRadioButton.Name = "singleEmptyRadioButton";
            singleEmptyRadioButton.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            singleEmptyRadioButton.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            singleEmptyRadioButton.Size = new Size(22, 22);
            singleEmptyRadioButton.TabIndex = 177;
            singleEmptyRadioButton.Tag = "Empty Rate";
            singleEmptyRadioButton.Text = null;
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label19.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label19.Location = new Point(151, 49);
            Label19.Margin = new Padding(0);
            Label19.Name = "Label19";
            Label19.Size = new Size(121, 25);
            Label19.TabIndex = 178;
            Label19.Text = "Single Empty";
            Label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label18
            // 
            Label18.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label18.Location = new Point(24, 22);
            Label18.Margin = new Padding(0);
            Label18.Name = "Label18";
            Label18.Size = new Size(97, 52);
            Label18.TabIndex = 176;
            Label18.Text = "Rate Type (Base):";
            Label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // multLoadRadioButton
            // 
            multLoadRadioButton.Checked = false;
            multLoadRadioButton.Location = new Point(315, 28);
            multLoadRadioButton.Name = "multLoadRadioButton";
            multLoadRadioButton.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            multLoadRadioButton.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            multLoadRadioButton.Size = new Size(22, 22);
            multLoadRadioButton.TabIndex = 174;
            multLoadRadioButton.Tag = "Load Rate";
            multLoadRadioButton.Text = null;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Location = new Point(334, 25);
            Label7.Margin = new Padding(0);
            Label7.Name = "Label7";
            Label7.Size = new Size(136, 25);
            Label7.TabIndex = 175;
            Label7.Text = "Multiple Loads";
            Label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // multipleEmtyRadioButton
            // 
            multipleEmtyRadioButton.Checked = true;
            multipleEmtyRadioButton.Location = new Point(132, 25);
            multipleEmtyRadioButton.Name = "multipleEmtyRadioButton";
            multipleEmtyRadioButton.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            multipleEmtyRadioButton.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            multipleEmtyRadioButton.Size = new Size(22, 22);
            multipleEmtyRadioButton.TabIndex = 167;
            multipleEmtyRadioButton.Tag = "Empty Rate";
            multipleEmtyRadioButton.Text = null;
            // 
            // toDropdown
            // 
            toDropdown.BackColor = Color.White;
            toDropdown.BorderRadius = 3;
            toDropdown.Color = Color.Teal;
            toDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            toDropdown.DisabledColor = Color.Gray;
            toDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            toDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            toDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            toDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            toDropdown.FillDropDown = false;
            toDropdown.FillIndicator = true;
            toDropdown.FlatStyle = FlatStyle.Flat;
            toDropdown.Font = new Font("Arial", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            toDropdown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            toDropdown.FormattingEnabled = true;
            toDropdown.Icon = null;
            toDropdown.IndicatorColor = Color.Teal;
            toDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            toDropdown.ItemBackColor = Color.White;
            toDropdown.ItemBorderColor = Color.White;
            toDropdown.ItemForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            toDropdown.ItemHeight = 27;
            toDropdown.ItemHighLightColor = Color.Gray;
            toDropdown.Location = new Point(128, 122);
            toDropdown.MaxDropDownItems = 50;
            toDropdown.Name = "toDropdown";
            toDropdown.Size = new Size(462, 33);
            toDropdown.TabIndex = 172;
            toDropdown.Text = null;
            // 
            // Label12
            // 
            Label12.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Location = new Point(58, 125);
            Label12.Margin = new Padding(0);
            Label12.Name = "Label12";
            Label12.Size = new Size(67, 25);
            Label12.TabIndex = 171;
            Label12.Text = "To:";
            Label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label14.Location = new Point(151, 22);
            Label14.Margin = new Padding(0);
            Label14.Name = "Label14";
            Label14.Size = new Size(147, 25);
            Label14.TabIndex = 168;
            Label14.Text = "Multiple Emptys";
            Label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fromDropdown
            // 
            fromDropdown.BackColor = Color.White;
            fromDropdown.BorderRadius = 3;
            fromDropdown.Color = Color.Teal;
            fromDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            fromDropdown.DisabledColor = Color.Gray;
            fromDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            fromDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            fromDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            fromDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            fromDropdown.FillDropDown = false;
            fromDropdown.FillIndicator = true;
            fromDropdown.FlatStyle = FlatStyle.Flat;
            fromDropdown.Font = new Font("Arial", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            fromDropdown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            fromDropdown.FormattingEnabled = true;
            fromDropdown.Icon = null;
            fromDropdown.IndicatorColor = Color.Teal;
            fromDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            fromDropdown.ItemBackColor = Color.White;
            fromDropdown.ItemBorderColor = Color.White;
            fromDropdown.ItemForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            fromDropdown.ItemHeight = 27;
            fromDropdown.ItemHighLightColor = Color.Gray;
            fromDropdown.Location = new Point(128, 85);
            fromDropdown.MaxDropDownItems = 50;
            fromDropdown.Name = "fromDropdown";
            fromDropdown.Size = new Size(462, 33);
            fromDropdown.TabIndex = 170;
            fromDropdown.Text = null;
            // 
            // Label11
            // 
            Label11.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label11.Location = new Point(57, 92);
            Label11.Margin = new Padding(0);
            Label11.Name = "Label11";
            Label11.Size = new Size(65, 25);
            Label11.TabIndex = 169;
            Label11.Text = "From:";
            Label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label21.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label21.Location = new Point(2, 166);
            Label21.Margin = new Padding(0);
            Label21.Name = "Label21";
            Label21.Size = new Size(119, 25);
            Label21.TabIndex = 181;
            Label21.Text = "Default Rate:";
            Label21.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fscTab
            // 
            fscTab.Controls.Add(_toDateToggleSwitch);
            fscTab.Controls.Add(toDatePicker);
            fscTab.Controls.Add(Label20);
            fscTab.Controls.Add(fromDatePicker);
            fscTab.Controls.Add(Label16);
            fscTab.Controls.Add(rateFSCUpDown);
            fscTab.Controls.Add(percentLabel);
            fscTab.Controls.Add(Label15);
            fscTab.Location = new Point(4, 4);
            fscTab.Name = "fscTab";
            fscTab.Padding = new Padding(3);
            fscTab.Size = new Size(685, 308);
            fscTab.TabIndex = 0;
            fscTab.Text = "FSC";
            fscTab.UseVisualStyleBackColor = true;
            // 
            // toDateToggleSwitch
            // 
            _toDateToggleSwitch.Animation = 5;
            _toDateToggleSwitch.BackColor = Color.Transparent;
            _toDateToggleSwitch.BackgroundImage = (Image)resources.GetObject("toDateToggleSwitch.BackgroundImage");
            _toDateToggleSwitch.Cursor = Cursors.Hand;
            _toDateToggleSwitch.Location = new Point(168, 84);
            _toDateToggleSwitch.Name = "_toDateToggleSwitch";
            _toDateToggleSwitch.Size = new Size(28, 17);
            _toDateToggleSwitch.TabIndex = 167;
            ToggleState1.BackColor = Color.Empty;
            ToggleState1.BackColorInner = Color.Empty;
            ToggleState1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(236)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(140)));
            ToggleState1.BorderColorInner = Color.Empty;
            ToggleState1.BorderRadius = 1;
            ToggleState1.BorderRadiusInner = 1;
            ToggleState1.BorderThickness = 1;
            ToggleState1.BorderThicknessInner = 1;
            _toDateToggleSwitch.ToggleStateDisabled = ToggleState1;
            ToggleState2.BackColor = Color.Gray;
            ToggleState2.BackColorInner = Color.White;
            ToggleState2.BorderColor = Color.Gray;
            ToggleState2.BorderColorInner = Color.White;
            ToggleState2.BorderRadius = 14;
            ToggleState2.BorderRadiusInner = 10;
            ToggleState2.BorderThickness = 1;
            ToggleState2.BorderThicknessInner = 1;
            _toDateToggleSwitch.ToggleStateOff = ToggleState2;
            ToggleState3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState3.BackColorInner = Color.White;
            ToggleState3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState3.BorderColorInner = Color.White;
            ToggleState3.BorderRadius = 14;
            ToggleState3.BorderRadiusInner = 10;
            ToggleState3.BorderThickness = 1;
            ToggleState3.BorderThicknessInner = 1;
            _toDateToggleSwitch.ToggleStateOn = ToggleState3;
            _toDateToggleSwitch.Value = true;
            // 
            // toDatePicker
            // 
            toDatePicker.BorderRadius = 1;
            toDatePicker.Color = Color.Teal;
            toDatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            toDatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            toDatePicker.DisabledColor = Color.Gray;
            toDatePicker.DisplayWeekNumbers = false;
            toDatePicker.DPHeight = 0;
            toDatePicker.DropDownAlign = LeftRightAlignment.Right;
            toDatePicker.FillDatePicker = false;
            toDatePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            toDatePicker.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            toDatePicker.Icon = (Image)resources.GetObject("toDatePicker.Icon");
            toDatePicker.IconColor = Color.Teal;
            toDatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            toDatePicker.Location = new Point(202, 75);
            toDatePicker.MinimumSize = new Size(200, 34);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(200, 34);
            toDatePicker.TabIndex = 174;
            // 
            // Label20
            // 
            Label20.Anchor = AnchorStyles.None;
            Label20.AutoSize = true;
            Label20.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label20.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label20.Location = new Point(136, 78);
            Label20.Margin = new Padding(0);
            Label20.Name = "Label20";
            Label20.Size = new Size(35, 25);
            Label20.TabIndex = 173;
            Label20.Text = "To:";
            Label20.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fromDatePicker
            // 
            fromDatePicker.BorderRadius = 1;
            fromDatePicker.Color = Color.Teal;
            fromDatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            fromDatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            fromDatePicker.DisabledColor = Color.Gray;
            fromDatePicker.DisplayWeekNumbers = false;
            fromDatePicker.DPHeight = 0;
            fromDatePicker.DropDownAlign = LeftRightAlignment.Right;
            fromDatePicker.FillDatePicker = false;
            fromDatePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            fromDatePicker.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            fromDatePicker.Icon = (Image)resources.GetObject("fromDatePicker.Icon");
            fromDatePicker.IconColor = Color.Teal;
            fromDatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            fromDatePicker.Location = new Point(202, 27);
            fromDatePicker.MinimumSize = new Size(200, 34);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(200, 34);
            fromDatePicker.TabIndex = 172;
            // 
            // Label16
            // 
            Label16.Anchor = AnchorStyles.None;
            Label16.AutoSize = true;
            Label16.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label16.Location = new Point(117, 34);
            Label16.Margin = new Padding(0);
            Label16.Name = "Label16";
            Label16.Size = new Size(59, 25);
            Label16.TabIndex = 170;
            Label16.Text = "From:";
            Label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rateFSCUpDown
            // 
            rateFSCUpDown.Anchor = AnchorStyles.None;
            rateFSCUpDown.BorderStyle = BorderStyle.FixedSingle;
            rateFSCUpDown.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            rateFSCUpDown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            rateFSCUpDown.Location = new Point(202, 124);
            rateFSCUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            rateFSCUpDown.Name = "rateFSCUpDown";
            rateFSCUpDown.Size = new Size(98, 35);
            rateFSCUpDown.TabIndex = 168;
            rateFSCUpDown.TextAlign = HorizontalAlignment.Center;
            rateFSCUpDown.ThousandsSeparator = true;
            // 
            // percentLabel
            // 
            percentLabel.Anchor = AnchorStyles.None;
            percentLabel.AutoSize = true;
            percentLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            percentLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            percentLabel.Location = new Point(302, 128);
            percentLabel.Margin = new Padding(0);
            percentLabel.Name = "percentLabel";
            percentLabel.Size = new Size(31, 30);
            percentLabel.TabIndex = 169;
            percentLabel.Text = "%";
            percentLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label15
            // 
            Label15.Anchor = AnchorStyles.None;
            Label15.AutoSize = true;
            Label15.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label15.Location = new Point(118, 130);
            Label15.Margin = new Padding(0);
            Label15.Name = "Label15";
            Label15.Size = new Size(53, 25);
            Label15.TabIndex = 167;
            Label15.Text = "Rate:";
            Label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(_endDateCheckbox);
            TabPage1.Controls.Add(Panel4);
            TabPage1.Controls.Add(Panel1);
            TabPage1.Controls.Add(toRVDatePicker);
            TabPage1.Controls.Add(fromRVDatePicker);
            TabPage1.Controls.Add(Label29);
            TabPage1.Controls.Add(Label31);
            TabPage1.Controls.Add(Label32);
            TabPage1.Controls.Add(portsRvDropdown);
            TabPage1.Location = new Point(4, 4);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(685, 308);
            TabPage1.TabIndex = 2;
            TabPage1.Text = "TEF";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // endDateCheckbox
            // 
            _endDateCheckbox.Anchor = AnchorStyles.None;
            _endDateCheckbox.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(132)), Conversions.ToInteger(Conversions.ToByte(135)), Conversions.ToInteger(Conversions.ToByte(140)));
            _endDateCheckbox.ChechedOffColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(132)), Conversions.ToInteger(Conversions.ToByte(135)), Conversions.ToInteger(Conversions.ToByte(140)));
            _endDateCheckbox.Checked = false;
            _endDateCheckbox.CheckedOnColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _endDateCheckbox.ForeColor = Color.White;
            _endDateCheckbox.Location = new Point(359, 279);
            _endDateCheckbox.Name = "_endDateCheckbox";
            _endDateCheckbox.Size = new Size(20, 20);
            _endDateCheckbox.TabIndex = 195;
            // 
            // Panel4
            // 
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(rvRateTypeDropdown);
            Panel4.Controls.Add(Label30);
            Panel4.Controls.Add(_diffRateRadioButton);
            Panel4.Controls.Add(Label28);
            Panel4.Controls.Add(_sameRateRadioButton);
            Panel4.Controls.Add(Label33);
            Panel4.Location = new Point(15, 5);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(620, 85);
            Panel4.TabIndex = 194;
            // 
            // rvRateTypeDropdown
            // 
            rvRateTypeDropdown.Anchor = AnchorStyles.None;
            rvRateTypeDropdown.BackColor = Color.Transparent;
            rvRateTypeDropdown.BorderRadius = 3;
            rvRateTypeDropdown.Color = Color.Teal;
            rvRateTypeDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            rvRateTypeDropdown.DisabledColor = Color.Gray;
            rvRateTypeDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            rvRateTypeDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            rvRateTypeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            rvRateTypeDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            rvRateTypeDropdown.FillDropDown = false;
            rvRateTypeDropdown.FillIndicator = true;
            rvRateTypeDropdown.FlatStyle = FlatStyle.Flat;
            rvRateTypeDropdown.Font = new Font("Arial", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            rvRateTypeDropdown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            rvRateTypeDropdown.FormattingEnabled = true;
            rvRateTypeDropdown.Icon = null;
            rvRateTypeDropdown.IndicatorColor = Color.Teal;
            rvRateTypeDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            rvRateTypeDropdown.ItemBackColor = Color.White;
            rvRateTypeDropdown.ItemBorderColor = Color.White;
            rvRateTypeDropdown.ItemForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            rvRateTypeDropdown.ItemHeight = 25;
            rvRateTypeDropdown.ItemHighLightColor = Color.Gray;
            rvRateTypeDropdown.Items.AddRange(new object[] { "Load", "Empty" });
            rvRateTypeDropdown.Location = new Point(100, 2);
            rvRateTypeDropdown.MaxDropDownItems = 50;
            rvRateTypeDropdown.Name = "rvRateTypeDropdown";
            rvRateTypeDropdown.Size = new Size(142, 31);
            rvRateTypeDropdown.TabIndex = 191;
            rvRateTypeDropdown.Text = null;
            // 
            // Label30
            // 
            Label30.Anchor = AnchorStyles.None;
            Label30.AutoSize = true;
            Label30.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label30.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label30.Location = new Point(114, 34);
            Label30.Margin = new Padding(0);
            Label30.Name = "Label30";
            Label30.Size = new Size(350, 25);
            Label30.TabIndex = 186;
            Label30.Text = "Same rates for Weekdays and Weekends";
            Label30.TextAlign = ContentAlignment.MiddleRight;
            // 
            // diffRateRadioButton
            // 
            _diffRateRadioButton.Anchor = AnchorStyles.None;
            _diffRateRadioButton.Checked = false;
            _diffRateRadioButton.Location = new Point(93, 61);
            _diffRateRadioButton.Name = "_diffRateRadioButton";
            _diffRateRadioButton.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _diffRateRadioButton.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _diffRateRadioButton.Size = new Size(22, 22);
            _diffRateRadioButton.TabIndex = 189;
            _diffRateRadioButton.Tag = "Load Rate";
            _diffRateRadioButton.Text = null;
            // 
            // Label28
            // 
            Label28.Anchor = AnchorStyles.None;
            Label28.AutoSize = true;
            Label28.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label28.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label28.Location = new Point(113, 58);
            Label28.Margin = new Padding(0);
            Label28.Name = "Label28";
            Label28.Size = new Size(378, 25);
            Label28.TabIndex = 190;
            Label28.Text = "Different rates for Weekdays and Weekends";
            Label28.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sameRateRadioButton
            // 
            _sameRateRadioButton.Anchor = AnchorStyles.None;
            _sameRateRadioButton.Checked = true;
            _sameRateRadioButton.Location = new Point(93, 37);
            _sameRateRadioButton.Name = "_sameRateRadioButton";
            _sameRateRadioButton.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _sameRateRadioButton.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _sameRateRadioButton.Size = new Size(22, 22);
            _sameRateRadioButton.TabIndex = 185;
            _sameRateRadioButton.Tag = "Empty Rate";
            _sameRateRadioButton.Text = null;
            // 
            // Label33
            // 
            Label33.Anchor = AnchorStyles.None;
            Label33.AutoSize = true;
            Label33.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label33.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label33.Location = new Point(4, 7);
            Label33.Margin = new Padding(0);
            Label33.Name = "Label33";
            Label33.Size = new Size(97, 25);
            Label33.TabIndex = 188;
            Label33.Text = "Rate Type:";
            Label33.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Panel1.Controls.Add(wkdayPanel);
            Panel1.Controls.Add(wkEndPanel);
            Panel1.Location = new Point(15, 91);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(620, 144);
            Panel1.TabIndex = 193;
            // 
            // wkdayPanel
            // 
            wkdayPanel.BackColor = Color.White;
            wkdayPanel.Controls.Add(_wkDayCutoffCheckbox);
            wkdayPanel.Controls.Add(Label23);
            wkdayPanel.Controls.Add(wkDayCutOfftimePicker);
            wkdayPanel.Controls.Add(_wkDayDayRateFeeday);
            wkdayPanel.Controls.Add(wkDayNightRateUpDown);
            wkdayPanel.Controls.Add(beforeLabel);
            wkdayPanel.Controls.Add(Label17);
            wkdayPanel.Controls.Add(Label6);
            wkdayPanel.Dock = DockStyle.Left;
            wkdayPanel.Location = new Point(0, 0);
            wkdayPanel.Name = "wkdayPanel";
            wkdayPanel.Size = new Size(314, 144);
            wkdayPanel.TabIndex = 195;
            // 
            // wkDayCutoffCheckbox
            // 
            _wkDayCutoffCheckbox.Anchor = AnchorStyles.None;
            _wkDayCutoffCheckbox.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _wkDayCutoffCheckbox.ChechedOffColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(132)), Conversions.ToInteger(Conversions.ToByte(135)), Conversions.ToInteger(Conversions.ToByte(140)));
            _wkDayCutoffCheckbox.Checked = true;
            _wkDayCutoffCheckbox.CheckedOnColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _wkDayCutoffCheckbox.ForeColor = Color.White;
            _wkDayCutoffCheckbox.Location = new Point(5, 43);
            _wkDayCutoffCheckbox.Name = "_wkDayCutoffCheckbox";
            _wkDayCutoffCheckbox.Size = new Size(20, 20);
            _wkDayCutoffCheckbox.TabIndex = 167;
            // 
            // Label23
            // 
            Label23.Anchor = AnchorStyles.None;
            Label23.AutoSize = true;
            Label23.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label23.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label23.Location = new Point(7, 2);
            Label23.Margin = new Padding(0);
            Label23.Name = "Label23";
            Label23.Size = new Size(99, 25);
            Label23.TabIndex = 179;
            Label23.Text = "Weekdays";
            Label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // wkDayCutOfftimePicker
            // 
            wkDayCutOfftimePicker.Anchor = AnchorStyles.None;
            wkDayCutOfftimePicker.CalendarFont = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            wkDayCutOfftimePicker.CalendarForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            wkDayCutOfftimePicker.CalendarTitleForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            wkDayCutOfftimePicker.CustomFormat = "hh:mm tt";
            wkDayCutOfftimePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            wkDayCutOfftimePicker.Format = DateTimePickerFormat.Custom;
            wkDayCutOfftimePicker.Location = new Point(163, 35);
            wkDayCutOfftimePicker.Name = "wkDayCutOfftimePicker";
            wkDayCutOfftimePicker.ShowUpDown = true;
            wkDayCutOfftimePicker.Size = new Size(105, 31);
            wkDayCutOfftimePicker.TabIndex = 173;
            // 
            // wkDayDayRateFeeday
            // 
            _wkDayDayRateFeeday.Anchor = AnchorStyles.None;
            _wkDayDayRateFeeday.BorderStyle = BorderStyle.FixedSingle;
            _wkDayDayRateFeeday.DecimalPlaces = 2;
            _wkDayDayRateFeeday.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _wkDayDayRateFeeday.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _wkDayDayRateFeeday.Location = new Point(164, 68);
            _wkDayDayRateFeeday.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            _wkDayDayRateFeeday.Name = "_wkDayDayRateFeeday";
            _wkDayDayRateFeeday.Size = new Size(105, 35);
            _wkDayDayRateFeeday.TabIndex = 175;
            _wkDayDayRateFeeday.TextAlign = HorizontalAlignment.Center;
            _wkDayDayRateFeeday.ThousandsSeparator = true;
            // 
            // wkDayNightRateUpDown
            // 
            wkDayNightRateUpDown.Anchor = AnchorStyles.None;
            wkDayNightRateUpDown.BorderStyle = BorderStyle.FixedSingle;
            wkDayNightRateUpDown.DecimalPlaces = 2;
            wkDayNightRateUpDown.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            wkDayNightRateUpDown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            wkDayNightRateUpDown.Location = new Point(164, 105);
            wkDayNightRateUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            wkDayNightRateUpDown.Name = "wkDayNightRateUpDown";
            wkDayNightRateUpDown.Size = new Size(105, 35);
            wkDayNightRateUpDown.TabIndex = 178;
            wkDayNightRateUpDown.TextAlign = HorizontalAlignment.Center;
            wkDayNightRateUpDown.ThousandsSeparator = true;
            // 
            // beforeLabel
            // 
            beforeLabel.Anchor = AnchorStyles.None;
            beforeLabel.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            beforeLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            beforeLabel.Location = new Point(37, 75);
            beforeLabel.Margin = new Padding(0);
            beforeLabel.Name = "beforeLabel";
            beforeLabel.Size = new Size(118, 26);
            beforeLabel.TabIndex = 176;
            beforeLabel.Text = "Day Rate:";
            beforeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label17
            // 
            Label17.Anchor = AnchorStyles.None;
            Label17.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label17.Location = new Point(18, 40);
            Label17.Margin = new Padding(0);
            Label17.Name = "Label17";
            Label17.Size = new Size(137, 25);
            Label17.TabIndex = 174;
            Label17.Text = "RV Cut off time:";
            Label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.None;
            Label6.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(37, 110);
            Label6.Margin = new Padding(0);
            Label6.Name = "Label6";
            Label6.Size = new Size(118, 28);
            Label6.TabIndex = 177;
            Label6.Text = "Night Rate:";
            Label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // wkEndPanel
            // 
            wkEndPanel.BackColor = Color.White;
            wkEndPanel.Controls.Add(_wkEndCutOffCheckbox);
            wkEndPanel.Controls.Add(Label24);
            wkEndPanel.Controls.Add(wkEndCutOffTimePicker);
            wkEndPanel.Controls.Add(_wkEndsDayNumericUpDown);
            wkEndPanel.Controls.Add(wkEndNightNumericUpDown);
            wkEndPanel.Controls.Add(Label27);
            wkEndPanel.Controls.Add(Label25);
            wkEndPanel.Controls.Add(Label26);
            wkEndPanel.Dock = DockStyle.Right;
            wkEndPanel.Location = new Point(320, 0);
            wkEndPanel.Name = "wkEndPanel";
            wkEndPanel.Size = new Size(300, 144);
            wkEndPanel.TabIndex = 194;
            // 
            // wkEndCutOffCheckbox
            // 
            _wkEndCutOffCheckbox.Anchor = AnchorStyles.None;
            _wkEndCutOffCheckbox.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _wkEndCutOffCheckbox.ChechedOffColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(132)), Conversions.ToInteger(Conversions.ToByte(135)), Conversions.ToInteger(Conversions.ToByte(140)));
            _wkEndCutOffCheckbox.Checked = true;
            _wkEndCutOffCheckbox.CheckedOnColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _wkEndCutOffCheckbox.ForeColor = Color.White;
            _wkEndCutOffCheckbox.Location = new Point(3, 43);
            _wkEndCutOffCheckbox.Name = "_wkEndCutOffCheckbox";
            _wkEndCutOffCheckbox.Size = new Size(20, 20);
            _wkEndCutOffCheckbox.TabIndex = 187;
            // 
            // Label24
            // 
            Label24.Anchor = AnchorStyles.None;
            Label24.AutoSize = true;
            Label24.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label24.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label24.Location = new Point(21, 2);
            Label24.Margin = new Padding(0);
            Label24.Name = "Label24";
            Label24.Size = new Size(100, 25);
            Label24.TabIndex = 186;
            Label24.Text = "Weekends";
            Label24.TextAlign = ContentAlignment.MiddleRight;
            // 
            // wkEndCutOffTimePicker
            // 
            wkEndCutOffTimePicker.Anchor = AnchorStyles.None;
            wkEndCutOffTimePicker.CalendarFont = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            wkEndCutOffTimePicker.CalendarForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            wkEndCutOffTimePicker.CalendarTitleForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            wkEndCutOffTimePicker.CustomFormat = "hh:mm tt";
            wkEndCutOffTimePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            wkEndCutOffTimePicker.Format = DateTimePickerFormat.Custom;
            wkEndCutOffTimePicker.Location = new Point(155, 34);
            wkEndCutOffTimePicker.Name = "wkEndCutOffTimePicker";
            wkEndCutOffTimePicker.ShowUpDown = true;
            wkEndCutOffTimePicker.Size = new Size(105, 31);
            wkEndCutOffTimePicker.TabIndex = 180;
            // 
            // wkEndsDayNumericUpDown
            // 
            _wkEndsDayNumericUpDown.Anchor = AnchorStyles.None;
            _wkEndsDayNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            _wkEndsDayNumericUpDown.DecimalPlaces = 2;
            _wkEndsDayNumericUpDown.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _wkEndsDayNumericUpDown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _wkEndsDayNumericUpDown.Location = new Point(154, 66);
            _wkEndsDayNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            _wkEndsDayNumericUpDown.Name = "_wkEndsDayNumericUpDown";
            _wkEndsDayNumericUpDown.Size = new Size(105, 35);
            _wkEndsDayNumericUpDown.TabIndex = 182;
            _wkEndsDayNumericUpDown.TextAlign = HorizontalAlignment.Center;
            _wkEndsDayNumericUpDown.ThousandsSeparator = true;
            // 
            // wkEndNightNumericUpDown
            // 
            wkEndNightNumericUpDown.Anchor = AnchorStyles.None;
            wkEndNightNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            wkEndNightNumericUpDown.DecimalPlaces = 2;
            wkEndNightNumericUpDown.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            wkEndNightNumericUpDown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            wkEndNightNumericUpDown.Location = new Point(155, 103);
            wkEndNightNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            wkEndNightNumericUpDown.Name = "wkEndNightNumericUpDown";
            wkEndNightNumericUpDown.Size = new Size(105, 35);
            wkEndNightNumericUpDown.TabIndex = 185;
            wkEndNightNumericUpDown.TextAlign = HorizontalAlignment.Center;
            wkEndNightNumericUpDown.ThousandsSeparator = true;
            // 
            // Label27
            // 
            Label27.Anchor = AnchorStyles.None;
            Label27.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label27.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label27.Location = new Point(27, 73);
            Label27.Margin = new Padding(0);
            Label27.Name = "Label27";
            Label27.Size = new Size(118, 26);
            Label27.TabIndex = 183;
            Label27.Text = "Day Rate:";
            Label27.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label25
            // 
            Label25.Anchor = AnchorStyles.None;
            Label25.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label25.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label25.Location = new Point(14, 40);
            Label25.Margin = new Padding(0);
            Label25.Name = "Label25";
            Label25.Size = new Size(137, 25);
            Label25.TabIndex = 181;
            Label25.Text = "RV Cut off time:";
            Label25.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label26
            // 
            Label26.Anchor = AnchorStyles.None;
            Label26.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label26.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label26.Location = new Point(28, 108);
            Label26.Margin = new Padding(0);
            Label26.Name = "Label26";
            Label26.Size = new Size(118, 28);
            Label26.TabIndex = 184;
            Label26.Text = "Night Rate:";
            Label26.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toRVDatePicker
            // 
            toRVDatePicker.Anchor = AnchorStyles.None;
            toRVDatePicker.BorderRadius = 1;
            toRVDatePicker.Color = Color.Teal;
            toRVDatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            toRVDatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            toRVDatePicker.DisabledColor = Color.Gray;
            toRVDatePicker.DisplayWeekNumbers = false;
            toRVDatePicker.DPHeight = 0;
            toRVDatePicker.DropDownAlign = LeftRightAlignment.Right;
            toRVDatePicker.Enabled = false;
            toRVDatePicker.FillDatePicker = false;
            toRVDatePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            toRVDatePicker.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            toRVDatePicker.Icon = (Image)resources.GetObject("toRVDatePicker.Icon");
            toRVDatePicker.IconColor = Color.Teal;
            toRVDatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            toRVDatePicker.Location = new Point(499, 272);
            toRVDatePicker.MinimumSize = new Size(180, 31);
            toRVDatePicker.Name = "toRVDatePicker";
            toRVDatePicker.Size = new Size(180, 31);
            toRVDatePicker.TabIndex = 183;
            // 
            // fromRVDatePicker
            // 
            fromRVDatePicker.Anchor = AnchorStyles.None;
            fromRVDatePicker.BorderRadius = 1;
            fromRVDatePicker.Color = Color.Teal;
            fromRVDatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            fromRVDatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            fromRVDatePicker.DisabledColor = Color.Gray;
            fromRVDatePicker.DisplayWeekNumbers = false;
            fromRVDatePicker.DPHeight = 0;
            fromRVDatePicker.DropDownAlign = LeftRightAlignment.Right;
            fromRVDatePicker.FillDatePicker = false;
            fromRVDatePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            fromRVDatePicker.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            fromRVDatePicker.Icon = (Image)resources.GetObject("fromRVDatePicker.Icon");
            fromRVDatePicker.IconColor = Color.Teal;
            fromRVDatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            fromRVDatePicker.Location = new Point(173, 272);
            fromRVDatePicker.MinimumSize = new Size(180, 30);
            fromRVDatePicker.Name = "fromRVDatePicker";
            fromRVDatePicker.Size = new Size(180, 31);
            fromRVDatePicker.TabIndex = 181;
            // 
            // Label29
            // 
            Label29.Anchor = AnchorStyles.None;
            Label29.AutoSize = true;
            Label29.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label29.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label29.Location = new Point(375, 276);
            Label29.Margin = new Padding(0);
            Label29.Name = "Label29";
            Label29.Size = new Size(128, 25);
            Label29.TabIndex = 182;
            Label29.Text = "End rate date:";
            Label29.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label31
            // 
            Label31.Anchor = AnchorStyles.None;
            Label31.AutoSize = true;
            Label31.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label31.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label31.Location = new Point(15, 276);
            Label31.Margin = new Padding(0);
            Label31.Name = "Label31";
            Label31.Size = new Size(161, 25);
            Label31.TabIndex = 180;
            Label31.Text = "Starting rate date:";
            Label31.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label32
            // 
            Label32.Anchor = AnchorStyles.None;
            Label32.AutoSize = true;
            Label32.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label32.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label32.Location = new Point(31, 245);
            Label32.Margin = new Padding(0);
            Label32.Name = "Label32";
            Label32.Size = new Size(50, 25);
            Label32.TabIndex = 192;
            Label32.Text = "Port:";
            Label32.TextAlign = ContentAlignment.MiddleRight;
            // 
            // portsRvDropdown
            // 
            portsRvDropdown.Anchor = AnchorStyles.None;
            portsRvDropdown.BackColor = Color.Transparent;
            portsRvDropdown.BorderRadius = 3;
            portsRvDropdown.Color = Color.Teal;
            portsRvDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            portsRvDropdown.DisabledColor = Color.Gray;
            portsRvDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            portsRvDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            portsRvDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            portsRvDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            portsRvDropdown.FillDropDown = false;
            portsRvDropdown.FillIndicator = true;
            portsRvDropdown.FlatStyle = FlatStyle.Flat;
            portsRvDropdown.Font = new Font("Arial", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            portsRvDropdown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            portsRvDropdown.FormattingEnabled = true;
            portsRvDropdown.Icon = null;
            portsRvDropdown.IndicatorColor = Color.Teal;
            portsRvDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            portsRvDropdown.ItemBackColor = Color.White;
            portsRvDropdown.ItemBorderColor = Color.White;
            portsRvDropdown.ItemForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            portsRvDropdown.ItemHeight = 27;
            portsRvDropdown.ItemHighLightColor = Color.Gray;
            portsRvDropdown.Location = new Point(84, 237);
            portsRvDropdown.MaxDropDownItems = 50;
            portsRvDropdown.Name = "portsRvDropdown";
            portsRvDropdown.Size = new Size(423, 33);
            portsRvDropdown.TabIndex = 191;
            portsRvDropdown.Text = null;
            // 
            // closeFlatButton
            // 
            _closeFlatButton.Active = false;
            _closeFlatButton.Activecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeFlatButton.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.BackgroundImageLayout = ImageLayout.Stretch;
            _closeFlatButton.BorderRadius = 0;
            _closeFlatButton.ButtonText = "🗙";
            _closeFlatButton.Cursor = Cursors.Hand;
            _closeFlatButton.DisabledColor = Color.Gray;
            _closeFlatButton.Iconcolor = Color.Transparent;
            _closeFlatButton.Iconimage = null;
            _closeFlatButton.Iconimage_right = null;
            _closeFlatButton.Iconimage_right_Selected = null;
            _closeFlatButton.Iconimage_Selected = null;
            _closeFlatButton.IconMarginLeft = 0;
            _closeFlatButton.IconMarginRight = 0;
            _closeFlatButton.IconRightVisible = true;
            _closeFlatButton.IconRightZoom = 0d;
            _closeFlatButton.IconVisible = true;
            _closeFlatButton.IconZoom = 90.0d;
            _closeFlatButton.IsTab = false;
            _closeFlatButton.Location = new Point(674, 0);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(43, 41);
            _closeFlatButton.TabIndex = 166;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // FrmAddEditServices
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(717, 570);
            Controls.Add(buttonsPanel);
            Controls.Add(_closeFlatButton);
            Controls.Add(ratePages);
            Controls.Add(Label2);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label1);
            Controls.Add(_Label8);
            Controls.Add(_servTypeDropdown);
            Controls.Add(Label4);
            Controls.Add(truckNameDropdown6);
            Controls.Add(Label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddEditServices";
            Text = "FrmAddEditServices";
            buttonsPanel.ResumeLayout(false);
            ratePages.ResumeLayout(false);
            drayageTab.ResumeLayout(false);
            drayageTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rateNumericUpDown).EndInit();
            fscTab.ResumeLayout(false);
            fscTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rateFSCUpDown).EndInit();
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            Panel4.ResumeLayout(false);
            Panel4.PerformLayout();
            Panel1.ResumeLayout(false);
            wkdayPanel.ResumeLayout(false);
            wkdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_wkDayDayRateFeeday).EndInit();
            ((System.ComponentModel.ISupportInitialize)wkDayNightRateUpDown).EndInit();
            wkEndPanel.ResumeLayout(false);
            wkEndPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_wkEndsDayNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)wkEndNightNumericUpDown).EndInit();
            Load += new EventHandler(FrmAddEditServices_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label _Label8;

        internal Label Label8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label8 != null)
                {
                    _Label8.Click -= Label8_Click;
                }

                _Label8 = value;
                if (_Label8 != null)
                {
                    _Label8.Click += Label8_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDropdown _servTypeDropdown;

        internal Bunifu.UI.WinForms.BunifuDropdown servTypeDropdown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _servTypeDropdown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_servTypeDropdown != null)
                {
                    _servTypeDropdown.SelectedIndexChanged -= servTypeDropdown_SelectedIndexChanged;
                }

                _servTypeDropdown = value;
                if (_servTypeDropdown != null)
                {
                    _servTypeDropdown.SelectedIndexChanged += servTypeDropdown_SelectedIndexChanged;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuDropdown truckNameDropdown6;
        internal Label Label3;
        internal Label Label4;
        internal TableLayoutPanel buttonsPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _saveButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton saveButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _saveButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_saveButton != null)
                {
                    _saveButton.Click -= saveButton_Click;
                }

                _saveButton = value;
                if (_saveButton != null)
                {
                    _saveButton.Click += saveButton_Click;
                }
            }
        }

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
                    _cancelButton.Click -= cancelButton_Click;
                }

                _cancelButton = value;
                if (_cancelButton != null)
                {
                    _cancelButton.Click += cancelButton_Click;
                }
            }
        }

        internal Label Label1;
        internal Label Label2;
        internal Label Label9;
        internal Label Label10;
        internal Bunifu.UI.WinForms.BunifuPages ratePages;
        internal TabPage drayageTab;
        internal TabPage fscTab;
        internal Bunifu.UI.WinForms.BunifuRadioButton multipleEmtyRadioButton;
        internal Bunifu.UI.WinForms.BunifuDropdown toDropdown;
        internal Label Label12;
        internal Label Label14;
        internal Bunifu.UI.WinForms.BunifuDropdown fromDropdown;
        internal Label Label11;
        internal NumericUpDown rateFSCUpDown;
        internal Label percentLabel;
        internal Label Label15;
        internal Label Label16;
        private Bunifu.Framework.UI.BunifuFlatButton _closeFlatButton;

        internal Bunifu.Framework.UI.BunifuFlatButton closeFlatButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _closeFlatButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_closeFlatButton != null)
                {
                    _closeFlatButton.Click -= closeBtn_Click;
                }

                _closeFlatButton = value;
                if (_closeFlatButton != null)
                {
                    _closeFlatButton.Click += closeBtn_Click;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuRadioButton multLoadRadioButton;
        internal Label Label7;
        internal Label Label18;
        internal Bunifu.UI.WinForms.BunifuRadioButton singleEmptyRadioButton;
        internal Label Label19;
        internal Bunifu.UI.WinForms.BunifuDatePicker toDatePicker;
        internal Label Label20;
        internal Bunifu.UI.WinForms.BunifuDatePicker fromDatePicker;
        internal Bunifu.UI.WinForms.BunifuRadioButton singleLoadsRadioButton2;
        internal Label Label5;
        internal NumericUpDown rateNumericUpDown;
        internal Label Label21;
        internal Bunifu.UI.WinForms.BunifuRadioButton transfersRadioButton;
        internal Label Label13;
        internal Bunifu.UI.WinForms.BunifuRadioButton deadCallRadioButton;
        internal Label Label22;
        internal TabPage TabPage1;
        private Bunifu.UI.WinForms.BunifuRadioButton _diffRateRadioButton;

        internal Bunifu.UI.WinForms.BunifuRadioButton diffRateRadioButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _diffRateRadioButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_diffRateRadioButton != null)
                {
                    _diffRateRadioButton.CheckedChanged -= diffRateRadioButton_Click;
                }

                _diffRateRadioButton = value;
                if (_diffRateRadioButton != null)
                {
                    _diffRateRadioButton.CheckedChanged += diffRateRadioButton_Click;
                }
            }
        }

        internal Label Label28;
        private Bunifu.UI.WinForms.BunifuRadioButton _sameRateRadioButton;

        internal Bunifu.UI.WinForms.BunifuRadioButton sameRateRadioButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sameRateRadioButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sameRateRadioButton != null)
                {
                    _sameRateRadioButton.CheckedChanged -= BunifuRadioButton3_Click;
                }

                _sameRateRadioButton = value;
                if (_sameRateRadioButton != null)
                {
                    _sameRateRadioButton.CheckedChanged += BunifuRadioButton3_Click;
                }
            }
        }

        internal Label Label30;
        internal Label Label23;
        internal DateTimePicker wkDayCutOfftimePicker;
        internal NumericUpDown wkDayNightRateUpDown;
        internal Label Label17;
        internal Label Label6;
        internal Label beforeLabel;
        private NumericUpDown _wkDayDayRateFeeday;

        internal NumericUpDown wkDayDayRateFeeday
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _wkDayDayRateFeeday;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_wkDayDayRateFeeday != null)
                {
                    _wkDayDayRateFeeday.ValueChanged -= wkDayDayRateFeeday_ValueChanged;
                }

                _wkDayDayRateFeeday = value;
                if (_wkDayDayRateFeeday != null)
                {
                    _wkDayDayRateFeeday.ValueChanged += wkDayDayRateFeeday_ValueChanged;
                }
            }
        }

        internal Label Label24;
        internal DateTimePicker wkEndCutOffTimePicker;
        internal NumericUpDown wkEndNightNumericUpDown;
        internal Label Label25;
        internal Label Label26;
        internal Label Label27;
        private NumericUpDown _wkEndsDayNumericUpDown;

        internal NumericUpDown wkEndsDayNumericUpDown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _wkEndsDayNumericUpDown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_wkEndsDayNumericUpDown != null)
                {
                    _wkEndsDayNumericUpDown.ValueChanged -= wkEndsDayNumericUpDown_ValueChanged;
                }

                _wkEndsDayNumericUpDown = value;
                if (_wkEndsDayNumericUpDown != null)
                {
                    _wkEndsDayNumericUpDown.ValueChanged += wkEndsDayNumericUpDown_ValueChanged;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuDatePicker toRVDatePicker;
        internal Bunifu.UI.WinForms.BunifuDatePicker fromRVDatePicker;
        internal Label Label29;
        internal Label Label31;
        internal Label Label32;
        internal Bunifu.UI.WinForms.BunifuDropdown portsRvDropdown;
        internal Panel Panel4;
        internal Panel Panel1;
        internal Panel wkdayPanel;
        internal Panel wkEndPanel;
        internal Bunifu.UI.WinForms.BunifuDropdown rvRateTypeDropdown;
        internal Label Label33;
        private Bunifu.Framework.UI.BunifuCheckbox _wkDayCutoffCheckbox;

        internal Bunifu.Framework.UI.BunifuCheckbox wkDayCutoffCheckbox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _wkDayCutoffCheckbox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_wkDayCutoffCheckbox != null)
                {
                    _wkDayCutoffCheckbox.OnChange -= wkDayCutoffCheckbox_OnChange;
                }

                _wkDayCutoffCheckbox = value;
                if (_wkDayCutoffCheckbox != null)
                {
                    _wkDayCutoffCheckbox.OnChange += wkDayCutoffCheckbox_OnChange;
                }
            }
        }

        private Bunifu.Framework.UI.BunifuCheckbox _wkEndCutOffCheckbox;

        internal Bunifu.Framework.UI.BunifuCheckbox wkEndCutOffCheckbox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _wkEndCutOffCheckbox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_wkEndCutOffCheckbox != null)
                {
                    _wkEndCutOffCheckbox.OnChange -= wkEndCutOffCheckbox_OnChange;
                }

                _wkEndCutOffCheckbox = value;
                if (_wkEndCutOffCheckbox != null)
                {
                    _wkEndCutOffCheckbox.OnChange += wkEndCutOffCheckbox_OnChange;
                }
            }
        }

        private Bunifu.Framework.UI.BunifuCheckbox _endDateCheckbox;

        internal Bunifu.Framework.UI.BunifuCheckbox endDateCheckbox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _endDateCheckbox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_endDateCheckbox != null)
                {
                    _endDateCheckbox.OnChange -= endDateCheckbox_OnChange;
                }

                _endDateCheckbox = value;
                if (_endDateCheckbox != null)
                {
                    _endDateCheckbox.OnChange += endDateCheckbox_OnChange;
                }
            }
        }

        private Bunifu.ToggleSwitch.BunifuToggleSwitch _toDateToggleSwitch;

        internal Bunifu.ToggleSwitch.BunifuToggleSwitch toDateToggleSwitch
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _toDateToggleSwitch;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_toDateToggleSwitch != null)
                {
                    _toDateToggleSwitch.OnValuechange -= toDateToggleSwitch_OnValuechange;
                }

                _toDateToggleSwitch = value;
                if (_toDateToggleSwitch != null)
                {
                    _toDateToggleSwitch.OnValuechange += toDateToggleSwitch_OnValuechange;
                }
            }
        }
    }
}