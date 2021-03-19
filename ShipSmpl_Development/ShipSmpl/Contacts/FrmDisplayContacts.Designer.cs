using System;
using System.Diagnostics;
using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;
namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmDisplayContacts : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayContacts));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties19 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties20 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            iconsImageList = new ImageList(components);
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel1 = new Panel();
            Panel2 = new Panel();
            Label1 = new Label();
            _addNewContactButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _addNewContactButton.Click += new EventHandler(adNewContactToolStripMenuItem_Click);
            TableLayoutPanel1 = new TableLayoutPanel();
            _editContactButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _editContactButton.Click += new EventHandler(ToolStripMenuItem6_Click);
            _deleteContactButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _deleteContactButton.Click += new EventHandler(deleteContactToolStripMenuItem7_Click);
            _findContactTextBox = new BunifuTextBox();
            _findContactTextBox.TextChanged += new EventHandler(findContactToolStripTextBox_Click);
            _findContactTextBox.TextChanged += new EventHandler(findContactToolStripTextBox_TextChanged);
            _tbSearchCompany = new BunifuTextBox();
            _tbSearchCompany.TextChanged += new EventHandler(ToolStripTextBox1_TextChanged);
            _tbSearchCompany.TextChanged += new EventHandler(ToolStripTextBox1_Click_1);
            Panel5 = new Panel();
            _contactsBunifuDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            _contactsBunifuDataGridView.SelectionChanged += new EventHandler(contactsListView_Click);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Panel4 = new Panel();
            _companiesBunifuDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            _companiesBunifuDataGridView.SelectionChanged += new EventHandler(companiesBunifuDataGridView_1);
            CompanyCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CompanyNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            EmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            WebsiteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            NotesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            RatingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AttentionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CategoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            VWCompanyBindingSource = new BindingSource(components);
            TableLayoutPanel3 = new TableLayoutPanel();
            _EditButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _EditButton.Click += new EventHandler(EditButton_Click);
            _DeleteCompanyButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _DeleteCompanyButton.Click += new EventHandler(DeleteToolStripMenuItem_Click);
            _newCompanyButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _newCompanyButton.Click += new EventHandler(CompanyToolStripMenuItem_Click);
            timeSheetDescriptionLabel = new Label();
            BunifuShadowPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_contactsBunifuDataGridView).BeginInit();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_companiesBunifuDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWCompanyBindingSource).BeginInit();
            TableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // iconsImageList
            // 
            iconsImageList.ImageStream = (ImageListStreamer)resources.GetObject("iconsImageList.ImageStream");
            iconsImageList.TransparentColor = Color.Transparent;
            iconsImageList.Images.SetKeyName(0, "add.png");
            iconsImageList.Images.SetKeyName(1, "delete.png");
            iconsImageList.Images.SetKeyName(2, "pencil.png");
            // 
            // BunifuShadowPanel1
            // 
            BunifuShadowPanel1.BackColor = Color.White;
            BunifuShadowPanel1.BorderColor = Color.Transparent;
            BunifuShadowPanel1.Controls.Add(Panel1);
            BunifuShadowPanel1.Dock = DockStyle.Fill;
            BunifuShadowPanel1.ForeColor = Color.White;
            BunifuShadowPanel1.Location = new Point(0, 0);
            BunifuShadowPanel1.Margin = new Padding(0);
            BunifuShadowPanel1.Name = "BunifuShadowPanel1";
            BunifuShadowPanel1.Padding = new Padding(10, 10, 5, 5);
            BunifuShadowPanel1.PanelColor = Color.Empty;
            BunifuShadowPanel1.ShadowDept = 2;
            BunifuShadowPanel1.ShadowTopLeftVisible = true;
            BunifuShadowPanel1.Size = new Size(1522, 894);
            BunifuShadowPanel1.TabIndex = 58;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel1.Controls.Add(Panel2);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(10, 10);
            Panel1.Name = "Panel1";
            Panel1.Padding = new Padding(0, 40, 0, 0);
            Panel1.Size = new Size(1507, 879);
            Panel1.TabIndex = 33;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(_addNewContactButton);
            Panel2.Controls.Add(TableLayoutPanel1);
            Panel2.Controls.Add(_findContactTextBox);
            Panel2.Controls.Add(_tbSearchCompany);
            Panel2.Controls.Add(Panel5);
            Panel2.Controls.Add(Panel4);
            Panel2.Controls.Add(TableLayoutPanel3);
            Panel2.Controls.Add(_newCompanyButton);
            Panel2.Controls.Add(timeSheetDescriptionLabel);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(0, 40);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1507, 839);
            Panel2.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Segoe UI Semibold", 18.32727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label1.Location = new Point(45, 522);
            Label1.Name = "Label1";
            Label1.Size = new Size(156, 44);
            Label1.TabIndex = 82;
            Label1.Text = "Contacts";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addNewContactButton
            // 
            _addNewContactButton.AllowToggling = false;
            _addNewContactButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _addNewContactButton.AnimationSpeed = 200;
            _addNewContactButton.AutoGenerateColors = false;
            _addNewContactButton.BackColor = Color.Transparent;
            _addNewContactButton.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _addNewContactButton.BackgroundImage = (Image)resources.GetObject("addNewContactButton.BackgroundImage");
            _addNewContactButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _addNewContactButton.ButtonText = "New Contact";
            _addNewContactButton.ButtonTextMarginLeft = 0;
            _addNewContactButton.ColorContrastOnClick = 45;
            _addNewContactButton.ColorContrastOnHover = 45;
            _addNewContactButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _addNewContactButton.CustomizableEdges = BorderEdges1;
            _addNewContactButton.DialogResult = DialogResult.None;
            _addNewContactButton.DisabledBorderColor = Color.Empty;
            _addNewContactButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _addNewContactButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _addNewContactButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _addNewContactButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _addNewContactButton.ForeColor = Color.White;
            _addNewContactButton.IconLeftCursor = Cursors.Hand;
            _addNewContactButton.IconMarginLeft = 11;
            _addNewContactButton.IconPadding = 10;
            _addNewContactButton.IconRightCursor = Cursors.Hand;
            _addNewContactButton.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _addNewContactButton.IdleBorderRadius = 40;
            _addNewContactButton.IdleBorderThickness = 1;
            _addNewContactButton.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _addNewContactButton.IdleIconLeftImage = null;
            _addNewContactButton.IdleIconRightImage = null;
            _addNewContactButton.IndicateFocus = true;
            _addNewContactButton.Location = new Point(1314, 625);
            _addNewContactButton.Name = "_addNewContactButton";
            StateProperties1.BorderColor = Color.Coral;
            StateProperties1.BorderRadius = 40;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.Coral;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _addNewContactButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties2.BorderRadius = 40;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _addNewContactButton.OnPressedState = StateProperties2;
            _addNewContactButton.Size = new Size(137, 45);
            _addNewContactButton.TabIndex = 81;
            _addNewContactButton.TextAlign = ContentAlignment.MiddleCenter;
            _addNewContactButton.TextMarginLeft = 0;
            _addNewContactButton.UseDefaultRadiusAndThickness = true;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel1.Controls.Add(_editContactButton, 0, 0);
            TableLayoutPanel1.Controls.Add(_deleteContactButton, 1, 0);
            TableLayoutPanel1.Location = new Point(985, 975);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel1.Size = new Size(257, 55);
            TableLayoutPanel1.TabIndex = 80;
            // 
            // editContactButton
            // 
            _editContactButton.AllowToggling = false;
            _editContactButton.AnimationSpeed = 200;
            _editContactButton.AutoGenerateColors = false;
            _editContactButton.BackColor = Color.Transparent;
            _editContactButton.BackColor1 = Color.Teal;
            _editContactButton.BackgroundImage = (Image)resources.GetObject("editContactButton.BackgroundImage");
            _editContactButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _editContactButton.ButtonText = "Edit";
            _editContactButton.ButtonTextMarginLeft = 0;
            _editContactButton.ColorContrastOnClick = 45;
            _editContactButton.ColorContrastOnHover = 45;
            _editContactButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _editContactButton.CustomizableEdges = BorderEdges2;
            _editContactButton.DialogResult = DialogResult.None;
            _editContactButton.DisabledBorderColor = Color.Empty;
            _editContactButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _editContactButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _editContactButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _editContactButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _editContactButton.ForeColor = Color.White;
            _editContactButton.IconLeftCursor = Cursors.Hand;
            _editContactButton.IconMarginLeft = 11;
            _editContactButton.IconPadding = 10;
            _editContactButton.IconRightCursor = Cursors.Hand;
            _editContactButton.IdleBorderColor = Color.Teal;
            _editContactButton.IdleBorderRadius = 3;
            _editContactButton.IdleBorderThickness = 1;
            _editContactButton.IdleFillColor = Color.Teal;
            _editContactButton.IdleIconLeftImage = null;
            _editContactButton.IdleIconRightImage = null;
            _editContactButton.IndicateFocus = true;
            _editContactButton.Location = new Point(3, 3);
            _editContactButton.Name = "_editContactButton";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _editContactButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _editContactButton.OnPressedState = StateProperties4;
            _editContactButton.Size = new Size(122, 45);
            _editContactButton.TabIndex = 67;
            _editContactButton.TextAlign = ContentAlignment.MiddleCenter;
            _editContactButton.TextMarginLeft = 0;
            _editContactButton.UseDefaultRadiusAndThickness = true;
            // 
            // deleteContactButton
            // 
            _deleteContactButton.AllowToggling = false;
            _deleteContactButton.AnimationSpeed = 200;
            _deleteContactButton.AutoGenerateColors = false;
            _deleteContactButton.BackColor = Color.Transparent;
            _deleteContactButton.BackColor1 = Color.IndianRed;
            _deleteContactButton.BackgroundImage = (Image)resources.GetObject("deleteContactButton.BackgroundImage");
            _deleteContactButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _deleteContactButton.ButtonText = "Delete";
            _deleteContactButton.ButtonTextMarginLeft = 0;
            _deleteContactButton.ColorContrastOnClick = 45;
            _deleteContactButton.ColorContrastOnHover = 45;
            _deleteContactButton.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _deleteContactButton.CustomizableEdges = BorderEdges3;
            _deleteContactButton.DialogResult = DialogResult.None;
            _deleteContactButton.DisabledBorderColor = Color.Empty;
            _deleteContactButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _deleteContactButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _deleteContactButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _deleteContactButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _deleteContactButton.ForeColor = Color.White;
            _deleteContactButton.IconLeftCursor = Cursors.Hand;
            _deleteContactButton.IconMarginLeft = 11;
            _deleteContactButton.IconPadding = 10;
            _deleteContactButton.IconRightCursor = Cursors.Hand;
            _deleteContactButton.IdleBorderColor = Color.IndianRed;
            _deleteContactButton.IdleBorderRadius = 3;
            _deleteContactButton.IdleBorderThickness = 1;
            _deleteContactButton.IdleFillColor = Color.IndianRed;
            _deleteContactButton.IdleIconLeftImage = null;
            _deleteContactButton.IdleIconRightImage = null;
            _deleteContactButton.IndicateFocus = true;
            _deleteContactButton.Location = new Point(131, 3);
            _deleteContactButton.Name = "_deleteContactButton";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _deleteContactButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.LightCoral;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.LightCoral;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _deleteContactButton.OnPressedState = StateProperties6;
            _deleteContactButton.Size = new Size(123, 45);
            _deleteContactButton.TabIndex = 61;
            _deleteContactButton.TextAlign = ContentAlignment.MiddleCenter;
            _deleteContactButton.TextMarginLeft = 0;
            _deleteContactButton.UseDefaultRadiusAndThickness = true;
            // 
            // findContactTextBox
            // 
            _findContactTextBox.AcceptsReturn = false;
            _findContactTextBox.AcceptsTab = false;
            _findContactTextBox.AnimationSpeed = 200;
            _findContactTextBox.AutoCompleteMode = AutoCompleteMode.None;
            _findContactTextBox.AutoCompleteSource = AutoCompleteSource.None;
            _findContactTextBox.BackColor = Color.Transparent;
            _findContactTextBox.BackgroundImage = (Image)resources.GetObject("findContactTextBox.BackgroundImage");
            _findContactTextBox.BorderColorActive = Color.DodgerBlue;
            _findContactTextBox.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _findContactTextBox.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _findContactTextBox.BorderColorIdle = Color.Silver;
            _findContactTextBox.BorderRadius = 1;
            _findContactTextBox.BorderThickness = 1;
            _findContactTextBox.CharacterCasing = CharacterCasing.Normal;
            _findContactTextBox.Cursor = Cursors.IBeam;
            _findContactTextBox.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _findContactTextBox.DefaultText = "";
            _findContactTextBox.FillColor = Color.White;
            _findContactTextBox.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _findContactTextBox.HideSelection = true;
            _findContactTextBox.IconLeft = null;
            _findContactTextBox.IconLeftCursor = Cursors.IBeam;
            _findContactTextBox.IconPadding = 10;
            _findContactTextBox.IconRight = null;
            _findContactTextBox.IconRightCursor = Cursors.IBeam;
            _findContactTextBox.Lines = new string[0];
            _findContactTextBox.Location = new Point(909, 532);
            _findContactTextBox.MaxLength = 32767;
            _findContactTextBox.MinimumSize = new Size(100, 35);
            _findContactTextBox.Modified = false;
            _findContactTextBox.Multiline = false;
            _findContactTextBox.Name = "_findContactTextBox";
            StateProperties7.BorderColor = Color.DodgerBlue;
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            _findContactTextBox.OnActiveState = StateProperties7;
            StateProperties8.BorderColor = Color.Empty;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.Empty;
            StateProperties8.PlaceholderForeColor = Color.Silver;
            _findContactTextBox.OnDisabledState = StateProperties8;
            StateProperties9.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties9.FillColor = Color.Empty;
            StateProperties9.ForeColor = Color.Empty;
            StateProperties9.PlaceholderForeColor = Color.Empty;
            _findContactTextBox.OnHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.Silver;
            StateProperties10.FillColor = Color.White;
            StateProperties10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties10.PlaceholderForeColor = Color.Empty;
            _findContactTextBox.OnIdleState = StateProperties10;
            _findContactTextBox.PasswordChar = '\0';
            _findContactTextBox.PlaceholderForeColor = Color.Silver;
            _findContactTextBox.PlaceholderText = "Find...";
            _findContactTextBox.ReadOnly = false;
            _findContactTextBox.ScrollBars = ScrollBars.None;
            _findContactTextBox.SelectedText = "";
            _findContactTextBox.SelectionLength = 0;
            _findContactTextBox.SelectionStart = 0;
            _findContactTextBox.ShortcutsEnabled = true;
            _findContactTextBox.Size = new Size(398, 35);
            _findContactTextBox.Style = _Style.Bunifu;
            _findContactTextBox.TabIndex = 79;
            _findContactTextBox.TextAlign = HorizontalAlignment.Left;
            _findContactTextBox.TextMarginBottom = 0;
            _findContactTextBox.TextMarginLeft = 5;
            _findContactTextBox.TextMarginTop = 0;
            _findContactTextBox.TextPlaceholder = "Find...";
            _findContactTextBox.UseSystemPasswordChar = false;
            _findContactTextBox.WordWrap = true;
            // 
            // tbSearchCompany
            // 
            _tbSearchCompany.AcceptsReturn = false;
            _tbSearchCompany.AcceptsTab = false;
            _tbSearchCompany.AnimationSpeed = 200;
            _tbSearchCompany.AutoCompleteMode = AutoCompleteMode.None;
            _tbSearchCompany.AutoCompleteSource = AutoCompleteSource.None;
            _tbSearchCompany.BackColor = Color.Transparent;
            _tbSearchCompany.BackgroundImage = (Image)resources.GetObject("tbSearchCompany.BackgroundImage");
            _tbSearchCompany.BorderColorActive = Color.DodgerBlue;
            _tbSearchCompany.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            _tbSearchCompany.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            _tbSearchCompany.BorderColorIdle = Color.Silver;
            _tbSearchCompany.BorderRadius = 1;
            _tbSearchCompany.BorderThickness = 1;
            _tbSearchCompany.CharacterCasing = CharacterCasing.Normal;
            _tbSearchCompany.Cursor = Cursors.IBeam;
            _tbSearchCompany.DefaultFont = new Font("Segoe UI Semibold", 9.75f);
            _tbSearchCompany.DefaultText = "";
            _tbSearchCompany.FillColor = Color.White;
            _tbSearchCompany.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _tbSearchCompany.HideSelection = true;
            _tbSearchCompany.IconLeft = null;
            _tbSearchCompany.IconLeftCursor = Cursors.IBeam;
            _tbSearchCompany.IconPadding = 10;
            _tbSearchCompany.IconRight = null;
            _tbSearchCompany.IconRightCursor = Cursors.IBeam;
            _tbSearchCompany.Lines = new string[0];
            _tbSearchCompany.Location = new Point(909, 36);
            _tbSearchCompany.MaxLength = 32767;
            _tbSearchCompany.MinimumSize = new Size(100, 35);
            _tbSearchCompany.Modified = false;
            _tbSearchCompany.Multiline = false;
            _tbSearchCompany.Name = "_tbSearchCompany";
            StateProperties11.BorderColor = Color.DodgerBlue;
            StateProperties11.FillColor = Color.Empty;
            StateProperties11.ForeColor = Color.Empty;
            StateProperties11.PlaceholderForeColor = Color.Empty;
            _tbSearchCompany.OnActiveState = StateProperties11;
            StateProperties12.BorderColor = Color.Empty;
            StateProperties12.FillColor = Color.White;
            StateProperties12.ForeColor = Color.Empty;
            StateProperties12.PlaceholderForeColor = Color.Silver;
            _tbSearchCompany.OnDisabledState = StateProperties12;
            StateProperties13.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties13.FillColor = Color.Empty;
            StateProperties13.ForeColor = Color.Empty;
            StateProperties13.PlaceholderForeColor = Color.Empty;
            _tbSearchCompany.OnHoverState = StateProperties13;
            StateProperties14.BorderColor = Color.Silver;
            StateProperties14.FillColor = Color.White;
            StateProperties14.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties14.PlaceholderForeColor = Color.Empty;
            _tbSearchCompany.OnIdleState = StateProperties14;
            _tbSearchCompany.PasswordChar = '\0';
            _tbSearchCompany.PlaceholderForeColor = Color.Silver;
            _tbSearchCompany.PlaceholderText = "Find...";
            _tbSearchCompany.ReadOnly = false;
            _tbSearchCompany.ScrollBars = ScrollBars.None;
            _tbSearchCompany.SelectedText = "";
            _tbSearchCompany.SelectionLength = 0;
            _tbSearchCompany.SelectionStart = 0;
            _tbSearchCompany.ShortcutsEnabled = true;
            _tbSearchCompany.Size = new Size(398, 35);
            _tbSearchCompany.Style = _Style.Bunifu;
            _tbSearchCompany.TabIndex = 78;
            _tbSearchCompany.TextAlign = HorizontalAlignment.Left;
            _tbSearchCompany.TextMarginBottom = 0;
            _tbSearchCompany.TextMarginLeft = 5;
            _tbSearchCompany.TextMarginTop = 0;
            _tbSearchCompany.TextPlaceholder = "Find...";
            _tbSearchCompany.UseSystemPasswordChar = false;
            _tbSearchCompany.WordWrap = true;
            // 
            // Panel5
            // 
            Panel5.BorderStyle = BorderStyle.FixedSingle;
            Panel5.Controls.Add(_contactsBunifuDataGridView);
            Panel5.Location = new Point(85, 572);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(1219, 245);
            Panel5.TabIndex = 76;
            // 
            // contactsBunifuDataGridView
            // 
            _contactsBunifuDataGridView.AllowCustomTheming = true;
            _contactsBunifuDataGridView.AllowUserToAddRows = false;
            _contactsBunifuDataGridView.AllowUserToDeleteRows = false;
            _contactsBunifuDataGridView.AllowUserToResizeColumns = false;
            _contactsBunifuDataGridView.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _contactsBunifuDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _contactsBunifuDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _contactsBunifuDataGridView.BackgroundColor = Color.White;
            _contactsBunifuDataGridView.BorderStyle = BorderStyle.None;
            _contactsBunifuDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _contactsBunifuDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _contactsBunifuDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _contactsBunifuDataGridView.ColumnHeadersHeight = 35;
            _contactsBunifuDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            _contactsBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _contactsBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _contactsBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _contactsBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _contactsBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _contactsBunifuDataGridView.CurrentTheme.BackColor = Color.Snow;
            _contactsBunifuDataGridView.CurrentTheme.GridColor = Color.Gray;
            _contactsBunifuDataGridView.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _contactsBunifuDataGridView.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _contactsBunifuDataGridView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _contactsBunifuDataGridView.CurrentTheme.Name = null;
            _contactsBunifuDataGridView.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _contactsBunifuDataGridView.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _contactsBunifuDataGridView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _contactsBunifuDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _contactsBunifuDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _contactsBunifuDataGridView.DefaultCellStyle = DataGridViewCellStyle3;
            _contactsBunifuDataGridView.Dock = DockStyle.Fill;
            _contactsBunifuDataGridView.EnableHeadersVisualStyles = false;
            _contactsBunifuDataGridView.GridColor = Color.Gray;
            _contactsBunifuDataGridView.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _contactsBunifuDataGridView.HeaderBgColor = Color.Empty;
            _contactsBunifuDataGridView.HeaderForeColor = Color.White;
            _contactsBunifuDataGridView.Location = new Point(0, 0);
            _contactsBunifuDataGridView.Name = "_contactsBunifuDataGridView";
            _contactsBunifuDataGridView.ReadOnly = true;
            _contactsBunifuDataGridView.RowHeadersVisible = false;
            _contactsBunifuDataGridView.RowHeadersWidth = 51;
            _contactsBunifuDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _contactsBunifuDataGridView.RowTemplate.Height = 35;
            _contactsBunifuDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _contactsBunifuDataGridView.Size = new Size(1217, 243);
            _contactsBunifuDataGridView.TabIndex = 58;
            _contactsBunifuDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column1
            // 
            Column1.HeaderText = "First Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Last Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Email";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Mobile";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Department";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "ID";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            // 
            // Panel4
            // 
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(_companiesBunifuDataGridView);
            Panel4.Location = new Point(86, 74);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(1222, 396);
            Panel4.TabIndex = 75;
            // 
            // companiesBunifuDataGridView
            // 
            _companiesBunifuDataGridView.AllowCustomTheming = true;
            _companiesBunifuDataGridView.AllowUserToAddRows = false;
            _companiesBunifuDataGridView.AllowUserToDeleteRows = false;
            _companiesBunifuDataGridView.AllowUserToOrderColumns = true;
            _companiesBunifuDataGridView.AllowUserToResizeRows = false;
            DataGridViewCellStyle4.BackColor = SystemColors.Control;
            DataGridViewCellStyle4.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle4.ForeColor = Color.Black;
            DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _companiesBunifuDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
            _companiesBunifuDataGridView.AutoGenerateColumns = false;
            _companiesBunifuDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _companiesBunifuDataGridView.BackgroundColor = Color.White;
            _companiesBunifuDataGridView.BorderStyle = BorderStyle.None;
            _companiesBunifuDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            _companiesBunifuDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            _companiesBunifuDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            _companiesBunifuDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            _companiesBunifuDataGridView.ColumnHeadersHeight = 35;
            _companiesBunifuDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            _companiesBunifuDataGridView.Columns.AddRange(new DataGridViewColumn[] { CompanyCodeDataGridViewTextBoxColumn, CompanyNameDataGridViewTextBoxColumn, EmailDataGridViewTextBoxColumn, WebsiteDataGridViewTextBoxColumn, NotesDataGridViewTextBoxColumn, RatingDataGridViewTextBoxColumn, AttentionDataGridViewTextBoxColumn, CategoryNameDataGridViewTextBoxColumn });
            _companiesBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = SystemColors.Control;
            _companiesBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Arial", 9.5f);
            _companiesBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _companiesBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _companiesBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _companiesBunifuDataGridView.CurrentTheme.BackColor = Color.White;
            _companiesBunifuDataGridView.CurrentTheme.GridColor = Color.Gainsboro;
            _companiesBunifuDataGridView.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _companiesBunifuDataGridView.CurrentTheme.HeaderStyle.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            _companiesBunifuDataGridView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _companiesBunifuDataGridView.CurrentTheme.Name = null;
            _companiesBunifuDataGridView.CurrentTheme.RowsStyle.BackColor = Color.White;
            _companiesBunifuDataGridView.CurrentTheme.RowsStyle.Font = new Font("Arial", 9.5f);
            _companiesBunifuDataGridView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _companiesBunifuDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _companiesBunifuDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _companiesBunifuDataGridView.DataSource = VWCompanyBindingSource;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.White;
            DataGridViewCellStyle6.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle6.ForeColor = Color.Black;
            DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle6.SelectionForeColor = Color.Black;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            _companiesBunifuDataGridView.DefaultCellStyle = DataGridViewCellStyle6;
            _companiesBunifuDataGridView.Dock = DockStyle.Fill;
            _companiesBunifuDataGridView.EnableHeadersVisualStyles = false;
            _companiesBunifuDataGridView.GridColor = Color.Gainsboro;
            _companiesBunifuDataGridView.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _companiesBunifuDataGridView.HeaderBgColor = Color.Empty;
            _companiesBunifuDataGridView.HeaderForeColor = Color.White;
            _companiesBunifuDataGridView.Location = new Point(0, 0);
            _companiesBunifuDataGridView.Name = "_companiesBunifuDataGridView";
            _companiesBunifuDataGridView.ReadOnly = true;
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle7.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            _companiesBunifuDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle7;
            _companiesBunifuDataGridView.RowHeadersVisible = false;
            _companiesBunifuDataGridView.RowHeadersWidth = 29;
            DataGridViewCellStyle8.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _companiesBunifuDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle8;
            _companiesBunifuDataGridView.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.0f);
            _companiesBunifuDataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            _companiesBunifuDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _companiesBunifuDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            _companiesBunifuDataGridView.RowTemplate.Height = 27;
            _companiesBunifuDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _companiesBunifuDataGridView.Size = new Size(1220, 394);
            _companiesBunifuDataGridView.TabIndex = 141;
            _companiesBunifuDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // CompanyCodeDataGridViewTextBoxColumn
            // 
            CompanyCodeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CompanyCodeDataGridViewTextBoxColumn.DataPropertyName = "CompanyCode";
            CompanyCodeDataGridViewTextBoxColumn.FillWeight = 76.00599f;
            CompanyCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            CompanyCodeDataGridViewTextBoxColumn.Name = "CompanyCodeDataGridViewTextBoxColumn";
            CompanyCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CompanyNameDataGridViewTextBoxColumn
            // 
            CompanyNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CompanyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            CompanyNameDataGridViewTextBoxColumn.FillWeight = 140.9864f;
            CompanyNameDataGridViewTextBoxColumn.HeaderText = "Name";
            CompanyNameDataGridViewTextBoxColumn.Name = "CompanyNameDataGridViewTextBoxColumn";
            CompanyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EmailDataGridViewTextBoxColumn
            // 
            EmailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            EmailDataGridViewTextBoxColumn.FillWeight = 125.292f;
            EmailDataGridViewTextBoxColumn.HeaderText = "Email";
            EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn";
            EmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WebsiteDataGridViewTextBoxColumn
            // 
            WebsiteDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WebsiteDataGridViewTextBoxColumn.DataPropertyName = "Website";
            WebsiteDataGridViewTextBoxColumn.FillWeight = 130.5373f;
            WebsiteDataGridViewTextBoxColumn.HeaderText = "Website";
            WebsiteDataGridViewTextBoxColumn.Name = "WebsiteDataGridViewTextBoxColumn";
            WebsiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NotesDataGridViewTextBoxColumn
            // 
            NotesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            NotesDataGridViewTextBoxColumn.FillWeight = 96.09328f;
            NotesDataGridViewTextBoxColumn.HeaderText = "Notes";
            NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn";
            NotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RatingDataGridViewTextBoxColumn
            // 
            RatingDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RatingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            RatingDataGridViewTextBoxColumn.FillWeight = 53.77348f;
            RatingDataGridViewTextBoxColumn.HeaderText = "Rating";
            RatingDataGridViewTextBoxColumn.Name = "RatingDataGridViewTextBoxColumn";
            RatingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AttentionDataGridViewTextBoxColumn
            // 
            AttentionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AttentionDataGridViewTextBoxColumn.DataPropertyName = "Attention";
            AttentionDataGridViewTextBoxColumn.FillWeight = 96.09328f;
            AttentionDataGridViewTextBoxColumn.HeaderText = "Attention";
            AttentionDataGridViewTextBoxColumn.Name = "AttentionDataGridViewTextBoxColumn";
            AttentionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CategoryNameDataGridViewTextBoxColumn
            // 
            CategoryNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            CategoryNameDataGridViewTextBoxColumn.FillWeight = 81.21828f;
            CategoryNameDataGridViewTextBoxColumn.HeaderText = "Category";
            CategoryNameDataGridViewTextBoxColumn.Name = "CategoryNameDataGridViewTextBoxColumn";
            CategoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VWCompanyBindingSource
            // 
            VWCompanyBindingSource.DataSource = typeof(ModelLayer.CustomModel.VW_Company);
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.ColumnCount = 2;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel3.Controls.Add(_EditButton, 0, 0);
            TableLayoutPanel3.Controls.Add(_DeleteCompanyButton, 1, 0);
            TableLayoutPanel3.Location = new Point(1050, 475);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel3.Size = new Size(257, 41);
            TableLayoutPanel3.TabIndex = 71;
            // 
            // EditButton
            // 
            _EditButton.AllowToggling = false;
            _EditButton.AnimationSpeed = 200;
            _EditButton.AutoGenerateColors = false;
            _EditButton.BackColor = Color.Transparent;
            _EditButton.BackColor1 = Color.Teal;
            _EditButton.BackgroundImage = (Image)resources.GetObject("EditButton.BackgroundImage");
            _EditButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _EditButton.ButtonText = "Edit";
            _EditButton.ButtonTextMarginLeft = 0;
            _EditButton.ColorContrastOnClick = 45;
            _EditButton.ColorContrastOnHover = 45;
            _EditButton.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _EditButton.CustomizableEdges = BorderEdges4;
            _EditButton.DialogResult = DialogResult.None;
            _EditButton.DisabledBorderColor = Color.Empty;
            _EditButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _EditButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _EditButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _EditButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _EditButton.ForeColor = Color.White;
            _EditButton.IconLeftCursor = Cursors.Hand;
            _EditButton.IconMarginLeft = 11;
            _EditButton.IconPadding = 10;
            _EditButton.IconRightCursor = Cursors.Hand;
            _EditButton.IdleBorderColor = Color.Teal;
            _EditButton.IdleBorderRadius = 3;
            _EditButton.IdleBorderThickness = 1;
            _EditButton.IdleFillColor = Color.Teal;
            _EditButton.IdleIconLeftImage = null;
            _EditButton.IdleIconRightImage = null;
            _EditButton.IndicateFocus = true;
            _EditButton.Location = new Point(3, 3);
            _EditButton.Name = "_EditButton";
            StateProperties15.BorderColor = Color.MediumTurquoise;
            StateProperties15.BorderRadius = 3;
            StateProperties15.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties15.BorderThickness = 1;
            StateProperties15.FillColor = Color.MediumTurquoise;
            StateProperties15.ForeColor = Color.White;
            StateProperties15.IconLeftImage = null;
            StateProperties15.IconRightImage = null;
            _EditButton.onHoverState = StateProperties15;
            StateProperties16.BorderColor = Color.Teal;
            StateProperties16.BorderRadius = 3;
            StateProperties16.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties16.BorderThickness = 1;
            StateProperties16.FillColor = Color.Teal;
            StateProperties16.ForeColor = Color.White;
            StateProperties16.IconLeftImage = null;
            StateProperties16.IconRightImage = null;
            _EditButton.OnPressedState = StateProperties16;
            _EditButton.Size = new Size(122, 35);
            _EditButton.TabIndex = 67;
            _EditButton.TextAlign = ContentAlignment.MiddleCenter;
            _EditButton.TextMarginLeft = 0;
            _EditButton.UseDefaultRadiusAndThickness = true;
            // 
            // DeleteCompanyButton
            // 
            _DeleteCompanyButton.AllowToggling = false;
            _DeleteCompanyButton.AnimationSpeed = 200;
            _DeleteCompanyButton.AutoGenerateColors = false;
            _DeleteCompanyButton.BackColor = Color.Transparent;
            _DeleteCompanyButton.BackColor1 = Color.IndianRed;
            _DeleteCompanyButton.BackgroundImage = (Image)resources.GetObject("DeleteCompanyButton.BackgroundImage");
            _DeleteCompanyButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _DeleteCompanyButton.ButtonText = "Delete";
            _DeleteCompanyButton.ButtonTextMarginLeft = 0;
            _DeleteCompanyButton.ColorContrastOnClick = 45;
            _DeleteCompanyButton.ColorContrastOnHover = 45;
            _DeleteCompanyButton.Cursor = Cursors.Hand;
            BorderEdges5.BottomLeft = true;
            BorderEdges5.BottomRight = true;
            BorderEdges5.TopLeft = true;
            BorderEdges5.TopRight = true;
            _DeleteCompanyButton.CustomizableEdges = BorderEdges5;
            _DeleteCompanyButton.DialogResult = DialogResult.None;
            _DeleteCompanyButton.DisabledBorderColor = Color.Empty;
            _DeleteCompanyButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _DeleteCompanyButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _DeleteCompanyButton.Enabled = false;
            _DeleteCompanyButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _DeleteCompanyButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _DeleteCompanyButton.ForeColor = Color.White;
            _DeleteCompanyButton.IconLeftCursor = Cursors.Hand;
            _DeleteCompanyButton.IconMarginLeft = 11;
            _DeleteCompanyButton.IconPadding = 10;
            _DeleteCompanyButton.IconRightCursor = Cursors.Hand;
            _DeleteCompanyButton.IdleBorderColor = Color.IndianRed;
            _DeleteCompanyButton.IdleBorderRadius = 3;
            _DeleteCompanyButton.IdleBorderThickness = 1;
            _DeleteCompanyButton.IdleFillColor = Color.IndianRed;
            _DeleteCompanyButton.IdleIconLeftImage = null;
            _DeleteCompanyButton.IdleIconRightImage = null;
            _DeleteCompanyButton.IndicateFocus = true;
            _DeleteCompanyButton.Location = new Point(131, 3);
            _DeleteCompanyButton.Name = "_DeleteCompanyButton";
            StateProperties17.BorderColor = Color.MediumTurquoise;
            StateProperties17.BorderRadius = 3;
            StateProperties17.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties17.BorderThickness = 1;
            StateProperties17.FillColor = Color.MediumTurquoise;
            StateProperties17.ForeColor = Color.White;
            StateProperties17.IconLeftImage = null;
            StateProperties17.IconRightImage = null;
            _DeleteCompanyButton.onHoverState = StateProperties17;
            StateProperties18.BorderColor = Color.LightCoral;
            StateProperties18.BorderRadius = 3;
            StateProperties18.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties18.BorderThickness = 1;
            StateProperties18.FillColor = Color.LightCoral;
            StateProperties18.ForeColor = Color.White;
            StateProperties18.IconLeftImage = null;
            StateProperties18.IconRightImage = null;
            _DeleteCompanyButton.OnPressedState = StateProperties18;
            _DeleteCompanyButton.Size = new Size(123, 35);
            _DeleteCompanyButton.TabIndex = 61;
            _DeleteCompanyButton.TextAlign = ContentAlignment.MiddleCenter;
            _DeleteCompanyButton.TextMarginLeft = 0;
            _DeleteCompanyButton.UseDefaultRadiusAndThickness = true;
            // 
            // newCompanyButton
            // 
            _newCompanyButton.AllowToggling = false;
            _newCompanyButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _newCompanyButton.AnimationSpeed = 200;
            _newCompanyButton.AutoGenerateColors = false;
            _newCompanyButton.BackColor = Color.Transparent;
            _newCompanyButton.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _newCompanyButton.BackgroundImage = (Image)resources.GetObject("newCompanyButton.BackgroundImage");
            _newCompanyButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _newCompanyButton.ButtonText = "New Company";
            _newCompanyButton.ButtonTextMarginLeft = 0;
            _newCompanyButton.ColorContrastOnClick = 45;
            _newCompanyButton.ColorContrastOnHover = 45;
            _newCompanyButton.Cursor = Cursors.Hand;
            BorderEdges6.BottomLeft = true;
            BorderEdges6.BottomRight = true;
            BorderEdges6.TopLeft = true;
            BorderEdges6.TopRight = true;
            _newCompanyButton.CustomizableEdges = BorderEdges6;
            _newCompanyButton.DialogResult = DialogResult.None;
            _newCompanyButton.DisabledBorderColor = Color.Empty;
            _newCompanyButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _newCompanyButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _newCompanyButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _newCompanyButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _newCompanyButton.ForeColor = Color.White;
            _newCompanyButton.IconLeftCursor = Cursors.Hand;
            _newCompanyButton.IconMarginLeft = 11;
            _newCompanyButton.IconPadding = 10;
            _newCompanyButton.IconRightCursor = Cursors.Hand;
            _newCompanyButton.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _newCompanyButton.IdleBorderRadius = 40;
            _newCompanyButton.IdleBorderThickness = 1;
            _newCompanyButton.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _newCompanyButton.IdleIconLeftImage = null;
            _newCompanyButton.IdleIconRightImage = null;
            _newCompanyButton.IndicateFocus = true;
            _newCompanyButton.Location = new Point(1314, 192);
            _newCompanyButton.Name = "_newCompanyButton";
            StateProperties19.BorderColor = Color.Coral;
            StateProperties19.BorderRadius = 40;
            StateProperties19.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties19.BorderThickness = 1;
            StateProperties19.FillColor = Color.Coral;
            StateProperties19.ForeColor = Color.White;
            StateProperties19.IconLeftImage = null;
            StateProperties19.IconRightImage = null;
            _newCompanyButton.onHoverState = StateProperties19;
            StateProperties20.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties20.BorderRadius = 40;
            StateProperties20.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties20.BorderThickness = 1;
            StateProperties20.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties20.ForeColor = Color.White;
            StateProperties20.IconLeftImage = null;
            StateProperties20.IconRightImage = null;
            _newCompanyButton.OnPressedState = StateProperties20;
            _newCompanyButton.Size = new Size(137, 42);
            _newCompanyButton.TabIndex = 70;
            _newCompanyButton.TextAlign = ContentAlignment.MiddleCenter;
            _newCompanyButton.TextMarginLeft = 0;
            _newCompanyButton.UseDefaultRadiusAndThickness = true;
            // 
            // timeSheetDescriptionLabel
            // 
            timeSheetDescriptionLabel.BackColor = Color.Transparent;
            timeSheetDescriptionLabel.Font = new Font("Segoe UI Semibold", 18.32727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            timeSheetDescriptionLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            timeSheetDescriptionLabel.Location = new Point(31, 20);
            timeSheetDescriptionLabel.Name = "timeSheetDescriptionLabel";
            timeSheetDescriptionLabel.Size = new Size(182, 44);
            timeSheetDescriptionLabel.TabIndex = 48;
            timeSheetDescriptionLabel.Text = "Companies";
            timeSheetDescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmDisplayContacts
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1522, 894);
            ControlBox = false;
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDisplayContacts";
            StartPosition = FormStartPosition.CenterScreen;
            BunifuShadowPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            TableLayoutPanel1.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_contactsBunifuDataGridView).EndInit();
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_companiesBunifuDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWCompanyBindingSource).EndInit();
            TableLayoutPanel3.ResumeLayout(false);
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
        }

        internal ImageList iconsImageList;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel1;
        internal Panel Panel2;
        internal Panel Panel4;
        internal TableLayoutPanel TableLayoutPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _EditButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton EditButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EditButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EditButton != null)
                {
                    _EditButton.Click -= EditButton_Click;
                }

                _EditButton = value;
                if (_EditButton != null)
                {
                    _EditButton.Click += EditButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _DeleteCompanyButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton DeleteCompanyButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DeleteCompanyButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DeleteCompanyButton != null)
                {
                    _DeleteCompanyButton.Click -= DeleteToolStripMenuItem_Click;
                }

                _DeleteCompanyButton = value;
                if (_DeleteCompanyButton != null)
                {
                    _DeleteCompanyButton.Click += DeleteToolStripMenuItem_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _newCompanyButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton newCompanyButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _newCompanyButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_newCompanyButton != null)
                {
                    _newCompanyButton.Click -= CompanyToolStripMenuItem_Click;
                }

                _newCompanyButton = value;
                if (_newCompanyButton != null)
                {
                    _newCompanyButton.Click += CompanyToolStripMenuItem_Click;
                }
            }
        }

        internal Label timeSheetDescriptionLabel;
        internal Panel Panel5;
        private Bunifu.UI.WinForms.BunifuDataGridView _contactsBunifuDataGridView;

        internal Bunifu.UI.WinForms.BunifuDataGridView contactsBunifuDataGridView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _contactsBunifuDataGridView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_contactsBunifuDataGridView != null)
                {
                    _contactsBunifuDataGridView.SelectionChanged -= contactsListView_Click;
                }

                _contactsBunifuDataGridView = value;
                if (_contactsBunifuDataGridView != null)
                {
                    _contactsBunifuDataGridView.SelectionChanged += contactsListView_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column6;
        private BunifuTextBox _tbSearchCompany;

        internal BunifuTextBox tbSearchCompany
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbSearchCompany;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbSearchCompany != null)
                {
                    _tbSearchCompany.TextChanged -= ToolStripTextBox1_TextChanged;
                    _tbSearchCompany.TextChanged -= ToolStripTextBox1_Click_1;
                }

                _tbSearchCompany = value;
                if (_tbSearchCompany != null)
                {
                    _tbSearchCompany.TextChanged += ToolStripTextBox1_TextChanged;
                    _tbSearchCompany.TextChanged += ToolStripTextBox1_Click_1;
                }
            }
        }

        private BunifuTextBox _findContactTextBox;

        internal BunifuTextBox findContactTextBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _findContactTextBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_findContactTextBox != null)
                {
                    _findContactTextBox.TextChanged -= findContactToolStripTextBox_Click;
                    _findContactTextBox.TextChanged -= findContactToolStripTextBox_TextChanged;
                }

                _findContactTextBox = value;
                if (_findContactTextBox != null)
                {
                    _findContactTextBox.TextChanged += findContactToolStripTextBox_Click;
                    _findContactTextBox.TextChanged += findContactToolStripTextBox_TextChanged;
                }
            }
        }

        internal TableLayoutPanel TableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _editContactButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton editContactButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _editContactButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_editContactButton != null)
                {
                    _editContactButton.Click -= ToolStripMenuItem6_Click;
                }

                _editContactButton = value;
                if (_editContactButton != null)
                {
                    _editContactButton.Click += ToolStripMenuItem6_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _deleteContactButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteContactButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _deleteContactButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_deleteContactButton != null)
                {
                    _deleteContactButton.Click -= deleteContactToolStripMenuItem7_Click;
                }

                _deleteContactButton = value;
                if (_deleteContactButton != null)
                {
                    _deleteContactButton.Click += deleteContactToolStripMenuItem7_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _addNewContactButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton addNewContactButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _addNewContactButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_addNewContactButton != null)
                {
                    _addNewContactButton.Click -= adNewContactToolStripMenuItem_Click;
                }

                _addNewContactButton = value;
                if (_addNewContactButton != null)
                {
                    _addNewContactButton.Click += adNewContactToolStripMenuItem_Click;
                }
            }
        }

        internal Label Label1;
        internal BindingSource VWCompanyBindingSource;
        private Bunifu.UI.WinForms.BunifuDataGridView _companiesBunifuDataGridView;

        public Bunifu.UI.WinForms.BunifuDataGridView companiesBunifuDataGridView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _companiesBunifuDataGridView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_companiesBunifuDataGridView != null)
                {
                    _companiesBunifuDataGridView.SelectionChanged -= companiesBunifuDataGridView_1;
                }

                _companiesBunifuDataGridView = value;
                if (_companiesBunifuDataGridView != null)
                {
                    _companiesBunifuDataGridView.SelectionChanged += companiesBunifuDataGridView_1;
                }
            }
        }

        internal DataGridViewTextBoxColumn CompanyCodeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CompanyNameDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn EmailDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn WebsiteDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn NotesDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn RatingDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn AttentionDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CategoryNameDataGridViewTextBoxColumn;
    }
}