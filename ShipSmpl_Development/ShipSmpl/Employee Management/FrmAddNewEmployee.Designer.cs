using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAddNewEmployee : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewEmployee));
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
            emergencyLastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            Label19 = new Label();
            adressTextBox = new TextBox();
            addressLabel = new Label();
            _phoneNumberTextBox = new TextBox();
            _phoneNumberTextBox.LostFocus += new EventHandler(phoneNumberTextBox_LostFocus);
            aliasTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            _firstNameTextBox = new TextBox();
            _firstNameTextBox.TextChanged += new EventHandler(firstNameTextBox_TextChanged_1);
            firstNameLabel = new Label();
            Label1 = new Label();
            phoneNumberLabel = new Label();
            Label13 = new Label();
            Label18 = new Label();
            certificationsTabPage = new Dotnetrix.Controls.TabPageEX();
            Panel4 = new Panel();
            GroupBox5 = new GroupBox();
            SkillsCertificationPictureBox = new PictureBox();
            _skillsCertificationButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _skillsCertificationButton.Click += new EventHandler(skillsCertificationButton_Click);
            titleSkillsAndCertificationLabel = new Label();
            Label14 = new Label();
            Label2 = new Label();
            Panel2 = new Panel();
            TableLayoutPanel3 = new TableLayoutPanel();
            yardManagerCheckBox = new CheckBox();
            warehouseCheckBox = new CheckBox();
            bulk_HeadsCheckBox = new CheckBox();
            BulkCheckBox = new CheckBox();
            bagTipperCheckBox = new CheckBox();
            baggerCheckBox = new CheckBox();
            bagCheckBox = new CheckBox();
            driverLicenseCheckBox = new CheckBox();
            emptyMachineCheckBox = new CheckBox();
            _firstAidCheckBox = new CheckBox();
            _firstAidCheckBox.CheckedChanged += new EventHandler(firstAidCheckBox_CheckedChanged);
            reachstacherCheckBox = new CheckBox();
            railcarMoverCheckBox8 = new CheckBox();
            firstAidComboBox = new ComboBox();
            _700HysterCheckBox6 = new CheckBox();
            _otherCheckBox = new CheckBox();
            _otherCheckBox.CheckedChanged += new EventHandler(otherCheckBox_CheckedChanged);
            otherTextBox = new RichTextBox();
            Label9 = new Label();
            emergencyFirstNameTextBox = new TextBox();
            Label10 = new Label();
            Label11 = new Label();
            emergencyPhoneNumberLabel = new Label();
            _emergencyPhoneNumberTextBox = new TextBox();
            _emergencyPhoneNumberTextBox.LostFocus += new EventHandler(emergencyPhoneNumberTextBox_LostFocus);
            titleScanLabel = new Label();
            cardIDTabPage = new Dotnetrix.Controls.TabPageEX();
            _FinishButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _FinishButton.Click += new EventHandler(Button4_Click);
            ScanCardPictureBox = new PictureBox();
            genderComboBox = new ComboBox();
            TabPageEX1 = new Dotnetrix.Controls.TabPageEX();
            _personalInfoButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _personalInfoButton.Click += new EventHandler(Button2_Click);
            titlePersonalInfoLabel = new Label();
            Panel3 = new Panel();
            GroupBox3 = new GroupBox();
            employeePictureBox = new PictureBox();
            _uploadPhotoButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _uploadPhotoButton.Click += new EventHandler(Button1_Click);
            GroupBox2 = new GroupBox();
            TableLayoutPanel5 = new TableLayoutPanel();
            jobDescriptionComboBox = new ComboBox();
            typeComboBox = new ComboBox();
            Label7 = new Label();
            Label22 = new Label();
            Label8 = new Label();
            yardComboBox = new ComboBox();
            Label23 = new Label();
            Label21 = new Label();
            payMehodComboBox = new ComboBox();
            supervisorTextBox = new TextBox();
            Label4 = new Label();
            startDateDateTimePicker = new DateTimePicker();
            GroupBox1 = new GroupBox();
            TableLayoutPanel1 = new TableLayoutPanel();
            cardAddignedLabel = new CustomizedControlsLibrary.ShapedLabel();
            Label16 = new Label();
            SINumbTextBox = new TextBox();
            birthdateDateTimePicker = new DateTimePicker();
            Label15 = new Label();
            GroupBox4 = new GroupBox();
            TableLayoutPanel2 = new TableLayoutPanel();
            relationshipTextBox = new TextBox();
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel1 = new Panel();
            _newEmployeeTabControl = new Dotnetrix.Controls.TabControlEX();
            _newEmployeeTabControl.KeyDown += new KeyEventHandler(Key_press_KeyDown);
            certificationsTabPage.SuspendLayout();
            Panel4.SuspendLayout();
            GroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SkillsCertificationPictureBox).BeginInit();
            Panel2.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            cardIDTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScanCardPictureBox).BeginInit();
            TabPageEX1.SuspendLayout();
            Panel3.SuspendLayout();
            GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeePictureBox).BeginInit();
            GroupBox2.SuspendLayout();
            TableLayoutPanel5.SuspendLayout();
            GroupBox1.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            GroupBox4.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            BunifuShadowPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            _newEmployeeTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // emergencyLastNameTextBox
            // 
            emergencyLastNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emergencyLastNameTextBox.CharacterCasing = CharacterCasing.Upper;
            emergencyLastNameTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            emergencyLastNameTextBox.Location = new Point(198, 44);
            emergencyLastNameTextBox.Margin = new Padding(2);
            emergencyLastNameTextBox.MaxLength = 30;
            emergencyLastNameTextBox.Name = "emergencyLastNameTextBox";
            emergencyLastNameTextBox.Size = new Size(327, 31);
            emergencyLastNameTextBox.TabIndex = 16;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.CharacterCasing = CharacterCasing.Upper;
            emailTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            emailTextBox.Location = new Point(211, 222);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.MaxLength = 50;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(337, 31);
            emailTextBox.TabIndex = 26;
            // 
            // Label19
            // 
            Label19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label19.AutoSize = true;
            Label19.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label19.Location = new Point(130, 220);
            Label19.Margin = new Padding(2, 0, 2, 0);
            Label19.Name = "Label19";
            Label19.Size = new Size(77, 25);
            Label19.TabIndex = 26;
            Label19.Text = "   Email:";
            Label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // adressTextBox
            // 
            adressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adressTextBox.CharacterCasing = CharacterCasing.Upper;
            adressTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            adressTextBox.Location = new Point(211, 178);
            adressTextBox.Margin = new Padding(2);
            adressTextBox.MaxLength = 95;
            adressTextBox.Name = "adressTextBox";
            adressTextBox.Size = new Size(337, 31);
            adressTextBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            addressLabel.Location = new Point(40, 176);
            addressLabel.Margin = new Padding(2, 0, 2, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(167, 25);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "   Mailing Address:";
            addressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // phoneNumberTextBox
            // 
            _phoneNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _phoneNumberTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _phoneNumberTextBox.Location = new Point(211, 134);
            _phoneNumberTextBox.Margin = new Padding(2);
            _phoneNumberTextBox.MaxLength = 15;
            _phoneNumberTextBox.Name = "_phoneNumberTextBox";
            _phoneNumberTextBox.Size = new Size(337, 31);
            _phoneNumberTextBox.TabIndex = 4;
            // 
            // aliasTextBox
            // 
            aliasTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aliasTextBox.CharacterCasing = CharacterCasing.Upper;
            aliasTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            aliasTextBox.Location = new Point(211, 90);
            aliasTextBox.Margin = new Padding(2);
            aliasTextBox.MaxLength = 30;
            aliasTextBox.Name = "aliasTextBox";
            aliasTextBox.Size = new Size(337, 31);
            aliasTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lastNameTextBox.CharacterCasing = CharacterCasing.Upper;
            lastNameTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lastNameTextBox.Location = new Point(211, 46);
            lastNameTextBox.Margin = new Padding(2);
            lastNameTextBox.MaxLength = 30;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(337, 31);
            lastNameTextBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lastNameLabel.Location = new Point(90, 44);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(117, 25);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "* Last Name:";
            lastNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // firstNameTextBox
            // 
            _firstNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _firstNameTextBox.CharacterCasing = CharacterCasing.Upper;
            _firstNameTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _firstNameTextBox.Location = new Point(211, 2);
            _firstNameTextBox.Margin = new Padding(2);
            _firstNameTextBox.MaxLength = 30;
            _firstNameTextBox.Name = "_firstNameTextBox";
            _firstNameTextBox.Size = new Size(337, 31);
            _firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            firstNameLabel.Location = new Point(88, 0);
            firstNameLabel.Margin = new Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(119, 25);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "* First Name:";
            firstNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(136, 88);
            Label1.Margin = new Padding(2, 0, 2, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(71, 25);
            Label1.TabIndex = 5;
            Label1.Text = "   Alias:";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            phoneNumberLabel.Location = new Point(48, 132);
            phoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(159, 25);
            phoneNumberLabel.TabIndex = 1;
            phoneNumberLabel.Text = "   Phone Number:";
            phoneNumberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            Label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label13.AutoSize = true;
            Label13.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.Location = new Point(113, 396);
            Label13.Margin = new Padding(2, 0, 2, 0);
            Label13.Name = "Label13";
            Label13.Size = new Size(94, 25);
            Label13.TabIndex = 15;
            Label13.Text = "   Card ID:";
            Label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label18
            // 
            Label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label18.AutoSize = true;
            Label18.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.Location = new Point(116, 352);
            Label18.Margin = new Padding(2, 0, 2, 0);
            Label18.Name = "Label18";
            Label18.Size = new Size(91, 25);
            Label18.TabIndex = 27;
            Label18.Text = "* Gender:";
            Label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // certificationsTabPage
            // 
            certificationsTabPage.BackColor = Color.White;
            certificationsTabPage.Controls.Add(Panel4);
            certificationsTabPage.Controls.Add(_skillsCertificationButton);
            certificationsTabPage.Controls.Add(titleSkillsAndCertificationLabel);
            certificationsTabPage.Controls.Add(Label14);
            certificationsTabPage.Controls.Add(Label2);
            certificationsTabPage.Controls.Add(Panel2);
            certificationsTabPage.Location = new Point(4, 39);
            certificationsTabPage.Name = "certificationsTabPage";
            certificationsTabPage.Size = new Size(1544, 828);
            certificationsTabPage.TabIndex = 1;
            certificationsTabPage.Text = "Skills and Certifications";
            // 
            // Panel4
            // 
            Panel4.Controls.Add(GroupBox5);
            Panel4.Location = new Point(1312, 102);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(181, 276);
            Panel4.TabIndex = 72;
            // 
            // GroupBox5
            // 
            GroupBox5.Controls.Add(SkillsCertificationPictureBox);
            GroupBox5.Dock = DockStyle.Top;
            GroupBox5.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            GroupBox5.Location = new Point(0, 0);
            GroupBox5.Name = "GroupBox5";
            GroupBox5.Padding = new Padding(3, 11, 3, 3);
            GroupBox5.Size = new Size(181, 236);
            GroupBox5.TabIndex = 28;
            GroupBox5.TabStop = false;
            GroupBox5.Text = "Photo";
            // 
            // SkillsCertificationPictureBox
            // 
            SkillsCertificationPictureBox.Anchor = AnchorStyles.None;
            SkillsCertificationPictureBox.BackgroundImage = (Image)resources.GetObject("SkillsCertificationPictureBox.BackgroundImage");
            SkillsCertificationPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            SkillsCertificationPictureBox.Location = new Point(5, 30);
            SkillsCertificationPictureBox.Margin = new Padding(2);
            SkillsCertificationPictureBox.Name = "SkillsCertificationPictureBox";
            SkillsCertificationPictureBox.Size = new Size(171, 199);
            SkillsCertificationPictureBox.TabIndex = 36;
            SkillsCertificationPictureBox.TabStop = false;
            // 
            // skillsCertificationButton
            // 
            _skillsCertificationButton.AllowToggling = false;
            _skillsCertificationButton.Anchor = AnchorStyles.Right;
            _skillsCertificationButton.AnimationSpeed = 200;
            _skillsCertificationButton.AutoGenerateColors = false;
            _skillsCertificationButton.BackColor = Color.Transparent;
            _skillsCertificationButton.BackColor1 = Color.Teal;
            _skillsCertificationButton.BackgroundImage = (Image)resources.GetObject("skillsCertificationButton.BackgroundImage");
            _skillsCertificationButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _skillsCertificationButton.ButtonText = "Save and Continue";
            _skillsCertificationButton.ButtonTextMarginLeft = 0;
            _skillsCertificationButton.ColorContrastOnClick = 45;
            _skillsCertificationButton.ColorContrastOnHover = 45;
            _skillsCertificationButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _skillsCertificationButton.CustomizableEdges = BorderEdges1;
            _skillsCertificationButton.DialogResult = DialogResult.None;
            _skillsCertificationButton.DisabledBorderColor = Color.Empty;
            _skillsCertificationButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _skillsCertificationButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _skillsCertificationButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _skillsCertificationButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _skillsCertificationButton.ForeColor = Color.White;
            _skillsCertificationButton.IconLeftCursor = Cursors.Hand;
            _skillsCertificationButton.IconMarginLeft = 11;
            _skillsCertificationButton.IconPadding = 10;
            _skillsCertificationButton.IconRightCursor = Cursors.Hand;
            _skillsCertificationButton.IdleBorderColor = Color.Teal;
            _skillsCertificationButton.IdleBorderRadius = 3;
            _skillsCertificationButton.IdleBorderThickness = 1;
            _skillsCertificationButton.IdleFillColor = Color.Teal;
            _skillsCertificationButton.IdleIconLeftImage = null;
            _skillsCertificationButton.IdleIconRightImage = null;
            _skillsCertificationButton.IndicateFocus = true;
            _skillsCertificationButton.Location = new Point(1310, 733);
            _skillsCertificationButton.Name = "_skillsCertificationButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _skillsCertificationButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _skillsCertificationButton.OnPressedState = StateProperties2;
            _skillsCertificationButton.Size = new Size(178, 45);
            _skillsCertificationButton.TabIndex = 71;
            _skillsCertificationButton.TextAlign = ContentAlignment.MiddleCenter;
            _skillsCertificationButton.TextMarginLeft = 0;
            _skillsCertificationButton.UseDefaultRadiusAndThickness = true;
            // 
            // titleSkillsAndCertificationLabel
            // 
            titleSkillsAndCertificationLabel.BackColor = Color.Transparent;
            titleSkillsAndCertificationLabel.FlatStyle = FlatStyle.Flat;
            titleSkillsAndCertificationLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleSkillsAndCertificationLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titleSkillsAndCertificationLabel.Location = new Point(267, 30);
            titleSkillsAndCertificationLabel.Margin = new Padding(2, 0, 2, 0);
            titleSkillsAndCertificationLabel.Name = "titleSkillsAndCertificationLabel";
            titleSkillsAndCertificationLabel.Size = new Size(824, 49);
            titleSkillsAndCertificationLabel.TabIndex = 40;
            titleSkillsAndCertificationLabel.Text = "Fill up all the skills and certifications that apply";
            titleSkillsAndCertificationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label14
            // 
            Label14.Anchor = AnchorStyles.None;
            Label14.AutoSize = true;
            Label14.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.Black;
            Label14.Location = new Point(812, 108);
            Label14.Margin = new Padding(2, 0, 2, 0);
            Label14.Name = "Label14";
            Label14.Size = new Size(127, 25);
            Label14.TabIndex = 39;
            Label14.Text = "Certifications";
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.None;
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.Black;
            Label2.Location = new Point(300, 108);
            Label2.Margin = new Padding(2, 0, 2, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(55, 25);
            Label2.TabIndex = 38;
            Label2.Text = "Skills";
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.None;
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(TableLayoutPanel3);
            Panel2.Controls.Add(_otherCheckBox);
            Panel2.Controls.Add(otherTextBox);
            Panel2.ForeColor = Color.Black;
            Panel2.Location = new Point(267, 125);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(895, 653);
            Panel2.TabIndex = 37;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutPanel3.AutoSize = true;
            TableLayoutPanel3.ColumnCount = 3;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 164.0f));
            TableLayoutPanel3.Controls.Add(yardManagerCheckBox, 0, 6);
            TableLayoutPanel3.Controls.Add(warehouseCheckBox, 0, 5);
            TableLayoutPanel3.Controls.Add(bulk_HeadsCheckBox, 0, 4);
            TableLayoutPanel3.Controls.Add(BulkCheckBox, 0, 3);
            TableLayoutPanel3.Controls.Add(bagTipperCheckBox, 0, 2);
            TableLayoutPanel3.Controls.Add(baggerCheckBox, 0, 1);
            TableLayoutPanel3.Controls.Add(bagCheckBox, 0, 0);
            TableLayoutPanel3.Controls.Add(driverLicenseCheckBox, 1, 1);
            TableLayoutPanel3.Controls.Add(emptyMachineCheckBox, 1, 2);
            TableLayoutPanel3.Controls.Add(_firstAidCheckBox, 1, 3);
            TableLayoutPanel3.Controls.Add(reachstacherCheckBox, 1, 5);
            TableLayoutPanel3.Controls.Add(railcarMoverCheckBox8, 1, 4);
            TableLayoutPanel3.Controls.Add(firstAidComboBox, 2, 3);
            TableLayoutPanel3.Controls.Add(_700HysterCheckBox6, 1, 0);
            TableLayoutPanel3.Font = new Font("Microsoft Sans Serif", 14.14286f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel3.Location = new Point(37, 33);
            TableLayoutPanel3.Margin = new Padding(2);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 7;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 41.0f));
            TableLayoutPanel3.Size = new Size(838, 344);
            TableLayoutPanel3.TabIndex = 22;
            // 
            // yardManagerCheckBox
            // 
            yardManagerCheckBox.AutoSize = true;
            yardManagerCheckBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            yardManagerCheckBox.Location = new Point(2, 302);
            yardManagerCheckBox.Margin = new Padding(2);
            yardManagerCheckBox.Name = "yardManagerCheckBox";
            yardManagerCheckBox.Size = new Size(149, 29);
            yardManagerCheckBox.TabIndex = 34;
            yardManagerCheckBox.Text = "Yard Manager";
            yardManagerCheckBox.UseVisualStyleBackColor = true;
            // 
            // warehouseCheckBox
            // 
            warehouseCheckBox.AutoSize = true;
            warehouseCheckBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            warehouseCheckBox.Location = new Point(2, 252);
            warehouseCheckBox.Margin = new Padding(2);
            warehouseCheckBox.Name = "warehouseCheckBox";
            warehouseCheckBox.Size = new Size(126, 29);
            warehouseCheckBox.TabIndex = 33;
            warehouseCheckBox.Text = "Warehouse";
            warehouseCheckBox.UseVisualStyleBackColor = true;
            // 
            // bulk_HeadsCheckBox
            // 
            bulk_HeadsCheckBox.AutoSize = true;
            bulk_HeadsCheckBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            bulk_HeadsCheckBox.Location = new Point(2, 202);
            bulk_HeadsCheckBox.Margin = new Padding(2);
            bulk_HeadsCheckBox.Name = "bulk_HeadsCheckBox";
            bulk_HeadsCheckBox.Size = new Size(124, 29);
            bulk_HeadsCheckBox.TabIndex = 30;
            bulk_HeadsCheckBox.Text = "Bulk Heads";
            bulk_HeadsCheckBox.UseVisualStyleBackColor = true;
            // 
            // BulkCheckBox
            // 
            BulkCheckBox.AutoSize = true;
            BulkCheckBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BulkCheckBox.Location = new Point(2, 152);
            BulkCheckBox.Margin = new Padding(2);
            BulkCheckBox.Name = "BulkCheckBox";
            BulkCheckBox.Size = new Size(67, 29);
            BulkCheckBox.TabIndex = 24;
            BulkCheckBox.Text = "Bulk";
            BulkCheckBox.UseVisualStyleBackColor = true;
            // 
            // bagTipperCheckBox
            // 
            bagTipperCheckBox.AutoSize = true;
            bagTipperCheckBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            bagTipperCheckBox.Location = new Point(2, 102);
            bagTipperCheckBox.Margin = new Padding(2);
            bagTipperCheckBox.Name = "bagTipperCheckBox";
            bagTipperCheckBox.Size = new Size(122, 29);
            bagTipperCheckBox.TabIndex = 23;
            bagTipperCheckBox.Text = "Bag Tipper";
            bagTipperCheckBox.UseVisualStyleBackColor = true;
            // 
            // baggerCheckBox
            // 
            baggerCheckBox.AutoSize = true;
            baggerCheckBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            baggerCheckBox.Location = new Point(2, 52);
            baggerCheckBox.Margin = new Padding(2);
            baggerCheckBox.Name = "baggerCheckBox";
            baggerCheckBox.Size = new Size(91, 29);
            baggerCheckBox.TabIndex = 22;
            baggerCheckBox.Text = "Bagger";
            baggerCheckBox.UseVisualStyleBackColor = true;
            // 
            // bagCheckBox
            // 
            bagCheckBox.AutoSize = true;
            bagCheckBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            bagCheckBox.Location = new Point(2, 2);
            bagCheckBox.Margin = new Padding(2);
            bagCheckBox.Name = "bagCheckBox";
            bagCheckBox.Size = new Size(63, 29);
            bagCheckBox.TabIndex = 21;
            bagCheckBox.Text = "Bag";
            bagCheckBox.UseVisualStyleBackColor = true;
            // 
            // driverLicenseCheckBox
            // 
            driverLicenseCheckBox.AutoSize = true;
            driverLicenseCheckBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            driverLicenseCheckBox.Location = new Point(511, 52);
            driverLicenseCheckBox.Margin = new Padding(2);
            driverLicenseCheckBox.Name = "driverLicenseCheckBox";
            driverLicenseCheckBox.Size = new Size(149, 29);
            driverLicenseCheckBox.TabIndex = 25;
            driverLicenseCheckBox.Text = "Driver License";
            driverLicenseCheckBox.UseVisualStyleBackColor = true;
            // 
            // emptyMachineCheckBox
            // 
            emptyMachineCheckBox.AutoSize = true;
            emptyMachineCheckBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            emptyMachineCheckBox.Location = new Point(511, 102);
            emptyMachineCheckBox.Margin = new Padding(2);
            emptyMachineCheckBox.Name = "emptyMachineCheckBox";
            emptyMachineCheckBox.Size = new Size(161, 29);
            emptyMachineCheckBox.TabIndex = 27;
            emptyMachineCheckBox.Text = "Empty Machine";
            emptyMachineCheckBox.UseVisualStyleBackColor = true;
            // 
            // firstAidCheckBox
            // 
            _firstAidCheckBox.AutoSize = true;
            _firstAidCheckBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _firstAidCheckBox.Location = new Point(511, 152);
            _firstAidCheckBox.Margin = new Padding(2);
            _firstAidCheckBox.Name = "_firstAidCheckBox";
            _firstAidCheckBox.Size = new Size(99, 29);
            _firstAidCheckBox.TabIndex = 31;
            _firstAidCheckBox.Text = "First Aid";
            _firstAidCheckBox.UseVisualStyleBackColor = true;
            // 
            // reachstacherCheckBox
            // 
            reachstacherCheckBox.AutoSize = true;
            reachstacherCheckBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            reachstacherCheckBox.Location = new Point(511, 252);
            reachstacherCheckBox.Margin = new Padding(2);
            reachstacherCheckBox.Name = "reachstacherCheckBox";
            reachstacherCheckBox.Size = new Size(140, 29);
            reachstacherCheckBox.TabIndex = 29;
            reachstacherCheckBox.Text = "Reachstacker";
            reachstacherCheckBox.UseVisualStyleBackColor = true;
            // 
            // railcarMoverCheckBox8
            // 
            railcarMoverCheckBox8.AutoSize = true;
            railcarMoverCheckBox8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            railcarMoverCheckBox8.Location = new Point(511, 202);
            railcarMoverCheckBox8.Margin = new Padding(2);
            railcarMoverCheckBox8.Name = "railcarMoverCheckBox8";
            railcarMoverCheckBox8.Size = new Size(147, 29);
            railcarMoverCheckBox8.TabIndex = 28;
            railcarMoverCheckBox8.Text = "Railcar Mover";
            railcarMoverCheckBox8.UseVisualStyleBackColor = true;
            // 
            // firstAidComboBox
            // 
            firstAidComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            firstAidComboBox.Font = new Font("Microsoft Sans Serif", 12.0f);
            firstAidComboBox.FormattingEnabled = true;
            firstAidComboBox.Items.AddRange(new object[] { "Level A", "Level C", "Level HCP" });
            firstAidComboBox.Location = new Point(676, 152);
            firstAidComboBox.Margin = new Padding(2);
            firstAidComboBox.Name = "firstAidComboBox";
            firstAidComboBox.Size = new Size(134, 30);
            firstAidComboBox.TabIndex = 32;
            firstAidComboBox.Visible = false;
            // 
            // _700HysterCheckBox6
            // 
            _700HysterCheckBox6.AutoSize = true;
            _700HysterCheckBox6.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _700HysterCheckBox6.Location = new Point(511, 2);
            _700HysterCheckBox6.Margin = new Padding(2);
            _700HysterCheckBox6.Name = "_700HysterCheckBox6";
            _700HysterCheckBox6.Size = new Size(119, 29);
            _700HysterCheckBox6.TabIndex = 26;
            _700HysterCheckBox6.Text = "700 Hyster";
            _700HysterCheckBox6.UseVisualStyleBackColor = true;
            // 
            // otherCheckBox
            // 
            _otherCheckBox.Anchor = AnchorStyles.None;
            _otherCheckBox.AutoSize = true;
            _otherCheckBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _otherCheckBox.Location = new Point(39, 422);
            _otherCheckBox.Margin = new Padding(2);
            _otherCheckBox.Name = "_otherCheckBox";
            _otherCheckBox.Size = new Size(79, 29);
            _otherCheckBox.TabIndex = 31;
            _otherCheckBox.Text = "Other";
            _otherCheckBox.UseVisualStyleBackColor = true;
            // 
            // otherTextBox
            // 
            otherTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            otherTextBox.Location = new Point(39, 437);
            otherTextBox.Margin = new Padding(2);
            otherTextBox.Name = "otherTextBox";
            otherTextBox.Size = new Size(634, 154);
            otherTextBox.TabIndex = 20;
            otherTextBox.Text = "";
            otherTextBox.Visible = false;
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.Location = new Point(75, 42);
            Label9.Margin = new Padding(2, 0, 2, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(119, 25);
            Label9.TabIndex = 2;
            Label9.Text = "   Last Name:";
            Label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emergencyFirstNameTextBox
            // 
            emergencyFirstNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emergencyFirstNameTextBox.CharacterCasing = CharacterCasing.Upper;
            emergencyFirstNameTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            emergencyFirstNameTextBox.Location = new Point(198, 2);
            emergencyFirstNameTextBox.Margin = new Padding(2);
            emergencyFirstNameTextBox.MaxLength = 30;
            emergencyFirstNameTextBox.Name = "emergencyFirstNameTextBox";
            emergencyFirstNameTextBox.Size = new Size(327, 31);
            emergencyFirstNameTextBox.TabIndex = 15;
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.Location = new Point(73, 0);
            Label10.Margin = new Padding(2, 0, 2, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(121, 25);
            Label10.TabIndex = 0;
            Label10.Text = "   First Name:";
            Label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label11
            // 
            Label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label11.AutoSize = true;
            Label11.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.Location = new Point(60, 126);
            Label11.Margin = new Padding(2, 0, 2, 0);
            Label11.Name = "Label11";
            Label11.Size = new Size(134, 25);
            Label11.TabIndex = 5;
            Label11.Text = "   Relationship:";
            Label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emergencyPhoneNumberLabel
            // 
            emergencyPhoneNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            emergencyPhoneNumberLabel.AutoSize = true;
            emergencyPhoneNumberLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            emergencyPhoneNumberLabel.Location = new Point(35, 84);
            emergencyPhoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            emergencyPhoneNumberLabel.Name = "emergencyPhoneNumberLabel";
            emergencyPhoneNumberLabel.Size = new Size(159, 25);
            emergencyPhoneNumberLabel.TabIndex = 1;
            emergencyPhoneNumberLabel.Text = "   Phone Number:";
            emergencyPhoneNumberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emergencyPhoneNumberTextBox
            // 
            _emergencyPhoneNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _emergencyPhoneNumberTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _emergencyPhoneNumberTextBox.Location = new Point(198, 86);
            _emergencyPhoneNumberTextBox.Margin = new Padding(2);
            _emergencyPhoneNumberTextBox.MaxLength = 15;
            _emergencyPhoneNumberTextBox.Name = "_emergencyPhoneNumberTextBox";
            _emergencyPhoneNumberTextBox.Size = new Size(327, 31);
            _emergencyPhoneNumberTextBox.TabIndex = 17;
            // 
            // titleScanLabel
            // 
            titleScanLabel.Anchor = AnchorStyles.None;
            titleScanLabel.BackColor = Color.Transparent;
            titleScanLabel.FlatStyle = FlatStyle.Flat;
            titleScanLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleScanLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titleScanLabel.Location = new Point(366, 29);
            titleScanLabel.Margin = new Padding(2, 0, 2, 0);
            titleScanLabel.Name = "titleScanLabel";
            titleScanLabel.Size = new Size(755, 58);
            titleScanLabel.TabIndex = 21;
            titleScanLabel.Text = "Please scan the card assigned to employee";
            titleScanLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardIDTabPage
            // 
            cardIDTabPage.BackColor = Color.White;
            cardIDTabPage.Controls.Add(_FinishButton);
            cardIDTabPage.Controls.Add(titleScanLabel);
            cardIDTabPage.Controls.Add(ScanCardPictureBox);
            cardIDTabPage.Location = new Point(4, 39);
            cardIDTabPage.Name = "cardIDTabPage";
            cardIDTabPage.Size = new Size(1544, 828);
            cardIDTabPage.TabIndex = 2;
            cardIDTabPage.Text = "Card ID";
            // 
            // FinishButton
            // 
            _FinishButton.AllowToggling = false;
            _FinishButton.Anchor = AnchorStyles.None;
            _FinishButton.AnimationSpeed = 200;
            _FinishButton.AutoGenerateColors = false;
            _FinishButton.BackColor = Color.Transparent;
            _FinishButton.BackColor1 = Color.Teal;
            _FinishButton.BackgroundImage = (Image)resources.GetObject("FinishButton.BackgroundImage");
            _FinishButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _FinishButton.ButtonText = "Cancel";
            _FinishButton.ButtonTextMarginLeft = 0;
            _FinishButton.ColorContrastOnClick = 45;
            _FinishButton.ColorContrastOnHover = 45;
            _FinishButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _FinishButton.CustomizableEdges = BorderEdges2;
            _FinishButton.DialogResult = DialogResult.None;
            _FinishButton.DisabledBorderColor = Color.Empty;
            _FinishButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _FinishButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _FinishButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _FinishButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _FinishButton.ForeColor = Color.White;
            _FinishButton.IconLeftCursor = Cursors.Hand;
            _FinishButton.IconMarginLeft = 11;
            _FinishButton.IconPadding = 10;
            _FinishButton.IconRightCursor = Cursors.Hand;
            _FinishButton.IdleBorderColor = Color.Teal;
            _FinishButton.IdleBorderRadius = 3;
            _FinishButton.IdleBorderThickness = 1;
            _FinishButton.IdleFillColor = Color.Teal;
            _FinishButton.IdleIconLeftImage = null;
            _FinishButton.IdleIconRightImage = null;
            _FinishButton.IndicateFocus = true;
            _FinishButton.Location = new Point(668, 678);
            _FinishButton.Name = "_FinishButton";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _FinishButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _FinishButton.OnPressedState = StateProperties4;
            _FinishButton.Size = new Size(178, 45);
            _FinishButton.TabIndex = 71;
            _FinishButton.TextAlign = ContentAlignment.MiddleCenter;
            _FinishButton.TextMarginLeft = 0;
            _FinishButton.UseDefaultRadiusAndThickness = true;
            // 
            // ScanCardPictureBox
            // 
            ScanCardPictureBox.Anchor = AnchorStyles.None;
            ScanCardPictureBox.BackgroundImage = My.Resources.Resources.tapCardIcon2;
            ScanCardPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            ScanCardPictureBox.Location = new Point(598, 108);
            ScanCardPictureBox.Margin = new Padding(2);
            ScanCardPictureBox.Name = "ScanCardPictureBox";
            ScanCardPictureBox.Size = new Size(315, 406);
            ScanCardPictureBox.TabIndex = 20;
            ScanCardPictureBox.TabStop = false;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            genderComboBox.FormattingEnabled = true;
            genderComboBox.ItemHeight = 25;
            genderComboBox.Items.AddRange(new object[] { "Female", "Male" });
            genderComboBox.Location = new Point(211, 354);
            genderComboBox.Margin = new Padding(2);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(207, 33);
            genderComboBox.TabIndex = 8;
            // 
            // TabPageEX1
            // 
            TabPageEX1.BackColor = Color.White;
            TabPageEX1.Controls.Add(_personalInfoButton);
            TabPageEX1.Controls.Add(titlePersonalInfoLabel);
            TabPageEX1.Controls.Add(Panel3);
            TabPageEX1.Controls.Add(GroupBox2);
            TabPageEX1.Controls.Add(GroupBox1);
            TabPageEX1.Controls.Add(GroupBox4);
            TabPageEX1.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TabPageEX1.Location = new Point(4, 39);
            TabPageEX1.Name = "TabPageEX1";
            TabPageEX1.Size = new Size(1544, 828);
            TabPageEX1.TabIndex = 0;
            TabPageEX1.Text = "Personal Info";
            // 
            // personalInfoButton
            // 
            _personalInfoButton.AllowToggling = false;
            _personalInfoButton.AnimationSpeed = 200;
            _personalInfoButton.AutoGenerateColors = false;
            _personalInfoButton.BackColor = Color.Transparent;
            _personalInfoButton.BackColor1 = Color.Teal;
            _personalInfoButton.BackgroundImage = (Image)resources.GetObject("personalInfoButton.BackgroundImage");
            _personalInfoButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _personalInfoButton.ButtonText = "Save and Continue";
            _personalInfoButton.ButtonTextMarginLeft = 0;
            _personalInfoButton.ColorContrastOnClick = 45;
            _personalInfoButton.ColorContrastOnHover = 45;
            _personalInfoButton.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _personalInfoButton.CustomizableEdges = BorderEdges3;
            _personalInfoButton.DialogResult = DialogResult.None;
            _personalInfoButton.DisabledBorderColor = Color.Empty;
            _personalInfoButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _personalInfoButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _personalInfoButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _personalInfoButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _personalInfoButton.ForeColor = Color.White;
            _personalInfoButton.IconLeftCursor = Cursors.Hand;
            _personalInfoButton.IconMarginLeft = 11;
            _personalInfoButton.IconPadding = 10;
            _personalInfoButton.IconRightCursor = Cursors.Hand;
            _personalInfoButton.IdleBorderColor = Color.Teal;
            _personalInfoButton.IdleBorderRadius = 3;
            _personalInfoButton.IdleBorderThickness = 1;
            _personalInfoButton.IdleFillColor = Color.Teal;
            _personalInfoButton.IdleIconLeftImage = null;
            _personalInfoButton.IdleIconRightImage = null;
            _personalInfoButton.IndicateFocus = true;
            _personalInfoButton.Location = new Point(1315, 756);
            _personalInfoButton.Name = "_personalInfoButton";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _personalInfoButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Teal;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _personalInfoButton.OnPressedState = StateProperties6;
            _personalInfoButton.Size = new Size(178, 45);
            _personalInfoButton.TabIndex = 70;
            _personalInfoButton.TextAlign = ContentAlignment.MiddleCenter;
            _personalInfoButton.TextMarginLeft = 0;
            _personalInfoButton.UseDefaultRadiusAndThickness = true;
            // 
            // titlePersonalInfoLabel
            // 
            titlePersonalInfoLabel.BackColor = Color.Transparent;
            titlePersonalInfoLabel.FlatStyle = FlatStyle.Flat;
            titlePersonalInfoLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titlePersonalInfoLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titlePersonalInfoLabel.Location = new Point(155, 32);
            titlePersonalInfoLabel.Margin = new Padding(2, 0, 2, 0);
            titlePersonalInfoLabel.Name = "titlePersonalInfoLabel";
            titlePersonalInfoLabel.Size = new Size(709, 38);
            titlePersonalInfoLabel.TabIndex = 31;
            titlePersonalInfoLabel.Text = "Fill up all that apply";
            titlePersonalInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Panel3
            // 
            Panel3.Controls.Add(GroupBox3);
            Panel3.Controls.Add(_uploadPhotoButton);
            Panel3.Location = new Point(1312, 102);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(181, 276);
            Panel3.TabIndex = 29;
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(employeePictureBox);
            GroupBox3.Dock = DockStyle.Top;
            GroupBox3.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            GroupBox3.Location = new Point(0, 0);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Padding = new Padding(3, 11, 3, 3);
            GroupBox3.Size = new Size(181, 236);
            GroupBox3.TabIndex = 28;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Photo";
            // 
            // employeePictureBox
            // 
            employeePictureBox.BackgroundImage = (Image)resources.GetObject("employeePictureBox.BackgroundImage");
            employeePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            employeePictureBox.Dock = DockStyle.Fill;
            employeePictureBox.Location = new Point(3, 35);
            employeePictureBox.Margin = new Padding(2);
            employeePictureBox.Name = "employeePictureBox";
            employeePictureBox.Size = new Size(175, 198);
            employeePictureBox.TabIndex = 17;
            employeePictureBox.TabStop = false;
            // 
            // uploadPhotoButton
            // 
            _uploadPhotoButton.AllowToggling = false;
            _uploadPhotoButton.AnimationSpeed = 200;
            _uploadPhotoButton.AutoGenerateColors = false;
            _uploadPhotoButton.BackColor = Color.Transparent;
            _uploadPhotoButton.BackColor1 = Color.Teal;
            _uploadPhotoButton.BackgroundImage = (Image)resources.GetObject("uploadPhotoButton.BackgroundImage");
            _uploadPhotoButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _uploadPhotoButton.ButtonText = "Upload Photo...";
            _uploadPhotoButton.ButtonTextMarginLeft = 0;
            _uploadPhotoButton.ColorContrastOnClick = 45;
            _uploadPhotoButton.ColorContrastOnHover = 45;
            _uploadPhotoButton.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _uploadPhotoButton.CustomizableEdges = BorderEdges4;
            _uploadPhotoButton.DialogResult = DialogResult.None;
            _uploadPhotoButton.DisabledBorderColor = Color.Empty;
            _uploadPhotoButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _uploadPhotoButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _uploadPhotoButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _uploadPhotoButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _uploadPhotoButton.ForeColor = Color.White;
            _uploadPhotoButton.IconLeftCursor = Cursors.Hand;
            _uploadPhotoButton.IconMarginLeft = 11;
            _uploadPhotoButton.IconPadding = 10;
            _uploadPhotoButton.IconRightCursor = Cursors.Hand;
            _uploadPhotoButton.IdleBorderColor = Color.Teal;
            _uploadPhotoButton.IdleBorderRadius = 3;
            _uploadPhotoButton.IdleBorderThickness = 1;
            _uploadPhotoButton.IdleFillColor = Color.Teal;
            _uploadPhotoButton.IdleIconLeftImage = null;
            _uploadPhotoButton.IdleIconRightImage = null;
            _uploadPhotoButton.IndicateFocus = true;
            _uploadPhotoButton.Location = new Point(24, 234);
            _uploadPhotoButton.Name = "_uploadPhotoButton";
            StateProperties7.BorderColor = Color.MediumTurquoise;
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.MediumTurquoise;
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _uploadPhotoButton.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Teal;
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.Teal;
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _uploadPhotoButton.OnPressedState = StateProperties8;
            _uploadPhotoButton.Size = new Size(138, 35);
            _uploadPhotoButton.TabIndex = 69;
            _uploadPhotoButton.TextAlign = ContentAlignment.MiddleCenter;
            _uploadPhotoButton.TextMarginLeft = 0;
            _uploadPhotoButton.UseDefaultRadiusAndThickness = true;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(TableLayoutPanel5);
            GroupBox2.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            GroupBox2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            GroupBox2.Location = new Point(738, 88);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Padding = new Padding(11, 11, 3, 3);
            GroupBox2.Size = new Size(463, 368);
            GroupBox2.TabIndex = 27;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Job Information";
            // 
            // TableLayoutPanel5
            // 
            TableLayoutPanel5.AutoSize = true;
            TableLayoutPanel5.ColumnCount = 2;
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.13084f));
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.86916f));
            TableLayoutPanel5.Controls.Add(jobDescriptionComboBox, 1, 0);
            TableLayoutPanel5.Controls.Add(typeComboBox, 1, 1);
            TableLayoutPanel5.Controls.Add(Label7, 0, 1);
            TableLayoutPanel5.Controls.Add(Label22, 0, 0);
            TableLayoutPanel5.Controls.Add(Label8, 0, 2);
            TableLayoutPanel5.Controls.Add(yardComboBox, 1, 2);
            TableLayoutPanel5.Controls.Add(Label23, 0, 3);
            TableLayoutPanel5.Controls.Add(Label21, 0, 4);
            TableLayoutPanel5.Controls.Add(payMehodComboBox, 1, 3);
            TableLayoutPanel5.Controls.Add(supervisorTextBox, 1, 4);
            TableLayoutPanel5.Controls.Add(Label4, 0, 5);
            TableLayoutPanel5.Controls.Add(startDateDateTimePicker, 1, 5);
            TableLayoutPanel5.Dock = DockStyle.Fill;
            TableLayoutPanel5.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel5.Location = new Point(11, 35);
            TableLayoutPanel5.Margin = new Padding(2);
            TableLayoutPanel5.Name = "TableLayoutPanel5";
            TableLayoutPanel5.RowCount = 7;
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571f));
            TableLayoutPanel5.Size = new Size(449, 330);
            TableLayoutPanel5.TabIndex = 6;
            // 
            // jobDescriptionComboBox
            // 
            jobDescriptionComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            jobDescriptionComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Accounting Manager", "Bag/Bagger Labourer", "Bulk Labourer/Yard Hand ", "IT Junior", "IT Manager", "Logistics Coordinator", "Logistics Manager", "Machine Operator", "Mechanic", "Operations Manager", "Vice President", "Yard Manager" });
            jobDescriptionComboBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            jobDescriptionComboBox.FormattingEnabled = true;
            jobDescriptionComboBox.ItemHeight = 25;
            jobDescriptionComboBox.Items.AddRange(new object[] { "Accounting Assistant", "Accounting Manager", "Bag Labourer", "Bag/Bagger Labourer", "Bagger Labourer", "Bagger Labourer/Yard Hand", "Bulk Labourer", "Bulk Labourer/Yard Hand", "Container Manager", "Freight Forwarding Manager", "Software Developer", "Senior Software Developer / IT Manager", "Logistics Coordinator", "Logistics Manager", "Machine Operator", "Mechanic", "President", "Safety and Risk Manager", "Vice President", "Yard Hand", "Warehouse Labourer", "Terminal Manager", "Operations Manager", "HR Generalist", "Other" });
            jobDescriptionComboBox.Location = new Point(173, 2);
            jobDescriptionComboBox.Margin = new Padding(2);
            jobDescriptionComboBox.Name = "jobDescriptionComboBox";
            jobDescriptionComboBox.Size = new Size(274, 33);
            jobDescriptionComboBox.TabIndex = 9;
            // 
            // typeComboBox
            // 
            typeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "Office", "Crew" });
            typeComboBox.Location = new Point(173, 49);
            typeComboBox.Margin = new Padding(2);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(274, 33);
            typeComboBox.TabIndex = 10;
            // 
            // Label7
            // 
            Label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(96, 47);
            Label7.Margin = new Padding(2, 0, 2, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(73, 25);
            Label7.TabIndex = 13;
            Label7.Text = "*  Type:";
            Label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label22
            // 
            Label22.AutoSize = true;
            Label22.Dock = DockStyle.Fill;
            Label22.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label22.Location = new Point(2, 0);
            Label22.Margin = new Padding(2, 0, 2, 0);
            Label22.Name = "Label22";
            Label22.Size = new Size(167, 47);
            Label22.TabIndex = 0;
            Label22.Text = "* Job Description:";
            Label22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label8
            // 
            Label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(98, 94);
            Label8.Margin = new Padding(2, 0, 2, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(71, 25);
            Label8.TabIndex = 18;
            Label8.Text = "*  Yard:";
            Label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // yardComboBox
            // 
            yardComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            yardComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yardComboBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            yardComboBox.FormattingEnabled = true;
            yardComboBox.Items.AddRange(new object[] { "Ewen", "Lindsey", "Both" });
            yardComboBox.Location = new Point(173, 96);
            yardComboBox.Margin = new Padding(2);
            yardComboBox.Name = "yardComboBox";
            yardComboBox.Size = new Size(274, 33);
            yardComboBox.TabIndex = 11;
            // 
            // Label23
            // 
            Label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label23.AutoSize = true;
            Label23.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label23.Location = new Point(40, 141);
            Label23.Margin = new Padding(2, 0, 2, 0);
            Label23.Name = "Label23";
            Label23.Size = new Size(129, 25);
            Label23.TabIndex = 5;
            Label23.Text = "* Pay Method:";
            Label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label21
            // 
            Label21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label21.AutoSize = true;
            Label21.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label21.Location = new Point(49, 188);
            Label21.Margin = new Padding(2, 0, 2, 0);
            Label21.Name = "Label21";
            Label21.Size = new Size(120, 25);
            Label21.TabIndex = 2;
            Label21.Tag = " ";
            Label21.Text = "   Supervisor:";
            Label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // payMehodComboBox
            // 
            payMehodComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            payMehodComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Accounting Manager", "Bag/Bagger Labourer", "Bulk Labourer/Yard Hand ", "IT Junior", "IT Manager", "Logistics Coordinator", "Logistics Manager", "Machine Operator", "Mechanic", "Operations Manager", "Vice President", "Yard Manager" });
            payMehodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            payMehodComboBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            payMehodComboBox.FormattingEnabled = true;
            payMehodComboBox.Items.AddRange(new object[] { "Hourly", "Salary", "Piece Work/Hourly" });
            payMehodComboBox.Location = new Point(173, 143);
            payMehodComboBox.Margin = new Padding(2);
            payMehodComboBox.Name = "payMehodComboBox";
            payMehodComboBox.Size = new Size(274, 33);
            payMehodComboBox.TabIndex = 12;
            // 
            // supervisorTextBox
            // 
            supervisorTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            supervisorTextBox.CharacterCasing = CharacterCasing.Upper;
            supervisorTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            supervisorTextBox.Location = new Point(173, 190);
            supervisorTextBox.Margin = new Padding(2);
            supervisorTextBox.MaxLength = 15;
            supervisorTextBox.Name = "supervisorTextBox";
            supervisorTextBox.Size = new Size(274, 31);
            supervisorTextBox.TabIndex = 13;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(56, 235);
            Label4.Margin = new Padding(2, 0, 2, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(113, 25);
            Label4.TabIndex = 11;
            Label4.Text = "   Start Date:";
            Label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // startDateDateTimePicker
            // 
            startDateDateTimePicker.Anchor = AnchorStyles.Left;
            startDateDateTimePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            startDateDateTimePicker.Format = DateTimePickerFormat.Short;
            startDateDateTimePicker.Location = new Point(173, 243);
            startDateDateTimePicker.Margin = new Padding(2);
            startDateDateTimePicker.Name = "startDateDateTimePicker";
            startDateDateTimePicker.Size = new Size(160, 31);
            startDateDateTimePicker.TabIndex = 14;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(TableLayoutPanel1);
            GroupBox1.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            GroupBox1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            GroupBox1.Location = new Point(160, 88);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(3, 11, 3, 3);
            GroupBox1.Size = new Size(556, 478);
            GroupBox1.TabIndex = 26;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Employe Information";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.AutoSize = true;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.13084f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.86916f));
            TableLayoutPanel1.Controls.Add(cardAddignedLabel, 1, 9);
            TableLayoutPanel1.Controls.Add(emailTextBox, 1, 5);
            TableLayoutPanel1.Controls.Add(Label19, 0, 5);
            TableLayoutPanel1.Controls.Add(adressTextBox, 1, 4);
            TableLayoutPanel1.Controls.Add(addressLabel, 0, 4);
            TableLayoutPanel1.Controls.Add(_phoneNumberTextBox, 1, 3);
            TableLayoutPanel1.Controls.Add(aliasTextBox, 1, 2);
            TableLayoutPanel1.Controls.Add(lastNameTextBox, 1, 1);
            TableLayoutPanel1.Controls.Add(lastNameLabel, 0, 1);
            TableLayoutPanel1.Controls.Add(_firstNameTextBox, 1, 0);
            TableLayoutPanel1.Controls.Add(firstNameLabel, 0, 0);
            TableLayoutPanel1.Controls.Add(Label1, 0, 2);
            TableLayoutPanel1.Controls.Add(phoneNumberLabel, 0, 3);
            TableLayoutPanel1.Controls.Add(Label13, 0, 9);
            TableLayoutPanel1.Controls.Add(Label18, 0, 8);
            TableLayoutPanel1.Controls.Add(genderComboBox, 1, 8);
            TableLayoutPanel1.Controls.Add(Label16, 0, 7);
            TableLayoutPanel1.Controls.Add(SINumbTextBox, 1, 7);
            TableLayoutPanel1.Controls.Add(birthdateDateTimePicker, 1, 6);
            TableLayoutPanel1.Controls.Add(Label15, 0, 6);
            TableLayoutPanel1.Dock = DockStyle.Fill;
            TableLayoutPanel1.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel1.Location = new Point(3, 35);
            TableLayoutPanel1.Margin = new Padding(2);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 10;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0f));
            TableLayoutPanel1.Size = new Size(550, 440);
            TableLayoutPanel1.TabIndex = 7;
            // 
            // cardAddignedLabel
            // 
            cardAddignedLabel.BackColor = Color.Firebrick;
            cardAddignedLabel.BorderColor = Color.White;
            cardAddignedLabel.Edge = 30;
            cardAddignedLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            cardAddignedLabel.ForeColor = Color.White;
            cardAddignedLabel.Location = new Point(212, 396);
            cardAddignedLabel.Name = "cardAddignedLabel";
            cardAddignedLabel.Size = new Size(175, 29);
            cardAddignedLabel.TabIndex = 71;
            cardAddignedLabel.Text = "NOT ASSIGNED";
            cardAddignedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label16
            // 
            Label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label16.AutoSize = true;
            Label16.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.Location = new Point(73, 308);
            Label16.Margin = new Padding(2, 0, 2, 0);
            Label16.Name = "Label16";
            Label16.Size = new Size(134, 25);
            Label16.TabIndex = 25;
            Label16.Text = "   SIN Number:";
            Label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SINumbTextBox
            // 
            SINumbTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            SINumbTextBox.Location = new Point(211, 310);
            SINumbTextBox.Margin = new Padding(2);
            SINumbTextBox.MaxLength = 14;
            SINumbTextBox.Name = "SINumbTextBox";
            SINumbTextBox.Size = new Size(175, 31);
            SINumbTextBox.TabIndex = 7;
            // 
            // birthdateDateTimePicker
            // 
            birthdateDateTimePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            birthdateDateTimePicker.Format = DateTimePickerFormat.Short;
            birthdateDateTimePicker.Location = new Point(211, 266);
            birthdateDateTimePicker.Margin = new Padding(2);
            birthdateDateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            birthdateDateTimePicker.Size = new Size(175, 31);
            birthdateDateTimePicker.TabIndex = 6;
            // 
            // Label15
            // 
            Label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label15.AutoSize = true;
            Label15.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.Location = new Point(92, 264);
            Label15.Margin = new Padding(2, 0, 2, 0);
            Label15.Name = "Label15";
            Label15.Size = new Size(115, 25);
            Label15.TabIndex = 23;
            Label15.Text = "   Birth Date:";
            Label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GroupBox4
            // 
            GroupBox4.Controls.Add(TableLayoutPanel2);
            GroupBox4.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            GroupBox4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            GroupBox4.Location = new Point(160, 595);
            GroupBox4.Name = "GroupBox4";
            GroupBox4.Padding = new Padding(3, 11, 3, 3);
            GroupBox4.Size = new Size(533, 207);
            GroupBox4.TabIndex = 30;
            GroupBox4.TabStop = false;
            GroupBox4.Text = "Emergency Contact";
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.AutoSize = true;
            TableLayoutPanel2.ColumnCount = 2;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.24395f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.75605f));
            TableLayoutPanel2.Controls.Add(relationshipTextBox, 1, 3);
            TableLayoutPanel2.Controls.Add(_emergencyPhoneNumberTextBox, 1, 2);
            TableLayoutPanel2.Controls.Add(emergencyLastNameTextBox, 1, 1);
            TableLayoutPanel2.Controls.Add(Label9, 0, 1);
            TableLayoutPanel2.Controls.Add(emergencyFirstNameTextBox, 1, 0);
            TableLayoutPanel2.Controls.Add(Label10, 0, 0);
            TableLayoutPanel2.Controls.Add(Label11, 0, 3);
            TableLayoutPanel2.Controls.Add(emergencyPhoneNumberLabel, 0, 2);
            TableLayoutPanel2.Dock = DockStyle.Fill;
            TableLayoutPanel2.Font = new Font("Microsoft Sans Serif", 14.14286f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TableLayoutPanel2.Location = new Point(3, 35);
            TableLayoutPanel2.Margin = new Padding(2);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 4;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel2.Size = new Size(527, 169);
            TableLayoutPanel2.TabIndex = 2;
            // 
            // relationshipTextBox
            // 
            relationshipTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            relationshipTextBox.CharacterCasing = CharacterCasing.Upper;
            relationshipTextBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            relationshipTextBox.Location = new Point(198, 128);
            relationshipTextBox.Margin = new Padding(2);
            relationshipTextBox.MaxLength = 15;
            relationshipTextBox.Name = "relationshipTextBox";
            relationshipTextBox.Size = new Size(327, 31);
            relationshipTextBox.TabIndex = 18;
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
            BunifuShadowPanel1.Size = new Size(1567, 886);
            BunifuShadowPanel1.TabIndex = 37;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Transparent;
            Panel1.Controls.Add(_newEmployeeTabControl);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(10, 10);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1552, 871);
            Panel1.TabIndex = 33;
            // 
            // newEmployeeTabControl
            // 
            _newEmployeeTabControl.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatTab;
            _newEmployeeTabControl.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _newEmployeeTabControl.Controls.Add(TabPageEX1);
            _newEmployeeTabControl.Controls.Add(certificationsTabPage);
            _newEmployeeTabControl.Controls.Add(cardIDTabPage);
            _newEmployeeTabControl.Dock = DockStyle.Fill;
            _newEmployeeTabControl.FlatBorderColor = Color.Gray;
            _newEmployeeTabControl.Font = new Font("Microsoft Sans Serif", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _newEmployeeTabControl.ForeColor = Color.White;
            _newEmployeeTabControl.Location = new Point(0, 0);
            _newEmployeeTabControl.Name = "_newEmployeeTabControl";
            _newEmployeeTabControl.Padding = new Point(20, 8);
            _newEmployeeTabControl.SelectedIndex = 0;
            _newEmployeeTabControl.SelectedTabColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _newEmployeeTabControl.Size = new Size(1552, 871);
            _newEmployeeTabControl.TabColor = SystemColors.ControlDarkDark;
            _newEmployeeTabControl.TabIndex = 0;
            _newEmployeeTabControl.UseVisualStyles = false;
            // 
            // FrmAddNewEmployee
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1567, 886);
            ControlBox = false;
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmAddNewEmployee";
            certificationsTabPage.ResumeLayout(false);
            certificationsTabPage.PerformLayout();
            Panel4.ResumeLayout(false);
            GroupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SkillsCertificationPictureBox).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            TableLayoutPanel3.ResumeLayout(false);
            TableLayoutPanel3.PerformLayout();
            cardIDTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ScanCardPictureBox).EndInit();
            TabPageEX1.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeePictureBox).EndInit();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            TableLayoutPanel5.ResumeLayout(false);
            TableLayoutPanel5.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            GroupBox4.ResumeLayout(false);
            GroupBox4.PerformLayout();
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            BunifuShadowPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            _newEmployeeTabControl.ResumeLayout(false);
            Load += new EventHandler(EmployeeManagementForm_Load);
            ResumeLayout(false);
        }

        internal TextBox emergencyLastNameTextBox;
        internal TextBox emailTextBox;
        internal Label Label19;
        internal TextBox adressTextBox;
        internal Label addressLabel;
        private TextBox _phoneNumberTextBox;

        internal TextBox phoneNumberTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _phoneNumberTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_phoneNumberTextBox != null)
                {
                    _phoneNumberTextBox.LostFocus -= phoneNumberTextBox_LostFocus;
                }

                _phoneNumberTextBox = value;
                if (_phoneNumberTextBox != null)
                {
                    _phoneNumberTextBox.LostFocus += phoneNumberTextBox_LostFocus;
                }
            }
        }

        internal TextBox aliasTextBox;
        internal TextBox lastNameTextBox;
        internal Label lastNameLabel;
        private TextBox _firstNameTextBox;

        internal TextBox firstNameTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _firstNameTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_firstNameTextBox != null)
                {
                    _firstNameTextBox.TextChanged -= firstNameTextBox_TextChanged_1;
                }

                _firstNameTextBox = value;
                if (_firstNameTextBox != null)
                {
                    _firstNameTextBox.TextChanged += firstNameTextBox_TextChanged_1;
                }
            }
        }

        internal Label firstNameLabel;
        internal Label Label1;
        internal Label phoneNumberLabel;
        internal Label Label13;
        internal Label Label18;
        internal Dotnetrix.Controls.TabPageEX certificationsTabPage;
        internal Label titleSkillsAndCertificationLabel;
        public Label Label14;
        internal Label Label2;
        internal Panel Panel2;
        internal TableLayoutPanel TableLayoutPanel3;
        internal CheckBox yardManagerCheckBox;
        internal CheckBox warehouseCheckBox;
        internal CheckBox bulk_HeadsCheckBox;
        internal CheckBox BulkCheckBox;
        internal CheckBox bagTipperCheckBox;
        internal CheckBox baggerCheckBox;
        internal CheckBox bagCheckBox;
        internal CheckBox driverLicenseCheckBox;
        internal CheckBox emptyMachineCheckBox;
        private CheckBox _firstAidCheckBox;

        internal CheckBox firstAidCheckBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _firstAidCheckBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_firstAidCheckBox != null)
                {
                    _firstAidCheckBox.CheckedChanged -= firstAidCheckBox_CheckedChanged;
                }

                _firstAidCheckBox = value;
                if (_firstAidCheckBox != null)
                {
                    _firstAidCheckBox.CheckedChanged += firstAidCheckBox_CheckedChanged;
                }
            }
        }

        internal CheckBox reachstacherCheckBox;
        internal CheckBox railcarMoverCheckBox8;
        internal ComboBox firstAidComboBox;
        internal CheckBox _700HysterCheckBox6;
        private CheckBox _otherCheckBox;

        internal CheckBox otherCheckBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _otherCheckBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_otherCheckBox != null)
                {
                    _otherCheckBox.CheckedChanged -= otherCheckBox_CheckedChanged;
                }

                _otherCheckBox = value;
                if (_otherCheckBox != null)
                {
                    _otherCheckBox.CheckedChanged += otherCheckBox_CheckedChanged;
                }
            }
        }

        internal RichTextBox otherTextBox;
        internal PictureBox SkillsCertificationPictureBox;
        internal Label Label9;
        internal TextBox emergencyFirstNameTextBox;
        internal Label Label10;
        internal Label Label11;
        internal Label emergencyPhoneNumberLabel;
        private TextBox _emergencyPhoneNumberTextBox;

        internal TextBox emergencyPhoneNumberTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _emergencyPhoneNumberTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_emergencyPhoneNumberTextBox != null)
                {
                    _emergencyPhoneNumberTextBox.LostFocus -= emergencyPhoneNumberTextBox_LostFocus;
                }

                _emergencyPhoneNumberTextBox = value;
                if (_emergencyPhoneNumberTextBox != null)
                {
                    _emergencyPhoneNumberTextBox.LostFocus += emergencyPhoneNumberTextBox_LostFocus;
                }
            }
        }

        internal Label titleScanLabel;
        internal Dotnetrix.Controls.TabPageEX cardIDTabPage;
        internal PictureBox ScanCardPictureBox;
        internal ComboBox genderComboBox;
        internal Dotnetrix.Controls.TabPageEX TabPageEX1;
        internal Label titlePersonalInfoLabel;
        internal Panel Panel3;
        internal GroupBox GroupBox3;
        internal PictureBox employeePictureBox;
        internal GroupBox GroupBox2;
        internal TableLayoutPanel TableLayoutPanel5;
        internal ComboBox jobDescriptionComboBox;
        internal ComboBox typeComboBox;
        internal Label Label7;
        internal Label Label22;
        internal Label Label8;
        internal ComboBox yardComboBox;
        internal Label Label23;
        internal Label Label21;
        internal ComboBox payMehodComboBox;
        internal TextBox supervisorTextBox;
        internal Label Label4;
        internal DateTimePicker startDateDateTimePicker;
        internal GroupBox GroupBox1;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Label Label16;
        internal TextBox SINumbTextBox;
        internal DateTimePicker birthdateDateTimePicker;
        internal Label Label15;
        internal GroupBox GroupBox4;
        internal TableLayoutPanel TableLayoutPanel2;
        internal TextBox relationshipTextBox;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel1;
        private Dotnetrix.Controls.TabControlEX _newEmployeeTabControl;

        internal Dotnetrix.Controls.TabControlEX newEmployeeTabControl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _newEmployeeTabControl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_newEmployeeTabControl != null)
                {
                    _newEmployeeTabControl.KeyDown -= Key_press_KeyDown;
                }

                _newEmployeeTabControl = value;
                if (_newEmployeeTabControl != null)
                {
                    _newEmployeeTabControl.KeyDown += Key_press_KeyDown;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _personalInfoButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton personalInfoButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _personalInfoButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_personalInfoButton != null)
                {
                    _personalInfoButton.Click -= Button2_Click;
                }

                _personalInfoButton = value;
                if (_personalInfoButton != null)
                {
                    _personalInfoButton.Click += Button2_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _uploadPhotoButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton uploadPhotoButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _uploadPhotoButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_uploadPhotoButton != null)
                {
                    _uploadPhotoButton.Click -= Button1_Click;
                }

                _uploadPhotoButton = value;
                if (_uploadPhotoButton != null)
                {
                    _uploadPhotoButton.Click += Button1_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _skillsCertificationButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton skillsCertificationButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _skillsCertificationButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_skillsCertificationButton != null)
                {
                    _skillsCertificationButton.Click -= skillsCertificationButton_Click;
                }

                _skillsCertificationButton = value;
                if (_skillsCertificationButton != null)
                {
                    _skillsCertificationButton.Click += skillsCertificationButton_Click;
                }
            }
        }

        internal Panel Panel4;
        internal GroupBox GroupBox5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _FinishButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton FinishButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FinishButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FinishButton != null)
                {
                    _FinishButton.Click -= Button4_Click;
                }

                _FinishButton = value;
                if (_FinishButton != null)
                {
                    _FinishButton.Click += Button4_Click;
                }
            }
        }

        internal CustomizedControlsLibrary.ShapedLabel cardAddignedLabel;
    }
}