using System;
using System.Diagnostics;
using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAddEditInventory : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditInventory));
            var BorderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties23 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties24 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties25 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties26 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var BorderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties19 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties20 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            var BorderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties27 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties28 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Label18 = new Label();
            BunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label17 = new Label();
            Label7 = new Label();
            _btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSave.Click += new EventHandler(btnSave_Click);
            lblWarning = new Label();
            Label8 = new Label();
            BunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            TableLayoutPanel3 = new TableLayoutPanel();
            _cboCustomer = new ComboBox();
            _cboCustomer.SelectedIndexChanged += new EventHandler(cboCustomer_SelectedIndexChanged);
            Label13 = new Label();
            dtpStorage = new DateTimePicker();
            Label12 = new Label();
            TableLayoutPanel1 = new TableLayoutPanel();
            TableLayoutPanel4 = new TableLayoutPanel();
            lblLogoDescription = new Label();
            Label10 = new Label();
            lblColorType = new Label();
            Label4 = new Label();
            lblBagWeight = new Label();
            lblBagColor = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label9 = new Label();
            lblBagSize = new Label();
            TableLayoutPanel2 = new TableLayoutPanel();
            lblBagName = new Label();
            _btnChooseLogo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnChooseLogo.Click += new EventHandler(btnChooseLogo_Click);
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            BunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            panelBagsList = new Panel();
            _BunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            _BunifuFlatButton1.Click += new EventHandler(BunifuFlatButton1_Click);
            Label11 = new Label();
            Label16 = new Label();
            GroupBox1 = new GroupBox();
            _cboCustomerBag = new ComboBox();
            _cboCustomerBag.SelectedIndexChanged += new EventHandler(cboBagWeight_SelectedIndexChanged);
            Label67 = new Label();
            _tbBagName = new BunifuTextBox();
            _tbBagName.TextChanged += new EventHandler(cboBagWeight_SelectedIndexChanged);
            Label63 = new Label();
            cboBagColor = new ComboBox();
            Label65 = new Label();
            _cboBagSize = new ComboBox();
            _cboBagSize.SelectedIndexChanged += new EventHandler(cboBagWeight_SelectedIndexChanged);
            Label66 = new Label();
            _btnAddLogo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddLogo.Click += new EventHandler(btnAddLogo_Click);
            _btnOkLogo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnOkLogo.Click += new EventHandler(btnOkLogo_Click);
            _dgvBags = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvBags.DoubleClick += new EventHandler(dgvBags_DoubleClick);
            BagDescription = new DataGridViewTextBoxColumn();
            ColorTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ColorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LogoDescription = new DataGridViewTextBoxColumn();
            VWBagBindingSource = new BindingSource(components);
            Panel1 = new Panel();
            dgvBagLocations = new Bunifu.UI.WinForms.BunifuDataGridView();
            LocationTag = new DataGridViewTextBoxColumn();
            StorageTypeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LocationName = new DataGridViewTextBoxColumn();
            BagQuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            VWInvenotryBagLocationBindingSource = new BindingSource(components);
            _BunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _BunifuButton1.Click += new EventHandler(BunifuButton1_Click);
            Label20 = new Label();
            lblTotalBags = new Label();
            GroupBox2 = new GroupBox();
            Label15 = new Label();
            TableLayoutPanel3.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            TableLayoutPanel4.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            panelBagsList.SuspendLayout();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvBags).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWBagBindingSource).BeginInit();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBagLocations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWInvenotryBagLocationBindingSource).BeginInit();
            GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label18.Location = new Point(48, 227);
            Label18.Name = "Label18";
            Label18.Size = new Size(190, 21);
            Label18.TabIndex = 193;
            Label18.Text = "Bag Location and quantity";
            // 
            // BunifuSeparator5
            // 
            BunifuSeparator5.BackColor = Color.Transparent;
            BunifuSeparator5.ForeColor = Color.Gray;
            BunifuSeparator5.LineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)));
            BunifuSeparator5.LineThickness = 1;
            BunifuSeparator5.Location = new Point(50, 249);
            BunifuSeparator5.Margin = new Padding(4);
            BunifuSeparator5.Name = "BunifuSeparator5";
            BunifuSeparator5.Size = new Size(584, 18);
            BunifuSeparator5.TabIndex = 192;
            BunifuSeparator5.Transparency = 255;
            BunifuSeparator5.Vertical = false;
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
            _closeFlatButton.Location = new Point(724, 0);
            _closeFlatButton.Margin = new Padding(7);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(55, 41);
            _closeFlatButton.TabIndex = 191;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Label17
            // 
            Label17.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label17.Dock = DockStyle.Top;
            Label17.Font = new Font("Segoe UI", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = Color.White;
            Label17.Location = new Point(0, 0);
            Label17.Margin = new Padding(4, 0, 4, 0);
            Label17.Name = "Label17";
            Label17.Size = new Size(779, 41);
            Label17.TabIndex = 190;
            Label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label7.Location = new Point(28, 54);
            Label7.Name = "Label7";
            Label7.Size = new Size(171, 25);
            Label7.TabIndex = 189;
            Label7.Text = "Edit Bag Inventory";
            // 
            // btnSave
            // 
            _btnSave.AllowToggling = false;
            _btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            _btnSave.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnSave.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSave.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSave.Font = new Font("Segoe UI Semibold", 9.75f);
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
            _btnSave.IndicateFocus = false;
            _btnSave.Location = new Point(311, 649);
            _btnSave.Margin = new Padding(3, 2, 3, 2);
            _btnSave.Name = "_btnSave";
            StateProperties15.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties15.BorderRadius = 3;
            StateProperties15.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties15.BorderThickness = 1;
            StateProperties15.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties15.ForeColor = Color.White;
            StateProperties15.IconLeftImage = null;
            StateProperties15.IconRightImage = null;
            _btnSave.onHoverState = StateProperties15;
            StateProperties16.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties16.BorderRadius = 3;
            StateProperties16.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties16.BorderThickness = 1;
            StateProperties16.FillColor = Color.Teal;
            StateProperties16.ForeColor = Color.White;
            StateProperties16.IconLeftImage = null;
            StateProperties16.IconRightImage = null;
            _btnSave.OnPressedState = StateProperties16;
            _btnSave.Size = new Size(107, 42);
            _btnSave.TabIndex = 195;
            _btnSave.TextAlign = ContentAlignment.MiddleCenter;
            _btnSave.TextMarginLeft = 0;
            _btnSave.UseDefaultRadiusAndThickness = true;
            // 
            // lblWarning
            // 
            lblWarning.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(325, 91);
            lblWarning.Margin = new Padding(4, 0, 4, 0);
            lblWarning.Name = "lblWarning";
            lblWarning.Padding = new Padding(4);
            lblWarning.Size = new Size(441, 28);
            lblWarning.TabIndex = 197;
            // 
            // Label8
            // 
            Label8.Anchor = AnchorStyles.Right;
            Label8.AutoSize = true;
            Label8.Location = new Point(69, 7);
            Label8.Name = "Label8";
            Label8.Size = new Size(72, 17);
            Label8.TabIndex = 11;
            Label8.Text = "Customer:";
            // 
            // BunifuSeparator3
            // 
            BunifuSeparator3.BackColor = Color.Transparent;
            BunifuSeparator3.ForeColor = Color.Gray;
            BunifuSeparator3.LineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)));
            BunifuSeparator3.LineThickness = 1;
            BunifuSeparator3.Location = new Point(45, 126);
            BunifuSeparator3.Margin = new Padding(4);
            BunifuSeparator3.Name = "BunifuSeparator3";
            BunifuSeparator3.Size = new Size(597, 17);
            BunifuSeparator3.TabIndex = 187;
            BunifuSeparator3.Transparency = 255;
            BunifuSeparator3.Vertical = false;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.ColumnCount = 2;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.89083f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.10917f));
            TableLayoutPanel3.Controls.Add(_cboCustomer, 1, 0);
            TableLayoutPanel3.Controls.Add(Label8, 0, 0);
            TableLayoutPanel3.Controls.Add(Label13, 0, 1);
            TableLayoutPanel3.Controls.Add(dtpStorage, 1, 1);
            TableLayoutPanel3.Location = new Point(52, 146);
            TableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 2;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.Size = new Size(581, 64);
            TableLayoutPanel3.TabIndex = 186;
            // 
            // cboCustomer
            // 
            _cboCustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
            _cboCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboCustomer.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboCustomer.FormattingEnabled = true;
            _cboCustomer.Location = new Point(147, 2);
            _cboCustomer.Margin = new Padding(3, 2, 3, 2);
            _cboCustomer.Name = "_cboCustomer";
            _cboCustomer.Size = new Size(354, 26);
            _cboCustomer.TabIndex = 8;
            // 
            // Label13
            // 
            Label13.Anchor = AnchorStyles.Right;
            Label13.AutoSize = true;
            Label13.Location = new Point(45, 39);
            Label13.Name = "Label13";
            Label13.Size = new Size(96, 17);
            Label13.TabIndex = 9;
            Label13.Text = "Storage Date:";
            // 
            // dtpStorage
            // 
            dtpStorage.CalendarFont = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            dtpStorage.CustomFormat = "dd-MMM-yyyy";
            dtpStorage.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            dtpStorage.Format = DateTimePickerFormat.Custom;
            dtpStorage.Location = new Point(147, 34);
            dtpStorage.Margin = new Padding(3, 2, 3, 2);
            dtpStorage.Name = "dtpStorage";
            dtpStorage.Size = new Size(192, 26);
            dtpStorage.TabIndex = 12;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label12.Location = new Point(44, 100);
            Label12.Name = "Label12";
            Label12.Size = new Size(79, 21);
            Label12.TabIndex = 188;
            Label12.Text = "Inventory:";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8995f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.1005f));
            TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 1, 1);
            TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 0);
            TableLayoutPanel1.Controls.Add(Label1, 0, 0);
            TableLayoutPanel1.Controls.Add(Label2, 0, 1);
            TableLayoutPanel1.Location = new Point(45, 482);
            TableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.28395f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.71605f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22.0f));
            TableLayoutPanel1.Size = new Size(527, 162);
            TableLayoutPanel1.TabIndex = 200;
            // 
            // TableLayoutPanel4
            // 
            TableLayoutPanel4.ColumnCount = 2;
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8995f));
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.1005f));
            TableLayoutPanel4.Controls.Add(lblLogoDescription, 1, 4);
            TableLayoutPanel4.Controls.Add(Label10, 0, 4);
            TableLayoutPanel4.Controls.Add(lblColorType, 1, 3);
            TableLayoutPanel4.Controls.Add(Label4, 0, 3);
            TableLayoutPanel4.Controls.Add(lblBagWeight, 1, 1);
            TableLayoutPanel4.Controls.Add(lblBagColor, 1, 2);
            TableLayoutPanel4.Controls.Add(Label5, 0, 0);
            TableLayoutPanel4.Controls.Add(Label6, 0, 1);
            TableLayoutPanel4.Controls.Add(Label9, 0, 2);
            TableLayoutPanel4.Controls.Add(lblBagSize, 1, 0);
            TableLayoutPanel4.Dock = DockStyle.Fill;
            TableLayoutPanel4.Location = new Point(160, 30);
            TableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            TableLayoutPanel4.Name = "TableLayoutPanel4";
            TableLayoutPanel4.RowCount = 5;
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel4.Size = new Size(364, 130);
            TableLayoutPanel4.TabIndex = 203;
            // 
            // lblLogoDescription
            // 
            lblLogoDescription.Anchor = AnchorStyles.Left;
            lblLogoDescription.AutoSize = true;
            lblLogoDescription.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblLogoDescription.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblLogoDescription.Location = new Point(111, 108);
            lblLogoDescription.Name = "lblLogoDescription";
            lblLogoDescription.Size = new Size(49, 17);
            lblLogoDescription.TabIndex = 206;
            lblLogoDescription.Text = "Logo:";
            lblLogoDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.Right;
            Label10.AutoSize = true;
            Label10.Location = new Point(61, 108);
            Label10.Name = "Label10";
            Label10.Size = new Size(44, 17);
            Label10.TabIndex = 9;
            Label10.Text = "Logo:";
            // 
            // lblColorType
            // 
            lblColorType.Anchor = AnchorStyles.Left;
            lblColorType.AutoSize = true;
            lblColorType.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblColorType.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblColorType.Location = new Point(111, 82);
            lblColorType.Name = "lblColorType";
            lblColorType.Size = new Size(87, 17);
            lblColorType.TabIndex = 203;
            lblColorType.Text = "Color Type";
            lblColorType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Right;
            Label4.AutoSize = true;
            Label4.Location = new Point(28, 82);
            Label4.Name = "Label4";
            Label4.Size = new Size(77, 17);
            Label4.TabIndex = 6;
            Label4.Text = "Color Type";
            // 
            // lblBagWeight
            // 
            lblBagWeight.Anchor = AnchorStyles.Left;
            lblBagWeight.AutoSize = true;
            lblBagWeight.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBagWeight.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblBagWeight.Location = new Point(111, 30);
            lblBagWeight.Name = "lblBagWeight";
            lblBagWeight.Size = new Size(58, 17);
            lblBagWeight.TabIndex = 204;
            lblBagWeight.Text = "Weight";
            lblBagWeight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBagColor
            // 
            lblBagColor.Anchor = AnchorStyles.Left;
            lblBagColor.AutoSize = true;
            lblBagColor.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBagColor.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblBagColor.Location = new Point(111, 56);
            lblBagColor.Name = "lblBagColor";
            lblBagColor.Size = new Size(51, 17);
            lblBagColor.TabIndex = 205;
            lblBagColor.Text = "Color:";
            lblBagColor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.Right;
            Label5.AutoSize = true;
            Label5.Location = new Point(66, 4);
            Label5.Name = "Label5";
            Label5.Size = new Size(39, 17);
            Label5.TabIndex = 5;
            Label5.Text = "Size:";
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.Right;
            Label6.AutoSize = true;
            Label6.Location = new Point(53, 30);
            Label6.Name = "Label6";
            Label6.Size = new Size(52, 17);
            Label6.TabIndex = 7;
            Label6.Text = "Weight";
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.Right;
            Label9.AutoSize = true;
            Label9.Location = new Point(60, 56);
            Label9.Name = "Label9";
            Label9.Size = new Size(45, 17);
            Label9.TabIndex = 8;
            Label9.Text = "Color:";
            // 
            // lblBagSize
            // 
            lblBagSize.Anchor = AnchorStyles.Left;
            lblBagSize.AutoSize = true;
            lblBagSize.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBagSize.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblBagSize.Location = new Point(111, 4);
            lblBagSize.Name = "lblBagSize";
            lblBagSize.Size = new Size(44, 17);
            lblBagSize.TabIndex = 10;
            lblBagSize.Text = "Size:";
            lblBagSize.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 2;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.589041f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.41096f));
            TableLayoutPanel2.Controls.Add(lblBagName, 0, 0);
            TableLayoutPanel2.Controls.Add(_btnChooseLogo, 0, 0);
            TableLayoutPanel2.Location = new Point(160, 2);
            TableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 1;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40.74074f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 24.0f));
            TableLayoutPanel2.Size = new Size(292, 24);
            TableLayoutPanel2.TabIndex = 202;
            // 
            // lblBagName
            // 
            lblBagName.AutoSize = true;
            lblBagName.BackColor = SystemColors.ButtonFace;
            lblBagName.Dock = DockStyle.Fill;
            lblBagName.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBagName.Location = new Point(29, 0);
            lblBagName.Margin = new Padding(2, 0, 2, 0);
            lblBagName.Name = "lblBagName";
            lblBagName.Padding = new Padding(0, 5, 0, 0);
            lblBagName.Size = new Size(261, 24);
            lblBagName.TabIndex = 178;
            lblBagName.Text = "...";
            lblBagName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnChooseLogo
            // 
            _btnChooseLogo.AllowToggling = false;
            _btnChooseLogo.AnimationSpeed = 200;
            _btnChooseLogo.AutoGenerateColors = false;
            _btnChooseLogo.BackColor = Color.Transparent;
            _btnChooseLogo.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnChooseLogo.BackgroundImage = (Image)resources.GetObject("btnChooseLogo.BackgroundImage");
            _btnChooseLogo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnChooseLogo.ButtonText = "...";
            _btnChooseLogo.ButtonTextMarginLeft = 0;
            _btnChooseLogo.ColorContrastOnClick = 45;
            _btnChooseLogo.ColorContrastOnHover = 45;
            _btnChooseLogo.Cursor = Cursors.Hand;
            BorderEdges7.BottomLeft = true;
            BorderEdges7.BottomRight = true;
            BorderEdges7.TopLeft = true;
            BorderEdges7.TopRight = true;
            _btnChooseLogo.CustomizableEdges = BorderEdges7;
            _btnChooseLogo.DialogResult = DialogResult.None;
            _btnChooseLogo.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnChooseLogo.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnChooseLogo.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnChooseLogo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnChooseLogo.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnChooseLogo.ForeColor = Color.White;
            _btnChooseLogo.IconLeftCursor = Cursors.Hand;
            _btnChooseLogo.IconMarginLeft = 11;
            _btnChooseLogo.IconPadding = 10;
            _btnChooseLogo.IconRightCursor = Cursors.Hand;
            _btnChooseLogo.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnChooseLogo.IdleBorderRadius = 3;
            _btnChooseLogo.IdleBorderThickness = 1;
            _btnChooseLogo.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnChooseLogo.IdleIconLeftImage = null;
            _btnChooseLogo.IdleIconRightImage = null;
            _btnChooseLogo.IndicateFocus = false;
            _btnChooseLogo.Location = new Point(2, 2);
            _btnChooseLogo.Margin = new Padding(2);
            _btnChooseLogo.Name = "_btnChooseLogo";
            StateProperties17.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties17.BorderRadius = 3;
            StateProperties17.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties17.BorderThickness = 1;
            StateProperties17.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties17.ForeColor = Color.White;
            StateProperties17.IconLeftImage = null;
            StateProperties17.IconRightImage = null;
            _btnChooseLogo.onHoverState = StateProperties17;
            StateProperties18.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties18.BorderRadius = 3;
            StateProperties18.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties18.BorderThickness = 1;
            StateProperties18.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties18.ForeColor = Color.White;
            StateProperties18.IconLeftImage = null;
            StateProperties18.IconRightImage = null;
            _btnChooseLogo.OnPressedState = StateProperties18;
            _btnChooseLogo.Size = new Size(22, 20);
            _btnChooseLogo.TabIndex = 177;
            _btnChooseLogo.TextAlign = ContentAlignment.MiddleCenter;
            _btnChooseLogo.TextMarginLeft = 0;
            _btnChooseLogo.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Location = new Point(117, 5);
            Label1.Name = "Label1";
            Label1.Size = new Size(37, 17);
            Label1.TabIndex = 5;
            Label1.Text = "Bag:";
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Right;
            Label2.AutoSize = true;
            Label2.Location = new Point(154, 86);
            Label2.Name = "Label2";
            Label2.Size = new Size(0, 17);
            Label2.TabIndex = 6;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label3.Location = new Point(40, 443);
            Label3.Name = "Label3";
            Label3.Size = new Size(122, 21);
            Label3.TabIndex = 199;
            Label3.Text = "Bag Information";
            // 
            // BunifuSeparator2
            // 
            BunifuSeparator2.BackColor = Color.Transparent;
            BunifuSeparator2.ForeColor = Color.Gray;
            BunifuSeparator2.LineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)));
            BunifuSeparator2.LineThickness = 1;
            BunifuSeparator2.Location = new Point(41, 465);
            BunifuSeparator2.Margin = new Padding(5);
            BunifuSeparator2.Name = "BunifuSeparator2";
            BunifuSeparator2.Size = new Size(588, 22);
            BunifuSeparator2.TabIndex = 201;
            BunifuSeparator2.Transparency = 255;
            BunifuSeparator2.Vertical = false;
            // 
            // panelBagsList
            // 
            panelBagsList.BackColor = Color.WhiteSmoke;
            panelBagsList.BorderStyle = BorderStyle.FixedSingle;
            panelBagsList.Controls.Add(_BunifuFlatButton1);
            panelBagsList.Controls.Add(Label11);
            panelBagsList.Controls.Add(Label16);
            panelBagsList.Controls.Add(GroupBox1);
            panelBagsList.Controls.Add(_btnAddLogo);
            panelBagsList.Controls.Add(_btnOkLogo);
            panelBagsList.Controls.Add(_dgvBags);
            panelBagsList.Location = new Point(234, 86);
            panelBagsList.Name = "panelBagsList";
            panelBagsList.Size = new Size(542, 422);
            panelBagsList.TabIndex = 202;
            panelBagsList.Visible = false;
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
            _BunifuFlatButton1.Location = new Point(505, 1);
            _BunifuFlatButton1.Margin = new Padding(6, 7, 6, 7);
            _BunifuFlatButton1.Name = "_BunifuFlatButton1";
            _BunifuFlatButton1.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuFlatButton1.OnHovercolor = Color.Gray;
            _BunifuFlatButton1.OnHoverTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuFlatButton1.selected = false;
            _BunifuFlatButton1.Size = new Size(35, 22);
            _BunifuFlatButton1.TabIndex = 177;
            _BunifuFlatButton1.Text = "🗙";
            _BunifuFlatButton1.TextAlign = ContentAlignment.MiddleCenter;
            _BunifuFlatButton1.Textcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _BunifuFlatButton1.TextFont = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Label11
            // 
            Label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 9.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.Location = new Point(154, -2);
            Label11.Margin = new Padding(2, 0, 2, 0);
            Label11.Name = "Label11";
            Label11.Padding = new Padding(0, 5, 0, 0);
            Label11.Size = new Size(175, 21);
            Label11.TabIndex = 58;
            Label11.Text = "Select bag and click ok";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Font = new Font("Microsoft Sans Serif", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.Location = new Point(-1, 378);
            Label16.Margin = new Padding(2, 0, 2, 0);
            Label16.Name = "Label16";
            Label16.Size = new Size(102, 13);
            Label16.TabIndex = 189;
            Label16.Text = "*Double click to edit";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(_cboCustomerBag);
            GroupBox1.Controls.Add(Label67);
            GroupBox1.Controls.Add(_tbBagName);
            GroupBox1.Controls.Add(Label63);
            GroupBox1.Controls.Add(cboBagColor);
            GroupBox1.Controls.Add(Label65);
            GroupBox1.Controls.Add(_cboBagSize);
            GroupBox1.Controls.Add(Label66);
            GroupBox1.Location = new Point(3, 20);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(528, 79);
            GroupBox1.TabIndex = 203;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Filter";
            // 
            // cboCustomerBag
            // 
            _cboCustomerBag.AutoCompleteMode = AutoCompleteMode.Append;
            _cboCustomerBag.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboCustomerBag.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboCustomerBag.FormattingEnabled = true;
            _cboCustomerBag.Location = new Point(81, 20);
            _cboCustomerBag.Margin = new Padding(2);
            _cboCustomerBag.Name = "_cboCustomerBag";
            _cboCustomerBag.Size = new Size(261, 24);
            _cboCustomerBag.TabIndex = 198;
            // 
            // Label67
            // 
            Label67.AutoSize = true;
            Label67.Location = new Point(6, 23);
            Label67.Margin = new Padding(2, 0, 2, 0);
            Label67.Name = "Label67";
            Label67.Size = new Size(74, 17);
            Label67.TabIndex = 197;
            Label67.Text = "Bag Color:";
            // 
            // tbBagName
            // 
            _tbBagName.AcceptsReturn = false;
            _tbBagName.AcceptsTab = false;
            _tbBagName.AnimationSpeed = 200;
            _tbBagName.AutoCompleteMode = AutoCompleteMode.None;
            _tbBagName.AutoCompleteSource = AutoCompleteSource.None;
            _tbBagName.BackColor = Color.Transparent;
            _tbBagName.BackgroundImage = (Image)resources.GetObject("tbBagName.BackgroundImage");
            _tbBagName.BorderColorActive = Color.DodgerBlue;
            _tbBagName.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _tbBagName.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _tbBagName.BorderColorIdle = Color.Silver;
            _tbBagName.BorderRadius = 1;
            _tbBagName.BorderThickness = 1;
            _tbBagName.CharacterCasing = CharacterCasing.Normal;
            _tbBagName.Cursor = Cursors.IBeam;
            _tbBagName.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _tbBagName.DefaultText = "";
            _tbBagName.FillColor = Color.White;
            _tbBagName.HideSelection = true;
            _tbBagName.IconLeft = null;
            _tbBagName.IconLeftCursor = Cursors.IBeam;
            _tbBagName.IconPadding = 10;
            _tbBagName.IconRight = null;
            _tbBagName.IconRightCursor = Cursors.IBeam;
            _tbBagName.Lines = new string[0];
            _tbBagName.Location = new Point(81, 45);
            _tbBagName.Margin = new Padding(3, 2, 3, 2);
            _tbBagName.MaxLength = 32767;
            _tbBagName.MinimumSize = new Size(116, 25);
            _tbBagName.Modified = false;
            _tbBagName.Multiline = false;
            _tbBagName.Name = "_tbBagName";
            StateProperties23.BorderColor = Color.DodgerBlue;
            StateProperties23.FillColor = Color.Empty;
            StateProperties23.ForeColor = Color.Empty;
            StateProperties23.PlaceholderForeColor = Color.Empty;
            _tbBagName.OnActiveState = StateProperties23;
            StateProperties24.BorderColor = Color.Empty;
            StateProperties24.FillColor = Color.White;
            StateProperties24.ForeColor = Color.Empty;
            StateProperties24.PlaceholderForeColor = Color.Silver;
            _tbBagName.OnDisabledState = StateProperties24;
            StateProperties25.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties25.FillColor = Color.Empty;
            StateProperties25.ForeColor = Color.Empty;
            StateProperties25.PlaceholderForeColor = Color.Empty;
            _tbBagName.OnHoverState = StateProperties25;
            StateProperties26.BorderColor = Color.Silver;
            StateProperties26.FillColor = Color.White;
            StateProperties26.ForeColor = Color.Empty;
            StateProperties26.PlaceholderForeColor = Color.Empty;
            _tbBagName.OnIdleState = StateProperties26;
            _tbBagName.PasswordChar = '\0';
            _tbBagName.PlaceholderForeColor = Color.Silver;
            _tbBagName.PlaceholderText = "";
            _tbBagName.ReadOnly = false;
            _tbBagName.ScrollBars = ScrollBars.None;
            _tbBagName.SelectedText = "";
            _tbBagName.SelectionLength = 0;
            _tbBagName.SelectionStart = 0;
            _tbBagName.ShortcutsEnabled = true;
            _tbBagName.Size = new Size(247, 29);
            _tbBagName.Style = _Style.Bunifu;
            _tbBagName.TabIndex = 196;
            _tbBagName.TextAlign = HorizontalAlignment.Left;
            _tbBagName.TextMarginBottom = 0;
            _tbBagName.TextMarginLeft = 5;
            _tbBagName.TextMarginTop = 0;
            _tbBagName.TextPlaceholder = "";
            _tbBagName.UseSystemPasswordChar = false;
            _tbBagName.WordWrap = true;
            // 
            // Label63
            // 
            Label63.AutoSize = true;
            Label63.Location = new Point(3, 53);
            Label63.Margin = new Padding(2, 0, 2, 0);
            Label63.Name = "Label63";
            Label63.Size = new Size(78, 17);
            Label63.TabIndex = 195;
            Label63.Text = "Bag Name:";
            // 
            // cboBagColor
            // 
            cboBagColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBagColor.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboBagColor.FormattingEnabled = true;
            cboBagColor.Location = new Point(414, 44);
            cboBagColor.Margin = new Padding(2);
            cboBagColor.Name = "cboBagColor";
            cboBagColor.Size = new Size(110, 24);
            cboBagColor.TabIndex = 194;
            // 
            // Label65
            // 
            Label65.AutoSize = true;
            Label65.Location = new Point(339, 48);
            Label65.Margin = new Padding(2, 0, 2, 0);
            Label65.Name = "Label65";
            Label65.Size = new Size(74, 17);
            Label65.TabIndex = 192;
            Label65.Text = "Bag Color:";
            // 
            // cboBagSize
            // 
            _cboBagSize.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboBagSize.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboBagSize.FormattingEnabled = true;
            _cboBagSize.Location = new Point(432, 16);
            _cboBagSize.Margin = new Padding(2);
            _cboBagSize.Name = "_cboBagSize";
            _cboBagSize.Size = new Size(92, 24);
            _cboBagSize.TabIndex = 193;
            // 
            // Label66
            // 
            Label66.AutoSize = true;
            Label66.Location = new Point(362, 19);
            Label66.Margin = new Padding(2, 0, 2, 0);
            Label66.Name = "Label66";
            Label66.Size = new Size(68, 17);
            Label66.TabIndex = 191;
            Label66.Text = "Bag Size:";
            // 
            // btnAddLogo
            // 
            _btnAddLogo.AllowToggling = false;
            _btnAddLogo.AnimationSpeed = 200;
            _btnAddLogo.AutoGenerateColors = false;
            _btnAddLogo.BackColor = Color.Transparent;
            _btnAddLogo.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddLogo.BackgroundImage = (Image)resources.GetObject("btnAddLogo.BackgroundImage");
            _btnAddLogo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddLogo.ButtonText = "+";
            _btnAddLogo.ButtonTextMarginLeft = 0;
            _btnAddLogo.ColorContrastOnClick = 45;
            _btnAddLogo.ColorContrastOnHover = 45;
            _btnAddLogo.Cursor = Cursors.Hand;
            BorderEdges8.BottomLeft = true;
            BorderEdges8.BottomRight = true;
            BorderEdges8.TopLeft = true;
            BorderEdges8.TopRight = true;
            _btnAddLogo.CustomizableEdges = BorderEdges8;
            _btnAddLogo.DialogResult = DialogResult.None;
            _btnAddLogo.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnAddLogo.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddLogo.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddLogo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddLogo.Font = new Font("Microsoft YaHei", 14.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddLogo.ForeColor = Color.White;
            _btnAddLogo.IconLeftCursor = Cursors.Hand;
            _btnAddLogo.IconMarginLeft = 11;
            _btnAddLogo.IconPadding = 10;
            _btnAddLogo.IconRightCursor = Cursors.Hand;
            _btnAddLogo.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddLogo.IdleBorderRadius = 25;
            _btnAddLogo.IdleBorderThickness = 1;
            _btnAddLogo.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddLogo.IdleIconLeftImage = null;
            _btnAddLogo.IdleIconRightImage = null;
            _btnAddLogo.IndicateFocus = false;
            _btnAddLogo.Location = new Point(512, 378);
            _btnAddLogo.Margin = new Padding(2);
            _btnAddLogo.Name = "_btnAddLogo";
            StateProperties19.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties19.BorderRadius = 25;
            StateProperties19.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties19.BorderThickness = 1;
            StateProperties19.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties19.ForeColor = Color.White;
            StateProperties19.IconLeftImage = null;
            StateProperties19.IconRightImage = null;
            _btnAddLogo.onHoverState = StateProperties19;
            StateProperties20.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties20.BorderRadius = 25;
            StateProperties20.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties20.BorderThickness = 1;
            StateProperties20.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties20.ForeColor = Color.White;
            StateProperties20.IconLeftImage = null;
            StateProperties20.IconRightImage = null;
            _btnAddLogo.OnPressedState = StateProperties20;
            _btnAddLogo.Size = new Size(29, 31);
            _btnAddLogo.TabIndex = 178;
            _btnAddLogo.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddLogo.TextMarginLeft = 0;
            _btnAddLogo.UseDefaultRadiusAndThickness = true;
            // 
            // btnOkLogo
            // 
            _btnOkLogo.AllowToggling = false;
            _btnOkLogo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _btnOkLogo.AnimationSpeed = 200;
            _btnOkLogo.AutoGenerateColors = false;
            _btnOkLogo.BackColor = Color.Transparent;
            _btnOkLogo.BackColor1 = Color.Teal;
            _btnOkLogo.BackgroundImage = (Image)resources.GetObject("btnOkLogo.BackgroundImage");
            _btnOkLogo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnOkLogo.ButtonText = "Ok";
            _btnOkLogo.ButtonTextMarginLeft = 0;
            _btnOkLogo.ColorContrastOnClick = 45;
            _btnOkLogo.ColorContrastOnHover = 45;
            _btnOkLogo.Cursor = Cursors.Hand;
            BorderEdges9.BottomLeft = true;
            BorderEdges9.BottomRight = true;
            BorderEdges9.TopLeft = true;
            BorderEdges9.TopRight = true;
            _btnOkLogo.CustomizableEdges = BorderEdges9;
            _btnOkLogo.DialogResult = DialogResult.None;
            _btnOkLogo.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnOkLogo.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnOkLogo.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnOkLogo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnOkLogo.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnOkLogo.ForeColor = Color.White;
            _btnOkLogo.IconLeftCursor = Cursors.Hand;
            _btnOkLogo.IconMarginLeft = 11;
            _btnOkLogo.IconPadding = 10;
            _btnOkLogo.IconRightCursor = Cursors.Hand;
            _btnOkLogo.IdleBorderColor = Color.Teal;
            _btnOkLogo.IdleBorderRadius = 3;
            _btnOkLogo.IdleBorderThickness = 1;
            _btnOkLogo.IdleFillColor = Color.Teal;
            _btnOkLogo.IdleIconLeftImage = null;
            _btnOkLogo.IdleIconRightImage = null;
            _btnOkLogo.IndicateFocus = false;
            _btnOkLogo.Location = new Point(224, 382);
            _btnOkLogo.Margin = new Padding(2);
            _btnOkLogo.Name = "_btnOkLogo";
            StateProperties21.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties21.BorderRadius = 3;
            StateProperties21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties21.BorderThickness = 1;
            StateProperties21.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties21.ForeColor = Color.White;
            StateProperties21.IconLeftImage = null;
            StateProperties21.IconRightImage = null;
            _btnOkLogo.onHoverState = StateProperties21;
            StateProperties22.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties22.BorderRadius = 3;
            StateProperties22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties22.BorderThickness = 1;
            StateProperties22.FillColor = Color.Teal;
            StateProperties22.ForeColor = Color.White;
            StateProperties22.IconLeftImage = null;
            StateProperties22.IconRightImage = null;
            _btnOkLogo.OnPressedState = StateProperties22;
            _btnOkLogo.Size = new Size(65, 28);
            _btnOkLogo.TabIndex = 176;
            _btnOkLogo.TextAlign = ContentAlignment.MiddleCenter;
            _btnOkLogo.TextMarginLeft = 0;
            _btnOkLogo.UseDefaultRadiusAndThickness = true;
            // 
            // dgvBags
            // 
            _dgvBags.AllowCustomTheming = true;
            _dgvBags.AllowUserToAddRows = false;
            _dgvBags.AllowUserToDeleteRows = false;
            _dgvBags.AllowUserToResizeColumns = false;
            _dgvBags.AllowUserToResizeRows = false;
            DataGridViewCellStyle7.BackColor = Color.White;
            DataGridViewCellStyle7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle7.SelectionBackColor = SystemColors.ButtonFace;
            _dgvBags.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7;
            _dgvBags.AutoGenerateColumns = false;
            _dgvBags.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvBags.BackgroundColor = Color.White;
            _dgvBags.BorderStyle = BorderStyle.None;
            _dgvBags.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvBags.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle8.BackColor = Color.Silver;
            DataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle8.ForeColor = Color.Black;
            DataGridViewCellStyle8.SelectionBackColor = Color.Silver;
            DataGridViewCellStyle8.SelectionForeColor = Color.Black;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            _dgvBags.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8;
            _dgvBags.ColumnHeadersHeight = 30;
            _dgvBags.Columns.AddRange(new DataGridViewColumn[] { BagDescription, ColorTypeDataGridViewTextBoxColumn, ColorNameDataGridViewTextBoxColumn, LogoDescription });
            _dgvBags.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvBags.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvBags.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvBags.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.Lavender;
            _dgvBags.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvBags.CurrentTheme.BackColor = Color.White;
            _dgvBags.CurrentTheme.GridColor = Color.DarkGray;
            _dgvBags.CurrentTheme.HeaderStyle.BackColor = Color.Silver;
            _dgvBags.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _dgvBags.CurrentTheme.HeaderStyle.ForeColor = Color.Black;
            _dgvBags.CurrentTheme.Name = null;
            _dgvBags.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgvBags.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvBags.CurrentTheme.RowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvBags.CurrentTheme.RowsStyle.SelectionBackColor = Color.Lavender;
            _dgvBags.CurrentTheme.RowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvBags.DataSource = VWBagBindingSource;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle9.BackColor = Color.White;
            DataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle9.SelectionBackColor = Color.Lavender;
            DataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            _dgvBags.DefaultCellStyle = DataGridViewCellStyle9;
            _dgvBags.EnableHeadersVisualStyles = false;
            _dgvBags.GridColor = Color.DarkGray;
            _dgvBags.HeaderBackColor = Color.Silver;
            _dgvBags.HeaderBgColor = Color.Empty;
            _dgvBags.HeaderForeColor = Color.Black;
            _dgvBags.Location = new Point(3, 104);
            _dgvBags.MultiSelect = false;
            _dgvBags.Name = "_dgvBags";
            _dgvBags.ReadOnly = true;
            _dgvBags.RowHeadersVisible = false;
            _dgvBags.RowHeadersWidth = 30;
            _dgvBags.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonFace;
            _dgvBags.RowTemplate.Height = 25;
            _dgvBags.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvBags.Size = new Size(534, 270);
            _dgvBags.TabIndex = 57;
            _dgvBags.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // BagDescription
            // 
            BagDescription.DataPropertyName = "BagDescription";
            BagDescription.FillWeight = 121.8274f;
            BagDescription.HeaderText = "Bag Name";
            BagDescription.MinimumWidth = 6;
            BagDescription.Name = "BagDescription";
            BagDescription.ReadOnly = true;
            // 
            // ColorTypeDataGridViewTextBoxColumn
            // 
            ColorTypeDataGridViewTextBoxColumn.DataPropertyName = "ColorType";
            ColorTypeDataGridViewTextBoxColumn.FillWeight = 92.7242f;
            ColorTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            ColorTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            ColorTypeDataGridViewTextBoxColumn.Name = "ColorTypeDataGridViewTextBoxColumn";
            ColorTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ColorNameDataGridViewTextBoxColumn
            // 
            ColorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            ColorNameDataGridViewTextBoxColumn.FillWeight = 92.7242f;
            ColorNameDataGridViewTextBoxColumn.HeaderText = "Color";
            ColorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            ColorNameDataGridViewTextBoxColumn.Name = "ColorNameDataGridViewTextBoxColumn";
            ColorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LogoDescription
            // 
            LogoDescription.DataPropertyName = "LogoDescription";
            LogoDescription.FillWeight = 92.7242f;
            LogoDescription.HeaderText = "Logo Name";
            LogoDescription.MinimumWidth = 6;
            LogoDescription.Name = "LogoDescription";
            LogoDescription.ReadOnly = true;
            // 
            // VWBagBindingSource
            // 
            VWBagBindingSource.DataSource = typeof(ModelLayer.VW_Bag);
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(dgvBagLocations);
            Panel1.Location = new Point(60, 268);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(403, 100);
            Panel1.TabIndex = 204;
            // 
            // dgvBagLocations
            // 
            dgvBagLocations.AllowCustomTheming = true;
            dgvBagLocations.AllowUserToAddRows = false;
            dgvBagLocations.AllowUserToDeleteRows = false;
            dgvBagLocations.AllowUserToResizeColumns = false;
            dgvBagLocations.AllowUserToResizeRows = false;
            DataGridViewCellStyle10.BackColor = Color.White;
            DataGridViewCellStyle10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle10.SelectionBackColor = SystemColors.ButtonFace;
            dgvBagLocations.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10;
            dgvBagLocations.AutoGenerateColumns = false;
            dgvBagLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBagLocations.BackgroundColor = Color.White;
            dgvBagLocations.BorderStyle = BorderStyle.None;
            dgvBagLocations.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBagLocations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle11.BackColor = Color.Silver;
            DataGridViewCellStyle11.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle11.ForeColor = Color.Black;
            DataGridViewCellStyle11.SelectionBackColor = Color.Silver;
            DataGridViewCellStyle11.SelectionForeColor = Color.Black;
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvBagLocations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11;
            dgvBagLocations.ColumnHeadersHeight = 20;
            dgvBagLocations.Columns.AddRange(new DataGridViewColumn[] { LocationTag, StorageTypeNameDataGridViewTextBoxColumn, LocationName, BagQuantityDataGridViewTextBoxColumn });
            dgvBagLocations.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            dgvBagLocations.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvBagLocations.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvBagLocations.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.Lavender;
            dgvBagLocations.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvBagLocations.CurrentTheme.BackColor = Color.White;
            dgvBagLocations.CurrentTheme.GridColor = Color.DarkGray;
            dgvBagLocations.CurrentTheme.HeaderStyle.BackColor = Color.Silver;
            dgvBagLocations.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            dgvBagLocations.CurrentTheme.HeaderStyle.ForeColor = Color.Black;
            dgvBagLocations.CurrentTheme.Name = null;
            dgvBagLocations.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvBagLocations.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvBagLocations.CurrentTheme.RowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvBagLocations.CurrentTheme.RowsStyle.SelectionBackColor = Color.Lavender;
            dgvBagLocations.CurrentTheme.RowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvBagLocations.DataSource = VWInvenotryBagLocationBindingSource;
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle12.BackColor = Color.White;
            DataGridViewCellStyle12.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle12.SelectionBackColor = Color.Lavender;
            DataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvBagLocations.DefaultCellStyle = DataGridViewCellStyle12;
            dgvBagLocations.Dock = DockStyle.Fill;
            dgvBagLocations.EnableHeadersVisualStyles = false;
            dgvBagLocations.GridColor = Color.DarkGray;
            dgvBagLocations.HeaderBackColor = Color.Silver;
            dgvBagLocations.HeaderBgColor = Color.Empty;
            dgvBagLocations.HeaderForeColor = Color.Black;
            dgvBagLocations.Location = new Point(0, 0);
            dgvBagLocations.MultiSelect = false;
            dgvBagLocations.Name = "dgvBagLocations";
            dgvBagLocations.ReadOnly = true;
            dgvBagLocations.RowHeadersVisible = false;
            dgvBagLocations.RowHeadersWidth = 25;
            dgvBagLocations.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonFace;
            dgvBagLocations.RowTemplate.Height = 25;
            dgvBagLocations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBagLocations.Size = new Size(401, 98);
            dgvBagLocations.TabIndex = 204;
            dgvBagLocations.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // LocationTag
            // 
            LocationTag.DataPropertyName = "LocationTag";
            LocationTag.HeaderText = "Location Tag";
            LocationTag.Name = "LocationTag";
            LocationTag.ReadOnly = true;
            // 
            // StorageTypeNameDataGridViewTextBoxColumn
            // 
            StorageTypeNameDataGridViewTextBoxColumn.DataPropertyName = "StorageTypeName";
            StorageTypeNameDataGridViewTextBoxColumn.HeaderText = "Storage Type";
            StorageTypeNameDataGridViewTextBoxColumn.Name = "StorageTypeNameDataGridViewTextBoxColumn";
            StorageTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LocationName
            // 
            LocationName.DataPropertyName = "LocationStorageName";
            LocationName.FillWeight = 146.7332f;
            LocationName.HeaderText = "Location";
            LocationName.Name = "LocationName";
            LocationName.ReadOnly = true;
            // 
            // BagQuantityDataGridViewTextBoxColumn
            // 
            BagQuantityDataGridViewTextBoxColumn.DataPropertyName = "BagQuantity";
            BagQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            BagQuantityDataGridViewTextBoxColumn.Name = "BagQuantityDataGridViewTextBoxColumn";
            BagQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VWInvenotryBagLocationBindingSource
            // 
            VWInvenotryBagLocationBindingSource.DataSource = typeof(ModelLayer.VW_InventoryBagLocation);
            // 
            // BunifuButton1
            // 
            _BunifuButton1.AllowToggling = false;
            _BunifuButton1.AnimationSpeed = 200;
            _BunifuButton1.AutoGenerateColors = false;
            _BunifuButton1.BackColor = Color.Transparent;
            _BunifuButton1.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _BunifuButton1.BackgroundImage = (Image)resources.GetObject("BunifuButton1.BackgroundImage");
            _BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _BunifuButton1.ButtonText = "+";
            _BunifuButton1.ButtonTextMarginLeft = 0;
            _BunifuButton1.ColorContrastOnClick = 45;
            _BunifuButton1.ColorContrastOnHover = 45;
            _BunifuButton1.Cursor = Cursors.Hand;
            BorderEdges10.BottomLeft = true;
            BorderEdges10.BottomRight = true;
            BorderEdges10.TopLeft = true;
            BorderEdges10.TopRight = true;
            _BunifuButton1.CustomizableEdges = BorderEdges10;
            _BunifuButton1.DialogResult = DialogResult.None;
            _BunifuButton1.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _BunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _BunifuButton1.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _BunifuButton1.Font = new Font("Microsoft YaHei", 14.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _BunifuButton1.ForeColor = Color.White;
            _BunifuButton1.IconLeftCursor = Cursors.Hand;
            _BunifuButton1.IconMarginLeft = 11;
            _BunifuButton1.IconPadding = 10;
            _BunifuButton1.IconRightCursor = Cursors.Hand;
            _BunifuButton1.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _BunifuButton1.IdleBorderRadius = 25;
            _BunifuButton1.IdleBorderThickness = 1;
            _BunifuButton1.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _BunifuButton1.IdleIconLeftImage = null;
            _BunifuButton1.IdleIconRightImage = null;
            _BunifuButton1.IndicateFocus = false;
            _BunifuButton1.Location = new Point(468, 268);
            _BunifuButton1.Margin = new Padding(2);
            _BunifuButton1.Name = "_BunifuButton1";
            StateProperties27.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties27.BorderRadius = 25;
            StateProperties27.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties27.BorderThickness = 1;
            StateProperties27.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties27.ForeColor = Color.White;
            StateProperties27.IconLeftImage = null;
            StateProperties27.IconRightImage = null;
            _BunifuButton1.onHoverState = StateProperties27;
            StateProperties28.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties28.BorderRadius = 25;
            StateProperties28.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties28.BorderThickness = 1;
            StateProperties28.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties28.ForeColor = Color.White;
            StateProperties28.IconLeftImage = null;
            StateProperties28.IconRightImage = null;
            _BunifuButton1.OnPressedState = StateProperties28;
            _BunifuButton1.Size = new Size(29, 28);
            _BunifuButton1.TabIndex = 205;
            _BunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            _BunifuButton1.TextMarginLeft = 0;
            _BunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // Label20
            // 
            Label20.Anchor = AnchorStyles.Right;
            Label20.AutoSize = true;
            Label20.Font = new Font("Microsoft Sans Serif", 9.5f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label20.Location = new Point(58, 371);
            Label20.Name = "Label20";
            Label20.Size = new Size(129, 16);
            Label20.TabIndex = 207;
            Label20.Text = "* Double click to edit";
            // 
            // lblTotalBags
            // 
            lblTotalBags.Anchor = AnchorStyles.Right;
            lblTotalBags.Font = new Font("Microsoft Sans Serif", 20.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotalBags.ForeColor = Color.Teal;
            lblTotalBags.Location = new Point(5, 36);
            lblTotalBags.Name = "lblTotalBags";
            lblTotalBags.Size = new Size(149, 34);
            lblTotalBags.TabIndex = 208;
            lblTotalBags.Text = "0";
            lblTotalBags.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(Label15);
            GroupBox2.Controls.Add(lblTotalBags);
            GroupBox2.Location = new Point(543, 274);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(155, 82);
            GroupBox2.TabIndex = 209;
            GroupBox2.TabStop = false;
            // 
            // Label15
            // 
            Label15.Anchor = AnchorStyles.Right;
            Label15.AutoSize = true;
            Label15.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.Location = new Point(36, 15);
            Label15.Name = "Label15";
            Label15.Size = new Size(89, 20);
            Label15.TabIndex = 209;
            Label15.Text = "Total Bags:";
            // 
            // FrmAddEditInventory
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(779, 702);
            Controls.Add(panelBagsList);
            Controls.Add(GroupBox2);
            Controls.Add(Label20);
            Controls.Add(Panel1);
            Controls.Add(Label3);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(BunifuSeparator2);
            Controls.Add(Label18);
            Controls.Add(BunifuSeparator5);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label17);
            Controls.Add(Label7);
            Controls.Add(_btnSave);
            Controls.Add(lblWarning);
            Controls.Add(BunifuSeparator3);
            Controls.Add(TableLayoutPanel3);
            Controls.Add(Label12);
            Controls.Add(_BunifuButton1);
            Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmAddEditInventory";
            Text = "ss";
            TableLayoutPanel3.ResumeLayout(false);
            TableLayoutPanel3.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            TableLayoutPanel4.ResumeLayout(false);
            TableLayoutPanel4.PerformLayout();
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            panelBagsList.ResumeLayout(false);
            panelBagsList.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvBags).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWBagBindingSource).EndInit();
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBagLocations).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWInvenotryBagLocationBindingSource).EndInit();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label18;
        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator5;
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

        internal Label Label17;
        internal Label Label7;
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

        internal Label lblWarning;
        internal Label Label8;
        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator3;
        internal TableLayoutPanel TableLayoutPanel3;
        internal Label Label13;
        private ComboBox _cboCustomer;

        internal ComboBox cboCustomer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboCustomer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboCustomer != null)
                {
                    _cboCustomer.SelectedIndexChanged -= cboCustomer_SelectedIndexChanged;
                }

                _cboCustomer = value;
                if (_cboCustomer != null)
                {
                    _cboCustomer.SelectedIndexChanged += cboCustomer_SelectedIndexChanged;
                }
            }
        }

        internal DateTimePicker dtpStorage;
        internal Label Label12;
        internal TableLayoutPanel TableLayoutPanel1;
        internal TableLayoutPanel TableLayoutPanel4;
        internal Label Label5;
        internal TableLayoutPanel TableLayoutPanel2;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnChooseLogo;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnChooseLogo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnChooseLogo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnChooseLogo != null)
                {
                    _btnChooseLogo.Click -= btnChooseLogo_Click;
                }

                _btnChooseLogo = value;
                if (_btnChooseLogo != null)
                {
                    _btnChooseLogo.Click += btnChooseLogo_Click;
                }
            }
        }

        internal Label Label10;
        internal Label Label4;
        internal Label Label6;
        internal Label Label9;
        internal Label lblBagName;
        internal Panel panelBagsList;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddLogo;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddLogo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddLogo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddLogo != null)
                {
                    _btnAddLogo.Click -= btnAddLogo_Click;
                }

                _btnAddLogo = value;
                if (_btnAddLogo != null)
                {
                    _btnAddLogo.Click += btnAddLogo_Click;
                }
            }
        }

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

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnOkLogo;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOkLogo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOkLogo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOkLogo != null)
                {
                    _btnOkLogo.Click -= btnOkLogo_Click;
                }

                _btnOkLogo = value;
                if (_btnOkLogo != null)
                {
                    _btnOkLogo.Click += btnOkLogo_Click;
                }
            }
        }

        internal Label Label11;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvBags;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvBags
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvBags;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvBags != null)
                {
                    _dgvBags.DoubleClick -= dgvBags_DoubleClick;
                }

                _dgvBags = value;
                if (_dgvBags != null)
                {
                    _dgvBags.DoubleClick += dgvBags_DoubleClick;
                }
            }
        }

        internal GroupBox GroupBox1;
        internal DataGridViewTextBoxColumn BagWeightDataGridViewTextBoxColumn;
        internal Label lblLogoDescription;
        internal Label lblColorType;
        internal Label lblBagWeight;
        internal Label lblBagColor;
        internal Label lblBagSize;
        internal Label Label16;
        internal DataGridViewTextBoxColumn BagSizeDataGridViewTextBoxColumn;
        internal Panel Panel1;
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

        internal BindingSource VWInvenotryBagLocationBindingSource;
        internal BindingSource VWBagBindingSource;
        internal Label Label20;
        internal DataGridViewTextBoxColumn LocationNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn BagDescription;
        internal DataGridViewTextBoxColumn ColorTypeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ColorNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn LogoDescription;
        internal Label lblTotalBags;
        internal GroupBox GroupBox2;
        internal Label Label15;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvBagLocations;
        internal DataGridViewTextBoxColumn LocationTag;
        internal DataGridViewTextBoxColumn StorageTypeNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn LocationName;
        internal DataGridViewTextBoxColumn BagQuantityDataGridViewTextBoxColumn;
        private ComboBox _cboCustomerBag;

        internal ComboBox cboCustomerBag
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboCustomerBag;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboCustomerBag != null)
                {
                    _cboCustomerBag.SelectedIndexChanged -= cboBagWeight_SelectedIndexChanged;
                }

                _cboCustomerBag = value;
                if (_cboCustomerBag != null)
                {
                    _cboCustomerBag.SelectedIndexChanged += cboBagWeight_SelectedIndexChanged;
                }
            }
        }

        internal Label Label67;
        private BunifuTextBox _tbBagName;

        internal BunifuTextBox tbBagName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbBagName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbBagName != null)
                {
                    _tbBagName.TextChanged -= cboBagWeight_SelectedIndexChanged;
                }

                _tbBagName = value;
                if (_tbBagName != null)
                {
                    _tbBagName.TextChanged += cboBagWeight_SelectedIndexChanged;
                }
            }
        }

        internal Label Label63;
        internal ComboBox cboBagColor;
        internal Label Label65;
        private ComboBox _cboBagSize;

        internal ComboBox cboBagSize
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboBagSize;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboBagSize != null)
                {
                    _cboBagSize.SelectedIndexChanged -= cboBagWeight_SelectedIndexChanged;
                }

                _cboBagSize = value;
                if (_cboBagSize != null)
                {
                    _cboBagSize.SelectedIndexChanged += cboBagWeight_SelectedIndexChanged;
                }
            }
        }

        internal Label Label66;
    }
}