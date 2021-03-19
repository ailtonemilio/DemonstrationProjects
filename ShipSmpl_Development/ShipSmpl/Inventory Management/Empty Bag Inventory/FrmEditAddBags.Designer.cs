using System;
using System.Diagnostics;
using System.Drawing; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmEditAddBags : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditAddBags));
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
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            Label2 = new Label();
            Label4 = new Label();
            cboBagColor = new ComboBox();
            BunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            Label9 = new Label();
            TableLayoutPanel2 = new TableLayoutPanel();
            TableLayoutPanel4 = new TableLayoutPanel();
            pbLogo = new PictureBox();
            lblBagLogo = new Label();
            TableLayoutPanel5 = new TableLayoutPanel();
            _btnChooseLogo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnChooseLogo.Click += new EventHandler(btnChooseLogo_Click);
            Label1 = new Label();
            Label6 = new Label();
            tbBagDescription = new BunifuTextBox();
            cboColortype = new ComboBox();
            Label11 = new Label();
            BunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            cboBagSize = new ComboBox();
            Label3 = new Label();
            Label5 = new Label();
            _cboBagWeight = new ComboBox();
            _cboBagWeight.SelectedValueChanged += new EventHandler(cboBagWeight_SelectedValueChanged);
            TableLayoutPanel1 = new TableLayoutPanel();
            TableLayoutPanel8 = new TableLayoutPanel();
            lblUnitWeight = new Label();
            lvlBag = new Label();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label17 = new Label();
            _btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSave.Click += new EventHandler(btnSave_Click);
            panelLogoList = new Panel();
            _btnAddLogo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddLogo.Click += new EventHandler(btnAddLogo_Click);
            _BunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            _BunifuFlatButton1.Click += new EventHandler(BunifuFlatButton1_Click);
            _btnOkLogo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnOkLogo.Click += new EventHandler(btnOkLogo_Click);
            Label10 = new Label();
            _dgvLogos = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvLogos.DoubleClick += new EventHandler(dgvLogos_DoubleClick);
            LogoDescription = new DataGridViewTextBoxColumn();
            BagYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ImagePathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BagLogoBindingSource = new BindingSource(components);
            lblWarning = new Label();
            TableLayoutPanel2.SuspendLayout();
            TableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            TableLayoutPanel5.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            TableLayoutPanel8.SuspendLayout();
            panelLogoList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvLogos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BagLogoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Right;
            Label2.AutoSize = true;
            Label2.Location = new Point(38, 67);
            Label2.Margin = new Padding(2, 0, 2, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(83, 20);
            Label2.TabIndex = 5;
            Label2.Text = "Bag Color:";
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Right;
            Label4.AutoSize = true;
            Label4.Location = new Point(33, 98);
            Label4.Margin = new Padding(2, 0, 2, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(88, 20);
            Label4.TabIndex = 6;
            Label4.Text = "Color Type:";
            // 
            // cboBagColor
            // 
            cboBagColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBagColor.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboBagColor.FormattingEnabled = true;
            cboBagColor.Location = new Point(125, 64);
            cboBagColor.Margin = new Padding(2);
            cboBagColor.Name = "cboBagColor";
            cboBagColor.Size = new Size(126, 32);
            cboBagColor.TabIndex = 8;
            // 
            // BunifuSeparator1
            // 
            BunifuSeparator1.BackColor = Color.Transparent;
            BunifuSeparator1.ForeColor = Color.Gray;
            BunifuSeparator1.LineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)));
            BunifuSeparator1.LineThickness = 1;
            BunifuSeparator1.Location = new Point(53, 102);
            BunifuSeparator1.Margin = new Padding(4, 4, 4, 4);
            BunifuSeparator1.Name = "BunifuSeparator1";
            BunifuSeparator1.Size = new Size(448, 15);
            BunifuSeparator1.TabIndex = 10;
            BunifuSeparator1.Transparency = 255;
            BunifuSeparator1.Vertical = false;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label9.Location = new Point(51, 80);
            Label9.Margin = new Padding(2, 0, 2, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(153, 28);
            Label9.TabIndex = 12;
            Label9.Text = "Bag Information";
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 2;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.23312f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.76688f));
            TableLayoutPanel2.Controls.Add(TableLayoutPanel4, 1, 1);
            TableLayoutPanel2.Controls.Add(TableLayoutPanel5, 0, 1);
            TableLayoutPanel2.Controls.Add(Label6, 0, 0);
            TableLayoutPanel2.Controls.Add(tbBagDescription, 1, 0);
            TableLayoutPanel2.Location = new Point(51, 315);
            TableLayoutPanel2.Margin = new Padding(2);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 2;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.17323f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85.82677f));
            TableLayoutPanel2.Size = new Size(459, 254);
            TableLayoutPanel2.TabIndex = 14;
            // 
            // TableLayoutPanel4
            // 
            TableLayoutPanel4.ColumnCount = 1;
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.46821f));
            TableLayoutPanel4.Controls.Add(pbLogo, 0, 1);
            TableLayoutPanel4.Controls.Add(lblBagLogo, 0, 0);
            TableLayoutPanel4.Dock = DockStyle.Fill;
            TableLayoutPanel4.Location = new Point(125, 36);
            TableLayoutPanel4.Margin = new Padding(0);
            TableLayoutPanel4.Name = "TableLayoutPanel4";
            TableLayoutPanel4.RowCount = 2;
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 195.0f));
            TableLayoutPanel4.Size = new Size(334, 218);
            TableLayoutPanel4.TabIndex = 178;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Location = new Point(83, 23);
            pbLogo.Margin = new Padding(0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(168, 195);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 9;
            pbLogo.TabStop = false;
            // 
            // lblBagLogo
            // 
            lblBagLogo.AutoSize = true;
            lblBagLogo.Dock = DockStyle.Fill;
            lblBagLogo.Location = new Point(2, 0);
            lblBagLogo.Margin = new Padding(2, 0, 2, 0);
            lblBagLogo.Name = "lblBagLogo";
            lblBagLogo.Padding = new Padding(0, 5, 0, 0);
            lblBagLogo.Size = new Size(330, 23);
            lblBagLogo.TabIndex = 10;
            lblBagLogo.Text = "Bag Logo:";
            lblBagLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel5
            // 
            TableLayoutPanel5.ColumnCount = 2;
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.4f));
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.6f));
            TableLayoutPanel5.Controls.Add(_btnChooseLogo, 1, 0);
            TableLayoutPanel5.Controls.Add(Label1, 0, 0);
            TableLayoutPanel5.Dock = DockStyle.Fill;
            TableLayoutPanel5.Location = new Point(0, 36);
            TableLayoutPanel5.Margin = new Padding(0);
            TableLayoutPanel5.Name = "TableLayoutPanel5";
            TableLayoutPanel5.RowCount = 1;
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 218.0f));
            TableLayoutPanel5.Size = new Size(125, 218);
            TableLayoutPanel5.TabIndex = 177;
            // 
            // btnChooseLogo
            // 
            _btnChooseLogo.AllowToggling = false;
            _btnChooseLogo.AnimationSpeed = 200;
            _btnChooseLogo.AutoGenerateColors = false;
            _btnChooseLogo.BackColor = Color.Transparent;
            _btnChooseLogo.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnChooseLogo.BackgroundImage = (Image)resources.GetObject("btnChooseLogo.BackgroundImage");
            _btnChooseLogo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnChooseLogo.ButtonText = "...";
            _btnChooseLogo.ButtonTextMarginLeft = 0;
            _btnChooseLogo.ColorContrastOnClick = 45;
            _btnChooseLogo.ColorContrastOnHover = 45;
            _btnChooseLogo.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnChooseLogo.CustomizableEdges = BorderEdges1;
            _btnChooseLogo.DialogResult = DialogResult.None;
            _btnChooseLogo.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnChooseLogo.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnChooseLogo.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnChooseLogo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnChooseLogo.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnChooseLogo.ForeColor = Color.White;
            _btnChooseLogo.IconLeftCursor = Cursors.Hand;
            _btnChooseLogo.IconMarginLeft = 11;
            _btnChooseLogo.IconPadding = 10;
            _btnChooseLogo.IconRightCursor = Cursors.Hand;
            _btnChooseLogo.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnChooseLogo.IdleBorderRadius = 3;
            _btnChooseLogo.IdleBorderThickness = 1;
            _btnChooseLogo.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnChooseLogo.IdleIconLeftImage = null;
            _btnChooseLogo.IdleIconRightImage = null;
            _btnChooseLogo.IndicateFocus = false;
            _btnChooseLogo.Location = new Point(100, 2);
            _btnChooseLogo.Margin = new Padding(2);
            _btnChooseLogo.Name = "_btnChooseLogo";
            StateProperties1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnChooseLogo.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnChooseLogo.OnPressedState = StateProperties2;
            _btnChooseLogo.Size = new Size(22, 22);
            _btnChooseLogo.TabIndex = 176;
            _btnChooseLogo.TextAlign = ContentAlignment.MiddleCenter;
            _btnChooseLogo.TextMarginLeft = 0;
            _btnChooseLogo.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Location = new Point(14, 0);
            Label1.Margin = new Padding(2, 0, 2, 0);
            Label1.Name = "Label1";
            Label1.Padding = new Padding(0, 5, 0, 0);
            Label1.Size = new Size(82, 25);
            Label1.TabIndex = 7;
            Label1.Text = "Bag Logo:";
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.Right;
            Label6.AutoSize = true;
            Label6.Location = new Point(30, 0);
            Label6.Margin = new Padding(2, 0, 2, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(93, 36);
            Label6.TabIndex = 12;
            Label6.Text = "Bag Description:";
            // 
            // tbBagDescription
            // 
            tbBagDescription.AcceptsReturn = false;
            tbBagDescription.AcceptsTab = false;
            tbBagDescription.AnimationSpeed = 200;
            tbBagDescription.AutoCompleteMode = AutoCompleteMode.None;
            tbBagDescription.AutoCompleteSource = AutoCompleteSource.None;
            tbBagDescription.BackColor = Color.Transparent;
            tbBagDescription.BackgroundImage = (Image)resources.GetObject("tbBagDescription.BackgroundImage");
            tbBagDescription.BorderColorActive = Color.DodgerBlue;
            tbBagDescription.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            tbBagDescription.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            tbBagDescription.BorderColorIdle = Color.Silver;
            tbBagDescription.BorderRadius = 1;
            tbBagDescription.BorderThickness = 1;
            tbBagDescription.CharacterCasing = CharacterCasing.Normal;
            tbBagDescription.Cursor = Cursors.IBeam;
            tbBagDescription.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            tbBagDescription.DefaultText = "";
            tbBagDescription.FillColor = Color.White;
            tbBagDescription.HideSelection = true;
            tbBagDescription.IconLeft = null;
            tbBagDescription.IconLeftCursor = Cursors.IBeam;
            tbBagDescription.IconPadding = 10;
            tbBagDescription.IconRight = null;
            tbBagDescription.IconRightCursor = Cursors.IBeam;
            tbBagDescription.Lines = new string[0];
            tbBagDescription.Location = new Point(127, 2);
            tbBagDescription.Margin = new Padding(2);
            tbBagDescription.MaxLength = 32767;
            tbBagDescription.MinimumSize = new Size(87, 28);
            tbBagDescription.Modified = false;
            tbBagDescription.Multiline = false;
            tbBagDescription.Name = "tbBagDescription";
            StateProperties3.BorderColor = Color.DodgerBlue;
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            tbBagDescription.OnActiveState = StateProperties3;
            StateProperties4.BorderColor = Color.Empty;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Empty;
            StateProperties4.PlaceholderForeColor = Color.Silver;
            tbBagDescription.OnDisabledState = StateProperties4;
            StateProperties5.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            tbBagDescription.OnHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Silver;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Empty;
            tbBagDescription.OnIdleState = StateProperties6;
            tbBagDescription.PasswordChar = '\0';
            tbBagDescription.PlaceholderForeColor = Color.Silver;
            tbBagDescription.PlaceholderText = "";
            tbBagDescription.ReadOnly = false;
            tbBagDescription.ScrollBars = ScrollBars.None;
            tbBagDescription.SelectedText = "";
            tbBagDescription.SelectionLength = 0;
            tbBagDescription.SelectionStart = 0;
            tbBagDescription.ShortcutsEnabled = true;
            tbBagDescription.Size = new Size(330, 32);
            tbBagDescription.Style = _Style.Bunifu;
            tbBagDescription.TabIndex = 14;
            tbBagDescription.TextAlign = HorizontalAlignment.Left;
            tbBagDescription.TextMarginBottom = 0;
            tbBagDescription.TextMarginLeft = 5;
            tbBagDescription.TextMarginTop = 0;
            tbBagDescription.TextPlaceholder = "";
            tbBagDescription.UseSystemPasswordChar = false;
            tbBagDescription.WordWrap = true;
            // 
            // cboColortype
            // 
            cboColortype.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColortype.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboColortype.FormattingEnabled = true;
            cboColortype.Location = new Point(125, 95);
            cboColortype.Margin = new Padding(2);
            cboColortype.Name = "cboColortype";
            cboColortype.Size = new Size(126, 32);
            cboColortype.TabIndex = 7;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label11.Location = new Point(49, 277);
            Label11.Margin = new Padding(2, 0, 2, 0);
            Label11.Name = "Label11";
            Label11.Size = new Size(186, 28);
            Label11.TabIndex = 16;
            Label11.Text = "Bag Color and Logo";
            // 
            // BunifuSeparator2
            // 
            BunifuSeparator2.BackColor = Color.Transparent;
            BunifuSeparator2.ForeColor = Color.Gray;
            BunifuSeparator2.LineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)));
            BunifuSeparator2.LineThickness = 1;
            BunifuSeparator2.Location = new Point(50, 297);
            BunifuSeparator2.Margin = new Padding(4, 4, 4, 4);
            BunifuSeparator2.Name = "BunifuSeparator2";
            BunifuSeparator2.Size = new Size(447, 14);
            BunifuSeparator2.TabIndex = 15;
            BunifuSeparator2.Transparency = 255;
            BunifuSeparator2.Vertical = false;
            // 
            // cboBagSize
            // 
            cboBagSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBagSize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboBagSize.FormattingEnabled = true;
            cboBagSize.Location = new Point(125, 2);
            cboBagSize.Margin = new Padding(2);
            cboBagSize.Name = "cboBagSize";
            cboBagSize.Size = new Size(92, 32);
            cboBagSize.TabIndex = 7;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Right;
            Label3.AutoSize = true;
            Label3.Location = new Point(44, 5);
            Label3.Margin = new Padding(2, 0, 2, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(77, 20);
            Label3.TabIndex = 4;
            Label3.Text = "Bag Size:";
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.Right;
            Label5.AutoSize = true;
            Label5.Location = new Point(25, 36);
            Label5.Margin = new Padding(2, 0, 2, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(96, 20);
            Label5.TabIndex = 9;
            Label5.Text = "Bag Weight:";
            // 
            // cboBagWeight
            // 
            _cboBagWeight.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboBagWeight.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboBagWeight.FormattingEnabled = true;
            _cboBagWeight.Location = new Point(2, 2);
            _cboBagWeight.Margin = new Padding(2);
            _cboBagWeight.Name = "_cboBagWeight";
            _cboBagWeight.Size = new Size(72, 32);
            _cboBagWeight.TabIndex = 10;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.8559f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.1441f));
            TableLayoutPanel1.Controls.Add(Label3, 0, 0);
            TableLayoutPanel1.Controls.Add(cboBagSize, 1, 0);
            TableLayoutPanel1.Controls.Add(Label5, 0, 1);
            TableLayoutPanel1.Controls.Add(TableLayoutPanel8, 1, 1);
            TableLayoutPanel1.Controls.Add(Label2, 0, 2);
            TableLayoutPanel1.Controls.Add(cboBagColor, 1, 2);
            TableLayoutPanel1.Controls.Add(cboColortype, 1, 3);
            TableLayoutPanel1.Controls.Add(Label4, 0, 3);
            TableLayoutPanel1.Location = new Point(55, 118);
            TableLayoutPanel1.Margin = new Padding(2);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 5;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34.0f));
            TableLayoutPanel1.Size = new Size(458, 157);
            TableLayoutPanel1.TabIndex = 9;
            // 
            // TableLayoutPanel8
            // 
            TableLayoutPanel8.ColumnCount = 2;
            TableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.16716f));
            TableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.83285f));
            TableLayoutPanel8.Controls.Add(_cboBagWeight, 0, 0);
            TableLayoutPanel8.Controls.Add(lblUnitWeight, 1, 0);
            TableLayoutPanel8.Location = new Point(123, 31);
            TableLayoutPanel8.Margin = new Padding(0);
            TableLayoutPanel8.Name = "TableLayoutPanel8";
            TableLayoutPanel8.RowCount = 1;
            TableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 31.0f));
            TableLayoutPanel8.Size = new Size(331, 31);
            TableLayoutPanel8.TabIndex = 176;
            // 
            // lblUnitWeight
            // 
            lblUnitWeight.Anchor = AnchorStyles.Left;
            lblUnitWeight.AutoSize = true;
            lblUnitWeight.Location = new Point(78, 5);
            lblUnitWeight.Margin = new Padding(2, 0, 2, 0);
            lblUnitWeight.Name = "lblUnitWeight";
            lblUnitWeight.Size = new Size(32, 20);
            lblUnitWeight.TabIndex = 5;
            lblUnitWeight.Text = "KG";
            lblUnitWeight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lvlBag
            // 
            lvlBag.AutoSize = true;
            lvlBag.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lvlBag.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lvlBag.Location = new Point(22, 43);
            lvlBag.Margin = new Padding(2, 0, 2, 0);
            lvlBag.Name = "lvlBag";
            lvlBag.Size = new Size(108, 32);
            lvlBag.TabIndex = 23;
            lvlBag.Text = "Add Bag";
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
            _closeFlatButton.Location = new Point(594, 0);
            _closeFlatButton.Margin = new Padding(5, 6, 5, 6);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(41, 33);
            _closeFlatButton.TabIndex = 171;
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
            Label17.Name = "Label17";
            Label17.Size = new Size(634, 33);
            Label17.TabIndex = 170;
            Label17.TextAlign = ContentAlignment.MiddleCenter;
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
            _btnSave.Location = new Point(278, 606);
            _btnSave.Margin = new Padding(2);
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
            _btnSave.Size = new Size(99, 34);
            _btnSave.TabIndex = 175;
            _btnSave.TextAlign = ContentAlignment.MiddleCenter;
            _btnSave.TextMarginLeft = 0;
            _btnSave.UseDefaultRadiusAndThickness = true;
            // 
            // panelLogoList
            // 
            panelLogoList.BackColor = Color.WhiteSmoke;
            panelLogoList.BorderStyle = BorderStyle.FixedSingle;
            panelLogoList.Controls.Add(_btnAddLogo);
            panelLogoList.Controls.Add(_BunifuFlatButton1);
            panelLogoList.Controls.Add(_btnOkLogo);
            panelLogoList.Controls.Add(Label10);
            panelLogoList.Controls.Add(_dgvLogos);
            panelLogoList.Location = new Point(172, 372);
            panelLogoList.Name = "panelLogoList";
            panelLogoList.Size = new Size(435, 200);
            panelLogoList.TabIndex = 176;
            panelLogoList.Visible = false;
            // 
            // btnAddLogo
            // 
            _btnAddLogo.AllowToggling = false;
            _btnAddLogo.AnimationSpeed = 200;
            _btnAddLogo.AutoGenerateColors = false;
            _btnAddLogo.BackColor = Color.Transparent;
            _btnAddLogo.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddLogo.BackgroundImage = (Image)resources.GetObject("btnAddLogo.BackgroundImage");
            _btnAddLogo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddLogo.ButtonText = "+";
            _btnAddLogo.ButtonTextMarginLeft = 0;
            _btnAddLogo.ColorContrastOnClick = 45;
            _btnAddLogo.ColorContrastOnHover = 45;
            _btnAddLogo.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _btnAddLogo.CustomizableEdges = BorderEdges3;
            _btnAddLogo.DialogResult = DialogResult.None;
            _btnAddLogo.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnAddLogo.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddLogo.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddLogo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddLogo.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddLogo.ForeColor = Color.White;
            _btnAddLogo.IconLeftCursor = Cursors.Hand;
            _btnAddLogo.IconMarginLeft = 11;
            _btnAddLogo.IconPadding = 10;
            _btnAddLogo.IconRightCursor = Cursors.Hand;
            _btnAddLogo.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddLogo.IdleBorderRadius = 11;
            _btnAddLogo.IdleBorderThickness = 1;
            _btnAddLogo.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAddLogo.IdleIconLeftImage = null;
            _btnAddLogo.IdleIconRightImage = null;
            _btnAddLogo.IndicateFocus = false;
            _btnAddLogo.Location = new Point(409, 178);
            _btnAddLogo.Margin = new Padding(2);
            _btnAddLogo.Name = "_btnAddLogo";
            StateProperties9.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties9.BorderRadius = 11;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            _btnAddLogo.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties10.BorderRadius = 11;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            _btnAddLogo.OnPressedState = StateProperties10;
            _btnAddLogo.Size = new Size(16, 16);
            _btnAddLogo.TabIndex = 178;
            _btnAddLogo.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddLogo.TextMarginLeft = 0;
            _btnAddLogo.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuFlatButton1
            // 
            _BunifuFlatButton1.Active = false;
            _BunifuFlatButton1.Activecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuFlatButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _BunifuFlatButton1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch;
            _BunifuFlatButton1.BorderRadius = 0;
            _BunifuFlatButton1.ButtonText = "🗙";
            _BunifuFlatButton1.Cursor = Cursors.Hand;
            _BunifuFlatButton1.DisabledColor = Color.Gray;
            _BunifuFlatButton1.Iconcolor = Color.Transparent;
            _BunifuFlatButton1.Iconimage = null;
            _BunifuFlatButton1.Iconimage_right = null;
            _BunifuFlatButton1.Iconimage_right_Selected = null;
            _BunifuFlatButton1.Iconimage_Selected = null;
            _BunifuFlatButton1.IconMarginLeft = 0;
            _BunifuFlatButton1.IconMarginRight = 0;
            _BunifuFlatButton1.IconRightVisible = true;
            _BunifuFlatButton1.IconRightZoom = 0d;
            _BunifuFlatButton1.IconVisible = true;
            _BunifuFlatButton1.IconZoom = 90.0d;
            _BunifuFlatButton1.IsTab = false;
            _BunifuFlatButton1.Location = new Point(409, 1);
            _BunifuFlatButton1.Margin = new Padding(6, 7, 6, 7);
            _BunifuFlatButton1.Name = "_BunifuFlatButton1";
            _BunifuFlatButton1.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuFlatButton1.OnHovercolor = Color.Gray;
            _BunifuFlatButton1.OnHoverTextColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuFlatButton1.selected = false;
            _BunifuFlatButton1.Size = new Size(24, 18);
            _BunifuFlatButton1.TabIndex = 177;
            _BunifuFlatButton1.Text = "🗙";
            _BunifuFlatButton1.TextAlign = ContentAlignment.MiddleCenter;
            _BunifuFlatButton1.Textcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _BunifuFlatButton1.TextFont = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // btnOkLogo
            // 
            _btnOkLogo.AllowToggling = false;
            _btnOkLogo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _btnOkLogo.AnimationSpeed = 200;
            _btnOkLogo.AutoGenerateColors = false;
            _btnOkLogo.BackColor = Color.Transparent;
            _btnOkLogo.BackColor1 = Color.Teal;
            _btnOkLogo.BackgroundImage = (Image)resources.GetObject("btnOkLogo.BackgroundImage");
            _btnOkLogo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnOkLogo.ButtonText = "Ok";
            _btnOkLogo.ButtonTextMarginLeft = 0;
            _btnOkLogo.ColorContrastOnClick = 45;
            _btnOkLogo.ColorContrastOnHover = 45;
            _btnOkLogo.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _btnOkLogo.CustomizableEdges = BorderEdges4;
            _btnOkLogo.DialogResult = DialogResult.None;
            _btnOkLogo.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnOkLogo.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnOkLogo.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnOkLogo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnOkLogo.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnOkLogo.ForeColor = Color.White;
            _btnOkLogo.IconLeftCursor = Cursors.Hand;
            _btnOkLogo.IconMarginLeft = 11;
            _btnOkLogo.IconPadding = 10;
            _btnOkLogo.IconRightCursor = Cursors.Hand;
            _btnOkLogo.IdleBorderColor = Color.Teal;
            _btnOkLogo.IdleBorderRadius = 3;
            _btnOkLogo.IdleBorderThickness = 1;
            _btnOkLogo.IdleFillColor = Color.Teal;
            _btnOkLogo.IdleIconLeftImage = null;
            _btnOkLogo.IdleIconRightImage = null;
            _btnOkLogo.IndicateFocus = false;
            _btnOkLogo.Location = new Point(192, 172);
            _btnOkLogo.Margin = new Padding(2);
            _btnOkLogo.Name = "_btnOkLogo";
            StateProperties11.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties11.BorderRadius = 3;
            StateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties11.BorderThickness = 1;
            StateProperties11.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties11.ForeColor = Color.White;
            StateProperties11.IconLeftImage = null;
            StateProperties11.IconRightImage = null;
            _btnOkLogo.onHoverState = StateProperties11;
            StateProperties12.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties12.BorderRadius = 3;
            StateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties12.BorderThickness = 1;
            StateProperties12.FillColor = Color.Teal;
            StateProperties12.ForeColor = Color.White;
            StateProperties12.IconLeftImage = null;
            StateProperties12.IconRightImage = null;
            _btnOkLogo.OnPressedState = StateProperties12;
            _btnOkLogo.Size = new Size(59, 24);
            _btnOkLogo.TabIndex = 176;
            _btnOkLogo.TextAlign = ContentAlignment.MiddleCenter;
            _btnOkLogo.TextMarginLeft = 0;
            _btnOkLogo.UseDefaultRadiusAndThickness = true;
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label10.AutoSize = true;
            Label10.Font = new Font("Microsoft Sans Serif", 9.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.Location = new Point(130, -2);
            Label10.Margin = new Padding(2, 0, 2, 0);
            Label10.Name = "Label10";
            Label10.Padding = new Padding(0, 5, 0, 0);
            Label10.Size = new Size(198, 25);
            Label10.TabIndex = 58;
            Label10.Text = "Select logo and click ok";
            // 
            // dgvLogos
            // 
            _dgvLogos.AllowCustomTheming = true;
            _dgvLogos.AllowUserToAddRows = false;
            _dgvLogos.AllowUserToDeleteRows = false;
            _dgvLogos.AllowUserToResizeColumns = false;
            _dgvLogos.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            _dgvLogos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvLogos.AutoGenerateColumns = false;
            _dgvLogos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvLogos.BackgroundColor = Color.White;
            _dgvLogos.BorderStyle = BorderStyle.None;
            _dgvLogos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvLogos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.Silver;
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle2.ForeColor = Color.Black;
            DataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            DataGridViewCellStyle2.SelectionForeColor = Color.Black;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvLogos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvLogos.ColumnHeadersHeight = 30;
            _dgvLogos.ColumnHeadersVisible = false;
            _dgvLogos.Columns.AddRange(new DataGridViewColumn[] { LogoDescription, BagYearDataGridViewTextBoxColumn, ImagePathDataGridViewTextBoxColumn });
            _dgvLogos.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvLogos.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvLogos.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvLogos.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = SystemColors.ButtonFace;
            _dgvLogos.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvLogos.CurrentTheme.BackColor = Color.White;
            _dgvLogos.CurrentTheme.GridColor = Color.DarkGray;
            _dgvLogos.CurrentTheme.HeaderStyle.BackColor = Color.Silver;
            _dgvLogos.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _dgvLogos.CurrentTheme.HeaderStyle.ForeColor = Color.Black;
            _dgvLogos.CurrentTheme.Name = null;
            _dgvLogos.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgvLogos.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvLogos.CurrentTheme.RowsStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvLogos.CurrentTheme.RowsStyle.SelectionBackColor = SystemColors.ButtonFace;
            _dgvLogos.CurrentTheme.RowsStyle.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvLogos.DataSource = BagLogoBindingSource;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.White;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonFace;
            DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvLogos.DefaultCellStyle = DataGridViewCellStyle3;
            _dgvLogos.EnableHeadersVisualStyles = false;
            _dgvLogos.GridColor = Color.DarkGray;
            _dgvLogos.HeaderBackColor = Color.Silver;
            _dgvLogos.HeaderBgColor = Color.Empty;
            _dgvLogos.HeaderForeColor = Color.Black;
            _dgvLogos.Location = new Point(1, 21);
            _dgvLogos.MultiSelect = false;
            _dgvLogos.Name = "_dgvLogos";
            _dgvLogos.ReadOnly = true;
            _dgvLogos.RowHeadersVisible = false;
            _dgvLogos.RowHeadersWidth = 30;
            _dgvLogos.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonFace;
            _dgvLogos.RowTemplate.Height = 25;
            _dgvLogos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvLogos.Size = new Size(433, 152);
            _dgvLogos.TabIndex = 57;
            _dgvLogos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // LogoDescription
            // 
            LogoDescription.DataPropertyName = "LogoDescription";
            LogoDescription.HeaderText = "Logo";
            LogoDescription.MinimumWidth = 6;
            LogoDescription.Name = "LogoDescription";
            LogoDescription.ReadOnly = true;
            // 
            // BagYearDataGridViewTextBoxColumn
            // 
            BagYearDataGridViewTextBoxColumn.DataPropertyName = "BagYear";
            BagYearDataGridViewTextBoxColumn.HeaderText = "BagYear";
            BagYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            BagYearDataGridViewTextBoxColumn.Name = "BagYearDataGridViewTextBoxColumn";
            BagYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ImagePathDataGridViewTextBoxColumn
            // 
            ImagePathDataGridViewTextBoxColumn.DataPropertyName = "ImagePath";
            ImagePathDataGridViewTextBoxColumn.HeaderText = "ImagePath";
            ImagePathDataGridViewTextBoxColumn.MinimumWidth = 6;
            ImagePathDataGridViewTextBoxColumn.Name = "ImagePathDataGridViewTextBoxColumn";
            ImagePathDataGridViewTextBoxColumn.ReadOnly = true;
            ImagePathDataGridViewTextBoxColumn.Visible = false;
            // 
            // BagLogoBindingSource
            // 
            BagLogoBindingSource.DataSource = typeof(ModelLayer.BagLogo);
            // 
            // lblWarning
            // 
            lblWarning.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWarning.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblWarning.Location = new Point(151, 54);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(456, 26);
            lblWarning.TabIndex = 177;
            // 
            // FrmEditAddBags
            // 
            AutoScaleDimensions = new SizeF(9.0f, 18.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(634, 663);
            Controls.Add(lblWarning);
            Controls.Add(panelLogoList);
            Controls.Add(_btnSave);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label17);
            Controls.Add(lvlBag);
            Controls.Add(Label11);
            Controls.Add(BunifuSeparator2);
            Controls.Add(TableLayoutPanel2);
            Controls.Add(Label9);
            Controls.Add(BunifuSeparator1);
            Controls.Add(TableLayoutPanel1);
            Font = new Font("Microsoft Sans Serif", 9.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmEditAddBags";
            Text = "FrmEdiAddBags";
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            TableLayoutPanel4.ResumeLayout(false);
            TableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            TableLayoutPanel5.ResumeLayout(false);
            TableLayoutPanel5.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            TableLayoutPanel8.ResumeLayout(false);
            TableLayoutPanel8.PerformLayout();
            panelLogoList.ResumeLayout(false);
            panelLogoList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvLogos).EndInit();
            ((System.ComponentModel.ISupportInitialize)BagLogoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label2;
        internal Label Label4;
        internal ComboBox cboBagColor;
        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator1;
        internal Label Label9;
        internal TableLayoutPanel TableLayoutPanel2;
        internal ComboBox cboColortype;
        internal Label Label11;
        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator2;
        internal BunifuTextBox tbBagDescription;
        internal Label Label6;
        internal ComboBox cboBagSize;
        internal Label Label3;
        internal Label Label5;
        private ComboBox _cboBagWeight;

        internal ComboBox cboBagWeight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboBagWeight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboBagWeight != null)
                {
                    _cboBagWeight.SelectedValueChanged -= cboBagWeight_SelectedValueChanged;
                }

                _cboBagWeight = value;
                if (_cboBagWeight != null)
                {
                    _cboBagWeight.SelectedValueChanged += cboBagWeight_SelectedValueChanged;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel1;
        internal Label lvlBag;
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

        internal TableLayoutPanel TableLayoutPanel8;
        internal Label lblUnitWeight;
        internal Panel panelLogoList;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvLogos;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvLogos
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvLogos;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvLogos != null)
                {
                    _dgvLogos.DoubleClick -= dgvLogos_DoubleClick;
                }

                _dgvLogos = value;
                if (_dgvLogos != null)
                {
                    _dgvLogos.DoubleClick += dgvLogos_DoubleClick;
                }
            }
        }

        internal DataGridViewTextBoxColumn BagDescriptionDataGridViewTextBoxColumn;
        internal BindingSource BagLogoBindingSource;
        private Bunifu.Framework.UI.BunifuFlatButton _BunifuFlatButton1;

        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuFlatButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuFlatButton1 != null)
                {
                    _BunifuFlatButton1.Click -= BunifuFlatButton1_Click;
                }

                _BunifuFlatButton1 = value;
                if (_BunifuFlatButton1 != null)
                {
                    _BunifuFlatButton1.Click += BunifuFlatButton1_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnOkLogo;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOkLogo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnOkLogo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOkLogo != null)
                {
                    _btnOkLogo.Click -= btnOkLogo_Click;
                }

                _btnOkLogo = value;
                if (_btnOkLogo != null)
                {
                    _btnOkLogo.Click += btnOkLogo_Click;
                }
            }
        }

        internal Label Label10;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddLogo;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddLogo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddLogo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddLogo != null)
                {
                    _btnAddLogo.Click -= btnAddLogo_Click;
                }

                _btnAddLogo = value;
                if (_btnAddLogo != null)
                {
                    _btnAddLogo.Click += btnAddLogo_Click;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel4;
        internal PictureBox pbLogo;
        internal TableLayoutPanel TableLayoutPanel5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnChooseLogo;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnChooseLogo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnChooseLogo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnChooseLogo != null)
                {
                    _btnChooseLogo.Click -= btnChooseLogo_Click;
                }

                _btnChooseLogo = value;
                if (_btnChooseLogo != null)
                {
                    _btnChooseLogo.Click += btnChooseLogo_Click;
                }
            }
        }

        internal Label Label1;
        internal Label lblBagLogo;
        internal DataGridViewTextBoxColumn LogoDescription;
        internal DataGridViewTextBoxColumn BagYearDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ImagePathDataGridViewTextBoxColumn;
        internal Label lblWarning;
    }
}