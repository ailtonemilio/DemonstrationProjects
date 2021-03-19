using System;
using System.Diagnostics;
using System.Drawing; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;  using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmAddEditStoreFiles : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditStoreFiles));
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties19 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties20 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties23 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties24 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label2 = new Label();
            txtFile = new BunifuTextBox();
            EmployeeNameBindingSource = new BindingSource(components);
            BunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            BunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            DocumentsStoredTypeBindingSource = new BindingSource(components);
            BunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            _btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSave.Click += new EventHandler(btnSave_Click);
            BunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            txtDescription = new BunifuTextBox();
            BunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            txtFileTitle = new BunifuTextBox();
            BunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            ofdDoc = new OpenFileDialog();
            _btnSearchFile = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSearchFile.Click += new EventHandler(btnSearchFile_Click);
            _txtExpireDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            _txtExpireDate.ValueChanged += new EventHandler(txtExpireDate_ValueChanged);
            BunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            _btnAddDocumentType = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddDocumentType.Click += new EventHandler(btnAddDocumentType_Click);
            DocumentsStoredDepartmentBindingSource = new BindingSource(components);
            BunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            _ddlArea = new ComboBox();
            _ddlArea.SelectedIndexChanged += new EventHandler(ddlArea_SelectedIndexChanged);
            ddlType = new ComboBox();
            ddlEmployee = new ComboBox();
            _btnCancelIssueDate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancelIssueDate.Click += new EventHandler(btnCancelIssueDate_Click);
            _txtIssueDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            _txtIssueDate.ValueChanged += new EventHandler(txtIssueDate_ValueChanged);
            _btnCancelExpireDate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancelExpireDate.Click += new EventHandler(btnCancelExpireDate_Click);
            _btnAddDepartment = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAddDepartment.Click += new EventHandler(btnAddDepartment_Click);
            BunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)EmployeeNameBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredDepartmentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(1037, -3);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(40, 41);
            _closeLabel.TabIndex = 146;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            Label2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Dock = DockStyle.Top;
            Label2.Font = new Font("Microsoft Sans Serif", 22.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(0, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(1077, 41);
            Label2.TabIndex = 145;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFile
            // 
            txtFile.AcceptsReturn = false;
            txtFile.AcceptsTab = false;
            txtFile.AnimationSpeed = 200;
            txtFile.AutoCompleteMode = AutoCompleteMode.None;
            txtFile.AutoCompleteSource = AutoCompleteSource.None;
            txtFile.BackColor = Color.Transparent;
            txtFile.BackgroundImage = (Image)resources.GetObject("txtFile.BackgroundImage");
            txtFile.BorderColorActive = Color.DodgerBlue;
            txtFile.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            txtFile.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtFile.BorderColorIdle = Color.Silver;
            txtFile.BorderRadius = 1;
            txtFile.BorderThickness = 1;
            txtFile.CharacterCasing = CharacterCasing.Normal;
            txtFile.Cursor = Cursors.IBeam;
            txtFile.DefaultFont = new Font("Segoe UI Semibold", 10.0f);
            txtFile.DefaultText = "";
            txtFile.Enabled = false;
            txtFile.FillColor = Color.White;
            txtFile.ForeColor = Color.Black;
            txtFile.HideSelection = true;
            txtFile.IconLeft = null;
            txtFile.IconLeftCursor = Cursors.IBeam;
            txtFile.IconPadding = 10;
            txtFile.IconRight = null;
            txtFile.IconRightCursor = Cursors.IBeam;
            txtFile.Lines = new string[0];
            txtFile.Location = new Point(155, 269);
            txtFile.MaxLength = 32767;
            txtFile.MinimumSize = new Size(100, 35);
            txtFile.Modified = false;
            txtFile.Multiline = false;
            txtFile.Name = "txtFile";
            StateProperties1.BorderColor = Color.DodgerBlue;
            StateProperties1.FillColor = Color.Empty;
            StateProperties1.ForeColor = Color.Empty;
            StateProperties1.PlaceholderForeColor = Color.Empty;
            txtFile.OnActiveState = StateProperties1;
            StateProperties2.BorderColor = Color.Empty;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.Empty;
            StateProperties2.PlaceholderForeColor = Color.Silver;
            txtFile.OnDisabledState = StateProperties2;
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            txtFile.OnHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Silver;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Black;
            StateProperties4.PlaceholderForeColor = Color.Empty;
            txtFile.OnIdleState = StateProperties4;
            txtFile.PasswordChar = '\0';
            txtFile.PlaceholderForeColor = Color.Silver;
            txtFile.PlaceholderText = "Enter text";
            txtFile.ReadOnly = false;
            txtFile.ScrollBars = ScrollBars.None;
            txtFile.SelectedText = "";
            txtFile.SelectionLength = 0;
            txtFile.SelectionStart = 0;
            txtFile.ShortcutsEnabled = true;
            txtFile.Size = new Size(866, 35);
            txtFile.Style = _Style.Bunifu;
            txtFile.TabIndex = 183;
            txtFile.TextAlign = HorizontalAlignment.Left;
            txtFile.TextMarginBottom = 0;
            txtFile.TextMarginLeft = 5;
            txtFile.TextMarginTop = 0;
            txtFile.TextPlaceholder = "Enter text";
            txtFile.UseSystemPasswordChar = false;
            txtFile.WordWrap = true;
            // 
            // EmployeeNameBindingSource
            // 
            EmployeeNameBindingSource.DataSource = typeof(ModelLayer.CustomModel.EmployeeName);
            // 
            // BunifuLabel8
            // 
            BunifuLabel8.AutoEllipsis = false;
            BunifuLabel8.CursorType = null;
            BunifuLabel8.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel8.Location = new Point(57, 231);
            BunifuLabel8.Name = "BunifuLabel8";
            BunifuLabel8.RightToLeft = RightToLeft.No;
            BunifuLabel8.Size = new Size(77, 22);
            BunifuLabel8.TabIndex = 181;
            BunifuLabel8.Text = "Employee:";
            BunifuLabel8.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BunifuLabel7
            // 
            BunifuLabel7.AutoEllipsis = false;
            BunifuLabel7.CursorType = null;
            BunifuLabel7.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel7.Location = new Point(438, 104);
            BunifuLabel7.Name = "BunifuLabel7";
            BunifuLabel7.RightToLeft = RightToLeft.No;
            BunifuLabel7.Size = new Size(46, 22);
            BunifuLabel7.TabIndex = 179;
            BunifuLabel7.Text = "Issue:";
            BunifuLabel7.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DocumentsStoredTypeBindingSource
            // 
            DocumentsStoredTypeBindingSource.DataSource = typeof(ModelLayer.DocumentsStoredType);
            // 
            // BunifuLabel6
            // 
            BunifuLabel6.AutoEllipsis = false;
            BunifuLabel6.CursorType = null;
            BunifuLabel6.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel6.Location = new Point(444, 190);
            BunifuLabel6.Name = "BunifuLabel6";
            BunifuLabel6.RightToLeft = RightToLeft.No;
            BunifuLabel6.Size = new Size(119, 22);
            BunifuLabel6.TabIndex = 177;
            BunifuLabel6.Text = "Document Type:";
            BunifuLabel6.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnSave
            // 
            _btnSave.AllowToggling = false;
            _btnSave.AnimationSpeed = 200;
            _btnSave.AutoGenerateColors = false;
            _btnSave.BackColor = Color.Transparent;
            _btnSave.BackColor1 = Color.Teal;
            _btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            _btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnSave.ButtonText = "Insert";
            _btnSave.ButtonTextMarginLeft = 0;
            _btnSave.ColorContrastOnClick = 45;
            _btnSave.ColorContrastOnHover = 45;
            _btnSave.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnSave.CustomizableEdges = BorderEdges1;
            _btnSave.DialogResult = DialogResult.None;
            _btnSave.DisabledBorderColor = Color.Empty;
            _btnSave.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSave.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSave.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnSave.ForeColor = Color.White;
            _btnSave.IconLeftCursor = Cursors.Hand;
            _btnSave.IconMarginLeft = 11;
            _btnSave.IconPadding = 10;
            _btnSave.IconRightCursor = Cursors.Hand;
            _btnSave.IdleBorderColor = Color.Teal;
            _btnSave.IdleBorderRadius = 3;
            _btnSave.IdleBorderThickness = 1;
            _btnSave.IdleFillColor = Color.Teal;
            _btnSave.IdleIconLeftImage = null;
            _btnSave.IdleIconRightImage = null;
            _btnSave.IndicateFocus = true;
            _btnSave.Location = new Point(949, 322);
            _btnSave.Name = "_btnSave";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _btnSave.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Teal;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _btnSave.OnPressedState = StateProperties6;
            _btnSave.Size = new Size(100, 40);
            _btnSave.TabIndex = 176;
            _btnSave.TextAlign = ContentAlignment.MiddleCenter;
            _btnSave.TextMarginLeft = 0;
            _btnSave.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuLabel3
            // 
            BunifuLabel3.AutoEllipsis = false;
            BunifuLabel3.CursorType = null;
            BunifuLabel3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel3.Location = new Point(106, 280);
            BunifuLabel3.Name = "BunifuLabel3";
            BunifuLabel3.RightToLeft = RightToLeft.No;
            BunifuLabel3.Size = new Size(32, 22);
            BunifuLabel3.TabIndex = 174;
            BunifuLabel3.Text = "File:";
            BunifuLabel3.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtDescription
            // 
            txtDescription.AcceptsReturn = false;
            txtDescription.AcceptsTab = false;
            txtDescription.AnimationSpeed = 200;
            txtDescription.AutoCompleteMode = AutoCompleteMode.None;
            txtDescription.AutoCompleteSource = AutoCompleteSource.None;
            txtDescription.BackColor = Color.Transparent;
            txtDescription.BackgroundImage = (Image)resources.GetObject("txtDescription.BackgroundImage");
            txtDescription.BorderColorActive = Color.DodgerBlue;
            txtDescription.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            txtDescription.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtDescription.BorderColorIdle = Color.Silver;
            txtDescription.BorderRadius = 1;
            txtDescription.BorderThickness = 1;
            txtDescription.CharacterCasing = CharacterCasing.Upper;
            txtDescription.Cursor = Cursors.IBeam;
            txtDescription.DefaultFont = new Font("Segoe UI Semibold", 10.0f);
            txtDescription.DefaultText = "";
            txtDescription.FillColor = Color.White;
            txtDescription.ForeColor = Color.Black;
            txtDescription.HideSelection = true;
            txtDescription.IconLeft = null;
            txtDescription.IconLeftCursor = Cursors.IBeam;
            txtDescription.IconPadding = 10;
            txtDescription.IconRight = null;
            txtDescription.IconRightCursor = Cursors.IBeam;
            txtDescription.Lines = new string[0];
            txtDescription.Location = new Point(156, 142);
            txtDescription.MaxLength = 250;
            txtDescription.MinimumSize = new Size(100, 35);
            txtDescription.Modified = false;
            txtDescription.Multiline = false;
            txtDescription.Name = "txtDescription";
            StateProperties7.BorderColor = Color.DodgerBlue;
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            txtDescription.OnActiveState = StateProperties7;
            StateProperties8.BorderColor = Color.Empty;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.Empty;
            StateProperties8.PlaceholderForeColor = Color.Silver;
            txtDescription.OnDisabledState = StateProperties8;
            StateProperties9.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties9.FillColor = Color.Empty;
            StateProperties9.ForeColor = Color.Empty;
            StateProperties9.PlaceholderForeColor = Color.Empty;
            txtDescription.OnHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.Silver;
            StateProperties10.FillColor = Color.White;
            StateProperties10.ForeColor = Color.Black;
            StateProperties10.PlaceholderForeColor = Color.Empty;
            txtDescription.OnIdleState = StateProperties10;
            txtDescription.PasswordChar = '\0';
            txtDescription.PlaceholderForeColor = Color.Silver;
            txtDescription.PlaceholderText = "ENTER TEXT";
            txtDescription.ReadOnly = false;
            txtDescription.ScrollBars = ScrollBars.None;
            txtDescription.SelectedText = "";
            txtDescription.SelectionLength = 0;
            txtDescription.SelectionStart = 0;
            txtDescription.ShortcutsEnabled = true;
            txtDescription.Size = new Size(877, 35);
            txtDescription.Style = _Style.Bunifu;
            txtDescription.TabIndex = 173;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.TextMarginBottom = 0;
            txtDescription.TextMarginLeft = 5;
            txtDescription.TextMarginTop = 0;
            txtDescription.TextPlaceholder = "ENTER TEXT";
            txtDescription.UseSystemPasswordChar = false;
            txtDescription.WordWrap = true;
            // 
            // BunifuLabel2
            // 
            BunifuLabel2.AutoEllipsis = false;
            BunifuLabel2.CursorType = null;
            BunifuLabel2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel2.Location = new Point(45, 147);
            BunifuLabel2.Name = "BunifuLabel2";
            BunifuLabel2.RightToLeft = RightToLeft.No;
            BunifuLabel2.Size = new Size(87, 22);
            BunifuLabel2.TabIndex = 172;
            BunifuLabel2.Text = "Description:";
            BunifuLabel2.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtFileTitle
            // 
            txtFileTitle.AcceptsReturn = false;
            txtFileTitle.AcceptsTab = false;
            txtFileTitle.AnimationSpeed = 200;
            txtFileTitle.AutoCompleteMode = AutoCompleteMode.None;
            txtFileTitle.AutoCompleteSource = AutoCompleteSource.None;
            txtFileTitle.BackColor = Color.Transparent;
            txtFileTitle.BackgroundImage = (Image)resources.GetObject("txtFileTitle.BackgroundImage");
            txtFileTitle.BorderColorActive = Color.DodgerBlue;
            txtFileTitle.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            txtFileTitle.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtFileTitle.BorderColorIdle = Color.Silver;
            txtFileTitle.BorderRadius = 1;
            txtFileTitle.BorderThickness = 1;
            txtFileTitle.CharacterCasing = CharacterCasing.Upper;
            txtFileTitle.Cursor = Cursors.IBeam;
            txtFileTitle.DefaultFont = new Font("Segoe UI Semibold", 10.0f);
            txtFileTitle.DefaultText = "";
            txtFileTitle.FillColor = Color.White;
            txtFileTitle.ForeColor = Color.Black;
            txtFileTitle.HideSelection = true;
            txtFileTitle.IconLeft = null;
            txtFileTitle.IconLeftCursor = Cursors.IBeam;
            txtFileTitle.IconPadding = 10;
            txtFileTitle.IconRight = null;
            txtFileTitle.IconRightCursor = Cursors.IBeam;
            txtFileTitle.Lines = new string[0];
            txtFileTitle.Location = new Point(156, 102);
            txtFileTitle.MaxLength = 50;
            txtFileTitle.MinimumSize = new Size(100, 35);
            txtFileTitle.Modified = false;
            txtFileTitle.Multiline = false;
            txtFileTitle.Name = "txtFileTitle";
            StateProperties11.BorderColor = Color.DodgerBlue;
            StateProperties11.FillColor = Color.Empty;
            StateProperties11.ForeColor = Color.Empty;
            StateProperties11.PlaceholderForeColor = Color.Empty;
            txtFileTitle.OnActiveState = StateProperties11;
            StateProperties12.BorderColor = Color.Empty;
            StateProperties12.FillColor = Color.White;
            StateProperties12.ForeColor = Color.Empty;
            StateProperties12.PlaceholderForeColor = Color.Silver;
            txtFileTitle.OnDisabledState = StateProperties12;
            StateProperties13.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties13.FillColor = Color.Empty;
            StateProperties13.ForeColor = Color.Empty;
            StateProperties13.PlaceholderForeColor = Color.Empty;
            txtFileTitle.OnHoverState = StateProperties13;
            StateProperties14.BorderColor = Color.Silver;
            StateProperties14.FillColor = Color.White;
            StateProperties14.ForeColor = Color.Black;
            StateProperties14.PlaceholderForeColor = Color.Empty;
            txtFileTitle.OnIdleState = StateProperties14;
            txtFileTitle.PasswordChar = '\0';
            txtFileTitle.PlaceholderForeColor = Color.Silver;
            txtFileTitle.PlaceholderText = "ENTER TEXT";
            txtFileTitle.ReadOnly = false;
            txtFileTitle.ScrollBars = ScrollBars.None;
            txtFileTitle.SelectedText = "";
            txtFileTitle.SelectionLength = 0;
            txtFileTitle.SelectionStart = 0;
            txtFileTitle.ShortcutsEnabled = true;
            txtFileTitle.Size = new Size(276, 35);
            txtFileTitle.Style = _Style.Bunifu;
            txtFileTitle.TabIndex = 171;
            txtFileTitle.TextAlign = HorizontalAlignment.Left;
            txtFileTitle.TextMarginBottom = 0;
            txtFileTitle.TextMarginLeft = 5;
            txtFileTitle.TextMarginTop = 0;
            txtFileTitle.TextPlaceholder = "ENTER TEXT";
            txtFileTitle.UseSystemPasswordChar = false;
            txtFileTitle.WordWrap = true;
            // 
            // BunifuLabel1
            // 
            BunifuLabel1.AutoEllipsis = false;
            BunifuLabel1.CursorType = null;
            BunifuLabel1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel1.Location = new Point(67, 102);
            BunifuLabel1.Name = "BunifuLabel1";
            BunifuLabel1.RightToLeft = RightToLeft.No;
            BunifuLabel1.Size = new Size(65, 22);
            BunifuLabel1.TabIndex = 170;
            BunifuLabel1.Text = "File Title:";
            BunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ofdDoc
            // 
            ofdDoc.FileName = "OpenFileDialog1";
            // 
            // btnSearchFile
            // 
            _btnSearchFile.AllowToggling = false;
            _btnSearchFile.AnimationSpeed = 200;
            _btnSearchFile.AutoGenerateColors = false;
            _btnSearchFile.BackColor = Color.Transparent;
            _btnSearchFile.BackColor1 = Color.DodgerBlue;
            _btnSearchFile.BackgroundImage = (Image)resources.GetObject("btnSearchFile.BackgroundImage");
            _btnSearchFile.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnSearchFile.ButtonText = "";
            _btnSearchFile.ButtonTextMarginLeft = 15;
            _btnSearchFile.ColorContrastOnClick = 45;
            _btnSearchFile.ColorContrastOnHover = 45;
            _btnSearchFile.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnSearchFile.CustomizableEdges = BorderEdges2;
            _btnSearchFile.DialogResult = DialogResult.None;
            _btnSearchFile.DisabledBorderColor = Color.Empty;
            _btnSearchFile.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSearchFile.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSearchFile.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSearchFile.Font = new Font("Segoe UI Semibold", 12.0f);
            _btnSearchFile.ForeColor = Color.White;
            _btnSearchFile.IconLeftCursor = Cursors.Hand;
            _btnSearchFile.IconMarginLeft = 10;
            _btnSearchFile.IconPadding = 10;
            _btnSearchFile.IconRightCursor = Cursors.Hand;
            _btnSearchFile.IdleBorderColor = Color.DodgerBlue;
            _btnSearchFile.IdleBorderRadius = 3;
            _btnSearchFile.IdleBorderThickness = 1;
            _btnSearchFile.IdleFillColor = Color.DodgerBlue;
            _btnSearchFile.IdleIconLeftImage = (Image)resources.GetObject("btnSearchFile.IdleIconLeftImage");
            _btnSearchFile.IdleIconRightImage = null;
            _btnSearchFile.IndicateFocus = false;
            _btnSearchFile.Location = new Point(996, 269);
            _btnSearchFile.Name = "_btnSearchFile";
            StateProperties15.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties15.BorderRadius = 3;
            StateProperties15.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties15.BorderThickness = 1;
            StateProperties15.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties15.ForeColor = Color.White;
            StateProperties15.IconLeftImage = null;
            StateProperties15.IconRightImage = null;
            _btnSearchFile.onHoverState = StateProperties15;
            StateProperties16.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties16.BorderRadius = 3;
            StateProperties16.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties16.BorderThickness = 1;
            StateProperties16.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties16.ForeColor = Color.White;
            StateProperties16.IconLeftImage = null;
            StateProperties16.IconRightImage = null;
            _btnSearchFile.OnPressedState = StateProperties16;
            _btnSearchFile.RightToLeft = RightToLeft.No;
            _btnSearchFile.Size = new Size(37, 35);
            _btnSearchFile.TabIndex = 184;
            _btnSearchFile.TextAlign = ContentAlignment.MiddleCenter;
            _btnSearchFile.TextMarginLeft = 15;
            _btnSearchFile.UseDefaultRadiusAndThickness = true;
            // 
            // txtExpireDate
            // 
            _txtExpireDate.BorderRadius = 1;
            _txtExpireDate.Color = Color.Gray;
            _txtExpireDate.CustomFormat = " ";
            _txtExpireDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            _txtExpireDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            _txtExpireDate.DisabledColor = Color.Gray;
            _txtExpireDate.DisplayWeekNumbers = false;
            _txtExpireDate.DPHeight = 0;
            _txtExpireDate.DropDownAlign = LeftRightAlignment.Right;
            _txtExpireDate.FillDatePicker = false;
            _txtExpireDate.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtExpireDate.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _txtExpireDate.Format = DateTimePickerFormat.Custom;
            _txtExpireDate.Icon = (Image)resources.GetObject("txtExpireDate.Icon");
            _txtExpireDate.IconColor = Color.Teal;
            _txtExpireDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            _txtExpireDate.Location = new Point(791, 97);
            _txtExpireDate.MinimumSize = new Size(214, 34);
            _txtExpireDate.Name = "_txtExpireDate";
            _txtExpireDate.Size = new Size(214, 34);
            _txtExpireDate.TabIndex = 186;
            // 
            // BunifuLabel4
            // 
            BunifuLabel4.AutoEllipsis = false;
            BunifuLabel4.CursorType = null;
            BunifuLabel4.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel4.Location = new Point(736, 104);
            BunifuLabel4.Name = "BunifuLabel4";
            BunifuLabel4.RightToLeft = RightToLeft.No;
            BunifuLabel4.Size = new Size(51, 22);
            BunifuLabel4.TabIndex = 185;
            BunifuLabel4.Text = "Expire:";
            BunifuLabel4.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAddDocumentType
            // 
            _btnAddDocumentType.AllowToggling = false;
            _btnAddDocumentType.AnimationSpeed = 200;
            _btnAddDocumentType.AutoGenerateColors = false;
            _btnAddDocumentType.BackColor = Color.Transparent;
            _btnAddDocumentType.BackColor1 = Color.Teal;
            _btnAddDocumentType.BackgroundImage = (Image)resources.GetObject("btnAddDocumentType.BackgroundImage");
            _btnAddDocumentType.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddDocumentType.ButtonText = "";
            _btnAddDocumentType.ButtonTextMarginLeft = 0;
            _btnAddDocumentType.ColorContrastOnClick = 45;
            _btnAddDocumentType.ColorContrastOnHover = 45;
            _btnAddDocumentType.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _btnAddDocumentType.CustomizableEdges = BorderEdges3;
            _btnAddDocumentType.DialogResult = DialogResult.None;
            _btnAddDocumentType.DisabledBorderColor = Color.Empty;
            _btnAddDocumentType.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddDocumentType.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddDocumentType.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddDocumentType.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddDocumentType.ForeColor = Color.White;
            _btnAddDocumentType.IconLeftCursor = Cursors.Hand;
            _btnAddDocumentType.IconMarginLeft = 11;
            _btnAddDocumentType.IconPadding = 10;
            _btnAddDocumentType.IconRightCursor = Cursors.Hand;
            _btnAddDocumentType.IdleBorderColor = Color.Teal;
            _btnAddDocumentType.IdleBorderRadius = 3;
            _btnAddDocumentType.IdleBorderThickness = 1;
            _btnAddDocumentType.IdleFillColor = Color.Teal;
            _btnAddDocumentType.IdleIconLeftImage = My.Resources.Resources.addWhite;
            _btnAddDocumentType.IdleIconRightImage = null;
            _btnAddDocumentType.IndicateFocus = true;
            _btnAddDocumentType.Location = new Point(859, 182);
            _btnAddDocumentType.Name = "_btnAddDocumentType";
            StateProperties17.BorderColor = Color.MediumTurquoise;
            StateProperties17.BorderRadius = 3;
            StateProperties17.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties17.BorderThickness = 1;
            StateProperties17.FillColor = Color.MediumTurquoise;
            StateProperties17.ForeColor = Color.White;
            StateProperties17.IconLeftImage = null;
            StateProperties17.IconRightImage = null;
            _btnAddDocumentType.onHoverState = StateProperties17;
            StateProperties18.BorderColor = Color.Teal;
            StateProperties18.BorderRadius = 3;
            StateProperties18.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties18.BorderThickness = 1;
            StateProperties18.FillColor = Color.Teal;
            StateProperties18.ForeColor = Color.White;
            StateProperties18.IconLeftImage = null;
            StateProperties18.IconRightImage = null;
            _btnAddDocumentType.OnPressedState = StateProperties18;
            _btnAddDocumentType.Size = new Size(32, 32);
            _btnAddDocumentType.TabIndex = 206;
            _btnAddDocumentType.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddDocumentType.TextMarginLeft = 0;
            _btnAddDocumentType.UseDefaultRadiusAndThickness = true;
            // 
            // DocumentsStoredDepartmentBindingSource
            // 
            DocumentsStoredDepartmentBindingSource.DataSource = typeof(ModelLayer.DocumentsStoredDepartment);
            // 
            // BunifuLabel5
            // 
            BunifuLabel5.AutoEllipsis = false;
            BunifuLabel5.CursorType = null;
            BunifuLabel5.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel5.Location = new Point(44, 190);
            BunifuLabel5.Name = "BunifuLabel5";
            BunifuLabel5.RightToLeft = RightToLeft.No;
            BunifuLabel5.Size = new Size(92, 22);
            BunifuLabel5.TabIndex = 208;
            BunifuLabel5.Text = "Department:";
            BunifuLabel5.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ddlArea
            // 
            _ddlArea.DataSource = DocumentsStoredDepartmentBindingSource;
            _ddlArea.DisplayMember = "DescDocumentsStoredDepartment";
            _ddlArea.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _ddlArea.FormattingEnabled = true;
            _ddlArea.Location = new Point(156, 187);
            _ddlArea.Name = "_ddlArea";
            _ddlArea.Size = new Size(230, 28);
            _ddlArea.TabIndex = 212;
            _ddlArea.ValueMember = "DocumentsStoredDepartmentId";
            // 
            // ddlType
            // 
            ddlType.DataSource = DocumentsStoredTypeBindingSource;
            ddlType.DisplayMember = "DescDocumentsStoredType";
            ddlType.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ddlType.FormattingEnabled = true;
            ddlType.Location = new Point(576, 185);
            ddlType.Name = "ddlType";
            ddlType.Size = new Size(277, 28);
            ddlType.TabIndex = 213;
            ddlType.ValueMember = "DocumentsStoredTypeId";
            // 
            // ddlEmployee
            // 
            ddlEmployee.AutoCompleteMode = AutoCompleteMode.Append;
            ddlEmployee.AutoCompleteSource = AutoCompleteSource.ListItems;
            ddlEmployee.DataSource = EmployeeNameBindingSource;
            ddlEmployee.DisplayMember = "FisrtNameLastName";
            ddlEmployee.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ddlEmployee.FormattingEnabled = true;
            ddlEmployee.Location = new Point(156, 227);
            ddlEmployee.Name = "ddlEmployee";
            ddlEmployee.Size = new Size(527, 28);
            ddlEmployee.TabIndex = 214;
            ddlEmployee.ValueMember = "EmployeeId";
            // 
            // btnCancelIssueDate
            // 
            _btnCancelIssueDate.AllowToggling = false;
            _btnCancelIssueDate.AnimationSpeed = 200;
            _btnCancelIssueDate.AutoGenerateColors = false;
            _btnCancelIssueDate.BackColor = Color.Transparent;
            _btnCancelIssueDate.BackColor1 = Color.White;
            _btnCancelIssueDate.BackgroundImage = (Image)resources.GetObject("btnCancelIssueDate.BackgroundImage");
            _btnCancelIssueDate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnCancelIssueDate.ButtonText = "";
            _btnCancelIssueDate.ButtonTextMarginLeft = 0;
            _btnCancelIssueDate.ColorContrastOnClick = 45;
            _btnCancelIssueDate.ColorContrastOnHover = 45;
            _btnCancelIssueDate.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _btnCancelIssueDate.CustomizableEdges = BorderEdges4;
            _btnCancelIssueDate.DialogResult = DialogResult.None;
            _btnCancelIssueDate.DisabledBorderColor = Color.Empty;
            _btnCancelIssueDate.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnCancelIssueDate.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnCancelIssueDate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnCancelIssueDate.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnCancelIssueDate.ForeColor = Color.White;
            _btnCancelIssueDate.IconLeftCursor = Cursors.Hand;
            _btnCancelIssueDate.IconMarginLeft = 5;
            _btnCancelIssueDate.IconPadding = 5;
            _btnCancelIssueDate.IconRightCursor = Cursors.Hand;
            _btnCancelIssueDate.IdleBorderColor = Color.White;
            _btnCancelIssueDate.IdleBorderRadius = 3;
            _btnCancelIssueDate.IdleBorderThickness = 1;
            _btnCancelIssueDate.IdleFillColor = Color.White;
            _btnCancelIssueDate.IdleIconLeftImage = My.Resources.Resources.removeRedBall;
            _btnCancelIssueDate.IdleIconRightImage = null;
            _btnCancelIssueDate.IndicateFocus = false;
            _btnCancelIssueDate.Location = new Point(702, 97);
            _btnCancelIssueDate.Name = "_btnCancelIssueDate";
            StateProperties19.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties19.BorderRadius = 3;
            StateProperties19.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties19.BorderThickness = 1;
            StateProperties19.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties19.ForeColor = Color.White;
            StateProperties19.IconLeftImage = null;
            StateProperties19.IconRightImage = null;
            _btnCancelIssueDate.onHoverState = StateProperties19;
            StateProperties20.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties20.BorderRadius = 3;
            StateProperties20.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties20.BorderThickness = 1;
            StateProperties20.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties20.ForeColor = Color.White;
            StateProperties20.IconLeftImage = null;
            StateProperties20.IconRightImage = null;
            _btnCancelIssueDate.OnPressedState = StateProperties20;
            _btnCancelIssueDate.Size = new Size(25, 25);
            _btnCancelIssueDate.TabIndex = 221;
            _btnCancelIssueDate.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancelIssueDate.TextMarginLeft = 0;
            _btnCancelIssueDate.UseDefaultRadiusAndThickness = true;
            // 
            // txtIssueDate
            // 
            _txtIssueDate.BorderRadius = 1;
            _txtIssueDate.Color = Color.Gray;
            _txtIssueDate.CustomFormat = " ";
            _txtIssueDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            _txtIssueDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            _txtIssueDate.DisabledColor = Color.Gray;
            _txtIssueDate.DisplayWeekNumbers = false;
            _txtIssueDate.DPHeight = 0;
            _txtIssueDate.DropDownAlign = LeftRightAlignment.Right;
            _txtIssueDate.FillDatePicker = false;
            _txtIssueDate.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _txtIssueDate.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _txtIssueDate.Format = DateTimePickerFormat.Custom;
            _txtIssueDate.Icon = (Image)resources.GetObject("txtIssueDate.Icon");
            _txtIssueDate.IconColor = Color.Teal;
            _txtIssueDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            _txtIssueDate.Location = new Point(488, 97);
            _txtIssueDate.MinimumSize = new Size(212, 34);
            _txtIssueDate.Name = "_txtIssueDate";
            _txtIssueDate.Size = new Size(212, 34);
            _txtIssueDate.TabIndex = 180;
            // 
            // btnCancelExpireDate
            // 
            _btnCancelExpireDate.AllowToggling = false;
            _btnCancelExpireDate.AnimationSpeed = 200;
            _btnCancelExpireDate.AutoGenerateColors = false;
            _btnCancelExpireDate.BackColor = Color.Transparent;
            _btnCancelExpireDate.BackColor1 = Color.White;
            _btnCancelExpireDate.BackgroundImage = (Image)resources.GetObject("btnCancelExpireDate.BackgroundImage");
            _btnCancelExpireDate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnCancelExpireDate.ButtonText = "";
            _btnCancelExpireDate.ButtonTextMarginLeft = 0;
            _btnCancelExpireDate.ColorContrastOnClick = 45;
            _btnCancelExpireDate.ColorContrastOnHover = 45;
            _btnCancelExpireDate.Cursor = Cursors.Hand;
            BorderEdges5.BottomLeft = true;
            BorderEdges5.BottomRight = true;
            BorderEdges5.TopLeft = true;
            BorderEdges5.TopRight = true;
            _btnCancelExpireDate.CustomizableEdges = BorderEdges5;
            _btnCancelExpireDate.DialogResult = DialogResult.None;
            _btnCancelExpireDate.DisabledBorderColor = Color.Empty;
            _btnCancelExpireDate.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnCancelExpireDate.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnCancelExpireDate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnCancelExpireDate.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnCancelExpireDate.ForeColor = Color.White;
            _btnCancelExpireDate.IconLeftCursor = Cursors.Hand;
            _btnCancelExpireDate.IconMarginLeft = 5;
            _btnCancelExpireDate.IconPadding = 5;
            _btnCancelExpireDate.IconRightCursor = Cursors.Hand;
            _btnCancelExpireDate.IdleBorderColor = Color.White;
            _btnCancelExpireDate.IdleBorderRadius = 3;
            _btnCancelExpireDate.IdleBorderThickness = 1;
            _btnCancelExpireDate.IdleFillColor = Color.White;
            _btnCancelExpireDate.IdleIconLeftImage = My.Resources.Resources.removeRedBall;
            _btnCancelExpireDate.IdleIconRightImage = null;
            _btnCancelExpireDate.IndicateFocus = false;
            _btnCancelExpireDate.Location = new Point(1007, 96);
            _btnCancelExpireDate.Name = "_btnCancelExpireDate";
            StateProperties21.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties21.BorderRadius = 3;
            StateProperties21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties21.BorderThickness = 1;
            StateProperties21.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties21.ForeColor = Color.White;
            StateProperties21.IconLeftImage = null;
            StateProperties21.IconRightImage = null;
            _btnCancelExpireDate.onHoverState = StateProperties21;
            StateProperties22.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties22.BorderRadius = 3;
            StateProperties22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties22.BorderThickness = 1;
            StateProperties22.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties22.ForeColor = Color.White;
            StateProperties22.IconLeftImage = null;
            StateProperties22.IconRightImage = null;
            _btnCancelExpireDate.OnPressedState = StateProperties22;
            _btnCancelExpireDate.Size = new Size(25, 25);
            _btnCancelExpireDate.TabIndex = 222;
            _btnCancelExpireDate.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancelExpireDate.TextMarginLeft = 0;
            _btnCancelExpireDate.UseDefaultRadiusAndThickness = true;
            // 
            // btnAddDepartment
            // 
            _btnAddDepartment.AllowToggling = false;
            _btnAddDepartment.AnimationSpeed = 200;
            _btnAddDepartment.AutoGenerateColors = false;
            _btnAddDepartment.BackColor = Color.Transparent;
            _btnAddDepartment.BackColor1 = Color.Teal;
            _btnAddDepartment.BackgroundImage = (Image)resources.GetObject("btnAddDepartment.BackgroundImage");
            _btnAddDepartment.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAddDepartment.ButtonText = "";
            _btnAddDepartment.ButtonTextMarginLeft = 0;
            _btnAddDepartment.ColorContrastOnClick = 45;
            _btnAddDepartment.ColorContrastOnHover = 45;
            _btnAddDepartment.Cursor = Cursors.Hand;
            BorderEdges6.BottomLeft = true;
            BorderEdges6.BottomRight = true;
            BorderEdges6.TopLeft = true;
            BorderEdges6.TopRight = true;
            _btnAddDepartment.CustomizableEdges = BorderEdges6;
            _btnAddDepartment.DialogResult = DialogResult.None;
            _btnAddDepartment.DisabledBorderColor = Color.Empty;
            _btnAddDepartment.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAddDepartment.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAddDepartment.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAddDepartment.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAddDepartment.ForeColor = Color.White;
            _btnAddDepartment.IconLeftCursor = Cursors.Hand;
            _btnAddDepartment.IconMarginLeft = 11;
            _btnAddDepartment.IconPadding = 10;
            _btnAddDepartment.IconRightCursor = Cursors.Hand;
            _btnAddDepartment.IdleBorderColor = Color.Teal;
            _btnAddDepartment.IdleBorderRadius = 3;
            _btnAddDepartment.IdleBorderThickness = 1;
            _btnAddDepartment.IdleFillColor = Color.Teal;
            _btnAddDepartment.IdleIconLeftImage = My.Resources.Resources.addWhite;
            _btnAddDepartment.IdleIconRightImage = null;
            _btnAddDepartment.IndicateFocus = true;
            _btnAddDepartment.Location = new Point(391, 185);
            _btnAddDepartment.Name = "_btnAddDepartment";
            StateProperties23.BorderColor = Color.MediumTurquoise;
            StateProperties23.BorderRadius = 3;
            StateProperties23.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties23.BorderThickness = 1;
            StateProperties23.FillColor = Color.MediumTurquoise;
            StateProperties23.ForeColor = Color.White;
            StateProperties23.IconLeftImage = null;
            StateProperties23.IconRightImage = null;
            _btnAddDepartment.onHoverState = StateProperties23;
            StateProperties24.BorderColor = Color.Teal;
            StateProperties24.BorderRadius = 3;
            StateProperties24.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties24.BorderThickness = 1;
            StateProperties24.FillColor = Color.Teal;
            StateProperties24.ForeColor = Color.White;
            StateProperties24.IconLeftImage = null;
            StateProperties24.IconRightImage = null;
            _btnAddDepartment.OnPressedState = StateProperties24;
            _btnAddDepartment.Size = new Size(32, 32);
            _btnAddDepartment.TabIndex = 223;
            _btnAddDepartment.TextAlign = ContentAlignment.MiddleCenter;
            _btnAddDepartment.TextMarginLeft = 0;
            _btnAddDepartment.UseDefaultRadiusAndThickness = true;
            _btnAddDepartment.Visible = false;
            // 
            // BunifuLabel9
            // 
            BunifuLabel9.AutoEllipsis = false;
            BunifuLabel9.CursorType = null;
            BunifuLabel9.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuLabel9.Location = new Point(30, 57);
            BunifuLabel9.Name = "BunifuLabel9";
            BunifuLabel9.RightToLeft = RightToLeft.No;
            BunifuLabel9.Size = new Size(139, 24);
            BunifuLabel9.TabIndex = 224;
            BunifuLabel9.Text = "Add Document:";
            BunifuLabel9.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmAddEditStoreFiles
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1077, 372);
            Controls.Add(BunifuLabel9);
            Controls.Add(_btnAddDepartment);
            Controls.Add(_btnCancelExpireDate);
            Controls.Add(_btnCancelIssueDate);
            Controls.Add(ddlEmployee);
            Controls.Add(ddlType);
            Controls.Add(_ddlArea);
            Controls.Add(_btnAddDocumentType);
            Controls.Add(BunifuLabel6);
            Controls.Add(BunifuLabel5);
            Controls.Add(BunifuLabel1);
            Controls.Add(_txtExpireDate);
            Controls.Add(BunifuLabel4);
            Controls.Add(_btnSearchFile);
            Controls.Add(txtFile);
            Controls.Add(BunifuLabel8);
            Controls.Add(_txtIssueDate);
            Controls.Add(BunifuLabel7);
            Controls.Add(_btnSave);
            Controls.Add(BunifuLabel3);
            Controls.Add(txtDescription);
            Controls.Add(BunifuLabel2);
            Controls.Add(txtFileTitle);
            Controls.Add(_closeLabel);
            Controls.Add(Label2);
            ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddEditStoreFiles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddEditStoreFiles";
            ((System.ComponentModel.ISupportInitialize)EmployeeNameBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredDepartmentBindingSource).EndInit();
            Load += new EventHandler(frmAddEditStoreFiles_Load);
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

        internal Label Label2;
        internal BunifuTextBox txtFile;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel8;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel7;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel6;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnSave;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSave != null)
                {
                    _btnSave.Click -= btnSave_Click;
                }

                _btnSave = value;
                if (_btnSave != null)
                {
                    _btnSave.Click += btnSave_Click;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel3;
        internal BunifuTextBox txtDescription;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel2;
        internal BunifuTextBox txtFileTitle;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel1;
        internal OpenFileDialog ofdDoc;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnSearchFile;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSearchFile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSearchFile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSearchFile != null)
                {
                    _btnSearchFile.Click -= btnSearchFile_Click;
                }

                _btnSearchFile = value;
                if (_btnSearchFile != null)
                {
                    _btnSearchFile.Click += btnSearchFile_Click;
                }
            }
        }

        internal BindingSource EmployeeNameBindingSource;
        private Bunifu.UI.WinForms.BunifuDatePicker _txtExpireDate;

        internal Bunifu.UI.WinForms.BunifuDatePicker txtExpireDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtExpireDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtExpireDate != null)
                {
                    _txtExpireDate.ValueChanged -= txtExpireDate_ValueChanged;
                }

                _txtExpireDate = value;
                if (_txtExpireDate != null)
                {
                    _txtExpireDate.ValueChanged += txtExpireDate_ValueChanged;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddDocumentType;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddDocumentType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddDocumentType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddDocumentType != null)
                {
                    _btnAddDocumentType.Click -= btnAddDocumentType_Click;
                }

                _btnAddDocumentType = value;
                if (_btnAddDocumentType != null)
                {
                    _btnAddDocumentType.Click += btnAddDocumentType_Click;
                }
            }
        }

        internal BindingSource DocumentsStoredTypeBindingSource;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel5;
        internal BindingSource DocumentsStoredDepartmentBindingSource;
        private ComboBox _ddlArea;

        internal ComboBox ddlArea
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ddlArea;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ddlArea != null)
                {
                    _ddlArea.SelectedIndexChanged -= ddlArea_SelectedIndexChanged;
                }

                _ddlArea = value;
                if (_ddlArea != null)
                {
                    _ddlArea.SelectedIndexChanged += ddlArea_SelectedIndexChanged;
                }
            }
        }

        internal ComboBox ddlType;
        internal ComboBox ddlEmployee;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnCancelIssueDate;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelIssueDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCancelIssueDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCancelIssueDate != null)
                {
                    _btnCancelIssueDate.Click -= btnCancelIssueDate_Click;
                }

                _btnCancelIssueDate = value;
                if (_btnCancelIssueDate != null)
                {
                    _btnCancelIssueDate.Click += btnCancelIssueDate_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDatePicker _txtIssueDate;

        internal Bunifu.UI.WinForms.BunifuDatePicker txtIssueDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtIssueDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtIssueDate != null)
                {
                    _txtIssueDate.ValueChanged -= txtIssueDate_ValueChanged;
                }

                _txtIssueDate = value;
                if (_txtIssueDate != null)
                {
                    _txtIssueDate.ValueChanged += txtIssueDate_ValueChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnCancelExpireDate;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelExpireDate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCancelExpireDate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCancelExpireDate != null)
                {
                    _btnCancelExpireDate.Click -= btnCancelExpireDate_Click;
                }

                _btnCancelExpireDate = value;
                if (_btnCancelExpireDate != null)
                {
                    _btnCancelExpireDate.Click += btnCancelExpireDate_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAddDepartment;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddDepartment
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAddDepartment;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddDepartment != null)
                {
                    _btnAddDepartment.Click -= btnAddDepartment_Click;
                }

                _btnAddDepartment = value;
                if (_btnAddDepartment != null)
                {
                    _btnAddDepartment.Click += btnAddDepartment_Click;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel9;
    }
}