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
    public partial class FrmLoginWindow : Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginWindow));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this._loginButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this._BunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this._usernameTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this._passwordTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.BunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Image = global::ShipSmpl.My.Resources.Resources.SSWithName;
            this.PictureBox1.Location = new System.Drawing.Point(144, 5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(145, 87);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 4;
            this.PictureBox1.TabStop = false;
            // 
            // warningLabel
            // 
            this.warningLabel.BackColor = System.Drawing.Color.Transparent;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.warningLabel.Location = new System.Drawing.Point(12, 192);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(384, 31);
            this.warningLabel.TabIndex = 7;
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _loginButton
            // 
            this._loginButton.AllowToggling = false;
            this._loginButton.AnimationSpeed = 200;
            this._loginButton.AutoGenerateColors = false;
            this._loginButton.BackColor = System.Drawing.Color.Transparent;
            this._loginButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_loginButton.BackgroundImage")));
            this._loginButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this._loginButton.ButtonText = "Login";
            this._loginButton.ButtonTextMarginLeft = 0;
            this._loginButton.ColorContrastOnClick = 45;
            this._loginButton.ColorContrastOnHover = 45;
            this._loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this._loginButton.CustomizableEdges = borderEdges3;
            this._loginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this._loginButton.DisabledBorderColor = System.Drawing.Color.Empty;
            this._loginButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this._loginButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this._loginButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this._loginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._loginButton.ForeColor = System.Drawing.Color.White;
            this._loginButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this._loginButton.IconMarginLeft = 11;
            this._loginButton.IconPadding = 10;
            this._loginButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this._loginButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._loginButton.IdleBorderRadius = 3;
            this._loginButton.IdleBorderThickness = 1;
            this._loginButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._loginButton.IdleIconLeftImage = null;
            this._loginButton.IdleIconRightImage = null;
            this._loginButton.IndicateFocus = false;
            this._loginButton.Location = new System.Drawing.Point(146, 225);
            this._loginButton.Name = "_loginButton";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            stateProperties13.BorderRadius = 3;
            stateProperties13.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties13.BorderThickness = 1;
            stateProperties13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            stateProperties13.ForeColor = System.Drawing.Color.White;
            stateProperties13.IconLeftImage = null;
            stateProperties13.IconRightImage = null;
            this._loginButton.onHoverState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            stateProperties14.BorderRadius = 3;
            stateProperties14.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties14.BorderThickness = 1;
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            stateProperties14.ForeColor = System.Drawing.Color.White;
            stateProperties14.IconLeftImage = null;
            stateProperties14.IconRightImage = null;
            this._loginButton.OnPressedState = stateProperties14;
            this._loginButton.Size = new System.Drawing.Size(111, 31);
            this._loginButton.TabIndex = 9;
            this._loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._loginButton.TextMarginLeft = 0;
            this._loginButton.UseDefaultRadiusAndThickness = true;
            this._loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // _BunifuButton2
            // 
            this._BunifuButton2.AllowToggling = false;
            this._BunifuButton2.AnimationSpeed = 200;
            this._BunifuButton2.AutoGenerateColors = false;
            this._BunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this._BunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._BunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_BunifuButton2.BackgroundImage")));
            this._BunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this._BunifuButton2.ButtonText = "×";
            this._BunifuButton2.ButtonTextMarginLeft = 0;
            this._BunifuButton2.ColorContrastOnClick = 45;
            this._BunifuButton2.ColorContrastOnHover = 45;
            this._BunifuButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this._BunifuButton2.CustomizableEdges = borderEdges4;
            this._BunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this._BunifuButton2.DisabledBorderColor = System.Drawing.Color.Empty;
            this._BunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this._BunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this._BunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this._BunifuButton2.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BunifuButton2.ForeColor = System.Drawing.Color.White;
            this._BunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this._BunifuButton2.IconMarginLeft = 0;
            this._BunifuButton2.IconPadding = 0;
            this._BunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this._BunifuButton2.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._BunifuButton2.IdleBorderRadius = 25;
            this._BunifuButton2.IdleBorderThickness = 1;
            this._BunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._BunifuButton2.IdleIconLeftImage = null;
            this._BunifuButton2.IdleIconRightImage = null;
            this._BunifuButton2.IndicateFocus = false;
            this._BunifuButton2.Location = new System.Drawing.Point(380, 0);
            this._BunifuButton2.Name = "_BunifuButton2";
            stateProperties15.BorderColor = System.Drawing.Color.Teal;
            stateProperties15.BorderRadius = 25;
            stateProperties15.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties15.BorderThickness = 1;
            stateProperties15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            stateProperties15.ForeColor = System.Drawing.Color.White;
            stateProperties15.IconLeftImage = null;
            stateProperties15.IconRightImage = null;
            this._BunifuButton2.onHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties16.BorderRadius = 25;
            stateProperties16.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties16.BorderThickness = 1;
            stateProperties16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties16.ForeColor = System.Drawing.Color.White;
            stateProperties16.IconLeftImage = null;
            stateProperties16.IconRightImage = null;
            this._BunifuButton2.OnPressedState = stateProperties16;
            this._BunifuButton2.Size = new System.Drawing.Size(29, 31);
            this._BunifuButton2.TabIndex = 10;
            this._BunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._BunifuButton2.TextMarginLeft = 0;
            this._BunifuButton2.UseDefaultRadiusAndThickness = true;
            this._BunifuButton2.Click += new System.EventHandler(this.BunifuButton2_Click);
            // 
            // BunifuElipse1
            // 
            this.BunifuElipse1.ElipseRadius = 5;
            this.BunifuElipse1.TargetControl = this.Panel1;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.Controls.Add(this._usernameTextBox);
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Location = new System.Drawing.Point(92, 129);
            this.Panel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(241, 28);
            this.Panel1.TabIndex = 13;
            // 
            // _usernameTextBox
            // 
            this._usernameTextBox.AcceptsReturn = false;
            this._usernameTextBox.AcceptsTab = false;
            this._usernameTextBox.AnimationSpeed = 200;
            this._usernameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this._usernameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this._usernameTextBox.BackColor = System.Drawing.Color.Transparent;
            this._usernameTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_usernameTextBox.BackgroundImage")));
            this._usernameTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this._usernameTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this._usernameTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this._usernameTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this._usernameTextBox.BorderRadius = 1;
            this._usernameTextBox.BorderThickness = 1;
            this._usernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this._usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._usernameTextBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this._usernameTextBox.DefaultText = "";
            this._usernameTextBox.FillColor = System.Drawing.Color.White;
            this._usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._usernameTextBox.HideSelection = true;
            this._usernameTextBox.IconLeft = null;
            this._usernameTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this._usernameTextBox.IconPadding = 10;
            this._usernameTextBox.IconRight = null;
            this._usernameTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this._usernameTextBox.Lines = new string[0];
            this._usernameTextBox.Location = new System.Drawing.Point(28, -3);
            this._usernameTextBox.MaxLength = 32767;
            this._usernameTextBox.MinimumSize = new System.Drawing.Size(100, 34);
            this._usernameTextBox.Modified = false;
            this._usernameTextBox.Multiline = false;
            this._usernameTextBox.Name = "_usernameTextBox";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this._usernameTextBox.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.Empty;
            stateProperties18.FillColor = System.Drawing.Color.White;
            stateProperties18.ForeColor = System.Drawing.Color.Empty;
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.Silver;
            this._usernameTextBox.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this._usernameTextBox.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this._usernameTextBox.OnIdleState = stateProperties20;
            this._usernameTextBox.PasswordChar = '\0';
            this._usernameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this._usernameTextBox.PlaceholderText = "USERNAME";
            this._usernameTextBox.ReadOnly = false;
            this._usernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._usernameTextBox.SelectedText = "";
            this._usernameTextBox.SelectionLength = 0;
            this._usernameTextBox.SelectionStart = 0;
            this._usernameTextBox.ShortcutsEnabled = true;
            this._usernameTextBox.Size = new System.Drawing.Size(216, 34);
            this._usernameTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this._usernameTextBox.TabIndex = 17;
            this._usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this._usernameTextBox.TextMarginBottom = 0;
            this._usernameTextBox.TextMarginLeft = 5;
            this._usernameTextBox.TextMarginTop = 0;
            this._usernameTextBox.TextPlaceholder = "USERNAME";
            this._usernameTextBox.UseSystemPasswordChar = false;
            this._usernameTextBox.WordWrap = true;
            this._usernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTextBox_KeyDown);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PictureBox2.Image = global::ShipSmpl.My.Resources.Resources.user;
            this.PictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Padding = new System.Windows.Forms.Padding(5);
            this.PictureBox2.Size = new System.Drawing.Size(32, 30);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 16;
            this.PictureBox2.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.Controls.Add(this._passwordTextBox);
            this.Panel2.Controls.Add(this.PictureBox3);
            this.Panel2.Location = new System.Drawing.Point(92, 162);
            this.Panel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(241, 28);
            this.Panel2.TabIndex = 14;
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.AcceptsReturn = false;
            this._passwordTextBox.AcceptsTab = false;
            this._passwordTextBox.AnimationSpeed = 200;
            this._passwordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this._passwordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this._passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this._passwordTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_passwordTextBox.BackgroundImage")));
            this._passwordTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this._passwordTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this._passwordTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this._passwordTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this._passwordTextBox.BorderRadius = 1;
            this._passwordTextBox.BorderThickness = 1;
            this._passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this._passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._passwordTextBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this._passwordTextBox.DefaultText = "";
            this._passwordTextBox.FillColor = System.Drawing.Color.White;
            this._passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._passwordTextBox.HideSelection = true;
            this._passwordTextBox.IconLeft = null;
            this._passwordTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this._passwordTextBox.IconPadding = 10;
            this._passwordTextBox.IconRight = null;
            this._passwordTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this._passwordTextBox.Lines = new string[0];
            this._passwordTextBox.Location = new System.Drawing.Point(28, -3);
            this._passwordTextBox.MaxLength = 32767;
            this._passwordTextBox.MinimumSize = new System.Drawing.Size(100, 34);
            this._passwordTextBox.Modified = false;
            this._passwordTextBox.Multiline = false;
            this._passwordTextBox.Name = "_passwordTextBox";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this._passwordTextBox.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.Empty;
            stateProperties22.FillColor = System.Drawing.Color.White;
            stateProperties22.ForeColor = System.Drawing.Color.Empty;
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.Silver;
            this._passwordTextBox.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this._passwordTextBox.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this._passwordTextBox.OnIdleState = stateProperties24;
            this._passwordTextBox.PasswordChar = '•';
            this._passwordTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this._passwordTextBox.PlaceholderText = "PASSWORD";
            this._passwordTextBox.ReadOnly = false;
            this._passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._passwordTextBox.SelectedText = "";
            this._passwordTextBox.SelectionLength = 0;
            this._passwordTextBox.SelectionStart = 0;
            this._passwordTextBox.ShortcutsEnabled = true;
            this._passwordTextBox.Size = new System.Drawing.Size(216, 34);
            this._passwordTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this._passwordTextBox.TabIndex = 18;
            this._passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this._passwordTextBox.TextMarginBottom = 0;
            this._passwordTextBox.TextMarginLeft = 5;
            this._passwordTextBox.TextMarginTop = 0;
            this._passwordTextBox.TextPlaceholder = "PASSWORD";
            this._passwordTextBox.UseSystemPasswordChar = false;
            this._passwordTextBox.WordWrap = true;
            this._passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PictureBox3.Image = global::ShipSmpl.My.Resources.Resources.password;
            this.PictureBox3.Location = new System.Drawing.Point(-3, -1);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Padding = new System.Windows.Forms.Padding(5);
            this.PictureBox3.Size = new System.Drawing.Size(32, 30);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 17;
            this.PictureBox3.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(87, 100);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 20);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Login";
            // 
            // BunifuElipse2
            // 
            this.BunifuElipse2.ElipseRadius = 15;
            this.BunifuElipse2.TargetControl = this;
            // 
            // BunifuElipse3
            // 
            this.BunifuElipse3.ElipseRadius = 5;
            this.BunifuElipse3.TargetControl = this.Panel2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(166, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Development";
            // 
            // FrmLoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(408, 276);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this._BunifuButton2);
            this.Controls.Add(this._loginButton);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Closed += new System.EventHandler(this.FrmLoginWindow_Closed);
            this.Load += new System.EventHandler(this.FrmLoginWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal PictureBox PictureBox1;
        internal Label warningLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _loginButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton loginButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _loginButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_loginButton != null)
                {
                    _loginButton.Click -= loginButton_Click;
                }

                _loginButton = value;
                if (_loginButton != null)
                {
                    _loginButton.Click += loginButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _BunifuButton2;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuButton2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuButton2 != null)
                {
                    _BunifuButton2.Click -= BunifuButton2_Click;
                }

                _BunifuButton2 = value;
                if (_BunifuButton2 != null)
                {
                    _BunifuButton2.Click += BunifuButton2_Click;
                }
            }
        }

        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        internal Panel Panel1;
        internal Panel Panel2;
        private BunifuTextBox _passwordTextBox;

        internal BunifuTextBox passwordTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _passwordTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_passwordTextBox != null)
                {
                    _passwordTextBox.KeyDown -= passwordTextBox_KeyDown;
                }

                _passwordTextBox = value;
                if (_passwordTextBox != null)
                {
                    _passwordTextBox.KeyDown += passwordTextBox_KeyDown;
                }
            }
        }

        internal PictureBox PictureBox3;
        private BunifuTextBox _usernameTextBox;

        internal BunifuTextBox usernameTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _usernameTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_usernameTextBox != null)
                {
                    _usernameTextBox.KeyDown -= usernameTextBox_KeyDown;
                }

                _usernameTextBox = value;
                if (_usernameTextBox != null)
                {
                    _usernameTextBox.KeyDown += usernameTextBox_KeyDown;
                }
            }
        }

        internal PictureBox PictureBox2;
        internal Label Label1;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse2;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse3;
        internal Label label2;
    }
}