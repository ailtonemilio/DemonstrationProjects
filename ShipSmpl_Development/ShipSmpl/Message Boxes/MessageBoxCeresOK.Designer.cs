using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class MessageBoxCeresOK : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxCeresOK));
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            buttonsPanel = new TableLayoutPanel();
            _okButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _okButton.Click += new EventHandler(okButton_Click);
            messageLabel = new Label();
            titleLabel = new Label();
            BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            PictureBox1 = new PictureBox();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.None;
            buttonsPanel.ColumnCount = 1;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Controls.Add(_okButton, 0, 0);
            buttonsPanel.Location = new Point(121, 302);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(210, 39);
            buttonsPanel.TabIndex = 174;
            // 
            // okButton
            // 
            _okButton.AllowToggling = false;
            _okButton.Anchor = AnchorStyles.None;
            _okButton.AnimationSpeed = 200;
            _okButton.AutoGenerateColors = false;
            _okButton.BackColor = Color.Transparent;
            _okButton.BackColor1 = Color.White;
            _okButton.BackgroundImage = (Image)resources.GetObject("okButton.BackgroundImage");
            _okButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _okButton.ButtonText = "OK";
            _okButton.ButtonTextMarginLeft = 0;
            _okButton.ColorContrastOnClick = 45;
            _okButton.ColorContrastOnHover = 45;
            _okButton.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _okButton.CustomizableEdges = BorderEdges3;
            _okButton.DialogResult = DialogResult.None;
            _okButton.DisabledBorderColor = Color.Empty;
            _okButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _okButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _okButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _okButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _okButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _okButton.IconLeftCursor = Cursors.Hand;
            _okButton.IconMarginLeft = 11;
            _okButton.IconPadding = 10;
            _okButton.IconRightCursor = Cursors.Hand;
            _okButton.IdleBorderColor = Color.Gray;
            _okButton.IdleBorderRadius = 3;
            _okButton.IdleBorderThickness = 1;
            _okButton.IdleFillColor = Color.White;
            _okButton.IdleIconLeftImage = null;
            _okButton.IdleIconRightImage = null;
            _okButton.IndicateFocus = true;
            _okButton.Location = new Point(57, 3);
            _okButton.Name = "_okButton";
            StateProperties5.BorderColor = Color.DarkGray;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.DarkGray;
            StateProperties5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _okButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _okButton.OnPressedState = StateProperties6;
            _okButton.Size = new Size(95, 33);
            _okButton.TabIndex = 137;
            _okButton.TextAlign = ContentAlignment.MiddleCenter;
            _okButton.TextMarginLeft = 0;
            _okButton.UseDefaultRadiusAndThickness = true;
            // 
            // messageLabel
            // 
            messageLabel.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            messageLabel.Location = new Point(21, 122);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(428, 177);
            messageLabel.TabIndex = 171;
            messageLabel.Text = "Label1";
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.Location = new Point(12, 81);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(414, 41);
            titleLabel.TabIndex = 175;
            titleLabel.Text = "Label2";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BunifuElipse1
            // 
            BunifuElipse1.ElipseRadius = 30;
            BunifuElipse1.TargetControl = this;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.warning;
            PictureBox1.Location = new Point(208, 0);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(87, 78);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 176;
            PictureBox1.TabStop = false;
            // 
            // MessageBoxCeresOK
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(478, 360);
            Controls.Add(PictureBox1);
            Controls.Add(buttonsPanel);
            Controls.Add(messageLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageBoxCeresOK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBoxCeresOK";
            buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
        }

        internal TableLayoutPanel buttonsPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _okButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton okButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _okButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_okButton != null)
                {
                    _okButton.Click -= okButton_Click;
                }

                _okButton = value;
                if (_okButton != null)
                {
                    _okButton.Click += okButton_Click;
                }
            }
        }

        internal Label messageLabel;
        internal Label titleLabel;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        internal PictureBox PictureBox1;
    }
}