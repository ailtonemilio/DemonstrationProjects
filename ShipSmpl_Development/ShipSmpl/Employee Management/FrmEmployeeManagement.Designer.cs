using System;
using System.Diagnostics;
using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;
namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmEmployeeManagement : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeManagement));
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
            var ToggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties19 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties20 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            Panel1 = new Panel();
            _printCardButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _printCardButton.Click += new EventHandler(printCardButton_Click);
            Panel2 = new Panel();
            _searchBunifuTextBox1 = new BunifuTextBox();
            _searchBunifuTextBox1.TextChanged += new EventHandler(searchBunifuTextBox1_TextChanged);
            _addEntryButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _addEntryButton.Click += new EventHandler(addEntryButton_Click);
            Label1 = new Label();
            _BunifuToggleSwitch1 = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            _BunifuToggleSwitch1.OnValuechange += new EventHandler(BunifuToggleSwitch1_OnValuechange);
            TableLayoutPanel3 = new TableLayoutPanel();
            _clearanceButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _clearanceButton.Click += new EventHandler(clearanceButton_Click);
            _modifyButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _modifyButton.Click += new EventHandler(Button1_Click_1);
            _terminateButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _terminateButton.Click += new EventHandler(Button2_Click_2);
            _cardIDButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cardIDButton.Click += new EventHandler(cardIDButton_Click);
            _createUsernameButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _createUsernameButton.Click += new EventHandler(createUsernameButton_Click);
            _deleteButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _deleteButton.Click += new EventHandler(deleteButton_Click);
            Panel3 = new Panel();
            _BunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            _BunifuDataGridView1.DoubleClick += new EventHandler(BunifuDataGridView1_CellContentClick);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            empManagementTitleLabel = new Label();
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_BunifuDataGridView1).BeginInit();
            BunifuShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel1.Controls.Add(_printCardButton);
            Panel1.Controls.Add(Panel2);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(10, 10);
            Panel1.Name = "Panel1";
            Panel1.Padding = new Padding(0, 40, 0, 0);
            Panel1.Size = new Size(1198, 836);
            Panel1.TabIndex = 33;
            // 
            // printCardButton
            // 
            _printCardButton.AllowToggling = false;
            _printCardButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _printCardButton.AnimationSpeed = 200;
            _printCardButton.AutoGenerateColors = false;
            _printCardButton.BackColor = Color.Transparent;
            _printCardButton.BackColor1 = Color.White;
            _printCardButton.BackgroundImage = (Image)resources.GetObject("printCardButton.BackgroundImage");
            _printCardButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _printCardButton.ButtonText = "Print Card";
            _printCardButton.ButtonTextMarginLeft = 15;
            _printCardButton.ColorContrastOnClick = 45;
            _printCardButton.ColorContrastOnHover = 45;
            _printCardButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _printCardButton.CustomizableEdges = BorderEdges1;
            _printCardButton.DialogResult = DialogResult.None;
            _printCardButton.DisabledBorderColor = Color.Empty;
            _printCardButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _printCardButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _printCardButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _printCardButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _printCardButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _printCardButton.IconLeftCursor = Cursors.Hand;
            _printCardButton.IconMarginLeft = 11;
            _printCardButton.IconPadding = 10;
            _printCardButton.IconRightCursor = Cursors.Hand;
            _printCardButton.IdleBorderColor = Color.LightGray;
            _printCardButton.IdleBorderRadius = 35;
            _printCardButton.IdleBorderThickness = 1;
            _printCardButton.IdleFillColor = Color.White;
            _printCardButton.IdleIconLeftImage = My.Resources.Resources.badge;
            _printCardButton.IdleIconRightImage = null;
            _printCardButton.IndicateFocus = true;
            _printCardButton.Location = new Point(1055, 3);
            _printCardButton.Name = "_printCardButton";
            StateProperties1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties1.BorderRadius = 35;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _printCardButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties2.BorderRadius = 35;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _printCardButton.OnPressedState = StateProperties2;
            _printCardButton.Padding = new Padding(3, 0, 3, 0);
            _printCardButton.Size = new Size(136, 34);
            _printCardButton.TabIndex = 75;
            _printCardButton.TextAlign = ContentAlignment.MiddleCenter;
            _printCardButton.TextMarginLeft = 15;
            _printCardButton.UseDefaultRadiusAndThickness = true;
            // 
            // Panel2
            // 
            Panel2.AutoScroll = true;
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(_searchBunifuTextBox1);
            Panel2.Controls.Add(_addEntryButton);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(_BunifuToggleSwitch1);
            Panel2.Controls.Add(TableLayoutPanel3);
            Panel2.Controls.Add(Panel3);
            Panel2.Controls.Add(empManagementTitleLabel);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(0, 40);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1198, 796);
            Panel2.TabIndex = 1;
            // 
            // searchBunifuTextBox1
            // 
            _searchBunifuTextBox1.AcceptsReturn = false;
            _searchBunifuTextBox1.AcceptsTab = false;
            _searchBunifuTextBox1.Anchor = AnchorStyles.None;
            _searchBunifuTextBox1.AnimationSpeed = 200;
            _searchBunifuTextBox1.AutoCompleteMode = AutoCompleteMode.None;
            _searchBunifuTextBox1.AutoCompleteSource = AutoCompleteSource.None;
            _searchBunifuTextBox1.BackColor = Color.Transparent;
            _searchBunifuTextBox1.BackgroundImage = (Image)resources.GetObject("searchBunifuTextBox1.BackgroundImage");
            _searchBunifuTextBox1.BorderColorActive = Color.DodgerBlue;
            _searchBunifuTextBox1.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _searchBunifuTextBox1.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _searchBunifuTextBox1.BorderColorIdle = Color.Silver;
            _searchBunifuTextBox1.BorderRadius = 1;
            _searchBunifuTextBox1.BorderThickness = 1;
            _searchBunifuTextBox1.CharacterCasing = CharacterCasing.Normal;
            _searchBunifuTextBox1.Cursor = Cursors.IBeam;
            _searchBunifuTextBox1.DefaultFont = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _searchBunifuTextBox1.DefaultText = "";
            _searchBunifuTextBox1.FillColor = Color.White;
            _searchBunifuTextBox1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _searchBunifuTextBox1.HideSelection = true;
            _searchBunifuTextBox1.IconLeft = null;
            _searchBunifuTextBox1.IconLeftCursor = Cursors.IBeam;
            _searchBunifuTextBox1.IconPadding = 10;
            _searchBunifuTextBox1.IconRight = null;
            _searchBunifuTextBox1.IconRightCursor = Cursors.IBeam;
            _searchBunifuTextBox1.Lines = new string[0];
            _searchBunifuTextBox1.Location = new Point(817, 65);
            _searchBunifuTextBox1.MaxLength = 32767;
            _searchBunifuTextBox1.MinimumSize = new Size(100, 35);
            _searchBunifuTextBox1.Modified = false;
            _searchBunifuTextBox1.Multiline = false;
            _searchBunifuTextBox1.Name = "_searchBunifuTextBox1";
            StateProperties3.BorderColor = Color.DodgerBlue;
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnActiveState = StateProperties3;
            StateProperties4.BorderColor = Color.Empty;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Empty;
            StateProperties4.PlaceholderForeColor = Color.Silver;
            _searchBunifuTextBox1.OnDisabledState = StateProperties4;
            StateProperties5.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Silver;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties6.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnIdleState = StateProperties6;
            _searchBunifuTextBox1.PasswordChar = '\0';
            _searchBunifuTextBox1.PlaceholderForeColor = Color.Silver;
            _searchBunifuTextBox1.PlaceholderText = "Search...";
            _searchBunifuTextBox1.ReadOnly = false;
            _searchBunifuTextBox1.ScrollBars = ScrollBars.None;
            _searchBunifuTextBox1.SelectedText = "";
            _searchBunifuTextBox1.SelectionLength = 0;
            _searchBunifuTextBox1.SelectionStart = 0;
            _searchBunifuTextBox1.ShortcutsEnabled = true;
            _searchBunifuTextBox1.Size = new Size(312, 35);
            _searchBunifuTextBox1.Style = _Style.Bunifu;
            _searchBunifuTextBox1.TabIndex = 79;
            _searchBunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            _searchBunifuTextBox1.TextMarginBottom = 0;
            _searchBunifuTextBox1.TextMarginLeft = 5;
            _searchBunifuTextBox1.TextMarginTop = 0;
            _searchBunifuTextBox1.TextPlaceholder = "Search...";
            _searchBunifuTextBox1.UseSystemPasswordChar = false;
            _searchBunifuTextBox1.WordWrap = true;
            // 
            // addEntryButton
            // 
            _addEntryButton.AllowToggling = false;
            _addEntryButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _addEntryButton.AnimationSpeed = 200;
            _addEntryButton.AutoGenerateColors = false;
            _addEntryButton.BackColor = Color.Transparent;
            _addEntryButton.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _addEntryButton.BackgroundImage = (Image)resources.GetObject("addEntryButton.BackgroundImage");
            _addEntryButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _addEntryButton.ButtonText = "New Employee";
            _addEntryButton.ButtonTextMarginLeft = 0;
            _addEntryButton.ColorContrastOnClick = 45;
            _addEntryButton.ColorContrastOnHover = 45;
            _addEntryButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _addEntryButton.CustomizableEdges = BorderEdges2;
            _addEntryButton.DialogResult = DialogResult.None;
            _addEntryButton.DisabledBorderColor = Color.Empty;
            _addEntryButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _addEntryButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _addEntryButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _addEntryButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _addEntryButton.ForeColor = Color.White;
            _addEntryButton.IconLeftCursor = Cursors.Hand;
            _addEntryButton.IconMarginLeft = 11;
            _addEntryButton.IconPadding = 10;
            _addEntryButton.IconRightCursor = Cursors.Hand;
            _addEntryButton.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _addEntryButton.IdleBorderRadius = 40;
            _addEntryButton.IdleBorderThickness = 1;
            _addEntryButton.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _addEntryButton.IdleIconLeftImage = null;
            _addEntryButton.IdleIconRightImage = null;
            _addEntryButton.IndicateFocus = true;
            _addEntryButton.Location = new Point(1059, 20);
            _addEntryButton.Name = "_addEntryButton";
            StateProperties7.BorderColor = Color.Coral;
            StateProperties7.BorderRadius = 40;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.Coral;
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _addEntryButton.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties8.BorderRadius = 40;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _addEntryButton.OnPressedState = StateProperties8;
            _addEntryButton.Size = new Size(136, 45);
            _addEntryButton.TabIndex = 75;
            _addEntryButton.TextAlign = ContentAlignment.MiddleCenter;
            _addEntryButton.TextMarginLeft = 0;
            _addEntryButton.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.None;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(71, 71);
            Label1.Name = "Label1";
            Label1.Size = new Size(178, 25);
            Label1.TabIndex = 74;
            Label1.Text = "Show all employees";
            // 
            // BunifuToggleSwitch1
            // 
            _BunifuToggleSwitch1.Anchor = AnchorStyles.None;
            _BunifuToggleSwitch1.Animation = 5;
            _BunifuToggleSwitch1.BackColor = Color.Transparent;
            _BunifuToggleSwitch1.BackgroundImage = (Image)resources.GetObject("BunifuToggleSwitch1.BackgroundImage");
            _BunifuToggleSwitch1.Cursor = Cursors.Hand;
            _BunifuToggleSwitch1.Location = new Point(255, 69);
            _BunifuToggleSwitch1.Name = "_BunifuToggleSwitch1";
            _BunifuToggleSwitch1.Size = new Size(48, 27);
            _BunifuToggleSwitch1.TabIndex = 73;
            ToggleState1.BackColor = Color.Empty;
            ToggleState1.BackColorInner = Color.Empty;
            ToggleState1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(236)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(140)));
            ToggleState1.BorderColorInner = Color.Empty;
            ToggleState1.BorderRadius = 1;
            ToggleState1.BorderRadiusInner = 1;
            ToggleState1.BorderThickness = 1;
            ToggleState1.BorderThicknessInner = 1;
            _BunifuToggleSwitch1.ToggleStateDisabled = ToggleState1;
            ToggleState2.BackColor = Color.Gray;
            ToggleState2.BackColorInner = Color.White;
            ToggleState2.BorderColor = Color.Gray;
            ToggleState2.BorderColorInner = Color.White;
            ToggleState2.BorderRadius = 17;
            ToggleState2.BorderRadiusInner = 15;
            ToggleState2.BorderThickness = 1;
            ToggleState2.BorderThicknessInner = 1;
            _BunifuToggleSwitch1.ToggleStateOff = ToggleState2;
            ToggleState3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState3.BackColorInner = Color.White;
            ToggleState3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState3.BorderColorInner = Color.White;
            ToggleState3.BorderRadius = 17;
            ToggleState3.BorderRadiusInner = 15;
            ToggleState3.BorderThickness = 1;
            ToggleState3.BorderThicknessInner = 1;
            _BunifuToggleSwitch1.ToggleStateOn = ToggleState3;
            _BunifuToggleSwitch1.Value = false;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.Anchor = AnchorStyles.None;
            TableLayoutPanel3.ColumnCount = 6;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.16554f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.13553f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.99205f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.60636f));
            TableLayoutPanel3.Controls.Add(_clearanceButton, 0, 0);
            TableLayoutPanel3.Controls.Add(_modifyButton, 0, 0);
            TableLayoutPanel3.Controls.Add(_terminateButton, 3, 0);
            TableLayoutPanel3.Controls.Add(_cardIDButton, 3, 0);
            TableLayoutPanel3.Controls.Add(_createUsernameButton, 1, 0);
            TableLayoutPanel3.Controls.Add(_deleteButton, 5, 0);
            TableLayoutPanel3.Location = new Point(110, 710);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel3.Size = new Size(972, 55);
            TableLayoutPanel3.TabIndex = 72;
            // 
            // clearanceButton
            // 
            _clearanceButton.AllowToggling = false;
            _clearanceButton.AnimationSpeed = 200;
            _clearanceButton.AutoGenerateColors = false;
            _clearanceButton.BackColor = Color.Transparent;
            _clearanceButton.BackColor1 = Color.Teal;
            _clearanceButton.BackgroundImage = (Image)resources.GetObject("clearanceButton.BackgroundImage");
            _clearanceButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _clearanceButton.ButtonText = "Set Clearance";
            _clearanceButton.ButtonTextMarginLeft = 0;
            _clearanceButton.ColorContrastOnClick = 45;
            _clearanceButton.ColorContrastOnHover = 45;
            _clearanceButton.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _clearanceButton.CustomizableEdges = BorderEdges3;
            _clearanceButton.DialogResult = DialogResult.None;
            _clearanceButton.DisabledBorderColor = Color.Empty;
            _clearanceButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _clearanceButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _clearanceButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _clearanceButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _clearanceButton.ForeColor = Color.White;
            _clearanceButton.IconLeftCursor = Cursors.Hand;
            _clearanceButton.IconMarginLeft = 11;
            _clearanceButton.IconPadding = 10;
            _clearanceButton.IconRightCursor = Cursors.Hand;
            _clearanceButton.IdleBorderColor = Color.Teal;
            _clearanceButton.IdleBorderRadius = 3;
            _clearanceButton.IdleBorderThickness = 1;
            _clearanceButton.IdleFillColor = Color.Teal;
            _clearanceButton.IdleIconLeftImage = null;
            _clearanceButton.IdleIconRightImage = null;
            _clearanceButton.IndicateFocus = true;
            _clearanceButton.Location = new Point(130, 3);
            _clearanceButton.Name = "_clearanceButton";
            StateProperties9.BorderColor = Color.MediumTurquoise;
            StateProperties9.BorderRadius = 3;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.MediumTurquoise;
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            _clearanceButton.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.Teal;
            StateProperties10.BorderRadius = 3;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.Teal;
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            _clearanceButton.OnPressedState = StateProperties10;
            _clearanceButton.Size = new Size(189, 45);
            _clearanceButton.TabIndex = 71;
            _clearanceButton.TextAlign = ContentAlignment.MiddleCenter;
            _clearanceButton.TextMarginLeft = 0;
            _clearanceButton.UseDefaultRadiusAndThickness = true;
            // 
            // modifyButton
            // 
            _modifyButton.AllowToggling = false;
            _modifyButton.AnimationSpeed = 200;
            _modifyButton.AutoGenerateColors = false;
            _modifyButton.BackColor = Color.Transparent;
            _modifyButton.BackColor1 = Color.Teal;
            _modifyButton.BackgroundImage = (Image)resources.GetObject("modifyButton.BackgroundImage");
            _modifyButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _modifyButton.ButtonText = "Edit";
            _modifyButton.ButtonTextMarginLeft = 0;
            _modifyButton.ColorContrastOnClick = 45;
            _modifyButton.ColorContrastOnHover = 45;
            _modifyButton.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _modifyButton.CustomizableEdges = BorderEdges4;
            _modifyButton.DialogResult = DialogResult.None;
            _modifyButton.DisabledBorderColor = Color.Empty;
            _modifyButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _modifyButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _modifyButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _modifyButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _modifyButton.ForeColor = Color.White;
            _modifyButton.IconLeftCursor = Cursors.Hand;
            _modifyButton.IconMarginLeft = 11;
            _modifyButton.IconPadding = 10;
            _modifyButton.IconRightCursor = Cursors.Hand;
            _modifyButton.IdleBorderColor = Color.Teal;
            _modifyButton.IdleBorderRadius = 3;
            _modifyButton.IdleBorderThickness = 1;
            _modifyButton.IdleFillColor = Color.Teal;
            _modifyButton.IdleIconLeftImage = null;
            _modifyButton.IdleIconRightImage = null;
            _modifyButton.IndicateFocus = true;
            _modifyButton.Location = new Point(3, 3);
            _modifyButton.Name = "_modifyButton";
            StateProperties11.BorderColor = Color.MediumTurquoise;
            StateProperties11.BorderRadius = 3;
            StateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties11.BorderThickness = 1;
            StateProperties11.FillColor = Color.MediumTurquoise;
            StateProperties11.ForeColor = Color.White;
            StateProperties11.IconLeftImage = null;
            StateProperties11.IconRightImage = null;
            _modifyButton.onHoverState = StateProperties11;
            StateProperties12.BorderColor = Color.Teal;
            StateProperties12.BorderRadius = 3;
            StateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties12.BorderThickness = 1;
            StateProperties12.FillColor = Color.Teal;
            StateProperties12.ForeColor = Color.White;
            StateProperties12.IconLeftImage = null;
            StateProperties12.IconRightImage = null;
            _modifyButton.OnPressedState = StateProperties12;
            _modifyButton.Size = new Size(121, 45);
            _modifyButton.TabIndex = 67;
            _modifyButton.TextAlign = ContentAlignment.MiddleCenter;
            _modifyButton.TextMarginLeft = 0;
            _modifyButton.UseDefaultRadiusAndThickness = true;
            // 
            // terminateButton
            // 
            _terminateButton.AllowToggling = false;
            _terminateButton.AnimationSpeed = 200;
            _terminateButton.AutoGenerateColors = false;
            _terminateButton.BackColor = Color.Transparent;
            _terminateButton.BackColor1 = Color.Teal;
            _terminateButton.BackgroundImage = (Image)resources.GetObject("terminateButton.BackgroundImage");
            _terminateButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _terminateButton.ButtonText = "Suspend/Reinstate";
            _terminateButton.ButtonTextMarginLeft = 0;
            _terminateButton.ColorContrastOnClick = 45;
            _terminateButton.ColorContrastOnHover = 45;
            _terminateButton.Cursor = Cursors.Hand;
            BorderEdges5.BottomLeft = true;
            BorderEdges5.BottomRight = true;
            BorderEdges5.TopLeft = true;
            BorderEdges5.TopRight = true;
            _terminateButton.CustomizableEdges = BorderEdges5;
            _terminateButton.DialogResult = DialogResult.None;
            _terminateButton.DisabledBorderColor = Color.Empty;
            _terminateButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _terminateButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _terminateButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _terminateButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _terminateButton.ForeColor = Color.White;
            _terminateButton.IconLeftCursor = Cursors.Hand;
            _terminateButton.IconMarginLeft = 11;
            _terminateButton.IconPadding = 10;
            _terminateButton.IconRightCursor = Cursors.Hand;
            _terminateButton.IdleBorderColor = Color.Teal;
            _terminateButton.IdleBorderRadius = 3;
            _terminateButton.IdleBorderThickness = 1;
            _terminateButton.IdleFillColor = Color.Teal;
            _terminateButton.IdleIconLeftImage = null;
            _terminateButton.IdleIconRightImage = null;
            _terminateButton.IndicateFocus = true;
            _terminateButton.Location = new Point(647, 3);
            _terminateButton.Name = "_terminateButton";
            StateProperties13.BorderColor = Color.MediumTurquoise;
            StateProperties13.BorderRadius = 3;
            StateProperties13.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties13.BorderThickness = 1;
            StateProperties13.FillColor = Color.MediumTurquoise;
            StateProperties13.ForeColor = Color.White;
            StateProperties13.IconLeftImage = null;
            StateProperties13.IconRightImage = null;
            _terminateButton.onHoverState = StateProperties13;
            StateProperties14.BorderColor = Color.Teal;
            StateProperties14.BorderRadius = 3;
            StateProperties14.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties14.BorderThickness = 1;
            StateProperties14.FillColor = Color.Teal;
            StateProperties14.ForeColor = Color.White;
            StateProperties14.IconLeftImage = null;
            StateProperties14.IconRightImage = null;
            _terminateButton.OnPressedState = StateProperties14;
            _terminateButton.Size = new Size(168, 45);
            _terminateButton.TabIndex = 61;
            _terminateButton.TextAlign = ContentAlignment.MiddleCenter;
            _terminateButton.TextMarginLeft = 0;
            _terminateButton.UseDefaultRadiusAndThickness = true;
            // 
            // cardIDButton
            // 
            _cardIDButton.AllowToggling = false;
            _cardIDButton.AnimationSpeed = 200;
            _cardIDButton.AutoGenerateColors = false;
            _cardIDButton.BackColor = Color.Transparent;
            _cardIDButton.BackColor1 = Color.Teal;
            _cardIDButton.BackgroundImage = (Image)resources.GetObject("cardIDButton.BackgroundImage");
            _cardIDButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _cardIDButton.ButtonText = "Set Card/Phone ID";
            _cardIDButton.ButtonTextMarginLeft = 0;
            _cardIDButton.ColorContrastOnClick = 45;
            _cardIDButton.ColorContrastOnHover = 45;
            _cardIDButton.Cursor = Cursors.Hand;
            BorderEdges6.BottomLeft = true;
            BorderEdges6.BottomRight = true;
            BorderEdges6.TopLeft = true;
            BorderEdges6.TopRight = true;
            _cardIDButton.CustomizableEdges = BorderEdges6;
            _cardIDButton.DialogResult = DialogResult.None;
            _cardIDButton.DisabledBorderColor = Color.Empty;
            _cardIDButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _cardIDButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _cardIDButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _cardIDButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _cardIDButton.ForeColor = Color.White;
            _cardIDButton.IconLeftCursor = Cursors.Hand;
            _cardIDButton.IconMarginLeft = 11;
            _cardIDButton.IconPadding = 10;
            _cardIDButton.IconRightCursor = Cursors.Hand;
            _cardIDButton.IdleBorderColor = Color.Teal;
            _cardIDButton.IdleBorderRadius = 3;
            _cardIDButton.IdleBorderThickness = 1;
            _cardIDButton.IdleFillColor = Color.Teal;
            _cardIDButton.IdleIconLeftImage = null;
            _cardIDButton.IdleIconRightImage = null;
            _cardIDButton.IndicateFocus = true;
            _cardIDButton.Location = new Point(486, 3);
            _cardIDButton.Name = "_cardIDButton";
            StateProperties15.BorderColor = Color.MediumTurquoise;
            StateProperties15.BorderRadius = 3;
            StateProperties15.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties15.BorderThickness = 1;
            StateProperties15.FillColor = Color.MediumTurquoise;
            StateProperties15.ForeColor = Color.White;
            StateProperties15.IconLeftImage = null;
            StateProperties15.IconRightImage = null;
            _cardIDButton.onHoverState = StateProperties15;
            StateProperties16.BorderColor = Color.Teal;
            StateProperties16.BorderRadius = 3;
            StateProperties16.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties16.BorderThickness = 1;
            StateProperties16.FillColor = Color.Teal;
            StateProperties16.ForeColor = Color.White;
            StateProperties16.IconLeftImage = null;
            StateProperties16.IconRightImage = null;
            _cardIDButton.OnPressedState = StateProperties16;
            _cardIDButton.Size = new Size(155, 45);
            _cardIDButton.TabIndex = 69;
            _cardIDButton.TextAlign = ContentAlignment.MiddleCenter;
            _cardIDButton.TextMarginLeft = 0;
            _cardIDButton.UseDefaultRadiusAndThickness = true;
            // 
            // createUsernameButton
            // 
            _createUsernameButton.AllowToggling = false;
            _createUsernameButton.AnimationSpeed = 200;
            _createUsernameButton.AutoGenerateColors = false;
            _createUsernameButton.BackColor = Color.Transparent;
            _createUsernameButton.BackColor1 = Color.Teal;
            _createUsernameButton.BackgroundImage = (Image)resources.GetObject("createUsernameButton.BackgroundImage");
            _createUsernameButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _createUsernameButton.ButtonText = "Create Login";
            _createUsernameButton.ButtonTextMarginLeft = 0;
            _createUsernameButton.ColorContrastOnClick = 45;
            _createUsernameButton.ColorContrastOnHover = 45;
            _createUsernameButton.Cursor = Cursors.Hand;
            BorderEdges7.BottomLeft = true;
            BorderEdges7.BottomRight = true;
            BorderEdges7.TopLeft = true;
            BorderEdges7.TopRight = true;
            _createUsernameButton.CustomizableEdges = BorderEdges7;
            _createUsernameButton.DialogResult = DialogResult.None;
            _createUsernameButton.DisabledBorderColor = Color.Empty;
            _createUsernameButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _createUsernameButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _createUsernameButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _createUsernameButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _createUsernameButton.ForeColor = Color.White;
            _createUsernameButton.IconLeftCursor = Cursors.Hand;
            _createUsernameButton.IconMarginLeft = 11;
            _createUsernameButton.IconPadding = 10;
            _createUsernameButton.IconRightCursor = Cursors.Hand;
            _createUsernameButton.IdleBorderColor = Color.Teal;
            _createUsernameButton.IdleBorderRadius = 3;
            _createUsernameButton.IdleBorderThickness = 1;
            _createUsernameButton.IdleFillColor = Color.Teal;
            _createUsernameButton.IdleIconLeftImage = null;
            _createUsernameButton.IdleIconRightImage = null;
            _createUsernameButton.IndicateFocus = true;
            _createUsernameButton.Location = new Point(325, 3);
            _createUsernameButton.Name = "_createUsernameButton";
            StateProperties17.BorderColor = Color.MediumTurquoise;
            StateProperties17.BorderRadius = 3;
            StateProperties17.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties17.BorderThickness = 1;
            StateProperties17.FillColor = Color.MediumTurquoise;
            StateProperties17.ForeColor = Color.White;
            StateProperties17.IconLeftImage = null;
            StateProperties17.IconRightImage = null;
            _createUsernameButton.onHoverState = StateProperties17;
            StateProperties18.BorderColor = Color.Teal;
            StateProperties18.BorderRadius = 3;
            StateProperties18.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties18.BorderThickness = 1;
            StateProperties18.FillColor = Color.Teal;
            StateProperties18.ForeColor = Color.White;
            StateProperties18.IconLeftImage = null;
            StateProperties18.IconRightImage = null;
            _createUsernameButton.OnPressedState = StateProperties18;
            _createUsernameButton.Size = new Size(155, 45);
            _createUsernameButton.TabIndex = 68;
            _createUsernameButton.TextAlign = ContentAlignment.MiddleCenter;
            _createUsernameButton.TextMarginLeft = 0;
            _createUsernameButton.UseDefaultRadiusAndThickness = true;
            // 
            // deleteButton
            // 
            _deleteButton.AllowToggling = false;
            _deleteButton.AnimationSpeed = 200;
            _deleteButton.AutoGenerateColors = false;
            _deleteButton.BackColor = Color.Transparent;
            _deleteButton.BackColor1 = Color.IndianRed;
            _deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            _deleteButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _deleteButton.ButtonText = "Delete";
            _deleteButton.ButtonTextMarginLeft = 0;
            _deleteButton.ColorContrastOnClick = 45;
            _deleteButton.ColorContrastOnHover = 45;
            _deleteButton.Cursor = Cursors.Hand;
            BorderEdges8.BottomLeft = true;
            BorderEdges8.BottomRight = true;
            BorderEdges8.TopLeft = true;
            BorderEdges8.TopRight = true;
            _deleteButton.CustomizableEdges = BorderEdges8;
            _deleteButton.DialogResult = DialogResult.None;
            _deleteButton.DisabledBorderColor = Color.Empty;
            _deleteButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _deleteButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _deleteButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _deleteButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _deleteButton.ForeColor = Color.White;
            _deleteButton.IconLeftCursor = Cursors.Hand;
            _deleteButton.IconMarginLeft = 11;
            _deleteButton.IconPadding = 10;
            _deleteButton.IconRightCursor = Cursors.Hand;
            _deleteButton.IdleBorderColor = Color.IndianRed;
            _deleteButton.IdleBorderRadius = 3;
            _deleteButton.IdleBorderThickness = 1;
            _deleteButton.IdleFillColor = Color.IndianRed;
            _deleteButton.IdleIconLeftImage = null;
            _deleteButton.IdleIconRightImage = null;
            _deleteButton.IndicateFocus = true;
            _deleteButton.Location = new Point(821, 3);
            _deleteButton.Name = "_deleteButton";
            StateProperties19.BorderColor = Color.LightCoral;
            StateProperties19.BorderRadius = 3;
            StateProperties19.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties19.BorderThickness = 1;
            StateProperties19.FillColor = Color.LightCoral;
            StateProperties19.ForeColor = Color.White;
            StateProperties19.IconLeftImage = null;
            StateProperties19.IconRightImage = null;
            _deleteButton.onHoverState = StateProperties19;
            StateProperties20.BorderColor = Color.IndianRed;
            StateProperties20.BorderRadius = 3;
            StateProperties20.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties20.BorderThickness = 1;
            StateProperties20.FillColor = Color.IndianRed;
            StateProperties20.ForeColor = Color.White;
            StateProperties20.IconLeftImage = null;
            StateProperties20.IconRightImage = null;
            _deleteButton.OnPressedState = StateProperties20;
            _deleteButton.Size = new Size(148, 45);
            _deleteButton.TabIndex = 70;
            _deleteButton.TextAlign = ContentAlignment.MiddleCenter;
            _deleteButton.TextMarginLeft = 0;
            _deleteButton.UseDefaultRadiusAndThickness = true;
            // 
            // Panel3
            // 
            Panel3.Anchor = AnchorStyles.None;
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(_BunifuDataGridView1);
            Panel3.Location = new Point(62, 102);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1068, 602);
            Panel3.TabIndex = 60;
            // 
            // BunifuDataGridView1
            // 
            _BunifuDataGridView1.AllowCustomTheming = true;
            _BunifuDataGridView1.AllowUserToAddRows = false;
            _BunifuDataGridView1.AllowUserToDeleteRows = false;
            _BunifuDataGridView1.AllowUserToResizeColumns = false;
            _BunifuDataGridView1.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            _BunifuDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _BunifuDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _BunifuDataGridView1.BackgroundColor = Color.White;
            _BunifuDataGridView1.BorderStyle = BorderStyle.None;
            _BunifuDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _BunifuDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _BunifuDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _BunifuDataGridView1.ColumnHeadersHeight = 40;
            _BunifuDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            _BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _BunifuDataGridView1.CurrentTheme.BackColor = Color.Snow;
            _BunifuDataGridView1.CurrentTheme.GridColor = Color.Gray;
            _BunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _BunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _BunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _BunifuDataGridView1.CurrentTheme.Name = null;
            _BunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _BunifuDataGridView1.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _BunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _BunifuDataGridView1.DefaultCellStyle = DataGridViewCellStyle3;
            _BunifuDataGridView1.Dock = DockStyle.Fill;
            _BunifuDataGridView1.EnableHeadersVisualStyles = false;
            _BunifuDataGridView1.GridColor = Color.Gray;
            _BunifuDataGridView1.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _BunifuDataGridView1.HeaderBgColor = Color.Empty;
            _BunifuDataGridView1.HeaderForeColor = Color.White;
            _BunifuDataGridView1.Location = new Point(0, 0);
            _BunifuDataGridView1.Name = "_BunifuDataGridView1";
            _BunifuDataGridView1.ReadOnly = true;
            _BunifuDataGridView1.RowHeadersVisible = false;
            _BunifuDataGridView1.RowTemplate.Height = 40;
            _BunifuDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _BunifuDataGridView1.Size = new Size(1066, 600);
            _BunifuDataGridView1.TabIndex = 59;
            _BunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column1
            // 
            Column1.FillWeight = 113.8421f;
            Column1.HeaderText = "Alias";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 113.8421f;
            Column2.HeaderText = "First Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 113.8421f;
            Column3.HeaderText = "Last Name";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 73.09647f;
            Column4.HeaderText = "Yard";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 94.30699f;
            Column5.HeaderText = "Phone Number";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.FillWeight = 91.07047f;
            Column6.HeaderText = "Status";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "ID";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Visible = false;
            // 
            // empManagementTitleLabel
            // 
            empManagementTitleLabel.Anchor = AnchorStyles.None;
            empManagementTitleLabel.BackColor = Color.Transparent;
            empManagementTitleLabel.FlatStyle = FlatStyle.Flat;
            empManagementTitleLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            empManagementTitleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            empManagementTitleLabel.Location = new Point(66, 20);
            empManagementTitleLabel.Margin = new Padding(2, 0, 2, 0);
            empManagementTitleLabel.Name = "empManagementTitleLabel";
            empManagementTitleLabel.Size = new Size(712, 35);
            empManagementTitleLabel.TabIndex = 50;
            empManagementTitleLabel.Text = "Double click an employee to see details";
            empManagementTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
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
            BunifuShadowPanel1.Size = new Size(1213, 851);
            BunifuShadowPanel1.TabIndex = 36;
            // 
            // FrmEmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1213, 851);
            ControlBox = false;
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmployeeManagement";
            StartPosition = FormStartPosition.Manual;
            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            TableLayoutPanel3.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_BunifuDataGridView1).EndInit();
            BunifuShadowPanel1.ResumeLayout(false);
            Load += new EventHandler(EmployeeManagementForm_Load);
            ResumeLayout(false);
        }

        internal Panel Panel1;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Label empManagementTitleLabel;
        internal Panel Panel2;
        internal Panel Panel3;
        internal TableLayoutPanel TableLayoutPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _clearanceButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton clearanceButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _clearanceButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_clearanceButton != null)
                {
                    _clearanceButton.Click -= clearanceButton_Click;
                }

                _clearanceButton = value;
                if (_clearanceButton != null)
                {
                    _clearanceButton.Click += clearanceButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _cardIDButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton cardIDButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cardIDButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cardIDButton != null)
                {
                    _cardIDButton.Click -= cardIDButton_Click;
                }

                _cardIDButton = value;
                if (_cardIDButton != null)
                {
                    _cardIDButton.Click += cardIDButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _createUsernameButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton createUsernameButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _createUsernameButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_createUsernameButton != null)
                {
                    _createUsernameButton.Click -= createUsernameButton_Click;
                }

                _createUsernameButton = value;
                if (_createUsernameButton != null)
                {
                    _createUsernameButton.Click += createUsernameButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _modifyButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton modifyButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _modifyButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_modifyButton != null)
                {
                    _modifyButton.Click -= Button1_Click_1;
                }

                _modifyButton = value;
                if (_modifyButton != null)
                {
                    _modifyButton.Click += Button1_Click_1;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _deleteButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _deleteButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_deleteButton != null)
                {
                    _deleteButton.Click -= deleteButton_Click;
                }

                _deleteButton = value;
                if (_deleteButton != null)
                {
                    _deleteButton.Click += deleteButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _terminateButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton terminateButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _terminateButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_terminateButton != null)
                {
                    _terminateButton.Click -= Button2_Click_2;
                }

                _terminateButton = value;
                if (_terminateButton != null)
                {
                    _terminateButton.Click += Button2_Click_2;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _printCardButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton printCardButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _printCardButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_printCardButton != null)
                {
                    _printCardButton.Click -= printCardButton_Click;
                }

                _printCardButton = value;
                if (_printCardButton != null)
                {
                    _printCardButton.Click += printCardButton_Click;
                }
            }
        }

        private Bunifu.ToggleSwitch.BunifuToggleSwitch _BunifuToggleSwitch1;

        internal Bunifu.ToggleSwitch.BunifuToggleSwitch BunifuToggleSwitch1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuToggleSwitch1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuToggleSwitch1 != null)
                {
                    _BunifuToggleSwitch1.OnValuechange -= BunifuToggleSwitch1_OnValuechange;
                }

                _BunifuToggleSwitch1 = value;
                if (_BunifuToggleSwitch1 != null)
                {
                    _BunifuToggleSwitch1.OnValuechange += BunifuToggleSwitch1_OnValuechange;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDataGridView _BunifuDataGridView1;

        internal Bunifu.UI.WinForms.BunifuDataGridView BunifuDataGridView1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuDataGridView1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuDataGridView1 != null)
                {
                    _BunifuDataGridView1.DoubleClick -= BunifuDataGridView1_CellContentClick;
                }

                _BunifuDataGridView1 = value;
                if (_BunifuDataGridView1 != null)
                {
                    _BunifuDataGridView1.DoubleClick += BunifuDataGridView1_CellContentClick;
                }
            }
        }

        internal Label Label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _addEntryButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton addEntryButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _addEntryButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_addEntryButton != null)
                {
                    _addEntryButton.Click -= addEntryButton_Click;
                }

                _addEntryButton = value;
                if (_addEntryButton != null)
                {
                    _addEntryButton.Click += addEntryButton_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column6;
        internal DataGridViewTextBoxColumn Column7;
        private BunifuTextBox _searchBunifuTextBox1;

        internal BunifuTextBox searchBunifuTextBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _searchBunifuTextBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_searchBunifuTextBox1 != null)
                {
                    _searchBunifuTextBox1.TextChanged -= searchBunifuTextBox1_TextChanged;
                }

                _searchBunifuTextBox1 = value;
                if (_searchBunifuTextBox1 != null)
                {
                    _searchBunifuTextBox1.TextChanged += searchBunifuTextBox1_TextChanged;
                }
            }
        }
        // Friend WithEvents WTCOperationsDataSet As WTCOperationsDataSet
        // Friend WithEvents EmployeesBindingSource As BindingSource
        // Friend WithEvents EmployeesTableAdapter As WTCOperationsDataSetTableAdapters.EmployeesTableAdapter
        // Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        // Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        // Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        // Friend WithEvents AliasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        // 'Friend WithEvents WTCOperationsDataSet1 As WTCOperationsDataSet1
        // Friend WithEvents EmployeesBindingSource1 As BindingSource
        // Friend WithEvents EmployeesTableAdapter1 As WTCOperationsDataSet1TableAdapters.EmployeesTableAdapter
    }
}