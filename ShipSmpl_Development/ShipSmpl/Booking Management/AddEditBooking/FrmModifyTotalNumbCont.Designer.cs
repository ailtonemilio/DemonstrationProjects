using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmModifyTotalNumbCont : Form
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
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifyTotalNumbCont));
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            lbltotalNumber = new Label();
            Label6 = new Label();
            Label5 = new Label();
            lblTotaltoBeAsgn = new Label();
            lblminiBkgNumber = new Label();
            labelTotalSomething = new Label();
            Panel3 = new Panel();
            _nucTotal = new NumericUpDown();
            _nucTotal.ValueChanged += new EventHandler(nucTotal_ValueChanged);
            Label1 = new Label();
            Label2 = new Label();
            lblTitle = new Label();
            _dgvMiniBks = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvMiniBks.SelectionChanged += new EventHandler(dgvMiniBks_SelectionChanged);
            _btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancel.Click += new EventHandler(closeLabel_Click);
            _btnSaveMb = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSaveMb.Click += new EventHandler(btnSaveMb_Click);
            Panel2 = new Panel();
            Label12 = new Label();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label3 = new Label();
            lblContInMb = new Label();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_nucTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dgvMiniBks).BeginInit();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbltotalNumber
            // 
            lbltotalNumber.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lbltotalNumber.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lbltotalNumber.Location = new Point(689, 54);
            lbltotalNumber.Name = "lbltotalNumber";
            lbltotalNumber.Size = new Size(93, 25);
            lbltotalNumber.TabIndex = 210;
            lbltotalNumber.Text = "500";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(509, 102);
            Label6.Name = "Label6";
            Label6.Size = new Size(216, 20);
            Label6.TabIndex = 209;
            Label6.Text = "_______________________";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label5.Location = new Point(17, 15);
            Label5.Name = "Label5";
            Label5.Size = new Size(126, 20);
            Label5.TabIndex = 194;
            Label5.Text = "Total containers:";
            // 
            // lblTotaltoBeAsgn
            // 
            lblTotaltoBeAsgn.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotaltoBeAsgn.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblTotaltoBeAsgn.Location = new Point(689, 128);
            lblTotaltoBeAsgn.Name = "lblTotaltoBeAsgn";
            lblTotaltoBeAsgn.Size = new Size(96, 25);
            lblTotaltoBeAsgn.TabIndex = 205;
            lblTotaltoBeAsgn.Text = "200";
            // 
            // lblminiBkgNumber
            // 
            lblminiBkgNumber.AutoSize = true;
            lblminiBkgNumber.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblminiBkgNumber.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblminiBkgNumber.Location = new Point(340, 221);
            lblminiBkgNumber.Name = "lblminiBkgNumber";
            lblminiBkgNumber.Size = new Size(133, 20);
            lblminiBkgNumber.TabIndex = 207;
            lblminiBkgNumber.Text = "MINIBOOKNG(A)";
            // 
            // labelTotalSomething
            // 
            labelTotalSomething.AutoSize = true;
            labelTotalSomething.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            labelTotalSomething.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            labelTotalSomething.Location = new Point(509, 56);
            labelTotalSomething.Name = "labelTotalSomething";
            labelTotalSomething.Size = new Size(129, 20);
            labelTotalSomething.TabIndex = 211;
            labelTotalSomething.Text = "Total Containers:";
            // 
            // Panel3
            // 
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(Label5);
            Panel3.Controls.Add(_nucTotal);
            Panel3.Location = new Point(336, 248);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(193, 96);
            Panel3.TabIndex = 208;
            // 
            // nucTotal
            // 
            _nucTotal.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _nucTotal.Location = new Point(30, 45);
            _nucTotal.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            _nucTotal.Name = "_nucTotal";
            _nucTotal.Size = new Size(120, 31);
            _nucTotal.TabIndex = 187;
            _nucTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(509, 129);
            Label1.Name = "Label1";
            Label1.Size = new Size(145, 20);
            Label1.TabIndex = 206;
            Label1.Text = "Extra containers:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(12, 122);
            Label2.Name = "Label2";
            Label2.Size = new Size(435, 20);
            Label2.TabIndex = 204;
            Label2.Text = "Select the mini bookings that will receive the extra containers" + '\r' + '\n';
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTitle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblTitle.Location = new Point(12, 77);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(234, 24);
            lblTitle.TabIndex = 203;
            lblTitle.Text = "Total number of containers";
            // 
            // dgvMiniBks
            // 
            _dgvMiniBks.AllowCustomTheming = true;
            _dgvMiniBks.AllowUserToAddRows = false;
            _dgvMiniBks.AllowUserToDeleteRows = false;
            _dgvMiniBks.AllowUserToOrderColumns = true;
            _dgvMiniBks.AllowUserToResizeRows = false;
            DataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewCellStyle4.ForeColor = Color.Black;
            DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvMiniBks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
            _dgvMiniBks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvMiniBks.BackgroundColor = Color.White;
            _dgvMiniBks.BorderStyle = BorderStyle.None;
            _dgvMiniBks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvMiniBks.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _dgvMiniBks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            _dgvMiniBks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            _dgvMiniBks.ColumnHeadersHeight = 30;
            _dgvMiniBks.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3 });
            _dgvMiniBks.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvMiniBks.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvMiniBks.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvMiniBks.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvMiniBks.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvMiniBks.CurrentTheme.BackColor = Color.Snow;
            _dgvMiniBks.CurrentTheme.GridColor = Color.Gray;
            _dgvMiniBks.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvMiniBks.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvMiniBks.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvMiniBks.CurrentTheme.Name = null;
            _dgvMiniBks.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvMiniBks.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvMiniBks.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvMiniBks.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvMiniBks.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle6.ForeColor = Color.Black;
            DataGridViewCellStyle6.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle6.SelectionForeColor = Color.Black;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            _dgvMiniBks.DefaultCellStyle = DataGridViewCellStyle6;
            _dgvMiniBks.Dock = DockStyle.Fill;
            _dgvMiniBks.EnableHeadersVisualStyles = false;
            _dgvMiniBks.GridColor = Color.Gray;
            _dgvMiniBks.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvMiniBks.HeaderBgColor = Color.Empty;
            _dgvMiniBks.HeaderForeColor = Color.White;
            _dgvMiniBks.Location = new Point(0, 0);
            _dgvMiniBks.MultiSelect = false;
            _dgvMiniBks.Name = "_dgvMiniBks";
            _dgvMiniBks.ReadOnly = true;
            _dgvMiniBks.RowHeadersVisible = false;
            _dgvMiniBks.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvMiniBks.RowTemplate.Height = 30;
            _dgvMiniBks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvMiniBks.Size = new Size(241, 271);
            _dgvMiniBks.TabIndex = 173;
            _dgvMiniBks.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // btnCancel
            // 
            _btnCancel.AllowToggling = false;
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
            _btnCancel.Location = new Point(401, 449);
            _btnCancel.Name = "_btnCancel";
            StateProperties5.BorderColor = Color.DarkGray;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.DarkGray;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _btnCancel.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _btnCancel.OnPressedState = StateProperties6;
            _btnCancel.Size = new Size(86, 34);
            _btnCancel.TabIndex = 200;
            _btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancel.TextMarginLeft = 0;
            _btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // btnSaveMb
            // 
            _btnSaveMb.AllowToggling = false;
            _btnSaveMb.AnimationSpeed = 200;
            _btnSaveMb.AutoGenerateColors = false;
            _btnSaveMb.BackColor = Color.Transparent;
            _btnSaveMb.BackColor1 = Color.Teal;
            _btnSaveMb.BackgroundImage = (Image)resources.GetObject("btnSaveMb.BackgroundImage");
            _btnSaveMb.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnSaveMb.ButtonText = "Save";
            _btnSaveMb.ButtonTextMarginLeft = 0;
            _btnSaveMb.ColorContrastOnClick = 45;
            _btnSaveMb.ColorContrastOnHover = 45;
            _btnSaveMb.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _btnSaveMb.CustomizableEdges = BorderEdges4;
            _btnSaveMb.DialogResult = DialogResult.None;
            _btnSaveMb.DisabledBorderColor = Color.Empty;
            _btnSaveMb.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSaveMb.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSaveMb.Enabled = false;
            _btnSaveMb.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSaveMb.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSaveMb.ForeColor = Color.White;
            _btnSaveMb.IconLeftCursor = Cursors.Hand;
            _btnSaveMb.IconMarginLeft = 11;
            _btnSaveMb.IconPadding = 10;
            _btnSaveMb.IconRightCursor = Cursors.Hand;
            _btnSaveMb.IdleBorderColor = Color.Teal;
            _btnSaveMb.IdleBorderRadius = 3;
            _btnSaveMb.IdleBorderThickness = 1;
            _btnSaveMb.IdleFillColor = Color.Teal;
            _btnSaveMb.IdleIconLeftImage = null;
            _btnSaveMb.IdleIconRightImage = null;
            _btnSaveMb.IndicateFocus = true;
            _btnSaveMb.Location = new Point(282, 449);
            _btnSaveMb.Name = "_btnSaveMb";
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _btnSaveMb.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Teal;
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.Teal;
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _btnSaveMb.OnPressedState = StateProperties8;
            _btnSaveMb.Size = new Size(96, 34);
            _btnSaveMb.TabIndex = 201;
            _btnSaveMb.TextAlign = ContentAlignment.MiddleCenter;
            _btnSaveMb.TextMarginLeft = 0;
            _btnSaveMb.UseDefaultRadiusAndThickness = true;
            // 
            // Panel2
            // 
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(_dgvMiniBks);
            Panel2.Location = new Point(16, 156);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(243, 273);
            Panel2.TabIndex = 202;
            // 
            // Label12
            // 
            Label12.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Dock = DockStyle.Top;
            Label12.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Location = new Point(0, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(780, 42);
            Label12.TabIndex = 198;
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(733, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(47, 42);
            _closeLabel.TabIndex = 199;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(509, 90);
            Label3.Name = "Label3";
            Label3.Size = new Size(142, 20);
            Label3.TabIndex = 213;
            Label3.Text = "Containers in MBs:";
            // 
            // lblContInMb
            // 
            lblContInMb.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblContInMb.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblContInMb.Location = new Point(689, 88);
            lblContInMb.Name = "lblContInMb";
            lblContInMb.Size = new Size(93, 25);
            lblContInMb.TabIndex = 212;
            lblContInMb.Text = "500";
            // 
            // Column2
            // 
            Column2.FillWeight = 153.1309f;
            Column2.HeaderText = "Minibooking";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 52.08535f;
            Column3.HeaderText = "# Cans";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // FrmModifyTotalNumbCont
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(780, 505);
            Controls.Add(Label3);
            Controls.Add(lblContInMb);
            Controls.Add(_closeLabel);
            Controls.Add(labelTotalSomething);
            Controls.Add(lbltotalNumber);
            Controls.Add(Label6);
            Controls.Add(lblTotaltoBeAsgn);
            Controls.Add(lblminiBkgNumber);
            Controls.Add(Panel3);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Controls.Add(lblTitle);
            Controls.Add(_btnCancel);
            Controls.Add(_btnSaveMb);
            Controls.Add(Panel2);
            Controls.Add(Label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmModifyTotalNumbCont";
            Text = "FrmModifyTotalNumbCont";
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_nucTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dgvMiniBks).EndInit();
            Panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label lbltotalNumber;
        internal Label Label6;
        internal Label Label5;
        internal Label lblTotaltoBeAsgn;
        internal Label lblminiBkgNumber;
        internal Label labelTotalSomething;
        internal Panel Panel3;
        private NumericUpDown _nucTotal;

        internal NumericUpDown nucTotal
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _nucTotal;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nucTotal != null)
                {
                    _nucTotal.ValueChanged -= nucTotal_ValueChanged;
                }

                _nucTotal = value;
                if (_nucTotal != null)
                {
                    _nucTotal.ValueChanged += nucTotal_ValueChanged;
                }
            }
        }

        internal Label Label1;
        internal Label Label2;
        internal Label lblTitle;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvMiniBks;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvMiniBks
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvMiniBks;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvMiniBks != null)
                {
                    _dgvMiniBks.SelectionChanged -= dgvMiniBks_SelectionChanged;
                }

                _dgvMiniBks = value;
                if (_dgvMiniBks != null)
                {
                    _dgvMiniBks.SelectionChanged += dgvMiniBks_SelectionChanged;
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
                    _btnCancel.Click -= closeLabel_Click;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += closeLabel_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnSaveMb;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveMb
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSaveMb;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSaveMb != null)
                {
                    _btnSaveMb.Click -= btnSaveMb_Click;
                }

                _btnSaveMb = value;
                if (_btnSaveMb != null)
                {
                    _btnSaveMb.Click += btnSaveMb_Click;
                }
            }
        }

        internal Panel Panel2;
        internal Label Label12;
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
                    _closeLabel.Click -= closeLabel_Click;
                }

                _closeLabel = value;
                if (_closeLabel != null)
                {
                    _closeLabel.Click += closeLabel_Click;
                }
            }
        }

        internal Label Label3;
        internal Label lblContInMb;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
    }
}