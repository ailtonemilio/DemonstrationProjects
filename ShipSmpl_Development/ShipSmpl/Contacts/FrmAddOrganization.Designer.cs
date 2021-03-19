using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAddOrganization : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOrganization));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Label5 = new Label();
            TableLayoutPanel15 = new TableLayoutPanel();
            ediTextBox = new TextBox();
            cbRquiresedi = new CheckBox();
            _ediButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _ediButton.Click += new EventHandler(Button1_Click_1);
            ediPanel = new Panel();
            typeNewCompanyModePanel = new Panel();
            TableLayoutPanel11 = new TableLayoutPanel();
            _cblCompanyType = new CheckedListBox();
            _cblCompanyType.SelectedIndexChanged += new EventHandler(CheckedListBox1_SelectedIndexChanged);
            _cblCompanyType.ItemCheck += new ItemCheckEventHandler(typeCheckedListBox_ItemCheck);
            _cblCompanyType.ItemCheck += new ItemCheckEventHandler(cblCompanyType_CheckedChanged);
            typeNewCompanyModeLabel = new Label();
            titleLabel = new Label();
            Panel3 = new Panel();
            _btnAddCompany = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddCompany.Click += new EventHandler(btnAddCompany_Click);
            _Label8 = new Label();
            _Label8.Click += new EventHandler(Label8_Click);
            BunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            TableLayoutPanel12 = new TableLayoutPanel();
            Panel4 = new Panel();
            _dgvAddresses = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvAddresses.CellDoubleClick += new DataGridViewCellEventHandler(dgvAddresses_CellDoubleClick);
            Label15 = new Label();
            _PictureBox5 = new PictureBox();
            _PictureBox5.Click += new EventHandler(PictureBox5_Click);
            _PictureBox4 = new PictureBox();
            _PictureBox4.Click += new EventHandler(PictureBox4_Click);
            TableLayoutPanel6 = new TableLayoutPanel();
            TableLayoutPanel16 = new TableLayoutPanel();
            _PictureBox3 = new PictureBox();
            _PictureBox3.Click += new EventHandler(PictureBox3_Click);
            _PictureBox2 = new PictureBox();
            _PictureBox2.Click += new EventHandler(PictureBox2_Click);
            _PictureBox1 = new PictureBox();
            _PictureBox1.Click += new EventHandler(PictureBox1_Click);
            Label18 = new Label();
            Label13 = new Label();
            tbNotes = new RichTextBox();
            TableLayoutPanel1 = new TableLayoutPanel();
            _cboCompanyCategory = new ComboBox();
            _cboCompanyCategory.SelectedIndexChanged += new EventHandler(tbCompanyCategory_SelectedIndexChanged);
            Label20 = new Label();
            Label16 = new Label();
            tbAttention = new TextBox();
            tbWebsite = new TextBox();
            tbEmail = new TextBox();
            tbName = new TextBox();
            tbCode = new TextBox();
            availableCodePictureBox = new PictureBox();
            Label4 = new Label();
            Label12 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            warningLabel = new Label();
            Label17 = new Label();
            Label11 = new Label();
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(Button4_Click);
            _saveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _saveButton.Click += new EventHandler(saveButton_Click);
            pnlRAteTier = new Panel();
            cboRateTier = new ComboBox();
            Label3 = new Label();
            lblWarning = new Label();
            CompanyAddressBindingSource = new BindingSource(components);
            StreetAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AddressDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ZipCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            FaxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TableLayoutPanel15.SuspendLayout();
            ediPanel.SuspendLayout();
            typeNewCompanyModePanel.SuspendLayout();
            TableLayoutPanel11.SuspendLayout();
            Panel3.SuspendLayout();
            TableLayoutPanel12.SuspendLayout();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvAddresses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox4).BeginInit();
            TableLayoutPanel6.SuspendLayout();
            TableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox1).BeginInit();
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)availableCodePictureBox).BeginInit();
            pnlRAteTier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CompanyAddressBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label5.Location = new Point(49, 378);
            Label5.Name = "Label5";
            Label5.Size = new Size(1019, 20);
            Label5.TabIndex = 45;
            Label5.Text = "_________________________________________________________________________________" + "____________________";
            // 
            // TableLayoutPanel15
            // 
            TableLayoutPanel15.ColumnCount = 2;
            TableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.62245f));
            TableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.37755f));
            TableLayoutPanel15.Controls.Add(ediTextBox, 0, 1);
            TableLayoutPanel15.Controls.Add(cbRquiresedi, 0, 0);
            TableLayoutPanel15.Controls.Add(_ediButton, 1, 1);
            TableLayoutPanel15.Dock = DockStyle.Fill;
            TableLayoutPanel15.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel15.Location = new Point(0, 0);
            TableLayoutPanel15.Name = "TableLayoutPanel15";
            TableLayoutPanel15.RowCount = 2;
            TableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 48.64865f));
            TableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 28.0f));
            TableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 31.0f));
            TableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 31.0f));
            TableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 31.0f));
            TableLayoutPanel15.Size = new Size(294, 61);
            TableLayoutPanel15.TabIndex = 31;
            // 
            // ediTextBox
            // 
            ediTextBox.BorderStyle = BorderStyle.None;
            ediTextBox.CharacterCasing = CharacterCasing.Upper;
            ediTextBox.Dock = DockStyle.Fill;
            ediTextBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ediTextBox.Location = new Point(3, 36);
            ediTextBox.Multiline = true;
            ediTextBox.Name = "ediTextBox";
            ediTextBox.ReadOnly = true;
            ediTextBox.Size = new Size(195, 22);
            ediTextBox.TabIndex = 74;
            ediTextBox.Text = "N/A";
            ediTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // cbRquiresedi
            // 
            cbRquiresedi.AutoSize = true;
            cbRquiresedi.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cbRquiresedi.Location = new Point(2, 2);
            cbRquiresedi.Margin = new Padding(2);
            cbRquiresedi.Name = "cbRquiresedi";
            cbRquiresedi.Size = new Size(135, 26);
            cbRquiresedi.TabIndex = 74;
            cbRquiresedi.Text = "Requires EDI";
            cbRquiresedi.TextAlign = ContentAlignment.MiddleRight;
            cbRquiresedi.UseVisualStyleBackColor = true;
            // 
            // ediButton
            // 
            _ediButton.AllowToggling = false;
            _ediButton.AnimationSpeed = 200;
            _ediButton.AutoGenerateColors = false;
            _ediButton.BackColor = Color.Transparent;
            _ediButton.BackColor1 = Color.Teal;
            _ediButton.BackgroundImage = (Image)resources.GetObject("ediButton.BackgroundImage");
            _ediButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _ediButton.ButtonText = "Save";
            _ediButton.ButtonTextMarginLeft = 0;
            _ediButton.ColorContrastOnClick = 45;
            _ediButton.ColorContrastOnHover = 45;
            _ediButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _ediButton.CustomizableEdges = BorderEdges1;
            _ediButton.DialogResult = DialogResult.None;
            _ediButton.DisabledBorderColor = Color.Empty;
            _ediButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _ediButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _ediButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _ediButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _ediButton.ForeColor = Color.White;
            _ediButton.IconLeftCursor = Cursors.Hand;
            _ediButton.IconMarginLeft = 11;
            _ediButton.IconPadding = 10;
            _ediButton.IconRightCursor = Cursors.Hand;
            _ediButton.IdleBorderColor = Color.Teal;
            _ediButton.IdleBorderRadius = 3;
            _ediButton.IdleBorderThickness = 1;
            _ediButton.IdleFillColor = Color.Teal;
            _ediButton.IdleIconLeftImage = null;
            _ediButton.IdleIconRightImage = null;
            _ediButton.IndicateFocus = true;
            _ediButton.Location = new Point(204, 36);
            _ediButton.Name = "_ediButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _ediButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _ediButton.OnPressedState = StateProperties2;
            _ediButton.Size = new Size(84, 22);
            _ediButton.TabIndex = 72;
            _ediButton.TextAlign = ContentAlignment.MiddleCenter;
            _ediButton.TextMarginLeft = 0;
            _ediButton.UseDefaultRadiusAndThickness = true;
            // 
            // ediPanel
            // 
            ediPanel.BorderStyle = BorderStyle.FixedSingle;
            ediPanel.Controls.Add(TableLayoutPanel15);
            ediPanel.Location = new Point(796, 292);
            ediPanel.Name = "ediPanel";
            ediPanel.Size = new Size(296, 63);
            ediPanel.TabIndex = 53;
            ediPanel.Visible = false;
            // 
            // typeNewCompanyModePanel
            // 
            typeNewCompanyModePanel.BorderStyle = BorderStyle.FixedSingle;
            typeNewCompanyModePanel.Controls.Add(TableLayoutPanel11);
            typeNewCompanyModePanel.Location = new Point(708, 166);
            typeNewCompanyModePanel.Name = "typeNewCompanyModePanel";
            typeNewCompanyModePanel.Size = new Size(494, 122);
            typeNewCompanyModePanel.TabIndex = 51;
            // 
            // TableLayoutPanel11
            // 
            TableLayoutPanel11.ColumnCount = 2;
            TableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.10526f));
            TableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.89474f));
            TableLayoutPanel11.Controls.Add(_cblCompanyType, 1, 0);
            TableLayoutPanel11.Controls.Add(typeNewCompanyModeLabel, 0, 0);
            TableLayoutPanel11.Dock = DockStyle.Fill;
            TableLayoutPanel11.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel11.Location = new Point(0, 0);
            TableLayoutPanel11.Name = "TableLayoutPanel11";
            TableLayoutPanel11.RowCount = 1;
            TableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 48.64865f));
            TableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 120.0f));
            TableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 120.0f));
            TableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 120.0f));
            TableLayoutPanel11.Size = new Size(492, 120);
            TableLayoutPanel11.TabIndex = 31;
            // 
            // cblCompanyType
            // 
            _cblCompanyType.BorderStyle = BorderStyle.None;
            _cblCompanyType.CheckOnClick = true;
            _cblCompanyType.ColumnWidth = 180;
            _cblCompanyType.Dock = DockStyle.Fill;
            _cblCompanyType.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cblCompanyType.FormattingEnabled = true;
            _cblCompanyType.Location = new Point(87, 3);
            _cblCompanyType.MultiColumn = true;
            _cblCompanyType.Name = "_cblCompanyType";
            _cblCompanyType.RightToLeft = RightToLeft.No;
            _cblCompanyType.Size = new Size(402, 114);
            _cblCompanyType.TabIndex = 0;
            _cblCompanyType.ThreeDCheckBoxes = true;
            // 
            // typeNewCompanyModeLabel
            // 
            typeNewCompanyModeLabel.AutoSize = true;
            typeNewCompanyModeLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            typeNewCompanyModeLabel.Location = new Point(3, 0);
            typeNewCompanyModeLabel.Name = "typeNewCompanyModeLabel";
            typeNewCompanyModeLabel.Padding = new Padding(0, 3, 0, 0);
            typeNewCompanyModeLabel.Size = new Size(47, 23);
            typeNewCompanyModeLabel.TabIndex = 0;
            typeNewCompanyModeLabel.Text = "Type:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            titleLabel.Location = new Point(55, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(213, 30);
            titleLabel.TabIndex = 48;
            titleLabel.Text = "Add New Company";
            // 
            // Panel3
            // 
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(_btnAddCompany);
            Panel3.Controls.Add(_Label8);
            Panel3.Controls.Add(BunifuButton1);
            Panel3.Controls.Add(TableLayoutPanel12);
            Panel3.Location = new Point(46, 404);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(710, 164);
            Panel3.TabIndex = 54;
            // 
            // btnAddCompany
            // 
            _btnAddCompany.AllowToggling = false;
            _btnAddCompany.AnimationSpeed = 200;
            _btnAddCompany.AutoGenerateColors = false;
            _btnAddCompany.BackColor = Color.Transparent;
            _btnAddCompany.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddCompany.BackgroundImage = (Image)resources.GetObject("btnAddCompany.BackgroundImage");
            _btnAddCompany.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddCompany.ButtonText = "−";
            _btnAddCompany.ButtonTextMarginLeft = 0;
            _btnAddCompany.ColorContrastOnClick = 45;
            _btnAddCompany.ColorContrastOnHover = 45;
            _btnAddCompany.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnAddCompany.CustomizableEdges = BorderEdges2;
            _btnAddCompany.DialogResult = DialogResult.None;
            _btnAddCompany.DisabledBorderColor = Color.Empty;
            _btnAddCompany.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddCompany.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddCompany.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddCompany.Font = new Font("Segoe UI Semibold", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddCompany.ForeColor = Color.White;
            _btnAddCompany.IconLeftCursor = Cursors.Hand;
            _btnAddCompany.IconMarginLeft = 5;
            _btnAddCompany.IconPadding = 5;
            _btnAddCompany.IconRightCursor = Cursors.Hand;
            _btnAddCompany.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddCompany.IdleBorderRadius = 15;
            _btnAddCompany.IdleBorderThickness = 1;
            _btnAddCompany.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddCompany.IdleIconLeftImage = My.Resources.Resources.addWhite;
            _btnAddCompany.IdleIconRightImage = null;
            _btnAddCompany.IndicateFocus = true;
            _btnAddCompany.Location = new Point(684, 3);
            _btnAddCompany.Name = "_btnAddCompany";
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties3.BorderRadius = 15;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _btnAddCompany.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties4.BorderRadius = 15;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _btnAddCompany.OnPressedState = StateProperties4;
            _btnAddCompany.Size = new Size(22, 22);
            _btnAddCompany.TabIndex = 79;
            _btnAddCompany.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddCompany.TextMarginLeft = 0;
            _btnAddCompany.UseDefaultRadiusAndThickness = true;
            // 
            // Label8
            // 
            _Label8.Anchor = AnchorStyles.Right;
            _Label8.AutoSize = true;
            _Label8.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label8.Location = new Point(90, 143);
            _Label8.Name = "_Label8";
            _Label8.Size = new Size(134, 17);
            _Label8.TabIndex = 78;
            _Label8.Text = "* double click to edit";
            _Label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BunifuButton1
            // 
            BunifuButton1.AllowToggling = false;
            BunifuButton1.AnimationSpeed = 200;
            BunifuButton1.AutoGenerateColors = false;
            BunifuButton1.BackColor = Color.Transparent;
            BunifuButton1.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuButton1.BackgroundImage = (Image)resources.GetObject("BunifuButton1.BackgroundImage");
            BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            BunifuButton1.ButtonText = "−";
            BunifuButton1.ButtonTextMarginLeft = 0;
            BunifuButton1.ColorContrastOnClick = 45;
            BunifuButton1.ColorContrastOnHover = 45;
            BunifuButton1.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            BunifuButton1.CustomizableEdges = BorderEdges3;
            BunifuButton1.DialogResult = DialogResult.None;
            BunifuButton1.DisabledBorderColor = Color.Empty;
            BunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            BunifuButton1.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            BunifuButton1.Font = new Font("Segoe UI Semibold", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuButton1.ForeColor = Color.White;
            BunifuButton1.IconLeftCursor = Cursors.Hand;
            BunifuButton1.IconMarginLeft = 5;
            BunifuButton1.IconPadding = 5;
            BunifuButton1.IconRightCursor = Cursors.Hand;
            BunifuButton1.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuButton1.IdleBorderRadius = 15;
            BunifuButton1.IdleBorderThickness = 1;
            BunifuButton1.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuButton1.IdleIconLeftImage = My.Resources.Resources.removeWhite;
            BunifuButton1.IdleIconRightImage = null;
            BunifuButton1.IndicateFocus = true;
            BunifuButton1.Location = new Point(686, 119);
            BunifuButton1.Name = "BunifuButton1";
            StateProperties5.BorderColor = Color.Red;
            StateProperties5.BorderRadius = 15;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.Red;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            BunifuButton1.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties6.BorderRadius = 15;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            BunifuButton1.OnPressedState = StateProperties6;
            BunifuButton1.Size = new Size(20, 20);
            BunifuButton1.TabIndex = 77;
            BunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            BunifuButton1.TextMarginLeft = 0;
            BunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // TableLayoutPanel12
            // 
            TableLayoutPanel12.ColumnCount = 2;
            TableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.16617f));
            TableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.83382f));
            TableLayoutPanel12.Controls.Add(Panel4, 0, 0);
            TableLayoutPanel12.Controls.Add(Label15, 0, 0);
            TableLayoutPanel12.Location = new Point(8, 3);
            TableLayoutPanel12.Name = "TableLayoutPanel12";
            TableLayoutPanel12.RowCount = 1;
            TableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 68.11594f));
            TableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 140.0f));
            TableLayoutPanel12.Size = new Size(674, 140);
            TableLayoutPanel12.TabIndex = 26;
            // 
            // Panel4
            // 
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(_dgvAddresses);
            Panel4.Location = new Point(84, 3);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(587, 134);
            Panel4.TabIndex = 77;
            // 
            // dgvAddresses
            // 
            _dgvAddresses.AllowCustomTheming = true;
            _dgvAddresses.AllowUserToAddRows = false;
            _dgvAddresses.AllowUserToDeleteRows = false;
            _dgvAddresses.AllowUserToOrderColumns = true;
            _dgvAddresses.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = SystemColors.Control;
            DataGridViewCellStyle1.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvAddresses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvAddresses.AutoGenerateColumns = false;
            _dgvAddresses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvAddresses.BackgroundColor = Color.White;
            _dgvAddresses.BorderStyle = BorderStyle.None;
            _dgvAddresses.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            _dgvAddresses.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            _dgvAddresses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvAddresses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvAddresses.ColumnHeadersHeight = 35;
            _dgvAddresses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            _dgvAddresses.Columns.AddRange(new DataGridViewColumn[] { StreetAddressDataGridViewTextBoxColumn, AddressDescriptionDataGridViewTextBoxColumn, ZipCodeDataGridViewTextBoxColumn, PhoneDataGridViewTextBoxColumn, FaxDataGridViewTextBoxColumn });
            _dgvAddresses.CurrentTheme.AlternatingRowsStyle.BackColor = SystemColors.Control;
            _dgvAddresses.CurrentTheme.AlternatingRowsStyle.Font = new Font("Arial", 9.5f);
            _dgvAddresses.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvAddresses.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvAddresses.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvAddresses.CurrentTheme.BackColor = Color.White;
            _dgvAddresses.CurrentTheme.GridColor = Color.Gainsboro;
            _dgvAddresses.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvAddresses.CurrentTheme.HeaderStyle.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            _dgvAddresses.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvAddresses.CurrentTheme.Name = null;
            _dgvAddresses.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgvAddresses.CurrentTheme.RowsStyle.Font = new Font("Arial", 9.5f);
            _dgvAddresses.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvAddresses.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvAddresses.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvAddresses.DataSource = CompanyAddressBindingSource;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.White;
            DataGridViewCellStyle3.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvAddresses.DefaultCellStyle = DataGridViewCellStyle3;
            _dgvAddresses.Dock = DockStyle.Fill;
            _dgvAddresses.EnableHeadersVisualStyles = false;
            _dgvAddresses.GridColor = Color.Gainsboro;
            _dgvAddresses.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvAddresses.HeaderBgColor = Color.Empty;
            _dgvAddresses.HeaderForeColor = Color.White;
            _dgvAddresses.Location = new Point(0, 0);
            _dgvAddresses.Name = "_dgvAddresses";
            _dgvAddresses.ReadOnly = true;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            _dgvAddresses.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
            _dgvAddresses.RowHeadersVisible = false;
            _dgvAddresses.RowHeadersWidth = 29;
            DataGridViewCellStyle5.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvAddresses.RowsDefaultCellStyle = DataGridViewCellStyle5;
            _dgvAddresses.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.0f);
            _dgvAddresses.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            _dgvAddresses.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvAddresses.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            _dgvAddresses.RowTemplate.Height = 27;
            _dgvAddresses.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _dgvAddresses.Size = new Size(585, 132);
            _dgvAddresses.TabIndex = 141;
            _dgvAddresses.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.Location = new Point(3, 0);
            Label15.Name = "Label15";
            Label15.Size = new Size(72, 20);
            Label15.TabIndex = 0;
            Label15.Text = "Address:";
            Label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PictureBox5
            // 
            _PictureBox5.BackgroundImage = (Image)resources.GetObject("PictureBox5.BackgroundImage");
            _PictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            _PictureBox5.Dock = DockStyle.Fill;
            _PictureBox5.Location = new Point(151, 3);
            _PictureBox5.Name = "_PictureBox5";
            _PictureBox5.Size = new Size(31, 29);
            _PictureBox5.TabIndex = 4;
            _PictureBox5.TabStop = false;
            // 
            // PictureBox4
            // 
            _PictureBox4.BackgroundImage = (Image)resources.GetObject("PictureBox4.BackgroundImage");
            _PictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            _PictureBox4.Dock = DockStyle.Fill;
            _PictureBox4.Location = new Point(114, 3);
            _PictureBox4.Name = "_PictureBox4";
            _PictureBox4.Size = new Size(31, 29);
            _PictureBox4.TabIndex = 3;
            _PictureBox4.TabStop = false;
            // 
            // TableLayoutPanel6
            // 
            TableLayoutPanel6.Anchor = AnchorStyles.Right;
            TableLayoutPanel6.ColumnCount = 2;
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.76923f));
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.23077f));
            TableLayoutPanel6.Controls.Add(TableLayoutPanel16, 1, 0);
            TableLayoutPanel6.Controls.Add(Label18, 0, 0);
            TableLayoutPanel6.Location = new Point(712, 91);
            TableLayoutPanel6.Name = "TableLayoutPanel6";
            TableLayoutPanel6.RowCount = 1;
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 37.0f));
            TableLayoutPanel6.Size = new Size(325, 37);
            TableLayoutPanel6.TabIndex = 52;
            // 
            // TableLayoutPanel16
            // 
            TableLayoutPanel16.ColumnCount = 5;
            TableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel16.Controls.Add(_PictureBox5, 4, 0);
            TableLayoutPanel16.Controls.Add(_PictureBox4, 3, 0);
            TableLayoutPanel16.Controls.Add(_PictureBox3, 2, 0);
            TableLayoutPanel16.Controls.Add(_PictureBox2, 1, 0);
            TableLayoutPanel16.Controls.Add(_PictureBox1, 0, 0);
            TableLayoutPanel16.Dock = DockStyle.Fill;
            TableLayoutPanel16.Location = new Point(139, 1);
            TableLayoutPanel16.Margin = new Padding(1);
            TableLayoutPanel16.Name = "TableLayoutPanel16";
            TableLayoutPanel16.RowCount = 1;
            TableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel16.Size = new Size(185, 35);
            TableLayoutPanel16.TabIndex = 36;
            // 
            // PictureBox3
            // 
            _PictureBox3.BackgroundImage = (Image)resources.GetObject("PictureBox3.BackgroundImage");
            _PictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            _PictureBox3.Dock = DockStyle.Fill;
            _PictureBox3.Location = new Point(77, 3);
            _PictureBox3.Name = "_PictureBox3";
            _PictureBox3.Size = new Size(31, 29);
            _PictureBox3.TabIndex = 2;
            _PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            _PictureBox2.BackgroundImage = (Image)resources.GetObject("PictureBox2.BackgroundImage");
            _PictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            _PictureBox2.Dock = DockStyle.Fill;
            _PictureBox2.Location = new Point(40, 3);
            _PictureBox2.Name = "_PictureBox2";
            _PictureBox2.Size = new Size(31, 29);
            _PictureBox2.TabIndex = 1;
            _PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            _PictureBox1.BackgroundImage = My.Resources.Resources.starOn;
            _PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            _PictureBox1.Dock = DockStyle.Fill;
            _PictureBox1.Location = new Point(3, 3);
            _PictureBox1.Name = "_PictureBox1";
            _PictureBox1.Size = new Size(31, 29);
            _PictureBox1.TabIndex = 0;
            _PictureBox1.TabStop = false;
            // 
            // Label18
            // 
            Label18.Anchor = AnchorStyles.Right;
            Label18.AutoSize = true;
            Label18.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.Location = new Point(4, 8);
            Label18.Name = "Label18";
            Label18.Size = new Size(131, 20);
            Label18.TabIndex = 0;
            Label18.Text = "Company Rating:";
            Label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.Location = new Point(51, 596);
            Label13.Name = "Label13";
            Label13.Size = new Size(55, 20);
            Label13.TabIndex = 47;
            Label13.Text = "Notes:";
            // 
            // tbNotes
            // 
            tbNotes.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            tbNotes.Location = new Point(132, 596);
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(917, 88);
            tbNotes.TabIndex = 42;
            tbNotes.Text = "";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 3;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.05755f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.94245f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 77.0f));
            TableLayoutPanel1.Controls.Add(_cboCompanyCategory, 1, 0);
            TableLayoutPanel1.Controls.Add(Label20, 0, 5);
            TableLayoutPanel1.Controls.Add(Label16, 0, 0);
            TableLayoutPanel1.Controls.Add(tbAttention, 1, 5);
            TableLayoutPanel1.Controls.Add(tbWebsite, 1, 4);
            TableLayoutPanel1.Controls.Add(tbEmail, 1, 3);
            TableLayoutPanel1.Controls.Add(tbName, 1, 2);
            TableLayoutPanel1.Controls.Add(tbCode, 1, 1);
            TableLayoutPanel1.Controls.Add(availableCodePictureBox, 2, 1);
            TableLayoutPanel1.Controls.Add(Label4, 0, 4);
            TableLayoutPanel1.Controls.Add(Label12, 0, 3);
            TableLayoutPanel1.Controls.Add(Label2, 0, 2);
            TableLayoutPanel1.Controls.Add(Label1, 0, 1);
            TableLayoutPanel1.Location = new Point(46, 91);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 6;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel1.Size = new Size(627, 210);
            TableLayoutPanel1.TabIndex = 44;
            // 
            // cboCompanyCategory
            // 
            _cboCompanyCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboCompanyCategory.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboCompanyCategory.FormattingEnabled = true;
            _cboCompanyCategory.Items.AddRange(new object[] { "CUSTOMER", "VENDOR", "CUSTOMER | VENDOR" });
            _cboCompanyCategory.Location = new Point(157, 3);
            _cboCompanyCategory.Name = "_cboCompanyCategory";
            _cboCompanyCategory.Size = new Size(189, 28);
            _cboCompanyCategory.TabIndex = 3;
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label20.Location = new Point(3, 170);
            Label20.Name = "Label20";
            Label20.Size = new Size(100, 20);
            Label20.TabIndex = 42;
            Label20.Text = "Attention To:";
            Label20.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label16
            // 
            Label16.Anchor = AnchorStyles.Left;
            Label16.AutoSize = true;
            Label16.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.Location = new Point(3, 5);
            Label16.Name = "Label16";
            Label16.Padding = new Padding(0, 3, 0, 0);
            Label16.Size = new Size(148, 23);
            Label16.TabIndex = 1;
            Label16.Text = "Company Category:";
            // 
            // tbAttention
            // 
            tbAttention.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            tbAttention.Location = new Point(157, 173);
            tbAttention.Name = "tbAttention";
            tbAttention.Size = new Size(387, 26);
            tbAttention.TabIndex = 41;
            // 
            // tbWebsite
            // 
            tbWebsite.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            tbWebsite.Location = new Point(157, 139);
            tbWebsite.Name = "tbWebsite";
            tbWebsite.Size = new Size(387, 26);
            tbWebsite.TabIndex = 4;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            tbEmail.Location = new Point(157, 105);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(387, 26);
            tbEmail.TabIndex = 3;
            // 
            // tbName
            // 
            tbName.CharacterCasing = CharacterCasing.Upper;
            tbName.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            tbName.Location = new Point(157, 71);
            tbName.Name = "tbName";
            tbName.Size = new Size(387, 26);
            tbName.TabIndex = 2;
            // 
            // tbCode
            // 
            tbCode.CharacterCasing = CharacterCasing.Upper;
            tbCode.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            tbCode.Location = new Point(157, 37);
            tbCode.Name = "tbCode";
            tbCode.Size = new Size(387, 26);
            tbCode.TabIndex = 1;
            // 
            // availableCodePictureBox
            // 
            availableCodePictureBox.Location = new Point(552, 37);
            availableCodePictureBox.Name = "availableCodePictureBox";
            availableCodePictureBox.Size = new Size(32, 28);
            availableCodePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            availableCodePictureBox.TabIndex = 39;
            availableCodePictureBox.TabStop = false;
            availableCodePictureBox.Visible = false;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(3, 136);
            Label4.Name = "Label4";
            Label4.Size = new Size(71, 20);
            Label4.TabIndex = 3;
            Label4.Text = "Website:";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.Location = new Point(3, 102);
            Label12.Name = "Label12";
            Label12.Size = new Size(52, 20);
            Label12.TabIndex = 8;
            Label12.Text = "Email:";
            Label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(3, 68);
            Label2.Name = "Label2";
            Label2.Size = new Size(55, 20);
            Label2.TabIndex = 1;
            Label2.Text = "Name:";
            Label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(3, 34);
            Label1.Name = "Label1";
            Label1.Size = new Size(51, 20);
            Label1.TabIndex = 0;
            Label1.Text = "Code:";
            Label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // warningLabel
            // 
            warningLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            warningLabel.ForeColor = Color.Firebrick;
            warningLabel.Location = new Point(200, 686);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(631, 23);
            warningLabel.TabIndex = 55;
            warningLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.BackColor = Color.Transparent;
            Label17.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label17.Location = new Point(50, 54);
            Label17.Name = "Label17";
            Label17.Size = new Size(1019, 20);
            Label17.TabIndex = 49;
            Label17.Text = "_________________________________________________________________________________" + "____________________";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label11.Location = new Point(42, 566);
            Label11.Name = "Label11";
            Label11.Size = new Size(1019, 20);
            Label11.TabIndex = 46;
            Label11.Text = "_________________________________________________________________________________" + "____________________";
            // 
            // cancelButton
            // 
            _cancelButton.AccessibleRole = AccessibleRole.Clock;
            _cancelButton.AllowToggling = false;
            _cancelButton.AnimationSpeed = 200;
            _cancelButton.AutoGenerateColors = false;
            _cancelButton.BackColor = Color.Transparent;
            _cancelButton.BackColor1 = Color.DarkGray;
            _cancelButton.BackgroundImage = (Image)resources.GetObject("cancelButton.BackgroundImage");
            _cancelButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _cancelButton.ButtonText = "Cancel";
            _cancelButton.ButtonTextMarginLeft = 0;
            _cancelButton.ColorContrastOnClick = 45;
            _cancelButton.ColorContrastOnHover = 45;
            _cancelButton.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _cancelButton.CustomizableEdges = BorderEdges4;
            _cancelButton.DialogResult = DialogResult.None;
            _cancelButton.DisabledBorderColor = Color.Empty;
            _cancelButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _cancelButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _cancelButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _cancelButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _cancelButton.ForeColor = Color.White;
            _cancelButton.IconLeftCursor = Cursors.Hand;
            _cancelButton.IconMarginLeft = 11;
            _cancelButton.IconPadding = 10;
            _cancelButton.IconRightCursor = Cursors.Hand;
            _cancelButton.IdleBorderColor = Color.DarkGray;
            _cancelButton.IdleBorderRadius = 3;
            _cancelButton.IdleBorderThickness = 1;
            _cancelButton.IdleFillColor = Color.DarkGray;
            _cancelButton.IdleIconLeftImage = null;
            _cancelButton.IdleIconRightImage = null;
            _cancelButton.IndicateFocus = true;
            _cancelButton.Location = new Point(1038, 710);
            _cancelButton.Name = "_cancelButton";
            StateProperties7.BorderColor = Color.Silver;
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.Silver;
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.DarkGray;
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.DarkGray;
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties8;
            _cancelButton.Size = new Size(122, 45);
            _cancelButton.TabIndex = 71;
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
            BorderEdges5.BottomLeft = true;
            BorderEdges5.BottomRight = true;
            BorderEdges5.TopLeft = true;
            BorderEdges5.TopRight = true;
            _saveButton.CustomizableEdges = BorderEdges5;
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
            _saveButton.Location = new Point(883, 710);
            _saveButton.Name = "_saveButton";
            StateProperties9.BorderColor = Color.MediumTurquoise;
            StateProperties9.BorderRadius = 3;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.MediumTurquoise;
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            _saveButton.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.Teal;
            StateProperties10.BorderRadius = 3;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.Teal;
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            _saveButton.OnPressedState = StateProperties10;
            _saveButton.Size = new Size(122, 45);
            _saveButton.TabIndex = 70;
            _saveButton.TextAlign = ContentAlignment.MiddleCenter;
            _saveButton.TextMarginLeft = 0;
            _saveButton.UseDefaultRadiusAndThickness = true;
            // 
            // pnlRAteTier
            // 
            pnlRAteTier.BorderStyle = BorderStyle.FixedSingle;
            pnlRAteTier.Controls.Add(cboRateTier);
            pnlRAteTier.Controls.Add(Label3);
            pnlRAteTier.Location = new Point(708, 132);
            pnlRAteTier.Name = "pnlRAteTier";
            pnlRAteTier.Size = new Size(385, 33);
            pnlRAteTier.TabIndex = 72;
            pnlRAteTier.Visible = false;
            // 
            // cboRateTier
            // 
            cboRateTier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRateTier.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboRateTier.FormattingEnabled = true;
            cboRateTier.Location = new Point(183, 2);
            cboRateTier.Name = "cboRateTier";
            cboRateTier.Size = new Size(183, 28);
            cboRateTier.TabIndex = 2;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Left;
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(7, 4);
            Label3.Name = "Label3";
            Label3.Padding = new Padding(0, 3, 0, 0);
            Label3.Size = new Size(151, 23);
            Label3.TabIndex = 1;
            Label3.Text = "Customer Rate Tier:";
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWarning.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblWarning.Location = new Point(729, 30);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 20);
            lblWarning.TabIndex = 73;
            lblWarning.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CompanyAddressBindingSource
            // 
            CompanyAddressBindingSource.DataSource = typeof(ModelLayer.CompanyAddress);
            // 
            // StreetAddressDataGridViewTextBoxColumn
            // 
            StreetAddressDataGridViewTextBoxColumn.DataPropertyName = "StreetAddress";
            StreetAddressDataGridViewTextBoxColumn.HeaderText = "StreetAddress";
            StreetAddressDataGridViewTextBoxColumn.Name = "StreetAddressDataGridViewTextBoxColumn";
            StreetAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AddressDescriptionDataGridViewTextBoxColumn
            // 
            AddressDescriptionDataGridViewTextBoxColumn.DataPropertyName = "AddressDescription";
            AddressDescriptionDataGridViewTextBoxColumn.HeaderText = "AddressDescription";
            AddressDescriptionDataGridViewTextBoxColumn.Name = "AddressDescriptionDataGridViewTextBoxColumn";
            AddressDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ZipCodeDataGridViewTextBoxColumn
            // 
            ZipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            ZipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            ZipCodeDataGridViewTextBoxColumn.Name = "ZipCodeDataGridViewTextBoxColumn";
            ZipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PhoneDataGridViewTextBoxColumn
            // 
            PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            PhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn";
            PhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FaxDataGridViewTextBoxColumn
            // 
            FaxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            FaxDataGridViewTextBoxColumn.HeaderText = "Fax";
            FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn";
            FaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmAddOrganization
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1230, 791);
            ControlBox = false;
            Controls.Add(lblWarning);
            Controls.Add(pnlRAteTier);
            Controls.Add(_cancelButton);
            Controls.Add(_saveButton);
            Controls.Add(ediPanel);
            Controls.Add(typeNewCompanyModePanel);
            Controls.Add(titleLabel);
            Controls.Add(Panel3);
            Controls.Add(TableLayoutPanel6);
            Controls.Add(Label13);
            Controls.Add(tbNotes);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(warningLabel);
            Controls.Add(Label17);
            Controls.Add(Label11);
            Controls.Add(Label5);
            Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmAddOrganization";
            StartPosition = FormStartPosition.CenterScreen;
            TableLayoutPanel15.ResumeLayout(false);
            TableLayoutPanel15.PerformLayout();
            ediPanel.ResumeLayout(false);
            typeNewCompanyModePanel.ResumeLayout(false);
            TableLayoutPanel11.ResumeLayout(false);
            TableLayoutPanel11.PerformLayout();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            TableLayoutPanel12.ResumeLayout(false);
            TableLayoutPanel12.PerformLayout();
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvAddresses).EndInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox4).EndInit();
            TableLayoutPanel6.ResumeLayout(false);
            TableLayoutPanel6.PerformLayout();
            TableLayoutPanel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)_PictureBox1).EndInit();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)availableCodePictureBox).EndInit();
            pnlRAteTier.ResumeLayout(false);
            pnlRAteTier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CompanyAddressBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label5;
        internal TableLayoutPanel TableLayoutPanel15;
        internal Panel ediPanel;
        internal Panel typeNewCompanyModePanel;
        internal TableLayoutPanel TableLayoutPanel11;
        private CheckedListBox _cblCompanyType;

        internal CheckedListBox cblCompanyType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cblCompanyType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cblCompanyType != null)
                {
                    _cblCompanyType.SelectedIndexChanged -= CheckedListBox1_SelectedIndexChanged;
                    _cblCompanyType.ItemCheck -= typeCheckedListBox_ItemCheck;
                    _cblCompanyType.ItemCheck -= cblCompanyType_CheckedChanged;
                }

                _cblCompanyType = value;
                if (_cblCompanyType != null)
                {
                    _cblCompanyType.SelectedIndexChanged += CheckedListBox1_SelectedIndexChanged;
                    _cblCompanyType.ItemCheck += typeCheckedListBox_ItemCheck;
                    _cblCompanyType.ItemCheck += cblCompanyType_CheckedChanged;
                }
            }
        }

        internal Label typeNewCompanyModeLabel;
        internal Label titleLabel;
        internal Panel Panel3;
        internal TableLayoutPanel TableLayoutPanel12;
        internal Label Label15;
        private PictureBox _PictureBox5;

        internal PictureBox PictureBox5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox5 != null)
                {
                    _PictureBox5.Click -= PictureBox5_Click;
                }

                _PictureBox5 = value;
                if (_PictureBox5 != null)
                {
                    _PictureBox5.Click += PictureBox5_Click;
                }
            }
        }

        private PictureBox _PictureBox4;

        internal PictureBox PictureBox4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox4 != null)
                {
                    _PictureBox4.Click -= PictureBox4_Click;
                }

                _PictureBox4 = value;
                if (_PictureBox4 != null)
                {
                    _PictureBox4.Click += PictureBox4_Click;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel6;
        internal TableLayoutPanel TableLayoutPanel16;
        private PictureBox _PictureBox3;

        internal PictureBox PictureBox3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox3 != null)
                {
                    _PictureBox3.Click -= PictureBox3_Click;
                }

                _PictureBox3 = value;
                if (_PictureBox3 != null)
                {
                    _PictureBox3.Click += PictureBox3_Click;
                }
            }
        }

        private PictureBox _PictureBox2;

        internal PictureBox PictureBox2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox2 != null)
                {
                    _PictureBox2.Click -= PictureBox2_Click;
                }

                _PictureBox2 = value;
                if (_PictureBox2 != null)
                {
                    _PictureBox2.Click += PictureBox2_Click;
                }
            }
        }

        private PictureBox _PictureBox1;

        internal PictureBox PictureBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox1 != null)
                {
                    _PictureBox1.Click -= PictureBox1_Click;
                }

                _PictureBox1 = value;
                if (_PictureBox1 != null)
                {
                    _PictureBox1.Click += PictureBox1_Click;
                }
            }
        }

        internal Label Label18;
        internal Label Label13;
        internal RichTextBox tbNotes;
        internal TableLayoutPanel TableLayoutPanel1;
        internal PictureBox availableCodePictureBox;
        internal TextBox tbName;
        internal TextBox tbCode;
        internal Label Label1;
        internal Label Label2;
        internal TextBox tbEmail;
        internal Label Label12;
        internal TextBox tbWebsite;
        internal Label warningLabel;
        internal Label Label17;
        internal Label Label11;
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

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _ediButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton ediButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ediButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ediButton != null)
                {
                    _ediButton.Click -= Button1_Click_1;
                }

                _ediButton = value;
                if (_ediButton != null)
                {
                    _ediButton.Click += Button1_Click_1;
                }
            }
        }

        internal Panel pnlRAteTier;
        internal Label Label3;
        internal Label lblWarning;
        internal CheckBox cbRquiresedi;
        internal TextBox tbAttention;
        internal ComboBox cboRateTier;
        internal TextBox ediTextBox;
        private ComboBox _cboCompanyCategory;

        internal ComboBox cboCompanyCategory
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboCompanyCategory;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboCompanyCategory != null)
                {
                    _cboCompanyCategory.SelectedIndexChanged -= tbCompanyCategory_SelectedIndexChanged;
                }

                _cboCompanyCategory = value;
                if (_cboCompanyCategory != null)
                {
                    _cboCompanyCategory.SelectedIndexChanged += tbCompanyCategory_SelectedIndexChanged;
                }
            }
        }

        internal Label Label16;
        internal Label Label20;
        internal Label Label4;
        internal Panel Panel4;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvAddresses;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvAddresses
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvAddresses;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvAddresses != null)
                {
                    _dgvAddresses.CellDoubleClick -= dgvAddresses_CellDoubleClick;
                }

                _dgvAddresses = value;
                if (_dgvAddresses != null)
                {
                    _dgvAddresses.CellDoubleClick += dgvAddresses_CellDoubleClick;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton1;
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

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddCompany;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddCompany
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddCompany;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddCompany != null)
                {
                    _btnAddCompany.Click -= btnAddCompany_Click;
                }

                _btnAddCompany = value;
                if (_btnAddCompany != null)
                {
                    _btnAddCompany.Click += btnAddCompany_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn StreetAddressDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn AddressDescriptionDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ZipCodeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn PhoneDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn FaxDataGridViewTextBoxColumn;
        internal BindingSource CompanyAddressBindingSource;
    }
}