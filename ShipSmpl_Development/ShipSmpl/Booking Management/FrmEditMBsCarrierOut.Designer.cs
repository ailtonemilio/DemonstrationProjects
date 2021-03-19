using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmEditMBsCarrierOut : Form
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
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditMBsCarrierOut));
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            ShapedPanel3 = new CustomizedControlsLibrary.ShapedPanel();
            _dgvBookings = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvBookings.CellContentClick += new DataGridViewCellEventHandler(dgvBookings_CellContentClick);
            _dgvBookings.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dgvBookings_RowPostPaint);
            _dgvBookings.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dgvBookings_ColumnHeaderMouseClick);
            VWBookingMinibookingBindingSource = new BindingSource(components);
            Label1 = new Label();
            cboCarrierOut = new ComboBox();
            lblTitle = new Label();
            buttonsPanel = new TableLayoutPanel();
            _noButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _noButton.Click += new EventHandler(closeFlatButton_Click);
            _btnComplete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnComplete.Click += new EventHandler(btnComplete_Click);
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label8 = new Label();
            lblWarning = new Label();
            check = new DataGridViewTextBoxColumn();
            MinibookingNumber = new DataGridViewTextBoxColumn();
            ServiceCode = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            CarrierNameOut = new DataGridViewTextBoxColumn();
            NumberOfContainer = new DataGridViewTextBoxColumn();
            ShapedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvBookings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWBookingMinibookingBindingSource).BeginInit();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ShapedPanel3
            // 
            ShapedPanel3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ShapedPanel3.BorderColor = Color.Gray;
            ShapedPanel3.Controls.Add(_dgvBookings);
            ShapedPanel3.Edge = 2;
            ShapedPanel3.Location = new Point(21, 111);
            ShapedPanel3.Name = "ShapedPanel3";
            ShapedPanel3.Padding = new Padding(1);
            ShapedPanel3.Size = new Size(813, 338);
            ShapedPanel3.TabIndex = 140;
            // 
            // dgvBookings
            // 
            _dgvBookings.AllowCustomTheming = true;
            _dgvBookings.AllowUserToAddRows = false;
            _dgvBookings.AllowUserToDeleteRows = false;
            _dgvBookings.AllowUserToOrderColumns = true;
            _dgvBookings.AllowUserToResizeRows = false;
            DataGridViewCellStyle6.BackColor = SystemColors.Control;
            DataGridViewCellStyle6.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle6.ForeColor = Color.Black;
            DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvBookings.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6;
            _dgvBookings.AutoGenerateColumns = false;
            _dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvBookings.BackgroundColor = Color.White;
            _dgvBookings.BorderStyle = BorderStyle.None;
            _dgvBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            _dgvBookings.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            _dgvBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle7.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle7.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            DataGridViewCellStyle7.ForeColor = Color.White;
            DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            _dgvBookings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7;
            _dgvBookings.ColumnHeadersHeight = 30;
            _dgvBookings.Columns.AddRange(new DataGridViewColumn[] { check, MinibookingNumber, ServiceCode, CustomerName, CarrierNameOut, NumberOfContainer });
            _dgvBookings.CurrentTheme.AlternatingRowsStyle.BackColor = SystemColors.Control;
            _dgvBookings.CurrentTheme.AlternatingRowsStyle.Font = new Font("Arial", 9.5f);
            _dgvBookings.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvBookings.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvBookings.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvBookings.CurrentTheme.BackColor = Color.White;
            _dgvBookings.CurrentTheme.GridColor = Color.Gainsboro;
            _dgvBookings.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvBookings.CurrentTheme.HeaderStyle.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            _dgvBookings.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvBookings.CurrentTheme.Name = null;
            _dgvBookings.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgvBookings.CurrentTheme.RowsStyle.Font = new Font("Arial", 9.5f);
            _dgvBookings.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvBookings.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvBookings.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvBookings.DataSource = VWBookingMinibookingBindingSource;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle8.BackColor = Color.White;
            DataGridViewCellStyle8.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle8.ForeColor = Color.Black;
            DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle8.SelectionForeColor = Color.Black;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            _dgvBookings.DefaultCellStyle = DataGridViewCellStyle8;
            _dgvBookings.Dock = DockStyle.Fill;
            _dgvBookings.EnableHeadersVisualStyles = false;
            _dgvBookings.GridColor = Color.Gainsboro;
            _dgvBookings.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvBookings.HeaderBgColor = Color.Empty;
            _dgvBookings.HeaderForeColor = Color.White;
            _dgvBookings.Location = new Point(1, 1);
            _dgvBookings.Name = "_dgvBookings";
            _dgvBookings.ReadOnly = true;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle9.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            _dgvBookings.RowHeadersDefaultCellStyle = DataGridViewCellStyle9;
            _dgvBookings.RowHeadersVisible = false;
            _dgvBookings.RowHeadersWidth = 29;
            DataGridViewCellStyle10.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvBookings.RowsDefaultCellStyle = DataGridViewCellStyle10;
            _dgvBookings.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.0f);
            _dgvBookings.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            _dgvBookings.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvBookings.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            _dgvBookings.RowTemplate.Height = 27;
            _dgvBookings.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _dgvBookings.Size = new Size(811, 336);
            _dgvBookings.TabIndex = 140;
            _dgvBookings.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // VWBookingMinibookingBindingSource
            // 
            VWBookingMinibookingBindingSource.DataSource = typeof(ModelLayer.VW_BookingMinibooking);
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(856, 195);
            Label1.Name = "Label1";
            Label1.Size = new Size(136, 20);
            Label1.TabIndex = 181;
            Label1.Text = "Select Carrier out:";
            // 
            // cboCarrierOut
            // 
            cboCarrierOut.AutoCompleteMode = AutoCompleteMode.Append;
            cboCarrierOut.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboCarrierOut.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboCarrierOut.FormattingEnabled = true;
            cboCarrierOut.Items.AddRange(new object[] { "Booking was completed", "Booking was cancelled ", "Booking was created by mistake" });
            cboCarrierOut.Location = new Point(860, 218);
            cboCarrierOut.Name = "cboCarrierOut";
            cboCarrierOut.Size = new Size(327, 28);
            cboCarrierOut.TabIndex = 180;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTitle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblTitle.Location = new Point(18, 66);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(227, 20);
            lblTitle.TabIndex = 179;
            lblTitle.Text = "Update Carrier information:";
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.None;
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Controls.Add(_noButton, 1, 0);
            buttonsPanel.Controls.Add(_btnComplete, 0, 0);
            buttonsPanel.Location = new Point(920, 320);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(210, 39);
            buttonsPanel.TabIndex = 178;
            // 
            // noButton
            // 
            _noButton.AllowToggling = false;
            _noButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _noButton.AnimationSpeed = 200;
            _noButton.AutoGenerateColors = false;
            _noButton.BackColor = Color.Transparent;
            _noButton.BackColor1 = Color.White;
            _noButton.BackgroundImage = (Image)resources.GetObject("noButton.BackgroundImage");
            _noButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _noButton.ButtonText = "Cancel";
            _noButton.ButtonTextMarginLeft = 0;
            _noButton.ColorContrastOnClick = 45;
            _noButton.ColorContrastOnHover = 45;
            _noButton.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _noButton.CustomizableEdges = BorderEdges3;
            _noButton.DialogResult = DialogResult.None;
            _noButton.DisabledBorderColor = Color.Empty;
            _noButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _noButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _noButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _noButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _noButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _noButton.IconLeftCursor = Cursors.Hand;
            _noButton.IconMarginLeft = 11;
            _noButton.IconPadding = 10;
            _noButton.IconRightCursor = Cursors.Hand;
            _noButton.IdleBorderColor = Color.Gray;
            _noButton.IdleBorderRadius = 3;
            _noButton.IdleBorderThickness = 1;
            _noButton.IdleFillColor = Color.White;
            _noButton.IdleIconLeftImage = null;
            _noButton.IdleIconRightImage = null;
            _noButton.IndicateFocus = true;
            _noButton.Location = new Point(112, 3);
            _noButton.Name = "_noButton";
            StateProperties5.BorderColor = Color.DarkGray;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.DarkGray;
            StateProperties5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _noButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _noButton.OnPressedState = StateProperties6;
            _noButton.Size = new Size(95, 33);
            _noButton.TabIndex = 137;
            _noButton.TextAlign = ContentAlignment.MiddleCenter;
            _noButton.TextMarginLeft = 0;
            _noButton.UseDefaultRadiusAndThickness = true;
            // 
            // btnComplete
            // 
            _btnComplete.AllowToggling = false;
            _btnComplete.AnimationSpeed = 200;
            _btnComplete.AutoGenerateColors = false;
            _btnComplete.BackColor = Color.Transparent;
            _btnComplete.BackColor1 = Color.Teal;
            _btnComplete.BackgroundImage = (Image)resources.GetObject("btnComplete.BackgroundImage");
            _btnComplete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnComplete.ButtonText = "OK";
            _btnComplete.ButtonTextMarginLeft = 0;
            _btnComplete.ColorContrastOnClick = 45;
            _btnComplete.ColorContrastOnHover = 45;
            _btnComplete.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _btnComplete.CustomizableEdges = BorderEdges4;
            _btnComplete.DialogResult = DialogResult.None;
            _btnComplete.DisabledBorderColor = Color.Empty;
            _btnComplete.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnComplete.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnComplete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnComplete.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnComplete.ForeColor = Color.White;
            _btnComplete.IconLeftCursor = Cursors.Hand;
            _btnComplete.IconMarginLeft = 11;
            _btnComplete.IconPadding = 10;
            _btnComplete.IconRightCursor = Cursors.Hand;
            _btnComplete.IdleBorderColor = Color.Teal;
            _btnComplete.IdleBorderRadius = 3;
            _btnComplete.IdleBorderThickness = 1;
            _btnComplete.IdleFillColor = Color.Teal;
            _btnComplete.IdleIconLeftImage = null;
            _btnComplete.IdleIconRightImage = null;
            _btnComplete.IndicateFocus = true;
            _btnComplete.Location = new Point(3, 3);
            _btnComplete.Name = "_btnComplete";
            StateProperties7.BorderColor = Color.MediumTurquoise;
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.MediumTurquoise;
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _btnComplete.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Teal;
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.Teal;
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _btnComplete.OnPressedState = StateProperties8;
            _btnComplete.Size = new Size(99, 33);
            _btnComplete.TabIndex = 136;
            _btnComplete.TextAlign = ContentAlignment.MiddleCenter;
            _btnComplete.TextMarginLeft = 0;
            _btnComplete.UseDefaultRadiusAndThickness = true;
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
            _closeFlatButton.Location = new Point(1167, 0);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(43, 41);
            _closeFlatButton.TabIndex = 177;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Label8
            // 
            Label8.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label8.Dock = DockStyle.Top;
            Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(0, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(1210, 41);
            Label8.TabIndex = 176;
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWarning.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblWarning.Location = new Point(560, 66);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 20);
            lblWarning.TabIndex = 182;
            // 
            // check
            // 
            check.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            check.FillWeight = 25.61316f;
            check.Frozen = true;
            check.HeaderText = "✔";
            check.MinimumWidth = 6;
            check.Name = "check";
            check.ReadOnly = true;
            check.Resizable = DataGridViewTriState.True;
            check.SortMode = DataGridViewColumnSortMode.NotSortable;
            check.Width = 35;
            // 
            // MinibookingNumber
            // 
            MinibookingNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MinibookingNumber.DataPropertyName = "MinibookingNumber";
            MinibookingNumber.FillWeight = 73.2803f;
            MinibookingNumber.HeaderText = "Minibooking #";
            MinibookingNumber.Name = "MinibookingNumber";
            MinibookingNumber.ReadOnly = true;
            MinibookingNumber.Width = 130;
            // 
            // ServiceCode
            // 
            ServiceCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ServiceCode.DataPropertyName = "ServiceCode";
            ServiceCode.FillWeight = 63.49331f;
            ServiceCode.HeaderText = "Service";
            ServiceCode.Name = "ServiceCode";
            ServiceCode.ReadOnly = true;
            ServiceCode.Width = 85;
            // 
            // CustomerName
            // 
            CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CustomerName.DataPropertyName = "CustomerName";
            CustomerName.FillWeight = 150.9001f;
            CustomerName.HeaderText = "Customer";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 232;
            // 
            // CarrierNameOut
            // 
            CarrierNameOut.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CarrierNameOut.DataPropertyName = "CarrierNameOut";
            CarrierNameOut.FillWeight = 169.1165f;
            CarrierNameOut.HeaderText = "Carrier Out";
            CarrierNameOut.Name = "CarrierNameOut";
            CarrierNameOut.ReadOnly = true;
            CarrierNameOut.Width = 261;
            // 
            // NumberOfContainer
            // 
            NumberOfContainer.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NumberOfContainer.DataPropertyName = "NumberOfContainer";
            NumberOfContainer.FillWeight = 43.20988f;
            NumberOfContainer.HeaderText = "Cans #";
            NumberOfContainer.Name = "NumberOfContainer";
            NumberOfContainer.ReadOnly = true;
            NumberOfContainer.Width = 66;
            // 
            // FrmEditMBsCarrierOut
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1210, 518);
            Controls.Add(lblWarning);
            Controls.Add(Label1);
            Controls.Add(cboCarrierOut);
            Controls.Add(lblTitle);
            Controls.Add(buttonsPanel);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label8);
            Controls.Add(ShapedPanel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditMBsCarrierOut";
            Text = "FrmEditMBsCarrierOut";
            ShapedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvBookings).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWBookingMinibookingBindingSource).EndInit();
            buttonsPanel.ResumeLayout(false);
            Load += new EventHandler(FrmEditMBsCarrierOut_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal CustomizedControlsLibrary.ShapedPanel ShapedPanel3;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvBookings;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvBookings
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvBookings;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvBookings != null)
                {
                    _dgvBookings.CellContentClick -= dgvBookings_CellContentClick;
                    _dgvBookings.RowPostPaint -= dgvBookings_RowPostPaint;
                    _dgvBookings.ColumnHeaderMouseClick -= dgvBookings_ColumnHeaderMouseClick;
                }

                _dgvBookings = value;
                if (_dgvBookings != null)
                {
                    _dgvBookings.CellContentClick += dgvBookings_CellContentClick;
                    _dgvBookings.RowPostPaint += dgvBookings_RowPostPaint;
                    _dgvBookings.ColumnHeaderMouseClick += dgvBookings_ColumnHeaderMouseClick;
                }
            }
        }

        internal BindingSource VWBookingMinibookingBindingSource;
        internal Label Label1;
        internal ComboBox cboCarrierOut;
        internal Label lblTitle;
        internal TableLayoutPanel buttonsPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _noButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton noButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _noButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_noButton != null)
                {
                    _noButton.Click -= closeFlatButton_Click;
                }

                _noButton = value;
                if (_noButton != null)
                {
                    _noButton.Click += closeFlatButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnComplete;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnComplete
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnComplete;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnComplete != null)
                {
                    _btnComplete.Click -= btnComplete_Click;
                }

                _btnComplete = value;
                if (_btnComplete != null)
                {
                    _btnComplete.Click += btnComplete_Click;
                }
            }
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

        internal Label Label8;
        internal Label lblWarning;
        internal DataGridViewTextBoxColumn check;
        internal DataGridViewTextBoxColumn MinibookingNumber;
        internal DataGridViewTextBoxColumn ServiceCode;
        internal DataGridViewTextBoxColumn CustomerName;
        internal DataGridViewTextBoxColumn CarrierNameOut;
        internal DataGridViewTextBoxColumn NumberOfContainer;
    }
}