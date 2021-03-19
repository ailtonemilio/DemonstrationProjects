using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmReturnSplitMiniUnit : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnSplitMiniUnit));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label12 = new Label();
            gboMain = new GroupBox();
            dgvMiniUnit = new Bunifu.UI.WinForms.BunifuDataGridView();
            Label1 = new Label();
            nudMaxSplitMU = new NumericUpDown();
            lblMUSplit = new Label();
            _btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancel.Click += new EventHandler(btnCancel_Click);
            _btnReturn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnReturn.Click += new EventHandler(btnReturn_Click);
            gboMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMiniUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxSplitMU).BeginInit();
            SuspendLayout();
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(561, -2);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 45);
            _closeLabel.TabIndex = 141;
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
            Label12.Size = new Size(611, 46);
            Label12.TabIndex = 140;
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gboMain
            // 
            gboMain.Controls.Add(dgvMiniUnit);
            gboMain.Controls.Add(Label1);
            gboMain.Controls.Add(nudMaxSplitMU);
            gboMain.Controls.Add(lblMUSplit);
            gboMain.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            gboMain.Location = new Point(13, 66);
            gboMain.Name = "gboMain";
            gboMain.Size = new Size(584, 255);
            gboMain.TabIndex = 153;
            gboMain.TabStop = false;
            gboMain.Text = "GroupBox1";
            // 
            // dgvMiniUnit
            // 
            dgvMiniUnit.AllowCustomTheming = true;
            dgvMiniUnit.AllowUserToAddRows = false;
            dgvMiniUnit.AllowUserToDeleteRows = false;
            dgvMiniUnit.AllowUserToResizeColumns = false;
            dgvMiniUnit.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvMiniUnit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dgvMiniUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMiniUnit.BackgroundColor = Color.White;
            dgvMiniUnit.BorderStyle = BorderStyle.None;
            dgvMiniUnit.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMiniUnit.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMiniUnit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dgvMiniUnit.ColumnHeadersHeight = 40;
            dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvMiniUnit.CurrentTheme.BackColor = Color.Snow;
            dgvMiniUnit.CurrentTheme.GridColor = Color.Gray;
            dgvMiniUnit.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvMiniUnit.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            dgvMiniUnit.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvMiniUnit.CurrentTheme.Name = null;
            dgvMiniUnit.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            dgvMiniUnit.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvMiniUnit.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvMiniUnit.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            dgvMiniUnit.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMiniUnit.DefaultCellStyle = DataGridViewCellStyle3;
            dgvMiniUnit.EnableHeadersVisualStyles = false;
            dgvMiniUnit.GridColor = Color.Gray;
            dgvMiniUnit.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvMiniUnit.HeaderBgColor = Color.Empty;
            dgvMiniUnit.HeaderForeColor = Color.White;
            dgvMiniUnit.Location = new Point(10, 48);
            dgvMiniUnit.MultiSelect = false;
            dgvMiniUnit.Name = "dgvMiniUnit";
            dgvMiniUnit.ReadOnly = true;
            dgvMiniUnit.RowHeadersVisible = false;
            dgvMiniUnit.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgvMiniUnit.RowTemplate.Height = 40;
            dgvMiniUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMiniUnit.Size = new Size(319, 191);
            dgvMiniUnit.TabIndex = 153;
            dgvMiniUnit.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Left;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(6, 24);
            Label1.Name = "Label1";
            Label1.Size = new Size(251, 21);
            Label1.TabIndex = 153;
            Label1.Text = "Select Mini Unit for Receive Return";
            // 
            // nudMaxSplitMU
            // 
            nudMaxSplitMU.Anchor = AnchorStyles.Left;
            nudMaxSplitMU.Enabled = false;
            nudMaxSplitMU.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            nudMaxSplitMU.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            nudMaxSplitMU.Location = new Point(488, 60);
            nudMaxSplitMU.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMaxSplitMU.Name = "nudMaxSplitMU";
            nudMaxSplitMU.Size = new Size(74, 32);
            nudMaxSplitMU.TabIndex = 151;
            nudMaxSplitMU.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMUSplit
            // 
            lblMUSplit.Anchor = AnchorStyles.Left;
            lblMUSplit.AutoSize = true;
            lblMUSplit.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblMUSplit.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblMUSplit.Location = new Point(345, 65);
            lblMUSplit.Name = "lblMUSplit";
            lblMUSplit.Size = new Size(95, 21);
            lblMUSplit.TabIndex = 150;
            lblMUSplit.Text = "M.U. Return:";
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
            _btnCancel.Location = new Point(507, 340);
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
            _btnCancel.Size = new Size(86, 34);
            _btnCancel.TabIndex = 154;
            _btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancel.TextMarginLeft = 0;
            _btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // btnReturn
            // 
            _btnReturn.AllowToggling = false;
            _btnReturn.AnimationSpeed = 200;
            _btnReturn.AutoGenerateColors = false;
            _btnReturn.BackColor = Color.Transparent;
            _btnReturn.BackColor1 = Color.IndianRed;
            _btnReturn.BackgroundImage = (Image)resources.GetObject("btnReturn.BackgroundImage");
            _btnReturn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnReturn.ButtonText = "Return";
            _btnReturn.ButtonTextMarginLeft = 0;
            _btnReturn.ColorContrastOnClick = 45;
            _btnReturn.ColorContrastOnHover = 45;
            _btnReturn.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnReturn.CustomizableEdges = BorderEdges2;
            _btnReturn.DialogResult = DialogResult.None;
            _btnReturn.DisabledBorderColor = Color.Empty;
            _btnReturn.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnReturn.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnReturn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnReturn.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnReturn.ForeColor = Color.White;
            _btnReturn.IconLeftCursor = Cursors.Hand;
            _btnReturn.IconMarginLeft = 11;
            _btnReturn.IconPadding = 10;
            _btnReturn.IconRightCursor = Cursors.Hand;
            _btnReturn.IdleBorderColor = Color.IndianRed;
            _btnReturn.IdleBorderRadius = 3;
            _btnReturn.IdleBorderThickness = 1;
            _btnReturn.IdleFillColor = Color.IndianRed;
            _btnReturn.IdleIconLeftImage = null;
            _btnReturn.IdleIconRightImage = null;
            _btnReturn.IndicateFocus = true;
            _btnReturn.Location = new Point(392, 340);
            _btnReturn.Name = "_btnReturn";
            StateProperties3.BorderColor = Color.LightCoral;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.LightCoral;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _btnReturn.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.IndianRed;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.IndianRed;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _btnReturn.OnPressedState = StateProperties4;
            _btnReturn.Size = new Size(96, 34);
            _btnReturn.TabIndex = 156;
            _btnReturn.TextAlign = ContentAlignment.MiddleCenter;
            _btnReturn.TextMarginLeft = 0;
            _btnReturn.UseDefaultRadiusAndThickness = true;
            // 
            // frmReturnSplitMiniUnit
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(611, 386);
            Controls.Add(_btnReturn);
            Controls.Add(_btnCancel);
            Controls.Add(gboMain);
            Controls.Add(_closeLabel);
            Controls.Add(Label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReturnSplitMiniUnit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmReturnSplitMiniUnit";
            gboMain.ResumeLayout(false);
            gboMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMiniUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxSplitMU).EndInit();
            Load += new EventHandler(frmReturnSplitMiniUnit_Load);
            ResumeLayout(false);
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
        internal GroupBox gboMain;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvMiniUnit;
        internal Label Label1;
        internal NumericUpDown nudMaxSplitMU;
        internal Label lblMUSplit;
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

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnReturn;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReturn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnReturn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnReturn != null)
                {
                    _btnReturn.Click -= btnReturn_Click;
                }

                _btnReturn = value;
                if (_btnReturn != null)
                {
                    _btnReturn.Click += btnReturn_Click;
                }
            }
        }
    }
}