using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmCommodityGrainMain : Form
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
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommodityGrainMain));
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
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties23 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties24 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties19 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties20 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label2 = new Label();
            _dgvCommodity = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvCommodity.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dgvCommodity_ColumnHeaderMouseClick);
            _dgvGrade = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvGrade.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dgvGrade_ColumnHeaderMouseClick);
            _txtCommodity = new BunifuTextBox();
            _txtCommodity.TextChange += new EventHandler(txtCommodity_TextChange);
            _txtCommodityCode = new BunifuTextBox();
            _txtCommodityCode.TextChange += new EventHandler(txtCommodityCode_TextChange);
            TableLayoutPanel2 = new TableLayoutPanel();
            _txtGrade = new BunifuTextBox();
            _txtGrade.TextChange += new EventHandler(txtGrade_TextChange);
            _txtGradeCode = new BunifuTextBox();
            _txtGradeCode.TextChange += new EventHandler(txtGradeCode_TextChange);
            BunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            Panel1 = new Panel();
            Panel2 = new Panel();
            _btnEditCommodity = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnEditCommodity.Click += new EventHandler(btnEditCommodity_Click);
            TableLayoutPanel3 = new TableLayoutPanel();
            TableLayoutPanel4 = new TableLayoutPanel();
            _btnEditGrade = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnEditGrade.Click += new EventHandler(btnEditGrade_Click);
            _btnAddCommodity = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddCommodity.Click += new EventHandler(btnAddCommodity_Click);
            _btnAddGrade = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddGrade.Click += new EventHandler(btnAddGrade_Click);
            GradeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GradeCode = new DataGridViewTextBoxColumn();
            GradeName = new DataGridViewTextBoxColumn();
            MiniUnitDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            MiniBookingCommodityDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            GradeBindingSource = new BindingSource(components);
            CommodityIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CommodityCode = new DataGridViewTextBoxColumn();
            CommodityName = new DataGridViewTextBoxColumn();
            MiniUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            MiniBookingCommodityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CommodityBindingSource = new BindingSource(components);
            TableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)_dgvCommodity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dgvGrade).BeginInit();
            TableLayoutPanel2.SuspendLayout();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            TableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GradeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CommodityBindingSource).BeginInit();
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(1160, -1);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(40, 41);
            _closeLabel.TabIndex = 148;
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
            Label2.TabIndex = 147;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCommodity
            // 
            _dgvCommodity.AllowCustomTheming = true;
            _dgvCommodity.AllowUserToAddRows = false;
            _dgvCommodity.AllowUserToDeleteRows = false;
            _dgvCommodity.AllowUserToResizeColumns = false;
            _dgvCommodity.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvCommodity.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvCommodity.AutoGenerateColumns = false;
            _dgvCommodity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvCommodity.BackgroundColor = Color.White;
            _dgvCommodity.BorderStyle = BorderStyle.None;
            _dgvCommodity.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvCommodity.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvCommodity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvCommodity.ColumnHeadersHeight = 45;
            _dgvCommodity.Columns.AddRange(new DataGridViewColumn[] { CommodityIdDataGridViewTextBoxColumn, CommodityCode, CommodityName, MiniUnitDataGridViewTextBoxColumn, MiniBookingCommodityDataGridViewTextBoxColumn });
            _dgvCommodity.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvCommodity.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvCommodity.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvCommodity.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvCommodity.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvCommodity.CurrentTheme.BackColor = Color.Snow;
            _dgvCommodity.CurrentTheme.GridColor = Color.Gray;
            _dgvCommodity.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvCommodity.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvCommodity.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvCommodity.CurrentTheme.Name = null;
            _dgvCommodity.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvCommodity.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvCommodity.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvCommodity.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvCommodity.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvCommodity.DataSource = CommodityBindingSource;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvCommodity.DefaultCellStyle = DataGridViewCellStyle3;
            _dgvCommodity.Dock = DockStyle.Fill;
            _dgvCommodity.EnableHeadersVisualStyles = false;
            _dgvCommodity.GridColor = Color.Gray;
            _dgvCommodity.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvCommodity.HeaderBgColor = Color.Empty;
            _dgvCommodity.HeaderForeColor = Color.White;
            _dgvCommodity.Location = new Point(0, 0);
            _dgvCommodity.MultiSelect = false;
            _dgvCommodity.Name = "_dgvCommodity";
            _dgvCommodity.ReadOnly = true;
            _dgvCommodity.RowHeadersVisible = false;
            _dgvCommodity.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvCommodity.RowTemplate.Height = 40;
            _dgvCommodity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvCommodity.Size = new Size(578, 403);
            _dgvCommodity.TabIndex = 149;
            _dgvCommodity.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // dgvGrade
            // 
            _dgvGrade.AllowCustomTheming = true;
            _dgvGrade.AllowUserToAddRows = false;
            _dgvGrade.AllowUserToDeleteRows = false;
            _dgvGrade.AllowUserToResizeColumns = false;
            _dgvGrade.AllowUserToResizeRows = false;
            DataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewCellStyle4.ForeColor = Color.Black;
            DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvGrade.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
            _dgvGrade.AutoGenerateColumns = false;
            _dgvGrade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvGrade.BackgroundColor = Color.White;
            _dgvGrade.BorderStyle = BorderStyle.None;
            _dgvGrade.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvGrade.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            _dgvGrade.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            _dgvGrade.ColumnHeadersHeight = 40;
            _dgvGrade.Columns.AddRange(new DataGridViewColumn[] { GradeIdDataGridViewTextBoxColumn, GradeCode, GradeName, MiniUnitDataGridViewTextBoxColumn1, MiniBookingCommodityDataGridViewTextBoxColumn1 });
            _dgvGrade.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvGrade.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvGrade.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvGrade.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvGrade.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvGrade.CurrentTheme.BackColor = Color.Snow;
            _dgvGrade.CurrentTheme.GridColor = Color.Gray;
            _dgvGrade.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvGrade.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvGrade.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvGrade.CurrentTheme.Name = null;
            _dgvGrade.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvGrade.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvGrade.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvGrade.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvGrade.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvGrade.DataSource = GradeBindingSource;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle6.ForeColor = Color.Black;
            DataGridViewCellStyle6.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle6.SelectionForeColor = Color.Black;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            _dgvGrade.DefaultCellStyle = DataGridViewCellStyle6;
            _dgvGrade.Dock = DockStyle.Fill;
            _dgvGrade.EnableHeadersVisualStyles = false;
            _dgvGrade.GridColor = Color.Gray;
            _dgvGrade.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvGrade.HeaderBgColor = Color.Empty;
            _dgvGrade.HeaderForeColor = Color.White;
            _dgvGrade.Location = new Point(0, 0);
            _dgvGrade.MultiSelect = false;
            _dgvGrade.Name = "_dgvGrade";
            _dgvGrade.ReadOnly = true;
            _dgvGrade.RowHeadersVisible = false;
            _dgvGrade.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvGrade.RowTemplate.Height = 40;
            _dgvGrade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvGrade.Size = new Size(576, 403);
            _dgvGrade.TabIndex = 150;
            _dgvGrade.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // txtCommodity
            // 
            _txtCommodity.AcceptsReturn = false;
            _txtCommodity.AcceptsTab = false;
            _txtCommodity.Anchor = AnchorStyles.Left;
            _txtCommodity.AnimationSpeed = 200;
            _txtCommodity.AutoCompleteMode = AutoCompleteMode.None;
            _txtCommodity.AutoCompleteSource = AutoCompleteSource.None;
            _txtCommodity.BackColor = Color.Transparent;
            _txtCommodity.BackgroundImage = (Image)resources.GetObject("txtCommodity.BackgroundImage");
            _txtCommodity.BorderColorActive = Color.DodgerBlue;
            _txtCommodity.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtCommodity.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtCommodity.BorderColorIdle = Color.Silver;
            _txtCommodity.BorderRadius = 1;
            _txtCommodity.BorderThickness = 1;
            _txtCommodity.CharacterCasing = CharacterCasing.Upper;
            _txtCommodity.Cursor = Cursors.IBeam;
            _txtCommodity.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _txtCommodity.DefaultText = "";
            _txtCommodity.FillColor = Color.White;
            _txtCommodity.ForeColor = Color.Black;
            _txtCommodity.HideSelection = true;
            _txtCommodity.IconLeft = null;
            _txtCommodity.IconLeftCursor = Cursors.IBeam;
            _txtCommodity.IconPadding = 10;
            _txtCommodity.IconRight = null;
            _txtCommodity.IconRightCursor = Cursors.IBeam;
            _txtCommodity.Lines = new string[0];
            _txtCommodity.Location = new Point(123, 5);
            _txtCommodity.MaxLength = 32767;
            _txtCommodity.MinimumSize = new Size(100, 30);
            _txtCommodity.Modified = false;
            _txtCommodity.Multiline = false;
            _txtCommodity.Name = "_txtCommodity";
            StateProperties1.BorderColor = Color.DodgerBlue;
            StateProperties1.FillColor = Color.Empty;
            StateProperties1.ForeColor = Color.Empty;
            StateProperties1.PlaceholderForeColor = Color.Empty;
            _txtCommodity.OnActiveState = StateProperties1;
            StateProperties2.BorderColor = Color.Empty;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.Empty;
            StateProperties2.PlaceholderForeColor = Color.Silver;
            _txtCommodity.OnDisabledState = StateProperties2;
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            _txtCommodity.OnHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Silver;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Black;
            StateProperties4.PlaceholderForeColor = Color.Empty;
            _txtCommodity.OnIdleState = StateProperties4;
            _txtCommodity.PasswordChar = '\0';
            _txtCommodity.PlaceholderForeColor = Color.Silver;
            _txtCommodity.PlaceholderText = "COMMODITY";
            _txtCommodity.ReadOnly = false;
            _txtCommodity.ScrollBars = ScrollBars.None;
            _txtCommodity.SelectedText = "";
            _txtCommodity.SelectionLength = 0;
            _txtCommodity.SelectionStart = 0;
            _txtCommodity.ShortcutsEnabled = true;
            _txtCommodity.Size = new Size(454, 30);
            _txtCommodity.Style = _Style.Bunifu;
            _txtCommodity.TabIndex = 242;
            _txtCommodity.TextAlign = HorizontalAlignment.Left;
            _txtCommodity.TextMarginBottom = 0;
            _txtCommodity.TextMarginLeft = 5;
            _txtCommodity.TextMarginTop = 0;
            _txtCommodity.TextPlaceholder = "COMMODITY";
            _txtCommodity.UseSystemPasswordChar = false;
            _txtCommodity.WordWrap = true;
            // 
            // txtCommodityCode
            // 
            _txtCommodityCode.AcceptsReturn = false;
            _txtCommodityCode.AcceptsTab = false;
            _txtCommodityCode.Anchor = AnchorStyles.Left;
            _txtCommodityCode.AnimationSpeed = 200;
            _txtCommodityCode.AutoCompleteMode = AutoCompleteMode.None;
            _txtCommodityCode.AutoCompleteSource = AutoCompleteSource.None;
            _txtCommodityCode.BackColor = Color.Transparent;
            _txtCommodityCode.BackgroundImage = (Image)resources.GetObject("txtCommodityCode.BackgroundImage");
            _txtCommodityCode.BorderColorActive = Color.DodgerBlue;
            _txtCommodityCode.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtCommodityCode.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtCommodityCode.BorderColorIdle = Color.Silver;
            _txtCommodityCode.BorderRadius = 1;
            _txtCommodityCode.BorderThickness = 1;
            _txtCommodityCode.CharacterCasing = CharacterCasing.Upper;
            _txtCommodityCode.Cursor = Cursors.IBeam;
            _txtCommodityCode.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _txtCommodityCode.DefaultText = "";
            _txtCommodityCode.FillColor = Color.White;
            _txtCommodityCode.ForeColor = Color.Black;
            _txtCommodityCode.HideSelection = true;
            _txtCommodityCode.IconLeft = null;
            _txtCommodityCode.IconLeftCursor = Cursors.IBeam;
            _txtCommodityCode.IconPadding = 10;
            _txtCommodityCode.IconRight = null;
            _txtCommodityCode.IconRightCursor = Cursors.IBeam;
            _txtCommodityCode.Lines = new string[0];
            _txtCommodityCode.Location = new Point(3, 5);
            _txtCommodityCode.MaxLength = 32767;
            _txtCommodityCode.MinimumSize = new Size(100, 30);
            _txtCommodityCode.Modified = false;
            _txtCommodityCode.Multiline = false;
            _txtCommodityCode.Name = "_txtCommodityCode";
            StateProperties5.BorderColor = Color.DodgerBlue;
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            _txtCommodityCode.OnActiveState = StateProperties5;
            StateProperties6.BorderColor = Color.Empty;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Silver;
            _txtCommodityCode.OnDisabledState = StateProperties6;
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            _txtCommodityCode.OnHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Silver;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.Black;
            StateProperties8.PlaceholderForeColor = Color.Empty;
            _txtCommodityCode.OnIdleState = StateProperties8;
            _txtCommodityCode.PasswordChar = '\0';
            _txtCommodityCode.PlaceholderForeColor = Color.Silver;
            _txtCommodityCode.PlaceholderText = "CODE";
            _txtCommodityCode.ReadOnly = false;
            _txtCommodityCode.ScrollBars = ScrollBars.None;
            _txtCommodityCode.SelectedText = "";
            _txtCommodityCode.SelectionLength = 0;
            _txtCommodityCode.SelectionStart = 0;
            _txtCommodityCode.ShortcutsEnabled = true;
            _txtCommodityCode.Size = new Size(114, 30);
            _txtCommodityCode.Style = _Style.Bunifu;
            _txtCommodityCode.TabIndex = 241;
            _txtCommodityCode.TextAlign = HorizontalAlignment.Left;
            _txtCommodityCode.TextMarginBottom = 0;
            _txtCommodityCode.TextMarginLeft = 5;
            _txtCommodityCode.TextMarginTop = 0;
            _txtCommodityCode.TextPlaceholder = "CODE";
            _txtCommodityCode.UseSystemPasswordChar = false;
            _txtCommodityCode.WordWrap = true;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            TableLayoutPanel2.ColumnCount = 2;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120.0f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 460.0f));
            TableLayoutPanel2.Controls.Add(_txtGrade, 0, 0);
            TableLayoutPanel2.Controls.Add(_txtGradeCode, 0, 0);
            TableLayoutPanel2.Location = new Point(613, 116);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 1;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel2.Size = new Size(578, 40);
            TableLayoutPanel2.TabIndex = 152;
            // 
            // txtGrade
            // 
            _txtGrade.AcceptsReturn = false;
            _txtGrade.AcceptsTab = false;
            _txtGrade.Anchor = AnchorStyles.Left;
            _txtGrade.AnimationSpeed = 200;
            _txtGrade.AutoCompleteMode = AutoCompleteMode.None;
            _txtGrade.AutoCompleteSource = AutoCompleteSource.None;
            _txtGrade.BackColor = Color.Transparent;
            _txtGrade.BackgroundImage = (Image)resources.GetObject("txtGrade.BackgroundImage");
            _txtGrade.BorderColorActive = Color.DodgerBlue;
            _txtGrade.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtGrade.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtGrade.BorderColorIdle = Color.Silver;
            _txtGrade.BorderRadius = 1;
            _txtGrade.BorderThickness = 1;
            _txtGrade.CharacterCasing = CharacterCasing.Upper;
            _txtGrade.Cursor = Cursors.IBeam;
            _txtGrade.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _txtGrade.DefaultText = "";
            _txtGrade.FillColor = Color.White;
            _txtGrade.ForeColor = Color.Black;
            _txtGrade.HideSelection = true;
            _txtGrade.IconLeft = null;
            _txtGrade.IconLeftCursor = Cursors.IBeam;
            _txtGrade.IconPadding = 10;
            _txtGrade.IconRight = null;
            _txtGrade.IconRightCursor = Cursors.IBeam;
            _txtGrade.Lines = new string[0];
            _txtGrade.Location = new Point(123, 5);
            _txtGrade.MaxLength = 32767;
            _txtGrade.MinimumSize = new Size(100, 30);
            _txtGrade.Modified = false;
            _txtGrade.Multiline = false;
            _txtGrade.Name = "_txtGrade";
            StateProperties9.BorderColor = Color.DodgerBlue;
            StateProperties9.FillColor = Color.Empty;
            StateProperties9.ForeColor = Color.Empty;
            StateProperties9.PlaceholderForeColor = Color.Empty;
            _txtGrade.OnActiveState = StateProperties9;
            StateProperties10.BorderColor = Color.Empty;
            StateProperties10.FillColor = Color.White;
            StateProperties10.ForeColor = Color.Empty;
            StateProperties10.PlaceholderForeColor = Color.Silver;
            _txtGrade.OnDisabledState = StateProperties10;
            StateProperties11.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties11.FillColor = Color.Empty;
            StateProperties11.ForeColor = Color.Empty;
            StateProperties11.PlaceholderForeColor = Color.Empty;
            _txtGrade.OnHoverState = StateProperties11;
            StateProperties12.BorderColor = Color.Silver;
            StateProperties12.FillColor = Color.White;
            StateProperties12.ForeColor = Color.Black;
            StateProperties12.PlaceholderForeColor = Color.Empty;
            _txtGrade.OnIdleState = StateProperties12;
            _txtGrade.PasswordChar = '\0';
            _txtGrade.PlaceholderForeColor = Color.Silver;
            _txtGrade.PlaceholderText = "GRADE";
            _txtGrade.ReadOnly = false;
            _txtGrade.ScrollBars = ScrollBars.None;
            _txtGrade.SelectedText = "";
            _txtGrade.SelectionLength = 0;
            _txtGrade.SelectionStart = 0;
            _txtGrade.ShortcutsEnabled = true;
            _txtGrade.Size = new Size(450, 30);
            _txtGrade.Style = _Style.Bunifu;
            _txtGrade.TabIndex = 243;
            _txtGrade.TextAlign = HorizontalAlignment.Left;
            _txtGrade.TextMarginBottom = 0;
            _txtGrade.TextMarginLeft = 5;
            _txtGrade.TextMarginTop = 0;
            _txtGrade.TextPlaceholder = "GRADE";
            _txtGrade.UseSystemPasswordChar = false;
            _txtGrade.WordWrap = true;
            // 
            // txtGradeCode
            // 
            _txtGradeCode.AcceptsReturn = false;
            _txtGradeCode.AcceptsTab = false;
            _txtGradeCode.Anchor = AnchorStyles.Left;
            _txtGradeCode.AnimationSpeed = 200;
            _txtGradeCode.AutoCompleteMode = AutoCompleteMode.None;
            _txtGradeCode.AutoCompleteSource = AutoCompleteSource.None;
            _txtGradeCode.BackColor = Color.Transparent;
            _txtGradeCode.BackgroundImage = (Image)resources.GetObject("txtGradeCode.BackgroundImage");
            _txtGradeCode.BorderColorActive = Color.DodgerBlue;
            _txtGradeCode.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtGradeCode.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtGradeCode.BorderColorIdle = Color.Silver;
            _txtGradeCode.BorderRadius = 1;
            _txtGradeCode.BorderThickness = 1;
            _txtGradeCode.CharacterCasing = CharacterCasing.Upper;
            _txtGradeCode.Cursor = Cursors.IBeam;
            _txtGradeCode.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _txtGradeCode.DefaultText = "";
            _txtGradeCode.FillColor = Color.White;
            _txtGradeCode.ForeColor = Color.Black;
            _txtGradeCode.HideSelection = true;
            _txtGradeCode.IconLeft = null;
            _txtGradeCode.IconLeftCursor = Cursors.IBeam;
            _txtGradeCode.IconPadding = 10;
            _txtGradeCode.IconRight = null;
            _txtGradeCode.IconRightCursor = Cursors.IBeam;
            _txtGradeCode.Lines = new string[0];
            _txtGradeCode.Location = new Point(3, 5);
            _txtGradeCode.MaxLength = 32767;
            _txtGradeCode.MinimumSize = new Size(100, 30);
            _txtGradeCode.Modified = false;
            _txtGradeCode.Multiline = false;
            _txtGradeCode.Name = "_txtGradeCode";
            StateProperties13.BorderColor = Color.DodgerBlue;
            StateProperties13.FillColor = Color.Empty;
            StateProperties13.ForeColor = Color.Empty;
            StateProperties13.PlaceholderForeColor = Color.Empty;
            _txtGradeCode.OnActiveState = StateProperties13;
            StateProperties14.BorderColor = Color.Empty;
            StateProperties14.FillColor = Color.White;
            StateProperties14.ForeColor = Color.Empty;
            StateProperties14.PlaceholderForeColor = Color.Silver;
            _txtGradeCode.OnDisabledState = StateProperties14;
            StateProperties15.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties15.FillColor = Color.Empty;
            StateProperties15.ForeColor = Color.Empty;
            StateProperties15.PlaceholderForeColor = Color.Empty;
            _txtGradeCode.OnHoverState = StateProperties15;
            StateProperties16.BorderColor = Color.Silver;
            StateProperties16.FillColor = Color.White;
            StateProperties16.ForeColor = Color.Black;
            StateProperties16.PlaceholderForeColor = Color.Empty;
            _txtGradeCode.OnIdleState = StateProperties16;
            _txtGradeCode.PasswordChar = '\0';
            _txtGradeCode.PlaceholderForeColor = Color.Silver;
            _txtGradeCode.PlaceholderText = "CODE";
            _txtGradeCode.ReadOnly = false;
            _txtGradeCode.ScrollBars = ScrollBars.None;
            _txtGradeCode.SelectedText = "";
            _txtGradeCode.SelectionLength = 0;
            _txtGradeCode.SelectionStart = 0;
            _txtGradeCode.ShortcutsEnabled = true;
            _txtGradeCode.Size = new Size(114, 30);
            _txtGradeCode.Style = _Style.Bunifu;
            _txtGradeCode.TabIndex = 242;
            _txtGradeCode.TextAlign = HorizontalAlignment.Left;
            _txtGradeCode.TextMarginBottom = 0;
            _txtGradeCode.TextMarginLeft = 5;
            _txtGradeCode.TextMarginTop = 0;
            _txtGradeCode.TextPlaceholder = "CODE";
            _txtGradeCode.UseSystemPasswordChar = false;
            _txtGradeCode.WordWrap = true;
            // 
            // BunifuLabel7
            // 
            BunifuLabel7.Anchor = AnchorStyles.Top;
            BunifuLabel7.AutoEllipsis = false;
            BunifuLabel7.CursorType = null;
            BunifuLabel7.Font = new Font("Microsoft Sans Serif", 14.0f);
            BunifuLabel7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuLabel7.Location = new Point(12, 63);
            BunifuLabel7.Name = "BunifuLabel7";
            BunifuLabel7.RightToLeft = RightToLeft.No;
            BunifuLabel7.Size = new Size(308, 26);
            BunifuLabel7.TabIndex = 233;
            BunifuLabel7.Text = "Commodity and Grade Management";
            BunifuLabel7.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(_dgvCommodity);
            Panel1.Location = new Point(9, 156);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(580, 405);
            Panel1.TabIndex = 234;
            // 
            // Panel2
            // 
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(_dgvGrade);
            Panel2.Location = new Point(613, 156);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(578, 405);
            Panel2.TabIndex = 235;
            // 
            // btnEditCommodity
            // 
            _btnEditCommodity.AllowToggling = false;
            _btnEditCommodity.Anchor = AnchorStyles.Right;
            _btnEditCommodity.AnimationSpeed = 200;
            _btnEditCommodity.AutoGenerateColors = false;
            _btnEditCommodity.BackColor = Color.Transparent;
            _btnEditCommodity.BackColor1 = Color.Teal;
            _btnEditCommodity.BackgroundImage = (Image)resources.GetObject("btnEditCommodity.BackgroundImage");
            _btnEditCommodity.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnEditCommodity.ButtonText = "Edit";
            _btnEditCommodity.ButtonTextMarginLeft = 0;
            _btnEditCommodity.ColorContrastOnClick = 45;
            _btnEditCommodity.ColorContrastOnHover = 45;
            _btnEditCommodity.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnEditCommodity.CustomizableEdges = BorderEdges1;
            _btnEditCommodity.DialogResult = DialogResult.None;
            _btnEditCommodity.DisabledBorderColor = Color.Empty;
            _btnEditCommodity.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnEditCommodity.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnEditCommodity.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnEditCommodity.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnEditCommodity.ForeColor = Color.White;
            _btnEditCommodity.IconLeftCursor = Cursors.Hand;
            _btnEditCommodity.IconMarginLeft = 11;
            _btnEditCommodity.IconPadding = 10;
            _btnEditCommodity.IconRightCursor = Cursors.Hand;
            _btnEditCommodity.IdleBorderColor = Color.Teal;
            _btnEditCommodity.IdleBorderRadius = 3;
            _btnEditCommodity.IdleBorderThickness = 1;
            _btnEditCommodity.IdleFillColor = Color.Teal;
            _btnEditCommodity.IdleIconLeftImage = null;
            _btnEditCommodity.IdleIconRightImage = null;
            _btnEditCommodity.IndicateFocus = true;
            _btnEditCommodity.Location = new Point(497, 3);
            _btnEditCommodity.Name = "_btnEditCommodity";
            StateProperties17.BorderColor = Color.LightSeaGreen;
            StateProperties17.BorderRadius = 3;
            StateProperties17.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties17.BorderThickness = 1;
            StateProperties17.FillColor = Color.LightSeaGreen;
            StateProperties17.ForeColor = Color.White;
            StateProperties17.IconLeftImage = null;
            StateProperties17.IconRightImage = null;
            _btnEditCommodity.onHoverState = StateProperties17;
            StateProperties18.BorderColor = Color.Teal;
            StateProperties18.BorderRadius = 3;
            StateProperties18.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties18.BorderThickness = 1;
            StateProperties18.FillColor = Color.Teal;
            StateProperties18.ForeColor = Color.White;
            StateProperties18.IconLeftImage = null;
            StateProperties18.IconRightImage = null;
            _btnEditCommodity.OnPressedState = StateProperties18;
            _btnEditCommodity.Size = new Size(80, 33);
            _btnEditCommodity.TabIndex = 237;
            _btnEditCommodity.TextAlign = ContentAlignment.MiddleCenter;
            _btnEditCommodity.TextMarginLeft = 0;
            _btnEditCommodity.UseDefaultRadiusAndThickness = true;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.ColumnCount = 2;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.0f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel3.Controls.Add(_btnAddCommodity, 0, 0);
            TableLayoutPanel3.Controls.Add(_btnEditCommodity, 1, 0);
            TableLayoutPanel3.Location = new Point(9, 564);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel3.Size = new Size(580, 40);
            TableLayoutPanel3.TabIndex = 238;
            // 
            // TableLayoutPanel4
            // 
            TableLayoutPanel4.ColumnCount = 2;
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.0f));
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel4.Controls.Add(_btnAddGrade, 0, 0);
            TableLayoutPanel4.Controls.Add(_btnEditGrade, 1, 0);
            TableLayoutPanel4.Location = new Point(613, 564);
            TableLayoutPanel4.Name = "TableLayoutPanel4";
            TableLayoutPanel4.RowCount = 1;
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40.0f));
            TableLayoutPanel4.Size = new Size(580, 40);
            TableLayoutPanel4.TabIndex = 239;
            // 
            // btnEditGrade
            // 
            _btnEditGrade.AllowToggling = false;
            _btnEditGrade.Anchor = AnchorStyles.Right;
            _btnEditGrade.AnimationSpeed = 200;
            _btnEditGrade.AutoGenerateColors = false;
            _btnEditGrade.BackColor = Color.Transparent;
            _btnEditGrade.BackColor1 = Color.Teal;
            _btnEditGrade.BackgroundImage = (Image)resources.GetObject("btnEditGrade.BackgroundImage");
            _btnEditGrade.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnEditGrade.ButtonText = "Edit";
            _btnEditGrade.ButtonTextMarginLeft = 0;
            _btnEditGrade.ColorContrastOnClick = 45;
            _btnEditGrade.ColorContrastOnHover = 45;
            _btnEditGrade.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _btnEditGrade.CustomizableEdges = BorderEdges4;
            _btnEditGrade.DialogResult = DialogResult.None;
            _btnEditGrade.DisabledBorderColor = Color.Empty;
            _btnEditGrade.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnEditGrade.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnEditGrade.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnEditGrade.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnEditGrade.ForeColor = Color.White;
            _btnEditGrade.IconLeftCursor = Cursors.Hand;
            _btnEditGrade.IconMarginLeft = 11;
            _btnEditGrade.IconPadding = 10;
            _btnEditGrade.IconRightCursor = Cursors.Hand;
            _btnEditGrade.IdleBorderColor = Color.Teal;
            _btnEditGrade.IdleBorderRadius = 3;
            _btnEditGrade.IdleBorderThickness = 1;
            _btnEditGrade.IdleFillColor = Color.Teal;
            _btnEditGrade.IdleIconLeftImage = null;
            _btnEditGrade.IdleIconRightImage = null;
            _btnEditGrade.IndicateFocus = true;
            _btnEditGrade.Location = new Point(497, 3);
            _btnEditGrade.Name = "_btnEditGrade";
            StateProperties23.BorderColor = Color.LightSeaGreen;
            StateProperties23.BorderRadius = 3;
            StateProperties23.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties23.BorderThickness = 1;
            StateProperties23.FillColor = Color.LightSeaGreen;
            StateProperties23.ForeColor = Color.White;
            StateProperties23.IconLeftImage = null;
            StateProperties23.IconRightImage = null;
            _btnEditGrade.onHoverState = StateProperties23;
            StateProperties24.BorderColor = Color.Teal;
            StateProperties24.BorderRadius = 3;
            StateProperties24.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties24.BorderThickness = 1;
            StateProperties24.FillColor = Color.Teal;
            StateProperties24.ForeColor = Color.White;
            StateProperties24.IconLeftImage = null;
            StateProperties24.IconRightImage = null;
            _btnEditGrade.OnPressedState = StateProperties24;
            _btnEditGrade.Size = new Size(80, 33);
            _btnEditGrade.TabIndex = 240;
            _btnEditGrade.TextAlign = ContentAlignment.MiddleCenter;
            _btnEditGrade.TextMarginLeft = 0;
            _btnEditGrade.UseDefaultRadiusAndThickness = true;
            // 
            // btnAddCommodity
            // 
            _btnAddCommodity.AllowToggling = false;
            _btnAddCommodity.Anchor = AnchorStyles.Right;
            _btnAddCommodity.AnimationSpeed = 200;
            _btnAddCommodity.AutoGenerateColors = false;
            _btnAddCommodity.BackColor = Color.Transparent;
            _btnAddCommodity.BackColor1 = Color.Teal;
            _btnAddCommodity.BackgroundImage = (Image)resources.GetObject("btnAddCommodity.BackgroundImage");
            _btnAddCommodity.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddCommodity.ButtonText = "Add";
            _btnAddCommodity.ButtonTextMarginLeft = 0;
            _btnAddCommodity.ColorContrastOnClick = 45;
            _btnAddCommodity.ColorContrastOnHover = 45;
            _btnAddCommodity.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnAddCommodity.CustomizableEdges = BorderEdges2;
            _btnAddCommodity.DialogResult = DialogResult.None;
            _btnAddCommodity.DisabledBorderColor = Color.Empty;
            _btnAddCommodity.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddCommodity.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddCommodity.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddCommodity.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddCommodity.ForeColor = Color.White;
            _btnAddCommodity.IconLeftCursor = Cursors.Hand;
            _btnAddCommodity.IconMarginLeft = 11;
            _btnAddCommodity.IconPadding = 10;
            _btnAddCommodity.IconRightCursor = Cursors.Hand;
            _btnAddCommodity.IdleBorderColor = Color.Teal;
            _btnAddCommodity.IdleBorderRadius = 3;
            _btnAddCommodity.IdleBorderThickness = 1;
            _btnAddCommodity.IdleFillColor = Color.Teal;
            _btnAddCommodity.IdleIconLeftImage = null;
            _btnAddCommodity.IdleIconRightImage = null;
            _btnAddCommodity.IndicateFocus = true;
            _btnAddCommodity.Location = new Point(381, 3);
            _btnAddCommodity.Name = "_btnAddCommodity";
            StateProperties19.BorderColor = Color.LightSeaGreen;
            StateProperties19.BorderRadius = 3;
            StateProperties19.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties19.BorderThickness = 1;
            StateProperties19.FillColor = Color.LightSeaGreen;
            StateProperties19.ForeColor = Color.White;
            StateProperties19.IconLeftImage = null;
            StateProperties19.IconRightImage = null;
            _btnAddCommodity.onHoverState = StateProperties19;
            StateProperties20.BorderColor = Color.Teal;
            StateProperties20.BorderRadius = 3;
            StateProperties20.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties20.BorderThickness = 1;
            StateProperties20.FillColor = Color.Teal;
            StateProperties20.ForeColor = Color.White;
            StateProperties20.IconLeftImage = null;
            StateProperties20.IconRightImage = null;
            _btnAddCommodity.OnPressedState = StateProperties20;
            _btnAddCommodity.Size = new Size(80, 33);
            _btnAddCommodity.TabIndex = 238;
            _btnAddCommodity.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddCommodity.TextMarginLeft = 0;
            _btnAddCommodity.UseDefaultRadiusAndThickness = true;
            // 
            // btnAddGrade
            // 
            _btnAddGrade.AllowToggling = false;
            _btnAddGrade.Anchor = AnchorStyles.Right;
            _btnAddGrade.AnimationSpeed = 200;
            _btnAddGrade.AutoGenerateColors = false;
            _btnAddGrade.BackColor = Color.Transparent;
            _btnAddGrade.BackColor1 = Color.Teal;
            _btnAddGrade.BackgroundImage = (Image)resources.GetObject("btnAddGrade.BackgroundImage");
            _btnAddGrade.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddGrade.ButtonText = "Add";
            _btnAddGrade.ButtonTextMarginLeft = 0;
            _btnAddGrade.ColorContrastOnClick = 45;
            _btnAddGrade.ColorContrastOnHover = 45;
            _btnAddGrade.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _btnAddGrade.CustomizableEdges = BorderEdges3;
            _btnAddGrade.DialogResult = DialogResult.None;
            _btnAddGrade.DisabledBorderColor = Color.Empty;
            _btnAddGrade.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddGrade.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddGrade.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddGrade.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddGrade.ForeColor = Color.White;
            _btnAddGrade.IconLeftCursor = Cursors.Hand;
            _btnAddGrade.IconMarginLeft = 11;
            _btnAddGrade.IconPadding = 10;
            _btnAddGrade.IconRightCursor = Cursors.Hand;
            _btnAddGrade.IdleBorderColor = Color.Teal;
            _btnAddGrade.IdleBorderRadius = 3;
            _btnAddGrade.IdleBorderThickness = 1;
            _btnAddGrade.IdleFillColor = Color.Teal;
            _btnAddGrade.IdleIconLeftImage = null;
            _btnAddGrade.IdleIconRightImage = null;
            _btnAddGrade.IndicateFocus = true;
            _btnAddGrade.Location = new Point(381, 3);
            _btnAddGrade.Name = "_btnAddGrade";
            StateProperties21.BorderColor = Color.LightSeaGreen;
            StateProperties21.BorderRadius = 3;
            StateProperties21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties21.BorderThickness = 1;
            StateProperties21.FillColor = Color.LightSeaGreen;
            StateProperties21.ForeColor = Color.White;
            StateProperties21.IconLeftImage = null;
            StateProperties21.IconRightImage = null;
            _btnAddGrade.onHoverState = StateProperties21;
            StateProperties22.BorderColor = Color.Teal;
            StateProperties22.BorderRadius = 3;
            StateProperties22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties22.BorderThickness = 1;
            StateProperties22.FillColor = Color.Teal;
            StateProperties22.ForeColor = Color.White;
            StateProperties22.IconLeftImage = null;
            StateProperties22.IconRightImage = null;
            _btnAddGrade.OnPressedState = StateProperties22;
            _btnAddGrade.Size = new Size(80, 33);
            _btnAddGrade.TabIndex = 241;
            _btnAddGrade.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddGrade.TextMarginLeft = 0;
            _btnAddGrade.UseDefaultRadiusAndThickness = true;
            // 
            // GradeIdDataGridViewTextBoxColumn
            // 
            GradeIdDataGridViewTextBoxColumn.DataPropertyName = "GradeId";
            GradeIdDataGridViewTextBoxColumn.HeaderText = "GradeId";
            GradeIdDataGridViewTextBoxColumn.Name = "GradeIdDataGridViewTextBoxColumn";
            GradeIdDataGridViewTextBoxColumn.ReadOnly = true;
            GradeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // GradeCode
            // 
            GradeCode.DataPropertyName = "GradeCode";
            GradeCode.FillWeight = 101.5228f;
            GradeCode.HeaderText = "Code";
            GradeCode.MinimumWidth = 100;
            GradeCode.Name = "GradeCode";
            GradeCode.ReadOnly = true;
            // 
            // GradeName
            // 
            GradeName.DataPropertyName = "GradeName";
            GradeName.FillWeight = 98.47716f;
            GradeName.HeaderText = "Grade";
            GradeName.MinimumWidth = 460;
            GradeName.Name = "GradeName";
            GradeName.ReadOnly = true;
            // 
            // MiniUnitDataGridViewTextBoxColumn1
            // 
            MiniUnitDataGridViewTextBoxColumn1.DataPropertyName = "MiniUnit";
            MiniUnitDataGridViewTextBoxColumn1.HeaderText = "MiniUnit";
            MiniUnitDataGridViewTextBoxColumn1.Name = "MiniUnitDataGridViewTextBoxColumn1";
            MiniUnitDataGridViewTextBoxColumn1.ReadOnly = true;
            MiniUnitDataGridViewTextBoxColumn1.Visible = false;
            // 
            // MiniBookingCommodityDataGridViewTextBoxColumn1
            // 
            MiniBookingCommodityDataGridViewTextBoxColumn1.DataPropertyName = "MiniBookingCommodity";
            MiniBookingCommodityDataGridViewTextBoxColumn1.HeaderText = "MiniBookingCommodity";
            MiniBookingCommodityDataGridViewTextBoxColumn1.Name = "MiniBookingCommodityDataGridViewTextBoxColumn1";
            MiniBookingCommodityDataGridViewTextBoxColumn1.ReadOnly = true;
            MiniBookingCommodityDataGridViewTextBoxColumn1.Visible = false;
            // 
            // GradeBindingSource
            // 
            GradeBindingSource.DataSource = typeof(ModelLayer.Grade);
            // 
            // CommodityIdDataGridViewTextBoxColumn
            // 
            CommodityIdDataGridViewTextBoxColumn.DataPropertyName = "CommodityId";
            CommodityIdDataGridViewTextBoxColumn.HeaderText = "CommodityId";
            CommodityIdDataGridViewTextBoxColumn.Name = "CommodityIdDataGridViewTextBoxColumn";
            CommodityIdDataGridViewTextBoxColumn.ReadOnly = true;
            CommodityIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // CommodityCode
            // 
            CommodityCode.DataPropertyName = "CommodityCode";
            CommodityCode.FillWeight = 101.5228f;
            CommodityCode.HeaderText = "Code";
            CommodityCode.MinimumWidth = 120;
            CommodityCode.Name = "CommodityCode";
            CommodityCode.ReadOnly = true;
            // 
            // CommodityName
            // 
            CommodityName.DataPropertyName = "CommodityName";
            CommodityName.FillWeight = 98.47716f;
            CommodityName.HeaderText = "Commodity";
            CommodityName.MinimumWidth = 440;
            CommodityName.Name = "CommodityName";
            CommodityName.ReadOnly = true;
            // 
            // MiniUnitDataGridViewTextBoxColumn
            // 
            MiniUnitDataGridViewTextBoxColumn.DataPropertyName = "MiniUnit";
            MiniUnitDataGridViewTextBoxColumn.HeaderText = "MiniUnit";
            MiniUnitDataGridViewTextBoxColumn.Name = "MiniUnitDataGridViewTextBoxColumn";
            MiniUnitDataGridViewTextBoxColumn.ReadOnly = true;
            MiniUnitDataGridViewTextBoxColumn.Visible = false;
            // 
            // MiniBookingCommodityDataGridViewTextBoxColumn
            // 
            MiniBookingCommodityDataGridViewTextBoxColumn.DataPropertyName = "MiniBookingCommodity";
            MiniBookingCommodityDataGridViewTextBoxColumn.HeaderText = "MiniBookingCommodity";
            MiniBookingCommodityDataGridViewTextBoxColumn.Name = "MiniBookingCommodityDataGridViewTextBoxColumn";
            MiniBookingCommodityDataGridViewTextBoxColumn.ReadOnly = true;
            MiniBookingCommodityDataGridViewTextBoxColumn.Visible = false;
            // 
            // CommodityBindingSource
            // 
            CommodityBindingSource.DataSource = typeof(ModelLayer.Commodity);
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 460.0f));
            TableLayoutPanel1.Controls.Add(_txtCommodity, 1, 0);
            TableLayoutPanel1.Controls.Add(_txtCommodityCode, 0, 0);
            TableLayoutPanel1.Location = new Point(9, 116);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel1.Size = new Size(580, 40);
            TableLayoutPanel1.TabIndex = 151;
            // 
            // frmCommodityGrainMain
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 650);
            Controls.Add(TableLayoutPanel4);
            Controls.Add(TableLayoutPanel3);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Controls.Add(BunifuLabel7);
            Controls.Add(TableLayoutPanel2);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(_closeLabel);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCommodityGrainMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCommodityGrainManagement";
            ((System.ComponentModel.ISupportInitialize)_dgvCommodity).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dgvGrade).EndInit();
            TableLayoutPanel2.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            TableLayoutPanel3.ResumeLayout(false);
            TableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GradeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)CommodityBindingSource).EndInit();
            TableLayoutPanel1.ResumeLayout(false);
            Load += new EventHandler(frmCommodityGrainMain_Load);
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
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvCommodity;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvCommodity
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvCommodity;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvCommodity != null)
                {
                    _dgvCommodity.ColumnHeaderMouseClick -= dgvCommodity_ColumnHeaderMouseClick;
                }

                _dgvCommodity = value;
                if (_dgvCommodity != null)
                {
                    _dgvCommodity.ColumnHeaderMouseClick += dgvCommodity_ColumnHeaderMouseClick;
                }
            }
        }

        internal BindingSource CommodityBindingSource;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvGrade;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvGrade
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvGrade;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvGrade != null)
                {
                    _dgvGrade.ColumnHeaderMouseClick -= dgvGrade_ColumnHeaderMouseClick;
                }

                _dgvGrade = value;
                if (_dgvGrade != null)
                {
                    _dgvGrade.ColumnHeaderMouseClick += dgvGrade_ColumnHeaderMouseClick;
                }
            }
        }

        internal BindingSource GradeBindingSource;
        internal TableLayoutPanel TableLayoutPanel2;
        private BunifuTextBox _txtCommodityCode;

        internal BunifuTextBox txtCommodityCode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCommodityCode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCommodityCode != null)
                {
                    _txtCommodityCode.TextChange -= txtCommodityCode_TextChange;
                }

                _txtCommodityCode = value;
                if (_txtCommodityCode != null)
                {
                    _txtCommodityCode.TextChange += txtCommodityCode_TextChange;
                }
            }
        }

        private BunifuTextBox _txtCommodity;

        internal BunifuTextBox txtCommodity
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtCommodity;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtCommodity != null)
                {
                    _txtCommodity.TextChange -= txtCommodity_TextChange;
                }

                _txtCommodity = value;
                if (_txtCommodity != null)
                {
                    _txtCommodity.TextChange += txtCommodity_TextChange;
                }
            }
        }

        private BunifuTextBox _txtGrade;

        internal BunifuTextBox txtGrade
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtGrade;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtGrade != null)
                {
                    _txtGrade.TextChange -= txtGrade_TextChange;
                }

                _txtGrade = value;
                if (_txtGrade != null)
                {
                    _txtGrade.TextChange += txtGrade_TextChange;
                }
            }
        }

        private BunifuTextBox _txtGradeCode;

        internal BunifuTextBox txtGradeCode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtGradeCode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtGradeCode != null)
                {
                    _txtGradeCode.TextChange -= txtGradeCode_TextChange;
                }

                _txtGradeCode = value;
                if (_txtGradeCode != null)
                {
                    _txtGradeCode.TextChange += txtGradeCode_TextChange;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel7;
        internal Panel Panel1;
        internal DataGridViewTextBoxColumn GradeIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn GradeCode;
        internal DataGridViewTextBoxColumn GradeName;
        internal DataGridViewTextBoxColumn MiniUnitDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn MiniBookingCommodityDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn CommodityIdDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CommodityCode;
        internal DataGridViewTextBoxColumn CommodityName;
        internal DataGridViewTextBoxColumn MiniUnitDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn MiniBookingCommodityDataGridViewTextBoxColumn;
        internal Panel Panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnEditCommodity;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEditCommodity
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnEditCommodity;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnEditCommodity != null)
                {
                    _btnEditCommodity.Click -= btnEditCommodity_Click;
                }

                _btnEditCommodity = value;
                if (_btnEditCommodity != null)
                {
                    _btnEditCommodity.Click += btnEditCommodity_Click;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel3;
        internal TableLayoutPanel TableLayoutPanel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnEditGrade;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEditGrade
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnEditGrade;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnEditGrade != null)
                {
                    _btnEditGrade.Click -= btnEditGrade_Click;
                }

                _btnEditGrade = value;
                if (_btnEditGrade != null)
                {
                    _btnEditGrade.Click += btnEditGrade_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddCommodity;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddCommodity
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddCommodity;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddCommodity != null)
                {
                    _btnAddCommodity.Click -= btnAddCommodity_Click;
                }

                _btnAddCommodity = value;
                if (_btnAddCommodity != null)
                {
                    _btnAddCommodity.Click += btnAddCommodity_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddGrade;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddGrade
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddGrade;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddGrade != null)
                {
                    _btnAddGrade.Click -= btnAddGrade_Click;
                }

                _btnAddGrade = value;
                if (_btnAddGrade != null)
                {
                    _btnAddGrade.Click += btnAddGrade_Click;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel1;
    }
}