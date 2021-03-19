using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Microsoft.VisualBasic.CompilerServices;
using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmAddDocumentType : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDocumentType));
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Label2 = new Label();
            BunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            txtDocumentType = new BunifuTextBox();
            _btnInsert = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnInsert.Click += new EventHandler(btnInsert_Click);
            _btnClose = new Label();
            _btnClose.Click += new EventHandler(btnClose_Click);
            BunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            ddlDepartment = new Bunifu.UI.WinForms.BunifuDropdown();
            DocumentsStoredDepartmentBindingSource = new BindingSource(components);
            GroupBox1 = new GroupBox();
            BunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            Panel1 = new Panel();
            dgvDocGroup = new Bunifu.UI.WinForms.BunifuDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Chebox = new DataGridViewCheckBoxColumn();
            Group = new DataGridViewTextBoxColumn();
            btnAddDepartment = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            BunifuTextBox1 = new BunifuTextBox();
            BunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredDepartmentBindingSource).BeginInit();
            GroupBox1.SuspendLayout();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocGroup).BeginInit();
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Dock = DockStyle.Top;
            Label2.Font = new Font("Microsoft Sans Serif", 22.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(0, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(629, 41);
            Label2.TabIndex = 146;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuLabel3
            // 
            BunifuLabel3.AutoEllipsis = false;
            BunifuLabel3.CursorType = null;
            BunifuLabel3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel3.Location = new Point(40, 137);
            BunifuLabel3.Name = "BunifuLabel3";
            BunifuLabel3.RightToLeft = RightToLeft.No;
            BunifuLabel3.Size = new Size(135, 24);
            BunifuLabel3.TabIndex = 192;
            BunifuLabel3.Text = "Document Type:";
            BunifuLabel3.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtDocumentType
            // 
            txtDocumentType.AcceptsReturn = false;
            txtDocumentType.AcceptsTab = false;
            txtDocumentType.AnimationSpeed = 200;
            txtDocumentType.AutoCompleteMode = AutoCompleteMode.None;
            txtDocumentType.AutoCompleteSource = AutoCompleteSource.None;
            txtDocumentType.BackColor = Color.Transparent;
            txtDocumentType.BackgroundImage = (Image)resources.GetObject("txtDocumentType.BackgroundImage");
            txtDocumentType.BorderColorActive = Color.DodgerBlue;
            txtDocumentType.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            txtDocumentType.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            txtDocumentType.BorderColorIdle = Color.Silver;
            txtDocumentType.BorderRadius = 1;
            txtDocumentType.BorderThickness = 1;
            txtDocumentType.CharacterCasing = CharacterCasing.Upper;
            txtDocumentType.Cursor = Cursors.IBeam;
            txtDocumentType.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            txtDocumentType.DefaultText = "";
            txtDocumentType.FillColor = Color.White;
            txtDocumentType.HideSelection = true;
            txtDocumentType.IconLeft = null;
            txtDocumentType.IconLeftCursor = Cursors.IBeam;
            txtDocumentType.IconPadding = 10;
            txtDocumentType.IconRight = null;
            txtDocumentType.IconRightCursor = Cursors.IBeam;
            txtDocumentType.Lines = new string[0];
            txtDocumentType.Location = new Point(175, 130);
            txtDocumentType.MaxLength = 32767;
            txtDocumentType.MinimumSize = new Size(100, 35);
            txtDocumentType.Modified = false;
            txtDocumentType.Multiline = false;
            txtDocumentType.Name = "txtDocumentType";
            StateProperties1.BorderColor = Color.DodgerBlue;
            StateProperties1.FillColor = Color.Empty;
            StateProperties1.ForeColor = Color.Empty;
            StateProperties1.PlaceholderForeColor = Color.Empty;
            txtDocumentType.OnActiveState = StateProperties1;
            StateProperties2.BorderColor = Color.Empty;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.Empty;
            StateProperties2.PlaceholderForeColor = Color.Silver;
            txtDocumentType.OnDisabledState = StateProperties2;
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties3.FillColor = Color.Empty;
            StateProperties3.ForeColor = Color.Empty;
            StateProperties3.PlaceholderForeColor = Color.Empty;
            txtDocumentType.OnHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Silver;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.Empty;
            StateProperties4.PlaceholderForeColor = Color.Empty;
            txtDocumentType.OnIdleState = StateProperties4;
            txtDocumentType.PasswordChar = '\0';
            txtDocumentType.PlaceholderForeColor = Color.Silver;
            txtDocumentType.PlaceholderText = "ENTER TEXT";
            txtDocumentType.ReadOnly = false;
            txtDocumentType.ScrollBars = ScrollBars.None;
            txtDocumentType.SelectedText = "";
            txtDocumentType.SelectionLength = 0;
            txtDocumentType.SelectionStart = 0;
            txtDocumentType.ShortcutsEnabled = true;
            txtDocumentType.Size = new Size(425, 35);
            txtDocumentType.Style = _Style.Bunifu;
            txtDocumentType.TabIndex = 193;
            txtDocumentType.TextAlign = HorizontalAlignment.Left;
            txtDocumentType.TextMarginBottom = 0;
            txtDocumentType.TextMarginLeft = 5;
            txtDocumentType.TextMarginTop = 0;
            txtDocumentType.TextPlaceholder = "ENTER TEXT";
            txtDocumentType.UseSystemPasswordChar = false;
            txtDocumentType.WordWrap = true;
            // 
            // btnInsert
            // 
            _btnInsert.AllowToggling = false;
            _btnInsert.AnimationSpeed = 200;
            _btnInsert.AutoGenerateColors = false;
            _btnInsert.BackColor = Color.Transparent;
            _btnInsert.BackColor1 = Color.Teal;
            _btnInsert.BackgroundImage = (Image)resources.GetObject("btnInsert.BackgroundImage");
            _btnInsert.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnInsert.ButtonText = "Insert";
            _btnInsert.ButtonTextMarginLeft = 0;
            _btnInsert.ColorContrastOnClick = 45;
            _btnInsert.ColorContrastOnHover = 45;
            _btnInsert.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnInsert.CustomizableEdges = BorderEdges1;
            _btnInsert.DialogResult = DialogResult.None;
            _btnInsert.DisabledBorderColor = Color.Empty;
            _btnInsert.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnInsert.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnInsert.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnInsert.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnInsert.ForeColor = Color.White;
            _btnInsert.IconLeftCursor = Cursors.Hand;
            _btnInsert.IconMarginLeft = 11;
            _btnInsert.IconPadding = 10;
            _btnInsert.IconRightCursor = Cursors.Hand;
            _btnInsert.IdleBorderColor = Color.Teal;
            _btnInsert.IdleBorderRadius = 3;
            _btnInsert.IdleBorderThickness = 1;
            _btnInsert.IdleFillColor = Color.Teal;
            _btnInsert.IdleIconLeftImage = null;
            _btnInsert.IdleIconRightImage = null;
            _btnInsert.IndicateFocus = true;
            _btnInsert.Location = new Point(508, 176);
            _btnInsert.Name = "_btnInsert";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _btnInsert.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Teal;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _btnInsert.OnPressedState = StateProperties6;
            _btnInsert.Size = new Size(100, 40);
            _btnInsert.TabIndex = 199;
            _btnInsert.TextAlign = ContentAlignment.MiddleCenter;
            _btnInsert.TextMarginLeft = 0;
            _btnInsert.UseDefaultRadiusAndThickness = true;
            // 
            // btnClose
            // 
            _btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnClose.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _btnClose.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClose.ForeColor = Color.White;
            _btnClose.Location = new Point(589, -4);
            _btnClose.Margin = new Padding(0);
            _btnClose.Name = "_btnClose";
            _btnClose.Size = new Size(40, 41);
            _btnClose.TabIndex = 203;
            _btnClose.Text = "🗙";
            _btnClose.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuLabel5
            // 
            BunifuLabel5.AutoEllipsis = false;
            BunifuLabel5.CursorType = null;
            BunifuLabel5.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuLabel5.Location = new Point(68, 92);
            BunifuLabel5.Name = "BunifuLabel5";
            BunifuLabel5.RightToLeft = RightToLeft.No;
            BunifuLabel5.Size = new Size(101, 24);
            BunifuLabel5.TabIndex = 210;
            BunifuLabel5.Text = "Department:";
            BunifuLabel5.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ddlDepartment
            // 
            ddlDepartment.BackColor = Color.White;
            ddlDepartment.BorderRadius = 1;
            ddlDepartment.Color = Color.Gray;
            ddlDepartment.DataSource = DocumentsStoredDepartmentBindingSource;
            ddlDepartment.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            ddlDepartment.DisabledColor = Color.Gray;
            ddlDepartment.DisplayMember = "DescDocumentsStoredDepartment";
            ddlDepartment.DrawMode = DrawMode.OwnerDrawFixed;
            ddlDepartment.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            ddlDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlDepartment.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            ddlDepartment.Enabled = false;
            ddlDepartment.FillDropDown = false;
            ddlDepartment.FillIndicator = false;
            ddlDepartment.FlatStyle = FlatStyle.Flat;
            ddlDepartment.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ddlDepartment.ForeColor = Color.Black;
            ddlDepartment.FormattingEnabled = true;
            ddlDepartment.Icon = null;
            ddlDepartment.IndicatorColor = Color.Gray;
            ddlDepartment.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            ddlDepartment.ItemBackColor = Color.White;
            ddlDepartment.ItemBorderColor = Color.White;
            ddlDepartment.ItemForeColor = Color.Black;
            ddlDepartment.ItemHeight = 26;
            ddlDepartment.ItemHighLightColor = Color.DodgerBlue;
            ddlDepartment.Location = new Point(175, 92);
            ddlDepartment.Name = "ddlDepartment";
            ddlDepartment.Size = new Size(230, 32);
            ddlDepartment.TabIndex = 209;
            ddlDepartment.Text = null;
            ddlDepartment.ValueMember = "DocumentsStoredDepartmentId";
            // 
            // DocumentsStoredDepartmentBindingSource
            // 
            DocumentsStoredDepartmentBindingSource.DataSource = typeof(ModelLayer.DocumentsStoredDepartment);
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(BunifuButton1);
            GroupBox1.Controls.Add(Panel1);
            GroupBox1.Controls.Add(btnAddDepartment);
            GroupBox1.Controls.Add(BunifuTextBox1);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            GroupBox1.Location = new Point(12, 245);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(596, 323);
            GroupBox1.TabIndex = 211;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Group";
            // 
            // BunifuButton1
            // 
            BunifuButton1.AllowToggling = false;
            BunifuButton1.AnimationSpeed = 200;
            BunifuButton1.AutoGenerateColors = false;
            BunifuButton1.BackColor = Color.Transparent;
            BunifuButton1.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuButton1.BackgroundImage = (Image)resources.GetObject("BunifuButton1.BackgroundImage");
            BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            BunifuButton1.ButtonText = "";
            BunifuButton1.ButtonTextMarginLeft = 0;
            BunifuButton1.ColorContrastOnClick = 45;
            BunifuButton1.ColorContrastOnHover = 45;
            BunifuButton1.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            BunifuButton1.CustomizableEdges = BorderEdges2;
            BunifuButton1.DialogResult = DialogResult.None;
            BunifuButton1.DisabledBorderColor = Color.Empty;
            BunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            BunifuButton1.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            BunifuButton1.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuButton1.ForeColor = Color.White;
            BunifuButton1.IconLeftCursor = Cursors.Hand;
            BunifuButton1.IconMarginLeft = 11;
            BunifuButton1.IconPadding = 10;
            BunifuButton1.IconRightCursor = Cursors.Hand;
            BunifuButton1.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuButton1.IdleBorderRadius = 3;
            BunifuButton1.IdleBorderThickness = 1;
            BunifuButton1.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuButton1.IdleIconLeftImage = My.Resources.Resources.removeWhite;
            BunifuButton1.IdleIconRightImage = null;
            BunifuButton1.IndicateFocus = true;
            BunifuButton1.Location = new Point(496, 35);
            BunifuButton1.Name = "BunifuButton1";
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(128)));
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            BunifuButton1.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            BunifuButton1.OnPressedState = StateProperties8;
            BunifuButton1.Size = new Size(32, 32);
            BunifuButton1.TabIndex = 226;
            BunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            BunifuButton1.TextMarginLeft = 0;
            BunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(dgvDocGroup);
            Panel1.Location = new Point(19, 108);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(560, 196);
            Panel1.TabIndex = 225;
            // 
            // dgvDocGroup
            // 
            dgvDocGroup.AllowCustomTheming = true;
            dgvDocGroup.AllowUserToAddRows = false;
            dgvDocGroup.AllowUserToDeleteRows = false;
            dgvDocGroup.AllowUserToResizeColumns = false;
            dgvDocGroup.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvDocGroup.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dgvDocGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGroup.BackgroundColor = Color.White;
            dgvDocGroup.BorderStyle = BorderStyle.None;
            dgvDocGroup.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDocGroup.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDocGroup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dgvDocGroup.ColumnHeadersHeight = 40;
            dgvDocGroup.Columns.AddRange(new DataGridViewColumn[] { Column1, Chebox, Group });
            dgvDocGroup.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            dgvDocGroup.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvDocGroup.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvDocGroup.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            dgvDocGroup.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvDocGroup.CurrentTheme.BackColor = Color.Snow;
            dgvDocGroup.CurrentTheme.GridColor = Color.Gray;
            dgvDocGroup.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvDocGroup.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            dgvDocGroup.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvDocGroup.CurrentTheme.Name = null;
            dgvDocGroup.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            dgvDocGroup.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvDocGroup.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvDocGroup.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            dgvDocGroup.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDocGroup.DefaultCellStyle = DataGridViewCellStyle3;
            dgvDocGroup.Dock = DockStyle.Fill;
            dgvDocGroup.EnableHeadersVisualStyles = false;
            dgvDocGroup.GridColor = Color.Gray;
            dgvDocGroup.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvDocGroup.HeaderBgColor = Color.Empty;
            dgvDocGroup.HeaderForeColor = Color.White;
            dgvDocGroup.Location = new Point(0, 0);
            dgvDocGroup.MultiSelect = false;
            dgvDocGroup.Name = "dgvDocGroup";
            dgvDocGroup.ReadOnly = true;
            dgvDocGroup.RowHeadersVisible = false;
            dgvDocGroup.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgvDocGroup.RowTemplate.Height = 40;
            dgvDocGroup.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocGroup.Size = new Size(558, 194);
            dgvDocGroup.TabIndex = 212;
            dgvDocGroup.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column1
            // 
            Column1.HeaderText = "GroupId";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Chebox
            // 
            Chebox.HeaderText = "";
            Chebox.Name = "Chebox";
            Chebox.ReadOnly = true;
            // 
            // Group
            // 
            Group.HeaderText = "Group";
            Group.Name = "Group";
            Group.ReadOnly = true;
            Group.Visible = false;
            // 
            // btnAddDepartment
            // 
            btnAddDepartment.AllowToggling = false;
            btnAddDepartment.AnimationSpeed = 200;
            btnAddDepartment.AutoGenerateColors = false;
            btnAddDepartment.BackColor = Color.Transparent;
            btnAddDepartment.BackColor1 = Color.Teal;
            btnAddDepartment.BackgroundImage = (Image)resources.GetObject("btnAddDepartment.BackgroundImage");
            btnAddDepartment.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnAddDepartment.ButtonText = "";
            btnAddDepartment.ButtonTextMarginLeft = 0;
            btnAddDepartment.ColorContrastOnClick = 45;
            btnAddDepartment.ColorContrastOnHover = 45;
            btnAddDepartment.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            btnAddDepartment.CustomizableEdges = BorderEdges3;
            btnAddDepartment.DialogResult = DialogResult.None;
            btnAddDepartment.DisabledBorderColor = Color.Empty;
            btnAddDepartment.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            btnAddDepartment.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            btnAddDepartment.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnAddDepartment.Font = new Font("Segoe UI Semibold", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            btnAddDepartment.ForeColor = Color.White;
            btnAddDepartment.IconLeftCursor = Cursors.Hand;
            btnAddDepartment.IconMarginLeft = 11;
            btnAddDepartment.IconPadding = 10;
            btnAddDepartment.IconRightCursor = Cursors.Hand;
            btnAddDepartment.IdleBorderColor = Color.Teal;
            btnAddDepartment.IdleBorderRadius = 3;
            btnAddDepartment.IdleBorderThickness = 1;
            btnAddDepartment.IdleFillColor = Color.Teal;
            btnAddDepartment.IdleIconLeftImage = My.Resources.Resources.addWhite;
            btnAddDepartment.IdleIconRightImage = null;
            btnAddDepartment.IndicateFocus = true;
            btnAddDepartment.Location = new Point(438, 35);
            btnAddDepartment.Name = "btnAddDepartment";
            StateProperties9.BorderColor = Color.MediumTurquoise;
            StateProperties9.BorderRadius = 3;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.MediumTurquoise;
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            btnAddDepartment.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.Teal;
            StateProperties10.BorderRadius = 3;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.Teal;
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            btnAddDepartment.OnPressedState = StateProperties10;
            btnAddDepartment.Size = new Size(32, 32);
            btnAddDepartment.TabIndex = 224;
            btnAddDepartment.TextAlign = ContentAlignment.MiddleCenter;
            btnAddDepartment.TextMarginLeft = 0;
            btnAddDepartment.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuTextBox1
            // 
            BunifuTextBox1.AcceptsReturn = false;
            BunifuTextBox1.AcceptsTab = false;
            BunifuTextBox1.AnimationSpeed = 200;
            BunifuTextBox1.AutoCompleteMode = AutoCompleteMode.None;
            BunifuTextBox1.AutoCompleteSource = AutoCompleteSource.None;
            BunifuTextBox1.BackColor = Color.Transparent;
            BunifuTextBox1.BackgroundImage = (Image)resources.GetObject("BunifuTextBox1.BackgroundImage");
            BunifuTextBox1.BorderColorActive = Color.DodgerBlue;
            BunifuTextBox1.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            BunifuTextBox1.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            BunifuTextBox1.BorderColorIdle = Color.Silver;
            BunifuTextBox1.BorderRadius = 1;
            BunifuTextBox1.BorderThickness = 1;
            BunifuTextBox1.CharacterCasing = CharacterCasing.Upper;
            BunifuTextBox1.Cursor = Cursors.IBeam;
            BunifuTextBox1.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            BunifuTextBox1.DefaultText = "";
            BunifuTextBox1.FillColor = Color.White;
            BunifuTextBox1.HideSelection = true;
            BunifuTextBox1.IconLeft = null;
            BunifuTextBox1.IconLeftCursor = Cursors.IBeam;
            BunifuTextBox1.IconPadding = 10;
            BunifuTextBox1.IconRight = null;
            BunifuTextBox1.IconRightCursor = Cursors.IBeam;
            BunifuTextBox1.Lines = new string[0];
            BunifuTextBox1.Location = new Point(10, 34);
            BunifuTextBox1.MaxLength = 32767;
            BunifuTextBox1.MinimumSize = new Size(100, 35);
            BunifuTextBox1.Modified = false;
            BunifuTextBox1.Multiline = false;
            BunifuTextBox1.Name = "BunifuTextBox1";
            StateProperties11.BorderColor = Color.DodgerBlue;
            StateProperties11.FillColor = Color.Empty;
            StateProperties11.ForeColor = Color.Empty;
            StateProperties11.PlaceholderForeColor = Color.Empty;
            BunifuTextBox1.OnActiveState = StateProperties11;
            StateProperties12.BorderColor = Color.Empty;
            StateProperties12.FillColor = Color.White;
            StateProperties12.ForeColor = Color.Empty;
            StateProperties12.PlaceholderForeColor = Color.Silver;
            StateProperties12.PlaceholderForeColor = Color.Silver;
            BunifuTextBox1.OnDisabledState = StateProperties12;
            StateProperties13.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties13.FillColor = Color.Empty;
            StateProperties13.ForeColor = Color.Empty;
            StateProperties13.PlaceholderForeColor = Color.Empty;
            BunifuTextBox1.OnHoverState = StateProperties13;
            StateProperties14.BorderColor = Color.Silver;
            StateProperties14.FillColor = Color.White;
            StateProperties14.ForeColor = Color.Empty;
            StateProperties14.PlaceholderForeColor = Color.Empty;
            BunifuTextBox1.OnIdleState = StateProperties14;
            BunifuTextBox1.PasswordChar = '\0';
            BunifuTextBox1.PlaceholderForeColor = Color.Silver;
            BunifuTextBox1.PlaceholderText = "ENTER TEXT";
            BunifuTextBox1.ReadOnly = false;
            BunifuTextBox1.ScrollBars = ScrollBars.None;
            BunifuTextBox1.SelectedText = "";
            BunifuTextBox1.SelectionLength = 0;
            BunifuTextBox1.SelectionStart = 0;
            BunifuTextBox1.ShortcutsEnabled = true;
            BunifuTextBox1.Size = new Size(422, 35);
            BunifuTextBox1.Style = _Style.Bunifu;
            BunifuTextBox1.TabIndex = 212;
            BunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            BunifuTextBox1.TextMarginBottom = 0;
            BunifuTextBox1.TextMarginLeft = 5;
            BunifuTextBox1.TextMarginTop = 0;
            BunifuTextBox1.TextPlaceholder = "ENTER TEXT";
            BunifuTextBox1.UseSystemPasswordChar = false;
            BunifuTextBox1.WordWrap = true;
            // 
            // BunifuLabel1
            // 
            BunifuLabel1.AutoEllipsis = false;
            BunifuLabel1.CursorType = null;
            BunifuLabel1.Font = new Font("Microsoft Sans Serif", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuLabel1.Location = new Point(32, 56);
            BunifuLabel1.Name = "BunifuLabel1";
            BunifuLabel1.RightToLeft = RightToLeft.No;
            BunifuLabel1.Size = new Size(212, 27);
            BunifuLabel1.TabIndex = 212;
            BunifuLabel1.Text = "Add document type:";
            BunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmAddDocumentType
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(629, 232);
            Controls.Add(BunifuLabel1);
            Controls.Add(GroupBox1);
            Controls.Add(BunifuLabel5);
            Controls.Add(ddlDepartment);
            Controls.Add(_btnClose);
            Controls.Add(_btnInsert);
            Controls.Add(txtDocumentType);
            Controls.Add(BunifuLabel3);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddDocumentType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddDocumentType";
            ((System.ComponentModel.ISupportInitialize)DocumentsStoredDepartmentBindingSource).EndInit();
            GroupBox1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocGroup).EndInit();
            Load += new EventHandler(frmAddDocumentType_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label2;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel3;
        internal BunifuTextBox txtDocumentType;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnInsert;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInsert
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnInsert;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnInsert != null)
                {
                    _btnInsert.Click -= btnInsert_Click;
                }

                _btnInsert = value;
                if (_btnInsert != null)
                {
                    _btnInsert.Click += btnInsert_Click;
                }
            }
        }

        private Label _btnClose;

        internal Label btnClose
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnClose;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnClose != null)
                {
                    _btnClose.Click -= btnClose_Click;
                }

                _btnClose = value;
                if (_btnClose != null)
                {
                    _btnClose.Click += btnClose_Click;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel5;
        internal Bunifu.UI.WinForms.BunifuDropdown ddlDepartment;
        internal BindingSource DocumentsStoredDepartmentBindingSource;
        internal GroupBox GroupBox1;
        internal BunifuTextBox BunifuTextBox1;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddDepartment;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvDocGroup;
        internal Panel Panel1;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewCheckBoxColumn Chebox;
        internal DataGridViewTextBoxColumn Group;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton1;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel1;
    }
}