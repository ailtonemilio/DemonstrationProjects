using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Microsoft.VisualBasic.CompilerServices;
using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmTruckingRecon : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    try
                    {
                        components.Dispose();
                    }
                    catch
                    {
                    }
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
            var BorderEdges33 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties85 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties86 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges34 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties87 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties88 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges35 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties89 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties90 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle41 = new DataGridViewCellStyle();
            var DataGridViewCellStyle42 = new DataGridViewCellStyle();
            var DataGridViewCellStyle43 = new DataGridViewCellStyle();
            var DataGridViewCellStyle44 = new DataGridViewCellStyle();
            var DataGridViewCellStyle45 = new DataGridViewCellStyle();
            var DataGridViewCellStyle46 = new DataGridViewCellStyle();
            var DataGridViewCellStyle47 = new DataGridViewCellStyle();
            var DataGridViewCellStyle48 = new DataGridViewCellStyle();
            var DataGridViewCellStyle50 = new DataGridViewCellStyle();
            var DataGridViewCellStyle49 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTruckingRecon));
            var BorderEdges29 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties73 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties74 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges30 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties75 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties76 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var ToggleState13 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState14 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState15 = new Bunifu.ToggleSwitch.ToggleState();
            var StateProperties77 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties78 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties79 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties80 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var BorderEdges31 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties81 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties82 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges32 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties83 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties84 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Panel5 = new Panel();
            Panel6 = new Panel();
            _exportButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _exportButton.Click += new EventHandler(exportButton_Click);
            Panel3 = new Panel();
            panelCarriers = new Panel();
            btnAddLogo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _BunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            _BunifuFlatButton1.Click += new EventHandler(BunifuFlatButton1_Click);
            _btnOkExtraCarriers = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnOkExtraCarriers.Click += new EventHandler(btnOkExtraCarriers_Click);
            Label26 = new Label();
            _dgvExtraCarriers = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvExtraCarriers.CellContentClick += new DataGridViewCellEventHandler(dgvExtraCarriers_CellContentClick);
            VWCompanyCompanyTypeBindingSource = new BindingSource(components);
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            warningLabel = new Label();
            Panel1 = new Panel();
            _dgvTest = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvTest.RowPostPaint += new DataGridViewRowPostPaintEventHandler(reports1_RowPostPaint);
            UniqueIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rate = new DataGridViewTextBoxColumn();
            rateType = new DataGridViewTextBoxColumn();
            ContainerNumbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BkrelNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pickUpCode = new DataGridViewTextBoxColumn();
            dropOffCode = new DataGridViewTextBoxColumn();
            GateDateTime = new DataGridViewTextBoxColumn();
            TruckIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            truckDriverId = new DataGridViewTextBoxColumn();
            DriverNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            StreetTurnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CarrierCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CarrierNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DrayageTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ContainersInOutDrayageBindingSource = new BindingSource(components);
            GroupBox2 = new GroupBox();
            TableLayoutPanel1 = new TableLayoutPanel();
            Panel7 = new Panel();
            _addedServDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            _addedServDataGridView.CellContentClick += new DataGridViewCellEventHandler(addedServDataGridView_CellContentClick);
            _addedServDataGridView.RowPostPaint += new DataGridViewRowPostPaintEventHandler(BunifuDataGridView1_RowPostPaint);
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            delCol = new DataGridViewButtonColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Label7 = new Label();
            GroupBox1 = new GroupBox();
            FlowLayoutPanel1 = new FlowLayoutPanel();
            lblExtraCarrier = new Label();
            Label28 = new Label();
            _btnAddCarrier = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddCarrier.Click += new EventHandler(btnAddCarrier_Click);
            _btnRemoveDate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnRemoveDate.Click += new EventHandler(btnRemoveDate_Click);
            _cboMultiEmpty = new Bunifu.UI.WinForms.BunifuCheckBox();
            _cboMultiEmpty.Click += new EventHandler(cboBookingNumber_SelectedIndexChanged);
            _cboSingleLoad = new Bunifu.UI.WinForms.BunifuCheckBox();
            _cboSingleLoad.Click += new EventHandler(cboBookingNumber_SelectedIndexChanged);
            _cboMultiLoad = new Bunifu.UI.WinForms.BunifuCheckBox();
            _cboMultiLoad.Click += new EventHandler(cboBookingNumber_SelectedIndexChanged);
            _cbxSingleEmpty = new Bunifu.UI.WinForms.BunifuCheckBox();
            _cbxSingleEmpty.Click += new EventHandler(cboBookingNumber_SelectedIndexChanged);
            Label25 = new Label();
            cboDriverId = new ComboBox();
            TruckDriversBindingSource = new BindingSource(components);
            Label24 = new Label();
            _cboDropOff = new ComboBox();
            _cboDropOff.SelectedValueChanged += new EventHandler(cboBookingNumber_SelectedIndexChanged);
            Label20 = new Label();
            _cboPickUp = new ComboBox();
            _cboPickUp.SelectedValueChanged += new EventHandler(cboBookingNumber_SelectedIndexChanged);
            Label19 = new Label();
            Label18 = new Label();
            Label15 = new Label();
            Label13 = new Label();
            Label6 = new Label();
            Label4 = new Label();
            _cboBookingNumber = new ComboBox();
            _cboBookingNumber.SelectedIndexChanged += new EventHandler(cboBookingNumber_SelectedIndexChanged);
            streetTurnToggleSwitch = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            toIDatePicker = new DateTimePicker();
            Label5 = new Label();
            _fromDatePicker = new DateTimePicker();
            _fromDatePicker.ValueChanged += new EventHandler(fromDatePicker_ValueChanged);
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            _cboTruckingCompany = new ComboBox();
            _cboTruckingCompany.SelectedValueChanged += new EventHandler(cboBookingNumber_SelectedIndexChanged);
            _cboTruckingCompany.SelectedIndexChanged += new EventHandler(cboTruckingCompany_SelectedIndexChanged);
            _searchBunifuTextBox1 = new BunifuTextBox();
            _searchBunifuTextBox1.TextChanged += new EventHandler(searchBunifuTextBox1_TextChanged);
            _BunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _BunifuButton2.Click += new EventHandler(BunifuButton2_Click);
            _printButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _printButton.Click += new EventHandler(printButton_Click);
            titleLabel = new Label();
            BunifuShadowPanel2 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            TableLayoutPanel3 = new TableLayoutPanel();
            totalQtyLbl = new Label();
            TableLayoutPanel18 = new TableLayoutPanel();
            Label14 = new Label();
            totalaftTaxesLabel = new Label();
            TableLayoutPanel17 = new TableLayoutPanel();
            totalfsctefLabel = new Label();
            TableLayoutPanel16 = new TableLayoutPanel();
            Label17 = new Label();
            tefFeeLabel = new Label();
            fscFeeLabel = new Label();
            Label16 = new Label();
            fscLabel = new Label();
            TableLayoutPanel15 = new TableLayoutPanel();
            lblTotalLoad = new Label();
            TableLayoutPanel2 = new TableLayoutPanel();
            ratetotalSingleEptyLabel = new Label();
            ratetotalMultiEptyLabel = new Label();
            totalSingleEptyLabel = new Label();
            totalMultiEptyLabel = new Label();
            rateSingleEptyLabel = new Label();
            rateMultEptyLabel = new Label();
            Label = new Label();
            Label23 = new Label();
            Label22 = new Label();
            Label21 = new Label();
            Label11 = new Label();
            Label9 = new Label();
            totalMultiLoadLabel = new Label();
            Label10 = new Label();
            Label12 = new Label();
            totalSingleLoadLabel = new Label();
            rateSingleLoadsLabel = new Label();
            ratetotalSingleLoadLabel = new Label();
            rateMultiLoadLabel = new Label();
            ratetotalMultiLoadLabel = new Label();
            lblqtyEmpty = new Label();
            lblqtyLoads = new Label();
            lblTotalEmpty = new Label();
            Label27 = new Label();
            Label8 = new Label();
            ImageList1 = new ImageList(components);
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel2 = new Panel();
            PrintDialog1 = new PrintDialog();
            PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            cbCheck = new DataGridViewCheckBoxColumn();
            CompanyNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Panel5.SuspendLayout();
            Panel6.SuspendLayout();
            Panel3.SuspendLayout();
            panelCarriers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvExtraCarriers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWCompanyCompanyTypeBindingSource).BeginInit();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvTest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContainersInOutDrayageBindingSource).BeginInit();
            GroupBox2.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            Panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_addedServDataGridView).BeginInit();
            GroupBox1.SuspendLayout();
            FlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TruckDriversBindingSource).BeginInit();
            BunifuShadowPanel2.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            TableLayoutPanel18.SuspendLayout();
            TableLayoutPanel17.SuspendLayout();
            TableLayoutPanel16.SuspendLayout();
            TableLayoutPanel15.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            BunifuShadowPanel1.SuspendLayout();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel5.Controls.Add(Panel6);
            Panel5.Controls.Add(Panel3);
            Panel5.Dock = DockStyle.Fill;
            Panel5.Location = new Point(0, 0);
            Panel5.Name = "Panel5";
            Panel5.Padding = new Padding(0, 40, 0, 0);
            Panel5.Size = new Size(1668, 939);
            Panel5.TabIndex = 33;
            // 
            // Panel6
            // 
            Panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel6.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel6.Controls.Add(_exportButton);
            Panel6.Location = new Point(1520, 6);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(148, 33);
            Panel6.TabIndex = 35;
            // 
            // exportButton
            // 
            _exportButton.AllowToggling = false;
            _exportButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _exportButton.AnimationSpeed = 200;
            _exportButton.AutoGenerateColors = false;
            _exportButton.BackColor = Color.Transparent;
            _exportButton.BackColor1 = Color.White;
            _exportButton.BackgroundImage = (Image)resources.GetObject("exportButton.BackgroundImage");
            _exportButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _exportButton.ButtonText = "CSV Report";
            _exportButton.ButtonTextMarginLeft = 15;
            _exportButton.ColorContrastOnClick = 45;
            _exportButton.ColorContrastOnHover = 45;
            _exportButton.Cursor = Cursors.Hand;
            BorderEdges33.BottomLeft = true;
            BorderEdges33.BottomRight = true;
            BorderEdges33.TopLeft = true;
            BorderEdges33.TopRight = true;
            _exportButton.CustomizableEdges = BorderEdges33;
            _exportButton.DialogResult = DialogResult.None;
            _exportButton.DisabledBorderColor = Color.Empty;
            _exportButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _exportButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _exportButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _exportButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _exportButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _exportButton.IconLeftCursor = Cursors.Hand;
            _exportButton.IconMarginLeft = 11;
            _exportButton.IconPadding = 3;
            _exportButton.IconRightCursor = Cursors.Hand;
            _exportButton.IdleBorderColor = Color.LightGray;
            _exportButton.IdleBorderRadius = 30;
            _exportButton.IdleBorderThickness = 1;
            _exportButton.IdleFillColor = Color.White;
            _exportButton.IdleIconLeftImage = My.Resources.Resources.csv;
            _exportButton.IdleIconRightImage = null;
            _exportButton.IndicateFocus = true;
            _exportButton.Location = new Point(4, -1);
            _exportButton.Name = "_exportButton";
            StateProperties85.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties85.BorderRadius = 30;
            StateProperties85.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties85.BorderThickness = 1;
            StateProperties85.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties85.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties85.IconLeftImage = null;
            StateProperties85.IconRightImage = null;
            _exportButton.onHoverState = StateProperties85;
            StateProperties86.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties86.BorderRadius = 30;
            StateProperties86.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties86.BorderThickness = 1;
            StateProperties86.FillColor = Color.White;
            StateProperties86.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties86.IconLeftImage = null;
            StateProperties86.IconRightImage = null;
            _exportButton.OnPressedState = StateProperties86;
            _exportButton.Padding = new Padding(3, 0, 3, 0);
            _exportButton.Size = new Size(140, 33);
            _exportButton.TabIndex = 76;
            _exportButton.TextAlign = ContentAlignment.MiddleCenter;
            _exportButton.TextMarginLeft = 15;
            _exportButton.UseDefaultRadiusAndThickness = true;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.White;
            Panel3.Controls.Add(titleLabel);
            Panel3.Controls.Add(panelCarriers);
            Panel3.Controls.Add(_closeFlatButton);
            Panel3.Controls.Add(warningLabel);
            Panel3.Controls.Add(Panel1);
            Panel3.Controls.Add(GroupBox2);
            Panel3.Controls.Add(GroupBox1);
            Panel3.Controls.Add(_searchBunifuTextBox1);
            Panel3.Controls.Add(_BunifuButton2);
            Panel3.Controls.Add(_printButton);
            Panel3.Controls.Add(BunifuShadowPanel2);
            Panel3.Dock = DockStyle.Fill;
            Panel3.Location = new Point(0, 40);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1668, 899);
            Panel3.TabIndex = 0;
            // 
            // panelCarriers
            // 
            panelCarriers.BackColor = Color.WhiteSmoke;
            panelCarriers.BorderStyle = BorderStyle.FixedSingle;
            panelCarriers.Controls.Add(btnAddLogo);
            panelCarriers.Controls.Add(_BunifuFlatButton1);
            panelCarriers.Controls.Add(_btnOkExtraCarriers);
            panelCarriers.Controls.Add(Label26);
            panelCarriers.Controls.Add(_dgvExtraCarriers);
            panelCarriers.Location = new Point(601, 95);
            panelCarriers.Name = "panelCarriers";
            panelCarriers.Size = new Size(359, 200);
            panelCarriers.TabIndex = 204;
            panelCarriers.Visible = false;
            // 
            // btnAddLogo
            // 
            btnAddLogo.AllowToggling = false;
            btnAddLogo.AnimationSpeed = 200;
            btnAddLogo.AutoGenerateColors = false;
            btnAddLogo.BackColor = Color.Transparent;
            btnAddLogo.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            btnAddLogo.BackgroundImage = (Image)resources.GetObject("btnAddLogo.BackgroundImage");
            btnAddLogo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddLogo.ButtonText = "+";
            btnAddLogo.ButtonTextMarginLeft = 0;
            btnAddLogo.ColorContrastOnClick = 45;
            btnAddLogo.ColorContrastOnHover = 45;
            btnAddLogo.Cursor = Cursors.Hand;
            BorderEdges34.BottomLeft = true;
            BorderEdges34.BottomRight = true;
            BorderEdges34.TopLeft = true;
            BorderEdges34.TopRight = true;
            btnAddLogo.CustomizableEdges = BorderEdges34;
            btnAddLogo.DialogResult = DialogResult.None;
            btnAddLogo.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            btnAddLogo.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            btnAddLogo.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            btnAddLogo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnAddLogo.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            btnAddLogo.ForeColor = Color.White;
            btnAddLogo.IconLeftCursor = Cursors.Hand;
            btnAddLogo.IconMarginLeft = 11;
            btnAddLogo.IconPadding = 10;
            btnAddLogo.IconRightCursor = Cursors.Hand;
            btnAddLogo.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            btnAddLogo.IdleBorderRadius = 11;
            btnAddLogo.IdleBorderThickness = 1;
            btnAddLogo.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            btnAddLogo.IdleIconLeftImage = null;
            btnAddLogo.IdleIconRightImage = null;
            btnAddLogo.IndicateFocus = false;
            btnAddLogo.Location = new Point(409, 178);
            btnAddLogo.Margin = new Padding(2);
            btnAddLogo.Name = "btnAddLogo";
            StateProperties87.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties87.BorderRadius = 11;
            StateProperties87.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties87.BorderThickness = 1;
            StateProperties87.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties87.ForeColor = Color.White;
            StateProperties87.IconLeftImage = null;
            StateProperties87.IconRightImage = null;
            btnAddLogo.onHoverState = StateProperties87;
            StateProperties88.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties88.BorderRadius = 11;
            StateProperties88.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties88.BorderThickness = 1;
            StateProperties88.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties88.ForeColor = Color.White;
            StateProperties88.IconLeftImage = null;
            StateProperties88.IconRightImage = null;
            btnAddLogo.OnPressedState = StateProperties88;
            btnAddLogo.Size = new Size(16, 16);
            btnAddLogo.TabIndex = 178;
            btnAddLogo.TextAlign = ContentAlignment.MiddleCenter;
            btnAddLogo.TextMarginLeft = 0;
            btnAddLogo.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuFlatButton1
            // 
            _BunifuFlatButton1.Active = false;
            _BunifuFlatButton1.Activecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuFlatButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _BunifuFlatButton1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch;
            _BunifuFlatButton1.BorderRadius = 0;
            _BunifuFlatButton1.ButtonText = "🗙";
            _BunifuFlatButton1.Cursor = Cursors.Hand;
            _BunifuFlatButton1.DisabledColor = Color.Gray;
            _BunifuFlatButton1.Iconcolor = Color.Transparent;
            _BunifuFlatButton1.Iconimage = null;
            _BunifuFlatButton1.Iconimage_right = null;
            _BunifuFlatButton1.Iconimage_right_Selected = null;
            _BunifuFlatButton1.Iconimage_Selected = null;
            _BunifuFlatButton1.IconMarginLeft = 0;
            _BunifuFlatButton1.IconMarginRight = 0;
            _BunifuFlatButton1.IconRightVisible = true;
            _BunifuFlatButton1.IconRightZoom = 0d;
            _BunifuFlatButton1.IconVisible = true;
            _BunifuFlatButton1.IconZoom = 90.0d;
            _BunifuFlatButton1.IsTab = false;
            _BunifuFlatButton1.Location = new Point(333, 1);
            _BunifuFlatButton1.Margin = new Padding(6, 7, 6, 7);
            _BunifuFlatButton1.Name = "_BunifuFlatButton1";
            _BunifuFlatButton1.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuFlatButton1.OnHovercolor = Color.Gray;
            _BunifuFlatButton1.OnHoverTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuFlatButton1.selected = false;
            _BunifuFlatButton1.Size = new Size(24, 18);
            _BunifuFlatButton1.TabIndex = 177;
            _BunifuFlatButton1.Text = "🗙";
            _BunifuFlatButton1.TextAlign = ContentAlignment.MiddleCenter;
            _BunifuFlatButton1.Textcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _BunifuFlatButton1.TextFont = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // btnOkExtraCarriers
            // 
            _btnOkExtraCarriers.AllowToggling = false;
            _btnOkExtraCarriers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _btnOkExtraCarriers.AnimationSpeed = 200;
            _btnOkExtraCarriers.AutoGenerateColors = false;
            _btnOkExtraCarriers.BackColor = Color.Transparent;
            _btnOkExtraCarriers.BackColor1 = Color.Teal;
            _btnOkExtraCarriers.BackgroundImage = (Image)resources.GetObject("btnOkExtraCarriers.BackgroundImage");
            _btnOkExtraCarriers.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnOkExtraCarriers.ButtonText = "Ok";
            _btnOkExtraCarriers.ButtonTextMarginLeft = 0;
            _btnOkExtraCarriers.ColorContrastOnClick = 45;
            _btnOkExtraCarriers.ColorContrastOnHover = 45;
            _btnOkExtraCarriers.Cursor = Cursors.Hand;
            BorderEdges35.BottomLeft = true;
            BorderEdges35.BottomRight = true;
            BorderEdges35.TopLeft = true;
            BorderEdges35.TopRight = true;
            _btnOkExtraCarriers.CustomizableEdges = BorderEdges35;
            _btnOkExtraCarriers.DialogResult = DialogResult.None;
            _btnOkExtraCarriers.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnOkExtraCarriers.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnOkExtraCarriers.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnOkExtraCarriers.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnOkExtraCarriers.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnOkExtraCarriers.ForeColor = Color.White;
            _btnOkExtraCarriers.IconLeftCursor = Cursors.Hand;
            _btnOkExtraCarriers.IconMarginLeft = 11;
            _btnOkExtraCarriers.IconPadding = 10;
            _btnOkExtraCarriers.IconRightCursor = Cursors.Hand;
            _btnOkExtraCarriers.IdleBorderColor = Color.Teal;
            _btnOkExtraCarriers.IdleBorderRadius = 3;
            _btnOkExtraCarriers.IdleBorderThickness = 1;
            _btnOkExtraCarriers.IdleFillColor = Color.Teal;
            _btnOkExtraCarriers.IdleIconLeftImage = null;
            _btnOkExtraCarriers.IdleIconRightImage = null;
            _btnOkExtraCarriers.IndicateFocus = false;
            _btnOkExtraCarriers.Location = new Point(150, 173);
            _btnOkExtraCarriers.Margin = new Padding(2);
            _btnOkExtraCarriers.Name = "_btnOkExtraCarriers";
            StateProperties89.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties89.BorderRadius = 3;
            StateProperties89.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties89.BorderThickness = 1;
            StateProperties89.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties89.ForeColor = Color.White;
            StateProperties89.IconLeftImage = null;
            StateProperties89.IconRightImage = null;
            _btnOkExtraCarriers.onHoverState = StateProperties89;
            StateProperties90.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties90.BorderRadius = 3;
            StateProperties90.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties90.BorderThickness = 1;
            StateProperties90.FillColor = Color.Teal;
            StateProperties90.ForeColor = Color.White;
            StateProperties90.IconLeftImage = null;
            StateProperties90.IconRightImage = null;
            _btnOkExtraCarriers.OnPressedState = StateProperties90;
            _btnOkExtraCarriers.Size = new Size(59, 24);
            _btnOkExtraCarriers.TabIndex = 176;
            _btnOkExtraCarriers.TextAlign = ContentAlignment.MiddleCenter;
            _btnOkExtraCarriers.TextMarginLeft = 0;
            _btnOkExtraCarriers.UseDefaultRadiusAndThickness = true;
            // 
            // Label26
            // 
            Label26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label26.AutoSize = true;
            Label26.Font = new Font("Microsoft Sans Serif", 9.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label26.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label26.Location = new Point(112, -2);
            Label26.Margin = new Padding(2, 0, 2, 0);
            Label26.Name = "Label26";
            Label26.Padding = new Padding(0, 5, 0, 0);
            Label26.Size = new Size(131, 21);
            Label26.TabIndex = 58;
            Label26.Text = "Add extra carriers";
            // 
            // dgvExtraCarriers
            // 
            _dgvExtraCarriers.AllowCustomTheming = true;
            _dgvExtraCarriers.AllowUserToAddRows = false;
            _dgvExtraCarriers.AllowUserToDeleteRows = false;
            _dgvExtraCarriers.AllowUserToResizeColumns = false;
            _dgvExtraCarriers.AllowUserToResizeRows = false;
            DataGridViewCellStyle41.BackColor = Color.White;
            DataGridViewCellStyle41.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle41.SelectionBackColor = SystemColors.ButtonFace;
            _dgvExtraCarriers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle41;
            _dgvExtraCarriers.AutoGenerateColumns = false;
            _dgvExtraCarriers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvExtraCarriers.BackgroundColor = Color.White;
            _dgvExtraCarriers.BorderStyle = BorderStyle.None;
            _dgvExtraCarriers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvExtraCarriers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle42.BackColor = Color.Silver;
            DataGridViewCellStyle42.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle42.ForeColor = Color.Black;
            DataGridViewCellStyle42.SelectionBackColor = Color.Silver;
            DataGridViewCellStyle42.SelectionForeColor = Color.Black;
            DataGridViewCellStyle42.WrapMode = DataGridViewTriState.True;
            _dgvExtraCarriers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle42;
            _dgvExtraCarriers.ColumnHeadersHeight = 25;
            _dgvExtraCarriers.Columns.AddRange(new DataGridViewColumn[] { cbCheck, CompanyNameDataGridViewTextBoxColumn });
            _dgvExtraCarriers.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvExtraCarriers.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvExtraCarriers.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvExtraCarriers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = SystemColors.ButtonFace;
            _dgvExtraCarriers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvExtraCarriers.CurrentTheme.BackColor = Color.White;
            _dgvExtraCarriers.CurrentTheme.GridColor = Color.DarkGray;
            _dgvExtraCarriers.CurrentTheme.HeaderStyle.BackColor = Color.Silver;
            _dgvExtraCarriers.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _dgvExtraCarriers.CurrentTheme.HeaderStyle.ForeColor = Color.Black;
            _dgvExtraCarriers.CurrentTheme.Name = null;
            _dgvExtraCarriers.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgvExtraCarriers.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvExtraCarriers.CurrentTheme.RowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvExtraCarriers.CurrentTheme.RowsStyle.SelectionBackColor = SystemColors.ButtonFace;
            _dgvExtraCarriers.CurrentTheme.RowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvExtraCarriers.DataSource = VWCompanyCompanyTypeBindingSource;
            DataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle43.BackColor = Color.White;
            DataGridViewCellStyle43.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle43.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle43.SelectionBackColor = SystemColors.ButtonFace;
            DataGridViewCellStyle43.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle43.WrapMode = DataGridViewTriState.False;
            _dgvExtraCarriers.DefaultCellStyle = DataGridViewCellStyle43;
            _dgvExtraCarriers.EnableHeadersVisualStyles = false;
            _dgvExtraCarriers.GridColor = Color.DarkGray;
            _dgvExtraCarriers.HeaderBackColor = Color.Silver;
            _dgvExtraCarriers.HeaderBgColor = Color.Empty;
            _dgvExtraCarriers.HeaderForeColor = Color.Black;
            _dgvExtraCarriers.Location = new Point(1, 21);
            _dgvExtraCarriers.MultiSelect = false;
            _dgvExtraCarriers.Name = "_dgvExtraCarriers";
            _dgvExtraCarriers.ReadOnly = true;
            _dgvExtraCarriers.RowHeadersVisible = false;
            _dgvExtraCarriers.RowHeadersWidth = 30;
            _dgvExtraCarriers.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonFace;
            _dgvExtraCarriers.RowTemplate.Height = 25;
            _dgvExtraCarriers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvExtraCarriers.Size = new Size(357, 152);
            _dgvExtraCarriers.TabIndex = 57;
            _dgvExtraCarriers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // VWCompanyCompanyTypeBindingSource
            // 
            VWCompanyCompanyTypeBindingSource.DataSource = typeof(ModelLayer.VW_CompanyCompanyType);
            // 
            // closeFlatButton
            // 
            _closeFlatButton.Active = false;
            _closeFlatButton.Activecolor = Color.White;
            _closeFlatButton.BackColor = Color.White;
            _closeFlatButton.BackgroundImageLayout = ImageLayout.Zoom;
            _closeFlatButton.BorderRadius = 0;
            _closeFlatButton.ButtonText = "";
            _closeFlatButton.Cursor = Cursors.Hand;
            _closeFlatButton.DisabledColor = Color.Gray;
            _closeFlatButton.Iconcolor = Color.White;
            _closeFlatButton.Iconimage = My.Resources.Resources.settings;
            _closeFlatButton.Iconimage_right = null;
            _closeFlatButton.Iconimage_right_Selected = null;
            _closeFlatButton.Iconimage_Selected = null;
            _closeFlatButton.IconMarginLeft = 0;
            _closeFlatButton.IconMarginRight = 0;
            _closeFlatButton.IconRightVisible = true;
            _closeFlatButton.IconRightZoom = 0d;
            _closeFlatButton.IconVisible = true;
            _closeFlatButton.IconZoom = 50.0d;
            _closeFlatButton.IsTab = false;
            _closeFlatButton.Location = new Point(1079, 242);
            _closeFlatButton.Margin = new Padding(2);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.White;
            _closeFlatButton.OnHovercolor = Color.Silver;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(33, 30);
            _closeFlatButton.TabIndex = 167;
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // warningLabel
            // 
            warningLabel.AutoSize = true;
            warningLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            warningLabel.ForeColor = Color.Firebrick;
            warningLabel.Location = new Point(554, 19);
            warningLabel.Margin = new Padding(0);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(0, 21);
            warningLabel.TabIndex = 202;
            warningLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(_dgvTest);
            Panel1.Location = new Point(32, 274);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1083, 546);
            Panel1.TabIndex = 113;
            // 
            // dgvTest
            // 
            _dgvTest.AllowCustomTheming = true;
            _dgvTest.AllowUserToAddRows = false;
            _dgvTest.AllowUserToDeleteRows = false;
            _dgvTest.AllowUserToOrderColumns = true;
            _dgvTest.AllowUserToResizeRows = false;
            DataGridViewCellStyle44.BackColor = Color.White;
            DataGridViewCellStyle44.ForeColor = Color.Black;
            DataGridViewCellStyle44.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvTest.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle44;
            _dgvTest.AutoGenerateColumns = false;
            _dgvTest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvTest.BackgroundColor = Color.White;
            _dgvTest.BorderStyle = BorderStyle.None;
            _dgvTest.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvTest.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _dgvTest.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle45.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle45.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle45.ForeColor = Color.White;
            DataGridViewCellStyle45.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle45.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle45.WrapMode = DataGridViewTriState.True;
            _dgvTest.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle45;
            _dgvTest.ColumnHeadersHeight = 35;
            _dgvTest.Columns.AddRange(new DataGridViewColumn[] { UniqueIDDataGridViewTextBoxColumn, rate, rateType, ContainerNumbDataGridViewTextBoxColumn, BkrelNumberDataGridViewTextBoxColumn, pickUpCode, dropOffCode, GateDateTime, TruckIDDataGridViewTextBoxColumn, truckDriverId, DriverNameDataGridViewTextBoxColumn, StreetTurnDataGridViewTextBoxColumn, CarrierCodeDataGridViewTextBoxColumn, CarrierNameDataGridViewTextBoxColumn, DrayageTypeDataGridViewTextBoxColumn });
            _dgvTest.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvTest.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvTest.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvTest.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvTest.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvTest.CurrentTheme.BackColor = Color.Snow;
            _dgvTest.CurrentTheme.GridColor = Color.Gray;
            _dgvTest.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvTest.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvTest.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvTest.CurrentTheme.Name = null;
            _dgvTest.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvTest.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvTest.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvTest.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvTest.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvTest.DataSource = ContainersInOutDrayageBindingSource;
            DataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle46.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle46.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle46.ForeColor = Color.Black;
            DataGridViewCellStyle46.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle46.SelectionForeColor = Color.Black;
            DataGridViewCellStyle46.WrapMode = DataGridViewTriState.False;
            _dgvTest.DefaultCellStyle = DataGridViewCellStyle46;
            _dgvTest.Dock = DockStyle.Fill;
            _dgvTest.EnableHeadersVisualStyles = false;
            _dgvTest.GridColor = Color.Gray;
            _dgvTest.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvTest.HeaderBgColor = Color.Empty;
            _dgvTest.HeaderForeColor = Color.White;
            _dgvTest.Location = new Point(0, 0);
            _dgvTest.Name = "_dgvTest";
            _dgvTest.ReadOnly = true;
            _dgvTest.RowHeadersVisible = false;
            _dgvTest.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvTest.RowTemplate.Height = 30;
            _dgvTest.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _dgvTest.Size = new Size(1081, 544);
            _dgvTest.TabIndex = 57;
            _dgvTest.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // UniqueIDDataGridViewTextBoxColumn
            // 
            UniqueIDDataGridViewTextBoxColumn.DataPropertyName = "Unique_ID";
            UniqueIDDataGridViewTextBoxColumn.HeaderText = "Unique_ID";
            UniqueIDDataGridViewTextBoxColumn.Name = "UniqueIDDataGridViewTextBoxColumn";
            UniqueIDDataGridViewTextBoxColumn.ReadOnly = true;
            UniqueIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // rate
            // 
            rate.DataPropertyName = "rate";
            rate.FillWeight = 67.36669f;
            rate.HeaderText = "Cost";
            rate.Name = "rate";
            rate.ReadOnly = true;
            // 
            // rateType
            // 
            rateType.DataPropertyName = "rateType";
            rateType.FillWeight = 98.62072f;
            rateType.HeaderText = "Status";
            rateType.Name = "rateType";
            rateType.ReadOnly = true;
            // 
            // ContainerNumbDataGridViewTextBoxColumn
            // 
            ContainerNumbDataGridViewTextBoxColumn.DataPropertyName = "containerNumb";
            ContainerNumbDataGridViewTextBoxColumn.FillWeight = 126.4619f;
            ContainerNumbDataGridViewTextBoxColumn.HeaderText = "Container #";
            ContainerNumbDataGridViewTextBoxColumn.Name = "ContainerNumbDataGridViewTextBoxColumn";
            ContainerNumbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BkrelNumberDataGridViewTextBoxColumn
            // 
            BkrelNumberDataGridViewTextBoxColumn.DataPropertyName = "bkrelNumber";
            BkrelNumberDataGridViewTextBoxColumn.FillWeight = 115.3839f;
            BkrelNumberDataGridViewTextBoxColumn.HeaderText = "Booking #";
            BkrelNumberDataGridViewTextBoxColumn.Name = "BkrelNumberDataGridViewTextBoxColumn";
            BkrelNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pickUpCode
            // 
            pickUpCode.DataPropertyName = "pickUpCode";
            pickUpCode.FillWeight = 96.17241f;
            pickUpCode.HeaderText = "Pick Up";
            pickUpCode.Name = "pickUpCode";
            pickUpCode.ReadOnly = true;
            // 
            // dropOffCode
            // 
            dropOffCode.DataPropertyName = "dropOffCode";
            dropOffCode.FillWeight = 96.17241f;
            dropOffCode.HeaderText = "Drop Off";
            dropOffCode.Name = "dropOffCode";
            dropOffCode.ReadOnly = true;
            // 
            // GateDateTime
            // 
            GateDateTime.DataPropertyName = "GateDateTime";
            GateDateTime.FillWeight = 125.6343f;
            GateDateTime.HeaderText = "Date/Time";
            GateDateTime.Name = "GateDateTime";
            GateDateTime.ReadOnly = true;
            // 
            // TruckIDDataGridViewTextBoxColumn
            // 
            TruckIDDataGridViewTextBoxColumn.DataPropertyName = "truckID";
            TruckIDDataGridViewTextBoxColumn.FillWeight = 103.4798f;
            TruckIDDataGridViewTextBoxColumn.HeaderText = "Truck ID";
            TruckIDDataGridViewTextBoxColumn.Name = "TruckIDDataGridViewTextBoxColumn";
            TruckIDDataGridViewTextBoxColumn.ReadOnly = true;
            TruckIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // truckDriverId
            // 
            truckDriverId.DataPropertyName = "truckDriverId";
            truckDriverId.FillWeight = 87.76475f;
            truckDriverId.HeaderText = "Driver ID";
            truckDriverId.Name = "truckDriverId";
            truckDriverId.ReadOnly = true;
            // 
            // DriverNameDataGridViewTextBoxColumn
            // 
            DriverNameDataGridViewTextBoxColumn.DataPropertyName = "driverName";
            DriverNameDataGridViewTextBoxColumn.FillWeight = 120.6362f;
            DriverNameDataGridViewTextBoxColumn.HeaderText = "Driver";
            DriverNameDataGridViewTextBoxColumn.Name = "DriverNameDataGridViewTextBoxColumn";
            DriverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StreetTurnDataGridViewTextBoxColumn
            // 
            StreetTurnDataGridViewTextBoxColumn.DataPropertyName = "streetTurn";
            StreetTurnDataGridViewTextBoxColumn.HeaderText = "streetTurn";
            StreetTurnDataGridViewTextBoxColumn.Name = "StreetTurnDataGridViewTextBoxColumn";
            StreetTurnDataGridViewTextBoxColumn.ReadOnly = true;
            StreetTurnDataGridViewTextBoxColumn.Visible = false;
            // 
            // CarrierCodeDataGridViewTextBoxColumn
            // 
            CarrierCodeDataGridViewTextBoxColumn.DataPropertyName = "carrierCode";
            CarrierCodeDataGridViewTextBoxColumn.FillWeight = 62.30655f;
            CarrierCodeDataGridViewTextBoxColumn.HeaderText = "Carrier";
            CarrierCodeDataGridViewTextBoxColumn.Name = "CarrierCodeDataGridViewTextBoxColumn";
            CarrierCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CarrierNameDataGridViewTextBoxColumn
            // 
            CarrierNameDataGridViewTextBoxColumn.DataPropertyName = "carrierName";
            CarrierNameDataGridViewTextBoxColumn.HeaderText = "carrierName";
            CarrierNameDataGridViewTextBoxColumn.Name = "CarrierNameDataGridViewTextBoxColumn";
            CarrierNameDataGridViewTextBoxColumn.ReadOnly = true;
            CarrierNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // DrayageTypeDataGridViewTextBoxColumn
            // 
            DrayageTypeDataGridViewTextBoxColumn.DataPropertyName = "drayageType";
            DrayageTypeDataGridViewTextBoxColumn.HeaderText = "drayageType";
            DrayageTypeDataGridViewTextBoxColumn.Name = "DrayageTypeDataGridViewTextBoxColumn";
            DrayageTypeDataGridViewTextBoxColumn.ReadOnly = true;
            DrayageTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // ContainersInOutDrayageBindingSource
            // 
            ContainersInOutDrayageBindingSource.DataSource = typeof(ModelLayer.VW_ContainersInOutDrayage);
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(TableLayoutPanel1);
            GroupBox2.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            GroupBox2.Location = new Point(1152, 68);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(492, 201);
            GroupBox2.TabIndex = 178;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Services:";
            GroupBox2.Visible = false;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 3;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.63682f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.36318f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95.0f));
            TableLayoutPanel1.Controls.Add(Panel7, 1, 0);
            TableLayoutPanel1.Controls.Add(Label7, 0, 0);
            TableLayoutPanel1.Location = new Point(6, 22);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.57143f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 173.0f));
            TableLayoutPanel1.Size = new Size(474, 173);
            TableLayoutPanel1.TabIndex = 126;
            // 
            // Panel7
            // 
            Panel7.BorderStyle = BorderStyle.FixedSingle;
            Panel7.Controls.Add(_addedServDataGridView);
            Panel7.Location = new Point(88, 3);
            Panel7.Name = "Panel7";
            Panel7.Size = new Size(287, 167);
            Panel7.TabIndex = 137;
            // 
            // addedServDataGridView
            // 
            _addedServDataGridView.AllowCustomTheming = true;
            _addedServDataGridView.AllowUserToAddRows = false;
            _addedServDataGridView.AllowUserToDeleteRows = false;
            _addedServDataGridView.AllowUserToOrderColumns = true;
            _addedServDataGridView.AllowUserToResizeRows = false;
            DataGridViewCellStyle47.BackColor = Color.White;
            DataGridViewCellStyle47.ForeColor = Color.Black;
            DataGridViewCellStyle47.SelectionBackColor = Color.Silver;
            DataGridViewCellStyle47.SelectionForeColor = Color.Black;
            _addedServDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle47;
            _addedServDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _addedServDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _addedServDataGridView.BackgroundColor = Color.White;
            _addedServDataGridView.BorderStyle = BorderStyle.None;
            _addedServDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _addedServDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _addedServDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle48.BackColor = Color.White;
            DataGridViewCellStyle48.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle48.ForeColor = Color.White;
            DataGridViewCellStyle48.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle48.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle48.WrapMode = DataGridViewTriState.True;
            _addedServDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle48;
            _addedServDataGridView.ColumnHeadersHeight = 40;
            _addedServDataGridView.ColumnHeadersVisible = false;
            _addedServDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, delCol, Column3, Column8 });
            _addedServDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _addedServDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _addedServDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _addedServDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.White;
            _addedServDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _addedServDataGridView.CurrentTheme.BackColor = Color.Snow;
            _addedServDataGridView.CurrentTheme.GridColor = Color.White;
            _addedServDataGridView.CurrentTheme.HeaderStyle.BackColor = Color.White;
            _addedServDataGridView.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _addedServDataGridView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _addedServDataGridView.CurrentTheme.Name = null;
            _addedServDataGridView.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _addedServDataGridView.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _addedServDataGridView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _addedServDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = Color.Snow;
            _addedServDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle50.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle50.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle50.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle50.ForeColor = Color.Black;
            DataGridViewCellStyle50.SelectionBackColor = Color.Snow;
            DataGridViewCellStyle50.SelectionForeColor = Color.Black;
            DataGridViewCellStyle50.WrapMode = DataGridViewTriState.False;
            _addedServDataGridView.DefaultCellStyle = DataGridViewCellStyle50;
            _addedServDataGridView.Dock = DockStyle.Fill;
            _addedServDataGridView.EnableHeadersVisualStyles = false;
            _addedServDataGridView.GridColor = Color.White;
            _addedServDataGridView.HeaderBackColor = Color.White;
            _addedServDataGridView.HeaderBgColor = Color.Empty;
            _addedServDataGridView.HeaderForeColor = Color.White;
            _addedServDataGridView.Location = new Point(0, 0);
            _addedServDataGridView.MultiSelect = false;
            _addedServDataGridView.Name = "_addedServDataGridView";
            _addedServDataGridView.ReadOnly = true;
            _addedServDataGridView.RowHeadersVisible = false;
            _addedServDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _addedServDataGridView.RowTemplate.Height = 30;
            _addedServDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _addedServDataGridView.Size = new Size(285, 165);
            _addedServDataGridView.TabIndex = 124;
            _addedServDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.HeaderText = "Type Of service";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            DataGridViewTextBoxColumn1.Visible = false;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.HeaderText = "serviceID";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            DataGridViewTextBoxColumn2.Visible = false;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.FillWeight = 219.7405f;
            DataGridViewTextBoxColumn3.HeaderText = "Service";
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // delCol
            // 
            DataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle49.BackColor = Color.Firebrick;
            DataGridViewCellStyle49.Font = new Font("Segoe UI Semibold", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle49.ForeColor = Color.White;
            DataGridViewCellStyle49.NullValue = "X";
            DataGridViewCellStyle49.SelectionBackColor = Color.Firebrick;
            DataGridViewCellStyle49.SelectionForeColor = Color.White;
            delCol.DefaultCellStyle = DataGridViewCellStyle49;
            delCol.FillWeight = 24.82943f;
            delCol.FlatStyle = FlatStyle.Flat;
            delCol.HeaderText = "delCol";
            delCol.Name = "delCol";
            delCol.ReadOnly = true;
            delCol.Text = "X";
            // 
            // Column3
            // 
            Column3.HeaderText = "from";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // Column8
            // 
            Column8.HeaderText = "to";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Visible = false;
            // 
            // Label7
            // 
            Label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Location = new Point(15, 0);
            Label7.Margin = new Padding(0);
            Label7.Name = "Label7";
            Label7.Size = new Size(70, 42);
            Label7.TabIndex = 123;
            Label7.Text = "Added Services:";
            Label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(FlowLayoutPanel1);
            GroupBox1.Controls.Add(Label28);
            GroupBox1.Controls.Add(_btnAddCarrier);
            GroupBox1.Controls.Add(_btnRemoveDate);
            GroupBox1.Controls.Add(_cboMultiEmpty);
            GroupBox1.Controls.Add(_cboSingleLoad);
            GroupBox1.Controls.Add(_cboMultiLoad);
            GroupBox1.Controls.Add(_cbxSingleEmpty);
            GroupBox1.Controls.Add(Label25);
            GroupBox1.Controls.Add(cboDriverId);
            GroupBox1.Controls.Add(Label24);
            GroupBox1.Controls.Add(_cboDropOff);
            GroupBox1.Controls.Add(Label20);
            GroupBox1.Controls.Add(_cboPickUp);
            GroupBox1.Controls.Add(Label19);
            GroupBox1.Controls.Add(Label18);
            GroupBox1.Controls.Add(Label15);
            GroupBox1.Controls.Add(Label13);
            GroupBox1.Controls.Add(Label6);
            GroupBox1.Controls.Add(Label4);
            GroupBox1.Controls.Add(_cboBookingNumber);
            GroupBox1.Controls.Add(streetTurnToggleSwitch);
            GroupBox1.Controls.Add(toIDatePicker);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(_fromDatePicker);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(_cboTruckingCompany);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 9.163636f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            GroupBox1.Location = new Point(56, 38);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(846, 234);
            GroupBox1.TabIndex = 177;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Filters";
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            FlowLayoutPanel1.Controls.Add(lblExtraCarrier);
            FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel1.Location = new Point(130, 48);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(381, 58);
            FlowLayoutPanel1.TabIndex = 207;
            // 
            // lblExtraCarrier
            // 
            lblExtraCarrier.AutoSize = true;
            lblExtraCarrier.Dock = DockStyle.Fill;
            lblExtraCarrier.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblExtraCarrier.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblExtraCarrier.Location = new Point(0, 0);
            lblExtraCarrier.Margin = new Padding(0);
            lblExtraCarrier.Name = "lblExtraCarrier";
            lblExtraCarrier.Size = new Size(0, 17);
            lblExtraCarrier.TabIndex = 206;
            // 
            // Label28
            // 
            Label28.AutoSize = true;
            Label28.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label28.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label28.Location = new Point(19, 50);
            Label28.Margin = new Padding(0);
            Label28.Name = "Label28";
            Label28.Size = new Size(106, 21);
            Label28.TabIndex = 204;
            Label28.Text = "Extra Carriers:";
            Label28.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddCarrier
            // 
            _btnAddCarrier.AllowToggling = false;
            _btnAddCarrier.AnimationSpeed = 200;
            _btnAddCarrier.AutoGenerateColors = false;
            _btnAddCarrier.BackColor = Color.Transparent;
            _btnAddCarrier.BackColor1 = Color.White;
            _btnAddCarrier.BackgroundImage = (Image)resources.GetObject("btnAddCarrier.BackgroundImage");
            _btnAddCarrier.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddCarrier.ButtonText = "";
            _btnAddCarrier.ButtonTextMarginLeft = 0;
            _btnAddCarrier.ColorContrastOnClick = 45;
            _btnAddCarrier.ColorContrastOnHover = 45;
            _btnAddCarrier.Cursor = Cursors.Hand;
            BorderEdges29.BottomLeft = true;
            BorderEdges29.BottomRight = true;
            BorderEdges29.TopLeft = true;
            BorderEdges29.TopRight = true;
            _btnAddCarrier.CustomizableEdges = BorderEdges29;
            _btnAddCarrier.DialogResult = DialogResult.None;
            _btnAddCarrier.DisabledBorderColor = Color.Empty;
            _btnAddCarrier.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddCarrier.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddCarrier.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddCarrier.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnAddCarrier.ForeColor = Color.White;
            _btnAddCarrier.IconLeftCursor = Cursors.Hand;
            _btnAddCarrier.IconMarginLeft = 2;
            _btnAddCarrier.IconPadding = 2;
            _btnAddCarrier.IconRightCursor = Cursors.Hand;
            _btnAddCarrier.IdleBorderColor = Color.White;
            _btnAddCarrier.IdleBorderRadius = 5;
            _btnAddCarrier.IdleBorderThickness = 1;
            _btnAddCarrier.IdleFillColor = Color.White;
            _btnAddCarrier.IdleIconLeftImage = My.Resources.Resources.add;
            _btnAddCarrier.IdleIconRightImage = null;
            _btnAddCarrier.IndicateFocus = false;
            _btnAddCarrier.Location = new Point(517, 51);
            _btnAddCarrier.Name = "_btnAddCarrier";
            StateProperties73.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties73.BorderRadius = 5;
            StateProperties73.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties73.BorderThickness = 1;
            StateProperties73.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties73.ForeColor = Color.White;
            StateProperties73.IconLeftImage = null;
            StateProperties73.IconRightImage = null;
            _btnAddCarrier.onHoverState = StateProperties73;
            StateProperties74.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties74.BorderRadius = 5;
            StateProperties74.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties74.BorderThickness = 1;
            StateProperties74.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties74.ForeColor = Color.White;
            StateProperties74.IconLeftImage = null;
            StateProperties74.IconRightImage = null;
            _btnAddCarrier.OnPressedState = StateProperties74;
            _btnAddCarrier.Size = new Size(23, 22);
            _btnAddCarrier.TabIndex = 203;
            _btnAddCarrier.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddCarrier.TextMarginLeft = 0;
            _btnAddCarrier.UseDefaultRadiusAndThickness = true;
            _btnAddCarrier.Visible = false;
            // 
            // btnRemoveDate
            // 
            _btnRemoveDate.AllowToggling = false;
            _btnRemoveDate.AnimationSpeed = 200;
            _btnRemoveDate.AutoGenerateColors = false;
            _btnRemoveDate.BackColor = Color.Transparent;
            _btnRemoveDate.BackColor1 = Color.White;
            _btnRemoveDate.BackgroundImage = (Image)resources.GetObject("btnRemoveDate.BackgroundImage");
            _btnRemoveDate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnRemoveDate.ButtonText = "";
            _btnRemoveDate.ButtonTextMarginLeft = 0;
            _btnRemoveDate.ColorContrastOnClick = 45;
            _btnRemoveDate.ColorContrastOnHover = 45;
            _btnRemoveDate.Cursor = Cursors.Hand;
            BorderEdges30.BottomLeft = true;
            BorderEdges30.BottomRight = true;
            BorderEdges30.TopLeft = true;
            BorderEdges30.TopRight = true;
            _btnRemoveDate.CustomizableEdges = BorderEdges30;
            _btnRemoveDate.DialogResult = DialogResult.None;
            _btnRemoveDate.DisabledBorderColor = Color.Empty;
            _btnRemoveDate.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnRemoveDate.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnRemoveDate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnRemoveDate.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnRemoveDate.ForeColor = Color.White;
            _btnRemoveDate.IconLeftCursor = Cursors.Hand;
            _btnRemoveDate.IconMarginLeft = 2;
            _btnRemoveDate.IconPadding = 2;
            _btnRemoveDate.IconRightCursor = Cursors.Hand;
            _btnRemoveDate.IdleBorderColor = Color.White;
            _btnRemoveDate.IdleBorderRadius = 5;
            _btnRemoveDate.IdleBorderThickness = 1;
            _btnRemoveDate.IdleFillColor = Color.White;
            _btnRemoveDate.IdleIconLeftImage = My.Resources.Resources.removeRedBall;
            _btnRemoveDate.IdleIconRightImage = null;
            _btnRemoveDate.IndicateFocus = false;
            _btnRemoveDate.Location = new Point(800, 41);
            _btnRemoveDate.Name = "_btnRemoveDate";
            StateProperties75.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties75.BorderRadius = 5;
            StateProperties75.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties75.BorderThickness = 1;
            StateProperties75.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties75.ForeColor = Color.White;
            StateProperties75.IconLeftImage = null;
            StateProperties75.IconRightImage = null;
            _btnRemoveDate.onHoverState = StateProperties75;
            StateProperties76.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties76.BorderRadius = 5;
            StateProperties76.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties76.BorderThickness = 1;
            StateProperties76.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties76.ForeColor = Color.White;
            StateProperties76.IconLeftImage = null;
            StateProperties76.IconRightImage = null;
            _btnRemoveDate.OnPressedState = StateProperties76;
            _btnRemoveDate.Size = new Size(25, 26);
            _btnRemoveDate.TabIndex = 202;
            _btnRemoveDate.TextAlign = ContentAlignment.MiddleCenter;
            _btnRemoveDate.TextMarginLeft = 0;
            _btnRemoveDate.UseDefaultRadiusAndThickness = true;
            _btnRemoveDate.Visible = false;
            // 
            // cboMultiEmpty
            // 
            _cboMultiEmpty.AllowBindingControlAnimation = true;
            _cboMultiEmpty.AllowBindingControlColorChanges = false;
            _cboMultiEmpty.AllowBindingControlLocation = true;
            _cboMultiEmpty.AllowCheckBoxAnimation = false;
            _cboMultiEmpty.AllowCheckmarkAnimation = true;
            _cboMultiEmpty.AllowOnHoverStates = true;
            _cboMultiEmpty.AutoCheck = true;
            _cboMultiEmpty.BackColor = Color.Transparent;
            _cboMultiEmpty.BackgroundImage = (Image)resources.GetObject("cboMultiEmpty.BackgroundImage");
            _cboMultiEmpty.BackgroundImageLayout = ImageLayout.Zoom;
            _cboMultiEmpty.BindingControl = null;
            _cboMultiEmpty.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            _cboMultiEmpty.Checked = true;
            _cboMultiEmpty.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            _cboMultiEmpty.Cursor = Cursors.Hand;
            _cboMultiEmpty.CustomCheckmarkImage = null;
            _cboMultiEmpty.Location = new Point(630, 111);
            _cboMultiEmpty.MinimumSize = new Size(17, 17);
            _cboMultiEmpty.Name = "_cboMultiEmpty";
            _cboMultiEmpty.OnCheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboMultiEmpty.OnCheck.BorderRadius = 2;
            _cboMultiEmpty.OnCheck.BorderThickness = 2;
            _cboMultiEmpty.OnCheck.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboMultiEmpty.OnCheck.CheckmarkColor = Color.White;
            _cboMultiEmpty.OnCheck.CheckmarkThickness = 2;
            _cboMultiEmpty.OnDisable.BorderColor = Color.LightGray;
            _cboMultiEmpty.OnDisable.BorderRadius = 2;
            _cboMultiEmpty.OnDisable.BorderThickness = 2;
            _cboMultiEmpty.OnDisable.CheckBoxColor = Color.Transparent;
            _cboMultiEmpty.OnDisable.CheckmarkColor = Color.LightGray;
            _cboMultiEmpty.OnDisable.CheckmarkThickness = 2;
            _cboMultiEmpty.OnHoverChecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboMultiEmpty.OnHoverChecked.BorderRadius = 2;
            _cboMultiEmpty.OnHoverChecked.BorderThickness = 2;
            _cboMultiEmpty.OnHoverChecked.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboMultiEmpty.OnHoverChecked.CheckmarkColor = Color.White;
            _cboMultiEmpty.OnHoverChecked.CheckmarkThickness = 2;
            _cboMultiEmpty.OnHoverUnchecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboMultiEmpty.OnHoverUnchecked.BorderRadius = 2;
            _cboMultiEmpty.OnHoverUnchecked.BorderThickness = 2;
            _cboMultiEmpty.OnHoverUnchecked.CheckBoxColor = Color.Transparent;
            _cboMultiEmpty.OnUncheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboMultiEmpty.OnUncheck.BorderRadius = 2;
            _cboMultiEmpty.OnUncheck.BorderThickness = 2;
            _cboMultiEmpty.OnUncheck.CheckBoxColor = Color.Transparent;
            _cboMultiEmpty.Size = new Size(21, 21);
            _cboMultiEmpty.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            _cboMultiEmpty.TabIndex = 201;
            _cboMultiEmpty.ThreeState = false;
            _cboMultiEmpty.ToolTipText = null;
            // 
            // cboSingleLoad
            // 
            _cboSingleLoad.AllowBindingControlAnimation = true;
            _cboSingleLoad.AllowBindingControlColorChanges = false;
            _cboSingleLoad.AllowBindingControlLocation = true;
            _cboSingleLoad.AllowCheckBoxAnimation = false;
            _cboSingleLoad.AllowCheckmarkAnimation = true;
            _cboSingleLoad.AllowOnHoverStates = true;
            _cboSingleLoad.AutoCheck = true;
            _cboSingleLoad.BackColor = Color.Transparent;
            _cboSingleLoad.BackgroundImage = (Image)resources.GetObject("cboSingleLoad.BackgroundImage");
            _cboSingleLoad.BackgroundImageLayout = ImageLayout.Zoom;
            _cboSingleLoad.BindingControl = null;
            _cboSingleLoad.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            _cboSingleLoad.Checked = true;
            _cboSingleLoad.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            _cboSingleLoad.Cursor = Cursors.Hand;
            _cboSingleLoad.CustomCheckmarkImage = null;
            _cboSingleLoad.Location = new Point(630, 132);
            _cboSingleLoad.MinimumSize = new Size(17, 17);
            _cboSingleLoad.Name = "_cboSingleLoad";
            _cboSingleLoad.OnCheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboSingleLoad.OnCheck.BorderRadius = 2;
            _cboSingleLoad.OnCheck.BorderThickness = 2;
            _cboSingleLoad.OnCheck.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboSingleLoad.OnCheck.CheckmarkColor = Color.White;
            _cboSingleLoad.OnCheck.CheckmarkThickness = 2;
            _cboSingleLoad.OnDisable.BorderColor = Color.LightGray;
            _cboSingleLoad.OnDisable.BorderRadius = 2;
            _cboSingleLoad.OnDisable.BorderThickness = 2;
            _cboSingleLoad.OnDisable.CheckBoxColor = Color.Transparent;
            _cboSingleLoad.OnDisable.CheckmarkColor = Color.LightGray;
            _cboSingleLoad.OnDisable.CheckmarkThickness = 2;
            _cboSingleLoad.OnHoverChecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboSingleLoad.OnHoverChecked.BorderRadius = 2;
            _cboSingleLoad.OnHoverChecked.BorderThickness = 2;
            _cboSingleLoad.OnHoverChecked.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboSingleLoad.OnHoverChecked.CheckmarkColor = Color.White;
            _cboSingleLoad.OnHoverChecked.CheckmarkThickness = 2;
            _cboSingleLoad.OnHoverUnchecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboSingleLoad.OnHoverUnchecked.BorderRadius = 2;
            _cboSingleLoad.OnHoverUnchecked.BorderThickness = 2;
            _cboSingleLoad.OnHoverUnchecked.CheckBoxColor = Color.Transparent;
            _cboSingleLoad.OnUncheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboSingleLoad.OnUncheck.BorderRadius = 2;
            _cboSingleLoad.OnUncheck.BorderThickness = 2;
            _cboSingleLoad.OnUncheck.CheckBoxColor = Color.Transparent;
            _cboSingleLoad.Size = new Size(21, 21);
            _cboSingleLoad.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            _cboSingleLoad.TabIndex = 200;
            _cboSingleLoad.ThreeState = false;
            _cboSingleLoad.ToolTipText = null;
            // 
            // cboMultiLoad
            // 
            _cboMultiLoad.AllowBindingControlAnimation = true;
            _cboMultiLoad.AllowBindingControlColorChanges = false;
            _cboMultiLoad.AllowBindingControlLocation = true;
            _cboMultiLoad.AllowCheckBoxAnimation = false;
            _cboMultiLoad.AllowCheckmarkAnimation = true;
            _cboMultiLoad.AllowOnHoverStates = true;
            _cboMultiLoad.AutoCheck = true;
            _cboMultiLoad.BackColor = Color.Transparent;
            _cboMultiLoad.BackgroundImage = (Image)resources.GetObject("cboMultiLoad.BackgroundImage");
            _cboMultiLoad.BackgroundImageLayout = ImageLayout.Zoom;
            _cboMultiLoad.BindingControl = null;
            _cboMultiLoad.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            _cboMultiLoad.Checked = true;
            _cboMultiLoad.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            _cboMultiLoad.Cursor = Cursors.Hand;
            _cboMultiLoad.CustomCheckmarkImage = null;
            _cboMultiLoad.Location = new Point(630, 153);
            _cboMultiLoad.MinimumSize = new Size(17, 17);
            _cboMultiLoad.Name = "_cboMultiLoad";
            _cboMultiLoad.OnCheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboMultiLoad.OnCheck.BorderRadius = 2;
            _cboMultiLoad.OnCheck.BorderThickness = 2;
            _cboMultiLoad.OnCheck.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboMultiLoad.OnCheck.CheckmarkColor = Color.White;
            _cboMultiLoad.OnCheck.CheckmarkThickness = 2;
            _cboMultiLoad.OnDisable.BorderColor = Color.LightGray;
            _cboMultiLoad.OnDisable.BorderRadius = 2;
            _cboMultiLoad.OnDisable.BorderThickness = 2;
            _cboMultiLoad.OnDisable.CheckBoxColor = Color.Transparent;
            _cboMultiLoad.OnDisable.CheckmarkColor = Color.LightGray;
            _cboMultiLoad.OnDisable.CheckmarkThickness = 2;
            _cboMultiLoad.OnHoverChecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboMultiLoad.OnHoverChecked.BorderRadius = 2;
            _cboMultiLoad.OnHoverChecked.BorderThickness = 2;
            _cboMultiLoad.OnHoverChecked.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboMultiLoad.OnHoverChecked.CheckmarkColor = Color.White;
            _cboMultiLoad.OnHoverChecked.CheckmarkThickness = 2;
            _cboMultiLoad.OnHoverUnchecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboMultiLoad.OnHoverUnchecked.BorderRadius = 2;
            _cboMultiLoad.OnHoverUnchecked.BorderThickness = 2;
            _cboMultiLoad.OnHoverUnchecked.CheckBoxColor = Color.Transparent;
            _cboMultiLoad.OnUncheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cboMultiLoad.OnUncheck.BorderRadius = 2;
            _cboMultiLoad.OnUncheck.BorderThickness = 2;
            _cboMultiLoad.OnUncheck.CheckBoxColor = Color.Transparent;
            _cboMultiLoad.Size = new Size(21, 21);
            _cboMultiLoad.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            _cboMultiLoad.TabIndex = 199;
            _cboMultiLoad.ThreeState = false;
            _cboMultiLoad.ToolTipText = null;
            // 
            // cbxSingleEmpty
            // 
            _cbxSingleEmpty.AllowBindingControlAnimation = true;
            _cbxSingleEmpty.AllowBindingControlColorChanges = false;
            _cbxSingleEmpty.AllowBindingControlLocation = true;
            _cbxSingleEmpty.AllowCheckBoxAnimation = false;
            _cbxSingleEmpty.AllowCheckmarkAnimation = true;
            _cbxSingleEmpty.AllowOnHoverStates = true;
            _cbxSingleEmpty.AutoCheck = true;
            _cbxSingleEmpty.BackColor = Color.Transparent;
            _cbxSingleEmpty.BackgroundImage = (Image)resources.GetObject("cbxSingleEmpty.BackgroundImage");
            _cbxSingleEmpty.BackgroundImageLayout = ImageLayout.Zoom;
            _cbxSingleEmpty.BindingControl = null;
            _cbxSingleEmpty.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            _cbxSingleEmpty.Checked = true;
            _cbxSingleEmpty.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            _cbxSingleEmpty.Cursor = Cursors.Hand;
            _cbxSingleEmpty.CustomCheckmarkImage = null;
            _cbxSingleEmpty.Location = new Point(630, 90);
            _cbxSingleEmpty.MinimumSize = new Size(17, 17);
            _cbxSingleEmpty.Name = "_cbxSingleEmpty";
            _cbxSingleEmpty.OnCheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cbxSingleEmpty.OnCheck.BorderRadius = 2;
            _cbxSingleEmpty.OnCheck.BorderThickness = 2;
            _cbxSingleEmpty.OnCheck.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cbxSingleEmpty.OnCheck.CheckmarkColor = Color.White;
            _cbxSingleEmpty.OnCheck.CheckmarkThickness = 2;
            _cbxSingleEmpty.OnDisable.BorderColor = Color.LightGray;
            _cbxSingleEmpty.OnDisable.BorderRadius = 2;
            _cbxSingleEmpty.OnDisable.BorderThickness = 2;
            _cbxSingleEmpty.OnDisable.CheckBoxColor = Color.Transparent;
            _cbxSingleEmpty.OnDisable.CheckmarkColor = Color.LightGray;
            _cbxSingleEmpty.OnDisable.CheckmarkThickness = 2;
            _cbxSingleEmpty.OnHoverChecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cbxSingleEmpty.OnHoverChecked.BorderRadius = 2;
            _cbxSingleEmpty.OnHoverChecked.BorderThickness = 2;
            _cbxSingleEmpty.OnHoverChecked.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cbxSingleEmpty.OnHoverChecked.CheckmarkColor = Color.White;
            _cbxSingleEmpty.OnHoverChecked.CheckmarkThickness = 2;
            _cbxSingleEmpty.OnHoverUnchecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cbxSingleEmpty.OnHoverUnchecked.BorderRadius = 2;
            _cbxSingleEmpty.OnHoverUnchecked.BorderThickness = 2;
            _cbxSingleEmpty.OnHoverUnchecked.CheckBoxColor = Color.Transparent;
            _cbxSingleEmpty.OnUncheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cbxSingleEmpty.OnUncheck.BorderRadius = 2;
            _cbxSingleEmpty.OnUncheck.BorderThickness = 2;
            _cbxSingleEmpty.OnUncheck.CheckBoxColor = Color.Transparent;
            _cbxSingleEmpty.Size = new Size(21, 21);
            _cbxSingleEmpty.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            _cbxSingleEmpty.TabIndex = 198;
            _cbxSingleEmpty.ThreeState = false;
            _cbxSingleEmpty.ToolTipText = null;
            // 
            // Label25
            // 
            Label25.AutoSize = true;
            Label25.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label25.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label25.Location = new Point(48, 201);
            Label25.Margin = new Padding(0);
            Label25.Name = "Label25";
            Label25.Size = new Size(75, 21);
            Label25.TabIndex = 195;
            Label25.Text = "Driver ID:";
            Label25.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboDriverId
            // 
            cboDriverId.AutoCompleteMode = AutoCompleteMode.Append;
            cboDriverId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboDriverId.DataBindings.Add(new Binding("SelectedItem", TruckDriversBindingSource, "Port_Pass_ID", true, DataSourceUpdateMode.Never));
            cboDriverId.DataBindings.Add(new Binding("SelectedValue", TruckDriversBindingSource, "Port_Pass_ID", true));
            cboDriverId.DataBindings.Add(new Binding("Text", TruckDriversBindingSource, "Port_Pass_ID", true, DataSourceUpdateMode.Never));
            cboDriverId.DataSource = TruckDriversBindingSource;
            cboDriverId.DisplayMember = "Port_Pass_ID";
            cboDriverId.Font = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboDriverId.FormattingEnabled = true;
            cboDriverId.Location = new Point(131, 199);
            cboDriverId.Name = "cboDriverId";
            cboDriverId.Size = new Size(196, 26);
            cboDriverId.TabIndex = 194;
            cboDriverId.ValueMember = "Port_Pass_ID";
            // 
            // TruckDriversBindingSource
            // 
            TruckDriversBindingSource.DataSource = typeof(ModelLayer.Truck_Drivers);
            // 
            // Label24
            // 
            Label24.AutoSize = true;
            Label24.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label24.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label24.Location = new Point(54, 170);
            Label24.Margin = new Padding(0);
            Label24.Name = "Label24";
            Label24.Size = new Size(71, 21);
            Label24.TabIndex = 193;
            Label24.Text = "Drop off:";
            Label24.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboDropOff
            // 
            _cboDropOff.AutoCompleteMode = AutoCompleteMode.Append;
            _cboDropOff.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboDropOff.DataBindings.Add(new Binding("SelectedItem", VWCompanyCompanyTypeBindingSource, "CompanyCode", true, DataSourceUpdateMode.Never));
            _cboDropOff.DataBindings.Add(new Binding("SelectedValue", VWCompanyCompanyTypeBindingSource, "CompanyCode", true, DataSourceUpdateMode.Never));
            _cboDropOff.DataSource = VWCompanyCompanyTypeBindingSource;
            _cboDropOff.DisplayMember = "CompanyCode";
            _cboDropOff.Font = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboDropOff.FormattingEnabled = true;
            _cboDropOff.Location = new Point(131, 168);
            _cboDropOff.Name = "_cboDropOff";
            _cboDropOff.Size = new Size(196, 26);
            _cboDropOff.TabIndex = 192;
            _cboDropOff.ValueMember = "CompanyCode";
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label20.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label20.Location = new Point(61, 141);
            Label20.Margin = new Padding(0);
            Label20.Name = "Label20";
            Label20.Size = new Size(63, 21);
            Label20.TabIndex = 191;
            Label20.Text = "Pick up:";
            Label20.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboPickUp
            // 
            _cboPickUp.AutoCompleteMode = AutoCompleteMode.Append;
            _cboPickUp.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboPickUp.DataBindings.Add(new Binding("SelectedItem", VWCompanyCompanyTypeBindingSource, "CompanyCode", true, DataSourceUpdateMode.Never));
            _cboPickUp.DataBindings.Add(new Binding("SelectedValue", VWCompanyCompanyTypeBindingSource, "CompanyCode", true, DataSourceUpdateMode.Never));
            _cboPickUp.DataSource = VWCompanyCompanyTypeBindingSource;
            _cboPickUp.DisplayMember = "CompanyCode";
            _cboPickUp.Font = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboPickUp.FormattingEnabled = true;
            _cboPickUp.Location = new Point(131, 138);
            _cboPickUp.Name = "_cboPickUp";
            _cboPickUp.Size = new Size(196, 26);
            _cboPickUp.TabIndex = 190;
            _cboPickUp.ValueMember = "CompanyCode";
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.Font = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label19.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label19.Location = new Point(648, 112);
            Label19.Margin = new Padding(0);
            Label19.Name = "Label19";
            Label19.Size = new Size(85, 18);
            Label19.TabIndex = 189;
            Label19.Text = "Multi Empty";
            Label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Font = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label18.Location = new Point(648, 134);
            Label18.Margin = new Padding(0);
            Label18.Name = "Label18";
            Label18.Size = new Size(85, 18);
            Label18.TabIndex = 188;
            Label18.Text = "Single Load";
            Label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Font = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label15.Location = new Point(648, 154);
            Label15.Margin = new Padding(0);
            Label15.Name = "Label15";
            Label15.Size = new Size(76, 18);
            Label15.TabIndex = 187;
            Label15.Text = "Multi Load";
            Label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label13.Location = new Point(648, 90);
            Label13.Margin = new Padding(0);
            Label13.Name = "Label13";
            Label13.Size = new Size(94, 18);
            Label13.TabIndex = 186;
            Label13.Text = "Single Empty";
            Label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(561, 86);
            Label6.Margin = new Padding(0);
            Label6.Name = "Label6";
            Label6.Size = new Size(55, 21);
            Label6.TabIndex = 181;
            Label6.Text = "Status:";
            Label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label4.Location = new Point(37, 111);
            Label4.Margin = new Padding(0);
            Label4.Name = "Label4";
            Label4.Size = new Size(83, 21);
            Label4.TabIndex = 176;
            Label4.Text = "Booking #:";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboBookingNumber
            // 
            _cboBookingNumber.AutoCompleteMode = AutoCompleteMode.Append;
            _cboBookingNumber.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboBookingNumber.Font = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboBookingNumber.FormattingEnabled = true;
            _cboBookingNumber.Location = new Point(131, 108);
            _cboBookingNumber.Name = "_cboBookingNumber";
            _cboBookingNumber.Size = new Size(196, 26);
            _cboBookingNumber.Sorted = true;
            _cboBookingNumber.TabIndex = 175;
            // 
            // streetTurnToggleSwitch
            // 
            streetTurnToggleSwitch.Animation = 5;
            streetTurnToggleSwitch.BackColor = Color.Transparent;
            streetTurnToggleSwitch.BackgroundImage = (Image)resources.GetObject("streetTurnToggleSwitch.BackgroundImage");
            streetTurnToggleSwitch.Cursor = Cursors.Hand;
            streetTurnToggleSwitch.Font = new Font("Microsoft Sans Serif", 7.854546f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            streetTurnToggleSwitch.Location = new Point(630, 180);
            streetTurnToggleSwitch.Margin = new Padding(4);
            streetTurnToggleSwitch.Name = "streetTurnToggleSwitch";
            streetTurnToggleSwitch.Size = new Size(40, 20);
            streetTurnToggleSwitch.TabIndex = 139;
            ToggleState13.BackColor = Color.Empty;
            ToggleState13.BackColorInner = Color.Empty;
            ToggleState13.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(236)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(140)));
            ToggleState13.BorderColorInner = Color.Empty;
            ToggleState13.BorderRadius = 1;
            ToggleState13.BorderRadiusInner = 1;
            ToggleState13.BorderThickness = 1;
            ToggleState13.BorderThicknessInner = 1;
            streetTurnToggleSwitch.ToggleStateDisabled = ToggleState13;
            ToggleState14.BackColor = Color.Gray;
            ToggleState14.BackColorInner = Color.White;
            ToggleState14.BorderColor = Color.Gray;
            ToggleState14.BorderColorInner = Color.White;
            ToggleState14.BorderRadius = 17;
            ToggleState14.BorderRadiusInner = 15;
            ToggleState14.BorderThickness = 1;
            ToggleState14.BorderThicknessInner = 1;
            streetTurnToggleSwitch.ToggleStateOff = ToggleState14;
            ToggleState15.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState15.BackColorInner = Color.White;
            ToggleState15.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState15.BorderColorInner = Color.White;
            ToggleState15.BorderRadius = 17;
            ToggleState15.BorderRadiusInner = 15;
            ToggleState15.BorderThickness = 1;
            ToggleState15.BorderThicknessInner = 1;
            streetTurnToggleSwitch.ToggleStateOn = ToggleState15;
            streetTurnToggleSwitch.Value = false;
            // 
            // toIDatePicker
            // 
            toIDatePicker.CustomFormat = " ";
            toIDatePicker.Font = new Font("Microsoft Sans Serif", 11.12727f);
            toIDatePicker.Format = DateTimePickerFormat.Custom;
            toIDatePicker.Location = new Point(630, 56);
            toIDatePicker.Name = "toIDatePicker";
            toIDatePicker.Size = new Size(165, 24);
            toIDatePicker.TabIndex = 180;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label5.Location = new Point(511, 177);
            Label5.Margin = new Padding(0);
            Label5.Name = "Label5";
            Label5.Size = new Size(96, 21);
            Label5.TabIndex = 138;
            Label5.Text = "Street Turns:";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fromDatePicker
            // 
            _fromDatePicker.CustomFormat = " ";
            _fromDatePicker.Font = new Font("Microsoft Sans Serif", 11.12727f);
            _fromDatePicker.Format = DateTimePickerFormat.Custom;
            _fromDatePicker.Location = new Point(630, 23);
            _fromDatePicker.Name = "_fromDatePicker";
            _fromDatePicker.Size = new Size(165, 24);
            _fromDatePicker.TabIndex = 179;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(19, 20);
            Label3.Margin = new Padding(0);
            Label3.Name = "Label3";
            Label3.Size = new Size(108, 21);
            Label3.TabIndex = 120;
            Label3.Text = "Billing Carrier:";
            Label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(568, 25);
            Label2.Margin = new Padding(0);
            Label2.Name = "Label2";
            Label2.Size = new Size(50, 21);
            Label2.TabIndex = 114;
            Label2.Text = "From:";
            Label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(592, 56);
            Label1.Margin = new Padding(0);
            Label1.Name = "Label1";
            Label1.Size = new Size(28, 21);
            Label1.TabIndex = 115;
            Label1.Text = "To:";
            Label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboTruckingCompany
            // 
            _cboTruckingCompany.AutoCompleteMode = AutoCompleteMode.Append;
            _cboTruckingCompany.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboTruckingCompany.DataBindings.Add(new Binding("SelectedItem", VWCompanyCompanyTypeBindingSource, "CompanyName", true, DataSourceUpdateMode.Never));
            _cboTruckingCompany.DataBindings.Add(new Binding("SelectedValue", VWCompanyCompanyTypeBindingSource, "CompanyCode", true, DataSourceUpdateMode.Never));
            _cboTruckingCompany.DataBindings.Add(new Binding("Text", VWCompanyCompanyTypeBindingSource, "CompanyName", true, DataSourceUpdateMode.Never));
            _cboTruckingCompany.DataSource = VWCompanyCompanyTypeBindingSource;
            _cboTruckingCompany.DisplayMember = "CompanyName";
            _cboTruckingCompany.Font = new Font("Microsoft Sans Serif", 11.12727f);
            _cboTruckingCompany.FormattingEnabled = true;
            _cboTruckingCompany.Location = new Point(130, 17);
            _cboTruckingCompany.Name = "_cboTruckingCompany";
            _cboTruckingCompany.Size = new Size(382, 26);
            _cboTruckingCompany.TabIndex = 174;
            _cboTruckingCompany.ValueMember = "CompanyCode";
            // 
            // searchBunifuTextBox1
            // 
            _searchBunifuTextBox1.AcceptsReturn = false;
            _searchBunifuTextBox1.AcceptsTab = false;
            _searchBunifuTextBox1.Anchor = AnchorStyles.None;
            _searchBunifuTextBox1.AnimationSpeed = 200;
            _searchBunifuTextBox1.AutoCompleteMode = AutoCompleteMode.None;
            _searchBunifuTextBox1.AutoCompleteSource = AutoCompleteSource.None;
            _searchBunifuTextBox1.BackColor = Color.Transparent;
            _searchBunifuTextBox1.BackgroundImage = (Image)resources.GetObject("searchBunifuTextBox1.BackgroundImage");
            _searchBunifuTextBox1.BorderColorActive = Color.DodgerBlue;
            _searchBunifuTextBox1.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _searchBunifuTextBox1.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _searchBunifuTextBox1.BorderColorIdle = Color.DimGray;
            _searchBunifuTextBox1.BorderRadius = 1;
            _searchBunifuTextBox1.BorderThickness = 1;
            _searchBunifuTextBox1.CharacterCasing = CharacterCasing.Normal;
            _searchBunifuTextBox1.Cursor = Cursors.IBeam;
            _searchBunifuTextBox1.DefaultFont = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _searchBunifuTextBox1.DefaultText = "";
            _searchBunifuTextBox1.FillColor = Color.White;
            _searchBunifuTextBox1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _searchBunifuTextBox1.HideSelection = true;
            _searchBunifuTextBox1.IconLeft = null;
            _searchBunifuTextBox1.IconLeftCursor = Cursors.IBeam;
            _searchBunifuTextBox1.IconPadding = 10;
            _searchBunifuTextBox1.IconRight = null;
            _searchBunifuTextBox1.IconRightCursor = Cursors.IBeam;
            _searchBunifuTextBox1.Lines = new string[0];
            _searchBunifuTextBox1.Location = new Point(32, 830);
            _searchBunifuTextBox1.MaxLength = 32767;
            _searchBunifuTextBox1.MinimumSize = new Size(100, 35);
            _searchBunifuTextBox1.Modified = false;
            _searchBunifuTextBox1.Multiline = false;
            _searchBunifuTextBox1.Name = "_searchBunifuTextBox1";
            StateProperties77.BorderColor = Color.DodgerBlue;
            StateProperties77.FillColor = Color.Empty;
            StateProperties77.ForeColor = Color.Empty;
            StateProperties77.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnActiveState = StateProperties77;
            StateProperties78.BorderColor = Color.Empty;
            StateProperties78.FillColor = Color.White;
            StateProperties78.ForeColor = Color.Empty;
            StateProperties78.PlaceholderForeColor = Color.Silver;
            _searchBunifuTextBox1.OnDisabledState = StateProperties78;
            StateProperties79.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties79.FillColor = Color.Empty;
            StateProperties79.ForeColor = Color.Empty;
            StateProperties79.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnHoverState = StateProperties79;
            StateProperties80.BorderColor = Color.DimGray;
            StateProperties80.FillColor = Color.White;
            StateProperties80.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties80.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnIdleState = StateProperties80;
            _searchBunifuTextBox1.PasswordChar = '\0';
            _searchBunifuTextBox1.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _searchBunifuTextBox1.PlaceholderText = "Search container...";
            _searchBunifuTextBox1.ReadOnly = false;
            _searchBunifuTextBox1.ScrollBars = ScrollBars.None;
            _searchBunifuTextBox1.SelectedText = "";
            _searchBunifuTextBox1.SelectionLength = 0;
            _searchBunifuTextBox1.SelectionStart = 0;
            _searchBunifuTextBox1.ShortcutsEnabled = true;
            _searchBunifuTextBox1.Size = new Size(312, 35);
            _searchBunifuTextBox1.Style = _Style.Bunifu;
            _searchBunifuTextBox1.TabIndex = 135;
            _searchBunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            _searchBunifuTextBox1.TextMarginBottom = 0;
            _searchBunifuTextBox1.TextMarginLeft = 5;
            _searchBunifuTextBox1.TextMarginTop = 0;
            _searchBunifuTextBox1.TextPlaceholder = "Search container...";
            _searchBunifuTextBox1.UseSystemPasswordChar = false;
            _searchBunifuTextBox1.WordWrap = true;
            // 
            // BunifuButton2
            // 
            _BunifuButton2.AllowToggling = false;
            _BunifuButton2.AnimationSpeed = 200;
            _BunifuButton2.AutoGenerateColors = false;
            _BunifuButton2.BackColor = Color.Transparent;
            _BunifuButton2.BackColor1 = Color.White;
            _BunifuButton2.BackgroundImage = (Image)resources.GetObject("BunifuButton2.BackgroundImage");
            _BunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _BunifuButton2.ButtonText = "";
            _BunifuButton2.ButtonTextMarginLeft = 0;
            _BunifuButton2.ColorContrastOnClick = 45;
            _BunifuButton2.ColorContrastOnHover = 45;
            _BunifuButton2.Cursor = Cursors.Hand;
            BorderEdges31.BottomLeft = true;
            BorderEdges31.BottomRight = true;
            BorderEdges31.TopLeft = true;
            BorderEdges31.TopRight = true;
            _BunifuButton2.CustomizableEdges = BorderEdges31;
            _BunifuButton2.DialogResult = DialogResult.None;
            _BunifuButton2.DisabledBorderColor = Color.Empty;
            _BunifuButton2.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _BunifuButton2.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _BunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _BunifuButton2.Font = new Font("Segoe UI Semibold", 9.75f);
            _BunifuButton2.ForeColor = Color.White;
            _BunifuButton2.IconLeftCursor = Cursors.Hand;
            _BunifuButton2.IconMarginLeft = 0;
            _BunifuButton2.IconPadding = 0;
            _BunifuButton2.IconRightCursor = Cursors.Hand;
            _BunifuButton2.IdleBorderColor = Color.White;
            _BunifuButton2.IdleBorderRadius = 3;
            _BunifuButton2.IdleBorderThickness = 1;
            _BunifuButton2.IdleFillColor = Color.White;
            _BunifuButton2.IdleIconLeftImage = My.Resources.Resources.refresh_pngrepo_com;
            _BunifuButton2.IdleIconRightImage = null;
            _BunifuButton2.IndicateFocus = false;
            _BunifuButton2.Location = new Point(920, 157);
            _BunifuButton2.Name = "_BunifuButton2";
            StateProperties81.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties81.BorderRadius = 3;
            StateProperties81.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties81.BorderThickness = 1;
            StateProperties81.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties81.ForeColor = Color.White;
            StateProperties81.IconLeftImage = null;
            StateProperties81.IconRightImage = null;
            _BunifuButton2.onHoverState = StateProperties81;
            StateProperties82.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties82.BorderRadius = 3;
            StateProperties82.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties82.BorderThickness = 1;
            StateProperties82.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties82.ForeColor = Color.White;
            StateProperties82.IconLeftImage = null;
            StateProperties82.IconRightImage = null;
            _BunifuButton2.OnPressedState = StateProperties82;
            _BunifuButton2.Size = new Size(40, 37);
            _BunifuButton2.TabIndex = 134;
            _BunifuButton2.TextAlign = ContentAlignment.MiddleCenter;
            _BunifuButton2.TextMarginLeft = 0;
            _BunifuButton2.UseDefaultRadiusAndThickness = true;
            // 
            // printButton
            // 
            _printButton.AllowToggling = false;
            _printButton.AnimationSpeed = 200;
            _printButton.AutoGenerateColors = false;
            _printButton.BackColor = Color.Transparent;
            _printButton.BackColor1 = Color.Teal;
            _printButton.BackgroundImage = (Image)resources.GetObject("printButton.BackgroundImage");
            _printButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _printButton.ButtonText = "PRINT SUMMARY";
            _printButton.ButtonTextMarginLeft = 0;
            _printButton.ColorContrastOnClick = 45;
            _printButton.ColorContrastOnHover = 45;
            _printButton.Cursor = Cursors.Hand;
            BorderEdges32.BottomLeft = true;
            BorderEdges32.BottomRight = true;
            BorderEdges32.TopLeft = true;
            BorderEdges32.TopRight = true;
            _printButton.CustomizableEdges = BorderEdges32;
            _printButton.DialogResult = DialogResult.None;
            _printButton.DisabledBorderColor = Color.Empty;
            _printButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _printButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _printButton.Enabled = false;
            _printButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _printButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _printButton.ForeColor = Color.White;
            _printButton.IconLeftCursor = Cursors.Hand;
            _printButton.IconMarginLeft = 11;
            _printButton.IconPadding = 10;
            _printButton.IconRightCursor = Cursors.Hand;
            _printButton.IdleBorderColor = Color.Teal;
            _printButton.IdleBorderRadius = 3;
            _printButton.IdleBorderThickness = 1;
            _printButton.IdleFillColor = Color.Teal;
            _printButton.IdleIconLeftImage = null;
            _printButton.IdleIconRightImage = null;
            _printButton.IndicateFocus = true;
            _printButton.Location = new Point(1311, 830);
            _printButton.Name = "_printButton";
            StateProperties83.BorderColor = Color.MediumTurquoise;
            StateProperties83.BorderRadius = 3;
            StateProperties83.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties83.BorderThickness = 1;
            StateProperties83.FillColor = Color.MediumTurquoise;
            StateProperties83.ForeColor = Color.White;
            StateProperties83.IconLeftImage = null;
            StateProperties83.IconRightImage = null;
            _printButton.onHoverState = StateProperties83;
            StateProperties84.BorderColor = Color.Teal;
            StateProperties84.BorderRadius = 3;
            StateProperties84.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties84.BorderThickness = 1;
            StateProperties84.FillColor = Color.Teal;
            StateProperties84.ForeColor = Color.White;
            StateProperties84.IconLeftImage = null;
            StateProperties84.IconRightImage = null;
            _printButton.OnPressedState = StateProperties84;
            _printButton.Size = new Size(193, 46);
            _printButton.TabIndex = 133;
            _printButton.TextAlign = ContentAlignment.MiddleCenter;
            _printButton.TextMarginLeft = 0;
            _printButton.UseDefaultRadiusAndThickness = true;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            titleLabel.Location = new Point(37, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(408, 29);
            titleLabel.TabIndex = 113;
            titleLabel.Text = "Trucking Reconciliation Report";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BunifuShadowPanel2
            // 
            BunifuShadowPanel2.BorderColor = Color.Transparent;
            BunifuShadowPanel2.Controls.Add(TableLayoutPanel3);
            BunifuShadowPanel2.Controls.Add(TableLayoutPanel18);
            BunifuShadowPanel2.Controls.Add(TableLayoutPanel17);
            BunifuShadowPanel2.Controls.Add(TableLayoutPanel16);
            BunifuShadowPanel2.Controls.Add(TableLayoutPanel15);
            BunifuShadowPanel2.Controls.Add(TableLayoutPanel2);
            BunifuShadowPanel2.Controls.Add(Label8);
            BunifuShadowPanel2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuShadowPanel2.Location = new Point(1135, 274);
            BunifuShadowPanel2.Name = "BunifuShadowPanel2";
            BunifuShadowPanel2.PanelColor = Color.Empty;
            BunifuShadowPanel2.ShadowDept = 2;
            BunifuShadowPanel2.ShadowTopLeftVisible = true;
            BunifuShadowPanel2.Size = new Size(509, 546);
            BunifuShadowPanel2.TabIndex = 140;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel3.ColumnCount = 1;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel3.Controls.Add(totalQtyLbl, 0, 0);
            TableLayoutPanel3.Location = new Point(166, 287);
            TableLayoutPanel3.Margin = new Padding(0);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 38.0f));
            TableLayoutPanel3.Size = new Size(97, 39);
            TableLayoutPanel3.TabIndex = 157;
            // 
            // totalQtyLbl
            // 
            totalQtyLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            totalQtyLbl.AutoSize = true;
            totalQtyLbl.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            totalQtyLbl.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            totalQtyLbl.Location = new Point(1, 9);
            totalQtyLbl.Margin = new Padding(0);
            totalQtyLbl.Name = "totalQtyLbl";
            totalQtyLbl.Padding = new Padding(5, 0, 0, 0);
            totalQtyLbl.Size = new Size(95, 20);
            totalQtyLbl.TabIndex = 156;
            totalQtyLbl.Text = "0";
            // 
            // TableLayoutPanel18
            // 
            TableLayoutPanel18.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel18.ColumnCount = 2;
            TableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135.0f));
            TableLayoutPanel18.Controls.Add(Label14, 0, 0);
            TableLayoutPanel18.Controls.Add(totalaftTaxesLabel, 1, 0);
            TableLayoutPanel18.Location = new Point(253, 464);
            TableLayoutPanel18.Margin = new Padding(0);
            TableLayoutPanel18.Name = "TableLayoutPanel18";
            TableLayoutPanel18.RowCount = 1;
            TableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Absolute, 38.0f));
            TableLayoutPanel18.Size = new Size(245, 39);
            TableLayoutPanel18.TabIndex = 144;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Dock = DockStyle.Fill;
            Label14.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label14.Location = new Point(1, 1);
            Label14.Margin = new Padding(0);
            Label14.Name = "Label14";
            Label14.Size = new Size(107, 37);
            Label14.TabIndex = 154;
            Label14.Text = "TOTAL:";
            Label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalaftTaxesLabel
            // 
            totalaftTaxesLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            totalaftTaxesLabel.AutoSize = true;
            totalaftTaxesLabel.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            totalaftTaxesLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            totalaftTaxesLabel.Location = new Point(109, 9);
            totalaftTaxesLabel.Margin = new Padding(0);
            totalaftTaxesLabel.Name = "totalaftTaxesLabel";
            totalaftTaxesLabel.Padding = new Padding(5, 0, 0, 0);
            totalaftTaxesLabel.Size = new Size(135, 20);
            totalaftTaxesLabel.TabIndex = 153;
            totalaftTaxesLabel.Text = "$0.00";
            // 
            // TableLayoutPanel17
            // 
            TableLayoutPanel17.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel17.ColumnCount = 1;
            TableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel17.Controls.Add(totalfsctefLabel, 0, 0);
            TableLayoutPanel17.Location = new Point(367, 406);
            TableLayoutPanel17.Margin = new Padding(0);
            TableLayoutPanel17.Name = "TableLayoutPanel17";
            TableLayoutPanel17.RowCount = 1;
            TableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Absolute, 38.0f));
            TableLayoutPanel17.Size = new Size(130, 39);
            TableLayoutPanel17.TabIndex = 143;
            // 
            // totalfsctefLabel
            // 
            totalfsctefLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            totalfsctefLabel.AutoSize = true;
            totalfsctefLabel.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            totalfsctefLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            totalfsctefLabel.Location = new Point(1, 9);
            totalfsctefLabel.Margin = new Padding(0);
            totalfsctefLabel.Name = "totalfsctefLabel";
            totalfsctefLabel.Padding = new Padding(5, 0, 0, 0);
            totalfsctefLabel.Size = new Size(128, 20);
            totalfsctefLabel.TabIndex = 153;
            totalfsctefLabel.Text = "$0.00";
            // 
            // TableLayoutPanel16
            // 
            TableLayoutPanel16.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel16.ColumnCount = 3;
            TableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 198.0f));
            TableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137.0f));
            TableLayoutPanel16.Controls.Add(Label17, 0, 1);
            TableLayoutPanel16.Controls.Add(tefFeeLabel, 2, 1);
            TableLayoutPanel16.Controls.Add(fscFeeLabel, 2, 0);
            TableLayoutPanel16.Controls.Add(Label16, 0, 0);
            TableLayoutPanel16.Controls.Add(fscLabel, 1, 0);
            TableLayoutPanel16.Location = new Point(17, 335);
            TableLayoutPanel16.Margin = new Padding(0);
            TableLayoutPanel16.Name = "TableLayoutPanel16";
            TableLayoutPanel16.RowCount = 2;
            TableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 36.0f));
            TableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel16.Size = new Size(480, 72);
            TableLayoutPanel16.TabIndex = 142;
            // 
            // Label17
            // 
            Label17.Anchor = AnchorStyles.Right;
            Label17.AutoSize = true;
            Label17.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label17.Location = new Point(20, 42);
            Label17.Margin = new Padding(0);
            Label17.Name = "Label17";
            Label17.Size = new Size(122, 21);
            Label17.TabIndex = 120;
            Label17.Text = "Terminal Eff Fee:";
            // 
            // tefFeeLabel
            // 
            tefFeeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tefFeeLabel.AutoSize = true;
            tefFeeLabel.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            tefFeeLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            tefFeeLabel.Location = new Point(342, 43);
            tefFeeLabel.Margin = new Padding(0);
            tefFeeLabel.Name = "tefFeeLabel";
            tefFeeLabel.Padding = new Padding(5, 0, 0, 0);
            tefFeeLabel.Size = new Size(137, 20);
            tefFeeLabel.TabIndex = 153;
            tefFeeLabel.Text = "$0.00";
            // 
            // fscFeeLabel
            // 
            fscFeeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fscFeeLabel.AutoSize = true;
            fscFeeLabel.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            fscFeeLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            fscFeeLabel.Location = new Point(342, 7);
            fscFeeLabel.Margin = new Padding(0);
            fscFeeLabel.Name = "fscFeeLabel";
            fscFeeLabel.Padding = new Padding(5, 0, 0, 0);
            fscFeeLabel.Size = new Size(137, 20);
            fscFeeLabel.TabIndex = 153;
            fscFeeLabel.Text = "$0.00";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Dock = DockStyle.Fill;
            Label16.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label16.Location = new Point(1, 1);
            Label16.Margin = new Padding(0);
            Label16.Name = "Label16";
            Label16.Size = new Size(141, 33);
            Label16.TabIndex = 120;
            Label16.Text = "Fuel Surcharge:";
            // 
            // fscLabel
            // 
            fscLabel.Anchor = AnchorStyles.Left;
            fscLabel.AutoSize = true;
            fscLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            fscLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            fscLabel.Location = new Point(143, 7);
            fscLabel.Margin = new Padding(0);
            fscLabel.Name = "fscLabel";
            fscLabel.Padding = new Padding(5, 0, 0, 0);
            fscLabel.Size = new Size(37, 21);
            fscLabel.TabIndex = 119;
            fscLabel.Text = "0%";
            // 
            // TableLayoutPanel15
            // 
            TableLayoutPanel15.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel15.ColumnCount = 1;
            TableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel15.Controls.Add(lblTotalLoad, 0, 0);
            TableLayoutPanel15.Location = new Point(366, 287);
            TableLayoutPanel15.Margin = new Padding(0);
            TableLayoutPanel15.Name = "TableLayoutPanel15";
            TableLayoutPanel15.RowCount = 1;
            TableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 38.0f));
            TableLayoutPanel15.Size = new Size(130, 39);
            TableLayoutPanel15.TabIndex = 141;
            // 
            // lblTotalLoad
            // 
            lblTotalLoad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTotalLoad.AutoSize = true;
            lblTotalLoad.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotalLoad.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblTotalLoad.Location = new Point(1, 9);
            lblTotalLoad.Margin = new Padding(0);
            lblTotalLoad.Name = "lblTotalLoad";
            lblTotalLoad.Padding = new Padding(5, 0, 0, 0);
            lblTotalLoad.Size = new Size(128, 20);
            lblTotalLoad.TabIndex = 153;
            lblTotalLoad.Text = "$0.00";
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel2.ColumnCount = 4;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137.0f));
            TableLayoutPanel2.Controls.Add(ratetotalSingleEptyLabel, 3, 2);
            TableLayoutPanel2.Controls.Add(ratetotalMultiEptyLabel, 3, 1);
            TableLayoutPanel2.Controls.Add(totalSingleEptyLabel, 1, 2);
            TableLayoutPanel2.Controls.Add(totalMultiEptyLabel, 1, 1);
            TableLayoutPanel2.Controls.Add(rateSingleEptyLabel, 2, 2);
            TableLayoutPanel2.Controls.Add(rateMultEptyLabel, 2, 1);
            TableLayoutPanel2.Controls.Add(Label, 3, 0);
            TableLayoutPanel2.Controls.Add(Label23, 2, 0);
            TableLayoutPanel2.Controls.Add(Label22, 1, 0);
            TableLayoutPanel2.Controls.Add(Label21, 0, 0);
            TableLayoutPanel2.Controls.Add(Label11, 0, 2);
            TableLayoutPanel2.Controls.Add(Label9, 0, 1);
            TableLayoutPanel2.Controls.Add(totalMultiLoadLabel, 1, 4);
            TableLayoutPanel2.Controls.Add(Label10, 0, 4);
            TableLayoutPanel2.Controls.Add(Label12, 0, 5);
            TableLayoutPanel2.Controls.Add(totalSingleLoadLabel, 1, 5);
            TableLayoutPanel2.Controls.Add(rateSingleLoadsLabel, 2, 5);
            TableLayoutPanel2.Controls.Add(ratetotalSingleLoadLabel, 3, 5);
            TableLayoutPanel2.Controls.Add(rateMultiLoadLabel, 2, 4);
            TableLayoutPanel2.Controls.Add(ratetotalMultiLoadLabel, 3, 4);
            TableLayoutPanel2.Controls.Add(lblqtyEmpty, 1, 3);
            TableLayoutPanel2.Controls.Add(lblqtyLoads, 1, 6);
            TableLayoutPanel2.Controls.Add(lblTotalEmpty, 3, 3);
            TableLayoutPanel2.Controls.Add(Label27, 3, 6);
            TableLayoutPanel2.Location = new Point(17, 68);
            TableLayoutPanel2.Margin = new Padding(0);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 7;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel2.Size = new Size(480, 220);
            TableLayoutPanel2.TabIndex = 2;
            // 
            // ratetotalSingleEptyLabel
            // 
            ratetotalSingleEptyLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ratetotalSingleEptyLabel.AutoSize = true;
            ratetotalSingleEptyLabel.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ratetotalSingleEptyLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ratetotalSingleEptyLabel.Location = new Point(342, 68);
            ratetotalSingleEptyLabel.Margin = new Padding(0);
            ratetotalSingleEptyLabel.Name = "ratetotalSingleEptyLabel";
            ratetotalSingleEptyLabel.Padding = new Padding(5, 0, 0, 0);
            ratetotalSingleEptyLabel.Size = new Size(137, 20);
            ratetotalSingleEptyLabel.TabIndex = 150;
            ratetotalSingleEptyLabel.Text = "$0.00";
            // 
            // ratetotalMultiEptyLabel
            // 
            ratetotalMultiEptyLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ratetotalMultiEptyLabel.AutoSize = true;
            ratetotalMultiEptyLabel.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ratetotalMultiEptyLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ratetotalMultiEptyLabel.Location = new Point(342, 37);
            ratetotalMultiEptyLabel.Margin = new Padding(0);
            ratetotalMultiEptyLabel.Name = "ratetotalMultiEptyLabel";
            ratetotalMultiEptyLabel.Padding = new Padding(5, 0, 0, 0);
            ratetotalMultiEptyLabel.Size = new Size(137, 20);
            ratetotalMultiEptyLabel.TabIndex = 151;
            ratetotalMultiEptyLabel.Text = "$0.00";
            // 
            // totalSingleEptyLabel
            // 
            totalSingleEptyLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            totalSingleEptyLabel.AutoSize = true;
            totalSingleEptyLabel.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            totalSingleEptyLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            totalSingleEptyLabel.Location = new Point(142, 68);
            totalSingleEptyLabel.Margin = new Padding(0);
            totalSingleEptyLabel.Name = "totalSingleEptyLabel";
            totalSingleEptyLabel.Padding = new Padding(5, 0, 0, 0);
            totalSingleEptyLabel.Size = new Size(96, 20);
            totalSingleEptyLabel.TabIndex = 151;
            totalSingleEptyLabel.Text = "0";
            // 
            // totalMultiEptyLabel
            // 
            totalMultiEptyLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            totalMultiEptyLabel.AutoSize = true;
            totalMultiEptyLabel.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            totalMultiEptyLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            totalMultiEptyLabel.Location = new Point(142, 37);
            totalMultiEptyLabel.Margin = new Padding(0);
            totalMultiEptyLabel.Name = "totalMultiEptyLabel";
            totalMultiEptyLabel.Padding = new Padding(5, 0, 0, 0);
            totalMultiEptyLabel.Size = new Size(96, 20);
            totalMultiEptyLabel.TabIndex = 152;
            totalMultiEptyLabel.Text = "0";
            // 
            // rateSingleEptyLabel
            // 
            rateSingleEptyLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rateSingleEptyLabel.AutoSize = true;
            rateSingleEptyLabel.BackColor = Color.White;
            rateSingleEptyLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            rateSingleEptyLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            rateSingleEptyLabel.Location = new Point(239, 67);
            rateSingleEptyLabel.Margin = new Padding(0);
            rateSingleEptyLabel.Name = "rateSingleEptyLabel";
            rateSingleEptyLabel.Padding = new Padding(5, 0, 0, 0);
            rateSingleEptyLabel.Size = new Size(102, 21);
            rateSingleEptyLabel.TabIndex = 146;
            rateSingleEptyLabel.Text = "$0.00";
            rateSingleEptyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rateMultEptyLabel
            // 
            rateMultEptyLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rateMultEptyLabel.AutoSize = true;
            rateMultEptyLabel.BackColor = Color.White;
            rateMultEptyLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            rateMultEptyLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            rateMultEptyLabel.Location = new Point(239, 36);
            rateMultEptyLabel.Margin = new Padding(0);
            rateMultEptyLabel.Name = "rateMultEptyLabel";
            rateMultEptyLabel.Padding = new Padding(5, 0, 0, 0);
            rateMultEptyLabel.Size = new Size(102, 21);
            rateMultEptyLabel.TabIndex = 149;
            rateMultEptyLabel.Text = "$0.00";
            rateMultEptyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Dock = DockStyle.Fill;
            Label.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label.Location = new Point(342, 1);
            Label.Margin = new Padding(0);
            Label.Name = "Label";
            Label.Size = new Size(137, 30);
            Label.TabIndex = 150;
            Label.Text = "Total";
            Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label23
            // 
            Label23.AutoSize = true;
            Label23.Dock = DockStyle.Fill;
            Label23.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label23.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label23.Location = new Point(239, 1);
            Label23.Margin = new Padding(0);
            Label23.Name = "Label23";
            Label23.Size = new Size(102, 30);
            Label23.TabIndex = 149;
            Label23.Text = "Rate";
            Label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label22
            // 
            Label22.AutoSize = true;
            Label22.Dock = DockStyle.Fill;
            Label22.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label22.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label22.Location = new Point(142, 1);
            Label22.Margin = new Padding(0);
            Label22.Name = "Label22";
            Label22.Size = new Size(96, 30);
            Label22.TabIndex = 144;
            Label22.Text = "Quantity";
            Label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.Dock = DockStyle.Fill;
            Label21.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label21.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label21.Location = new Point(1, 1);
            Label21.Margin = new Padding(0);
            Label21.Name = "Label21";
            Label21.Size = new Size(140, 30);
            Label21.TabIndex = 144;
            Label21.Text = "Service";
            Label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label11
            // 
            Label11.Anchor = AnchorStyles.Right;
            Label11.AutoSize = true;
            Label11.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label11.Location = new Point(30, 67);
            Label11.Margin = new Padding(0);
            Label11.Name = "Label11";
            Label11.Size = new Size(111, 21);
            Label11.TabIndex = 117;
            Label11.Text = "Single Emptys:";
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.Right;
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label9.Location = new Point(44, 36);
            Label9.Margin = new Padding(0);
            Label9.Name = "Label9";
            Label9.Size = new Size(97, 21);
            Label9.TabIndex = 115;
            Label9.Text = "Multi Empty:";
            // 
            // totalMultiLoadLabel
            // 
            totalMultiLoadLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            totalMultiLoadLabel.AutoSize = true;
            totalMultiLoadLabel.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            totalMultiLoadLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            totalMultiLoadLabel.Location = new Point(142, 130);
            totalMultiLoadLabel.Margin = new Padding(0);
            totalMultiLoadLabel.Name = "totalMultiLoadLabel";
            totalMultiLoadLabel.Padding = new Padding(5, 0, 0, 0);
            totalMultiLoadLabel.Size = new Size(96, 20);
            totalMultiLoadLabel.TabIndex = 150;
            totalMultiLoadLabel.Text = "0";
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.Right;
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label10.Location = new Point(47, 129);
            Label10.Margin = new Padding(0);
            Label10.Name = "Label10";
            Label10.Size = new Size(94, 21);
            Label10.TabIndex = 116;
            Label10.Text = "Multi Loads:";
            // 
            // Label12
            // 
            Label12.Anchor = AnchorStyles.Right;
            Label12.AutoSize = true;
            Label12.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Location = new Point(43, 160);
            Label12.Margin = new Padding(0);
            Label12.Name = "Label12";
            Label12.Size = new Size(98, 21);
            Label12.TabIndex = 118;
            Label12.Text = "Single Loads";
            // 
            // totalSingleLoadLabel
            // 
            totalSingleLoadLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            totalSingleLoadLabel.AutoSize = true;
            totalSingleLoadLabel.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            totalSingleLoadLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            totalSingleLoadLabel.Location = new Point(142, 161);
            totalSingleLoadLabel.Margin = new Padding(0);
            totalSingleLoadLabel.Name = "totalSingleLoadLabel";
            totalSingleLoadLabel.Padding = new Padding(5, 0, 0, 0);
            totalSingleLoadLabel.Size = new Size(96, 20);
            totalSingleLoadLabel.TabIndex = 153;
            totalSingleLoadLabel.Text = "0";
            // 
            // rateSingleLoadsLabel
            // 
            rateSingleLoadsLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rateSingleLoadsLabel.AutoSize = true;
            rateSingleLoadsLabel.BackColor = Color.White;
            rateSingleLoadsLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            rateSingleLoadsLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            rateSingleLoadsLabel.Location = new Point(239, 160);
            rateSingleLoadsLabel.Margin = new Padding(0);
            rateSingleLoadsLabel.Name = "rateSingleLoadsLabel";
            rateSingleLoadsLabel.Padding = new Padding(5, 0, 0, 0);
            rateSingleLoadsLabel.Size = new Size(102, 21);
            rateSingleLoadsLabel.TabIndex = 148;
            rateSingleLoadsLabel.Text = "$0.00";
            rateSingleLoadsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ratetotalSingleLoadLabel
            // 
            ratetotalSingleLoadLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ratetotalSingleLoadLabel.AutoSize = true;
            ratetotalSingleLoadLabel.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ratetotalSingleLoadLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ratetotalSingleLoadLabel.Location = new Point(342, 161);
            ratetotalSingleLoadLabel.Margin = new Padding(0);
            ratetotalSingleLoadLabel.Name = "ratetotalSingleLoadLabel";
            ratetotalSingleLoadLabel.Padding = new Padding(5, 0, 0, 0);
            ratetotalSingleLoadLabel.Size = new Size(137, 20);
            ratetotalSingleLoadLabel.TabIndex = 152;
            ratetotalSingleLoadLabel.Text = "$0.00";
            // 
            // rateMultiLoadLabel
            // 
            rateMultiLoadLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rateMultiLoadLabel.AutoSize = true;
            rateMultiLoadLabel.BackColor = Color.White;
            rateMultiLoadLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            rateMultiLoadLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            rateMultiLoadLabel.Location = new Point(239, 129);
            rateMultiLoadLabel.Margin = new Padding(0);
            rateMultiLoadLabel.Name = "rateMultiLoadLabel";
            rateMultiLoadLabel.Padding = new Padding(5, 0, 0, 0);
            rateMultiLoadLabel.Size = new Size(102, 21);
            rateMultiLoadLabel.TabIndex = 145;
            rateMultiLoadLabel.Text = "$0.00";
            rateMultiLoadLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ratetotalMultiLoadLabel
            // 
            ratetotalMultiLoadLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ratetotalMultiLoadLabel.AutoSize = true;
            ratetotalMultiLoadLabel.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ratetotalMultiLoadLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ratetotalMultiLoadLabel.Location = new Point(342, 130);
            ratetotalMultiLoadLabel.Margin = new Padding(0);
            ratetotalMultiLoadLabel.Name = "ratetotalMultiLoadLabel";
            ratetotalMultiLoadLabel.Padding = new Padding(5, 0, 0, 0);
            ratetotalMultiLoadLabel.Size = new Size(137, 20);
            ratetotalMultiLoadLabel.TabIndex = 149;
            ratetotalMultiLoadLabel.Text = "$0.00";
            // 
            // lblqtyEmpty
            // 
            lblqtyEmpty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblqtyEmpty.AutoSize = true;
            lblqtyEmpty.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblqtyEmpty.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblqtyEmpty.Location = new Point(142, 99);
            lblqtyEmpty.Margin = new Padding(0);
            lblqtyEmpty.Name = "lblqtyEmpty";
            lblqtyEmpty.Padding = new Padding(5, 0, 0, 0);
            lblqtyEmpty.Size = new Size(96, 20);
            lblqtyEmpty.TabIndex = 154;
            lblqtyEmpty.Text = "0";
            // 
            // lblqtyLoads
            // 
            lblqtyLoads.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblqtyLoads.AutoSize = true;
            lblqtyLoads.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblqtyLoads.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblqtyLoads.Location = new Point(142, 193);
            lblqtyLoads.Margin = new Padding(0);
            lblqtyLoads.Name = "lblqtyLoads";
            lblqtyLoads.Padding = new Padding(5, 0, 0, 0);
            lblqtyLoads.Size = new Size(96, 20);
            lblqtyLoads.TabIndex = 155;
            lblqtyLoads.Text = "0";
            // 
            // lblTotalEmpty
            // 
            lblTotalEmpty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTotalEmpty.AutoSize = true;
            lblTotalEmpty.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotalEmpty.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblTotalEmpty.Location = new Point(342, 99);
            lblTotalEmpty.Margin = new Padding(0);
            lblTotalEmpty.Name = "lblTotalEmpty";
            lblTotalEmpty.Padding = new Padding(5, 0, 0, 0);
            lblTotalEmpty.Size = new Size(137, 20);
            lblTotalEmpty.TabIndex = 156;
            lblTotalEmpty.Text = "$0.00";
            // 
            // Label27
            // 
            Label27.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Label27.AutoSize = true;
            Label27.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label27.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label27.Location = new Point(342, 193);
            Label27.Margin = new Padding(0);
            Label27.Name = "Label27";
            Label27.Padding = new Padding(5, 0, 0, 0);
            Label27.Size = new Size(137, 20);
            Label27.TabIndex = 157;
            Label27.Text = "$0.00";
            // 
            // Label8
            // 
            Label8.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label8.Location = new Point(33, 26);
            Label8.Name = "Label8";
            Label8.Size = new Size(335, 32);
            Label8.TabIndex = 1;
            Label8.Text = "Report Summary";
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "blueBall.png");
            ImageList1.Images.SetKeyName(1, "settings.png");
            ImageList1.Images.SetKeyName(2, "pencil.png");
            ImageList1.Images.SetKeyName(3, "redBall.png");
            // 
            // BunifuShadowPanel1
            // 
            BunifuShadowPanel1.BackColor = Color.White;
            BunifuShadowPanel1.BorderColor = Color.Transparent;
            BunifuShadowPanel1.Controls.Add(Panel2);
            BunifuShadowPanel1.Dock = DockStyle.Fill;
            BunifuShadowPanel1.ForeColor = Color.White;
            BunifuShadowPanel1.Location = new Point(0, 0);
            BunifuShadowPanel1.Margin = new Padding(0);
            BunifuShadowPanel1.Name = "BunifuShadowPanel1";
            BunifuShadowPanel1.Padding = new Padding(10, 6, 5, 5);
            BunifuShadowPanel1.PanelColor = Color.Empty;
            BunifuShadowPanel1.ShadowDept = 2;
            BunifuShadowPanel1.ShadowTopLeftVisible = true;
            BunifuShadowPanel1.Size = new Size(1683, 950);
            BunifuShadowPanel1.TabIndex = 7;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(Panel5);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(10, 6);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1668, 939);
            Panel2.TabIndex = 32;
            // 
            // PrintDialog1
            // 
            PrintDialog1.UseEXDialog = true;
            // 
            // cbCheck
            // 
            cbCheck.FillWeight = 15.91126f;
            cbCheck.HeaderText = "";
            cbCheck.Name = "cbCheck";
            cbCheck.ReadOnly = true;
            // 
            // CompanyNameDataGridViewTextBoxColumn
            // 
            CompanyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            CompanyNameDataGridViewTextBoxColumn.FillWeight = 109.4695f;
            CompanyNameDataGridViewTextBoxColumn.HeaderText = "Carrier Name";
            CompanyNameDataGridViewTextBoxColumn.Name = "CompanyNameDataGridViewTextBoxColumn";
            CompanyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmTruckingRecon
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1683, 950);
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTruckingRecon";
            Text = "FrmContainerReport";
            Panel5.ResumeLayout(false);
            Panel6.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            panelCarriers.ResumeLayout(false);
            panelCarriers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvExtraCarriers).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWCompanyCompanyTypeBindingSource).EndInit();
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvTest).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContainersInOutDrayageBindingSource).EndInit();
            GroupBox2.ResumeLayout(false);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            Panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_addedServDataGridView).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            FlowLayoutPanel1.ResumeLayout(false);
            FlowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TruckDriversBindingSource).EndInit();
            BunifuShadowPanel2.ResumeLayout(false);
            TableLayoutPanel3.ResumeLayout(false);
            TableLayoutPanel3.PerformLayout();
            TableLayoutPanel18.ResumeLayout(false);
            TableLayoutPanel18.PerformLayout();
            TableLayoutPanel17.ResumeLayout(false);
            TableLayoutPanel17.PerformLayout();
            TableLayoutPanel16.ResumeLayout(false);
            TableLayoutPanel16.PerformLayout();
            TableLayoutPanel15.ResumeLayout(false);
            TableLayoutPanel15.PerformLayout();
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            BunifuShadowPanel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Load += new EventHandler(FrmTruckingRecon_Load);
            ResumeLayout(false);
        }

        internal Panel Panel5;
        internal Panel Panel3;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Label Label1;
        internal Label Label2;
        internal Label titleLabel;
        internal Label Label3;
        internal ImageList ImageList1;
        internal TableLayoutPanel TableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _printButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton printButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _printButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_printButton != null)
                {
                    _printButton.Click -= printButton_Click;
                }

                _printButton = value;
                if (_printButton != null)
                {
                    _printButton.Click += printButton_Click;
                }
            }
        }

        internal Label Label7;
        internal Panel Panel6;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _exportButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton exportButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _exportButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_exportButton != null)
                {
                    _exportButton.Click -= exportButton_Click;
                }

                _exportButton = value;
                if (_exportButton != null)
                {
                    _exportButton.Click += exportButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _BunifuButton2;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuButton2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuButton2 != null)
                {
                    _BunifuButton2.Click -= BunifuButton2_Click;
                }

                _BunifuButton2 = value;
                if (_BunifuButton2 != null)
                {
                    _BunifuButton2.Click += BunifuButton2_Click;
                }
            }
        }

        private BunifuTextBox _searchBunifuTextBox1;

        internal BunifuTextBox searchBunifuTextBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _searchBunifuTextBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_searchBunifuTextBox1 != null)
                {
                    _searchBunifuTextBox1.TextChanged -= searchBunifuTextBox1_TextChanged;
                }

                _searchBunifuTextBox1 = value;
                if (_searchBunifuTextBox1 != null)
                {
                    _searchBunifuTextBox1.TextChanged += searchBunifuTextBox1_TextChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDataGridView _addedServDataGridView;

        public Bunifu.UI.WinForms.BunifuDataGridView addedServDataGridView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _addedServDataGridView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_addedServDataGridView != null)
                {
                    _addedServDataGridView.CellContentClick -= addedServDataGridView_CellContentClick;
                    _addedServDataGridView.RowPostPaint -= BunifuDataGridView1_RowPostPaint;
                }

                _addedServDataGridView = value;
                if (_addedServDataGridView != null)
                {
                    _addedServDataGridView.CellContentClick += addedServDataGridView_CellContentClick;
                    _addedServDataGridView.RowPostPaint += BunifuDataGridView1_RowPostPaint;
                }
            }
        }

        internal Panel Panel7;
        internal Bunifu.ToggleSwitch.BunifuToggleSwitch streetTurnToggleSwitch;
        internal Label Label5;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel2;
        internal Label Label8;
        internal TableLayoutPanel TableLayoutPanel2;
        internal Label Label23;
        internal Label Label22;
        internal Label Label21;
        internal Label Label12;
        internal Label rateSingleLoadsLabel;
        internal Label rateMultiLoadLabel;
        internal Label Label10;
        internal Label Label11;
        internal Label Label9;
        internal Label ratetotalSingleLoadLabel;
        internal Label Label;
        internal Label ratetotalSingleEptyLabel;
        internal Label ratetotalMultiEptyLabel;
        internal Label rateMultEptyLabel;
        internal Label rateSingleEptyLabel;
        internal Panel Panel2;
        internal Label totalSingleLoadLabel;
        internal Label totalMultiLoadLabel;
        internal Label totalSingleEptyLabel;
        internal Label totalMultiEptyLabel;
        internal TableLayoutPanel TableLayoutPanel16;
        internal Label totalfsctefLabel;
        internal Label Label16;
        internal Label fscLabel;
        internal TableLayoutPanel TableLayoutPanel15;
        internal Label lblTotalLoad;
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
                    _closeFlatButton.Click -= closeFlatButton_Click;
                }

                _closeFlatButton = value;
                if (_closeFlatButton != null)
                {
                    _closeFlatButton.Click += closeFlatButton_Click;
                }
            }
        }

        internal Label tefFeeLabel;
        internal Label Label17;
        internal TableLayoutPanel TableLayoutPanel17;
        internal Label fscFeeLabel;
        internal TableLayoutPanel TableLayoutPanel18;
        internal Label Label14;
        internal Label totalaftTaxesLabel;
        internal PrintDialog PrintDialog1;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        internal Label ratetotalMultiLoadLabel;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewButtonColumn delCol;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column8;
        private ComboBox _cboTruckingCompany;

        internal ComboBox cboTruckingCompany
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboTruckingCompany;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboTruckingCompany != null)
                {
                    _cboTruckingCompany.SelectedValueChanged -= cboBookingNumber_SelectedIndexChanged;
                    _cboTruckingCompany.SelectedIndexChanged -= cboTruckingCompany_SelectedIndexChanged;
                }

                _cboTruckingCompany = value;
                if (_cboTruckingCompany != null)
                {
                    _cboTruckingCompany.SelectedValueChanged += cboBookingNumber_SelectedIndexChanged;
                    _cboTruckingCompany.SelectedIndexChanged += cboTruckingCompany_SelectedIndexChanged;
                }
            }
        }

        internal Label Label4;
        private ComboBox _cboBookingNumber;

        internal ComboBox cboBookingNumber
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboBookingNumber;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboBookingNumber != null)
                {
                    _cboBookingNumber.SelectedIndexChanged -= cboBookingNumber_SelectedIndexChanged;
                }

                _cboBookingNumber = value;
                if (_cboBookingNumber != null)
                {
                    _cboBookingNumber.SelectedIndexChanged += cboBookingNumber_SelectedIndexChanged;
                }
            }
        }

        internal GroupBox GroupBox1;
        internal DateTimePicker toIDatePicker;
        private DateTimePicker _fromDatePicker;

        internal DateTimePicker fromDatePicker
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _fromDatePicker;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_fromDatePicker != null)
                {
                    _fromDatePicker.ValueChanged -= fromDatePicker_ValueChanged;
                }

                _fromDatePicker = value;
                if (_fromDatePicker != null)
                {
                    _fromDatePicker.ValueChanged += fromDatePicker_ValueChanged;
                }
            }
        }

        internal GroupBox GroupBox2;
        internal Label Label25;
        internal ComboBox cboDriverId;
        internal Label Label24;
        private ComboBox _cboDropOff;

        internal ComboBox cboDropOff
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboDropOff;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboDropOff != null)
                {
                    _cboDropOff.SelectedValueChanged -= cboBookingNumber_SelectedIndexChanged;
                }

                _cboDropOff = value;
                if (_cboDropOff != null)
                {
                    _cboDropOff.SelectedValueChanged += cboBookingNumber_SelectedIndexChanged;
                }
            }
        }

        internal Label Label20;
        private ComboBox _cboPickUp;

        internal ComboBox cboPickUp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboPickUp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboPickUp != null)
                {
                    _cboPickUp.SelectedValueChanged -= cboBookingNumber_SelectedIndexChanged;
                }

                _cboPickUp = value;
                if (_cboPickUp != null)
                {
                    _cboPickUp.SelectedValueChanged += cboBookingNumber_SelectedIndexChanged;
                }
            }
        }

        internal Label Label19;
        internal Label Label18;
        internal Label Label15;
        internal Label Label13;
        internal Label Label6;
        internal Label lblqtyEmpty;
        internal Label lblqtyLoads;
        internal Label lblTotalEmpty;
        internal Label Label27;
        internal BindingSource TruckDriversBindingSource;
        private Bunifu.UI.WinForms.BunifuCheckBox _cbxSingleEmpty;

        internal Bunifu.UI.WinForms.BunifuCheckBox cbxSingleEmpty
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbxSingleEmpty;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbxSingleEmpty != null)
                {
                    _cbxSingleEmpty.Click -= cboBookingNumber_SelectedIndexChanged;
                }

                _cbxSingleEmpty = value;
                if (_cbxSingleEmpty != null)
                {
                    _cbxSingleEmpty.Click += cboBookingNumber_SelectedIndexChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuCheckBox _cboMultiEmpty;

        internal Bunifu.UI.WinForms.BunifuCheckBox cboMultiEmpty
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboMultiEmpty;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboMultiEmpty != null)
                {
                    _cboMultiEmpty.Click -= cboBookingNumber_SelectedIndexChanged;
                }

                _cboMultiEmpty = value;
                if (_cboMultiEmpty != null)
                {
                    _cboMultiEmpty.Click += cboBookingNumber_SelectedIndexChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuCheckBox _cboSingleLoad;

        internal Bunifu.UI.WinForms.BunifuCheckBox cboSingleLoad
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboSingleLoad;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboSingleLoad != null)
                {
                    _cboSingleLoad.Click -= cboBookingNumber_SelectedIndexChanged;
                }

                _cboSingleLoad = value;
                if (_cboSingleLoad != null)
                {
                    _cboSingleLoad.Click += cboBookingNumber_SelectedIndexChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuCheckBox _cboMultiLoad;

        internal Bunifu.UI.WinForms.BunifuCheckBox cboMultiLoad
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboMultiLoad;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboMultiLoad != null)
                {
                    _cboMultiLoad.Click -= cboBookingNumber_SelectedIndexChanged;
                }

                _cboMultiLoad = value;
                if (_cboMultiLoad != null)
                {
                    _cboMultiLoad.Click += cboBookingNumber_SelectedIndexChanged;
                }
            }
        }

        internal Panel Panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvTest;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvTest
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvTest;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvTest != null)
                {
                    _dgvTest.RowPostPaint -= reports1_RowPostPaint;
                }

                _dgvTest = value;
                if (_dgvTest != null)
                {
                    _dgvTest.RowPostPaint += reports1_RowPostPaint;
                }
            }
        }

        internal BindingSource ContainersInOutDrayageBindingSource;
        internal DataGridViewTextBoxColumn GateDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn GateTimeDataGridViewTextBoxColumn;
        internal TableLayoutPanel TableLayoutPanel3;
        internal Label totalQtyLbl;
        internal Label warningLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnRemoveDate;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRemoveDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRemoveDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnRemoveDate != null)
                {
                    _btnRemoveDate.Click -= btnRemoveDate_Click;
                }

                _btnRemoveDate = value;
                if (_btnRemoveDate != null)
                {
                    _btnRemoveDate.Click += btnRemoveDate_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn UniqueIDDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn rate;
        internal DataGridViewTextBoxColumn rateType;
        internal DataGridViewTextBoxColumn ContainerNumbDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn BkrelNumberDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn pickUpCode;
        internal DataGridViewTextBoxColumn dropOffCode;
        internal DataGridViewTextBoxColumn GateDateTime;
        internal DataGridViewTextBoxColumn TruckIDDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn truckDriverId;
        internal DataGridViewTextBoxColumn DriverNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn StreetTurnDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CarrierCodeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CarrierNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DrayageTypeDataGridViewTextBoxColumn;
        internal BindingSource VWCompanyCompanyTypeBindingSource;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddCarrier;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddCarrier
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddCarrier;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddCarrier != null)
                {
                    _btnAddCarrier.Click -= btnAddCarrier_Click;
                }

                _btnAddCarrier = value;
                if (_btnAddCarrier != null)
                {
                    _btnAddCarrier.Click += btnAddCarrier_Click;
                }
            }
        }

        internal Panel panelCarriers;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddLogo;
        private Bunifu.Framework.UI.BunifuFlatButton _BunifuFlatButton1;

        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuFlatButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuFlatButton1 != null)
                {
                    _BunifuFlatButton1.Click -= BunifuFlatButton1_Click;
                }

                _BunifuFlatButton1 = value;
                if (_BunifuFlatButton1 != null)
                {
                    _BunifuFlatButton1.Click += BunifuFlatButton1_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnOkExtraCarriers;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOkExtraCarriers
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOkExtraCarriers;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOkExtraCarriers != null)
                {
                    _btnOkExtraCarriers.Click -= btnOkExtraCarriers_Click;
                }

                _btnOkExtraCarriers = value;
                if (_btnOkExtraCarriers != null)
                {
                    _btnOkExtraCarriers.Click += btnOkExtraCarriers_Click;
                }
            }
        }

        internal Label Label26;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvExtraCarriers;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvExtraCarriers
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvExtraCarriers;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvExtraCarriers != null)
                {
                    _dgvExtraCarriers.CellContentClick -= dgvExtraCarriers_CellContentClick;
                }

                _dgvExtraCarriers = value;
                if (_dgvExtraCarriers != null)
                {
                    _dgvExtraCarriers.CellContentClick += dgvExtraCarriers_CellContentClick;
                }
            }
        }

        internal Label Label28;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Label lblExtraCarrier;
        internal DataGridViewCheckBoxColumn cbCheck;
        internal DataGridViewTextBoxColumn CompanyNameDataGridViewTextBoxColumn;
    }
}