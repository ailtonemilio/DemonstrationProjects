using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class MessageBoxCeresYesNo : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxCeresYesNo));
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            messageLabel = new Label();
            buttonsPanel = new TableLayoutPanel();
            _noButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _noButton.Click += new EventHandler(Button_OK_Click);
            _yesButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _yesButton.Click += new EventHandler(Button_Abort_Click);
            titleLabel = new Label();
            PictureBox1 = new PictureBox();
            BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            messageLabel.Location = new Point(33, 127);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(423, 191);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "Label1";
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.None;
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Controls.Add(_noButton, 1, 0);
            buttonsPanel.Controls.Add(_yesButton, 0, 0);
            buttonsPanel.Location = new Point(133, 335);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(210, 39);
            buttonsPanel.TabIndex = 169;
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
            _noButton.ButtonText = "No";
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
            // yesButton
            // 
            _yesButton.AllowToggling = false;
            _yesButton.AnimationSpeed = 200;
            _yesButton.AutoGenerateColors = false;
            _yesButton.BackColor = Color.Transparent;
            _yesButton.BackColor1 = Color.Teal;
            _yesButton.BackgroundImage = (Image)resources.GetObject("yesButton.BackgroundImage");
            _yesButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _yesButton.ButtonText = "Yes";
            _yesButton.ButtonTextMarginLeft = 0;
            _yesButton.ColorContrastOnClick = 45;
            _yesButton.ColorContrastOnHover = 45;
            _yesButton.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _yesButton.CustomizableEdges = BorderEdges4;
            _yesButton.DialogResult = DialogResult.None;
            _yesButton.DisabledBorderColor = Color.Empty;
            _yesButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _yesButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _yesButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _yesButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _yesButton.ForeColor = Color.White;
            _yesButton.IconLeftCursor = Cursors.Hand;
            _yesButton.IconMarginLeft = 11;
            _yesButton.IconPadding = 10;
            _yesButton.IconRightCursor = Cursors.Hand;
            _yesButton.IdleBorderColor = Color.Teal;
            _yesButton.IdleBorderRadius = 3;
            _yesButton.IdleBorderThickness = 1;
            _yesButton.IdleFillColor = Color.Teal;
            _yesButton.IdleIconLeftImage = null;
            _yesButton.IdleIconRightImage = null;
            _yesButton.IndicateFocus = true;
            _yesButton.Location = new Point(3, 3);
            _yesButton.Name = "_yesButton";
            StateProperties7.BorderColor = Color.MediumTurquoise;
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.MediumTurquoise;
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _yesButton.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Teal;
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.Teal;
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _yesButton.OnPressedState = StateProperties8;
            _yesButton.Size = new Size(99, 33);
            _yesButton.TabIndex = 136;
            _yesButton.TextAlign = ContentAlignment.MiddleCenter;
            _yesButton.TextMarginLeft = 0;
            _yesButton.UseDefaultRadiusAndThickness = true;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.Location = new Point(12, 86);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(441, 41);
            titleLabel.TabIndex = 170;
            titleLabel.Text = "Label2";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.warning;
            PictureBox1.Location = new Point(200, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(87, 78);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 171;
            PictureBox1.TabStop = false;
            // 
            // BunifuElipse1
            // 
            BunifuElipse1.ElipseRadius = 30;
            BunifuElipse1.TargetControl = this;
            // 
            // MessageBoxCeresYesNo
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(478, 386);
            Controls.Add(PictureBox1);
            Controls.Add(titleLabel);
            Controls.Add(buttonsPanel);
            Controls.Add(messageLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageBoxCeresYesNo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBoxCeresYesNo";
            buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(MessageBoxCeresYesNo_Load);
            ResumeLayout(false);
        }

        internal Label messageLabel;
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
                    _noButton.Click -= Button_OK_Click;
                }

                _noButton = value;
                if (_noButton != null)
                {
                    _noButton.Click += Button_OK_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _yesButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton yesButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _yesButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_yesButton != null)
                {
                    _yesButton.Click -= Button_Abort_Click;
                }

                _yesButton = value;
                if (_yesButton != null)
                {
                    _yesButton.Click += Button_Abort_Click;
                }
            }
        }

        internal Label titleLabel;
        internal PictureBox PictureBox1;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
    }
}