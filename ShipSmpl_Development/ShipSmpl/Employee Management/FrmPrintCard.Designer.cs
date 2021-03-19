using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmPrintCard : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintCard));
            _employeesListView = new ListView();
            _employeesListView.Click += new EventHandler(reportFromListView_SelectedIndexChanged);
            ColumnHeader1 = new ColumnHeader();
            ColumnHeader5 = new ColumnHeader();
            Splitter1 = new Splitter();
            Label2 = new Label();
            Label3 = new Label();
            _NameTextBox = new TextBox();
            _NameTextBox.TextChanged += new EventHandler(NameTextBox_TextChanged);
            _PositionTextBox = new TextBox();
            _PositionTextBox.TextChanged += new EventHandler(PositionTextBox_TextChanged);
            IDTextBox = new TextBox();
            Label1 = new Label();
            _Button1 = new Button();
            _Button1.Click += new EventHandler(Button1_Click);
            _PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            _PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDocument1_PrintPage);
            PrintDialog1 = new PrintDialog();
            warningLabel = new Label();
            _selectAllCheckBox = new CheckBox();
            _selectAllCheckBox.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            _CheckBox1 = new CheckBox();
            _CheckBox1.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged_1);
            lowerSettingsPanel = new Panel();
            lowPositionLabe = new Label();
            Panel2 = new Panel();
            lowNameLabel = new Label();
            PictureBox4 = new PictureBox();
            lowPictureBox = new PictureBox();
            PictureBox2 = new PictureBox();
            PictureBox1 = new PictureBox();
            lowIdLabel = new Label();
            lowbarcodeLabel = new Label();
            normalSettingPanel = new Panel();
            employeePictureBox = new PictureBox();
            idLabel = new Label();
            barcodeLabel = new Label();
            positionLabel = new Label();
            nameLabel = new Label();
            lowerSettingsPanel.SuspendLayout();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lowPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            normalSettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeePictureBox).BeginInit();
            SuspendLayout();
            // 
            // employeesListView
            // 
            _employeesListView.CheckBoxes = true;
            _employeesListView.Columns.AddRange(new ColumnHeader[] { ColumnHeader1, ColumnHeader5 });
            _employeesListView.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _employeesListView.FullRowSelect = true;
            _employeesListView.HideSelection = false;
            _employeesListView.Location = new Point(27, 38);
            _employeesListView.MultiSelect = false;
            _employeesListView.Name = "_employeesListView";
            _employeesListView.Size = new Size(411, 388);
            _employeesListView.TabIndex = 42;
            _employeesListView.UseCompatibleStateImageBehavior = false;
            _employeesListView.View = View.Details;
            // 
            // ColumnHeader1
            // 
            ColumnHeader1.Text = "    Employee Name";
            ColumnHeader1.Width = 400;
            // 
            // ColumnHeader5
            // 
            ColumnHeader5.Text = "";
            ColumnHeader5.Width = 0;
            // 
            // Splitter1
            // 
            Splitter1.BackColor = Color.Gray;
            Splitter1.BorderStyle = BorderStyle.Fixed3D;
            Splitter1.Dock = DockStyle.Right;
            Splitter1.Location = new Point(462, 0);
            Splitter1.Name = "Splitter1";
            Splitter1.Size = new Size(450, 630);
            Splitter1.TabIndex = 43;
            Splitter1.TabStop = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(64, 532);
            Label2.Name = "Label2";
            Label2.Size = new Size(43, 26);
            Label2.TabIndex = 46;
            Label2.Text = "ID:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(19, 489);
            Label3.Name = "Label3";
            Label3.Size = new Size(105, 26);
            Label3.TabIndex = 47;
            Label3.Text = "Position:";
            // 
            // NameTextBox
            // 
            _NameTextBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _NameTextBox.Location = new Point(114, 446);
            _NameTextBox.Name = "_NameTextBox";
            _NameTextBox.Size = new Size(324, 32);
            _NameTextBox.TabIndex = 48;
            // 
            // PositionTextBox
            // 
            _PositionTextBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _PositionTextBox.Location = new Point(114, 486);
            _PositionTextBox.Name = "_PositionTextBox";
            _PositionTextBox.Size = new Size(324, 32);
            _PositionTextBox.TabIndex = 49;
            // 
            // IDTextBox
            // 
            IDTextBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            IDTextBox.Location = new Point(114, 525);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(141, 32);
            IDTextBox.TabIndex = 50;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(37, 449);
            Label1.Name = "Label1";
            Label1.Size = new Size(82, 26);
            Label1.TabIndex = 45;
            Label1.Text = "Name:";
            // 
            // Button1
            // 
            _Button1.BackColor = Color.White;
            _Button1.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _Button1.ForeColor = Color.Maroon;
            _Button1.Location = new Point(369, 563);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(184, 58);
            _Button1.TabIndex = 51;
            _Button1.Text = "Print";
            _Button1.UseVisualStyleBackColor = false;
            // 
            // PrintDocument1
            // 
            // 
            // PrintDialog1
            // 
            PrintDialog1.UseEXDialog = true;
            // 
            // warningLabel
            // 
            warningLabel.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            warningLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            warningLabel.Location = new Point(12, 9);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(444, 26);
            warningLabel.TabIndex = 52;
            warningLabel.Text = "Please select the employee";
            warningLabel.TextAlign = ContentAlignment.MiddleCenter;
            warningLabel.Visible = false;
            // 
            // selectAllCheckBox
            // 
            _selectAllCheckBox.AutoSize = true;
            _selectAllCheckBox.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _selectAllCheckBox.Location = new Point(35, 48);
            _selectAllCheckBox.Name = "_selectAllCheckBox";
            _selectAllCheckBox.Size = new Size(15, 14);
            _selectAllCheckBox.TabIndex = 53;
            _selectAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckBox1
            // 
            _CheckBox1.AutoSize = true;
            _CheckBox1.BackColor = Color.Gray;
            _CheckBox1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _CheckBox1.ForeColor = Color.White;
            _CheckBox1.Location = new Point(612, 0);
            _CheckBox1.Name = "_CheckBox1";
            _CheckBox1.Size = new Size(197, 28);
            _CheckBox1.TabIndex = 54;
            _CheckBox1.Text = "With punch whole";
            _CheckBox1.UseVisualStyleBackColor = false;
            // 
            // lowerSettingsPanel
            // 
            lowerSettingsPanel.BackColor = Color.Gray;
            lowerSettingsPanel.BackgroundImage = (Image)resources.GetObject("lowerSettingsPanel.BackgroundImage");
            lowerSettingsPanel.BackgroundImageLayout = ImageLayout.Zoom;
            lowerSettingsPanel.Controls.Add(lowPositionLabe);
            lowerSettingsPanel.Controls.Add(Panel2);
            lowerSettingsPanel.Controls.Add(PictureBox1);
            lowerSettingsPanel.Controls.Add(lowIdLabel);
            lowerSettingsPanel.Controls.Add(lowbarcodeLabel);
            lowerSettingsPanel.Location = new Point(497, 30);
            lowerSettingsPanel.Name = "lowerSettingsPanel";
            lowerSettingsPanel.Size = new Size(382, 542);
            lowerSettingsPanel.TabIndex = 45;
            // 
            // lowPositionLabe
            // 
            lowPositionLabe.BackColor = Color.Red;
            lowPositionLabe.Font = new Font("MagistralC", 18.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lowPositionLabe.ForeColor = Color.Black;
            lowPositionLabe.Location = new Point(30, 401);
            lowPositionLabe.Name = "lowPositionLabe";
            lowPositionLabe.Size = new Size(325, 41);
            lowPositionLabe.TabIndex = 56;
            lowPositionLabe.Text = "Software Developer";
            lowPositionLabe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(lowNameLabel);
            Panel2.Controls.Add(PictureBox4);
            Panel2.Controls.Add(lowPictureBox);
            Panel2.Controls.Add(PictureBox2);
            Panel2.Location = new Point(27, 14);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(331, 391);
            Panel2.TabIndex = 54;
            // 
            // lowNameLabel
            // 
            lowNameLabel.BackColor = Color.Red;
            lowNameLabel.Font = new Font("MagistralC", 21.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lowNameLabel.ForeColor = Color.White;
            lowNameLabel.Location = new Point(0, 354);
            lowNameLabel.Name = "lowNameLabel";
            lowNameLabel.Size = new Size(331, 38);
            lowNameLabel.TabIndex = 51;
            lowNameLabel.Text = "Bob Singer";
            lowNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PictureBox4
            // 
            PictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox4.Location = new Point(119, 23);
            PictureBox4.Name = "PictureBox4";
            PictureBox4.Size = new Size(104, 34);
            PictureBox4.TabIndex = 57;
            PictureBox4.TabStop = false;
            // 
            // lowPictureBox
            // 
            lowPictureBox.BackgroundImage = (Image)resources.GetObject("lowPictureBox.BackgroundImage");
            lowPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            lowPictureBox.BorderStyle = BorderStyle.FixedSingle;
            lowPictureBox.Location = new Point(95, 172);
            lowPictureBox.Name = "lowPictureBox";
            lowPictureBox.Size = new Size(150, 176);
            lowPictureBox.TabIndex = 56;
            lowPictureBox.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            PictureBox2.Location = new Point(62, 59);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(208, 116);
            PictureBox2.TabIndex = 0;
            PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImage = (Image)resources.GetObject("PictureBox1.BackgroundImage");
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.BorderStyle = BorderStyle.FixedSingle;
            PictureBox1.Location = new Point(116, 143);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(150, 176);
            PictureBox1.TabIndex = 55;
            PictureBox1.TabStop = false;
            // 
            // lowIdLabel
            // 
            lowIdLabel.BackColor = Color.White;
            lowIdLabel.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lowIdLabel.ForeColor = Color.Red;
            lowIdLabel.Location = new Point(182, 503);
            lowIdLabel.Name = "lowIdLabel";
            lowIdLabel.Size = new Size(94, 23);
            lowIdLabel.TabIndex = 54;
            lowIdLabel.Text = "00025";
            lowIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lowbarcodeLabel
            // 
            lowbarcodeLabel.BackColor = Color.Transparent;
            lowbarcodeLabel.Font = new Font("IDAutomationHC39M", 26.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lowbarcodeLabel.ForeColor = Color.Black;
            lowbarcodeLabel.Location = new Point(46, 452);
            lowbarcodeLabel.Margin = new Padding(0);
            lowbarcodeLabel.Name = "lowbarcodeLabel";
            lowbarcodeLabel.Size = new Size(295, 49);
            lowbarcodeLabel.TabIndex = 53;
            lowbarcodeLabel.Text = "*12345*";
            lowbarcodeLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // normalSettingPanel
            // 
            normalSettingPanel.BackColor = Color.Gray;
            normalSettingPanel.BackgroundImage = (Image)resources.GetObject("normalSettingPanel.BackgroundImage");
            normalSettingPanel.BackgroundImageLayout = ImageLayout.Zoom;
            normalSettingPanel.Controls.Add(employeePictureBox);
            normalSettingPanel.Controls.Add(idLabel);
            normalSettingPanel.Controls.Add(barcodeLabel);
            normalSettingPanel.Controls.Add(positionLabel);
            normalSettingPanel.Controls.Add(nameLabel);
            normalSettingPanel.Location = new Point(496, 29);
            normalSettingPanel.Name = "normalSettingPanel";
            normalSettingPanel.Size = new Size(382, 542);
            normalSettingPanel.TabIndex = 44;
            // 
            // employeePictureBox
            // 
            employeePictureBox.BackgroundImage = (Image)resources.GetObject("employeePictureBox.BackgroundImage");
            employeePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            employeePictureBox.BorderStyle = BorderStyle.FixedSingle;
            employeePictureBox.Location = new Point(116, 143);
            employeePictureBox.Name = "employeePictureBox";
            employeePictureBox.Size = new Size(150, 176);
            employeePictureBox.TabIndex = 55;
            employeePictureBox.TabStop = false;
            // 
            // idLabel
            // 
            idLabel.BackColor = Color.White;
            idLabel.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            idLabel.ForeColor = Color.Red;
            idLabel.Location = new Point(182, 503);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(94, 23);
            idLabel.TabIndex = 54;
            idLabel.Text = "00025";
            idLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // barcodeLabel
            // 
            barcodeLabel.BackColor = Color.Transparent;
            barcodeLabel.Font = new Font("IDAutomationHC39M", 26.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            barcodeLabel.ForeColor = Color.Black;
            barcodeLabel.Location = new Point(46, 452);
            barcodeLabel.Margin = new Padding(0);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new Size(295, 49);
            barcodeLabel.TabIndex = 53;
            barcodeLabel.Text = "*12345*";
            barcodeLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // positionLabel
            // 
            positionLabel.BackColor = Color.Red;
            positionLabel.Font = new Font("MagistralC", 18.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            positionLabel.ForeColor = Color.Black;
            positionLabel.Location = new Point(30, 388);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(322, 38);
            positionLabel.TabIndex = 52;
            positionLabel.Text = "Software Developer";
            positionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Red;
            nameLabel.Font = new Font("MagistralC", 21.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(33, 343);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(320, 63);
            nameLabel.TabIndex = 51;
            nameLabel.Text = "Bob Singer";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPrintCard
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(912, 630);
            Controls.Add(_Button1);
            Controls.Add(normalSettingPanel);
            Controls.Add(_CheckBox1);
            Controls.Add(lowerSettingsPanel);
            Controls.Add(_selectAllCheckBox);
            Controls.Add(warningLabel);
            Controls.Add(IDTextBox);
            Controls.Add(_PositionTextBox);
            Controls.Add(_NameTextBox);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(_employeesListView);
            Controls.Add(Splitter1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmPrintCard";
            StartPosition = FormStartPosition.CenterScreen;
            lowerSettingsPanel.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)lowPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            normalSettingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeePictureBox).EndInit();
            Load += new EventHandler(FrmPrintCard_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private ListView _employeesListView;

        internal ListView employeesListView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _employeesListView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_employeesListView != null)
                {
                    _employeesListView.Click -= reportFromListView_SelectedIndexChanged;
                }

                _employeesListView = value;
                if (_employeesListView != null)
                {
                    _employeesListView.Click += reportFromListView_SelectedIndexChanged;
                }
            }
        }

        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader ColumnHeader5;
        internal Splitter Splitter1;
        internal Panel normalSettingPanel;
        internal PictureBox employeePictureBox;
        internal Label idLabel;
        internal Label barcodeLabel;
        internal Label positionLabel;
        internal Label nameLabel;
        internal Label Label2;
        internal Label Label3;
        private TextBox _NameTextBox;

        internal TextBox NameTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NameTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NameTextBox != null)
                {
                    _NameTextBox.TextChanged -= NameTextBox_TextChanged;
                }

                _NameTextBox = value;
                if (_NameTextBox != null)
                {
                    _NameTextBox.TextChanged += NameTextBox_TextChanged;
                }
            }
        }

        private TextBox _PositionTextBox;

        internal TextBox PositionTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PositionTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PositionTextBox != null)
                {
                    _PositionTextBox.TextChanged -= PositionTextBox_TextChanged;
                }

                _PositionTextBox = value;
                if (_PositionTextBox != null)
                {
                    _PositionTextBox.TextChanged += PositionTextBox_TextChanged;
                }
            }
        }

        internal TextBox IDTextBox;
        internal Label Label1;
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
        internal Label warningLabel;
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

        internal Panel Panel2;
        internal PictureBox PictureBox4;
        internal PictureBox lowPictureBox;
        internal PictureBox PictureBox2;
        internal Label lowNameLabel;
        internal Label lowbarcodeLabel;
        internal Label lowIdLabel;
        internal PictureBox PictureBox1;
        internal Panel lowerSettingsPanel;
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
                    _CheckBox1.CheckedChanged -= CheckBox1_CheckedChanged_1;
                }

                _CheckBox1 = value;
                if (_CheckBox1 != null)
                {
                    _CheckBox1.CheckedChanged += CheckBox1_CheckedChanged_1;
                }
            }
        }

        internal Label lowPositionLabe;
    }
}