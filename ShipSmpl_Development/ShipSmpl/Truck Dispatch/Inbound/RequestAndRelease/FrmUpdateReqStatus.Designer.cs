using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmUpdateReqStatus : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateReqStatus));
            var BorderEdges25 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties49 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties50 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges26 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties51 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties52 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle21 = new DataGridViewCellStyle();
            var DataGridViewCellStyle22 = new DataGridViewCellStyle();
            var DataGridViewCellStyle23 = new DataGridViewCellStyle();
            var DataGridViewCellStyle24 = new DataGridViewCellStyle();
            var DataGridViewCellStyle25 = new DataGridViewCellStyle();
            var BorderEdges27 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties53 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties54 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges28 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties55 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties56 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle26 = new DataGridViewCellStyle();
            var DataGridViewCellStyle27 = new DataGridViewCellStyle();
            var DataGridViewCellStyle28 = new DataGridViewCellStyle();
            var DataGridViewCellStyle29 = new DataGridViewCellStyle();
            var DataGridViewCellStyle30 = new DataGridViewCellStyle();
            var BorderEdges29 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties57 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties58 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges30 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties59 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties60 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges31 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties61 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties62 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges32 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties63 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties64 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges33 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties65 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties66 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges34 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties67 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties68 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges35 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties69 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties70 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges36 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties71 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties72 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label8 = new Label();
            buttonsPanel = new TableLayoutPanel();
            _btnComplete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnComplete.Click += new EventHandler(btnComplete_Click);
            _btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancel.Click += new EventHandler(closeFlatButton_Click);
            ShapedPanel3 = new CustomizedControlsLibrary.ShapedPanel();
            _dgvRelease = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvRelease.SelectionChanged += new EventHandler(dgvRelease_SelectionChanged);
            _dgvRelease.DoubleClick += new EventHandler(dgvRelease_DoubleClick);
            ReleaseNumber = new DataGridViewTextBoxColumn();
            TotalQtyAccepted = new DataGridViewTextBoxColumn();
            VWReleaseBindingSource = new BindingSource(components);
            Label7 = new Label();
            Label11 = new Label();
            _btnNewRequest = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnNewRequest.Click += new EventHandler(btnNewRequest_Click);
            _btnManageBal = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnManageBal.Click += new EventHandler(btnManageBal_Click);
            Label1 = new Label();
            _cbStatus = new ComboBox();
            _cbStatus.SelectedIndexChanged += new EventHandler(cbStatus_SelectedIndexChanged);
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            TableLayoutPanel1 = new TableLayoutPanel();
            lblRelType = new Label();
            Label33 = new Label();
            lblSSLineName = new Label();
            lblReqDate = new Label();
            lblSize = new Label();
            Label14 = new Label();
            Label15 = new Label();
            Label16 = new Label();
            ShapedPanel1 = new CustomizedControlsLibrary.ShapedPanel();
            dgvPickUpDropOff = new Bunifu.UI.WinForms.BunifuDataGridView();
            PickUpTerminalNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            YardNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            QtyPickUpDropOffDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            VWRelOrderPickUpDropOffLocationBindingSource = new BindingSource(components);
            Label18 = new Label();
            BunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            BunifuButton5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            BunifuButton6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            Label17 = new Label();
            lblTotalReq = new Label();
            Panel1 = new Panel();
            PictureBox1 = new PictureBox();
            Panel2 = new Panel();
            Label22 = new Label();
            TableLayoutPanel2 = new TableLayoutPanel();
            Label24 = new Label();
            Label23 = new Label();
            Label12 = new Label();
            Label6 = new Label();
            Label26 = new Label();
            lblAddedRel = new Label();
            lblBalRelease = new Label();
            lblAddedPickUpDropOff = new Label();
            lblBalPickUpDropOff = new Label();
            _btnRmRel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnRmRel.Click += new EventHandler(btnRmRel_Click);
            _btnRmPickUpDropOff = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnRmPickUpDropOff.Click += new EventHandler(btnRmPickUpDropOff_Click);
            _btnAddNewPUDO = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddNewPUDO.Click += new EventHandler(btnAddNewPUDO_Click);
            PictureBox2 = new PictureBox();
            BunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            Label9 = new Label();
            _cboRelOrder = new ComboBox();
            _cboRelOrder.SelectedIndexChanged += new EventHandler(cboRelOrder_SelectedIndexChanged);
            Label10 = new Label();
            BunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            Label13 = new Label();
            Label25 = new Label();
            dtpFollowUpDate = new DateTimePicker();
            pnlFollowUp = new Panel();
            Label19 = new Label();
            _nudFlwUpQtyCans = new NumericUpDown();
            _nudFlwUpQtyCans.ValueChanged += new EventHandler(nudFlwUpQtyCans_ValueChanged);
            buttonsPanel.SuspendLayout();
            ShapedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvRelease).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWReleaseBindingSource).BeginInit();
            TableLayoutPanel1.SuspendLayout();
            ShapedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPickUpDropOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWRelOrderPickUpDropOffLocationBindingSource).BeginInit();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            Panel2.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            pnlFollowUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_nudFlwUpQtyCans).BeginInit();
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
            _closeFlatButton.Location = new Point(1076, 0);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(43, 36);
            _closeFlatButton.TabIndex = 182;
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
            Label8.Size = new Size(1119, 36);
            Label8.TabIndex = 181;
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Controls.Add(_btnComplete, 0, 0);
            buttonsPanel.Controls.Add(_btnCancel, 1, 0);
            buttonsPanel.Location = new Point(452, 676);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(210, 36);
            buttonsPanel.TabIndex = 183;
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
            _btnComplete.ButtonText = "Save";
            _btnComplete.ButtonTextMarginLeft = 0;
            _btnComplete.ColorContrastOnClick = 45;
            _btnComplete.ColorContrastOnHover = 45;
            _btnComplete.Cursor = Cursors.Hand;
            BorderEdges25.BottomLeft = true;
            BorderEdges25.BottomRight = true;
            BorderEdges25.TopLeft = true;
            BorderEdges25.TopRight = true;
            _btnComplete.CustomizableEdges = BorderEdges25;
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
            StateProperties49.BorderColor = Color.MediumTurquoise;
            StateProperties49.BorderRadius = 3;
            StateProperties49.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties49.BorderThickness = 1;
            StateProperties49.FillColor = Color.MediumTurquoise;
            StateProperties49.ForeColor = Color.White;
            StateProperties49.IconLeftImage = null;
            StateProperties49.IconRightImage = null;
            _btnComplete.onHoverState = StateProperties49;
            StateProperties50.BorderColor = Color.Teal;
            StateProperties50.BorderRadius = 3;
            StateProperties50.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties50.BorderThickness = 1;
            StateProperties50.FillColor = Color.Teal;
            StateProperties50.ForeColor = Color.White;
            StateProperties50.IconLeftImage = null;
            StateProperties50.IconRightImage = null;
            _btnComplete.OnPressedState = StateProperties50;
            _btnComplete.Size = new Size(99, 30);
            _btnComplete.TabIndex = 136;
            _btnComplete.TextAlign = ContentAlignment.MiddleCenter;
            _btnComplete.TextMarginLeft = 0;
            _btnComplete.UseDefaultRadiusAndThickness = true;
            // 
            // btnCancel
            // 
            _btnCancel.AllowToggling = false;
            _btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            BorderEdges26.BottomLeft = true;
            BorderEdges26.BottomRight = true;
            BorderEdges26.TopLeft = true;
            BorderEdges26.TopRight = true;
            _btnCancel.CustomizableEdges = BorderEdges26;
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
            _btnCancel.Location = new Point(112, 3);
            _btnCancel.Name = "_btnCancel";
            StateProperties51.BorderColor = Color.DarkGray;
            StateProperties51.BorderRadius = 3;
            StateProperties51.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties51.BorderThickness = 1;
            StateProperties51.FillColor = Color.DarkGray;
            StateProperties51.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties51.IconLeftImage = null;
            StateProperties51.IconRightImage = null;
            _btnCancel.onHoverState = StateProperties51;
            StateProperties52.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties52.BorderRadius = 3;
            StateProperties52.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties52.BorderThickness = 1;
            StateProperties52.FillColor = Color.White;
            StateProperties52.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties52.IconLeftImage = null;
            StateProperties52.IconRightImage = null;
            _btnCancel.OnPressedState = StateProperties52;
            _btnCancel.Size = new Size(95, 30);
            _btnCancel.TabIndex = 137;
            _btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancel.TextMarginLeft = 0;
            _btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // ShapedPanel3
            // 
            ShapedPanel3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ShapedPanel3.BorderColor = Color.Gray;
            ShapedPanel3.Controls.Add(_dgvRelease);
            ShapedPanel3.Controls.Add(Label7);
            ShapedPanel3.Edge = 2;
            ShapedPanel3.Location = new Point(66, 370);
            ShapedPanel3.Name = "ShapedPanel3";
            ShapedPanel3.Padding = new Padding(1);
            ShapedPanel3.Size = new Size(205, 228);
            ShapedPanel3.TabIndex = 205;
            // 
            // dgvRelease
            // 
            _dgvRelease.AllowCustomTheming = true;
            _dgvRelease.AllowUserToAddRows = false;
            _dgvRelease.AllowUserToDeleteRows = false;
            _dgvRelease.AllowUserToOrderColumns = true;
            _dgvRelease.AllowUserToResizeRows = false;
            DataGridViewCellStyle21.BackColor = SystemColors.Control;
            DataGridViewCellStyle21.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle21.ForeColor = Color.Black;
            DataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvRelease.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21;
            _dgvRelease.AutoGenerateColumns = false;
            _dgvRelease.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvRelease.BackgroundColor = Color.White;
            _dgvRelease.BorderStyle = BorderStyle.None;
            _dgvRelease.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            _dgvRelease.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            _dgvRelease.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle22.BackColor = Color.Gray;
            DataGridViewCellStyle22.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            DataGridViewCellStyle22.ForeColor = Color.White;
            DataGridViewCellStyle22.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            _dgvRelease.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22;
            _dgvRelease.ColumnHeadersHeight = 30;
            _dgvRelease.Columns.AddRange(new DataGridViewColumn[] { ReleaseNumber, TotalQtyAccepted });
            _dgvRelease.CurrentTheme.AlternatingRowsStyle.BackColor = SystemColors.Control;
            _dgvRelease.CurrentTheme.AlternatingRowsStyle.Font = new Font("Arial", 9.5f);
            _dgvRelease.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvRelease.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvRelease.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvRelease.CurrentTheme.BackColor = Color.White;
            _dgvRelease.CurrentTheme.GridColor = Color.Gainsboro;
            _dgvRelease.CurrentTheme.HeaderStyle.BackColor = Color.Gray;
            _dgvRelease.CurrentTheme.HeaderStyle.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            _dgvRelease.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvRelease.CurrentTheme.Name = null;
            _dgvRelease.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgvRelease.CurrentTheme.RowsStyle.Font = new Font("Arial", 9.5f);
            _dgvRelease.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvRelease.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvRelease.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvRelease.DataSource = VWReleaseBindingSource;
            DataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle23.BackColor = Color.White;
            DataGridViewCellStyle23.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle23.ForeColor = Color.Black;
            DataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle23.SelectionForeColor = Color.Black;
            DataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            _dgvRelease.DefaultCellStyle = DataGridViewCellStyle23;
            _dgvRelease.Dock = DockStyle.Fill;
            _dgvRelease.EnableHeadersVisualStyles = false;
            _dgvRelease.GridColor = Color.Gainsboro;
            _dgvRelease.HeaderBackColor = Color.Gray;
            _dgvRelease.HeaderBgColor = Color.Empty;
            _dgvRelease.HeaderForeColor = Color.White;
            _dgvRelease.Location = new Point(1, 1);
            _dgvRelease.MultiSelect = false;
            _dgvRelease.Name = "_dgvRelease";
            _dgvRelease.ReadOnly = true;
            DataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle24.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle24.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            _dgvRelease.RowHeadersDefaultCellStyle = DataGridViewCellStyle24;
            _dgvRelease.RowHeadersVisible = false;
            _dgvRelease.RowHeadersWidth = 29;
            DataGridViewCellStyle25.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle25.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvRelease.RowsDefaultCellStyle = DataGridViewCellStyle25;
            _dgvRelease.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.0f);
            _dgvRelease.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            _dgvRelease.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgvRelease.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            _dgvRelease.RowTemplate.Height = 27;
            _dgvRelease.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvRelease.Size = new Size(203, 226);
            _dgvRelease.TabIndex = 141;
            _dgvRelease.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // ReleaseNumber
            // 
            ReleaseNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ReleaseNumber.DataPropertyName = "ReleaseNumber";
            ReleaseNumber.FillWeight = 142.132f;
            ReleaseNumber.HeaderText = "Release Number";
            ReleaseNumber.Name = "ReleaseNumber";
            ReleaseNumber.ReadOnly = true;
            ReleaseNumber.Width = 150;
            // 
            // TotalQtyAccepted
            // 
            TotalQtyAccepted.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TotalQtyAccepted.DataPropertyName = "TotalQtyAccepted";
            TotalQtyAccepted.FillWeight = 57.86803f;
            TotalQtyAccepted.HeaderText = "Qty";
            TotalQtyAccepted.Name = "TotalQtyAccepted";
            TotalQtyAccepted.ReadOnly = true;
            TotalQtyAccepted.Width = 52;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Arial Narrow", 6.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(3, 16);
            Label7.Name = "Label7";
            Label7.Size = new Size(34, 13);
            Label7.TabIndex = 140;
            Label7.Text = "FILTER";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label11.Location = new Point(34, 50);
            Label11.Name = "Label11";
            Label11.Size = new Size(199, 25);
            Label11.TabIndex = 206;
            Label11.Text = "Update request status";
            // 
            // btnNewRequest
            // 
            _btnNewRequest.AllowToggling = false;
            _btnNewRequest.AnimationSpeed = 200;
            _btnNewRequest.AutoGenerateColors = false;
            _btnNewRequest.BackColor = Color.Transparent;
            _btnNewRequest.BackColor1 = Color.Teal;
            _btnNewRequest.BackgroundImage = (Image)resources.GetObject("btnNewRequest.BackgroundImage");
            _btnNewRequest.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnNewRequest.ButtonText = "";
            _btnNewRequest.ButtonTextMarginLeft = 0;
            _btnNewRequest.ColorContrastOnClick = 45;
            _btnNewRequest.ColorContrastOnHover = 45;
            _btnNewRequest.Cursor = Cursors.Hand;
            BorderEdges27.BottomLeft = true;
            BorderEdges27.BottomRight = true;
            BorderEdges27.TopLeft = true;
            BorderEdges27.TopRight = true;
            _btnNewRequest.CustomizableEdges = BorderEdges27;
            _btnNewRequest.DialogResult = DialogResult.None;
            _btnNewRequest.DisabledBorderColor = Color.Empty;
            _btnNewRequest.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnNewRequest.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnNewRequest.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnNewRequest.Font = new Font("Segoe UI Semibold", 20.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnNewRequest.ForeColor = Color.White;
            _btnNewRequest.IconLeftCursor = Cursors.Hand;
            _btnNewRequest.IconMarginLeft = 8;
            _btnNewRequest.IconPadding = 8;
            _btnNewRequest.IconRightCursor = Cursors.Hand;
            _btnNewRequest.IdleBorderColor = Color.Teal;
            _btnNewRequest.IdleBorderRadius = 25;
            _btnNewRequest.IdleBorderThickness = 1;
            _btnNewRequest.IdleFillColor = Color.Teal;
            _btnNewRequest.IdleIconLeftImage = My.Resources.Resources.addWhite;
            _btnNewRequest.IdleIconRightImage = null;
            _btnNewRequest.IndicateFocus = true;
            _btnNewRequest.Location = new Point(272, 370);
            _btnNewRequest.Name = "_btnNewRequest";
            StateProperties53.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties53.BorderRadius = 25;
            StateProperties53.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties53.BorderThickness = 1;
            StateProperties53.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties53.ForeColor = Color.White;
            StateProperties53.IconLeftImage = null;
            StateProperties53.IconRightImage = null;
            _btnNewRequest.onHoverState = StateProperties53;
            StateProperties54.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties54.BorderRadius = 25;
            StateProperties54.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties54.BorderThickness = 1;
            StateProperties54.FillColor = Color.Teal;
            StateProperties54.ForeColor = Color.White;
            StateProperties54.IconLeftImage = null;
            StateProperties54.IconRightImage = null;
            _btnNewRequest.OnPressedState = StateProperties54;
            _btnNewRequest.Size = new Size(29, 29);
            _btnNewRequest.TabIndex = 207;
            _btnNewRequest.TextAlign = ContentAlignment.MiddleCenter;
            _btnNewRequest.TextMarginLeft = 0;
            _btnNewRequest.UseDefaultRadiusAndThickness = true;
            // 
            // btnManageBal
            // 
            _btnManageBal.AllowToggling = false;
            _btnManageBal.AnimationSpeed = 200;
            _btnManageBal.AutoGenerateColors = false;
            _btnManageBal.BackColor = Color.Transparent;
            _btnManageBal.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnManageBal.BackgroundImage = (Image)resources.GetObject("btnManageBal.BackgroundImage");
            _btnManageBal.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnManageBal.ButtonText = "Write off remaining";
            _btnManageBal.ButtonTextMarginLeft = 0;
            _btnManageBal.ColorContrastOnClick = 45;
            _btnManageBal.ColorContrastOnHover = 45;
            _btnManageBal.Cursor = Cursors.Hand;
            BorderEdges28.BottomLeft = true;
            BorderEdges28.BottomRight = true;
            BorderEdges28.TopLeft = true;
            BorderEdges28.TopRight = true;
            _btnManageBal.CustomizableEdges = BorderEdges28;
            _btnManageBal.DialogResult = DialogResult.None;
            _btnManageBal.DisabledBorderColor = Color.Empty;
            _btnManageBal.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnManageBal.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnManageBal.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnManageBal.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnManageBal.ForeColor = Color.White;
            _btnManageBal.IconLeftCursor = Cursors.Hand;
            _btnManageBal.IconMarginLeft = 11;
            _btnManageBal.IconPadding = 10;
            _btnManageBal.IconRightCursor = Cursors.Hand;
            _btnManageBal.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnManageBal.IdleBorderRadius = 3;
            _btnManageBal.IdleBorderThickness = 1;
            _btnManageBal.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnManageBal.IdleIconLeftImage = null;
            _btnManageBal.IdleIconRightImage = null;
            _btnManageBal.IndicateFocus = true;
            _btnManageBal.Location = new Point(66, 598);
            _btnManageBal.Name = "_btnManageBal";
            StateProperties55.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties55.BorderRadius = 3;
            StateProperties55.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties55.BorderThickness = 1;
            StateProperties55.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties55.ForeColor = Color.White;
            StateProperties55.IconLeftImage = null;
            StateProperties55.IconRightImage = null;
            _btnManageBal.onHoverState = StateProperties55;
            StateProperties56.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties56.BorderRadius = 3;
            StateProperties56.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties56.BorderThickness = 1;
            StateProperties56.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties56.ForeColor = Color.White;
            StateProperties56.IconLeftImage = null;
            StateProperties56.IconRightImage = null;
            _btnManageBal.OnPressedState = StateProperties56;
            _btnManageBal.Size = new Size(151, 25);
            _btnManageBal.TabIndex = 77;
            _btnManageBal.TextAlign = ContentAlignment.MiddleCenter;
            _btnManageBal.TextMarginLeft = 0;
            _btnManageBal.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(78, 7);
            Label1.Name = "Label1";
            Label1.Size = new Size(54, 18);
            Label1.TabIndex = 210;
            Label1.Text = "Status:";
            Label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbStatus
            // 
            _cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            _cbStatus.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cbStatus.FormattingEnabled = true;
            _cbStatus.Location = new Point(138, 3);
            _cbStatus.Name = "_cbStatus";
            _cbStatus.Size = new Size(168, 26);
            _cbStatus.TabIndex = 211;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Right;
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(37, 40);
            Label2.Name = "Label2";
            Label2.Size = new Size(95, 18);
            Label2.TabIndex = 212;
            Label2.Text = "Shipping Line";
            Label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(698, 603);
            Label3.Name = "Label3";
            Label3.Size = new Size(116, 15);
            Label3.TabIndex = 213;
            Label3.Text = "* double click to edit";
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Right;
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(91, 106);
            Label4.Name = "Label4";
            Label4.Size = new Size(41, 18);
            Label4.TabIndex = 214;
            Label4.Text = "Size:";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.Right;
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(30, 140);
            Label5.Name = "Label5";
            Label5.Size = new Size(102, 18);
            Label5.TabIndex = 215;
            Label5.Text = "Request Date:";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.08761f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.91239f));
            TableLayoutPanel1.Controls.Add(lblRelType, 1, 2);
            TableLayoutPanel1.Controls.Add(Label33, 0, 2);
            TableLayoutPanel1.Controls.Add(lblSSLineName, 1, 1);
            TableLayoutPanel1.Controls.Add(Label1, 0, 0);
            TableLayoutPanel1.Controls.Add(_cbStatus, 1, 0);
            TableLayoutPanel1.Controls.Add(Label2, 0, 1);
            TableLayoutPanel1.Controls.Add(lblReqDate, 1, 4);
            TableLayoutPanel1.Controls.Add(Label5, 0, 4);
            TableLayoutPanel1.Controls.Add(Label4, 0, 3);
            TableLayoutPanel1.Controls.Add(lblSize, 1, 3);
            TableLayoutPanel1.Location = new Point(62, 123);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 5;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel1.Size = new Size(331, 166);
            TableLayoutPanel1.TabIndex = 217;
            // 
            // lblRelType
            // 
            lblRelType.Anchor = AnchorStyles.Left;
            lblRelType.AutoSize = true;
            lblRelType.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblRelType.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblRelType.Location = new Point(138, 73);
            lblRelType.Name = "lblRelType";
            lblRelType.Size = new Size(108, 18);
            lblRelType.TabIndex = 238;
            lblRelType.Text = "Shipping Line";
            lblRelType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label33
            // 
            Label33.Anchor = AnchorStyles.Right;
            Label33.AutoSize = true;
            Label33.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label33.Location = new Point(35, 73);
            Label33.Name = "Label33";
            Label33.Size = new Size(97, 18);
            Label33.TabIndex = 238;
            Label33.Text = "Release type:";
            Label33.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSSLineName
            // 
            lblSSLineName.Anchor = AnchorStyles.Left;
            lblSSLineName.AutoSize = true;
            lblSSLineName.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSSLineName.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblSSLineName.Location = new Point(138, 40);
            lblSSLineName.Name = "lblSSLineName";
            lblSSLineName.Size = new Size(108, 18);
            lblSSLineName.TabIndex = 217;
            lblSSLineName.Text = "Shipping Line";
            lblSSLineName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblReqDate
            // 
            lblReqDate.Anchor = AnchorStyles.Left;
            lblReqDate.AutoSize = true;
            lblReqDate.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblReqDate.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblReqDate.Location = new Point(138, 140);
            lblReqDate.Name = "lblReqDate";
            lblReqDate.Size = new Size(108, 18);
            lblReqDate.TabIndex = 220;
            lblReqDate.Text = "Shipping Line";
            lblReqDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSize
            // 
            lblSize.Anchor = AnchorStyles.Left;
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSize.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblSize.Location = new Point(138, 106);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(108, 18);
            lblSize.TabIndex = 218;
            lblSize.Text = "Shipping Line";
            lblSize.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Font = new Font("Segoe UI Semibold", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label14.Location = new Point(83, 99);
            Label14.Name = "Label14";
            Label14.Size = new Size(80, 20);
            Label14.TabIndex = 218;
            Label14.Text = "Pick status";
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Font = new Font("Segoe UI Semibold", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label15.Location = new Point(90, 347);
            Label15.Name = "Label15";
            Label15.Size = new Size(105, 20);
            Label15.TabIndex = 219;
            Label15.Text = "Create release";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Font = new Font("Segoe UI Semibold", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label16.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label16.Location = new Point(707, 351);
            Label16.Name = "Label16";
            Label16.Size = new Size(225, 20);
            Label16.TabIndex = 224;
            Label16.Text = "Add Pick Up/ Drop Off Location";
            // 
            // ShapedPanel1
            // 
            ShapedPanel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ShapedPanel1.BorderColor = Color.Gray;
            ShapedPanel1.Controls.Add(dgvPickUpDropOff);
            ShapedPanel1.Controls.Add(Label18);
            ShapedPanel1.Edge = 2;
            ShapedPanel1.Location = new Point(686, 373);
            ShapedPanel1.Name = "ShapedPanel1";
            ShapedPanel1.Padding = new Padding(1);
            ShapedPanel1.Size = new Size(368, 228);
            ShapedPanel1.TabIndex = 221;
            // 
            // dgvPickUpDropOff
            // 
            dgvPickUpDropOff.AllowCustomTheming = true;
            dgvPickUpDropOff.AllowUserToAddRows = false;
            dgvPickUpDropOff.AllowUserToDeleteRows = false;
            dgvPickUpDropOff.AllowUserToOrderColumns = true;
            dgvPickUpDropOff.AllowUserToResizeRows = false;
            DataGridViewCellStyle26.BackColor = SystemColors.Control;
            DataGridViewCellStyle26.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle26.ForeColor = Color.Black;
            DataGridViewCellStyle26.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvPickUpDropOff.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle26;
            dgvPickUpDropOff.AutoGenerateColumns = false;
            dgvPickUpDropOff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPickUpDropOff.BackgroundColor = Color.White;
            dgvPickUpDropOff.BorderStyle = BorderStyle.None;
            dgvPickUpDropOff.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvPickUpDropOff.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvPickUpDropOff.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle27.BackColor = Color.Gray;
            DataGridViewCellStyle27.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            DataGridViewCellStyle27.ForeColor = Color.White;
            DataGridViewCellStyle27.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
            dgvPickUpDropOff.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27;
            dgvPickUpDropOff.ColumnHeadersHeight = 30;
            dgvPickUpDropOff.Columns.AddRange(new DataGridViewColumn[] { PickUpTerminalNameDataGridViewTextBoxColumn, YardNameDataGridViewTextBoxColumn, QtyPickUpDropOffDataGridViewTextBoxColumn });
            dgvPickUpDropOff.CurrentTheme.AlternatingRowsStyle.BackColor = SystemColors.Control;
            dgvPickUpDropOff.CurrentTheme.AlternatingRowsStyle.Font = new Font("Arial", 9.5f);
            dgvPickUpDropOff.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvPickUpDropOff.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            dgvPickUpDropOff.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvPickUpDropOff.CurrentTheme.BackColor = Color.White;
            dgvPickUpDropOff.CurrentTheme.GridColor = Color.Gainsboro;
            dgvPickUpDropOff.CurrentTheme.HeaderStyle.BackColor = Color.Gray;
            dgvPickUpDropOff.CurrentTheme.HeaderStyle.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            dgvPickUpDropOff.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvPickUpDropOff.CurrentTheme.Name = null;
            dgvPickUpDropOff.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvPickUpDropOff.CurrentTheme.RowsStyle.Font = new Font("Arial", 9.5f);
            dgvPickUpDropOff.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvPickUpDropOff.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            dgvPickUpDropOff.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dgvPickUpDropOff.DataSource = VWRelOrderPickUpDropOffLocationBindingSource;
            DataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle28.BackColor = Color.White;
            DataGridViewCellStyle28.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle28.ForeColor = Color.Black;
            DataGridViewCellStyle28.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle28.SelectionForeColor = Color.Black;
            DataGridViewCellStyle28.WrapMode = DataGridViewTriState.False;
            dgvPickUpDropOff.DefaultCellStyle = DataGridViewCellStyle28;
            dgvPickUpDropOff.Dock = DockStyle.Fill;
            dgvPickUpDropOff.EnableHeadersVisualStyles = false;
            dgvPickUpDropOff.GridColor = Color.Gainsboro;
            dgvPickUpDropOff.HeaderBackColor = Color.Gray;
            dgvPickUpDropOff.HeaderBgColor = Color.Empty;
            dgvPickUpDropOff.HeaderForeColor = Color.White;
            dgvPickUpDropOff.Location = new Point(1, 1);
            dgvPickUpDropOff.MultiSelect = false;
            dgvPickUpDropOff.Name = "dgvPickUpDropOff";
            dgvPickUpDropOff.ReadOnly = true;
            DataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle29.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle29.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle29.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
            dgvPickUpDropOff.RowHeadersDefaultCellStyle = DataGridViewCellStyle29;
            dgvPickUpDropOff.RowHeadersVisible = false;
            dgvPickUpDropOff.RowHeadersWidth = 29;
            DataGridViewCellStyle30.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle30.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            dgvPickUpDropOff.RowsDefaultCellStyle = DataGridViewCellStyle30;
            dgvPickUpDropOff.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.0f);
            dgvPickUpDropOff.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvPickUpDropOff.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            dgvPickUpDropOff.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPickUpDropOff.RowTemplate.Height = 27;
            dgvPickUpDropOff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPickUpDropOff.Size = new Size(366, 226);
            dgvPickUpDropOff.TabIndex = 141;
            dgvPickUpDropOff.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // PickUpTerminalNameDataGridViewTextBoxColumn
            // 
            PickUpTerminalNameDataGridViewTextBoxColumn.DataPropertyName = "PickUpTerminalName";
            PickUpTerminalNameDataGridViewTextBoxColumn.FillWeight = 157.8305f;
            PickUpTerminalNameDataGridViewTextBoxColumn.HeaderText = "Pick Up Terminal";
            PickUpTerminalNameDataGridViewTextBoxColumn.Name = "PickUpTerminalNameDataGridViewTextBoxColumn";
            PickUpTerminalNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // YardNameDataGridViewTextBoxColumn
            // 
            YardNameDataGridViewTextBoxColumn.DataPropertyName = "YardName";
            YardNameDataGridViewTextBoxColumn.FillWeight = 96.48424f;
            YardNameDataGridViewTextBoxColumn.HeaderText = "Drop Off Yard";
            YardNameDataGridViewTextBoxColumn.Name = "YardNameDataGridViewTextBoxColumn";
            YardNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // QtyPickUpDropOffDataGridViewTextBoxColumn
            // 
            QtyPickUpDropOffDataGridViewTextBoxColumn.DataPropertyName = "QtyPickUpDropOff";
            QtyPickUpDropOffDataGridViewTextBoxColumn.FillWeight = 45.68528f;
            QtyPickUpDropOffDataGridViewTextBoxColumn.HeaderText = "Qty";
            QtyPickUpDropOffDataGridViewTextBoxColumn.Name = "QtyPickUpDropOffDataGridViewTextBoxColumn";
            QtyPickUpDropOffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VWRelOrderPickUpDropOffLocationBindingSource
            // 
            VWRelOrderPickUpDropOffLocationBindingSource.DataSource = typeof(ModelLayer.VW_RelOrderPickUpDropOffLocation);
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Font = new Font("Arial Narrow", 6.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.ForeColor = Color.White;
            Label18.Location = new Point(3, 16);
            Label18.Name = "Label18";
            Label18.Size = new Size(34, 13);
            Label18.TabIndex = 140;
            Label18.Text = "FILTER";
            // 
            // BunifuButton4
            // 
            BunifuButton4.AllowToggling = false;
            BunifuButton4.AnimationSpeed = 200;
            BunifuButton4.AutoGenerateColors = false;
            BunifuButton4.BackColor = Color.Transparent;
            BunifuButton4.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton4.BackgroundImage = (Image)resources.GetObject("BunifuButton4.BackgroundImage");
            BunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            BunifuButton4.ButtonText = "1";
            BunifuButton4.ButtonTextMarginLeft = 0;
            BunifuButton4.ColorContrastOnClick = 45;
            BunifuButton4.ColorContrastOnHover = 45;
            BunifuButton4.Cursor = Cursors.Hand;
            BorderEdges29.BottomLeft = true;
            BorderEdges29.BottomRight = true;
            BorderEdges29.TopLeft = true;
            BorderEdges29.TopRight = true;
            BunifuButton4.CustomizableEdges = BorderEdges29;
            BunifuButton4.DialogResult = DialogResult.None;
            BunifuButton4.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton4.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton4.DisabledForecolor = Color.White;
            BunifuButton4.Enabled = false;
            BunifuButton4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            BunifuButton4.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuButton4.ForeColor = Color.White;
            BunifuButton4.IconLeftCursor = Cursors.Hand;
            BunifuButton4.IconMarginLeft = 8;
            BunifuButton4.IconPadding = 8;
            BunifuButton4.IconRightCursor = Cursors.Hand;
            BunifuButton4.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton4.IdleBorderRadius = 25;
            BunifuButton4.IdleBorderThickness = 1;
            BunifuButton4.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton4.IdleIconLeftImage = null;
            BunifuButton4.IdleIconRightImage = null;
            BunifuButton4.IndicateFocus = true;
            BunifuButton4.Location = new Point(48, 91);
            BunifuButton4.Name = "BunifuButton4";
            StateProperties57.BorderColor = Color.Coral;
            StateProperties57.BorderRadius = 25;
            StateProperties57.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties57.BorderThickness = 1;
            StateProperties57.FillColor = Color.Coral;
            StateProperties57.ForeColor = Color.White;
            StateProperties57.IconLeftImage = null;
            StateProperties57.IconRightImage = null;
            BunifuButton4.onHoverState = StateProperties57;
            StateProperties58.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties58.BorderRadius = 25;
            StateProperties58.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties58.BorderThickness = 1;
            StateProperties58.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties58.ForeColor = Color.White;
            StateProperties58.IconLeftImage = null;
            StateProperties58.IconRightImage = null;
            BunifuButton4.OnPressedState = StateProperties58;
            BunifuButton4.Size = new Size(29, 29);
            BunifuButton4.TabIndex = 225;
            BunifuButton4.TextAlign = ContentAlignment.MiddleCenter;
            BunifuButton4.TextMarginLeft = 0;
            BunifuButton4.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuButton5
            // 
            BunifuButton5.AllowToggling = false;
            BunifuButton5.AnimationSpeed = 200;
            BunifuButton5.AutoGenerateColors = false;
            BunifuButton5.BackColor = Color.Transparent;
            BunifuButton5.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton5.BackgroundImage = (Image)resources.GetObject("BunifuButton5.BackgroundImage");
            BunifuButton5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            BunifuButton5.ButtonText = "2";
            BunifuButton5.ButtonTextMarginLeft = 0;
            BunifuButton5.ColorContrastOnClick = 45;
            BunifuButton5.ColorContrastOnHover = 45;
            BunifuButton5.Cursor = Cursors.Hand;
            BorderEdges30.BottomLeft = true;
            BorderEdges30.BottomRight = true;
            BorderEdges30.TopLeft = true;
            BorderEdges30.TopRight = true;
            BunifuButton5.CustomizableEdges = BorderEdges30;
            BunifuButton5.DialogResult = DialogResult.None;
            BunifuButton5.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton5.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton5.DisabledForecolor = Color.White;
            BunifuButton5.Enabled = false;
            BunifuButton5.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            BunifuButton5.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuButton5.ForeColor = Color.White;
            BunifuButton5.IconLeftCursor = Cursors.Hand;
            BunifuButton5.IconMarginLeft = 8;
            BunifuButton5.IconPadding = 8;
            BunifuButton5.IconRightCursor = Cursors.Hand;
            BunifuButton5.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton5.IdleBorderRadius = 25;
            BunifuButton5.IdleBorderThickness = 1;
            BunifuButton5.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton5.IdleIconLeftImage = null;
            BunifuButton5.IdleIconRightImage = null;
            BunifuButton5.IndicateFocus = true;
            BunifuButton5.Location = new Point(55, 339);
            BunifuButton5.Name = "BunifuButton5";
            StateProperties59.BorderColor = Color.Coral;
            StateProperties59.BorderRadius = 25;
            StateProperties59.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties59.BorderThickness = 1;
            StateProperties59.FillColor = Color.Coral;
            StateProperties59.ForeColor = Color.White;
            StateProperties59.IconLeftImage = null;
            StateProperties59.IconRightImage = null;
            BunifuButton5.onHoverState = StateProperties59;
            StateProperties60.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties60.BorderRadius = 25;
            StateProperties60.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties60.BorderThickness = 1;
            StateProperties60.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties60.ForeColor = Color.White;
            StateProperties60.IconLeftImage = null;
            StateProperties60.IconRightImage = null;
            BunifuButton5.OnPressedState = StateProperties60;
            BunifuButton5.Size = new Size(29, 29);
            BunifuButton5.TabIndex = 226;
            BunifuButton5.TextAlign = ContentAlignment.MiddleCenter;
            BunifuButton5.TextMarginLeft = 0;
            BunifuButton5.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuButton6
            // 
            BunifuButton6.AllowToggling = false;
            BunifuButton6.AnimationSpeed = 200;
            BunifuButton6.AutoGenerateColors = false;
            BunifuButton6.BackColor = Color.Transparent;
            BunifuButton6.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton6.BackgroundImage = (Image)resources.GetObject("BunifuButton6.BackgroundImage");
            BunifuButton6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            BunifuButton6.ButtonText = "3";
            BunifuButton6.ButtonTextMarginLeft = 0;
            BunifuButton6.ColorContrastOnClick = 45;
            BunifuButton6.ColorContrastOnHover = 45;
            BunifuButton6.Cursor = Cursors.Hand;
            BorderEdges31.BottomLeft = true;
            BorderEdges31.BottomRight = true;
            BorderEdges31.TopLeft = true;
            BorderEdges31.TopRight = true;
            BunifuButton6.CustomizableEdges = BorderEdges31;
            BunifuButton6.DialogResult = DialogResult.None;
            BunifuButton6.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton6.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton6.DisabledForecolor = Color.White;
            BunifuButton6.Enabled = false;
            BunifuButton6.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            BunifuButton6.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuButton6.ForeColor = Color.White;
            BunifuButton6.IconLeftCursor = Cursors.Hand;
            BunifuButton6.IconMarginLeft = 8;
            BunifuButton6.IconPadding = 8;
            BunifuButton6.IconRightCursor = Cursors.Hand;
            BunifuButton6.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton6.IdleBorderRadius = 25;
            BunifuButton6.IdleBorderThickness = 1;
            BunifuButton6.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton6.IdleIconLeftImage = null;
            BunifuButton6.IdleIconRightImage = null;
            BunifuButton6.IndicateFocus = true;
            BunifuButton6.Location = new Point(672, 342);
            BunifuButton6.Name = "BunifuButton6";
            StateProperties61.BorderColor = Color.Coral;
            StateProperties61.BorderRadius = 25;
            StateProperties61.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties61.BorderThickness = 1;
            StateProperties61.FillColor = Color.Coral;
            StateProperties61.ForeColor = Color.White;
            StateProperties61.IconLeftImage = null;
            StateProperties61.IconRightImage = null;
            BunifuButton6.onHoverState = StateProperties61;
            StateProperties62.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties62.BorderRadius = 25;
            StateProperties62.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties62.BorderThickness = 1;
            StateProperties62.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties62.ForeColor = Color.White;
            StateProperties62.IconLeftImage = null;
            StateProperties62.IconRightImage = null;
            BunifuButton6.OnPressedState = StateProperties62;
            BunifuButton6.Size = new Size(29, 29);
            BunifuButton6.TabIndex = 227;
            BunifuButton6.TextAlign = ContentAlignment.MiddleCenter;
            BunifuButton6.TextMarginLeft = 0;
            BunifuButton6.UseDefaultRadiusAndThickness = true;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = Color.White;
            Label17.Location = new Point(2, 5);
            Label17.Name = "Label17";
            Label17.Size = new Size(137, 29);
            Label17.TabIndex = 217;
            Label17.Text = "Requested:";
            Label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalReq
            // 
            lblTotalReq.AutoSize = true;
            lblTotalReq.Font = new Font("Microsoft Sans Serif", 25.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotalReq.ForeColor = Color.White;
            lblTotalReq.Location = new Point(145, 0);
            lblTotalReq.Name = "lblTotalReq";
            lblTotalReq.Size = new Size(37, 39);
            lblTotalReq.TabIndex = 220;
            lblTotalReq.Text = "0";
            lblTotalReq.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.SandyBrown;
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(lblTotalReq);
            Panel1.Controls.Add(Label17);
            Panel1.Dock = DockStyle.Top;
            Panel1.ForeColor = Color.White;
            Panel1.Location = new Point(0, 0);
            Panel1.Margin = new Padding(3, 3, 3, 15);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(299, 39);
            Panel1.TabIndex = 234;
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.Gray;
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Image = My.Resources.Resources.arrowRightWhiteBackground;
            PictureBox1.Location = new Point(303, 420);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(47, 36);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 235;
            PictureBox1.TabStop = false;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.GhostWhite;
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(Label22);
            Panel2.Controls.Add(TableLayoutPanel2);
            Panel2.Controls.Add(Panel1);
            Panel2.ForeColor = Color.White;
            Panel2.Location = new Point(806, 46);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(301, 157);
            Panel2.TabIndex = 237;
            // 
            // Label22
            // 
            Label22.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label22.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label22.ForeColor = Color.White;
            Label22.Location = new Point(0, 42);
            Label22.Margin = new Padding(0, 10, 0, 0);
            Label22.Name = "Label22";
            Label22.Size = new Size(299, 22);
            Label22.TabIndex = 239;
            Label22.Text = "Containers balance";
            Label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel2.ColumnCount = 3;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.92893f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.07107f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109.0f));
            TableLayoutPanel2.Controls.Add(Label24, 0, 2);
            TableLayoutPanel2.Controls.Add(Label23, 0, 1);
            TableLayoutPanel2.Controls.Add(Label12, 0, 0);
            TableLayoutPanel2.Controls.Add(Label6, 1, 0);
            TableLayoutPanel2.Controls.Add(Label26, 2, 0);
            TableLayoutPanel2.Controls.Add(lblAddedRel, 1, 1);
            TableLayoutPanel2.Controls.Add(lblBalRelease, 2, 1);
            TableLayoutPanel2.Controls.Add(lblAddedPickUpDropOff, 1, 2);
            TableLayoutPanel2.Controls.Add(lblBalPickUpDropOff, 2, 2);
            TableLayoutPanel2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            TableLayoutPanel2.Location = new Point(0, 64);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 3;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.61069f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.9542f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.48092f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            TableLayoutPanel2.Size = new Size(300, 92);
            TableLayoutPanel2.TabIndex = 238;
            // 
            // Label24
            // 
            Label24.Anchor = AnchorStyles.Right;
            Label24.AutoSize = true;
            Label24.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label24.Location = new Point(11, 57);
            Label24.Name = "Label24";
            Label24.Size = new Size(102, 34);
            Label24.TabIndex = 214;
            Label24.Text = "Prick Up/Drop Off:";
            Label24.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label23
            // 
            Label23.Anchor = AnchorStyles.Right;
            Label23.AutoSize = true;
            Label23.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label23.Location = new Point(47, 32);
            Label23.Name = "Label23";
            Label23.Size = new Size(66, 18);
            Label23.TabIndex = 212;
            Label23.Text = "Release:";
            Label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(128)));
            Label12.Dock = DockStyle.Fill;
            Label12.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Location = new Point(1, 1);
            Label12.Margin = new Padding(0);
            Label12.Name = "Label12";
            Label12.Size = new Size(115, 24);
            Label12.TabIndex = 217;
            Label12.Text = "Shipping Line";
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(128)));
            Label6.Dock = DockStyle.Fill;
            Label6.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(117, 1);
            Label6.Margin = new Padding(0);
            Label6.Name = "Label6";
            Label6.Size = new Size(71, 24);
            Label6.TabIndex = 218;
            Label6.Text = "Added";
            Label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label26
            // 
            Label26.AutoSize = true;
            Label26.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(128)));
            Label26.Dock = DockStyle.Fill;
            Label26.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label26.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label26.Location = new Point(189, 1);
            Label26.Margin = new Padding(0);
            Label26.Name = "Label26";
            Label26.Size = new Size(110, 24);
            Label26.TabIndex = 220;
            Label26.Text = "Balance";
            Label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddedRel
            // 
            lblAddedRel.AutoSize = true;
            lblAddedRel.BackColor = Color.Transparent;
            lblAddedRel.Dock = DockStyle.Fill;
            lblAddedRel.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblAddedRel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblAddedRel.Location = new Point(117, 26);
            lblAddedRel.Margin = new Padding(0);
            lblAddedRel.Name = "lblAddedRel";
            lblAddedRel.Size = new Size(71, 30);
            lblAddedRel.TabIndex = 222;
            lblAddedRel.Text = "0";
            lblAddedRel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBalRelease
            // 
            lblBalRelease.AutoSize = true;
            lblBalRelease.BackColor = Color.Transparent;
            lblBalRelease.Dock = DockStyle.Fill;
            lblBalRelease.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBalRelease.ForeColor = Color.Green;
            lblBalRelease.Location = new Point(189, 26);
            lblBalRelease.Margin = new Padding(0);
            lblBalRelease.Name = "lblBalRelease";
            lblBalRelease.Size = new Size(110, 30);
            lblBalRelease.TabIndex = 221;
            lblBalRelease.Text = "0";
            lblBalRelease.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddedPickUpDropOff
            // 
            lblAddedPickUpDropOff.AutoSize = true;
            lblAddedPickUpDropOff.BackColor = Color.Transparent;
            lblAddedPickUpDropOff.Dock = DockStyle.Fill;
            lblAddedPickUpDropOff.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblAddedPickUpDropOff.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblAddedPickUpDropOff.Location = new Point(117, 57);
            lblAddedPickUpDropOff.Margin = new Padding(0);
            lblAddedPickUpDropOff.Name = "lblAddedPickUpDropOff";
            lblAddedPickUpDropOff.Size = new Size(71, 34);
            lblAddedPickUpDropOff.TabIndex = 223;
            lblAddedPickUpDropOff.Text = "0";
            lblAddedPickUpDropOff.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBalPickUpDropOff
            // 
            lblBalPickUpDropOff.AutoSize = true;
            lblBalPickUpDropOff.BackColor = Color.Transparent;
            lblBalPickUpDropOff.Dock = DockStyle.Fill;
            lblBalPickUpDropOff.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBalPickUpDropOff.ForeColor = Color.Green;
            lblBalPickUpDropOff.Location = new Point(189, 57);
            lblBalPickUpDropOff.Margin = new Padding(0);
            lblBalPickUpDropOff.Name = "lblBalPickUpDropOff";
            lblBalPickUpDropOff.Size = new Size(110, 34);
            lblBalPickUpDropOff.TabIndex = 224;
            lblBalPickUpDropOff.Text = "0";
            lblBalPickUpDropOff.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRmRel
            // 
            _btnRmRel.AllowToggling = false;
            _btnRmRel.AnimationSpeed = 200;
            _btnRmRel.AutoGenerateColors = false;
            _btnRmRel.BackColor = Color.Transparent;
            _btnRmRel.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRmRel.BackgroundImage = (Image)resources.GetObject("btnRmRel.BackgroundImage");
            _btnRmRel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnRmRel.ButtonText = "";
            _btnRmRel.ButtonTextMarginLeft = 0;
            _btnRmRel.ColorContrastOnClick = 45;
            _btnRmRel.ColorContrastOnHover = 45;
            _btnRmRel.Cursor = Cursors.Hand;
            BorderEdges32.BottomLeft = true;
            BorderEdges32.BottomRight = true;
            BorderEdges32.TopLeft = true;
            BorderEdges32.TopRight = true;
            _btnRmRel.CustomizableEdges = BorderEdges32;
            _btnRmRel.DialogResult = DialogResult.None;
            _btnRmRel.DisabledBorderColor = Color.Empty;
            _btnRmRel.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnRmRel.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnRmRel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnRmRel.Font = new Font("Segoe UI Semibold", 20.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnRmRel.ForeColor = Color.White;
            _btnRmRel.IconLeftCursor = Cursors.Hand;
            _btnRmRel.IconMarginLeft = 7;
            _btnRmRel.IconPadding = 7;
            _btnRmRel.IconRightCursor = Cursors.Hand;
            _btnRmRel.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRmRel.IdleBorderRadius = 23;
            _btnRmRel.IdleBorderThickness = 1;
            _btnRmRel.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRmRel.IdleIconLeftImage = My.Resources.Resources.removeWhite;
            _btnRmRel.IdleIconRightImage = null;
            _btnRmRel.IndicateFocus = true;
            _btnRmRel.Location = new Point(272, 569);
            _btnRmRel.Name = "_btnRmRel";
            StateProperties63.BorderColor = Color.Coral;
            StateProperties63.BorderRadius = 23;
            StateProperties63.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties63.BorderThickness = 1;
            StateProperties63.FillColor = Color.Red;
            StateProperties63.ForeColor = Color.White;
            StateProperties63.IconLeftImage = null;
            StateProperties63.IconRightImage = null;
            _btnRmRel.onHoverState = StateProperties63;
            StateProperties64.BorderColor = Color.Red;
            StateProperties64.BorderRadius = 23;
            StateProperties64.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties64.BorderThickness = 1;
            StateProperties64.FillColor = Color.Red;
            StateProperties64.ForeColor = Color.White;
            StateProperties64.IconLeftImage = null;
            StateProperties64.IconRightImage = null;
            _btnRmRel.OnPressedState = StateProperties64;
            _btnRmRel.Size = new Size(25, 25);
            _btnRmRel.TabIndex = 238;
            _btnRmRel.TextAlign = ContentAlignment.MiddleCenter;
            _btnRmRel.TextMarginLeft = 0;
            _btnRmRel.UseDefaultRadiusAndThickness = true;
            // 
            // btnRmPickUpDropOff
            // 
            _btnRmPickUpDropOff.AllowToggling = false;
            _btnRmPickUpDropOff.AnimationSpeed = 200;
            _btnRmPickUpDropOff.AutoGenerateColors = false;
            _btnRmPickUpDropOff.BackColor = Color.Transparent;
            _btnRmPickUpDropOff.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRmPickUpDropOff.BackgroundImage = (Image)resources.GetObject("btnRmPickUpDropOff.BackgroundImage");
            _btnRmPickUpDropOff.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnRmPickUpDropOff.ButtonText = "";
            _btnRmPickUpDropOff.ButtonTextMarginLeft = 0;
            _btnRmPickUpDropOff.ColorContrastOnClick = 45;
            _btnRmPickUpDropOff.ColorContrastOnHover = 45;
            _btnRmPickUpDropOff.Cursor = Cursors.Hand;
            BorderEdges33.BottomLeft = true;
            BorderEdges33.BottomRight = true;
            BorderEdges33.TopLeft = true;
            BorderEdges33.TopRight = true;
            _btnRmPickUpDropOff.CustomizableEdges = BorderEdges33;
            _btnRmPickUpDropOff.DialogResult = DialogResult.None;
            _btnRmPickUpDropOff.DisabledBorderColor = Color.Empty;
            _btnRmPickUpDropOff.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnRmPickUpDropOff.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnRmPickUpDropOff.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnRmPickUpDropOff.Font = new Font("Segoe UI Semibold", 20.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnRmPickUpDropOff.ForeColor = Color.White;
            _btnRmPickUpDropOff.IconLeftCursor = Cursors.Hand;
            _btnRmPickUpDropOff.IconMarginLeft = 7;
            _btnRmPickUpDropOff.IconPadding = 7;
            _btnRmPickUpDropOff.IconRightCursor = Cursors.Hand;
            _btnRmPickUpDropOff.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRmPickUpDropOff.IdleBorderRadius = 23;
            _btnRmPickUpDropOff.IdleBorderThickness = 1;
            _btnRmPickUpDropOff.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnRmPickUpDropOff.IdleIconLeftImage = My.Resources.Resources.removeWhite;
            _btnRmPickUpDropOff.IdleIconRightImage = null;
            _btnRmPickUpDropOff.IndicateFocus = true;
            _btnRmPickUpDropOff.Location = new Point(1060, 572);
            _btnRmPickUpDropOff.Name = "_btnRmPickUpDropOff";
            StateProperties65.BorderColor = Color.Coral;
            StateProperties65.BorderRadius = 23;
            StateProperties65.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties65.BorderThickness = 1;
            StateProperties65.FillColor = Color.Red;
            StateProperties65.ForeColor = Color.White;
            StateProperties65.IconLeftImage = null;
            StateProperties65.IconRightImage = null;
            _btnRmPickUpDropOff.onHoverState = StateProperties65;
            StateProperties66.BorderColor = Color.Red;
            StateProperties66.BorderRadius = 23;
            StateProperties66.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties66.BorderThickness = 1;
            StateProperties66.FillColor = Color.Red;
            StateProperties66.ForeColor = Color.White;
            StateProperties66.IconLeftImage = null;
            StateProperties66.IconRightImage = null;
            _btnRmPickUpDropOff.OnPressedState = StateProperties66;
            _btnRmPickUpDropOff.Size = new Size(25, 25);
            _btnRmPickUpDropOff.TabIndex = 239;
            _btnRmPickUpDropOff.TextAlign = ContentAlignment.MiddleCenter;
            _btnRmPickUpDropOff.TextMarginLeft = 0;
            _btnRmPickUpDropOff.UseDefaultRadiusAndThickness = true;
            // 
            // btnAddNewPUDO
            // 
            _btnAddNewPUDO.AllowToggling = false;
            _btnAddNewPUDO.AnimationSpeed = 200;
            _btnAddNewPUDO.AutoGenerateColors = false;
            _btnAddNewPUDO.BackColor = Color.Transparent;
            _btnAddNewPUDO.BackColor1 = Color.Teal;
            _btnAddNewPUDO.BackgroundImage = (Image)resources.GetObject("btnAddNewPUDO.BackgroundImage");
            _btnAddNewPUDO.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddNewPUDO.ButtonText = "";
            _btnAddNewPUDO.ButtonTextMarginLeft = 0;
            _btnAddNewPUDO.ColorContrastOnClick = 45;
            _btnAddNewPUDO.ColorContrastOnHover = 45;
            _btnAddNewPUDO.Cursor = Cursors.Hand;
            BorderEdges34.BottomLeft = true;
            BorderEdges34.BottomRight = true;
            BorderEdges34.TopLeft = true;
            BorderEdges34.TopRight = true;
            _btnAddNewPUDO.CustomizableEdges = BorderEdges34;
            _btnAddNewPUDO.DialogResult = DialogResult.None;
            _btnAddNewPUDO.DisabledBorderColor = Color.Empty;
            _btnAddNewPUDO.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddNewPUDO.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddNewPUDO.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddNewPUDO.Font = new Font("Segoe UI Semibold", 20.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddNewPUDO.ForeColor = Color.White;
            _btnAddNewPUDO.IconLeftCursor = Cursors.Hand;
            _btnAddNewPUDO.IconMarginLeft = 8;
            _btnAddNewPUDO.IconPadding = 8;
            _btnAddNewPUDO.IconRightCursor = Cursors.Hand;
            _btnAddNewPUDO.IdleBorderColor = Color.Teal;
            _btnAddNewPUDO.IdleBorderRadius = 25;
            _btnAddNewPUDO.IdleBorderThickness = 1;
            _btnAddNewPUDO.IdleFillColor = Color.Teal;
            _btnAddNewPUDO.IdleIconLeftImage = My.Resources.Resources.addWhite;
            _btnAddNewPUDO.IdleIconRightImage = null;
            _btnAddNewPUDO.IndicateFocus = true;
            _btnAddNewPUDO.Location = new Point(1059, 373);
            _btnAddNewPUDO.Name = "_btnAddNewPUDO";
            StateProperties67.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties67.BorderRadius = 25;
            StateProperties67.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties67.BorderThickness = 1;
            StateProperties67.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties67.ForeColor = Color.White;
            StateProperties67.IconLeftImage = null;
            StateProperties67.IconRightImage = null;
            _btnAddNewPUDO.onHoverState = StateProperties67;
            StateProperties68.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties68.BorderRadius = 25;
            StateProperties68.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties68.BorderThickness = 1;
            StateProperties68.FillColor = Color.Teal;
            StateProperties68.ForeColor = Color.White;
            StateProperties68.IconLeftImage = null;
            StateProperties68.IconRightImage = null;
            _btnAddNewPUDO.OnPressedState = StateProperties68;
            _btnAddNewPUDO.Size = new Size(29, 29);
            _btnAddNewPUDO.TabIndex = 240;
            _btnAddNewPUDO.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddNewPUDO.TextMarginLeft = 0;
            _btnAddNewPUDO.UseDefaultRadiusAndThickness = true;
            // 
            // PictureBox2
            // 
            PictureBox2.BackColor = Color.Gray;
            PictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox2.Image = My.Resources.Resources.arrowRightWhiteBackground;
            PictureBox2.Location = new Point(619, 420);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(47, 36);
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox2.TabIndex = 241;
            PictureBox2.TabStop = false;
            // 
            // BunifuButton1
            // 
            BunifuButton1.AllowToggling = false;
            BunifuButton1.AnimationSpeed = 200;
            BunifuButton1.AutoGenerateColors = false;
            BunifuButton1.BackColor = Color.Transparent;
            BunifuButton1.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton1.BackgroundImage = (Image)resources.GetObject("BunifuButton1.BackgroundImage");
            BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            BunifuButton1.ButtonText = "2";
            BunifuButton1.ButtonTextMarginLeft = 0;
            BunifuButton1.ColorContrastOnClick = 45;
            BunifuButton1.ColorContrastOnHover = 45;
            BunifuButton1.Cursor = Cursors.Hand;
            BorderEdges35.BottomLeft = true;
            BorderEdges35.BottomRight = true;
            BorderEdges35.TopLeft = true;
            BorderEdges35.TopRight = true;
            BunifuButton1.CustomizableEdges = BorderEdges35;
            BunifuButton1.DialogResult = DialogResult.None;
            BunifuButton1.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton1.DisabledForecolor = Color.White;
            BunifuButton1.Enabled = false;
            BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            BunifuButton1.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuButton1.ForeColor = Color.White;
            BunifuButton1.IconLeftCursor = Cursors.Hand;
            BunifuButton1.IconMarginLeft = 8;
            BunifuButton1.IconPadding = 8;
            BunifuButton1.IconRightCursor = Cursors.Hand;
            BunifuButton1.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton1.IdleBorderRadius = 25;
            BunifuButton1.IdleBorderThickness = 1;
            BunifuButton1.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton1.IdleIconLeftImage = null;
            BunifuButton1.IdleIconRightImage = null;
            BunifuButton1.IndicateFocus = true;
            BunifuButton1.Location = new Point(371, 343);
            BunifuButton1.Name = "BunifuButton1";
            StateProperties69.BorderColor = Color.Coral;
            StateProperties69.BorderRadius = 25;
            StateProperties69.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties69.BorderThickness = 1;
            StateProperties69.FillColor = Color.Coral;
            StateProperties69.ForeColor = Color.White;
            StateProperties69.IconLeftImage = null;
            StateProperties69.IconRightImage = null;
            BunifuButton1.onHoverState = StateProperties69;
            StateProperties70.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties70.BorderRadius = 25;
            StateProperties70.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties70.BorderThickness = 1;
            StateProperties70.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties70.ForeColor = Color.White;
            StateProperties70.IconLeftImage = null;
            StateProperties70.IconRightImage = null;
            BunifuButton1.OnPressedState = StateProperties70;
            BunifuButton1.Size = new Size(29, 29);
            BunifuButton1.TabIndex = 243;
            BunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            BunifuButton1.TextMarginLeft = 0;
            BunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Semibold", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label9.Location = new Point(406, 351);
            Label9.Name = "Label9";
            Label9.Size = new Size(136, 20);
            Label9.TabIndex = 242;
            Label9.Text = "Pick Release Order";
            // 
            // cboRelOrder
            // 
            _cboRelOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboRelOrder.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboRelOrder.FormattingEnabled = true;
            _cboRelOrder.Location = new Point(384, 424);
            _cboRelOrder.Name = "_cboRelOrder";
            _cboRelOrder.Size = new Size(208, 26);
            _cboRelOrder.TabIndex = 244;
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.Right;
            Label10.AutoSize = true;
            Label10.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.Location = new Point(384, 403);
            Label10.Name = "Label10";
            Label10.Size = new Size(108, 18);
            Label10.TabIndex = 245;
            Label10.Text = "Release Order:";
            Label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BunifuButton2
            // 
            BunifuButton2.AllowToggling = false;
            BunifuButton2.AnimationSpeed = 200;
            BunifuButton2.AutoGenerateColors = false;
            BunifuButton2.BackColor = Color.Transparent;
            BunifuButton2.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton2.BackgroundImage = (Image)resources.GetObject("BunifuButton2.BackgroundImage");
            BunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            BunifuButton2.ButtonText = "1.1";
            BunifuButton2.ButtonTextMarginLeft = 0;
            BunifuButton2.ColorContrastOnClick = 45;
            BunifuButton2.ColorContrastOnHover = 45;
            BunifuButton2.Cursor = Cursors.Hand;
            BorderEdges36.BottomLeft = true;
            BorderEdges36.BottomRight = true;
            BorderEdges36.TopLeft = true;
            BorderEdges36.TopRight = true;
            BunifuButton2.CustomizableEdges = BorderEdges36;
            BunifuButton2.DialogResult = DialogResult.None;
            BunifuButton2.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton2.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton2.DisabledForecolor = Color.White;
            BunifuButton2.Enabled = false;
            BunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            BunifuButton2.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuButton2.ForeColor = Color.White;
            BunifuButton2.IconLeftCursor = Cursors.Hand;
            BunifuButton2.IconMarginLeft = 8;
            BunifuButton2.IconPadding = 8;
            BunifuButton2.IconRightCursor = Cursors.Hand;
            BunifuButton2.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton2.IdleBorderRadius = 25;
            BunifuButton2.IdleBorderThickness = 1;
            BunifuButton2.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuButton2.IdleIconLeftImage = null;
            BunifuButton2.IdleIconRightImage = null;
            BunifuButton2.IndicateFocus = true;
            BunifuButton2.Location = new Point(15, 3);
            BunifuButton2.Name = "BunifuButton2";
            StateProperties71.BorderColor = Color.Coral;
            StateProperties71.BorderRadius = 25;
            StateProperties71.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties71.BorderThickness = 1;
            StateProperties71.FillColor = Color.Coral;
            StateProperties71.ForeColor = Color.White;
            StateProperties71.IconLeftImage = null;
            StateProperties71.IconRightImage = null;
            BunifuButton2.onHoverState = StateProperties71;
            StateProperties72.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties72.BorderRadius = 25;
            StateProperties72.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties72.BorderThickness = 1;
            StateProperties72.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties72.ForeColor = Color.White;
            StateProperties72.IconLeftImage = null;
            StateProperties72.IconRightImage = null;
            BunifuButton2.OnPressedState = StateProperties72;
            BunifuButton2.Size = new Size(41, 29);
            BunifuButton2.TabIndex = 247;
            BunifuButton2.TextAlign = ContentAlignment.MiddleCenter;
            BunifuButton2.TextMarginLeft = 0;
            BunifuButton2.UseDefaultRadiusAndThickness = true;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Segoe UI Semibold", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label13.Location = new Point(60, 8);
            Label13.Name = "Label13";
            Label13.Size = new Size(142, 20);
            Label13.TabIndex = 246;
            Label13.Text = "Add Follow up date";
            // 
            // Label25
            // 
            Label25.Anchor = AnchorStyles.Right;
            Label25.AutoSize = true;
            Label25.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label25.Location = new Point(37, 37);
            Label25.Name = "Label25";
            Label25.Size = new Size(136, 18);
            Label25.TabIndex = 210;
            Label25.Text = "Follow up due date:";
            Label25.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpFollowUpDate
            // 
            dtpFollowUpDate.CustomFormat = "  dd-MMM-yyyy";
            dtpFollowUpDate.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            dtpFollowUpDate.Format = DateTimePickerFormat.Custom;
            dtpFollowUpDate.Location = new Point(174, 33);
            dtpFollowUpDate.Name = "dtpFollowUpDate";
            dtpFollowUpDate.Size = new Size(161, 26);
            dtpFollowUpDate.TabIndex = 249;
            // 
            // pnlFollowUp
            // 
            pnlFollowUp.Controls.Add(Label19);
            pnlFollowUp.Controls.Add(_nudFlwUpQtyCans);
            pnlFollowUp.Controls.Add(Label25);
            pnlFollowUp.Controls.Add(BunifuButton2);
            pnlFollowUp.Controls.Add(dtpFollowUpDate);
            pnlFollowUp.Controls.Add(Label13);
            pnlFollowUp.Location = new Point(425, 91);
            pnlFollowUp.Name = "pnlFollowUp";
            pnlFollowUp.Size = new Size(338, 111);
            pnlFollowUp.TabIndex = 250;
            // 
            // Label19
            // 
            Label19.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label19.Location = new Point(35, 65);
            Label19.Name = "Label19";
            Label19.Size = new Size(136, 42);
            Label19.TabIndex = 275;
            Label19.Text = "Quantity to be followed up:";
            Label19.TextAlign = ContentAlignment.TopRight;
            // 
            // nudFlwUpQtyCans
            // 
            _nudFlwUpQtyCans.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _nudFlwUpQtyCans.Location = new Point(173, 69);
            _nudFlwUpQtyCans.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            _nudFlwUpQtyCans.Name = "_nudFlwUpQtyCans";
            _nudFlwUpQtyCans.Size = new Size(105, 27);
            _nudFlwUpQtyCans.TabIndex = 274;
            _nudFlwUpQtyCans.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmUpdateReqStatus
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1119, 735);
            Controls.Add(pnlFollowUp);
            Controls.Add(Label10);
            Controls.Add(_cboRelOrder);
            Controls.Add(BunifuButton1);
            Controls.Add(Label9);
            Controls.Add(PictureBox2);
            Controls.Add(_btnAddNewPUDO);
            Controls.Add(_btnRmPickUpDropOff);
            Controls.Add(_btnRmRel);
            Controls.Add(Panel2);
            Controls.Add(PictureBox1);
            Controls.Add(BunifuButton6);
            Controls.Add(BunifuButton5);
            Controls.Add(BunifuButton4);
            Controls.Add(Label16);
            Controls.Add(ShapedPanel1);
            Controls.Add(Label15);
            Controls.Add(Label14);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(Label3);
            Controls.Add(_btnManageBal);
            Controls.Add(_btnNewRequest);
            Controls.Add(ShapedPanel3);
            Controls.Add(Label11);
            Controls.Add(buttonsPanel);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUpdateReqStatus";
            buttonsPanel.ResumeLayout(false);
            ShapedPanel3.ResumeLayout(false);
            ShapedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvRelease).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWReleaseBindingSource).EndInit();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ShapedPanel1.ResumeLayout(false);
            ShapedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPickUpDropOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWRelOrderPickUpDropOffLocationBindingSource).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Panel2.ResumeLayout(false);
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            pnlFollowUp.ResumeLayout(false);
            pnlFollowUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_nudFlwUpQtyCans).EndInit();
            Shown += new EventHandler(FrmUpdateReqStatus_Shown);
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

        internal Label Label8;
        internal TableLayoutPanel buttonsPanel;
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
                    _btnCancel.Click -= closeFlatButton_Click;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += closeFlatButton_Click;
                }
            }
        }

        internal CustomizedControlsLibrary.ShapedPanel ShapedPanel3;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvRelease;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvRelease
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvRelease;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvRelease != null)
                {
                    _dgvRelease.SelectionChanged -= dgvRelease_SelectionChanged;
                    _dgvRelease.DoubleClick -= dgvRelease_DoubleClick;
                }

                _dgvRelease = value;
                if (_dgvRelease != null)
                {
                    _dgvRelease.SelectionChanged += dgvRelease_SelectionChanged;
                    _dgvRelease.DoubleClick += dgvRelease_DoubleClick;
                }
            }
        }

        internal Label Label7;
        internal Label Label11;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnNewRequest;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNewRequest
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnNewRequest;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnNewRequest != null)
                {
                    _btnNewRequest.Click -= btnNewRequest_Click;
                }

                _btnNewRequest = value;
                if (_btnNewRequest != null)
                {
                    _btnNewRequest.Click += btnNewRequest_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnManageBal;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnManageBal
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnManageBal;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnManageBal != null)
                {
                    _btnManageBal.Click -= btnManageBal_Click;
                }

                _btnManageBal = value;
                if (_btnManageBal != null)
                {
                    _btnManageBal.Click += btnManageBal_Click;
                }
            }
        }

        internal Label Label1;
        private ComboBox _cbStatus;

        internal ComboBox cbStatus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cbStatus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cbStatus != null)
                {
                    _cbStatus.SelectedIndexChanged -= cbStatus_SelectedIndexChanged;
                }

                _cbStatus = value;
                if (_cbStatus != null)
                {
                    _cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
                }
            }
        }

        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Label lblReqDate;
        internal Label lblSize;
        internal Label lblSSLineName;
        internal Label Label14;
        internal Label Label15;
        internal Label Label16;
        internal CustomizedControlsLibrary.ShapedPanel ShapedPanel1;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvPickUpDropOff;
        internal Label Label18;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton4;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton5;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton6;
        internal Label Label17;
        internal Label lblTotalReq;
        internal Panel Panel1;
        internal PictureBox PictureBox1;
        internal Panel Panel2;
        internal Label Label22;
        internal TableLayoutPanel TableLayoutPanel2;
        internal Label Label24;
        internal Label Label23;
        internal Label Label12;
        internal Label Label6;
        internal Label Label26;
        internal Label lblAddedRel;
        internal Label lblBalRelease;
        internal Label lblAddedPickUpDropOff;
        internal Label lblBalPickUpDropOff;
        internal Label lblRelType;
        internal Label Label33;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnRmRel;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRmRel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRmRel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnRmRel != null)
                {
                    _btnRmRel.Click -= btnRmRel_Click;
                }

                _btnRmRel = value;
                if (_btnRmRel != null)
                {
                    _btnRmRel.Click += btnRmRel_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnRmPickUpDropOff;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRmPickUpDropOff
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRmPickUpDropOff;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnRmPickUpDropOff != null)
                {
                    _btnRmPickUpDropOff.Click -= btnRmPickUpDropOff_Click;
                }

                _btnRmPickUpDropOff = value;
                if (_btnRmPickUpDropOff != null)
                {
                    _btnRmPickUpDropOff.Click += btnRmPickUpDropOff_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddNewPUDO;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddNewPUDO
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddNewPUDO;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddNewPUDO != null)
                {
                    _btnAddNewPUDO.Click -= btnAddNewPUDO_Click;
                }

                _btnAddNewPUDO = value;
                if (_btnAddNewPUDO != null)
                {
                    _btnAddNewPUDO.Click += btnAddNewPUDO_Click;
                }
            }
        }

        internal PictureBox PictureBox2;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton1;
        internal Label Label9;
        private ComboBox _cboRelOrder;

        internal ComboBox cboRelOrder
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboRelOrder;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboRelOrder != null)
                {
                    _cboRelOrder.SelectedIndexChanged -= cboRelOrder_SelectedIndexChanged;
                }

                _cboRelOrder = value;
                if (_cboRelOrder != null)
                {
                    _cboRelOrder.SelectedIndexChanged += cboRelOrder_SelectedIndexChanged;
                }
            }
        }

        internal Label Label10;
        internal BindingSource VWReleaseBindingSource;
        internal BindingSource VWRelOrderPickUpDropOffLocationBindingSource;
        internal DataGridViewTextBoxColumn PickUpTerminalNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn YardNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn QtyPickUpDropOffDataGridViewTextBoxColumn;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton2;
        internal Label Label13;
        internal Label Label25;
        internal DateTimePicker dtpFollowUpDate;
        internal Panel pnlFollowUp;
        internal DataGridViewTextBoxColumn ReleaseNumber;
        internal DataGridViewTextBoxColumn TotalQtyAccepted;
        internal Label Label19;
        private NumericUpDown _nudFlwUpQtyCans;

        internal NumericUpDown nudFlwUpQtyCans
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _nudFlwUpQtyCans;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudFlwUpQtyCans != null)
                {
                    _nudFlwUpQtyCans.ValueChanged -= nudFlwUpQtyCans_ValueChanged;
                }

                _nudFlwUpQtyCans = value;
                if (_nudFlwUpQtyCans != null)
                {
                    _nudFlwUpQtyCans.ValueChanged += nudFlwUpQtyCans_ValueChanged;
                }
            }
        }
    }
}