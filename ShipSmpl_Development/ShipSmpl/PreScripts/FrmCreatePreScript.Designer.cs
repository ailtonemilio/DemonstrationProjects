using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmCreatePreScript : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreatePreScript));
            departmentComboBox = new ComboBox();
            FlowLayoutPanel2 = new FlowLayoutPanel();
            _companyNameShapedLabel = new CustomizedControlsLibrary.ShapedLabel();
            _companyNameShapedLabel.Click += new EventHandler(companyNameShapedLabel_Click);
            _containerWeightShapedLabel = new CustomizedControlsLibrary.ShapedLabel();
            _containerWeightShapedLabel.Click += new EventHandler(containerWeightShapedLabel_Click);
            _bookingStatusShapedLabel = new CustomizedControlsLibrary.ShapedLabel();
            _bookingStatusShapedLabel.Click += new EventHandler(bookingStatusShapedLabel_Click);
            typeComboBox = new ComboBox();
            _TouchButton2 = new YardTabletControls.TouchButton();
            _TouchButton2.ButtonClick += new YardTabletControls.TouchButton.ButtonClickEventHandler(TouchButton2_Load);
            _createTemplateTouchButton = new YardTabletControls.TouchButton();
            _createTemplateTouchButton.ButtonClick += new YardTabletControls.TouchButton.ButtonClickEventHandler(createTemplateTouchButton_Load);
            _tamplateTitleTextBox = new TextBox();
            _tamplateTitleTextBox.TextChanged += new EventHandler(tamplateTitleTextBox_TextChanged);
            Label11 = new Label();
            Label9 = new Label();
            Label1 = new Label();
            _messageRichTextBox = new RichTextBox();
            _messageRichTextBox.TextChanged += new EventHandler(messageRichTextBox_TextChanged);
            titleLabel = new Label();
            Label8 = new Label();
            _containerNumberShapedLabel = new CustomizedControlsLibrary.ShapedLabel();
            _containerNumberShapedLabel.Click += new EventHandler(containerNumberShapedLabel_Click);
            _dateShapedLabel = new CustomizedControlsLibrary.ShapedLabel();
            _dateShapedLabel.Click += new EventHandler(dateShapedLabel_Click);
            _bookingNumberShapedLabel = new CustomizedControlsLibrary.ShapedLabel();
            _bookingNumberShapedLabel.Click += new EventHandler(bookingNumberShapedLabel_Click);
            Label10 = new Label();
            FlowLayoutPanel1 = new FlowLayoutPanel();
            TableLayoutPanel1 = new TableLayoutPanel();
            _addActionLabel = new Label();
            _addActionLabel.Click += new EventHandler(addActionLabel_Click);
            ImageList1 = new ImageList(components);
            FlowLayoutPanel4 = new FlowLayoutPanel();
            ShapedLabelAction1 = new CustomizedControlsLibrary.ShapedLabel();
            ShapedLabelAction2 = new CustomizedControlsLibrary.ShapedLabel();
            ShapedLabelAction3 = new CustomizedControlsLibrary.ShapedLabel();
            ShapedLabelAction4 = new CustomizedControlsLibrary.ShapedLabel();
            ShapedLabelAction5 = new CustomizedControlsLibrary.ShapedLabel();
            ShapedLabelAction6 = new CustomizedControlsLibrary.ShapedLabel();
            FlowLayoutPanel3 = new FlowLayoutPanel();
            ShapedLabelRule2 = new CustomizedControlsLibrary.ShapedLabel();
            ShapedLabelRule1 = new CustomizedControlsLibrary.ShapedLabel();
            ShapedLabelRule3 = new CustomizedControlsLibrary.ShapedLabel();
            ShapedLabelRule4 = new CustomizedControlsLibrary.ShapedLabel();
            ShapedLabelRule5 = new CustomizedControlsLibrary.ShapedLabel();
            ShapedLabelRule6 = new CustomizedControlsLibrary.ShapedLabel();
            Label2 = new Label();
            availableTitle = new PictureBox();
            Label3 = new Label();
            _addRuleLabel = new Label();
            _addRuleLabel.Click += new EventHandler(addRuleLabel_Click);
            rulesActionsPanel = new Panel();
            rulesListView = new ListView();
            _Button1 = new Button();
            _Button1.Click += new EventHandler(Button1_Click);
            _editRulesLabel = new Label();
            _editRulesLabel.Click += new EventHandler(editRulesLabel_Click);
            Label4 = new Label();
            ToolTip1 = new ToolTip(components);
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            GroupBox1 = new GroupBox();
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            TextBox3 = new TextBox();
            Label12 = new Label();
            Label13 = new Label();
            Label14 = new Label();
            TextBox4 = new TextBox();
            Label15 = new Label();
            FlowLayoutPanel2.SuspendLayout();
            FlowLayoutPanel1.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            FlowLayoutPanel4.SuspendLayout();
            FlowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)availableTitle).BeginInit();
            rulesActionsPanel.SuspendLayout();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // departmentComboBox
            // 
            departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentComboBox.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(155, 259);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(309, 33);
            departmentComboBox.TabIndex = 29;
            // 
            // FlowLayoutPanel2
            // 
            FlowLayoutPanel2.BackColor = Color.Snow;
            FlowLayoutPanel2.Controls.Add(_companyNameShapedLabel);
            FlowLayoutPanel2.Controls.Add(_containerWeightShapedLabel);
            FlowLayoutPanel2.Controls.Add(_bookingStatusShapedLabel);
            FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel2.Location = new Point(56, 176);
            FlowLayoutPanel2.Margin = new Padding(0);
            FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            FlowLayoutPanel2.Size = new Size(1663, 30);
            FlowLayoutPanel2.TabIndex = 17;
            // 
            // companyNameShapedLabel
            // 
            _companyNameShapedLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _companyNameShapedLabel.BorderColor = Color.Transparent;
            _companyNameShapedLabel.Edge = 30;
            _companyNameShapedLabel.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            _companyNameShapedLabel.ForeColor = Color.White;
            _companyNameShapedLabel.Location = new Point(3, 0);
            _companyNameShapedLabel.Name = "_companyNameShapedLabel";
            _companyNameShapedLabel.Padding = new Padding(5);
            _companyNameShapedLabel.Size = new Size(176, 29);
            _companyNameShapedLabel.TabIndex = 15;
            _companyNameShapedLabel.Text = "#company_name#";
            _companyNameShapedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // containerWeightShapedLabel
            // 
            _containerWeightShapedLabel.BackColor = Color.Green;
            _containerWeightShapedLabel.BorderColor = Color.Transparent;
            _containerWeightShapedLabel.Edge = 30;
            _containerWeightShapedLabel.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            _containerWeightShapedLabel.ForeColor = Color.White;
            _containerWeightShapedLabel.Location = new Point(185, 0);
            _containerWeightShapedLabel.Name = "_containerWeightShapedLabel";
            _containerWeightShapedLabel.Padding = new Padding(5);
            _containerWeightShapedLabel.Size = new Size(184, 29);
            _containerWeightShapedLabel.TabIndex = 18;
            _containerWeightShapedLabel.Text = "#container_weight#";
            _containerWeightShapedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bookingStatusShapedLabel
            // 
            _bookingStatusShapedLabel.BackColor = Color.Gray;
            _bookingStatusShapedLabel.BorderColor = Color.Transparent;
            _bookingStatusShapedLabel.Edge = 30;
            _bookingStatusShapedLabel.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            _bookingStatusShapedLabel.ForeColor = Color.White;
            _bookingStatusShapedLabel.Location = new Point(375, 0);
            _bookingStatusShapedLabel.Name = "_bookingStatusShapedLabel";
            _bookingStatusShapedLabel.Padding = new Padding(5);
            _bookingStatusShapedLabel.Size = new Size(178, 29);
            _bookingStatusShapedLabel.TabIndex = 18;
            _bookingStatusShapedLabel.Text = "#booking_status#";
            _bookingStatusShapedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // typeComboBox
            // 
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "Bag Provider", "Consignee", "Customer", "Forwarder", "IPOR", "Shipper", "Shipping Line", "Trucking Company", "Terminal", "Railroad", "Vendor", "Port" });
            typeComboBox.Location = new Point(155, 217);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(309, 33);
            typeComboBox.TabIndex = 28;
            // 
            // TouchButton2
            // 
            _TouchButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _TouchButton2.BevelWidth = Conversions.ToShort(2);
            _TouchButton2.ButtonEnabled = true;
            _TouchButton2.ButtonFontSize = Conversions.ToShort(28);
            _TouchButton2.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            _TouchButton2.Caption = "X";
            _TouchButton2.CaptionStyle = YardTabletControls.TouchButton.StyleOfCaption.FlatCaption;
            _TouchButton2.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _TouchButton2.Location = new Point(1358, 12);
            _TouchButton2.Margin = new Padding(4, 3, 4, 3);
            _TouchButton2.Name = "_TouchButton2";
            _TouchButton2.Size = new Size(58, 56);
            _TouchButton2.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _TouchButton2.TabIndex = 26;
            _TouchButton2.TextColour = Color.White;
            _TouchButton2.TouchButtonColour = Color.Firebrick;
            _TouchButton2.Value = false;
            // 
            // createTemplateTouchButton
            // 
            _createTemplateTouchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _createTemplateTouchButton.BevelWidth = Conversions.ToShort(2);
            _createTemplateTouchButton.ButtonEnabled = true;
            _createTemplateTouchButton.ButtonFontSize = Conversions.ToShort(25);
            _createTemplateTouchButton.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            _createTemplateTouchButton.Caption = "Create Template";
            _createTemplateTouchButton.CaptionStyle = YardTabletControls.TouchButton.StyleOfCaption.FlatCaption;
            _createTemplateTouchButton.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _createTemplateTouchButton.Location = new Point(892, 753);
            _createTemplateTouchButton.Margin = new Padding(4, 3, 4, 3);
            _createTemplateTouchButton.Name = "_createTemplateTouchButton";
            _createTemplateTouchButton.Size = new Size(224, 62);
            _createTemplateTouchButton.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _createTemplateTouchButton.TabIndex = 25;
            _createTemplateTouchButton.TextColour = Color.White;
            _createTemplateTouchButton.TouchButtonColour = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _createTemplateTouchButton.Value = false;
            // 
            // tamplateTitleTextBox
            // 
            _tamplateTitleTextBox.CharacterCasing = CharacterCasing.Upper;
            _tamplateTitleTextBox.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _tamplateTitleTextBox.Location = new Point(155, 3);
            _tamplateTitleTextBox.MaxLength = 400;
            _tamplateTitleTextBox.Name = "_tamplateTitleTextBox";
            _tamplateTitleTextBox.Size = new Size(351, 31);
            _tamplateTitleTextBox.TabIndex = 24;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label11.Location = new Point(3, 214);
            Label11.Name = "Label11";
            Label11.Size = new Size(144, 24);
            Label11.TabIndex = 23;
            Label11.Text = "Company Type:";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label9.Location = new Point(3, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(134, 24);
            Label9.TabIndex = 21;
            Label9.Text = "Template Title:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(59, 233);
            Label1.Name = "Label1";
            Label1.Size = new Size(92, 24);
            Label1.TabIndex = 19;
            Label1.Text = "Message:";
            // 
            // messageRichTextBox
            // 
            _messageRichTextBox.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _messageRichTextBox.Location = new Point(63, 260);
            _messageRichTextBox.Name = "_messageRichTextBox";
            _messageRichTextBox.Size = new Size(562, 449);
            _messageRichTextBox.TabIndex = 18;
            _messageRichTextBox.Text = "";
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 28.14545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1429, 93);
            titleLabel.TabIndex = 27;
            titleLabel.Text = "Create new message template";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label8.Location = new Point(53, 121);
            Label8.Name = "Label8";
            Label8.Size = new Size(57, 24);
            Label8.TabIndex = 20;
            Label8.Text = "Tags:";
            // 
            // containerNumberShapedLabel
            // 
            _containerNumberShapedLabel.BackColor = Color.Teal;
            _containerNumberShapedLabel.BorderColor = Color.Transparent;
            _containerNumberShapedLabel.Edge = 30;
            _containerNumberShapedLabel.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            _containerNumberShapedLabel.ForeColor = Color.White;
            _containerNumberShapedLabel.Location = new Point(3, 0);
            _containerNumberShapedLabel.Name = "_containerNumberShapedLabel";
            _containerNumberShapedLabel.Padding = new Padding(5);
            _containerNumberShapedLabel.Size = new Size(187, 29);
            _containerNumberShapedLabel.TabIndex = 14;
            _containerNumberShapedLabel.Text = "#container_number#";
            _containerNumberShapedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateShapedLabel
            // 
            _dateShapedLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dateShapedLabel.BorderColor = Color.Transparent;
            _dateShapedLabel.Edge = 30;
            _dateShapedLabel.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            _dateShapedLabel.ForeColor = Color.White;
            _dateShapedLabel.Location = new Point(196, 0);
            _dateShapedLabel.Name = "_dateShapedLabel";
            _dateShapedLabel.Padding = new Padding(5);
            _dateShapedLabel.Size = new Size(117, 29);
            _dateShapedLabel.TabIndex = 17;
            _dateShapedLabel.Text = "#date#";
            _dateShapedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bookingNumberShapedLabel
            // 
            _bookingNumberShapedLabel.BackColor = Color.Olive;
            _bookingNumberShapedLabel.BorderColor = Color.Transparent;
            _bookingNumberShapedLabel.Edge = 30;
            _bookingNumberShapedLabel.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            _bookingNumberShapedLabel.ForeColor = Color.White;
            _bookingNumberShapedLabel.Location = new Point(319, 0);
            _bookingNumberShapedLabel.Name = "_bookingNumberShapedLabel";
            _bookingNumberShapedLabel.Padding = new Padding(5);
            _bookingNumberShapedLabel.Size = new Size(178, 29);
            _bookingNumberShapedLabel.TabIndex = 16;
            _bookingNumberShapedLabel.Text = "#booking_number#";
            _bookingNumberShapedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label10.Location = new Point(3, 256);
            Label10.Name = "Label10";
            Label10.Size = new Size(112, 24);
            Label10.TabIndex = 22;
            Label10.Text = "Department:";
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.BackColor = Color.Snow;
            FlowLayoutPanel1.Controls.Add(_containerNumberShapedLabel);
            FlowLayoutPanel1.Controls.Add(_dateShapedLabel);
            FlowLayoutPanel1.Controls.Add(_bookingNumberShapedLabel);
            FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel1.Location = new Point(56, 145);
            FlowLayoutPanel1.Margin = new Padding(0);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(1663, 30);
            FlowLayoutPanel1.TabIndex = 16;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 3;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.08875f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.91125f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38.0f));
            TableLayoutPanel1.Controls.Add(_addActionLabel, 2, 2);
            TableLayoutPanel1.Controls.Add(FlowLayoutPanel4, 1, 2);
            TableLayoutPanel1.Controls.Add(FlowLayoutPanel3, 1, 1);
            TableLayoutPanel1.Controls.Add(departmentComboBox, 1, 4);
            TableLayoutPanel1.Controls.Add(typeComboBox, 1, 3);
            TableLayoutPanel1.Controls.Add(Label10, 0, 4);
            TableLayoutPanel1.Controls.Add(Label11, 0, 3);
            TableLayoutPanel1.Controls.Add(Label2, 0, 1);
            TableLayoutPanel1.Controls.Add(Label9, 0, 0);
            TableLayoutPanel1.Controls.Add(_tamplateTitleTextBox, 1, 0);
            TableLayoutPanel1.Controls.Add(availableTitle, 2, 0);
            TableLayoutPanel1.Controls.Add(Label3, 0, 2);
            TableLayoutPanel1.Controls.Add(_addRuleLabel, 2, 1);
            TableLayoutPanel1.Location = new Point(664, 260);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 5;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.47811f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.95623f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.61953f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.14141f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.46801f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel1.Size = new Size(670, 297);
            TableLayoutPanel1.TabIndex = 41;
            // 
            // addActionLabel
            // 
            _addActionLabel.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _addActionLabel.ForeColor = Color.White;
            _addActionLabel.ImageIndex = 0;
            _addActionLabel.ImageList = ImageList1;
            _addActionLabel.Location = new Point(631, 129);
            _addActionLabel.Margin = new Padding(0);
            _addActionLabel.Name = "_addActionLabel";
            _addActionLabel.Size = new Size(33, 34);
            _addActionLabel.TabIndex = 44;
            _addActionLabel.Text = "+";
            _addActionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "blueBall.png");
            ImageList1.Images.SetKeyName(1, "settings.png");
            ImageList1.Images.SetKeyName(2, "pencil.png");
            // 
            // FlowLayoutPanel4
            // 
            FlowLayoutPanel4.AutoScroll = true;
            FlowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
            FlowLayoutPanel4.Controls.Add(ShapedLabelAction1);
            FlowLayoutPanel4.Controls.Add(ShapedLabelAction2);
            FlowLayoutPanel4.Controls.Add(ShapedLabelAction3);
            FlowLayoutPanel4.Controls.Add(ShapedLabelAction4);
            FlowLayoutPanel4.Controls.Add(ShapedLabelAction5);
            FlowLayoutPanel4.Controls.Add(ShapedLabelAction6);
            FlowLayoutPanel4.Location = new Point(155, 132);
            FlowLayoutPanel4.Name = "FlowLayoutPanel4";
            FlowLayoutPanel4.Size = new Size(473, 79);
            FlowLayoutPanel4.TabIndex = 44;
            // 
            // ShapedLabelAction1
            // 
            ShapedLabelAction1.AutoSize = true;
            ShapedLabelAction1.BackColor = Color.Green;
            ShapedLabelAction1.BorderColor = Color.Transparent;
            ShapedLabelAction1.Edge = 30;
            ShapedLabelAction1.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            ShapedLabelAction1.ForeColor = Color.White;
            ShapedLabelAction1.Location = new Point(3, 0);
            ShapedLabelAction1.Name = "ShapedLabelAction1";
            ShapedLabelAction1.Padding = new Padding(5);
            ShapedLabelAction1.Size = new Size(68, 30);
            ShapedLabelAction1.TabIndex = 18;
            ShapedLabelAction1.Text = "action";
            ShapedLabelAction1.TextAlign = ContentAlignment.MiddleCenter;
            ShapedLabelAction1.Visible = false;
            // 
            // ShapedLabelAction2
            // 
            ShapedLabelAction2.AutoSize = true;
            ShapedLabelAction2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ShapedLabelAction2.BorderColor = Color.Transparent;
            ShapedLabelAction2.Edge = 30;
            ShapedLabelAction2.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            ShapedLabelAction2.ForeColor = Color.White;
            ShapedLabelAction2.Location = new Point(77, 0);
            ShapedLabelAction2.Name = "ShapedLabelAction2";
            ShapedLabelAction2.Padding = new Padding(5);
            ShapedLabelAction2.Size = new Size(68, 30);
            ShapedLabelAction2.TabIndex = 17;
            ShapedLabelAction2.Text = "action";
            ShapedLabelAction2.TextAlign = ContentAlignment.MiddleCenter;
            ShapedLabelAction2.Visible = false;
            // 
            // ShapedLabelAction3
            // 
            ShapedLabelAction3.AutoSize = true;
            ShapedLabelAction3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ShapedLabelAction3.BorderColor = Color.Transparent;
            ShapedLabelAction3.Edge = 30;
            ShapedLabelAction3.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            ShapedLabelAction3.ForeColor = Color.White;
            ShapedLabelAction3.Location = new Point(151, 0);
            ShapedLabelAction3.Name = "ShapedLabelAction3";
            ShapedLabelAction3.Padding = new Padding(5);
            ShapedLabelAction3.Size = new Size(68, 30);
            ShapedLabelAction3.TabIndex = 19;
            ShapedLabelAction3.Text = "action";
            ShapedLabelAction3.TextAlign = ContentAlignment.MiddleCenter;
            ShapedLabelAction3.Visible = false;
            // 
            // ShapedLabelAction4
            // 
            ShapedLabelAction4.AutoSize = true;
            ShapedLabelAction4.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)));
            ShapedLabelAction4.BorderColor = Color.Transparent;
            ShapedLabelAction4.Edge = 30;
            ShapedLabelAction4.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            ShapedLabelAction4.ForeColor = Color.White;
            ShapedLabelAction4.Location = new Point(225, 0);
            ShapedLabelAction4.Name = "ShapedLabelAction4";
            ShapedLabelAction4.Padding = new Padding(5);
            ShapedLabelAction4.Size = new Size(68, 30);
            ShapedLabelAction4.TabIndex = 20;
            ShapedLabelAction4.Text = "action";
            ShapedLabelAction4.TextAlign = ContentAlignment.MiddleCenter;
            ShapedLabelAction4.Visible = false;
            // 
            // ShapedLabelAction5
            // 
            ShapedLabelAction5.AutoSize = true;
            ShapedLabelAction5.BackColor = Color.Teal;
            ShapedLabelAction5.BorderColor = Color.Transparent;
            ShapedLabelAction5.Edge = 30;
            ShapedLabelAction5.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            ShapedLabelAction5.ForeColor = Color.White;
            ShapedLabelAction5.Location = new Point(299, 0);
            ShapedLabelAction5.Name = "ShapedLabelAction5";
            ShapedLabelAction5.Padding = new Padding(5);
            ShapedLabelAction5.Size = new Size(68, 30);
            ShapedLabelAction5.TabIndex = 21;
            ShapedLabelAction5.Text = "action";
            ShapedLabelAction5.TextAlign = ContentAlignment.MiddleCenter;
            ShapedLabelAction5.Visible = false;
            // 
            // ShapedLabelAction6
            // 
            ShapedLabelAction6.AutoSize = true;
            ShapedLabelAction6.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            ShapedLabelAction6.BorderColor = Color.Transparent;
            ShapedLabelAction6.Edge = 30;
            ShapedLabelAction6.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            ShapedLabelAction6.ForeColor = Color.White;
            ShapedLabelAction6.Location = new Point(373, 0);
            ShapedLabelAction6.Name = "ShapedLabelAction6";
            ShapedLabelAction6.Padding = new Padding(5);
            ShapedLabelAction6.Size = new Size(68, 30);
            ShapedLabelAction6.TabIndex = 22;
            ShapedLabelAction6.Text = "action";
            ShapedLabelAction6.TextAlign = ContentAlignment.MiddleCenter;
            ShapedLabelAction6.Visible = false;
            // 
            // FlowLayoutPanel3
            // 
            FlowLayoutPanel3.AutoScroll = true;
            FlowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            FlowLayoutPanel3.Controls.Add(ShapedLabelRule2);
            FlowLayoutPanel3.Controls.Add(ShapedLabelRule1);
            FlowLayoutPanel3.Controls.Add(ShapedLabelRule3);
            FlowLayoutPanel3.Controls.Add(ShapedLabelRule4);
            FlowLayoutPanel3.Controls.Add(ShapedLabelRule5);
            FlowLayoutPanel3.Controls.Add(ShapedLabelRule6);
            FlowLayoutPanel3.Dock = DockStyle.Fill;
            FlowLayoutPanel3.Location = new Point(155, 46);
            FlowLayoutPanel3.Name = "FlowLayoutPanel3";
            FlowLayoutPanel3.Size = new Size(473, 80);
            FlowLayoutPanel3.TabIndex = 43;
            // 
            // ShapedLabelRule2
            // 
            ShapedLabelRule2.AutoSize = true;
            ShapedLabelRule2.BackColor = Color.Green;
            ShapedLabelRule2.BorderColor = Color.Transparent;
            ShapedLabelRule2.Edge = 30;
            ShapedLabelRule2.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            ShapedLabelRule2.ForeColor = Color.White;
            ShapedLabelRule2.Location = new Point(3, 0);
            ShapedLabelRule2.Name = "ShapedLabelRule2";
            ShapedLabelRule2.Padding = new Padding(5);
            ShapedLabelRule2.Size = new Size(59, 30);
            ShapedLabelRule2.TabIndex = 18;
            ShapedLabelRule2.Text = "rule1";
            ShapedLabelRule2.TextAlign = ContentAlignment.MiddleCenter;
            ShapedLabelRule2.Visible = false;
            // 
            // ShapedLabelRule1
            // 
            ShapedLabelRule1.AutoSize = true;
            ShapedLabelRule1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ShapedLabelRule1.BorderColor = Color.Transparent;
            ShapedLabelRule1.Edge = 30;
            ShapedLabelRule1.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            ShapedLabelRule1.ForeColor = Color.White;
            ShapedLabelRule1.Location = new Point(68, 0);
            ShapedLabelRule1.Name = "ShapedLabelRule1";
            ShapedLabelRule1.Padding = new Padding(5);
            ShapedLabelRule1.Size = new Size(59, 30);
            ShapedLabelRule1.TabIndex = 17;
            ShapedLabelRule1.Text = "rule1";
            ShapedLabelRule1.TextAlign = ContentAlignment.MiddleCenter;
            ShapedLabelRule1.Visible = false;
            // 
            // ShapedLabelRule3
            // 
            ShapedLabelRule3.AutoSize = true;
            ShapedLabelRule3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ShapedLabelRule3.BorderColor = Color.Transparent;
            ShapedLabelRule3.Edge = 30;
            ShapedLabelRule3.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            ShapedLabelRule3.ForeColor = Color.White;
            ShapedLabelRule3.Location = new Point(133, 0);
            ShapedLabelRule3.Name = "ShapedLabelRule3";
            ShapedLabelRule3.Padding = new Padding(5);
            ShapedLabelRule3.Size = new Size(59, 30);
            ShapedLabelRule3.TabIndex = 19;
            ShapedLabelRule3.Text = "rule1";
            ShapedLabelRule3.TextAlign = ContentAlignment.MiddleCenter;
            ShapedLabelRule3.Visible = false;
            // 
            // ShapedLabelRule4
            // 
            ShapedLabelRule4.AutoSize = true;
            ShapedLabelRule4.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)));
            ShapedLabelRule4.BorderColor = Color.Transparent;
            ShapedLabelRule4.Edge = 30;
            ShapedLabelRule4.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            ShapedLabelRule4.ForeColor = Color.White;
            ShapedLabelRule4.Location = new Point(198, 0);
            ShapedLabelRule4.Name = "ShapedLabelRule4";
            ShapedLabelRule4.Padding = new Padding(5);
            ShapedLabelRule4.Size = new Size(59, 30);
            ShapedLabelRule4.TabIndex = 20;
            ShapedLabelRule4.Text = "rule1";
            ShapedLabelRule4.TextAlign = ContentAlignment.MiddleCenter;
            ShapedLabelRule4.Visible = false;
            // 
            // ShapedLabelRule5
            // 
            ShapedLabelRule5.AutoSize = true;
            ShapedLabelRule5.BackColor = Color.Teal;
            ShapedLabelRule5.BorderColor = Color.Transparent;
            ShapedLabelRule5.Edge = 30;
            ShapedLabelRule5.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            ShapedLabelRule5.ForeColor = Color.White;
            ShapedLabelRule5.Location = new Point(263, 0);
            ShapedLabelRule5.Name = "ShapedLabelRule5";
            ShapedLabelRule5.Padding = new Padding(5);
            ShapedLabelRule5.Size = new Size(59, 30);
            ShapedLabelRule5.TabIndex = 21;
            ShapedLabelRule5.Text = "rule1";
            ShapedLabelRule5.TextAlign = ContentAlignment.MiddleCenter;
            ShapedLabelRule5.Visible = false;
            // 
            // ShapedLabelRule6
            // 
            ShapedLabelRule6.AutoSize = true;
            ShapedLabelRule6.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            ShapedLabelRule6.BorderColor = Color.Transparent;
            ShapedLabelRule6.Edge = 30;
            ShapedLabelRule6.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold);
            ShapedLabelRule6.ForeColor = Color.White;
            ShapedLabelRule6.Location = new Point(328, 0);
            ShapedLabelRule6.Name = "ShapedLabelRule6";
            ShapedLabelRule6.Padding = new Padding(5);
            ShapedLabelRule6.Size = new Size(59, 30);
            ShapedLabelRule6.TabIndex = 22;
            ShapedLabelRule6.Text = "rule1";
            ShapedLabelRule6.TextAlign = ContentAlignment.MiddleCenter;
            ShapedLabelRule6.Visible = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(3, 43);
            Label2.Name = "Label2";
            Label2.Size = new Size(63, 24);
            Label2.TabIndex = 41;
            Label2.Text = "Rules:";
            // 
            // availableTitle
            // 
            // Me.availableTitle.Image = Global.BackEndHR.My.Resources.Resources.icon_available
            availableTitle.Location = new Point(632, 1);
            availableTitle.Margin = new Padding(1);
            availableTitle.Name = "availableTitle";
            availableTitle.Size = new Size(32, 33);
            availableTitle.SizeMode = PictureBoxSizeMode.Zoom;
            availableTitle.TabIndex = 40;
            availableTitle.TabStop = false;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(3, 129);
            Label3.Name = "Label3";
            Label3.Size = new Size(77, 24);
            Label3.TabIndex = 42;
            Label3.Text = "Actions:";
            // 
            // addRuleLabel
            // 
            _addRuleLabel.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _addRuleLabel.ForeColor = Color.White;
            _addRuleLabel.ImageIndex = 0;
            _addRuleLabel.ImageList = ImageList1;
            _addRuleLabel.Location = new Point(631, 43);
            _addRuleLabel.Margin = new Padding(0);
            _addRuleLabel.Name = "_addRuleLabel";
            _addRuleLabel.Size = new Size(33, 34);
            _addRuleLabel.TabIndex = 43;
            _addRuleLabel.Text = "+";
            _addRuleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rulesActionsPanel
            // 
            rulesActionsPanel.BackColor = Color.AliceBlue;
            rulesActionsPanel.BorderStyle = BorderStyle.FixedSingle;
            rulesActionsPanel.Controls.Add(rulesListView);
            rulesActionsPanel.Controls.Add(_Button1);
            rulesActionsPanel.Controls.Add(_editRulesLabel);
            rulesActionsPanel.Controls.Add(Label4);
            rulesActionsPanel.Location = new Point(846, 300);
            rulesActionsPanel.Name = "rulesActionsPanel";
            rulesActionsPanel.Size = new Size(450, 261);
            rulesActionsPanel.TabIndex = 42;
            rulesActionsPanel.Visible = false;
            // 
            // rulesListView
            // 
            rulesListView.CheckBoxes = true;
            rulesListView.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            rulesListView.FullRowSelect = true;
            rulesListView.GridLines = true;
            rulesListView.HeaderStyle = ColumnHeaderStyle.None;
            rulesListView.HideSelection = false;
            rulesListView.Location = new Point(3, 35);
            rulesListView.Name = "rulesListView";
            rulesListView.Size = new Size(442, 182);
            rulesListView.TabIndex = 46;
            rulesListView.UseCompatibleStateImageBehavior = false;
            rulesListView.View = View.Details;
            // 
            // Button1
            // 
            _Button1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _Button1.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _Button1.ForeColor = Color.White;
            _Button1.Location = new Point(181, 221);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(84, 35);
            _Button1.TabIndex = 45;
            _Button1.Text = "Finish";
            _Button1.UseVisualStyleBackColor = false;
            // 
            // editRulesLabel
            // 
            _editRulesLabel.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _editRulesLabel.ForeColor = Color.White;
            _editRulesLabel.ImageIndex = 1;
            _editRulesLabel.ImageList = ImageList1;
            _editRulesLabel.Location = new Point(408, -1);
            _editRulesLabel.Margin = new Padding(0);
            _editRulesLabel.Name = "_editRulesLabel";
            _editRulesLabel.Size = new Size(33, 34);
            _editRulesLabel.TabIndex = 44;
            _editRulesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Navy;
            Label4.BorderStyle = BorderStyle.FixedSingle;
            Label4.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(3, 9);
            Label4.Name = "Label4";
            Label4.Padding = new Padding(0, 0, 0, 10);
            Label4.Size = new Size(98, 36);
            Label4.TabIndex = 1;
            Label4.Text = "Add rules:";
            // 
            // ToolTip1
            // 
            ToolTip1.AutoPopDelay = 5000;
            ToolTip1.BackColor = Color.White;
            ToolTip1.InitialDelay = 300;
            ToolTip1.IsBalloon = true;
            ToolTip1.ReshowDelay = 100;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label5.Location = new Point(59, 22);
            Label5.Name = "Label5";
            Label5.Size = new Size(38, 24);
            Label5.TabIndex = 43;
            Label5.Text = "To:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(59, 60);
            Label6.Name = "Label6";
            Label6.Size = new Size(38, 24);
            Label6.TabIndex = 44;
            Label6.Text = "Cc:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Location = new Point(50, 94);
            Label7.Name = "Label7";
            Label7.Size = new Size(47, 24);
            Label7.TabIndex = 45;
            Label7.Text = "Bcc:";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(TextBox4);
            GroupBox1.Controls.Add(Label15);
            GroupBox1.Controls.Add(Label14);
            GroupBox1.Controls.Add(Label13);
            GroupBox1.Controls.Add(Label12);
            GroupBox1.Controls.Add(TextBox3);
            GroupBox1.Controls.Add(TextBox2);
            GroupBox1.Controls.Add(TextBox1);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Controls.Add(Label6);
            GroupBox1.Location = new Point(664, 580);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(670, 167);
            GroupBox1.TabIndex = 46;
            GroupBox1.TabStop = false;
            // 
            // TextBox1
            // 
            TextBox1.CharacterCasing = CharacterCasing.Upper;
            TextBox1.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox1.Location = new Point(103, 15);
            TextBox1.MaxLength = 400;
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(521, 31);
            TextBox1.TabIndex = 46;
            // 
            // TextBox2
            // 
            TextBox2.CharacterCasing = CharacterCasing.Upper;
            TextBox2.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox2.Location = new Point(103, 52);
            TextBox2.MaxLength = 400;
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(521, 31);
            TextBox2.TabIndex = 47;
            // 
            // TextBox3
            // 
            TextBox3.CharacterCasing = CharacterCasing.Upper;
            TextBox3.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox3.Location = new Point(103, 89);
            TextBox3.MaxLength = 400;
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(521, 31);
            TextBox3.TabIndex = 48;
            // 
            // Label12
            // 
            Label12.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.White;
            Label12.ImageIndex = 0;
            Label12.ImageList = ImageList1;
            Label12.Location = new Point(631, 16);
            Label12.Margin = new Padding(0);
            Label12.Name = "Label12";
            Label12.Size = new Size(33, 34);
            Label12.TabIndex = 49;
            Label12.Text = "+";
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label13
            // 
            Label13.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = Color.White;
            Label13.ImageIndex = 0;
            Label13.ImageList = ImageList1;
            Label13.Location = new Point(631, 52);
            Label13.Margin = new Padding(0);
            Label13.Name = "Label13";
            Label13.Size = new Size(33, 34);
            Label13.TabIndex = 50;
            Label13.Text = "+";
            Label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label14
            // 
            Label14.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.White;
            Label14.ImageIndex = 0;
            Label14.ImageList = ImageList1;
            Label14.Location = new Point(631, 86);
            Label14.Margin = new Padding(0);
            Label14.Name = "Label14";
            Label14.Size = new Size(33, 34);
            Label14.TabIndex = 51;
            Label14.Text = "+";
            Label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBox4
            // 
            TextBox4.CharacterCasing = CharacterCasing.Upper;
            TextBox4.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox4.Location = new Point(103, 130);
            TextBox4.MaxLength = 400;
            TextBox4.Name = "TextBox4";
            TextBox4.Size = new Size(521, 31);
            TextBox4.TabIndex = 53;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label15.Location = new Point(19, 135);
            Label15.Name = "Label15";
            Label15.Size = new Size(78, 24);
            Label15.TabIndex = 52;
            Label15.Text = "Subject:";
            // 
            // FrmCreatePreScript
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1429, 873);
            ControlBox = false;
            Controls.Add(rulesActionsPanel);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(FlowLayoutPanel2);
            Controls.Add(_TouchButton2);
            Controls.Add(_createTemplateTouchButton);
            Controls.Add(Label1);
            Controls.Add(_messageRichTextBox);
            Controls.Add(titleLabel);
            Controls.Add(Label8);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(GroupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCreatePreScript";
            StartPosition = FormStartPosition.CenterScreen;
            FlowLayoutPanel2.ResumeLayout(false);
            FlowLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            FlowLayoutPanel4.ResumeLayout(false);
            FlowLayoutPanel4.PerformLayout();
            FlowLayoutPanel3.ResumeLayout(false);
            FlowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)availableTitle).EndInit();
            rulesActionsPanel.ResumeLayout(false);
            rulesActionsPanel.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            Load += new EventHandler(FrmCreatePreScript_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal ComboBox departmentComboBox;
        internal FlowLayoutPanel FlowLayoutPanel2;
        private CustomizedControlsLibrary.ShapedLabel _companyNameShapedLabel;

        internal CustomizedControlsLibrary.ShapedLabel companyNameShapedLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _companyNameShapedLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_companyNameShapedLabel != null)
                {
                    _companyNameShapedLabel.Click -= companyNameShapedLabel_Click;
                }

                _companyNameShapedLabel = value;
                if (_companyNameShapedLabel != null)
                {
                    _companyNameShapedLabel.Click += companyNameShapedLabel_Click;
                }
            }
        }

        private CustomizedControlsLibrary.ShapedLabel _containerWeightShapedLabel;

        internal CustomizedControlsLibrary.ShapedLabel containerWeightShapedLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _containerWeightShapedLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_containerWeightShapedLabel != null)
                {
                    _containerWeightShapedLabel.Click -= containerWeightShapedLabel_Click;
                }

                _containerWeightShapedLabel = value;
                if (_containerWeightShapedLabel != null)
                {
                    _containerWeightShapedLabel.Click += containerWeightShapedLabel_Click;
                }
            }
        }

        private CustomizedControlsLibrary.ShapedLabel _bookingStatusShapedLabel;

        internal CustomizedControlsLibrary.ShapedLabel bookingStatusShapedLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _bookingStatusShapedLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_bookingStatusShapedLabel != null)
                {
                    _bookingStatusShapedLabel.Click -= bookingStatusShapedLabel_Click;
                }

                _bookingStatusShapedLabel = value;
                if (_bookingStatusShapedLabel != null)
                {
                    _bookingStatusShapedLabel.Click += bookingStatusShapedLabel_Click;
                }
            }
        }

        internal ComboBox typeComboBox;
        private YardTabletControls.TouchButton _TouchButton2;

        internal YardTabletControls.TouchButton TouchButton2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TouchButton2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TouchButton2 != null)
                {
                    _TouchButton2.ButtonClick -= TouchButton2_Load;
                }

                _TouchButton2 = value;
                if (_TouchButton2 != null)
                {
                    _TouchButton2.ButtonClick += TouchButton2_Load;
                }
            }
        }

        private YardTabletControls.TouchButton _createTemplateTouchButton;

        internal YardTabletControls.TouchButton createTemplateTouchButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _createTemplateTouchButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_createTemplateTouchButton != null)
                {
                    _createTemplateTouchButton.ButtonClick -= createTemplateTouchButton_Load;
                }

                _createTemplateTouchButton = value;
                if (_createTemplateTouchButton != null)
                {
                    _createTemplateTouchButton.ButtonClick += createTemplateTouchButton_Load;
                }
            }
        }

        private TextBox _tamplateTitleTextBox;

        internal TextBox tamplateTitleTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tamplateTitleTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tamplateTitleTextBox != null)
                {
                    _tamplateTitleTextBox.TextChanged -= tamplateTitleTextBox_TextChanged;
                }

                _tamplateTitleTextBox = value;
                if (_tamplateTitleTextBox != null)
                {
                    _tamplateTitleTextBox.TextChanged += tamplateTitleTextBox_TextChanged;
                }
            }
        }

        internal Label Label11;
        internal Label Label9;
        internal Label Label1;
        private RichTextBox _messageRichTextBox;

        internal RichTextBox messageRichTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _messageRichTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_messageRichTextBox != null)
                {
                    _messageRichTextBox.TextChanged -= messageRichTextBox_TextChanged;
                }

                _messageRichTextBox = value;
                if (_messageRichTextBox != null)
                {
                    _messageRichTextBox.TextChanged += messageRichTextBox_TextChanged;
                }
            }
        }

        internal Label titleLabel;
        internal Label Label8;
        private CustomizedControlsLibrary.ShapedLabel _containerNumberShapedLabel;

        internal CustomizedControlsLibrary.ShapedLabel containerNumberShapedLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _containerNumberShapedLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_containerNumberShapedLabel != null)
                {
                    _containerNumberShapedLabel.Click -= containerNumberShapedLabel_Click;
                }

                _containerNumberShapedLabel = value;
                if (_containerNumberShapedLabel != null)
                {
                    _containerNumberShapedLabel.Click += containerNumberShapedLabel_Click;
                }
            }
        }

        private CustomizedControlsLibrary.ShapedLabel _dateShapedLabel;

        internal CustomizedControlsLibrary.ShapedLabel dateShapedLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dateShapedLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dateShapedLabel != null)
                {
                    _dateShapedLabel.Click -= dateShapedLabel_Click;
                }

                _dateShapedLabel = value;
                if (_dateShapedLabel != null)
                {
                    _dateShapedLabel.Click += dateShapedLabel_Click;
                }
            }
        }

        private CustomizedControlsLibrary.ShapedLabel _bookingNumberShapedLabel;

        internal CustomizedControlsLibrary.ShapedLabel bookingNumberShapedLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _bookingNumberShapedLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_bookingNumberShapedLabel != null)
                {
                    _bookingNumberShapedLabel.Click -= bookingNumberShapedLabel_Click;
                }

                _bookingNumberShapedLabel = value;
                if (_bookingNumberShapedLabel != null)
                {
                    _bookingNumberShapedLabel.Click += bookingNumberShapedLabel_Click;
                }
            }
        }

        internal Label Label10;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal PictureBox availableTitle;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Label Label3;
        internal Label Label2;
        private Label _addRuleLabel;

        internal Label addRuleLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _addRuleLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_addRuleLabel != null)
                {
                    _addRuleLabel.Click -= addRuleLabel_Click;
                }

                _addRuleLabel = value;
                if (_addRuleLabel != null)
                {
                    _addRuleLabel.Click += addRuleLabel_Click;
                }
            }
        }

        internal ImageList ImageList1;
        internal Panel rulesActionsPanel;
        internal Label Label4;
        private Label _editRulesLabel;

        internal Label editRulesLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _editRulesLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_editRulesLabel != null)
                {
                    _editRulesLabel.Click -= editRulesLabel_Click;
                }

                _editRulesLabel = value;
                if (_editRulesLabel != null)
                {
                    _editRulesLabel.Click += editRulesLabel_Click;
                }
            }
        }

        internal ToolTip ToolTip1;
        internal ListView rulesListView;
        private Button _Button1;

        internal Button Button1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button1 != null)
                {
                    _Button1.Click -= Button1_Click;
                }

                _Button1 = value;
                if (_Button1 != null)
                {
                    _Button1.Click += Button1_Click;
                }
            }
        }

        internal CustomizedControlsLibrary.ShapedLabel ShapedLabelRule1;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabelRule6;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabelRule5;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabelRule4;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabelRule3;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabelRule2;
        internal FlowLayoutPanel FlowLayoutPanel3;
        internal FlowLayoutPanel FlowLayoutPanel4;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabelAction1;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabelAction2;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabelAction3;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabelAction4;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabelAction5;
        internal CustomizedControlsLibrary.ShapedLabel ShapedLabelAction6;
        private Label _addActionLabel;

        internal Label addActionLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _addActionLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_addActionLabel != null)
                {
                    _addActionLabel.Click -= addActionLabel_Click;
                }

                _addActionLabel = value;
                if (_addActionLabel != null)
                {
                    _addActionLabel.Click += addActionLabel_Click;
                }
            }
        }

        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal GroupBox GroupBox1;
        internal Label Label14;
        internal Label Label13;
        internal Label Label12;
        internal TextBox TextBox3;
        internal TextBox TextBox2;
        internal TextBox TextBox1;
        internal TextBox TextBox4;
        internal Label Label15;
    }
}