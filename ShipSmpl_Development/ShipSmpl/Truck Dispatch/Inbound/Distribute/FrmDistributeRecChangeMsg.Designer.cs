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
    public partial class FrmDistributeRecChangeMsg : Form
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
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDistributeRecChangeMsg));
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            buttonsPanel = new TableLayoutPanel();
            _btnComplete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnComplete.Click += new EventHandler(btnComplete_Click);
            _btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancel.Click += new EventHandler(BunifuButton1_Click);
            lblTitle = new Label();
            _BunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _BunifuButton1.Click += new EventHandler(BunifuButton1_Click);
            ShapedPanel2 = new CustomizedControlsLibrary.ShapedPanel();
            dgvPUDODates = new Bunifu.UI.WinForms.BunifuDataGridView();
            FromDate = new DataGridViewTextBoxColumn();
            ToDate = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            VWRelDistChangeSchRequestedBindingSource = new BindingSource(components);
            ShapedPanel1 = new CustomizedControlsLibrary.ShapedPanel();
            _dgvProposedChange = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvProposedChange.RowsAdded += new DataGridViewRowsAddedEventHandler(dgvProposedChange_RowsAdded);
            _dgvProposedChange.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dgvProposedChange_RowPostPaint);
            _dgvProposedChange.CellEndEdit += new DataGridViewCellEventHandler(dgvProposedChange_CellEndEdit);
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Label1 = new Label();
            tbNotes = new BunifuTextBox();
            Label3 = new Label();
            Label2 = new Label();
            Label4 = new Label();
            lblCarrierNotes = new CustomizedControlsLibrary.ShapedLabel();
            Label5 = new Label();
            cboDistReqStatus = new ComboBox();
            buttonsPanel.SuspendLayout();
            ShapedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPUDODates).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWRelDistChangeSchRequestedBindingSource).BeginInit();
            ShapedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvProposedChange).BeginInit();
            SuspendLayout();
            // 
            // BunifuElipse1
            // 
            BunifuElipse1.ElipseRadius = 10;
            BunifuElipse1.TargetControl = this;
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.48454f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.51546f));
            buttonsPanel.Controls.Add(_btnComplete, 0, 0);
            buttonsPanel.Controls.Add(_btnCancel, 1, 0);
            buttonsPanel.Location = new Point(236, 441);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(194, 31);
            buttonsPanel.TabIndex = 233;
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
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnComplete.CustomizableEdges = BorderEdges2;
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
            _btnComplete.Size = new Size(87, 25);
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
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _btnCancel.CustomizableEdges = BorderEdges3;
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
            _btnCancel.Location = new Point(102, 3);
            _btnCancel.Name = "_btnCancel";
            StateProperties9.BorderColor = Color.DarkGray;
            StateProperties9.BorderRadius = 3;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.DarkGray;
            StateProperties9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            _btnCancel.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties10.BorderRadius = 3;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.White;
            StateProperties10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            _btnCancel.OnPressedState = StateProperties10;
            _btnCancel.Size = new Size(89, 25);
            _btnCancel.TabIndex = 137;
            _btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancel.TextMarginLeft = 0;
            _btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTitle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(225, 25);
            lblTitle.TabIndex = 237;
            lblTitle.Text = "Schedule change request";
            // 
            // BunifuButton1
            // 
            _BunifuButton1.AllowToggling = false;
            _BunifuButton1.AnimationSpeed = 200;
            _BunifuButton1.AutoGenerateColors = false;
            _BunifuButton1.BackColor = Color.Transparent;
            _BunifuButton1.BackColor1 = Color.White;
            _BunifuButton1.BackgroundImage = (Image)resources.GetObject("BunifuButton1.BackgroundImage");
            _BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _BunifuButton1.ButtonText = "🗙";
            _BunifuButton1.ButtonTextMarginLeft = 0;
            _BunifuButton1.ColorContrastOnClick = 45;
            _BunifuButton1.ColorContrastOnHover = 45;
            _BunifuButton1.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _BunifuButton1.CustomizableEdges = BorderEdges1;
            _BunifuButton1.DialogResult = DialogResult.None;
            _BunifuButton1.DisabledBorderColor = Color.Empty;
            _BunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _BunifuButton1.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _BunifuButton1.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _BunifuButton1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _BunifuButton1.IconLeftCursor = Cursors.Hand;
            _BunifuButton1.IconMarginLeft = 11;
            _BunifuButton1.IconPadding = 10;
            _BunifuButton1.IconRightCursor = Cursors.Hand;
            _BunifuButton1.IdleBorderColor = Color.White;
            _BunifuButton1.IdleBorderRadius = 20;
            _BunifuButton1.IdleBorderThickness = 1;
            _BunifuButton1.IdleFillColor = Color.White;
            _BunifuButton1.IdleIconLeftImage = null;
            _BunifuButton1.IdleIconRightImage = null;
            _BunifuButton1.IndicateFocus = true;
            _BunifuButton1.Location = new Point(674, 0);
            _BunifuButton1.Name = "_BunifuButton1";
            StateProperties5.BorderColor = Color.Silver;
            StateProperties5.BorderRadius = 20;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.Silver;
            StateProperties5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _BunifuButton1.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Silver;
            StateProperties6.BorderRadius = 20;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Silver;
            StateProperties6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _BunifuButton1.OnPressedState = StateProperties6;
            _BunifuButton1.Size = new Size(25, 25);
            _BunifuButton1.TabIndex = 238;
            _BunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            _BunifuButton1.TextMarginLeft = 0;
            _BunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // ShapedPanel2
            // 
            ShapedPanel2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ShapedPanel2.BorderColor = Color.Gray;
            ShapedPanel2.Controls.Add(dgvPUDODates);
            ShapedPanel2.Edge = 2;
            ShapedPanel2.Location = new Point(25, 142);
            ShapedPanel2.Name = "ShapedPanel2";
            ShapedPanel2.Padding = new Padding(1);
            ShapedPanel2.Size = new Size(263, 162);
            ShapedPanel2.TabIndex = 239;
            // 
            // dgvPUDODates
            // 
            dgvPUDODates.AllowCustomTheming = true;
            dgvPUDODates.AllowUserToAddRows = false;
            dgvPUDODates.AllowUserToDeleteRows = false;
            dgvPUDODates.AllowUserToOrderColumns = true;
            dgvPUDODates.AllowUserToResizeRows = false;
            DataGridViewCellStyle6.BackColor = SystemColors.Control;
            DataGridViewCellStyle6.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle6.ForeColor = Color.Black;
            DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvPUDODates.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6;
            dgvPUDODates.AutoGenerateColumns = false;
            dgvPUDODates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPUDODates.BackgroundColor = Color.White;
            dgvPUDODates.BorderStyle = BorderStyle.None;
            dgvPUDODates.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvPUDODates.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvPUDODates.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle7.BackColor = Color.Gray;
            DataGridViewCellStyle7.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            DataGridViewCellStyle7.ForeColor = Color.White;
            DataGridViewCellStyle7.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPUDODates.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7;
            dgvPUDODates.ColumnHeadersHeight = 28;
            dgvPUDODates.Columns.AddRange(new DataGridViewColumn[] { FromDate, ToDate, DataGridViewTextBoxColumn1 });
            dgvPUDODates.CurrentTheme.AlternatingRowsStyle.BackColor = SystemColors.Control;
            dgvPUDODates.CurrentTheme.AlternatingRowsStyle.Font = new Font("Arial", 9.5f);
            dgvPUDODates.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvPUDODates.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            dgvPUDODates.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvPUDODates.CurrentTheme.BackColor = Color.White;
            dgvPUDODates.CurrentTheme.GridColor = Color.Gainsboro;
            dgvPUDODates.CurrentTheme.HeaderStyle.BackColor = Color.Gray;
            dgvPUDODates.CurrentTheme.HeaderStyle.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            dgvPUDODates.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvPUDODates.CurrentTheme.Name = null;
            dgvPUDODates.CurrentTheme.RowsStyle.BackColor = Color.White;
            dgvPUDODates.CurrentTheme.RowsStyle.Font = new Font("Arial", 9.5f);
            dgvPUDODates.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvPUDODates.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            dgvPUDODates.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dgvPUDODates.DataSource = VWRelDistChangeSchRequestedBindingSource;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle8.BackColor = Color.White;
            DataGridViewCellStyle8.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle8.ForeColor = Color.Black;
            DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            DataGridViewCellStyle8.SelectionForeColor = Color.Black;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPUDODates.DefaultCellStyle = DataGridViewCellStyle8;
            dgvPUDODates.Dock = DockStyle.Fill;
            dgvPUDODates.EnableHeadersVisualStyles = false;
            dgvPUDODates.GridColor = Color.Gainsboro;
            dgvPUDODates.HeaderBackColor = Color.Gray;
            dgvPUDODates.HeaderBgColor = Color.Empty;
            dgvPUDODates.HeaderForeColor = Color.White;
            dgvPUDODates.Location = new Point(1, 1);
            dgvPUDODates.MultiSelect = false;
            dgvPUDODates.Name = "dgvPUDODates";
            dgvPUDODates.ReadOnly = true;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            DataGridViewCellStyle9.SelectionForeColor = Color.Black;
            DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvPUDODates.RowHeadersDefaultCellStyle = DataGridViewCellStyle9;
            dgvPUDODates.RowHeadersVisible = false;
            dgvPUDODates.RowHeadersWidth = 28;
            DataGridViewCellStyle10.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            DataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dgvPUDODates.RowsDefaultCellStyle = DataGridViewCellStyle10;
            dgvPUDODates.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.0f);
            dgvPUDODates.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvPUDODates.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            dgvPUDODates.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvPUDODates.RowTemplate.Height = 27;
            dgvPUDODates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPUDODates.Size = new Size(261, 160);
            dgvPUDODates.TabIndex = 141;
            dgvPUDODates.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // FromDate
            // 
            FromDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FromDate.DataPropertyName = "OrigFromDate";
            FromDate.HeaderText = "From Date";
            FromDate.Name = "FromDate";
            FromDate.ReadOnly = true;
            FromDate.Width = 95;
            // 
            // ToDate
            // 
            ToDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ToDate.DataPropertyName = "OrigToDate";
            ToDate.HeaderText = "To Date";
            ToDate.Name = "ToDate";
            ToDate.ReadOnly = true;
            ToDate.Width = 95;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewTextBoxColumn1.DataPropertyName = "OrigQtyRequested";
            DataGridViewTextBoxColumn1.HeaderText = "Qty Req";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            DataGridViewTextBoxColumn1.Width = 70;
            // 
            // ShapedPanel1
            // 
            ShapedPanel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ShapedPanel1.BorderColor = Color.Gray;
            ShapedPanel1.Controls.Add(_dgvProposedChange);
            ShapedPanel1.Edge = 2;
            ShapedPanel1.Location = new Point(285, 142);
            ShapedPanel1.Name = "ShapedPanel1";
            ShapedPanel1.Padding = new Padding(1);
            ShapedPanel1.Size = new Size(384, 162);
            ShapedPanel1.TabIndex = 240;
            // 
            // dgvProposedChange
            // 
            _dgvProposedChange.AllowCustomTheming = true;
            _dgvProposedChange.AllowUserToAddRows = false;
            _dgvProposedChange.AllowUserToDeleteRows = false;
            _dgvProposedChange.AllowUserToOrderColumns = true;
            _dgvProposedChange.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = SystemColors.Control;
            DataGridViewCellStyle1.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvProposedChange.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvProposedChange.AutoGenerateColumns = false;
            _dgvProposedChange.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvProposedChange.BackgroundColor = Color.White;
            _dgvProposedChange.BorderStyle = BorderStyle.None;
            _dgvProposedChange.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            _dgvProposedChange.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            _dgvProposedChange.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle2.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.DarkSlateGray;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvProposedChange.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvProposedChange.ColumnHeadersHeight = 28;
            _dgvProposedChange.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4 });
            _dgvProposedChange.CurrentTheme.AlternatingRowsStyle.BackColor = SystemColors.Control;
            _dgvProposedChange.CurrentTheme.AlternatingRowsStyle.Font = new Font("Arial", 9.5f);
            _dgvProposedChange.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvProposedChange.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            _dgvProposedChange.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvProposedChange.CurrentTheme.BackColor = Color.White;
            _dgvProposedChange.CurrentTheme.GridColor = Color.Gainsboro;
            _dgvProposedChange.CurrentTheme.HeaderStyle.BackColor = Color.DarkSlateGray;
            _dgvProposedChange.CurrentTheme.HeaderStyle.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            _dgvProposedChange.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvProposedChange.CurrentTheme.Name = null;
            _dgvProposedChange.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgvProposedChange.CurrentTheme.RowsStyle.Font = new Font("Arial", 9.5f);
            _dgvProposedChange.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvProposedChange.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            _dgvProposedChange.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvProposedChange.DataSource = VWRelDistChangeSchRequestedBindingSource;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.White;
            DataGridViewCellStyle3.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvProposedChange.DefaultCellStyle = DataGridViewCellStyle3;
            _dgvProposedChange.Dock = DockStyle.Fill;
            _dgvProposedChange.EnableHeadersVisualStyles = false;
            _dgvProposedChange.GridColor = Color.Gainsboro;
            _dgvProposedChange.HeaderBackColor = Color.DarkSlateGray;
            _dgvProposedChange.HeaderBgColor = Color.Empty;
            _dgvProposedChange.HeaderForeColor = Color.White;
            _dgvProposedChange.Location = new Point(1, 1);
            _dgvProposedChange.MultiSelect = false;
            _dgvProposedChange.Name = "_dgvProposedChange";
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            DataGridViewCellStyle4.SelectionForeColor = Color.Black;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            _dgvProposedChange.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
            _dgvProposedChange.RowHeadersVisible = false;
            _dgvProposedChange.RowHeadersWidth = 28;
            DataGridViewCellStyle5.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle5.ForeColor = Color.Black;
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            DataGridViewCellStyle5.SelectionForeColor = Color.Black;
            _dgvProposedChange.RowsDefaultCellStyle = DataGridViewCellStyle5;
            _dgvProposedChange.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.0f);
            _dgvProposedChange.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            _dgvProposedChange.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            _dgvProposedChange.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            _dgvProposedChange.RowTemplate.Height = 27;
            _dgvProposedChange.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvProposedChange.Size = new Size(382, 160);
            _dgvProposedChange.TabIndex = 141;
            _dgvProposedChange.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewTextBoxColumn2.DataPropertyName = "FromDateChange";
            DataGridViewTextBoxColumn2.HeaderText = "From Date";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            DataGridViewTextBoxColumn2.Width = 95;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewTextBoxColumn3.DataPropertyName = "ToDateChange";
            DataGridViewTextBoxColumn3.HeaderText = "To Date";
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            DataGridViewTextBoxColumn3.Width = 95;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewTextBoxColumn4.DataPropertyName = "QtyRequestdChange";
            DataGridViewTextBoxColumn4.HeaderText = "Qty Req";
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.ReadOnly = true;
            DataGridViewTextBoxColumn4.Width = 70;
            // 
            // Label1
            // 
            Label1.BackColor = Color.Gray;
            Label1.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(25, 120);
            Label1.Name = "Label1";
            Label1.Size = new Size(262, 32);
            Label1.TabIndex = 241;
            Label1.Text = "Original:";
            Label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbNotes
            // 
            tbNotes.AcceptsReturn = false;
            tbNotes.AcceptsTab = false;
            tbNotes.AnimationSpeed = 200;
            tbNotes.AutoCompleteMode = AutoCompleteMode.None;
            tbNotes.AutoCompleteSource = AutoCompleteSource.None;
            tbNotes.BackColor = Color.Transparent;
            tbNotes.BackgroundImage = (Image)resources.GetObject("tbNotes.BackgroundImage");
            tbNotes.BorderColorActive = Color.DodgerBlue;
            tbNotes.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            tbNotes.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            tbNotes.BorderColorIdle = Color.Silver;
            tbNotes.BorderRadius = 1;
            tbNotes.BorderThickness = 1;
            tbNotes.CharacterCasing = CharacterCasing.Normal;
            tbNotes.Cursor = Cursors.IBeam;
            tbNotes.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            tbNotes.DefaultText = "";
            tbNotes.FillColor = Color.White;
            tbNotes.HideSelection = true;
            tbNotes.IconLeft = null;
            tbNotes.IconLeftCursor = Cursors.IBeam;
            tbNotes.IconPadding = 10;
            tbNotes.IconRight = null;
            tbNotes.IconRightCursor = Cursors.IBeam;
            tbNotes.Lines = new string[0];
            tbNotes.Location = new Point(340, 329);
            tbNotes.MaxLength = 32767;
            tbNotes.MinimumSize = new Size(100, 35);
            tbNotes.Modified = false;
            tbNotes.Multiline = false;
            tbNotes.Name = "tbNotes";
            StateProperties1.BorderColor = Color.DodgerBlue;
            StateProperties1.FillColor = Color.Empty;
            StateProperties1.ForeColor = Color.Empty;
            StateProperties1.PlaceholderForeColor = Color.Empty;
            tbNotes.OnActiveState = StateProperties1;
            StateProperties2.BorderColor = Color.Empty;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.Empty;
            StateProperties2.PlaceholderForeColor = Color.Silver;
            tbNotes.OnDisabledState = StateProperties2;
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            tbNotes.OnHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Silver;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Empty;
            StateProperties4.PlaceholderForeColor = Color.Empty;
            tbNotes.OnIdleState = StateProperties4;
            tbNotes.PasswordChar = '\0';
            tbNotes.PlaceholderForeColor = Color.Silver;
            tbNotes.PlaceholderText = "Enter text";
            tbNotes.ReadOnly = false;
            tbNotes.ScrollBars = ScrollBars.None;
            tbNotes.SelectedText = "";
            tbNotes.SelectionLength = 0;
            tbNotes.SelectionStart = 0;
            tbNotes.ShortcutsEnabled = true;
            tbNotes.Size = new Size(282, 80);
            tbNotes.Style = _Style.Bunifu;
            tbNotes.TabIndex = 243;
            tbNotes.TextAlign = HorizontalAlignment.Left;
            tbNotes.TextMarginBottom = 0;
            tbNotes.TextMarginLeft = 5;
            tbNotes.TextMarginTop = 0;
            tbNotes.TextPlaceholder = "Enter text";
            tbNotes.UseSystemPasswordChar = false;
            tbNotes.WordWrap = true;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI Semibold", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(302, 309);
            Label3.Name = "Label3";
            Label3.Size = new Size(110, 19);
            Label3.TabIndex = 244;
            Label3.Text = "Add extra notes:";
            // 
            // Label2
            // 
            Label2.BackColor = Color.DarkSlateGray;
            Label2.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(286, 120);
            Label2.Name = "Label2";
            Label2.Size = new Size(383, 32);
            Label2.TabIndex = 245;
            Label2.Text = "Proposed:";
            Label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI Semibold", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label4.Location = new Point(17, 305);
            Label4.Name = "Label4";
            Label4.Size = new Size(99, 19);
            Label4.TabIndex = 246;
            Label4.Text = "Carrier Notes: ";
            // 
            // lblCarrierNotes
            // 
            lblCarrierNotes.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            lblCarrierNotes.BorderColor = Color.White;
            lblCarrierNotes.Edge = 20;
            lblCarrierNotes.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCarrierNotes.Location = new Point(26, 329);
            lblCarrierNotes.Name = "lblCarrierNotes";
            lblCarrierNotes.Padding = new Padding(5);
            lblCarrierNotes.Size = new Size(261, 80);
            lblCarrierNotes.TabIndex = 247;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(94, 72);
            Label5.Name = "Label5";
            Label5.Size = new Size(155, 22);
            Label5.TabIndex = 290;
            Label5.Text = "Dist. Req. Status: ";
            // 
            // cboDistReqStatus
            // 
            cboDistReqStatus.AutoCompleteMode = AutoCompleteMode.Append;
            cboDistReqStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboDistReqStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistReqStatus.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboDistReqStatus.FormattingEnabled = true;
            cboDistReqStatus.Items.AddRange(new object[] { "DECLINED" });
            cboDistReqStatus.Location = new Point(250, 66);
            cboDistReqStatus.Name = "cboDistReqStatus";
            cboDistReqStatus.Size = new Size(269, 32);
            cboDistReqStatus.TabIndex = 289;
            // 
            // FrmDistributeRecChangeMsg
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(698, 500);
            Controls.Add(Label5);
            Controls.Add(cboDistReqStatus);
            Controls.Add(lblCarrierNotes);
            Controls.Add(Label4);
            Controls.Add(ShapedPanel1);
            Controls.Add(Label2);
            Controls.Add(ShapedPanel2);
            Controls.Add(Label3);
            Controls.Add(tbNotes);
            Controls.Add(Label1);
            Controls.Add(_BunifuButton1);
            Controls.Add(lblTitle);
            Controls.Add(buttonsPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDistributeRecChangeMsg";
            Text = "FrmDistributeRecChangeMsg";
            buttonsPanel.ResumeLayout(false);
            ShapedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPUDODates).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWRelDistChangeSchRequestedBindingSource).EndInit();
            ShapedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvProposedChange).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
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
                    _btnCancel.Click -= BunifuButton1_Click;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += BunifuButton1_Click;
                }
            }
        }

        internal Label lblTitle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _BunifuButton1;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuButton1 != null)
                {
                    _BunifuButton1.Click -= BunifuButton1_Click;
                }

                _BunifuButton1 = value;
                if (_BunifuButton1 != null)
                {
                    _BunifuButton1.Click += BunifuButton1_Click;
                }
            }
        }

        internal CustomizedControlsLibrary.ShapedPanel ShapedPanel2;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvPUDODates;
        internal Label Label1;
        internal CustomizedControlsLibrary.ShapedPanel ShapedPanel1;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvProposedChange;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvProposedChange
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvProposedChange;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvProposedChange != null)
                {
                    _dgvProposedChange.RowsAdded -= dgvProposedChange_RowsAdded;
                    _dgvProposedChange.RowPostPaint -= dgvProposedChange_RowPostPaint;
                    _dgvProposedChange.CellEndEdit -= dgvProposedChange_CellEndEdit;
                }

                _dgvProposedChange = value;
                if (_dgvProposedChange != null)
                {
                    _dgvProposedChange.RowsAdded += dgvProposedChange_RowsAdded;
                    _dgvProposedChange.RowPostPaint += dgvProposedChange_RowPostPaint;
                    _dgvProposedChange.CellEndEdit += dgvProposedChange_CellEndEdit;
                }
            }
        }

        internal BindingSource VWRelDistChangeSchRequestedBindingSource;
        internal BunifuTextBox tbNotes;
        internal Label Label3;
        internal Label Label2;
        internal CustomizedControlsLibrary.ShapedLabel lblCarrierNotes;
        internal Label Label4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn FromDate;
        internal DataGridViewTextBoxColumn ToDate;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal Label Label5;
        internal ComboBox cboDistReqStatus;
    }
}