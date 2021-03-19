using System;
using System.Diagnostics;
using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAddEditBagLogo : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditBagLogo));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label17 = new Label();
            Label1 = new Label();
            BunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            TableLayoutPanel4 = new TableLayoutPanel();
            Label16 = new Label();
            TableLayoutPanel5 = new TableLayoutPanel();
            pbBagLogo = new PictureBox();
            _btnUploadLogo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnUploadLogo.Click += new EventHandler(BunifuButton1_Click);
            Label22 = new Label();
            TableLayoutPanel7 = new TableLayoutPanel();
            nudBagYear = new NumericUpDown();
            Label23 = new Label();
            _cbNoBagYear = new Bunifu.UI.WinForms.BunifuCheckBox();
            _cbNoBagYear.CheckedChanged += new EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(cbNoBagYear_CheckedChanged);
            tbLogoDescription = new BunifuTextBox();
            Label14 = new Label();
            _btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSave.Click += new EventHandler(btnSave_Click);
            lblWarning = new Label();
            TableLayoutPanel4.SuspendLayout();
            TableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBagLogo).BeginInit();
            TableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBagYear).BeginInit();
            SuspendLayout();
            // 
            // closeFlatButton
            // 
            _closeFlatButton.Active = false;
            _closeFlatButton.Activecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeFlatButton.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.BackgroundImageLayout = ImageLayout.Stretch;
            _closeFlatButton.BorderRadius = 0;
            _closeFlatButton.ButtonText = "🗙";
            _closeFlatButton.Cursor = Cursors.Hand;
            _closeFlatButton.DisabledColor = Color.Gray;
            _closeFlatButton.Iconcolor = Color.Transparent;
            _closeFlatButton.Iconimage = null;
            _closeFlatButton.Iconimage_right = null;
            _closeFlatButton.Iconimage_right_Selected = null;
            _closeFlatButton.Iconimage_Selected = null;
            _closeFlatButton.IconMarginLeft = 0;
            _closeFlatButton.IconMarginRight = 0;
            _closeFlatButton.IconRightVisible = true;
            _closeFlatButton.IconRightZoom = 0d;
            _closeFlatButton.IconVisible = true;
            _closeFlatButton.IconZoom = 90.0d;
            _closeFlatButton.IsTab = false;
            _closeFlatButton.Location = new Point(605, 0);
            _closeFlatButton.Margin = new Padding(7);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(39, 41);
            _closeFlatButton.TabIndex = 173;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Label17
            // 
            Label17.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label17.Dock = DockStyle.Top;
            Label17.Font = new Font("Segoe UI", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = Color.White;
            Label17.Location = new Point(0, 0);
            Label17.Margin = new Padding(4, 0, 4, 0);
            Label17.Name = "Label17";
            Label17.Size = new Size(643, 41);
            Label17.TabIndex = 172;
            Label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label1.Location = new Point(26, 51);
            Label1.Name = "Label1";
            Label1.Size = new Size(209, 21);
            Label1.TabIndex = 176;
            Label1.Text = "Bag Logo/Special Printing";
            // 
            // BunifuSeparator4
            // 
            BunifuSeparator4.BackColor = Color.Transparent;
            BunifuSeparator4.ForeColor = Color.Gray;
            BunifuSeparator4.LineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)));
            BunifuSeparator4.LineThickness = 1;
            BunifuSeparator4.Location = new Point(24, 73);
            BunifuSeparator4.Margin = new Padding(5);
            BunifuSeparator4.Name = "BunifuSeparator4";
            BunifuSeparator4.Size = new Size(533, 19);
            BunifuSeparator4.TabIndex = 175;
            BunifuSeparator4.Transparency = 255;
            BunifuSeparator4.Vertical = false;
            // 
            // TableLayoutPanel4
            // 
            TableLayoutPanel4.ColumnCount = 2;
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0f));
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.0f));
            TableLayoutPanel4.Controls.Add(Label16, 0, 3);
            TableLayoutPanel4.Controls.Add(TableLayoutPanel5, 1, 3);
            TableLayoutPanel4.Controls.Add(Label22, 0, 2);
            TableLayoutPanel4.Controls.Add(TableLayoutPanel7, 1, 2);
            TableLayoutPanel4.Controls.Add(tbLogoDescription, 1, 1);
            TableLayoutPanel4.Controls.Add(Label14, 0, 1);
            TableLayoutPanel4.Location = new Point(27, 110);
            TableLayoutPanel4.Name = "TableLayoutPanel4";
            TableLayoutPanel4.RowCount = 4;
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.30769f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 87.69231f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 37.0f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 213.0f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 22.0f));
            TableLayoutPanel4.Size = new Size(533, 294);
            TableLayoutPanel4.TabIndex = 174;
            // 
            // Label16
            // 
            Label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label16.AutoSize = true;
            Label16.Location = new Point(71, 80);
            Label16.Name = "Label16";
            Label16.Padding = new Padding(3);
            Label16.Size = new Size(85, 23);
            Label16.TabIndex = 6;
            Label16.Text = "Bag Image:";
            // 
            // TableLayoutPanel5
            // 
            TableLayoutPanel5.ColumnCount = 2;
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.29824f));
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.70176f));
            TableLayoutPanel5.Controls.Add(pbBagLogo, 0, 0);
            TableLayoutPanel5.Controls.Add(_btnUploadLogo, 1, 0);
            TableLayoutPanel5.Location = new Point(162, 83);
            TableLayoutPanel5.Name = "TableLayoutPanel5";
            TableLayoutPanel5.RowCount = 1;
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 29.82456f));
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 208.0f));
            TableLayoutPanel5.Size = new Size(333, 208);
            TableLayoutPanel5.TabIndex = 24;
            // 
            // pbBagLogo
            // 
            pbBagLogo.BorderStyle = BorderStyle.FixedSingle;
            pbBagLogo.Dock = DockStyle.Fill;
            pbBagLogo.Location = new Point(0, 0);
            pbBagLogo.Margin = new Padding(0);
            pbBagLogo.Name = "pbBagLogo";
            pbBagLogo.Size = new Size(197, 208);
            pbBagLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbBagLogo.TabIndex = 24;
            pbBagLogo.TabStop = false;
            // 
            // btnUploadLogo
            // 
            _btnUploadLogo.AllowToggling = false;
            _btnUploadLogo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _btnUploadLogo.AnimationSpeed = 200;
            _btnUploadLogo.AutoGenerateColors = false;
            _btnUploadLogo.BackColor = Color.Transparent;
            _btnUploadLogo.BackColor1 = Color.Teal;
            _btnUploadLogo.BackgroundImage = (Image)resources.GetObject("btnUploadLogo.BackgroundImage");
            _btnUploadLogo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnUploadLogo.ButtonText = "Upload...";
            _btnUploadLogo.ButtonTextMarginLeft = 0;
            _btnUploadLogo.ColorContrastOnClick = 45;
            _btnUploadLogo.ColorContrastOnHover = 45;
            _btnUploadLogo.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnUploadLogo.CustomizableEdges = BorderEdges1;
            _btnUploadLogo.DialogResult = DialogResult.None;
            _btnUploadLogo.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnUploadLogo.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnUploadLogo.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnUploadLogo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnUploadLogo.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnUploadLogo.ForeColor = Color.White;
            _btnUploadLogo.IconLeftCursor = Cursors.Hand;
            _btnUploadLogo.IconMarginLeft = 11;
            _btnUploadLogo.IconPadding = 10;
            _btnUploadLogo.IconRightCursor = Cursors.Hand;
            _btnUploadLogo.IdleBorderColor = Color.Teal;
            _btnUploadLogo.IdleBorderRadius = 3;
            _btnUploadLogo.IdleBorderThickness = 1;
            _btnUploadLogo.IdleFillColor = Color.Teal;
            _btnUploadLogo.IdleIconLeftImage = null;
            _btnUploadLogo.IdleIconRightImage = null;
            _btnUploadLogo.IndicateFocus = false;
            _btnUploadLogo.Location = new Point(200, 184);
            _btnUploadLogo.Name = "_btnUploadLogo";
            StateProperties1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnUploadLogo.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnUploadLogo.OnPressedState = StateProperties2;
            _btnUploadLogo.Size = new Size(72, 21);
            _btnUploadLogo.TabIndex = 25;
            _btnUploadLogo.TextAlign = ContentAlignment.MiddleCenter;
            _btnUploadLogo.TextMarginLeft = 0;
            _btnUploadLogo.UseDefaultRadiusAndThickness = true;
            // 
            // Label22
            // 
            Label22.Anchor = AnchorStyles.Right;
            Label22.AutoSize = true;
            Label22.Location = new Point(53, 53);
            Label22.Name = "Label22";
            Label22.Size = new Size(103, 17);
            Label22.TabIndex = 25;
            Label22.Text = "Bag/Logo Year";
            // 
            // TableLayoutPanel7
            // 
            TableLayoutPanel7.ColumnCount = 3;
            TableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.87671f));
            TableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.12329f));
            TableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 191.0f));
            TableLayoutPanel7.Controls.Add(nudBagYear, 0, 0);
            TableLayoutPanel7.Controls.Add(Label23, 2, 0);
            TableLayoutPanel7.Controls.Add(_cbNoBagYear, 1, 0);
            TableLayoutPanel7.Location = new Point(162, 46);
            TableLayoutPanel7.Name = "TableLayoutPanel7";
            TableLayoutPanel7.RowCount = 1;
            TableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 29.82456f));
            TableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 31.0f));
            TableLayoutPanel7.Size = new Size(333, 31);
            TableLayoutPanel7.TabIndex = 177;
            // 
            // nudBagYear
            // 
            nudBagYear.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            nudBagYear.Location = new Point(3, 3);
            nudBagYear.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudBagYear.Name = "nudBagYear";
            nudBagYear.Size = new Size(109, 26);
            nudBagYear.TabIndex = 26;
            nudBagYear.TextAlign = HorizontalAlignment.Center;
            // 
            // Label23
            // 
            Label23.Anchor = AnchorStyles.Left;
            Label23.AutoSize = true;
            Label23.Location = new Point(144, 7);
            Label23.Name = "Label23";
            Label23.Size = new Size(31, 17);
            Label23.TabIndex = 177;
            Label23.Text = "N/A";
            // 
            // cbNoBagYear
            // 
            _cbNoBagYear.AllowBindingControlAnimation = true;
            _cbNoBagYear.AllowBindingControlColorChanges = false;
            _cbNoBagYear.AllowBindingControlLocation = true;
            _cbNoBagYear.AllowCheckBoxAnimation = false;
            _cbNoBagYear.AllowCheckmarkAnimation = true;
            _cbNoBagYear.AllowOnHoverStates = true;
            _cbNoBagYear.Anchor = AnchorStyles.Right;
            _cbNoBagYear.AutoCheck = true;
            _cbNoBagYear.BackColor = Color.Transparent;
            _cbNoBagYear.BackgroundImage = (Image)resources.GetObject("cbNoBagYear.BackgroundImage");
            _cbNoBagYear.BackgroundImageLayout = ImageLayout.Zoom;
            _cbNoBagYear.BindingControl = null;
            _cbNoBagYear.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            _cbNoBagYear.Checked = false;
            _cbNoBagYear.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            _cbNoBagYear.Cursor = Cursors.Hand;
            _cbNoBagYear.CustomCheckmarkImage = null;
            _cbNoBagYear.Location = new Point(120, 5);
            _cbNoBagYear.MinimumSize = new Size(20, 20);
            _cbNoBagYear.Name = "_cbNoBagYear";
            _cbNoBagYear.OnCheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cbNoBagYear.OnCheck.BorderRadius = 2;
            _cbNoBagYear.OnCheck.BorderThickness = 2;
            _cbNoBagYear.OnCheck.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cbNoBagYear.OnCheck.CheckmarkColor = Color.White;
            _cbNoBagYear.OnCheck.CheckmarkThickness = 2;
            _cbNoBagYear.OnDisable.BorderColor = Color.LightGray;
            _cbNoBagYear.OnDisable.BorderRadius = 2;
            _cbNoBagYear.OnDisable.BorderThickness = 2;
            _cbNoBagYear.OnDisable.CheckBoxColor = Color.Transparent;
            _cbNoBagYear.OnDisable.CheckmarkColor = Color.LightGray;
            _cbNoBagYear.OnDisable.CheckmarkThickness = 2;
            _cbNoBagYear.OnHoverChecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cbNoBagYear.OnHoverChecked.BorderRadius = 2;
            _cbNoBagYear.OnHoverChecked.BorderThickness = 2;
            _cbNoBagYear.OnHoverChecked.CheckBoxColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cbNoBagYear.OnHoverChecked.CheckmarkColor = Color.White;
            _cbNoBagYear.OnHoverChecked.CheckmarkThickness = 2;
            _cbNoBagYear.OnHoverUnchecked.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cbNoBagYear.OnHoverUnchecked.BorderRadius = 2;
            _cbNoBagYear.OnHoverUnchecked.BorderThickness = 2;
            _cbNoBagYear.OnHoverUnchecked.CheckBoxColor = Color.Transparent;
            _cbNoBagYear.OnUncheck.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _cbNoBagYear.OnUncheck.BorderRadius = 2;
            _cbNoBagYear.OnUncheck.BorderThickness = 2;
            _cbNoBagYear.OnUncheck.CheckBoxColor = Color.Transparent;
            _cbNoBagYear.Size = new Size(20, 20);
            _cbNoBagYear.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            _cbNoBagYear.TabIndex = 178;
            _cbNoBagYear.ThreeState = false;
            _cbNoBagYear.ToolTipText = null;
            // 
            // tbLogoDescription
            // 
            tbLogoDescription.AcceptsReturn = false;
            tbLogoDescription.AcceptsTab = false;
            tbLogoDescription.AnimationSpeed = 200;
            tbLogoDescription.AutoCompleteMode = AutoCompleteMode.None;
            tbLogoDescription.AutoCompleteSource = AutoCompleteSource.None;
            tbLogoDescription.BackColor = Color.Transparent;
            tbLogoDescription.BackgroundImage = (Image)resources.GetObject("tbLogoDescription.BackgroundImage");
            tbLogoDescription.BorderColorActive = Color.DodgerBlue;
            tbLogoDescription.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            tbLogoDescription.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            tbLogoDescription.BorderColorIdle = Color.Silver;
            tbLogoDescription.BorderRadius = 1;
            tbLogoDescription.BorderThickness = 1;
            tbLogoDescription.CharacterCasing = CharacterCasing.Normal;
            tbLogoDescription.Cursor = Cursors.IBeam;
            tbLogoDescription.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            tbLogoDescription.DefaultText = "";
            tbLogoDescription.FillColor = Color.White;
            tbLogoDescription.HideSelection = true;
            tbLogoDescription.IconLeft = null;
            tbLogoDescription.IconLeftCursor = Cursors.IBeam;
            tbLogoDescription.IconPadding = 10;
            tbLogoDescription.IconRight = null;
            tbLogoDescription.IconRightCursor = Cursors.IBeam;
            tbLogoDescription.Lines = new string[0];
            tbLogoDescription.Location = new Point(162, 8);
            tbLogoDescription.MaxLength = 32767;
            tbLogoDescription.MinimumSize = new Size(116, 35);
            tbLogoDescription.Modified = false;
            tbLogoDescription.Multiline = false;
            tbLogoDescription.Name = "tbLogoDescription";
            StateProperties3.BorderColor = Color.DodgerBlue;
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            tbLogoDescription.OnActiveState = StateProperties3;
            StateProperties4.BorderColor = Color.Empty;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Empty;
            StateProperties4.PlaceholderForeColor = Color.Silver;
            tbLogoDescription.OnDisabledState = StateProperties4;
            StateProperties5.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            tbLogoDescription.OnHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Silver;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Empty;
            tbLogoDescription.OnIdleState = StateProperties6;
            tbLogoDescription.PasswordChar = '\0';
            tbLogoDescription.PlaceholderForeColor = Color.Silver;
            tbLogoDescription.PlaceholderText = "";
            tbLogoDescription.ReadOnly = false;
            tbLogoDescription.ScrollBars = ScrollBars.None;
            tbLogoDescription.SelectedText = "";
            tbLogoDescription.SelectionLength = 0;
            tbLogoDescription.SelectionStart = 0;
            tbLogoDescription.ShortcutsEnabled = true;
            tbLogoDescription.Size = new Size(368, 35);
            tbLogoDescription.Style = _Style.Bunifu;
            tbLogoDescription.TabIndex = 23;
            tbLogoDescription.TextAlign = HorizontalAlignment.Left;
            tbLogoDescription.TextMarginBottom = 0;
            tbLogoDescription.TextMarginLeft = 5;
            tbLogoDescription.TextMarginTop = 0;
            tbLogoDescription.TextPlaceholder = "";
            tbLogoDescription.UseSystemPasswordChar = false;
            tbLogoDescription.WordWrap = true;
            // 
            // Label14
            // 
            Label14.Anchor = AnchorStyles.Right;
            Label14.AutoSize = true;
            Label14.Location = new Point(37, 15);
            Label14.Name = "Label14";
            Label14.Size = new Size(119, 17);
            Label14.TabIndex = 5;
            Label14.Text = "Logo Description:";
            // 
            // btnSave
            // 
            _btnSave.AllowToggling = false;
            _btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _btnSave.AnimationSpeed = 200;
            _btnSave.AutoGenerateColors = false;
            _btnSave.BackColor = Color.Transparent;
            _btnSave.BackColor1 = Color.Teal;
            _btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            _btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnSave.ButtonText = "Save";
            _btnSave.ButtonTextMarginLeft = 0;
            _btnSave.ColorContrastOnClick = 45;
            _btnSave.ColorContrastOnHover = 45;
            _btnSave.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnSave.CustomizableEdges = BorderEdges2;
            _btnSave.DialogResult = DialogResult.None;
            _btnSave.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnSave.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSave.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSave.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnSave.ForeColor = Color.White;
            _btnSave.IconLeftCursor = Cursors.Hand;
            _btnSave.IconMarginLeft = 11;
            _btnSave.IconPadding = 10;
            _btnSave.IconRightCursor = Cursors.Hand;
            _btnSave.IdleBorderColor = Color.Teal;
            _btnSave.IdleBorderRadius = 3;
            _btnSave.IdleBorderThickness = 1;
            _btnSave.IdleFillColor = Color.Teal;
            _btnSave.IdleIconLeftImage = null;
            _btnSave.IdleIconRightImage = null;
            _btnSave.IndicateFocus = false;
            _btnSave.Location = new Point(265, 417);
            _btnSave.Name = "_btnSave";
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _btnSave.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.Teal;
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _btnSave.OnPressedState = StateProperties8;
            _btnSave.Size = new Size(91, 30);
            _btnSave.TabIndex = 177;
            _btnSave.TextAlign = ContentAlignment.MiddleCenter;
            _btnSave.TextMarginLeft = 0;
            _btnSave.UseDefaultRadiusAndThickness = true;
            // 
            // lblWarning
            // 
            lblWarning.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(30, 87);
            lblWarning.Name = "lblWarning";
            lblWarning.Padding = new Padding(3);
            lblWarning.Size = new Size(527, 23);
            lblWarning.TabIndex = 178;
            // 
            // FrmAddEditBagLogo
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(643, 459);
            Controls.Add(lblWarning);
            Controls.Add(_btnSave);
            Controls.Add(Label1);
            Controls.Add(BunifuSeparator4);
            Controls.Add(TableLayoutPanel4);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label17);
            Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmAddEditBagLogo";
            Text = "FrmAddEditBagLogo";
            TableLayoutPanel4.ResumeLayout(false);
            TableLayoutPanel4.PerformLayout();
            TableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBagLogo).EndInit();
            TableLayoutPanel7.ResumeLayout(false);
            TableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBagYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Bunifu.Framework.UI.BunifuFlatButton _closeFlatButton;

        internal Bunifu.Framework.UI.BunifuFlatButton closeFlatButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _closeFlatButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_closeFlatButton != null)
                {
                    _closeFlatButton.Click -= closeFlatButton_Click;
                }

                _closeFlatButton = value;
                if (_closeFlatButton != null)
                {
                    _closeFlatButton.Click += closeFlatButton_Click;
                }
            }
        }

        internal Label Label17;
        internal Label Label1;
        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator4;
        internal TableLayoutPanel TableLayoutPanel4;
        internal TableLayoutPanel TableLayoutPanel7;
        internal NumericUpDown nudBagYear;
        internal Label Label23;
        private Bunifu.UI.WinForms.BunifuCheckBox _cbNoBagYear;

        internal Bunifu.UI.WinForms.BunifuCheckBox cbNoBagYear
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbNoBagYear;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbNoBagYear != null)
                {
                    _cbNoBagYear.CheckedChanged -= cbNoBagYear_CheckedChanged;
                }

                _cbNoBagYear = value;
                if (_cbNoBagYear != null)
                {
                    _cbNoBagYear.CheckedChanged += cbNoBagYear_CheckedChanged;
                }
            }
        }

        internal BunifuTextBox tbLogoDescription;
        internal Label Label14;
        internal Label Label22;
        internal Label Label16;
        internal TableLayoutPanel TableLayoutPanel5;
        public PictureBox pbBagLogo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnUploadLogo;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUploadLogo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnUploadLogo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnUploadLogo != null)
                {
                    _btnUploadLogo.Click -= BunifuButton1_Click;
                }

                _btnUploadLogo = value;
                if (_btnUploadLogo != null)
                {
                    _btnUploadLogo.Click += BunifuButton1_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnSave;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSave != null)
                {
                    _btnSave.Click -= btnSave_Click;
                }

                _btnSave = value;
                if (_btnSave != null)
                {
                    _btnSave.Click += btnSave_Click;
                }
            }
        }

        internal Label lblWarning;
    }
}