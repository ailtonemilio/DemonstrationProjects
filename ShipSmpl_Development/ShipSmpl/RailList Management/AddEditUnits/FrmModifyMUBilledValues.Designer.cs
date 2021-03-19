using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmModifyMUBilledValues : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifyMUBilledValues));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label12 = new Label();
            _btnUpdateMu = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnUpdateMu.Click += new EventHandler(btnUpdateMu_Click);
            _btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancel.Click += new EventHandler(closeLabel_Click);
            Panel2 = new Panel();
            _dgvMiniUnits = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvMiniUnits.SelectionChanged += new EventHandler(dgvMiniUnits_SelectionChanged);
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            _nucTotal = new NumericUpDown();
            _nucTotal.ValueChanged += new EventHandler(nucTotal_ValueChanged);
            lblTitle = new Label();
            Label2 = new Label();
            lblTotaltoBeAsgn = new Label();
            Label1 = new Label();
            lblminiUnitNumber = new Label();
            Panel3 = new Panel();
            Label5 = new Label();
            Label6 = new Label();
            labelTotalSomething = new Label();
            lbltotalNumber = new Label();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvMiniUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_nucTotal).BeginInit();
            Panel3.SuspendLayout();
            SuspendLayout();
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(877, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 45);
            _closeLabel.TabIndex = 158;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label12
            // 
            Label12.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Dock = DockStyle.Top;
            Label12.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Location = new Point(0, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(925, 46);
            Label12.TabIndex = 157;
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpdateMu
            // 
            _btnUpdateMu.AllowToggling = false;
            _btnUpdateMu.AnimationSpeed = 200;
            _btnUpdateMu.AutoGenerateColors = false;
            _btnUpdateMu.BackColor = Color.Transparent;
            _btnUpdateMu.BackColor1 = Color.Teal;
            _btnUpdateMu.BackgroundImage = (Image)resources.GetObject("btnUpdateMu.BackgroundImage");
            _btnUpdateMu.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnUpdateMu.ButtonText = "Save";
            _btnUpdateMu.ButtonTextMarginLeft = 0;
            _btnUpdateMu.ColorContrastOnClick = 45;
            _btnUpdateMu.ColorContrastOnHover = 45;
            _btnUpdateMu.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnUpdateMu.CustomizableEdges = BorderEdges1;
            _btnUpdateMu.DialogResult = DialogResult.None;
            _btnUpdateMu.DisabledBorderColor = Color.Empty;
            _btnUpdateMu.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnUpdateMu.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnUpdateMu.Enabled = false;
            _btnUpdateMu.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnUpdateMu.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnUpdateMu.ForeColor = Color.White;
            _btnUpdateMu.IconLeftCursor = Cursors.Hand;
            _btnUpdateMu.IconMarginLeft = 11;
            _btnUpdateMu.IconPadding = 10;
            _btnUpdateMu.IconRightCursor = Cursors.Hand;
            _btnUpdateMu.IdleBorderColor = Color.Teal;
            _btnUpdateMu.IdleBorderRadius = 3;
            _btnUpdateMu.IdleBorderThickness = 1;
            _btnUpdateMu.IdleFillColor = Color.Teal;
            _btnUpdateMu.IdleIconLeftImage = null;
            _btnUpdateMu.IdleIconRightImage = null;
            _btnUpdateMu.IndicateFocus = true;
            _btnUpdateMu.Location = new Point(672, 439);
            _btnUpdateMu.Name = "_btnUpdateMu";
            StateProperties1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnUpdateMu.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnUpdateMu.OnPressedState = StateProperties2;
            _btnUpdateMu.Size = new Size(96, 34);
            _btnUpdateMu.TabIndex = 161;
            _btnUpdateMu.TextAlign = ContentAlignment.MiddleCenter;
            _btnUpdateMu.TextMarginLeft = 0;
            _btnUpdateMu.UseDefaultRadiusAndThickness = true;
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
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnCancel.CustomizableEdges = BorderEdges2;
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
            _btnCancel.Location = new Point(791, 439);
            _btnCancel.Name = "_btnCancel";
            StateProperties3.BorderColor = Color.DarkGray;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.DarkGray;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _btnCancel.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _btnCancel.OnPressedState = StateProperties4;
            _btnCancel.Size = new Size(86, 34);
            _btnCancel.TabIndex = 160;
            _btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancel.TextMarginLeft = 0;
            _btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // Panel2
            // 
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(_dgvMiniUnits);
            Panel2.Location = new Point(16, 152);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(596, 273);
            Panel2.TabIndex = 186;
            // 
            // dgvMiniUnits
            // 
            _dgvMiniUnits.AllowCustomTheming = true;
            _dgvMiniUnits.AllowUserToAddRows = false;
            _dgvMiniUnits.AllowUserToDeleteRows = false;
            _dgvMiniUnits.AllowUserToOrderColumns = true;
            _dgvMiniUnits.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvMiniUnits.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvMiniUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvMiniUnits.BackgroundColor = Color.White;
            _dgvMiniUnits.BorderStyle = BorderStyle.None;
            _dgvMiniUnits.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvMiniUnits.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _dgvMiniUnits.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvMiniUnits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvMiniUnits.ColumnHeadersHeight = 30;
            _dgvMiniUnits.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column4, Column3 });
            _dgvMiniUnits.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvMiniUnits.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvMiniUnits.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvMiniUnits.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvMiniUnits.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvMiniUnits.CurrentTheme.BackColor = Color.Snow;
            _dgvMiniUnits.CurrentTheme.GridColor = Color.Gray;
            _dgvMiniUnits.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvMiniUnits.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _dgvMiniUnits.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgvMiniUnits.CurrentTheme.Name = null;
            _dgvMiniUnits.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvMiniUnits.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvMiniUnits.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvMiniUnits.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _dgvMiniUnits.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvMiniUnits.DefaultCellStyle = DataGridViewCellStyle3;
            _dgvMiniUnits.Dock = DockStyle.Fill;
            _dgvMiniUnits.EnableHeadersVisualStyles = false;
            _dgvMiniUnits.GridColor = Color.Gray;
            _dgvMiniUnits.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvMiniUnits.HeaderBgColor = Color.Empty;
            _dgvMiniUnits.HeaderForeColor = Color.White;
            _dgvMiniUnits.Location = new Point(0, 0);
            _dgvMiniUnits.MultiSelect = false;
            _dgvMiniUnits.Name = "_dgvMiniUnits";
            _dgvMiniUnits.ReadOnly = true;
            _dgvMiniUnits.RowHeadersVisible = false;
            _dgvMiniUnits.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _dgvMiniUnits.RowTemplate.Height = 30;
            _dgvMiniUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvMiniUnits.Size = new Size(594, 271);
            _dgvMiniUnits.TabIndex = 173;
            _dgvMiniUnits.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column2
            // 
            Column2.FillWeight = 89.44664f;
            Column2.HeaderText = "Mini Unit";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Customer";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 134.4113f;
            Column4.HeaderText = "Commodity/Grade";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 76.14214f;
            Column3.HeaderText = "Total Billed";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // nucTotal
            // 
            _nucTotal.Font = new Font("Microsoft Sans Serif", 15.70909f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _nucTotal.Location = new Point(30, 45);
            _nucTotal.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            _nucTotal.Name = "_nucTotal";
            _nucTotal.Size = new Size(120, 35);
            _nucTotal.TabIndex = 187;
            _nucTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTitle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblTitle.Location = new Point(12, 73);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(311, 25);
            lblTitle.TabIndex = 188;
            lblTitle.Text = "Total billed number assignment";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(12, 118);
            Label2.Name = "Label2";
            Label2.Size = new Size(429, 24);
            Label2.TabIndex = 189;
            Label2.Text = "Select the mini units to be assigned the difference ";
            // 
            // lblTotaltoBeAsgn
            // 
            lblTotaltoBeAsgn.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotaltoBeAsgn.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblTotaltoBeAsgn.Location = new Point(819, 100);
            lblTotaltoBeAsgn.Name = "lblTotaltoBeAsgn";
            lblTotaltoBeAsgn.Size = new Size(96, 25);
            lblTotaltoBeAsgn.TabIndex = 190;
            lblTotaltoBeAsgn.Text = "200";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(639, 101);
            Label1.Name = "Label1";
            Label1.Size = new Size(180, 24);
            Label1.TabIndex = 191;
            Label1.Text = "To be reassigned:";
            // 
            // lblminiUnitNumber
            // 
            lblminiUnitNumber.AutoSize = true;
            lblminiUnitNumber.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblminiUnitNumber.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblminiUnitNumber.Location = new Point(705, 186);
            lblminiUnitNumber.Name = "lblminiUnitNumber";
            lblminiUnitNumber.Size = new Size(116, 24);
            lblminiUnitNumber.TabIndex = 193;
            lblminiUnitNumber.Text = "MINIUNIT(A)";
            // 
            // Panel3
            // 
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(Label5);
            Panel3.Controls.Add(_nucTotal);
            Panel3.Location = new Point(670, 213);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(193, 96);
            Panel3.TabIndex = 194;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label5.Location = new Point(17, 15);
            Label5.Name = "Label5";
            Label5.Size = new Size(56, 24);
            Label5.TabIndex = 194;
            Label5.Text = "Total:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(637, 71);
            Label6.Name = "Label6";
            Label6.Size = new Size(240, 24);
            Label6.TabIndex = 195;
            Label6.Text = "_______________________";
            // 
            // labelTotalSomething
            // 
            labelTotalSomething.AutoSize = true;
            labelTotalSomething.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            labelTotalSomething.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            labelTotalSomething.Location = new Point(639, 63);
            labelTotalSomething.Name = "labelTotalSomething";
            labelTotalSomething.Size = new Size(118, 24);
            labelTotalSomething.TabIndex = 197;
            labelTotalSomething.Text = "Total Pieces:";
            // 
            // lbltotalNumber
            // 
            lbltotalNumber.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lbltotalNumber.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lbltotalNumber.Location = new Point(819, 61);
            lbltotalNumber.Name = "lbltotalNumber";
            lbltotalNumber.Size = new Size(93, 25);
            lbltotalNumber.TabIndex = 196;
            lbltotalNumber.Text = "500";
            // 
            // FrmModifyMUBilledValues
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 500);
            Controls.Add(lblTotaltoBeAsgn);
            Controls.Add(lblminiUnitNumber);
            Controls.Add(labelTotalSomething);
            Controls.Add(_btnCancel);
            Controls.Add(lbltotalNumber);
            Controls.Add(_btnUpdateMu);
            Controls.Add(Label6);
            Controls.Add(Panel3);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Controls.Add(lblTitle);
            Controls.Add(Panel2);
            Controls.Add(_closeLabel);
            Controls.Add(Label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmModifyMUBilledValues";
            Text = "FrmModifyMUBilledValues";
            Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvMiniUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)_nucTotal).EndInit();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            Load += new EventHandler(FrmModifyMUBilledValues_Load);
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
                    _closeLabel.Click -= closeLabel_Click;
                }

                _closeLabel = value;
                if (_closeLabel != null)
                {
                    _closeLabel.Click += closeLabel_Click;
                }
            }
        }

        internal Label Label12;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnUpdateMu;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateMu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnUpdateMu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnUpdateMu != null)
                {
                    _btnUpdateMu.Click -= btnUpdateMu_Click;
                }

                _btnUpdateMu = value;
                if (_btnUpdateMu != null)
                {
                    _btnUpdateMu.Click += btnUpdateMu_Click;
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

        internal Panel Panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvMiniUnits;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvMiniUnits
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvMiniUnits;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvMiniUnits != null)
                {
                    _dgvMiniUnits.SelectionChanged -= dgvMiniUnits_SelectionChanged;
                }

                _dgvMiniUnits = value;
                if (_dgvMiniUnits != null)
                {
                    _dgvMiniUnits.SelectionChanged += dgvMiniUnits_SelectionChanged;
                }
            }
        }

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

        internal Label lblTitle;
        internal Label Label2;
        internal Label lblTotaltoBeAsgn;
        internal Label Label1;
        internal Label lblminiUnitNumber;
        internal Panel Panel3;
        internal Label Label5;
        internal Label Label6;
        internal Label labelTotalSomething;
        internal Label lbltotalNumber;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column3;
    }
}