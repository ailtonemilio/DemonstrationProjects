using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAddEditDestination : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditDestination));
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties17 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties18 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties19 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties20 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties21 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties22 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties23 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties24 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Label34 = new Label();
            Label60 = new Label();
            Label55 = new Label();
            Label11 = new Label();
            addressTextBox = new BunifuTextBox();
            Label56 = new Label();
            _doneAddressButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _doneAddressButton.Click += new EventHandler(doneAddressButton_Click);
            _closeAddressButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _closeAddressButton.Click += new EventHandler(closeAddressButton_Click);
            Label1 = new Label();
            tbCoordinates = new BunifuTextBox();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label12 = new Label();
            tbCityName = new BunifuTextBox();
            tbRegionName = new BunifuTextBox();
            tbCountryCode = new BunifuTextBox();
            SuspendLayout();
            // 
            // Label34
            // 
            Label34.Anchor = AnchorStyles.Left;
            Label34.AutoSize = true;
            Label34.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label34.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label34.Location = new Point(122, 172);
            Label34.Name = "Label34";
            Label34.Size = new Size(40, 21);
            Label34.TabIndex = 228;
            Label34.Text = "City:";
            // 
            // Label60
            // 
            Label60.AutoSize = true;
            Label60.BackColor = Color.Transparent;
            Label60.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label60.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label60.Location = new Point(25, 58);
            Label60.Name = "Label60";
            Label60.Padding = new Padding(0, 0, 0, 10);
            Label60.Size = new Size(182, 30);
            Label60.TabIndex = 218;
            Label60.Text = "Add New Destination:";
            // 
            // Label55
            // 
            Label55.Anchor = AnchorStyles.Left;
            Label55.AutoSize = true;
            Label55.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label55.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label55.Location = new Point(57, 134);
            Label55.Name = "Label55";
            Label55.Size = new Size(108, 21);
            Label55.TabIndex = 220;
            Label55.Text = "Region Name:";
            // 
            // Label11
            // 
            Label11.Anchor = AnchorStyles.Left;
            Label11.AutoSize = true;
            Label11.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label11.Location = new Point(53, 91);
            Label11.Name = "Label11";
            Label11.Size = new Size(109, 21);
            Label11.TabIndex = 219;
            Label11.Text = "Country Code:";
            // 
            // addressTextBox
            // 
            addressTextBox.AcceptsReturn = false;
            addressTextBox.AcceptsTab = false;
            addressTextBox.AnimationSpeed = 200;
            addressTextBox.AutoCompleteMode = AutoCompleteMode.None;
            addressTextBox.AutoCompleteSource = AutoCompleteSource.None;
            addressTextBox.BackColor = Color.Transparent;
            addressTextBox.BackgroundImage = (Image)resources.GetObject("addressTextBox.BackgroundImage");
            addressTextBox.BorderColorActive = Color.DodgerBlue;
            addressTextBox.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            addressTextBox.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            addressTextBox.BorderColorIdle = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(128)));
            addressTextBox.BorderRadius = 5;
            addressTextBox.BorderThickness = 1;
            addressTextBox.CharacterCasing = CharacterCasing.Upper;
            addressTextBox.Cursor = Cursors.IBeam;
            addressTextBox.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            addressTextBox.DefaultText = "";
            addressTextBox.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            addressTextBox.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            addressTextBox.HideSelection = true;
            addressTextBox.IconLeft = null;
            addressTextBox.IconLeftCursor = Cursors.IBeam;
            addressTextBox.IconPadding = 10;
            addressTextBox.IconRight = null;
            addressTextBox.IconRightCursor = Cursors.IBeam;
            addressTextBox.Lines = new string[0];
            addressTextBox.Location = new Point(168, 235);
            addressTextBox.MaxLength = 32767;
            addressTextBox.MinimumSize = new Size(100, 35);
            addressTextBox.Modified = false;
            addressTextBox.Multiline = false;
            addressTextBox.Name = "addressTextBox";
            StateProperties1.BorderColor = Color.DodgerBlue;
            StateProperties1.FillColor = Color.Empty;
            StateProperties1.ForeColor = Color.Empty;
            StateProperties1.PlaceholderForeColor = Color.Empty;
            addressTextBox.OnActiveState = StateProperties1;
            StateProperties2.BorderColor = Color.Empty;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.Empty;
            StateProperties2.PlaceholderForeColor = Color.Silver;
            addressTextBox.OnDisabledState = StateProperties2;
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            addressTextBox.OnHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(128)));
            StateProperties4.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties4.PlaceholderForeColor = Color.Empty;
            addressTextBox.OnIdleState = StateProperties4;
            addressTextBox.PasswordChar = '\0';
            addressTextBox.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            addressTextBox.PlaceholderText = "";
            addressTextBox.ReadOnly = false;
            addressTextBox.ScrollBars = ScrollBars.None;
            addressTextBox.SelectedText = "";
            addressTextBox.SelectionLength = 0;
            addressTextBox.SelectionStart = 0;
            addressTextBox.ShortcutsEnabled = true;
            addressTextBox.Size = new Size(238, 48);
            addressTextBox.Style = _Style.Bunifu;
            addressTextBox.TabIndex = 221;
            addressTextBox.TextAlign = HorizontalAlignment.Left;
            addressTextBox.TextMarginBottom = 0;
            addressTextBox.TextMarginLeft = 5;
            addressTextBox.TextMarginTop = 0;
            addressTextBox.TextPlaceholder = "";
            addressTextBox.UseSystemPasswordChar = false;
            addressTextBox.WordWrap = true;
            // 
            // Label56
            // 
            Label56.Anchor = AnchorStyles.Left;
            Label56.AutoSize = true;
            Label56.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label56.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label56.Location = new Point(93, 235);
            Label56.Name = "Label56";
            Label56.Size = new Size(69, 21);
            Label56.TabIndex = 222;
            Label56.Text = "Address:";
            // 
            // doneAddressButton
            // 
            _doneAddressButton.AllowToggling = false;
            _doneAddressButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _doneAddressButton.AnimationSpeed = 200;
            _doneAddressButton.AutoGenerateColors = false;
            _doneAddressButton.BackColor = Color.Transparent;
            _doneAddressButton.BackColor1 = Color.Teal;
            _doneAddressButton.BackgroundImage = (Image)resources.GetObject("doneAddressButton.BackgroundImage");
            _doneAddressButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _doneAddressButton.ButtonText = "Save";
            _doneAddressButton.ButtonTextMarginLeft = 0;
            _doneAddressButton.ColorContrastOnClick = 45;
            _doneAddressButton.ColorContrastOnHover = 45;
            _doneAddressButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _doneAddressButton.CustomizableEdges = BorderEdges1;
            _doneAddressButton.DialogResult = DialogResult.None;
            _doneAddressButton.DisabledBorderColor = Color.Empty;
            _doneAddressButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _doneAddressButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _doneAddressButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _doneAddressButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _doneAddressButton.ForeColor = Color.White;
            _doneAddressButton.IconLeftCursor = Cursors.Hand;
            _doneAddressButton.IconMarginLeft = 11;
            _doneAddressButton.IconPadding = 10;
            _doneAddressButton.IconRightCursor = Cursors.Hand;
            _doneAddressButton.IdleBorderColor = Color.Teal;
            _doneAddressButton.IdleBorderRadius = 3;
            _doneAddressButton.IdleBorderThickness = 1;
            _doneAddressButton.IdleFillColor = Color.Teal;
            _doneAddressButton.IdleIconLeftImage = null;
            _doneAddressButton.IdleIconRightImage = null;
            _doneAddressButton.IndicateFocus = true;
            _doneAddressButton.Location = new Point(259, 299);
            _doneAddressButton.Name = "_doneAddressButton";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _doneAddressButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Teal;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _doneAddressButton.OnPressedState = StateProperties6;
            _doneAddressButton.Size = new Size(79, 33);
            _doneAddressButton.TabIndex = 223;
            _doneAddressButton.TextAlign = ContentAlignment.MiddleCenter;
            _doneAddressButton.TextMarginLeft = 0;
            _doneAddressButton.UseDefaultRadiusAndThickness = true;
            // 
            // closeAddressButton
            // 
            _closeAddressButton.AccessibleRole = AccessibleRole.Clock;
            _closeAddressButton.AllowToggling = false;
            _closeAddressButton.AnimationSpeed = 200;
            _closeAddressButton.AutoGenerateColors = false;
            _closeAddressButton.BackColor = Color.Transparent;
            _closeAddressButton.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _closeAddressButton.BackgroundImage = (Image)resources.GetObject("closeAddressButton.BackgroundImage");
            _closeAddressButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _closeAddressButton.ButtonText = "Close";
            _closeAddressButton.ButtonTextMarginLeft = 0;
            _closeAddressButton.ColorContrastOnClick = 45;
            _closeAddressButton.ColorContrastOnHover = 45;
            _closeAddressButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _closeAddressButton.CustomizableEdges = BorderEdges2;
            _closeAddressButton.DialogResult = DialogResult.None;
            _closeAddressButton.DisabledBorderColor = Color.Empty;
            _closeAddressButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _closeAddressButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _closeAddressButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _closeAddressButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeAddressButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeAddressButton.IconLeftCursor = Cursors.Hand;
            _closeAddressButton.IconMarginLeft = 11;
            _closeAddressButton.IconPadding = 10;
            _closeAddressButton.IconRightCursor = Cursors.Hand;
            _closeAddressButton.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeAddressButton.IdleBorderRadius = 3;
            _closeAddressButton.IdleBorderThickness = 1;
            _closeAddressButton.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _closeAddressButton.IdleIconLeftImage = null;
            _closeAddressButton.IdleIconRightImage = null;
            _closeAddressButton.IndicateFocus = true;
            _closeAddressButton.Location = new Point(344, 299);
            _closeAddressButton.Name = "_closeAddressButton";
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            StateProperties7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _closeAddressButton.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _closeAddressButton.OnPressedState = StateProperties8;
            _closeAddressButton.Size = new Size(88, 33);
            _closeAddressButton.TabIndex = 224;
            _closeAddressButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeAddressButton.TextMarginLeft = 0;
            _closeAddressButton.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Left;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(66, 199);
            Label1.Name = "Label1";
            Label1.Size = new Size(97, 21);
            Label1.TabIndex = 229;
            Label1.Text = "Coordinates:";
            // 
            // tbCoordinates
            // 
            tbCoordinates.AcceptsReturn = false;
            tbCoordinates.AcceptsTab = false;
            tbCoordinates.AnimationSpeed = 200;
            tbCoordinates.AutoCompleteMode = AutoCompleteMode.None;
            tbCoordinates.AutoCompleteSource = AutoCompleteSource.None;
            tbCoordinates.BackColor = Color.Transparent;
            tbCoordinates.BackgroundImage = (Image)resources.GetObject("tbCoordinates.BackgroundImage");
            tbCoordinates.BorderColorActive = Color.DodgerBlue;
            tbCoordinates.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            tbCoordinates.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            tbCoordinates.BorderColorIdle = Color.Gray;
            tbCoordinates.BorderRadius = 5;
            tbCoordinates.BorderThickness = 1;
            tbCoordinates.CharacterCasing = CharacterCasing.Upper;
            tbCoordinates.Cursor = Cursors.IBeam;
            tbCoordinates.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            tbCoordinates.DefaultText = "";
            tbCoordinates.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            tbCoordinates.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            tbCoordinates.HideSelection = true;
            tbCoordinates.IconLeft = null;
            tbCoordinates.IconLeftCursor = Cursors.IBeam;
            tbCoordinates.IconPadding = 10;
            tbCoordinates.IconRight = null;
            tbCoordinates.IconRightCursor = Cursors.IBeam;
            tbCoordinates.Lines = new string[0];
            tbCoordinates.Location = new Point(168, 199);
            tbCoordinates.MaxLength = 32767;
            tbCoordinates.MinimumSize = new Size(100, 30);
            tbCoordinates.Modified = false;
            tbCoordinates.Multiline = false;
            tbCoordinates.Name = "tbCoordinates";
            StateProperties9.BorderColor = Color.DodgerBlue;
            StateProperties9.FillColor = Color.Empty;
            StateProperties9.ForeColor = Color.Empty;
            StateProperties9.PlaceholderForeColor = Color.Empty;
            tbCoordinates.OnActiveState = StateProperties9;
            StateProperties10.BorderColor = Color.Empty;
            StateProperties10.FillColor = Color.White;
            StateProperties10.ForeColor = Color.Empty;
            StateProperties10.PlaceholderForeColor = Color.Silver;
            tbCoordinates.OnDisabledState = StateProperties10;
            StateProperties11.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties11.FillColor = Color.Empty;
            StateProperties11.ForeColor = Color.Empty;
            StateProperties11.PlaceholderForeColor = Color.Empty;
            tbCoordinates.OnHoverState = StateProperties11;
            StateProperties12.BorderColor = Color.Gray;
            StateProperties12.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties12.PlaceholderForeColor = Color.Empty;
            tbCoordinates.OnIdleState = StateProperties12;
            tbCoordinates.PasswordChar = '\0';
            tbCoordinates.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            tbCoordinates.PlaceholderText = "";
            tbCoordinates.ReadOnly = false;
            tbCoordinates.ScrollBars = ScrollBars.None;
            tbCoordinates.SelectedText = "";
            tbCoordinates.SelectionLength = 0;
            tbCoordinates.SelectionStart = 0;
            tbCoordinates.ShortcutsEnabled = true;
            tbCoordinates.Size = new Size(222, 30);
            tbCoordinates.Style = _Style.Bunifu;
            tbCoordinates.TabIndex = 230;
            tbCoordinates.TextAlign = HorizontalAlignment.Left;
            tbCoordinates.TextMarginBottom = 0;
            tbCoordinates.TextMarginLeft = 5;
            tbCoordinates.TextMarginTop = 0;
            tbCoordinates.TextPlaceholder = "";
            tbCoordinates.UseSystemPasswordChar = false;
            tbCoordinates.WordWrap = true;
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(393, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(51, 39);
            _closeLabel.TabIndex = 232;
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
            Label12.Size = new Size(444, 39);
            Label12.TabIndex = 231;
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbCityName
            // 
            tbCityName.AcceptsReturn = false;
            tbCityName.AcceptsTab = false;
            tbCityName.AnimationSpeed = 200;
            tbCityName.AutoCompleteMode = AutoCompleteMode.None;
            tbCityName.AutoCompleteSource = AutoCompleteSource.None;
            tbCityName.BackColor = Color.Transparent;
            tbCityName.BackgroundImage = (Image)resources.GetObject("tbCityName.BackgroundImage");
            tbCityName.BorderColorActive = Color.DodgerBlue;
            tbCityName.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            tbCityName.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            tbCityName.BorderColorIdle = Color.Gray;
            tbCityName.BorderRadius = 5;
            tbCityName.BorderThickness = 1;
            tbCityName.CharacterCasing = CharacterCasing.Upper;
            tbCityName.Cursor = Cursors.IBeam;
            tbCityName.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            tbCityName.DefaultText = "";
            tbCityName.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            tbCityName.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            tbCityName.HideSelection = true;
            tbCityName.IconLeft = null;
            tbCityName.IconLeftCursor = Cursors.IBeam;
            tbCityName.IconPadding = 10;
            tbCityName.IconRight = null;
            tbCityName.IconRightCursor = Cursors.IBeam;
            tbCityName.Lines = new string[0];
            tbCityName.Location = new Point(168, 163);
            tbCityName.MaxLength = 32767;
            tbCityName.MinimumSize = new Size(100, 30);
            tbCityName.Modified = false;
            tbCityName.Multiline = false;
            tbCityName.Name = "tbCityName";
            StateProperties13.BorderColor = Color.DodgerBlue;
            StateProperties13.FillColor = Color.Empty;
            StateProperties13.ForeColor = Color.Empty;
            StateProperties13.PlaceholderForeColor = Color.Empty;
            tbCityName.OnActiveState = StateProperties13;
            StateProperties14.BorderColor = Color.Empty;
            StateProperties14.FillColor = Color.White;
            StateProperties14.ForeColor = Color.Empty;
            StateProperties14.PlaceholderForeColor = Color.Silver;
            tbCityName.OnDisabledState = StateProperties14;
            StateProperties15.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties15.FillColor = Color.Empty;
            StateProperties15.ForeColor = Color.Empty;
            StateProperties15.PlaceholderForeColor = Color.Empty;
            tbCityName.OnHoverState = StateProperties15;
            StateProperties16.BorderColor = Color.Gray;
            StateProperties16.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties16.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties16.PlaceholderForeColor = Color.Empty;
            tbCityName.OnIdleState = StateProperties16;
            tbCityName.PasswordChar = '\0';
            tbCityName.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            tbCityName.PlaceholderText = "";
            tbCityName.ReadOnly = false;
            tbCityName.ScrollBars = ScrollBars.None;
            tbCityName.SelectedText = "";
            tbCityName.SelectionLength = 0;
            tbCityName.SelectionStart = 0;
            tbCityName.ShortcutsEnabled = true;
            tbCityName.Size = new Size(222, 30);
            tbCityName.Style = _Style.Bunifu;
            tbCityName.TabIndex = 233;
            tbCityName.TextAlign = HorizontalAlignment.Left;
            tbCityName.TextMarginBottom = 0;
            tbCityName.TextMarginLeft = 5;
            tbCityName.TextMarginTop = 0;
            tbCityName.TextPlaceholder = "";
            tbCityName.UseSystemPasswordChar = false;
            tbCityName.WordWrap = true;
            // 
            // tbRegionName
            // 
            tbRegionName.AcceptsReturn = false;
            tbRegionName.AcceptsTab = false;
            tbRegionName.AnimationSpeed = 200;
            tbRegionName.AutoCompleteMode = AutoCompleteMode.None;
            tbRegionName.AutoCompleteSource = AutoCompleteSource.None;
            tbRegionName.BackColor = Color.Transparent;
            tbRegionName.BackgroundImage = (Image)resources.GetObject("tbRegionName.BackgroundImage");
            tbRegionName.BorderColorActive = Color.DodgerBlue;
            tbRegionName.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            tbRegionName.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            tbRegionName.BorderColorIdle = Color.Gray;
            tbRegionName.BorderRadius = 5;
            tbRegionName.BorderThickness = 1;
            tbRegionName.CharacterCasing = CharacterCasing.Upper;
            tbRegionName.Cursor = Cursors.IBeam;
            tbRegionName.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            tbRegionName.DefaultText = "";
            tbRegionName.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            tbRegionName.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            tbRegionName.HideSelection = true;
            tbRegionName.IconLeft = null;
            tbRegionName.IconLeftCursor = Cursors.IBeam;
            tbRegionName.IconPadding = 10;
            tbRegionName.IconRight = null;
            tbRegionName.IconRightCursor = Cursors.IBeam;
            tbRegionName.Lines = new string[0];
            tbRegionName.Location = new Point(168, 127);
            tbRegionName.MaxLength = 32767;
            tbRegionName.MinimumSize = new Size(100, 30);
            tbRegionName.Modified = false;
            tbRegionName.Multiline = false;
            tbRegionName.Name = "tbRegionName";
            StateProperties17.BorderColor = Color.DodgerBlue;
            StateProperties17.FillColor = Color.Empty;
            StateProperties17.ForeColor = Color.Empty;
            StateProperties17.PlaceholderForeColor = Color.Empty;
            tbRegionName.OnActiveState = StateProperties17;
            StateProperties18.BorderColor = Color.Empty;
            StateProperties18.FillColor = Color.White;
            StateProperties18.ForeColor = Color.Empty;
            StateProperties18.PlaceholderForeColor = Color.Silver;
            tbRegionName.OnDisabledState = StateProperties18;
            StateProperties19.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties19.FillColor = Color.Empty;
            StateProperties19.ForeColor = Color.Empty;
            StateProperties19.PlaceholderForeColor = Color.Empty;
            tbRegionName.OnHoverState = StateProperties19;
            StateProperties20.BorderColor = Color.Gray;
            StateProperties20.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties20.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties20.PlaceholderForeColor = Color.Empty;
            tbRegionName.OnIdleState = StateProperties20;
            tbRegionName.PasswordChar = '\0';
            tbRegionName.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            tbRegionName.PlaceholderText = "";
            tbRegionName.ReadOnly = false;
            tbRegionName.ScrollBars = ScrollBars.None;
            tbRegionName.SelectedText = "";
            tbRegionName.SelectionLength = 0;
            tbRegionName.SelectionStart = 0;
            tbRegionName.ShortcutsEnabled = true;
            tbRegionName.Size = new Size(222, 30);
            tbRegionName.Style = _Style.Bunifu;
            tbRegionName.TabIndex = 234;
            tbRegionName.TextAlign = HorizontalAlignment.Left;
            tbRegionName.TextMarginBottom = 0;
            tbRegionName.TextMarginLeft = 5;
            tbRegionName.TextMarginTop = 0;
            tbRegionName.TextPlaceholder = "";
            tbRegionName.UseSystemPasswordChar = false;
            tbRegionName.WordWrap = true;
            // 
            // tbCountryCode
            // 
            tbCountryCode.AcceptsReturn = false;
            tbCountryCode.AcceptsTab = false;
            tbCountryCode.AnimationSpeed = 200;
            tbCountryCode.AutoCompleteMode = AutoCompleteMode.None;
            tbCountryCode.AutoCompleteSource = AutoCompleteSource.None;
            tbCountryCode.BackColor = Color.Transparent;
            tbCountryCode.BackgroundImage = (Image)resources.GetObject("tbCountryCode.BackgroundImage");
            tbCountryCode.BorderColorActive = Color.DodgerBlue;
            tbCountryCode.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            tbCountryCode.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            tbCountryCode.BorderColorIdle = Color.Gray;
            tbCountryCode.BorderRadius = 5;
            tbCountryCode.BorderThickness = 1;
            tbCountryCode.CharacterCasing = CharacterCasing.Upper;
            tbCountryCode.Cursor = Cursors.IBeam;
            tbCountryCode.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            tbCountryCode.DefaultText = "";
            tbCountryCode.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            tbCountryCode.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            tbCountryCode.HideSelection = true;
            tbCountryCode.IconLeft = null;
            tbCountryCode.IconLeftCursor = Cursors.IBeam;
            tbCountryCode.IconPadding = 10;
            tbCountryCode.IconRight = null;
            tbCountryCode.IconRightCursor = Cursors.IBeam;
            tbCountryCode.Lines = new string[0];
            tbCountryCode.Location = new Point(168, 91);
            tbCountryCode.MaxLength = 32767;
            tbCountryCode.MinimumSize = new Size(100, 30);
            tbCountryCode.Modified = false;
            tbCountryCode.Multiline = false;
            tbCountryCode.Name = "tbCountryCode";
            StateProperties21.BorderColor = Color.DodgerBlue;
            StateProperties21.FillColor = Color.Empty;
            StateProperties21.ForeColor = Color.Empty;
            StateProperties21.PlaceholderForeColor = Color.Empty;
            tbCountryCode.OnActiveState = StateProperties21;
            StateProperties22.BorderColor = Color.Empty;
            StateProperties22.FillColor = Color.White;
            StateProperties22.ForeColor = Color.Empty;
            StateProperties22.PlaceholderForeColor = Color.Silver;
            tbCountryCode.OnDisabledState = StateProperties22;
            StateProperties23.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties23.FillColor = Color.Empty;
            StateProperties23.ForeColor = Color.Empty;
            StateProperties23.PlaceholderForeColor = Color.Empty;
            tbCountryCode.OnHoverState = StateProperties23;
            StateProperties24.BorderColor = Color.Gray;
            StateProperties24.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties24.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties24.PlaceholderForeColor = Color.Empty;
            tbCountryCode.OnIdleState = StateProperties24;
            tbCountryCode.PasswordChar = '\0';
            tbCountryCode.PlaceholderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            tbCountryCode.PlaceholderText = "";
            tbCountryCode.ReadOnly = false;
            tbCountryCode.ScrollBars = ScrollBars.None;
            tbCountryCode.SelectedText = "";
            tbCountryCode.SelectionLength = 0;
            tbCountryCode.SelectionStart = 0;
            tbCountryCode.ShortcutsEnabled = true;
            tbCountryCode.Size = new Size(222, 30);
            tbCountryCode.Style = _Style.Bunifu;
            tbCountryCode.TabIndex = 235;
            tbCountryCode.TextAlign = HorizontalAlignment.Left;
            tbCountryCode.TextMarginBottom = 0;
            tbCountryCode.TextMarginLeft = 5;
            tbCountryCode.TextMarginTop = 0;
            tbCountryCode.TextPlaceholder = "";
            tbCountryCode.UseSystemPasswordChar = false;
            tbCountryCode.WordWrap = true;
            // 
            // FrmAddEditDestination
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(444, 344);
            Controls.Add(tbCountryCode);
            Controls.Add(tbRegionName);
            Controls.Add(tbCityName);
            Controls.Add(_closeLabel);
            Controls.Add(Label12);
            Controls.Add(tbCoordinates);
            Controls.Add(Label1);
            Controls.Add(Label34);
            Controls.Add(Label60);
            Controls.Add(Label55);
            Controls.Add(Label11);
            Controls.Add(addressTextBox);
            Controls.Add(_closeAddressButton);
            Controls.Add(Label56);
            Controls.Add(_doneAddressButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddEditDestination";
            Text = "FrmAddEditDestination";
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label34;
        internal Label Label60;
        internal Label Label55;
        internal Label Label11;
        internal BunifuTextBox addressTextBox;
        internal Label Label56;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _doneAddressButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton doneAddressButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _doneAddressButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_doneAddressButton != null)
                {
                    _doneAddressButton.Click -= doneAddressButton_Click;
                }

                _doneAddressButton = value;
                if (_doneAddressButton != null)
                {
                    _doneAddressButton.Click += doneAddressButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _closeAddressButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton closeAddressButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _closeAddressButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_closeAddressButton != null)
                {
                    _closeAddressButton.Click -= closeAddressButton_Click;
                }

                _closeAddressButton = value;
                if (_closeAddressButton != null)
                {
                    _closeAddressButton.Click += closeAddressButton_Click;
                }
            }
        }

        internal Label Label1;
        internal BunifuTextBox tbCoordinates;
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
        internal BunifuTextBox tbCityName;
        internal BunifuTextBox tbRegionName;
        internal BunifuTextBox tbCountryCode;
    }
}