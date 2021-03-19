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
    public partial class frmTruckDriverList : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTruckDriverList));
            var ToggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties17 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties18 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties19 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties20 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties23 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties24 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties25 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties26 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties27 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties28 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel2 = new Panel();
            Panel5 = new Panel();
            Panel3 = new Panel();
            TableLayoutPanel2 = new TableLayoutPanel();
            activePanelPanel = new Panel();
            Label1 = new Label();
            Label3 = new Label();
            _activeToggleSwitch = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            _activeToggleSwitch.Click += new EventHandler(activeToggleSwitch_Click);
            Panel7 = new Panel();
            Label5 = new Label();
            lblQtySelected = new Label();
            TableLayoutPanel3 = new TableLayoutPanel();
            _txtTruckNumber = new BunifuTextBox();
            _txtTruckNumber.TextChange += new EventHandler(txtTruckNumber_TextChange);
            _txtTruckCompany = new BunifuTextBox();
            _txtTruckCompany.TextChange += new EventHandler(txtTruckCompany_TextChange);
            _txtLastName = new BunifuTextBox();
            _txtLastName.TextChange += new EventHandler(txtLastName_TextChange);
            _txtFirstName = new BunifuTextBox();
            _txtFirstName.TextChange += new EventHandler(txtFirstName_TextChange);
            _txtPassId = new BunifuTextBox();
            _txtPassId.TextChange += new EventHandler(txtPassId_TextChange);
            _dgvTruckDrivers = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvTruckDrivers.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dgvTruckDrivers_ColumnHeaderMouseClick);
            _dgvTruckDrivers.CellContentClick += new DataGridViewCellEventHandler(dgvTruckDrivers_CellContentClick);
            _dgvTruckDrivers.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dgvTruckDrivers_RowPostPaint);
            check = new DataGridViewTextBoxColumn();
            TruckDriverIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            PortPassId = new DataGridViewTextBoxColumn();
            FirstNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            LastNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CompanyNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TruckNumberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            SuspendTruckDriverDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CompanyIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CompanyCodeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TruckDriverListBindingSource = new BindingSource(components);
            TableLayoutPanel1 = new TableLayoutPanel();
            _btnUpdateDriver = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnUpdateDriver.Click += new EventHandler(btnUpdateDriver_Click);
            _btnAddCompanyToDriver = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddCompanyToDriver.Click += new EventHandler(btnAddCompanyToDriver_Click);
            _btnAddDriver = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddDriver.Click += new EventHandler(btnAddDriver_Click);
            _btnSuspend = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSuspend.Click += new EventHandler(btnSuspend_Click);
            BunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuShadowPanel1.SuspendLayout();
            Panel2.SuspendLayout();
            Panel5.SuspendLayout();
            Panel3.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            activePanelPanel.SuspendLayout();
            Panel7.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvTruckDrivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TruckDriverListBindingSource).BeginInit();
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            BunifuShadowPanel1.Size = new Size(1500, 840);
            BunifuShadowPanel1.TabIndex = 236;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(Panel5);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(10, 6);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1485, 829);
            Panel2.TabIndex = 32;
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel5.Controls.Add(Panel3);
            Panel5.Dock = DockStyle.Fill;
            Panel5.Location = new Point(0, 0);
            Panel5.Name = "Panel5";
            Panel5.Padding = new Padding(0, 40, 0, 0);
            Panel5.Size = new Size(1485, 829);
            Panel5.TabIndex = 33;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.White;
            Panel3.Controls.Add(TableLayoutPanel2);
            Panel3.Controls.Add(TableLayoutPanel3);
            Panel3.Controls.Add(_dgvTruckDrivers);
            Panel3.Controls.Add(TableLayoutPanel1);
            Panel3.Controls.Add(BunifuLabel7);
            Panel3.Dock = DockStyle.Fill;
            Panel3.Location = new Point(0, 40);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1485, 789);
            Panel3.TabIndex = 0;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.Anchor = AnchorStyles.None;
            TableLayoutPanel2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            TableLayoutPanel2.ColumnCount = 3;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.51511f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.48489f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 568.0f));
            TableLayoutPanel2.Controls.Add(activePanelPanel, 0, 0);
            TableLayoutPanel2.Controls.Add(Panel7, 1, 0);
            TableLayoutPanel2.Location = new Point(111, 678);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 1;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel2.Size = new Size(1250, 25);
            TableLayoutPanel2.TabIndex = 238;
            // 
            // activePanelPanel
            // 
            activePanelPanel.Anchor = AnchorStyles.Left;
            activePanelPanel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            activePanelPanel.Controls.Add(Label1);
            activePanelPanel.Controls.Add(Label3);
            activePanelPanel.Controls.Add(_activeToggleSwitch);
            activePanelPanel.Location = new Point(3, 3);
            activePanelPanel.Name = "activePanelPanel";
            activePanelPanel.Size = new Size(188, 19);
            activePanelPanel.TabIndex = 239;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.Tomato;
            Label1.Location = new Point(4, -1);
            Label1.Name = "Label1";
            Label1.Size = new Size(62, 19);
            Label1.TabIndex = 81;
            Label1.Text = "Suspend";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI Semibold", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.Green;
            Label3.Location = new Point(103, -1);
            Label3.Name = "Label3";
            Label3.Size = new Size(85, 19);
            Label3.TabIndex = 80;
            Label3.Text = "No Suspend";
            // 
            // activeToggleSwitch
            // 
            _activeToggleSwitch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _activeToggleSwitch.Animation = 5;
            _activeToggleSwitch.BackColor = Color.Transparent;
            _activeToggleSwitch.BackgroundImage = (Image)resources.GetObject("activeToggleSwitch.BackgroundImage");
            _activeToggleSwitch.Cursor = Cursors.Hand;
            _activeToggleSwitch.Location = new Point(68, 3);
            _activeToggleSwitch.Margin = new Padding(4);
            _activeToggleSwitch.Name = "_activeToggleSwitch";
            _activeToggleSwitch.Size = new Size(31, 15);
            _activeToggleSwitch.TabIndex = 79;
            ToggleState1.BackColor = Color.Empty;
            ToggleState1.BackColorInner = Color.Empty;
            ToggleState1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(236)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(140)));
            ToggleState1.BorderColorInner = Color.Empty;
            ToggleState1.BorderRadius = 1;
            ToggleState1.BorderRadiusInner = 1;
            ToggleState1.BorderThickness = 1;
            ToggleState1.BorderThicknessInner = 1;
            _activeToggleSwitch.ToggleStateDisabled = ToggleState1;
            ToggleState2.BackColor = Color.Tomato;
            ToggleState2.BackColorInner = Color.White;
            ToggleState2.BorderColor = Color.Tomato;
            ToggleState2.BorderColorInner = Color.White;
            ToggleState2.BorderRadius = 12;
            ToggleState2.BorderRadiusInner = 10;
            ToggleState2.BorderThickness = 1;
            ToggleState2.BorderThicknessInner = 1;
            _activeToggleSwitch.ToggleStateOff = ToggleState2;
            ToggleState3.BackColor = Color.Green;
            ToggleState3.BackColorInner = Color.White;
            ToggleState3.BorderColor = Color.Green;
            ToggleState3.BorderColorInner = Color.White;
            ToggleState3.BorderRadius = 12;
            ToggleState3.BorderRadiusInner = 10;
            ToggleState3.BorderThickness = 1;
            ToggleState3.BorderThicknessInner = 1;
            _activeToggleSwitch.ToggleStateOn = ToggleState3;
            _activeToggleSwitch.Value = true;
            // 
            // Panel7
            // 
            Panel7.Anchor = AnchorStyles.Left;
            Panel7.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel7.Controls.Add(Label5);
            Panel7.Controls.Add(lblQtySelected);
            Panel7.Location = new Point(197, 3);
            Panel7.Name = "Panel7";
            Panel7.Size = new Size(174, 19);
            Panel7.TabIndex = 239;
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.Left;
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Semibold", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.LightGray;
            Label5.Location = new Point(4, -1);
            Label5.Name = "Label5";
            Label5.Size = new Size(90, 19);
            Label5.TabIndex = 81;
            Label5.Text = "Qty selected:";
            // 
            // lblQtySelected
            // 
            lblQtySelected.AutoSize = true;
            lblQtySelected.Font = new Font("Segoe UI Semibold", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblQtySelected.ForeColor = Color.White;
            lblQtySelected.ImageAlign = ContentAlignment.MiddleLeft;
            lblQtySelected.Location = new Point(97, -2);
            lblQtySelected.Name = "lblQtySelected";
            lblQtySelected.Size = new Size(17, 20);
            lblQtySelected.TabIndex = 80;
            lblQtySelected.Text = "0";
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.Anchor = AnchorStyles.None;
            TableLayoutPanel3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            TableLayoutPanel3.ColumnCount = 5;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 205.0f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 168.0f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 167.0f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 506.0f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 143.0f));
            TableLayoutPanel3.Controls.Add(_txtTruckNumber, 4, 0);
            TableLayoutPanel3.Controls.Add(_txtTruckCompany, 3, 0);
            TableLayoutPanel3.Controls.Add(_txtLastName, 2, 0);
            TableLayoutPanel3.Controls.Add(_txtFirstName, 1, 0);
            TableLayoutPanel3.Controls.Add(_txtPassId, 0, 0);
            TableLayoutPanel3.Location = new Point(147, 93);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel3.Size = new Size(1189, 23);
            TableLayoutPanel3.TabIndex = 235;
            // 
            // txtTruckNumber
            // 
            _txtTruckNumber.AcceptsReturn = false;
            _txtTruckNumber.AcceptsTab = false;
            _txtTruckNumber.Anchor = AnchorStyles.Left;
            _txtTruckNumber.AnimationSpeed = 200;
            _txtTruckNumber.AutoCompleteMode = AutoCompleteMode.None;
            _txtTruckNumber.AutoCompleteSource = AutoCompleteSource.None;
            _txtTruckNumber.BackColor = Color.Transparent;
            _txtTruckNumber.BackgroundImage = (Image)resources.GetObject("txtTruckNumber.BackgroundImage");
            _txtTruckNumber.BorderColorActive = Color.DodgerBlue;
            _txtTruckNumber.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtTruckNumber.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtTruckNumber.BorderColorIdle = Color.Transparent;
            _txtTruckNumber.BorderRadius = 2;
            _txtTruckNumber.BorderThickness = 0;
            _txtTruckNumber.CharacterCasing = CharacterCasing.Upper;
            _txtTruckNumber.Cursor = Cursors.IBeam;
            _txtTruckNumber.DefaultFont = new Font("Arial", 8.5f, FontStyle.Bold);
            _txtTruckNumber.DefaultText = "";
            _txtTruckNumber.FillColor = Color.White;
            _txtTruckNumber.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _txtTruckNumber.HideSelection = true;
            _txtTruckNumber.IconLeft = null;
            _txtTruckNumber.IconLeftCursor = Cursors.IBeam;
            _txtTruckNumber.IconPadding = 10;
            _txtTruckNumber.IconRight = null;
            _txtTruckNumber.IconRightCursor = Cursors.IBeam;
            _txtTruckNumber.Lines = new string[0];
            _txtTruckNumber.Location = new Point(1046, 1);
            _txtTruckNumber.Margin = new Padding(0);
            _txtTruckNumber.MaxLength = 32767;
            _txtTruckNumber.MinimumSize = new Size(30, 15);
            _txtTruckNumber.Modified = false;
            _txtTruckNumber.Multiline = false;
            _txtTruckNumber.Name = "_txtTruckNumber";
            StateProperties1.BorderColor = Color.DodgerBlue;
            StateProperties1.FillColor = Color.Empty;
            StateProperties1.ForeColor = Color.Empty;
            StateProperties1.PlaceholderForeColor = Color.Empty;
            _txtTruckNumber.OnActiveState = StateProperties1;
            StateProperties2.BorderColor = Color.Empty;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.Empty;
            StateProperties2.PlaceholderForeColor = Color.Silver;
            _txtTruckNumber.OnDisabledState = StateProperties2;
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            _txtTruckNumber.OnHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Transparent;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.PlaceholderForeColor = Color.Empty;
            _txtTruckNumber.OnIdleState = StateProperties4;
            _txtTruckNumber.PasswordChar = '\0';
            _txtTruckNumber.PlaceholderForeColor = Color.Silver;
            _txtTruckNumber.PlaceholderText = "TRUCK NUMBER";
            _txtTruckNumber.ReadOnly = false;
            _txtTruckNumber.ScrollBars = ScrollBars.None;
            _txtTruckNumber.SelectedText = "";
            _txtTruckNumber.SelectionLength = 0;
            _txtTruckNumber.SelectionStart = 0;
            _txtTruckNumber.ShortcutsEnabled = true;
            _txtTruckNumber.Size = new Size(140, 20);
            _txtTruckNumber.Style = _Style.Bunifu;
            _txtTruckNumber.TabIndex = 241;
            _txtTruckNumber.TextAlign = HorizontalAlignment.Left;
            _txtTruckNumber.TextMarginBottom = 0;
            _txtTruckNumber.TextMarginLeft = 0;
            _txtTruckNumber.TextMarginTop = 0;
            _txtTruckNumber.TextPlaceholder = "TRUCK NUMBER";
            _txtTruckNumber.UseSystemPasswordChar = false;
            _txtTruckNumber.WordWrap = true;
            // 
            // txtTruckCompany
            // 
            _txtTruckCompany.AcceptsReturn = false;
            _txtTruckCompany.AcceptsTab = false;
            _txtTruckCompany.Anchor = AnchorStyles.Left;
            _txtTruckCompany.AnimationSpeed = 200;
            _txtTruckCompany.AutoCompleteMode = AutoCompleteMode.None;
            _txtTruckCompany.AutoCompleteSource = AutoCompleteSource.None;
            _txtTruckCompany.BackColor = Color.Transparent;
            _txtTruckCompany.BackgroundImage = (Image)resources.GetObject("txtTruckCompany.BackgroundImage");
            _txtTruckCompany.BorderColorActive = Color.DodgerBlue;
            _txtTruckCompany.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtTruckCompany.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtTruckCompany.BorderColorIdle = Color.Transparent;
            _txtTruckCompany.BorderRadius = 2;
            _txtTruckCompany.BorderThickness = 0;
            _txtTruckCompany.CharacterCasing = CharacterCasing.Upper;
            _txtTruckCompany.Cursor = Cursors.IBeam;
            _txtTruckCompany.DefaultFont = new Font("Arial", 8.5f, FontStyle.Bold);
            _txtTruckCompany.DefaultText = "";
            _txtTruckCompany.FillColor = Color.White;
            _txtTruckCompany.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _txtTruckCompany.HideSelection = true;
            _txtTruckCompany.IconLeft = null;
            _txtTruckCompany.IconLeftCursor = Cursors.IBeam;
            _txtTruckCompany.IconPadding = 10;
            _txtTruckCompany.IconRight = null;
            _txtTruckCompany.IconRightCursor = Cursors.IBeam;
            _txtTruckCompany.Lines = new string[0];
            _txtTruckCompany.Location = new Point(540, 1);
            _txtTruckCompany.Margin = new Padding(0);
            _txtTruckCompany.MaxLength = 32767;
            _txtTruckCompany.MinimumSize = new Size(30, 15);
            _txtTruckCompany.Modified = false;
            _txtTruckCompany.Multiline = false;
            _txtTruckCompany.Name = "_txtTruckCompany";
            StateProperties5.BorderColor = Color.DodgerBlue;
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            _txtTruckCompany.OnActiveState = StateProperties5;
            StateProperties6.BorderColor = Color.Empty;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Silver;
            _txtTruckCompany.OnDisabledState = StateProperties6;
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            _txtTruckCompany.OnHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Transparent;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties8.PlaceholderForeColor = Color.Empty;
            _txtTruckCompany.OnIdleState = StateProperties8;
            _txtTruckCompany.PasswordChar = '\0';
            _txtTruckCompany.PlaceholderForeColor = Color.Silver;
            _txtTruckCompany.PlaceholderText = "TRUCK COMPANY";
            _txtTruckCompany.ReadOnly = false;
            _txtTruckCompany.ScrollBars = ScrollBars.None;
            _txtTruckCompany.SelectedText = "";
            _txtTruckCompany.SelectionLength = 0;
            _txtTruckCompany.SelectionStart = 0;
            _txtTruckCompany.ShortcutsEnabled = true;
            _txtTruckCompany.Size = new Size(506, 20);
            _txtTruckCompany.Style = _Style.Bunifu;
            _txtTruckCompany.TabIndex = 240;
            _txtTruckCompany.TextAlign = HorizontalAlignment.Left;
            _txtTruckCompany.TextMarginBottom = 0;
            _txtTruckCompany.TextMarginLeft = 0;
            _txtTruckCompany.TextMarginTop = 0;
            _txtTruckCompany.TextPlaceholder = "TRUCK COMPANY";
            _txtTruckCompany.UseSystemPasswordChar = false;
            _txtTruckCompany.WordWrap = true;
            // 
            // txtLastName
            // 
            _txtLastName.AcceptsReturn = false;
            _txtLastName.AcceptsTab = false;
            _txtLastName.Anchor = AnchorStyles.Left;
            _txtLastName.AnimationSpeed = 200;
            _txtLastName.AutoCompleteMode = AutoCompleteMode.None;
            _txtLastName.AutoCompleteSource = AutoCompleteSource.None;
            _txtLastName.BackColor = Color.Transparent;
            _txtLastName.BackgroundImage = (Image)resources.GetObject("txtLastName.BackgroundImage");
            _txtLastName.BorderColorActive = Color.DodgerBlue;
            _txtLastName.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtLastName.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtLastName.BorderColorIdle = Color.Transparent;
            _txtLastName.BorderRadius = 2;
            _txtLastName.BorderThickness = 0;
            _txtLastName.CharacterCasing = CharacterCasing.Upper;
            _txtLastName.Cursor = Cursors.IBeam;
            _txtLastName.DefaultFont = new Font("Arial", 8.5f, FontStyle.Bold);
            _txtLastName.DefaultText = "";
            _txtLastName.FillColor = Color.White;
            _txtLastName.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _txtLastName.HideSelection = true;
            _txtLastName.IconLeft = null;
            _txtLastName.IconLeftCursor = Cursors.IBeam;
            _txtLastName.IconPadding = 10;
            _txtLastName.IconRight = null;
            _txtLastName.IconRightCursor = Cursors.IBeam;
            _txtLastName.Lines = new string[0];
            _txtLastName.Location = new Point(373, 1);
            _txtLastName.Margin = new Padding(0);
            _txtLastName.MaxLength = 32767;
            _txtLastName.MinimumSize = new Size(30, 15);
            _txtLastName.Modified = false;
            _txtLastName.Multiline = false;
            _txtLastName.Name = "_txtLastName";
            StateProperties9.BorderColor = Color.DodgerBlue;
            StateProperties9.FillColor = Color.Empty;
            StateProperties9.ForeColor = Color.Empty;
            StateProperties9.PlaceholderForeColor = Color.Empty;
            _txtLastName.OnActiveState = StateProperties9;
            StateProperties10.BorderColor = Color.Empty;
            StateProperties10.FillColor = Color.White;
            StateProperties10.ForeColor = Color.Empty;
            StateProperties10.PlaceholderForeColor = Color.Silver;
            _txtLastName.OnDisabledState = StateProperties10;
            StateProperties11.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties11.FillColor = Color.Empty;
            StateProperties11.ForeColor = Color.Empty;
            StateProperties11.PlaceholderForeColor = Color.Empty;
            _txtLastName.OnHoverState = StateProperties11;
            StateProperties12.BorderColor = Color.Transparent;
            StateProperties12.FillColor = Color.White;
            StateProperties12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties12.PlaceholderForeColor = Color.Empty;
            _txtLastName.OnIdleState = StateProperties12;
            _txtLastName.PasswordChar = '\0';
            _txtLastName.PlaceholderForeColor = Color.Silver;
            _txtLastName.PlaceholderText = "LAST NAME";
            _txtLastName.ReadOnly = false;
            _txtLastName.ScrollBars = ScrollBars.None;
            _txtLastName.SelectedText = "";
            _txtLastName.SelectionLength = 0;
            _txtLastName.SelectionStart = 0;
            _txtLastName.ShortcutsEnabled = true;
            _txtLastName.Size = new Size(167, 20);
            _txtLastName.Style = _Style.Bunifu;
            _txtLastName.TabIndex = 239;
            _txtLastName.TextAlign = HorizontalAlignment.Left;
            _txtLastName.TextMarginBottom = 0;
            _txtLastName.TextMarginLeft = 0;
            _txtLastName.TextMarginTop = 0;
            _txtLastName.TextPlaceholder = "LAST NAME";
            _txtLastName.UseSystemPasswordChar = false;
            _txtLastName.WordWrap = true;
            // 
            // txtFirstName
            // 
            _txtFirstName.AcceptsReturn = false;
            _txtFirstName.AcceptsTab = false;
            _txtFirstName.Anchor = AnchorStyles.Left;
            _txtFirstName.AnimationSpeed = 200;
            _txtFirstName.AutoCompleteMode = AutoCompleteMode.None;
            _txtFirstName.AutoCompleteSource = AutoCompleteSource.None;
            _txtFirstName.BackColor = Color.Transparent;
            _txtFirstName.BackgroundImage = (Image)resources.GetObject("txtFirstName.BackgroundImage");
            _txtFirstName.BorderColorActive = Color.DodgerBlue;
            _txtFirstName.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtFirstName.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtFirstName.BorderColorIdle = Color.Transparent;
            _txtFirstName.BorderRadius = 2;
            _txtFirstName.BorderThickness = 0;
            _txtFirstName.CharacterCasing = CharacterCasing.Upper;
            _txtFirstName.Cursor = Cursors.IBeam;
            _txtFirstName.DefaultFont = new Font("Arial", 8.5f, FontStyle.Bold);
            _txtFirstName.DefaultText = "";
            _txtFirstName.FillColor = Color.White;
            _txtFirstName.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _txtFirstName.HideSelection = true;
            _txtFirstName.IconLeft = null;
            _txtFirstName.IconLeftCursor = Cursors.IBeam;
            _txtFirstName.IconPadding = 10;
            _txtFirstName.IconRight = null;
            _txtFirstName.IconRightCursor = Cursors.IBeam;
            _txtFirstName.Lines = new string[0];
            _txtFirstName.Location = new Point(205, 1);
            _txtFirstName.Margin = new Padding(0);
            _txtFirstName.MaxLength = 32767;
            _txtFirstName.MinimumSize = new Size(30, 15);
            _txtFirstName.Modified = false;
            _txtFirstName.Multiline = false;
            _txtFirstName.Name = "_txtFirstName";
            StateProperties13.BorderColor = Color.DodgerBlue;
            StateProperties13.FillColor = Color.Empty;
            StateProperties13.ForeColor = Color.Empty;
            StateProperties13.PlaceholderForeColor = Color.Empty;
            _txtFirstName.OnActiveState = StateProperties13;
            StateProperties14.BorderColor = Color.Empty;
            StateProperties14.FillColor = Color.White;
            StateProperties14.ForeColor = Color.Empty;
            StateProperties14.PlaceholderForeColor = Color.Silver;
            _txtFirstName.OnDisabledState = StateProperties14;
            StateProperties15.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties15.FillColor = Color.Empty;
            StateProperties15.ForeColor = Color.Empty;
            StateProperties15.PlaceholderForeColor = Color.Empty;
            _txtFirstName.OnHoverState = StateProperties15;
            StateProperties16.BorderColor = Color.Transparent;
            StateProperties16.FillColor = Color.White;
            StateProperties16.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties16.PlaceholderForeColor = Color.Empty;
            _txtFirstName.OnIdleState = StateProperties16;
            _txtFirstName.PasswordChar = '\0';
            _txtFirstName.PlaceholderForeColor = Color.Silver;
            _txtFirstName.PlaceholderText = "FIRST NAME";
            _txtFirstName.ReadOnly = false;
            _txtFirstName.ScrollBars = ScrollBars.None;
            _txtFirstName.SelectedText = "";
            _txtFirstName.SelectionLength = 0;
            _txtFirstName.SelectionStart = 0;
            _txtFirstName.ShortcutsEnabled = true;
            _txtFirstName.Size = new Size(168, 20);
            _txtFirstName.Style = _Style.Bunifu;
            _txtFirstName.TabIndex = 238;
            _txtFirstName.TextAlign = HorizontalAlignment.Left;
            _txtFirstName.TextMarginBottom = 0;
            _txtFirstName.TextMarginLeft = 0;
            _txtFirstName.TextMarginTop = 0;
            _txtFirstName.TextPlaceholder = "FIRST NAME";
            _txtFirstName.UseSystemPasswordChar = false;
            _txtFirstName.WordWrap = true;
            // 
            // txtPassId
            // 
            _txtPassId.AcceptsReturn = false;
            _txtPassId.AcceptsTab = false;
            _txtPassId.Anchor = AnchorStyles.Left;
            _txtPassId.AnimationSpeed = 200;
            _txtPassId.AutoCompleteMode = AutoCompleteMode.None;
            _txtPassId.AutoCompleteSource = AutoCompleteSource.None;
            _txtPassId.BackColor = Color.Transparent;
            _txtPassId.BackgroundImage = (Image)resources.GetObject("txtPassId.BackgroundImage");
            _txtPassId.BorderColorActive = Color.DodgerBlue;
            _txtPassId.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtPassId.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtPassId.BorderColorIdle = Color.Transparent;
            _txtPassId.BorderRadius = 2;
            _txtPassId.BorderThickness = 0;
            _txtPassId.CharacterCasing = CharacterCasing.Upper;
            _txtPassId.Cursor = Cursors.IBeam;
            _txtPassId.DefaultFont = new Font("Arial", 8.5f, FontStyle.Bold);
            _txtPassId.DefaultText = "";
            _txtPassId.FillColor = Color.White;
            _txtPassId.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _txtPassId.HideSelection = true;
            _txtPassId.IconLeft = null;
            _txtPassId.IconLeftCursor = Cursors.IBeam;
            _txtPassId.IconPadding = 10;
            _txtPassId.IconRight = null;
            _txtPassId.IconRightCursor = Cursors.IBeam;
            _txtPassId.Lines = new string[0];
            _txtPassId.Location = new Point(0, 1);
            _txtPassId.Margin = new Padding(0);
            _txtPassId.MaxLength = 32767;
            _txtPassId.MinimumSize = new Size(30, 15);
            _txtPassId.Modified = false;
            _txtPassId.Multiline = false;
            _txtPassId.Name = "_txtPassId";
            StateProperties17.BorderColor = Color.DodgerBlue;
            StateProperties17.FillColor = Color.Empty;
            StateProperties17.ForeColor = Color.Empty;
            StateProperties17.PlaceholderForeColor = Color.Empty;
            _txtPassId.OnActiveState = StateProperties17;
            StateProperties18.BorderColor = Color.Empty;
            StateProperties18.FillColor = Color.White;
            StateProperties18.ForeColor = Color.Empty;
            StateProperties18.PlaceholderForeColor = Color.Silver;
            _txtPassId.OnDisabledState = StateProperties18;
            StateProperties19.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties19.FillColor = Color.Empty;
            StateProperties19.ForeColor = Color.Empty;
            StateProperties19.PlaceholderForeColor = Color.Empty;
            _txtPassId.OnHoverState = StateProperties19;
            StateProperties20.BorderColor = Color.Transparent;
            StateProperties20.FillColor = Color.White;
            StateProperties20.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties20.PlaceholderForeColor = Color.Empty;
            _txtPassId.OnIdleState = StateProperties20;
            _txtPassId.PasswordChar = '\0';
            _txtPassId.PlaceholderForeColor = Color.Silver;
            _txtPassId.PlaceholderText = "PASS ID";
            _txtPassId.ReadOnly = false;
            _txtPassId.ScrollBars = ScrollBars.None;
            _txtPassId.SelectedText = "";
            _txtPassId.SelectionLength = 0;
            _txtPassId.SelectionStart = 0;
            _txtPassId.ShortcutsEnabled = true;
            _txtPassId.Size = new Size(205, 20);
            _txtPassId.Style = _Style.Bunifu;
            _txtPassId.TabIndex = 237;
            _txtPassId.TextAlign = HorizontalAlignment.Left;
            _txtPassId.TextMarginBottom = 0;
            _txtPassId.TextMarginLeft = 0;
            _txtPassId.TextMarginTop = 0;
            _txtPassId.TextPlaceholder = "PASS ID";
            _txtPassId.UseSystemPasswordChar = false;
            _txtPassId.WordWrap = true;
            // 
            // dgvTruckDrivers
            // 
            _dgvTruckDrivers.AllowCustomTheming = true;
            _dgvTruckDrivers.AllowUserToAddRows = false;
            _dgvTruckDrivers.AllowUserToDeleteRows = false;
            _dgvTruckDrivers.AllowUserToOrderColumns = true;
            _dgvTruckDrivers.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = SystemColors.Control;
            DataGridViewCellStyle1.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvTruckDrivers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvTruckDrivers.Anchor = AnchorStyles.None;
            _dgvTruckDrivers.AutoGenerateColumns = false;
            _dgvTruckDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvTruckDrivers.BackgroundColor = Color.White;
            _dgvTruckDrivers.BorderStyle = BorderStyle.None;
            _dgvTruckDrivers.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            _dgvTruckDrivers.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            _dgvTruckDrivers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvTruckDrivers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvTruckDrivers.ColumnHeadersHeight = 45;
            _dgvTruckDrivers.Columns.AddRange(new DataGridViewColumn[] { check, TruckDriverIdDataGridViewTextBoxColumn1, PortPassId, FirstNameDataGridViewTextBoxColumn1, LastNameDataGridViewTextBoxColumn1, CompanyNameDataGridViewTextBoxColumn1, TruckNumberDataGridViewTextBoxColumn1, SuspendTruckDriverDataGridViewTextBoxColumn1, CompanyIdDataGridViewTextBoxColumn1, CompanyCodeDataGridViewTextBoxColumn1 });
            _dgvTruckDrivers.CurrentTheme.AlternatingRowsStyle.BackColor = SystemColors.Control;
            _dgvTruckDrivers.CurrentTheme.AlternatingRowsStyle.Font = new Font("Arial", 9.5f);
            _dgvTruckDrivers.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvTruckDrivers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvTruckDrivers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvTruckDrivers.CurrentTheme.BackColor = Color.White;
            _dgvTruckDrivers.CurrentTheme.GridColor = Color.Gainsboro;
            _dgvTruckDrivers.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvTruckDrivers.CurrentTheme.HeaderStyle.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            _dgvTruckDrivers.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvTruckDrivers.CurrentTheme.Name = null;
            _dgvTruckDrivers.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgvTruckDrivers.CurrentTheme.RowsStyle.Font = new Font("Arial", 9.5f);
            _dgvTruckDrivers.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvTruckDrivers.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvTruckDrivers.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvTruckDrivers.DataSource = TruckDriverListBindingSource;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.White;
            DataGridViewCellStyle3.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvTruckDrivers.DefaultCellStyle = DataGridViewCellStyle3;
            _dgvTruckDrivers.EnableHeadersVisualStyles = false;
            _dgvTruckDrivers.GridColor = Color.Gainsboro;
            _dgvTruckDrivers.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvTruckDrivers.HeaderBgColor = Color.Empty;
            _dgvTruckDrivers.HeaderForeColor = Color.White;
            _dgvTruckDrivers.Location = new Point(111, 72);
            _dgvTruckDrivers.Name = "_dgvTruckDrivers";
            _dgvTruckDrivers.ReadOnly = true;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            _dgvTruckDrivers.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
            _dgvTruckDrivers.RowHeadersVisible = false;
            _dgvTruckDrivers.RowHeadersWidth = 29;
            DataGridViewCellStyle5.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvTruckDrivers.RowsDefaultCellStyle = DataGridViewCellStyle5;
            _dgvTruckDrivers.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.0f);
            _dgvTruckDrivers.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            _dgvTruckDrivers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvTruckDrivers.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            _dgvTruckDrivers.RowTemplate.Height = 27;
            _dgvTruckDrivers.ScrollBars = ScrollBars.Vertical;
            _dgvTruckDrivers.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _dgvTruckDrivers.Size = new Size(1250, 606);
            _dgvTruckDrivers.TabIndex = 237;
            _dgvTruckDrivers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // check
            // 
            check.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            check.FillWeight = 35.0f;
            check.HeaderText = "✔";
            check.MinimumWidth = 35;
            check.Name = "check";
            check.ReadOnly = true;
            check.Resizable = DataGridViewTriState.True;
            check.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // TruckDriverIdDataGridViewTextBoxColumn1
            // 
            TruckDriverIdDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TruckDriverIdDataGridViewTextBoxColumn1.DataPropertyName = "TruckDriverId";
            TruckDriverIdDataGridViewTextBoxColumn1.HeaderText = "TruckDriverId";
            TruckDriverIdDataGridViewTextBoxColumn1.Name = "TruckDriverIdDataGridViewTextBoxColumn1";
            TruckDriverIdDataGridViewTextBoxColumn1.ReadOnly = true;
            TruckDriverIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // PortPassId
            // 
            PortPassId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PortPassId.DataPropertyName = "PortPassId";
            PortPassId.FillWeight = 205.0f;
            PortPassId.HeaderText = "PortPassId";
            PortPassId.MinimumWidth = 205;
            PortPassId.Name = "PortPassId";
            PortPassId.ReadOnly = true;
            // 
            // FirstNameDataGridViewTextBoxColumn1
            // 
            FirstNameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FirstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            FirstNameDataGridViewTextBoxColumn1.FillWeight = 168.0f;
            FirstNameDataGridViewTextBoxColumn1.HeaderText = "First Name";
            FirstNameDataGridViewTextBoxColumn1.MinimumWidth = 168;
            FirstNameDataGridViewTextBoxColumn1.Name = "FirstNameDataGridViewTextBoxColumn1";
            FirstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // LastNameDataGridViewTextBoxColumn1
            // 
            LastNameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            LastNameDataGridViewTextBoxColumn1.FillWeight = 168.0f;
            LastNameDataGridViewTextBoxColumn1.HeaderText = "Last Name";
            LastNameDataGridViewTextBoxColumn1.MinimumWidth = 168;
            LastNameDataGridViewTextBoxColumn1.Name = "LastNameDataGridViewTextBoxColumn1";
            LastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // CompanyNameDataGridViewTextBoxColumn1
            // 
            CompanyNameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CompanyNameDataGridViewTextBoxColumn1.DataPropertyName = "CompanyName";
            CompanyNameDataGridViewTextBoxColumn1.FillWeight = 505.0f;
            CompanyNameDataGridViewTextBoxColumn1.HeaderText = "Truck Company";
            CompanyNameDataGridViewTextBoxColumn1.MinimumWidth = 505;
            CompanyNameDataGridViewTextBoxColumn1.Name = "CompanyNameDataGridViewTextBoxColumn1";
            CompanyNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TruckNumberDataGridViewTextBoxColumn1
            // 
            TruckNumberDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TruckNumberDataGridViewTextBoxColumn1.DataPropertyName = "TruckNumber";
            TruckNumberDataGridViewTextBoxColumn1.FillWeight = 168.0f;
            TruckNumberDataGridViewTextBoxColumn1.HeaderText = "Truck Number";
            TruckNumberDataGridViewTextBoxColumn1.MinimumWidth = 168;
            TruckNumberDataGridViewTextBoxColumn1.Name = "TruckNumberDataGridViewTextBoxColumn1";
            TruckNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // SuspendTruckDriverDataGridViewTextBoxColumn1
            // 
            SuspendTruckDriverDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SuspendTruckDriverDataGridViewTextBoxColumn1.DataPropertyName = "SuspendTruckDriver";
            SuspendTruckDriverDataGridViewTextBoxColumn1.HeaderText = "Suspend";
            SuspendTruckDriverDataGridViewTextBoxColumn1.Name = "SuspendTruckDriverDataGridViewTextBoxColumn1";
            SuspendTruckDriverDataGridViewTextBoxColumn1.ReadOnly = true;
            SuspendTruckDriverDataGridViewTextBoxColumn1.Visible = false;
            // 
            // CompanyIdDataGridViewTextBoxColumn1
            // 
            CompanyIdDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CompanyIdDataGridViewTextBoxColumn1.DataPropertyName = "CompanyId";
            CompanyIdDataGridViewTextBoxColumn1.HeaderText = "CompanyId";
            CompanyIdDataGridViewTextBoxColumn1.Name = "CompanyIdDataGridViewTextBoxColumn1";
            CompanyIdDataGridViewTextBoxColumn1.ReadOnly = true;
            CompanyIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // CompanyCodeDataGridViewTextBoxColumn1
            // 
            CompanyCodeDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CompanyCodeDataGridViewTextBoxColumn1.DataPropertyName = "CompanyCode";
            CompanyCodeDataGridViewTextBoxColumn1.HeaderText = "CompanyCode";
            CompanyCodeDataGridViewTextBoxColumn1.Name = "CompanyCodeDataGridViewTextBoxColumn1";
            CompanyCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            CompanyCodeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // TruckDriverListBindingSource
            // 
            TruckDriverListBindingSource.DataSource = typeof(ModelLayer.CustomModel.TruckDriverList);
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.None;
            TableLayoutPanel1.ColumnCount = 4;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.10526f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.89474f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 271.0f));
            TableLayoutPanel1.Controls.Add(_btnUpdateDriver, 1, 0);
            TableLayoutPanel1.Controls.Add(_btnAddCompanyToDriver, 3, 0);
            TableLayoutPanel1.Controls.Add(_btnAddDriver, 2, 0);
            TableLayoutPanel1.Controls.Add(_btnSuspend, 0, 0);
            TableLayoutPanel1.Location = new Point(583, 725);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new Size(776, 44);
            TableLayoutPanel1.TabIndex = 236;
            // 
            // btnUpdateDriver
            // 
            _btnUpdateDriver.AllowToggling = false;
            _btnUpdateDriver.Anchor = AnchorStyles.Right;
            _btnUpdateDriver.AnimationSpeed = 200;
            _btnUpdateDriver.AutoGenerateColors = false;
            _btnUpdateDriver.BackColor = Color.Transparent;
            _btnUpdateDriver.BackColor1 = Color.Teal;
            _btnUpdateDriver.BackgroundImage = (Image)resources.GetObject("btnUpdateDriver.BackgroundImage");
            _btnUpdateDriver.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnUpdateDriver.ButtonText = "Edit";
            _btnUpdateDriver.ButtonTextMarginLeft = 0;
            _btnUpdateDriver.ColorContrastOnClick = 45;
            _btnUpdateDriver.ColorContrastOnHover = 45;
            _btnUpdateDriver.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnUpdateDriver.CustomizableEdges = BorderEdges1;
            _btnUpdateDriver.DialogResult = DialogResult.None;
            _btnUpdateDriver.DisabledBorderColor = Color.Empty;
            _btnUpdateDriver.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnUpdateDriver.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnUpdateDriver.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnUpdateDriver.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnUpdateDriver.ForeColor = Color.White;
            _btnUpdateDriver.IconLeftCursor = Cursors.Hand;
            _btnUpdateDriver.IconMarginLeft = 11;
            _btnUpdateDriver.IconPadding = 10;
            _btnUpdateDriver.IconRightCursor = Cursors.Hand;
            _btnUpdateDriver.IdleBorderColor = Color.Teal;
            _btnUpdateDriver.IdleBorderRadius = 3;
            _btnUpdateDriver.IdleBorderThickness = 1;
            _btnUpdateDriver.IdleFillColor = Color.Teal;
            _btnUpdateDriver.IdleIconLeftImage = null;
            _btnUpdateDriver.IdleIconRightImage = null;
            _btnUpdateDriver.IndicateFocus = true;
            _btnUpdateDriver.Location = new Point(237, 4);
            _btnUpdateDriver.Name = "_btnUpdateDriver";
            StateProperties21.BorderColor = Color.MediumTurquoise;
            StateProperties21.BorderRadius = 3;
            StateProperties21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties21.BorderThickness = 1;
            StateProperties21.FillColor = Color.MediumTurquoise;
            StateProperties21.ForeColor = Color.White;
            StateProperties21.IconLeftImage = null;
            StateProperties21.IconRightImage = null;
            _btnUpdateDriver.onHoverState = StateProperties21;
            StateProperties22.BorderColor = Color.Teal;
            StateProperties22.BorderRadius = 3;
            StateProperties22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties22.BorderThickness = 1;
            StateProperties22.FillColor = Color.Teal;
            StateProperties22.ForeColor = Color.White;
            StateProperties22.IconLeftImage = null;
            StateProperties22.IconRightImage = null;
            _btnUpdateDriver.OnPressedState = StateProperties22;
            _btnUpdateDriver.Size = new Size(136, 35);
            _btnUpdateDriver.TabIndex = 233;
            _btnUpdateDriver.TextAlign = ContentAlignment.MiddleCenter;
            _btnUpdateDriver.TextMarginLeft = 0;
            _btnUpdateDriver.UseDefaultRadiusAndThickness = true;
            // 
            // btnAddCompanyToDriver
            // 
            _btnAddCompanyToDriver.AllowToggling = false;
            _btnAddCompanyToDriver.Anchor = AnchorStyles.Right;
            _btnAddCompanyToDriver.AnimationSpeed = 200;
            _btnAddCompanyToDriver.AutoGenerateColors = false;
            _btnAddCompanyToDriver.BackColor = Color.Transparent;
            _btnAddCompanyToDriver.BackColor1 = Color.Teal;
            _btnAddCompanyToDriver.BackgroundImage = (Image)resources.GetObject("btnAddCompanyToDriver.BackgroundImage");
            _btnAddCompanyToDriver.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddCompanyToDriver.ButtonText = "Connect Truck Driver to company";
            _btnAddCompanyToDriver.ButtonTextMarginLeft = 0;
            _btnAddCompanyToDriver.ColorContrastOnClick = 45;
            _btnAddCompanyToDriver.ColorContrastOnHover = 45;
            _btnAddCompanyToDriver.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnAddCompanyToDriver.CustomizableEdges = BorderEdges2;
            _btnAddCompanyToDriver.DialogResult = DialogResult.None;
            _btnAddCompanyToDriver.DisabledBorderColor = Color.Empty;
            _btnAddCompanyToDriver.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddCompanyToDriver.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddCompanyToDriver.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddCompanyToDriver.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddCompanyToDriver.ForeColor = Color.White;
            _btnAddCompanyToDriver.IconLeftCursor = Cursors.Hand;
            _btnAddCompanyToDriver.IconMarginLeft = 11;
            _btnAddCompanyToDriver.IconPadding = 10;
            _btnAddCompanyToDriver.IconRightCursor = Cursors.Hand;
            _btnAddCompanyToDriver.IdleBorderColor = Color.Teal;
            _btnAddCompanyToDriver.IdleBorderRadius = 3;
            _btnAddCompanyToDriver.IdleBorderThickness = 1;
            _btnAddCompanyToDriver.IdleFillColor = Color.Teal;
            _btnAddCompanyToDriver.IdleIconLeftImage = null;
            _btnAddCompanyToDriver.IdleIconRightImage = null;
            _btnAddCompanyToDriver.IndicateFocus = true;
            _btnAddCompanyToDriver.Location = new Point(513, 4);
            _btnAddCompanyToDriver.Name = "_btnAddCompanyToDriver";
            StateProperties23.BorderColor = Color.MediumTurquoise;
            StateProperties23.BorderRadius = 3;
            StateProperties23.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties23.BorderThickness = 1;
            StateProperties23.FillColor = Color.MediumTurquoise;
            StateProperties23.ForeColor = Color.White;
            StateProperties23.IconLeftImage = null;
            StateProperties23.IconRightImage = null;
            _btnAddCompanyToDriver.onHoverState = StateProperties23;
            StateProperties24.BorderColor = Color.Teal;
            StateProperties24.BorderRadius = 3;
            StateProperties24.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties24.BorderThickness = 1;
            StateProperties24.FillColor = Color.Teal;
            StateProperties24.ForeColor = Color.White;
            StateProperties24.IconLeftImage = null;
            StateProperties24.IconRightImage = null;
            _btnAddCompanyToDriver.OnPressedState = StateProperties24;
            _btnAddCompanyToDriver.Size = new Size(260, 35);
            _btnAddCompanyToDriver.TabIndex = 232;
            _btnAddCompanyToDriver.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddCompanyToDriver.TextMarginLeft = 0;
            _btnAddCompanyToDriver.UseDefaultRadiusAndThickness = true;
            // 
            // btnAddDriver
            // 
            _btnAddDriver.AllowToggling = false;
            _btnAddDriver.Anchor = AnchorStyles.Right;
            _btnAddDriver.AnimationSpeed = 200;
            _btnAddDriver.AutoGenerateColors = false;
            _btnAddDriver.BackColor = Color.Transparent;
            _btnAddDriver.BackColor1 = Color.Teal;
            _btnAddDriver.BackgroundImage = (Image)resources.GetObject("btnAddDriver.BackgroundImage");
            _btnAddDriver.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddDriver.ButtonText = "Add";
            _btnAddDriver.ButtonTextMarginLeft = 0;
            _btnAddDriver.ColorContrastOnClick = 45;
            _btnAddDriver.ColorContrastOnHover = 45;
            _btnAddDriver.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _btnAddDriver.CustomizableEdges = BorderEdges3;
            _btnAddDriver.DialogResult = DialogResult.None;
            _btnAddDriver.DisabledBorderColor = Color.Empty;
            _btnAddDriver.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddDriver.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddDriver.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddDriver.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddDriver.ForeColor = Color.White;
            _btnAddDriver.IconLeftCursor = Cursors.Hand;
            _btnAddDriver.IconMarginLeft = 11;
            _btnAddDriver.IconPadding = 10;
            _btnAddDriver.IconRightCursor = Cursors.Hand;
            _btnAddDriver.IdleBorderColor = Color.Teal;
            _btnAddDriver.IdleBorderRadius = 3;
            _btnAddDriver.IdleBorderThickness = 1;
            _btnAddDriver.IdleFillColor = Color.Teal;
            _btnAddDriver.IdleIconLeftImage = null;
            _btnAddDriver.IdleIconRightImage = null;
            _btnAddDriver.IndicateFocus = true;
            _btnAddDriver.Location = new Point(380, 4);
            _btnAddDriver.Name = "_btnAddDriver";
            StateProperties25.BorderColor = Color.MediumTurquoise;
            StateProperties25.BorderRadius = 3;
            StateProperties25.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties25.BorderThickness = 1;
            StateProperties25.FillColor = Color.MediumTurquoise;
            StateProperties25.ForeColor = Color.White;
            StateProperties25.IconLeftImage = null;
            StateProperties25.IconRightImage = null;
            _btnAddDriver.onHoverState = StateProperties25;
            StateProperties26.BorderColor = Color.Teal;
            StateProperties26.BorderRadius = 3;
            StateProperties26.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties26.BorderThickness = 1;
            StateProperties26.FillColor = Color.Teal;
            StateProperties26.ForeColor = Color.White;
            StateProperties26.IconLeftImage = null;
            StateProperties26.IconRightImage = null;
            _btnAddDriver.OnPressedState = StateProperties26;
            _btnAddDriver.Size = new Size(121, 35);
            _btnAddDriver.TabIndex = 213;
            _btnAddDriver.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddDriver.TextMarginLeft = 0;
            _btnAddDriver.UseDefaultRadiusAndThickness = true;
            // 
            // btnSuspend
            // 
            _btnSuspend.AllowToggling = false;
            _btnSuspend.Anchor = AnchorStyles.Right;
            _btnSuspend.AnimationSpeed = 200;
            _btnSuspend.AutoGenerateColors = false;
            _btnSuspend.BackColor = Color.Transparent;
            _btnSuspend.BackColor1 = Color.IndianRed;
            _btnSuspend.BackgroundImage = (Image)resources.GetObject("btnSuspend.BackgroundImage");
            _btnSuspend.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnSuspend.ButtonText = "Suspend";
            _btnSuspend.ButtonTextMarginLeft = 0;
            _btnSuspend.ColorContrastOnClick = 45;
            _btnSuspend.ColorContrastOnHover = 45;
            _btnSuspend.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _btnSuspend.CustomizableEdges = BorderEdges4;
            _btnSuspend.DialogResult = DialogResult.None;
            _btnSuspend.DisabledBorderColor = Color.Empty;
            _btnSuspend.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSuspend.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSuspend.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSuspend.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSuspend.ForeColor = Color.White;
            _btnSuspend.IconLeftCursor = Cursors.Hand;
            _btnSuspend.IconMarginLeft = 11;
            _btnSuspend.IconPadding = 10;
            _btnSuspend.IconRightCursor = Cursors.Hand;
            _btnSuspend.IdleBorderColor = Color.IndianRed;
            _btnSuspend.IdleBorderRadius = 3;
            _btnSuspend.IdleBorderThickness = 1;
            _btnSuspend.IdleFillColor = Color.IndianRed;
            _btnSuspend.IdleIconLeftImage = null;
            _btnSuspend.IdleIconRightImage = null;
            _btnSuspend.IndicateFocus = true;
            _btnSuspend.Location = new Point(122, 4);
            _btnSuspend.Name = "_btnSuspend";
            StateProperties27.BorderColor = Color.Salmon;
            StateProperties27.BorderRadius = 3;
            StateProperties27.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties27.BorderThickness = 1;
            StateProperties27.FillColor = Color.Salmon;
            StateProperties27.ForeColor = Color.White;
            StateProperties27.IconLeftImage = null;
            StateProperties27.IconRightImage = null;
            _btnSuspend.onHoverState = StateProperties27;
            StateProperties28.BorderColor = Color.IndianRed;
            StateProperties28.BorderRadius = 3;
            StateProperties28.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties28.BorderThickness = 1;
            StateProperties28.FillColor = Color.IndianRed;
            StateProperties28.ForeColor = Color.White;
            StateProperties28.IconLeftImage = null;
            StateProperties28.IconRightImage = null;
            _btnSuspend.OnPressedState = StateProperties28;
            _btnSuspend.Size = new Size(109, 35);
            _btnSuspend.TabIndex = 231;
            _btnSuspend.TextAlign = ContentAlignment.MiddleCenter;
            _btnSuspend.TextMarginLeft = 0;
            _btnSuspend.UseDefaultRadiusAndThickness = true;
            _btnSuspend.Visible = false;
            // 
            // BunifuLabel7
            // 
            BunifuLabel7.Anchor = AnchorStyles.None;
            BunifuLabel7.AutoEllipsis = false;
            BunifuLabel7.CursorType = null;
            BunifuLabel7.Font = new Font("Microsoft Sans Serif", 14.0f);
            BunifuLabel7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuLabel7.Location = new Point(111, 25);
            BunifuLabel7.Name = "BunifuLabel7";
            BunifuLabel7.RightToLeft = RightToLeft.No;
            BunifuLabel7.Size = new Size(230, 26);
            BunifuLabel7.TabIndex = 232;
            BunifuLabel7.Text = "Truck Drivers Management";
            BunifuLabel7.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmTruckDriverList
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1500, 840);
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTruckDriverList";
            Text = "frmTruckDriverList";
            BunifuShadowPanel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            TableLayoutPanel2.ResumeLayout(false);
            activePanelPanel.ResumeLayout(false);
            activePanelPanel.PerformLayout();
            Panel7.ResumeLayout(false);
            Panel7.PerformLayout();
            TableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvTruckDrivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)TruckDriverListBindingSource).EndInit();
            TableLayoutPanel1.ResumeLayout(false);
            Load += new EventHandler(frmTruckDriverList_Load);
            ResumeLayout(false);
        }

        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel2;
        internal Panel Panel5;
        internal Panel Panel3;
        internal TableLayoutPanel TableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddCompanyToDriver;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddCompanyToDriver
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddCompanyToDriver;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddCompanyToDriver != null)
                {
                    _btnAddCompanyToDriver.Click -= btnAddCompanyToDriver_Click;
                }

                _btnAddCompanyToDriver = value;
                if (_btnAddCompanyToDriver != null)
                {
                    _btnAddCompanyToDriver.Click += btnAddCompanyToDriver_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddDriver;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddDriver
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddDriver;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddDriver != null)
                {
                    _btnAddDriver.Click -= btnAddDriver_Click;
                }

                _btnAddDriver = value;
                if (_btnAddDriver != null)
                {
                    _btnAddDriver.Click += btnAddDriver_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnSuspend;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSuspend
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSuspend;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSuspend != null)
                {
                    _btnSuspend.Click -= btnSuspend_Click;
                }

                _btnSuspend = value;
                if (_btnSuspend != null)
                {
                    _btnSuspend.Click += btnSuspend_Click;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel3;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel7;
        internal BindingSource TruckDriverListBindingSource;
        private BunifuTextBox _txtTruckNumber;

        internal BunifuTextBox txtTruckNumber
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTruckNumber;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTruckNumber != null)
                {
                    _txtTruckNumber.TextChange -= txtTruckNumber_TextChange;
                }

                _txtTruckNumber = value;
                if (_txtTruckNumber != null)
                {
                    _txtTruckNumber.TextChange += txtTruckNumber_TextChange;
                }
            }
        }

        private BunifuTextBox _txtTruckCompany;

        internal BunifuTextBox txtTruckCompany
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtTruckCompany;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtTruckCompany != null)
                {
                    _txtTruckCompany.TextChange -= txtTruckCompany_TextChange;
                }

                _txtTruckCompany = value;
                if (_txtTruckCompany != null)
                {
                    _txtTruckCompany.TextChange += txtTruckCompany_TextChange;
                }
            }
        }

        private BunifuTextBox _txtLastName;

        internal BunifuTextBox txtLastName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLastName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLastName != null)
                {
                    _txtLastName.TextChange -= txtLastName_TextChange;
                }

                _txtLastName = value;
                if (_txtLastName != null)
                {
                    _txtLastName.TextChange += txtLastName_TextChange;
                }
            }
        }

        private BunifuTextBox _txtFirstName;

        internal BunifuTextBox txtFirstName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtFirstName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtFirstName != null)
                {
                    _txtFirstName.TextChange -= txtFirstName_TextChange;
                }

                _txtFirstName = value;
                if (_txtFirstName != null)
                {
                    _txtFirstName.TextChange += txtFirstName_TextChange;
                }
            }
        }

        private BunifuTextBox _txtPassId;

        internal BunifuTextBox txtPassId
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtPassId;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtPassId != null)
                {
                    _txtPassId.TextChange -= txtPassId_TextChange;
                }

                _txtPassId = value;
                if (_txtPassId != null)
                {
                    _txtPassId.TextChange += txtPassId_TextChange;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDataGridView _dgvTruckDrivers;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvTruckDrivers
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvTruckDrivers;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvTruckDrivers != null)
                {
                    _dgvTruckDrivers.ColumnHeaderMouseClick -= dgvTruckDrivers_ColumnHeaderMouseClick;
                    _dgvTruckDrivers.CellContentClick -= dgvTruckDrivers_CellContentClick;
                    _dgvTruckDrivers.RowPostPaint -= dgvTruckDrivers_RowPostPaint;
                }

                _dgvTruckDrivers = value;
                if (_dgvTruckDrivers != null)
                {
                    _dgvTruckDrivers.ColumnHeaderMouseClick += dgvTruckDrivers_ColumnHeaderMouseClick;
                    _dgvTruckDrivers.CellContentClick += dgvTruckDrivers_CellContentClick;
                    _dgvTruckDrivers.RowPostPaint += dgvTruckDrivers_RowPostPaint;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel2;
        internal Panel activePanelPanel;
        internal Label Label1;
        internal Label Label3;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch _activeToggleSwitch;

        internal Bunifu.ToggleSwitch.BunifuToggleSwitch activeToggleSwitch
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _activeToggleSwitch;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_activeToggleSwitch != null)
                {
                    _activeToggleSwitch.Click -= activeToggleSwitch_Click;
                }

                _activeToggleSwitch = value;
                if (_activeToggleSwitch != null)
                {
                    _activeToggleSwitch.Click += activeToggleSwitch_Click;
                }
            }
        }

        internal Panel Panel7;
        internal Label Label5;
        internal Label lblQtySelected;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnUpdateDriver;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateDriver
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnUpdateDriver;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnUpdateDriver != null)
                {
                    _btnUpdateDriver.Click -= btnUpdateDriver_Click;
                }

                _btnUpdateDriver = value;
                if (_btnUpdateDriver != null)
                {
                    _btnUpdateDriver.Click += btnUpdateDriver_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn PortPassIDDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn check;
        internal DataGridViewTextBoxColumn TruckDriverIdDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn PortPassId;
        internal DataGridViewTextBoxColumn FirstNameDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn LastNameDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CompanyNameDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn TruckNumberDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn SuspendTruckDriverDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CompanyIdDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CompanyCodeDataGridViewTextBoxColumn1;
    }
}