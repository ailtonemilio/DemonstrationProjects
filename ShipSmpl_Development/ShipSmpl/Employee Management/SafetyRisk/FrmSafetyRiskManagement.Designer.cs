using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmSafetyRiskManagement : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSafetyRiskManagement));
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            Label2 = new Label();
            GroupBox1 = new GroupBox();
            _btnSearch = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSearch.Click += new EventHandler(btnSearch_Click);
            endDateTimePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            yardComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            startDateTimePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            _btnPrintReport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnPrintReport.Click += new EventHandler(btnPrintReport_Click);
            typeComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            BunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            rblHoursPerSite = new Bunifu.UI.WinForms.BunifuRadioButton();
            rblHoursPerSiteType = new Bunifu.UI.WinForms.BunifuRadioButton();
            rblHoursPerEmployeeSite = new Bunifu.UI.WinForms.BunifuRadioButton();
            Label1 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            dgvEmployees = new Bunifu.UI.WinForms.BunifuDataGridView();
            BunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            lblTotHours = new Bunifu.UI.WinForms.BunifuLabel();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label6 = new Label();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Dock = DockStyle.Top;
            Label2.Font = new Font("Microsoft Sans Serif", 22.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(0, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(1099, 41);
            Label2.TabIndex = 3;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(_btnSearch);
            GroupBox1.Controls.Add(endDateTimePicker);
            GroupBox1.Controls.Add(yardComboBox);
            GroupBox1.Controls.Add(startDateTimePicker);
            GroupBox1.Controls.Add(_btnPrintReport);
            GroupBox1.Controls.Add(typeComboBox);
            GroupBox1.Controls.Add(BunifuLabel3);
            GroupBox1.Controls.Add(BunifuLabel2);
            GroupBox1.Controls.Add(BunifuLabel1);
            GroupBox1.Controls.Add(rblHoursPerSite);
            GroupBox1.Controls.Add(rblHoursPerSiteType);
            GroupBox1.Controls.Add(rblHoursPerEmployeeSite);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(Label4);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            GroupBox1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            GroupBox1.Location = new Point(57, 90);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(1030, 107);
            GroupBox1.TabIndex = 7;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "1 - Filters";
            // 
            // btnSearch
            // 
            _btnSearch.AllowToggling = false;
            _btnSearch.AnimationSpeed = 200;
            _btnSearch.AutoGenerateColors = false;
            _btnSearch.BackColor = Color.Transparent;
            _btnSearch.BackColor1 = Color.Teal;
            _btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            _btnSearch.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnSearch.ButtonText = "Search";
            _btnSearch.ButtonTextMarginLeft = 0;
            _btnSearch.ColorContrastOnClick = 45;
            _btnSearch.ColorContrastOnHover = 45;
            _btnSearch.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _btnSearch.CustomizableEdges = BorderEdges3;
            _btnSearch.DialogResult = DialogResult.None;
            _btnSearch.DisabledBorderColor = Color.Empty;
            _btnSearch.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSearch.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSearch.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSearch.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSearch.ForeColor = Color.White;
            _btnSearch.IconLeftCursor = Cursors.Hand;
            _btnSearch.IconMarginLeft = 11;
            _btnSearch.IconPadding = 10;
            _btnSearch.IconRightCursor = Cursors.Hand;
            _btnSearch.IdleBorderColor = Color.Teal;
            _btnSearch.IdleBorderRadius = 3;
            _btnSearch.IdleBorderThickness = 1;
            _btnSearch.IdleFillColor = Color.Teal;
            _btnSearch.IdleIconLeftImage = null;
            _btnSearch.IdleIconRightImage = null;
            _btnSearch.IndicateFocus = true;
            _btnSearch.Location = new Point(900, 11);
            _btnSearch.Name = "_btnSearch";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _btnSearch.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Teal;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _btnSearch.OnPressedState = StateProperties6;
            _btnSearch.Size = new Size(128, 38);
            _btnSearch.TabIndex = 68;
            _btnSearch.TextAlign = ContentAlignment.MiddleCenter;
            _btnSearch.TextMarginLeft = 0;
            _btnSearch.UseDefaultRadiusAndThickness = true;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.BorderRadius = 3;
            endDateTimePicker.Color = Color.Teal;
            endDateTimePicker.CustomFormat = "MMM dd, yyyy";
            endDateTimePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            endDateTimePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            endDateTimePicker.DisabledColor = Color.Gray;
            endDateTimePicker.DisplayWeekNumbers = false;
            endDateTimePicker.DPHeight = 0;
            endDateTimePicker.DropDownAlign = LeftRightAlignment.Right;
            endDateTimePicker.FillDatePicker = false;
            endDateTimePicker.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            endDateTimePicker.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.Icon = (Image)resources.GetObject("endDateTimePicker.Icon");
            endDateTimePicker.IconColor = Color.Teal;
            endDateTimePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            endDateTimePicker.Location = new Point(347, 65);
            endDateTimePicker.MinimumSize = new Size(214, 34);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(214, 34);
            endDateTimePicker.TabIndex = 123;
            // 
            // yardComboBox
            // 
            yardComboBox.BackColor = Color.Snow;
            yardComboBox.BorderRadius = 3;
            yardComboBox.Color = Color.Teal;
            yardComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            yardComboBox.DisabledColor = Color.Gray;
            yardComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            yardComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            yardComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yardComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            yardComboBox.FillDropDown = false;
            yardComboBox.FillIndicator = true;
            yardComboBox.FlatStyle = FlatStyle.Flat;
            yardComboBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            yardComboBox.ForeColor = SystemColors.ControlDarkDark;
            yardComboBox.FormattingEnabled = true;
            yardComboBox.Icon = null;
            yardComboBox.IndicatorColor = Color.Teal;
            yardComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            yardComboBox.ItemBackColor = Color.White;
            yardComboBox.ItemBorderColor = Color.White;
            yardComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            yardComboBox.ItemHeight = 28;
            yardComboBox.ItemHighLightColor = Color.Gray;
            yardComboBox.Items.AddRange(new object[] { "All", "Ewen", "Lindsey", "Remote" });
            yardComboBox.Location = new Point(92, 65);
            yardComboBox.MaxDropDownItems = 50;
            yardComboBox.Name = "yardComboBox";
            yardComboBox.Size = new Size(162, 34);
            yardComboBox.TabIndex = 122;
            yardComboBox.Text = null;
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.BorderRadius = 3;
            startDateTimePicker.Color = Color.Teal;
            startDateTimePicker.CustomFormat = "MMM dd, yyyy";
            startDateTimePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            startDateTimePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            startDateTimePicker.DisabledColor = Color.Gray;
            startDateTimePicker.DisplayWeekNumbers = false;
            startDateTimePicker.DPHeight = 0;
            startDateTimePicker.DropDownAlign = LeftRightAlignment.Right;
            startDateTimePicker.FillDatePicker = false;
            startDateTimePicker.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            startDateTimePicker.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.Icon = (Image)resources.GetObject("startDateTimePicker.Icon");
            startDateTimePicker.IconColor = Color.Teal;
            startDateTimePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            startDateTimePicker.Location = new Point(347, 25);
            startDateTimePicker.MinimumSize = new Size(214, 34);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(214, 34);
            startDateTimePicker.TabIndex = 122;
            // 
            // btnPrintReport
            // 
            _btnPrintReport.AllowToggling = false;
            _btnPrintReport.AnimationSpeed = 200;
            _btnPrintReport.AutoGenerateColors = false;
            _btnPrintReport.BackColor = Color.Transparent;
            _btnPrintReport.BackColor1 = Color.DodgerBlue;
            _btnPrintReport.BackgroundImage = (Image)resources.GetObject("btnPrintReport.BackgroundImage");
            _btnPrintReport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnPrintReport.ButtonText = "Print";
            _btnPrintReport.ButtonTextMarginLeft = 0;
            _btnPrintReport.ColorContrastOnClick = 45;
            _btnPrintReport.ColorContrastOnHover = 45;
            _btnPrintReport.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _btnPrintReport.CustomizableEdges = BorderEdges4;
            _btnPrintReport.DialogResult = DialogResult.None;
            _btnPrintReport.DisabledBorderColor = Color.Empty;
            _btnPrintReport.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnPrintReport.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnPrintReport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnPrintReport.Font = new Font("Segoe UI Semibold", 12.0f);
            _btnPrintReport.ForeColor = Color.White;
            _btnPrintReport.IconLeftCursor = Cursors.Hand;
            _btnPrintReport.IconMarginLeft = 11;
            _btnPrintReport.IconPadding = 10;
            _btnPrintReport.IconRightCursor = Cursors.Hand;
            _btnPrintReport.IdleBorderColor = Color.DodgerBlue;
            _btnPrintReport.IdleBorderRadius = 3;
            _btnPrintReport.IdleBorderThickness = 1;
            _btnPrintReport.IdleFillColor = Color.DodgerBlue;
            _btnPrintReport.IdleIconLeftImage = null;
            _btnPrintReport.IdleIconRightImage = null;
            _btnPrintReport.IndicateFocus = false;
            _btnPrintReport.Location = new Point(900, 57);
            _btnPrintReport.Name = "_btnPrintReport";
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _btnPrintReport.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _btnPrintReport.OnPressedState = StateProperties8;
            _btnPrintReport.Size = new Size(128, 38);
            _btnPrintReport.TabIndex = 61;
            _btnPrintReport.TextAlign = ContentAlignment.MiddleCenter;
            _btnPrintReport.TextMarginLeft = 0;
            _btnPrintReport.UseDefaultRadiusAndThickness = true;
            // 
            // typeComboBox
            // 
            typeComboBox.BackColor = Color.Snow;
            typeComboBox.BorderRadius = 3;
            typeComboBox.Color = Color.Teal;
            typeComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            typeComboBox.DisabledColor = Color.Gray;
            typeComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            typeComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            typeComboBox.FillDropDown = false;
            typeComboBox.FillIndicator = true;
            typeComboBox.FlatStyle = FlatStyle.Flat;
            typeComboBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            typeComboBox.ForeColor = SystemColors.ControlDarkDark;
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Icon = null;
            typeComboBox.IndicatorColor = Color.Teal;
            typeComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            typeComboBox.ItemBackColor = Color.White;
            typeComboBox.ItemBorderColor = Color.White;
            typeComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            typeComboBox.ItemHeight = 28;
            typeComboBox.ItemHighLightColor = Color.Gray;
            typeComboBox.Items.AddRange(new object[] { "All", "Crew", "Office" });
            typeComboBox.Location = new Point(92, 25);
            typeComboBox.MaxDropDownItems = 50;
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(162, 34);
            typeComboBox.TabIndex = 120;
            typeComboBox.Text = null;
            // 
            // BunifuLabel3
            // 
            BunifuLabel3.AutoEllipsis = false;
            BunifuLabel3.CursorType = null;
            BunifuLabel3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel3.Location = new Point(621, 78);
            BunifuLabel3.Name = "BunifuLabel3";
            BunifuLabel3.RightToLeft = RightToLeft.No;
            BunifuLabel3.Size = new Size(264, 24);
            BunifuLabel3.TabIndex = 25;
            BunifuLabel3.Text = "Hours per Employee and Site";
            BunifuLabel3.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel2
            // 
            BunifuLabel2.AutoEllipsis = false;
            BunifuLabel2.CursorType = null;
            BunifuLabel2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel2.Location = new Point(621, 50);
            BunifuLabel2.Name = "BunifuLabel2";
            BunifuLabel2.RightToLeft = RightToLeft.No;
            BunifuLabel2.Size = new Size(229, 24);
            BunifuLabel2.TabIndex = 24;
            BunifuLabel2.Text = "Hours per Yard and Type";
            BunifuLabel2.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel1
            // 
            BunifuLabel1.AutoEllipsis = false;
            BunifuLabel1.CursorType = null;
            BunifuLabel1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel1.Location = new Point(621, 22);
            BunifuLabel1.Name = "BunifuLabel1";
            BunifuLabel1.RightToLeft = RightToLeft.No;
            BunifuLabel1.Size = new Size(139, 24);
            BunifuLabel1.TabIndex = 23;
            BunifuLabel1.Text = "Hours per Yard";
            BunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // rblHoursPerSite
            // 
            rblHoursPerSite.Checked = false;
            rblHoursPerSite.Location = new Point(590, 22);
            rblHoursPerSite.Name = "rblHoursPerSite";
            rblHoursPerSite.OutlineColor = Color.Teal;
            rblHoursPerSite.RadioColor = Color.Teal;
            rblHoursPerSite.Size = new Size(25, 25);
            rblHoursPerSite.TabIndex = 22;
            rblHoursPerSite.Text = null;
            // 
            // rblHoursPerSiteType
            // 
            rblHoursPerSiteType.Checked = false;
            rblHoursPerSiteType.Location = new Point(590, 50);
            rblHoursPerSiteType.Name = "rblHoursPerSiteType";
            rblHoursPerSiteType.OutlineColor = Color.Teal;
            rblHoursPerSiteType.RadioColor = Color.Teal;
            rblHoursPerSiteType.Size = new Size(25, 25);
            rblHoursPerSiteType.TabIndex = 21;
            rblHoursPerSiteType.Text = null;
            // 
            // rblHoursPerEmployeeSite
            // 
            rblHoursPerEmployeeSite.Checked = true;
            rblHoursPerEmployeeSite.Location = new Point(590, 76);
            rblHoursPerEmployeeSite.Name = "rblHoursPerEmployeeSite";
            rblHoursPerEmployeeSite.OutlineColor = Color.Teal;
            rblHoursPerEmployeeSite.RadioColor = Color.Teal;
            rblHoursPerEmployeeSite.Size = new Size(25, 25);
            rblHoursPerEmployeeSite.TabIndex = 20;
            rblHoursPerEmployeeSite.Text = null;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(260, 71);
            Label1.Name = "Label1";
            Label1.Size = new Size(93, 24);
            Label1.TabIndex = 18;
            Label1.Text = "End Date:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label5.Location = new Point(260, 33);
            Label5.Name = "Label5";
            Label5.Size = new Size(94, 24);
            Label5.TabIndex = 11;
            Label5.Text = "Start Date:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label4.Location = new Point(39, 73);
            Label4.Name = "Label4";
            Label4.Size = new Size(54, 24);
            Label4.TabIndex = 9;
            Label4.Text = "Yard:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(39, 33);
            Label3.Name = "Label3";
            Label3.Size = new Size(58, 24);
            Label3.TabIndex = 7;
            Label3.Text = "Type:";
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowCustomTheming = true;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToResizeColumns = false;
            dgvEmployees.AllowUserToResizeRows = false;
            DataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewCellStyle4.ForeColor = Color.Black;
            DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvEmployees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.BorderStyle = BorderStyle.None;
            dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            dgvEmployees.ColumnHeadersHeight = 40;
            dgvEmployees.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            dgvEmployees.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvEmployees.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvEmployees.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            dgvEmployees.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvEmployees.CurrentTheme.BackColor = Color.Snow;
            dgvEmployees.CurrentTheme.GridColor = Color.Gray;
            dgvEmployees.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvEmployees.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            dgvEmployees.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvEmployees.CurrentTheme.Name = null;
            dgvEmployees.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            dgvEmployees.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvEmployees.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvEmployees.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            dgvEmployees.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle6.ForeColor = Color.Black;
            DataGridViewCellStyle6.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle6.SelectionForeColor = Color.Black;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = DataGridViewCellStyle6;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.GridColor = Color.Gray;
            dgvEmployees.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvEmployees.HeaderBgColor = Color.Empty;
            dgvEmployees.HeaderForeColor = Color.White;
            dgvEmployees.Location = new Point(57, 212);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgvEmployees.RowTemplate.Height = 40;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1024, 422);
            dgvEmployees.TabIndex = 58;
            dgvEmployees.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // BunifuLabel4
            // 
            BunifuLabel4.AutoEllipsis = false;
            BunifuLabel4.CursorType = null;
            BunifuLabel4.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel4.Location = new Point(760, 662);
            BunifuLabel4.Name = "BunifuLabel4";
            BunifuLabel4.RightToLeft = RightToLeft.No;
            BunifuLabel4.Size = new Size(111, 24);
            BunifuLabel4.TabIndex = 26;
            BunifuLabel4.Text = "Total hours:";
            BunifuLabel4.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTotHours
            // 
            lblTotHours.AutoEllipsis = false;
            lblTotHours.CursorType = null;
            lblTotHours.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotHours.Location = new Point(870, 662);
            lblTotHours.Name = "lblTotHours";
            lblTotHours.RightToLeft = RightToLeft.No;
            lblTotHours.Size = new Size(86, 24);
            lblTotHours.TabIndex = 59;
            lblTotHours.Text = "TotHours";
            lblTotHours.TextAlignment = ContentAlignment.TopLeft;
            lblTotHours.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(1057, -3);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(40, 41);
            _closeLabel.TabIndex = 142;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label6.Location = new Point(47, 58);
            Label6.Name = "Label6";
            Label6.Size = new Size(163, 26);
            Label6.TabIndex = 143;
            Label6.Text = "Hours Worked";
            // 
            // FrmSafetyRiskManagement
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1099, 705);
            ControlBox = false;
            Controls.Add(Label6);
            Controls.Add(_closeLabel);
            Controls.Add(lblTotHours);
            Controls.Add(BunifuLabel4);
            Controls.Add(dgvEmployees);
            Controls.Add(GroupBox1);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSafetyRiskManagement";
            StartPosition = FormStartPosition.CenterScreen;
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            Load += new EventHandler(FrmSafetyRiskManagement_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label2;
        internal GroupBox GroupBox1;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label Label1;
        internal Bunifu.UI.WinForms.BunifuRadioButton rblHoursPerSite;
        internal Bunifu.UI.WinForms.BunifuRadioButton rblHoursPerSiteType;
        internal Bunifu.UI.WinForms.BunifuRadioButton rblHoursPerEmployeeSite;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel3;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel2;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel1;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvEmployees;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel4;
        internal Bunifu.UI.WinForms.BunifuLabel lblTotHours;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnPrintReport;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPrintReport
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnPrintReport;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnPrintReport != null)
                {
                    _btnPrintReport.Click -= btnPrintReport_Click;
                }

                _btnPrintReport = value;
                if (_btnPrintReport != null)
                {
                    _btnPrintReport.Click += btnPrintReport_Click;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuDropdown typeComboBox;
        internal Bunifu.UI.WinForms.BunifuDropdown yardComboBox;
        internal Bunifu.UI.WinForms.BunifuDatePicker startDateTimePicker;
        internal Bunifu.UI.WinForms.BunifuDatePicker endDateTimePicker;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnSearch;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSearch
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSearch;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSearch != null)
                {
                    _btnSearch.Click -= btnSearch_Click;
                }

                _btnSearch = value;
                if (_btnSearch != null)
                {
                    _btnSearch.Click += btnSearch_Click;
                }
            }
        }

        private Label _closeLabel;

        internal Label closeLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _closeLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_closeLabel != null)
                {
                    _closeLabel.Click -= closeLabel_Click;
                }

                _closeLabel = value;
                if (_closeLabel != null)
                {
                    _closeLabel.Click += closeLabel_Click;
                }
            }
        }

        internal Label Label6;
    }
}