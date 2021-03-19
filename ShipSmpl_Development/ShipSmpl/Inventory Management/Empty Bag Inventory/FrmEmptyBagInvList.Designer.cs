using System;
using System.Diagnostics;
using System.Drawing; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmEmptyBagInvList : Form
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
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmptyBagInvList));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            dgpp = new Panel();
            PictureBox1 = new PictureBox();
            BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            btnActions = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            Label7 = new Label();
            Panel2 = new Panel();
            Panel6 = new Panel();
            _dgvInventory = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvInventory.SelectionChanged += new EventHandler(dgv_SelectionChanged);
            _dgvInventory.CellContentDoubleClick += new DataGridViewCellEventHandler(dgv_DoubleClick);
            _dgvInventory.CellContentClick += new DataGridViewCellEventHandler(dgvInventory_CellContentClick);
            _dgvInventory.RowsAdded += new DataGridViewRowsAddedEventHandler(dgvInventory_RowsAdded);
            CustomerName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            TotalQuantity = new DataGridViewTextBoxColumn();
            percentagePicture = new DataGridViewImageColumn();
            Remaining = new DataGridViewTextBoxColumn();
            btnEditQtyCol = new DataGridViewButtonColumn();
            VWBagInventoryBindingSource = new BindingSource(components);
            Label21 = new Label();
            _btnNewInventory = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnNewInventory.Click += new EventHandler(btnNewInventory_Click);
            Label1 = new Label();
            GroupBox1 = new GroupBox();
            TableLayoutPanel1 = new TableLayoutPanel();
            _cboBagColor = new ComboBox();
            _cboBagColor.SelectedIndexChanged += new EventHandler(cboCustomer_SelectedIndexChanged);
            Label5 = new Label();
            _cboBagSize = new ComboBox();
            _cboBagSize.SelectedIndexChanged += new EventHandler(cboCustomer_SelectedIndexChanged);
            _cboCustomer = new ComboBox();
            _cboCustomer.SelectedIndexChanged += new EventHandler(cboCustomer_SelectedIndexChanged);
            Label4 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            tbBagName = new BunifuTextBox();
            Panel3 = new Panel();
            btnEditTransaction = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _dgvDetails = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvDetails.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dgvDetails_RowPostPaint);
            BagDescriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            BagSizeName = new DataGridViewTextBoxColumn();
            BagWeightName = new DataGridViewTextBoxColumn();
            BagUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ColorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TransactionType = new DataGridViewTextBoxColumn();
            TransactionQuantity = new DataGridViewTextBoxColumn();
            TransactionDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LocationName = new DataGridViewTextBoxColumn();
            YardLocationName = new DataGridViewTextBoxColumn();
            BagQuantity = new DataGridViewTextBoxColumn();
            VWBagInventoryTransactionBindingSource = new BindingSource(components);
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel1 = new Panel();
            Panel5 = new Panel();
            dgpp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            Panel2.SuspendLayout();
            Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWBagInventoryBindingSource).BeginInit();
            GroupBox1.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWBagInventoryTransactionBindingSource).BeginInit();
            BunifuShadowPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            Panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgpp
            // 
            dgpp.BackColor = SystemColors.ControlLight;
            dgpp.Controls.Add(PictureBox1);
            dgpp.Location = new Point(1059, 170);
            dgpp.Margin = new Padding(2, 2, 2, 2);
            dgpp.Name = "dgpp";
            dgpp.Size = new Size(112, 14);
            dgpp.TabIndex = 1;
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            PictureBox1.Dock = DockStyle.Left;
            PictureBox1.Location = new Point(0, 0);
            PictureBox1.Margin = new Padding(2, 2, 2, 2);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(63, 14);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // BunifuElipse1
            // 
            BunifuElipse1.ElipseRadius = 8;
            BunifuElipse1.TargetControl = this;
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
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            btnActions.CustomizableEdges = BorderEdges3;
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
            btnActions.Location = new Point(1162, 30);
            btnActions.Name = "btnActions";
            StateProperties9.BorderColor = Color.MediumTurquoise;
            StateProperties9.BorderRadius = 30;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.MediumTurquoise;
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            btnActions.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.Teal;
            StateProperties10.BorderRadius = 30;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.Teal;
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            btnActions.OnPressedState = StateProperties10;
            btnActions.Size = new Size(58, 32);
            btnActions.TabIndex = 138;
            btnActions.TextAlign = ContentAlignment.MiddleCenter;
            btnActions.TextMarginLeft = -10;
            btnActions.UseDefaultRadiusAndThickness = true;
            btnActions.Visible = false;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label7.Location = new Point(56, 15);
            Label7.Margin = new Padding(2, 0, 2, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(193, 25);
            Label7.TabIndex = 139;
            Label7.Text = "Empty Bag Inventory";
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
            Panel2.Controls.Add(dgpp);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Font = new Font("Microsoft Sans Serif", 11.0f);
            Panel2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel2.Location = new Point(0, 35);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1295, 906);
            Panel2.TabIndex = 0;
            // 
            // Panel6
            // 
            Panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Panel6.BorderStyle = BorderStyle.FixedSingle;
            Panel6.Controls.Add(_dgvInventory);
            Panel6.Location = new Point(76, 167);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(1145, 326);
            Panel6.TabIndex = 157;
            // 
            // dgvInventory
            // 
            _dgvInventory.AllowCustomTheming = true;
            _dgvInventory.AllowUserToAddRows = false;
            _dgvInventory.AllowUserToDeleteRows = false;
            _dgvInventory.AllowUserToResizeColumns = false;
            _dgvInventory.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            _dgvInventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvInventory.AutoGenerateColumns = false;
            _dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvInventory.BackgroundColor = Color.White;
            _dgvInventory.BorderStyle = BorderStyle.None;
            _dgvInventory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.Silver;
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle2.ForeColor = Color.Black;
            DataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            DataGridViewCellStyle2.SelectionForeColor = Color.Black;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvInventory.ColumnHeadersHeight = 35;
            _dgvInventory.Columns.AddRange(new DataGridViewColumn[] { CustomerName, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn8, TotalQuantity, percentagePicture, Remaining, btnEditQtyCol });
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
            _dgvInventory.DataSource = VWBagInventoryBindingSource;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle4.SelectionBackColor = Color.Lavender;
            DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            _dgvInventory.DefaultCellStyle = DataGridViewCellStyle4;
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
            _dgvInventory.Size = new Size(1143, 324);
            _dgvInventory.TabIndex = 58;
            _dgvInventory.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // CustomerName
            // 
            CustomerName.DataPropertyName = "CustomerName";
            CustomerName.FillWeight = 199.0734f;
            CustomerName.HeaderText = "Customer Name";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.DataPropertyName = "BagDescription";
            DataGridViewTextBoxColumn2.FillWeight = 226.8385f;
            DataGridViewTextBoxColumn2.HeaderText = "Bag Description";
            DataGridViewTextBoxColumn2.MinimumWidth = 6;
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewTextBoxColumn6.DataPropertyName = "BagSizeName";
            DataGridViewTextBoxColumn6.FillWeight = 57.24067f;
            DataGridViewTextBoxColumn6.HeaderText = "Bag Size";
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            DataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn7
            // 
            DataGridViewTextBoxColumn7.DataPropertyName = "BagWeightName";
            DataGridViewTextBoxColumn7.FillWeight = 76.12813f;
            DataGridViewTextBoxColumn7.HeaderText = "Bag Weight";
            DataGridViewTextBoxColumn7.MinimumWidth = 6;
            DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            DataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn8
            // 
            DataGridViewTextBoxColumn8.DataPropertyName = "BagUnit";
            DataGridViewTextBoxColumn8.FillWeight = 55.96835f;
            DataGridViewTextBoxColumn8.HeaderText = "BagUnit";
            DataGridViewTextBoxColumn8.MinimumWidth = 6;
            DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            DataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // TotalQuantity
            // 
            TotalQuantity.DataPropertyName = "TotalQuantity";
            TotalQuantity.FillWeight = 86.43018f;
            TotalQuantity.HeaderText = "Initial Quantity";
            TotalQuantity.Name = "TotalQuantity";
            TotalQuantity.ReadOnly = true;
            // 
            // percentagePicture
            // 
            percentagePicture.FillWeight = 80.59641f;
            percentagePicture.HeaderText = "Remaining";
            percentagePicture.Name = "percentagePicture";
            percentagePicture.ReadOnly = true;
            // 
            // Remaining
            // 
            Remaining.DataPropertyName = "Remaining";
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Remaining.DefaultCellStyle = DataGridViewCellStyle3;
            Remaining.FillWeight = 68.52792f;
            Remaining.HeaderText = "";
            Remaining.Name = "Remaining";
            Remaining.ReadOnly = true;
            // 
            // btnEditQtyCol
            // 
            btnEditQtyCol.FillWeight = 49.19656f;
            btnEditQtyCol.FlatStyle = FlatStyle.Popup;
            btnEditQtyCol.HeaderText = "";
            btnEditQtyCol.Name = "btnEditQtyCol";
            btnEditQtyCol.ReadOnly = true;
            btnEditQtyCol.Text = "Adjust";
            // 
            // VWBagInventoryBindingSource
            // 
            VWBagInventoryBindingSource.DataSource = typeof(ModelLayer.VW_BagInventory);
            // 
            // Label21
            // 
            Label21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Label21.AutoSize = true;
            Label21.Font = new Font("Microsoft Sans Serif", 9.5f);
            Label21.Location = new Point(73, 150);
            Label21.Name = "Label21";
            Label21.Size = new Size(213, 16);
            Label21.TabIndex = 156;
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
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnNewInventory.CustomizableEdges = BorderEdges1;
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
            _btnNewInventory.Location = new Point(1095, 99);
            _btnNewInventory.Name = "_btnNewInventory";
            StateProperties1.BorderColor = Color.Coral;
            StateProperties1.BorderRadius = 30;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.Coral;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnNewInventory.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties2.BorderRadius = 30;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnNewInventory.OnPressedState = StateProperties2;
            _btnNewInventory.Size = new Size(123, 35);
            _btnNewInventory.TabIndex = 155;
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
            Label1.Location = new Point(56, 612);
            Label1.Margin = new Padding(2, 0, 2, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(76, 25);
            Label1.TabIndex = 154;
            Label1.Text = "Details:";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(TableLayoutPanel1);
            GroupBox1.Location = new Point(76, 66);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(808, 80);
            GroupBox1.TabIndex = 153;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Filters";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 4;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.16749f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.83251f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156.0f));
            TableLayoutPanel1.Controls.Add(_cboBagColor, 3, 1);
            TableLayoutPanel1.Controls.Add(Label5, 2, 1);
            TableLayoutPanel1.Controls.Add(_cboBagSize, 3, 0);
            TableLayoutPanel1.Controls.Add(_cboCustomer, 1, 0);
            TableLayoutPanel1.Controls.Add(Label4, 2, 0);
            TableLayoutPanel1.Controls.Add(Label2, 0, 0);
            TableLayoutPanel1.Controls.Add(Label3, 0, 1);
            TableLayoutPanel1.Controls.Add(tbBagName, 1, 1);
            TableLayoutPanel1.Location = new Point(14, 17);
            TableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new Size(716, 61);
            TableLayoutPanel1.TabIndex = 158;
            // 
            // cboBagColor
            // 
            _cboBagColor.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboBagColor.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboBagColor.FormattingEnabled = true;
            _cboBagColor.Location = new Point(561, 32);
            _cboBagColor.Margin = new Padding(2);
            _cboBagColor.Name = "_cboBagColor";
            _cboBagColor.Size = new Size(105, 24);
            _cboBagColor.TabIndex = 198;
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label5.AutoSize = true;
            Label5.Location = new Point(478, 30);
            Label5.Margin = new Padding(2, 0, 2, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(79, 18);
            Label5.TabIndex = 202;
            Label5.Text = "Bag Color:";
            // 
            // cboBagSize
            // 
            _cboBagSize.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboBagSize.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboBagSize.FormattingEnabled = true;
            _cboBagSize.Location = new Point(561, 2);
            _cboBagSize.Margin = new Padding(2);
            _cboBagSize.Name = "_cboBagSize";
            _cboBagSize.Size = new Size(92, 24);
            _cboBagSize.TabIndex = 197;
            // 
            // cboCustomer
            // 
            _cboCustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
            _cboCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboCustomer.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboCustomer.FormattingEnabled = true;
            _cboCustomer.Location = new Point(94, 2);
            _cboCustomer.Margin = new Padding(2, 2, 2, 2);
            _cboCustomer.Name = "_cboCustomer";
            _cboCustomer.Size = new Size(319, 26);
            _cboCustomer.TabIndex = 146;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label4.AutoSize = true;
            Label4.Location = new Point(486, 0);
            Label4.Margin = new Padding(2, 0, 2, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(71, 18);
            Label4.TabIndex = 201;
            Label4.Text = "Bag Size:";
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label2.AutoSize = true;
            Label2.Location = new Point(12, 0);
            Label2.Margin = new Padding(2, 0, 2, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(78, 18);
            Label2.TabIndex = 199;
            Label2.Text = "Customer:";
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label3.AutoSize = true;
            Label3.Location = new Point(3, 30);
            Label3.Margin = new Padding(2, 0, 2, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(87, 31);
            Label3.TabIndex = 200;
            Label3.Text = "Bag Description:";
            // 
            // tbBagName
            // 
            tbBagName.AcceptsReturn = false;
            tbBagName.AcceptsTab = false;
            tbBagName.AnimationSpeed = 200;
            tbBagName.AutoCompleteMode = AutoCompleteMode.None;
            tbBagName.AutoCompleteSource = AutoCompleteSource.None;
            tbBagName.BackColor = Color.Transparent;
            tbBagName.BackgroundImage = (Image)resources.GetObject("tbBagName.BackgroundImage");
            tbBagName.BorderColorActive = Color.DodgerBlue;
            tbBagName.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            tbBagName.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            tbBagName.BorderColorIdle = Color.Silver;
            tbBagName.BorderRadius = 1;
            tbBagName.BorderThickness = 1;
            tbBagName.CharacterCasing = CharacterCasing.Normal;
            tbBagName.Cursor = Cursors.IBeam;
            tbBagName.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            tbBagName.DefaultText = "";
            tbBagName.FillColor = Color.White;
            tbBagName.HideSelection = true;
            tbBagName.IconLeft = null;
            tbBagName.IconLeftCursor = Cursors.IBeam;
            tbBagName.IconPadding = 10;
            tbBagName.IconRight = null;
            tbBagName.IconRightCursor = Cursors.IBeam;
            tbBagName.Lines = new string[0];
            tbBagName.Location = new Point(95, 32);
            tbBagName.Margin = new Padding(3, 2, 3, 2);
            tbBagName.MaxLength = 32767;
            tbBagName.MinimumSize = new Size(116, 25);
            tbBagName.Modified = false;
            tbBagName.Multiline = false;
            tbBagName.Name = "tbBagName";
            StateProperties3.BorderColor = Color.DodgerBlue;
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            tbBagName.OnActiveState = StateProperties3;
            StateProperties4.BorderColor = Color.Empty;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Empty;
            StateProperties4.PlaceholderForeColor = Color.Silver;
            tbBagName.OnDisabledState = StateProperties4;
            StateProperties5.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            tbBagName.OnHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Silver;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Empty;
            tbBagName.OnIdleState = StateProperties6;
            tbBagName.PasswordChar = '\0';
            tbBagName.PlaceholderForeColor = Color.Silver;
            tbBagName.PlaceholderText = "";
            tbBagName.ReadOnly = false;
            tbBagName.ScrollBars = ScrollBars.None;
            tbBagName.SelectedText = "";
            tbBagName.SelectionLength = 0;
            tbBagName.SelectionStart = 0;
            tbBagName.ShortcutsEnabled = true;
            tbBagName.Size = new Size(317, 25);
            tbBagName.Style = _Style.Bunifu;
            tbBagName.TabIndex = 190;
            tbBagName.TextAlign = HorizontalAlignment.Left;
            tbBagName.TextMarginBottom = 0;
            tbBagName.TextMarginLeft = 5;
            tbBagName.TextMarginTop = 0;
            tbBagName.TextPlaceholder = "";
            tbBagName.UseSystemPasswordChar = false;
            tbBagName.WordWrap = true;
            // 
            // Panel3
            // 
            Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(btnEditTransaction);
            Panel3.Controls.Add(_dgvDetails);
            Panel3.Location = new Point(76, 639);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1143, 215);
            Panel3.TabIndex = 140;
            // 
            // btnEditTransaction
            // 
            btnEditTransaction.AllowToggling = false;
            btnEditTransaction.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditTransaction.AnimationSpeed = 200;
            btnEditTransaction.AutoGenerateColors = false;
            btnEditTransaction.BackColor = Color.Transparent;
            btnEditTransaction.BackColor1 = Color.Teal;
            btnEditTransaction.BackgroundImage = (Image)resources.GetObject("btnEditTransaction.BackgroundImage");
            btnEditTransaction.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnEditTransaction.ButtonText = "Edit";
            btnEditTransaction.ButtonTextMarginLeft = 0;
            btnEditTransaction.ColorContrastOnClick = 45;
            btnEditTransaction.ColorContrastOnHover = 45;
            btnEditTransaction.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            btnEditTransaction.CustomizableEdges = BorderEdges2;
            btnEditTransaction.DialogResult = DialogResult.None;
            btnEditTransaction.DisabledBorderColor = Color.Empty;
            btnEditTransaction.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            btnEditTransaction.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            btnEditTransaction.Enabled = false;
            btnEditTransaction.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnEditTransaction.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            btnEditTransaction.ForeColor = Color.White;
            btnEditTransaction.IconLeftCursor = Cursors.Hand;
            btnEditTransaction.IconMarginLeft = 11;
            btnEditTransaction.IconPadding = 10;
            btnEditTransaction.IconRightCursor = Cursors.Hand;
            btnEditTransaction.IdleBorderColor = Color.Teal;
            btnEditTransaction.IdleBorderRadius = 3;
            btnEditTransaction.IdleBorderThickness = 1;
            btnEditTransaction.IdleFillColor = Color.Teal;
            btnEditTransaction.IdleIconLeftImage = null;
            btnEditTransaction.IdleIconRightImage = null;
            btnEditTransaction.IndicateFocus = true;
            btnEditTransaction.Location = new Point(1068, 187);
            btnEditTransaction.Name = "btnEditTransaction";
            StateProperties7.BorderColor = Color.MediumTurquoise;
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.MediumTurquoise;
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            btnEditTransaction.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Teal;
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.Teal;
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            btnEditTransaction.OnPressedState = StateProperties8;
            btnEditTransaction.Size = new Size(73, 28);
            btnEditTransaction.TabIndex = 157;
            btnEditTransaction.TextAlign = ContentAlignment.MiddleCenter;
            btnEditTransaction.TextMarginLeft = 0;
            btnEditTransaction.UseDefaultRadiusAndThickness = true;
            // 
            // dgvDetails
            // 
            _dgvDetails.AllowCustomTheming = true;
            _dgvDetails.AllowUserToAddRows = false;
            _dgvDetails.AllowUserToDeleteRows = false;
            _dgvDetails.AllowUserToResizeColumns = false;
            _dgvDetails.AllowUserToResizeRows = false;
            DataGridViewCellStyle5.BackColor = Color.White;
            DataGridViewCellStyle5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.SelectionBackColor = SystemColors.ButtonFace;
            _dgvDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5;
            _dgvDetails.AutoGenerateColumns = false;
            _dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvDetails.BackgroundColor = Color.White;
            _dgvDetails.BorderStyle = BorderStyle.None;
            _dgvDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.Silver;
            DataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle6.ForeColor = Color.Black;
            DataGridViewCellStyle6.SelectionBackColor = Color.Silver;
            DataGridViewCellStyle6.SelectionForeColor = Color.Black;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            _dgvDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6;
            _dgvDetails.ColumnHeadersHeight = 35;
            _dgvDetails.Columns.AddRange(new DataGridViewColumn[] { BagDescriptionDataGridViewTextBoxColumn1, BagSizeName, BagWeightName, BagUnitDataGridViewTextBoxColumn, DataGridViewTextBoxColumn1, ColorNameDataGridViewTextBoxColumn, TransactionType, TransactionQuantity, TransactionDateDataGridViewTextBoxColumn, LocationName, YardLocationName, BagQuantity });
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
            _dgvDetails.DataSource = VWBagInventoryTransactionBindingSource;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle9.BackColor = Color.White;
            DataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle9.SelectionBackColor = Color.Lavender;
            DataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            _dgvDetails.DefaultCellStyle = DataGridViewCellStyle9;
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
            // BagDescriptionDataGridViewTextBoxColumn1
            // 
            BagDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "BagDescription";
            BagDescriptionDataGridViewTextBoxColumn1.FillWeight = 169.8178f;
            BagDescriptionDataGridViewTextBoxColumn1.HeaderText = "Bag Description";
            BagDescriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            BagDescriptionDataGridViewTextBoxColumn1.Name = "BagDescriptionDataGridViewTextBoxColumn1";
            BagDescriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // BagSizeName
            // 
            BagSizeName.DataPropertyName = "BagSizeName";
            BagSizeName.FillWeight = 98.89297f;
            BagSizeName.HeaderText = "Bag Size";
            BagSizeName.Name = "BagSizeName";
            BagSizeName.ReadOnly = true;
            // 
            // BagWeightName
            // 
            BagWeightName.DataPropertyName = "BagWeightName";
            BagWeightName.FillWeight = 98.89297f;
            BagWeightName.HeaderText = "Bag Weight";
            BagWeightName.MinimumWidth = 6;
            BagWeightName.Name = "BagWeightName";
            BagWeightName.ReadOnly = true;
            // 
            // BagUnitDataGridViewTextBoxColumn
            // 
            BagUnitDataGridViewTextBoxColumn.DataPropertyName = "BagUnit";
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            BagUnitDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7;
            BagUnitDataGridViewTextBoxColumn.FillWeight = 55.28215f;
            BagUnitDataGridViewTextBoxColumn.HeaderText = "";
            BagUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            BagUnitDataGridViewTextBoxColumn.Name = "BagUnitDataGridViewTextBoxColumn";
            BagUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "ColorType";
            DataGridViewTextBoxColumn1.FillWeight = 98.89297f;
            DataGridViewTextBoxColumn1.HeaderText = "Type";
            DataGridViewTextBoxColumn1.MinimumWidth = 6;
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ColorNameDataGridViewTextBoxColumn
            // 
            ColorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            ColorNameDataGridViewTextBoxColumn.FillWeight = 98.89297f;
            ColorNameDataGridViewTextBoxColumn.HeaderText = "Color";
            ColorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            ColorNameDataGridViewTextBoxColumn.Name = "ColorNameDataGridViewTextBoxColumn";
            ColorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TransactionType
            // 
            TransactionType.DataPropertyName = "TransactionType";
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TransactionType.DefaultCellStyle = DataGridViewCellStyle8;
            TransactionType.FillWeight = 83.75636f;
            TransactionType.HeaderText = "Transaction";
            TransactionType.MinimumWidth = 6;
            TransactionType.Name = "TransactionType";
            TransactionType.ReadOnly = true;
            // 
            // TransactionQuantity
            // 
            TransactionQuantity.DataPropertyName = "TransactionQuantity";
            TransactionQuantity.HeaderText = "Transaction Quantity";
            TransactionQuantity.Name = "TransactionQuantity";
            TransactionQuantity.ReadOnly = true;
            // 
            // TransactionDateDataGridViewTextBoxColumn
            // 
            TransactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            TransactionDateDataGridViewTextBoxColumn.FillWeight = 98.89297f;
            TransactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            TransactionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            TransactionDateDataGridViewTextBoxColumn.Name = "TransactionDateDataGridViewTextBoxColumn";
            TransactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LocationName
            // 
            LocationName.DataPropertyName = "LocationName";
            LocationName.FillWeight = 98.89297f;
            LocationName.HeaderText = "Location";
            LocationName.Name = "LocationName";
            LocationName.ReadOnly = true;
            // 
            // YardLocationName
            // 
            YardLocationName.DataPropertyName = "YardLocationName";
            YardLocationName.FillWeight = 98.89297f;
            YardLocationName.HeaderText = "Yard";
            YardLocationName.Name = "YardLocationName";
            YardLocationName.ReadOnly = true;
            // 
            // BagQuantity
            // 
            BagQuantity.DataPropertyName = "BagQuantity";
            BagQuantity.FillWeight = 98.89297f;
            BagQuantity.HeaderText = "Remaining Quantity";
            BagQuantity.Name = "BagQuantity";
            BagQuantity.ReadOnly = true;
            // 
            // VWBagInventoryTransactionBindingSource
            // 
            VWBagInventoryTransactionBindingSource.DataSource = typeof(ModelLayer.VW_BagInventoryTransaction);
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
            BunifuShadowPanel1.Size = new Size(1310, 952);
            BunifuShadowPanel1.TabIndex = 140;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Controls.Add(Panel5);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(10, 6);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1295, 941);
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
            Panel5.Size = new Size(1295, 941);
            Panel5.TabIndex = 33;
            // 
            // FrmEmptyBagInvList
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1310, 952);
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmEmptyBagInvList";
            Text = "FrmEmptyBagInvList";
            dgpp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWBagInventoryBindingSource).EndInit();
            GroupBox1.ResumeLayout(false);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWBagInventoryTransactionBindingSource).EndInit();
            BunifuShadowPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Load += new EventHandler(FrmEmptyBagInvList_Load);
            ResumeLayout(false);
        }

        internal PictureBox PictureBox1;
        public Panel dgpp;
        internal DataGridViewTextBoxColumn ColorTypeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ContainerNumberDataGridViewTextBoxColumn;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnActions;
        internal Label Label7;
        internal Panel Panel2;
        internal Panel Panel3;
        internal BindingSource VWBagInventoryTransactionBindingSource;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel1;
        internal Panel Panel5;
        internal Label Label1;
        internal GroupBox GroupBox1;
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

        internal DataGridViewTextBoxColumn BagWeightDataGridViewTextBoxColumn;
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

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEditTransaction;
        internal DataGridViewTextBoxColumn QuantityDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn BagSizeDataGridViewTextBoxColumn;
        internal BunifuTextBox tbBagName;
        internal Label Label21;
        internal BindingSource VWBagInventoryBindingSource;
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
                    _dgvInventory.SelectionChanged -= dgv_SelectionChanged;
                    _dgvInventory.CellContentDoubleClick -= dgv_DoubleClick;
                    _dgvInventory.CellContentClick -= dgvInventory_CellContentClick;
                    _dgvInventory.RowsAdded -= dgvInventory_RowsAdded;
                }

                _dgvInventory = value;
                if (_dgvInventory != null)
                {
                    _dgvInventory.SelectionChanged += dgv_SelectionChanged;
                    _dgvInventory.CellContentDoubleClick += dgv_DoubleClick;
                    _dgvInventory.CellContentClick += dgvInventory_CellContentClick;
                    _dgvInventory.RowsAdded += dgvInventory_RowsAdded;
                }
            }
        }

        internal DataGridViewTextBoxColumn CustomerName;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        internal DataGridViewTextBoxColumn TotalQuantity;
        internal DataGridViewImageColumn percentagePicture;
        internal DataGridViewTextBoxColumn Remaining;
        internal DataGridViewButtonColumn btnEditQtyCol;
        internal DataGridViewTextBoxColumn BagDescriptionDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn BagSizeName;
        internal DataGridViewTextBoxColumn BagWeightName;
        internal DataGridViewTextBoxColumn BagUnitDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn ColorNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn TransactionType;
        internal DataGridViewTextBoxColumn TransactionQuantity;
        internal DataGridViewTextBoxColumn TransactionDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn LocationName;
        internal DataGridViewTextBoxColumn YardLocationName;
        internal DataGridViewTextBoxColumn BagQuantity;
        private ComboBox _cboBagColor;

        internal ComboBox cboBagColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboBagColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboBagColor != null)
                {
                    _cboBagColor.SelectedIndexChanged -= cboCustomer_SelectedIndexChanged;
                }

                _cboBagColor = value;
                if (_cboBagColor != null)
                {
                    _cboBagColor.SelectedIndexChanged += cboCustomer_SelectedIndexChanged;
                }
            }
        }

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
                    _cboBagSize.SelectedIndexChanged -= cboCustomer_SelectedIndexChanged;
                }

                _cboBagSize = value;
                if (_cboBagSize != null)
                {
                    _cboBagSize.SelectedIndexChanged += cboCustomer_SelectedIndexChanged;
                }
            }
        }

        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal TableLayoutPanel TableLayoutPanel1;
    }
}