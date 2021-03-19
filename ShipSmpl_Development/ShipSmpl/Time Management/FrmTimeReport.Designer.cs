using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmTimeReport : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimeReport));
            titleLabel = new Label();
            Label2 = new Label();
            typeReportComboBox = new ComboBox();
            Label3 = new Label();
            fromDateTimePicker1 = new DateTimePicker();
            toDateTimePicker2 = new DateTimePicker();
            Label4 = new Label();
            reportFromListView = new ListView();
            ColumnHeader1 = new ColumnHeader();
            ColumnHeader5 = new ColumnHeader();
            Label5 = new Label();
            Label7 = new Label();
            _comparisonTypeComboBox = new ComboBox();
            _comparisonTypeComboBox.SelectedIndexChanged += new EventHandler(comparisonTypeComboBox_SelectedIndexChanged);
            PanelCheckList = new Panel();
            _printButton = new Button();
            _printButton.Click += new EventHandler(printButton_Click);
            ImageList = new ImageList(components);
            PrintDialog1 = new PrintDialog();
            _PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            _PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDocument1_PrintPage);
            yardComboBox = new ComboBox();
            Label1 = new Label();
            GroupBox1 = new GroupBox();
            GroupBox2 = new GroupBox();
            CheckedListBox1 = new CheckedListBox();
            PanelCheckList.SuspendLayout();
            GroupBox1.SuspendLayout();
            GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Microsoft Sans Serif", 26.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Padding = new Padding(30, 0, 30, 0);
            titleLabel.Size = new Size(1008, 92);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Hours worked comparison report";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.Black;
            Label2.Location = new Point(66, 132);
            Label2.Name = "Label2";
            Label2.Size = new Size(152, 25);
            Label2.TabIndex = 1;
            Label2.Text = "Type of report:";
            // 
            // typeReportComboBox
            // 
            typeReportComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeReportComboBox.Enabled = false;
            typeReportComboBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            typeReportComboBox.FormattingEnabled = true;
            typeReportComboBox.Items.AddRange(new object[] { "HOURS WORKED COMPARISON REPORT" });
            typeReportComboBox.Location = new Point(241, 125);
            typeReportComboBox.Name = "typeReportComboBox";
            typeReportComboBox.Size = new Size(406, 32);
            typeReportComboBox.TabIndex = 2;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.Black;
            Label3.Location = new Point(665, 125);
            Label3.Name = "Label3";
            Label3.Size = new Size(67, 25);
            Label3.TabIndex = 3;
            Label3.Text = "From:";
            // 
            // fromDateTimePicker1
            // 
            fromDateTimePicker1.CustomFormat = "MMM dd, yyyy";
            fromDateTimePicker1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            fromDateTimePicker1.Format = DateTimePickerFormat.Custom;
            fromDateTimePicker1.Location = new Point(738, 119);
            fromDateTimePicker1.Name = "fromDateTimePicker1";
            fromDateTimePicker1.Size = new Size(200, 31);
            fromDateTimePicker1.TabIndex = 4;
            // 
            // toDateTimePicker2
            // 
            toDateTimePicker2.CustomFormat = "MMM dd, yyyy";
            toDateTimePicker2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            toDateTimePicker2.Format = DateTimePickerFormat.Custom;
            toDateTimePicker2.Location = new Point(738, 166);
            toDateTimePicker2.Name = "toDateTimePicker2";
            toDateTimePicker2.Size = new Size(200, 31);
            toDateTimePicker2.TabIndex = 6;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.Black;
            Label4.Location = new Point(689, 172);
            Label4.Name = "Label4";
            Label4.Size = new Size(43, 25);
            Label4.TabIndex = 5;
            Label4.Text = "To:";
            // 
            // reportFromListView
            // 
            reportFromListView.Columns.AddRange(new ColumnHeader[] { ColumnHeader1, ColumnHeader5 });
            reportFromListView.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            reportFromListView.FullRowSelect = true;
            reportFromListView.HideSelection = false;
            reportFromListView.Location = new Point(19, 35);
            reportFromListView.MultiSelect = false;
            reportFromListView.Name = "reportFromListView";
            reportFromListView.Size = new Size(520, 162);
            reportFromListView.TabIndex = 41;
            reportFromListView.UseCompatibleStateImageBehavior = false;
            reportFromListView.View = View.Details;
            // 
            // ColumnHeader1
            // 
            ColumnHeader1.Text = "Employee Name";
            ColumnHeader1.Width = 500;
            // 
            // ColumnHeader5
            // 
            ColumnHeader5.Text = "";
            ColumnHeader5.Width = 0;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.Black;
            Label5.Location = new Point(17, 35);
            Label5.Name = "Label5";
            Label5.Size = new Size(0, 25);
            Label5.TabIndex = 42;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.Black;
            Label7.Location = new Point(31, 166);
            Label7.Name = "Label7";
            Label7.Size = new Size(187, 25);
            Label7.TabIndex = 45;
            Label7.Text = "Comparison Type:";
            // 
            // comparisonTypeComboBox
            // 
            _comparisonTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _comparisonTypeComboBox.Enabled = false;
            _comparisonTypeComboBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _comparisonTypeComboBox.FormattingEnabled = true;
            _comparisonTypeComboBox.Items.AddRange(new object[] { "COMPARE TO ANOTHER EMPLOYEE", "COMPRATE TO ALL EMPLOYEES" });
            _comparisonTypeComboBox.Location = new Point(241, 165);
            _comparisonTypeComboBox.Name = "_comparisonTypeComboBox";
            _comparisonTypeComboBox.Size = new Size(343, 32);
            _comparisonTypeComboBox.TabIndex = 46;
            // 
            // PanelCheckList
            // 
            PanelCheckList.Controls.Add(CheckedListBox1);
            PanelCheckList.Location = new Point(22, 73);
            PanelCheckList.Name = "PanelCheckList";
            PanelCheckList.Size = new Size(575, 185);
            PanelCheckList.TabIndex = 47;
            // 
            // printButton
            // 
            _printButton.BackColor = Color.Gainsboro;
            _printButton.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _printButton.ForeColor = Color.DarkSlateGray;
            _printButton.ImageAlign = ContentAlignment.MiddleLeft;
            _printButton.ImageIndex = 1;
            _printButton.ImageList = ImageList;
            _printButton.Location = new Point(738, 296);
            _printButton.Margin = new Padding(2);
            _printButton.Name = "_printButton";
            _printButton.Padding = new Padding(2);
            _printButton.Size = new Size(200, 60);
            _printButton.TabIndex = 56;
            _printButton.Text = "  Print report";
            _printButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            _printButton.UseVisualStyleBackColor = false;
            // 
            // ImageList
            // 
            ImageList.ImageStream = (ImageListStreamer)resources.GetObject("ImageList.ImageStream");
            ImageList.TransparentColor = Color.Transparent;
            ImageList.Images.SetKeyName(0, "pngfind.com-excel-logo-png-383338.png");
            ImageList.Images.SetKeyName(1, "print-icon.png");
            ImageList.Images.SetKeyName(2, "holiday.png");
            // 
            // PrintDialog1
            // 
            PrintDialog1.UseEXDialog = true;
            // 
            // PrintDocument1
            // 
            // 
            // yardComboBox
            // 
            yardComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yardComboBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            yardComboBox.FormattingEnabled = true;
            yardComboBox.Items.AddRange(new object[] { "Both", "Ewen", "Lindsey" });
            yardComboBox.Location = new Point(99, 41);
            yardComboBox.Name = "yardComboBox";
            yardComboBox.Size = new Size(188, 32);
            yardComboBox.TabIndex = 46;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(29, 48);
            Label1.Name = "Label1";
            Label1.Size = new Size(64, 25);
            Label1.TabIndex = 45;
            Label1.Text = "Yard:";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(reportFromListView);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            GroupBox1.Location = new Point(70, 203);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(551, 217);
            GroupBox1.TabIndex = 57;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Select the employee you wish to get the report from";
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(Label1);
            GroupBox2.Controls.Add(yardComboBox);
            GroupBox2.Controls.Add(PanelCheckList);
            GroupBox2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            GroupBox2.Location = new Point(70, 442);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(683, 274);
            GroupBox2.TabIndex = 58;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Select the type of work you wish to compare";
            // 
            // CheckedListBox1
            // 
            CheckedListBox1.CheckOnClick = true;
            CheckedListBox1.ColumnWidth = 250;
            CheckedListBox1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            CheckedListBox1.FormattingEnabled = true;
            CheckedListBox1.Items.AddRange(new object[] { "Bag to Bag (BAG)", "Bulk to Bag (BGR)", "Bulk to Bulk (BLK)", "Forklift Operator", "Mechanic", "Paperwork", "Repairs", "Shunter Operator", "Reach Stacker", "Tipping", "Warehouse", "Workshop", "Yard Work" });
            CheckedListBox1.Location = new Point(12, 3);
            CheckedListBox1.MultiColumn = true;
            CheckedListBox1.Name = "CheckedListBox1";
            CheckedListBox1.RightToLeft = RightToLeft.No;
            CheckedListBox1.Size = new Size(545, 172);
            CheckedListBox1.TabIndex = 44;
            CheckedListBox1.ThreeDCheckBoxes = true;
            // 
            // FrmTimeReport
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1008, 742);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            Controls.Add(_printButton);
            Controls.Add(_comparisonTypeComboBox);
            Controls.Add(Label7);
            Controls.Add(toDateTimePicker2);
            Controls.Add(Label4);
            Controls.Add(fromDateTimePicker1);
            Controls.Add(Label3);
            Controls.Add(typeReportComboBox);
            Controls.Add(Label2);
            Controls.Add(titleLabel);
            Name = "FrmTimeReport";
            StartPosition = FormStartPosition.CenterScreen;
            PanelCheckList.ResumeLayout(false);
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            Load += new EventHandler(FrmTimeReport_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label titleLabel;
        internal Label Label2;
        internal ComboBox typeReportComboBox;
        internal Label Label3;
        internal DateTimePicker fromDateTimePicker1;
        internal DateTimePicker toDateTimePicker2;
        internal Label Label4;
        internal ListView reportFromListView;
        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader ColumnHeader5;
        internal Label Label5;
        internal Label Label7;
        private ComboBox _comparisonTypeComboBox;

        internal ComboBox comparisonTypeComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _comparisonTypeComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_comparisonTypeComboBox != null)
                {
                    _comparisonTypeComboBox.SelectedIndexChanged -= comparisonTypeComboBox_SelectedIndexChanged;
                }

                _comparisonTypeComboBox = value;
                if (_comparisonTypeComboBox != null)
                {
                    _comparisonTypeComboBox.SelectedIndexChanged += comparisonTypeComboBox_SelectedIndexChanged;
                }
            }
        }

        internal Panel PanelCheckList;
        private Button _printButton;

        internal Button printButton
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

        internal ImageList ImageList;
        internal PrintDialog PrintDialog1;
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

        internal ComboBox yardComboBox;
        internal Label Label1;
        internal GroupBox GroupBox1;
        internal GroupBox GroupBox2;
        internal CheckedListBox CheckedListBox1;
    }
}