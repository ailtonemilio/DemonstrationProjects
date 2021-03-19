using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmCardAssignment : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardAssignment));
            var ToggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            var ToggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            reassignCardTitleLabel = new Label();
            _BunifuToggleSwitch1 = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            _BunifuToggleSwitch1.OnValuechange += new EventHandler(BunifuToggleSwitch1_OnValuechange);
            Label1 = new Label();
            Label2 = new Label();
            PictureBox1 = new PictureBox();
            _closeButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _closeButton.Click += new EventHandler(closeButton_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // reassignCardTitleLabel
            // 
            reassignCardTitleLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            reassignCardTitleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            reassignCardTitleLabel.Location = new Point(11, 63);
            reassignCardTitleLabel.Margin = new Padding(2, 0, 2, 0);
            reassignCardTitleLabel.Name = "reassignCardTitleLabel";
            reassignCardTitleLabel.Size = new Size(566, 46);
            reassignCardTitleLabel.TabIndex = 1;
            reassignCardTitleLabel.Text = "Scan card that will be assigned to employee";
            reassignCardTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BunifuToggleSwitch1
            // 
            _BunifuToggleSwitch1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _BunifuToggleSwitch1.Animation = 5;
            _BunifuToggleSwitch1.BackColor = Color.Transparent;
            _BunifuToggleSwitch1.BackgroundImage = (Image)resources.GetObject("BunifuToggleSwitch1.BackgroundImage");
            _BunifuToggleSwitch1.Cursor = Cursors.Hand;
            _BunifuToggleSwitch1.Location = new Point(603, 12);
            _BunifuToggleSwitch1.Name = "_BunifuToggleSwitch1";
            _BunifuToggleSwitch1.Size = new Size(62, 31);
            _BunifuToggleSwitch1.TabIndex = 74;
            ToggleState1.BackColor = Color.Empty;
            ToggleState1.BackColorInner = Color.Empty;
            ToggleState1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(236)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(140)));
            ToggleState1.BorderColorInner = Color.Empty;
            ToggleState1.BorderRadius = 1;
            ToggleState1.BorderRadiusInner = 1;
            ToggleState1.BorderThickness = 1;
            ToggleState1.BorderThicknessInner = 1;
            _BunifuToggleSwitch1.ToggleStateDisabled = ToggleState1;
            ToggleState2.BackColor = Color.Teal;
            ToggleState2.BackColorInner = Color.White;
            ToggleState2.BorderColor = Color.Teal;
            ToggleState2.BorderColorInner = Color.White;
            ToggleState2.BorderRadius = 17;
            ToggleState2.BorderRadiusInner = 15;
            ToggleState2.BorderThickness = 1;
            ToggleState2.BorderThicknessInner = 1;
            _BunifuToggleSwitch1.ToggleStateOff = ToggleState2;
            ToggleState3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState3.BackColorInner = Color.White;
            ToggleState3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            ToggleState3.BorderColorInner = Color.White;
            ToggleState3.BorderRadius = 17;
            ToggleState3.BorderRadiusInner = 15;
            ToggleState3.BorderThickness = 1;
            ToggleState3.BorderThicknessInner = 1;
            _BunifuToggleSwitch1.ToggleStateOn = ToggleState3;
            _BunifuToggleSwitch1.Value = false;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(522, 18);
            Label1.Name = "Label1";
            Label1.Size = new Size(75, 25);
            Label1.TabIndex = 75;
            Label1.Text = "Card ID";
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(671, 18);
            Label2.Name = "Label2";
            Label2.Size = new Size(89, 25);
            Label2.TabIndex = 76;
            Label2.Text = "Phone ID";
            // 
            // PictureBox1
            // 
            PictureBox1.Location = new Point(279, 121);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(251, 283);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 77;
            PictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            _closeButton.AllowToggling = false;
            _closeButton.AnimationSpeed = 200;
            _closeButton.AutoGenerateColors = false;
            _closeButton.BackColor = Color.Transparent;
            _closeButton.BackColor1 = Color.Teal;
            _closeButton.BackgroundImage = (Image)resources.GetObject("closeButton.BackgroundImage");
            _closeButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _closeButton.ButtonText = "Close";
            _closeButton.ButtonTextMarginLeft = 0;
            _closeButton.ColorContrastOnClick = 45;
            _closeButton.ColorContrastOnHover = 45;
            _closeButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _closeButton.CustomizableEdges = BorderEdges1;
            _closeButton.DialogResult = DialogResult.None;
            _closeButton.DisabledBorderColor = Color.Empty;
            _closeButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _closeButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _closeButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _closeButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeButton.ForeColor = Color.White;
            _closeButton.IconLeftCursor = Cursors.Hand;
            _closeButton.IconMarginLeft = 11;
            _closeButton.IconPadding = 10;
            _closeButton.IconRightCursor = Cursors.Hand;
            _closeButton.IdleBorderColor = Color.Teal;
            _closeButton.IdleBorderRadius = 3;
            _closeButton.IdleBorderThickness = 1;
            _closeButton.IdleFillColor = Color.Teal;
            _closeButton.IdleIconLeftImage = null;
            _closeButton.IdleIconRightImage = null;
            _closeButton.IndicateFocus = true;
            _closeButton.Location = new Point(329, 456);
            _closeButton.Name = "_closeButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _closeButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _closeButton.OnPressedState = StateProperties2;
            _closeButton.Size = new Size(152, 45);
            _closeButton.TabIndex = 78;
            _closeButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeButton.TextMarginLeft = 0;
            _closeButton.UseDefaultRadiusAndThickness = true;
            // 
            // FrmCardAssignment
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(785, 515);
            ControlBox = false;
            Controls.Add(_closeButton);
            Controls.Add(PictureBox1);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(_BunifuToggleSwitch1);
            Controls.Add(reassignCardTitleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(2);
            MaximumSize = new Size(787, 551);
            MinimumSize = new Size(787, 515);
            Name = "FrmCardAssignment";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            KeyDown += new KeyEventHandler(Key_press_KeyDown);
            Load += new EventHandler(FrmCardAssignment_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label reassignCardTitleLabel;
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

        internal Label Label1;
        internal Label Label2;
        internal PictureBox PictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _closeButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton closeButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _closeButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_closeButton != null)
                {
                    _closeButton.Click -= closeButton_Click;
                }

                _closeButton = value;
                if (_closeButton != null)
                {
                    _closeButton.Click += closeButton_Click;
                }
            }
        }
    }
}