using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmHolidays : Form
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
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            TextBox1 = new TextBox();
            DateTimePicker1 = new DateTimePicker();
            _ListView1 = new ListView();
            _ListView1.Click += new EventHandler(ListView1_SelectedIndexChanged);
            ColumnHeader1 = new ColumnHeader();
            ColumnHeader2 = new ColumnHeader();
            ColumnHeader3 = new ColumnHeader();
            Label4 = new Label();
            _saveTouchButton = new YardTabletControls.TouchButton();
            _saveTouchButton.ButtonClick += new YardTabletControls.TouchButton.ButtonClickEventHandler(saveTouchButton_Load);
            _deleteTouchButton = new YardTabletControls.TouchButton();
            _deleteTouchButton.ButtonClick += new YardTabletControls.TouchButton.ButtonClickEventHandler(deleteTouchButton_Load);
            Label5 = new Label();
            TabControl1 = new TabControl();
            tab1 = new TabPage();
            _holidayYearComboBox = new ComboBox();
            _holidayYearComboBox.SelectedIndexChanged += new EventHandler(holidayYearComboBox_SelectedIndexChanged);
            TabPage2 = new TabPage();
            TableLayoutPanel2 = new TableLayoutPanel();
            Label9 = new Label();
            Label11 = new Label();
            _yearComboBox = new ComboBox();
            _yearComboBox.SelectedIndexChanged += new EventHandler(yearComboBox_SelectedIndexChanged);
            _showEmployeesComboBox = new ComboBox();
            _showEmployeesComboBox.SelectedIndexChanged += new EventHandler(showEmployeesComboBox_SelectedIndexChanged);
            _CheckBox1 = new CheckBox();
            _CheckBox1.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            datePickedLabel = new Label();
            _Button2 = new Button();
            _Button2.Click += new EventHandler(Button2_Click);
            Label7 = new Label();
            _ComboBox1 = new ComboBox();
            _ComboBox1.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);
            qualifiedEmployeesListView = new ListView();
            ColumnHeader4 = new ColumnHeader();
            ColumnHeader6 = new ColumnHeader();
            ColumnHeader7 = new ColumnHeader();
            ColumnHeader8 = new ColumnHeader();
            ColumnHeader5 = new ColumnHeader();
            Label6 = new Label();
            TabControl1.SuspendLayout();
            tab1.SuspendLayout();
            TabPage2.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // Button1
            // 
            _Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _Button1.BackColor = Color.Firebrick;
            _Button1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _Button1.ForeColor = Color.White;
            _Button1.Location = new Point(867, 3);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(43, 43);
            _Button1.TabIndex = 2;
            _Button1.Text = "X";
            _Button1.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.BackColor = Color.White;
            Label1.Dock = DockStyle.Top;
            Label1.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(0, 0);
            Label1.Name = "Label1";
            Label1.Padding = new Padding(15, 5, 5, 5);
            Label1.Size = new Size(914, 61);
            Label1.TabIndex = 3;
            Label1.Text = "Holidays";
            Label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(97, 104);
            Label2.Name = "Label2";
            Label2.Size = new Size(70, 26);
            Label2.TabIndex = 4;
            Label2.Text = "Date: ";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(97, 192);
            Label3.Name = "Label3";
            Label3.Size = new Size(152, 26);
            Label3.TabIndex = 5;
            Label3.Text = "Holiday name:";
            // 
            // TextBox1
            // 
            TextBox1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox1.Location = new Point(101, 223);
            TextBox1.MaxLength = 30;
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(303, 32);
            TextBox1.TabIndex = 6;
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.CustomFormat = "MMM dd, yyyy";
            DateTimePicker1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DateTimePicker1.Format = DateTimePickerFormat.Custom;
            DateTimePicker1.Location = new Point(101, 135);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(222, 32);
            DateTimePicker1.TabIndex = 7;
            // 
            // ListView1
            // 
            _ListView1.BackColor = Color.WhiteSmoke;
            _ListView1.Columns.AddRange(new ColumnHeader[] { ColumnHeader1, ColumnHeader2, ColumnHeader3 });
            _ListView1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ListView1.FullRowSelect = true;
            _ListView1.HideSelection = false;
            _ListView1.Location = new Point(469, 131);
            _ListView1.MultiSelect = false;
            _ListView1.Name = "_ListView1";
            _ListView1.Size = new Size(347, 228);
            _ListView1.TabIndex = 8;
            _ListView1.UseCompatibleStateImageBehavior = false;
            _ListView1.View = View.Details;
            // 
            // ColumnHeader1
            // 
            ColumnHeader1.Text = "Holiday name";
            ColumnHeader1.Width = 195;
            // 
            // ColumnHeader2
            // 
            ColumnHeader2.Text = "Date";
            ColumnHeader2.Width = 126;
            // 
            // ColumnHeader3
            // 
            ColumnHeader3.Width = 0;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(465, 104);
            Label4.Name = "Label4";
            Label4.Size = new Size(164, 26);
            Label4.TabIndex = 9;
            Label4.Text = "Saved Holidays";
            // 
            // saveTouchButton
            // 
            _saveTouchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _saveTouchButton.BevelWidth = Conversions.ToShort(2);
            _saveTouchButton.ButtonEnabled = true;
            _saveTouchButton.ButtonFontSize = Conversions.ToShort(22);
            _saveTouchButton.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            _saveTouchButton.Caption = "Save";
            _saveTouchButton.CaptionStyle = YardTabletControls.TouchButton.StyleOfCaption.FlatCaption;
            _saveTouchButton.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _saveTouchButton.Location = new Point(174, 293);
            _saveTouchButton.Margin = new Padding(5, 3, 5, 3);
            _saveTouchButton.Name = "_saveTouchButton";
            _saveTouchButton.Size = new Size(121, 47);
            _saveTouchButton.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _saveTouchButton.TabIndex = 10;
            _saveTouchButton.TextColour = Color.White;
            _saveTouchButton.TouchButtonColour = Color.Olive;
            _saveTouchButton.Value = false;
            // 
            // deleteTouchButton
            // 
            _deleteTouchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _deleteTouchButton.BevelWidth = Conversions.ToShort(2);
            _deleteTouchButton.ButtonEnabled = true;
            _deleteTouchButton.ButtonFontSize = Conversions.ToShort(22);
            _deleteTouchButton.ButtonStyle = YardTabletControls.TouchButton.StyleOFButton.HorizantalStyle;
            _deleteTouchButton.Caption = "Delete";
            _deleteTouchButton.CaptionStyle = YardTabletControls.TouchButton.StyleOfCaption.FlatCaption;
            _deleteTouchButton.Font = new Font("Arial Black", 8.142858f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _deleteTouchButton.Location = new Point(614, 371);
            _deleteTouchButton.Margin = new Padding(5, 3, 5, 3);
            _deleteTouchButton.Name = "_deleteTouchButton";
            _deleteTouchButton.Size = new Size(121, 47);
            _deleteTouchButton.StickyMode = YardTabletControls.TouchButton.ModeOfSticky.StickyOff;
            _deleteTouchButton.TabIndex = 11;
            _deleteTouchButton.TextColour = Color.White;
            _deleteTouchButton.TouchButtonColour = Color.Firebrick;
            _deleteTouchButton.Value = false;
            _deleteTouchButton.Visible = false;
            // 
            // Label5
            // 
            Label5.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label5.Location = new Point(129, 260);
            Label5.Name = "Label5";
            Label5.Size = new Size(254, 20);
            Label5.TabIndex = 12;
            Label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(tab1);
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TabControl1.Location = new Point(0, 64);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(914, 574);
            TabControl1.TabIndex = 13;
            // 
            // tab1
            // 
            tab1.Controls.Add(_holidayYearComboBox);
            tab1.Controls.Add(Label2);
            tab1.Controls.Add(Label5);
            tab1.Controls.Add(Label3);
            tab1.Controls.Add(_deleteTouchButton);
            tab1.Controls.Add(TextBox1);
            tab1.Controls.Add(_saveTouchButton);
            tab1.Controls.Add(DateTimePicker1);
            tab1.Controls.Add(Label4);
            tab1.Controls.Add(_ListView1);
            tab1.Location = new Point(4, 31);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3);
            tab1.Size = new Size(906, 539);
            tab1.TabIndex = 0;
            tab1.Text = "Add Holidays";
            tab1.UseVisualStyleBackColor = true;
            // 
            // holidayYearComboBox
            // 
            _holidayYearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _holidayYearComboBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _holidayYearComboBox.FormattingEnabled = true;
            _holidayYearComboBox.Location = new Point(686, 56);
            _holidayYearComboBox.Name = "_holidayYearComboBox";
            _holidayYearComboBox.Size = new Size(130, 34);
            _holidayYearComboBox.TabIndex = 13;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(TableLayoutPanel2);
            TabPage2.Controls.Add(_yearComboBox);
            TabPage2.Controls.Add(_showEmployeesComboBox);
            TabPage2.Controls.Add(_CheckBox1);
            TabPage2.Controls.Add(datePickedLabel);
            TabPage2.Controls.Add(_Button2);
            TabPage2.Controls.Add(Label7);
            TabPage2.Controls.Add(_ComboBox1);
            TabPage2.Controls.Add(qualifiedEmployeesListView);
            TabPage2.Controls.Add(Label6);
            TabPage2.Location = new Point(4, 31);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(906, 539);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Update Holiday on Timesheets";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 2;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.25f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.75f));
            TableLayoutPanel2.Controls.Add(Label9, 1, 0);
            TableLayoutPanel2.Controls.Add(Label11, 0, 0);
            TableLayoutPanel2.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel2.Location = new Point(602, 469);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.Padding = new Padding(5);
            TableLayoutPanel2.RowCount = 1;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333f));
            TableLayoutPanel2.Size = new Size(279, 36);
            TableLayoutPanel2.TabIndex = 52;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Dock = DockStyle.Fill;
            Label9.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label9.Location = new Point(38, 5);
            Label9.Name = "Label9";
            Label9.Size = new Size(233, 26);
            Label9.TabIndex = 54;
            Label9.Text = "Already received Holiday";
            Label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label11
            // 
            Label11.BackColor = Color.Orange;
            Label11.Dock = DockStyle.Fill;
            Label11.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.Location = new Point(8, 8);
            Label11.Margin = new Padding(3);
            Label11.Name = "Label11";
            Label11.Padding = new Padding(5);
            Label11.Size = new Size(24, 20);
            Label11.TabIndex = 52;
            // 
            // yearComboBox
            // 
            _yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _yearComboBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _yearComboBox.FormattingEnabled = true;
            _yearComboBox.Location = new Point(728, 45);
            _yearComboBox.Name = "_yearComboBox";
            _yearComboBox.Size = new Size(130, 34);
            _yearComboBox.TabIndex = 8;
            // 
            // showEmployeesComboBox
            // 
            _showEmployeesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _showEmployeesComboBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _showEmployeesComboBox.FormattingEnabled = true;
            _showEmployeesComboBox.Items.AddRange(new object[] { "Qualified Employees", "All Employees" });
            _showEmployeesComboBox.Location = new Point(18, 10);
            _showEmployeesComboBox.Name = "_showEmployeesComboBox";
            _showEmployeesComboBox.Size = new Size(212, 34);
            _showEmployeesComboBox.TabIndex = 7;
            // 
            // CheckBox1
            // 
            _CheckBox1.AutoSize = true;
            _CheckBox1.Location = new Point(27, 84);
            _CheckBox1.Name = "_CheckBox1";
            _CheckBox1.Size = new Size(15, 14);
            _CheckBox1.TabIndex = 6;
            _CheckBox1.UseVisualStyleBackColor = true;
            // 
            // datePickedLabel
            // 
            datePickedLabel.BackColor = Color.SeaShell;
            datePickedLabel.BorderStyle = BorderStyle.Fixed3D;
            datePickedLabel.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            datePickedLabel.Location = new Point(578, 198);
            datePickedLabel.Name = "datePickedLabel";
            datePickedLabel.Size = new Size(249, 66);
            datePickedLabel.TabIndex = 5;
            datePickedLabel.Text = "No Holiday selected";
            datePickedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Button2
            // 
            _Button2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _Button2.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _Button2.ForeColor = Color.White;
            _Button2.Location = new Point(578, 313);
            _Button2.Name = "_Button2";
            _Button2.Size = new Size(251, 71);
            _Button2.TabIndex = 4;
            _Button2.Text = "Assign Holiday to Employee's Time Sheet";
            _Button2.UseVisualStyleBackColor = false;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(547, 100);
            Label7.Name = "Label7";
            Label7.Size = new Size(208, 26);
            Label7.TabIndex = 3;
            Label7.Text = "Choose the Holiday:";
            // 
            // ComboBox1
            // 
            _ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBox1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ComboBox1.FormattingEnabled = true;
            _ComboBox1.Location = new Point(551, 127);
            _ComboBox1.Name = "_ComboBox1";
            _ComboBox1.Size = new Size(307, 34);
            _ComboBox1.TabIndex = 2;
            // 
            // qualifiedEmployeesListView
            // 
            qualifiedEmployeesListView.BackColor = SystemColors.InactiveBorder;
            qualifiedEmployeesListView.CheckBoxes = true;
            qualifiedEmployeesListView.Columns.AddRange(new ColumnHeader[] { ColumnHeader4, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader5 });
            qualifiedEmployeesListView.FullRowSelect = true;
            qualifiedEmployeesListView.HideSelection = false;
            qualifiedEmployeesListView.Location = new Point(18, 77);
            qualifiedEmployeesListView.Name = "qualifiedEmployeesListView";
            qualifiedEmployeesListView.Size = new Size(440, 428);
            qualifiedEmployeesListView.TabIndex = 0;
            qualifiedEmployeesListView.UseCompatibleStateImageBehavior = false;
            qualifiedEmployeesListView.View = View.Details;
            // 
            // ColumnHeader4
            // 
            ColumnHeader4.Text = "      Alias";
            ColumnHeader4.Width = 160;
            // 
            // ColumnHeader6
            // 
            ColumnHeader6.Text = "Last Name";
            ColumnHeader6.Width = 160;
            // 
            // ColumnHeader7
            // 
            ColumnHeader7.Text = "Days worked ";
            ColumnHeader7.Width = 110;
            // 
            // ColumnHeader8
            // 
            ColumnHeader8.Text = "";
            ColumnHeader8.Width = 0;
            // 
            // ColumnHeader5
            // 
            ColumnHeader5.Text = "";
            ColumnHeader5.Width = 0;
            // 
            // Label6
            // 
            Label6.BackColor = Color.DarkKhaki;
            Label6.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.Location = new Point(18, 45);
            Label6.Name = "Label6";
            Label6.Padding = new Padding(0, 5, 0, 0);
            Label6.Size = new Size(440, 44);
            Label6.TabIndex = 1;
            Label6.Text = "Qualified employees to receive holiday pay";
            Label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmHolidays
            // 
            AutoScaleDimensions = new SizeF(8.0f, 17.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 638);
            ControlBox = false;
            Controls.Add(TabControl1);
            Controls.Add(_Button1);
            Controls.Add(Label1);
            Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmHolidays";
            StartPosition = FormStartPosition.CenterScreen;
            TabControl1.ResumeLayout(false);
            tab1.ResumeLayout(false);
            tab1.PerformLayout();
            TabPage2.ResumeLayout(false);
            TabPage2.PerformLayout();
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            Load += new EventHandler(FrmHolidays_Load);
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

        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal TextBox TextBox1;
        internal DateTimePicker DateTimePicker1;
        private ListView _ListView1;

        internal ListView ListView1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListView1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListView1 != null)
                {
                    _ListView1.Click -= ListView1_SelectedIndexChanged;
                }

                _ListView1 = value;
                if (_ListView1 != null)
                {
                    _ListView1.Click += ListView1_SelectedIndexChanged;
                }
            }
        }

        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader ColumnHeader2;
        internal Label Label4;
        private YardTabletControls.TouchButton _saveTouchButton;

        internal YardTabletControls.TouchButton saveTouchButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _saveTouchButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_saveTouchButton != null)
                {
                    _saveTouchButton.ButtonClick -= saveTouchButton_Load;
                }

                _saveTouchButton = value;
                if (_saveTouchButton != null)
                {
                    _saveTouchButton.ButtonClick += saveTouchButton_Load;
                }
            }
        }

        private YardTabletControls.TouchButton _deleteTouchButton;

        internal YardTabletControls.TouchButton deleteTouchButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _deleteTouchButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_deleteTouchButton != null)
                {
                    _deleteTouchButton.ButtonClick -= deleteTouchButton_Load;
                }

                _deleteTouchButton = value;
                if (_deleteTouchButton != null)
                {
                    _deleteTouchButton.ButtonClick += deleteTouchButton_Load;
                }
            }
        }

        internal Label Label5;
        internal ColumnHeader ColumnHeader3;
        internal TabControl TabControl1;
        internal TabPage tab1;
        internal TabPage TabPage2;
        private CheckBox _CheckBox1;

        internal CheckBox CheckBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBox1 != null)
                {
                    _CheckBox1.CheckedChanged -= CheckBox1_CheckedChanged;
                }

                _CheckBox1 = value;
                if (_CheckBox1 != null)
                {
                    _CheckBox1.CheckedChanged += CheckBox1_CheckedChanged;
                }
            }
        }

        internal Label datePickedLabel;
        private Button _Button2;

        internal Button Button2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button2 != null)
                {
                    _Button2.Click -= Button2_Click;
                }

                _Button2 = value;
                if (_Button2 != null)
                {
                    _Button2.Click += Button2_Click;
                }
            }
        }

        internal Label Label7;
        private ComboBox _ComboBox1;

        internal ComboBox ComboBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox1 != null)
                {
                    _ComboBox1.SelectedIndexChanged -= ComboBox1_SelectedIndexChanged;
                }

                _ComboBox1 = value;
                if (_ComboBox1 != null)
                {
                    _ComboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
                }
            }
        }

        internal ListView qualifiedEmployeesListView;
        internal ColumnHeader ColumnHeader4;
        internal ColumnHeader ColumnHeader6;
        internal ColumnHeader ColumnHeader7;
        internal ColumnHeader ColumnHeader8;
        internal Label Label6;
        internal ColumnHeader ColumnHeader5;
        private ComboBox _showEmployeesComboBox;

        internal ComboBox showEmployeesComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _showEmployeesComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_showEmployeesComboBox != null)
                {
                    _showEmployeesComboBox.SelectedIndexChanged -= showEmployeesComboBox_SelectedIndexChanged;
                }

                _showEmployeesComboBox = value;
                if (_showEmployeesComboBox != null)
                {
                    _showEmployeesComboBox.SelectedIndexChanged += showEmployeesComboBox_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _yearComboBox;

        internal ComboBox yearComboBox
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

        private ComboBox _holidayYearComboBox;

        internal ComboBox holidayYearComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _holidayYearComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_holidayYearComboBox != null)
                {
                    _holidayYearComboBox.SelectedIndexChanged -= holidayYearComboBox_SelectedIndexChanged;
                }

                _holidayYearComboBox = value;
                if (_holidayYearComboBox != null)
                {
                    _holidayYearComboBox.SelectedIndexChanged += holidayYearComboBox_SelectedIndexChanged;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel2;
        internal Label Label9;
        internal Label Label11;
    }
}