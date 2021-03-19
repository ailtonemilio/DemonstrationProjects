using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Microsoft.VisualBasic.CompilerServices;
using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmTimeSheet : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimeSheet));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            detailsLabel = new Label();
            timeSheetDescriptionLabel = new Label();
            titleTimeManagementLabel = new Label();
            ImageList1 = new ImageList(components);
            Label9 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Label10 = new Label();
            _PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            _PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDocument1_PrintPage);
            PrintDialog1 = new PrintDialog();
            PrintDocument2 = new System.Drawing.Printing.PrintDocument();
            Panel1 = new Panel();
            _printButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _printButton.Click += new EventHandler(printButton_Click);
            _exportCSVButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _exportCSVButton.Click += new EventHandler(Button1_Click);
            Panel2 = new Panel();
            _searchBunifuTextBox1 = new BunifuTextBox();
            _searchBunifuTextBox1.TextChanged += new EventHandler(searchBunifuTextBox1_TextChanged);
            Panel5 = new Panel();
            _detailsBunifuDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            _detailsBunifuDataGridView.RowPostPaint += new DataGridViewRowPostPaintEventHandler(detailsBunifuDataGridView1_RowPostPaint);
            _detailsBunifuDataGridView.DoubleClick += new EventHandler(detailsBunifuDataGridView_DoubleClick);
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Panel4 = new Panel();
            _selectAllCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            _selectAllCheckBox.CheckedChanged += new EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(BunifuCheckBox1_CheckedChanged);
            _summaryBunifuDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            _summaryBunifuDataGridView.SelectionChanged += new EventHandler(summaryListView_SelectedIndexChanged);
            _summaryBunifuDataGridView.RowPostPaint += new DataGridViewRowPostPaintEventHandler(BunifuDataGridView1_RowPostPaint);
            _summaryBunifuDataGridView.CellContentClick += new DataGridViewCellEventHandler(summaryBunifuDataGridView_CellContentClick);
            Column15 = new DataGridViewCheckBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Panel3 = new Panel();
            _holidaysButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _holidaysButton.Click += new EventHandler(Button1_Click_3);
            Label1 = new Label();
            TableLayoutPanel3 = new TableLayoutPanel();
            _editEntryButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _editEntryButton.Click += new EventHandler(editEntryButton_Click);
            _deleteEntryButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _deleteEntryButton.Click += new EventHandler(deleteEntryButton_Click);
            _addEntryButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _addEntryButton.Click += new EventHandler(addEntryButton_Click);
            _endPeriodComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            _endPeriodComboBox.SelectedIndexChanged += new EventHandler(endPeriodComboBox_SelectedIndexChanged);
            _monthComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            _monthComboBox.SelectedIndexChanged += new EventHandler(monthComboBox_SelectedIndexChanged);
            _payMethodComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            _payMethodComboBox.SelectedIndexChanged += new EventHandler(payMethodComboBox_SelectedIndexChanged);
            _yearComboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            _yearComboBox.SelectedIndexChanged += new EventHandler(yearComboBox_SelectedIndexChanged);
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_detailsBunifuDataGridView).BeginInit();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_summaryBunifuDataGridView).BeginInit();
            Panel3.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            BunifuShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // detailsLabel
            // 
            detailsLabel.Anchor = AnchorStyles.Top;
            detailsLabel.BackColor = Color.Transparent;
            detailsLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            detailsLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            detailsLabel.Location = new Point(708, 88);
            detailsLabel.Margin = new Padding(2, 0, 2, 0);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(690, 32);
            detailsLabel.TabIndex = 47;
            detailsLabel.Text = "Details";
            detailsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeSheetDescriptionLabel
            // 
            timeSheetDescriptionLabel.BackColor = Color.Transparent;
            timeSheetDescriptionLabel.Font = new Font("Segoe UI Semibold", 18.32727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            timeSheetDescriptionLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            timeSheetDescriptionLabel.Location = new Point(384, 9);
            timeSheetDescriptionLabel.Name = "timeSheetDescriptionLabel";
            timeSheetDescriptionLabel.Size = new Size(677, 44);
            timeSheetDescriptionLabel.TabIndex = 48;
            timeSheetDescriptionLabel.Text = "Time Sheet for period ending Jan, 01, 2019";
            timeSheetDescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleTimeManagementLabel
            // 
            titleTimeManagementLabel.Anchor = AnchorStyles.Top;
            titleTimeManagementLabel.BackColor = Color.Transparent;
            titleTimeManagementLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            titleTimeManagementLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titleTimeManagementLabel.Location = new Point(31, 52);
            titleTimeManagementLabel.Margin = new Padding(2, 0, 2, 0);
            titleTimeManagementLabel.Name = "titleTimeManagementLabel";
            titleTimeManagementLabel.Size = new Size(387, 29);
            titleTimeManagementLabel.TabIndex = 44;
            titleTimeManagementLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "pngfind.com-excel-logo-png-383338.png");
            ImageList1.Images.SetKeyName(1, "print-icon.png");
            ImageList1.Images.SetKeyName(2, "holiday.png");
            ImageList1.Images.SetKeyName(3, "editedPencil.ico");
            ImageList1.Images.SetKeyName(4, "workingComplete.ico");
            ImageList1.Images.SetKeyName(5, "workingInProgress.ico");
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label9.Location = new Point(255, 9);
            Label9.Name = "Label9";
            Label9.Size = new Size(149, 25);
            Label9.TabIndex = 54;
            Label9.Text = "Shift in progress";
            Label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ImageKey = "editedPencil.ico";
            Label5.ImageList = ImageList1;
            Label5.Location = new Point(456, 1);
            Label5.Margin = new Padding(3);
            Label5.Name = "Label5";
            Label5.Padding = new Padding(5);
            Label5.Size = new Size(31, 35);
            Label5.TabIndex = 55;
            // 
            // Label4
            // 
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ImageKey = "workingComplete.ico";
            Label4.ImageList = ImageList1;
            Label4.Location = new Point(3, 0);
            Label4.Margin = new Padding(3);
            Label4.Name = "Label4";
            Label4.Padding = new Padding(5);
            Label4.Size = new Size(35, 39);
            Label4.TabIndex = 0;
            // 
            // Label7
            // 
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ImageKey = "workingInProgress.ico";
            Label7.ImageList = ImageList1;
            Label7.Location = new Point(216, 0);
            Label7.Margin = new Padding(3);
            Label7.Name = "Label7";
            Label7.Padding = new Padding(5);
            Label7.Size = new Size(33, 39);
            Label7.TabIndex = 52;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label8.Location = new Point(44, 9);
            Label8.Name = "Label8";
            Label8.Size = new Size(144, 25);
            Label8.TabIndex = 53;
            Label8.Text = "Complete Shifts";
            Label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label10.Location = new Point(493, 10);
            Label10.Name = "Label10";
            Label10.Size = new Size(146, 25);
            Label10.TabIndex = 55;
            Label10.Text = "Modified Punch";
            Label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PrintDocument1
            // 
            // 
            // PrintDialog1
            // 
            PrintDialog1.UseEXDialog = true;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel1.Controls.Add(_printButton);
            Panel1.Controls.Add(_exportCSVButton);
            Panel1.Controls.Add(Panel2);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(10, 10);
            Panel1.Name = "Panel1";
            Panel1.Padding = new Padding(0, 40, 0, 0);
            Panel1.Size = new Size(1438, 948);
            Panel1.TabIndex = 33;
            // 
            // printButton
            // 
            _printButton.AllowToggling = false;
            _printButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _printButton.AnimationSpeed = 200;
            _printButton.AutoGenerateColors = false;
            _printButton.BackColor = Color.Transparent;
            _printButton.BackColor1 = Color.White;
            _printButton.BackgroundImage = (Image)resources.GetObject("printButton.BackgroundImage");
            _printButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _printButton.ButtonText = "Print";
            _printButton.ButtonTextMarginLeft = 15;
            _printButton.ColorContrastOnClick = 45;
            _printButton.ColorContrastOnHover = 45;
            _printButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = false;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = false;
            _printButton.CustomizableEdges = BorderEdges1;
            _printButton.DialogResult = DialogResult.None;
            _printButton.DisabledBorderColor = Color.Empty;
            _printButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _printButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _printButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _printButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _printButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _printButton.IconLeftCursor = Cursors.Hand;
            _printButton.IconMarginLeft = 11;
            _printButton.IconPadding = 10;
            _printButton.IconRightCursor = Cursors.Hand;
            _printButton.IdleBorderColor = Color.LightGray;
            _printButton.IdleBorderRadius = 38;
            _printButton.IdleBorderThickness = 1;
            _printButton.IdleFillColor = Color.White;
            _printButton.IdleIconLeftImage = (Image)resources.GetObject("printButton.IdleIconLeftImage");
            _printButton.IdleIconRightImage = null;
            _printButton.IndicateFocus = true;
            _printButton.Location = new Point(1248, 2);
            _printButton.Name = "_printButton";
            StateProperties1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties1.BorderRadius = 38;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _printButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties2.BorderRadius = 38;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _printButton.OnPressedState = StateProperties2;
            _printButton.Padding = new Padding(3, 0, 3, 0);
            _printButton.Size = new Size(95, 38);
            _printButton.TabIndex = 75;
            _printButton.TextAlign = ContentAlignment.MiddleCenter;
            _printButton.TextMarginLeft = 15;
            _printButton.UseDefaultRadiusAndThickness = true;
            // 
            // exportCSVButton
            // 
            _exportCSVButton.AllowToggling = false;
            _exportCSVButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _exportCSVButton.AnimationSpeed = 200;
            _exportCSVButton.AutoGenerateColors = false;
            _exportCSVButton.BackColor = Color.Transparent;
            _exportCSVButton.BackColor1 = Color.White;
            _exportCSVButton.BackgroundImage = (Image)resources.GetObject("exportCSVButton.BackgroundImage");
            _exportCSVButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _exportCSVButton.ButtonText = "Export";
            _exportCSVButton.ButtonTextMarginLeft = 15;
            _exportCSVButton.ColorContrastOnClick = 45;
            _exportCSVButton.ColorContrastOnHover = 45;
            _exportCSVButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = false;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = false;
            BorderEdges2.TopRight = true;
            _exportCSVButton.CustomizableEdges = BorderEdges2;
            _exportCSVButton.DialogResult = DialogResult.None;
            _exportCSVButton.DisabledBorderColor = Color.Empty;
            _exportCSVButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _exportCSVButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _exportCSVButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _exportCSVButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _exportCSVButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _exportCSVButton.IconLeftCursor = Cursors.Hand;
            _exportCSVButton.IconMarginLeft = 11;
            _exportCSVButton.IconPadding = 10;
            _exportCSVButton.IconRightCursor = Cursors.Hand;
            _exportCSVButton.IdleBorderColor = Color.LightGray;
            _exportCSVButton.IdleBorderRadius = 38;
            _exportCSVButton.IdleBorderThickness = 1;
            _exportCSVButton.IdleFillColor = Color.White;
            _exportCSVButton.IdleIconLeftImage = (Image)resources.GetObject("exportCSVButton.IdleIconLeftImage");
            _exportCSVButton.IdleIconRightImage = null;
            _exportCSVButton.IndicateFocus = true;
            _exportCSVButton.Location = new Point(1340, 2);
            _exportCSVButton.Name = "_exportCSVButton";
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties3.BorderRadius = 38;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _exportCSVButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties4.BorderRadius = 38;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _exportCSVButton.OnPressedState = StateProperties4;
            _exportCSVButton.Padding = new Padding(3, 0, 3, 0);
            _exportCSVButton.Size = new Size(95, 38);
            _exportCSVButton.TabIndex = 74;
            _exportCSVButton.TextAlign = ContentAlignment.MiddleCenter;
            _exportCSVButton.TextMarginLeft = 15;
            _exportCSVButton.UseDefaultRadiusAndThickness = true;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(_searchBunifuTextBox1);
            Panel2.Controls.Add(Panel5);
            Panel2.Controls.Add(Panel4);
            Panel2.Controls.Add(Panel3);
            Panel2.Controls.Add(_holidaysButton);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(TableLayoutPanel3);
            Panel2.Controls.Add(_addEntryButton);
            Panel2.Controls.Add(_endPeriodComboBox);
            Panel2.Controls.Add(timeSheetDescriptionLabel);
            Panel2.Controls.Add(_monthComboBox);
            Panel2.Controls.Add(_payMethodComboBox);
            Panel2.Controls.Add(_yearComboBox);
            Panel2.Controls.Add(titleTimeManagementLabel);
            Panel2.Controls.Add(detailsLabel);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(0, 40);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1438, 908);
            Panel2.TabIndex = 1;
            // 
            // searchBunifuTextBox1
            // 
            _searchBunifuTextBox1.AcceptsReturn = false;
            _searchBunifuTextBox1.AcceptsTab = false;
            _searchBunifuTextBox1.Anchor = AnchorStyles.Top;
            _searchBunifuTextBox1.AnimationSpeed = 200;
            _searchBunifuTextBox1.AutoCompleteMode = AutoCompleteMode.None;
            _searchBunifuTextBox1.AutoCompleteSource = AutoCompleteSource.None;
            _searchBunifuTextBox1.BackColor = Color.Transparent;
            _searchBunifuTextBox1.BackgroundImage = (Image)resources.GetObject("searchBunifuTextBox1.BackgroundImage");
            _searchBunifuTextBox1.BorderColorActive = Color.DodgerBlue;
            _searchBunifuTextBox1.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _searchBunifuTextBox1.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _searchBunifuTextBox1.BorderColorIdle = Color.Silver;
            _searchBunifuTextBox1.BorderRadius = 1;
            _searchBunifuTextBox1.BorderThickness = 1;
            _searchBunifuTextBox1.CharacterCasing = CharacterCasing.Normal;
            _searchBunifuTextBox1.Cursor = Cursors.IBeam;
            _searchBunifuTextBox1.DefaultFont = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _searchBunifuTextBox1.DefaultText = "";
            _searchBunifuTextBox1.FillColor = Color.White;
            _searchBunifuTextBox1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _searchBunifuTextBox1.HideSelection = true;
            _searchBunifuTextBox1.IconLeft = null;
            _searchBunifuTextBox1.IconLeftCursor = Cursors.IBeam;
            _searchBunifuTextBox1.IconPadding = 10;
            _searchBunifuTextBox1.IconRight = null;
            _searchBunifuTextBox1.IconRightCursor = Cursors.IBeam;
            _searchBunifuTextBox1.Lines = new string[0];
            _searchBunifuTextBox1.Location = new Point(33, 699);
            _searchBunifuTextBox1.MaxLength = 32767;
            _searchBunifuTextBox1.MinimumSize = new Size(100, 35);
            _searchBunifuTextBox1.Modified = false;
            _searchBunifuTextBox1.Multiline = false;
            _searchBunifuTextBox1.Name = "_searchBunifuTextBox1";
            StateProperties5.BorderColor = Color.DodgerBlue;
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnActiveState = StateProperties5;
            StateProperties6.BorderColor = Color.Empty;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Silver;
            _searchBunifuTextBox1.OnDisabledState = StateProperties6;
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Silver;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties8.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnIdleState = StateProperties8;
            _searchBunifuTextBox1.PasswordChar = '\0';
            _searchBunifuTextBox1.PlaceholderForeColor = Color.Silver;
            _searchBunifuTextBox1.PlaceholderText = "Search...";
            _searchBunifuTextBox1.ReadOnly = false;
            _searchBunifuTextBox1.ScrollBars = ScrollBars.None;
            _searchBunifuTextBox1.SelectedText = "";
            _searchBunifuTextBox1.SelectionLength = 0;
            _searchBunifuTextBox1.SelectionStart = 0;
            _searchBunifuTextBox1.ShortcutsEnabled = true;
            _searchBunifuTextBox1.Size = new Size(312, 35);
            _searchBunifuTextBox1.Style = _Style.Bunifu;
            _searchBunifuTextBox1.TabIndex = 77;
            _searchBunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            _searchBunifuTextBox1.TextMarginBottom = 0;
            _searchBunifuTextBox1.TextMarginLeft = 5;
            _searchBunifuTextBox1.TextMarginTop = 0;
            _searchBunifuTextBox1.TextPlaceholder = "Search...";
            _searchBunifuTextBox1.UseSystemPasswordChar = false;
            _searchBunifuTextBox1.WordWrap = true;
            // 
            // Panel5
            // 
            Panel5.Anchor = AnchorStyles.Top;
            Panel5.BorderStyle = BorderStyle.FixedSingle;
            Panel5.Controls.Add(_detailsBunifuDataGridView);
            Panel5.Location = new Point(712, 123);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(706, 571);
            Panel5.TabIndex = 76;
            // 
            // detailsBunifuDataGridView
            // 
            _detailsBunifuDataGridView.AllowCustomTheming = true;
            _detailsBunifuDataGridView.AllowUserToAddRows = false;
            _detailsBunifuDataGridView.AllowUserToDeleteRows = false;
            _detailsBunifuDataGridView.AllowUserToResizeColumns = false;
            _detailsBunifuDataGridView.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            _detailsBunifuDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _detailsBunifuDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _detailsBunifuDataGridView.BackgroundColor = Color.White;
            _detailsBunifuDataGridView.BorderStyle = BorderStyle.None;
            _detailsBunifuDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _detailsBunifuDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _detailsBunifuDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _detailsBunifuDataGridView.ColumnHeadersHeight = 40;
            _detailsBunifuDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column8, Column9, Column10, Column11, Column12, Column13, DataGridViewTextBoxColumn6 });
            _detailsBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _detailsBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _detailsBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _detailsBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _detailsBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _detailsBunifuDataGridView.CurrentTheme.BackColor = Color.Snow;
            _detailsBunifuDataGridView.CurrentTheme.GridColor = Color.Gray;
            _detailsBunifuDataGridView.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _detailsBunifuDataGridView.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _detailsBunifuDataGridView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _detailsBunifuDataGridView.CurrentTheme.Name = null;
            _detailsBunifuDataGridView.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _detailsBunifuDataGridView.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _detailsBunifuDataGridView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _detailsBunifuDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _detailsBunifuDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _detailsBunifuDataGridView.DefaultCellStyle = DataGridViewCellStyle3;
            _detailsBunifuDataGridView.Dock = DockStyle.Fill;
            _detailsBunifuDataGridView.EnableHeadersVisualStyles = false;
            _detailsBunifuDataGridView.GridColor = Color.Gray;
            _detailsBunifuDataGridView.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _detailsBunifuDataGridView.HeaderBgColor = Color.Empty;
            _detailsBunifuDataGridView.HeaderForeColor = Color.White;
            _detailsBunifuDataGridView.Location = new Point(0, 0);
            _detailsBunifuDataGridView.Name = "_detailsBunifuDataGridView";
            _detailsBunifuDataGridView.ReadOnly = true;
            _detailsBunifuDataGridView.RowHeadersVisible = false;
            _detailsBunifuDataGridView.RowTemplate.Height = 40;
            _detailsBunifuDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _detailsBunifuDataGridView.Size = new Size(704, 569);
            _detailsBunifuDataGridView.TabIndex = 58;
            _detailsBunifuDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column8
            // 
            Column8.HeaderText = "Date";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Clock In";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "Clock Out";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "Hours Worked";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.HeaderText = "Shift Type";
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "modifiedEntry";
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            Column13.Visible = false;
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewTextBoxColumn6.HeaderText = "punchID";
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            DataGridViewTextBoxColumn6.ReadOnly = true;
            DataGridViewTextBoxColumn6.Visible = false;
            // 
            // Panel4
            // 
            Panel4.Anchor = AnchorStyles.Top;
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(_selectAllCheckBox);
            Panel4.Controls.Add(_summaryBunifuDataGridView);
            Panel4.Location = new Point(32, 122);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(656, 571);
            Panel4.TabIndex = 75;
            // 
            // selectAllCheckBox
            // 
            _selectAllCheckBox.AllowBindingControlAnimation = true;
            _selectAllCheckBox.AllowBindingControlColorChanges = false;
            _selectAllCheckBox.AllowBindingControlLocation = true;
            _selectAllCheckBox.AllowCheckBoxAnimation = false;
            _selectAllCheckBox.AllowCheckmarkAnimation = true;
            _selectAllCheckBox.AllowOnHoverStates = true;
            _selectAllCheckBox.AutoCheck = true;
            _selectAllCheckBox.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _selectAllCheckBox.BackgroundImage = (Image)resources.GetObject("selectAllCheckBox.BackgroundImage");
            _selectAllCheckBox.BackgroundImageLayout = ImageLayout.Zoom;
            _selectAllCheckBox.BindingControl = null;
            _selectAllCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            _selectAllCheckBox.Checked = false;
            _selectAllCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            _selectAllCheckBox.Cursor = Cursors.Hand;
            _selectAllCheckBox.CustomCheckmarkImage = null;
            _selectAllCheckBox.Location = new Point(3, 8);
            _selectAllCheckBox.MinimumSize = new Size(17, 17);
            _selectAllCheckBox.Name = "_selectAllCheckBox";
            _selectAllCheckBox.OnCheck.BorderColor = Color.Teal;
            _selectAllCheckBox.OnCheck.BorderRadius = 2;
            _selectAllCheckBox.OnCheck.BorderThickness = 2;
            _selectAllCheckBox.OnCheck.CheckBoxColor = Color.Teal;
            _selectAllCheckBox.OnCheck.CheckmarkColor = Color.White;
            _selectAllCheckBox.OnCheck.CheckmarkThickness = 2;
            _selectAllCheckBox.OnDisable.BorderColor = Color.LightGray;
            _selectAllCheckBox.OnDisable.BorderRadius = 2;
            _selectAllCheckBox.OnDisable.BorderThickness = 2;
            _selectAllCheckBox.OnDisable.CheckBoxColor = Color.Transparent;
            _selectAllCheckBox.OnDisable.CheckmarkColor = Color.LightGray;
            _selectAllCheckBox.OnDisable.CheckmarkThickness = 2;
            _selectAllCheckBox.OnHoverChecked.BorderColor = Color.LightSeaGreen;
            _selectAllCheckBox.OnHoverChecked.BorderRadius = 2;
            _selectAllCheckBox.OnHoverChecked.BorderThickness = 2;
            _selectAllCheckBox.OnHoverChecked.CheckBoxColor = Color.LightSeaGreen;
            _selectAllCheckBox.OnHoverChecked.CheckmarkColor = Color.White;
            _selectAllCheckBox.OnHoverChecked.CheckmarkThickness = 2;
            _selectAllCheckBox.OnHoverUnchecked.BorderColor = Color.LightSeaGreen;
            _selectAllCheckBox.OnHoverUnchecked.BorderRadius = 2;
            _selectAllCheckBox.OnHoverUnchecked.BorderThickness = 2;
            _selectAllCheckBox.OnHoverUnchecked.CheckBoxColor = Color.Transparent;
            _selectAllCheckBox.OnUncheck.BorderColor = Color.Teal;
            _selectAllCheckBox.OnUncheck.BorderRadius = 2;
            _selectAllCheckBox.OnUncheck.BorderThickness = 2;
            _selectAllCheckBox.OnUncheck.CheckBoxColor = Color.Transparent;
            _selectAllCheckBox.Size = new Size(23, 23);
            _selectAllCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            _selectAllCheckBox.TabIndex = 77;
            _selectAllCheckBox.ThreeState = false;
            _selectAllCheckBox.ToolTipText = null;
            // 
            // summaryBunifuDataGridView
            // 
            _summaryBunifuDataGridView.AllowCustomTheming = true;
            _summaryBunifuDataGridView.AllowUserToAddRows = false;
            _summaryBunifuDataGridView.AllowUserToDeleteRows = false;
            _summaryBunifuDataGridView.AllowUserToResizeColumns = false;
            _summaryBunifuDataGridView.AllowUserToResizeRows = false;
            DataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewCellStyle4.ForeColor = Color.Black;
            DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _summaryBunifuDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
            _summaryBunifuDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _summaryBunifuDataGridView.BackgroundColor = Color.White;
            _summaryBunifuDataGridView.BorderStyle = BorderStyle.None;
            _summaryBunifuDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _summaryBunifuDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            _summaryBunifuDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            _summaryBunifuDataGridView.ColumnHeadersHeight = 40;
            _summaryBunifuDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column15, Column6, Column2, Column1, Column3, Column5, Column4, Column7, Column14 });
            _summaryBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _summaryBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _summaryBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _summaryBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _summaryBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _summaryBunifuDataGridView.CurrentTheme.BackColor = Color.Snow;
            _summaryBunifuDataGridView.CurrentTheme.GridColor = Color.Gray;
            _summaryBunifuDataGridView.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _summaryBunifuDataGridView.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _summaryBunifuDataGridView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _summaryBunifuDataGridView.CurrentTheme.Name = null;
            _summaryBunifuDataGridView.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _summaryBunifuDataGridView.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _summaryBunifuDataGridView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _summaryBunifuDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _summaryBunifuDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle7.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle7.ForeColor = Color.Black;
            DataGridViewCellStyle7.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle7.SelectionForeColor = Color.Black;
            DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            _summaryBunifuDataGridView.DefaultCellStyle = DataGridViewCellStyle7;
            _summaryBunifuDataGridView.Dock = DockStyle.Fill;
            _summaryBunifuDataGridView.EnableHeadersVisualStyles = false;
            _summaryBunifuDataGridView.GridColor = Color.Gray;
            _summaryBunifuDataGridView.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _summaryBunifuDataGridView.HeaderBgColor = Color.Empty;
            _summaryBunifuDataGridView.HeaderForeColor = Color.White;
            _summaryBunifuDataGridView.Location = new Point(0, 0);
            _summaryBunifuDataGridView.MultiSelect = false;
            _summaryBunifuDataGridView.Name = "_summaryBunifuDataGridView";
            _summaryBunifuDataGridView.ReadOnly = true;
            _summaryBunifuDataGridView.RowHeadersVisible = false;
            _summaryBunifuDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _summaryBunifuDataGridView.RowTemplate.Height = 40;
            _summaryBunifuDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _summaryBunifuDataGridView.Size = new Size(654, 569);
            _summaryBunifuDataGridView.TabIndex = 57;
            _summaryBunifuDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column15
            // 
            Column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column15.FillWeight = 68.988f;
            Column15.HeaderText = "";
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            Column15.Resizable = DataGridViewTriState.True;
            Column15.SortMode = DataGridViewColumnSortMode.Automatic;
            Column15.Width = 30;
            // 
            // Column6
            // 
            DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            Column6.DefaultCellStyle = DataGridViewCellStyle6;
            Column6.FillWeight = 96.23104f;
            Column6.HeaderText = "Alias";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.True;
            // 
            // Column2
            // 
            Column2.FillWeight = 95.74711f;
            Column2.HeaderText = "Last Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.FillWeight = 96.2751f;
            Column1.HeaderText = "First name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 95.77995f;
            Column3.HeaderText = "Hours Worked";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "status";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            // 
            // Column4
            // 
            Column4.HeaderText = "ID";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            // 
            // Column7
            // 
            Column7.HeaderText = "Punch Type";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Visible = false;
            // 
            // Column14
            // 
            Column14.HeaderText = "type";
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Visible = false;
            // 
            // Panel3
            // 
            Panel3.Anchor = AnchorStyles.Bottom;
            Panel3.Controls.Add(Label8);
            Panel3.Controls.Add(Label9);
            Panel3.Controls.Add(Label7);
            Panel3.Controls.Add(Label4);
            Panel3.Controls.Add(Label10);
            Panel3.Controls.Add(Label5);
            Panel3.Location = new Point(342, 860);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(664, 41);
            Panel3.TabIndex = 74;
            // 
            // holidaysButton
            // 
            _holidaysButton.AllowToggling = false;
            _holidaysButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _holidaysButton.AnimationSpeed = 200;
            _holidaysButton.AutoGenerateColors = false;
            _holidaysButton.BackColor = Color.Transparent;
            _holidaysButton.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _holidaysButton.BackgroundImage = (Image)resources.GetObject("holidaysButton.BackgroundImage");
            _holidaysButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _holidaysButton.ButtonText = "Holidays";
            _holidaysButton.ButtonTextMarginLeft = 0;
            _holidaysButton.ColorContrastOnClick = 45;
            _holidaysButton.ColorContrastOnHover = 45;
            _holidaysButton.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _holidaysButton.CustomizableEdges = BorderEdges3;
            _holidaysButton.DialogResult = DialogResult.None;
            _holidaysButton.DisabledBorderColor = Color.Empty;
            _holidaysButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _holidaysButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _holidaysButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _holidaysButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _holidaysButton.ForeColor = Color.White;
            _holidaysButton.IconLeftCursor = Cursors.Hand;
            _holidaysButton.IconMarginLeft = 11;
            _holidaysButton.IconPadding = 10;
            _holidaysButton.IconRightCursor = Cursors.Hand;
            _holidaysButton.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _holidaysButton.IdleBorderRadius = 40;
            _holidaysButton.IdleBorderThickness = 1;
            _holidaysButton.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _holidaysButton.IdleIconLeftImage = null;
            _holidaysButton.IdleIconRightImage = null;
            _holidaysButton.IndicateFocus = true;
            _holidaysButton.Location = new Point(1289, 856);
            _holidaysButton.Name = "_holidaysButton";
            StateProperties9.BorderColor = Color.Coral;
            StateProperties9.BorderRadius = 40;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.Coral;
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            _holidaysButton.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties10.BorderRadius = 40;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            _holidaysButton.OnPressedState = StateProperties10;
            _holidaysButton.Size = new Size(109, 45);
            _holidaysButton.TabIndex = 73;
            _holidaysButton.TextAlign = ContentAlignment.MiddleCenter;
            _holidaysButton.TextMarginLeft = 0;
            _holidaysButton.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(708, 697);
            Label1.Margin = new Padding(2, 0, 2, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(387, 29);
            Label1.TabIndex = 72;
            Label1.Text = "Double click entry to see details";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.Anchor = AnchorStyles.Top;
            TableLayoutPanel3.ColumnCount = 2;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel3.Controls.Add(_editEntryButton, 0, 0);
            TableLayoutPanel3.Controls.Add(_deleteEntryButton, 1, 0);
            TableLayoutPanel3.Location = new Point(1155, 696);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel3.Size = new Size(262, 55);
            TableLayoutPanel3.TabIndex = 71;
            // 
            // editEntryButton
            // 
            _editEntryButton.AllowToggling = false;
            _editEntryButton.AnimationSpeed = 200;
            _editEntryButton.AutoGenerateColors = false;
            _editEntryButton.BackColor = Color.Transparent;
            _editEntryButton.BackColor1 = Color.Teal;
            _editEntryButton.BackgroundImage = (Image)resources.GetObject("editEntryButton.BackgroundImage");
            _editEntryButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _editEntryButton.ButtonText = "Edit Entry";
            _editEntryButton.ButtonTextMarginLeft = 0;
            _editEntryButton.ColorContrastOnClick = 45;
            _editEntryButton.ColorContrastOnHover = 45;
            _editEntryButton.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _editEntryButton.CustomizableEdges = BorderEdges4;
            _editEntryButton.DialogResult = DialogResult.None;
            _editEntryButton.DisabledBorderColor = Color.Empty;
            _editEntryButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _editEntryButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _editEntryButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _editEntryButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _editEntryButton.ForeColor = Color.White;
            _editEntryButton.IconLeftCursor = Cursors.Hand;
            _editEntryButton.IconMarginLeft = 11;
            _editEntryButton.IconPadding = 10;
            _editEntryButton.IconRightCursor = Cursors.Hand;
            _editEntryButton.IdleBorderColor = Color.Teal;
            _editEntryButton.IdleBorderRadius = 3;
            _editEntryButton.IdleBorderThickness = 1;
            _editEntryButton.IdleFillColor = Color.Teal;
            _editEntryButton.IdleIconLeftImage = null;
            _editEntryButton.IdleIconRightImage = null;
            _editEntryButton.IndicateFocus = true;
            _editEntryButton.Location = new Point(3, 3);
            _editEntryButton.Name = "_editEntryButton";
            StateProperties11.BorderColor = Color.MediumTurquoise;
            StateProperties11.BorderRadius = 3;
            StateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties11.BorderThickness = 1;
            StateProperties11.FillColor = Color.MediumTurquoise;
            StateProperties11.ForeColor = Color.White;
            StateProperties11.IconLeftImage = null;
            StateProperties11.IconRightImage = null;
            _editEntryButton.onHoverState = StateProperties11;
            StateProperties12.BorderColor = Color.Teal;
            StateProperties12.BorderRadius = 3;
            StateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties12.BorderThickness = 1;
            StateProperties12.FillColor = Color.Teal;
            StateProperties12.ForeColor = Color.White;
            StateProperties12.IconLeftImage = null;
            StateProperties12.IconRightImage = null;
            _editEntryButton.OnPressedState = StateProperties12;
            _editEntryButton.Size = new Size(123, 45);
            _editEntryButton.TabIndex = 67;
            _editEntryButton.TextAlign = ContentAlignment.MiddleCenter;
            _editEntryButton.TextMarginLeft = 0;
            _editEntryButton.UseDefaultRadiusAndThickness = true;
            // 
            // deleteEntryButton
            // 
            _deleteEntryButton.AllowToggling = false;
            _deleteEntryButton.AnimationSpeed = 200;
            _deleteEntryButton.AutoGenerateColors = false;
            _deleteEntryButton.BackColor = Color.Transparent;
            _deleteEntryButton.BackColor1 = Color.IndianRed;
            _deleteEntryButton.BackgroundImage = (Image)resources.GetObject("deleteEntryButton.BackgroundImage");
            _deleteEntryButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _deleteEntryButton.ButtonText = "Delete Entry";
            _deleteEntryButton.ButtonTextMarginLeft = 0;
            _deleteEntryButton.ColorContrastOnClick = 45;
            _deleteEntryButton.ColorContrastOnHover = 45;
            _deleteEntryButton.Cursor = Cursors.Hand;
            BorderEdges5.BottomLeft = true;
            BorderEdges5.BottomRight = true;
            BorderEdges5.TopLeft = true;
            BorderEdges5.TopRight = true;
            _deleteEntryButton.CustomizableEdges = BorderEdges5;
            _deleteEntryButton.DialogResult = DialogResult.None;
            _deleteEntryButton.DisabledBorderColor = Color.Empty;
            _deleteEntryButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _deleteEntryButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _deleteEntryButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _deleteEntryButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _deleteEntryButton.ForeColor = Color.White;
            _deleteEntryButton.IconLeftCursor = Cursors.Hand;
            _deleteEntryButton.IconMarginLeft = 11;
            _deleteEntryButton.IconPadding = 10;
            _deleteEntryButton.IconRightCursor = Cursors.Hand;
            _deleteEntryButton.IdleBorderColor = Color.IndianRed;
            _deleteEntryButton.IdleBorderRadius = 3;
            _deleteEntryButton.IdleBorderThickness = 1;
            _deleteEntryButton.IdleFillColor = Color.IndianRed;
            _deleteEntryButton.IdleIconLeftImage = null;
            _deleteEntryButton.IdleIconRightImage = null;
            _deleteEntryButton.IndicateFocus = true;
            _deleteEntryButton.Location = new Point(134, 3);
            _deleteEntryButton.Name = "_deleteEntryButton";
            StateProperties13.BorderColor = Color.LightCoral;
            StateProperties13.BorderRadius = 3;
            StateProperties13.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties13.BorderThickness = 1;
            StateProperties13.FillColor = Color.LightCoral;
            StateProperties13.ForeColor = Color.White;
            StateProperties13.IconLeftImage = null;
            StateProperties13.IconRightImage = null;
            _deleteEntryButton.onHoverState = StateProperties13;
            StateProperties14.BorderColor = Color.IndianRed;
            StateProperties14.BorderRadius = 3;
            StateProperties14.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties14.BorderThickness = 1;
            StateProperties14.FillColor = Color.IndianRed;
            StateProperties14.ForeColor = Color.White;
            StateProperties14.IconLeftImage = null;
            StateProperties14.IconRightImage = null;
            _deleteEntryButton.OnPressedState = StateProperties14;
            _deleteEntryButton.Size = new Size(123, 45);
            _deleteEntryButton.TabIndex = 68;
            _deleteEntryButton.TextAlign = ContentAlignment.MiddleCenter;
            _deleteEntryButton.TextMarginLeft = 0;
            _deleteEntryButton.UseDefaultRadiusAndThickness = true;
            // 
            // addEntryButton
            // 
            _addEntryButton.AllowToggling = false;
            _addEntryButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _addEntryButton.AnimationSpeed = 200;
            _addEntryButton.AutoGenerateColors = false;
            _addEntryButton.BackColor = Color.Transparent;
            _addEntryButton.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _addEntryButton.BackgroundImage = (Image)resources.GetObject("addEntryButton.BackgroundImage");
            _addEntryButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _addEntryButton.ButtonText = "New Entry";
            _addEntryButton.ButtonTextMarginLeft = 0;
            _addEntryButton.ColorContrastOnClick = 45;
            _addEntryButton.ColorContrastOnHover = 45;
            _addEntryButton.Cursor = Cursors.Hand;
            BorderEdges6.BottomLeft = true;
            BorderEdges6.BottomRight = true;
            BorderEdges6.TopLeft = true;
            BorderEdges6.TopRight = true;
            _addEntryButton.CustomizableEdges = BorderEdges6;
            _addEntryButton.DialogResult = DialogResult.None;
            _addEntryButton.DisabledBorderColor = Color.Empty;
            _addEntryButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _addEntryButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _addEntryButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _addEntryButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _addEntryButton.ForeColor = Color.White;
            _addEntryButton.IconLeftCursor = Cursors.Hand;
            _addEntryButton.IconMarginLeft = 11;
            _addEntryButton.IconPadding = 10;
            _addEntryButton.IconRightCursor = Cursors.Hand;
            _addEntryButton.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _addEntryButton.IdleBorderRadius = 40;
            _addEntryButton.IdleBorderThickness = 1;
            _addEntryButton.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _addEntryButton.IdleIconLeftImage = null;
            _addEntryButton.IdleIconRightImage = null;
            _addEntryButton.IndicateFocus = true;
            _addEntryButton.Location = new Point(1289, 9);
            _addEntryButton.Name = "_addEntryButton";
            StateProperties15.BorderColor = Color.Coral;
            StateProperties15.BorderRadius = 40;
            StateProperties15.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties15.BorderThickness = 1;
            StateProperties15.FillColor = Color.Coral;
            StateProperties15.ForeColor = Color.White;
            StateProperties15.IconLeftImage = null;
            StateProperties15.IconRightImage = null;
            _addEntryButton.onHoverState = StateProperties15;
            StateProperties16.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties16.BorderRadius = 40;
            StateProperties16.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties16.BorderThickness = 1;
            StateProperties16.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties16.ForeColor = Color.White;
            StateProperties16.IconLeftImage = null;
            StateProperties16.IconRightImage = null;
            _addEntryButton.OnPressedState = StateProperties16;
            _addEntryButton.Size = new Size(109, 45);
            _addEntryButton.TabIndex = 70;
            _addEntryButton.TextAlign = ContentAlignment.MiddleCenter;
            _addEntryButton.TextMarginLeft = 0;
            _addEntryButton.UseDefaultRadiusAndThickness = true;
            // 
            // endPeriodComboBox
            // 
            _endPeriodComboBox.Anchor = AnchorStyles.Top;
            _endPeriodComboBox.BackColor = Color.White;
            _endPeriodComboBox.BorderRadius = 3;
            _endPeriodComboBox.Color = Color.Teal;
            _endPeriodComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _endPeriodComboBox.DisabledColor = Color.Gray;
            _endPeriodComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            _endPeriodComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            _endPeriodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _endPeriodComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _endPeriodComboBox.FillDropDown = false;
            _endPeriodComboBox.FillIndicator = true;
            _endPeriodComboBox.FlatStyle = FlatStyle.Flat;
            _endPeriodComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _endPeriodComboBox.ForeColor = SystemColors.ControlDarkDark;
            _endPeriodComboBox.FormattingEnabled = true;
            _endPeriodComboBox.Icon = null;
            _endPeriodComboBox.IndicatorColor = Color.Teal;
            _endPeriodComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _endPeriodComboBox.ItemBackColor = Color.White;
            _endPeriodComboBox.ItemBorderColor = Color.White;
            _endPeriodComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            _endPeriodComboBox.ItemHeight = 26;
            _endPeriodComboBox.ItemHighLightColor = Color.Gray;
            _endPeriodComboBox.Location = new Point(532, 84);
            _endPeriodComboBox.MaxDropDownItems = 20;
            _endPeriodComboBox.Name = "_endPeriodComboBox";
            _endPeriodComboBox.Size = new Size(153, 32);
            _endPeriodComboBox.TabIndex = 66;
            _endPeriodComboBox.Text = "End Period";
            // 
            // monthComboBox
            // 
            _monthComboBox.Anchor = AnchorStyles.Top;
            _monthComboBox.BackColor = Color.White;
            _monthComboBox.BorderRadius = 3;
            _monthComboBox.Color = Color.Teal;
            _monthComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _monthComboBox.DisabledColor = Color.Gray;
            _monthComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            _monthComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            _monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _monthComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _monthComboBox.FillDropDown = false;
            _monthComboBox.FillIndicator = true;
            _monthComboBox.FlatStyle = FlatStyle.Flat;
            _monthComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _monthComboBox.ForeColor = SystemColors.ControlDarkDark;
            _monthComboBox.FormattingEnabled = true;
            _monthComboBox.Icon = null;
            _monthComboBox.IndicatorColor = Color.Teal;
            _monthComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _monthComboBox.ItemBackColor = Color.White;
            _monthComboBox.ItemBorderColor = Color.White;
            _monthComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            _monthComboBox.ItemHeight = 26;
            _monthComboBox.ItemHighLightColor = Color.Gray;
            _monthComboBox.Location = new Point(379, 84);
            _monthComboBox.Name = "_monthComboBox";
            _monthComboBox.Size = new Size(147, 32);
            _monthComboBox.TabIndex = 65;
            _monthComboBox.Text = "Month";
            // 
            // payMethodComboBox
            // 
            _payMethodComboBox.Anchor = AnchorStyles.Top;
            _payMethodComboBox.BackColor = Color.White;
            _payMethodComboBox.BorderRadius = 3;
            _payMethodComboBox.Color = Color.Teal;
            _payMethodComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _payMethodComboBox.DisabledColor = Color.Gray;
            _payMethodComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            _payMethodComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            _payMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _payMethodComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _payMethodComboBox.FillDropDown = false;
            _payMethodComboBox.FillIndicator = true;
            _payMethodComboBox.FlatStyle = FlatStyle.Flat;
            _payMethodComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _payMethodComboBox.ForeColor = SystemColors.ControlDarkDark;
            _payMethodComboBox.FormattingEnabled = true;
            _payMethodComboBox.Icon = null;
            _payMethodComboBox.IndicatorColor = Color.Teal;
            _payMethodComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _payMethodComboBox.ItemBackColor = Color.White;
            _payMethodComboBox.ItemBorderColor = Color.White;
            _payMethodComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            _payMethodComboBox.ItemHeight = 26;
            _payMethodComboBox.ItemHighLightColor = Color.Gray;
            _payMethodComboBox.Items.AddRange(new object[] { "Hourly", "Salary", "Piece Work", "All" });
            _payMethodComboBox.Location = new Point(33, 84);
            _payMethodComboBox.Name = "_payMethodComboBox";
            _payMethodComboBox.Size = new Size(159, 32);
            _payMethodComboBox.TabIndex = 64;
            _payMethodComboBox.Text = "Pay Method";
            // 
            // yearComboBox
            // 
            _yearComboBox.Anchor = AnchorStyles.Top;
            _yearComboBox.BackColor = Color.White;
            _yearComboBox.BorderRadius = 3;
            _yearComboBox.Color = Color.Teal;
            _yearComboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _yearComboBox.DisabledColor = Color.Gray;
            _yearComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            _yearComboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            _yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _yearComboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _yearComboBox.FillDropDown = false;
            _yearComboBox.FillIndicator = true;
            _yearComboBox.FlatStyle = FlatStyle.Flat;
            _yearComboBox.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _yearComboBox.ForeColor = SystemColors.ControlDarkDark;
            _yearComboBox.FormattingEnabled = true;
            _yearComboBox.Icon = null;
            _yearComboBox.IndicatorColor = Color.Teal;
            _yearComboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _yearComboBox.ItemBackColor = Color.White;
            _yearComboBox.ItemBorderColor = Color.White;
            _yearComboBox.ItemForeColor = SystemColors.ControlDarkDark;
            _yearComboBox.ItemHeight = 26;
            _yearComboBox.ItemHighLightColor = Color.Gray;
            _yearComboBox.Location = new Point(247, 84);
            _yearComboBox.Name = "_yearComboBox";
            _yearComboBox.Size = new Size(115, 32);
            _yearComboBox.TabIndex = 63;
            _yearComboBox.Text = "Year";
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
            BunifuShadowPanel1.Padding = new Padding(10, 10, 5, 5);
            BunifuShadowPanel1.PanelColor = Color.Empty;
            BunifuShadowPanel1.ShadowDept = 2;
            BunifuShadowPanel1.ShadowTopLeftVisible = true;
            BunifuShadowPanel1.Size = new Size(1453, 963);
            BunifuShadowPanel1.TabIndex = 57;
            // 
            // FrmTimeSheet
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1453, 963);
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            MinimumSize = new Size(1136, 592);
            Name = "FrmTimeSheet";
            StartPosition = FormStartPosition.CenterScreen;
            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_detailsBunifuDataGridView).EndInit();
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_summaryBunifuDataGridView).EndInit();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            TableLayoutPanel3.ResumeLayout(false);
            BunifuShadowPanel1.ResumeLayout(false);
            Load += new EventHandler(FrmTimeManagement_Load);
            ResumeLayout(false);
        }

        internal Label detailsLabel;
        internal Label Label2;
        internal Label Label3;
        internal Label timeSheetDescriptionLabel;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Label titleTimeManagementLabel;
        internal ImageList ImageList1;
        internal Label Label9;
        internal Label Label4;
        internal Label Label7;
        internal Label Label8;
        internal Label Label5;
        internal Label Label10;
        internal Label Label11;
        private System.Drawing.Printing.PrintDocument _PrintDocument1;

        internal System.Drawing.Printing.PrintDocument PrintDocument1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PrintDocument1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PrintDocument1 != null)
                {
                    _PrintDocument1.PrintPage -= PrintDocument1_PrintPage;
                }

                _PrintDocument1 = value;
                if (_PrintDocument1 != null)
                {
                    _PrintDocument1.PrintPage += PrintDocument1_PrintPage;
                }
            }
        }

        internal PrintDialog PrintDialog1;
        internal System.Drawing.Printing.PrintDocument PrintDocument2;
        internal Label Label6;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuDataGridView _detailsBunifuDataGridView;

        internal Bunifu.UI.WinForms.BunifuDataGridView detailsBunifuDataGridView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _detailsBunifuDataGridView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_detailsBunifuDataGridView != null)
                {
                    _detailsBunifuDataGridView.RowPostPaint -= detailsBunifuDataGridView1_RowPostPaint;
                    _detailsBunifuDataGridView.DoubleClick -= detailsBunifuDataGridView_DoubleClick;
                }

                _detailsBunifuDataGridView = value;
                if (_detailsBunifuDataGridView != null)
                {
                    _detailsBunifuDataGridView.RowPostPaint += detailsBunifuDataGridView1_RowPostPaint;
                    _detailsBunifuDataGridView.DoubleClick += detailsBunifuDataGridView_DoubleClick;
                }
            }
        }

        internal DataGridViewTextBoxColumn Column8;
        internal DataGridViewTextBoxColumn Column9;
        internal DataGridViewTextBoxColumn Column10;
        internal DataGridViewTextBoxColumn Column11;
        internal DataGridViewTextBoxColumn Column12;
        internal DataGridViewTextBoxColumn Column13;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        private Bunifu.UI.WinForms.BunifuDropdown _monthComboBox;

        internal Bunifu.UI.WinForms.BunifuDropdown monthComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _monthComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_monthComboBox != null)
                {
                    _monthComboBox.SelectedIndexChanged -= monthComboBox_SelectedIndexChanged;
                }

                _monthComboBox = value;
                if (_monthComboBox != null)
                {
                    _monthComboBox.SelectedIndexChanged += monthComboBox_SelectedIndexChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDropdown _payMethodComboBox;

        internal Bunifu.UI.WinForms.BunifuDropdown payMethodComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _payMethodComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_payMethodComboBox != null)
                {
                    _payMethodComboBox.SelectedIndexChanged -= payMethodComboBox_SelectedIndexChanged;
                }

                _payMethodComboBox = value;
                if (_payMethodComboBox != null)
                {
                    _payMethodComboBox.SelectedIndexChanged += payMethodComboBox_SelectedIndexChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDropdown _yearComboBox;

        internal Bunifu.UI.WinForms.BunifuDropdown yearComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _yearComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_yearComboBox != null)
                {
                    _yearComboBox.SelectedIndexChanged -= yearComboBox_SelectedIndexChanged;
                }

                _yearComboBox = value;
                if (_yearComboBox != null)
                {
                    _yearComboBox.SelectedIndexChanged += yearComboBox_SelectedIndexChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDropdown _endPeriodComboBox;

        internal Bunifu.UI.WinForms.BunifuDropdown endPeriodComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _endPeriodComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_endPeriodComboBox != null)
                {
                    _endPeriodComboBox.SelectedIndexChanged -= endPeriodComboBox_SelectedIndexChanged;
                }

                _endPeriodComboBox = value;
                if (_endPeriodComboBox != null)
                {
                    _endPeriodComboBox.SelectedIndexChanged += endPeriodComboBox_SelectedIndexChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _deleteEntryButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteEntryButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _deleteEntryButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_deleteEntryButton != null)
                {
                    _deleteEntryButton.Click -= deleteEntryButton_Click;
                }

                _deleteEntryButton = value;
                if (_deleteEntryButton != null)
                {
                    _deleteEntryButton.Click += deleteEntryButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _editEntryButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton editEntryButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _editEntryButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_editEntryButton != null)
                {
                    _editEntryButton.Click -= editEntryButton_Click;
                }

                _editEntryButton = value;
                if (_editEntryButton != null)
                {
                    _editEntryButton.Click += editEntryButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _addEntryButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton addEntryButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _addEntryButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_addEntryButton != null)
                {
                    _addEntryButton.Click -= addEntryButton_Click;
                }

                _addEntryButton = value;
                if (_addEntryButton != null)
                {
                    _addEntryButton.Click += addEntryButton_Click;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _printButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton printButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _printButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_printButton != null)
                {
                    _printButton.Click -= printButton_Click;
                }

                _printButton = value;
                if (_printButton != null)
                {
                    _printButton.Click += printButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _exportCSVButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton exportCSVButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _exportCSVButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_exportCSVButton != null)
                {
                    _exportCSVButton.Click -= Button1_Click;
                }

                _exportCSVButton = value;
                if (_exportCSVButton != null)
                {
                    _exportCSVButton.Click += Button1_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _holidaysButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton holidaysButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _holidaysButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_holidaysButton != null)
                {
                    _holidaysButton.Click -= Button1_Click_3;
                }

                _holidaysButton = value;
                if (_holidaysButton != null)
                {
                    _holidaysButton.Click += Button1_Click_3;
                }
            }
        }

        internal Label Label1;
        internal Panel Panel3;
        internal Panel Panel1;
        internal Panel Panel2;
        internal Panel Panel4;
        internal Panel Panel5;
        private Bunifu.UI.WinForms.BunifuCheckBox _selectAllCheckBox;

        internal Bunifu.UI.WinForms.BunifuCheckBox selectAllCheckBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _selectAllCheckBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_selectAllCheckBox != null)
                {
                    _selectAllCheckBox.CheckedChanged -= BunifuCheckBox1_CheckedChanged;
                }

                _selectAllCheckBox = value;
                if (_selectAllCheckBox != null)
                {
                    _selectAllCheckBox.CheckedChanged += BunifuCheckBox1_CheckedChanged;
                }
            }
        }

        internal DataGridViewCheckBoxColumn Column15;
        internal DataGridViewTextBoxColumn Column6;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column7;
        internal DataGridViewTextBoxColumn Column14;
        private Bunifu.UI.WinForms.BunifuDataGridView _summaryBunifuDataGridView;

        public Bunifu.UI.WinForms.BunifuDataGridView summaryBunifuDataGridView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _summaryBunifuDataGridView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_summaryBunifuDataGridView != null)
                {
                    _summaryBunifuDataGridView.SelectionChanged -= summaryListView_SelectedIndexChanged;
                    _summaryBunifuDataGridView.RowPostPaint -= BunifuDataGridView1_RowPostPaint;
                    _summaryBunifuDataGridView.CellContentClick -= summaryBunifuDataGridView_CellContentClick;
                }

                _summaryBunifuDataGridView = value;
                if (_summaryBunifuDataGridView != null)
                {
                    _summaryBunifuDataGridView.SelectionChanged += summaryListView_SelectedIndexChanged;
                    _summaryBunifuDataGridView.RowPostPaint += BunifuDataGridView1_RowPostPaint;
                    _summaryBunifuDataGridView.CellContentClick += summaryBunifuDataGridView_CellContentClick;
                }
            }
        }

        private BunifuTextBox _searchBunifuTextBox1;

        internal BunifuTextBox searchBunifuTextBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _searchBunifuTextBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_searchBunifuTextBox1 != null)
                {
                    _searchBunifuTextBox1.TextChanged -= searchBunifuTextBox1_TextChanged;
                }

                _searchBunifuTextBox1 = value;
                if (_searchBunifuTextBox1 != null)
                {
                    _searchBunifuTextBox1.TextChanged += searchBunifuTextBox1_TextChanged;
                }
            }
        }
    }
}