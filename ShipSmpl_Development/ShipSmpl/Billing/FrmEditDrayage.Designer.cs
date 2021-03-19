using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmEditDrayage : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditDrayage));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            buttonsPanel = new TableLayoutPanel();
            _saveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _saveButton.Click += new EventHandler(saveButton_Click);
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label8 = new Label();
            Panel4 = new Panel();
            _dgvFromDock = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvFromDock.CellContentClick += new DataGridViewCellEventHandler(dgvFromDock_CellContentClick);
            IDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewCheckBoxColumn();
            Code = new DataGridViewTextBoxColumn();
            NameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fromCompaniesBS = new BindingSource(components);
            Panel1 = new Panel();
            _dgvToDock = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvToDock.CellContentClick += new DataGridViewCellEventHandler(dgvToDock_CellContentClick);
            IDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewCheckBoxColumn();
            CodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            NameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            toCompaniesBS = new BindingSource(components);
            truckCompaniesBS = new BindingSource(components);
            Label1 = new Label();
            _cboTuckingCompany = new ComboBox();
            _cboTuckingCompany.SelectedValueChanged += new EventHandler(cboTuckingCompany_SelectedIndexChanged);
            Label2 = new Label();
            Label3 = new Label();
            _cboRateType = new ComboBox();
            _cboRateType.SelectedIndexChanged += new EventHandler(cboRateType_SelectedIndexChanged);
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            _dtpEndDate = new DateTimePicker();
            _dtpEndDate.ValueChanged += new EventHandler(dtpEndDate_ValueChanged);
            Label7 = new Label();
            NumericUpDown1 = new NumericUpDown();
            DrayageRateBindingSource = new BindingSource(components);
            Label9 = new Label();
            Panel2 = new Panel();
            _dgvAssignedRates = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvAssignedRates.CellContentClick += new DataGridViewCellEventHandler(dgvAssignedRates_CellContentClick);
            DataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            DrayageRateIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DrayageSchemeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TruckingCompanyId = new DataGridViewTextBoxColumn();
            FromDockId = new DataGridViewTextBoxColumn();
            ToDockId = new DataGridViewTextBoxColumn();
            FromDock = new DataGridViewTextBoxColumn();
            ToDock = new DataGridViewTextBoxColumn();
            RateTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            FromDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ToDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            RateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DrayageSchemeRateBindingSource = new BindingSource(components);
            Label10 = new Label();
            _BunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _BunifuButton1.Click += new EventHandler(BunifuButton1_Click);
            _cboStartDate = new ComboBox();
            _cboStartDate.SelectedIndexChanged += new EventHandler(cboStartDate_SelectedIndexChanged);
            Label11 = new Label();
            _deleteButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _deleteButton.Click += new EventHandler(deleteButton_Click);
            buttonsPanel.SuspendLayout();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvFromDock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fromCompaniesBS).BeginInit();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvToDock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toCompaniesBS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)truckCompaniesBS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DrayageRateBindingSource).BeginInit();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvAssignedRates).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DrayageSchemeRateBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.None;
            buttonsPanel.ColumnCount = 1;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Controls.Add(_saveButton, 0, 0);
            buttonsPanel.Location = new Point(183, 397);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(90, 39);
            buttonsPanel.TabIndex = 167;
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
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _saveButton.CustomizableEdges = BorderEdges1;
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
            _saveButton.Location = new Point(3, 3);
            _saveButton.Name = "_saveButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _saveButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _saveButton.OnPressedState = StateProperties2;
            _saveButton.Size = new Size(84, 33);
            _saveButton.TabIndex = 136;
            _saveButton.TextAlign = ContentAlignment.MiddleCenter;
            _saveButton.TextMarginLeft = 0;
            _saveButton.UseDefaultRadiusAndThickness = true;
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
            _closeFlatButton.Location = new Point(1436, 0);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(43, 41);
            _closeFlatButton.TabIndex = 169;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Label8
            // 
            Label8.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label8.Dock = DockStyle.Top;
            Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(0, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(1479, 41);
            Label8.TabIndex = 168;
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel4
            // 
            Panel4.Anchor = AnchorStyles.None;
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(_dgvFromDock);
            Panel4.Location = new Point(604, 128);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(421, 334);
            Panel4.TabIndex = 170;
            // 
            // dgvFromDock
            // 
            _dgvFromDock.AllowCustomTheming = true;
            _dgvFromDock.AllowUserToAddRows = false;
            _dgvFromDock.AllowUserToDeleteRows = false;
            _dgvFromDock.AllowUserToOrderColumns = true;
            _dgvFromDock.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvFromDock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvFromDock.AutoGenerateColumns = false;
            _dgvFromDock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvFromDock.BackgroundColor = Color.White;
            _dgvFromDock.BorderStyle = BorderStyle.None;
            _dgvFromDock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvFromDock.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _dgvFromDock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvFromDock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvFromDock.ColumnHeadersHeight = 35;
            _dgvFromDock.Columns.AddRange(new DataGridViewColumn[] { IDDataGridViewTextBoxColumn, Column2, Code, NameDataGridViewTextBoxColumn });
            _dgvFromDock.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvFromDock.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvFromDock.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvFromDock.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvFromDock.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvFromDock.CurrentTheme.BackColor = Color.Snow;
            _dgvFromDock.CurrentTheme.GridColor = Color.Gray;
            _dgvFromDock.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvFromDock.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvFromDock.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvFromDock.CurrentTheme.Name = null;
            _dgvFromDock.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvFromDock.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvFromDock.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvFromDock.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvFromDock.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvFromDock.DataSource = fromCompaniesBS;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.NullValue = null;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvFromDock.DefaultCellStyle = DataGridViewCellStyle3;
            _dgvFromDock.Dock = DockStyle.Fill;
            _dgvFromDock.EnableHeadersVisualStyles = false;
            _dgvFromDock.GridColor = Color.Gray;
            _dgvFromDock.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvFromDock.HeaderBgColor = Color.Empty;
            _dgvFromDock.HeaderForeColor = Color.White;
            _dgvFromDock.Location = new Point(0, 0);
            _dgvFromDock.Name = "_dgvFromDock";
            _dgvFromDock.ReadOnly = true;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = SystemColors.Control;
            DataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.2f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            _dgvFromDock.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
            _dgvFromDock.RowHeadersVisible = false;
            _dgvFromDock.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvFromDock.RowTemplate.Height = 30;
            _dgvFromDock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvFromDock.Size = new Size(419, 332);
            _dgvFromDock.TabIndex = 57;
            _dgvFromDock.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // IDDataGridViewTextBoxColumn
            // 
            IDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            IDDataGridViewTextBoxColumn.HeaderText = "ID";
            IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn";
            IDDataGridViewTextBoxColumn.ReadOnly = true;
            IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column2
            // 
            Column2.FillWeight = 22.84264f;
            Column2.HeaderText = "";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Code
            // 
            Code.DataPropertyName = "Code";
            Code.FillWeight = 56.69322f;
            Code.HeaderText = "Code";
            Code.Name = "Code";
            Code.ReadOnly = true;
            // 
            // NameDataGridViewTextBoxColumn
            // 
            NameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            NameDataGridViewTextBoxColumn.FillWeight = 220.4642f;
            NameDataGridViewTextBoxColumn.HeaderText = "Name";
            NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn";
            NameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromCompaniesBS
            // 
            fromCompaniesBS.DataSource = typeof(ModelLayer.Company);
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.None;
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(_dgvToDock);
            Panel1.Location = new Point(1033, 127);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(421, 334);
            Panel1.TabIndex = 171;
            // 
            // dgvToDock
            // 
            _dgvToDock.AllowCustomTheming = true;
            _dgvToDock.AllowUserToAddRows = false;
            _dgvToDock.AllowUserToDeleteRows = false;
            _dgvToDock.AllowUserToOrderColumns = true;
            _dgvToDock.AllowUserToResizeRows = false;
            DataGridViewCellStyle5.BackColor = Color.White;
            DataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle5.ForeColor = Color.Black;
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvToDock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5;
            _dgvToDock.AutoGenerateColumns = false;
            _dgvToDock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvToDock.BackgroundColor = Color.White;
            _dgvToDock.BorderStyle = BorderStyle.None;
            _dgvToDock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvToDock.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _dgvToDock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle6.ForeColor = Color.White;
            DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            _dgvToDock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6;
            _dgvToDock.ColumnHeadersHeight = 35;
            _dgvToDock.Columns.AddRange(new DataGridViewColumn[] { IDDataGridViewTextBoxColumn1, Column1, CodeDataGridViewTextBoxColumn, NameDataGridViewTextBoxColumn1 });
            _dgvToDock.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvToDock.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvToDock.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvToDock.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvToDock.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvToDock.CurrentTheme.BackColor = Color.Snow;
            _dgvToDock.CurrentTheme.GridColor = Color.Gray;
            _dgvToDock.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvToDock.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvToDock.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvToDock.CurrentTheme.Name = null;
            _dgvToDock.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvToDock.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvToDock.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvToDock.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvToDock.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvToDock.DataSource = toCompaniesBS;
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle7.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle7.ForeColor = Color.Black;
            DataGridViewCellStyle7.NullValue = null;
            DataGridViewCellStyle7.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle7.SelectionForeColor = Color.Black;
            DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            _dgvToDock.DefaultCellStyle = DataGridViewCellStyle7;
            _dgvToDock.Dock = DockStyle.Fill;
            _dgvToDock.EnableHeadersVisualStyles = false;
            _dgvToDock.GridColor = Color.Gray;
            _dgvToDock.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvToDock.HeaderBgColor = Color.Empty;
            _dgvToDock.HeaderForeColor = Color.White;
            _dgvToDock.Location = new Point(0, 0);
            _dgvToDock.Name = "_dgvToDock";
            _dgvToDock.ReadOnly = true;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle8.BackColor = SystemColors.Control;
            DataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 7.2f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            _dgvToDock.RowHeadersDefaultCellStyle = DataGridViewCellStyle8;
            _dgvToDock.RowHeadersVisible = false;
            _dgvToDock.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvToDock.RowTemplate.Height = 30;
            _dgvToDock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvToDock.Size = new Size(419, 332);
            _dgvToDock.TabIndex = 57;
            _dgvToDock.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // IDDataGridViewTextBoxColumn1
            // 
            IDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            IDDataGridViewTextBoxColumn1.FillWeight = 111.3608f;
            IDDataGridViewTextBoxColumn1.HeaderText = "ID";
            IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1";
            IDDataGridViewTextBoxColumn1.ReadOnly = true;
            IDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // Column1
            // 
            Column1.FillWeight = 21.97761f;
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            Column1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CodeDataGridViewTextBoxColumn
            // 
            CodeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            CodeDataGridViewTextBoxColumn.FillWeight = 54.53192f;
            CodeDataGridViewTextBoxColumn.HeaderText = "Code";
            CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn";
            CodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NameDataGridViewTextBoxColumn1
            // 
            NameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            NameDataGridViewTextBoxColumn1.FillWeight = 212.1297f;
            NameDataGridViewTextBoxColumn1.HeaderText = "Name";
            NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1";
            NameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // toCompaniesBS
            // 
            toCompaniesBS.DataSource = typeof(ModelLayer.Company);
            // 
            // truckCompaniesBS
            // 
            truckCompaniesBS.DataSource = typeof(ModelLayer.Company);
            // 
            // Label1
            // 
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(51, 102);
            Label1.Name = "Label1";
            Label1.Size = new Size(98, 56);
            Label1.TabIndex = 172;
            Label1.Text = "Trucking Company:";
            // 
            // cboTuckingCompany
            // 
            _cboTuckingCompany.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _cboTuckingCompany.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboTuckingCompany.DataBindings.Add(new Binding("SelectedItem", truckCompaniesBS, "Name", true, DataSourceUpdateMode.Never));
            _cboTuckingCompany.DataBindings.Add(new Binding("SelectedValue", truckCompaniesBS, "Name", true, DataSourceUpdateMode.Never));
            _cboTuckingCompany.DataBindings.Add(new Binding("Tag", truckCompaniesBS, "Name", true, DataSourceUpdateMode.Never));
            _cboTuckingCompany.DataBindings.Add(new Binding("Text", truckCompaniesBS, "Name", true, DataSourceUpdateMode.Never));
            _cboTuckingCompany.DataSource = truckCompaniesBS;
            _cboTuckingCompany.DisplayMember = "Name";
            _cboTuckingCompany.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboTuckingCompany.FormattingEnabled = true;
            _cboTuckingCompany.Location = new Point(155, 125);
            _cboTuckingCompany.Name = "_cboTuckingCompany";
            _cboTuckingCompany.Size = new Size(409, 33);
            _cboTuckingCompany.TabIndex = 173;
            _cboTuckingCompany.ValueMember = "ID";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label2.Location = new Point(606, 86);
            Label2.Name = "Label2";
            Label2.Size = new Size(123, 30);
            Label2.TabIndex = 174;
            Label2.Text = "From dock:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label3.Location = new Point(1029, 86);
            Label3.Name = "Label3";
            Label3.Size = new Size(95, 30);
            Label3.TabIndex = 175;
            Label3.Text = "To dock:";
            // 
            // cboRateType
            // 
            _cboRateType.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboRateType.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboRateType.FormattingEnabled = true;
            _cboRateType.Items.AddRange(new object[] { "Single Empty", "Multi Empty", "Single Load", "Multi Load" });
            _cboRateType.Location = new Point(155, 170);
            _cboRateType.Name = "_cboRateType";
            _cboRateType.Size = new Size(227, 33);
            _cboRateType.TabIndex = 176;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(22, 176);
            Label4.Name = "Label4";
            Label4.Size = new Size(127, 25);
            Label4.TabIndex = 178;
            Label4.Text = "Drayage type:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(51, 220);
            Label5.Name = "Label5";
            Label5.Size = new Size(98, 25);
            Label5.TabIndex = 179;
            Label5.Text = "Start Date:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.Location = new Point(51, 270);
            Label6.Name = "Label6";
            Label6.Size = new Size(92, 25);
            Label6.TabIndex = 180;
            Label6.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            _dtpEndDate.CalendarFont = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _dtpEndDate.CalendarTrailingForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dtpEndDate.CustomFormat = " ";
            _dtpEndDate.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _dtpEndDate.Format = DateTimePickerFormat.Custom;
            _dtpEndDate.Location = new Point(155, 265);
            _dtpEndDate.Name = "_dtpEndDate";
            _dtpEndDate.Size = new Size(183, 31);
            _dtpEndDate.TabIndex = 182;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(89, 314);
            Label7.Name = "Label7";
            Label7.Size = new Size(68, 25);
            Label7.TabIndex = 183;
            Label7.Text = "Rate: $";
            // 
            // NumericUpDown1
            // 
            NumericUpDown1.BackColor = Color.White;
            NumericUpDown1.DataBindings.Add(new Binding("Value", DrayageRateBindingSource, "Rate", true, DataSourceUpdateMode.OnValidation, null, "C2"));
            NumericUpDown1.DecimalPlaces = 2;
            NumericUpDown1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            NumericUpDown1.Location = new Point(159, 309);
            NumericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            NumericUpDown1.Name = "NumericUpDown1";
            NumericUpDown1.Size = new Size(103, 31);
            NumericUpDown1.TabIndex = 184;
            // 
            // DrayageRateBindingSource
            // 
            DrayageRateBindingSource.DataSource = typeof(ModelLayer.DrayageRate);
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label9.Location = new Point(26, 54);
            Label9.Name = "Label9";
            Label9.Size = new Size(145, 30);
            Label9.TabIndex = 185;
            Label9.Text = "Edit Drayages";
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.None;
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(_dgvAssignedRates);
            Panel2.Font = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Panel2.Location = new Point(604, 513);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(849, 241);
            Panel2.TabIndex = 186;
            // 
            // dgvAssignedRates
            // 
            _dgvAssignedRates.AllowCustomTheming = true;
            _dgvAssignedRates.AllowUserToAddRows = false;
            _dgvAssignedRates.AllowUserToDeleteRows = false;
            _dgvAssignedRates.AllowUserToOrderColumns = true;
            _dgvAssignedRates.AllowUserToResizeRows = false;
            DataGridViewCellStyle9.BackColor = Color.White;
            DataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle9.ForeColor = Color.Black;
            DataGridViewCellStyle9.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvAssignedRates.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9;
            _dgvAssignedRates.AutoGenerateColumns = false;
            _dgvAssignedRates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvAssignedRates.BackgroundColor = Color.White;
            _dgvAssignedRates.BorderStyle = BorderStyle.None;
            _dgvAssignedRates.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvAssignedRates.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _dgvAssignedRates.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle10.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle10.ForeColor = Color.White;
            DataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            _dgvAssignedRates.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10;
            _dgvAssignedRates.ColumnHeadersHeight = 35;
            _dgvAssignedRates.Columns.AddRange(new DataGridViewColumn[] { DataGridViewCheckBoxColumn1, DrayageRateIdDataGridViewTextBoxColumn, DrayageSchemeIdDataGridViewTextBoxColumn, TruckingCompanyId, FromDockId, ToDockId, FromDock, ToDock, RateTypeDataGridViewTextBoxColumn, FromDateDataGridViewTextBoxColumn, ToDateDataGridViewTextBoxColumn, RateDataGridViewTextBoxColumn });
            _dgvAssignedRates.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvAssignedRates.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvAssignedRates.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvAssignedRates.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvAssignedRates.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvAssignedRates.CurrentTheme.BackColor = Color.Snow;
            _dgvAssignedRates.CurrentTheme.GridColor = Color.Gray;
            _dgvAssignedRates.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvAssignedRates.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvAssignedRates.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvAssignedRates.CurrentTheme.Name = null;
            _dgvAssignedRates.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvAssignedRates.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvAssignedRates.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvAssignedRates.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvAssignedRates.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvAssignedRates.DataSource = DrayageSchemeRateBindingSource;
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle11.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle11.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle11.ForeColor = Color.Black;
            DataGridViewCellStyle11.NullValue = null;
            DataGridViewCellStyle11.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle11.SelectionForeColor = Color.Black;
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            _dgvAssignedRates.DefaultCellStyle = DataGridViewCellStyle11;
            _dgvAssignedRates.Dock = DockStyle.Fill;
            _dgvAssignedRates.EnableHeadersVisualStyles = false;
            _dgvAssignedRates.GridColor = Color.Gray;
            _dgvAssignedRates.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvAssignedRates.HeaderBgColor = Color.Empty;
            _dgvAssignedRates.HeaderForeColor = Color.White;
            _dgvAssignedRates.Location = new Point(0, 0);
            _dgvAssignedRates.Name = "_dgvAssignedRates";
            _dgvAssignedRates.ReadOnly = true;
            _dgvAssignedRates.RowHeadersVisible = false;
            DataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _dgvAssignedRates.RowsDefaultCellStyle = DataGridViewCellStyle12;
            _dgvAssignedRates.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11.12727f);
            _dgvAssignedRates.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvAssignedRates.RowTemplate.Height = 30;
            _dgvAssignedRates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvAssignedRates.Size = new Size(847, 239);
            _dgvAssignedRates.TabIndex = 57;
            _dgvAssignedRates.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // DataGridViewCheckBoxColumn1
            // 
            DataGridViewCheckBoxColumn1.FillWeight = 22.84264f;
            DataGridViewCheckBoxColumn1.HeaderText = "";
            DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            DataGridViewCheckBoxColumn1.ReadOnly = true;
            DataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.True;
            DataGridViewCheckBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // DrayageRateIdDataGridViewTextBoxColumn
            // 
            DrayageRateIdDataGridViewTextBoxColumn.DataPropertyName = "DrayageRateId";
            DrayageRateIdDataGridViewTextBoxColumn.HeaderText = "DrayageRateId";
            DrayageRateIdDataGridViewTextBoxColumn.Name = "DrayageRateIdDataGridViewTextBoxColumn";
            DrayageRateIdDataGridViewTextBoxColumn.ReadOnly = true;
            DrayageRateIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // DrayageSchemeIdDataGridViewTextBoxColumn
            // 
            DrayageSchemeIdDataGridViewTextBoxColumn.DataPropertyName = "DrayageSchemeId";
            DrayageSchemeIdDataGridViewTextBoxColumn.HeaderText = "DrayageSchemeId";
            DrayageSchemeIdDataGridViewTextBoxColumn.Name = "DrayageSchemeIdDataGridViewTextBoxColumn";
            DrayageSchemeIdDataGridViewTextBoxColumn.ReadOnly = true;
            DrayageSchemeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // TruckingCompanyId
            // 
            TruckingCompanyId.DataPropertyName = "TruckingCompanyId";
            TruckingCompanyId.HeaderText = "TruckingCompanyId";
            TruckingCompanyId.Name = "TruckingCompanyId";
            TruckingCompanyId.ReadOnly = true;
            TruckingCompanyId.Visible = false;
            // 
            // FromDockId
            // 
            FromDockId.DataPropertyName = "FromDockId";
            FromDockId.HeaderText = "FromDockId";
            FromDockId.Name = "FromDockId";
            FromDockId.ReadOnly = true;
            FromDockId.Visible = false;
            // 
            // ToDockId
            // 
            ToDockId.DataPropertyName = "ToDockId";
            ToDockId.HeaderText = "ToDockId";
            ToDockId.Name = "ToDockId";
            ToDockId.ReadOnly = true;
            ToDockId.Visible = false;
            // 
            // FromDock
            // 
            FromDock.DataPropertyName = "FromDock";
            FromDock.HeaderText = "From Dock";
            FromDock.Name = "FromDock";
            FromDock.ReadOnly = true;
            // 
            // ToDock
            // 
            ToDock.DataPropertyName = "ToDock";
            ToDock.HeaderText = "To Dock";
            ToDock.Name = "ToDock";
            ToDock.ReadOnly = true;
            // 
            // RateTypeDataGridViewTextBoxColumn
            // 
            RateTypeDataGridViewTextBoxColumn.DataPropertyName = "RateType";
            RateTypeDataGridViewTextBoxColumn.HeaderText = "Rate Type";
            RateTypeDataGridViewTextBoxColumn.Name = "RateTypeDataGridViewTextBoxColumn";
            RateTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FromDateDataGridViewTextBoxColumn
            // 
            FromDateDataGridViewTextBoxColumn.DataPropertyName = "FromDate";
            FromDateDataGridViewTextBoxColumn.HeaderText = "From Date";
            FromDateDataGridViewTextBoxColumn.Name = "FromDateDataGridViewTextBoxColumn";
            FromDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ToDateDataGridViewTextBoxColumn
            // 
            ToDateDataGridViewTextBoxColumn.DataPropertyName = "ToDate";
            ToDateDataGridViewTextBoxColumn.HeaderText = "To Date";
            ToDateDataGridViewTextBoxColumn.Name = "ToDateDataGridViewTextBoxColumn";
            ToDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RateDataGridViewTextBoxColumn
            // 
            RateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            RateDataGridViewTextBoxColumn.HeaderText = "Rate";
            RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn";
            RateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DrayageSchemeRateBindingSource
            // 
            DrayageSchemeRateBindingSource.DataSource = typeof(ModelLayer.DrayageSchemeRate);
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label10.Location = new Point(600, 471);
            Label10.Name = "Label10";
            Label10.Size = new Size(148, 30);
            Label10.TabIndex = 187;
            Label10.Text = "Current Rates:";
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
            _BunifuButton1.ButtonText = "";
            _BunifuButton1.ButtonTextMarginLeft = 0;
            _BunifuButton1.ColorContrastOnClick = 45;
            _BunifuButton1.ColorContrastOnHover = 45;
            _BunifuButton1.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _BunifuButton1.CustomizableEdges = BorderEdges2;
            _BunifuButton1.DialogResult = DialogResult.None;
            _BunifuButton1.DisabledBorderColor = Color.Empty;
            _BunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _BunifuButton1.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _BunifuButton1.Font = new Font("Segoe UI", 20.29091f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _BunifuButton1.ForeColor = Color.White;
            _BunifuButton1.IconLeftCursor = Cursors.Hand;
            _BunifuButton1.IconMarginLeft = 10;
            _BunifuButton1.IconPadding = 10;
            _BunifuButton1.IconRightCursor = Cursors.Hand;
            _BunifuButton1.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _BunifuButton1.IdleBorderRadius = 35;
            _BunifuButton1.IdleBorderThickness = 1;
            _BunifuButton1.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _BunifuButton1.IdleIconLeftImage = My.Resources.Resources.addWhite;
            _BunifuButton1.IdleIconRightImage = null;
            _BunifuButton1.IndicateFocus = false;
            _BunifuButton1.Location = new Point(364, 220);
            _BunifuButton1.Margin = new Padding(0);
            _BunifuButton1.Name = "_BunifuButton1";
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties3.BorderRadius = 35;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _BunifuButton1.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties4.BorderRadius = 35;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _BunifuButton1.OnPressedState = StateProperties4;
            _BunifuButton1.Size = new Size(37, 37);
            _BunifuButton1.TabIndex = 188;
            _BunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            _BunifuButton1.TextMarginLeft = 0;
            _BunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // cboStartDate
            // 
            _cboStartDate.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _cboStartDate.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboStartDate.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboStartDate.FormattingEnabled = true;
            _cboStartDate.Location = new Point(155, 220);
            _cboStartDate.Name = "_cboStartDate";
            _cboStartDate.Size = new Size(183, 33);
            _cboStartDate.TabIndex = 189;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.Location = new Point(606, 757);
            Label11.Name = "Label11";
            Label11.Size = new Size(233, 25);
            Label11.TabIndex = 190;
            Label11.Text = "Select current rates to edit";
            // 
            // deleteButton
            // 
            _deleteButton.AllowToggling = false;
            _deleteButton.AnimationSpeed = 200;
            _deleteButton.AutoGenerateColors = false;
            _deleteButton.BackColor = Color.Transparent;
            _deleteButton.BackColor1 = Color.IndianRed;
            _deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            _deleteButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _deleteButton.ButtonText = "Delete";
            _deleteButton.ButtonTextMarginLeft = 0;
            _deleteButton.ColorContrastOnClick = 45;
            _deleteButton.ColorContrastOnHover = 45;
            _deleteButton.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _deleteButton.CustomizableEdges = BorderEdges3;
            _deleteButton.DialogResult = DialogResult.None;
            _deleteButton.DisabledBorderColor = Color.Empty;
            _deleteButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _deleteButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _deleteButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _deleteButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _deleteButton.ForeColor = Color.White;
            _deleteButton.IconLeftCursor = Cursors.Hand;
            _deleteButton.IconMarginLeft = 11;
            _deleteButton.IconPadding = 10;
            _deleteButton.IconRightCursor = Cursors.Hand;
            _deleteButton.IdleBorderColor = Color.IndianRed;
            _deleteButton.IdleBorderRadius = 3;
            _deleteButton.IdleBorderThickness = 1;
            _deleteButton.IdleFillColor = Color.IndianRed;
            _deleteButton.IdleIconLeftImage = null;
            _deleteButton.IdleIconRightImage = null;
            _deleteButton.IndicateFocus = true;
            _deleteButton.Location = new Point(1364, 755);
            _deleteButton.Name = "_deleteButton";
            StateProperties5.BorderColor = Color.LightCoral;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.LightCoral;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _deleteButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.IndianRed;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.IndianRed;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _deleteButton.OnPressedState = StateProperties6;
            _deleteButton.Size = new Size(89, 30);
            _deleteButton.TabIndex = 191;
            _deleteButton.TextAlign = ContentAlignment.MiddleCenter;
            _deleteButton.TextMarginLeft = 0;
            _deleteButton.UseDefaultRadiusAndThickness = true;
            // 
            // FrmEditDrayage
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1479, 830);
            Controls.Add(_deleteButton);
            Controls.Add(Label11);
            Controls.Add(_cboStartDate);
            Controls.Add(_BunifuButton1);
            Controls.Add(Label10);
            Controls.Add(Panel2);
            Controls.Add(Label9);
            Controls.Add(NumericUpDown1);
            Controls.Add(Label7);
            Controls.Add(_dtpEndDate);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(_cboRateType);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(_cboTuckingCompany);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            Controls.Add(Panel4);
            Controls.Add(buttonsPanel);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditDrayage";
            Text = "To dock:";
            buttonsPanel.ResumeLayout(false);
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvFromDock).EndInit();
            ((System.ComponentModel.ISupportInitialize)fromCompaniesBS).EndInit();
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvToDock).EndInit();
            ((System.ComponentModel.ISupportInitialize)toCompaniesBS).EndInit();
            ((System.ComponentModel.ISupportInitialize)truckCompaniesBS).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DrayageRateBindingSource).EndInit();
            Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvAssignedRates).EndInit();
            ((System.ComponentModel.ISupportInitialize)DrayageSchemeRateBindingSource).EndInit();
            Load += new EventHandler(FrmEditDrayage_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal TableLayoutPanel buttonsPanel;
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

        internal Label Label8;
        internal Panel Panel4;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvFromDock;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvFromDock
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvFromDock;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvFromDock != null)
                {
                    _dgvFromDock.CellContentClick -= dgvFromDock_CellContentClick;
                }

                _dgvFromDock = value;
                if (_dgvFromDock != null)
                {
                    _dgvFromDock.CellContentClick += dgvFromDock_CellContentClick;
                }
            }
        }

        internal Panel Panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvToDock;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvToDock
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvToDock;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvToDock != null)
                {
                    _dgvToDock.CellContentClick -= dgvToDock_CellContentClick;
                }

                _dgvToDock = value;
                if (_dgvToDock != null)
                {
                    _dgvToDock.CellContentClick += dgvToDock_CellContentClick;
                }
            }
        }

        internal Label Label1;
        private ComboBox _cboTuckingCompany;

        internal ComboBox cboTuckingCompany
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboTuckingCompany;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboTuckingCompany != null)
                {
                    _cboTuckingCompany.SelectedValueChanged -= cboTuckingCompany_SelectedIndexChanged;
                }

                _cboTuckingCompany = value;
                if (_cboTuckingCompany != null)
                {
                    _cboTuckingCompany.SelectedValueChanged += cboTuckingCompany_SelectedIndexChanged;
                }
            }
        }

        internal BindingSource fromCompaniesBS;
        internal Label Label2;
        internal Label Label3;
        private ComboBox _cboRateType;

        internal ComboBox cboRateType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboRateType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboRateType != null)
                {
                    _cboRateType.SelectedIndexChanged -= cboRateType_SelectedIndexChanged;
                }

                _cboRateType = value;
                if (_cboRateType != null)
                {
                    _cboRateType.SelectedIndexChanged += cboRateType_SelectedIndexChanged;
                }
            }
        }

        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        private DateTimePicker _dtpEndDate;

        internal DateTimePicker dtpEndDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dtpEndDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dtpEndDate != null)
                {
                    _dtpEndDate.ValueChanged -= dtpEndDate_ValueChanged;
                }

                _dtpEndDate = value;
                if (_dtpEndDate != null)
                {
                    _dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
                }
            }
        }

        internal Label Label7;
        internal NumericUpDown NumericUpDown1;
        internal BindingSource toCompaniesBS;
        internal BindingSource DrayageRateBindingSource;
        internal BindingSource truckCompaniesBS;
        internal DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn;
        internal DataGridViewCheckBoxColumn Column2;
        internal DataGridViewTextBoxColumn Code;
        internal DataGridViewTextBoxColumn NameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn1;
        internal DataGridViewCheckBoxColumn Column1;
        internal DataGridViewTextBoxColumn CodeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn NameDataGridViewTextBoxColumn1;
        internal Label Label9;
        internal Panel Panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvAssignedRates;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvAssignedRates
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvAssignedRates;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvAssignedRates != null)
                {
                    _dgvAssignedRates.CellContentClick -= dgvAssignedRates_CellContentClick;
                }

                _dgvAssignedRates = value;
                if (_dgvAssignedRates != null)
                {
                    _dgvAssignedRates.CellContentClick += dgvAssignedRates_CellContentClick;
                }
            }
        }

        internal Label Label10;
        internal BindingSource DrayageSchemeRateBindingSource;
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

        private ComboBox _cboStartDate;

        internal ComboBox cboStartDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboStartDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboStartDate != null)
                {
                    _cboStartDate.SelectedIndexChanged -= cboStartDate_SelectedIndexChanged;
                }

                _cboStartDate = value;
                if (_cboStartDate != null)
                {
                    _cboStartDate.SelectedIndexChanged += cboStartDate_SelectedIndexChanged;
                }
            }
        }

        internal DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
        internal DataGridViewTextBoxColumn DrayageRateIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DrayageSchemeIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn TruckingCompanyId;
        internal DataGridViewTextBoxColumn FromDockId;
        internal DataGridViewTextBoxColumn ToDockId;
        internal DataGridViewTextBoxColumn FromDock;
        internal DataGridViewTextBoxColumn ToDock;
        internal DataGridViewTextBoxColumn RateTypeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn FromDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ToDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn RateDataGridViewTextBoxColumn;
        internal Label Label11;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _deleteButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _deleteButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_deleteButton != null)
                {
                    _deleteButton.Click -= deleteButton_Click;
                }

                _deleteButton = value;
                if (_deleteButton != null)
                {
                    _deleteButton.Click += deleteButton_Click;
                }
            }
        }
    }
}