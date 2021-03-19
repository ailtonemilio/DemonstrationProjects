using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmVesselVoyageAddEdit : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVesselVoyageAddEdit));
            var BorderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties19 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties20 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSave.Click += new EventHandler(btnSave_Click);
            TableLayoutPanel1 = new TableLayoutPanel();
            _cboVessel = new ComboBox();
            _cboVessel.KeyPress += new KeyPressEventHandler(cboVessel_KeyPress);
            _cboVessel.SelectedValueChanged += new EventHandler(cboVessel_SelectedValueChanged);
            VesselBindingSource = new BindingSource(components);
            _cboVoyageStatus = new ComboBox();
            _cboVoyageStatus.SelectedValueChanged += new EventHandler(cboVoyageStatus_SelectedValueChanged);
            VesselVoyageStatusBindingSource = new BindingSource(components);
            BunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            _dtpETD = new Bunifu.UI.WinForms.BunifuDatePicker();
            _dtpETD.ValueChanged += new EventHandler(dtpETD_ValueChanged);
            _dtpETA = new Bunifu.UI.WinForms.BunifuDatePicker();
            _dtpETA.ValueChanged += new EventHandler(dtpETA_ValueChanged);
            _cboCompany = new ComboBox();
            _cboCompany.SelectedValueChanged += new EventHandler(cboCompany_SelectedValueChanged);
            CompaniesNameBindingSource = new BindingSource(components);
            BunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            _dtpLRD = new Bunifu.UI.WinForms.BunifuDatePicker();
            _dtpLRD.ValueChanged += new EventHandler(dtpLRD_ValueChanged);
            _dtpERD = new Bunifu.UI.WinForms.BunifuDatePicker();
            _dtpERD.ValueChanged += new EventHandler(dtpERD_ValueChanged);
            _btnCancelETA = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancelETA.Click += new EventHandler(btnCancelETA_Click);
            _btnCancelLRD = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancelLRD.Click += new EventHandler(btnCancelLRD_Click);
            _btnCancelERD = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancelERD.Click += new EventHandler(btnCancelERD_Click);
            BunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            _txtVoyageNumber = new TextBox();
            _txtVoyageNumber.KeyPress += new KeyPressEventHandler(txtVoyageNumber_KeyPress);
            _btnCancelETD = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancelETD.Click += new EventHandler(btnCancelETD_Click);
            ckbActive = new CheckBox();
            BunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            txtCity = new TextBox();
            BunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            _cboCountry = new ComboBox();
            _cboCountry.SelectedValueChanged += new EventHandler(cboCountry_SelectedValueChanged);
            CountryBindingSource = new BindingSource(components);
            lblTitleVessel = new Bunifu.UI.WinForms.BunifuLabel();
            _btnClose = new Label();
            _btnClose.Click += new EventHandler(btnClose_Click);
            Label2 = new Label();
            _pbxRefreshComboBox = new PictureBox();
            _pbxRefreshComboBox.Click += new EventHandler(pbxRefreshComboBox_Click);
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VesselBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VesselVoyageStatusBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CompaniesNameBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_pbxRefreshComboBox).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            _btnSave.AllowToggling = false;
            _btnSave.AnimationSpeed = 200;
            _btnSave.AutoGenerateColors = false;
            _btnSave.BackColor = Color.Transparent;
            _btnSave.BackColor1 = Color.Teal;
            _btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            _btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnSave.ButtonText = "Save";
            _btnSave.ButtonTextMarginLeft = 0;
            _btnSave.ColorContrastOnClick = 45;
            _btnSave.ColorContrastOnHover = 45;
            _btnSave.Cursor = Cursors.Hand;
            BorderEdges6.BottomLeft = true;
            BorderEdges6.BottomRight = true;
            BorderEdges6.TopLeft = true;
            BorderEdges6.TopRight = true;
            _btnSave.CustomizableEdges = BorderEdges6;
            _btnSave.DialogResult = DialogResult.None;
            _btnSave.DisabledBorderColor = Color.Empty;
            _btnSave.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSave.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSave.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSave.ForeColor = Color.White;
            _btnSave.IconLeftCursor = Cursors.Hand;
            _btnSave.IconMarginLeft = 11;
            _btnSave.IconPadding = 10;
            _btnSave.IconRightCursor = Cursors.Hand;
            _btnSave.IdleBorderColor = Color.Teal;
            _btnSave.IdleBorderRadius = 3;
            _btnSave.IdleBorderThickness = 1;
            _btnSave.IdleFillColor = Color.Teal;
            _btnSave.IdleIconLeftImage = null;
            _btnSave.IdleIconRightImage = null;
            _btnSave.IndicateFocus = true;
            _btnSave.Location = new Point(842, 358);
            _btnSave.Name = "_btnSave";
            StateProperties11.BorderColor = Color.MediumTurquoise;
            StateProperties11.BorderRadius = 3;
            StateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties11.BorderThickness = 1;
            StateProperties11.FillColor = Color.MediumTurquoise;
            StateProperties11.ForeColor = Color.White;
            StateProperties11.IconLeftImage = null;
            StateProperties11.IconRightImage = null;
            _btnSave.onHoverState = StateProperties11;
            StateProperties12.BorderColor = Color.Teal;
            StateProperties12.BorderRadius = 3;
            StateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties12.BorderThickness = 1;
            StateProperties12.FillColor = Color.Teal;
            StateProperties12.ForeColor = Color.White;
            StateProperties12.IconLeftImage = null;
            StateProperties12.IconRightImage = null;
            _btnSave.OnPressedState = StateProperties12;
            _btnSave.Size = new Size(100, 40);
            _btnSave.TabIndex = 12;
            _btnSave.TextAlign = ContentAlignment.MiddleCenter;
            _btnSave.TextMarginLeft = 0;
            _btnSave.UseDefaultRadiusAndThickness = true;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 5;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.69893f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.92473f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.870968f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.7957f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.03226f));
            TableLayoutPanel1.Controls.Add(_cboVessel, 4, 3);
            TableLayoutPanel1.Controls.Add(_cboVoyageStatus, 4, 4);
            TableLayoutPanel1.Controls.Add(BunifuLabel10, 3, 4);
            TableLayoutPanel1.Controls.Add(_dtpETD, 1, 4);
            TableLayoutPanel1.Controls.Add(_dtpETA, 1, 3);
            TableLayoutPanel1.Controls.Add(_cboCompany, 4, 0);
            TableLayoutPanel1.Controls.Add(BunifuLabel7, 3, 0);
            TableLayoutPanel1.Controls.Add(_dtpLRD, 1, 2);
            TableLayoutPanel1.Controls.Add(_dtpERD, 1, 1);
            TableLayoutPanel1.Controls.Add(_btnCancelETA, 2, 3);
            TableLayoutPanel1.Controls.Add(_btnCancelLRD, 2, 2);
            TableLayoutPanel1.Controls.Add(_btnCancelERD, 2, 1);
            TableLayoutPanel1.Controls.Add(BunifuLabel8, 3, 3);
            TableLayoutPanel1.Controls.Add(BunifuLabel4, 0, 4);
            TableLayoutPanel1.Controls.Add(BunifuLabel3, 0, 3);
            TableLayoutPanel1.Controls.Add(BunifuLabel5, 0, 0);
            TableLayoutPanel1.Controls.Add(BunifuLabel1, 0, 1);
            TableLayoutPanel1.Controls.Add(BunifuLabel9, 0, 2);
            TableLayoutPanel1.Controls.Add(_txtVoyageNumber, 1, 0);
            TableLayoutPanel1.Controls.Add(_btnCancelETD, 2, 4);
            TableLayoutPanel1.Controls.Add(ckbActive, 4, 5);
            TableLayoutPanel1.Controls.Add(BunifuLabel2, 3, 2);
            TableLayoutPanel1.Controls.Add(txtCity, 4, 2);
            TableLayoutPanel1.Controls.Add(BunifuLabel6, 3, 1);
            TableLayoutPanel1.Controls.Add(_cboCountry, 4, 1);
            TableLayoutPanel1.Location = new Point(12, 101);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 6;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel1.Size = new Size(930, 240);
            TableLayoutPanel1.TabIndex = 219;
            // 
            // cboVessel
            // 
            _cboVessel.Anchor = AnchorStyles.Left;
            _cboVessel.AutoCompleteMode = AutoCompleteMode.Suggest;
            _cboVessel.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboVessel.DataSource = VesselBindingSource;
            _cboVessel.DisplayMember = "VesselName";
            _cboVessel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboVessel.FormattingEnabled = true;
            _cboVessel.Location = new Point(569, 126);
            _cboVessel.Name = "_cboVessel";
            _cboVessel.Size = new Size(323, 28);
            _cboVessel.TabIndex = 9;
            _cboVessel.ValueMember = "VesselId";
            // 
            // VesselBindingSource
            // 
            VesselBindingSource.DataSource = typeof(ModelLayer.Vessel);
            // 
            // cboVoyageStatus
            // 
            _cboVoyageStatus.Anchor = AnchorStyles.Left;
            _cboVoyageStatus.AutoCompleteMode = AutoCompleteMode.Suggest;
            _cboVoyageStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboVoyageStatus.DataSource = VesselVoyageStatusBindingSource;
            _cboVoyageStatus.DisplayMember = "StatusName";
            _cboVoyageStatus.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboVoyageStatus.FormattingEnabled = true;
            _cboVoyageStatus.Location = new Point(569, 166);
            _cboVoyageStatus.Name = "_cboVoyageStatus";
            _cboVoyageStatus.Size = new Size(323, 28);
            _cboVoyageStatus.TabIndex = 10;
            _cboVoyageStatus.ValueMember = "VesselVoyageStatusId";
            // 
            // VesselVoyageStatusBindingSource
            // 
            VesselVoyageStatusBindingSource.DataSource = typeof(ModelLayer.VesselVoyageStatus);
            // 
            // BunifuLabel10
            // 
            BunifuLabel10.Anchor = AnchorStyles.Right;
            BunifuLabel10.AutoEllipsis = false;
            BunifuLabel10.CursorType = null;
            BunifuLabel10.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel10.Location = new Point(451, 169);
            BunifuLabel10.Name = "BunifuLabel10";
            BunifuLabel10.RightToLeft = RightToLeft.No;
            BunifuLabel10.Size = new Size(112, 22);
            BunifuLabel10.TabIndex = 221;
            BunifuLabel10.Text = "Voyage Status:";
            BunifuLabel10.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtpETD
            // 
            _dtpETD.BorderRadius = 1;
            _dtpETD.Color = Color.Gray;
            _dtpETD.CustomFormat = " ";
            _dtpETD.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            _dtpETD.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            _dtpETD.DisabledColor = Color.Gray;
            _dtpETD.DisplayWeekNumbers = false;
            _dtpETD.DPHeight = 0;
            _dtpETD.DropDownAlign = LeftRightAlignment.Right;
            _dtpETD.FillDatePicker = false;
            _dtpETD.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _dtpETD.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dtpETD.Format = DateTimePickerFormat.Custom;
            _dtpETD.Icon = (Image)resources.GetObject("dtpETD.Icon");
            _dtpETD.IconColor = Color.Teal;
            _dtpETD.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            _dtpETD.Location = new Point(148, 163);
            _dtpETD.MinimumSize = new Size(250, 34);
            _dtpETD.Name = "_dtpETD";
            _dtpETD.Size = new Size(262, 34);
            _dtpETD.TabIndex = 5;
            // 
            // dtpETA
            // 
            _dtpETA.BorderRadius = 1;
            _dtpETA.Color = Color.Gray;
            _dtpETA.CustomFormat = " ";
            _dtpETA.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            _dtpETA.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            _dtpETA.DisabledColor = Color.Gray;
            _dtpETA.DisplayWeekNumbers = false;
            _dtpETA.DPHeight = 0;
            _dtpETA.DropDownAlign = LeftRightAlignment.Right;
            _dtpETA.FillDatePicker = false;
            _dtpETA.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _dtpETA.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dtpETA.Format = DateTimePickerFormat.Custom;
            _dtpETA.Icon = (Image)resources.GetObject("dtpETA.Icon");
            _dtpETA.IconColor = Color.Teal;
            _dtpETA.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            _dtpETA.Location = new Point(148, 123);
            _dtpETA.MinimumSize = new Size(250, 34);
            _dtpETA.Name = "_dtpETA";
            _dtpETA.Size = new Size(262, 34);
            _dtpETA.TabIndex = 4;
            // 
            // cboCompany
            // 
            _cboCompany.Anchor = AnchorStyles.Left;
            _cboCompany.AutoCompleteMode = AutoCompleteMode.Suggest;
            _cboCompany.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboCompany.DataSource = CompaniesNameBindingSource;
            _cboCompany.DisplayMember = "CompanyName";
            _cboCompany.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboCompany.FormattingEnabled = true;
            _cboCompany.Location = new Point(569, 6);
            _cboCompany.Name = "_cboCompany";
            _cboCompany.Size = new Size(323, 28);
            _cboCompany.TabIndex = 6;
            _cboCompany.ValueMember = "CompanieId";
            // 
            // CompaniesNameBindingSource
            // 
            CompaniesNameBindingSource.DataSource = typeof(ModelLayer.CustomModel.CompaniesName);
            // 
            // BunifuLabel7
            // 
            BunifuLabel7.Anchor = AnchorStyles.Right;
            BunifuLabel7.AutoEllipsis = false;
            BunifuLabel7.CursorType = null;
            BunifuLabel7.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel7.Location = new Point(481, 9);
            BunifuLabel7.Name = "BunifuLabel7";
            BunifuLabel7.RightToLeft = RightToLeft.No;
            BunifuLabel7.Size = new Size(82, 22);
            BunifuLabel7.TabIndex = 220;
            BunifuLabel7.Text = "Port Name:";
            BunifuLabel7.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtpLRD
            // 
            _dtpLRD.BorderRadius = 1;
            _dtpLRD.Color = Color.Gray;
            _dtpLRD.CustomFormat = " ";
            _dtpLRD.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            _dtpLRD.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            _dtpLRD.DisabledColor = Color.Gray;
            _dtpLRD.DisplayWeekNumbers = false;
            _dtpLRD.DPHeight = 0;
            _dtpLRD.DropDownAlign = LeftRightAlignment.Right;
            _dtpLRD.FillDatePicker = false;
            _dtpLRD.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _dtpLRD.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dtpLRD.Format = DateTimePickerFormat.Custom;
            _dtpLRD.Icon = (Image)resources.GetObject("dtpLRD.Icon");
            _dtpLRD.IconColor = Color.Teal;
            _dtpLRD.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            _dtpLRD.Location = new Point(148, 83);
            _dtpLRD.MinimumSize = new Size(250, 34);
            _dtpLRD.Name = "_dtpLRD";
            _dtpLRD.Size = new Size(262, 34);
            _dtpLRD.TabIndex = 3;
            // 
            // dtpERD
            // 
            _dtpERD.BorderRadius = 1;
            _dtpERD.Color = Color.Gray;
            _dtpERD.CustomFormat = " ";
            _dtpERD.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            _dtpERD.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            _dtpERD.DisabledColor = Color.Gray;
            _dtpERD.DisplayWeekNumbers = false;
            _dtpERD.DPHeight = 0;
            _dtpERD.DropDownAlign = LeftRightAlignment.Right;
            _dtpERD.FillDatePicker = false;
            _dtpERD.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _dtpERD.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dtpERD.Format = DateTimePickerFormat.Custom;
            _dtpERD.Icon = (Image)resources.GetObject("dtpERD.Icon");
            _dtpERD.IconColor = Color.Teal;
            _dtpERD.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            _dtpERD.Location = new Point(148, 43);
            _dtpERD.MinimumSize = new Size(250, 34);
            _dtpERD.Name = "_dtpERD";
            _dtpERD.Size = new Size(262, 34);
            _dtpERD.TabIndex = 2;
            // 
            // btnCancelETA
            // 
            _btnCancelETA.AllowToggling = false;
            _btnCancelETA.Anchor = AnchorStyles.None;
            _btnCancelETA.AnimationSpeed = 200;
            _btnCancelETA.AutoGenerateColors = false;
            _btnCancelETA.BackColor = Color.Transparent;
            _btnCancelETA.BackColor1 = Color.White;
            _btnCancelETA.BackgroundImage = (Image)resources.GetObject("btnCancelETA.BackgroundImage");
            _btnCancelETA.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnCancelETA.ButtonText = "";
            _btnCancelETA.ButtonTextMarginLeft = 0;
            _btnCancelETA.ColorContrastOnClick = 45;
            _btnCancelETA.ColorContrastOnHover = 45;
            _btnCancelETA.Cursor = Cursors.Hand;
            BorderEdges7.BottomLeft = true;
            BorderEdges7.BottomRight = true;
            BorderEdges7.TopLeft = true;
            BorderEdges7.TopRight = true;
            _btnCancelETA.CustomizableEdges = BorderEdges7;
            _btnCancelETA.DialogResult = DialogResult.None;
            _btnCancelETA.DisabledBorderColor = Color.Empty;
            _btnCancelETA.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnCancelETA.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnCancelETA.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnCancelETA.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnCancelETA.ForeColor = Color.White;
            _btnCancelETA.IconLeftCursor = Cursors.Hand;
            _btnCancelETA.IconMarginLeft = 5;
            _btnCancelETA.IconPadding = 5;
            _btnCancelETA.IconRightCursor = Cursors.Hand;
            _btnCancelETA.IdleBorderColor = Color.White;
            _btnCancelETA.IdleBorderRadius = 3;
            _btnCancelETA.IdleBorderThickness = 1;
            _btnCancelETA.IdleFillColor = Color.White;
            _btnCancelETA.IdleIconLeftImage = My.Resources.Resources.removeRedBall;
            _btnCancelETA.IdleIconRightImage = null;
            _btnCancelETA.IndicateFocus = false;
            _btnCancelETA.Location = new Point(418, 127);
            _btnCancelETA.Name = "_btnCancelETA";
            StateProperties13.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties13.BorderRadius = 3;
            StateProperties13.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties13.BorderThickness = 1;
            StateProperties13.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties13.ForeColor = Color.White;
            StateProperties13.IconLeftImage = null;
            StateProperties13.IconRightImage = null;
            _btnCancelETA.onHoverState = StateProperties13;
            StateProperties14.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties14.BorderRadius = 3;
            StateProperties14.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties14.BorderThickness = 1;
            StateProperties14.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties14.ForeColor = Color.White;
            StateProperties14.IconLeftImage = null;
            StateProperties14.IconRightImage = null;
            _btnCancelETA.OnPressedState = StateProperties14;
            _btnCancelETA.Size = new Size(25, 25);
            _btnCancelETA.TabIndex = 222;
            _btnCancelETA.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancelETA.TextMarginLeft = 0;
            _btnCancelETA.UseDefaultRadiusAndThickness = true;
            // 
            // btnCancelLRD
            // 
            _btnCancelLRD.AllowToggling = false;
            _btnCancelLRD.Anchor = AnchorStyles.None;
            _btnCancelLRD.AnimationSpeed = 200;
            _btnCancelLRD.AutoGenerateColors = false;
            _btnCancelLRD.BackColor = Color.Transparent;
            _btnCancelLRD.BackColor1 = Color.White;
            _btnCancelLRD.BackgroundImage = (Image)resources.GetObject("btnCancelLRD.BackgroundImage");
            _btnCancelLRD.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnCancelLRD.ButtonText = "";
            _btnCancelLRD.ButtonTextMarginLeft = 0;
            _btnCancelLRD.ColorContrastOnClick = 45;
            _btnCancelLRD.ColorContrastOnHover = 45;
            _btnCancelLRD.Cursor = Cursors.Hand;
            BorderEdges8.BottomLeft = true;
            BorderEdges8.BottomRight = true;
            BorderEdges8.TopLeft = true;
            BorderEdges8.TopRight = true;
            _btnCancelLRD.CustomizableEdges = BorderEdges8;
            _btnCancelLRD.DialogResult = DialogResult.None;
            _btnCancelLRD.DisabledBorderColor = Color.Empty;
            _btnCancelLRD.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnCancelLRD.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnCancelLRD.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnCancelLRD.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnCancelLRD.ForeColor = Color.White;
            _btnCancelLRD.IconLeftCursor = Cursors.Hand;
            _btnCancelLRD.IconMarginLeft = 5;
            _btnCancelLRD.IconPadding = 5;
            _btnCancelLRD.IconRightCursor = Cursors.Hand;
            _btnCancelLRD.IdleBorderColor = Color.White;
            _btnCancelLRD.IdleBorderRadius = 3;
            _btnCancelLRD.IdleBorderThickness = 1;
            _btnCancelLRD.IdleFillColor = Color.White;
            _btnCancelLRD.IdleIconLeftImage = My.Resources.Resources.removeRedBall;
            _btnCancelLRD.IdleIconRightImage = null;
            _btnCancelLRD.IndicateFocus = false;
            _btnCancelLRD.Location = new Point(418, 87);
            _btnCancelLRD.Name = "_btnCancelLRD";
            StateProperties15.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties15.BorderRadius = 3;
            StateProperties15.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties15.BorderThickness = 1;
            StateProperties15.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties15.ForeColor = Color.White;
            StateProperties15.IconLeftImage = null;
            StateProperties15.IconRightImage = null;
            _btnCancelLRD.onHoverState = StateProperties15;
            StateProperties16.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties16.BorderRadius = 3;
            StateProperties16.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties16.BorderThickness = 1;
            StateProperties16.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties16.ForeColor = Color.White;
            StateProperties16.IconLeftImage = null;
            StateProperties16.IconRightImage = null;
            _btnCancelLRD.OnPressedState = StateProperties16;
            _btnCancelLRD.Size = new Size(25, 25);
            _btnCancelLRD.TabIndex = 222;
            _btnCancelLRD.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancelLRD.TextMarginLeft = 0;
            _btnCancelLRD.UseDefaultRadiusAndThickness = true;
            // 
            // btnCancelERD
            // 
            _btnCancelERD.AllowToggling = false;
            _btnCancelERD.Anchor = AnchorStyles.None;
            _btnCancelERD.AnimationSpeed = 200;
            _btnCancelERD.AutoGenerateColors = false;
            _btnCancelERD.BackColor = Color.Transparent;
            _btnCancelERD.BackColor1 = Color.White;
            _btnCancelERD.BackgroundImage = (Image)resources.GetObject("btnCancelERD.BackgroundImage");
            _btnCancelERD.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnCancelERD.ButtonText = "";
            _btnCancelERD.ButtonTextMarginLeft = 0;
            _btnCancelERD.ColorContrastOnClick = 45;
            _btnCancelERD.ColorContrastOnHover = 45;
            _btnCancelERD.Cursor = Cursors.Hand;
            BorderEdges9.BottomLeft = true;
            BorderEdges9.BottomRight = true;
            BorderEdges9.TopLeft = true;
            BorderEdges9.TopRight = true;
            _btnCancelERD.CustomizableEdges = BorderEdges9;
            _btnCancelERD.DialogResult = DialogResult.None;
            _btnCancelERD.DisabledBorderColor = Color.Empty;
            _btnCancelERD.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnCancelERD.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnCancelERD.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnCancelERD.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnCancelERD.ForeColor = Color.White;
            _btnCancelERD.IconLeftCursor = Cursors.Hand;
            _btnCancelERD.IconMarginLeft = 5;
            _btnCancelERD.IconPadding = 5;
            _btnCancelERD.IconRightCursor = Cursors.Hand;
            _btnCancelERD.IdleBorderColor = Color.White;
            _btnCancelERD.IdleBorderRadius = 3;
            _btnCancelERD.IdleBorderThickness = 1;
            _btnCancelERD.IdleFillColor = Color.White;
            _btnCancelERD.IdleIconLeftImage = My.Resources.Resources.removeRedBall;
            _btnCancelERD.IdleIconRightImage = null;
            _btnCancelERD.IndicateFocus = false;
            _btnCancelERD.Location = new Point(418, 47);
            _btnCancelERD.Name = "_btnCancelERD";
            StateProperties17.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties17.BorderRadius = 3;
            StateProperties17.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties17.BorderThickness = 1;
            StateProperties17.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties17.ForeColor = Color.White;
            StateProperties17.IconLeftImage = null;
            StateProperties17.IconRightImage = null;
            _btnCancelERD.onHoverState = StateProperties17;
            StateProperties18.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties18.BorderRadius = 3;
            StateProperties18.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties18.BorderThickness = 1;
            StateProperties18.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties18.ForeColor = Color.White;
            StateProperties18.IconLeftImage = null;
            StateProperties18.IconRightImage = null;
            _btnCancelERD.OnPressedState = StateProperties18;
            _btnCancelERD.Size = new Size(25, 25);
            _btnCancelERD.TabIndex = 222;
            _btnCancelERD.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancelERD.TextMarginLeft = 0;
            _btnCancelERD.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuLabel8
            // 
            BunifuLabel8.Anchor = AnchorStyles.Right;
            BunifuLabel8.AutoEllipsis = false;
            BunifuLabel8.CursorType = null;
            BunifuLabel8.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel8.Location = new Point(508, 129);
            BunifuLabel8.Name = "BunifuLabel8";
            BunifuLabel8.RightToLeft = RightToLeft.No;
            BunifuLabel8.Size = new Size(55, 22);
            BunifuLabel8.TabIndex = 220;
            BunifuLabel8.Text = "Vessel:";
            BunifuLabel8.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel4
            // 
            BunifuLabel4.Anchor = AnchorStyles.Right;
            BunifuLabel4.AutoEllipsis = false;
            BunifuLabel4.CursorType = null;
            BunifuLabel4.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel4.Location = new Point(103, 169);
            BunifuLabel4.Name = "BunifuLabel4";
            BunifuLabel4.RightToLeft = RightToLeft.No;
            BunifuLabel4.Size = new Size(39, 22);
            BunifuLabel4.TabIndex = 221;
            BunifuLabel4.Text = "ETD:";
            BunifuLabel4.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel3
            // 
            BunifuLabel3.Anchor = AnchorStyles.Right;
            BunifuLabel3.AutoEllipsis = false;
            BunifuLabel3.CursorType = null;
            BunifuLabel3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel3.Location = new Point(104, 129);
            BunifuLabel3.Name = "BunifuLabel3";
            BunifuLabel3.RightToLeft = RightToLeft.No;
            BunifuLabel3.Size = new Size(38, 22);
            BunifuLabel3.TabIndex = 220;
            BunifuLabel3.Text = "ETA:";
            BunifuLabel3.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel5
            // 
            BunifuLabel5.Anchor = AnchorStyles.Right;
            BunifuLabel5.AutoEllipsis = false;
            BunifuLabel5.CursorType = null;
            BunifuLabel5.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel5.Location = new Point(21, 9);
            BunifuLabel5.Name = "BunifuLabel5";
            BunifuLabel5.RightToLeft = RightToLeft.No;
            BunifuLabel5.Size = new Size(121, 22);
            BunifuLabel5.TabIndex = 211;
            BunifuLabel5.Text = "Voyage Number:";
            BunifuLabel5.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel1
            // 
            BunifuLabel1.Anchor = AnchorStyles.Right;
            BunifuLabel1.AutoEllipsis = false;
            BunifuLabel1.CursorType = null;
            BunifuLabel1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel1.Location = new Point(100, 49);
            BunifuLabel1.Name = "BunifuLabel1";
            BunifuLabel1.RightToLeft = RightToLeft.No;
            BunifuLabel1.Size = new Size(42, 22);
            BunifuLabel1.TabIndex = 212;
            BunifuLabel1.Text = "ERD:";
            BunifuLabel1.TextAlignment = ContentAlignment.TopRight;
            BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel9
            // 
            BunifuLabel9.Anchor = AnchorStyles.Right;
            BunifuLabel9.AutoEllipsis = false;
            BunifuLabel9.CursorType = null;
            BunifuLabel9.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel9.Location = new Point(102, 89);
            BunifuLabel9.Name = "BunifuLabel9";
            BunifuLabel9.RightToLeft = RightToLeft.No;
            BunifuLabel9.Size = new Size(40, 22);
            BunifuLabel9.TabIndex = 219;
            BunifuLabel9.Text = "LRD:";
            BunifuLabel9.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtVoyageNumber
            // 
            _txtVoyageNumber.Anchor = AnchorStyles.Left;
            _txtVoyageNumber.CharacterCasing = CharacterCasing.Upper;
            _txtVoyageNumber.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtVoyageNumber.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _txtVoyageNumber.Location = new Point(148, 7);
            _txtVoyageNumber.MaxLength = 150;
            _txtVoyageNumber.MinimumSize = new Size(4, 30);
            _txtVoyageNumber.Name = "_txtVoyageNumber";
            _txtVoyageNumber.Size = new Size(262, 26);
            _txtVoyageNumber.TabIndex = 1;
            // 
            // btnCancelETD
            // 
            _btnCancelETD.AllowToggling = false;
            _btnCancelETD.Anchor = AnchorStyles.None;
            _btnCancelETD.AnimationSpeed = 200;
            _btnCancelETD.AutoGenerateColors = false;
            _btnCancelETD.BackColor = Color.Transparent;
            _btnCancelETD.BackColor1 = Color.White;
            _btnCancelETD.BackgroundImage = (Image)resources.GetObject("btnCancelETD.BackgroundImage");
            _btnCancelETD.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnCancelETD.ButtonText = "";
            _btnCancelETD.ButtonTextMarginLeft = 0;
            _btnCancelETD.ColorContrastOnClick = 45;
            _btnCancelETD.ColorContrastOnHover = 45;
            _btnCancelETD.Cursor = Cursors.Hand;
            BorderEdges10.BottomLeft = true;
            BorderEdges10.BottomRight = true;
            BorderEdges10.TopLeft = true;
            BorderEdges10.TopRight = true;
            _btnCancelETD.CustomizableEdges = BorderEdges10;
            _btnCancelETD.DialogResult = DialogResult.None;
            _btnCancelETD.DisabledBorderColor = Color.Empty;
            _btnCancelETD.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnCancelETD.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnCancelETD.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnCancelETD.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnCancelETD.ForeColor = Color.White;
            _btnCancelETD.IconLeftCursor = Cursors.Hand;
            _btnCancelETD.IconMarginLeft = 5;
            _btnCancelETD.IconPadding = 5;
            _btnCancelETD.IconRightCursor = Cursors.Hand;
            _btnCancelETD.IdleBorderColor = Color.White;
            _btnCancelETD.IdleBorderRadius = 3;
            _btnCancelETD.IdleBorderThickness = 1;
            _btnCancelETD.IdleFillColor = Color.White;
            _btnCancelETD.IdleIconLeftImage = My.Resources.Resources.removeRedBall;
            _btnCancelETD.IdleIconRightImage = null;
            _btnCancelETD.IndicateFocus = false;
            _btnCancelETD.Location = new Point(418, 167);
            _btnCancelETD.Name = "_btnCancelETD";
            StateProperties19.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties19.BorderRadius = 3;
            StateProperties19.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties19.BorderThickness = 1;
            StateProperties19.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties19.ForeColor = Color.White;
            StateProperties19.IconLeftImage = null;
            StateProperties19.IconRightImage = null;
            _btnCancelETD.onHoverState = StateProperties19;
            StateProperties20.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties20.BorderRadius = 3;
            StateProperties20.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties20.BorderThickness = 1;
            StateProperties20.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties20.ForeColor = Color.White;
            StateProperties20.IconLeftImage = null;
            StateProperties20.IconRightImage = null;
            _btnCancelETD.OnPressedState = StateProperties20;
            _btnCancelETD.Size = new Size(25, 25);
            _btnCancelETD.TabIndex = 223;
            _btnCancelETD.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancelETD.TextMarginLeft = 0;
            _btnCancelETD.UseDefaultRadiusAndThickness = true;
            // 
            // ckbActive
            // 
            ckbActive.Anchor = AnchorStyles.Left;
            ckbActive.AutoSize = true;
            ckbActive.Checked = true;
            ckbActive.CheckState = CheckState.Checked;
            ckbActive.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ckbActive.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ckbActive.Location = new Point(569, 208);
            ckbActive.Name = "ckbActive";
            ckbActive.Size = new Size(71, 24);
            ckbActive.TabIndex = 11;
            ckbActive.Text = "Active";
            ckbActive.UseVisualStyleBackColor = true;
            // 
            // BunifuLabel2
            // 
            BunifuLabel2.Anchor = AnchorStyles.Right;
            BunifuLabel2.AutoEllipsis = false;
            BunifuLabel2.CursorType = null;
            BunifuLabel2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel2.Location = new Point(497, 89);
            BunifuLabel2.Name = "BunifuLabel2";
            BunifuLabel2.RightToLeft = RightToLeft.No;
            BunifuLabel2.Size = new Size(66, 22);
            BunifuLabel2.TabIndex = 213;
            BunifuLabel2.Text = "Port City:";
            BunifuLabel2.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Left;
            txtCity.CharacterCasing = CharacterCasing.Upper;
            txtCity.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            txtCity.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            txtCity.Location = new Point(569, 87);
            txtCity.MaxLength = 50;
            txtCity.MinimumSize = new Size(4, 30);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(323, 30);
            txtCity.TabIndex = 8;
            txtCity.Text = "   ";
            // 
            // BunifuLabel6
            // 
            BunifuLabel6.Anchor = AnchorStyles.Right;
            BunifuLabel6.AutoEllipsis = false;
            BunifuLabel6.CursorType = null;
            BunifuLabel6.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel6.Location = new Point(468, 49);
            BunifuLabel6.Name = "BunifuLabel6";
            BunifuLabel6.RightToLeft = RightToLeft.No;
            BunifuLabel6.Size = new Size(95, 22);
            BunifuLabel6.TabIndex = 216;
            BunifuLabel6.Text = "Port Country:";
            BunifuLabel6.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cboCountry
            // 
            _cboCountry.Anchor = AnchorStyles.Left;
            _cboCountry.AutoCompleteMode = AutoCompleteMode.Suggest;
            _cboCountry.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboCountry.DataSource = CountryBindingSource;
            _cboCountry.DisplayMember = "CountryName";
            _cboCountry.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboCountry.FormattingEnabled = true;
            _cboCountry.Location = new Point(569, 46);
            _cboCountry.Name = "_cboCountry";
            _cboCountry.Size = new Size(323, 28);
            _cboCountry.TabIndex = 7;
            _cboCountry.ValueMember = "Code";
            // 
            // CountryBindingSource
            // 
            CountryBindingSource.DataSource = typeof(ModelLayer.Country);
            // 
            // lblTitleVessel
            // 
            lblTitleVessel.AutoEllipsis = false;
            lblTitleVessel.CursorType = null;
            lblTitleVessel.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTitleVessel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblTitleVessel.Location = new Point(12, 58);
            lblTitleVessel.Name = "lblTitleVessel";
            lblTitleVessel.RightToLeft = RightToLeft.No;
            lblTitleVessel.Size = new Size(183, 24);
            lblTitleVessel.TabIndex = 218;
            lblTitleVessel.Text = "Add Vessel Voyage:";
            lblTitleVessel.TextAlignment = ContentAlignment.TopLeft;
            lblTitleVessel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnClose
            // 
            _btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnClose.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _btnClose.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClose.ForeColor = Color.White;
            _btnClose.Location = new Point(914, 0);
            _btnClose.Margin = new Padding(0);
            _btnClose.Name = "_btnClose";
            _btnClose.Size = new Size(40, 41);
            _btnClose.TabIndex = 217;
            _btnClose.Text = "🗙";
            _btnClose.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            Label2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Dock = DockStyle.Top;
            Label2.Font = new Font("Microsoft Sans Serif", 22.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(0, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(954, 41);
            Label2.TabIndex = 216;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbxRefreshComboBox
            // 
            _pbxRefreshComboBox.Image = My.Resources.Resources.refresh_pngrepo_com;
            _pbxRefreshComboBox.Location = new Point(912, 58);
            _pbxRefreshComboBox.Name = "_pbxRefreshComboBox";
            _pbxRefreshComboBox.Size = new Size(30, 30);
            _pbxRefreshComboBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _pbxRefreshComboBox.TabIndex = 220;
            _pbxRefreshComboBox.TabStop = false;
            _pbxRefreshComboBox.Visible = false;
            // 
            // frmVesselVoyageAddEdit
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(954, 410);
            Controls.Add(_pbxRefreshComboBox);
            Controls.Add(_btnSave);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(lblTitleVessel);
            Controls.Add(_btnClose);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVesselVoyageAddEdit";
            Text = "frmVesselVoyageAddEdit";
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VesselBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)VesselVoyageStatusBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)CompaniesNameBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_pbxRefreshComboBox).EndInit();
            Load += new EventHandler(frmVesselVoyageAddEdit_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnSave;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSave != null)
                {
                    _btnSave.Click -= btnSave_Click;
                }

                _btnSave = value;
                if (_btnSave != null)
                {
                    _btnSave.Click += btnSave_Click;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel1;
        private ComboBox _cboCompany;

        internal ComboBox cboCompany
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboCompany;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboCompany != null)
                {
                    _cboCompany.SelectedValueChanged -= cboCompany_SelectedValueChanged;
                }

                _cboCompany = value;
                if (_cboCompany != null)
                {
                    _cboCompany.SelectedValueChanged += cboCompany_SelectedValueChanged;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel3;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel5;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel1;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel2;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel6;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel9;
        private TextBox _txtVoyageNumber;

        internal TextBox txtVoyageNumber
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtVoyageNumber;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtVoyageNumber != null)
                {
                    _txtVoyageNumber.KeyPress -= txtVoyageNumber_KeyPress;
                }

                _txtVoyageNumber = value;
                if (_txtVoyageNumber != null)
                {
                    _txtVoyageNumber.KeyPress += txtVoyageNumber_KeyPress;
                }
            }
        }

        internal TextBox txtCity;
        internal CheckBox ckbActive;
        internal Bunifu.UI.WinForms.BunifuLabel lblTitleVessel;
        private Label _btnClose;

        internal Label btnClose
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnClose;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnClose != null)
                {
                    _btnClose.Click -= btnClose_Click;
                }

                _btnClose = value;
                if (_btnClose != null)
                {
                    _btnClose.Click += btnClose_Click;
                }
            }
        }

        internal Label Label2;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel4;
        private ComboBox _cboCountry;

        internal ComboBox cboCountry
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboCountry;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboCountry != null)
                {
                    _cboCountry.SelectedValueChanged -= cboCountry_SelectedValueChanged;
                }

                _cboCountry = value;
                if (_cboCountry != null)
                {
                    _cboCountry.SelectedValueChanged += cboCountry_SelectedValueChanged;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel8;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnCancelETA;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelETA
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCancelETA;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCancelETA != null)
                {
                    _btnCancelETA.Click -= btnCancelETA_Click;
                }

                _btnCancelETA = value;
                if (_btnCancelETA != null)
                {
                    _btnCancelETA.Click += btnCancelETA_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnCancelLRD;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelLRD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCancelLRD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCancelLRD != null)
                {
                    _btnCancelLRD.Click -= btnCancelLRD_Click;
                }

                _btnCancelLRD = value;
                if (_btnCancelLRD != null)
                {
                    _btnCancelLRD.Click += btnCancelLRD_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnCancelERD;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelERD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCancelERD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCancelERD != null)
                {
                    _btnCancelERD.Click -= btnCancelERD_Click;
                }

                _btnCancelERD = value;
                if (_btnCancelERD != null)
                {
                    _btnCancelERD.Click += btnCancelERD_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnCancelETD;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelETD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCancelETD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCancelETD != null)
                {
                    _btnCancelETD.Click -= btnCancelETD_Click;
                }

                _btnCancelETD = value;
                if (_btnCancelETD != null)
                {
                    _btnCancelETD.Click += btnCancelETD_Click;
                }
            }
        }

        private ComboBox _cboVessel;

        internal ComboBox cboVessel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboVessel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboVessel != null)
                {
                    _cboVessel.KeyPress -= cboVessel_KeyPress;
                    _cboVessel.SelectedValueChanged -= cboVessel_SelectedValueChanged;
                }

                _cboVessel = value;
                if (_cboVessel != null)
                {
                    _cboVessel.KeyPress += cboVessel_KeyPress;
                    _cboVessel.SelectedValueChanged += cboVessel_SelectedValueChanged;
                }
            }
        }

        private ComboBox _cboVoyageStatus;

        internal ComboBox cboVoyageStatus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboVoyageStatus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboVoyageStatus != null)
                {
                    _cboVoyageStatus.SelectedValueChanged -= cboVoyageStatus_SelectedValueChanged;
                }

                _cboVoyageStatus = value;
                if (_cboVoyageStatus != null)
                {
                    _cboVoyageStatus.SelectedValueChanged += cboVoyageStatus_SelectedValueChanged;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel10;
        private Bunifu.UI.WinForms.BunifuDatePicker _dtpETD;

        internal Bunifu.UI.WinForms.BunifuDatePicker dtpETD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dtpETD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dtpETD != null)
                {
                    _dtpETD.ValueChanged -= dtpETD_ValueChanged;
                }

                _dtpETD = value;
                if (_dtpETD != null)
                {
                    _dtpETD.ValueChanged += dtpETD_ValueChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDatePicker _dtpETA;

        internal Bunifu.UI.WinForms.BunifuDatePicker dtpETA
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dtpETA;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dtpETA != null)
                {
                    _dtpETA.ValueChanged -= dtpETA_ValueChanged;
                }

                _dtpETA = value;
                if (_dtpETA != null)
                {
                    _dtpETA.ValueChanged += dtpETA_ValueChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDatePicker _dtpLRD;

        internal Bunifu.UI.WinForms.BunifuDatePicker dtpLRD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dtpLRD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dtpLRD != null)
                {
                    _dtpLRD.ValueChanged -= dtpLRD_ValueChanged;
                }

                _dtpLRD = value;
                if (_dtpLRD != null)
                {
                    _dtpLRD.ValueChanged += dtpLRD_ValueChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDatePicker _dtpERD;

        internal Bunifu.UI.WinForms.BunifuDatePicker dtpERD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dtpERD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dtpERD != null)
                {
                    _dtpERD.ValueChanged -= dtpERD_ValueChanged;
                }

                _dtpERD = value;
                if (_dtpERD != null)
                {
                    _dtpERD.ValueChanged += dtpERD_ValueChanged;
                }
            }
        }

        internal BindingSource VesselVoyageStatusBindingSource;
        internal BindingSource CountryBindingSource;
        internal BindingSource CompaniesNameBindingSource;
        internal BindingSource VesselBindingSource;
        private PictureBox _pbxRefreshComboBox;

        internal PictureBox pbxRefreshComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pbxRefreshComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pbxRefreshComboBox != null)
                {
                    _pbxRefreshComboBox.Click -= pbxRefreshComboBox_Click;
                }

                _pbxRefreshComboBox = value;
                if (_pbxRefreshComboBox != null)
                {
                    _pbxRefreshComboBox.Click += pbxRefreshComboBox_Click;
                }
            }
        }
    }
}