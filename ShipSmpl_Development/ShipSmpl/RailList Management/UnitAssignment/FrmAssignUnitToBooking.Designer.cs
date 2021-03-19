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
    public partial class frmAssignUnitToBooking : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignUnitToBooking));
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            var DataGridViewCellStyle13 = new DataGridViewCellStyle();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Label12 = new Label();
            _btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancel.Click += new EventHandler(btnCancel_Click);
            _txtBookingNumber = new BunifuTextBox();
            _txtBookingNumber.TextChanged += new EventHandler(txtBookingNumber_TextChanged);
            buttonsPanel = new TableLayoutPanel();
            _btnAssignBooking = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAssignBooking.Click += new EventHandler(btnAssignBooking_Click);
            Panel1 = new Panel();
            dgvAsnBookings = new Bunifu.UI.WinForms.BunifuDataGridView();
            BookingNumberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            VWMinibookingMiniUnitAssignmentBindingSource = new BindingSource(components);
            Label3 = new Label();
            Label9 = new Label();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeLabel_Click);
            Panel4 = new Panel();
            Panel2 = new Panel();
            _dgvAllBookings = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvAllBookings.SelectionChanged += new EventHandler(dgvAllBookings_SelectionChanged);
            _dgvAllBookings.CellContentClick += new DataGridViewCellEventHandler(dgvAllBookings_CellContentClick);
            Column1 = new DataGridViewCheckBoxColumn();
            BookingNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CustomerNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            BookingService = new DataGridViewTextBoxColumn();
            NumberOfContainer = new DataGridViewTextBoxColumn();
            VWBookingMinibooking = new BindingSource(components);
            Panel3 = new Panel();
            BunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            GradeCommodityCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            VWMinibookingCommodityBindingSource = new BindingSource(components);
            Panel5 = new Panel();
            _dgvMiniUnit = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvMiniUnit.SelectionChanged += new EventHandler(dgvMiniUnit_SelectionChanged);
            _dgvMiniUnit.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dgvMiniUnits_RowPostPaint);
            MiniUnitNumber = new DataGridViewTextBoxColumn();
            BalanceInstruxCode = new DataGridViewTextBoxColumn();
            VWUnitSourceMiniUnitBindingSource = new BindingSource(components);
            Panel6 = new Panel();
            _btnBalToStorage = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnBalToStorage.Click += new EventHandler(btnBalToStorage_Click);
            _btnRemoveUnit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnRemoveUnit.Click += new EventHandler(btnRemoveUnit_Click);
            _Timer1 = new Timer(components);
            _Timer1.Tick += new EventHandler(Timer1_Tick);
            buttonsPanel.SuspendLayout();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsnBookings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWMinibookingMiniUnitAssignmentBindingSource).BeginInit();
            Panel4.SuspendLayout();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvAllBookings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWBookingMinibooking).BeginInit();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BunifuDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWMinibookingCommodityBindingSource).BeginInit();
            Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvMiniUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWUnitSourceMiniUnitBindingSource).BeginInit();
            Panel6.SuspendLayout();
            SuspendLayout();
            // 
            // Label12
            // 
            Label12.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Dock = DockStyle.Top;
            Label12.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Location = new Point(0, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(1477, 41);
            Label12.TabIndex = 140;
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            _btnCancel.AllowToggling = false;
            _btnCancel.Anchor = AnchorStyles.Right;
            _btnCancel.AnimationSpeed = 200;
            _btnCancel.AutoGenerateColors = false;
            _btnCancel.BackColor = Color.Transparent;
            _btnCancel.BackColor1 = Color.White;
            _btnCancel.BackgroundImage = (Image)resources.GetObject("btnCancel.BackgroundImage");
            _btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnCancel.ButtonText = "Cancel";
            _btnCancel.ButtonTextMarginLeft = 0;
            _btnCancel.ColorContrastOnClick = 45;
            _btnCancel.ColorContrastOnHover = 45;
            _btnCancel.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnCancel.CustomizableEdges = BorderEdges1;
            _btnCancel.DialogResult = DialogResult.None;
            _btnCancel.DisabledBorderColor = Color.Empty;
            _btnCancel.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnCancel.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnCancel.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCancel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _btnCancel.IconLeftCursor = Cursors.Hand;
            _btnCancel.IconMarginLeft = 11;
            _btnCancel.IconPadding = 10;
            _btnCancel.IconRightCursor = Cursors.Hand;
            _btnCancel.IdleBorderColor = Color.Gray;
            _btnCancel.IdleBorderRadius = 3;
            _btnCancel.IdleBorderThickness = 1;
            _btnCancel.IdleFillColor = Color.White;
            _btnCancel.IdleIconLeftImage = null;
            _btnCancel.IdleIconRightImage = null;
            _btnCancel.IndicateFocus = true;
            _btnCancel.Location = new Point(3, 3);
            _btnCancel.Name = "_btnCancel";
            StateProperties1.BorderColor = Color.DarkGray;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.DarkGray;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnCancel.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnCancel.OnPressedState = StateProperties2;
            _btnCancel.Size = new Size(117, 32);
            _btnCancel.TabIndex = 142;
            _btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancel.TextMarginLeft = 0;
            _btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // txtBookingNumber
            // 
            _txtBookingNumber.AcceptsReturn = false;
            _txtBookingNumber.AcceptsTab = false;
            _txtBookingNumber.AnimationSpeed = 200;
            _txtBookingNumber.AutoCompleteMode = AutoCompleteMode.None;
            _txtBookingNumber.AutoCompleteSource = AutoCompleteSource.None;
            _txtBookingNumber.BackColor = Color.Transparent;
            _txtBookingNumber.BackgroundImage = (Image)resources.GetObject("txtBookingNumber.BackgroundImage");
            _txtBookingNumber.BorderColorActive = Color.DodgerBlue;
            _txtBookingNumber.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _txtBookingNumber.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _txtBookingNumber.BorderColorIdle = Color.Silver;
            _txtBookingNumber.BorderRadius = 1;
            _txtBookingNumber.BorderThickness = 1;
            _txtBookingNumber.CharacterCasing = CharacterCasing.Normal;
            _txtBookingNumber.Cursor = Cursors.IBeam;
            _txtBookingNumber.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _txtBookingNumber.DefaultText = "";
            _txtBookingNumber.FillColor = Color.White;
            _txtBookingNumber.HideSelection = true;
            _txtBookingNumber.IconLeft = null;
            _txtBookingNumber.IconLeftCursor = Cursors.IBeam;
            _txtBookingNumber.IconPadding = 10;
            _txtBookingNumber.IconRight = null;
            _txtBookingNumber.IconRightCursor = Cursors.IBeam;
            _txtBookingNumber.Lines = new string[0];
            _txtBookingNumber.Location = new Point(45, 135);
            _txtBookingNumber.MaxLength = 32767;
            _txtBookingNumber.MinimumSize = new Size(100, 35);
            _txtBookingNumber.Modified = false;
            _txtBookingNumber.Multiline = false;
            _txtBookingNumber.Name = "_txtBookingNumber";
            StateProperties3.BorderColor = Color.DodgerBlue;
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            _txtBookingNumber.OnActiveState = StateProperties3;
            StateProperties4.BorderColor = Color.Empty;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Empty;
            StateProperties4.PlaceholderForeColor = Color.Silver;
            _txtBookingNumber.OnDisabledState = StateProperties4;
            StateProperties5.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            _txtBookingNumber.OnHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Silver;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Empty;
            _txtBookingNumber.OnIdleState = StateProperties6;
            _txtBookingNumber.PasswordChar = '\0';
            _txtBookingNumber.PlaceholderForeColor = Color.Silver;
            _txtBookingNumber.PlaceholderText = "Seach booking...";
            _txtBookingNumber.ReadOnly = false;
            _txtBookingNumber.ScrollBars = ScrollBars.None;
            _txtBookingNumber.SelectedText = "";
            _txtBookingNumber.SelectionLength = 0;
            _txtBookingNumber.SelectionStart = 0;
            _txtBookingNumber.ShortcutsEnabled = true;
            _txtBookingNumber.Size = new Size(231, 35);
            _txtBookingNumber.Style = _Style.Bunifu;
            _txtBookingNumber.TabIndex = 143;
            _txtBookingNumber.TextAlign = HorizontalAlignment.Left;
            _txtBookingNumber.TextMarginBottom = 0;
            _txtBookingNumber.TextMarginLeft = 5;
            _txtBookingNumber.TextMarginTop = 0;
            _txtBookingNumber.TextPlaceholder = "Seach booking...";
            _txtBookingNumber.UseSystemPasswordChar = false;
            _txtBookingNumber.WordWrap = true;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.None;
            buttonsPanel.ColumnCount = 1;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.0f));
            buttonsPanel.Controls.Add(_btnCancel, 0, 0);
            buttonsPanel.Location = new Point(694, 713);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            buttonsPanel.Size = new Size(123, 39);
            buttonsPanel.TabIndex = 171;
            // 
            // btnAssignBooking
            // 
            _btnAssignBooking.AllowToggling = false;
            _btnAssignBooking.Anchor = AnchorStyles.None;
            _btnAssignBooking.AnimationSpeed = 200;
            _btnAssignBooking.AutoGenerateColors = false;
            _btnAssignBooking.BackColor = Color.Transparent;
            _btnAssignBooking.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAssignBooking.BackgroundImage = (Image)resources.GetObject("btnAssignBooking.BackgroundImage");
            _btnAssignBooking.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAssignBooking.ButtonText = "";
            _btnAssignBooking.ButtonTextMarginLeft = 0;
            _btnAssignBooking.ColorContrastOnClick = 45;
            _btnAssignBooking.ColorContrastOnHover = 45;
            _btnAssignBooking.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnAssignBooking.CustomizableEdges = BorderEdges2;
            _btnAssignBooking.DialogResult = DialogResult.None;
            _btnAssignBooking.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnAssignBooking.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAssignBooking.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAssignBooking.Enabled = false;
            _btnAssignBooking.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAssignBooking.Font = new Font("Microsoft Sans Serif", 36.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAssignBooking.ForeColor = Color.White;
            _btnAssignBooking.IconLeftCursor = Cursors.Hand;
            _btnAssignBooking.IconMarginLeft = 8;
            _btnAssignBooking.IconPadding = 8;
            _btnAssignBooking.IconRightCursor = Cursors.Hand;
            _btnAssignBooking.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAssignBooking.IdleBorderRadius = 30;
            _btnAssignBooking.IdleBorderThickness = 1;
            _btnAssignBooking.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAssignBooking.IdleIconLeftImage = My.Resources.Resources.arrowRight;
            _btnAssignBooking.IdleIconRightImage = null;
            _btnAssignBooking.IndicateFocus = false;
            _btnAssignBooking.Location = new Point(873, 359);
            _btnAssignBooking.Name = "_btnAssignBooking";
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties7.BorderRadius = 30;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _btnAssignBooking.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties8.BorderRadius = 30;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _btnAssignBooking.OnPressedState = StateProperties8;
            _btnAssignBooking.Size = new Size(50, 50);
            _btnAssignBooking.TabIndex = 182;
            _btnAssignBooking.TextAlign = ContentAlignment.MiddleCenter;
            _btnAssignBooking.TextMarginLeft = 0;
            _btnAssignBooking.UseDefaultRadiusAndThickness = true;
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(dgvAsnBookings);
            Panel1.Location = new Point(286, 1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(218, 356);
            Panel1.TabIndex = 184;
            // 
            // dgvAsnBookings
            // 
            dgvAsnBookings.AllowCustomTheming = true;
            dgvAsnBookings.AllowUserToAddRows = false;
            dgvAsnBookings.AllowUserToDeleteRows = false;
            dgvAsnBookings.AllowUserToOrderColumns = true;
            dgvAsnBookings.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvAsnBookings.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dgvAsnBookings.AutoGenerateColumns = false;
            dgvAsnBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsnBookings.BackgroundColor = Color.White;
            dgvAsnBookings.BorderStyle = BorderStyle.None;
            dgvAsnBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAsnBookings.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvAsnBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAsnBookings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dgvAsnBookings.ColumnHeadersHeight = 30;
            dgvAsnBookings.Columns.AddRange(new DataGridViewColumn[] { BookingNumberDataGridViewTextBoxColumn1 });
            dgvAsnBookings.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            dgvAsnBookings.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvAsnBookings.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvAsnBookings.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            dgvAsnBookings.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvAsnBookings.CurrentTheme.BackColor = Color.Snow;
            dgvAsnBookings.CurrentTheme.GridColor = Color.Gray;
            dgvAsnBookings.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvAsnBookings.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            dgvAsnBookings.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvAsnBookings.CurrentTheme.Name = null;
            dgvAsnBookings.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            dgvAsnBookings.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvAsnBookings.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvAsnBookings.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            dgvAsnBookings.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dgvAsnBookings.DataSource = VWMinibookingMiniUnitAssignmentBindingSource;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAsnBookings.DefaultCellStyle = DataGridViewCellStyle3;
            dgvAsnBookings.Dock = DockStyle.Fill;
            dgvAsnBookings.EnableHeadersVisualStyles = false;
            dgvAsnBookings.GridColor = Color.Gray;
            dgvAsnBookings.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvAsnBookings.HeaderBgColor = Color.Empty;
            dgvAsnBookings.HeaderForeColor = Color.White;
            dgvAsnBookings.Location = new Point(0, 0);
            dgvAsnBookings.MultiSelect = false;
            dgvAsnBookings.Name = "dgvAsnBookings";
            dgvAsnBookings.ReadOnly = true;
            dgvAsnBookings.RowHeadersVisible = false;
            dgvAsnBookings.RowHeadersWidth = 51;
            dgvAsnBookings.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgvAsnBookings.RowTemplate.Height = 30;
            dgvAsnBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsnBookings.Size = new Size(216, 354);
            dgvAsnBookings.TabIndex = 176;
            dgvAsnBookings.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // BookingNumberDataGridViewTextBoxColumn1
            // 
            BookingNumberDataGridViewTextBoxColumn1.DataPropertyName = "BookingNumber";
            BookingNumberDataGridViewTextBoxColumn1.HeaderText = "  Assigned Bookings";
            BookingNumberDataGridViewTextBoxColumn1.Name = "BookingNumberDataGridViewTextBoxColumn1";
            BookingNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // VWMinibookingMiniUnitAssignmentBindingSource
            // 
            VWMinibookingMiniUnitAssignmentBindingSource.DataSource = typeof(ModelLayer.VW_MinibookingMiniUnitAssignment);
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.None;
            Label3.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(62, 85);
            Label3.Margin = new Padding(0);
            Label3.Name = "Label3";
            Label3.Size = new Size(975, 32);
            Label3.TabIndex = 187;
            Label3.Text = "Select the bookings then click the arrow button to assign them to the units";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.None;
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label9.Location = new Point(36, 60);
            Label9.Margin = new Padding(0);
            Label9.Name = "Label9";
            Label9.Size = new Size(276, 21);
            Label9.TabIndex = 186;
            Label9.Text = "Choose the bookings to be assigned";
            Label9.TextAlign = ContentAlignment.MiddleRight;
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
            _closeFlatButton.Location = new Point(1434, 0);
            _closeFlatButton.Margin = new Padding(4);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(43, 41);
            _closeFlatButton.TabIndex = 188;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Panel4
            // 
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(Panel2);
            Panel4.Location = new Point(41, 177);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(788, 494);
            Panel4.TabIndex = 189;
            // 
            // Panel2
            // 
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(_dgvAllBookings);
            Panel2.Location = new Point(2, -1);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(557, 490);
            Panel2.TabIndex = 185;
            // 
            // dgvAllBookings
            // 
            _dgvAllBookings.AllowCustomTheming = true;
            _dgvAllBookings.AllowUserToAddRows = false;
            _dgvAllBookings.AllowUserToDeleteRows = false;
            _dgvAllBookings.AllowUserToOrderColumns = true;
            _dgvAllBookings.AllowUserToResizeRows = false;
            DataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewCellStyle4.ForeColor = Color.Black;
            DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvAllBookings.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
            _dgvAllBookings.AutoGenerateColumns = false;
            _dgvAllBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvAllBookings.BackgroundColor = Color.White;
            _dgvAllBookings.BorderStyle = BorderStyle.None;
            _dgvAllBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvAllBookings.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _dgvAllBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            _dgvAllBookings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            _dgvAllBookings.ColumnHeadersHeight = 30;
            _dgvAllBookings.Columns.AddRange(new DataGridViewColumn[] { Column1, BookingNumberDataGridViewTextBoxColumn, CustomerNameDataGridViewTextBoxColumn1, BookingService, NumberOfContainer });
            _dgvAllBookings.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvAllBookings.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvAllBookings.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvAllBookings.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvAllBookings.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvAllBookings.CurrentTheme.BackColor = Color.Snow;
            _dgvAllBookings.CurrentTheme.GridColor = Color.Gray;
            _dgvAllBookings.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvAllBookings.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvAllBookings.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvAllBookings.CurrentTheme.Name = null;
            _dgvAllBookings.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvAllBookings.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvAllBookings.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvAllBookings.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvAllBookings.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvAllBookings.DataSource = VWBookingMinibooking;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle6.ForeColor = Color.Black;
            DataGridViewCellStyle6.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle6.SelectionForeColor = Color.Black;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            _dgvAllBookings.DefaultCellStyle = DataGridViewCellStyle6;
            _dgvAllBookings.Dock = DockStyle.Fill;
            _dgvAllBookings.EnableHeadersVisualStyles = false;
            _dgvAllBookings.GridColor = Color.Gray;
            _dgvAllBookings.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvAllBookings.HeaderBgColor = Color.Empty;
            _dgvAllBookings.HeaderForeColor = Color.White;
            _dgvAllBookings.Location = new Point(0, 0);
            _dgvAllBookings.MultiSelect = false;
            _dgvAllBookings.Name = "_dgvAllBookings";
            _dgvAllBookings.ReadOnly = true;
            _dgvAllBookings.RowHeadersVisible = false;
            _dgvAllBookings.RowHeadersWidth = 51;
            _dgvAllBookings.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvAllBookings.RowTemplate.Height = 30;
            _dgvAllBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvAllBookings.Size = new Size(555, 488);
            _dgvAllBookings.TabIndex = 174;
            _dgvAllBookings.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column1
            // 
            Column1.FillWeight = 36.33178f;
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // BookingNumberDataGridViewTextBoxColumn
            // 
            BookingNumberDataGridViewTextBoxColumn.DataPropertyName = "MinibookingNumber";
            BookingNumberDataGridViewTextBoxColumn.FillWeight = 145.4501f;
            BookingNumberDataGridViewTextBoxColumn.HeaderText = "Booking #";
            BookingNumberDataGridViewTextBoxColumn.Name = "BookingNumberDataGridViewTextBoxColumn";
            BookingNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomerNameDataGridViewTextBoxColumn1
            // 
            CustomerNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerName";
            CustomerNameDataGridViewTextBoxColumn1.FillWeight = 211.3493f;
            CustomerNameDataGridViewTextBoxColumn1.HeaderText = "Customer Name";
            CustomerNameDataGridViewTextBoxColumn1.Name = "CustomerNameDataGridViewTextBoxColumn1";
            CustomerNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // BookingService
            // 
            BookingService.DataPropertyName = "BookingService";
            BookingService.HeaderText = "Service";
            BookingService.Name = "BookingService";
            BookingService.ReadOnly = true;
            // 
            // NumberOfContainer
            // 
            NumberOfContainer.DataPropertyName = "NumberOfContainer";
            NumberOfContainer.FillWeight = 84.02622f;
            NumberOfContainer.HeaderText = "# Cans";
            NumberOfContainer.Name = "NumberOfContainer";
            NumberOfContainer.ReadOnly = true;
            // 
            // VWBookingMinibooking
            // 
            VWBookingMinibooking.DataSource = typeof(ModelLayer.VW_BookingMinibooking);
            // 
            // Panel3
            // 
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(BunifuDataGridView1);
            Panel3.Location = new Point(627, 177);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(198, 207);
            Panel3.TabIndex = 186;
            // 
            // BunifuDataGridView1
            // 
            BunifuDataGridView1.AllowCustomTheming = true;
            BunifuDataGridView1.AllowUserToAddRows = false;
            BunifuDataGridView1.AllowUserToDeleteRows = false;
            BunifuDataGridView1.AllowUserToOrderColumns = true;
            BunifuDataGridView1.AllowUserToResizeRows = false;
            DataGridViewCellStyle7.BackColor = Color.White;
            DataGridViewCellStyle7.ForeColor = Color.Black;
            DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7;
            BunifuDataGridView1.AutoGenerateColumns = false;
            BunifuDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BunifuDataGridView1.BackgroundColor = Color.White;
            BunifuDataGridView1.BorderStyle = BorderStyle.None;
            BunifuDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BunifuDataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            BunifuDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle8.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle8.ForeColor = Color.White;
            DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            BunifuDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8;
            BunifuDataGridView1.ColumnHeadersHeight = 30;
            BunifuDataGridView1.Columns.AddRange(new DataGridViewColumn[] { GradeCommodityCodeDataGridViewTextBoxColumn });
            BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            BunifuDataGridView1.CurrentTheme.BackColor = Color.Snow;
            BunifuDataGridView1.CurrentTheme.GridColor = Color.Gray;
            BunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            BunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            BunifuDataGridView1.CurrentTheme.Name = null;
            BunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            BunifuDataGridView1.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            BunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            BunifuDataGridView1.DataSource = VWMinibookingCommodityBindingSource;
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle10.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle10.ForeColor = Color.Black;
            DataGridViewCellStyle10.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle10.SelectionForeColor = Color.Black;
            DataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            BunifuDataGridView1.DefaultCellStyle = DataGridViewCellStyle10;
            BunifuDataGridView1.Dock = DockStyle.Fill;
            BunifuDataGridView1.EnableHeadersVisualStyles = false;
            BunifuDataGridView1.GridColor = Color.Gray;
            BunifuDataGridView1.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuDataGridView1.HeaderBgColor = Color.Empty;
            BunifuDataGridView1.HeaderForeColor = Color.White;
            BunifuDataGridView1.Location = new Point(0, 0);
            BunifuDataGridView1.MultiSelect = false;
            BunifuDataGridView1.Name = "BunifuDataGridView1";
            BunifuDataGridView1.ReadOnly = true;
            BunifuDataGridView1.RowHeadersVisible = false;
            BunifuDataGridView1.RowHeadersWidth = 51;
            BunifuDataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            BunifuDataGridView1.RowTemplate.Height = 30;
            BunifuDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BunifuDataGridView1.Size = new Size(196, 205);
            BunifuDataGridView1.TabIndex = 175;
            BunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // GradeCommodityCodeDataGridViewTextBoxColumn
            // 
            GradeCommodityCodeDataGridViewTextBoxColumn.DataPropertyName = "GradeCommodityCode";
            DataGridViewCellStyle9.Padding = new Padding(10, 0, 0, 0);
            GradeCommodityCodeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9;
            GradeCommodityCodeDataGridViewTextBoxColumn.HeaderText = "    Grade/Commodity";
            GradeCommodityCodeDataGridViewTextBoxColumn.Name = "GradeCommodityCodeDataGridViewTextBoxColumn";
            GradeCommodityCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VWMinibookingCommodityBindingSource
            // 
            VWMinibookingCommodityBindingSource.DataSource = typeof(ModelLayer.VW_MinibookingCommodity);
            // 
            // Panel5
            // 
            Panel5.BorderStyle = BorderStyle.FixedSingle;
            Panel5.Controls.Add(_dgvMiniUnit);
            Panel5.Location = new Point(3, 1);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(233, 357);
            Panel5.TabIndex = 190;
            // 
            // dgvMiniUnit
            // 
            _dgvMiniUnit.AllowCustomTheming = true;
            _dgvMiniUnit.AllowUserToAddRows = false;
            _dgvMiniUnit.AllowUserToDeleteRows = false;
            _dgvMiniUnit.AllowUserToOrderColumns = true;
            _dgvMiniUnit.AllowUserToResizeRows = false;
            DataGridViewCellStyle11.BackColor = Color.White;
            DataGridViewCellStyle11.ForeColor = Color.Black;
            DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvMiniUnit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11;
            _dgvMiniUnit.AutoGenerateColumns = false;
            _dgvMiniUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvMiniUnit.BackgroundColor = Color.White;
            _dgvMiniUnit.BorderStyle = BorderStyle.None;
            _dgvMiniUnit.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvMiniUnit.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _dgvMiniUnit.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle12.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle12.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle12.ForeColor = Color.White;
            DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            _dgvMiniUnit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12;
            _dgvMiniUnit.ColumnHeadersHeight = 30;
            _dgvMiniUnit.Columns.AddRange(new DataGridViewColumn[] { MiniUnitNumber, BalanceInstruxCode });
            _dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvMiniUnit.CurrentTheme.BackColor = Color.Snow;
            _dgvMiniUnit.CurrentTheme.GridColor = Color.Gray;
            _dgvMiniUnit.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvMiniUnit.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvMiniUnit.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvMiniUnit.CurrentTheme.Name = null;
            _dgvMiniUnit.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvMiniUnit.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvMiniUnit.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvMiniUnit.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvMiniUnit.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvMiniUnit.DataSource = VWUnitSourceMiniUnitBindingSource;
            DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle13.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle13.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle13.ForeColor = Color.Black;
            DataGridViewCellStyle13.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle13.SelectionForeColor = Color.Black;
            DataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            _dgvMiniUnit.DefaultCellStyle = DataGridViewCellStyle13;
            _dgvMiniUnit.Dock = DockStyle.Fill;
            _dgvMiniUnit.EnableHeadersVisualStyles = false;
            _dgvMiniUnit.GridColor = Color.Gray;
            _dgvMiniUnit.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvMiniUnit.HeaderBgColor = Color.Empty;
            _dgvMiniUnit.HeaderForeColor = Color.White;
            _dgvMiniUnit.Location = new Point(0, 0);
            _dgvMiniUnit.MultiSelect = false;
            _dgvMiniUnit.Name = "_dgvMiniUnit";
            _dgvMiniUnit.ReadOnly = true;
            _dgvMiniUnit.RowHeadersVisible = false;
            _dgvMiniUnit.RowHeadersWidth = 51;
            _dgvMiniUnit.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvMiniUnit.RowTemplate.Height = 30;
            _dgvMiniUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvMiniUnit.Size = new Size(231, 355);
            _dgvMiniUnit.TabIndex = 177;
            _dgvMiniUnit.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // MiniUnitNumber
            // 
            MiniUnitNumber.DataPropertyName = "MiniUnitNumber";
            MiniUnitNumber.FillWeight = 150.0f;
            MiniUnitNumber.HeaderText = "Selected Units";
            MiniUnitNumber.Name = "MiniUnitNumber";
            MiniUnitNumber.ReadOnly = true;
            // 
            // BalanceInstruxCode
            // 
            BalanceInstruxCode.DataPropertyName = "BalanceInstruxCode";
            BalanceInstruxCode.FillWeight = 50.0f;
            BalanceInstruxCode.HeaderText = "";
            BalanceInstruxCode.Name = "BalanceInstruxCode";
            BalanceInstruxCode.ReadOnly = true;
            // 
            // VWUnitSourceMiniUnitBindingSource
            // 
            VWUnitSourceMiniUnitBindingSource.DataSource = typeof(ModelLayer.VW_UnitSourceMiniUnit);
            // 
            // Panel6
            // 
            Panel6.BorderStyle = BorderStyle.FixedSingle;
            Panel6.Controls.Add(_btnBalToStorage);
            Panel6.Controls.Add(_btnRemoveUnit);
            Panel6.Controls.Add(Panel5);
            Panel6.Controls.Add(Panel1);
            Panel6.Location = new Point(943, 173);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(509, 422);
            Panel6.TabIndex = 191;
            // 
            // btnBalToStorage
            // 
            _btnBalToStorage.AllowToggling = false;
            _btnBalToStorage.Anchor = AnchorStyles.Right;
            _btnBalToStorage.AnimationSpeed = 200;
            _btnBalToStorage.AutoGenerateColors = false;
            _btnBalToStorage.BackColor = Color.Transparent;
            _btnBalToStorage.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnBalToStorage.BackgroundImage = (Image)resources.GetObject("btnBalToStorage.BackgroundImage");
            _btnBalToStorage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnBalToStorage.ButtonText = "BAL. TO STORAGE";
            _btnBalToStorage.ButtonTextMarginLeft = 0;
            _btnBalToStorage.ColorContrastOnClick = 45;
            _btnBalToStorage.ColorContrastOnHover = 45;
            _btnBalToStorage.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _btnBalToStorage.CustomizableEdges = BorderEdges3;
            _btnBalToStorage.DialogResult = DialogResult.None;
            _btnBalToStorage.DisabledBorderColor = Color.Empty;
            _btnBalToStorage.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnBalToStorage.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnBalToStorage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnBalToStorage.Font = new Font("Segoe UI Semibold", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnBalToStorage.ForeColor = Color.White;
            _btnBalToStorage.IconLeftCursor = Cursors.Hand;
            _btnBalToStorage.IconMarginLeft = 11;
            _btnBalToStorage.IconPadding = 10;
            _btnBalToStorage.IconRightCursor = Cursors.Hand;
            _btnBalToStorage.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnBalToStorage.IdleBorderRadius = 3;
            _btnBalToStorage.IdleBorderThickness = 1;
            _btnBalToStorage.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnBalToStorage.IdleIconLeftImage = null;
            _btnBalToStorage.IdleIconRightImage = null;
            _btnBalToStorage.IndicateFocus = true;
            _btnBalToStorage.Location = new Point(4, 360);
            _btnBalToStorage.Name = "_btnBalToStorage";
            StateProperties9.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties9.BorderRadius = 3;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            _btnBalToStorage.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties10.BorderRadius = 3;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            _btnBalToStorage.OnPressedState = StateProperties10;
            _btnBalToStorage.Size = new Size(151, 32);
            _btnBalToStorage.TabIndex = 192;
            _btnBalToStorage.TextAlign = ContentAlignment.MiddleCenter;
            _btnBalToStorage.TextMarginLeft = 0;
            _btnBalToStorage.UseDefaultRadiusAndThickness = true;
            // 
            // btnRemoveUnit
            // 
            _btnRemoveUnit.AllowToggling = false;
            _btnRemoveUnit.Anchor = AnchorStyles.None;
            _btnRemoveUnit.AnimationSpeed = 200;
            _btnRemoveUnit.AutoGenerateColors = false;
            _btnRemoveUnit.BackColor = Color.Transparent;
            _btnRemoveUnit.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRemoveUnit.BackgroundImage = (Image)resources.GetObject("btnRemoveUnit.BackgroundImage");
            _btnRemoveUnit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnRemoveUnit.ButtonText = "";
            _btnRemoveUnit.ButtonTextMarginLeft = 0;
            _btnRemoveUnit.ColorContrastOnClick = 45;
            _btnRemoveUnit.ColorContrastOnHover = 45;
            _btnRemoveUnit.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _btnRemoveUnit.CustomizableEdges = BorderEdges4;
            _btnRemoveUnit.DialogResult = DialogResult.None;
            _btnRemoveUnit.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnRemoveUnit.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnRemoveUnit.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnRemoveUnit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnRemoveUnit.Font = new Font("Microsoft Sans Serif", 36.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnRemoveUnit.ForeColor = Color.White;
            _btnRemoveUnit.IconLeftCursor = Cursors.Hand;
            _btnRemoveUnit.IconMarginLeft = 4;
            _btnRemoveUnit.IconPadding = 4;
            _btnRemoveUnit.IconRightCursor = Cursors.Hand;
            _btnRemoveUnit.IdleBorderColor = Color.Maroon;
            _btnRemoveUnit.IdleBorderRadius = 18;
            _btnRemoveUnit.IdleBorderThickness = 1;
            _btnRemoveUnit.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRemoveUnit.IdleIconLeftImage = My.Resources.Resources.removeRedBall;
            _btnRemoveUnit.IdleIconRightImage = null;
            _btnRemoveUnit.IndicateFocus = false;
            _btnRemoveUnit.Location = new Point(237, 46);
            _btnRemoveUnit.Name = "_btnRemoveUnit";
            StateProperties11.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties11.BorderRadius = 18;
            StateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties11.BorderThickness = 1;
            StateProperties11.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties11.ForeColor = Color.White;
            StateProperties11.IconLeftImage = null;
            StateProperties11.IconRightImage = null;
            _btnRemoveUnit.onHoverState = StateProperties11;
            StateProperties12.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties12.BorderRadius = 18;
            StateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties12.BorderThickness = 1;
            StateProperties12.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties12.ForeColor = Color.White;
            StateProperties12.IconLeftImage = null;
            StateProperties12.IconRightImage = null;
            _btnRemoveUnit.OnPressedState = StateProperties12;
            _btnRemoveUnit.Size = new Size(24, 24);
            _btnRemoveUnit.TabIndex = 191;
            _btnRemoveUnit.TextAlign = ContentAlignment.MiddleCenter;
            _btnRemoveUnit.TextMarginLeft = 0;
            _btnRemoveUnit.UseDefaultRadiusAndThickness = true;
            // 
            // frmAssignUnitToBooking
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1477, 777);
            Controls.Add(Panel3);
            Controls.Add(Panel6);
            Controls.Add(Panel4);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label3);
            Controls.Add(Label9);
            Controls.Add(_btnAssignBooking);
            Controls.Add(buttonsPanel);
            Controls.Add(_txtBookingNumber);
            Controls.Add(Label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAssignUnitToBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAssignUnitToBooking";
            buttonsPanel.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAsnBookings).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWMinibookingMiniUnitAssignmentBindingSource).EndInit();
            Panel4.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvAllBookings).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWBookingMinibooking).EndInit();
            Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BunifuDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWMinibookingCommodityBindingSource).EndInit();
            Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvMiniUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWUnitSourceMiniUnitBindingSource).EndInit();
            Panel6.ResumeLayout(false);
            Load += new EventHandler(frmAssignUnitToBooking_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label12;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnCancel;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCancel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCancel != null)
                {
                    _btnCancel.Click -= btnCancel_Click;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += btnCancel_Click;
                }
            }
        }

        private BunifuTextBox _txtBookingNumber;

        internal BunifuTextBox txtBookingNumber
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtBookingNumber;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtBookingNumber != null)
                {
                    _txtBookingNumber.TextChanged -= txtBookingNumber_TextChanged;
                }

                _txtBookingNumber = value;
                if (_txtBookingNumber != null)
                {
                    _txtBookingNumber.TextChanged += txtBookingNumber_TextChanged;
                }
            }
        }

        internal TableLayoutPanel buttonsPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAssignBooking;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAssignBooking
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAssignBooking;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAssignBooking != null)
                {
                    _btnAssignBooking.Click -= btnAssignBooking_Click;
                }

                _btnAssignBooking = value;
                if (_btnAssignBooking != null)
                {
                    _btnAssignBooking.Click += btnAssignBooking_Click;
                }
            }
        }

        internal Panel Panel1;
        internal Label Label3;
        internal Label Label9;
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
                    _closeFlatButton.Click -= closeLabel_Click;
                }

                _closeFlatButton = value;
                if (_closeFlatButton != null)
                {
                    _closeFlatButton.Click += closeLabel_Click;
                }
            }
        }

        internal Panel Panel4;
        internal Panel Panel3;
        internal Panel Panel5;
        internal Panel Panel6;
        internal Panel Panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvAllBookings;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvAllBookings
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvAllBookings;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvAllBookings != null)
                {
                    _dgvAllBookings.SelectionChanged -= dgvAllBookings_SelectionChanged;
                    _dgvAllBookings.CellContentClick -= dgvAllBookings_CellContentClick;
                }

                _dgvAllBookings = value;
                if (_dgvAllBookings != null)
                {
                    _dgvAllBookings.SelectionChanged += dgvAllBookings_SelectionChanged;
                    _dgvAllBookings.CellContentClick += dgvAllBookings_CellContentClick;
                }
            }
        }

        internal BindingSource VWBookingMinibooking;
        internal BindingSource VWMinibookingCommodityBindingSource;
        internal BindingSource VWUnitSourceMiniUnitBindingSource;
        internal BindingSource VWMinibookingMiniUnitAssignmentBindingSource;
        public Bunifu.UI.WinForms.BunifuDataGridView BunifuDataGridView1;
        internal DataGridViewTextBoxColumn GradeCommodityCodeDataGridViewTextBoxColumn;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvAsnBookings;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvMiniUnit;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvMiniUnit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvMiniUnit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvMiniUnit != null)
                {
                    _dgvMiniUnit.SelectionChanged -= dgvMiniUnit_SelectionChanged;
                    _dgvMiniUnit.RowPostPaint -= dgvMiniUnits_RowPostPaint;
                }

                _dgvMiniUnit = value;
                if (_dgvMiniUnit != null)
                {
                    _dgvMiniUnit.SelectionChanged += dgvMiniUnit_SelectionChanged;
                    _dgvMiniUnit.RowPostPaint += dgvMiniUnits_RowPostPaint;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnRemoveUnit;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRemoveUnit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRemoveUnit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnRemoveUnit != null)
                {
                    _btnRemoveUnit.Click -= btnRemoveUnit_Click;
                }

                _btnRemoveUnit = value;
                if (_btnRemoveUnit != null)
                {
                    _btnRemoveUnit.Click += btnRemoveUnit_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn BookingNumberDataGridViewTextBoxColumn1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnBalToStorage;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBalToStorage
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnBalToStorage;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnBalToStorage != null)
                {
                    _btnBalToStorage.Click -= btnBalToStorage_Click;
                }

                _btnBalToStorage = value;
                if (_btnBalToStorage != null)
                {
                    _btnBalToStorage.Click += btnBalToStorage_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn MiniUnitNumber;
        internal DataGridViewTextBoxColumn BalanceInstruxCode;
        internal DataGridViewCheckBoxColumn Column1;
        internal DataGridViewTextBoxColumn BookingNumberDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CustomerNameDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn BookingService;
        internal DataGridViewTextBoxColumn NumberOfContainer;
        private Timer _Timer1;

        internal Timer Timer1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Timer1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Timer1 != null)
                {
                    _Timer1.Tick -= Timer1_Tick;
                }

                _Timer1 = value;
                if (_Timer1 != null)
                {
                    _Timer1.Tick += Timer1_Tick;
                }
            }
        }
    }
}