using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmStoreFiles : Form
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
            var DataGridViewCellStyle13 = new DataGridViewCellStyle();
            var DataGridViewCellStyle14 = new DataGridViewCellStyle();
            var DataGridViewCellStyle17 = new DataGridViewCellStyle();
            var DataGridViewCellStyle18 = new DataGridViewCellStyle();
            var DataGridViewCellStyle15 = new DataGridViewCellStyle();
            var DataGridViewCellStyle16 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreFiles));
            var BorderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label2 = new Label();
            _dgvEmployees = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvEmployees.DoubleClick += new EventHandler(dgvEmployees_DoubleClick);
            DocumentsStoredIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            IssueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ExpireDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            EmployeeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DocumentsStoredTypeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DocumentsStoredDepartmentIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DocumentsStoredDepartmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DocumentsStoredBindingSource = new BindingSource(components);
            _ddlEmployee = new Bunifu.UI.WinForms.BunifuDropdown();
            _ddlEmployee.SelectedIndexChanged += new EventHandler(ddlEmployee_SelectedIndexChanged);
            EmployeeNameBindingSource = new BindingSource(components);
            BunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            _ddlType = new Bunifu.UI.WinForms.BunifuDropdown();
            _ddlType.SelectedIndexChanged += new EventHandler(ddlType_SelectedIndexChanged);
            DocumentsStoredTypeBindingSource = new BindingSource(components);
            BunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            _btnSearchFile = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSearchFile.Click += new EventHandler(btnSearchFile_Click);
            _btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAdd.Click += new EventHandler(btnAdd_Click);
            _btnClose = new Label();
            _btnClose.Click += new EventHandler(closeLabel_Click);
            BunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            _ddlArea = new Bunifu.UI.WinForms.BunifuDropdown();
            _ddlArea.SelectedIndexChanged += new EventHandler(ddlArea_SelectedIndexChanged);
            DocumentsStoredDepartmentBindingSource = new BindingSource(components);
            DocumentsStoredServiceBindingSource = new BindingSource(components);
            TableLayoutPanel1 = new TableLayoutPanel();
            BunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            _ckbDate = new Bunifu.UI.WinForms.BunifuCheckBox();
            _ckbDate.Click += new EventHandler(ckbDate_Click);
            _rbIssueDate = new Bunifu.UI.WinForms.BunifuRadioButton();
            _rbIssueDate.Click += new EventHandler(rbIssueDate_Click);
            _rbExpireDate = new Bunifu.UI.WinForms.BunifuRadioButton();
            _rbExpireDate.Click += new EventHandler(rbExpireDate_Click);
            lblIssueDate = new Bunifu.UI.WinForms.BunifuLabel();
            lblExpireDate = new Bunifu.UI.WinForms.BunifuLabel();
            Panel1 = new Panel();
            BunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            _btnDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnDelete.Click += new EventHandler(btnDelete_Click);
            BunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            _txtEndDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            _txtEndDate.ValueChanged += new EventHandler(txtEndDate_ValueChanged_1);
            _txtStartDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            _txtStartDate.ValueChanged += new EventHandler(txtStartDate_ValueChanged_1);
            BunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            _txtFileType = new TextBox();
            _txtFileType.TextChanged += new EventHandler(txtFileType_TextChange);
            _txtDecription = new TextBox();
            _txtDecription.TextChanged += new EventHandler(txtDecription_TextChanged);
            ((System.ComponentModel.ISupportInitialize)_dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeNameBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredDepartmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredServiceBindingSource).BeginInit();
            TableLayoutPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(1521, -3);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(40, 41);
            _closeLabel.TabIndex = 144;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            Label2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Dock = DockStyle.Top;
            Label2.Font = new Font("Microsoft Sans Serif", 22.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.WhiteSmoke;
            Label2.Location = new Point(0, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(1561, 41);
            Label2.TabIndex = 143;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvEmployees
            // 
            _dgvEmployees.AllowCustomTheming = true;
            _dgvEmployees.AllowUserToAddRows = false;
            _dgvEmployees.AllowUserToDeleteRows = false;
            _dgvEmployees.AllowUserToResizeColumns = false;
            _dgvEmployees.AllowUserToResizeRows = false;
            DataGridViewCellStyle13.BackColor = Color.White;
            DataGridViewCellStyle13.ForeColor = Color.Black;
            DataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvEmployees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13;
            _dgvEmployees.AutoGenerateColumns = false;
            _dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvEmployees.BackgroundColor = Color.White;
            _dgvEmployees.BorderStyle = BorderStyle.None;
            _dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle14.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle14.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle14.ForeColor = Color.White;
            DataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            _dgvEmployees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14;
            _dgvEmployees.ColumnHeadersHeight = 40;
            _dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { DocumentsStoredIdDataGridViewTextBoxColumn, DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn2, IssueDateDataGridViewTextBoxColumn, ExpireDateDataGridViewTextBoxColumn, DataGridViewTextBoxColumn3, EmployeeIdDataGridViewTextBoxColumn, DocumentsStoredTypeIdDataGridViewTextBoxColumn, DocumentsStoredDepartmentIdDataGridViewTextBoxColumn, DocumentsStoredDepartmentDataGridViewTextBoxColumn });
            _dgvEmployees.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvEmployees.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvEmployees.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvEmployees.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvEmployees.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvEmployees.CurrentTheme.BackColor = Color.Snow;
            _dgvEmployees.CurrentTheme.GridColor = Color.Gray;
            _dgvEmployees.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvEmployees.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvEmployees.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvEmployees.CurrentTheme.Name = null;
            _dgvEmployees.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvEmployees.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvEmployees.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvEmployees.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvEmployees.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvEmployees.DataSource = DocumentsStoredBindingSource;
            DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle17.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle17.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle17.ForeColor = Color.Black;
            DataGridViewCellStyle17.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle17.SelectionForeColor = Color.Black;
            DataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            _dgvEmployees.DefaultCellStyle = DataGridViewCellStyle17;
            _dgvEmployees.Dock = DockStyle.Fill;
            _dgvEmployees.EnableHeadersVisualStyles = false;
            _dgvEmployees.GridColor = Color.Gray;
            _dgvEmployees.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvEmployees.HeaderBgColor = Color.Empty;
            _dgvEmployees.HeaderForeColor = Color.White;
            _dgvEmployees.Location = new Point(0, 0);
            _dgvEmployees.MultiSelect = false;
            _dgvEmployees.Name = "_dgvEmployees";
            _dgvEmployees.ReadOnly = true;
            DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle18.BackColor = SystemColors.Control;
            DataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            _dgvEmployees.RowHeadersDefaultCellStyle = DataGridViewCellStyle18;
            _dgvEmployees.RowHeadersVisible = false;
            _dgvEmployees.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvEmployees.RowTemplate.Height = 40;
            _dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvEmployees.Size = new Size(1448, 562);
            _dgvEmployees.TabIndex = 189;
            _dgvEmployees.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // DocumentsStoredIdDataGridViewTextBoxColumn
            // 
            DocumentsStoredIdDataGridViewTextBoxColumn.DataPropertyName = "DocumentsStoredId";
            DocumentsStoredIdDataGridViewTextBoxColumn.HeaderText = "ID";
            DocumentsStoredIdDataGridViewTextBoxColumn.MinimumWidth = 50;
            DocumentsStoredIdDataGridViewTextBoxColumn.Name = "DocumentsStoredIdDataGridViewTextBoxColumn";
            DocumentsStoredIdDataGridViewTextBoxColumn.ReadOnly = true;
            DocumentsStoredIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "FileTitle";
            DataGridViewTextBoxColumn1.FillWeight = 26.08145f;
            DataGridViewTextBoxColumn1.HeaderText = "File Type";
            DataGridViewTextBoxColumn1.MinimumWidth = 200;
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewTextBoxColumn4.DataPropertyName = "FileName";
            DataGridViewTextBoxColumn4.FillWeight = 449.2386f;
            DataGridViewTextBoxColumn4.HeaderText = "File";
            DataGridViewTextBoxColumn4.MinimumWidth = 480;
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.DataPropertyName = "FileDescription";
            DataGridViewTextBoxColumn2.FillWeight = 0.6190484f;
            DataGridViewTextBoxColumn2.HeaderText = "Description";
            DataGridViewTextBoxColumn2.MinimumWidth = 400;
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // IssueDateDataGridViewTextBoxColumn
            // 
            IssueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            DataGridViewCellStyle15.Format = "dd/MMM/yyyy";
            DataGridViewCellStyle15.NullValue = null;
            IssueDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15;
            IssueDateDataGridViewTextBoxColumn.FillWeight = 13.15637f;
            IssueDateDataGridViewTextBoxColumn.HeaderText = "Issue Date";
            IssueDateDataGridViewTextBoxColumn.MinimumWidth = 150;
            IssueDateDataGridViewTextBoxColumn.Name = "IssueDateDataGridViewTextBoxColumn";
            IssueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ExpireDateDataGridViewTextBoxColumn
            // 
            ExpireDateDataGridViewTextBoxColumn.DataPropertyName = "ExpireDate";
            DataGridViewCellStyle16.Format = "dd/MMM/yyyy";
            DataGridViewCellStyle16.NullValue = null;
            ExpireDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle16;
            ExpireDateDataGridViewTextBoxColumn.FillWeight = 10.90454f;
            ExpireDateDataGridViewTextBoxColumn.HeaderText = "Expire Date";
            ExpireDateDataGridViewTextBoxColumn.MinimumWidth = 150;
            ExpireDateDataGridViewTextBoxColumn.Name = "ExpireDateDataGridViewTextBoxColumn";
            ExpireDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.DataPropertyName = "ServerPath";
            DataGridViewTextBoxColumn3.HeaderText = "ServerPath";
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            DataGridViewTextBoxColumn3.Visible = false;
            // 
            // EmployeeIdDataGridViewTextBoxColumn
            // 
            EmployeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            EmployeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            EmployeeIdDataGridViewTextBoxColumn.MinimumWidth = 150;
            EmployeeIdDataGridViewTextBoxColumn.Name = "EmployeeIdDataGridViewTextBoxColumn";
            EmployeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            EmployeeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // DocumentsStoredTypeIdDataGridViewTextBoxColumn
            // 
            DocumentsStoredTypeIdDataGridViewTextBoxColumn.DataPropertyName = "DocumentsStoredTypeId";
            DocumentsStoredTypeIdDataGridViewTextBoxColumn.HeaderText = "DocumentsStoredTypeId";
            DocumentsStoredTypeIdDataGridViewTextBoxColumn.Name = "DocumentsStoredTypeIdDataGridViewTextBoxColumn";
            DocumentsStoredTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            DocumentsStoredTypeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // DocumentsStoredDepartmentIdDataGridViewTextBoxColumn
            // 
            DocumentsStoredDepartmentIdDataGridViewTextBoxColumn.DataPropertyName = "DocumentsStoredDepartmentId";
            DocumentsStoredDepartmentIdDataGridViewTextBoxColumn.HeaderText = "DocumentsStoredDepartmentId";
            DocumentsStoredDepartmentIdDataGridViewTextBoxColumn.Name = "DocumentsStoredDepartmentIdDataGridViewTextBoxColumn";
            DocumentsStoredDepartmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            DocumentsStoredDepartmentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // DocumentsStoredDepartmentDataGridViewTextBoxColumn
            // 
            DocumentsStoredDepartmentDataGridViewTextBoxColumn.DataPropertyName = "DocumentsStoredDepartment";
            DocumentsStoredDepartmentDataGridViewTextBoxColumn.HeaderText = "DocumentsStoredDepartment";
            DocumentsStoredDepartmentDataGridViewTextBoxColumn.Name = "DocumentsStoredDepartmentDataGridViewTextBoxColumn";
            DocumentsStoredDepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            DocumentsStoredDepartmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // DocumentsStoredBindingSource
            // 
            DocumentsStoredBindingSource.DataSource = typeof(ModelLayer.DocumentsStored);
            // 
            // ddlEmployee
            // 
            _ddlEmployee.BackColor = Color.White;
            _ddlEmployee.BorderRadius = 1;
            _ddlEmployee.Color = Color.Gray;
            _ddlEmployee.DataSource = EmployeeNameBindingSource;
            _ddlEmployee.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _ddlEmployee.DisabledColor = Color.Gray;
            _ddlEmployee.DisplayMember = "FisrtNameLastName";
            _ddlEmployee.DrawMode = DrawMode.OwnerDrawFixed;
            _ddlEmployee.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            _ddlEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            _ddlEmployee.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _ddlEmployee.FillDropDown = false;
            _ddlEmployee.FillIndicator = false;
            _ddlEmployee.FlatStyle = FlatStyle.Flat;
            _ddlEmployee.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ddlEmployee.ForeColor = Color.Black;
            _ddlEmployee.FormattingEnabled = true;
            _ddlEmployee.Icon = null;
            _ddlEmployee.IndicatorColor = Color.Gray;
            _ddlEmployee.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _ddlEmployee.ItemBackColor = Color.White;
            _ddlEmployee.ItemBorderColor = Color.White;
            _ddlEmployee.ItemForeColor = Color.Black;
            _ddlEmployee.ItemHeight = 26;
            _ddlEmployee.ItemHighLightColor = Color.DodgerBlue;
            _ddlEmployee.Location = new Point(718, 114);
            _ddlEmployee.Name = "_ddlEmployee";
            _ddlEmployee.Size = new Size(564, 32);
            _ddlEmployee.TabIndex = 196;
            _ddlEmployee.Text = null;
            _ddlEmployee.ValueMember = "EmployeeId";
            // 
            // EmployeeNameBindingSource
            // 
            EmployeeNameBindingSource.DataSource = typeof(ModelLayer.CustomModel.EmployeeName);
            // 
            // BunifuLabel1
            // 
            BunifuLabel1.AutoEllipsis = false;
            BunifuLabel1.CursorType = null;
            BunifuLabel1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel1.Location = new Point(636, 120);
            BunifuLabel1.Name = "BunifuLabel1";
            BunifuLabel1.RightToLeft = RightToLeft.No;
            BunifuLabel1.Size = new Size(77, 22);
            BunifuLabel1.TabIndex = 195;
            BunifuLabel1.Text = "Employee:";
            BunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel2
            // 
            BunifuLabel2.AutoEllipsis = false;
            BunifuLabel2.CursorType = null;
            BunifuLabel2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel2.Location = new Point(671, 160);
            BunifuLabel2.Name = "BunifuLabel2";
            BunifuLabel2.RightToLeft = RightToLeft.No;
            BunifuLabel2.Size = new Size(42, 22);
            BunifuLabel2.TabIndex = 193;
            BunifuLabel2.Text = "Start:";
            BunifuLabel2.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ddlType
            // 
            _ddlType.BackColor = Color.White;
            _ddlType.BorderRadius = 1;
            _ddlType.Color = Color.Gray;
            _ddlType.DataSource = DocumentsStoredTypeBindingSource;
            _ddlType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _ddlType.DisabledColor = Color.Gray;
            _ddlType.DisplayMember = "DescDocumentsStoredType";
            _ddlType.DrawMode = DrawMode.OwnerDrawFixed;
            _ddlType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            _ddlType.DropDownStyle = ComboBoxStyle.DropDownList;
            _ddlType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _ddlType.Enabled = false;
            _ddlType.FillDropDown = false;
            _ddlType.FillIndicator = false;
            _ddlType.FlatStyle = FlatStyle.Flat;
            _ddlType.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ddlType.ForeColor = Color.Black;
            _ddlType.FormattingEnabled = true;
            _ddlType.Icon = null;
            _ddlType.IndicatorColor = Color.Gray;
            _ddlType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _ddlType.ItemBackColor = Color.White;
            _ddlType.ItemBorderColor = Color.White;
            _ddlType.ItemForeColor = Color.Black;
            _ddlType.ItemHeight = 26;
            _ddlType.ItemHighLightColor = Color.DodgerBlue;
            _ddlType.Location = new Point(176, 189);
            _ddlType.Name = "_ddlType";
            _ddlType.Size = new Size(415, 32);
            _ddlType.TabIndex = 192;
            _ddlType.Text = null;
            _ddlType.ValueMember = "DocumentsStoredTypeId";
            // 
            // DocumentsStoredTypeBindingSource
            // 
            DocumentsStoredTypeBindingSource.DataSource = typeof(ModelLayer.DocumentsStoredType);
            // 
            // BunifuLabel3
            // 
            BunifuLabel3.AutoEllipsis = false;
            BunifuLabel3.CursorType = null;
            BunifuLabel3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel3.Location = new Point(94, 194);
            BunifuLabel3.Name = "BunifuLabel3";
            BunifuLabel3.RightToLeft = RightToLeft.No;
            BunifuLabel3.Size = new Size(78, 22);
            BunifuLabel3.TabIndex = 191;
            BunifuLabel3.Text = "Doc. Type:";
            BunifuLabel3.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnSearchFile
            // 
            _btnSearchFile.AllowToggling = false;
            _btnSearchFile.AnimationSpeed = 200;
            _btnSearchFile.AutoGenerateColors = false;
            _btnSearchFile.BackColor = Color.Transparent;
            _btnSearchFile.BackColor1 = Color.DodgerBlue;
            _btnSearchFile.BackgroundImage = (Image)resources.GetObject("btnSearchFile.BackgroundImage");
            _btnSearchFile.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnSearchFile.ButtonText = "Search";
            _btnSearchFile.ButtonTextMarginLeft = 15;
            _btnSearchFile.ColorContrastOnClick = 45;
            _btnSearchFile.ColorContrastOnHover = 45;
            _btnSearchFile.Cursor = Cursors.Hand;
            BorderEdges7.BottomLeft = true;
            BorderEdges7.BottomRight = true;
            BorderEdges7.TopLeft = true;
            BorderEdges7.TopRight = true;
            _btnSearchFile.CustomizableEdges = BorderEdges7;
            _btnSearchFile.DialogResult = DialogResult.None;
            _btnSearchFile.DisabledBorderColor = Color.Empty;
            _btnSearchFile.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSearchFile.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSearchFile.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSearchFile.Font = new Font("Segoe UI Semibold", 12.0f);
            _btnSearchFile.ForeColor = Color.White;
            _btnSearchFile.IconLeftCursor = Cursors.Hand;
            _btnSearchFile.IconMarginLeft = 10;
            _btnSearchFile.IconPadding = 10;
            _btnSearchFile.IconRightCursor = Cursors.Hand;
            _btnSearchFile.IdleBorderColor = Color.DodgerBlue;
            _btnSearchFile.IdleBorderRadius = 3;
            _btnSearchFile.IdleBorderThickness = 1;
            _btnSearchFile.IdleFillColor = Color.DodgerBlue;
            _btnSearchFile.IdleIconLeftImage = (Image)resources.GetObject("btnSearchFile.IdleIconLeftImage");
            _btnSearchFile.IdleIconRightImage = null;
            _btnSearchFile.IndicateFocus = false;
            _btnSearchFile.Location = new Point(1316, 111);
            _btnSearchFile.Name = "_btnSearchFile";
            StateProperties13.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties13.BorderRadius = 3;
            StateProperties13.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties13.BorderThickness = 1;
            StateProperties13.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties13.ForeColor = Color.White;
            StateProperties13.IconLeftImage = null;
            StateProperties13.IconRightImage = null;
            _btnSearchFile.onHoverState = StateProperties13;
            StateProperties14.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties14.BorderRadius = 3;
            StateProperties14.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties14.BorderThickness = 1;
            StateProperties14.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties14.ForeColor = Color.White;
            StateProperties14.IconLeftImage = null;
            StateProperties14.IconRightImage = null;
            _btnSearchFile.OnPressedState = StateProperties14;
            _btnSearchFile.RightToLeft = RightToLeft.No;
            _btnSearchFile.Size = new Size(176, 38);
            _btnSearchFile.TabIndex = 197;
            _btnSearchFile.TextAlign = ContentAlignment.MiddleCenter;
            _btnSearchFile.TextMarginLeft = 15;
            _btnSearchFile.UseDefaultRadiusAndThickness = true;
            // 
            // btnAdd
            // 
            _btnAdd.AllowToggling = false;
            _btnAdd.AnimationSpeed = 200;
            _btnAdd.AutoGenerateColors = false;
            _btnAdd.BackColor = Color.Transparent;
            _btnAdd.BackColor1 = Color.Teal;
            _btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            _btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAdd.ButtonText = "Add";
            _btnAdd.ButtonTextMarginLeft = 0;
            _btnAdd.ColorContrastOnClick = 45;
            _btnAdd.ColorContrastOnHover = 45;
            _btnAdd.Cursor = Cursors.Hand;
            BorderEdges8.BottomLeft = true;
            BorderEdges8.BottomRight = true;
            BorderEdges8.TopLeft = true;
            BorderEdges8.TopRight = true;
            _btnAdd.CustomizableEdges = BorderEdges8;
            _btnAdd.DialogResult = DialogResult.None;
            _btnAdd.DisabledBorderColor = Color.Empty;
            _btnAdd.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAdd.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAdd.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAdd.ForeColor = Color.White;
            _btnAdd.IconLeftCursor = Cursors.Hand;
            _btnAdd.IconMarginLeft = 11;
            _btnAdd.IconPadding = 10;
            _btnAdd.IconRightCursor = Cursors.Hand;
            _btnAdd.IdleBorderColor = Color.Teal;
            _btnAdd.IdleBorderRadius = 3;
            _btnAdd.IdleBorderThickness = 1;
            _btnAdd.IdleFillColor = Color.Teal;
            _btnAdd.IdleIconLeftImage = null;
            _btnAdd.IdleIconRightImage = null;
            _btnAdd.IndicateFocus = true;
            _btnAdd.Location = new Point(1316, 158);
            _btnAdd.Name = "_btnAdd";
            StateProperties15.BorderColor = Color.MediumTurquoise;
            StateProperties15.BorderRadius = 3;
            StateProperties15.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties15.BorderThickness = 1;
            StateProperties15.FillColor = Color.MediumTurquoise;
            StateProperties15.ForeColor = Color.White;
            StateProperties15.IconLeftImage = null;
            StateProperties15.IconRightImage = null;
            _btnAdd.onHoverState = StateProperties15;
            StateProperties16.BorderColor = Color.Teal;
            StateProperties16.BorderRadius = 3;
            StateProperties16.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties16.BorderThickness = 1;
            StateProperties16.FillColor = Color.Teal;
            StateProperties16.ForeColor = Color.White;
            StateProperties16.IconLeftImage = null;
            StateProperties16.IconRightImage = null;
            _btnAdd.OnPressedState = StateProperties16;
            _btnAdd.Size = new Size(176, 38);
            _btnAdd.TabIndex = 198;
            _btnAdd.TextAlign = ContentAlignment.MiddleCenter;
            _btnAdd.TextMarginLeft = 0;
            _btnAdd.UseDefaultRadiusAndThickness = true;
            // 
            // btnClose
            // 
            _btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnClose.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _btnClose.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClose.ForeColor = Color.White;
            _btnClose.Location = new Point(1521, 0);
            _btnClose.Margin = new Padding(0);
            _btnClose.Name = "_btnClose";
            _btnClose.Size = new Size(40, 41);
            _btnClose.TabIndex = 202;
            _btnClose.Text = "🗙";
            _btnClose.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuLabel4
            // 
            BunifuLabel4.AutoEllipsis = false;
            BunifuLabel4.CursorType = null;
            BunifuLabel4.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel4.Location = new Point(677, 198);
            BunifuLabel4.Name = "BunifuLabel4";
            BunifuLabel4.RightToLeft = RightToLeft.No;
            BunifuLabel4.Size = new Size(36, 22);
            BunifuLabel4.TabIndex = 203;
            BunifuLabel4.Text = "End:";
            BunifuLabel4.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel5
            // 
            BunifuLabel5.AutoEllipsis = false;
            BunifuLabel5.CursorType = null;
            BunifuLabel5.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel5.Location = new Point(80, 160);
            BunifuLabel5.Name = "BunifuLabel5";
            BunifuLabel5.RightToLeft = RightToLeft.No;
            BunifuLabel5.Size = new Size(92, 22);
            BunifuLabel5.TabIndex = 210;
            BunifuLabel5.Text = "Department:";
            BunifuLabel5.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ddlArea
            // 
            _ddlArea.BackColor = Color.White;
            _ddlArea.BorderRadius = 1;
            _ddlArea.Color = Color.Gray;
            _ddlArea.DataSource = DocumentsStoredDepartmentBindingSource;
            _ddlArea.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _ddlArea.DisabledColor = Color.Gray;
            _ddlArea.DisplayMember = "DescDocumentsStoredDepartment";
            _ddlArea.DrawMode = DrawMode.OwnerDrawFixed;
            _ddlArea.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            _ddlArea.DropDownStyle = ComboBoxStyle.DropDownList;
            _ddlArea.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _ddlArea.FillDropDown = false;
            _ddlArea.FillIndicator = false;
            _ddlArea.FlatStyle = FlatStyle.Flat;
            _ddlArea.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ddlArea.ForeColor = Color.Black;
            _ddlArea.FormattingEnabled = true;
            _ddlArea.Icon = null;
            _ddlArea.IndicatorColor = Color.Gray;
            _ddlArea.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _ddlArea.ItemBackColor = Color.White;
            _ddlArea.ItemBorderColor = Color.White;
            _ddlArea.ItemForeColor = Color.Black;
            _ddlArea.ItemHeight = 26;
            _ddlArea.ItemHighLightColor = Color.DodgerBlue;
            _ddlArea.Location = new Point(176, 153);
            _ddlArea.Name = "_ddlArea";
            _ddlArea.Size = new Size(415, 32);
            _ddlArea.TabIndex = 209;
            _ddlArea.Text = null;
            _ddlArea.ValueMember = "DocumentsStoredDepartmentId";
            // 
            // DocumentsStoredDepartmentBindingSource
            // 
            DocumentsStoredDepartmentBindingSource.DataSource = typeof(ModelLayer.DocumentsStoredDepartment);
            // 
            // DocumentsStoredServiceBindingSource
            // 
            DocumentsStoredServiceBindingSource.DataSource = typeof(BusinessLayer.WTC_Ceres.DocumentsStoredService);
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel1.Controls.Add(BunifuLabel6, 1, 0);
            TableLayoutPanel1.Controls.Add(_ckbDate, 0, 0);
            TableLayoutPanel1.Controls.Add(_rbIssueDate, 0, 1);
            TableLayoutPanel1.Controls.Add(_rbExpireDate, 0, 2);
            TableLayoutPanel1.Controls.Add(lblIssueDate, 1, 1);
            TableLayoutPanel1.Controls.Add(lblExpireDate, 1, 2);
            TableLayoutPanel1.Location = new Point(943, 152);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 3;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25.0f));
            TableLayoutPanel1.Size = new Size(120, 75);
            TableLayoutPanel1.TabIndex = 213;
            // 
            // BunifuLabel6
            // 
            BunifuLabel6.AutoEllipsis = false;
            BunifuLabel6.CursorType = null;
            BunifuLabel6.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel6.Location = new Point(28, 3);
            BunifuLabel6.Name = "BunifuLabel6";
            BunifuLabel6.RightToLeft = RightToLeft.No;
            BunifuLabel6.Size = new Size(36, 18);
            BunifuLabel6.TabIndex = 225;
            BunifuLabel6.Text = "Date";
            BunifuLabel6.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ckbDate
            // 
            _ckbDate.AllowBindingControlAnimation = true;
            _ckbDate.AllowBindingControlColorChanges = false;
            _ckbDate.AllowBindingControlLocation = true;
            _ckbDate.AllowCheckBoxAnimation = false;
            _ckbDate.AllowCheckmarkAnimation = true;
            _ckbDate.AllowOnHoverStates = true;
            _ckbDate.AutoCheck = true;
            _ckbDate.BackColor = Color.Transparent;
            _ckbDate.BackgroundImage = (Image)resources.GetObject("ckbDate.BackgroundImage");
            _ckbDate.BackgroundImageLayout = ImageLayout.Zoom;
            _ckbDate.BindingControl = null;
            _ckbDate.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            _ckbDate.Checked = false;
            _ckbDate.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            _ckbDate.Cursor = Cursors.Hand;
            _ckbDate.CustomCheckmarkImage = null;
            _ckbDate.Location = new Point(3, 3);
            _ckbDate.MinimumSize = new Size(17, 17);
            _ckbDate.Name = "_ckbDate";
            _ckbDate.OnCheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ckbDate.OnCheck.BorderRadius = 2;
            _ckbDate.OnCheck.BorderThickness = 2;
            _ckbDate.OnCheck.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(128)));
            _ckbDate.OnCheck.CheckmarkColor = Color.White;
            _ckbDate.OnCheck.CheckmarkThickness = 2;
            _ckbDate.OnDisable.BorderColor = Color.LightGray;
            _ckbDate.OnDisable.BorderRadius = 2;
            _ckbDate.OnDisable.BorderThickness = 2;
            _ckbDate.OnDisable.CheckBoxColor = Color.Transparent;
            _ckbDate.OnDisable.CheckmarkColor = Color.LightGray;
            _ckbDate.OnDisable.CheckmarkThickness = 2;
            _ckbDate.OnHoverChecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(128)));
            _ckbDate.OnHoverChecked.BorderRadius = 2;
            _ckbDate.OnHoverChecked.BorderThickness = 2;
            _ckbDate.OnHoverChecked.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(128)));
            _ckbDate.OnHoverChecked.CheckmarkColor = Color.White;
            _ckbDate.OnHoverChecked.CheckmarkThickness = 2;
            _ckbDate.OnHoverUnchecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(128)));
            _ckbDate.OnHoverUnchecked.BorderRadius = 2;
            _ckbDate.OnHoverUnchecked.BorderThickness = 2;
            _ckbDate.OnHoverUnchecked.CheckBoxColor = Color.Transparent;
            _ckbDate.OnUncheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ckbDate.OnUncheck.BorderRadius = 2;
            _ckbDate.OnUncheck.BorderThickness = 2;
            _ckbDate.OnUncheck.CheckBoxColor = Color.Transparent;
            _ckbDate.Size = new Size(19, 19);
            _ckbDate.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            _ckbDate.TabIndex = 244;
            _ckbDate.ThreeState = false;
            _ckbDate.ToolTipText = null;
            // 
            // rbIssueDate
            // 
            _rbIssueDate.Checked = false;
            _rbIssueDate.Location = new Point(3, 29);
            _rbIssueDate.Name = "_rbIssueDate";
            _rbIssueDate.OutlineColor = Color.Purple;
            _rbIssueDate.RadioColor = Color.Purple;
            _rbIssueDate.Size = new Size(19, 19);
            _rbIssueDate.TabIndex = 223;
            _rbIssueDate.Text = null;
            _rbIssueDate.Visible = false;
            // 
            // rbExpireDate
            // 
            _rbExpireDate.Checked = true;
            _rbExpireDate.Location = new Point(3, 53);
            _rbExpireDate.Name = "_rbExpireDate";
            _rbExpireDate.OutlineColor = Color.Purple;
            _rbExpireDate.RadioColor = Color.Purple;
            _rbExpireDate.Size = new Size(19, 19);
            _rbExpireDate.TabIndex = 222;
            _rbExpireDate.Text = null;
            _rbExpireDate.Visible = false;
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoEllipsis = false;
            lblIssueDate.CursorType = null;
            lblIssueDate.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblIssueDate.Location = new Point(28, 29);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.RightToLeft = RightToLeft.No;
            lblIssueDate.Size = new Size(77, 18);
            lblIssueDate.TabIndex = 219;
            lblIssueDate.Text = "Issue Date";
            lblIssueDate.TextAlignment = ContentAlignment.TopLeft;
            lblIssueDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            lblIssueDate.Visible = false;
            // 
            // lblExpireDate
            // 
            lblExpireDate.AutoEllipsis = false;
            lblExpireDate.CursorType = null;
            lblExpireDate.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblExpireDate.Location = new Point(28, 53);
            lblExpireDate.Name = "lblExpireDate";
            lblExpireDate.RightToLeft = RightToLeft.No;
            lblExpireDate.Size = new Size(84, 18);
            lblExpireDate.TabIndex = 221;
            lblExpireDate.Text = "Expire Date";
            lblExpireDate.TextAlignment = ContentAlignment.TopLeft;
            lblExpireDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            lblExpireDate.Visible = false;
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(_dgvEmployees);
            Panel1.Location = new Point(43, 275);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1450, 564);
            Panel1.TabIndex = 226;
            // 
            // BunifuLabel8
            // 
            BunifuLabel8.AutoEllipsis = false;
            BunifuLabel8.CursorType = null;
            BunifuLabel8.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel8.Location = new Point(108, 122);
            BunifuLabel8.Name = "BunifuLabel8";
            BunifuLabel8.RightToLeft = RightToLeft.No;
            BunifuLabel8.Size = new Size(65, 22);
            BunifuLabel8.TabIndex = 227;
            BunifuLabel8.Text = "File Title:";
            BunifuLabel8.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnDelete
            // 
            _btnDelete.AllowToggling = false;
            _btnDelete.AnimationSpeed = 200;
            _btnDelete.AutoGenerateColors = false;
            _btnDelete.BackColor = Color.Transparent;
            _btnDelete.BackColor1 = Color.IndianRed;
            _btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            _btnDelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnDelete.ButtonText = "Delete";
            _btnDelete.ButtonTextMarginLeft = 0;
            _btnDelete.ColorContrastOnClick = 45;
            _btnDelete.ColorContrastOnHover = 45;
            _btnDelete.Cursor = Cursors.Hand;
            BorderEdges9.BottomLeft = true;
            BorderEdges9.BottomRight = true;
            BorderEdges9.TopLeft = true;
            BorderEdges9.TopRight = true;
            _btnDelete.CustomizableEdges = BorderEdges9;
            _btnDelete.DialogResult = DialogResult.None;
            _btnDelete.DisabledBorderColor = Color.Empty;
            _btnDelete.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnDelete.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnDelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnDelete.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnDelete.ForeColor = Color.White;
            _btnDelete.IconLeftCursor = Cursors.Hand;
            _btnDelete.IconMarginLeft = 11;
            _btnDelete.IconPadding = 10;
            _btnDelete.IconRightCursor = Cursors.Hand;
            _btnDelete.IdleBorderColor = Color.IndianRed;
            _btnDelete.IdleBorderRadius = 3;
            _btnDelete.IdleBorderThickness = 1;
            _btnDelete.IdleFillColor = Color.IndianRed;
            _btnDelete.IdleIconLeftImage = null;
            _btnDelete.IdleIconRightImage = null;
            _btnDelete.IndicateFocus = true;
            _btnDelete.Location = new Point(1316, 205);
            _btnDelete.Name = "_btnDelete";
            StateProperties17.BorderColor = Color.Salmon;
            StateProperties17.BorderRadius = 3;
            StateProperties17.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties17.BorderThickness = 1;
            StateProperties17.FillColor = Color.Salmon;
            StateProperties17.ForeColor = Color.White;
            StateProperties17.IconLeftImage = null;
            StateProperties17.IconRightImage = null;
            _btnDelete.onHoverState = StateProperties17;
            StateProperties18.BorderColor = Color.IndianRed;
            StateProperties18.BorderRadius = 3;
            StateProperties18.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties18.BorderThickness = 1;
            StateProperties18.FillColor = Color.IndianRed;
            StateProperties18.ForeColor = Color.White;
            StateProperties18.IconLeftImage = null;
            StateProperties18.IconRightImage = null;
            _btnDelete.OnPressedState = StateProperties18;
            _btnDelete.Size = new Size(176, 38);
            _btnDelete.TabIndex = 230;
            _btnDelete.TextAlign = ContentAlignment.MiddleCenter;
            _btnDelete.TextMarginLeft = 0;
            _btnDelete.UseDefaultRadiusAndThickness = true;
            _btnDelete.Visible = false;
            // 
            // BunifuLabel7
            // 
            BunifuLabel7.AutoEllipsis = false;
            BunifuLabel7.CursorType = null;
            BunifuLabel7.Font = new Font("Microsoft Sans Serif", 14.0f);
            BunifuLabel7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuLabel7.Location = new Point(59, 71);
            BunifuLabel7.Name = "BunifuLabel7";
            BunifuLabel7.RightToLeft = RightToLeft.No;
            BunifuLabel7.Size = new Size(215, 26);
            BunifuLabel7.TabIndex = 231;
            BunifuLabel7.Text = "Documents Management";
            BunifuLabel7.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtEndDate
            // 
            _txtEndDate.BorderRadius = 1;
            _txtEndDate.Color = Color.Gray;
            _txtEndDate.CustomFormat = " ";
            _txtEndDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            _txtEndDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            _txtEndDate.DisabledColor = Color.Gray;
            _txtEndDate.DisplayWeekNumbers = false;
            _txtEndDate.DPHeight = 0;
            _txtEndDate.DropDownAlign = LeftRightAlignment.Right;
            _txtEndDate.Enabled = false;
            _txtEndDate.FillDatePicker = false;
            _txtEndDate.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtEndDate.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _txtEndDate.Format = DateTimePickerFormat.Custom;
            _txtEndDate.Icon = (Image)resources.GetObject("txtEndDate.Icon");
            _txtEndDate.IconColor = Color.Teal;
            _txtEndDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            _txtEndDate.Location = new Point(718, 189);
            _txtEndDate.MinimumSize = new Size(212, 34);
            _txtEndDate.Name = "_txtEndDate";
            _txtEndDate.Size = new Size(214, 34);
            _txtEndDate.TabIndex = 233;
            // 
            // txtStartDate
            // 
            _txtStartDate.BorderRadius = 1;
            _txtStartDate.Color = Color.Gray;
            _txtStartDate.CustomFormat = " ";
            _txtStartDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            _txtStartDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            _txtStartDate.DisabledColor = Color.Gray;
            _txtStartDate.DisplayWeekNumbers = false;
            _txtStartDate.DPHeight = 0;
            _txtStartDate.DropDownAlign = LeftRightAlignment.Right;
            _txtStartDate.Enabled = false;
            _txtStartDate.FillDatePicker = false;
            _txtStartDate.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtStartDate.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _txtStartDate.Format = DateTimePickerFormat.Custom;
            _txtStartDate.Icon = (Image)resources.GetObject("txtStartDate.Icon");
            _txtStartDate.IconColor = Color.Teal;
            _txtStartDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            _txtStartDate.Location = new Point(718, 151);
            _txtStartDate.MinimumSize = new Size(212, 34);
            _txtStartDate.Name = "_txtStartDate";
            _txtStartDate.Size = new Size(214, 34);
            _txtStartDate.TabIndex = 238;
            // 
            // BunifuLabel9
            // 
            BunifuLabel9.AutoEllipsis = false;
            BunifuLabel9.CursorType = null;
            BunifuLabel9.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel9.Location = new Point(54, 234);
            BunifuLabel9.Name = "BunifuLabel9";
            BunifuLabel9.RightToLeft = RightToLeft.No;
            BunifuLabel9.Size = new Size(116, 22);
            BunifuLabel9.TabIndex = 239;
            BunifuLabel9.Text = "File Description:";
            BunifuLabel9.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtFileType
            // 
            _txtFileType.CharacterCasing = CharacterCasing.Upper;
            _txtFileType.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtFileType.Location = new Point(177, 114);
            _txtFileType.MinimumSize = new Size(200, 35);
            _txtFileType.Name = "_txtFileType";
            _txtFileType.Size = new Size(415, 29);
            _txtFileType.TabIndex = 241;
            // 
            // txtDecription
            // 
            _txtDecription.CharacterCasing = CharacterCasing.Upper;
            _txtDecription.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtDecription.Location = new Point(175, 225);
            _txtDecription.MinimumSize = new Size(200, 35);
            _txtDecription.Name = "_txtDecription";
            _txtDecription.Size = new Size(415, 29);
            _txtDecription.TabIndex = 242;
            // 
            // frmStoreFiles
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1561, 919);
            Controls.Add(_txtDecription);
            Controls.Add(_txtFileType);
            Controls.Add(BunifuLabel9);
            Controls.Add(_txtStartDate);
            Controls.Add(_txtEndDate);
            Controls.Add(BunifuLabel7);
            Controls.Add(_btnDelete);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(BunifuLabel8);
            Controls.Add(Panel1);
            Controls.Add(BunifuLabel5);
            Controls.Add(_ddlArea);
            Controls.Add(BunifuLabel4);
            Controls.Add(_btnClose);
            Controls.Add(_btnAdd);
            Controls.Add(_btnSearchFile);
            Controls.Add(_ddlEmployee);
            Controls.Add(BunifuLabel1);
            Controls.Add(BunifuLabel2);
            Controls.Add(_ddlType);
            Controls.Add(BunifuLabel3);
            Controls.Add(_closeLabel);
            Controls.Add(Label2);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStoreFiles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStoreFiles";
            ((System.ComponentModel.ISupportInitialize)_dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeNameBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredDepartmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredServiceBindingSource).EndInit();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            Panel1.ResumeLayout(false);
            Load += new EventHandler(frmStoreFiles_Load);
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
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvEmployees;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvEmployees
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvEmployees;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvEmployees != null)
                {
                    _dgvEmployees.DoubleClick -= dgvEmployees_DoubleClick;
                }

                _dgvEmployees = value;
                if (_dgvEmployees != null)
                {
                    _dgvEmployees.DoubleClick += dgvEmployees_DoubleClick;
                }
            }
        }

        internal DataGridViewTextBoxColumn EmployeeDataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuDropdown _ddlEmployee;

        internal Bunifu.UI.WinForms.BunifuDropdown ddlEmployee
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ddlEmployee;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ddlEmployee != null)
                {
                    _ddlEmployee.SelectedIndexChanged -= ddlEmployee_SelectedIndexChanged;
                }

                _ddlEmployee = value;
                if (_ddlEmployee != null)
                {
                    _ddlEmployee.SelectedIndexChanged += ddlEmployee_SelectedIndexChanged;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel1;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDropdown _ddlType;

        internal Bunifu.UI.WinForms.BunifuDropdown ddlType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ddlType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ddlType != null)
                {
                    _ddlType.SelectedIndexChanged -= ddlType_SelectedIndexChanged;
                }

                _ddlType = value;
                if (_ddlType != null)
                {
                    _ddlType.SelectedIndexChanged += ddlType_SelectedIndexChanged;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnSearchFile;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSearchFile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSearchFile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSearchFile != null)
                {
                    _btnSearchFile.Click -= btnSearchFile_Click;
                }

                _btnSearchFile = value;
                if (_btnSearchFile != null)
                {
                    _btnSearchFile.Click += btnSearchFile_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAdd;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdd != null)
                {
                    _btnAdd.Click -= btnAdd_Click;
                }

                _btnAdd = value;
                if (_btnAdd != null)
                {
                    _btnAdd.Click += btnAdd_Click;
                }
            }
        }

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
                    _btnClose.Click -= closeLabel_Click;
                }

                _btnClose = value;
                if (_btnClose != null)
                {
                    _btnClose.Click += closeLabel_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn StoreFilesIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn FileTitleDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn FileDescriptionDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ServerPathDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn TypeDocDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DueDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn FileNameDataGridViewTextBoxColumn;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel4;
        internal BindingSource EmployeeNameBindingSource;
        internal BindingSource DocumentsStoredTypeBindingSource;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel5;
        private Bunifu.UI.WinForms.BunifuDropdown _ddlArea;

        internal Bunifu.UI.WinForms.BunifuDropdown ddlArea
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ddlArea;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ddlArea != null)
                {
                    _ddlArea.SelectedIndexChanged -= ddlArea_SelectedIndexChanged;
                }

                _ddlArea = value;
                if (_ddlArea != null)
                {
                    _ddlArea.SelectedIndexChanged += ddlArea_SelectedIndexChanged;
                }
            }
        }

        internal BindingSource DocumentsStoredDepartmentBindingSource;
        internal BindingSource DocumentsStoredBindingSource;
        internal BindingSource DocumentsStoredServiceBindingSource;
        internal Bunifu.ToggleSwitch.BunifuToggleSwitch ttsIssueDate;
        internal Bunifu.ToggleSwitch.BunifuToggleSwitch tssExpireDate;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Bunifu.UI.WinForms.BunifuLabel lblExpireDate;
        internal Bunifu.UI.WinForms.BunifuLabel lblIssueDate;
        private Bunifu.UI.WinForms.BunifuRadioButton _rbIssueDate;

        internal Bunifu.UI.WinForms.BunifuRadioButton rbIssueDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _rbIssueDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbIssueDate != null)
                {
                    _rbIssueDate.Click -= rbIssueDate_Click;
                }

                _rbIssueDate = value;
                if (_rbIssueDate != null)
                {
                    _rbIssueDate.Click += rbIssueDate_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuRadioButton _rbExpireDate;

        internal Bunifu.UI.WinForms.BunifuRadioButton rbExpireDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _rbExpireDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbExpireDate != null)
                {
                    _rbExpireDate.Click -= rbExpireDate_Click;
                }

                _rbExpireDate = value;
                if (_rbExpireDate != null)
                {
                    _rbExpireDate.Click += rbExpireDate_Click;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel6;
        internal Panel Panel1;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnDelete;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDelete
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnDelete;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDelete != null)
                {
                    _btnDelete.Click -= btnDelete_Click;
                }

                _btnDelete = value;
                if (_btnDelete != null)
                {
                    _btnDelete.Click += btnDelete_Click;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel7;
        private Bunifu.UI.WinForms.BunifuDatePicker _txtEndDate;

        internal Bunifu.UI.WinForms.BunifuDatePicker txtEndDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtEndDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtEndDate != null)
                {
                    _txtEndDate.ValueChanged -= txtEndDate_ValueChanged_1;
                }

                _txtEndDate = value;
                if (_txtEndDate != null)
                {
                    _txtEndDate.ValueChanged += txtEndDate_ValueChanged_1;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDatePicker _txtStartDate;

        internal Bunifu.UI.WinForms.BunifuDatePicker txtStartDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtStartDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtStartDate != null)
                {
                    _txtStartDate.ValueChanged -= txtStartDate_ValueChanged_1;
                }

                _txtStartDate = value;
                if (_txtStartDate != null)
                {
                    _txtStartDate.ValueChanged += txtStartDate_ValueChanged_1;
                }
            }
        }

        internal DataGridViewTextBoxColumn DocumentsStoredIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn IssueDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ExpireDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn EmployeeIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DocumentsStoredTypeIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DocumentsStoredDepartmentIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DocumentsStoredDepartmentDataGridViewTextBoxColumn;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel9;
        private TextBox _txtFileType;

        internal TextBox txtFileType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtFileType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtFileType != null)
                {
                    _txtFileType.TextChanged -= txtFileType_TextChange;
                }

                _txtFileType = value;
                if (_txtFileType != null)
                {
                    _txtFileType.TextChanged += txtFileType_TextChange;
                }
            }
        }

        private TextBox _txtDecription;

        internal TextBox txtDecription
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDecription;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDecription != null)
                {
                    _txtDecription.TextChanged -= txtDecription_TextChanged;
                }

                _txtDecription = value;
                if (_txtDecription != null)
                {
                    _txtDecription.TextChanged += txtDecription_TextChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuCheckBox _ckbDate;

        internal Bunifu.UI.WinForms.BunifuCheckBox ckbDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckbDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckbDate != null)
                {
                    _ckbDate.Click -= ckbDate_Click;
                }

                _ckbDate = value;
                if (_ckbDate != null)
                {
                    _ckbDate.Click += ckbDate_Click;
                }
            }
        }
    }
}