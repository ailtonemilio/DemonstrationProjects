using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmCreateTransfer : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateTransfer));
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
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            TableLayoutPanel = new TableLayoutPanel();
            TableLayoutPanel2 = new TableLayoutPanel();
            _dueTypeBunifuDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            _dueTypeBunifuDropdown.SelectedIndexChanged += new EventHandler(dueTypeBunifuDropdown_SelectedIndexChanged);
            _NumericUpDown = new NumericUpDown();
            _NumericUpDown.ValueChanged += new EventHandler(NumericUpDown_ValueChanged);
            dueLabel = new Label();
            Label13 = new Label();
            fromComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            Label7 = new Label();
            Label5 = new Label();
            toComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            loadedInfoTableLayoutPanel = new TableLayoutPanel();
            Label6 = new Label();
            Label8 = new Label();
            weightTextBox = new TextBox();
            TableLayoutPanel1 = new TableLayoutPanel();
            sizeComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            _statusComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            _statusComboBox.SelectedIndexChanged += new EventHandler(statusComboBox_SelectedIndexChanged);
            Label4 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            _containersRichTextBox = new RichTextBox();
            _containersRichTextBox.TextChanged += new EventHandler(containersRichTextBox_TextChanged);
            _checkBunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _checkBunifuButton1.Click += new EventHandler(assignBunifuButton1_Click);
            _transferAnywaysButton = new Button();
            _transferAnywaysButton.Click += new EventHandler(transferAnywaysButton_Click);
            Label1 = new Label();
            Panel1 = new Panel();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(Label6_Click);
            _closeLabel.MouseHover += new EventHandler(closeLabel_MouseHover);
            _closeLabel.MouseLeave += new EventHandler(closeLabel_Click);
            _closeLabel.Click += new EventHandler(closeLabel_MouseLeave);
            Panel2 = new Panel();
            titlewarningLabel = new Label();
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(Label6_Click);
            _cancelButton.Click += new EventHandler(cancelButton_Click);
            explanationTableLayoutPanel = new TableLayoutPanel();
            Label10 = new Label();
            Label9 = new Label();
            Label11 = new Label();
            Label12 = new Label();
            problemsDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            truckerComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            okToTransferDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            _createTransfeRButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _createTransfeRButton.Click += new EventHandler(createTransfetTouchButton_Load);
            TableLayoutPanel.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_NumericUpDown).BeginInit();
            loadedInfoTableLayoutPanel.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            explanationTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)problemsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)okToTransferDataGrid).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.Anchor = AnchorStyles.Top;
            TableLayoutPanel.ColumnCount = 2;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117.0f));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanel.Controls.Add(TableLayoutPanel2, 1, 2);
            TableLayoutPanel.Controls.Add(Label13, 0, 2);
            TableLayoutPanel.Controls.Add(fromComboBox, 1, 0);
            TableLayoutPanel.Controls.Add(Label7, 0, 1);
            TableLayoutPanel.Controls.Add(Label5, 0, 0);
            TableLayoutPanel.Controls.Add(toComboBox, 1, 1);
            TableLayoutPanel.Location = new Point(107, 428);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 3;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42.0f));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 39.0f));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel.Size = new Size(651, 121);
            TableLayoutPanel.TabIndex = 9;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 3;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 310.0f));
            TableLayoutPanel2.Controls.Add(_dueTypeBunifuDropdown, 1, 0);
            TableLayoutPanel2.Controls.Add(_NumericUpDown, 0, 0);
            TableLayoutPanel2.Controls.Add(dueLabel, 2, 0);
            TableLayoutPanel2.Dock = DockStyle.Fill;
            TableLayoutPanel2.Location = new Point(117, 82);
            TableLayoutPanel2.Margin = new Padding(0);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 1;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39.0f));
            TableLayoutPanel2.Size = new Size(534, 39);
            TableLayoutPanel2.TabIndex = 80;
            // 
            // dueTypeBunifuDropdown
            // 
            _dueTypeBunifuDropdown.BackColor = Color.White;
            _dueTypeBunifuDropdown.BorderRadius = 3;
            _dueTypeBunifuDropdown.Color = Color.Teal;
            _dueTypeBunifuDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _dueTypeBunifuDropdown.DisabledColor = Color.Gray;
            _dueTypeBunifuDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            _dueTypeBunifuDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            _dueTypeBunifuDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            _dueTypeBunifuDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _dueTypeBunifuDropdown.FillDropDown = false;
            _dueTypeBunifuDropdown.FillIndicator = true;
            _dueTypeBunifuDropdown.FlatStyle = FlatStyle.Flat;
            _dueTypeBunifuDropdown.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _dueTypeBunifuDropdown.ForeColor = SystemColors.ControlDarkDark;
            _dueTypeBunifuDropdown.FormattingEnabled = true;
            _dueTypeBunifuDropdown.Icon = null;
            _dueTypeBunifuDropdown.IndicatorColor = Color.Teal;
            _dueTypeBunifuDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _dueTypeBunifuDropdown.ItemBackColor = Color.White;
            _dueTypeBunifuDropdown.ItemBorderColor = Color.White;
            _dueTypeBunifuDropdown.ItemForeColor = SystemColors.ControlDarkDark;
            _dueTypeBunifuDropdown.ItemHeight = 26;
            _dueTypeBunifuDropdown.ItemHighLightColor = Color.Gray;
            _dueTypeBunifuDropdown.Items.AddRange(new object[] { "Days", "Weeks", "Months" });
            _dueTypeBunifuDropdown.Location = new Point(87, 3);
            _dueTypeBunifuDropdown.MaxDropDownItems = 20;
            _dueTypeBunifuDropdown.Name = "_dueTypeBunifuDropdown";
            _dueTypeBunifuDropdown.Size = new Size(134, 32);
            _dueTypeBunifuDropdown.TabIndex = 80;
            _dueTypeBunifuDropdown.Text = "Days";
            // 
            // NumericUpDown
            // 
            _NumericUpDown.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _NumericUpDown.Location = new Point(3, 3);
            _NumericUpDown.Name = "_NumericUpDown";
            _NumericUpDown.Size = new Size(70, 28);
            _NumericUpDown.TabIndex = 79;
            _NumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dueLabel
            // 
            dueLabel.Anchor = AnchorStyles.None;
            dueLabel.AutoSize = true;
            dueLabel.BackColor = Color.Firebrick;
            dueLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            dueLabel.ForeColor = Color.White;
            dueLabel.Location = new Point(282, 9);
            dueLabel.Name = "dueLabel";
            dueLabel.Size = new Size(194, 21);
            dueLabel.TabIndex = 80;
            dueLabel.Text = "Deadline: 22-March-2020";
            dueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Dock = DockStyle.Fill;
            Label13.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.Location = new Point(3, 82);
            Label13.Name = "Label13";
            Label13.Size = new Size(111, 39);
            Label13.TabIndex = 79;
            Label13.Text = "Deadline:";
            Label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fromComboBox
            // 
            fromComboBox.BackColor = Color.White;
            fromComboBox.BorderRadius = 3;
            fromComboBox.Color = Color.Teal;
            fromComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            fromComboBox.DisabledColor = Color.Gray;
            fromComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            fromComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            fromComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fromComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            fromComboBox.FillDropDown = false;
            fromComboBox.FillIndicator = true;
            fromComboBox.FlatStyle = FlatStyle.Flat;
            fromComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            fromComboBox.ForeColor = SystemColors.ControlDarkDark;
            fromComboBox.FormattingEnabled = true;
            fromComboBox.Icon = null;
            fromComboBox.IndicatorColor = Color.Teal;
            fromComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            fromComboBox.ItemBackColor = Color.White;
            fromComboBox.ItemBorderColor = Color.White;
            fromComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            fromComboBox.ItemHeight = 26;
            fromComboBox.ItemHighLightColor = Color.Gray;
            fromComboBox.Location = new Point(120, 3);
            fromComboBox.MaxDropDownItems = 20;
            fromComboBox.Name = "fromComboBox";
            fromComboBox.Size = new Size(423, 32);
            fromComboBox.TabIndex = 78;
            fromComboBox.Text = "From";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Dock = DockStyle.Fill;
            Label7.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(3, 40);
            Label7.Name = "Label7";
            Label7.Size = new Size(111, 42);
            Label7.TabIndex = 9;
            Label7.Text = "To:";
            Label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Dock = DockStyle.Fill;
            Label5.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(3, 0);
            Label5.Name = "Label5";
            Label5.Padding = new Padding(0, 5, 0, 0);
            Label5.Size = new Size(111, 40);
            Label5.TabIndex = 5;
            Label5.Text = "From:";
            Label5.TextAlign = ContentAlignment.TopRight;
            // 
            // toComboBox
            // 
            toComboBox.BackColor = Color.White;
            toComboBox.BorderRadius = 3;
            toComboBox.Color = Color.Teal;
            toComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            toComboBox.DisabledColor = Color.Gray;
            toComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            toComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            toComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            toComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            toComboBox.FillDropDown = false;
            toComboBox.FillIndicator = true;
            toComboBox.FlatStyle = FlatStyle.Flat;
            toComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            toComboBox.ForeColor = SystemColors.ControlDarkDark;
            toComboBox.FormattingEnabled = true;
            toComboBox.Icon = null;
            toComboBox.IndicatorColor = Color.Teal;
            toComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            toComboBox.ItemBackColor = Color.White;
            toComboBox.ItemBorderColor = Color.White;
            toComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            toComboBox.ItemHeight = 26;
            toComboBox.ItemHighLightColor = Color.Gray;
            toComboBox.Location = new Point(120, 43);
            toComboBox.MaxDropDownItems = 20;
            toComboBox.Name = "toComboBox";
            toComboBox.Size = new Size(423, 32);
            toComboBox.TabIndex = 77;
            toComboBox.Text = "To";
            // 
            // loadedInfoTableLayoutPanel
            // 
            loadedInfoTableLayoutPanel.ColumnCount = 3;
            loadedInfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            loadedInfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            loadedInfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57.0f));
            loadedInfoTableLayoutPanel.Controls.Add(Label6, 0, 0);
            loadedInfoTableLayoutPanel.Controls.Add(Label8, 2, 0);
            loadedInfoTableLayoutPanel.Controls.Add(weightTextBox, 1, 0);
            loadedInfoTableLayoutPanel.Location = new Point(394, 205);
            loadedInfoTableLayoutPanel.Name = "loadedInfoTableLayoutPanel";
            loadedInfoTableLayoutPanel.RowCount = 1;
            loadedInfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            loadedInfoTableLayoutPanel.Size = new Size(233, 36);
            loadedInfoTableLayoutPanel.TabIndex = 9;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Dock = DockStyle.Fill;
            Label6.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.Location = new Point(3, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(63, 36);
            Label6.TabIndex = 5;
            Label6.Text = "Weight:";
            Label6.TextAlign = ContentAlignment.TopRight;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(176, 0);
            Label8.Margin = new Padding(0);
            Label8.Name = "Label8";
            Label8.Size = new Size(31, 20);
            Label8.TabIndex = 7;
            Label8.Text = "MT";
            Label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // weightTextBox
            // 
            weightTextBox.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            weightTextBox.Location = new Point(72, 3);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(90, 28);
            weightTextBox.TabIndex = 6;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Top;
            TableLayoutPanel1.ColumnCount = 3;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanel1.Controls.Add(sizeComboBox, 1, 2);
            TableLayoutPanel1.Controls.Add(_statusComboBox, 1, 3);
            TableLayoutPanel1.Controls.Add(Label4, 0, 3);
            TableLayoutPanel1.Controls.Add(Label2, 0, 1);
            TableLayoutPanel1.Controls.Add(Label3, 0, 2);
            TableLayoutPanel1.Controls.Add(loadedInfoTableLayoutPanel, 2, 3);
            TableLayoutPanel1.Controls.Add(_containersRichTextBox, 1, 1);
            TableLayoutPanel1.Controls.Add(_checkBunifuButton1, 2, 1);
            TableLayoutPanel1.Location = new Point(107, 174);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 4;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.721088f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.31925f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.04425f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.14159f));
            TableLayoutPanel1.Size = new Size(651, 248);
            TableLayoutPanel1.TabIndex = 10;
            // 
            // sizeComboBox
            // 
            sizeComboBox.BackColor = Color.White;
            sizeComboBox.BorderRadius = 3;
            sizeComboBox.Color = Color.Teal;
            sizeComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            sizeComboBox.DisabledColor = Color.Gray;
            sizeComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            sizeComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            sizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sizeComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            sizeComboBox.FillDropDown = false;
            sizeComboBox.FillIndicator = true;
            sizeComboBox.FlatStyle = FlatStyle.Flat;
            sizeComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            sizeComboBox.ForeColor = SystemColors.ControlDarkDark;
            sizeComboBox.FormattingEnabled = true;
            sizeComboBox.Icon = null;
            sizeComboBox.IndicatorColor = Color.Teal;
            sizeComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            sizeComboBox.ItemBackColor = Color.White;
            sizeComboBox.ItemBorderColor = Color.White;
            sizeComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            sizeComboBox.ItemHeight = 26;
            sizeComboBox.ItemHighLightColor = Color.Gray;
            sizeComboBox.Items.AddRange(new object[] { "20'", "40'" });
            sizeComboBox.Location = new Point(104, 168);
            sizeComboBox.MaxDropDownItems = 20;
            sizeComboBox.Name = "sizeComboBox";
            sizeComboBox.Size = new Size(173, 32);
            sizeComboBox.TabIndex = 79;
            sizeComboBox.Text = "Size";
            // 
            // statusComboBox
            // 
            _statusComboBox.BackColor = Color.White;
            _statusComboBox.BorderRadius = 3;
            _statusComboBox.Color = Color.Teal;
            _statusComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _statusComboBox.DisabledColor = Color.Gray;
            _statusComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            _statusComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            _statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _statusComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _statusComboBox.FillDropDown = false;
            _statusComboBox.FillIndicator = true;
            _statusComboBox.FlatStyle = FlatStyle.Flat;
            _statusComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _statusComboBox.ForeColor = SystemColors.ControlDarkDark;
            _statusComboBox.FormattingEnabled = true;
            _statusComboBox.Icon = null;
            _statusComboBox.IndicatorColor = Color.Teal;
            _statusComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _statusComboBox.ItemBackColor = Color.White;
            _statusComboBox.ItemBorderColor = Color.White;
            _statusComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            _statusComboBox.ItemHeight = 26;
            _statusComboBox.ItemHighLightColor = Color.Gray;
            _statusComboBox.Items.AddRange(new object[] { "Empty", "Loaded" });
            _statusComboBox.Location = new Point(104, 205);
            _statusComboBox.MaxDropDownItems = 20;
            _statusComboBox.Name = "_statusComboBox";
            _statusComboBox.Size = new Size(284, 32);
            _statusComboBox.TabIndex = 80;
            _statusComboBox.Text = "Status";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Dock = DockStyle.Fill;
            Label4.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(3, 202);
            Label4.Name = "Label4";
            Label4.Padding = new Padding(0, 5, 0, 0);
            Label4.Size = new Size(95, 46);
            Label4.TabIndex = 4;
            Label4.Text = "Status:";
            Label4.TextAlign = ContentAlignment.TopRight;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Dock = DockStyle.Fill;
            Label2.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(3, 6);
            Label2.Name = "Label2";
            Label2.Padding = new Padding(0, 5, 0, 0);
            Label2.Size = new Size(95, 159);
            Label2.TabIndex = 2;
            Label2.Text = "Container #:";
            Label2.TextAlign = ContentAlignment.TopRight;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Dock = DockStyle.Fill;
            Label3.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(3, 165);
            Label3.Name = "Label3";
            Label3.Padding = new Padding(0, 5, 0, 0);
            Label3.Size = new Size(95, 37);
            Label3.TabIndex = 3;
            Label3.Text = "Size:";
            Label3.TextAlign = ContentAlignment.TopRight;
            // 
            // containersRichTextBox
            // 
            _containersRichTextBox.Dock = DockStyle.Fill;
            _containersRichTextBox.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _containersRichTextBox.Location = new Point(104, 9);
            _containersRichTextBox.Name = "_containersRichTextBox";
            _containersRichTextBox.Size = new Size(284, 153);
            _containersRichTextBox.TabIndex = 10;
            _containersRichTextBox.Text = "";
            // 
            // checkBunifuButton1
            // 
            _checkBunifuButton1.AllowToggling = false;
            _checkBunifuButton1.AnimationSpeed = 200;
            _checkBunifuButton1.AutoGenerateColors = false;
            _checkBunifuButton1.BackColor = Color.Transparent;
            _checkBunifuButton1.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _checkBunifuButton1.BackgroundImage = (Image)resources.GetObject("checkBunifuButton1.BackgroundImage");
            _checkBunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _checkBunifuButton1.ButtonText = "Check";
            _checkBunifuButton1.ButtonTextMarginLeft = 0;
            _checkBunifuButton1.ColorContrastOnClick = 45;
            _checkBunifuButton1.ColorContrastOnHover = 45;
            _checkBunifuButton1.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _checkBunifuButton1.CustomizableEdges = BorderEdges1;
            _checkBunifuButton1.DialogResult = DialogResult.None;
            _checkBunifuButton1.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _checkBunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _checkBunifuButton1.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _checkBunifuButton1.Enabled = false;
            _checkBunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _checkBunifuButton1.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _checkBunifuButton1.ForeColor = Color.White;
            _checkBunifuButton1.IconLeftCursor = Cursors.Hand;
            _checkBunifuButton1.IconMarginLeft = 8;
            _checkBunifuButton1.IconPadding = 8;
            _checkBunifuButton1.IconRightCursor = Cursors.Hand;
            _checkBunifuButton1.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _checkBunifuButton1.IdleBorderRadius = 10;
            _checkBunifuButton1.IdleBorderThickness = 1;
            _checkBunifuButton1.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _checkBunifuButton1.IdleIconLeftImage = null;
            _checkBunifuButton1.IdleIconRightImage = null;
            _checkBunifuButton1.IndicateFocus = false;
            _checkBunifuButton1.Location = new Point(394, 9);
            _checkBunifuButton1.Name = "_checkBunifuButton1";
            StateProperties1.BorderColor = Color.Gray;
            StateProperties1.BorderRadius = 10;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.Gray;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _checkBunifuButton1.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties2.BorderRadius = 10;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _checkBunifuButton1.OnPressedState = StateProperties2;
            _checkBunifuButton1.Size = new Size(62, 30);
            _checkBunifuButton1.TabIndex = 82;
            _checkBunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            _checkBunifuButton1.TextMarginLeft = 0;
            _checkBunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // transferAnywaysButton
            // 
            _transferAnywaysButton.Anchor = AnchorStyles.Top;
            _transferAnywaysButton.BackColor = Color.White;
            _transferAnywaysButton.BackgroundImage = (Image)resources.GetObject("transferAnywaysButton.BackgroundImage");
            _transferAnywaysButton.BackgroundImageLayout = ImageLayout.Stretch;
            _transferAnywaysButton.FlatStyle = FlatStyle.Flat;
            _transferAnywaysButton.ForeColor = SystemColors.ButtonFace;
            _transferAnywaysButton.Location = new Point(1021, 540);
            _transferAnywaysButton.Name = "_transferAnywaysButton";
            _transferAnywaysButton.Size = new Size(140, 50);
            _transferAnywaysButton.TabIndex = 17;
            _transferAnywaysButton.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top;
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(138, 105);
            Label1.Name = "Label1";
            Label1.Size = new Size(66, 20);
            Label1.TabIndex = 18;
            Label1.Text = "Trucker:";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel1.Controls.Add(_closeLabel);
            Panel1.Controls.Add(Panel2);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Padding = new Padding(0, 40, 0, 0);
            Panel1.Size = new Size(1414, 815);
            Panel1.TabIndex = 33;
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 20.29091f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(1366, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 40);
            _closeLabel.TabIndex = 78;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(titlewarningLabel);
            Panel2.Controls.Add(_cancelButton);
            Panel2.Controls.Add(explanationTableLayoutPanel);
            Panel2.Controls.Add(problemsDataGrid);
            Panel2.Controls.Add(truckerComboBox);
            Panel2.Controls.Add(_transferAnywaysButton);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(okToTransferDataGrid);
            Panel2.Controls.Add(_createTransfeRButton);
            Panel2.Controls.Add(TableLayoutPanel1);
            Panel2.Controls.Add(TableLayoutPanel);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(0, 40);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1414, 775);
            Panel2.TabIndex = 1;
            // 
            // titlewarningLabel
            // 
            titlewarningLabel.Anchor = AnchorStyles.Top;
            titlewarningLabel.BackColor = Color.Transparent;
            titlewarningLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titlewarningLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titlewarningLabel.Location = new Point(102, 36);
            titlewarningLabel.Name = "titlewarningLabel";
            titlewarningLabel.Size = new Size(647, 36);
            titlewarningLabel.TabIndex = 82;
            titlewarningLabel.Text = "Create new transfer";
            titlewarningLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cancelButton
            // 
            _cancelButton.AllowToggling = false;
            _cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _cancelButton.AnimationSpeed = 200;
            _cancelButton.AutoGenerateColors = false;
            _cancelButton.BackColor = Color.Transparent;
            _cancelButton.BackColor1 = Color.White;
            _cancelButton.BackgroundImage = (Image)resources.GetObject("cancelButton.BackgroundImage");
            _cancelButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _cancelButton.ButtonText = "Cancel";
            _cancelButton.ButtonTextMarginLeft = 0;
            _cancelButton.ColorContrastOnClick = 45;
            _cancelButton.ColorContrastOnHover = 45;
            _cancelButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _cancelButton.CustomizableEdges = BorderEdges2;
            _cancelButton.DialogResult = DialogResult.None;
            _cancelButton.DisabledBorderColor = Color.Empty;
            _cancelButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _cancelButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _cancelButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _cancelButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _cancelButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _cancelButton.IconLeftCursor = Cursors.Hand;
            _cancelButton.IconMarginLeft = 11;
            _cancelButton.IconPadding = 10;
            _cancelButton.IconRightCursor = Cursors.Hand;
            _cancelButton.IdleBorderColor = Color.Gray;
            _cancelButton.IdleBorderRadius = 3;
            _cancelButton.IdleBorderThickness = 1;
            _cancelButton.IdleFillColor = Color.White;
            _cancelButton.IdleIconLeftImage = null;
            _cancelButton.IdleIconRightImage = null;
            _cancelButton.IndicateFocus = true;
            _cancelButton.Location = new Point(1204, 701);
            _cancelButton.Name = "_cancelButton";
            StateProperties3.BorderColor = Color.DarkGray;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.DarkGray;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.IndianRed;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.IndianRed;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties4;
            _cancelButton.Size = new Size(129, 45);
            _cancelButton.TabIndex = 80;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // explanationTableLayoutPanel
            // 
            explanationTableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            explanationTableLayoutPanel.ColumnCount = 2;
            explanationTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.1579f));
            explanationTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.8421f));
            explanationTableLayoutPanel.Controls.Add(Label10, 1, 1);
            explanationTableLayoutPanel.Controls.Add(Label9, 0, 1);
            explanationTableLayoutPanel.Controls.Add(Label11, 1, 0);
            explanationTableLayoutPanel.Controls.Add(Label12, 0, 0);
            explanationTableLayoutPanel.Location = new Point(1088, 3);
            explanationTableLayoutPanel.Name = "explanationTableLayoutPanel";
            explanationTableLayoutPanel.RowCount = 2;
            explanationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            explanationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            explanationTableLayoutPanel.Size = new Size(304, 55);
            explanationTableLayoutPanel.TabIndex = 78;
            // 
            // Label10
            // 
            Label10.BackColor = Color.White;
            Label10.Font = new Font("Microsoft Sans Serif", 7.854546f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label10.Location = new Point(40, 27);
            Label10.Margin = new Padding(0);
            Label10.Name = "Label10";
            Label10.Size = new Size(264, 16);
            Label10.TabIndex = 76;
            Label10.Text = "Container already out gated";
            Label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = Color.Transparent;
            Label9.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.Maroon;
            Label9.ImageAlign = ContentAlignment.MiddleRight;
            Label9.Location = new Point(3, 30);
            Label9.Margin = new Padding(3);
            Label9.Name = "Label9";
            Label9.Size = new Size(28, 22);
            Label9.TabIndex = 77;
            Label9.Text = "**";
            // 
            // Label11
            // 
            Label11.BackColor = Color.White;
            Label11.Font = new Font("Microsoft Sans Serif", 7.854546f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label11.Location = new Point(40, 0);
            Label11.Margin = new Padding(0);
            Label11.Name = "Label11";
            Label11.Size = new Size(226, 16);
            Label11.TabIndex = 78;
            Label11.Text = "Container not valid";
            Label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = Color.Transparent;
            Label12.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.Maroon;
            Label12.ImageAlign = ContentAlignment.MiddleRight;
            Label12.Location = new Point(3, 3);
            Label12.Margin = new Padding(3);
            Label12.Name = "Label12";
            Label12.Size = new Size(20, 21);
            Label12.TabIndex = 79;
            Label12.Text = "*";
            // 
            // problemsDataGrid
            // 
            problemsDataGrid.AllowCustomTheming = false;
            problemsDataGrid.AllowUserToAddRows = false;
            problemsDataGrid.AllowUserToDeleteRows = false;
            problemsDataGrid.AllowUserToResizeColumns = false;
            problemsDataGrid.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(223)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            DataGridViewCellStyle1.ForeColor = Color.Black;
            problemsDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            problemsDataGrid.Anchor = AnchorStyles.Top;
            problemsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            problemsDataGrid.BackgroundColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            problemsDataGrid.BorderStyle = BorderStyle.None;
            problemsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            problemsDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.Maroon;
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.Maroon;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            problemsDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            problemsDataGrid.ColumnHeadersHeight = 40;
            problemsDataGrid.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1 });
            problemsDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(223)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            problemsDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            problemsDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            problemsDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(178)), Conversions.ToInteger(Conversions.ToByte(102)), Conversions.ToInteger(Conversions.ToByte(102)));
            problemsDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            problemsDataGrid.CurrentTheme.BackColor = Color.Maroon;
            problemsDataGrid.CurrentTheme.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(216)), Conversions.ToInteger(Conversions.ToByte(178)), Conversions.ToInteger(Conversions.ToByte(178)));
            problemsDataGrid.CurrentTheme.HeaderStyle.BackColor = Color.Maroon;
            problemsDataGrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            problemsDataGrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            problemsDataGrid.CurrentTheme.Name = null;
            problemsDataGrid.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            problemsDataGrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            problemsDataGrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            problemsDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(178)), Conversions.ToInteger(Conversions.ToByte(102)), Conversions.ToInteger(Conversions.ToByte(102)));
            problemsDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(178)), Conversions.ToInteger(Conversions.ToByte(102)), Conversions.ToInteger(Conversions.ToByte(102)));
            DataGridViewCellStyle3.SelectionForeColor = Color.White;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            problemsDataGrid.DefaultCellStyle = DataGridViewCellStyle3;
            problemsDataGrid.EnableHeadersVisualStyles = false;
            problemsDataGrid.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(216)), Conversions.ToInteger(Conversions.ToByte(178)), Conversions.ToInteger(Conversions.ToByte(178)));
            problemsDataGrid.HeaderBackColor = Color.Maroon;
            problemsDataGrid.HeaderBgColor = Color.Empty;
            problemsDataGrid.HeaderForeColor = Color.White;
            problemsDataGrid.Location = new Point(1069, 161);
            problemsDataGrid.Name = "problemsDataGrid";
            problemsDataGrid.RowHeadersVisible = false;
            problemsDataGrid.RowTemplate.Height = 40;
            problemsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            problemsDataGrid.Size = new Size(249, 373);
            problemsDataGrid.TabIndex = 75;
            problemsDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.HeaderText = "Problems";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            // 
            // truckerComboBox
            // 
            truckerComboBox.Anchor = AnchorStyles.Top;
            truckerComboBox.BackColor = Color.White;
            truckerComboBox.BorderRadius = 3;
            truckerComboBox.Color = Color.Teal;
            truckerComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            truckerComboBox.DisabledColor = Color.Gray;
            truckerComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            truckerComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            truckerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            truckerComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            truckerComboBox.FillDropDown = false;
            truckerComboBox.FillIndicator = true;
            truckerComboBox.FlatStyle = FlatStyle.Flat;
            truckerComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            truckerComboBox.ForeColor = SystemColors.ControlDarkDark;
            truckerComboBox.FormattingEnabled = true;
            truckerComboBox.Icon = null;
            truckerComboBox.IndicatorColor = Color.Teal;
            truckerComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            truckerComboBox.ItemBackColor = Color.White;
            truckerComboBox.ItemBorderColor = Color.White;
            truckerComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            truckerComboBox.ItemHeight = 26;
            truckerComboBox.ItemHighLightColor = Color.Gray;
            truckerComboBox.Location = new Point(224, 101);
            truckerComboBox.MaxDropDownItems = 20;
            truckerComboBox.Name = "truckerComboBox";
            truckerComboBox.Size = new Size(465, 32);
            truckerComboBox.TabIndex = 74;
            truckerComboBox.Text = "Trucker";
            // 
            // okToTransferDataGrid
            // 
            okToTransferDataGrid.AllowCustomTheming = false;
            okToTransferDataGrid.AllowUserToAddRows = false;
            okToTransferDataGrid.AllowUserToDeleteRows = false;
            okToTransferDataGrid.AllowUserToResizeColumns = false;
            okToTransferDataGrid.AllowUserToResizeRows = false;
            DataGridViewCellStyle4.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(199)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(199)));
            DataGridViewCellStyle4.ForeColor = Color.Black;
            okToTransferDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
            okToTransferDataGrid.Anchor = AnchorStyles.Top;
            okToTransferDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            okToTransferDataGrid.BackgroundColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            okToTransferDataGrid.BorderStyle = BorderStyle.None;
            okToTransferDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            okToTransferDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.ForestGreen;
            DataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = Color.ForestGreen;
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            okToTransferDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            okToTransferDataGrid.ColumnHeadersHeight = 40;
            okToTransferDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column2 });
            okToTransferDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(199)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(199)));
            okToTransferDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            okToTransferDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            okToTransferDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(122)), Conversions.ToInteger(Conversions.ToByte(185)), Conversions.ToInteger(Conversions.ToByte(122)));
            okToTransferDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            okToTransferDataGrid.CurrentTheme.BackColor = Color.ForestGreen;
            okToTransferDataGrid.CurrentTheme.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(188)), Conversions.ToInteger(Conversions.ToByte(220)), Conversions.ToInteger(Conversions.ToByte(188)));
            okToTransferDataGrid.CurrentTheme.HeaderStyle.BackColor = Color.ForestGreen;
            okToTransferDataGrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            okToTransferDataGrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            okToTransferDataGrid.CurrentTheme.Name = null;
            okToTransferDataGrid.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(210)));
            okToTransferDataGrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            okToTransferDataGrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            okToTransferDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(122)), Conversions.ToInteger(Conversions.ToByte(185)), Conversions.ToInteger(Conversions.ToByte(122)));
            okToTransferDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(210)));
            DataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle6.ForeColor = Color.Black;
            DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(122)), Conversions.ToInteger(Conversions.ToByte(185)), Conversions.ToInteger(Conversions.ToByte(122)));
            DataGridViewCellStyle6.SelectionForeColor = Color.White;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            okToTransferDataGrid.DefaultCellStyle = DataGridViewCellStyle6;
            okToTransferDataGrid.EnableHeadersVisualStyles = false;
            okToTransferDataGrid.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(188)), Conversions.ToInteger(Conversions.ToByte(220)), Conversions.ToInteger(Conversions.ToByte(188)));
            okToTransferDataGrid.HeaderBackColor = Color.ForestGreen;
            okToTransferDataGrid.HeaderBgColor = Color.Empty;
            okToTransferDataGrid.HeaderForeColor = Color.White;
            okToTransferDataGrid.Location = new Point(827, 161);
            okToTransferDataGrid.Name = "okToTransferDataGrid";
            okToTransferDataGrid.RowHeadersVisible = false;
            okToTransferDataGrid.RowTemplate.Height = 40;
            okToTransferDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            okToTransferDataGrid.Size = new Size(249, 373);
            okToTransferDataGrid.TabIndex = 72;
            okToTransferDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.ForestGreen;
            // 
            // Column2
            // 
            Column2.HeaderText = "OK TO TRANSFER";
            Column2.Name = "Column2";
            // 
            // createTransfeRButton
            // 
            _createTransfeRButton.AllowToggling = false;
            _createTransfeRButton.Anchor = AnchorStyles.Bottom;
            _createTransfeRButton.AnimationSpeed = 200;
            _createTransfeRButton.AutoGenerateColors = false;
            _createTransfeRButton.BackColor = Color.Transparent;
            _createTransfeRButton.BackColor1 = Color.Teal;
            _createTransfeRButton.BackgroundImage = (Image)resources.GetObject("createTransfeRButton.BackgroundImage");
            _createTransfeRButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _createTransfeRButton.ButtonText = "Create Transfer";
            _createTransfeRButton.ButtonTextMarginLeft = 0;
            _createTransfeRButton.ColorContrastOnClick = 45;
            _createTransfeRButton.ColorContrastOnHover = 45;
            _createTransfeRButton.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _createTransfeRButton.CustomizableEdges = BorderEdges3;
            _createTransfeRButton.DialogResult = DialogResult.None;
            _createTransfeRButton.DisabledBorderColor = Color.Empty;
            _createTransfeRButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _createTransfeRButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _createTransfeRButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _createTransfeRButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _createTransfeRButton.ForeColor = Color.White;
            _createTransfeRButton.IconLeftCursor = Cursors.Hand;
            _createTransfeRButton.IconMarginLeft = 11;
            _createTransfeRButton.IconPadding = 10;
            _createTransfeRButton.IconRightCursor = Cursors.Hand;
            _createTransfeRButton.IdleBorderColor = Color.Teal;
            _createTransfeRButton.IdleBorderRadius = 3;
            _createTransfeRButton.IdleBorderThickness = 1;
            _createTransfeRButton.IdleFillColor = Color.Teal;
            _createTransfeRButton.IdleIconLeftImage = null;
            _createTransfeRButton.IdleIconRightImage = null;
            _createTransfeRButton.IndicateFocus = true;
            _createTransfeRButton.Location = new Point(1045, 701);
            _createTransfeRButton.Name = "_createTransfeRButton";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _createTransfeRButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Teal;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _createTransfeRButton.OnPressedState = StateProperties6;
            _createTransfeRButton.Size = new Size(150, 45);
            _createTransfeRButton.TabIndex = 68;
            _createTransfeRButton.TextAlign = ContentAlignment.MiddleCenter;
            _createTransfeRButton.TextMarginLeft = 0;
            _createTransfeRButton.UseDefaultRadiusAndThickness = true;
            // 
            // FrmCreateTransfer
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1414, 815);
            ControlBox = false;
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCreateTransfer";
            StartPosition = FormStartPosition.CenterScreen;
            TableLayoutPanel.ResumeLayout(false);
            TableLayoutPanel.PerformLayout();
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_NumericUpDown).EndInit();
            loadedInfoTableLayoutPanel.ResumeLayout(false);
            loadedInfoTableLayoutPanel.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            explanationTableLayoutPanel.ResumeLayout(false);
            explanationTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)problemsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)okToTransferDataGrid).EndInit();
            Load += new EventHandler(FrmCreateTransfer_Load);
            ResumeLayout(false);
        }

        internal TableLayoutPanel TableLayoutPanel;
        internal Label Label5;
        internal TableLayoutPanel loadedInfoTableLayoutPanel;
        internal Label Label6;
        internal Label Label8;
        internal TextBox weightTextBox;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Label Label4;
        internal Label Label2;
        internal Label Label3;
        private RichTextBox _containersRichTextBox;

        internal RichTextBox containersRichTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _containersRichTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_containersRichTextBox != null)
                {
                    _containersRichTextBox.TextChanged -= containersRichTextBox_TextChanged;
                }

                _containersRichTextBox = value;
                if (_containersRichTextBox != null)
                {
                    _containersRichTextBox.TextChanged += containersRichTextBox_TextChanged;
                }
            }
        }

        private Button _transferAnywaysButton;

        internal Button transferAnywaysButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _transferAnywaysButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_transferAnywaysButton != null)
                {
                    _transferAnywaysButton.Click -= transferAnywaysButton_Click;
                }

                _transferAnywaysButton = value;
                if (_transferAnywaysButton != null)
                {
                    _transferAnywaysButton.Click += transferAnywaysButton_Click;
                }
            }
        }

        internal Label Label1;
        internal Label Label7;
        internal Panel Panel1;
        internal Panel Panel2;
        internal Bunifu.UI.WinForms.BunifuDataGridView okToTransferDataGrid;
        internal DataGridViewTextBoxColumn Column2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _createTransfeRButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton createTransfeRButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _createTransfeRButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_createTransfeRButton != null)
                {
                    _createTransfeRButton.Click -= createTransfetTouchButton_Load;
                }

                _createTransfeRButton = value;
                if (_createTransfeRButton != null)
                {
                    _createTransfeRButton.Click += createTransfetTouchButton_Load;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuDropdown truckerComboBox;
        internal Bunifu.UI.WinForms.BunifuDropdown fromComboBox;
        internal Bunifu.UI.WinForms.BunifuDropdown toComboBox;
        internal Bunifu.UI.WinForms.BunifuDropdown sizeComboBox;
        private Bunifu.UI.WinForms.BunifuDropdown _statusComboBox;

        internal Bunifu.UI.WinForms.BunifuDropdown statusComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _statusComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_statusComboBox != null)
                {
                    _statusComboBox.SelectedIndexChanged -= statusComboBox_SelectedIndexChanged;
                }

                _statusComboBox = value;
                if (_statusComboBox != null)
                {
                    _statusComboBox.SelectedIndexChanged += statusComboBox_SelectedIndexChanged;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuDataGridView problemsDataGrid;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal TableLayoutPanel explanationTableLayoutPanel;
        internal Label Label10;
        internal Label Label9;
        internal Label Label11;
        internal Label Label12;
        internal TableLayoutPanel TableLayoutPanel2;
        private Bunifu.UI.WinForms.BunifuDropdown _dueTypeBunifuDropdown;

        internal Bunifu.UI.WinForms.BunifuDropdown dueTypeBunifuDropdown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dueTypeBunifuDropdown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dueTypeBunifuDropdown != null)
                {
                    _dueTypeBunifuDropdown.SelectedIndexChanged -= dueTypeBunifuDropdown_SelectedIndexChanged;
                }

                _dueTypeBunifuDropdown = value;
                if (_dueTypeBunifuDropdown != null)
                {
                    _dueTypeBunifuDropdown.SelectedIndexChanged += dueTypeBunifuDropdown_SelectedIndexChanged;
                }
            }
        }

        private NumericUpDown _NumericUpDown;

        internal NumericUpDown NumericUpDown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NumericUpDown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NumericUpDown != null)
                {
                    _NumericUpDown.ValueChanged -= NumericUpDown_ValueChanged;
                }

                _NumericUpDown = value;
                if (_NumericUpDown != null)
                {
                    _NumericUpDown.ValueChanged += NumericUpDown_ValueChanged;
                }
            }
        }

        internal Label dueLabel;
        internal Label Label13;
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
                    _closeLabel.Click -= Label6_Click;
                    _closeLabel.MouseHover -= closeLabel_MouseHover;
                    _closeLabel.MouseLeave -= closeLabel_Click;
                    _closeLabel.Click -= closeLabel_MouseLeave;
                }

                _closeLabel = value;
                if (_closeLabel != null)
                {
                    _closeLabel.Click += Label6_Click;
                    _closeLabel.MouseHover += closeLabel_MouseHover;
                    _closeLabel.MouseLeave += closeLabel_Click;
                    _closeLabel.Click += closeLabel_MouseLeave;
                }
            }
        }

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
                    _cancelButton.Click -= Label6_Click;
                    _cancelButton.Click -= cancelButton_Click;
                }

                _cancelButton = value;
                if (_cancelButton != null)
                {
                    _cancelButton.Click += Label6_Click;
                    _cancelButton.Click += cancelButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _checkBunifuButton1;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton checkBunifuButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkBunifuButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_checkBunifuButton1 != null)
                {
                    _checkBunifuButton1.Click -= assignBunifuButton1_Click;
                }

                _checkBunifuButton1 = value;
                if (_checkBunifuButton1 != null)
                {
                    _checkBunifuButton1.Click += assignBunifuButton1_Click;
                }
            }
        }

        internal Label titlewarningLabel;
    }
}