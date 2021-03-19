using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Microsoft.VisualBasic.CompilerServices;
using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmListBlockedContainers : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListBlockedContainers));
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel1 = new Panel();
            Panel2 = new Panel();
            _searchBunifuTextBox1 = new BunifuTextBox();
            _searchBunifuTextBox1.TextChanged += new EventHandler(searchBunifuTextBox1_TextChanged);
            _searchBunifuTextBox1.TextChanged += new EventHandler(searchBunifuTextBox1_TextChanged_1);
            _refheshInShapedButton = new CustomizedControlsLibrary.ShapedButton();
            _refheshInShapedButton.Click += new EventHandler(refheshInShapedButton_Click);
            toInBunifuDatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            fromInBunifuDatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            Label1 = new Label();
            Label2 = new Label();
            TableLayoutPanel3 = new TableLayoutPanel();
            _deleteButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _deleteButton.Click += new EventHandler(deleteButton_Click);
            titleLabel = new Label();
            Panel4 = new Panel();
            _blockContBunifuDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            _blockContBunifuDataGridView.RowPostPaint += new DataGridViewRowPostPaintEventHandler(blockContBunifuDataGridView_RowPostPaint);
            _blockContBunifuDataGridView.CellContentClick += new DataGridViewCellEventHandler(transfersBunifuDataGridView_CellContentClick);
            Column1 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewCheckBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            _createTransfeRButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _createTransfeRButton.Click += new EventHandler(createTransfeRButton_Click);
            BunifuShadowPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_blockContBunifuDataGridView).BeginInit();
            SuspendLayout();
            // 
            // BunifuShadowPanel1
            // 
            BunifuShadowPanel1.BackColor = Color.White;
            BunifuShadowPanel1.BorderColor = Color.Transparent;
            BunifuShadowPanel1.Controls.Add(Panel1);
            BunifuShadowPanel1.Dock = DockStyle.Fill;
            BunifuShadowPanel1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuShadowPanel1.Location = new Point(0, 0);
            BunifuShadowPanel1.Margin = new Padding(0);
            BunifuShadowPanel1.Name = "BunifuShadowPanel1";
            BunifuShadowPanel1.Padding = new Padding(10, 10, 5, 5);
            BunifuShadowPanel1.PanelColor = Color.Empty;
            BunifuShadowPanel1.ShadowDept = 2;
            BunifuShadowPanel1.ShadowTopLeftVisible = true;
            BunifuShadowPanel1.Size = new Size(1474, 940);
            BunifuShadowPanel1.TabIndex = 77;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel1.Controls.Add(Panel2);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(10, 10);
            Panel1.Name = "Panel1";
            Panel1.Padding = new Padding(0, 40, 0, 0);
            Panel1.Size = new Size(1459, 925);
            Panel1.TabIndex = 33;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(_searchBunifuTextBox1);
            Panel2.Controls.Add(_refheshInShapedButton);
            Panel2.Controls.Add(toInBunifuDatePicker);
            Panel2.Controls.Add(fromInBunifuDatePicker);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(Label2);
            Panel2.Controls.Add(TableLayoutPanel3);
            Panel2.Controls.Add(titleLabel);
            Panel2.Controls.Add(Panel4);
            Panel2.Controls.Add(_createTransfeRButton);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(0, 40);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1459, 885);
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
            _searchBunifuTextBox1.CharacterCasing = CharacterCasing.Upper;
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
            _searchBunifuTextBox1.Location = new Point(1053, 94);
            _searchBunifuTextBox1.MaxLength = 32767;
            _searchBunifuTextBox1.MinimumSize = new Size(100, 35);
            _searchBunifuTextBox1.Modified = false;
            _searchBunifuTextBox1.Multiline = false;
            _searchBunifuTextBox1.Name = "_searchBunifuTextBox1";
            StateProperties1.BorderColor = Color.DodgerBlue;
            StateProperties1.FillColor = Color.Empty;
            StateProperties1.ForeColor = Color.Empty;
            StateProperties1.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnActiveState = StateProperties1;
            StateProperties2.BorderColor = Color.Empty;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.Empty;
            StateProperties2.PlaceholderForeColor = Color.Silver;
            _searchBunifuTextBox1.OnDisabledState = StateProperties2;
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Silver;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnIdleState = StateProperties4;
            _searchBunifuTextBox1.PasswordChar = '\0';
            _searchBunifuTextBox1.PlaceholderForeColor = Color.Silver;
            _searchBunifuTextBox1.PlaceholderText = "SEARCH...";
            _searchBunifuTextBox1.ReadOnly = false;
            _searchBunifuTextBox1.ScrollBars = ScrollBars.None;
            _searchBunifuTextBox1.SelectedText = "";
            _searchBunifuTextBox1.SelectionLength = 0;
            _searchBunifuTextBox1.SelectionStart = 0;
            _searchBunifuTextBox1.ShortcutsEnabled = true;
            _searchBunifuTextBox1.Size = new Size(312, 35);
            _searchBunifuTextBox1.Style = _Style.Bunifu;
            _searchBunifuTextBox1.TabIndex = 111;
            _searchBunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            _searchBunifuTextBox1.TextMarginBottom = 0;
            _searchBunifuTextBox1.TextMarginLeft = 5;
            _searchBunifuTextBox1.TextMarginTop = 0;
            _searchBunifuTextBox1.TextPlaceholder = "SEARCH...";
            _searchBunifuTextBox1.UseSystemPasswordChar = false;
            _searchBunifuTextBox1.WordWrap = true;
            // 
            // refheshInShapedButton
            // 
            _refheshInShapedButton.Anchor = AnchorStyles.None;
            _refheshInShapedButton.BackColor = Color.White;
            _refheshInShapedButton.BackgroundImage = My.Resources.Resources.refresh_pngrepo_com;
            _refheshInShapedButton.BackgroundImageLayout = ImageLayout.Stretch;
            _refheshInShapedButton.BorderColor = Color.White;
            _refheshInShapedButton.Edge = 55;
            _refheshInShapedButton.Location = new Point(557, 86);
            _refheshInShapedButton.Name = "_refheshInShapedButton";
            _refheshInShapedButton.Size = new Size(40, 40);
            _refheshInShapedButton.TabIndex = 110;
            _refheshInShapedButton.UseVisualStyleBackColor = false;
            // 
            // toInBunifuDatePicker
            // 
            toInBunifuDatePicker.Anchor = AnchorStyles.None;
            toInBunifuDatePicker.BorderRadius = 3;
            toInBunifuDatePicker.CalendarFont = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            toInBunifuDatePicker.Color = Color.Teal;
            toInBunifuDatePicker.CustomFormat = "MMM dd, yyyy";
            toInBunifuDatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            toInBunifuDatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            toInBunifuDatePicker.DisabledColor = Color.Gray;
            toInBunifuDatePicker.DisplayWeekNumbers = false;
            toInBunifuDatePicker.DPHeight = 0;
            toInBunifuDatePicker.DropDownAlign = LeftRightAlignment.Right;
            toInBunifuDatePicker.FillDatePicker = false;
            toInBunifuDatePicker.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            toInBunifuDatePicker.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            toInBunifuDatePicker.Format = DateTimePickerFormat.Custom;
            toInBunifuDatePicker.Icon = (Image)resources.GetObject("toInBunifuDatePicker.Icon");
            toInBunifuDatePicker.IconColor = Color.Teal;
            toInBunifuDatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            toInBunifuDatePicker.Location = new Point(391, 94);
            toInBunifuDatePicker.MinimumSize = new Size(100, 32);
            toInBunifuDatePicker.Name = "toInBunifuDatePicker";
            toInBunifuDatePicker.Size = new Size(160, 32);
            toInBunifuDatePicker.TabIndex = 109;
            // 
            // fromInBunifuDatePicker
            // 
            fromInBunifuDatePicker.Anchor = AnchorStyles.None;
            fromInBunifuDatePicker.BorderRadius = 3;
            fromInBunifuDatePicker.CalendarFont = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            fromInBunifuDatePicker.Color = Color.Teal;
            fromInBunifuDatePicker.CustomFormat = "MMM dd, yyyy";
            fromInBunifuDatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            fromInBunifuDatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            fromInBunifuDatePicker.DisabledColor = Color.Gray;
            fromInBunifuDatePicker.DisplayWeekNumbers = false;
            fromInBunifuDatePicker.DPHeight = 0;
            fromInBunifuDatePicker.DropDownAlign = LeftRightAlignment.Right;
            fromInBunifuDatePicker.FillDatePicker = false;
            fromInBunifuDatePicker.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            fromInBunifuDatePicker.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            fromInBunifuDatePicker.Format = DateTimePickerFormat.Custom;
            fromInBunifuDatePicker.Icon = (Image)resources.GetObject("fromInBunifuDatePicker.Icon");
            fromInBunifuDatePicker.IconColor = Color.Teal;
            fromInBunifuDatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            fromInBunifuDatePicker.Location = new Point(178, 94);
            fromInBunifuDatePicker.MinimumSize = new Size(100, 32);
            fromInBunifuDatePicker.Name = "fromInBunifuDatePicker";
            fromInBunifuDatePicker.Size = new Size(160, 32);
            fromInBunifuDatePicker.TabIndex = 108;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.None;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(349, 96);
            Label1.Margin = new Padding(0);
            Label1.Name = "Label1";
            Label1.Size = new Size(39, 30);
            Label1.TabIndex = 107;
            Label1.Text = "To:";
            Label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.None;
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(110, 96);
            Label2.Margin = new Padding(0);
            Label2.Name = "Label2";
            Label2.Size = new Size(65, 30);
            Label2.TabIndex = 106;
            Label2.Text = "From:";
            Label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.Anchor = AnchorStyles.None;
            TableLayoutPanel3.ColumnCount = 2;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel3.Controls.Add(_deleteButton, 1, 0);
            TableLayoutPanel3.Location = new Point(1111, 777);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel3.Size = new Size(257, 46);
            TableLayoutPanel3.TabIndex = 81;
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
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _deleteButton.CustomizableEdges = BorderEdges1;
            _deleteButton.DialogResult = DialogResult.None;
            _deleteButton.DisabledBorderColor = Color.Empty;
            _deleteButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _deleteButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _deleteButton.Enabled = false;
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
            _deleteButton.Location = new Point(131, 3);
            _deleteButton.Name = "_deleteButton";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _deleteButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.LightCoral;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.LightCoral;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _deleteButton.OnPressedState = StateProperties6;
            _deleteButton.Size = new Size(123, 40);
            _deleteButton.TabIndex = 61;
            _deleteButton.TextAlign = ContentAlignment.MiddleCenter;
            _deleteButton.TextMarginLeft = 0;
            _deleteButton.UseDefaultRadiusAndThickness = true;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titleLabel.Location = new Point(71, 54);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(647, 36);
            titleLabel.TabIndex = 80;
            titleLabel.Text = "Current Blocked Containers";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Panel4
            // 
            Panel4.Anchor = AnchorStyles.None;
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(_blockContBunifuDataGridView);
            Panel4.Location = new Point(111, 132);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(1258, 639);
            Panel4.TabIndex = 79;
            // 
            // blockContBunifuDataGridView
            // 
            _blockContBunifuDataGridView.AllowCustomTheming = true;
            _blockContBunifuDataGridView.AllowUserToAddRows = false;
            _blockContBunifuDataGridView.AllowUserToDeleteRows = false;
            _blockContBunifuDataGridView.AllowUserToOrderColumns = true;
            _blockContBunifuDataGridView.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _blockContBunifuDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _blockContBunifuDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _blockContBunifuDataGridView.BackgroundColor = Color.White;
            _blockContBunifuDataGridView.BorderStyle = BorderStyle.None;
            _blockContBunifuDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _blockContBunifuDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _blockContBunifuDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _blockContBunifuDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _blockContBunifuDataGridView.ColumnHeadersHeight = 40;
            _blockContBunifuDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column15, Column4, Column5, Column6, Column7, status });
            _blockContBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _blockContBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _blockContBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _blockContBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _blockContBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _blockContBunifuDataGridView.CurrentTheme.BackColor = Color.Snow;
            _blockContBunifuDataGridView.CurrentTheme.GridColor = Color.Gray;
            _blockContBunifuDataGridView.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _blockContBunifuDataGridView.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _blockContBunifuDataGridView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _blockContBunifuDataGridView.CurrentTheme.Name = null;
            _blockContBunifuDataGridView.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _blockContBunifuDataGridView.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _blockContBunifuDataGridView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _blockContBunifuDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _blockContBunifuDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _blockContBunifuDataGridView.DefaultCellStyle = DataGridViewCellStyle3;
            _blockContBunifuDataGridView.Dock = DockStyle.Fill;
            _blockContBunifuDataGridView.EnableHeadersVisualStyles = false;
            _blockContBunifuDataGridView.GridColor = Color.Gray;
            _blockContBunifuDataGridView.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _blockContBunifuDataGridView.HeaderBgColor = Color.Empty;
            _blockContBunifuDataGridView.HeaderForeColor = Color.White;
            _blockContBunifuDataGridView.Location = new Point(0, 0);
            _blockContBunifuDataGridView.Name = "_blockContBunifuDataGridView";
            _blockContBunifuDataGridView.ReadOnly = true;
            _blockContBunifuDataGridView.RowHeadersVisible = false;
            _blockContBunifuDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _blockContBunifuDataGridView.RowTemplate.Height = 30;
            _blockContBunifuDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _blockContBunifuDataGridView.Size = new Size(1256, 637);
            _blockContBunifuDataGridView.TabIndex = 57;
            _blockContBunifuDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column15
            // 
            Column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column15.FillWeight = 68.988f;
            Column15.HeaderText = "";
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            Column15.Resizable = DataGridViewTriState.True;
            Column15.SortMode = DataGridViewColumnSortMode.Automatic;
            Column15.Width = 30;
            // 
            // Column4
            // 
            Column4.FillWeight = 65.89697f;
            Column4.HeaderText = "Container #";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 128.0558f;
            Column5.HeaderText = "Shipping Line";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            Column6.FillWeight = 68.81937f;
            Column6.HeaderText = "Blocked Date";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            Column7.FillWeight = 71.16756f;
            Column7.HeaderText = "Block End Date";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // status
            // 
            status.FillWeight = 40.34171f;
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // createTransfeRButton
            // 
            _createTransfeRButton.AllowToggling = false;
            _createTransfeRButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _createTransfeRButton.AnimationSpeed = 200;
            _createTransfeRButton.AutoGenerateColors = false;
            _createTransfeRButton.BackColor = Color.Transparent;
            _createTransfeRButton.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _createTransfeRButton.BackgroundImage = (Image)resources.GetObject("createTransfeRButton.BackgroundImage");
            _createTransfeRButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _createTransfeRButton.ButtonText = "Block Container";
            _createTransfeRButton.ButtonTextMarginLeft = 0;
            _createTransfeRButton.ColorContrastOnClick = 45;
            _createTransfeRButton.ColorContrastOnHover = 45;
            _createTransfeRButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _createTransfeRButton.CustomizableEdges = BorderEdges2;
            _createTransfeRButton.DialogResult = DialogResult.None;
            _createTransfeRButton.DisabledBorderColor = Color.Empty;
            _createTransfeRButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _createTransfeRButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _createTransfeRButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _createTransfeRButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _createTransfeRButton.ForeColor = Color.White;
            _createTransfeRButton.IconLeftCursor = Cursors.Hand;
            _createTransfeRButton.IconMarginLeft = 11;
            _createTransfeRButton.IconPadding = 10;
            _createTransfeRButton.IconRightCursor = Cursors.Hand;
            _createTransfeRButton.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _createTransfeRButton.IdleBorderRadius = 30;
            _createTransfeRButton.IdleBorderThickness = 1;
            _createTransfeRButton.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _createTransfeRButton.IdleIconLeftImage = null;
            _createTransfeRButton.IdleIconRightImage = null;
            _createTransfeRButton.IndicateFocus = true;
            _createTransfeRButton.Location = new Point(1288, 54);
            _createTransfeRButton.Name = "_createTransfeRButton";
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties7.BorderRadius = 30;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _createTransfeRButton.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties8.BorderRadius = 30;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _createTransfeRButton.OnPressedState = StateProperties8;
            _createTransfeRButton.Size = new Size(152, 37);
            _createTransfeRButton.TabIndex = 68;
            _createTransfeRButton.TextAlign = ContentAlignment.MiddleCenter;
            _createTransfeRButton.TextMarginLeft = 0;
            _createTransfeRButton.UseDefaultRadiusAndThickness = true;
            // 
            // FrmListBlockedContainers
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1474, 940);
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListBlockedContainers";
            Text = "FrmListBlockedContainers";
            BunifuShadowPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            TableLayoutPanel3.ResumeLayout(false);
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_blockContBunifuDataGridView).EndInit();
            Load += new EventHandler(FrmListBlockedContainers_Load);
            ResumeLayout(false);
        }

        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel1;
        internal Panel Panel2;
        internal TableLayoutPanel TableLayoutPanel3;
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

        internal Label titleLabel;
        internal Panel Panel4;
        private Bunifu.UI.WinForms.BunifuDataGridView _blockContBunifuDataGridView;

        public Bunifu.UI.WinForms.BunifuDataGridView blockContBunifuDataGridView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _blockContBunifuDataGridView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_blockContBunifuDataGridView != null)
                {
                    _blockContBunifuDataGridView.RowPostPaint -= blockContBunifuDataGridView_RowPostPaint;
                    _blockContBunifuDataGridView.CellContentClick -= transfersBunifuDataGridView_CellContentClick;
                }

                _blockContBunifuDataGridView = value;
                if (_blockContBunifuDataGridView != null)
                {
                    _blockContBunifuDataGridView.RowPostPaint += blockContBunifuDataGridView_RowPostPaint;
                    _blockContBunifuDataGridView.CellContentClick += transfersBunifuDataGridView_CellContentClick;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _createTransfeRButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton createTransfeRButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _createTransfeRButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_createTransfeRButton != null)
                {
                    _createTransfeRButton.Click -= createTransfeRButton_Click;
                }

                _createTransfeRButton = value;
                if (_createTransfeRButton != null)
                {
                    _createTransfeRButton.Click += createTransfeRButton_Click;
                }
            }
        }

        private CustomizedControlsLibrary.ShapedButton _refheshInShapedButton;

        internal CustomizedControlsLibrary.ShapedButton refheshInShapedButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _refheshInShapedButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_refheshInShapedButton != null)
                {
                    _refheshInShapedButton.Click -= refheshInShapedButton_Click;
                }

                _refheshInShapedButton = value;
                if (_refheshInShapedButton != null)
                {
                    _refheshInShapedButton.Click += refheshInShapedButton_Click;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuDatePicker toInBunifuDatePicker;
        internal Bunifu.UI.WinForms.BunifuDatePicker fromInBunifuDatePicker;
        internal Label Label1;
        internal Label Label2;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewCheckBoxColumn Column15;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column6;
        internal DataGridViewTextBoxColumn Column7;
        internal DataGridViewTextBoxColumn status;
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
                    _searchBunifuTextBox1.TextChanged -= searchBunifuTextBox1_TextChanged_1;
                }

                _searchBunifuTextBox1 = value;
                if (_searchBunifuTextBox1 != null)
                {
                    _searchBunifuTextBox1.TextChanged += searchBunifuTextBox1_TextChanged;
                    _searchBunifuTextBox1.TextChanged += searchBunifuTextBox1_TextChanged_1;
                }
            }
        }
    }
}