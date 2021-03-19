using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmAddCompanyToDriver : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCompanyToDriver));
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label2 = new Label();
            BunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            TableLayoutPanel2 = new TableLayoutPanel();
            TableLayoutPanel1 = new TableLayoutPanel();
            _ckbEdit = new CheckBox();
            _ckbEdit.Click += new EventHandler(ckbEdit_Click);
            _btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSave.Click += new EventHandler(btnSave_Click);
            _btnDisconnect = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnDisconnect.Click += new EventHandler(btnDisconnect_Click);
            _btnLink = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnLink.Click += new EventHandler(btnLink_Click);
            Label6 = new Label();
            ddlTruckCompany = new ComboBox();
            CompaniesNameBindingSource = new BindingSource(components);
            _dgvTruckDriverCompany = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvTruckDriverCompany.CellClick += new DataGridViewCellEventHandler(dgvTruckDriverCompany_CellClick);
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            PortPassId = new DataGridViewTextBoxColumn();
            TruckNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            FirstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            FullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            SuspendTruckDriverDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TruckDriverListBindingSourceGridView = new BindingSource(components);
            Panel2 = new Panel();
            lblNameDriver = new Label();
            TableLayoutPanel2.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CompaniesNameBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dgvTruckDriverCompany).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TruckDriverListBindingSourceGridView).BeginInit();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(892, -1);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(40, 41);
            _closeLabel.TabIndex = 146;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            Label2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Dock = DockStyle.Top;
            Label2.Font = new Font("Microsoft Sans Serif", 22.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(0, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(932, 41);
            Label2.TabIndex = 145;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuLabel7
            // 
            BunifuLabel7.AutoEllipsis = false;
            BunifuLabel7.CursorType = null;
            BunifuLabel7.Font = new Font("Microsoft Sans Serif", 14.0f);
            BunifuLabel7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuLabel7.Location = new Point(12, 60);
            BunifuLabel7.Name = "BunifuLabel7";
            BunifuLabel7.RightToLeft = RightToLeft.No;
            BunifuLabel7.Size = new Size(239, 26);
            BunifuLabel7.TabIndex = 238;
            BunifuLabel7.Text = "Connect Company to Driver:";
            BunifuLabel7.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 3;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 625.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 185.0f));
            TableLayoutPanel2.Controls.Add(_btnDisconnect, 2, 1);
            TableLayoutPanel2.Controls.Add(_btnLink, 2, 0);
            TableLayoutPanel2.Controls.Add(Label6, 0, 0);
            TableLayoutPanel2.Controls.Add(ddlTruckCompany, 1, 0);
            TableLayoutPanel2.Location = new Point(5, 5);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 2;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel2.Size = new Size(897, 80);
            TableLayoutPanel2.TabIndex = 239;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Left;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.71429f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.28571f));
            TableLayoutPanel1.Controls.Add(_ckbEdit, 0, 0);
            TableLayoutPanel1.Controls.Add(_btnSave, 1, 0);
            TableLayoutPanel1.Location = new Point(718, 86);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new Size(184, 39);
            TableLayoutPanel1.TabIndex = 245;
            // 
            // ckbEdit
            // 
            _ckbEdit.Anchor = AnchorStyles.None;
            _ckbEdit.AutoSize = true;
            _ckbEdit.Location = new Point(10, 11);
            _ckbEdit.Name = "_ckbEdit";
            _ckbEdit.Size = new Size(44, 17);
            _ckbEdit.TabIndex = 244;
            _ckbEdit.Text = "Edit";
            _ckbEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            _btnSave.AllowToggling = false;
            _btnSave.Anchor = AnchorStyles.None;
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
            _btnSave.DisabledBorderColor = Color.Empty;
            _btnSave.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSave.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSave.Enabled = false;
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
            _btnSave.Location = new Point(68, 3);
            _btnSave.Name = "_btnSave";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _btnSave.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Teal;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _btnSave.OnPressedState = StateProperties6;
            _btnSave.Size = new Size(113, 33);
            _btnSave.TabIndex = 242;
            _btnSave.TextAlign = ContentAlignment.MiddleCenter;
            _btnSave.TextMarginLeft = 0;
            _btnSave.UseDefaultRadiusAndThickness = true;
            // 
            // btnDisconnect
            // 
            _btnDisconnect.AllowToggling = false;
            _btnDisconnect.Anchor = AnchorStyles.Right;
            _btnDisconnect.AnimationSpeed = 200;
            _btnDisconnect.AutoGenerateColors = false;
            _btnDisconnect.BackColor = Color.Transparent;
            _btnDisconnect.BackColor1 = Color.IndianRed;
            _btnDisconnect.BackgroundImage = (Image)resources.GetObject("btnDisconnect.BackgroundImage");
            _btnDisconnect.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnDisconnect.ButtonText = "Disconnect";
            _btnDisconnect.ButtonTextMarginLeft = 0;
            _btnDisconnect.ColorContrastOnClick = 45;
            _btnDisconnect.ColorContrastOnHover = 45;
            _btnDisconnect.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnDisconnect.CustomizableEdges = BorderEdges1;
            _btnDisconnect.DialogResult = DialogResult.None;
            _btnDisconnect.DisabledBorderColor = Color.Empty;
            _btnDisconnect.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnDisconnect.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnDisconnect.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnDisconnect.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnDisconnect.ForeColor = Color.White;
            _btnDisconnect.IconLeftCursor = Cursors.Hand;
            _btnDisconnect.IconMarginLeft = 11;
            _btnDisconnect.IconPadding = 10;
            _btnDisconnect.IconRightCursor = Cursors.Hand;
            _btnDisconnect.IdleBorderColor = Color.IndianRed;
            _btnDisconnect.IdleBorderRadius = 3;
            _btnDisconnect.IdleBorderThickness = 1;
            _btnDisconnect.IdleFillColor = Color.IndianRed;
            _btnDisconnect.IdleIconLeftImage = null;
            _btnDisconnect.IdleIconRightImage = null;
            _btnDisconnect.IndicateFocus = true;
            _btnDisconnect.Location = new Point(723, 43);
            _btnDisconnect.Name = "_btnDisconnect";
            StateProperties1.BorderColor = Color.Salmon;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.Salmon;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnDisconnect.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.IndianRed;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.IndianRed;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnDisconnect.OnPressedState = StateProperties2;
            _btnDisconnect.Size = new Size(171, 34);
            _btnDisconnect.TabIndex = 242;
            _btnDisconnect.TextAlign = ContentAlignment.MiddleCenter;
            _btnDisconnect.TextMarginLeft = 0;
            _btnDisconnect.UseDefaultRadiusAndThickness = true;
            // 
            // btnLink
            // 
            _btnLink.AllowToggling = false;
            _btnLink.Anchor = AnchorStyles.Right;
            _btnLink.AnimationSpeed = 200;
            _btnLink.AutoGenerateColors = false;
            _btnLink.BackColor = Color.Transparent;
            _btnLink.BackColor1 = Color.Teal;
            _btnLink.BackgroundImage = (Image)resources.GetObject("btnLink.BackgroundImage");
            _btnLink.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnLink.ButtonText = "Connect";
            _btnLink.ButtonTextMarginLeft = 0;
            _btnLink.ColorContrastOnClick = 45;
            _btnLink.ColorContrastOnHover = 45;
            _btnLink.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnLink.CustomizableEdges = BorderEdges2;
            _btnLink.DialogResult = DialogResult.None;
            _btnLink.DisabledBorderColor = Color.Empty;
            _btnLink.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnLink.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnLink.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnLink.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnLink.ForeColor = Color.White;
            _btnLink.IconLeftCursor = Cursors.Hand;
            _btnLink.IconMarginLeft = 11;
            _btnLink.IconPadding = 10;
            _btnLink.IconRightCursor = Cursors.Hand;
            _btnLink.IdleBorderColor = Color.Teal;
            _btnLink.IdleBorderRadius = 3;
            _btnLink.IdleBorderThickness = 1;
            _btnLink.IdleFillColor = Color.Teal;
            _btnLink.IdleIconLeftImage = null;
            _btnLink.IdleIconRightImage = null;
            _btnLink.IndicateFocus = true;
            _btnLink.Location = new Point(723, 3);
            _btnLink.Name = "_btnLink";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _btnLink.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _btnLink.OnPressedState = StateProperties4;
            _btnLink.Size = new Size(171, 34);
            _btnLink.TabIndex = 241;
            _btnLink.TextAlign = ContentAlignment.MiddleCenter;
            _btnLink.TextMarginLeft = 0;
            _btnLink.UseDefaultRadiusAndThickness = true;
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.Left;
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(3, 10);
            Label6.Name = "Label6";
            Label6.Size = new Size(80, 20);
            Label6.TabIndex = 211;
            Label6.Text = "Company:";
            // 
            // ddlTruckCompany
            // 
            ddlTruckCompany.AutoCompleteMode = AutoCompleteMode.Append;
            ddlTruckCompany.AutoCompleteSource = AutoCompleteSource.ListItems;
            ddlTruckCompany.DataSource = CompaniesNameBindingSource;
            ddlTruckCompany.DisplayMember = "CompanyName";
            ddlTruckCompany.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ddlTruckCompany.FormattingEnabled = true;
            ddlTruckCompany.Location = new Point(90, 3);
            ddlTruckCompany.Name = "ddlTruckCompany";
            ddlTruckCompany.Size = new Size(592, 32);
            ddlTruckCompany.TabIndex = 237;
            ddlTruckCompany.ValueMember = "CompanieId";
            // 
            // CompaniesNameBindingSource
            // 
            CompaniesNameBindingSource.DataSource = typeof(ModelLayer.CustomModel.CompaniesName);
            // 
            // dgvTruckDriverCompany
            // 
            _dgvTruckDriverCompany.AllowCustomTheming = true;
            _dgvTruckDriverCompany.AllowUserToAddRows = false;
            _dgvTruckDriverCompany.AllowUserToDeleteRows = false;
            _dgvTruckDriverCompany.AllowUserToResizeColumns = false;
            _dgvTruckDriverCompany.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvTruckDriverCompany.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvTruckDriverCompany.AutoGenerateColumns = false;
            _dgvTruckDriverCompany.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvTruckDriverCompany.BackgroundColor = Color.White;
            _dgvTruckDriverCompany.BorderStyle = BorderStyle.None;
            _dgvTruckDriverCompany.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvTruckDriverCompany.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvTruckDriverCompany.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvTruckDriverCompany.ColumnHeadersHeight = 45;
            _dgvTruckDriverCompany.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, PortPassId, TruckNumberDataGridViewTextBoxColumn, FirstNameDataGridViewTextBoxColumn, LastNameDataGridViewTextBoxColumn, FullNameDataGridViewTextBoxColumn, SuspendTruckDriverDataGridViewTextBoxColumn, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn1 });
            _dgvTruckDriverCompany.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvTruckDriverCompany.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvTruckDriverCompany.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvTruckDriverCompany.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvTruckDriverCompany.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvTruckDriverCompany.CurrentTheme.BackColor = Color.Snow;
            _dgvTruckDriverCompany.CurrentTheme.GridColor = Color.Gray;
            _dgvTruckDriverCompany.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvTruckDriverCompany.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvTruckDriverCompany.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvTruckDriverCompany.CurrentTheme.Name = null;
            _dgvTruckDriverCompany.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvTruckDriverCompany.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvTruckDriverCompany.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvTruckDriverCompany.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvTruckDriverCompany.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvTruckDriverCompany.DataSource = TruckDriverListBindingSourceGridView;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvTruckDriverCompany.DefaultCellStyle = DataGridViewCellStyle3;
            _dgvTruckDriverCompany.EnableHeadersVisualStyles = false;
            _dgvTruckDriverCompany.GridColor = Color.Gray;
            _dgvTruckDriverCompany.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvTruckDriverCompany.HeaderBgColor = Color.Empty;
            _dgvTruckDriverCompany.HeaderForeColor = Color.White;
            _dgvTruckDriverCompany.Location = new Point(13, 239);
            _dgvTruckDriverCompany.MultiSelect = false;
            _dgvTruckDriverCompany.Name = "_dgvTruckDriverCompany";
            _dgvTruckDriverCompany.ReadOnly = true;
            _dgvTruckDriverCompany.RowHeadersVisible = false;
            _dgvTruckDriverCompany.RowHeadersWidth = 40;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            _dgvTruckDriverCompany.RowsDefaultCellStyle = DataGridViewCellStyle4;
            _dgvTruckDriverCompany.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvTruckDriverCompany.RowTemplate.Height = 40;
            _dgvTruckDriverCompany.ScrollBars = ScrollBars.Vertical;
            _dgvTruckDriverCompany.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvTruckDriverCompany.Size = new Size(907, 283);
            _dgvTruckDriverCompany.TabIndex = 241;
            _dgvTruckDriverCompany.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewTextBoxColumn5.DataPropertyName = "TruckDriverCompanyId";
            DataGridViewTextBoxColumn5.HeaderText = "TruckDriverCompanyId";
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
            DataGridViewTextBoxColumn5.Visible = false;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.DataPropertyName = "CompanyCode";
            DataGridViewTextBoxColumn3.FillWeight = 194.9239f;
            DataGridViewTextBoxColumn3.HeaderText = "Code";
            DataGridViewTextBoxColumn3.MinimumWidth = 105;
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewTextBoxColumn4.DataPropertyName = "CompanyName";
            DataGridViewTextBoxColumn4.FillWeight = 5.076141f;
            DataGridViewTextBoxColumn4.HeaderText = "Company";
            DataGridViewTextBoxColumn4.MinimumWidth = 530;
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // PortPassId
            // 
            PortPassId.DataPropertyName = "PortPassId";
            PortPassId.HeaderText = "Pass Id";
            PortPassId.MinimumWidth = 130;
            PortPassId.Name = "PortPassId";
            PortPassId.ReadOnly = true;
            // 
            // TruckNumberDataGridViewTextBoxColumn
            // 
            TruckNumberDataGridViewTextBoxColumn.DataPropertyName = "TruckNumber";
            TruckNumberDataGridViewTextBoxColumn.HeaderText = "Truck Number";
            TruckNumberDataGridViewTextBoxColumn.MinimumWidth = 142;
            TruckNumberDataGridViewTextBoxColumn.Name = "TruckNumberDataGridViewTextBoxColumn";
            TruckNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FirstNameDataGridViewTextBoxColumn
            // 
            FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn";
            FirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            FirstNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // LastNameDataGridViewTextBoxColumn
            // 
            LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            LastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn";
            LastNameDataGridViewTextBoxColumn.ReadOnly = true;
            LastNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // FullNameDataGridViewTextBoxColumn
            // 
            FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            FullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn";
            FullNameDataGridViewTextBoxColumn.ReadOnly = true;
            FullNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // SuspendTruckDriverDataGridViewTextBoxColumn
            // 
            SuspendTruckDriverDataGridViewTextBoxColumn.DataPropertyName = "SuspendTruckDriver";
            SuspendTruckDriverDataGridViewTextBoxColumn.HeaderText = "SuspendTruckDriver";
            SuspendTruckDriverDataGridViewTextBoxColumn.Name = "SuspendTruckDriverDataGridViewTextBoxColumn";
            SuspendTruckDriverDataGridViewTextBoxColumn.ReadOnly = true;
            SuspendTruckDriverDataGridViewTextBoxColumn.Visible = false;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.DataPropertyName = "CompanyId";
            DataGridViewTextBoxColumn2.HeaderText = "CompanyId";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            DataGridViewTextBoxColumn2.Visible = false;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "TruckDriverId";
            DataGridViewTextBoxColumn1.HeaderText = "TruckDriverId";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            DataGridViewTextBoxColumn1.Visible = false;
            // 
            // TruckDriverListBindingSourceGridView
            // 
            TruckDriverListBindingSourceGridView.DataSource = typeof(ModelLayer.CustomModel.TruckDriverList);
            // 
            // Panel2
            // 
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(TableLayoutPanel1);
            Panel2.Controls.Add(TableLayoutPanel2);
            Panel2.Location = new Point(12, 97);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(908, 130);
            Panel2.TabIndex = 242;
            // 
            // lblNameDriver
            // 
            lblNameDriver.AutoSize = true;
            lblNameDriver.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblNameDriver.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblNameDriver.Location = new Point(251, 62);
            lblNameDriver.Name = "lblNameDriver";
            lblNameDriver.Size = new Size(126, 24);
            lblNameDriver.TabIndex = 243;
            lblNameDriver.Text = "Name Driver";
            // 
            // frmAddCompanyToDriver
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(932, 536);
            Controls.Add(_dgvTruckDriverCompany);
            Controls.Add(lblNameDriver);
            Controls.Add(Panel2);
            Controls.Add(BunifuLabel7);
            Controls.Add(_closeLabel);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddCompanyToDriver";
            Text = "frmAddCompanyToDriver";
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CompaniesNameBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dgvTruckDriverCompany).EndInit();
            ((System.ComponentModel.ISupportInitialize)TruckDriverListBindingSourceGridView).EndInit();
            Panel2.ResumeLayout(false);
            Load += new EventHandler(frmAddCompanyToDriver_Load);
            ResumeLayout(false);
            PerformLayout();
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

        internal Label Label2;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel7;
        internal TableLayoutPanel TableLayoutPanel2;
        internal ComboBox ddlTruckCompany;
        internal Label Label6;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnLink;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLink
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnLink;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnLink != null)
                {
                    _btnLink.Click -= btnLink_Click;
                }

                _btnLink = value;
                if (_btnLink != null)
                {
                    _btnLink.Click += btnLink_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDataGridView _dgvTruckDriverCompany;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvTruckDriverCompany
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvTruckDriverCompany;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvTruckDriverCompany != null)
                {
                    _dgvTruckDriverCompany.CellClick -= dgvTruckDriverCompany_CellClick;
                }

                _dgvTruckDriverCompany = value;
                if (_dgvTruckDriverCompany != null)
                {
                    _dgvTruckDriverCompany.CellClick += dgvTruckDriverCompany_CellClick;
                }
            }
        }

        internal BindingSource CompaniesNameBindingSource;
        internal DataGridViewTextBoxColumn TruckDriverCompanyIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn TruckDriverIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CompanyIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CompanyCodeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CompanyNameDataGridViewTextBoxColumn;
        internal BindingSource TruckDriverListBindingSourceGridView;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnDisconnect;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDisconnect
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnDisconnect;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDisconnect != null)
                {
                    _btnDisconnect.Click -= btnDisconnect_Click;
                }

                _btnDisconnect = value;
                if (_btnDisconnect != null)
                {
                    _btnDisconnect.Click += btnDisconnect_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn PortPassIDDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn PortPassId;
        internal DataGridViewTextBoxColumn TruckNumberDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn FirstNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn LastNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn FullNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn SuspendTruckDriverDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
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

        internal Panel Panel2;
        internal Label lblNameDriver;
        private CheckBox _ckbEdit;

        internal CheckBox ckbEdit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckbEdit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckbEdit != null)
                {
                    _ckbEdit.Click -= ckbEdit_Click;
                }

                _ckbEdit = value;
                if (_ckbEdit != null)
                {
                    _ckbEdit.Click += ckbEdit_Click;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel1;
    }
}