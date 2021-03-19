using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmContactsWarningMessage : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContactsWarningMessage));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            messageLabel = new Label();
            ImageList1 = new ImageList(components);
            ButtonPanel = new Panel();
            _noBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _noBunifuButton.Click += new EventHandler(okTouchButton_ButtonClick);
            _yesBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _yesBunifuButton.Click += new EventHandler(yesTouchButton_Load);
            Label1 = new Label();
            _Label2 = new Label();
            _Label2.Click += new EventHandler(Label2_Click);
            imageWarningLabel = new Label();
            tileLabel = new Label();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            messageLabel.BackColor = Color.White;
            messageLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            messageLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            messageLabel.ImageAlign = ContentAlignment.MiddleLeft;
            messageLabel.ImageList = ImageList1;
            messageLabel.Location = new Point(88, 97);
            messageLabel.Name = "messageLabel";
            messageLabel.Padding = new Padding(5, 5, 5, 0);
            messageLabel.Size = new Size(586, 159);
            messageLabel.TabIndex = 17;
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "caution.png");
            ImageList1.Images.SetKeyName(1, "icon-available.jpg");
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor = Color.White;
            ButtonPanel.Controls.Add(_noBunifuButton);
            ButtonPanel.Controls.Add(_yesBunifuButton);
            ButtonPanel.Dock = DockStyle.Bottom;
            ButtonPanel.Location = new Point(0, 299);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(711, 70);
            ButtonPanel.TabIndex = 18;
            // 
            // noBunifuButton
            // 
            _noBunifuButton.AllowToggling = false;
            _noBunifuButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _noBunifuButton.AnimationSpeed = 200;
            _noBunifuButton.AutoGenerateColors = false;
            _noBunifuButton.BackColor = Color.Transparent;
            _noBunifuButton.BackColor1 = Color.White;
            _noBunifuButton.BackgroundImage = (Image)resources.GetObject("noBunifuButton.BackgroundImage");
            _noBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _noBunifuButton.ButtonText = "NO";
            _noBunifuButton.ButtonTextMarginLeft = 0;
            _noBunifuButton.ColorContrastOnClick = 45;
            _noBunifuButton.ColorContrastOnHover = 45;
            _noBunifuButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _noBunifuButton.CustomizableEdges = BorderEdges1;
            _noBunifuButton.DialogResult = DialogResult.None;
            _noBunifuButton.DisabledBorderColor = Color.Empty;
            _noBunifuButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _noBunifuButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _noBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _noBunifuButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _noBunifuButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _noBunifuButton.IconLeftCursor = Cursors.Hand;
            _noBunifuButton.IconMarginLeft = 11;
            _noBunifuButton.IconPadding = 10;
            _noBunifuButton.IconRightCursor = Cursors.Hand;
            _noBunifuButton.IdleBorderColor = Color.Gray;
            _noBunifuButton.IdleBorderRadius = 3;
            _noBunifuButton.IdleBorderThickness = 1;
            _noBunifuButton.IdleFillColor = Color.White;
            _noBunifuButton.IdleIconLeftImage = null;
            _noBunifuButton.IdleIconRightImage = null;
            _noBunifuButton.IndicateFocus = true;
            _noBunifuButton.Location = new Point(475, 5);
            _noBunifuButton.Name = "_noBunifuButton";
            StateProperties1.BorderColor = Color.DarkGray;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.DarkGray;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _noBunifuButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.IndianRed;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.IndianRed;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _noBunifuButton.OnPressedState = StateProperties2;
            _noBunifuButton.Size = new Size(82, 44);
            _noBunifuButton.TabIndex = 63;
            _noBunifuButton.TextAlign = ContentAlignment.MiddleCenter;
            _noBunifuButton.TextMarginLeft = 0;
            _noBunifuButton.UseDefaultRadiusAndThickness = true;
            // 
            // yesBunifuButton
            // 
            _yesBunifuButton.AllowToggling = false;
            _yesBunifuButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _yesBunifuButton.AnimationSpeed = 200;
            _yesBunifuButton.AutoGenerateColors = false;
            _yesBunifuButton.BackColor = Color.Transparent;
            _yesBunifuButton.BackColor1 = Color.IndianRed;
            _yesBunifuButton.BackgroundImage = (Image)resources.GetObject("yesBunifuButton.BackgroundImage");
            _yesBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _yesBunifuButton.ButtonText = "YES";
            _yesBunifuButton.ButtonTextMarginLeft = 0;
            _yesBunifuButton.ColorContrastOnClick = 45;
            _yesBunifuButton.ColorContrastOnHover = 45;
            _yesBunifuButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _yesBunifuButton.CustomizableEdges = BorderEdges2;
            _yesBunifuButton.DialogResult = DialogResult.None;
            _yesBunifuButton.DisabledBorderColor = Color.Empty;
            _yesBunifuButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _yesBunifuButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _yesBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _yesBunifuButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _yesBunifuButton.ForeColor = Color.White;
            _yesBunifuButton.IconLeftCursor = Cursors.Hand;
            _yesBunifuButton.IconMarginLeft = 11;
            _yesBunifuButton.IconPadding = 10;
            _yesBunifuButton.IconRightCursor = Cursors.Hand;
            _yesBunifuButton.IdleBorderColor = Color.IndianRed;
            _yesBunifuButton.IdleBorderRadius = 3;
            _yesBunifuButton.IdleBorderThickness = 1;
            _yesBunifuButton.IdleFillColor = Color.IndianRed;
            _yesBunifuButton.IdleIconLeftImage = null;
            _yesBunifuButton.IdleIconRightImage = null;
            _yesBunifuButton.IndicateFocus = true;
            _yesBunifuButton.Location = new Point(569, 5);
            _yesBunifuButton.Name = "_yesBunifuButton";
            StateProperties3.BorderColor = Color.LightCoral;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.LightCoral;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _yesBunifuButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.IndianRed;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.IndianRed;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _yesBunifuButton.OnPressedState = StateProperties4;
            _yesBunifuButton.Size = new Size(105, 44);
            _yesBunifuButton.TabIndex = 62;
            _yesBunifuButton.TextAlign = ContentAlignment.MiddleCenter;
            _yesBunifuButton.TextMarginLeft = 0;
            _yesBunifuButton.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.BackColor = Color.IndianRed;
            Label1.Dock = DockStyle.Top;
            Label1.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.IndianRed;
            Label1.Location = new Point(0, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(711, 49);
            Label1.TabIndex = 16;
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            _Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _Label2.BackColor = Color.IndianRed;
            _Label2.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label2.ForeColor = Color.White;
            _Label2.Location = new Point(654, -1);
            _Label2.Margin = new Padding(0);
            _Label2.Name = "_Label2";
            _Label2.Size = new Size(57, 50);
            _Label2.TabIndex = 19;
            _Label2.Text = "🗙";
            _Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imageWarningLabel
            // 
            imageWarningLabel.BackColor = Color.White;
            imageWarningLabel.Dock = DockStyle.Left;
            imageWarningLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            imageWarningLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            imageWarningLabel.ImageAlign = ContentAlignment.TopCenter;
            imageWarningLabel.ImageIndex = 0;
            imageWarningLabel.ImageList = ImageList1;
            imageWarningLabel.Location = new Point(0, 49);
            imageWarningLabel.Name = "imageWarningLabel";
            imageWarningLabel.Padding = new Padding(20, 40, 0, 0);
            imageWarningLabel.Size = new Size(80, 250);
            imageWarningLabel.TabIndex = 23;
            imageWarningLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tileLabel
            // 
            tileLabel.BackColor = Color.White;
            tileLabel.Dock = DockStyle.Top;
            tileLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            tileLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            tileLabel.ImageAlign = ContentAlignment.MiddleLeft;
            tileLabel.Location = new Point(80, 49);
            tileLabel.Name = "tileLabel";
            tileLabel.Size = new Size(631, 32);
            tileLabel.TabIndex = 24;
            tileLabel.Text = "Are you absolutely sure?";
            tileLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmContactsWarningMessage
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(711, 369);
            ControlBox = false;
            Controls.Add(_Label2);
            Controls.Add(tileLabel);
            Controls.Add(imageWarningLabel);
            Controls.Add(messageLabel);
            Controls.Add(ButtonPanel);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmContactsWarningMessage";
            StartPosition = FormStartPosition.CenterScreen;
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        internal Label messageLabel;
        internal ImageList ImageList1;
        internal Panel ButtonPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _noBunifuButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton noBunifuButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _noBunifuButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_noBunifuButton != null)
                {
                    _noBunifuButton.Click -= okTouchButton_ButtonClick;
                }

                _noBunifuButton = value;
                if (_noBunifuButton != null)
                {
                    _noBunifuButton.Click += okTouchButton_ButtonClick;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _yesBunifuButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton yesBunifuButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _yesBunifuButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_yesBunifuButton != null)
                {
                    _yesBunifuButton.Click -= yesTouchButton_Load;
                }

                _yesBunifuButton = value;
                if (_yesBunifuButton != null)
                {
                    _yesBunifuButton.Click += yesTouchButton_Load;
                }
            }
        }

        internal Label Label1;
        private Label _Label2;

        internal Label Label2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label2 != null)
                {
                    _Label2.Click -= Label2_Click;
                }

                _Label2 = value;
                if (_Label2 != null)
                {
                    _Label2.Click += Label2_Click;
                }
            }
        }

        internal Label imageWarningLabel;
        internal Label tileLabel;
    }
}