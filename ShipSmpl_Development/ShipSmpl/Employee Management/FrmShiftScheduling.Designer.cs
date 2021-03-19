using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmShiftScheduling : Form
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
            _Button1 = new Button();
            _Button1.Click += new EventHandler(Button1_Click);
            selectEmpoyeeListView = new ListView();
            ColumnHeader1 = new ColumnHeader();
            ColumnHeader2 = new ColumnHeader();
            ColumnHeader3 = new ColumnHeader();
            idColumnHeader = new ColumnHeader();
            Label1 = new Label();
            payMethodComboBox = new ComboBox();
            Label2 = new Label();
            GroupBox1 = new GroupBox();
            _TouchButton3 = new YardTabletControls.TouchButton();
            _TouchButton3.ButtonClick += new YardTabletControls.TouchButton.ButtonClickEventHandler(TouchButton3_Load);
            jobDescriptionComboBox = new ComboBox();
            Label5 = new Label();
            yardComboBox = new ComboBox();
            Label4 = new Label();
            typeComboBox = new ComboBox();
            Label3 = new Label();
            Label7 = new Label();
            _selectAllCheckBox = new CheckBox();
            _selectAllCheckBox.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            GroupBox2 = new GroupBox();
            testLabel = new Label();
            Label6 = new Label();
            GroupBox3 = new GroupBox();
            Label11 = new Label();
            ComboBox1 = new ComboBox();
            ComboBox6 = new ComboBox();
            Label9 = new Label();
            TabControl1 = new TabControl();
            TabPage0 = new TabPage();
            _scheduleEmployeesTouchButton = new YardTabletControls.TouchButton();
            _scheduleEmployeesTouchButton.ButtonClick += new YardTabletControls.TouchButton.ButtonClickEventHandler(scheduleEmployeesTouchButton_Load);
            TabPage1 = new TabPage();
            TouchButton2 = new YardTabletControls.TouchButton();
            ListView2 = new ListView();
            ColumnHeader5 = new ColumnHeader();
            ColumnHeader6 = new ColumnHeader();
            ColumnHeader8 = new ColumnHeader();
            Label10 = new Label();
            TouchButton1 = new YardTabletControls.TouchButton();
            GroupBox1.SuspendLayout();
            GroupBox2.SuspendLayout();
            GroupBox3.SuspendLayout();
            TabControl1.SuspendLayout();
            TabPage0.SuspendLayout();
            TabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // Button1
            // 
            _Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _Button1.BackColor = Color.Firebrick;
            _Button1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _Button1.ForeColor = Color.White;
            _Button1.Location = new Point(1291, 14);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(37, 37);
            _Button1.TabIndex = 1;
            _Button1.Text = "X";
            _Button1.UseVisualStyleBackColor = false;
            // 
            // selectEmpoyeeListView
            // 
            selectEmpoyeeListView.BackColor = Color.WhiteSmoke;
            selectEmpoyeeListView.CheckBoxes = true;
            selectEmpoyeeListView.Columns.AddRange(new ColumnHeader[] { ColumnHeader1, ColumnHeader2, ColumnHeader3, idColumnHeader });
            selectEmpoyeeListView.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            selectEmpoyeeListView.FullRowSelect = true;
            selectEmpoyeeListView.HideSelection = false;
            selectEmpoyeeListView.Location = new Point(13, 58);
            selectEmpoyeeListView.Name = "selectEmpoyeeListView";
            selectEmpoyeeListView.Size = new Size(567, 347);
            selectEmpoyeeListView.TabIndex = 2;
            selectEmpoyeeListView.UseCompatibleStateImageBehavior = false;
            selectEmpoyeeListView.View = View.Details;
            // 
            // ColumnHeader1
            // 
            ColumnHeader1.Text = "     Alias";
            ColumnHeader1.Width = 165;
            // 
            // ColumnHeader2
            // 
            ColumnHeader2.Text = "First Name";
            ColumnHeader2.Width = 182;
            // 
            // ColumnHeader3
            // 
            ColumnHeader3.Text = "Last Name";
            ColumnHeader3.Width = 184;
            // 
            // idColumnHeader
            // 
            idColumnHeader.Text = "";
            idColumnHeader.Width = 7;
            // 
            // Label1
            // 
            Label1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(13, 29);
            Label1.Name = "Label1";
            Label1.Size = new Size(567, 37);
            Label1.TabIndex = 3;
            Label1.Text = "Select Employees";
            Label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // payMethodComboBox
            // 
            payMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            payMethodComboBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            payMethodComboBox.FormattingEnabled = true;
            payMethodComboBox.Items.AddRange(new object[] { "All", "Hourly", "Salary", "Piece Work/Hour" });
            payMethodComboBox.Location = new Point(365, 27);
            payMethodComboBox.Name = "payMethodComboBox";
            payMethodComboBox.Size = new Size(194, 32);
            payMethodComboBox.TabIndex = 4;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.Black;
            Label2.Location = new Point(262, 33);
            Label2.Name = "Label2";
            Label2.Size = new Size(97, 20);
            Label2.TabIndex = 5;
            Label2.Text = "Pay Method:";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(_TouchButton3);
            GroupBox1.Controls.Add(jobDescriptionComboBox);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(yardComboBox);
            GroupBox1.Controls.Add(Label4);
            GroupBox1.Controls.Add(typeComboBox);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(payMethodComboBox);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            GroupBox1.ForeColor = Color.Black;
            GroupBox1.Location = new Point(81, 97);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(796, 108);
            GroupBox1.TabIndex = 6;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "1 - Filter employees";
            // 
            // TouchButton3
            // 
            _TouchButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _TouchButton3.BevelWidth = Conversions.ToShort(2);
            _TouchButton3.ButtonEnabled = true;
            _TouchButton3.ButtonFontSize = Conversions.ToShort(18);
            _TouchButton3.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            _TouchButton3.Caption = "Update Search";
            _TouchButton3.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _TouchButton3.Location = new Point(645, 56);
            _TouchButton3.Margin = new Padding(4, 3, 4, 3);
            _TouchButton3.Name = "_TouchButton3";
            _TouchButton3.Size = new Size(144, 43);
            _TouchButton3.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _TouchButton3.TabIndex = 14;
            _TouchButton3.TextColour = Color.White;
            _TouchButton3.TouchButtonColour = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _TouchButton3.Value = false;
            // 
            // jobDescriptionComboBox
            // 
            jobDescriptionComboBox.Anchor = AnchorStyles.Left;
            jobDescriptionComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Accounting Manager", "Bag/Bagger Labourer", "Bulk Labourer/Yard Hand ", "IT Junior", "IT Manager", "Logistics Coordinator", "Logistics Manager", "Machine Operator", "Mechanic", "Operations Manager", "Vice President", "Yard Manager" });
            jobDescriptionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            jobDescriptionComboBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            jobDescriptionComboBox.FormattingEnabled = true;
            jobDescriptionComboBox.ItemHeight = 24;
            jobDescriptionComboBox.Items.AddRange(new object[] { "Accounting Assistant", "Accounting Manager", "Bag Labourer", "Bag/Bagger Labourer", "Bagger Labourer", "Bagger Labourer/Yard Hand", "Bulk Labourer", "Bulk Labourer/Yard Hand", "Container Manager", "Forwarding Manager", "IT Junior", "IT Manager", "Logistics Coordinator", "Logistics Manager", "Machine Operator", "Mechanic", "President", "Safety and Risk Manager", "Vice President", "Yard Hand", "Warehouse Labourer", "All" });
            jobDescriptionComboBox.Location = new Point(365, 67);
            jobDescriptionComboBox.Margin = new Padding(2);
            jobDescriptionComboBox.Name = "jobDescriptionComboBox";
            jobDescriptionComboBox.Size = new Size(228, 32);
            jobDescriptionComboBox.TabIndex = 15;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.Black;
            Label5.Location = new Point(237, 74);
            Label5.Name = "Label5";
            Label5.Size = new Size(123, 20);
            Label5.TabIndex = 11;
            Label5.Text = "Job Description:";
            // 
            // yardComboBox
            // 
            yardComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yardComboBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            yardComboBox.FormattingEnabled = true;
            yardComboBox.Items.AddRange(new object[] { "Both", "Ewen", "Lindsey", "All" });
            yardComboBox.Location = new Point(92, 67);
            yardComboBox.Name = "yardComboBox";
            yardComboBox.Size = new Size(121, 32);
            yardComboBox.TabIndex = 8;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.Black;
            Label4.Location = new Point(39, 73);
            Label4.Name = "Label4";
            Label4.Size = new Size(47, 20);
            Label4.TabIndex = 9;
            Label4.Text = "Yard:";
            // 
            // typeComboBox
            // 
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "All", "Crew", "Office" });
            typeComboBox.Location = new Point(92, 27);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(121, 32);
            typeComboBox.TabIndex = 6;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.Black;
            Label3.Location = new Point(39, 33);
            Label3.Name = "Label3";
            Label3.Size = new Size(47, 20);
            Label3.TabIndex = 7;
            Label3.Text = "Type:";

            // Label7
            // 
            Label7.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Dock = DockStyle.Top;
            Label7.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(3, 3);
            Label7.Name = "Label7";
            Label7.Size = new Size(1336, 74);
            Label7.TabIndex = 9;
            Label7.Text = "Shift Scheduling";
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectAllCheckBox
            // 
            _selectAllCheckBox.AutoSize = true;
            _selectAllCheckBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _selectAllCheckBox.Location = new Point(18, 64);
            _selectAllCheckBox.Name = "_selectAllCheckBox";
            _selectAllCheckBox.Size = new Size(15, 14);
            _selectAllCheckBox.TabIndex = 10;
            _selectAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(testLabel);
            GroupBox2.Controls.Add(_selectAllCheckBox);
            GroupBox2.Controls.Add(selectEmpoyeeListView);
            GroupBox2.Controls.Add(Label1);
            GroupBox2.Controls.Add(Label6);
            GroupBox2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold);
            GroupBox2.ForeColor = Color.Black;
            GroupBox2.Location = new Point(81, 224);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(1193, 419);
            GroupBox2.TabIndex = 11;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "2 - Select employees and assign dates";
            // 
            // testLabel
            // 
            testLabel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            testLabel.Location = new Point(753, 312);
            testLabel.Name = "testLabel";
            testLabel.Size = new Size(339, 93);
            testLabel.TabIndex = 12;
            // 
            // Label6
            // 
            Label6.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(740, 29);
            Label6.Name = "Label6";
            Label6.Size = new Size(359, 37);
            Label6.TabIndex = 11;
            Label6.Text = "Select Dates";
            Label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(Label11);
            GroupBox3.Controls.Add(ComboBox1);
            GroupBox3.Controls.Add(ComboBox6);
            GroupBox3.Controls.Add(Label9);
            GroupBox3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold);
            GroupBox3.ForeColor = Color.Black;
            GroupBox3.Location = new Point(81, 658);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(497, 125);
            GroupBox3.TabIndex = 12;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "3 - Select shift type and location";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.Black;
            Label11.Location = new Point(48, 42);
            Label11.Name = "Label11";
            Label11.Size = new Size(80, 20);
            Label11.TabIndex = 14;
            Label11.Text = "Shift type:";
            // 
            // ComboBox1
            // 
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Items.AddRange(new object[] { "Hourly", "Piece Work/Hour" });
            ComboBox1.Location = new Point(134, 36);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(194, 32);
            ComboBox1.TabIndex = 12;
            // 
            // ComboBox6
            // 
            ComboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox6.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ComboBox6.FormattingEnabled = true;
            ComboBox6.Items.AddRange(new object[] { "Ewen", "Lindsey" });
            ComboBox6.Location = new Point(134, 74);
            ComboBox6.Name = "ComboBox6";
            ComboBox6.Size = new Size(121, 32);
            ComboBox6.TabIndex = 8;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.Black;
            Label9.Location = new Point(71, 80);
            Label9.Name = "Label9";
            Label9.Size = new Size(57, 20);
            Label9.TabIndex = 9;
            Label9.Text = "* Yard:";
            // 
            // TabControl1
            // 
            TabControl1.Alignment = TabAlignment.Left;
            TabControl1.Controls.Add(TabPage0);
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Dock = DockStyle.Fill;
            TabControl1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TabControl1.ItemSize = new Size(115, 35);
            TabControl1.Location = new Point(0, 0);
            TabControl1.Multiline = true;
            TabControl1.Name = "TabControl1";
            TabControl1.Padding = new Point(15, 3);
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(1385, 818);
            TabControl1.TabIndex = 14;
            // 
            // TabPage0
            // 
            TabPage0.Controls.Add(_scheduleEmployeesTouchButton);
            TabPage0.Controls.Add(_Button1);
            TabPage0.Controls.Add(Label7);
            TabPage0.Controls.Add(GroupBox1);
            TabPage0.Controls.Add(GroupBox3);
            TabPage0.Controls.Add(GroupBox2);
            TabPage0.Location = new Point(39, 4);
            TabPage0.Name = "TabPage0";
            TabPage0.Padding = new Padding(3);
            TabPage0.Size = new Size(1342, 810);
            TabPage0.TabIndex = 1;
            TabPage0.Text = "Add Shifts";
            TabPage0.UseVisualStyleBackColor = true;
            // 
            // scheduleEmployeesTouchButton
            // 
            _scheduleEmployeesTouchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _scheduleEmployeesTouchButton.BevelWidth = Conversions.ToShort(2);
            _scheduleEmployeesTouchButton.ButtonEnabled = true;
            _scheduleEmployeesTouchButton.ButtonFontSize = Conversions.ToShort(24);
            _scheduleEmployeesTouchButton.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            _scheduleEmployeesTouchButton.Caption = "Schedule Employees";
            _scheduleEmployeesTouchButton.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _scheduleEmployeesTouchButton.Location = new Point(1008, 717);
            _scheduleEmployeesTouchButton.Margin = new Padding(4, 3, 4, 3);
            _scheduleEmployeesTouchButton.Name = "_scheduleEmployeesTouchButton";
            _scheduleEmployeesTouchButton.Size = new Size(266, 56);
            _scheduleEmployeesTouchButton.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _scheduleEmployeesTouchButton.TabIndex = 16;
            _scheduleEmployeesTouchButton.TextColour = Color.White;
            _scheduleEmployeesTouchButton.TouchButtonColour = Color.Olive;
            _scheduleEmployeesTouchButton.Value = false;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(TouchButton2);
            TabPage1.Controls.Add(ListView2);
            TabPage1.Controls.Add(Label10);
            TabPage1.Controls.Add(TouchButton1);
            TabPage1.ForeColor = Color.Green;
            TabPage1.Location = new Point(39, 4);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(1342, 810);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Schedule";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // TouchButton2
            // 
            TouchButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TouchButton2.BevelWidth = Conversions.ToShort(2);
            TouchButton2.ButtonEnabled = true;
            TouchButton2.ButtonFontSize = Conversions.ToShort(28);
            TouchButton2.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            TouchButton2.Caption = ">";
            TouchButton2.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TouchButton2.Location = new Point(816, 154);
            TouchButton2.Margin = new Padding(4, 3, 4, 3);
            TouchButton2.Name = "TouchButton2";
            TouchButton2.Size = new Size(39, 37);
            TouchButton2.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            TouchButton2.TabIndex = 7;
            TouchButton2.TextColour = Color.White;
            TouchButton2.TouchButtonColour = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            TouchButton2.Value = false;
            // 
            // ListView2
            // 
            ListView2.BackColor = Color.WhiteSmoke;
            ListView2.CheckBoxes = true;
            ListView2.Columns.AddRange(new ColumnHeader[] { ColumnHeader5, ColumnHeader6, ColumnHeader8 });
            ListView2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ListView2.FullRowSelect = true;
            ListView2.HideSelection = false;
            ListView2.Location = new Point(70, 222);
            ListView2.Name = "ListView2";
            ListView2.Size = new Size(785, 416);
            ListView2.TabIndex = 4;
            ListView2.UseCompatibleStateImageBehavior = false;
            ListView2.View = View.Details;
            // 
            // ColumnHeader5
            // 
            ColumnHeader5.Text = "";
            ColumnHeader5.TextAlign = HorizontalAlignment.Center;
            ColumnHeader5.Width = 25;
            // 
            // ColumnHeader6
            // 
            ColumnHeader6.Text = "Alias";
            ColumnHeader6.Width = 150;
            // 
            // ColumnHeader8
            // 
            ColumnHeader8.Text = "Last Name";
            ColumnHeader8.Width = 150;
            // 
            // Label10
            // 
            Label10.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label10.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = Color.White;
            Label10.Location = new Point(70, 194);
            Label10.Name = "Label10";
            Label10.Size = new Size(785, 56);
            Label10.TabIndex = 5;
            Label10.Text = "Schedule for Sep 15, 2019";
            Label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // TouchButton1
            // 
            TouchButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TouchButton1.BevelWidth = Conversions.ToShort(2);
            TouchButton1.ButtonEnabled = true;
            TouchButton1.ButtonFontSize = Conversions.ToShort(28);
            TouchButton1.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            TouchButton1.Caption = "<";
            TouchButton1.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TouchButton1.Location = new Point(769, 154);
            TouchButton1.Margin = new Padding(4, 3, 4, 3);
            TouchButton1.Name = "TouchButton1";
            TouchButton1.Size = new Size(39, 37);
            TouchButton1.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            TouchButton1.TabIndex = 6;
            TouchButton1.TextColour = Color.White;
            TouchButton1.TouchButtonColour = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            TouchButton1.Value = false;
            // 
            // FrmShiftScheduling
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1385, 818);
            ControlBox = false;
            Controls.Add(TabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "FrmShiftScheduling";
            StartPosition = FormStartPosition.CenterScreen;
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            TabControl1.ResumeLayout(false);
            TabPage0.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            Load += new EventHandler(FrmShiftScheduling_Load);
            ResumeLayout(false);
        }

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

        internal ListView selectEmpoyeeListView;
        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader ColumnHeader2;
        internal ColumnHeader ColumnHeader3;
        internal Label Label1;
        internal ComboBox payMethodComboBox;
        internal Label Label2;
        internal GroupBox GroupBox1;
        internal ComboBox typeComboBox;
        internal Label Label3;
        internal ComboBox yardComboBox;
        internal Label Label4;
        internal Label Label5;
        internal Label Label7;
        private CheckBox _selectAllCheckBox;

        internal CheckBox selectAllCheckBox
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
                    _selectAllCheckBox.CheckedChanged -= CheckBox1_CheckedChanged;
                }

                _selectAllCheckBox = value;
                if (_selectAllCheckBox != null)
                {
                    _selectAllCheckBox.CheckedChanged += CheckBox1_CheckedChanged;
                }
            }
        }

        internal GroupBox GroupBox2;
        internal Label Label6;
        internal GroupBox GroupBox3;
        internal ComboBox ComboBox6;
        internal Label Label9;
        internal TabControl TabControl1;
        internal TabPage TabPage1;
        internal TabPage TabPage0;
        internal YardTabletControls.TouchButton TouchButton2;
        internal ListView ListView2;
        internal ColumnHeader ColumnHeader5;
        internal ColumnHeader ColumnHeader6;
        internal ColumnHeader ColumnHeader8;
        internal Label Label10;
        internal YardTabletControls.TouchButton TouchButton1;
        internal ColumnHeader idColumnHeader;
        internal ComboBox jobDescriptionComboBox;
        internal Label testLabel;
        internal Label Label11;
        internal ComboBox ComboBox1;
        private YardTabletControls.TouchButton _TouchButton3;

        internal YardTabletControls.TouchButton TouchButton3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TouchButton3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TouchButton3 != null)
                {
                    _TouchButton3.ButtonClick -= TouchButton3_Load;
                }

                _TouchButton3 = value;
                if (_TouchButton3 != null)
                {
                    _TouchButton3.ButtonClick += TouchButton3_Load;
                }
            }
        }

        private YardTabletControls.TouchButton _scheduleEmployeesTouchButton;

        internal YardTabletControls.TouchButton scheduleEmployeesTouchButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _scheduleEmployeesTouchButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_scheduleEmployeesTouchButton != null)
                {
                    _scheduleEmployeesTouchButton.ButtonClick -= scheduleEmployeesTouchButton_Load;
                }

                _scheduleEmployeesTouchButton = value;
                if (_scheduleEmployeesTouchButton != null)
                {
                    _scheduleEmployeesTouchButton.ButtonClick += scheduleEmployeesTouchButton_Load;
                }
            }
        }
    }
}