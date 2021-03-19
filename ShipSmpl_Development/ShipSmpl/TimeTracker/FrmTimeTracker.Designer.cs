using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmTimeTracker : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimeTracker));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Panel2 = new Panel();
            messageButto = new CustomizedControlsLibrary.ShapedLabel();
            _clockInOutButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _clockInOutButton.Click += new EventHandler(clockInOutButton_Click);
            titleLabel = new Label();
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel1 = new Panel();
            Panel5 = new Panel();
            Panel2.SuspendLayout();
            BunifuShadowPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            Panel5.SuspendLayout();
            SuspendLayout();
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(messageButto);
            Panel2.Controls.Add(_clockInOutButton);
            Panel2.Controls.Add(titleLabel);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(0, 40);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1140, 678);
            Panel2.TabIndex = 0;
            // 
            // messageButto
            // 
            messageButto.Anchor = AnchorStyles.None;
            messageButto.BackColor = Color.Gray;
            messageButto.BorderColor = Color.Transparent;
            messageButto.Edge = 200;
            messageButto.Font = new Font("Segoe UI Semibold", 20.29091f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            messageButto.Location = new Point(470, 159);
            messageButto.Name = "messageButto";
            messageButto.Size = new Size(199, 203);
            messageButto.TabIndex = 81;
            messageButto.Text = "CLOCKED" + '\r' + '\n' + "OUT";
            messageButto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clockInOutButton
            // 
            _clockInOutButton.AllowToggling = false;
            _clockInOutButton.Anchor = AnchorStyles.None;
            _clockInOutButton.AnimationSpeed = 200;
            _clockInOutButton.AutoGenerateColors = false;
            _clockInOutButton.BackColor = Color.Transparent;
            _clockInOutButton.BackColor1 = Color.Teal;
            _clockInOutButton.BackgroundImage = (Image)resources.GetObject("clockInOutButton.BackgroundImage");
            _clockInOutButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _clockInOutButton.ButtonText = "Clock In";
            _clockInOutButton.ButtonTextMarginLeft = 0;
            _clockInOutButton.ColorContrastOnClick = 45;
            _clockInOutButton.ColorContrastOnHover = 45;
            _clockInOutButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _clockInOutButton.CustomizableEdges = BorderEdges1;
            _clockInOutButton.DialogResult = DialogResult.None;
            _clockInOutButton.DisabledBorderColor = Color.Empty;
            _clockInOutButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _clockInOutButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _clockInOutButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _clockInOutButton.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _clockInOutButton.ForeColor = Color.White;
            _clockInOutButton.IconLeftCursor = Cursors.Hand;
            _clockInOutButton.IconMarginLeft = 11;
            _clockInOutButton.IconPadding = 10;
            _clockInOutButton.IconRightCursor = Cursors.Hand;
            _clockInOutButton.IdleBorderColor = Color.Teal;
            _clockInOutButton.IdleBorderRadius = 3;
            _clockInOutButton.IdleBorderThickness = 1;
            _clockInOutButton.IdleFillColor = Color.Teal;
            _clockInOutButton.IdleIconLeftImage = null;
            _clockInOutButton.IdleIconRightImage = null;
            _clockInOutButton.IndicateFocus = true;
            _clockInOutButton.Location = new Point(493, 551);
            _clockInOutButton.Name = "_clockInOutButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _clockInOutButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _clockInOutButton.OnPressedState = StateProperties2;
            _clockInOutButton.Size = new Size(161, 51);
            _clockInOutButton.TabIndex = 79;
            _clockInOutButton.TextAlign = ContentAlignment.MiddleCenter;
            _clockInOutButton.TextMarginLeft = 0;
            _clockInOutButton.UseDefaultRadiusAndThickness = true;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.None;
            titleLabel.Font = new Font("Segoe UI", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titleLabel.Location = new Point(195, 26);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(749, 87);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "CLock in Message";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuShadowPanel1
            // 
            BunifuShadowPanel1.BackColor = Color.White;
            BunifuShadowPanel1.BorderColor = Color.Transparent;
            BunifuShadowPanel1.Controls.Add(Panel1);
            BunifuShadowPanel1.Dock = DockStyle.Fill;
            BunifuShadowPanel1.ForeColor = Color.White;
            BunifuShadowPanel1.Location = new Point(0, 0);
            BunifuShadowPanel1.Margin = new Padding(0);
            BunifuShadowPanel1.Name = "BunifuShadowPanel1";
            BunifuShadowPanel1.Padding = new Padding(10, 6, 5, 5);
            BunifuShadowPanel1.PanelColor = Color.Empty;
            BunifuShadowPanel1.ShadowDept = 2;
            BunifuShadowPanel1.ShadowTopLeftVisible = true;
            BunifuShadowPanel1.Size = new Size(1155, 729);
            BunifuShadowPanel1.TabIndex = 5;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Controls.Add(Panel5);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(10, 6);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1140, 718);
            Panel1.TabIndex = 32;
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel5.Controls.Add(Panel2);
            Panel5.Dock = DockStyle.Fill;
            Panel5.Location = new Point(0, 0);
            Panel5.Name = "Panel5";
            Panel5.Padding = new Padding(0, 40, 0, 0);
            Panel5.Size = new Size(1140, 718);
            Panel5.TabIndex = 33;
            // 
            // FrmTimeTracker
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1155, 729);
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTimeTracker";
            Text = "FrmTimeTracker";
            Panel2.ResumeLayout(false);
            BunifuShadowPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Load += new EventHandler(FrmTimeTracker_Load);
            ResumeLayout(false);
        }

        internal Panel Panel2;
        internal Label titleLabel;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel1;
        internal Panel Panel5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _clockInOutButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton clockInOutButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _clockInOutButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_clockInOutButton != null)
                {
                    _clockInOutButton.Click -= clockInOutButton_Click;
                }

                _clockInOutButton = value;
                if (_clockInOutButton != null)
                {
                    _clockInOutButton.Click += clockInOutButton_Click;
                }
            }
        }

        internal CustomizedControlsLibrary.ShapedLabel messageButto;
    }
}