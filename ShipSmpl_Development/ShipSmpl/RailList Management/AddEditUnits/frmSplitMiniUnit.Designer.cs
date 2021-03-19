using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmSplitMiniUnit : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplitMiniUnit));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label12 = new Label();
            _btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancel.Click += new EventHandler(btnCancel_Click);
            _btnAddMiniUnit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddMiniUnit.Click += new EventHandler(btnAddMiniUnit_Click);
            lblTotalMUMain = new Label();
            lblTotalMU = new Label();
            lblMUSplit = new Label();
            nudMaxSplitMU = new NumericUpDown();
            Label1 = new Label();
            totalLabel = new Label();
            currentMUTotal = new Label();
            Label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMaxSplitMU).BeginInit();
            SuspendLayout();
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(563, 1);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 45);
            _closeLabel.TabIndex = 139;
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
            Label12.TabIndex = 138;
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
            _btnCancel.Location = new Point(510, 292);
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
            _btnCancel.TabIndex = 141;
            _btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancel.TextMarginLeft = 0;
            _btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // btnAddMiniUnit
            // 
            _btnAddMiniUnit.AllowToggling = false;
            _btnAddMiniUnit.Anchor = AnchorStyles.Right;
            _btnAddMiniUnit.AnimationSpeed = 200;
            _btnAddMiniUnit.AutoGenerateColors = false;
            _btnAddMiniUnit.BackColor = Color.Transparent;
            _btnAddMiniUnit.BackColor1 = Color.Teal;
            _btnAddMiniUnit.BackgroundImage = (Image)resources.GetObject("btnAddMiniUnit.BackgroundImage");
            _btnAddMiniUnit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddMiniUnit.ButtonText = "Add MiniUnit";
            _btnAddMiniUnit.ButtonTextMarginLeft = 0;
            _btnAddMiniUnit.ColorContrastOnClick = 45;
            _btnAddMiniUnit.ColorContrastOnHover = 45;
            _btnAddMiniUnit.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnAddMiniUnit.CustomizableEdges = BorderEdges2;
            _btnAddMiniUnit.DialogResult = DialogResult.None;
            _btnAddMiniUnit.DisabledBorderColor = Color.Empty;
            _btnAddMiniUnit.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddMiniUnit.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddMiniUnit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddMiniUnit.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddMiniUnit.ForeColor = Color.White;
            _btnAddMiniUnit.IconLeftCursor = Cursors.Hand;
            _btnAddMiniUnit.IconMarginLeft = 11;
            _btnAddMiniUnit.IconPadding = 10;
            _btnAddMiniUnit.IconRightCursor = Cursors.Hand;
            _btnAddMiniUnit.IdleBorderColor = Color.Teal;
            _btnAddMiniUnit.IdleBorderRadius = 3;
            _btnAddMiniUnit.IdleBorderThickness = 1;
            _btnAddMiniUnit.IdleFillColor = Color.Teal;
            _btnAddMiniUnit.IdleIconLeftImage = null;
            _btnAddMiniUnit.IdleIconRightImage = null;
            _btnAddMiniUnit.IndicateFocus = true;
            _btnAddMiniUnit.Location = new Point(343, 292);
            _btnAddMiniUnit.Name = "_btnAddMiniUnit";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _btnAddMiniUnit.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _btnAddMiniUnit.OnPressedState = StateProperties4;
            _btnAddMiniUnit.Size = new Size(161, 34);
            _btnAddMiniUnit.TabIndex = 140;
            _btnAddMiniUnit.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddMiniUnit.TextMarginLeft = 0;
            _btnAddMiniUnit.UseDefaultRadiusAndThickness = true;
            // 
            // lblTotalMUMain
            // 
            lblTotalMUMain.Anchor = AnchorStyles.Left;
            lblTotalMUMain.AutoSize = true;
            lblTotalMUMain.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotalMUMain.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblTotalMUMain.Location = new Point(142, 139);
            lblTotalMUMain.Name = "lblTotalMUMain";
            lblTotalMUMain.Size = new Size(106, 25);
            lblTotalMUMain.TabIndex = 147;
            lblTotalMUMain.Text = "Total Geral:";
            // 
            // lblTotalMU
            // 
            lblTotalMU.Anchor = AnchorStyles.Left;
            lblTotalMU.AutoSize = true;
            lblTotalMU.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotalMU.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblTotalMU.Location = new Point(77, 175);
            lblTotalMU.Name = "lblTotalMU";
            lblTotalMU.Size = new Size(167, 25);
            lblTotalMU.TabIndex = 148;
            lblTotalMU.Text = "Current MU Billed:";
            // 
            // lblMUSplit
            // 
            lblMUSplit.Anchor = AnchorStyles.Left;
            lblMUSplit.AutoSize = true;
            lblMUSplit.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblMUSplit.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblMUSplit.Location = new Point(142, 219);
            lblMUSplit.Name = "lblMUSplit";
            lblMUSplit.Size = new Size(96, 25);
            lblMUSplit.TabIndex = 150;
            lblMUSplit.Text = "M.U. Split:";
            // 
            // nudMaxSplitMU
            // 
            nudMaxSplitMU.Anchor = AnchorStyles.Left;
            nudMaxSplitMU.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            nudMaxSplitMU.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            nudMaxSplitMU.Location = new Point(255, 213);
            nudMaxSplitMU.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMaxSplitMU.Name = "nudMaxSplitMU";
            nudMaxSplitMU.Size = new Size(109, 35);
            nudMaxSplitMU.TabIndex = 151;
            nudMaxSplitMU.TextAlign = HorizontalAlignment.Center;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Left;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label1.Location = new Point(23, 66);
            Label1.Name = "Label1";
            Label1.Size = new Size(148, 30);
            Label1.TabIndex = 152;
            Label1.Text = "Spilt Mini Unit";
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Left;
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            totalLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            totalLabel.Location = new Point(250, 139);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(103, 25);
            totalLabel.TabIndex = 153;
            totalLabel.Text = "Total Geral";
            // 
            // currentMUTotal
            // 
            currentMUTotal.Anchor = AnchorStyles.Left;
            currentMUTotal.AutoSize = true;
            currentMUTotal.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            currentMUTotal.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            currentMUTotal.Location = new Point(250, 175);
            currentMUTotal.Name = "currentMUTotal";
            currentMUTotal.Size = new Size(103, 25);
            currentMUTotal.TabIndex = 154;
            currentMUTotal.Text = "Total Geral";
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Left;
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label4.Location = new Point(37, 99);
            Label4.Name = "Label4";
            Label4.Size = new Size(559, 25);
            Label4.TabIndex = 155;
            Label4.Text = "Type the value that will be decreased from the current Mini Unit";
            // 
            // frmSplitMiniUnit
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(611, 344);
            Controls.Add(Label4);
            Controls.Add(currentMUTotal);
            Controls.Add(totalLabel);
            Controls.Add(Label1);
            Controls.Add(nudMaxSplitMU);
            Controls.Add(_btnCancel);
            Controls.Add(lblTotalMUMain);
            Controls.Add(lblMUSplit);
            Controls.Add(_btnAddMiniUnit);
            Controls.Add(lblTotalMU);
            Controls.Add(_closeLabel);
            Controls.Add(Label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplitMiniUnit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "tot";
            ((System.ComponentModel.ISupportInitialize)nudMaxSplitMU).EndInit();
            Load += new EventHandler(frmSplitMiniUnit_Load);
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

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddMiniUnit;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddMiniUnit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddMiniUnit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddMiniUnit != null)
                {
                    _btnAddMiniUnit.Click -= btnAddMiniUnit_Click;
                }

                _btnAddMiniUnit = value;
                if (_btnAddMiniUnit != null)
                {
                    _btnAddMiniUnit.Click += btnAddMiniUnit_Click;
                }
            }
        }

        internal Label lblTotalMUMain;
        internal Label lblTotalMU;
        internal Label lblMUSplit;
        internal NumericUpDown nudMaxSplitMU;
        internal Label Label1;
        internal Label totalLabel;
        internal Label currentMUTotal;
        internal Label Label4;
    }
}