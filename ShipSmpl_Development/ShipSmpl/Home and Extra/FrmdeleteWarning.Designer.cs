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
    public partial class FrmdeleteWarning : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmdeleteWarning));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Label1 = new Label();
            ButtonPanel = new Panel();
            _noBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _noBunifuButton.Click += new EventHandler(noBunifuButton_Click);
            _yesBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _yesBunifuButton.Click += new EventHandler(yesBunifuButton_Click);
            _Label2 = new Label();
            _Label2.Click += new EventHandler(Label2_Click);
            _Label2.MouseHover += new EventHandler(Label2_MouseHover);
            _Label2.MouseLeave += new EventHandler(Label2_MouseLeave);
            ImageList1 = new ImageList(components);
            imageWarningLabel = new Label();
            tileLabel = new Label();
            _confirmationBunifuTextBox = new BunifuTextBox();
            _confirmationBunifuTextBox.TextChanged += new EventHandler(confirmationBunifuTextBox_TextChanged);
            Label4 = new Label();
            confirmationPanel = new Panel();
            mainMessageLabel = new TextBox();
            ButtonPanel.SuspendLayout();
            confirmationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.BackColor = Color.IndianRed;
            Label1.Dock = DockStyle.Top;
            Label1.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.IndianRed;
            Label1.Location = new Point(0, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(693, 49);
            Label1.TabIndex = 1;
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor = Color.White;
            ButtonPanel.Controls.Add(_noBunifuButton);
            ButtonPanel.Controls.Add(_yesBunifuButton);
            ButtonPanel.Dock = DockStyle.Bottom;
            ButtonPanel.Location = new Point(0, 299);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(693, 62);
            ButtonPanel.TabIndex = 4;
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
            _noBunifuButton.Location = new Point(457, 5);
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
            _yesBunifuButton.Location = new Point(551, 5);
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
            // Label2
            // 
            _Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _Label2.BackColor = Color.IndianRed;
            _Label2.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label2.ForeColor = Color.White;
            _Label2.Location = new Point(645, -2);
            _Label2.Margin = new Padding(0);
            _Label2.Name = "_Label2";
            _Label2.Size = new Size(48, 49);
            _Label2.TabIndex = 7;
            _Label2.Text = "🗙";
            _Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "caution.png");
            ImageList1.Images.SetKeyName(1, "icon-available.jpg");
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
            imageWarningLabel.TabIndex = 8;
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
            tileLabel.Size = new Size(613, 32);
            tileLabel.TabIndex = 11;
            tileLabel.Text = "Are you absolutely sure?";
            tileLabel.TextAlign = ContentAlignment.MiddleLeft;
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
            _confirmationBunifuTextBox.BorderColorActive = Color.DodgerBlue;
            _confirmationBunifuTextBox.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _confirmationBunifuTextBox.BorderColorHover = Color.SteelBlue;
            _confirmationBunifuTextBox.BorderColorIdle = Color.DodgerBlue;
            _confirmationBunifuTextBox.BorderRadius = 10;
            _confirmationBunifuTextBox.BorderThickness = 2;
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
            StateProperties5.BorderColor = Color.DodgerBlue;
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            _confirmationBunifuTextBox.OnActiveState = StateProperties5;
            StateProperties6.BorderColor = Color.Empty;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Silver;
            _confirmationBunifuTextBox.OnDisabledState = StateProperties6;
            StateProperties7.BorderColor = Color.SteelBlue;
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            _confirmationBunifuTextBox.OnHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.DodgerBlue;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties8.PlaceholderForeColor = Color.Empty;
            _confirmationBunifuTextBox.OnIdleState = StateProperties8;
            _confirmationBunifuTextBox.PasswordChar = '\0';
            _confirmationBunifuTextBox.PlaceholderForeColor = Color.Silver;
            _confirmationBunifuTextBox.PlaceholderText = "";
            _confirmationBunifuTextBox.ReadOnly = false;
            _confirmationBunifuTextBox.ScrollBars = ScrollBars.None;
            _confirmationBunifuTextBox.SelectedText = "";
            _confirmationBunifuTextBox.SelectionLength = 0;
            _confirmationBunifuTextBox.SelectionStart = 0;
            _confirmationBunifuTextBox.ShortcutsEnabled = true;
            _confirmationBunifuTextBox.Size = new Size(571, 38);
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
            // Label4
            // 
            Label4.BackColor = Color.White;
            Label4.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label4.ImageAlign = ContentAlignment.MiddleLeft;
            Label4.Location = new Point(3, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(425, 31);
            Label4.TabIndex = 14;
            Label4.Text = "Please type in the container number to confirm";
            Label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // confirmationPanel
            // 
            confirmationPanel.Controls.Add(Label4);
            confirmationPanel.Controls.Add(_confirmationBunifuTextBox);
            confirmationPanel.Location = new Point(73, 227);
            confirmationPanel.Name = "confirmationPanel";
            confirmationPanel.Size = new Size(620, 71);
            confirmationPanel.TabIndex = 15;
            // 
            // mainMessageLabel
            // 
            mainMessageLabel.BackColor = Color.White;
            mainMessageLabel.BorderStyle = BorderStyle.None;
            mainMessageLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            mainMessageLabel.Location = new Point(86, 84);
            mainMessageLabel.Multiline = true;
            mainMessageLabel.Name = "mainMessageLabel";
            mainMessageLabel.ReadOnly = true;
            mainMessageLabel.Size = new Size(582, 140);
            mainMessageLabel.TabIndex = 16;
            // 
            // FrmdeleteWarning
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(693, 361);
            ControlBox = false;
            Controls.Add(confirmationPanel);
            Controls.Add(mainMessageLabel);
            Controls.Add(tileLabel);
            Controls.Add(imageWarningLabel);
            Controls.Add(_Label2);
            Controls.Add(ButtonPanel);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmdeleteWarning";
            StartPosition = FormStartPosition.CenterScreen;
            ButtonPanel.ResumeLayout(false);
            confirmationPanel.ResumeLayout(false);
            Load += new EventHandler(FrmWarningBox_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label1;
        internal Panel ButtonPanel;
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
                    _Label2.MouseHover -= Label2_MouseHover;
                    _Label2.MouseLeave -= Label2_MouseLeave;
                }

                _Label2 = value;
                if (_Label2 != null)
                {
                    _Label2.Click += Label2_Click;
                    _Label2.MouseHover += Label2_MouseHover;
                    _Label2.MouseLeave += Label2_MouseLeave;
                }
            }
        }

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
                    _noBunifuButton.Click -= noBunifuButton_Click;
                }

                _noBunifuButton = value;
                if (_noBunifuButton != null)
                {
                    _noBunifuButton.Click += noBunifuButton_Click;
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
                    _yesBunifuButton.Click -= yesBunifuButton_Click;
                }

                _yesBunifuButton = value;
                if (_yesBunifuButton != null)
                {
                    _yesBunifuButton.Click += yesBunifuButton_Click;
                }
            }
        }

        internal ImageList ImageList1;
        internal Label imageWarningLabel;
        internal Label tileLabel;
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

        internal Label Label4;
        internal Panel confirmationPanel;
        internal TextBox mainMessageLabel;
    }
}