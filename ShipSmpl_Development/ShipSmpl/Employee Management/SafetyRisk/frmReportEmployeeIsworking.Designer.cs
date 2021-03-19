using System;
using System.Diagnostics;
using System.Drawing; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

using Bunifu.UI.WinForms.BunifuTextbox;
using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmReportEmployeeIsworking : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportEmployeeIsworking));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label2 = new Label();
            BunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            _dgvEmployee = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvEmployee.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dgvEmployee_ColumnHeaderMouseClick);
            FirstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            SiteLocation = new DataGridViewTextBoxColumn();
            EmployeeWorkingBindingSource = new BindingSource(components);
            TableLayoutPanel1 = new TableLayoutPanel();
            _txtSiteLocation = new BunifuTextBox();
            _txtSiteLocation.TextChange += new EventHandler(txtSiteLocation_TextChange);
            _txtPhoneNumber = new BunifuTextBox();
            _txtPhoneNumber.TextChange += new EventHandler(txtPhoneNumber_TextChange);
            _txtLastName = new BunifuTextBox();
            _txtLastName.TextChange += new EventHandler(txtLastName_TextChange);
            _txtFirstName = new BunifuTextBox();
            _txtFirstName.TextChange += new EventHandler(txtFirstName_TextChange);
            lblTotalEmployeeWorking = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            TableLayoutPanel2 = new TableLayoutPanel();
            lblTotalRemote = new Bunifu.UI.WinForms.BunifuLabel();
            lblTotalLindsey = new Bunifu.UI.WinForms.BunifuLabel();
            lblTotalEwen = new Bunifu.UI.WinForms.BunifuLabel();
            _btnExportToExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnExportToExcel.Click += new EventHandler(btnExportToExcel_Click);
            ((System.ComponentModel.ISupportInitialize)_dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeWorkingBindingSource).BeginInit();
            TableLayoutPanel1.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(1157, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(40, 41);
            _closeLabel.TabIndex = 150;
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
            Label2.Size = new Size(1200, 41);
            Label2.TabIndex = 149;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuLabel7
            // 
            BunifuLabel7.Anchor = AnchorStyles.Top;
            BunifuLabel7.AutoEllipsis = false;
            BunifuLabel7.CursorType = null;
            BunifuLabel7.Font = new Font("Microsoft Sans Serif", 14.0f);
            BunifuLabel7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuLabel7.Location = new Point(12, 62);
            BunifuLabel7.Name = "BunifuLabel7";
            BunifuLabel7.RightToLeft = RightToLeft.No;
            BunifuLabel7.Size = new Size(259, 26);
            BunifuLabel7.TabIndex = 234;
            BunifuLabel7.Text = "Report of Employee is working";
            BunifuLabel7.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvEmployee
            // 
            _dgvEmployee.AllowCustomTheming = true;
            _dgvEmployee.AllowUserToAddRows = false;
            _dgvEmployee.AllowUserToDeleteRows = false;
            _dgvEmployee.AllowUserToResizeColumns = false;
            _dgvEmployee.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvEmployee.AutoGenerateColumns = false;
            _dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvEmployee.BackgroundColor = Color.White;
            _dgvEmployee.BorderStyle = BorderStyle.None;
            _dgvEmployee.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvEmployee.ColumnHeadersHeight = 45;
            _dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { FirstNameDataGridViewTextBoxColumn, LastName, PhoneNumber, SiteLocation });
            _dgvEmployee.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvEmployee.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvEmployee.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvEmployee.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvEmployee.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvEmployee.CurrentTheme.BackColor = Color.Snow;
            _dgvEmployee.CurrentTheme.GridColor = Color.Gray;
            _dgvEmployee.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvEmployee.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvEmployee.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvEmployee.CurrentTheme.Name = null;
            _dgvEmployee.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvEmployee.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvEmployee.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvEmployee.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvEmployee.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvEmployee.DataSource = EmployeeWorkingBindingSource;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvEmployee.DefaultCellStyle = DataGridViewCellStyle3;
            _dgvEmployee.EnableHeadersVisualStyles = false;
            _dgvEmployee.GridColor = Color.Gray;
            _dgvEmployee.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvEmployee.HeaderBgColor = Color.Empty;
            _dgvEmployee.HeaderForeColor = Color.White;
            _dgvEmployee.Location = new Point(12, 151);
            _dgvEmployee.MultiSelect = false;
            _dgvEmployee.Name = "_dgvEmployee";
            _dgvEmployee.ReadOnly = true;
            _dgvEmployee.RowHeadersVisible = false;
            _dgvEmployee.RowHeadersWidth = 40;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            _dgvEmployee.RowsDefaultCellStyle = DataGridViewCellStyle4;
            _dgvEmployee.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvEmployee.RowTemplate.Height = 40;
            _dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvEmployee.Size = new Size(1176, 530);
            _dgvEmployee.TabIndex = 235;
            _dgvEmployee.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // FirstNameDataGridViewTextBoxColumn
            // 
            FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn";
            FirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            // 
            // SiteLocation
            // 
            SiteLocation.DataPropertyName = "SiteLocation";
            SiteLocation.HeaderText = "Site";
            SiteLocation.Name = "SiteLocation";
            SiteLocation.ReadOnly = true;
            // 
            // EmployeeWorkingBindingSource
            // 
            EmployeeWorkingBindingSource.DataSource = typeof(ModelLayer.CustomModel.EmployeeWorking);
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            TableLayoutPanel1.ColumnCount = 4;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.25467f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.74533f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 298.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 301.0f));
            TableLayoutPanel1.Controls.Add(_txtSiteLocation, 3, 0);
            TableLayoutPanel1.Controls.Add(_txtPhoneNumber, 2, 0);
            TableLayoutPanel1.Controls.Add(_txtLastName, 1, 0);
            TableLayoutPanel1.Controls.Add(_txtFirstName, 0, 0);
            TableLayoutPanel1.Location = new Point(12, 116);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new Size(1176, 35);
            TableLayoutPanel1.TabIndex = 236;
            // 
            // txtSiteLocation
            // 
            _txtSiteLocation.AcceptsReturn = false;
            _txtSiteLocation.AcceptsTab = false;
            _txtSiteLocation.AnimationSpeed = 200;
            _txtSiteLocation.AutoCompleteMode = AutoCompleteMode.None;
            _txtSiteLocation.AutoCompleteSource = AutoCompleteSource.None;
            _txtSiteLocation.BackColor = Color.Transparent;
            _txtSiteLocation.BackgroundImage = (Image)resources.GetObject("txtSiteLocation.BackgroundImage");
            _txtSiteLocation.BorderColorActive = Color.DodgerBlue;
            _txtSiteLocation.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtSiteLocation.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtSiteLocation.BorderColorIdle = Color.Silver;
            _txtSiteLocation.BorderRadius = 1;
            _txtSiteLocation.BorderThickness = 1;
            _txtSiteLocation.CharacterCasing = CharacterCasing.Upper;
            _txtSiteLocation.Cursor = Cursors.IBeam;
            _txtSiteLocation.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _txtSiteLocation.DefaultText = "";
            _txtSiteLocation.FillColor = Color.White;
            _txtSiteLocation.HideSelection = true;
            _txtSiteLocation.IconLeft = null;
            _txtSiteLocation.IconLeftCursor = Cursors.IBeam;
            _txtSiteLocation.IconPadding = 10;
            _txtSiteLocation.IconRight = null;
            _txtSiteLocation.IconRightCursor = Cursors.IBeam;
            _txtSiteLocation.Lines = new string[0];
            _txtSiteLocation.Location = new Point(877, 3);
            _txtSiteLocation.MaxLength = 32767;
            _txtSiteLocation.MinimumSize = new Size(100, 25);
            _txtSiteLocation.Modified = false;
            _txtSiteLocation.Multiline = false;
            _txtSiteLocation.Name = "_txtSiteLocation";
            StateProperties1.BorderColor = Color.DodgerBlue;
            StateProperties1.FillColor = Color.Empty;
            StateProperties1.ForeColor = Color.Empty;
            StateProperties1.PlaceholderForeColor = Color.Empty;
            _txtSiteLocation.OnActiveState = StateProperties1;
            StateProperties2.BorderColor = Color.Empty;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.Empty;
            StateProperties2.PlaceholderForeColor = Color.Silver;
            _txtSiteLocation.OnDisabledState = StateProperties2;
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            _txtSiteLocation.OnHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Silver;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Empty;
            StateProperties4.PlaceholderForeColor = Color.Empty;
            _txtSiteLocation.OnIdleState = StateProperties4;
            _txtSiteLocation.PasswordChar = '\0';
            _txtSiteLocation.PlaceholderForeColor = Color.Silver;
            _txtSiteLocation.PlaceholderText = "ENTER TEXT";
            _txtSiteLocation.ReadOnly = false;
            _txtSiteLocation.ScrollBars = ScrollBars.None;
            _txtSiteLocation.SelectedText = "";
            _txtSiteLocation.SelectionLength = 0;
            _txtSiteLocation.SelectionStart = 0;
            _txtSiteLocation.ShortcutsEnabled = true;
            _txtSiteLocation.Size = new Size(287, 29);
            _txtSiteLocation.Style = _Style.Bunifu;
            _txtSiteLocation.TabIndex = 240;
            _txtSiteLocation.TextAlign = HorizontalAlignment.Left;
            _txtSiteLocation.TextMarginBottom = 0;
            _txtSiteLocation.TextMarginLeft = 5;
            _txtSiteLocation.TextMarginTop = 0;
            _txtSiteLocation.TextPlaceholder = "ENTER TEXT";
            _txtSiteLocation.UseSystemPasswordChar = false;
            _txtSiteLocation.WordWrap = true;
            // 
            // txtPhoneNumber
            // 
            _txtPhoneNumber.AcceptsReturn = false;
            _txtPhoneNumber.AcceptsTab = false;
            _txtPhoneNumber.AnimationSpeed = 200;
            _txtPhoneNumber.AutoCompleteMode = AutoCompleteMode.None;
            _txtPhoneNumber.AutoCompleteSource = AutoCompleteSource.None;
            _txtPhoneNumber.BackColor = Color.Transparent;
            _txtPhoneNumber.BackgroundImage = (Image)resources.GetObject("txtPhoneNumber.BackgroundImage");
            _txtPhoneNumber.BorderColorActive = Color.DodgerBlue;
            _txtPhoneNumber.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtPhoneNumber.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtPhoneNumber.BorderColorIdle = Color.Silver;
            _txtPhoneNumber.BorderRadius = 1;
            _txtPhoneNumber.BorderThickness = 1;
            _txtPhoneNumber.CharacterCasing = CharacterCasing.Upper;
            _txtPhoneNumber.Cursor = Cursors.IBeam;
            _txtPhoneNumber.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _txtPhoneNumber.DefaultText = "";
            _txtPhoneNumber.FillColor = Color.White;
            _txtPhoneNumber.HideSelection = true;
            _txtPhoneNumber.IconLeft = null;
            _txtPhoneNumber.IconLeftCursor = Cursors.IBeam;
            _txtPhoneNumber.IconPadding = 10;
            _txtPhoneNumber.IconRight = null;
            _txtPhoneNumber.IconRightCursor = Cursors.IBeam;
            _txtPhoneNumber.Lines = new string[0];
            _txtPhoneNumber.Location = new Point(579, 3);
            _txtPhoneNumber.MaxLength = 32767;
            _txtPhoneNumber.MinimumSize = new Size(100, 25);
            _txtPhoneNumber.Modified = false;
            _txtPhoneNumber.Multiline = false;
            _txtPhoneNumber.Name = "_txtPhoneNumber";
            StateProperties5.BorderColor = Color.DodgerBlue;
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            _txtPhoneNumber.OnActiveState = StateProperties5;
            StateProperties6.BorderColor = Color.Empty;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Silver;
            _txtPhoneNumber.OnDisabledState = StateProperties6;
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            _txtPhoneNumber.OnHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Silver;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.Empty;
            StateProperties8.PlaceholderForeColor = Color.Empty;
            _txtPhoneNumber.OnIdleState = StateProperties8;
            _txtPhoneNumber.PasswordChar = '\0';
            _txtPhoneNumber.PlaceholderForeColor = Color.Silver;
            _txtPhoneNumber.PlaceholderText = "ENTER TEXT";
            _txtPhoneNumber.ReadOnly = false;
            _txtPhoneNumber.ScrollBars = ScrollBars.None;
            _txtPhoneNumber.SelectedText = "";
            _txtPhoneNumber.SelectionLength = 0;
            _txtPhoneNumber.SelectionStart = 0;
            _txtPhoneNumber.ShortcutsEnabled = true;
            _txtPhoneNumber.Size = new Size(287, 29);
            _txtPhoneNumber.Style = _Style.Bunifu;
            _txtPhoneNumber.TabIndex = 239;
            _txtPhoneNumber.TextAlign = HorizontalAlignment.Left;
            _txtPhoneNumber.TextMarginBottom = 0;
            _txtPhoneNumber.TextMarginLeft = 5;
            _txtPhoneNumber.TextMarginTop = 0;
            _txtPhoneNumber.TextPlaceholder = "ENTER TEXT";
            _txtPhoneNumber.UseSystemPasswordChar = false;
            _txtPhoneNumber.WordWrap = true;
            // 
            // txtLastName
            // 
            _txtLastName.AcceptsReturn = false;
            _txtLastName.AcceptsTab = false;
            _txtLastName.AnimationSpeed = 200;
            _txtLastName.AutoCompleteMode = AutoCompleteMode.None;
            _txtLastName.AutoCompleteSource = AutoCompleteSource.None;
            _txtLastName.BackColor = Color.Transparent;
            _txtLastName.BackgroundImage = (Image)resources.GetObject("txtLastName.BackgroundImage");
            _txtLastName.BorderColorActive = Color.DodgerBlue;
            _txtLastName.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtLastName.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtLastName.BorderColorIdle = Color.Silver;
            _txtLastName.BorderRadius = 1;
            _txtLastName.BorderThickness = 1;
            _txtLastName.CharacterCasing = CharacterCasing.Upper;
            _txtLastName.Cursor = Cursors.IBeam;
            _txtLastName.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _txtLastName.DefaultText = "";
            _txtLastName.FillColor = Color.White;
            _txtLastName.HideSelection = true;
            _txtLastName.IconLeft = null;
            _txtLastName.IconLeftCursor = Cursors.IBeam;
            _txtLastName.IconPadding = 10;
            _txtLastName.IconRight = null;
            _txtLastName.IconRightCursor = Cursors.IBeam;
            _txtLastName.Lines = new string[0];
            _txtLastName.Location = new Point(292, 3);
            _txtLastName.MaxLength = 32767;
            _txtLastName.MinimumSize = new Size(100, 25);
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
            StateProperties12.BorderColor = Color.Silver;
            StateProperties12.FillColor = Color.White;
            StateProperties12.ForeColor = Color.Empty;
            StateProperties12.PlaceholderForeColor = Color.Empty;
            _txtLastName.OnIdleState = StateProperties12;
            _txtLastName.PasswordChar = '\0';
            _txtLastName.PlaceholderForeColor = Color.Silver;
            _txtLastName.PlaceholderText = "ENTER TEXT";
            _txtLastName.ReadOnly = false;
            _txtLastName.ScrollBars = ScrollBars.None;
            _txtLastName.SelectedText = "";
            _txtLastName.SelectionLength = 0;
            _txtLastName.SelectionStart = 0;
            _txtLastName.ShortcutsEnabled = true;
            _txtLastName.Size = new Size(281, 29);
            _txtLastName.Style = _Style.Bunifu;
            _txtLastName.TabIndex = 238;
            _txtLastName.TextAlign = HorizontalAlignment.Left;
            _txtLastName.TextMarginBottom = 0;
            _txtLastName.TextMarginLeft = 5;
            _txtLastName.TextMarginTop = 0;
            _txtLastName.TextPlaceholder = "ENTER TEXT";
            _txtLastName.UseSystemPasswordChar = false;
            _txtLastName.WordWrap = true;
            // 
            // txtFirstName
            // 
            _txtFirstName.AcceptsReturn = false;
            _txtFirstName.AcceptsTab = false;
            _txtFirstName.AnimationSpeed = 200;
            _txtFirstName.AutoCompleteMode = AutoCompleteMode.None;
            _txtFirstName.AutoCompleteSource = AutoCompleteSource.None;
            _txtFirstName.BackColor = Color.Transparent;
            _txtFirstName.BackgroundImage = (Image)resources.GetObject("txtFirstName.BackgroundImage");
            _txtFirstName.BorderColorActive = Color.DodgerBlue;
            _txtFirstName.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtFirstName.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtFirstName.BorderColorIdle = Color.Silver;
            _txtFirstName.BorderRadius = 1;
            _txtFirstName.BorderThickness = 1;
            _txtFirstName.CharacterCasing = CharacterCasing.Upper;
            _txtFirstName.Cursor = Cursors.IBeam;
            _txtFirstName.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _txtFirstName.DefaultText = "";
            _txtFirstName.FillColor = Color.White;
            _txtFirstName.HideSelection = true;
            _txtFirstName.IconLeft = null;
            _txtFirstName.IconLeftCursor = Cursors.IBeam;
            _txtFirstName.IconPadding = 10;
            _txtFirstName.IconRight = null;
            _txtFirstName.IconRightCursor = Cursors.IBeam;
            _txtFirstName.Lines = new string[0];
            _txtFirstName.Location = new Point(3, 3);
            _txtFirstName.MaxLength = 32767;
            _txtFirstName.MinimumSize = new Size(100, 25);
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
            StateProperties16.BorderColor = Color.Silver;
            StateProperties16.FillColor = Color.White;
            StateProperties16.ForeColor = Color.Empty;
            StateProperties16.PlaceholderForeColor = Color.Empty;
            _txtFirstName.OnIdleState = StateProperties16;
            _txtFirstName.PasswordChar = '\0';
            _txtFirstName.PlaceholderForeColor = Color.Silver;
            _txtFirstName.PlaceholderText = "ENTER TEXT";
            _txtFirstName.ReadOnly = false;
            _txtFirstName.ScrollBars = ScrollBars.None;
            _txtFirstName.SelectedText = "";
            _txtFirstName.SelectionLength = 0;
            _txtFirstName.SelectionStart = 0;
            _txtFirstName.ShortcutsEnabled = true;
            _txtFirstName.Size = new Size(283, 29);
            _txtFirstName.Style = _Style.Bunifu;
            _txtFirstName.TabIndex = 237;
            _txtFirstName.TextAlign = HorizontalAlignment.Left;
            _txtFirstName.TextMarginBottom = 0;
            _txtFirstName.TextMarginLeft = 5;
            _txtFirstName.TextMarginTop = 0;
            _txtFirstName.TextPlaceholder = "ENTER TEXT";
            _txtFirstName.UseSystemPasswordChar = false;
            _txtFirstName.WordWrap = true;
            // 
            // lblTotalEmployeeWorking
            // 
            lblTotalEmployeeWorking.Anchor = AnchorStyles.Right;
            lblTotalEmployeeWorking.AutoEllipsis = false;
            lblTotalEmployeeWorking.CursorType = null;
            lblTotalEmployeeWorking.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotalEmployeeWorking.Location = new Point(961, 10);
            lblTotalEmployeeWorking.Name = "lblTotalEmployeeWorking";
            lblTotalEmployeeWorking.RightToLeft = RightToLeft.No;
            lblTotalEmployeeWorking.Size = new Size(212, 20);
            lblTotalEmployeeWorking.TabIndex = 237;
            lblTotalEmployeeWorking.Text = "Total Employee working: 10";
            lblTotalEmployeeWorking.TextAlignment = ContentAlignment.TopLeft;
            lblTotalEmployeeWorking.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel1
            // 
            BunifuLabel1.Anchor = AnchorStyles.Right;
            BunifuLabel1.AutoEllipsis = false;
            BunifuLabel1.CursorType = null;
            BunifuLabel1.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel1.Location = new Point(68, 10);
            BunifuLabel1.Name = "BunifuLabel1";
            BunifuLabel1.RightToLeft = RightToLeft.No;
            BunifuLabel1.Size = new Size(49, 20);
            BunifuLabel1.TabIndex = 238;
            BunifuLabel1.Text = "Ewen:";
            BunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel2
            // 
            BunifuLabel2.Anchor = AnchorStyles.Right;
            BunifuLabel2.AutoEllipsis = false;
            BunifuLabel2.CursorType = null;
            BunifuLabel2.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel2.Location = new Point(230, 10);
            BunifuLabel2.Name = "BunifuLabel2";
            BunifuLabel2.RightToLeft = RightToLeft.No;
            BunifuLabel2.Size = new Size(65, 20);
            BunifuLabel2.TabIndex = 239;
            BunifuLabel2.Text = "Lindsey:";
            BunifuLabel2.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel3
            // 
            BunifuLabel3.Anchor = AnchorStyles.Right;
            BunifuLabel3.AutoEllipsis = false;
            BunifuLabel3.CursorType = null;
            BunifuLabel3.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel3.Location = new Point(451, 10);
            BunifuLabel3.Name = "BunifuLabel3";
            BunifuLabel3.RightToLeft = RightToLeft.No;
            BunifuLabel3.Size = new Size(67, 20);
            BunifuLabel3.TabIndex = 240;
            BunifuLabel3.Text = "Remote:";
            BunifuLabel3.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 8;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 59.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 76.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 290.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 287.0f));
            TableLayoutPanel2.Controls.Add(lblTotalRemote, 5, 0);
            TableLayoutPanel2.Controls.Add(lblTotalLindsey, 3, 0);
            TableLayoutPanel2.Controls.Add(lblTotalEwen, 1, 0);
            TableLayoutPanel2.Controls.Add(BunifuLabel1, 0, 0);
            TableLayoutPanel2.Controls.Add(BunifuLabel3, 4, 0);
            TableLayoutPanel2.Controls.Add(lblTotalEmployeeWorking, 7, 0);
            TableLayoutPanel2.Controls.Add(BunifuLabel2, 2, 0);
            TableLayoutPanel2.Location = new Point(12, 689);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 1;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel2.Size = new Size(1176, 40);
            TableLayoutPanel2.TabIndex = 241;
            // 
            // lblTotalRemote
            // 
            lblTotalRemote.Anchor = AnchorStyles.Left;
            lblTotalRemote.AutoEllipsis = false;
            lblTotalRemote.CursorType = null;
            lblTotalRemote.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotalRemote.Location = new Point(524, 10);
            lblTotalRemote.Name = "lblTotalRemote";
            lblTotalRemote.RightToLeft = RightToLeft.No;
            lblTotalRemote.Size = new Size(72, 20);
            lblTotalRemote.TabIndex = 243;
            lblTotalRemote.Text = "TRemote";
            lblTotalRemote.TextAlignment = ContentAlignment.TopLeft;
            lblTotalRemote.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTotalLindsey
            // 
            lblTotalLindsey.Anchor = AnchorStyles.Left;
            lblTotalLindsey.AutoEllipsis = false;
            lblTotalLindsey.CursorType = null;
            lblTotalLindsey.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotalLindsey.Location = new Point(301, 10);
            lblTotalLindsey.Name = "lblTotalLindsey";
            lblTotalLindsey.RightToLeft = RightToLeft.No;
            lblTotalLindsey.Size = new Size(70, 20);
            lblTotalLindsey.TabIndex = 242;
            lblTotalLindsey.Text = "TLindsey";
            lblTotalLindsey.TextAlignment = ContentAlignment.TopLeft;
            lblTotalLindsey.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTotalEwen
            // 
            lblTotalEwen.Anchor = AnchorStyles.Left;
            lblTotalEwen.AutoEllipsis = false;
            lblTotalEwen.CursorType = null;
            lblTotalEwen.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotalEwen.Location = new Point(123, 10);
            lblTotalEwen.Name = "lblTotalEwen";
            lblTotalEwen.RightToLeft = RightToLeft.No;
            lblTotalEwen.Size = new Size(54, 20);
            lblTotalEwen.TabIndex = 241;
            lblTotalEwen.Text = "TEwen";
            lblTotalEwen.TextAlignment = ContentAlignment.TopLeft;
            lblTotalEwen.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnExportToExcel
            // 
            _btnExportToExcel.AllowToggling = false;
            _btnExportToExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnExportToExcel.AnimationSpeed = 200;
            _btnExportToExcel.AutoGenerateColors = false;
            _btnExportToExcel.BackColor = Color.Transparent;
            _btnExportToExcel.BackColor1 = Color.White;
            _btnExportToExcel.BackgroundImage = (Image)resources.GetObject("btnExportToExcel.BackgroundImage");
            _btnExportToExcel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnExportToExcel.ButtonText = "CSV Report";
            _btnExportToExcel.ButtonTextMarginLeft = 15;
            _btnExportToExcel.ColorContrastOnClick = 45;
            _btnExportToExcel.ColorContrastOnHover = 45;
            _btnExportToExcel.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnExportToExcel.CustomizableEdges = BorderEdges1;
            _btnExportToExcel.DialogResult = DialogResult.None;
            _btnExportToExcel.DisabledBorderColor = Color.Empty;
            _btnExportToExcel.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnExportToExcel.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnExportToExcel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnExportToExcel.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnExportToExcel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _btnExportToExcel.IconLeftCursor = Cursors.Hand;
            _btnExportToExcel.IconMarginLeft = 11;
            _btnExportToExcel.IconPadding = 3;
            _btnExportToExcel.IconRightCursor = Cursors.Hand;
            _btnExportToExcel.IdleBorderColor = Color.LightGray;
            _btnExportToExcel.IdleBorderRadius = 30;
            _btnExportToExcel.IdleBorderThickness = 1;
            _btnExportToExcel.IdleFillColor = Color.White;
            _btnExportToExcel.IdleIconLeftImage = My.Resources.Resources.csv;
            _btnExportToExcel.IdleIconRightImage = null;
            _btnExportToExcel.IndicateFocus = true;
            _btnExportToExcel.Location = new Point(1048, 62);
            _btnExportToExcel.Name = "_btnExportToExcel";
            StateProperties17.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties17.BorderRadius = 30;
            StateProperties17.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties17.BorderThickness = 1;
            StateProperties17.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties17.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties17.IconLeftImage = null;
            StateProperties17.IconRightImage = null;
            _btnExportToExcel.onHoverState = StateProperties17;
            StateProperties18.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties18.BorderRadius = 30;
            StateProperties18.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties18.BorderThickness = 1;
            StateProperties18.FillColor = Color.White;
            StateProperties18.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties18.IconLeftImage = null;
            StateProperties18.IconRightImage = null;
            _btnExportToExcel.OnPressedState = StateProperties18;
            _btnExportToExcel.Padding = new Padding(3, 0, 3, 0);
            _btnExportToExcel.Size = new Size(140, 33);
            _btnExportToExcel.TabIndex = 242;
            _btnExportToExcel.TextAlign = ContentAlignment.MiddleCenter;
            _btnExportToExcel.TextMarginLeft = 15;
            _btnExportToExcel.UseDefaultRadiusAndThickness = true;
            // 
            // frmReportEmployeeIsworking
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 750);
            Controls.Add(_btnExportToExcel);
            Controls.Add(TableLayoutPanel2);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(_dgvEmployee);
            Controls.Add(BunifuLabel7);
            Controls.Add(_closeLabel);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReportEmployeeIsworking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmReportEmployeeIsworking";
            ((System.ComponentModel.ISupportInitialize)_dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeWorkingBindingSource).EndInit();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            Load += new EventHandler(frmReportEmployeeIsworking_Load);
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
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvEmployee;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvEmployee
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvEmployee;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvEmployee != null)
                {
                    _dgvEmployee.ColumnHeaderMouseClick -= dgvEmployee_ColumnHeaderMouseClick;
                }

                _dgvEmployee = value;
                if (_dgvEmployee != null)
                {
                    _dgvEmployee.ColumnHeaderMouseClick += dgvEmployee_ColumnHeaderMouseClick;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel1;
        private BunifuTextBox _txtSiteLocation;

        internal BunifuTextBox txtSiteLocation
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtSiteLocation;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtSiteLocation != null)
                {
                    _txtSiteLocation.TextChange -= txtSiteLocation_TextChange;
                }

                _txtSiteLocation = value;
                if (_txtSiteLocation != null)
                {
                    _txtSiteLocation.TextChange += txtSiteLocation_TextChange;
                }
            }
        }

        private BunifuTextBox _txtPhoneNumber;

        internal BunifuTextBox txtPhoneNumber
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtPhoneNumber;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtPhoneNumber != null)
                {
                    _txtPhoneNumber.TextChange -= txtPhoneNumber_TextChange;
                }

                _txtPhoneNumber = value;
                if (_txtPhoneNumber != null)
                {
                    _txtPhoneNumber.TextChange += txtPhoneNumber_TextChange;
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

        internal Bunifu.UI.WinForms.BunifuLabel lblTotalEmployeeWorking;
        internal BindingSource EmployeeWorkingBindingSource;
        internal DataGridViewTextBoxColumn LatNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn StartDateDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn SiteLocationDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn FirstNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn LastName;
        internal DataGridViewTextBoxColumn PhoneNumber;
        internal DataGridViewTextBoxColumn SiteLocation;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel1;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel2;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel3;
        internal TableLayoutPanel TableLayoutPanel2;
        internal Bunifu.UI.WinForms.BunifuLabel lblTotalRemote;
        internal Bunifu.UI.WinForms.BunifuLabel lblTotalLindsey;
        internal Bunifu.UI.WinForms.BunifuLabel lblTotalEwen;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnExportToExcel;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExportToExcel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnExportToExcel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnExportToExcel != null)
                {
                    _btnExportToExcel.Click -= btnExportToExcel_Click;
                }

                _btnExportToExcel = value;
                if (_btnExportToExcel != null)
                {
                    _btnExportToExcel.Click += btnExportToExcel_Click;
                }
            }
        }
    }
}