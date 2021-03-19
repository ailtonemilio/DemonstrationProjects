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
    public partial class FrmAddEditGrainInventory : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditGrainInventory));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var BorderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            Panel1 = new Panel();
            dgvGrainLocations = new Bunifu.UI.WinForms.BunifuDataGridView();
            StorageLocation = new DataGridViewTextBoxColumn();
            QtyInStorage = new DataGridViewTextBoxColumn();
            Label18 = new Label();
            BunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            TableLayoutPanel3 = new TableLayoutPanel();
            Label1 = new Label();
            Panel2 = new Panel();
            lblBagName = new Label();
            _btnChooseLogo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnChooseLogo.Click += new EventHandler(btnChooseLogo_Click);
            lblCargoType = new Label();
            lblCommodityGrade = new Label();
            Label4 = new Label();
            _cboUnitSources = new ComboBox();
            _cboUnitSources.SelectedIndexChanged += new EventHandler(cboUnitSources_SelectedIndexChanged);
            Label8 = new Label();
            Label13 = new Label();
            dtpStorage = new DateTimePicker();
            Label3 = new Label();
            lblCustomer = new Label();
            Label2 = new Label();
            Label12 = new Label();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label17 = new Label();
            _btnAddQty = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddQty.Click += new EventHandler(btnAddLogo_Click);
            GroupBox2 = new GroupBox();
            Label15 = new Label();
            lblTotalQuantity = new Label();
            _btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSave.Click += new EventHandler(btnSave_Click);
            VWBagBindingSource = new BindingSource(components);
            panelBagsList = new Panel();
            _BunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _BunifuButton1.Click += new EventHandler(BunifuButton1_Click);
            _BunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            _BunifuFlatButton1.Click += new EventHandler(BunifuFlatButton1_Click);
            Label11 = new Label();
            Label16 = new Label();
            GroupBox1 = new GroupBox();
            _tbBagName = new BunifuTextBox();
            _tbBagName.TextChanged += new EventHandler(tbBagName_TextChanged);
            Label63 = new Label();
            _btnOkLogo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnOkLogo.Click += new EventHandler(btnOkLogo_Click);
            dgvBags = new Bunifu.UI.WinForms.BunifuDataGridView();
            BagDescription = new DataGridViewTextBoxColumn();
            ColorTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ColorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lblWarning = new Label();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrainLocations).BeginInit();
            TableLayoutPanel3.SuspendLayout();
            Panel2.SuspendLayout();
            GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VWBagBindingSource).BeginInit();
            panelBagsList.SuspendLayout();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBags).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(dgvGrainLocations);
            Panel1.Location = new Point(70, 333);
            Panel1.Margin = new Padding(4);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(336, 109);
            Panel1.TabIndex = 209;
            // 
            // dgvGrainLocations
            // 
            dgvGrainLocations.AllowCustomTheming = true;
            dgvGrainLocations.AllowUserToAddRows = false;
            dgvGrainLocations.AllowUserToDeleteRows = false;
            dgvGrainLocations.AllowUserToResizeColumns = false;
            dgvGrainLocations.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            dgvGrainLocations.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dgvGrainLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrainLocations.BackgroundColor = Color.White;
            dgvGrainLocations.BorderStyle = BorderStyle.None;
            dgvGrainLocations.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGrainLocations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.Silver;
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle2.ForeColor = Color.Black;
            DataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            DataGridViewCellStyle2.SelectionForeColor = Color.Black;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGrainLocations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dgvGrainLocations.ColumnHeadersHeight = 28;
            dgvGrainLocations.Columns.AddRange(new DataGridViewColumn[] { StorageLocation, QtyInStorage });
            dgvGrainLocations.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            dgvGrainLocations.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvGrainLocations.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvGrainLocations.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.Lavender;
            dgvGrainLocations.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvGrainLocations.CurrentTheme.BackColor = Color.White;
            dgvGrainLocations.CurrentTheme.GridColor = Color.DarkGray;
            dgvGrainLocations.CurrentTheme.HeaderStyle.BackColor = Color.Silver;
            dgvGrainLocations.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            dgvGrainLocations.CurrentTheme.HeaderStyle.ForeColor = Color.Black;
            dgvGrainLocations.CurrentTheme.Name = null;
            dgvGrainLocations.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvGrainLocations.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvGrainLocations.CurrentTheme.RowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvGrainLocations.CurrentTheme.RowsStyle.SelectionBackColor = Color.Lavender;
            dgvGrainLocations.CurrentTheme.RowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.White;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle3.SelectionBackColor = Color.Lavender;
            DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGrainLocations.DefaultCellStyle = DataGridViewCellStyle3;
            dgvGrainLocations.Dock = DockStyle.Fill;
            dgvGrainLocations.EnableHeadersVisualStyles = false;
            dgvGrainLocations.GridColor = Color.DarkGray;
            dgvGrainLocations.HeaderBackColor = Color.Silver;
            dgvGrainLocations.HeaderBgColor = Color.Empty;
            dgvGrainLocations.HeaderForeColor = Color.Black;
            dgvGrainLocations.Location = new Point(0, 0);
            dgvGrainLocations.MultiSelect = false;
            dgvGrainLocations.Name = "dgvGrainLocations";
            dgvGrainLocations.ReadOnly = true;
            dgvGrainLocations.RowHeadersVisible = false;
            dgvGrainLocations.RowHeadersWidth = 32;
            dgvGrainLocations.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonFace;
            dgvGrainLocations.RowTemplate.Height = 27;
            dgvGrainLocations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrainLocations.Size = new Size(334, 107);
            dgvGrainLocations.TabIndex = 59;
            dgvGrainLocations.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // StorageLocation
            // 
            StorageLocation.DataPropertyName = "StorageLocation";
            StorageLocation.FillWeight = 197.0467f;
            StorageLocation.HeaderText = "Storage Location";
            StorageLocation.MinimumWidth = 6;
            StorageLocation.Name = "StorageLocation";
            StorageLocation.ReadOnly = true;
            // 
            // QtyInStorage
            // 
            QtyInStorage.DataPropertyName = "QtyInStorage";
            QtyInStorage.FillWeight = 80.11068f;
            QtyInStorage.HeaderText = "Quantity";
            QtyInStorage.MinimumWidth = 6;
            QtyInStorage.Name = "QtyInStorage";
            QtyInStorage.ReadOnly = true;
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Font = new Font("Segoe UI", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label18.Location = new Point(51, 302);
            Label18.Margin = new Padding(4, 0, 4, 0);
            Label18.Name = "Label18";
            Label18.Size = new Size(223, 21);
            Label18.TabIndex = 208;
            Label18.Text = "Grain Location and quantity";
            // 
            // BunifuSeparator3
            // 
            BunifuSeparator3.BackColor = Color.Transparent;
            BunifuSeparator3.ForeColor = Color.Gray;
            BunifuSeparator3.LineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)));
            BunifuSeparator3.LineThickness = 1;
            BunifuSeparator3.Location = new Point(56, 282);
            BunifuSeparator3.Margin = new Padding(9, 8, 9, 8);
            BunifuSeparator3.Name = "BunifuSeparator3";
            BunifuSeparator3.Size = new Size(574, 12);
            BunifuSeparator3.TabIndex = 206;
            BunifuSeparator3.Transparency = 255;
            BunifuSeparator3.Vertical = false;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.ColumnCount = 2;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.30957f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.69043f));
            TableLayoutPanel3.Controls.Add(Label1, 0, 5);
            TableLayoutPanel3.Controls.Add(Panel2, 1, 5);
            TableLayoutPanel3.Controls.Add(lblCargoType, 1, 3);
            TableLayoutPanel3.Controls.Add(lblCommodityGrade, 1, 4);
            TableLayoutPanel3.Controls.Add(Label4, 0, 4);
            TableLayoutPanel3.Controls.Add(_cboUnitSources, 1, 0);
            TableLayoutPanel3.Controls.Add(Label8, 0, 0);
            TableLayoutPanel3.Controls.Add(Label13, 0, 1);
            TableLayoutPanel3.Controls.Add(dtpStorage, 1, 1);
            TableLayoutPanel3.Controls.Add(Label3, 0, 3);
            TableLayoutPanel3.Controls.Add(lblCustomer, 1, 2);
            TableLayoutPanel3.Controls.Add(Label2, 0, 2);
            TableLayoutPanel3.Location = new Point(56, 96);
            TableLayoutPanel3.Margin = new Padding(4, 3, 4, 3);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 6;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 28.0f));
            TableLayoutPanel3.Size = new Size(491, 175);
            TableLayoutPanel3.TabIndex = 205;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Location = new Point(96, 151);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(38, 18);
            Label1.TabIndex = 217;
            Label1.Text = "Bag:";
            // 
            // Panel2
            // 
            Panel2.Controls.Add(lblBagName);
            Panel2.Controls.Add(_btnChooseLogo);
            Panel2.Location = new Point(141, 148);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(347, 24);
            Panel2.TabIndex = 216;
            // 
            // lblBagName
            // 
            lblBagName.Anchor = AnchorStyles.Right;
            lblBagName.AutoSize = true;
            lblBagName.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBagName.Location = new Point(73, 2);
            lblBagName.Margin = new Padding(4, 0, 4, 0);
            lblBagName.Name = "lblBagName";
            lblBagName.Size = new Size(23, 18);
            lblBagName.TabIndex = 218;
            lblBagName.Text = "...";
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
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnChooseLogo.CustomizableEdges = BorderEdges1;
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
            StateProperties1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnChooseLogo.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnChooseLogo.OnPressedState = StateProperties2;
            _btnChooseLogo.Size = new Size(22, 20);
            _btnChooseLogo.TabIndex = 217;
            _btnChooseLogo.TextAlign = ContentAlignment.MiddleCenter;
            _btnChooseLogo.TextMarginLeft = 0;
            _btnChooseLogo.UseDefaultRadiusAndThickness = true;
            // 
            // lblCargoType
            // 
            lblCargoType.Anchor = AnchorStyles.Left;
            lblCargoType.AutoSize = true;
            lblCargoType.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCargoType.Location = new Point(142, 92);
            lblCargoType.Margin = new Padding(4, 0, 4, 0);
            lblCargoType.Name = "lblCargoType";
            lblCargoType.Size = new Size(147, 18);
            lblCargoType.TabIndex = 215;
            lblCargoType.Text = "Select Unit source";
            lblCargoType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCommodityGrade
            // 
            lblCommodityGrade.Anchor = AnchorStyles.Left;
            lblCommodityGrade.AutoSize = true;
            lblCommodityGrade.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCommodityGrade.Location = new Point(142, 121);
            lblCommodityGrade.Margin = new Padding(4, 0, 4, 0);
            lblCommodityGrade.Name = "lblCommodityGrade";
            lblCommodityGrade.Size = new Size(147, 18);
            lblCommodityGrade.TabIndex = 214;
            lblCommodityGrade.Text = "Select Unit source";
            lblCommodityGrade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Right;
            Label4.AutoSize = true;
            Label4.Location = new Point(4, 121);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(130, 18);
            Label4.TabIndex = 16;
            Label4.Text = "Commodity/Grade";
            // 
            // cboUnitSources
            // 
            _cboUnitSources.AutoCompleteMode = AutoCompleteMode.Suggest;
            _cboUnitSources.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboUnitSources.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboUnitSources.FormattingEnabled = true;
            _cboUnitSources.Location = new Point(142, 3);
            _cboUnitSources.Margin = new Padding(4, 3, 4, 3);
            _cboUnitSources.Name = "_cboUnitSources";
            _cboUnitSources.Size = new Size(207, 26);
            _cboUnitSources.TabIndex = 8;
            // 
            // Label8
            // 
            Label8.Anchor = AnchorStyles.Right;
            Label8.AutoSize = true;
            Label8.Location = new Point(48, 5);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(86, 18);
            Label8.TabIndex = 11;
            Label8.Text = "Unit Source";
            // 
            // Label13
            // 
            Label13.Anchor = AnchorStyles.Right;
            Label13.AutoSize = true;
            Label13.Location = new Point(35, 34);
            Label13.Margin = new Padding(4, 0, 4, 0);
            Label13.Name = "Label13";
            Label13.Size = new Size(99, 18);
            Label13.TabIndex = 9;
            Label13.Text = "Storage Date:";
            // 
            // dtpStorage
            // 
            dtpStorage.CalendarFont = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            dtpStorage.CustomFormat = "dd-MMM-yyyy";
            dtpStorage.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            dtpStorage.Format = DateTimePickerFormat.Custom;
            dtpStorage.Location = new Point(142, 32);
            dtpStorage.Margin = new Padding(4, 3, 4, 3);
            dtpStorage.Name = "dtpStorage";
            dtpStorage.Size = new Size(162, 26);
            dtpStorage.TabIndex = 12;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Right;
            Label3.AutoSize = true;
            Label3.Location = new Point(45, 92);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(89, 18);
            Label3.TabIndex = 15;
            Label3.Text = "Cargo Type:";
            // 
            // lblCustomer
            // 
            lblCustomer.Anchor = AnchorStyles.Left;
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCustomer.Location = new Point(142, 63);
            lblCustomer.Margin = new Padding(4, 0, 4, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(147, 18);
            lblCustomer.TabIndex = 13;
            lblCustomer.Text = "Select Unit source";
            lblCustomer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Right;
            Label2.AutoSize = true;
            Label2.Location = new Point(12, 63);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(122, 18);
            Label2.TabIndex = 14;
            Label2.Text = "Customer Name:";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Segoe UI", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label12.Location = new Point(39, 63);
            Label12.Margin = new Padding(4, 0, 4, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(134, 21);
            Label12.TabIndex = 207;
            Label12.Text = "Grain Inventory:";
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
            _closeFlatButton.Location = new Point(605, 0);
            _closeFlatButton.Margin = new Padding(10);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(46, 42);
            _closeFlatButton.TabIndex = 211;
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
            Label17.Size = new Size(651, 41);
            Label17.TabIndex = 210;
            Label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddQty
            // 
            _btnAddQty.AllowToggling = false;
            _btnAddQty.AnimationSpeed = 200;
            _btnAddQty.AutoGenerateColors = false;
            _btnAddQty.BackColor = Color.Transparent;
            _btnAddQty.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddQty.BackgroundImage = (Image)resources.GetObject("btnAddQty.BackgroundImage");
            _btnAddQty.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddQty.ButtonText = "+";
            _btnAddQty.ButtonTextMarginLeft = 0;
            _btnAddQty.ColorContrastOnClick = 45;
            _btnAddQty.ColorContrastOnHover = 45;
            _btnAddQty.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnAddQty.CustomizableEdges = BorderEdges2;
            _btnAddQty.DialogResult = DialogResult.None;
            _btnAddQty.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnAddQty.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddQty.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddQty.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddQty.Font = new Font("Microsoft YaHei", 14.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddQty.ForeColor = Color.White;
            _btnAddQty.IconLeftCursor = Cursors.Hand;
            _btnAddQty.IconMarginLeft = 11;
            _btnAddQty.IconPadding = 10;
            _btnAddQty.IconRightCursor = Cursors.Hand;
            _btnAddQty.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddQty.IdleBorderRadius = 25;
            _btnAddQty.IdleBorderThickness = 1;
            _btnAddQty.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddQty.IdleIconLeftImage = null;
            _btnAddQty.IdleIconRightImage = null;
            _btnAddQty.IndicateFocus = false;
            _btnAddQty.Location = new Point(412, 333);
            _btnAddQty.Margin = new Padding(2);
            _btnAddQty.Name = "_btnAddQty";
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties3.BorderRadius = 25;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _btnAddQty.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties4.BorderRadius = 25;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _btnAddQty.OnPressedState = StateProperties4;
            _btnAddQty.Size = new Size(29, 31);
            _btnAddQty.TabIndex = 212;
            _btnAddQty.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddQty.TextMarginLeft = 0;
            _btnAddQty.UseDefaultRadiusAndThickness = true;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(Label15);
            GroupBox2.Controls.Add(lblTotalQuantity);
            GroupBox2.Location = new Point(465, 334);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(155, 82);
            GroupBox2.TabIndex = 213;
            GroupBox2.TabStop = false;
            // 
            // Label15
            // 
            Label15.Anchor = AnchorStyles.Right;
            Label15.AutoSize = true;
            Label15.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.Location = new Point(36, 15);
            Label15.Name = "Label15";
            Label15.Size = new Size(107, 20);
            Label15.TabIndex = 209;
            Label15.Text = "Total Quantity";
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.Anchor = AnchorStyles.Right;
            lblTotalQuantity.Font = new Font("Microsoft Sans Serif", 20.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotalQuantity.ForeColor = Color.Teal;
            lblTotalQuantity.Location = new Point(5, 36);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(149, 34);
            lblTotalQuantity.TabIndex = 208;
            lblTotalQuantity.Text = "0";
            lblTotalQuantity.TextAlign = ContentAlignment.MiddleCenter;
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
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _btnSave.CustomizableEdges = BorderEdges3;
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
            _btnSave.Location = new Point(273, 481);
            _btnSave.Margin = new Padding(3, 2, 3, 2);
            _btnSave.Name = "_btnSave";
            StateProperties5.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _btnSave.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _btnSave.OnPressedState = StateProperties6;
            _btnSave.Size = new Size(107, 33);
            _btnSave.TabIndex = 215;
            _btnSave.TextAlign = ContentAlignment.MiddleCenter;
            _btnSave.TextMarginLeft = 0;
            _btnSave.UseDefaultRadiusAndThickness = true;
            // 
            // VWBagBindingSource
            // 
            VWBagBindingSource.DataSource = typeof(ModelLayer.VW_Bag);
            // 
            // panelBagsList
            // 
            panelBagsList.BackColor = Color.WhiteSmoke;
            panelBagsList.BorderStyle = BorderStyle.FixedSingle;
            panelBagsList.Controls.Add(_BunifuButton1);
            panelBagsList.Controls.Add(_BunifuFlatButton1);
            panelBagsList.Controls.Add(Label11);
            panelBagsList.Controls.Add(Label16);
            panelBagsList.Controls.Add(GroupBox1);
            panelBagsList.Controls.Add(_btnOkLogo);
            panelBagsList.Controls.Add(dgvBags);
            panelBagsList.Location = new Point(225, 246);
            panelBagsList.Name = "panelBagsList";
            panelBagsList.Size = new Size(382, 301);
            panelBagsList.TabIndex = 216;
            panelBagsList.Visible = false;
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
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _BunifuButton1.CustomizableEdges = BorderEdges4;
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
            _BunifuButton1.Location = new Point(341, 270);
            _BunifuButton1.Margin = new Padding(2);
            _BunifuButton1.Name = "_BunifuButton1";
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties7.BorderRadius = 25;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _BunifuButton1.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties8.BorderRadius = 25;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _BunifuButton1.OnPressedState = StateProperties8;
            _BunifuButton1.Size = new Size(29, 29);
            _BunifuButton1.TabIndex = 204;
            _BunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            _BunifuButton1.TextMarginLeft = 0;
            _BunifuButton1.UseDefaultRadiusAndThickness = true;
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
            _BunifuFlatButton1.Location = new Point(345, 1);
            _BunifuFlatButton1.Margin = new Padding(6, 7, 6, 7);
            _BunifuFlatButton1.Name = "_BunifuFlatButton1";
            _BunifuFlatButton1.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuFlatButton1.OnHovercolor = Color.Gray;
            _BunifuFlatButton1.OnHoverTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuFlatButton1.selected = false;
            _BunifuFlatButton1.Size = new Size(34, 22);
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
            Label11.Location = new Point(20, 0);
            Label11.Margin = new Padding(2, 0, 2, 0);
            Label11.Name = "Label11";
            Label11.Padding = new Padding(0, 5, 0, 0);
            Label11.Size = new Size(170, 21);
            Label11.TabIndex = 58;
            Label11.Text = "Select bag and click ok";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Font = new Font("Microsoft Sans Serif", 8.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.Location = new Point(4, 334);
            Label16.Margin = new Padding(2, 0, 2, 0);
            Label16.Name = "Label16";
            Label16.Size = new Size(102, 13);
            Label16.TabIndex = 189;
            Label16.Text = "*Double click to edit";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(_tbBagName);
            GroupBox1.Controls.Add(Label63);
            GroupBox1.Location = new Point(3, 20);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(347, 60);
            GroupBox1.TabIndex = 203;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Filter";
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
            _tbBagName.Location = new Point(91, 12);
            _tbBagName.Margin = new Padding(3, 2, 3, 2);
            _tbBagName.MaxLength = 32767;
            _tbBagName.MinimumSize = new Size(116, 25);
            _tbBagName.Modified = false;
            _tbBagName.Multiline = false;
            _tbBagName.Name = "_tbBagName";
            StateProperties9.BorderColor = Color.DodgerBlue;
            StateProperties9.FillColor = Color.Empty;
            StateProperties9.ForeColor = Color.Empty;
            StateProperties9.PlaceholderForeColor = Color.Empty;
            _tbBagName.OnActiveState = StateProperties9;
            StateProperties10.BorderColor = Color.Empty;
            StateProperties10.FillColor = Color.White;
            StateProperties10.ForeColor = Color.Empty;
            StateProperties10.PlaceholderForeColor = Color.Silver;
            _tbBagName.OnDisabledState = StateProperties10;
            StateProperties11.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties11.FillColor = Color.Empty;
            StateProperties11.ForeColor = Color.Empty;
            StateProperties11.PlaceholderForeColor = Color.Empty;
            _tbBagName.OnHoverState = StateProperties11;
            StateProperties12.BorderColor = Color.Silver;
            StateProperties12.FillColor = Color.White;
            StateProperties12.ForeColor = Color.Empty;
            StateProperties12.PlaceholderForeColor = Color.Empty;
            _tbBagName.OnIdleState = StateProperties12;
            _tbBagName.PasswordChar = '\0';
            _tbBagName.PlaceholderForeColor = Color.Silver;
            _tbBagName.PlaceholderText = "";
            _tbBagName.ReadOnly = false;
            _tbBagName.ScrollBars = ScrollBars.None;
            _tbBagName.SelectedText = "";
            _tbBagName.SelectionLength = 0;
            _tbBagName.SelectionStart = 0;
            _tbBagName.ShortcutsEnabled = true;
            _tbBagName.Size = new Size(197, 29);
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
            Label63.Location = new Point(5, 21);
            Label63.Margin = new Padding(2, 0, 2, 0);
            Label63.Name = "Label63";
            Label63.Size = new Size(82, 18);
            Label63.TabIndex = 195;
            Label63.Text = "Bag Name:";
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
            BorderEdges5.BottomLeft = true;
            BorderEdges5.BottomRight = true;
            BorderEdges5.TopLeft = true;
            BorderEdges5.TopRight = true;
            _btnOkLogo.CustomizableEdges = BorderEdges5;
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
            _btnOkLogo.Location = new Point(176, 269);
            _btnOkLogo.Margin = new Padding(2);
            _btnOkLogo.Name = "_btnOkLogo";
            StateProperties13.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties13.BorderRadius = 3;
            StateProperties13.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties13.BorderThickness = 1;
            StateProperties13.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties13.ForeColor = Color.White;
            StateProperties13.IconLeftImage = null;
            StateProperties13.IconRightImage = null;
            _btnOkLogo.onHoverState = StateProperties13;
            StateProperties14.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties14.BorderRadius = 3;
            StateProperties14.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties14.BorderThickness = 1;
            StateProperties14.FillColor = Color.Teal;
            StateProperties14.ForeColor = Color.White;
            StateProperties14.IconLeftImage = null;
            StateProperties14.IconRightImage = null;
            _btnOkLogo.OnPressedState = StateProperties14;
            _btnOkLogo.Size = new Size(65, 28);
            _btnOkLogo.TabIndex = 176;
            _btnOkLogo.TextAlign = ContentAlignment.MiddleCenter;
            _btnOkLogo.TextMarginLeft = 0;
            _btnOkLogo.UseDefaultRadiusAndThickness = true;
            // 
            // dgvBags
            // 
            dgvBags.AllowCustomTheming = true;
            dgvBags.AllowUserToAddRows = false;
            dgvBags.AllowUserToDeleteRows = false;
            dgvBags.AllowUserToResizeColumns = false;
            dgvBags.AllowUserToResizeRows = false;
            DataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewCellStyle4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.ButtonFace;
            dgvBags.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
            dgvBags.AutoGenerateColumns = false;
            dgvBags.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBags.BackgroundColor = Color.White;
            dgvBags.BorderStyle = BorderStyle.None;
            dgvBags.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBags.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.Silver;
            DataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle5.ForeColor = Color.Black;
            DataGridViewCellStyle5.SelectionBackColor = Color.Silver;
            DataGridViewCellStyle5.SelectionForeColor = Color.Black;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvBags.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            dgvBags.ColumnHeadersHeight = 30;
            dgvBags.Columns.AddRange(new DataGridViewColumn[] { BagDescription, ColorTypeDataGridViewTextBoxColumn, ColorNameDataGridViewTextBoxColumn });
            dgvBags.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            dgvBags.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvBags.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvBags.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.Lavender;
            dgvBags.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvBags.CurrentTheme.BackColor = Color.White;
            dgvBags.CurrentTheme.GridColor = Color.DarkGray;
            dgvBags.CurrentTheme.HeaderStyle.BackColor = Color.Silver;
            dgvBags.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            dgvBags.CurrentTheme.HeaderStyle.ForeColor = Color.Black;
            dgvBags.CurrentTheme.Name = null;
            dgvBags.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvBags.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvBags.CurrentTheme.RowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvBags.CurrentTheme.RowsStyle.SelectionBackColor = Color.Lavender;
            dgvBags.CurrentTheme.RowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvBags.DataSource = VWBagBindingSource;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.White;
            DataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle6.SelectionBackColor = Color.Lavender;
            DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvBags.DefaultCellStyle = DataGridViewCellStyle6;
            dgvBags.EnableHeadersVisualStyles = false;
            dgvBags.GridColor = Color.DarkGray;
            dgvBags.HeaderBackColor = Color.Silver;
            dgvBags.HeaderBgColor = Color.Empty;
            dgvBags.HeaderForeColor = Color.Black;
            dgvBags.Location = new Point(9, 83);
            dgvBags.MultiSelect = false;
            dgvBags.Name = "dgvBags";
            dgvBags.ReadOnly = true;
            dgvBags.RowHeadersVisible = false;
            dgvBags.RowHeadersWidth = 30;
            dgvBags.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonFace;
            dgvBags.RowTemplate.Height = 25;
            dgvBags.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBags.Size = new Size(361, 184);
            dgvBags.TabIndex = 57;
            dgvBags.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
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
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWarning.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblWarning.Location = new Point(246, 63);
            lblWarning.Margin = new Padding(4, 0, 4, 0);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 21);
            lblWarning.TabIndex = 217;
            // 
            // FrmAddEditGrainInventory
            // 
            AutoScaleDimensions = new SizeF(9.0f, 18.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(651, 549);
            Controls.Add(lblWarning);
            Controls.Add(panelBagsList);
            Controls.Add(_btnSave);
            Controls.Add(GroupBox2);
            Controls.Add(_btnAddQty);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label17);
            Controls.Add(Panel1);
            Controls.Add(Label18);
            Controls.Add(BunifuSeparator3);
            Controls.Add(TableLayoutPanel3);
            Controls.Add(Label12);
            Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmAddEditGrainInventory";
            Text = "FrmAddEditGrainInventory";
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrainLocations).EndInit();
            TableLayoutPanel3.ResumeLayout(false);
            TableLayoutPanel3.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VWBagBindingSource).EndInit();
            panelBagsList.ResumeLayout(false);
            panelBagsList.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBags).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Panel Panel1;
        internal Label Label18;
        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator3;
        internal TableLayoutPanel TableLayoutPanel3;
        private ComboBox _cboUnitSources;

        internal ComboBox cboUnitSources
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboUnitSources;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboUnitSources != null)
                {
                    _cboUnitSources.SelectedIndexChanged -= cboUnitSources_SelectedIndexChanged;
                }

                _cboUnitSources = value;
                if (_cboUnitSources != null)
                {
                    _cboUnitSources.SelectedIndexChanged += cboUnitSources_SelectedIndexChanged;
                }
            }
        }

        internal Label Label8;
        internal Label Label13;
        internal DateTimePicker dtpStorage;
        internal Label Label12;
        internal Label Label2;
        internal Label lblCustomer;
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddQty;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddQty
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddQty;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddQty != null)
                {
                    _btnAddQty.Click -= btnAddLogo_Click;
                }

                _btnAddQty = value;
                if (_btnAddQty != null)
                {
                    _btnAddQty.Click += btnAddLogo_Click;
                }
            }
        }

        internal GroupBox GroupBox2;
        internal Label Label15;
        internal Label lblTotalQuantity;
        internal Label lblCargoType;
        internal Label Label4;
        internal Label Label3;
        internal Label lblCommodityGrade;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvGrainLocations;
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

        internal Label Label1;
        internal Panel Panel2;
        internal Label lblBagName;
        internal BindingSource VWBagBindingSource;
        internal Panel panelBagsList;
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

        internal Label Label11;
        internal Label Label16;
        internal GroupBox GroupBox1;
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
                    _tbBagName.TextChanged -= tbBagName_TextChanged;
                }

                _tbBagName = value;
                if (_tbBagName != null)
                {
                    _tbBagName.TextChanged += tbBagName_TextChanged;
                }
            }
        }

        internal Label Label63;
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

        public Bunifu.UI.WinForms.BunifuDataGridView dgvBags;
        internal DataGridViewTextBoxColumn BagDescription;
        internal DataGridViewTextBoxColumn ColorTypeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ColorNameDataGridViewTextBoxColumn;
        internal Label lblWarning;
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

        internal DataGridViewTextBoxColumn StorageLocation;
        internal DataGridViewTextBoxColumn QtyInStorage;
    }
}