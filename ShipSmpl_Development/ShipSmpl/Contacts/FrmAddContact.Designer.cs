using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAddContact : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddContact));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            companyIDLabel = new Label();
            ImageList1 = new ImageList(components);
            Label13 = new Label();
            Label12 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            _newDepartamentLabel = new Label();
            _newDepartamentLabel.Click += new EventHandler(newDepartamentLabel_Click);
            departamentComboBox = new ComboBox();
            organizationTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            TableLayoutPanel1 = new TableLayoutPanel();
            Label11 = new Label();
            Label5 = new Label();
            notesRichTextBox = new RichTextBox();
            Label17 = new Label();
            Label16 = new Label();
            Label15 = new Label();
            WorkAddressRichTextBox = new RichTextBox();
            homeAddressRichTextBox = new RichTextBox();
            TableLayoutPanel12 = new TableLayoutPanel();
            Label8 = new Label();
            Label9 = new Label();
            Label = new Label();
            TableLayoutPanel6 = new TableLayoutPanel();
            _areaFaxTextBox = new TextBox();
            _areaFaxTextBox.KeyPress += new KeyPressEventHandler(areaFaxTextBox_TextChanged);
            faxTextBox = new TextBox();
            TableLayoutPanel3 = new TableLayoutPanel();
            Label10 = new Label();
            extensionTextBox = new TextBox();
            workPhoneTextBox = new TextBox();
            _areaWorkPhoneTextBox = new TextBox();
            _areaWorkPhoneTextBox.KeyPress += new KeyPressEventHandler(areaWorkPhoneTextBox_TextChanged);
            TableLayoutPanel5 = new TableLayoutPanel();
            _areaMobileTextBox = new TextBox();
            _areaMobileTextBox.KeyPress += new KeyPressEventHandler(areaMobileTextBox_TextChanged);
            mobileTextBox = new TextBox();
            TableLayoutPanel2 = new TableLayoutPanel();
            Label14 = new Label();
            _saveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _saveButton.Click += new EventHandler(saveButton_Click);
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(cancelButton_Click);
            _editButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _editButton.Click += new EventHandler(Button1_Click);
            TableLayoutPanel1.SuspendLayout();
            TableLayoutPanel12.SuspendLayout();
            TableLayoutPanel6.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            TableLayoutPanel5.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // companyIDLabel
            // 
            companyIDLabel.AutoSize = true;
            companyIDLabel.Location = new Point(1020, 44);
            companyIDLabel.Name = "companyIDLabel";
            companyIDLabel.Size = new Size(0, 13);
            companyIDLabel.TabIndex = 33;
            companyIDLabel.Visible = false;
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "settings.png");
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.Location = new Point(98, 516);
            Label13.Name = "Label13";
            Label13.Size = new Size(70, 24);
            Label13.TabIndex = 26;
            Label13.Text = "Notes:";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Dock = DockStyle.Fill;
            Label12.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.Location = new Point(3, 148);
            Label12.Name = "Label12";
            Label12.Size = new Size(157, 41);
            Label12.TabIndex = 8;
            Label12.Text = "Email:";
            Label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Dock = DockStyle.Fill;
            Label3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(3, 74);
            Label3.Name = "Label3";
            Label3.Size = new Size(157, 37);
            Label3.TabIndex = 2;
            Label3.Text = "Organization:";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Dock = DockStyle.Fill;
            Label4.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(3, 111);
            Label4.Name = "Label4";
            Label4.Size = new Size(157, 37);
            Label4.TabIndex = 3;
            Label4.Text = "Department:";
            Label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Dock = DockStyle.Fill;
            Label2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(3, 37);
            Label2.Name = "Label2";
            Label2.Size = new Size(157, 37);
            Label2.TabIndex = 1;
            Label2.Text = "Last Name:";
            Label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Dock = DockStyle.Fill;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(3, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(157, 37);
            Label1.TabIndex = 0;
            Label1.Text = "First Name:";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // newDepartamentLabel
            // 
            _newDepartamentLabel.AutoSize = true;
            _newDepartamentLabel.Dock = DockStyle.Fill;
            _newDepartamentLabel.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _newDepartamentLabel.ForeColor = Color.White;
            _newDepartamentLabel.ImageIndex = 0;
            _newDepartamentLabel.ImageList = ImageList1;
            _newDepartamentLabel.Location = new Point(568, 111);
            _newDepartamentLabel.Margin = new Padding(0);
            _newDepartamentLabel.Name = "_newDepartamentLabel";
            _newDepartamentLabel.Size = new Size(81, 37);
            _newDepartamentLabel.TabIndex = 15;
            _newDepartamentLabel.Text = "+";
            _newDepartamentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // departamentComboBox
            // 
            departamentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departamentComboBox.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            departamentComboBox.FormattingEnabled = true;
            departamentComboBox.Location = new Point(166, 114);
            departamentComboBox.Name = "departamentComboBox";
            departamentComboBox.Size = new Size(399, 30);
            departamentComboBox.TabIndex = 0;
            // 
            // organizationTextBox
            // 
            organizationTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            organizationTextBox.Location = new Point(166, 77);
            organizationTextBox.Name = "organizationTextBox";
            organizationTextBox.ReadOnly = true;
            organizationTextBox.Size = new Size(399, 28);
            organizationTextBox.TabIndex = 14;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.CharacterCasing = CharacterCasing.Upper;
            lastNameTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lastNameTextBox.Location = new Point(166, 40);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(399, 28);
            lastNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.CharacterCasing = CharacterCasing.Upper;
            firstNameTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            firstNameTextBox.Location = new Point(166, 3);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(399, 28);
            firstNameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.CharacterCasing = CharacterCasing.Upper;
            emailTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            emailTextBox.Location = new Point(166, 151);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(399, 28);
            emailTextBox.TabIndex = 4;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 3;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.64865f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.35135f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80.0f));
            TableLayoutPanel1.Controls.Add(emailTextBox, 1, 4);
            TableLayoutPanel1.Controls.Add(firstNameTextBox, 1, 0);
            TableLayoutPanel1.Controls.Add(lastNameTextBox, 1, 1);
            TableLayoutPanel1.Controls.Add(organizationTextBox, 1, 2);
            TableLayoutPanel1.Controls.Add(departamentComboBox, 1, 3);
            TableLayoutPanel1.Controls.Add(_newDepartamentLabel, 2, 3);
            TableLayoutPanel1.Controls.Add(Label1, 0, 0);
            TableLayoutPanel1.Controls.Add(Label2, 0, 1);
            TableLayoutPanel1.Controls.Add(Label4, 0, 3);
            TableLayoutPanel1.Controls.Add(Label3, 0, 2);
            TableLayoutPanel1.Controls.Add(Label12, 0, 4);
            TableLayoutPanel1.Location = new Point(95, 115);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 5;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel1.Size = new Size(649, 189);
            TableLayoutPanel1.TabIndex = 21;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label11.Location = new Point(91, 484);
            Label11.Name = "Label11";
            Label11.Size = new Size(1022, 24);
            Label11.TabIndex = 24;
            Label11.Text = "_________________________________________________________________________________" + "___________";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label5.Location = new Point(91, 296);
            Label5.Name = "Label5";
            Label5.Size = new Size(1022, 24);
            Label5.TabIndex = 23;
            Label5.Text = "_________________________________________________________________________________" + "___________";
            // 
            // notesRichTextBox
            // 
            notesRichTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            notesRichTextBox.Location = new Point(217, 516);
            notesRichTextBox.Name = "notesRichTextBox";
            notesRichTextBox.Size = new Size(692, 96);
            notesRichTextBox.TabIndex = 28;
            notesRichTextBox.Text = "";
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label17.Location = new Point(91, 84);
            Label17.Name = "Label17";
            Label17.Size = new Size(1022, 24);
            Label17.TabIndex = 32;
            Label17.Text = "_________________________________________________________________________________" + "___________";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Dock = DockStyle.Fill;
            Label16.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.Location = new Point(3, 84);
            Label16.Name = "Label16";
            Label16.Size = new Size(113, 89);
            Label16.TabIndex = 1;
            Label16.Text = "Secondary Address:";
            Label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Dock = DockStyle.Fill;
            Label15.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.Location = new Point(3, 0);
            Label15.Name = "Label15";
            Label15.Size = new Size(113, 84);
            Label15.TabIndex = 0;
            Label15.Text = "Company Address:";
            Label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WorkAddressRichTextBox
            // 
            WorkAddressRichTextBox.BackColor = SystemColors.Control;
            WorkAddressRichTextBox.BorderStyle = BorderStyle.FixedSingle;
            WorkAddressRichTextBox.Dock = DockStyle.Fill;
            WorkAddressRichTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            WorkAddressRichTextBox.Location = new Point(122, 3);
            WorkAddressRichTextBox.Name = "WorkAddressRichTextBox";
            WorkAddressRichTextBox.ReadOnly = true;
            WorkAddressRichTextBox.Size = new Size(238, 78);
            WorkAddressRichTextBox.TabIndex = 14;
            WorkAddressRichTextBox.Text = "";
            // 
            // homeAddressRichTextBox
            // 
            homeAddressRichTextBox.BackColor = SystemColors.Control;
            homeAddressRichTextBox.Dock = DockStyle.Fill;
            homeAddressRichTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            homeAddressRichTextBox.Location = new Point(122, 87);
            homeAddressRichTextBox.Name = "homeAddressRichTextBox";
            homeAddressRichTextBox.ReadOnly = true;
            homeAddressRichTextBox.Size = new Size(238, 83);
            homeAddressRichTextBox.TabIndex = 15;
            homeAddressRichTextBox.Text = "";
            // 
            // TableLayoutPanel12
            // 
            TableLayoutPanel12.ColumnCount = 2;
            TableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.78237f));
            TableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.21763f));
            TableLayoutPanel12.Controls.Add(homeAddressRichTextBox, 1, 1);
            TableLayoutPanel12.Controls.Add(WorkAddressRichTextBox, 1, 0);
            TableLayoutPanel12.Controls.Add(Label15, 0, 0);
            TableLayoutPanel12.Controls.Add(Label16, 0, 1);
            TableLayoutPanel12.Location = new Point(667, 323);
            TableLayoutPanel12.Name = "TableLayoutPanel12";
            TableLayoutPanel12.RowCount = 2;
            TableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 48.64865f));
            TableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 51.35135f));
            TableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel12.Size = new Size(363, 173);
            TableLayoutPanel12.TabIndex = 27;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Dock = DockStyle.Fill;
            Label8.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(3, 78);
            Label8.Name = "Label8";
            Label8.Size = new Size(136, 41);
            Label8.TabIndex = 3;
            Label8.Text = "Work fax:";
            Label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Dock = DockStyle.Fill;
            Label9.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.Location = new Point(3, 39);
            Label9.Name = "Label9";
            Label9.Size = new Size(136, 39);
            Label9.TabIndex = 2;
            Label9.Text = "Work Phone:";
            Label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Dock = DockStyle.Fill;
            Label.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label.Location = new Point(3, 0);
            Label.Name = "Label";
            Label.Size = new Size(136, 39);
            Label.TabIndex = 1;
            Label.Text = "Mobile:";
            Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TableLayoutPanel6
            // 
            TableLayoutPanel6.ColumnCount = 2;
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 332.0f));
            TableLayoutPanel6.Controls.Add(_areaFaxTextBox, 0, 0);
            TableLayoutPanel6.Controls.Add(faxTextBox, 1, 0);
            TableLayoutPanel6.Location = new Point(145, 81);
            TableLayoutPanel6.Name = "TableLayoutPanel6";
            TableLayoutPanel6.RowCount = 1;
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel6.Size = new Size(377, 35);
            TableLayoutPanel6.TabIndex = 7;
            // 
            // areaFaxTextBox
            // 
            _areaFaxTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _areaFaxTextBox.Location = new Point(3, 3);
            _areaFaxTextBox.Name = "_areaFaxTextBox";
            _areaFaxTextBox.Size = new Size(39, 28);
            _areaFaxTextBox.TabIndex = 10;
            // 
            // faxTextBox
            // 
            faxTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            faxTextBox.Location = new Point(48, 3);
            faxTextBox.Name = "faxTextBox";
            faxTextBox.Size = new Size(190, 28);
            faxTextBox.TabIndex = 11;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.ColumnCount = 4;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.10569f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.89431f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58.0f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94.0f));
            TableLayoutPanel3.Controls.Add(Label10, 2, 0);
            TableLayoutPanel3.Controls.Add(extensionTextBox, 3, 0);
            TableLayoutPanel3.Controls.Add(workPhoneTextBox, 1, 0);
            TableLayoutPanel3.Controls.Add(_areaWorkPhoneTextBox, 0, 0);
            TableLayoutPanel3.Location = new Point(145, 42);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel3.Size = new Size(377, 33);
            TableLayoutPanel3.TabIndex = 6;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Dock = DockStyle.Fill;
            Label10.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.Location = new Point(227, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(52, 33);
            Label10.TabIndex = 10;
            Label10.Text = "Ext.:";
            Label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // extensionTextBox
            // 
            extensionTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            extensionTextBox.Location = new Point(285, 3);
            extensionTextBox.Name = "extensionTextBox";
            extensionTextBox.Size = new Size(72, 28);
            extensionTextBox.TabIndex = 9;
            // 
            // workPhoneTextBox
            // 
            workPhoneTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            workPhoneTextBox.Location = new Point(45, 3);
            workPhoneTextBox.Name = "workPhoneTextBox";
            workPhoneTextBox.Size = new Size(176, 28);
            workPhoneTextBox.TabIndex = 8;
            // 
            // areaWorkPhoneTextBox
            // 
            _areaWorkPhoneTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _areaWorkPhoneTextBox.Location = new Point(3, 3);
            _areaWorkPhoneTextBox.Name = "_areaWorkPhoneTextBox";
            _areaWorkPhoneTextBox.Size = new Size(36, 28);
            _areaWorkPhoneTextBox.TabIndex = 7;
            // 
            // TableLayoutPanel5
            // 
            TableLayoutPanel5.ColumnCount = 2;
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.66158f));
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 332.0f));
            TableLayoutPanel5.Controls.Add(_areaMobileTextBox, 0, 0);
            TableLayoutPanel5.Controls.Add(mobileTextBox, 1, 0);
            TableLayoutPanel5.Location = new Point(145, 3);
            TableLayoutPanel5.Name = "TableLayoutPanel5";
            TableLayoutPanel5.RowCount = 1;
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel5.Size = new Size(377, 33);
            TableLayoutPanel5.TabIndex = 5;
            // 
            // areaMobileTextBox
            // 
            _areaMobileTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _areaMobileTextBox.Location = new Point(3, 3);
            _areaMobileTextBox.Name = "_areaMobileTextBox";
            _areaMobileTextBox.Size = new Size(39, 28);
            _areaMobileTextBox.TabIndex = 5;
            // 
            // mobileTextBox
            // 
            mobileTextBox.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            mobileTextBox.Location = new Point(48, 3);
            mobileTextBox.Name = "mobileTextBox";
            mobileTextBox.Size = new Size(190, 28);
            mobileTextBox.TabIndex = 6;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 2;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.23809f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.7619f));
            TableLayoutPanel2.Controls.Add(TableLayoutPanel5, 1, 0);
            TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 1, 1);
            TableLayoutPanel2.Controls.Add(TableLayoutPanel6, 1, 2);
            TableLayoutPanel2.Controls.Add(Label, 0, 0);
            TableLayoutPanel2.Controls.Add(Label9, 0, 1);
            TableLayoutPanel2.Controls.Add(Label8, 0, 2);
            TableLayoutPanel2.Location = new Point(95, 332);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 3;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel2.Size = new Size(525, 119);
            TableLayoutPanel2.TabIndex = 22;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.DarkSlateGray;
            Label14.Location = new Point(89, 62);
            Label14.Name = "Label14";
            Label14.Size = new Size(269, 35);
            Label14.TabIndex = 31;
            Label14.Text = "Add New Contact";
            // 
            // saveButton
            // 
            _saveButton.AllowToggling = false;
            _saveButton.AnimationSpeed = 200;
            _saveButton.AutoGenerateColors = false;
            _saveButton.BackColor = Color.Transparent;
            _saveButton.BackColor1 = Color.Teal;
            _saveButton.BackgroundImage = (Image)resources.GetObject("saveButton.BackgroundImage");
            _saveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _saveButton.ButtonText = "Save";
            _saveButton.ButtonTextMarginLeft = 0;
            _saveButton.ColorContrastOnClick = 45;
            _saveButton.ColorContrastOnHover = 45;
            _saveButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _saveButton.CustomizableEdges = BorderEdges1;
            _saveButton.DialogResult = DialogResult.None;
            _saveButton.DisabledBorderColor = Color.Empty;
            _saveButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _saveButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _saveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _saveButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _saveButton.ForeColor = Color.White;
            _saveButton.IconLeftCursor = Cursors.Hand;
            _saveButton.IconMarginLeft = 11;
            _saveButton.IconPadding = 10;
            _saveButton.IconRightCursor = Cursors.Hand;
            _saveButton.IdleBorderColor = Color.Teal;
            _saveButton.IdleBorderRadius = 3;
            _saveButton.IdleBorderThickness = 1;
            _saveButton.IdleFillColor = Color.Teal;
            _saveButton.IdleIconLeftImage = null;
            _saveButton.IdleIconRightImage = null;
            _saveButton.IndicateFocus = true;
            _saveButton.Location = new Point(836, 649);
            _saveButton.Name = "_saveButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _saveButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _saveButton.OnPressedState = StateProperties2;
            _saveButton.Size = new Size(122, 45);
            _saveButton.TabIndex = 68;
            _saveButton.TextAlign = ContentAlignment.MiddleCenter;
            _saveButton.TextMarginLeft = 0;
            _saveButton.UseDefaultRadiusAndThickness = true;
            // 
            // cancelButton
            // 
            _cancelButton.AccessibleRole = AccessibleRole.Clock;
            _cancelButton.AllowToggling = false;
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
            _cancelButton.IdleBorderColor = Color.DimGray;
            _cancelButton.IdleBorderRadius = 3;
            _cancelButton.IdleBorderThickness = 1;
            _cancelButton.IdleFillColor = Color.White;
            _cancelButton.IdleIconLeftImage = null;
            _cancelButton.IdleIconRightImage = null;
            _cancelButton.IndicateFocus = true;
            _cancelButton.Location = new Point(991, 649);
            _cancelButton.Name = "_cancelButton";
            StateProperties3.BorderColor = Color.Silver;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.Silver;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.DimGray;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties4;
            _cancelButton.Size = new Size(122, 45);
            _cancelButton.TabIndex = 69;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // editButton
            // 
            _editButton.AllowToggling = false;
            _editButton.AnimationSpeed = 200;
            _editButton.AutoGenerateColors = false;
            _editButton.BackColor = Color.Transparent;
            _editButton.BackColor1 = Color.Teal;
            _editButton.BackgroundImage = (Image)resources.GetObject("editButton.BackgroundImage");
            _editButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _editButton.ButtonText = "Edit";
            _editButton.ButtonTextMarginLeft = 0;
            _editButton.ColorContrastOnClick = 45;
            _editButton.ColorContrastOnHover = 45;
            _editButton.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _editButton.CustomizableEdges = BorderEdges3;
            _editButton.DialogResult = DialogResult.None;
            _editButton.DisabledBorderColor = Color.Empty;
            _editButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _editButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _editButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _editButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _editButton.ForeColor = Color.White;
            _editButton.IconLeftCursor = Cursors.Hand;
            _editButton.IconMarginLeft = 11;
            _editButton.IconPadding = 10;
            _editButton.IconRightCursor = Cursors.Hand;
            _editButton.IdleBorderColor = Color.Teal;
            _editButton.IdleBorderRadius = 3;
            _editButton.IdleBorderThickness = 1;
            _editButton.IdleFillColor = Color.Teal;
            _editButton.IdleIconLeftImage = null;
            _editButton.IdleIconRightImage = null;
            _editButton.IndicateFocus = true;
            _editButton.Location = new Point(1044, 437);
            _editButton.Name = "_editButton";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _editButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Teal;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _editButton.OnPressedState = StateProperties6;
            _editButton.Size = new Size(69, 32);
            _editButton.TabIndex = 70;
            _editButton.TextAlign = ContentAlignment.MiddleCenter;
            _editButton.TextMarginLeft = 0;
            _editButton.UseDefaultRadiusAndThickness = true;
            // 
            // FrmAddContact
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1181, 741);
            ControlBox = false;
            Controls.Add(_editButton);
            Controls.Add(_cancelButton);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(_saveButton);
            Controls.Add(Label13);
            Controls.Add(Label14);
            Controls.Add(Label11);
            Controls.Add(companyIDLabel);
            Controls.Add(Label5);
            Controls.Add(TableLayoutPanel2);
            Controls.Add(notesRichTextBox);
            Controls.Add(TableLayoutPanel12);
            Controls.Add(Label17);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmAddContact";
            StartPosition = FormStartPosition.CenterScreen;
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            TableLayoutPanel12.ResumeLayout(false);
            TableLayoutPanel12.PerformLayout();
            TableLayoutPanel6.ResumeLayout(false);
            TableLayoutPanel6.PerformLayout();
            TableLayoutPanel3.ResumeLayout(false);
            TableLayoutPanel3.PerformLayout();
            TableLayoutPanel5.ResumeLayout(false);
            TableLayoutPanel5.PerformLayout();
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label companyIDLabel;
        internal ImageList ImageList1;
        internal Label Label13;
        internal Label Label12;
        internal Label Label3;
        internal Label Label4;
        internal Label Label2;
        internal Label Label1;
        private Label _newDepartamentLabel;

        internal Label newDepartamentLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _newDepartamentLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_newDepartamentLabel != null)
                {
                    _newDepartamentLabel.Click -= newDepartamentLabel_Click;
                }

                _newDepartamentLabel = value;
                if (_newDepartamentLabel != null)
                {
                    _newDepartamentLabel.Click += newDepartamentLabel_Click;
                }
            }
        }

        internal ComboBox departamentComboBox;
        internal TextBox organizationTextBox;
        internal TextBox lastNameTextBox;
        internal TextBox firstNameTextBox;
        internal TextBox emailTextBox;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Label Label11;
        internal Label Label5;
        internal RichTextBox notesRichTextBox;
        internal Label Label17;
        internal Label Label16;
        internal Label Label15;
        internal RichTextBox WorkAddressRichTextBox;
        internal RichTextBox homeAddressRichTextBox;
        internal TableLayoutPanel TableLayoutPanel12;
        internal Label Label8;
        internal Label Label9;
        internal Label Label;
        internal TableLayoutPanel TableLayoutPanel6;
        private TextBox _areaFaxTextBox;

        internal TextBox areaFaxTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _areaFaxTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_areaFaxTextBox != null)
                {
                    _areaFaxTextBox.KeyPress -= areaFaxTextBox_TextChanged;
                }

                _areaFaxTextBox = value;
                if (_areaFaxTextBox != null)
                {
                    _areaFaxTextBox.KeyPress += areaFaxTextBox_TextChanged;
                }
            }
        }

        internal TextBox faxTextBox;
        internal TableLayoutPanel TableLayoutPanel3;
        internal Label Label10;
        internal TextBox extensionTextBox;
        internal TextBox workPhoneTextBox;
        private TextBox _areaWorkPhoneTextBox;

        internal TextBox areaWorkPhoneTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _areaWorkPhoneTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_areaWorkPhoneTextBox != null)
                {
                    _areaWorkPhoneTextBox.KeyPress -= areaWorkPhoneTextBox_TextChanged;
                }

                _areaWorkPhoneTextBox = value;
                if (_areaWorkPhoneTextBox != null)
                {
                    _areaWorkPhoneTextBox.KeyPress += areaWorkPhoneTextBox_TextChanged;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel5;
        private TextBox _areaMobileTextBox;

        internal TextBox areaMobileTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _areaMobileTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_areaMobileTextBox != null)
                {
                    _areaMobileTextBox.KeyPress -= areaMobileTextBox_TextChanged;
                }

                _areaMobileTextBox = value;
                if (_areaMobileTextBox != null)
                {
                    _areaMobileTextBox.KeyPress += areaMobileTextBox_TextChanged;
                }
            }
        }

        internal TextBox mobileTextBox;
        internal TableLayoutPanel TableLayoutPanel2;
        internal Label Label14;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _saveButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton saveButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _saveButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_saveButton != null)
                {
                    _saveButton.Click -= saveButton_Click;
                }

                _saveButton = value;
                if (_saveButton != null)
                {
                    _saveButton.Click += saveButton_Click;
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
                    _cancelButton.Click -= cancelButton_Click;
                }

                _cancelButton = value;
                if (_cancelButton != null)
                {
                    _cancelButton.Click += cancelButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _editButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton editButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _editButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_editButton != null)
                {
                    _editButton.Click -= Button1_Click;
                }

                _editButton = value;
                if (_editButton != null)
                {
                    _editButton.Click += Button1_Click;
                }
            }
        }
    }
}