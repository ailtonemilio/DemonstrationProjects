using System;
using System.Diagnostics;
using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;
namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class MessageBoxConfirmDelete : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxConfirmDelete));
            var BorderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties25 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties26 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties27 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties28 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties29 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties30 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties31 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties32 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            mainMessageLabel = new TextBox();
            ButtonPanel = new Panel();
            _noBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _noBunifuButton.Click += new EventHandler(yesBunifuButton_Click);
            _yesBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _yesBunifuButton.Click += new EventHandler(Button_Abort_Click);
            ImageList1 = new ImageList(components);
            Label4 = new Label();
            _confirmationBunifuTextBox = new BunifuTextBox();
            _confirmationBunifuTextBox.TextChanged += new EventHandler(confirmationBunifuTextBox_TextChanged);
            confirmationPanel = new Panel();
            titleLabel = new Label();
            PictureBox1 = new PictureBox();
            BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ButtonPanel.SuspendLayout();
            confirmationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainMessageLabel
            // 
            mainMessageLabel.BackColor = Color.White;
            mainMessageLabel.BorderStyle = BorderStyle.None;
            mainMessageLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            mainMessageLabel.Location = new Point(21, 123);
            mainMessageLabel.Multiline = true;
            mainMessageLabel.Name = "mainMessageLabel";
            mainMessageLabel.ReadOnly = true;
            mainMessageLabel.Size = new Size(443, 192);
            mainMessageLabel.TabIndex = 23;
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor = Color.White;
            ButtonPanel.Controls.Add(_noBunifuButton);
            ButtonPanel.Controls.Add(_yesBunifuButton);
            ButtonPanel.Location = new Point(135, 398);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(222, 49);
            ButtonPanel.TabIndex = 18;
            // 
            // noBunifuButton
            // 
            _noBunifuButton.AllowToggling = false;
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
            BorderEdges7.BottomLeft = true;
            BorderEdges7.BottomRight = true;
            BorderEdges7.TopLeft = true;
            BorderEdges7.TopRight = true;
            _noBunifuButton.CustomizableEdges = BorderEdges7;
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
            _noBunifuButton.Location = new Point(8, 5);
            _noBunifuButton.Name = "_noBunifuButton";
            StateProperties25.BorderColor = Color.DarkGray;
            StateProperties25.BorderRadius = 3;
            StateProperties25.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties25.BorderThickness = 1;
            StateProperties25.FillColor = Color.DarkGray;
            StateProperties25.ForeColor = Color.White;
            StateProperties25.IconLeftImage = null;
            StateProperties25.IconRightImage = null;
            _noBunifuButton.onHoverState = StateProperties25;
            StateProperties26.BorderColor = Color.IndianRed;
            StateProperties26.BorderRadius = 3;
            StateProperties26.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties26.BorderThickness = 1;
            StateProperties26.FillColor = Color.IndianRed;
            StateProperties26.ForeColor = Color.White;
            StateProperties26.IconLeftImage = null;
            StateProperties26.IconRightImage = null;
            _noBunifuButton.OnPressedState = StateProperties26;
            _noBunifuButton.Size = new Size(82, 37);
            _noBunifuButton.TabIndex = 63;
            _noBunifuButton.TextAlign = ContentAlignment.MiddleCenter;
            _noBunifuButton.TextMarginLeft = 0;
            _noBunifuButton.UseDefaultRadiusAndThickness = true;
            // 
            // yesBunifuButton
            // 
            _yesBunifuButton.AllowToggling = false;
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
            BorderEdges8.BottomLeft = true;
            BorderEdges8.BottomRight = true;
            BorderEdges8.TopLeft = true;
            BorderEdges8.TopRight = true;
            _yesBunifuButton.CustomizableEdges = BorderEdges8;
            _yesBunifuButton.DialogResult = DialogResult.None;
            _yesBunifuButton.DisabledBorderColor = Color.Empty;
            _yesBunifuButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _yesBunifuButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _yesBunifuButton.Enabled = false;
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
            _yesBunifuButton.Location = new Point(102, 5);
            _yesBunifuButton.Name = "_yesBunifuButton";
            StateProperties27.BorderColor = Color.LightCoral;
            StateProperties27.BorderRadius = 3;
            StateProperties27.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties27.BorderThickness = 1;
            StateProperties27.FillColor = Color.LightCoral;
            StateProperties27.ForeColor = Color.White;
            StateProperties27.IconLeftImage = null;
            StateProperties27.IconRightImage = null;
            _yesBunifuButton.onHoverState = StateProperties27;
            StateProperties28.BorderColor = Color.IndianRed;
            StateProperties28.BorderRadius = 3;
            StateProperties28.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties28.BorderThickness = 1;
            StateProperties28.FillColor = Color.IndianRed;
            StateProperties28.ForeColor = Color.White;
            StateProperties28.IconLeftImage = null;
            StateProperties28.IconRightImage = null;
            _yesBunifuButton.OnPressedState = StateProperties28;
            _yesBunifuButton.Size = new Size(105, 37);
            _yesBunifuButton.TabIndex = 62;
            _yesBunifuButton.TextAlign = ContentAlignment.MiddleCenter;
            _yesBunifuButton.TextMarginLeft = 0;
            _yesBunifuButton.UseDefaultRadiusAndThickness = true;
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "caution.png");
            ImageList1.Images.SetKeyName(1, "icon-available.jpg");
            // 
            // Label4
            // 
            Label4.BackColor = Color.White;
            Label4.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label4.ImageAlign = ContentAlignment.MiddleLeft;
            Label4.Location = new Point(3, -2);
            Label4.Name = "Label4";
            Label4.Size = new Size(425, 31);
            Label4.TabIndex = 14;
            Label4.Text = "Please type in the container number to confirm";
            Label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // confirmationBunifuTextBox
            // 
            _confirmationBunifuTextBox.AcceptsReturn = false;
            _confirmationBunifuTextBox.AcceptsTab = false;
            _confirmationBunifuTextBox.AnimationSpeed = 200;
            _confirmationBunifuTextBox.AutoCompleteMode = AutoCompleteMode.None;
            _confirmationBunifuTextBox.AutoCompleteSource = AutoCompleteSource.None;
            _confirmationBunifuTextBox.BackColor = Color.Transparent;
            _confirmationBunifuTextBox.BackgroundImage = (Image)resources.GetObject("confirmationBunifuTextBox.BackgroundImage");
            _confirmationBunifuTextBox.BorderColorActive = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _confirmationBunifuTextBox.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _confirmationBunifuTextBox.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _confirmationBunifuTextBox.BorderColorIdle = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _confirmationBunifuTextBox.BorderRadius = 10;
            _confirmationBunifuTextBox.BorderThickness = 1;
            _confirmationBunifuTextBox.CharacterCasing = CharacterCasing.Upper;
            _confirmationBunifuTextBox.Cursor = Cursors.IBeam;
            _confirmationBunifuTextBox.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _confirmationBunifuTextBox.DefaultText = "";
            _confirmationBunifuTextBox.FillColor = Color.White;
            _confirmationBunifuTextBox.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _confirmationBunifuTextBox.HideSelection = true;
            _confirmationBunifuTextBox.IconLeft = null;
            _confirmationBunifuTextBox.IconLeftCursor = Cursors.IBeam;
            _confirmationBunifuTextBox.IconPadding = 10;
            _confirmationBunifuTextBox.IconRight = null;
            _confirmationBunifuTextBox.IconRightCursor = Cursors.IBeam;
            _confirmationBunifuTextBox.Lines = new string[0];
            _confirmationBunifuTextBox.Location = new Point(7, 29);
            _confirmationBunifuTextBox.MaxLength = 32767;
            _confirmationBunifuTextBox.MinimumSize = new Size(100, 35);
            _confirmationBunifuTextBox.Modified = false;
            _confirmationBunifuTextBox.Multiline = false;
            _confirmationBunifuTextBox.Name = "_confirmationBunifuTextBox";
            StateProperties29.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties29.FillColor = Color.Empty;
            StateProperties29.ForeColor = Color.Empty;
            StateProperties29.PlaceholderForeColor = Color.Empty;
            _confirmationBunifuTextBox.OnActiveState = StateProperties29;
            StateProperties30.BorderColor = Color.Empty;
            StateProperties30.FillColor = Color.White;
            StateProperties30.ForeColor = Color.Empty;
            StateProperties30.PlaceholderForeColor = Color.Silver;
            _confirmationBunifuTextBox.OnDisabledState = StateProperties30;
            StateProperties31.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties31.FillColor = Color.Empty;
            StateProperties31.ForeColor = Color.Empty;
            StateProperties31.PlaceholderForeColor = Color.Empty;
            _confirmationBunifuTextBox.OnHoverState = StateProperties31;
            StateProperties32.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties32.FillColor = Color.White;
            StateProperties32.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties32.PlaceholderForeColor = Color.Empty;
            _confirmationBunifuTextBox.OnIdleState = StateProperties32;
            _confirmationBunifuTextBox.PasswordChar = '\0';
            _confirmationBunifuTextBox.PlaceholderForeColor = Color.Silver;
            _confirmationBunifuTextBox.PlaceholderText = "";
            _confirmationBunifuTextBox.ReadOnly = false;
            _confirmationBunifuTextBox.ScrollBars = ScrollBars.None;
            _confirmationBunifuTextBox.SelectedText = "";
            _confirmationBunifuTextBox.SelectionLength = 0;
            _confirmationBunifuTextBox.SelectionStart = 0;
            _confirmationBunifuTextBox.ShortcutsEnabled = true;
            _confirmationBunifuTextBox.Size = new Size(436, 38);
            _confirmationBunifuTextBox.Style = _Style.Bunifu;
            _confirmationBunifuTextBox.TabIndex = 13;
            _confirmationBunifuTextBox.TextAlign = HorizontalAlignment.Left;
            _confirmationBunifuTextBox.TextMarginBottom = 0;
            _confirmationBunifuTextBox.TextMarginLeft = 5;
            _confirmationBunifuTextBox.TextMarginTop = 0;
            _confirmationBunifuTextBox.TextPlaceholder = "";
            _confirmationBunifuTextBox.UseSystemPasswordChar = false;
            _confirmationBunifuTextBox.WordWrap = true;
            // 
            // confirmationPanel
            // 
            confirmationPanel.Controls.Add(Label4);
            confirmationPanel.Controls.Add(_confirmationBunifuTextBox);
            confirmationPanel.Location = new Point(21, 321);
            confirmationPanel.Name = "confirmationPanel";
            confirmationPanel.Size = new Size(445, 71);
            confirmationPanel.TabIndex = 22;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.White;
            titleLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titleLabel.ImageAlign = ContentAlignment.MiddleLeft;
            titleLabel.Location = new Point(9, 83);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(455, 40);
            titleLabel.TabIndex = 172;
            titleLabel.Text = "Are you absolutely sure?";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.warning;
            PictureBox1.Location = new Point(193, 5);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(87, 78);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 173;
            PictureBox1.TabStop = false;
            // 
            // BunifuElipse1
            // 
            BunifuElipse1.ElipseRadius = 30;
            BunifuElipse1.TargetControl = this;
            // 
            // MessageBoxConfirmDelete
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(478, 465);
            Controls.Add(PictureBox1);
            Controls.Add(titleLabel);
            Controls.Add(mainMessageLabel);
            Controls.Add(ButtonPanel);
            Controls.Add(confirmationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageBoxConfirmDelete";
            Text = "MessageBoxConfirmDelete";
            ButtonPanel.ResumeLayout(false);
            confirmationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal TextBox mainMessageLabel;
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
                    _noBunifuButton.Click -= yesBunifuButton_Click;
                }

                _noBunifuButton = value;
                if (_noBunifuButton != null)
                {
                    _noBunifuButton.Click += yesBunifuButton_Click;
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
                    _yesBunifuButton.Click -= Button_Abort_Click;
                }

                _yesBunifuButton = value;
                if (_yesBunifuButton != null)
                {
                    _yesBunifuButton.Click += Button_Abort_Click;
                }
            }
        }

        internal ImageList ImageList1;
        internal Label Label4;
        private BunifuTextBox _confirmationBunifuTextBox;

        internal BunifuTextBox confirmationBunifuTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _confirmationBunifuTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_confirmationBunifuTextBox != null)
                {
                    _confirmationBunifuTextBox.TextChanged -= confirmationBunifuTextBox_TextChanged;
                }

                _confirmationBunifuTextBox = value;
                if (_confirmationBunifuTextBox != null)
                {
                    _confirmationBunifuTextBox.TextChanged += confirmationBunifuTextBox_TextChanged;
                }
            }
        }

        internal Panel confirmationPanel;
        internal Label titleLabel;
        internal PictureBox PictureBox1;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
    }
}