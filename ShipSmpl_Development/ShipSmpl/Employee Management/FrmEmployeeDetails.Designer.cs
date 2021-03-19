using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmEmployeeDetails : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeDetails));
            ImageList1 = new ImageList(components);
            skillsAndCertificationsTab = new TabPage();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(Button2_Click);
            Label15 = new Label();
            TabControl1 = new TabControl();
            employeeInfoTab = new TabPage();
            Label3 = new Label();
            Label2 = new Label();
            Panel4 = new Panel();
            TableLayoutPanel3 = new TableLayoutPanel();
            relationshipLabel = new Label();
            emergPhoneNumbLabel = new Label();
            Label37 = new Label();
            Label39 = new Label();
            Label41 = new Label();
            emergNameLabel = new Label();
            Label45 = new Label();
            Label46 = new Label();
            Panel3 = new Panel();
            TableLayoutPanel2 = new TableLayoutPanel();
            emailLabel = new Label();
            Label16 = new Label();
            phoneLabel = new Label();
            sinLabel = new Label();
            genderLabel = new Label();
            birthdayLabel = new Label();
            Label21 = new Label();
            Label22 = new Label();
            Label23 = new Label();
            Label24 = new Label();
            Label25 = new Label();
            aliasLabel = new Label();
            Label27 = new Label();
            addressLabel = new Label();
            Label29 = new Label();
            Label30 = new Label();
            Panel2 = new Panel();
            TableLayoutPanel1 = new TableLayoutPanel();
            endDateLabel = new Label();
            Label12 = new Label();
            startDateLabel19 = new Label();
            PayMethodLabel = new Label();
            yardLabel = new Label();
            TypeLabel = new Label();
            Label7 = new Label();
            Label14 = new Label();
            Label11 = new Label();
            Label13 = new Label();
            Label8 = new Label();
            jobDescriptionLabel = new Label();
            reportToLabel = new Label();
            supervisorLabel = new Label();
            Label9 = new Label();
            Label10 = new Label();
            Panel1 = new Panel();
            cardStatusLabel = new Label();
            Label6 = new Label();
            Label4 = new Label();
            empIDLabel = new Label();
            statusLabel = new Label();
            empNameLabel = new Label();
            PictureBox = new PictureBox();
            Label1 = new Label();
            skillsCertificationsTab = new TabPage();
            Panel7 = new Panel();
            certificatesLabel = new Label();
            Label36 = new Label();
            Label38 = new Label();
            Panel6 = new Panel();
            skillsLabel = new Label();
            Label28 = new Label();
            Label33 = new Label();
            Panel5 = new Panel();
            Label40 = new Label();
            documentsListView = new ListView();
            DocumentNameHeader = new ColumnHeader();
            ColumnHeader1 = new ColumnHeader();
            docIDColumnHeader = new ColumnHeader();
            Label42 = new Label();
            Label5 = new Label();
            Label17 = new Label();
            TabControl1.SuspendLayout();
            employeeInfoTab.SuspendLayout();
            Panel4.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            Panel3.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            Panel2.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            skillsCertificationsTab.SuspendLayout();
            Panel7.SuspendLayout();
            Panel6.SuspendLayout();
            Panel5.SuspendLayout();
            SuspendLayout();
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "redBall.png");
            ImageList1.Images.SetKeyName(1, "roundedGradientGreen.png");
            // 
            // skillsAndCertificationsTab
            // 
            skillsAndCertificationsTab.Location = new Point(134, 4);
            skillsAndCertificationsTab.Name = "skillsAndCertificationsTab";
            skillsAndCertificationsTab.Size = new Size(902, 706);
            skillsAndCertificationsTab.TabIndex = 2;
            skillsAndCertificationsTab.Text = "Skills & Certidications";
            skillsAndCertificationsTab.UseVisualStyleBackColor = true;
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(1215, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 49);
            _closeLabel.TabIndex = 75;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label15
            // 
            Label15.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label15.Dock = DockStyle.Top;
            Label15.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label15.Location = new Point(0, 0);
            Label15.Name = "Label15";
            Label15.Size = new Size(1264, 49);
            Label15.TabIndex = 74;
            Label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(employeeInfoTab);
            TabControl1.Controls.Add(skillsCertificationsTab);
            TabControl1.Dock = DockStyle.Fill;
            TabControl1.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TabControl1.ItemSize = new Size(120, 30);
            TabControl1.Location = new Point(0, 49);
            TabControl1.Multiline = true;
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(1264, 825);
            TabControl1.TabIndex = 76;
            // 
            // employeeInfoTab
            // 
            employeeInfoTab.BackColor = Color.White;
            employeeInfoTab.Controls.Add(Label3);
            employeeInfoTab.Controls.Add(Label2);
            employeeInfoTab.Controls.Add(Panel4);
            employeeInfoTab.Controls.Add(Panel3);
            employeeInfoTab.Controls.Add(Panel2);
            employeeInfoTab.Controls.Add(Panel1);
            employeeInfoTab.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            employeeInfoTab.Location = new Point(4, 34);
            employeeInfoTab.Name = "employeeInfoTab";
            employeeInfoTab.Padding = new Padding(3);
            employeeInfoTab.Size = new Size(1256, 787);
            employeeInfoTab.TabIndex = 1;
            employeeInfoTab.Text = "Employee Information";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(34, 27);
            Label3.Name = "Label3";
            Label3.Size = new Size(182, 30);
            Label3.TabIndex = 7;
            Label3.Text = "Employee Profile";
            // 
            // Label2
            // 
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.ImageAlign = ContentAlignment.TopCenter;
            Label2.Location = new Point(34, 46);
            Label2.Name = "Label2";
            Label2.Size = new Size(1169, 27);
            Label2.TabIndex = 5;
            Label2.Text = "_________________________________________________________________________________" + "________________________________________________________________________________" + "_______________________";
            // 
            // Panel4
            // 
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(TableLayoutPanel3);
            Panel4.Controls.Add(Label45);
            Panel4.Controls.Add(Label46);
            Panel4.Location = new Point(622, 499);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(569, 236);
            Panel4.TabIndex = 11;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.ColumnCount = 2;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.19549f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.80451f));
            TableLayoutPanel3.Controls.Add(relationshipLabel, 1, 2);
            TableLayoutPanel3.Controls.Add(emergPhoneNumbLabel, 1, 1);
            TableLayoutPanel3.Controls.Add(Label37, 0, 0);
            TableLayoutPanel3.Controls.Add(Label39, 0, 1);
            TableLayoutPanel3.Controls.Add(Label41, 0, 2);
            TableLayoutPanel3.Controls.Add(emergNameLabel, 1, 0);
            TableLayoutPanel3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel3.Location = new Point(19, 71);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 3;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel3.Size = new Size(532, 139);
            TableLayoutPanel3.TabIndex = 6;
            // 
            // relationshipLabel
            // 
            relationshipLabel.AutoSize = true;
            relationshipLabel.Dock = DockStyle.Fill;
            relationshipLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            relationshipLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            relationshipLabel.Location = new Point(152, 92);
            relationshipLabel.Name = "relationshipLabel";
            relationshipLabel.Padding = new Padding(10, 0, 0, 0);
            relationshipLabel.Size = new Size(377, 47);
            relationshipLabel.TabIndex = 12;
            relationshipLabel.Text = "N/A";
            relationshipLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emergPhoneNumbLabel
            // 
            emergPhoneNumbLabel.AutoSize = true;
            emergPhoneNumbLabel.Dock = DockStyle.Fill;
            emergPhoneNumbLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            emergPhoneNumbLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            emergPhoneNumbLabel.Location = new Point(152, 46);
            emergPhoneNumbLabel.Name = "emergPhoneNumbLabel";
            emergPhoneNumbLabel.Padding = new Padding(10, 0, 0, 0);
            emergPhoneNumbLabel.Size = new Size(377, 46);
            emergPhoneNumbLabel.TabIndex = 11;
            emergPhoneNumbLabel.Text = "N/A";
            emergPhoneNumbLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label37
            // 
            Label37.Dock = DockStyle.Fill;
            Label37.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label37.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label37.Location = new Point(3, 0);
            Label37.Name = "Label37";
            Label37.Size = new Size(143, 46);
            Label37.TabIndex = 4;
            Label37.Text = "Name:";
            Label37.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label39
            // 
            Label39.Dock = DockStyle.Fill;
            Label39.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label39.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label39.Location = new Point(3, 46);
            Label39.Name = "Label39";
            Label39.Size = new Size(143, 46);
            Label39.TabIndex = 6;
            Label39.Text = "Phone:";
            Label39.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label41
            // 
            Label41.Dock = DockStyle.Fill;
            Label41.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label41.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label41.Location = new Point(3, 92);
            Label41.Name = "Label41";
            Label41.Size = new Size(143, 47);
            Label41.TabIndex = 5;
            Label41.Text = "Relationship:";
            Label41.TextAlign = ContentAlignment.MiddleRight;
            // 
            // emergNameLabel
            // 
            emergNameLabel.AutoSize = true;
            emergNameLabel.Dock = DockStyle.Fill;
            emergNameLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            emergNameLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            emergNameLabel.Location = new Point(152, 0);
            emergNameLabel.Name = "emergNameLabel";
            emergNameLabel.Padding = new Padding(10, 0, 0, 0);
            emergNameLabel.Size = new Size(377, 46);
            emergNameLabel.TabIndex = 10;
            emergNameLabel.Text = "N/A";
            emergNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label45
            // 
            Label45.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label45.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)));
            Label45.Location = new Point(27, 27);
            Label45.Name = "Label45";
            Label45.Size = new Size(259, 31);
            Label45.TabIndex = 2;
            Label45.Text = "Emergency Contact";
            Label45.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label46
            // 
            Label46.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label46.Dock = DockStyle.Top;
            Label46.Location = new Point(0, 0);
            Label46.Name = "Label46";
            Label46.Size = new Size(567, 15);
            Label46.TabIndex = 0;
            // 
            // Panel3
            // 
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(TableLayoutPanel2);
            Panel3.Controls.Add(Label29);
            Panel3.Controls.Add(Label30);
            Panel3.Location = new Point(64, 341);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(526, 394);
            Panel3.TabIndex = 10;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 2;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.04819f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.95181f));
            TableLayoutPanel2.Controls.Add(emailLabel, 1, 5);
            TableLayoutPanel2.Controls.Add(Label16, 0, 5);
            TableLayoutPanel2.Controls.Add(phoneLabel, 1, 4);
            TableLayoutPanel2.Controls.Add(sinLabel, 1, 3);
            TableLayoutPanel2.Controls.Add(genderLabel, 1, 2);
            TableLayoutPanel2.Controls.Add(birthdayLabel, 1, 1);
            TableLayoutPanel2.Controls.Add(Label21, 0, 0);
            TableLayoutPanel2.Controls.Add(Label22, 0, 4);
            TableLayoutPanel2.Controls.Add(Label23, 0, 1);
            TableLayoutPanel2.Controls.Add(Label24, 0, 3);
            TableLayoutPanel2.Controls.Add(Label25, 0, 2);
            TableLayoutPanel2.Controls.Add(aliasLabel, 1, 0);
            TableLayoutPanel2.Controls.Add(Label27, 0, 6);
            TableLayoutPanel2.Controls.Add(addressLabel, 1, 6);
            TableLayoutPanel2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel2.Location = new Point(13, 71);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 7;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9082f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.90821f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.90821f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.90821f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.90821f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.90821f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.55077f));
            TableLayoutPanel2.Size = new Size(491, 303);
            TableLayoutPanel2.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.Dock = DockStyle.Fill;
            emailLabel.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            emailLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            emailLabel.Location = new Point(160, 210);
            emailLabel.Name = "emailLabel";
            emailLabel.Padding = new Padding(10, 0, 0, 0);
            emailLabel.Size = new Size(328, 42);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "N/A";
            emailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label16
            // 
            Label16.Dock = DockStyle.Fill;
            Label16.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label16.Location = new Point(3, 210);
            Label16.Name = "Label16";
            Label16.Size = new Size(151, 42);
            Label16.TabIndex = 8;
            Label16.Text = "Email:";
            Label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Dock = DockStyle.Fill;
            phoneLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            phoneLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            phoneLabel.Location = new Point(160, 168);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Padding = new Padding(10, 0, 0, 0);
            phoneLabel.Size = new Size(328, 42);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "N/A";
            phoneLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sinLabel
            // 
            sinLabel.AutoSize = true;
            sinLabel.Dock = DockStyle.Fill;
            sinLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            sinLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            sinLabel.Location = new Point(160, 126);
            sinLabel.Name = "sinLabel";
            sinLabel.Padding = new Padding(10, 0, 0, 0);
            sinLabel.Size = new Size(328, 42);
            sinLabel.TabIndex = 13;
            sinLabel.Text = "N/A";
            sinLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Dock = DockStyle.Fill;
            genderLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            genderLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            genderLabel.Location = new Point(160, 84);
            genderLabel.Name = "genderLabel";
            genderLabel.Padding = new Padding(10, 0, 0, 0);
            genderLabel.Size = new Size(328, 42);
            genderLabel.TabIndex = 12;
            genderLabel.Text = "N/A";
            genderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Dock = DockStyle.Fill;
            birthdayLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            birthdayLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            birthdayLabel.Location = new Point(160, 42);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Padding = new Padding(10, 0, 0, 0);
            birthdayLabel.Size = new Size(328, 42);
            birthdayLabel.TabIndex = 11;
            birthdayLabel.Text = "N/A";
            birthdayLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label21
            // 
            Label21.Dock = DockStyle.Fill;
            Label21.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label21.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label21.Location = new Point(3, 0);
            Label21.Name = "Label21";
            Label21.Size = new Size(151, 42);
            Label21.TabIndex = 4;
            Label21.Text = "Alias:";
            Label21.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label22
            // 
            Label22.Dock = DockStyle.Fill;
            Label22.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label22.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label22.Location = new Point(3, 168);
            Label22.Name = "Label22";
            Label22.Size = new Size(151, 42);
            Label22.TabIndex = 9;
            Label22.Text = "Phone:";
            Label22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label23
            // 
            Label23.Dock = DockStyle.Fill;
            Label23.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label23.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label23.Location = new Point(3, 42);
            Label23.Name = "Label23";
            Label23.Size = new Size(151, 42);
            Label23.TabIndex = 6;
            Label23.Text = "Birthday:";
            Label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label24
            // 
            Label24.Dock = DockStyle.Fill;
            Label24.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label24.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label24.Location = new Point(3, 126);
            Label24.Name = "Label24";
            Label24.Size = new Size(151, 42);
            Label24.TabIndex = 8;
            Label24.Text = "SIN:";
            Label24.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label25
            // 
            Label25.Dock = DockStyle.Fill;
            Label25.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label25.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label25.Location = new Point(3, 84);
            Label25.Name = "Label25";
            Label25.Size = new Size(151, 42);
            Label25.TabIndex = 5;
            Label25.Text = "Gender:";
            Label25.TextAlign = ContentAlignment.MiddleRight;
            // 
            // aliasLabel
            // 
            aliasLabel.AutoSize = true;
            aliasLabel.Dock = DockStyle.Fill;
            aliasLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            aliasLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            aliasLabel.Location = new Point(160, 0);
            aliasLabel.Name = "aliasLabel";
            aliasLabel.Padding = new Padding(10, 0, 0, 0);
            aliasLabel.Size = new Size(328, 42);
            aliasLabel.TabIndex = 10;
            aliasLabel.Text = "N/A";
            aliasLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label27
            // 
            Label27.Dock = DockStyle.Fill;
            Label27.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label27.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label27.Location = new Point(3, 252);
            Label27.Name = "Label27";
            Label27.Size = new Size(151, 51);
            Label27.TabIndex = 7;
            Label27.Text = "Address:";
            Label27.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Dock = DockStyle.Fill;
            addressLabel.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            addressLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            addressLabel.Location = new Point(160, 252);
            addressLabel.Name = "addressLabel";
            addressLabel.Padding = new Padding(10, 0, 0, 0);
            addressLabel.Size = new Size(328, 51);
            addressLabel.TabIndex = 15;
            addressLabel.Text = "N/A";
            addressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label29
            // 
            Label29.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label29.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)));
            Label29.Location = new Point(27, 27);
            Label29.Name = "Label29";
            Label29.Size = new Size(259, 31);
            Label29.TabIndex = 2;
            Label29.Text = "Personal Information";
            Label29.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label30
            // 
            Label30.BackColor = Color.Goldenrod;
            Label30.Dock = DockStyle.Top;
            Label30.Location = new Point(0, 0);
            Label30.Name = "Label30";
            Label30.Size = new Size(524, 15);
            Label30.TabIndex = 0;
            // 
            // Panel2
            // 
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(TableLayoutPanel1);
            Panel2.Controls.Add(Label9);
            Panel2.Controls.Add(Label10);
            Panel2.Location = new Point(622, 95);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(569, 369);
            Panel2.TabIndex = 9;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.70223f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.29777f));
            TableLayoutPanel1.Controls.Add(endDateLabel, 1, 5);
            TableLayoutPanel1.Controls.Add(Label12, 0, 5);
            TableLayoutPanel1.Controls.Add(startDateLabel19, 1, 4);
            TableLayoutPanel1.Controls.Add(PayMethodLabel, 1, 3);
            TableLayoutPanel1.Controls.Add(yardLabel, 1, 2);
            TableLayoutPanel1.Controls.Add(TypeLabel, 1, 1);
            TableLayoutPanel1.Controls.Add(Label7, 0, 0);
            TableLayoutPanel1.Controls.Add(Label14, 0, 4);
            TableLayoutPanel1.Controls.Add(Label11, 0, 1);
            TableLayoutPanel1.Controls.Add(Label13, 0, 3);
            TableLayoutPanel1.Controls.Add(Label8, 0, 2);
            TableLayoutPanel1.Controls.Add(jobDescriptionLabel, 1, 0);
            TableLayoutPanel1.Controls.Add(reportToLabel, 0, 6);
            TableLayoutPanel1.Controls.Add(supervisorLabel, 1, 6);
            TableLayoutPanel1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel1.Location = new Point(5, 68);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 7;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5f));
            TableLayoutPanel1.Size = new Size(546, 291);
            TableLayoutPanel1.TabIndex = 6;
            // 
            // endDateLabel
            // 
            endDateLabel.Dock = DockStyle.Fill;
            endDateLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            endDateLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            endDateLabel.Location = new Point(219, 205);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Padding = new Padding(10, 0, 0, 0);
            endDateLabel.Size = new Size(324, 41);
            endDateLabel.TabIndex = 16;
            endDateLabel.Text = "N/A";
            endDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label12
            // 
            Label12.Dock = DockStyle.Fill;
            Label12.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Location = new Point(3, 205);
            Label12.Name = "Label12";
            Label12.Size = new Size(210, 41);
            Label12.TabIndex = 8;
            Label12.Text = "End Date:";
            Label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // startDateLabel19
            // 
            startDateLabel19.AutoSize = true;
            startDateLabel19.Dock = DockStyle.Fill;
            startDateLabel19.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            startDateLabel19.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            startDateLabel19.Location = new Point(219, 164);
            startDateLabel19.Name = "startDateLabel19";
            startDateLabel19.Padding = new Padding(10, 0, 0, 0);
            startDateLabel19.Size = new Size(324, 41);
            startDateLabel19.TabIndex = 14;
            startDateLabel19.Text = "N/A";
            startDateLabel19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PayMethodLabel
            // 
            PayMethodLabel.AutoSize = true;
            PayMethodLabel.Dock = DockStyle.Fill;
            PayMethodLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            PayMethodLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            PayMethodLabel.Location = new Point(219, 123);
            PayMethodLabel.Name = "PayMethodLabel";
            PayMethodLabel.Padding = new Padding(10, 0, 0, 0);
            PayMethodLabel.Size = new Size(324, 41);
            PayMethodLabel.TabIndex = 13;
            PayMethodLabel.Text = "N/A";
            PayMethodLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // yardLabel
            // 
            yardLabel.AutoSize = true;
            yardLabel.Dock = DockStyle.Fill;
            yardLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            yardLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            yardLabel.Location = new Point(219, 82);
            yardLabel.Name = "yardLabel";
            yardLabel.Padding = new Padding(10, 0, 0, 0);
            yardLabel.Size = new Size(324, 41);
            yardLabel.TabIndex = 12;
            yardLabel.Text = "N/A";
            yardLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Dock = DockStyle.Fill;
            TypeLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TypeLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            TypeLabel.Location = new Point(219, 41);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Padding = new Padding(10, 0, 0, 0);
            TypeLabel.Size = new Size(324, 41);
            TypeLabel.TabIndex = 11;
            TypeLabel.Text = "N/A";
            TypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            Label7.Dock = DockStyle.Fill;
            Label7.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Location = new Point(3, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(210, 41);
            Label7.TabIndex = 4;
            Label7.Text = "Job Description:";
            Label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label14
            // 
            Label14.Dock = DockStyle.Fill;
            Label14.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label14.Location = new Point(3, 164);
            Label14.Name = "Label14";
            Label14.Size = new Size(210, 41);
            Label14.TabIndex = 9;
            Label14.Text = "Start Date:";
            Label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            Label11.Dock = DockStyle.Fill;
            Label11.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label11.Location = new Point(3, 41);
            Label11.Name = "Label11";
            Label11.Size = new Size(210, 41);
            Label11.TabIndex = 6;
            Label11.Text = "Type:";
            Label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label13
            // 
            Label13.Dock = DockStyle.Fill;
            Label13.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label13.Location = new Point(3, 123);
            Label13.Name = "Label13";
            Label13.Size = new Size(210, 41);
            Label13.TabIndex = 8;
            Label13.Text = "Pay Method:";
            Label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label8
            // 
            Label8.Dock = DockStyle.Fill;
            Label8.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label8.Location = new Point(3, 82);
            Label8.Name = "Label8";
            Label8.Size = new Size(210, 41);
            Label8.TabIndex = 5;
            Label8.Text = "Yard:";
            Label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // jobDescriptionLabel
            // 
            jobDescriptionLabel.AutoSize = true;
            jobDescriptionLabel.Dock = DockStyle.Fill;
            jobDescriptionLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            jobDescriptionLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            jobDescriptionLabel.Location = new Point(219, 0);
            jobDescriptionLabel.Name = "jobDescriptionLabel";
            jobDescriptionLabel.Padding = new Padding(10, 0, 0, 0);
            jobDescriptionLabel.Size = new Size(324, 41);
            jobDescriptionLabel.TabIndex = 10;
            jobDescriptionLabel.Text = "N/A";
            jobDescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // reportToLabel
            // 
            reportToLabel.Dock = DockStyle.Fill;
            reportToLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            reportToLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            reportToLabel.Location = new Point(3, 246);
            reportToLabel.Name = "reportToLabel";
            reportToLabel.Size = new Size(210, 45);
            reportToLabel.TabIndex = 7;
            reportToLabel.Text = "Reporting to:";
            reportToLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // supervisorLabel
            // 
            supervisorLabel.AutoSize = true;
            supervisorLabel.Dock = DockStyle.Fill;
            supervisorLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            supervisorLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            supervisorLabel.Location = new Point(219, 246);
            supervisorLabel.Name = "supervisorLabel";
            supervisorLabel.Padding = new Padding(10, 0, 0, 0);
            supervisorLabel.Size = new Size(324, 45);
            supervisorLabel.TabIndex = 15;
            supervisorLabel.Text = "N/A";
            supervisorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            Label9.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)));
            Label9.Location = new Point(27, 27);
            Label9.Name = "Label9";
            Label9.Size = new Size(259, 31);
            Label9.TabIndex = 2;
            Label9.Text = "Current Position";
            Label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            Label10.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label10.Dock = DockStyle.Top;
            Label10.Location = new Point(0, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(567, 15);
            Label10.TabIndex = 0;
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(cardStatusLabel);
            Panel1.Controls.Add(Label6);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(empIDLabel);
            Panel1.Controls.Add(statusLabel);
            Panel1.Controls.Add(empNameLabel);
            Panel1.Controls.Add(PictureBox);
            Panel1.Controls.Add(Label1);
            Panel1.Location = new Point(65, 95);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(526, 230);
            Panel1.TabIndex = 8;
            // 
            // cardStatusLabel
            // 
            cardStatusLabel.BackColor = Color.Firebrick;
            cardStatusLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            cardStatusLabel.ForeColor = Color.White;
            cardStatusLabel.ImageAlign = ContentAlignment.MiddleLeft;
            cardStatusLabel.ImageKey = "(none)";
            cardStatusLabel.ImageList = ImageList1;
            cardStatusLabel.Location = new Point(309, 150);
            cardStatusLabel.Name = "cardStatusLabel";
            cardStatusLabel.Size = new Size(119, 23);
            cardStatusLabel.TabIndex = 7;
            cardStatusLabel.Text = "Not Assigned";
            cardStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            Label6.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.ImageAlign = ContentAlignment.MiddleLeft;
            Label6.ImageKey = "(none)";
            Label6.ImageList = ImageList1;
            Label6.Location = new Point(199, 150);
            Label6.Name = "Label6";
            Label6.Size = new Size(121, 23);
            Label6.TabIndex = 6;
            Label6.Text = "Card Status:";
            Label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            Label4.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label4.ImageAlign = ContentAlignment.MiddleRight;
            Label4.Location = new Point(199, 83);
            Label4.Name = "Label4";
            Label4.Size = new Size(42, 23);
            Label4.TabIndex = 5;
            Label4.Text = "ID:";
            // 
            // empIDLabel
            // 
            empIDLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            empIDLabel.Location = new Point(236, 83);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new Size(84, 23);
            empIDLabel.TabIndex = 4;
            empIDLabel.Text = "1234";
            // 
            // statusLabel
            // 
            statusLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            statusLabel.ImageAlign = ContentAlignment.MiddleLeft;
            statusLabel.ImageKey = "redBall.png";
            statusLabel.ImageList = ImageList1;
            statusLabel.Location = new Point(199, 115);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(165, 23);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "      Active";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // empNameLabel
            // 
            empNameLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            empNameLabel.Location = new Point(186, 52);
            empNameLabel.Name = "empNameLabel";
            empNameLabel.Size = new Size(259, 31);
            empNameLabel.TabIndex = 2;
            empNameLabel.Text = "John Doe";
            // 
            // PictureBox
            // 
            PictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            PictureBox.BorderStyle = BorderStyle.FixedSingle;
            PictureBox.Location = new Point(13, 29);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(153, 184);
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            // 
            // Label1
            // 
            Label1.BackColor = Color.MediumTurquoise;
            Label1.Dock = DockStyle.Top;
            Label1.Location = new Point(0, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(524, 15);
            Label1.TabIndex = 0;
            // 
            // skillsCertificationsTab
            // 
            skillsCertificationsTab.BackColor = Color.White;
            skillsCertificationsTab.Controls.Add(Label5);
            skillsCertificationsTab.Controls.Add(Label17);
            skillsCertificationsTab.Controls.Add(Panel7);
            skillsCertificationsTab.Controls.Add(Panel6);
            skillsCertificationsTab.Controls.Add(Panel5);
            skillsCertificationsTab.ForeColor = Color.Black;
            skillsCertificationsTab.Location = new Point(4, 34);
            skillsCertificationsTab.Name = "skillsCertificationsTab";
            skillsCertificationsTab.Size = new Size(1256, 787);
            skillsCertificationsTab.TabIndex = 2;
            skillsCertificationsTab.Text = "Skills/Certifications";
            // 
            // Panel7
            // 
            Panel7.BorderStyle = BorderStyle.FixedSingle;
            Panel7.Controls.Add(certificatesLabel);
            Panel7.Controls.Add(Label36);
            Panel7.Controls.Add(Label38);
            Panel7.Location = new Point(693, 113);
            Panel7.Name = "Panel7";
            Panel7.Size = new Size(393, 228);
            Panel7.TabIndex = 17;
            // 
            // certificatesLabel
            // 
            certificatesLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            certificatesLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            certificatesLabel.Location = new Point(38, 60);
            certificatesLabel.Name = "certificatesLabel";
            certificatesLabel.Padding = new Padding(3);
            certificatesLabel.Size = new Size(263, 147);
            certificatesLabel.TabIndex = 3;
            certificatesLabel.Text = "‣ Bagger" + '\r' + '\n' + "‣ Bulk" + '\r' + '\n' + "‣ Yard Manager";
            // 
            // Label36
            // 
            Label36.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label36.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)));
            Label36.Location = new Point(27, 27);
            Label36.Name = "Label36";
            Label36.Size = new Size(242, 31);
            Label36.TabIndex = 2;
            Label36.Text = "Certificates";
            Label36.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label38
            // 
            Label38.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label38.Dock = DockStyle.Top;
            Label38.Location = new Point(0, 0);
            Label38.Name = "Label38";
            Label38.Size = new Size(391, 15);
            Label38.TabIndex = 0;
            // 
            // Panel6
            // 
            Panel6.BorderStyle = BorderStyle.FixedSingle;
            Panel6.Controls.Add(skillsLabel);
            Panel6.Controls.Add(Label28);
            Panel6.Controls.Add(Label33);
            Panel6.Location = new Point(153, 113);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(393, 228);
            Panel6.TabIndex = 16;
            // 
            // skillsLabel
            // 
            skillsLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            skillsLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            skillsLabel.Location = new Point(38, 60);
            skillsLabel.Name = "skillsLabel";
            skillsLabel.Padding = new Padding(3);
            skillsLabel.Size = new Size(257, 158);
            skillsLabel.TabIndex = 3;
            skillsLabel.Text = "‣ Bagger" + '\r' + '\n' + "‣ Bulk" + '\r' + '\n' + "‣ Yard Manager";
            // 
            // Label28
            // 
            Label28.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label28.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)));
            Label28.Location = new Point(27, 27);
            Label28.Name = "Label28";
            Label28.Size = new Size(242, 31);
            Label28.TabIndex = 2;
            Label28.Text = "Skills";
            Label28.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label33
            // 
            Label33.BackColor = Color.Green;
            Label33.Dock = DockStyle.Top;
            Label33.Location = new Point(0, 0);
            Label33.Name = "Label33";
            Label33.Size = new Size(391, 15);
            Label33.TabIndex = 0;
            // 
            // Panel5
            // 
            Panel5.BorderStyle = BorderStyle.FixedSingle;
            Panel5.Controls.Add(Label40);
            Panel5.Controls.Add(documentsListView);
            Panel5.Controls.Add(Label42);
            Panel5.Location = new Point(256, 384);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(722, 321);
            Panel5.TabIndex = 15;
            // 
            // Label40
            // 
            Label40.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label40.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)), Conversions.ToInteger(Conversions.ToByte(63)));
            Label40.Location = new Point(27, 27);
            Label40.Name = "Label40";
            Label40.Size = new Size(259, 31);
            Label40.TabIndex = 2;
            Label40.Text = "Documents";
            Label40.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // documentsListView
            // 
            documentsListView.Columns.AddRange(new ColumnHeader[] { DocumentNameHeader, ColumnHeader1, docIDColumnHeader });
            documentsListView.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            documentsListView.FullRowSelect = true;
            documentsListView.HideSelection = false;
            documentsListView.Location = new Point(16, 74);
            documentsListView.MultiSelect = false;
            documentsListView.Name = "documentsListView";
            documentsListView.Size = new Size(675, 225);
            documentsListView.TabIndex = 14;
            documentsListView.UseCompatibleStateImageBehavior = false;
            documentsListView.View = View.Details;
            // 
            // DocumentNameHeader
            // 
            DocumentNameHeader.Text = "Document Name";
            DocumentNameHeader.Width = 470;
            // 
            // ColumnHeader1
            // 
            ColumnHeader1.Text = "Updated at";
            ColumnHeader1.Width = 188;
            // 
            // docIDColumnHeader
            // 
            docIDColumnHeader.Text = "";
            docIDColumnHeader.Width = 0;
            // 
            // Label42
            // 
            Label42.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label42.Dock = DockStyle.Top;
            Label42.Location = new Point(0, 0);
            Label42.Name = "Label42";
            Label42.Size = new Size(720, 15);
            Label42.TabIndex = 0;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label5.Location = new Point(32, 30);
            Label5.Name = "Label5";
            Label5.Size = new Size(246, 30);
            Label5.TabIndex = 19;
            Label5.Text = "Skills and Certifications";
            // 
            // Label17
            // 
            Label17.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label17.ImageAlign = ContentAlignment.TopCenter;
            Label17.Location = new Point(32, 49);
            Label17.Name = "Label17";
            Label17.Size = new Size(1169, 27);
            Label17.TabIndex = 18;
            Label17.Text = "_________________________________________________________________________________" + "________________________________________________________________________________" + "_______________________";
            // 
            // FrmEmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1264, 874);
            ControlBox = false;
            Controls.Add(TabControl1);
            Controls.Add(_closeLabel);
            Controls.Add(Label15);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmEmployeeDetails";
            StartPosition = FormStartPosition.CenterScreen;
            TabControl1.ResumeLayout(false);
            employeeInfoTab.ResumeLayout(false);
            employeeInfoTab.PerformLayout();
            Panel4.ResumeLayout(false);
            TableLayoutPanel3.ResumeLayout(false);
            TableLayoutPanel3.PerformLayout();
            Panel3.ResumeLayout(false);
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            Panel2.ResumeLayout(false);
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            skillsCertificationsTab.ResumeLayout(false);
            skillsCertificationsTab.PerformLayout();
            Panel7.ResumeLayout(false);
            Panel6.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        internal ImageList ImageList1;
        internal TabPage skillsAndCertificationsTab;
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
                    _closeLabel.Click -= Button2_Click;
                }

                _closeLabel = value;
                if (_closeLabel != null)
                {
                    _closeLabel.Click += Button2_Click;
                }
            }
        }

        internal Label Label15;
        internal TabControl TabControl1;
        internal TabPage employeeInfoTab;
        internal Label Label3;
        internal Label Label2;
        internal Panel Panel4;
        internal TableLayoutPanel TableLayoutPanel3;
        internal Label relationshipLabel;
        internal Label emergPhoneNumbLabel;
        internal Label Label37;
        internal Label Label39;
        internal Label Label41;
        internal Label emergNameLabel;
        internal Label Label45;
        internal Label Label46;
        internal Panel Panel3;
        internal TableLayoutPanel TableLayoutPanel2;
        internal Label emailLabel;
        internal Label Label16;
        internal Label phoneLabel;
        internal Label sinLabel;
        internal Label genderLabel;
        internal Label birthdayLabel;
        internal Label Label21;
        internal Label Label22;
        internal Label Label23;
        internal Label Label24;
        internal Label Label25;
        internal Label aliasLabel;
        internal Label Label27;
        internal Label addressLabel;
        internal Label Label29;
        internal Label Label30;
        internal Panel Panel2;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Label endDateLabel;
        internal Label Label12;
        internal Label startDateLabel19;
        internal Label PayMethodLabel;
        internal Label yardLabel;
        internal Label TypeLabel;
        internal Label Label7;
        internal Label Label14;
        internal Label Label11;
        internal Label Label13;
        internal Label Label8;
        internal Label jobDescriptionLabel;
        internal Label reportToLabel;
        internal Label supervisorLabel;
        internal Label Label9;
        internal Label Label10;
        internal Panel Panel1;
        internal Label cardStatusLabel;
        internal Label Label6;
        internal Label Label4;
        internal Label empIDLabel;
        internal Label statusLabel;
        internal Label empNameLabel;
        internal PictureBox PictureBox;
        internal Label Label1;
        internal TabPage skillsCertificationsTab;
        internal Panel Panel7;
        internal Label certificatesLabel;
        internal Label Label36;
        internal Label Label38;
        internal Panel Panel6;
        internal Label skillsLabel;
        internal Label Label28;
        internal Label Label33;
        internal Panel Panel5;
        internal Label Label40;
        internal ListView documentsListView;
        internal ColumnHeader DocumentNameHeader;
        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader docIDColumnHeader;
        internal Label Label42;
        internal Label Label5;
        internal Label Label17;
    }
}