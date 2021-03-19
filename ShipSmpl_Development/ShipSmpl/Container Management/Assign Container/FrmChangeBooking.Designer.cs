using System;
using System.Diagnostics;
using System.Drawing; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using Bunifu.UI.WinForms.BunifuTextbox;
using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmChangeBooking : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangeBooking));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var ToggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            _closeLabel = new Label();
            _closeLabel.MouseHover += new EventHandler(closeLabel_MouseHover);
            _closeLabel.MouseLeave += new EventHandler(closeLabel_Click);
            _closeLabel.Click += new EventHandler(closeLabel_MouseLeave);
            Label7 = new Label();
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(cancelButton_Click);
            _transferButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _transferButton.Click += new EventHandler(transferButton_Click);
            Panel3 = new Panel();
            _bookingsBunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            _bookingsBunifuDataGridView1.SelectionChanged += new EventHandler(bookingsBunifuDataGridView1_SelectionChanged);
            _searchBunifuTextBox1 = new BunifuTextBox();
            _searchBunifuTextBox1.TextChanged += new EventHandler(searchBunifuTextBox1_TextChanged);
            infoLabel = new CustomizedControlsLibrary.ShapedLabel();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            _BunifuToggleSwitch1 = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            _BunifuToggleSwitch1.OnValuechange += new EventHandler(BunifuToggleSwitch1_OnValuechange);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_bookingsBunifuDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(701, 2);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 44);
            _closeLabel.TabIndex = 81;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            Label7.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Dock = DockStyle.Top;
            Label7.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Location = new Point(0, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(749, 46);
            Label7.TabIndex = 80;
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            _cancelButton.AllowToggling = false;
            _cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _cancelButton.CustomizableEdges = BorderEdges1;
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
            _cancelButton.IdleBorderColor = Color.Gray;
            _cancelButton.IdleBorderRadius = 3;
            _cancelButton.IdleBorderThickness = 1;
            _cancelButton.IdleFillColor = Color.White;
            _cancelButton.IdleIconLeftImage = null;
            _cancelButton.IdleIconRightImage = null;
            _cancelButton.IndicateFocus = true;
            _cancelButton.Location = new Point(604, 536);
            _cancelButton.Name = "_cancelButton";
            StateProperties1.BorderColor = Color.DarkGray;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.DarkGray;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.IndianRed;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.IndianRed;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties2;
            _cancelButton.Size = new Size(97, 45);
            _cancelButton.TabIndex = 79;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // transferButton
            // 
            _transferButton.AllowToggling = false;
            _transferButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _transferButton.AnimationSpeed = 200;
            _transferButton.AutoGenerateColors = false;
            _transferButton.BackColor = Color.Transparent;
            _transferButton.BackColor1 = Color.Teal;
            _transferButton.BackgroundImage = (Image)resources.GetObject("transferButton.BackgroundImage");
            _transferButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _transferButton.ButtonText = "Transfer";
            _transferButton.ButtonTextMarginLeft = 0;
            _transferButton.ColorContrastOnClick = 45;
            _transferButton.ColorContrastOnHover = 45;
            _transferButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _transferButton.CustomizableEdges = BorderEdges2;
            _transferButton.DialogResult = DialogResult.None;
            _transferButton.DisabledBorderColor = Color.Empty;
            _transferButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _transferButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _transferButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _transferButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _transferButton.ForeColor = Color.White;
            _transferButton.IconLeftCursor = Cursors.Hand;
            _transferButton.IconMarginLeft = 11;
            _transferButton.IconPadding = 10;
            _transferButton.IconRightCursor = Cursors.Hand;
            _transferButton.IdleBorderColor = Color.Teal;
            _transferButton.IdleBorderRadius = 3;
            _transferButton.IdleBorderThickness = 1;
            _transferButton.IdleFillColor = Color.Teal;
            _transferButton.IdleIconLeftImage = null;
            _transferButton.IdleIconRightImage = null;
            _transferButton.IndicateFocus = true;
            _transferButton.Location = new Point(482, 536);
            _transferButton.Name = "_transferButton";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _transferButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _transferButton.OnPressedState = StateProperties4;
            _transferButton.Size = new Size(102, 45);
            _transferButton.TabIndex = 78;
            _transferButton.TextAlign = ContentAlignment.MiddleCenter;
            _transferButton.TextMarginLeft = 0;
            _transferButton.UseDefaultRadiusAndThickness = true;
            // 
            // Panel3
            // 
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(_bookingsBunifuDataGridView1);
            Panel3.Location = new Point(49, 140);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(652, 277);
            Panel3.TabIndex = 82;
            // 
            // bookingsBunifuDataGridView1
            // 
            _bookingsBunifuDataGridView1.AllowCustomTheming = true;
            _bookingsBunifuDataGridView1.AllowUserToAddRows = false;
            _bookingsBunifuDataGridView1.AllowUserToDeleteRows = false;
            _bookingsBunifuDataGridView1.AllowUserToOrderColumns = true;
            _bookingsBunifuDataGridView1.AllowUserToResizeColumns = false;
            _bookingsBunifuDataGridView1.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            _bookingsBunifuDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _bookingsBunifuDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _bookingsBunifuDataGridView1.BackgroundColor = Color.White;
            _bookingsBunifuDataGridView1.BorderStyle = BorderStyle.None;
            _bookingsBunifuDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _bookingsBunifuDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _bookingsBunifuDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _bookingsBunifuDataGridView1.ColumnHeadersHeight = 40;
            _bookingsBunifuDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column7, Column3 });
            _bookingsBunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _bookingsBunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _bookingsBunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _bookingsBunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _bookingsBunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _bookingsBunifuDataGridView1.CurrentTheme.BackColor = Color.Snow;
            _bookingsBunifuDataGridView1.CurrentTheme.GridColor = Color.Gray;
            _bookingsBunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _bookingsBunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _bookingsBunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _bookingsBunifuDataGridView1.CurrentTheme.Name = null;
            _bookingsBunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _bookingsBunifuDataGridView1.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _bookingsBunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _bookingsBunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _bookingsBunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _bookingsBunifuDataGridView1.DefaultCellStyle = DataGridViewCellStyle3;
            _bookingsBunifuDataGridView1.Dock = DockStyle.Fill;
            _bookingsBunifuDataGridView1.EnableHeadersVisualStyles = false;
            _bookingsBunifuDataGridView1.GridColor = Color.Gray;
            _bookingsBunifuDataGridView1.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _bookingsBunifuDataGridView1.HeaderBgColor = Color.Empty;
            _bookingsBunifuDataGridView1.HeaderForeColor = Color.White;
            _bookingsBunifuDataGridView1.Location = new Point(0, 0);
            _bookingsBunifuDataGridView1.MultiSelect = false;
            _bookingsBunifuDataGridView1.Name = "_bookingsBunifuDataGridView1";
            _bookingsBunifuDataGridView1.ReadOnly = true;
            _bookingsBunifuDataGridView1.RowHeadersVisible = false;
            _bookingsBunifuDataGridView1.RowTemplate.Height = 35;
            _bookingsBunifuDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _bookingsBunifuDataGridView1.Size = new Size(650, 275);
            _bookingsBunifuDataGridView1.TabIndex = 80;
            _bookingsBunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // searchBunifuTextBox1
            // 
            _searchBunifuTextBox1.AcceptsReturn = false;
            _searchBunifuTextBox1.AcceptsTab = false;
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
            _searchBunifuTextBox1.HideSelection = true;
            _searchBunifuTextBox1.IconLeft = null;
            _searchBunifuTextBox1.IconLeftCursor = Cursors.IBeam;
            _searchBunifuTextBox1.IconPadding = 10;
            _searchBunifuTextBox1.IconRight = null;
            _searchBunifuTextBox1.IconRightCursor = Cursors.IBeam;
            _searchBunifuTextBox1.Lines = new string[0];
            _searchBunifuTextBox1.Location = new Point(453, 104);
            _searchBunifuTextBox1.MaxLength = 32767;
            _searchBunifuTextBox1.MinimumSize = new Size(100, 35);
            _searchBunifuTextBox1.Modified = false;
            _searchBunifuTextBox1.Multiline = false;
            _searchBunifuTextBox1.Name = "_searchBunifuTextBox1";
            StateProperties5.BorderColor = Color.DodgerBlue;
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnActiveState = StateProperties5;
            StateProperties6.BorderColor = Color.Empty;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Silver;
            _searchBunifuTextBox1.OnDisabledState = StateProperties6;
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Silver;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.Empty;
            StateProperties8.PlaceholderForeColor = Color.Empty;
            _searchBunifuTextBox1.OnIdleState = StateProperties8;
            _searchBunifuTextBox1.PasswordChar = '\0';
            _searchBunifuTextBox1.PlaceholderForeColor = Color.Silver;
            _searchBunifuTextBox1.PlaceholderText = "Search...";
            _searchBunifuTextBox1.ReadOnly = false;
            _searchBunifuTextBox1.ScrollBars = ScrollBars.None;
            _searchBunifuTextBox1.SelectedText = "";
            _searchBunifuTextBox1.SelectionLength = 0;
            _searchBunifuTextBox1.SelectionStart = 0;
            _searchBunifuTextBox1.ShortcutsEnabled = true;
            _searchBunifuTextBox1.Size = new Size(218, 35);
            _searchBunifuTextBox1.Style = _Style.Bunifu;
            _searchBunifuTextBox1.TabIndex = 0;
            _searchBunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            _searchBunifuTextBox1.TextMarginBottom = 0;
            _searchBunifuTextBox1.TextMarginLeft = 5;
            _searchBunifuTextBox1.TextMarginTop = 0;
            _searchBunifuTextBox1.TextPlaceholder = "Search...";
            _searchBunifuTextBox1.UseSystemPasswordChar = false;
            _searchBunifuTextBox1.WordWrap = true;
            // 
            // infoLabel
            // 
            infoLabel.BackColor = Color.Silver;
            infoLabel.BorderColor = Color.White;
            infoLabel.Edge = 50;
            infoLabel.Font = new Font("Segoe UI Semibold", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            infoLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            infoLabel.Location = new Point(59, 423);
            infoLabel.Name = "infoLabel";
            infoLabel.Padding = new Padding(10);
            infoLabel.Size = new Size(612, 104);
            infoLabel.TabIndex = 83;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(59, 58);
            Label1.Name = "Label1";
            Label1.Size = new Size(474, 21);
            Label1.TabIndex = 84;
            Label1.Text = "Select the booking number the containers will be transferred to";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Semibold", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.Tomato;
            Label2.Location = new Point(52, 116);
            Label2.Name = "Label2";
            Label2.Size = new Size(58, 19);
            Label2.TabIndex = 87;
            Label2.Text = "Inactive";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI Semibold", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.Green;
            Label3.Location = new Point(154, 116);
            Label3.Name = "Label3";
            Label3.Size = new Size(48, 19);
            Label3.TabIndex = 86;
            Label3.Text = "Active";
            // 
            // BunifuToggleSwitch1
            // 
            _BunifuToggleSwitch1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _BunifuToggleSwitch1.Animation = 5;
            _BunifuToggleSwitch1.BackColor = Color.Transparent;
            _BunifuToggleSwitch1.BackgroundImage = (Image)resources.GetObject("BunifuToggleSwitch1.BackgroundImage");
            _BunifuToggleSwitch1.Cursor = Cursors.Hand;
            _BunifuToggleSwitch1.Location = new Point(117, 120);
            _BunifuToggleSwitch1.Name = "_BunifuToggleSwitch1";
            _BunifuToggleSwitch1.Size = new Size(35, 19);
            _BunifuToggleSwitch1.TabIndex = 85;
            ToggleState1.BackColor = Color.Empty;
            ToggleState1.BackColorInner = Color.Empty;
            ToggleState1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(236)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(140)));
            ToggleState1.BorderColorInner = Color.Empty;
            ToggleState1.BorderRadius = 1;
            ToggleState1.BorderRadiusInner = 1;
            ToggleState1.BorderThickness = 1;
            ToggleState1.BorderThicknessInner = 1;
            _BunifuToggleSwitch1.ToggleStateDisabled = ToggleState1;
            ToggleState2.BackColor = Color.Tomato;
            ToggleState2.BackColorInner = Color.White;
            ToggleState2.BorderColor = Color.Tomato;
            ToggleState2.BorderColorInner = Color.White;
            ToggleState2.BorderRadius = 17;
            ToggleState2.BorderRadiusInner = 15;
            ToggleState2.BorderThickness = 1;
            ToggleState2.BorderThicknessInner = 1;
            _BunifuToggleSwitch1.ToggleStateOff = ToggleState2;
            ToggleState3.BackColor = Color.Green;
            ToggleState3.BackColorInner = Color.White;
            ToggleState3.BorderColor = Color.Green;
            ToggleState3.BorderColorInner = Color.White;
            ToggleState3.BorderRadius = 17;
            ToggleState3.BorderRadiusInner = 15;
            ToggleState3.BorderThickness = 1;
            ToggleState3.BorderThicknessInner = 1;
            _BunifuToggleSwitch1.ToggleStateOn = ToggleState3;
            _BunifuToggleSwitch1.Value = true;
            // 
            // Column1
            // 
            Column1.FillWeight = 127.5518f;
            Column1.HeaderText = "Booking Number";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 186.5444f;
            Column2.HeaderText = "Customer";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.FillWeight = 56.42446f;
            Column7.HeaderText = "SS Line";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "mbId";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // FrmChangeBooking
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(749, 616);
            Controls.Add(_BunifuToggleSwitch1);
            Controls.Add(Label2);
            Controls.Add(Label3);
            Controls.Add(Label1);
            Controls.Add(infoLabel);
            Controls.Add(Panel3);
            Controls.Add(_closeLabel);
            Controls.Add(_searchBunifuTextBox1);
            Controls.Add(Label7);
            Controls.Add(_cancelButton);
            Controls.Add(_transferButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmChangeBooking";
            Text = "FrmChangeBooking";
            Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_bookingsBunifuDataGridView1).EndInit();
            Load += new EventHandler(FrmChangeBooking_Load);
            ResumeLayout(false);
            PerformLayout();
        }

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
                    _closeLabel.MouseHover -= closeLabel_MouseHover;
                    _closeLabel.MouseLeave -= closeLabel_Click;
                    _closeLabel.Click -= closeLabel_MouseLeave;
                }

                _closeLabel = value;
                if (_closeLabel != null)
                {
                    _closeLabel.MouseHover += closeLabel_MouseHover;
                    _closeLabel.MouseLeave += closeLabel_Click;
                    _closeLabel.Click += closeLabel_MouseLeave;
                }
            }
        }

        internal Label Label7;
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

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _transferButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton transferButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _transferButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_transferButton != null)
                {
                    _transferButton.Click -= transferButton_Click;
                }

                _transferButton = value;
                if (_transferButton != null)
                {
                    _transferButton.Click += transferButton_Click;
                }
            }
        }

        internal Panel Panel3;
        private Bunifu.UI.WinForms.BunifuDataGridView _bookingsBunifuDataGridView1;

        internal Bunifu.UI.WinForms.BunifuDataGridView bookingsBunifuDataGridView1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _bookingsBunifuDataGridView1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_bookingsBunifuDataGridView1 != null)
                {
                    _bookingsBunifuDataGridView1.SelectionChanged -= bookingsBunifuDataGridView1_SelectionChanged;
                }

                _bookingsBunifuDataGridView1 = value;
                if (_bookingsBunifuDataGridView1 != null)
                {
                    _bookingsBunifuDataGridView1.SelectionChanged += bookingsBunifuDataGridView1_SelectionChanged;
                }
            }
        }

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

        internal CustomizedControlsLibrary.ShapedLabel infoLabel;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
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

        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column7;
        internal DataGridViewTextBoxColumn Column3;
    }
}