using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmCFIALabel : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCFIALabel));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var ToggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState4 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState5 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState6 = new Bunifu.ToggleSwitch.ToggleState();
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
            var BorderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            ImageList1 = new ImageList(components);
            _PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            _PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printdocument1_printpage);
            PrintDialog1 = new PrintDialog();
            BunifuShadowPanel2 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            labelsTabControl = new Dotnetrix.Controls.TabControlEX();
            TabPageEX1 = new Dotnetrix.Controls.TabPageEX();
            Panel1 = new Panel();
            Label6 = new Label();
            tbCustomer = new TextBox();
            PictureBox1 = new PictureBox();
            warningLabel = new Label();
            typeUnitPanel = new Panel();
            commodityTextBox = new TextBox();
            Label14 = new Label();
            _unitNumberTextBox = new TextBox();
            _unitNumberTextBox.TextChanged += new EventHandler(unitNumberTextBox_TextChanged);
            Label3 = new Label();
            gradeAndComodityLabe = new Label();
            _sampletitlecombobox = new Bunifu.UI.WinForms.BunifuDropdown();
            _sampletitlecombobox.SelectedIndexChanged += new EventHandler(sampletitlecombobox_selectedindexchanged);
            Label2 = new Label();
            customerLabel = new Label();
            todatetimepicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            Label15 = new Label();
            bookingIDLabel = new Label();
            Label4 = new Label();
            _cboBooking = new ComboBox();
            _cboBooking.SelectedIndexChanged += new EventHandler(bookingsnumbcombobox_SelectedIndexChanged);
            fromdatetimepicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            selectUnitPanel = new Panel();
            _selectAllCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            _selectAllCheckBox.CheckedChanged += new EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(checkbox2_checkedchanged);
            _selectAllCheckBox.CheckedChanged += new EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(checkbox2_checkedchanged);
            _dgvUnits = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvUnits.SelectionChanged += new EventHandler(unitslistview_SelectionChanged);
            _dgvUnits.CellContentClick += new DataGridViewCellEventHandler(unitiesBunifuDataGridView_CellContentClick);
            _dgvUnits.DoubleClick += new EventHandler(dgvUnits_DoubleClick);
            VWMinibookingMiniUnitAssignmentBindingSource = new BindingSource(components);
            TableLayoutPanel4 = new TableLayoutPanel();
            _tgActiveBooking = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            _tgActiveBooking.OnValuechange += new EventHandler(tgActiveBooking_OnValuechange);
            Label1 = new Label();
            _BunifuToggleSwitch1 = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            _BunifuToggleSwitch1.OnValuechange += new EventHandler(bunifutoggleswitch1_onvaluechange);
            Label5 = new Label();
            _printButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _printButton.Click += new EventHandler(button1_click);
            certificationsTabPage = new Dotnetrix.Controls.TabPageEX();
            _pasteBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _pasteBunifuButton.Click += new EventHandler(BunifuButton1_Click);
            _addBttn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _addBttn.Click += new EventHandler(addBttn_Click);
            _printLabelsBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _printLabelsBunifuButton.Click += new EventHandler(printLabelsBunifuButton_Click);
            mainLabelPanel = new FlowLayoutPanel();
            labelPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            _RichTextBox1 = new RichTextBox();

            _RichTextBox1.KeyDown += new KeyEventHandler(RichTextBox1_KeyDown);
            _RichTextBox1.GotFocus += new EventHandler(RichTextBox1_GotFocus);
            labelPanel2 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            _deleteBunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _deleteBunifuButton1.Click += new EventHandler(deleteBunifuButton1_Click);
            _RichTextBox2 = new RichTextBox();
            _RichTextBox2.GotFocus += new EventHandler(RichTextBox2_GotFocus);
            labelPanel3 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            _deleteBunifuButto2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _deleteBunifuButto2.Click += new EventHandler(deleteBunifuButto2_Click);
            _RichTextBox3 = new RichTextBox();
            _RichTextBox3.GotFocus += new EventHandler(RichTextBox3_GotFocus);
            labelPanel4 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            _FlowLayoutPanel1 = new FlowLayoutPanel();
            _FlowLayoutPanel1.Paint += new PaintEventHandler(FlowLayoutPanel1_Paint);
            _deleteBunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _deleteBunifuButton3.Click += new EventHandler(deleteBunifuButton3_Click);
            _RichTextBox4 = new RichTextBox();
            _RichTextBox4.GotFocus += new EventHandler(RichTextBox4_GotFocus);
            PrintDialog2 = new PrintDialog();
            _PrintDocument2 = new System.Drawing.Printing.PrintDocument();
            _PrintDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDocument2_PrintPage);
            VWCompanyCompanyTypeBindingSource = new BindingSource(components);
            Column2 = new DataGridViewCheckBoxColumn();
            MiniUnitNumber = new DataGridViewTextBoxColumn();
            BunifuShadowPanel2.SuspendLayout();
            labelsTabControl.SuspendLayout();
            TabPageEX1.SuspendLayout();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            typeUnitPanel.SuspendLayout();
            selectUnitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWMinibookingMiniUnitAssignmentBindingSource).BeginInit();
            TableLayoutPanel4.SuspendLayout();
            certificationsTabPage.SuspendLayout();
            mainLabelPanel.SuspendLayout();
            labelPanel1.SuspendLayout();
            labelPanel2.SuspendLayout();
            labelPanel3.SuspendLayout();
            labelPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VWCompanyCompanyTypeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "print-icon.png");
            // 
            // PrintDocument1
            // 
            // 
            // PrintDialog1
            // 
            PrintDialog1.UseEXDialog = true;
            // 
            // BunifuShadowPanel2
            // 
            BunifuShadowPanel2.BackColor = Color.White;
            BunifuShadowPanel2.BorderColor = Color.Transparent;
            BunifuShadowPanel2.Controls.Add(labelsTabControl);
            BunifuShadowPanel2.Dock = DockStyle.Fill;
            BunifuShadowPanel2.ForeColor = Color.White;
            BunifuShadowPanel2.Location = new Point(0, 0);
            BunifuShadowPanel2.Margin = new Padding(0);
            BunifuShadowPanel2.Name = "BunifuShadowPanel2";
            BunifuShadowPanel2.Padding = new Padding(10, 10, 5, 5);
            BunifuShadowPanel2.PanelColor = Color.Empty;
            BunifuShadowPanel2.ShadowDept = 2;
            BunifuShadowPanel2.ShadowTopLeftVisible = true;
            BunifuShadowPanel2.Size = new Size(1476, 1039);
            BunifuShadowPanel2.TabIndex = 76;
            // 
            // labelsTabControl
            // 
            labelsTabControl.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatTab;
            labelsTabControl.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            labelsTabControl.Controls.Add(TabPageEX1);
            labelsTabControl.Controls.Add(certificationsTabPage);
            labelsTabControl.Dock = DockStyle.Fill;
            labelsTabControl.FlatBorderColor = Color.Gray;
            labelsTabControl.Font = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            labelsTabControl.ForeColor = Color.White;
            labelsTabControl.Location = new Point(10, 10);
            labelsTabControl.Name = "labelsTabControl";
            labelsTabControl.Padding = new Point(20, 8);
            labelsTabControl.SelectedIndex = 0;
            labelsTabControl.SelectedTabColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            labelsTabControl.Size = new Size(1461, 1024);
            labelsTabControl.TabColor = SystemColors.ControlDarkDark;
            labelsTabControl.TabIndex = 2;
            labelsTabControl.UseVisualStyles = false;
            // 
            // TabPageEX1
            // 
            TabPageEX1.BackColor = Color.White;
            TabPageEX1.Controls.Add(Panel1);
            TabPageEX1.Controls.Add(TableLayoutPanel4);
            TabPageEX1.Controls.Add(_printButton);
            TabPageEX1.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TabPageEX1.Location = new Point(4, 35);
            TabPageEX1.Name = "TabPageEX1";
            TabPageEX1.Size = new Size(1453, 985);
            TabPageEX1.TabIndex = 0;
            TabPageEX1.Text = "General Labels";
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.None;
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(Label6);
            Panel1.Controls.Add(tbCustomer);
            Panel1.Controls.Add(PictureBox1);
            Panel1.Controls.Add(warningLabel);
            Panel1.Controls.Add(typeUnitPanel);
            Panel1.Controls.Add(gradeAndComodityLabe);
            Panel1.Controls.Add(_sampletitlecombobox);
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(customerLabel);
            Panel1.Controls.Add(todatetimepicker);
            Panel1.Controls.Add(Label15);
            Panel1.Controls.Add(bookingIDLabel);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(_cboBooking);
            Panel1.Controls.Add(fromdatetimepicker);
            Panel1.Controls.Add(selectUnitPanel);
            Panel1.Location = new Point(153, 112);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1136, 617);
            Panel1.TabIndex = 91;
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.Top;
            Label6.Font = new Font("Segoe UI", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(215, 591);
            Label6.Name = "Label6";
            Label6.Size = new Size(195, 24);
            Label6.TabIndex = 92;
            Label6.Text = "* Double click unit to edit";
            Label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbCustomer
            // 
            tbCustomer.CharacterCasing = CharacterCasing.Upper;
            tbCustomer.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            tbCustomer.Location = new Point(220, 213);
            tbCustomer.Name = "tbCustomer";
            tbCustomer.Size = new Size(328, 31);
            tbCustomer.TabIndex = 91;
            // 
            // PictureBox1
            // 
            PictureBox1.Anchor = AnchorStyles.Top;
            PictureBox1.BackgroundImage = My.Resources.Resources.wtc;
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Location = new Point(100, 20);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(205, 112);
            PictureBox1.TabIndex = 77;
            PictureBox1.TabStop = false;
            // 
            // warningLabel
            // 
            warningLabel.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            warningLabel.ForeColor = Color.Firebrick;
            warningLabel.Location = new Point(354, 20);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(592, 23);
            warningLabel.TabIndex = 90;
            // 
            // typeUnitPanel
            // 
            typeUnitPanel.Anchor = AnchorStyles.Top;
            typeUnitPanel.Controls.Add(commodityTextBox);
            typeUnitPanel.Controls.Add(Label14);
            typeUnitPanel.Controls.Add(_unitNumberTextBox);
            typeUnitPanel.Controls.Add(Label3);
            typeUnitPanel.Location = new Point(24, 250);
            typeUnitPanel.Name = "typeUnitPanel";
            typeUnitPanel.Size = new Size(551, 113);
            typeUnitPanel.TabIndex = 82;
            typeUnitPanel.Visible = false;
            // 
            // commodityTextBox
            // 
            commodityTextBox.CharacterCasing = CharacterCasing.Upper;
            commodityTextBox.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            commodityTextBox.Location = new Point(198, 53);
            commodityTextBox.Name = "commodityTextBox";
            commodityTextBox.Size = new Size(295, 31);
            commodityTextBox.TabIndex = 26;
            // 
            // Label14
            // 
            Label14.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label14.Location = new Point(3, 54);
            Label14.Name = "Label14";
            Label14.Size = new Size(191, 32);
            Label14.TabIndex = 25;
            Label14.Text = "Commodity:";
            Label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // unitNumberTextBox
            // 
            _unitNumberTextBox.CharacterCasing = CharacterCasing.Upper;
            _unitNumberTextBox.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _unitNumberTextBox.Location = new Point(198, 7);
            _unitNumberTextBox.Name = "_unitNumberTextBox";
            _unitNumberTextBox.Size = new Size(295, 31);
            _unitNumberTextBox.TabIndex = 2;
            // 
            // Label3
            // 
            Label3.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(1, 8);
            Label3.Name = "Label3";
            Label3.Size = new Size(193, 32);
            Label3.TabIndex = 1;
            Label3.Text = "Unit #:";
            Label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gradeAndComodityLabe
            // 
            gradeAndComodityLabe.Anchor = AnchorStyles.Top;
            gradeAndComodityLabe.BorderStyle = BorderStyle.FixedSingle;
            gradeAndComodityLabe.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            gradeAndComodityLabe.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            gradeAndComodityLabe.Location = new Point(782, 271);
            gradeAndComodityLabe.Name = "gradeAndComodityLabe";
            gradeAndComodityLabe.Size = new Size(283, 228);
            gradeAndComodityLabe.TabIndex = 89;
            // 
            // sampletitlecombobox
            // 
            _sampletitlecombobox.Anchor = AnchorStyles.Top;
            _sampletitlecombobox.BackColor = Color.White;
            _sampletitlecombobox.BorderRadius = 3;
            _sampletitlecombobox.Color = Color.Teal;
            _sampletitlecombobox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _sampletitlecombobox.DisabledColor = Color.Gray;
            _sampletitlecombobox.DrawMode = DrawMode.OwnerDrawFixed;
            _sampletitlecombobox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            _sampletitlecombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            _sampletitlecombobox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _sampletitlecombobox.FillDropDown = false;
            _sampletitlecombobox.FillIndicator = true;
            _sampletitlecombobox.FlatStyle = FlatStyle.Flat;
            _sampletitlecombobox.Font = new Font("Segoe UI Semibold", 15.70909f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _sampletitlecombobox.ForeColor = SystemColors.ControlDarkDark;
            _sampletitlecombobox.FormattingEnabled = true;
            _sampletitlecombobox.Icon = null;
            _sampletitlecombobox.IndicatorColor = Color.Teal;
            _sampletitlecombobox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _sampletitlecombobox.ItemBackColor = Color.White;
            _sampletitlecombobox.ItemBorderColor = Color.White;
            _sampletitlecombobox.ItemForeColor = SystemColors.ControlDarkDark;
            _sampletitlecombobox.ItemHeight = 40;
            _sampletitlecombobox.ItemHighLightColor = Color.Gray;
            _sampletitlecombobox.Items.AddRange(new object[] { "CFIA SAMPLE", "CUSTOMER SAMPLE", "RETAINED SAMPLE", "SUBMITTED SAMPLE" });
            _sampletitlecombobox.Location = new Point(354, 66);
            _sampletitlecombobox.MaxDropDownItems = 20;
            _sampletitlecombobox.Name = "_sampletitlecombobox";
            _sampletitlecombobox.Size = new Size(592, 46);
            _sampletitlecombobox.TabIndex = 73;
            _sampletitlecombobox.Text = "Sample Title";
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top;
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(644, 272);
            Label2.Name = "Label2";
            Label2.Size = new Size(113, 25);
            Label2.TabIndex = 88;
            Label2.Text = "Commodity:";
            // 
            // customerLabel
            // 
            customerLabel.Anchor = AnchorStyles.Top;
            customerLabel.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            customerLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            customerLabel.Location = new Point(19, 211);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(195, 32);
            customerLabel.TabIndex = 76;
            customerLabel.Text = "Customer:";
            customerLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // todatetimepicker
            // 
            todatetimepicker.Anchor = AnchorStyles.Top;
            todatetimepicker.BorderRadius = 3;
            todatetimepicker.Color = Color.Teal;
            todatetimepicker.CustomFormat = "MMM dd, yyyy";
            todatetimepicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            todatetimepicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            todatetimepicker.DisabledColor = Color.Gray;
            todatetimepicker.DisplayWeekNumbers = false;
            todatetimepicker.DPHeight = 0;
            todatetimepicker.DropDownAlign = LeftRightAlignment.Right;
            todatetimepicker.FillDatePicker = false;
            todatetimepicker.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            todatetimepicker.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            todatetimepicker.Format = DateTimePickerFormat.Custom;
            todatetimepicker.Icon = (Image)resources.GetObject("todatetimepicker.Icon");
            todatetimepicker.IconColor = Color.Teal;
            todatetimepicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            todatetimepicker.Location = new Point(782, 209);
            todatetimepicker.MinimumSize = new Size(277, 35);
            todatetimepicker.Name = "todatetimepicker";
            todatetimepicker.Size = new Size(277, 35);
            todatetimepicker.TabIndex = 87;
            // 
            // Label15
            // 
            Label15.Anchor = AnchorStyles.Top;
            Label15.AutoSize = true;
            Label15.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.Location = new Point(735, 214);
            Label15.Name = "Label15";
            Label15.Size = new Size(35, 25);
            Label15.TabIndex = 86;
            Label15.Text = "To:";
            // 
            // bookingIDLabel
            // 
            bookingIDLabel.Anchor = AnchorStyles.Top;
            bookingIDLabel.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            bookingIDLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            bookingIDLabel.Location = new Point(25, 178);
            bookingIDLabel.Name = "bookingIDLabel";
            bookingIDLabel.Size = new Size(195, 32);
            bookingIDLabel.TabIndex = 75;
            bookingIDLabel.Text = "Booking #:";
            bookingIDLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Top;
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(707, 166);
            Label4.Name = "Label4";
            Label4.Size = new Size(59, 25);
            Label4.TabIndex = 85;
            Label4.Text = "From:";
            // 
            // cboBooking
            // 
            _cboBooking.Anchor = AnchorStyles.Top;
            _cboBooking.AutoCompleteMode = AutoCompleteMode.Append;
            _cboBooking.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboBooking.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboBooking.FormattingEnabled = true;
            _cboBooking.Location = new Point(221, 178);
            _cboBooking.Name = "_cboBooking";
            _cboBooking.Size = new Size(328, 30);
            _cboBooking.TabIndex = 15;
            // 
            // fromdatetimepicker
            // 
            fromdatetimepicker.Anchor = AnchorStyles.Top;
            fromdatetimepicker.BorderRadius = 3;
            fromdatetimepicker.Color = Color.Teal;
            fromdatetimepicker.CustomFormat = "MMM dd, yyyy";
            fromdatetimepicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            fromdatetimepicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            fromdatetimepicker.DisabledColor = Color.Gray;
            fromdatetimepicker.DisplayWeekNumbers = false;
            fromdatetimepicker.DPHeight = 0;
            fromdatetimepicker.DropDownAlign = LeftRightAlignment.Right;
            fromdatetimepicker.FillDatePicker = false;
            fromdatetimepicker.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            fromdatetimepicker.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            fromdatetimepicker.Format = DateTimePickerFormat.Custom;
            fromdatetimepicker.Icon = (Image)resources.GetObject("fromdatetimepicker.Icon");
            fromdatetimepicker.IconColor = Color.Teal;
            fromdatetimepicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            fromdatetimepicker.Location = new Point(782, 162);
            fromdatetimepicker.MinimumSize = new Size(277, 35);
            fromdatetimepicker.Name = "fromdatetimepicker";
            fromdatetimepicker.Size = new Size(277, 35);
            fromdatetimepicker.TabIndex = 84;
            // 
            // selectUnitPanel
            // 
            selectUnitPanel.Anchor = AnchorStyles.Top;
            selectUnitPanel.BorderStyle = BorderStyle.FixedSingle;
            selectUnitPanel.Controls.Add(_selectAllCheckBox);
            selectUnitPanel.Controls.Add(_dgvUnits);
            selectUnitPanel.Location = new Point(220, 262);
            selectUnitPanel.Name = "selectUnitPanel";
            selectUnitPanel.Size = new Size(325, 326);
            selectUnitPanel.TabIndex = 83;
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
            _selectAllCheckBox.Location = new Point(3, 9);
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
            _selectAllCheckBox.TabIndex = 78;
            _selectAllCheckBox.ThreeState = false;
            _selectAllCheckBox.ToolTipText = null;
            // 
            // dgvUnits
            // 
            _dgvUnits.AllowCustomTheming = true;
            _dgvUnits.AllowUserToAddRows = false;
            _dgvUnits.AllowUserToDeleteRows = false;
            _dgvUnits.AllowUserToResizeColumns = false;
            _dgvUnits.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvUnits.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvUnits.AutoGenerateColumns = false;
            _dgvUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvUnits.BackgroundColor = Color.White;
            _dgvUnits.BorderStyle = BorderStyle.None;
            _dgvUnits.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvUnits.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvUnits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvUnits.ColumnHeadersHeight = 40;
            _dgvUnits.Columns.AddRange(new DataGridViewColumn[] { Column2, MiniUnitNumber });
            _dgvUnits.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvUnits.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvUnits.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvUnits.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvUnits.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvUnits.CurrentTheme.BackColor = Color.Snow;
            _dgvUnits.CurrentTheme.GridColor = Color.Gray;
            _dgvUnits.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvUnits.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvUnits.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvUnits.CurrentTheme.Name = null;
            _dgvUnits.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvUnits.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvUnits.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvUnits.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvUnits.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvUnits.DataSource = VWMinibookingMiniUnitAssignmentBindingSource;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvUnits.DefaultCellStyle = DataGridViewCellStyle3;
            _dgvUnits.Dock = DockStyle.Fill;
            _dgvUnits.EnableHeadersVisualStyles = false;
            _dgvUnits.GridColor = Color.Gray;
            _dgvUnits.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvUnits.HeaderBgColor = Color.Empty;
            _dgvUnits.HeaderForeColor = Color.White;
            _dgvUnits.Location = new Point(0, 0);
            _dgvUnits.Name = "_dgvUnits";
            _dgvUnits.ReadOnly = true;
            _dgvUnits.RowHeadersVisible = false;
            _dgvUnits.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvUnits.RowTemplate.Height = 40;
            _dgvUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvUnits.Size = new Size(323, 324);
            _dgvUnits.TabIndex = 78;
            _dgvUnits.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // VWMinibookingMiniUnitAssignmentBindingSource
            // 
            VWMinibookingMiniUnitAssignmentBindingSource.DataSource = typeof(ModelLayer.VW_MinibookingMiniUnitAssignment);
            // 
            // TableLayoutPanel4
            // 
            TableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel4.ColumnCount = 2;
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.38461f));
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.61539f));
            TableLayoutPanel4.Controls.Add(_tgActiveBooking, 1, 1);
            TableLayoutPanel4.Controls.Add(Label1, 0, 0);
            TableLayoutPanel4.Controls.Add(_BunifuToggleSwitch1, 1, 0);
            TableLayoutPanel4.Controls.Add(Label5, 0, 1);
            TableLayoutPanel4.Location = new Point(1192, 3);
            TableLayoutPanel4.Margin = new Padding(0);
            TableLayoutPanel4.Name = "TableLayoutPanel4";
            TableLayoutPanel4.RowCount = 2;
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel4.Size = new Size(261, 62);
            TableLayoutPanel4.TabIndex = 91;
            // 
            // tgActiveBooking
            // 
            _tgActiveBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _tgActiveBooking.Animation = 5;
            _tgActiveBooking.BackColor = Color.Transparent;
            _tgActiveBooking.BackgroundImage = (Image)resources.GetObject("tgActiveBooking.BackgroundImage");
            _tgActiveBooking.Cursor = Cursors.Hand;
            _tgActiveBooking.Location = new Point(212, 34);
            _tgActiveBooking.Name = "_tgActiveBooking";
            _tgActiveBooking.Size = new Size(45, 24);
            _tgActiveBooking.TabIndex = 92;
            ToggleState1.BackColor = Color.Empty;
            ToggleState1.BackColorInner = Color.Empty;
            ToggleState1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(236)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(140)));
            ToggleState1.BorderColorInner = Color.Empty;
            ToggleState1.BorderRadius = 1;
            ToggleState1.BorderRadiusInner = 1;
            ToggleState1.BorderThickness = 1;
            ToggleState1.BorderThicknessInner = 1;
            _tgActiveBooking.ToggleStateDisabled = ToggleState1;
            ToggleState2.BackColor = Color.Gray;
            ToggleState2.BackColorInner = Color.White;
            ToggleState2.BorderColor = Color.Gray;
            ToggleState2.BorderColorInner = Color.White;
            ToggleState2.BorderRadius = 17;
            ToggleState2.BorderRadiusInner = 15;
            ToggleState2.BorderThickness = 1;
            ToggleState2.BorderThicknessInner = 1;
            _tgActiveBooking.ToggleStateOff = ToggleState2;
            ToggleState3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState3.BackColorInner = Color.White;
            ToggleState3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState3.BorderColorInner = Color.White;
            ToggleState3.BorderRadius = 17;
            ToggleState3.BorderRadiusInner = 15;
            ToggleState3.BorderThickness = 1;
            ToggleState3.BorderThicknessInner = 1;
            _tgActiveBooking.ToggleStateOn = ToggleState3;
            _tgActiveBooking.Value = true;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(65, 1);
            Label1.Name = "Label1";
            Label1.Size = new Size(140, 29);
            Label1.TabIndex = 79;
            Label1.Text = "Manual entry";
            Label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BunifuToggleSwitch1
            // 
            _BunifuToggleSwitch1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _BunifuToggleSwitch1.Animation = 5;
            _BunifuToggleSwitch1.BackColor = Color.Transparent;
            _BunifuToggleSwitch1.BackgroundImage = (Image)resources.GetObject("BunifuToggleSwitch1.BackgroundImage");
            _BunifuToggleSwitch1.Cursor = Cursors.Hand;
            _BunifuToggleSwitch1.Location = new Point(212, 4);
            _BunifuToggleSwitch1.Name = "_BunifuToggleSwitch1";
            _BunifuToggleSwitch1.Size = new Size(45, 23);
            _BunifuToggleSwitch1.TabIndex = 78;
            ToggleState4.BackColor = Color.Empty;
            ToggleState4.BackColorInner = Color.Empty;
            ToggleState4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(236)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(140)));
            ToggleState4.BorderColorInner = Color.Empty;
            ToggleState4.BorderRadius = 1;
            ToggleState4.BorderRadiusInner = 1;
            ToggleState4.BorderThickness = 1;
            ToggleState4.BorderThicknessInner = 1;
            _BunifuToggleSwitch1.ToggleStateDisabled = ToggleState4;
            ToggleState5.BackColor = Color.Gray;
            ToggleState5.BackColorInner = Color.White;
            ToggleState5.BorderColor = Color.Gray;
            ToggleState5.BorderColorInner = Color.White;
            ToggleState5.BorderRadius = 17;
            ToggleState5.BorderRadiusInner = 15;
            ToggleState5.BorderThickness = 1;
            ToggleState5.BorderThicknessInner = 1;
            _BunifuToggleSwitch1.ToggleStateOff = ToggleState5;
            ToggleState6.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState6.BackColorInner = Color.White;
            ToggleState6.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState6.BorderColorInner = Color.White;
            ToggleState6.BorderRadius = 17;
            ToggleState6.BorderRadiusInner = 15;
            ToggleState6.BorderThickness = 1;
            ToggleState6.BorderThicknessInner = 1;
            _BunifuToggleSwitch1.ToggleStateOn = ToggleState6;
            _BunifuToggleSwitch1.Value = false;
            // 
            // Label5
            // 
            Label5.Dock = DockStyle.Fill;
            Label5.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label5.Location = new Point(1, 31);
            Label5.Margin = new Padding(0);
            Label5.Name = "Label5";
            Label5.Size = new Size(207, 30);
            Label5.TabIndex = 84;
            Label5.Text = "Active Booking:";
            Label5.TextAlign = ContentAlignment.TopRight;
            // 
            // printButton
            // 
            _printButton.AllowToggling = false;
            _printButton.Anchor = AnchorStyles.Bottom;
            _printButton.AnimationSpeed = 200;
            _printButton.AutoGenerateColors = false;
            _printButton.BackColor = Color.Transparent;
            _printButton.BackColor1 = Color.Teal;
            _printButton.BackgroundImage = (Image)resources.GetObject("printButton.BackgroundImage");
            _printButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _printButton.ButtonText = "Print";
            _printButton.ButtonTextMarginLeft = 0;
            _printButton.ColorContrastOnClick = 45;
            _printButton.ColorContrastOnHover = 45;
            _printButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _printButton.CustomizableEdges = BorderEdges1;
            _printButton.DialogResult = DialogResult.None;
            _printButton.DisabledBorderColor = Color.Empty;
            _printButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _printButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _printButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _printButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _printButton.ForeColor = Color.White;
            _printButton.IconLeftCursor = Cursors.Hand;
            _printButton.IconMarginLeft = 11;
            _printButton.IconPadding = 10;
            _printButton.IconRightCursor = Cursors.Hand;
            _printButton.IdleBorderColor = Color.Teal;
            _printButton.IdleBorderRadius = 3;
            _printButton.IdleBorderThickness = 1;
            _printButton.IdleFillColor = Color.Teal;
            _printButton.IdleIconLeftImage = null;
            _printButton.IdleIconRightImage = null;
            _printButton.IndicateFocus = true;
            _printButton.Location = new Point(682, 792);
            _printButton.Name = "_printButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _printButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _printButton.OnPressedState = StateProperties2;
            _printButton.Size = new Size(177, 45);
            _printButton.TabIndex = 68;
            _printButton.TextAlign = ContentAlignment.MiddleCenter;
            _printButton.TextMarginLeft = 0;
            _printButton.UseDefaultRadiusAndThickness = true;
            // 
            // certificationsTabPage
            // 
            certificationsTabPage.BackColor = Color.White;
            certificationsTabPage.Controls.Add(_pasteBunifuButton);
            certificationsTabPage.Controls.Add(_addBttn);
            certificationsTabPage.Controls.Add(_printLabelsBunifuButton);
            certificationsTabPage.Controls.Add(mainLabelPanel);
            certificationsTabPage.Location = new Point(4, 35);
            certificationsTabPage.Name = "certificationsTabPage";
            certificationsTabPage.Size = new Size(1453, 985);
            certificationsTabPage.TabIndex = 1;
            certificationsTabPage.Text = "Cargo Labels";
            // 
            // pasteBunifuButton
            // 
            _pasteBunifuButton.AllowToggling = false;
            _pasteBunifuButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _pasteBunifuButton.AnimationSpeed = 200;
            _pasteBunifuButton.AutoGenerateColors = false;
            _pasteBunifuButton.BackColor = Color.Transparent;
            _pasteBunifuButton.BackColor1 = Color.White;
            _pasteBunifuButton.BackgroundImage = (Image)resources.GetObject("pasteBunifuButton.BackgroundImage");
            _pasteBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _pasteBunifuButton.ButtonText = "";
            _pasteBunifuButton.ButtonTextMarginLeft = 0;
            _pasteBunifuButton.ColorContrastOnClick = 45;
            _pasteBunifuButton.ColorContrastOnHover = 45;
            _pasteBunifuButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _pasteBunifuButton.CustomizableEdges = BorderEdges2;
            _pasteBunifuButton.DialogResult = DialogResult.None;
            _pasteBunifuButton.DisabledBorderColor = Color.Empty;
            _pasteBunifuButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _pasteBunifuButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _pasteBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _pasteBunifuButton.Font = new Font("Segoe UI Semibold", 26.18182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _pasteBunifuButton.ForeColor = Color.White;
            _pasteBunifuButton.IconLeftCursor = Cursors.Hand;
            _pasteBunifuButton.IconMarginLeft = 10;
            _pasteBunifuButton.IconPadding = 10;
            _pasteBunifuButton.IconRightCursor = Cursors.Hand;
            _pasteBunifuButton.IdleBorderColor = Color.Teal;
            _pasteBunifuButton.IdleBorderRadius = 3;
            _pasteBunifuButton.IdleBorderThickness = 3;
            _pasteBunifuButton.IdleFillColor = Color.White;
            _pasteBunifuButton.IdleIconLeftImage = My.Resources.Resources.copy_file;
            _pasteBunifuButton.IdleIconRightImage = null;
            _pasteBunifuButton.IndicateFocus = false;
            _pasteBunifuButton.Location = new Point(1349, 17);
            _pasteBunifuButton.Name = "_pasteBunifuButton";
            StateProperties3.BorderColor = Color.Teal;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 3;
            StateProperties3.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _pasteBunifuButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 3;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _pasteBunifuButton.OnPressedState = StateProperties4;
            _pasteBunifuButton.Size = new Size(50, 48);
            _pasteBunifuButton.TabIndex = 70;
            _pasteBunifuButton.TextAlign = ContentAlignment.MiddleCenter;
            _pasteBunifuButton.TextMarginLeft = 0;
            _pasteBunifuButton.UseDefaultRadiusAndThickness = true;
            // 
            // addBttn
            // 
            _addBttn.AllowToggling = false;
            _addBttn.AnimationSpeed = 200;
            _addBttn.AutoGenerateColors = false;
            _addBttn.BackColor = Color.Transparent;
            _addBttn.BackColor1 = Color.White;
            _addBttn.BackgroundImage = (Image)resources.GetObject("addBttn.BackgroundImage");
            _addBttn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _addBttn.ButtonText = "";
            _addBttn.ButtonTextMarginLeft = 0;
            _addBttn.ColorContrastOnClick = 45;
            _addBttn.ColorContrastOnHover = 45;
            _addBttn.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _addBttn.CustomizableEdges = BorderEdges3;
            _addBttn.DialogResult = DialogResult.None;
            _addBttn.DisabledBorderColor = Color.Empty;
            _addBttn.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _addBttn.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _addBttn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _addBttn.Font = new Font("Segoe UI Semibold", 26.18182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _addBttn.ForeColor = Color.White;
            _addBttn.IconLeftCursor = Cursors.Hand;
            _addBttn.IconMarginLeft = 15;
            _addBttn.IconPadding = 15;
            _addBttn.IconRightCursor = Cursors.Hand;
            _addBttn.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _addBttn.IdleBorderRadius = 90;
            _addBttn.IdleBorderThickness = 3;
            _addBttn.IdleFillColor = Color.White;
            _addBttn.IdleIconLeftImage = My.Resources.Resources.add;
            _addBttn.IdleIconRightImage = null;
            _addBttn.IndicateFocus = false;
            _addBttn.Location = new Point(1299, 294);
            _addBttn.Name = "_addBttn";
            StateProperties5.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties5.BorderRadius = 90;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 3;
            StateProperties5.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(128)));
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _addBttn.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties6.BorderRadius = 90;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 3;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _addBttn.OnPressedState = StateProperties6;
            _addBttn.Size = new Size(100, 98);
            _addBttn.TabIndex = 1;
            _addBttn.TextAlign = ContentAlignment.MiddleCenter;
            _addBttn.TextMarginLeft = 0;
            _addBttn.UseDefaultRadiusAndThickness = true;
            // 
            // printLabelsBunifuButton
            // 
            _printLabelsBunifuButton.AllowToggling = false;
            _printLabelsBunifuButton.Anchor = AnchorStyles.Bottom;
            _printLabelsBunifuButton.AnimationSpeed = 200;
            _printLabelsBunifuButton.AutoGenerateColors = false;
            _printLabelsBunifuButton.BackColor = Color.Transparent;
            _printLabelsBunifuButton.BackColor1 = Color.Teal;
            _printLabelsBunifuButton.BackgroundImage = (Image)resources.GetObject("printLabelsBunifuButton.BackgroundImage");
            _printLabelsBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _printLabelsBunifuButton.ButtonText = "Print";
            _printLabelsBunifuButton.ButtonTextMarginLeft = 0;
            _printLabelsBunifuButton.ColorContrastOnClick = 45;
            _printLabelsBunifuButton.ColorContrastOnHover = 45;
            _printLabelsBunifuButton.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _printLabelsBunifuButton.CustomizableEdges = BorderEdges4;
            _printLabelsBunifuButton.DialogResult = DialogResult.None;
            _printLabelsBunifuButton.DisabledBorderColor = Color.Empty;
            _printLabelsBunifuButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _printLabelsBunifuButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _printLabelsBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _printLabelsBunifuButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _printLabelsBunifuButton.ForeColor = Color.White;
            _printLabelsBunifuButton.IconLeftCursor = Cursors.Hand;
            _printLabelsBunifuButton.IconMarginLeft = 11;
            _printLabelsBunifuButton.IconPadding = 10;
            _printLabelsBunifuButton.IconRightCursor = Cursors.Hand;
            _printLabelsBunifuButton.IdleBorderColor = Color.Teal;
            _printLabelsBunifuButton.IdleBorderRadius = 3;
            _printLabelsBunifuButton.IdleBorderThickness = 1;
            _printLabelsBunifuButton.IdleFillColor = Color.Teal;
            _printLabelsBunifuButton.IdleIconLeftImage = null;
            _printLabelsBunifuButton.IdleIconRightImage = null;
            _printLabelsBunifuButton.IndicateFocus = true;
            _printLabelsBunifuButton.Location = new Point(607, 925);
            _printLabelsBunifuButton.Name = "_printLabelsBunifuButton";
            StateProperties7.BorderColor = Color.MediumTurquoise;
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.MediumTurquoise;
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _printLabelsBunifuButton.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Teal;
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.Teal;
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _printLabelsBunifuButton.OnPressedState = StateProperties8;
            _printLabelsBunifuButton.Size = new Size(177, 45);
            _printLabelsBunifuButton.TabIndex = 69;
            _printLabelsBunifuButton.TextAlign = ContentAlignment.MiddleCenter;
            _printLabelsBunifuButton.TextMarginLeft = 0;
            _printLabelsBunifuButton.UseDefaultRadiusAndThickness = true;
            // 
            // mainLabelPanel
            // 
            mainLabelPanel.Anchor = AnchorStyles.None;
            mainLabelPanel.Controls.Add(labelPanel1);
            mainLabelPanel.Controls.Add(labelPanel2);
            mainLabelPanel.Controls.Add(labelPanel3);
            mainLabelPanel.Controls.Add(labelPanel4);
            mainLabelPanel.Location = new Point(107, 10);
            mainLabelPanel.Margin = new Padding(0);
            mainLabelPanel.Name = "mainLabelPanel";
            mainLabelPanel.Size = new Size(1189, 903);
            mainLabelPanel.TabIndex = 2;
            // 
            // labelPanel1
            // 
            labelPanel1.BorderColor = Color.Transparent;
            labelPanel1.Controls.Add(_RichTextBox1);
            labelPanel1.Location = new Point(0, 0);
            labelPanel1.Margin = new Padding(0);
            labelPanel1.Name = "labelPanel1";
            labelPanel1.Padding = new Padding(23, 23, 25, 20);
            labelPanel1.PanelColor = Color.Empty;
            labelPanel1.RightToLeft = RightToLeft.No;
            labelPanel1.ShadowDept = 2;
            labelPanel1.ShadowTopLeftVisible = true;
            labelPanel1.Size = new Size(585, 450);
            labelPanel1.TabIndex = 1;
            // 
            // RichTextBox1
            // 
            _RichTextBox1.BorderStyle = BorderStyle.None;
            _RichTextBox1.Dock = DockStyle.Fill;
            _RichTextBox1.Location = new Point(23, 23);
            _RichTextBox1.Name = "_RichTextBox1";
            _RichTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            _RichTextBox1.Size = new Size(537, 407);
            _RichTextBox1.TabIndex = 0;
            _RichTextBox1.Text = "";
            // 
            // labelPanel2
            // 
            labelPanel2.BorderColor = Color.Transparent;
            labelPanel2.Controls.Add(_deleteBunifuButton1);
            labelPanel2.Controls.Add(_RichTextBox2);
            labelPanel2.Location = new Point(585, 0);
            labelPanel2.Margin = new Padding(0);
            labelPanel2.Name = "labelPanel2";
            labelPanel2.Padding = new Padding(23, 23, 25, 20);
            labelPanel2.PanelColor = Color.Empty;
            labelPanel2.RightToLeft = RightToLeft.No;
            labelPanel2.ShadowDept = 2;
            labelPanel2.ShadowTopLeftVisible = true;
            labelPanel2.Size = new Size(585, 450);
            labelPanel2.TabIndex = 2;
            // 
            // deleteBunifuButton1
            // 
            _deleteBunifuButton1.AllowToggling = false;
            _deleteBunifuButton1.AnimationSpeed = 200;
            _deleteBunifuButton1.AutoGenerateColors = false;
            _deleteBunifuButton1.BackColor = Color.Transparent;
            _deleteBunifuButton1.BackColor1 = Color.White;
            _deleteBunifuButton1.BackgroundImage = (Image)resources.GetObject("deleteBunifuButton1.BackgroundImage");
            _deleteBunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _deleteBunifuButton1.ButtonText = "";
            _deleteBunifuButton1.ButtonTextMarginLeft = 0;
            _deleteBunifuButton1.ColorContrastOnClick = 45;
            _deleteBunifuButton1.ColorContrastOnHover = 45;
            _deleteBunifuButton1.Cursor = Cursors.Hand;
            BorderEdges5.BottomLeft = true;
            BorderEdges5.BottomRight = true;
            BorderEdges5.TopLeft = true;
            BorderEdges5.TopRight = true;
            _deleteBunifuButton1.CustomizableEdges = BorderEdges5;
            _deleteBunifuButton1.DialogResult = DialogResult.None;
            _deleteBunifuButton1.DisabledBorderColor = Color.Empty;
            _deleteBunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _deleteBunifuButton1.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _deleteBunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _deleteBunifuButton1.Font = new Font("Segoe UI Semibold", 26.18182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _deleteBunifuButton1.ForeColor = Color.Transparent;
            _deleteBunifuButton1.IconLeftCursor = Cursors.Hand;
            _deleteBunifuButton1.IconMarginLeft = 8;
            _deleteBunifuButton1.IconPadding = 8;
            _deleteBunifuButton1.IconRightCursor = Cursors.Hand;
            _deleteBunifuButton1.IdleBorderColor = Color.Firebrick;
            _deleteBunifuButton1.IdleBorderRadius = 25;
            _deleteBunifuButton1.IdleBorderThickness = 3;
            _deleteBunifuButton1.IdleFillColor = Color.White;
            _deleteBunifuButton1.IdleIconLeftImage = My.Resources.Resources.delete;
            _deleteBunifuButton1.IdleIconRightImage = null;
            _deleteBunifuButton1.IndicateFocus = false;
            _deleteBunifuButton1.Location = new Point(552, 0);
            _deleteBunifuButton1.Name = "_deleteBunifuButton1";
            StateProperties9.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties9.BorderRadius = 25;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 3;
            StateProperties9.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(128)));
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            _deleteBunifuButton1.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties10.BorderRadius = 25;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 3;
            StateProperties10.FillColor = Color.White;
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            _deleteBunifuButton1.OnPressedState = StateProperties10;
            _deleteBunifuButton1.Size = new Size(33, 34);
            _deleteBunifuButton1.TabIndex = 70;
            _deleteBunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            _deleteBunifuButton1.TextMarginLeft = 0;
            _deleteBunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // RichTextBox2
            // 
            _RichTextBox2.BorderStyle = BorderStyle.None;
            _RichTextBox2.Dock = DockStyle.Fill;
            _RichTextBox2.Location = new Point(23, 23);
            _RichTextBox2.Name = "_RichTextBox2";
            _RichTextBox2.ScrollBars = RichTextBoxScrollBars.None;
            _RichTextBox2.Size = new Size(537, 407);
            _RichTextBox2.TabIndex = 0;
            _RichTextBox2.Text = "";
            // 
            // labelPanel3
            // 
            labelPanel3.BorderColor = Color.Transparent;
            labelPanel3.Controls.Add(_deleteBunifuButto2);
            labelPanel3.Controls.Add(_RichTextBox3);
            labelPanel3.Location = new Point(0, 450);
            labelPanel3.Margin = new Padding(0);
            labelPanel3.Name = "labelPanel3";
            labelPanel3.Padding = new Padding(23, 23, 25, 20);
            labelPanel3.PanelColor = Color.Empty;
            labelPanel3.RightToLeft = RightToLeft.No;
            labelPanel3.ShadowDept = 2;
            labelPanel3.ShadowTopLeftVisible = true;
            labelPanel3.Size = new Size(585, 450);
            labelPanel3.TabIndex = 3;
            // 
            // deleteBunifuButto2
            // 
            _deleteBunifuButto2.AllowToggling = false;
            _deleteBunifuButto2.AnimationSpeed = 200;
            _deleteBunifuButto2.AutoGenerateColors = false;
            _deleteBunifuButto2.BackColor = Color.Transparent;
            _deleteBunifuButto2.BackColor1 = Color.White;
            _deleteBunifuButto2.BackgroundImage = (Image)resources.GetObject("deleteBunifuButto2.BackgroundImage");
            _deleteBunifuButto2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _deleteBunifuButto2.ButtonText = "";
            _deleteBunifuButto2.ButtonTextMarginLeft = 0;
            _deleteBunifuButto2.ColorContrastOnClick = 45;
            _deleteBunifuButto2.ColorContrastOnHover = 45;
            _deleteBunifuButto2.Cursor = Cursors.Hand;
            BorderEdges6.BottomLeft = true;
            BorderEdges6.BottomRight = true;
            BorderEdges6.TopLeft = true;
            BorderEdges6.TopRight = true;
            _deleteBunifuButto2.CustomizableEdges = BorderEdges6;
            _deleteBunifuButto2.DialogResult = DialogResult.None;
            _deleteBunifuButto2.DisabledBorderColor = Color.Empty;
            _deleteBunifuButto2.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _deleteBunifuButto2.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _deleteBunifuButto2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _deleteBunifuButto2.Font = new Font("Segoe UI Semibold", 26.18182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _deleteBunifuButto2.ForeColor = Color.Transparent;
            _deleteBunifuButto2.IconLeftCursor = Cursors.Hand;
            _deleteBunifuButto2.IconMarginLeft = 8;
            _deleteBunifuButto2.IconPadding = 8;
            _deleteBunifuButto2.IconRightCursor = Cursors.Hand;
            _deleteBunifuButto2.IdleBorderColor = Color.Firebrick;
            _deleteBunifuButto2.IdleBorderRadius = 25;
            _deleteBunifuButto2.IdleBorderThickness = 3;
            _deleteBunifuButto2.IdleFillColor = Color.White;
            _deleteBunifuButto2.IdleIconLeftImage = My.Resources.Resources.delete;
            _deleteBunifuButto2.IdleIconRightImage = null;
            _deleteBunifuButto2.IndicateFocus = false;
            _deleteBunifuButto2.Location = new Point(552, 3);
            _deleteBunifuButto2.Name = "_deleteBunifuButto2";
            StateProperties11.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties11.BorderRadius = 25;
            StateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties11.BorderThickness = 3;
            StateProperties11.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(128)));
            StateProperties11.ForeColor = Color.White;
            StateProperties11.IconLeftImage = null;
            StateProperties11.IconRightImage = null;
            _deleteBunifuButto2.onHoverState = StateProperties11;
            StateProperties12.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties12.BorderRadius = 25;
            StateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties12.BorderThickness = 3;
            StateProperties12.FillColor = Color.White;
            StateProperties12.ForeColor = Color.White;
            StateProperties12.IconLeftImage = null;
            StateProperties12.IconRightImage = null;
            _deleteBunifuButto2.OnPressedState = StateProperties12;
            _deleteBunifuButto2.Size = new Size(33, 34);
            _deleteBunifuButto2.TabIndex = 71;
            _deleteBunifuButto2.TextAlign = ContentAlignment.MiddleCenter;
            _deleteBunifuButto2.TextMarginLeft = 0;
            _deleteBunifuButto2.UseDefaultRadiusAndThickness = true;
            // 
            // RichTextBox3
            // 
            _RichTextBox3.BorderStyle = BorderStyle.None;
            _RichTextBox3.Dock = DockStyle.Fill;
            _RichTextBox3.Location = new Point(23, 23);
            _RichTextBox3.Name = "_RichTextBox3";
            _RichTextBox3.ScrollBars = RichTextBoxScrollBars.None;
            _RichTextBox3.Size = new Size(537, 407);
            _RichTextBox3.TabIndex = 0;
            _RichTextBox3.Text = "";
            // 
            // labelPanel4
            // 
            labelPanel4.BorderColor = Color.Transparent;
            labelPanel4.Controls.Add(_FlowLayoutPanel1);
            labelPanel4.Controls.Add(_deleteBunifuButton3);
            labelPanel4.Controls.Add(_RichTextBox4);
            labelPanel4.Location = new Point(585, 450);
            labelPanel4.Margin = new Padding(0);
            labelPanel4.Name = "labelPanel4";
            labelPanel4.Padding = new Padding(23, 23, 25, 20);
            labelPanel4.PanelColor = Color.Empty;
            labelPanel4.RightToLeft = RightToLeft.No;
            labelPanel4.ShadowDept = 2;
            labelPanel4.ShadowTopLeftVisible = true;
            labelPanel4.Size = new Size(585, 450);
            labelPanel4.TabIndex = 4;
            // 
            // FlowLayoutPanel1
            // 
            _FlowLayoutPanel1.Location = new Point(702, 13);
            _FlowLayoutPanel1.Name = "_FlowLayoutPanel1";
            _FlowLayoutPanel1.Size = new Size(200, 100);
            _FlowLayoutPanel1.TabIndex = 73;
            // 
            // deleteBunifuButton3
            // 
            _deleteBunifuButton3.AllowToggling = false;
            _deleteBunifuButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _deleteBunifuButton3.AnimationSpeed = 200;
            _deleteBunifuButton3.AutoGenerateColors = false;
            _deleteBunifuButton3.BackColor = Color.Transparent;
            _deleteBunifuButton3.BackColor1 = Color.White;
            _deleteBunifuButton3.BackgroundImage = (Image)resources.GetObject("deleteBunifuButton3.BackgroundImage");
            _deleteBunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _deleteBunifuButton3.ButtonText = "";
            _deleteBunifuButton3.ButtonTextMarginLeft = 0;
            _deleteBunifuButton3.ColorContrastOnClick = 45;
            _deleteBunifuButton3.ColorContrastOnHover = 45;
            _deleteBunifuButton3.Cursor = Cursors.Hand;
            BorderEdges7.BottomLeft = true;
            BorderEdges7.BottomRight = true;
            BorderEdges7.TopLeft = true;
            BorderEdges7.TopRight = true;
            _deleteBunifuButton3.CustomizableEdges = BorderEdges7;
            _deleteBunifuButton3.DialogResult = DialogResult.None;
            _deleteBunifuButton3.DisabledBorderColor = Color.Empty;
            _deleteBunifuButton3.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _deleteBunifuButton3.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _deleteBunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _deleteBunifuButton3.Font = new Font("Segoe UI Semibold", 26.18182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _deleteBunifuButton3.ForeColor = Color.Transparent;
            _deleteBunifuButton3.IconLeftCursor = Cursors.Hand;
            _deleteBunifuButton3.IconMarginLeft = 8;
            _deleteBunifuButton3.IconPadding = 8;
            _deleteBunifuButton3.IconRightCursor = Cursors.Hand;
            _deleteBunifuButton3.IdleBorderColor = Color.Firebrick;
            _deleteBunifuButton3.IdleBorderRadius = 25;
            _deleteBunifuButton3.IdleBorderThickness = 3;
            _deleteBunifuButton3.IdleFillColor = Color.White;
            _deleteBunifuButton3.IdleIconLeftImage = My.Resources.Resources.delete;
            _deleteBunifuButton3.IdleIconRightImage = null;
            _deleteBunifuButton3.IndicateFocus = false;
            _deleteBunifuButton3.Location = new Point(552, 0);
            _deleteBunifuButton3.Name = "_deleteBunifuButton3";
            StateProperties13.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties13.BorderRadius = 25;
            StateProperties13.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties13.BorderThickness = 3;
            StateProperties13.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(128)));
            StateProperties13.ForeColor = Color.White;
            StateProperties13.IconLeftImage = null;
            StateProperties13.IconRightImage = null;
            _deleteBunifuButton3.onHoverState = StateProperties13;
            StateProperties14.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties14.BorderRadius = 25;
            StateProperties14.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties14.BorderThickness = 3;
            StateProperties14.FillColor = Color.White;
            StateProperties14.ForeColor = Color.White;
            StateProperties14.IconLeftImage = null;
            StateProperties14.IconRightImage = null;
            _deleteBunifuButton3.OnPressedState = StateProperties14;
            _deleteBunifuButton3.Size = new Size(33, 34);
            _deleteBunifuButton3.TabIndex = 72;
            _deleteBunifuButton3.TextAlign = ContentAlignment.MiddleCenter;
            _deleteBunifuButton3.TextMarginLeft = 0;
            _deleteBunifuButton3.UseDefaultRadiusAndThickness = true;
            // 
            // RichTextBox4
            // 
            _RichTextBox4.BorderStyle = BorderStyle.None;
            _RichTextBox4.Dock = DockStyle.Fill;
            _RichTextBox4.Location = new Point(23, 23);
            _RichTextBox4.Name = "_RichTextBox4";
            _RichTextBox4.ScrollBars = RichTextBoxScrollBars.None;
            _RichTextBox4.Size = new Size(537, 407);
            _RichTextBox4.TabIndex = 0;
            _RichTextBox4.Text = "";
            // 
            // PrintDialog2
            // 
            PrintDialog2.UseEXDialog = true;
            // 
            // PrintDocument2
            // 
            // 
            // VWCompanyCompanyTypeBindingSource
            // 
            VWCompanyCompanyTypeBindingSource.DataSource = typeof(ModelLayer.VW_CompanyCompanyType);
            // 
            // Column2
            // 
            Column2.FillWeight = 15.0f;
            Column2.HeaderText = "";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // MiniUnitNumber
            // 
            MiniUnitNumber.DataPropertyName = "MiniUnitNumber";
            MiniUnitNumber.HeaderText = "Unit Number";
            MiniUnitNumber.Name = "MiniUnitNumber";
            MiniUnitNumber.ReadOnly = true;
            // 
            // FrmCFIALabel
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1476, 1039);
            ControlBox = false;
            Controls.Add(BunifuShadowPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCFIALabel";
            StartPosition = FormStartPosition.CenterScreen;
            BunifuShadowPanel2.ResumeLayout(false);
            labelsTabControl.ResumeLayout(false);
            TabPageEX1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            typeUnitPanel.ResumeLayout(false);
            typeUnitPanel.PerformLayout();
            selectUnitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWMinibookingMiniUnitAssignmentBindingSource).EndInit();
            TableLayoutPanel4.ResumeLayout(false);
            certificationsTabPage.ResumeLayout(false);
            mainLabelPanel.ResumeLayout(false);
            labelPanel1.ResumeLayout(false);
            labelPanel2.ResumeLayout(false);
            labelPanel3.ResumeLayout(false);
            labelPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VWCompanyCompanyTypeBindingSource).EndInit();
            Load += new EventHandler(frmcfialabel_load);
            ResumeLayout(false);
        }

        internal ImageList ImageList1;
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
                    _PrintDocument1.PrintPage -= printdocument1_printpage;
                }

                _PrintDocument1 = value;
                if (_PrintDocument1 != null)
                {
                    _PrintDocument1.PrintPage += printdocument1_printpage;
                }
            }
        }

        internal PrintDialog PrintDialog1;

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void unitsListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        }

        private void unitsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void unitsListView_MouseClick(object sender, MouseEventArgs e)
        {
        }

        internal CheckBox CheckBox1;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel2;
        internal Dotnetrix.Controls.TabControlEX labelsTabControl;
        internal Dotnetrix.Controls.TabPageEX TabPageEX1;
        internal Panel Panel1;
        internal PictureBox PictureBox1;
        internal TableLayoutPanel TableLayoutPanel4;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch _tgActiveBooking;

        internal Bunifu.ToggleSwitch.BunifuToggleSwitch tgActiveBooking
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tgActiveBooking;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tgActiveBooking != null)
                {
                    _tgActiveBooking.OnValuechange -= tgActiveBooking_OnValuechange;
                }

                _tgActiveBooking = value;
                if (_tgActiveBooking != null)
                {
                    _tgActiveBooking.OnValuechange += tgActiveBooking_OnValuechange;
                }
            }
        }

        internal Label Label1;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch _BunifuToggleSwitch1;

        internal Bunifu.ToggleSwitch.BunifuToggleSwitch BunifuToggleSwitch1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuToggleSwitch1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuToggleSwitch1 != null)
                {
                    _BunifuToggleSwitch1.OnValuechange -= bunifutoggleswitch1_onvaluechange;
                }

                _BunifuToggleSwitch1 = value;
                if (_BunifuToggleSwitch1 != null)
                {
                    _BunifuToggleSwitch1.OnValuechange += bunifutoggleswitch1_onvaluechange;
                }
            }
        }

        internal Label Label5;
        internal Label warningLabel;
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
                    _printButton.Click -= button1_click;
                }

                _printButton = value;
                if (_printButton != null)
                {
                    _printButton.Click += button1_click;
                }
            }
        }

        internal Panel typeUnitPanel;
        internal TextBox commodityTextBox;
        internal Label Label14;
        private TextBox _unitNumberTextBox;

        internal TextBox unitNumberTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _unitNumberTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_unitNumberTextBox != null)
                {
                    _unitNumberTextBox.TextChanged -= unitNumberTextBox_TextChanged;
                }

                _unitNumberTextBox = value;
                if (_unitNumberTextBox != null)
                {
                    _unitNumberTextBox.TextChanged += unitNumberTextBox_TextChanged;
                }
            }
        }

        internal Label Label3;
        internal Label gradeAndComodityLabe;
        private Bunifu.UI.WinForms.BunifuDropdown _sampletitlecombobox;

        internal Bunifu.UI.WinForms.BunifuDropdown sampletitlecombobox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sampletitlecombobox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sampletitlecombobox != null)
                {
                    _sampletitlecombobox.SelectedIndexChanged -= sampletitlecombobox_selectedindexchanged;
                }

                _sampletitlecombobox = value;
                if (_sampletitlecombobox != null)
                {
                    _sampletitlecombobox.SelectedIndexChanged += sampletitlecombobox_selectedindexchanged;
                }
            }
        }

        internal Label Label2;
        internal Label customerLabel;
        internal Bunifu.UI.WinForms.BunifuDatePicker todatetimepicker;
        internal Label Label15;
        internal Label bookingIDLabel;
        internal Label Label4;
        private ComboBox _cboBooking;

        internal ComboBox cboBooking
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboBooking;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboBooking != null)
                {
                    _cboBooking.SelectedIndexChanged -= bookingsnumbcombobox_SelectedIndexChanged;
                }

                _cboBooking = value;
                if (_cboBooking != null)
                {
                    _cboBooking.SelectedIndexChanged += bookingsnumbcombobox_SelectedIndexChanged;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuDatePicker fromdatetimepicker;
        internal Panel selectUnitPanel;
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
                    _selectAllCheckBox.CheckedChanged -= checkbox2_checkedchanged;
                    _selectAllCheckBox.CheckedChanged -= checkbox2_checkedchanged;
                }

                _selectAllCheckBox = value;
                if (_selectAllCheckBox != null)
                {
                    _selectAllCheckBox.CheckedChanged += checkbox2_checkedchanged;
                    _selectAllCheckBox.CheckedChanged += checkbox2_checkedchanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDataGridView _dgvUnits;

        internal Bunifu.UI.WinForms.BunifuDataGridView dgvUnits
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvUnits;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvUnits != null)
                {
                    _dgvUnits.SelectionChanged -= unitslistview_SelectionChanged;
                    _dgvUnits.CellContentClick -= unitiesBunifuDataGridView_CellContentClick;
                    _dgvUnits.DoubleClick -= dgvUnits_DoubleClick;
                }

                _dgvUnits = value;
                if (_dgvUnits != null)
                {
                    _dgvUnits.SelectionChanged += unitslistview_SelectionChanged;
                    _dgvUnits.CellContentClick += unitiesBunifuDataGridView_CellContentClick;
                    _dgvUnits.DoubleClick += dgvUnits_DoubleClick;
                }
            }
        }

        internal Dotnetrix.Controls.TabPageEX certificationsTabPage;
        internal FlowLayoutPanel mainLabelPanel;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel labelPanel1;
        private RichTextBox _RichTextBox1;

        internal RichTextBox RichTextBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RichTextBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RichTextBox1 != null)
                {

                    _RichTextBox1.KeyDown -= RichTextBox1_KeyDown;
                    _RichTextBox1.GotFocus -= RichTextBox1_GotFocus;
                }

                _RichTextBox1 = value;
                if (_RichTextBox1 != null)
                {

                    _RichTextBox1.KeyDown += RichTextBox1_KeyDown;
                    _RichTextBox1.GotFocus += RichTextBox1_GotFocus;
                }
            }
        }

        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel labelPanel2;
        private RichTextBox _RichTextBox2;

        internal RichTextBox RichTextBox2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RichTextBox2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RichTextBox2 != null)
                {
                    _RichTextBox2.GotFocus -= RichTextBox2_GotFocus;
                }

                _RichTextBox2 = value;
                if (_RichTextBox2 != null)
                {
                    _RichTextBox2.GotFocus += RichTextBox2_GotFocus;
                }
            }
        }

        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel labelPanel3;
        private RichTextBox _RichTextBox3;

        internal RichTextBox RichTextBox3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RichTextBox3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RichTextBox3 != null)
                {
                    _RichTextBox3.GotFocus -= RichTextBox3_GotFocus;
                }

                _RichTextBox3 = value;
                if (_RichTextBox3 != null)
                {
                    _RichTextBox3.GotFocus += RichTextBox3_GotFocus;
                }
            }
        }

        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel labelPanel4;
        private RichTextBox _RichTextBox4;

        internal RichTextBox RichTextBox4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RichTextBox4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RichTextBox4 != null)
                {
                    _RichTextBox4.GotFocus -= RichTextBox4_GotFocus;
                }

                _RichTextBox4 = value;
                if (_RichTextBox4 != null)
                {
                    _RichTextBox4.GotFocus += RichTextBox4_GotFocus;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _printLabelsBunifuButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton printLabelsBunifuButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _printLabelsBunifuButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_printLabelsBunifuButton != null)
                {
                    _printLabelsBunifuButton.Click -= printLabelsBunifuButton_Click;
                }

                _printLabelsBunifuButton = value;
                if (_printLabelsBunifuButton != null)
                {
                    _printLabelsBunifuButton.Click += printLabelsBunifuButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _addBttn;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton addBttn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _addBttn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_addBttn != null)
                {
                    _addBttn.Click -= addBttn_Click;
                }

                _addBttn = value;
                if (_addBttn != null)
                {
                    _addBttn.Click += addBttn_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _deleteBunifuButton1;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteBunifuButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _deleteBunifuButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_deleteBunifuButton1 != null)
                {
                    _deleteBunifuButton1.Click -= deleteBunifuButton1_Click;
                }

                _deleteBunifuButton1 = value;
                if (_deleteBunifuButton1 != null)
                {
                    _deleteBunifuButton1.Click += deleteBunifuButton1_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _deleteBunifuButto2;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteBunifuButto2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _deleteBunifuButto2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_deleteBunifuButto2 != null)
                {
                    _deleteBunifuButto2.Click -= deleteBunifuButto2_Click;
                }

                _deleteBunifuButto2 = value;
                if (_deleteBunifuButto2 != null)
                {
                    _deleteBunifuButto2.Click += deleteBunifuButto2_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _deleteBunifuButton3;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteBunifuButton3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _deleteBunifuButton3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_deleteBunifuButton3 != null)
                {
                    _deleteBunifuButton3.Click -= deleteBunifuButton3_Click;
                }

                _deleteBunifuButton3 = value;
                if (_deleteBunifuButton3 != null)
                {
                    _deleteBunifuButton3.Click += deleteBunifuButton3_Click;
                }
            }
        }

        internal PrintDialog PrintDialog2;
        private System.Drawing.Printing.PrintDocument _PrintDocument2;

        internal System.Drawing.Printing.PrintDocument PrintDocument2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PrintDocument2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PrintDocument2 != null)
                {
                    _PrintDocument2.PrintPage -= PrintDocument2_PrintPage;
                }

                _PrintDocument2 = value;
                if (_PrintDocument2 != null)
                {
                    _PrintDocument2.PrintPage += PrintDocument2_PrintPage;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _pasteBunifuButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton pasteBunifuButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pasteBunifuButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pasteBunifuButton != null)
                {
                    _pasteBunifuButton.Click -= BunifuButton1_Click;
                }

                _pasteBunifuButton = value;
                if (_pasteBunifuButton != null)
                {
                    _pasteBunifuButton.Click += BunifuButton1_Click;
                }
            }
        }

        private FlowLayoutPanel _FlowLayoutPanel1;

        internal FlowLayoutPanel FlowLayoutPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FlowLayoutPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FlowLayoutPanel1 != null)
                {
                    _FlowLayoutPanel1.Paint -= FlowLayoutPanel1_Paint;
                }

                _FlowLayoutPanel1 = value;
                if (_FlowLayoutPanel1 != null)
                {
                    _FlowLayoutPanel1.Paint += FlowLayoutPanel1_Paint;
                }
            }
        }

        internal BindingSource VWCompanyCompanyTypeBindingSource;
        internal BindingSource VWMinibookingMiniUnitAssignmentBindingSource;
        internal TextBox tbCustomer;
        internal Label Label6;
        internal DataGridViewCheckBoxColumn Column2;
        internal DataGridViewTextBoxColumn MiniUnitNumber;
    }
}