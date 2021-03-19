using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmGrainInvList : Form
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
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrainInvList));
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Panel1 = new Panel();
            Panel5 = new Panel();
            Panel2 = new Panel();
            Panel6 = new Panel();
            _dgvInventory = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvInventory.SelectionChanged += new EventHandler(dgvInventory_SelectionChanged);
            MiniUnitNumber = new DataGridViewTextBoxColumn();
            GradeCommodityCode = new DataGridViewTextBoxColumn();
            percentagePicture = new DataGridViewImageColumn();
            RemainingQuantity = new DataGridViewTextBoxColumn();
            dgpp = new Panel();
            PictureBox1 = new PictureBox();
            Label21 = new Label();
            _btnNewInventory = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnNewInventory.Click += new EventHandler(btnNewInventory_Click);
            Label1 = new Label();
            GroupBox1 = new GroupBox();
            TableLayoutPanel1 = new TableLayoutPanel();
            _cboUnitNumber = new ComboBox();
            _cboUnitNumber.SelectedIndexChanged += new EventHandler(cboCustomer_SelectedIndexChanged);
            _cboGrade = new ComboBox();
            _cboGrade.SelectedIndexChanged += new EventHandler(cboCustomer_SelectedIndexChanged);
            Label5 = new Label();
            cboCommodity = new ComboBox();
            _cboCustomer = new ComboBox();
            _cboCustomer.SelectedIndexChanged += new EventHandler(cboCustomer_SelectedIndexChanged);
            Label4 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Panel3 = new Panel();
            _dgvDetails = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvDetails.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dgvDetails_RowPostPaint);
            GradeCommodityName = new DataGridViewTextBoxColumn();
            StorageLocation = new DataGridViewTextBoxColumn();
            Label7 = new Label();
            btnActions = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            CustomerNameGrainInvDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            BagWeightNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            VWGrainInventoryBindingSource = new BindingSource(components);
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            QtyInStorageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            StorageTypeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            StorageUnitNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            VWGrainInventoryTransactionBindingSource = new BindingSource(components);
            Panel1.SuspendLayout();
            Panel5.SuspendLayout();
            Panel2.SuspendLayout();
            Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvInventory).BeginInit();
            dgpp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            GroupBox1.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvDetails).BeginInit();
            BunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VWGrainInventoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWGrainInventoryTransactionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Controls.Add(Panel5);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(10, 6);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1481, 902);
            Panel1.TabIndex = 32;
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel5.Controls.Add(Panel2);
            Panel5.Dock = DockStyle.Fill;
            Panel5.Location = new Point(0, 0);
            Panel5.Name = "Panel5";
            Panel5.Padding = new Padding(0, 35, 0, 0);
            Panel5.Size = new Size(1481, 902);
            Panel5.TabIndex = 33;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(Panel6);
            Panel2.Controls.Add(Label21);
            Panel2.Controls.Add(_btnNewInventory);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(GroupBox1);
            Panel2.Controls.Add(Panel3);
            Panel2.Controls.Add(Label7);
            Panel2.Controls.Add(btnActions);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Panel2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel2.Location = new Point(0, 35);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1481, 867);
            Panel2.TabIndex = 0;
            // 
            // Panel6
            // 
            Panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Panel6.BorderStyle = BorderStyle.FixedSingle;
            Panel6.Controls.Add(_dgvInventory);
            Panel6.Controls.Add(dgpp);
            Panel6.Location = new Point(161, 141);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(1145, 301);
            Panel6.TabIndex = 166;
            // 
            // dgvInventory
            // 
            _dgvInventory.AllowCustomTheming = true;
            _dgvInventory.AllowUserToAddRows = false;
            _dgvInventory.AllowUserToDeleteRows = false;
            _dgvInventory.AllowUserToResizeColumns = false;
            _dgvInventory.AllowUserToResizeRows = false;
            DataGridViewCellStyle7.BackColor = Color.White;
            DataGridViewCellStyle7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle7.SelectionBackColor = SystemColors.ButtonFace;
            _dgvInventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7;
            _dgvInventory.AutoGenerateColumns = false;
            _dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvInventory.BackgroundColor = Color.White;
            _dgvInventory.BorderStyle = BorderStyle.None;
            _dgvInventory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle8.BackColor = Color.Silver;
            DataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle8.ForeColor = Color.Black;
            DataGridViewCellStyle8.SelectionBackColor = Color.Silver;
            DataGridViewCellStyle8.SelectionForeColor = Color.Black;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            _dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8;
            _dgvInventory.ColumnHeadersHeight = 35;
            _dgvInventory.Columns.AddRange(new DataGridViewColumn[] { CustomerNameGrainInvDataGridViewTextBoxColumn, MiniUnitNumber, DataGridViewTextBoxColumn1, BagWeightNameDataGridViewTextBoxColumn, DataGridViewTextBoxColumn2, GradeCommodityCode, percentagePicture, RemainingQuantity });
            _dgvInventory.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvInventory.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvInventory.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvInventory.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.Lavender;
            _dgvInventory.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvInventory.CurrentTheme.BackColor = Color.White;
            _dgvInventory.CurrentTheme.GridColor = Color.DarkGray;
            _dgvInventory.CurrentTheme.HeaderStyle.BackColor = Color.Silver;
            _dgvInventory.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _dgvInventory.CurrentTheme.HeaderStyle.ForeColor = Color.Black;
            _dgvInventory.CurrentTheme.Name = null;
            _dgvInventory.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgvInventory.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvInventory.CurrentTheme.RowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvInventory.CurrentTheme.RowsStyle.SelectionBackColor = Color.Lavender;
            _dgvInventory.CurrentTheme.RowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvInventory.DataSource = VWGrainInventoryBindingSource;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle9.BackColor = Color.White;
            DataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle9.SelectionBackColor = Color.Lavender;
            DataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            _dgvInventory.DefaultCellStyle = DataGridViewCellStyle9;
            _dgvInventory.Dock = DockStyle.Fill;
            _dgvInventory.EnableHeadersVisualStyles = false;
            _dgvInventory.GridColor = Color.DarkGray;
            _dgvInventory.HeaderBackColor = Color.Silver;
            _dgvInventory.HeaderBgColor = Color.Empty;
            _dgvInventory.HeaderForeColor = Color.Black;
            _dgvInventory.Location = new Point(0, 0);
            _dgvInventory.MultiSelect = false;
            _dgvInventory.Name = "_dgvInventory";
            _dgvInventory.ReadOnly = true;
            _dgvInventory.RowHeadersVisible = false;
            _dgvInventory.RowHeadersWidth = 32;
            _dgvInventory.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonFace;
            _dgvInventory.RowTemplate.Height = 35;
            _dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvInventory.Size = new Size(1143, 299);
            _dgvInventory.TabIndex = 58;
            _dgvInventory.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // MiniUnitNumber
            // 
            MiniUnitNumber.DataPropertyName = "MiniUnitNumber";
            MiniUnitNumber.HeaderText = "Unit Number";
            MiniUnitNumber.Name = "MiniUnitNumber";
            MiniUnitNumber.ReadOnly = true;
            // 
            // GradeCommodityCode
            // 
            GradeCommodityCode.DataPropertyName = "GradeCommodityCode";
            GradeCommodityCode.FillWeight = 91.93266f;
            GradeCommodityCode.HeaderText = "Commodity";
            GradeCommodityCode.Name = "GradeCommodityCode";
            GradeCommodityCode.ReadOnly = true;
            // 
            // percentagePicture
            // 
            percentagePicture.FillWeight = 86.18293f;
            percentagePicture.HeaderText = "Remaining";
            percentagePicture.Name = "percentagePicture";
            percentagePicture.ReadOnly = true;
            // 
            // RemainingQuantity
            // 
            RemainingQuantity.DataPropertyName = "RemainingQuantity";
            RemainingQuantity.FillWeight = 91.93266f;
            RemainingQuantity.HeaderText = "";
            RemainingQuantity.Name = "RemainingQuantity";
            RemainingQuantity.ReadOnly = true;
            // 
            // dgpp
            // 
            dgpp.BackColor = SystemColors.ControlLight;
            dgpp.Controls.Add(PictureBox1);
            dgpp.Location = new Point(927, 15);
            dgpp.Margin = new Padding(2);
            dgpp.Name = "dgpp";
            dgpp.Size = new Size(112, 14);
            dgpp.TabIndex = 158;
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            PictureBox1.Dock = DockStyle.Left;
            PictureBox1.Location = new Point(0, 0);
            PictureBox1.Margin = new Padding(2);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(63, 14);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // Label21
            // 
            Label21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Label21.AutoSize = true;
            Label21.Font = new Font("Microsoft Sans Serif", 9.5f);
            Label21.Location = new Point(158, 124);
            Label21.Name = "Label21";
            Label21.Size = new Size(213, 16);
            Label21.TabIndex = 165;
            Label21.Text = "* Double click to edit or see details";
            // 
            // btnNewInventory
            // 
            _btnNewInventory.AllowToggling = false;
            _btnNewInventory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnNewInventory.AnimationSpeed = 200;
            _btnNewInventory.AutoGenerateColors = false;
            _btnNewInventory.BackColor = Color.Transparent;
            _btnNewInventory.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnNewInventory.BackgroundImage = (Image)resources.GetObject("btnNewInventory.BackgroundImage");
            _btnNewInventory.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnNewInventory.ButtonText = "New Inventory";
            _btnNewInventory.ButtonTextMarginLeft = 0;
            _btnNewInventory.ColorContrastOnClick = 45;
            _btnNewInventory.ColorContrastOnHover = 45;
            _btnNewInventory.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _btnNewInventory.CustomizableEdges = BorderEdges3;
            _btnNewInventory.DialogResult = DialogResult.None;
            _btnNewInventory.DisabledBorderColor = Color.Empty;
            _btnNewInventory.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnNewInventory.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnNewInventory.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnNewInventory.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnNewInventory.ForeColor = Color.White;
            _btnNewInventory.IconLeftCursor = Cursors.Hand;
            _btnNewInventory.IconMarginLeft = 11;
            _btnNewInventory.IconPadding = 10;
            _btnNewInventory.IconRightCursor = Cursors.Hand;
            _btnNewInventory.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnNewInventory.IdleBorderRadius = 30;
            _btnNewInventory.IdleBorderThickness = 1;
            _btnNewInventory.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnNewInventory.IdleIconLeftImage = null;
            _btnNewInventory.IdleIconRightImage = null;
            _btnNewInventory.IndicateFocus = true;
            _btnNewInventory.Location = new Point(1180, 73);
            _btnNewInventory.Name = "_btnNewInventory";
            StateProperties5.BorderColor = Color.Coral;
            StateProperties5.BorderRadius = 30;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.Coral;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _btnNewInventory.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties6.BorderRadius = 30;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _btnNewInventory.OnPressedState = StateProperties6;
            _btnNewInventory.Size = new Size(123, 35);
            _btnNewInventory.TabIndex = 164;
            _btnNewInventory.TextAlign = ContentAlignment.MiddleCenter;
            _btnNewInventory.TextMarginLeft = 0;
            _btnNewInventory.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label1.Location = new Point(141, 575);
            Label1.Margin = new Padding(2, 0, 2, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(76, 25);
            Label1.TabIndex = 163;
            Label1.Text = "Details:";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(TableLayoutPanel1);
            GroupBox1.Location = new Point(161, 40);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(808, 80);
            GroupBox1.TabIndex = 162;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Filters";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 4;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.35644f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.64356f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 183.0f));
            TableLayoutPanel1.Controls.Add(_cboUnitNumber, 0, 1);
            TableLayoutPanel1.Controls.Add(_cboGrade, 3, 1);
            TableLayoutPanel1.Controls.Add(Label5, 2, 1);
            TableLayoutPanel1.Controls.Add(cboCommodity, 3, 0);
            TableLayoutPanel1.Controls.Add(_cboCustomer, 1, 0);
            TableLayoutPanel1.Controls.Add(Label4, 2, 0);
            TableLayoutPanel1.Controls.Add(Label2, 0, 0);
            TableLayoutPanel1.Controls.Add(Label3, 0, 1);
            TableLayoutPanel1.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel1.Location = new Point(14, 17);
            TableLayoutPanel1.Margin = new Padding(2);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new Size(777, 61);
            TableLayoutPanel1.TabIndex = 158;
            // 
            // cboUnitNumber
            // 
            _cboUnitNumber.AutoCompleteMode = AutoCompleteMode.Suggest;
            _cboUnitNumber.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboUnitNumber.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboUnitNumber.FormattingEnabled = true;
            _cboUnitNumber.Location = new Point(118, 32);
            _cboUnitNumber.Margin = new Padding(2);
            _cboUnitNumber.Name = "_cboUnitNumber";
            _cboUnitNumber.Size = new Size(261, 26);
            _cboUnitNumber.TabIndex = 203;
            // 
            // cboGrade
            // 
            _cboGrade.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboGrade.FormattingEnabled = true;
            _cboGrade.Location = new Point(595, 32);
            _cboGrade.Margin = new Padding(2);
            _cboGrade.Name = "_cboGrade";
            _cboGrade.Size = new Size(105, 24);
            _cboGrade.TabIndex = 198;
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label5.AutoSize = true;
            Label5.Location = new Point(539, 30);
            Label5.Margin = new Padding(2, 0, 2, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(52, 20);
            Label5.TabIndex = 202;
            Label5.Text = "Grade:";
            // 
            // cboCommodity
            // 
            cboCommodity.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboCommodity.FormattingEnabled = true;
            cboCommodity.Location = new Point(595, 2);
            cboCommodity.Margin = new Padding(2);
            cboCommodity.Name = "cboCommodity";
            cboCommodity.Size = new Size(105, 24);
            cboCommodity.TabIndex = 197;
            // 
            // cboCustomer
            // 
            _cboCustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
            _cboCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboCustomer.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboCustomer.FormattingEnabled = true;
            _cboCustomer.Location = new Point(118, 2);
            _cboCustomer.Margin = new Padding(2);
            _cboCustomer.Name = "_cboCustomer";
            _cboCustomer.Size = new Size(319, 26);
            _cboCustomer.TabIndex = 146;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label4.AutoSize = true;
            Label4.Location = new Point(501, 0);
            Label4.Margin = new Padding(2, 0, 2, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(90, 20);
            Label4.TabIndex = 201;
            Label4.Text = "Commodity:";
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label2.AutoSize = true;
            Label2.Location = new Point(39, 0);
            Label2.Margin = new Padding(2, 0, 2, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(75, 20);
            Label2.TabIndex = 199;
            Label2.Text = "Customer:";
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label3.AutoSize = true;
            Label3.Location = new Point(17, 30);
            Label3.Margin = new Padding(2, 0, 2, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(97, 20);
            Label3.TabIndex = 200;
            Label3.Text = "Unit Number:";
            // 
            // Panel3
            // 
            Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(_dgvDetails);
            Panel3.Location = new Point(161, 602);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1143, 215);
            Panel3.TabIndex = 161;
            // 
            // dgvDetails
            // 
            _dgvDetails.AllowCustomTheming = true;
            _dgvDetails.AllowUserToAddRows = false;
            _dgvDetails.AllowUserToDeleteRows = false;
            _dgvDetails.AllowUserToResizeColumns = false;
            _dgvDetails.AllowUserToResizeRows = false;
            DataGridViewCellStyle10.BackColor = Color.White;
            DataGridViewCellStyle10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle10.SelectionBackColor = SystemColors.ButtonFace;
            _dgvDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10;
            _dgvDetails.AutoGenerateColumns = false;
            _dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvDetails.BackgroundColor = Color.White;
            _dgvDetails.BorderStyle = BorderStyle.None;
            _dgvDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle11.BackColor = Color.Silver;
            DataGridViewCellStyle11.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle11.ForeColor = Color.Black;
            DataGridViewCellStyle11.SelectionBackColor = Color.Silver;
            DataGridViewCellStyle11.SelectionForeColor = Color.Black;
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            _dgvDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11;
            _dgvDetails.ColumnHeadersHeight = 35;
            _dgvDetails.Columns.AddRange(new DataGridViewColumn[] { GradeCommodityName, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, QtyInStorageDataGridViewTextBoxColumn, StorageTypeNameDataGridViewTextBoxColumn, StorageLocation, StorageUnitNumberDataGridViewTextBoxColumn });
            _dgvDetails.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvDetails.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvDetails.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvDetails.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.Lavender;
            _dgvDetails.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvDetails.CurrentTheme.BackColor = Color.White;
            _dgvDetails.CurrentTheme.GridColor = Color.DarkGray;
            _dgvDetails.CurrentTheme.HeaderStyle.BackColor = Color.Silver;
            _dgvDetails.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _dgvDetails.CurrentTheme.HeaderStyle.ForeColor = Color.Black;
            _dgvDetails.CurrentTheme.Name = null;
            _dgvDetails.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgvDetails.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvDetails.CurrentTheme.RowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvDetails.CurrentTheme.RowsStyle.SelectionBackColor = Color.Lavender;
            _dgvDetails.CurrentTheme.RowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvDetails.DataSource = VWGrainInventoryTransactionBindingSource;
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle12.BackColor = Color.White;
            DataGridViewCellStyle12.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle12.SelectionBackColor = Color.Lavender;
            DataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            _dgvDetails.DefaultCellStyle = DataGridViewCellStyle12;
            _dgvDetails.Dock = DockStyle.Top;
            _dgvDetails.EnableHeadersVisualStyles = false;
            _dgvDetails.GridColor = Color.DarkGray;
            _dgvDetails.HeaderBackColor = Color.Silver;
            _dgvDetails.HeaderBgColor = Color.Empty;
            _dgvDetails.HeaderForeColor = Color.Black;
            _dgvDetails.Location = new Point(0, 0);
            _dgvDetails.MultiSelect = false;
            _dgvDetails.Name = "_dgvDetails";
            _dgvDetails.ReadOnly = true;
            _dgvDetails.RowHeadersVisible = false;
            _dgvDetails.RowHeadersWidth = 32;
            _dgvDetails.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonFace;
            _dgvDetails.RowTemplate.Height = 35;
            _dgvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvDetails.Size = new Size(1141, 210);
            _dgvDetails.TabIndex = 58;
            _dgvDetails.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // GradeCommodityName
            // 
            GradeCommodityName.DataPropertyName = "GradeCommodityName";
            GradeCommodityName.FillWeight = 121.8274f;
            GradeCommodityName.HeaderText = "Grade/Commodity";
            GradeCommodityName.Name = "GradeCommodityName";
            GradeCommodityName.ReadOnly = true;
            // 
            // StorageLocation
            // 
            StorageLocation.DataPropertyName = "StorageLocation";
            StorageLocation.FillWeight = 96.8818f;
            StorageLocation.HeaderText = "Storage Location";
            StorageLocation.Name = "StorageLocation";
            StorageLocation.ReadOnly = true;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label7.Location = new Point(141, 14);
            Label7.Margin = new Padding(2, 0, 2, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(147, 25);
            Label7.TabIndex = 160;
            Label7.Text = "Grain Inventory";
            // 
            // btnActions
            // 
            btnActions.AllowToggling = false;
            btnActions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActions.AnimationSpeed = 200;
            btnActions.AutoGenerateColors = false;
            btnActions.BackColor = Color.Transparent;
            btnActions.BackColor1 = Color.White;
            btnActions.BackgroundImage = (Image)resources.GetObject("btnActions.BackgroundImage");
            btnActions.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnActions.ButtonText = "";
            btnActions.ButtonTextMarginLeft = -10;
            btnActions.ColorContrastOnClick = 45;
            btnActions.ColorContrastOnHover = 45;
            btnActions.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            btnActions.CustomizableEdges = BorderEdges4;
            btnActions.DialogResult = DialogResult.None;
            btnActions.DisabledBorderColor = Color.Empty;
            btnActions.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            btnActions.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            btnActions.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnActions.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold);
            btnActions.ForeColor = Color.White;
            btnActions.IconLeftCursor = Cursors.Hand;
            btnActions.IconMarginLeft = 11;
            btnActions.IconPadding = 7;
            btnActions.IconRightCursor = Cursors.Hand;
            btnActions.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            btnActions.IdleBorderRadius = 30;
            btnActions.IdleBorderThickness = 1;
            btnActions.IdleFillColor = Color.White;
            btnActions.IdleIconLeftImage = My.Resources.Resources.settings;
            btnActions.IdleIconRightImage = My.Resources.Resources.dropDownMenuDark1;
            btnActions.IndicateFocus = true;
            btnActions.Location = new Point(1247, 4);
            btnActions.Name = "btnActions";
            StateProperties7.BorderColor = Color.MediumTurquoise;
            StateProperties7.BorderRadius = 30;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.MediumTurquoise;
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            btnActions.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Teal;
            StateProperties8.BorderRadius = 30;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.Teal;
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            btnActions.OnPressedState = StateProperties8;
            btnActions.Size = new Size(58, 32);
            btnActions.TabIndex = 159;
            btnActions.TextAlign = ContentAlignment.MiddleCenter;
            btnActions.TextMarginLeft = -10;
            btnActions.UseDefaultRadiusAndThickness = true;
            btnActions.Visible = false;
            // 
            // BunifuShadowPanel1
            // 
            BunifuShadowPanel1.BackColor = Color.White;
            BunifuShadowPanel1.BorderColor = Color.Transparent;
            BunifuShadowPanel1.Controls.Add(Panel1);
            BunifuShadowPanel1.Dock = DockStyle.Fill;
            BunifuShadowPanel1.ForeColor = Color.White;
            BunifuShadowPanel1.Location = new Point(0, 0);
            BunifuShadowPanel1.Margin = new Padding(0);
            BunifuShadowPanel1.Name = "BunifuShadowPanel1";
            BunifuShadowPanel1.Padding = new Padding(10, 6, 5, 5);
            BunifuShadowPanel1.PanelColor = Color.Empty;
            BunifuShadowPanel1.ShadowDept = 2;
            BunifuShadowPanel1.ShadowTopLeftVisible = true;
            BunifuShadowPanel1.Size = new Size(1496, 913);
            BunifuShadowPanel1.TabIndex = 5;
            // 
            // CustomerNameGrainInvDataGridViewTextBoxColumn
            // 
            CustomerNameGrainInvDataGridViewTextBoxColumn.DataPropertyName = "CustomerNameGrainInv";
            CustomerNameGrainInvDataGridViewTextBoxColumn.FillWeight = 152.5389f;
            CustomerNameGrainInvDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            CustomerNameGrainInvDataGridViewTextBoxColumn.Name = "CustomerNameGrainInvDataGridViewTextBoxColumn";
            CustomerNameGrainInvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "BagSizeName";
            DataGridViewTextBoxColumn1.FillWeight = 91.93266f;
            DataGridViewTextBoxColumn1.HeaderText = "Bag Size";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // BagWeightNameDataGridViewTextBoxColumn
            // 
            BagWeightNameDataGridViewTextBoxColumn.DataPropertyName = "BagWeightName";
            BagWeightNameDataGridViewTextBoxColumn.FillWeight = 91.93266f;
            BagWeightNameDataGridViewTextBoxColumn.HeaderText = "Bag Weight";
            BagWeightNameDataGridViewTextBoxColumn.Name = "BagWeightNameDataGridViewTextBoxColumn";
            BagWeightNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.DataPropertyName = "InitialQuantity";
            DataGridViewTextBoxColumn2.FillWeight = 91.93266f;
            DataGridViewTextBoxColumn2.HeaderText = "Initial Quantity";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // VWGrainInventoryBindingSource
            // 
            VWGrainInventoryBindingSource.DataSource = typeof(ModelLayer.VW_GrainInventory);
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.DataPropertyName = "TransactionType";
            DataGridViewTextBoxColumn3.FillWeight = 96.8818f;
            DataGridViewTextBoxColumn3.HeaderText = "Transaction Type";
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            DataGridViewTextBoxColumn4.FillWeight = 96.8818f;
            DataGridViewTextBoxColumn4.HeaderText = "Quantity";
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewTextBoxColumn5.DataPropertyName = "CreatedAt";
            DataGridViewTextBoxColumn5.FillWeight = 96.8818f;
            DataGridViewTextBoxColumn5.HeaderText = "CreatedAt";
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // QtyInStorageDataGridViewTextBoxColumn
            // 
            QtyInStorageDataGridViewTextBoxColumn.DataPropertyName = "QtyInStorage";
            QtyInStorageDataGridViewTextBoxColumn.FillWeight = 96.8818f;
            QtyInStorageDataGridViewTextBoxColumn.HeaderText = "QtyInStorage";
            QtyInStorageDataGridViewTextBoxColumn.Name = "QtyInStorageDataGridViewTextBoxColumn";
            QtyInStorageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StorageTypeNameDataGridViewTextBoxColumn
            // 
            StorageTypeNameDataGridViewTextBoxColumn.DataPropertyName = "StorageTypeName";
            StorageTypeNameDataGridViewTextBoxColumn.FillWeight = 96.8818f;
            StorageTypeNameDataGridViewTextBoxColumn.HeaderText = "StorageTypeName";
            StorageTypeNameDataGridViewTextBoxColumn.Name = "StorageTypeNameDataGridViewTextBoxColumn";
            StorageTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StorageUnitNumberDataGridViewTextBoxColumn
            // 
            StorageUnitNumberDataGridViewTextBoxColumn.DataPropertyName = "StorageUnitNumber";
            StorageUnitNumberDataGridViewTextBoxColumn.FillWeight = 96.8818f;
            StorageUnitNumberDataGridViewTextBoxColumn.HeaderText = "StorageUnitNumber";
            StorageUnitNumberDataGridViewTextBoxColumn.Name = "StorageUnitNumberDataGridViewTextBoxColumn";
            StorageUnitNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VWGrainInventoryTransactionBindingSource
            // 
            VWGrainInventoryTransactionBindingSource.DataSource = typeof(ModelLayer.VW_GrainInventoryTransaction);
            // 
            // FrmGrainInvList
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1496, 913);
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGrainInvList";
            Text = "FrmGrainInvList";
            Panel1.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvInventory).EndInit();
            dgpp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            GroupBox1.ResumeLayout(false);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvDetails).EndInit();
            BunifuShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VWGrainInventoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWGrainInventoryTransactionBindingSource).EndInit();
            Load += new EventHandler(FrmGrainInvList_Load);
            ResumeLayout(false);
        }

        internal Panel Panel1;
        internal Panel Panel5;
        internal Panel Panel2;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel6;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvInventory;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvInventory
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvInventory;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvInventory != null)
                {
                    _dgvInventory.SelectionChanged -= dgvInventory_SelectionChanged;
                }

                _dgvInventory = value;
                if (_dgvInventory != null)
                {
                    _dgvInventory.SelectionChanged += dgvInventory_SelectionChanged;
                }
            }
        }

        internal Label Label21;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnNewInventory;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNewInventory
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnNewInventory;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnNewInventory != null)
                {
                    _btnNewInventory.Click -= btnNewInventory_Click;
                }

                _btnNewInventory = value;
                if (_btnNewInventory != null)
                {
                    _btnNewInventory.Click += btnNewInventory_Click;
                }
            }
        }

        internal Label Label1;
        internal GroupBox GroupBox1;
        internal TableLayoutPanel TableLayoutPanel1;
        private ComboBox _cboUnitNumber;

        internal ComboBox cboUnitNumber
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboUnitNumber;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboUnitNumber != null)
                {
                    _cboUnitNumber.SelectedIndexChanged -= cboCustomer_SelectedIndexChanged;
                }

                _cboUnitNumber = value;
                if (_cboUnitNumber != null)
                {
                    _cboUnitNumber.SelectedIndexChanged += cboCustomer_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _cboGrade;

        internal ComboBox cboGrade
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboGrade;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboGrade != null)
                {
                    _cboGrade.SelectedIndexChanged -= cboCustomer_SelectedIndexChanged;
                }

                _cboGrade = value;
                if (_cboGrade != null)
                {
                    _cboGrade.SelectedIndexChanged += cboCustomer_SelectedIndexChanged;
                }
            }
        }

        internal Label Label5;
        internal ComboBox cboCommodity;
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

        internal Label Label4;
        internal Label Label2;
        internal Label Label3;
        internal Panel Panel3;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvDetails;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvDetails
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvDetails;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvDetails != null)
                {
                    _dgvDetails.RowPostPaint -= dgvDetails_RowPostPaint;
                }

                _dgvDetails = value;
                if (_dgvDetails != null)
                {
                    _dgvDetails.RowPostPaint += dgvDetails_RowPostPaint;
                }
            }
        }

        internal Label Label7;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnActions;
        public Panel dgpp;
        internal PictureBox PictureBox1;
        internal DataGridViewTextBoxColumn CustomerNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn BagSizeNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CommodityCodeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn GradeCodeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn InitialQuantityDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn RemainingQuantityDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn TransactionTypeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CreatedAtDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn QuantityDataGridViewTextBoxColumn;
        internal BindingSource VWGrainInventoryBindingSource;
        internal BindingSource VWGrainInventoryTransactionBindingSource;
        internal DataGridViewTextBoxColumn CustomerNameGrainInvDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn MiniUnitNumber;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn BagWeightNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn GradeCommodityCode;
        internal DataGridViewImageColumn percentagePicture;
        internal DataGridViewTextBoxColumn RemainingQuantity;
        internal DataGridViewTextBoxColumn GradeCommodityName;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn QtyInStorageDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn StorageTypeNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn StorageLocation;
        internal DataGridViewTextBoxColumn StorageUnitNumberDataGridViewTextBoxColumn;
    }
}