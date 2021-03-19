using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmServices : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServices));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Panel4 = new Panel();
            _servicesDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            _servicesDataGridView.RowPostPaint += new DataGridViewRowPostPaintEventHandler(BunifuDataGridView1_RowPostPaint);
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            titleLabel = new Label();
            _servTypeDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            _servTypeDropdown.SelectedIndexChanged += new EventHandler(servTypeDropdown_SelectedIndexChanged);
            Label2 = new Label();
            Label12 = new Label();
            _editButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _editButton.Click += new EventHandler(BunifuButton1_Click);
            _deleteButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _deleteButton.Click += new EventHandler(deleteButton_Click);
            _truckNameDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            _truckNameDropdown.SelectedIndexChanged += new EventHandler(compNameDropdown6_SelectedIndexChanged);
            Label10 = new Label();
            _addButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _addButton.Click += new EventHandler(addButton_Click);
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            _fromDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            _fromDropdown.SelectedIndexChanged += new EventHandler(fromDropdown_SelectedIndexChanged);
            Label1 = new Label();
            _toDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            _toDropdown.SelectedIndexChanged += new EventHandler(toDropdown_SelectedIndexChanged);
            Label3 = new Label();
            _BunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _BunifuButton1.Click += new EventHandler(BunifuButton1_Click_1);
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_servicesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // Panel4
            // 
            Panel4.Anchor = AnchorStyles.None;
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(_servicesDataGridView);
            Panel4.Location = new Point(53, 204);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(1153, 477);
            Panel4.TabIndex = 113;
            // 
            // servicesDataGridView
            // 
            _servicesDataGridView.AllowCustomTheming = true;
            _servicesDataGridView.AllowUserToAddRows = false;
            _servicesDataGridView.AllowUserToDeleteRows = false;
            _servicesDataGridView.AllowUserToOrderColumns = true;
            _servicesDataGridView.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _servicesDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _servicesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _servicesDataGridView.BackgroundColor = Color.White;
            _servicesDataGridView.BorderStyle = BorderStyle.None;
            _servicesDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _servicesDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _servicesDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _servicesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _servicesDataGridView.ColumnHeadersHeight = 50;
            _servicesDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column6, Column2, Column4 });
            _servicesDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _servicesDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _servicesDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _servicesDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _servicesDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _servicesDataGridView.CurrentTheme.BackColor = Color.Snow;
            _servicesDataGridView.CurrentTheme.GridColor = Color.Gray;
            _servicesDataGridView.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _servicesDataGridView.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _servicesDataGridView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _servicesDataGridView.CurrentTheme.Name = null;
            _servicesDataGridView.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _servicesDataGridView.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _servicesDataGridView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _servicesDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _servicesDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _servicesDataGridView.DefaultCellStyle = DataGridViewCellStyle3;
            _servicesDataGridView.Dock = DockStyle.Fill;
            _servicesDataGridView.EnableHeadersVisualStyles = false;
            _servicesDataGridView.GridColor = Color.Gray;
            _servicesDataGridView.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _servicesDataGridView.HeaderBgColor = Color.Empty;
            _servicesDataGridView.HeaderForeColor = Color.White;
            _servicesDataGridView.Location = new Point(0, 0);
            _servicesDataGridView.MultiSelect = false;
            _servicesDataGridView.Name = "_servicesDataGridView";
            _servicesDataGridView.ReadOnly = true;
            _servicesDataGridView.RowHeadersVisible = false;
            _servicesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _servicesDataGridView.RowTemplate.Height = 30;
            _servicesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _servicesDataGridView.Size = new Size(1151, 475);
            _servicesDataGridView.TabIndex = 57;
            _servicesDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column3
            // 
            Column3.FillWeight = 153.9028f;
            Column3.HeaderText = "Service Name";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.FillWeight = 92.59637f;
            Column6.HeaderText = "Service Type";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 132.9588f;
            Column2.HeaderText = "Company Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 57.0902f;
            Column4.HeaderText = "Rate";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.None;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            titleLabel.Location = new Point(49, 63);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(326, 36);
            titleLabel.TabIndex = 114;
            titleLabel.Text = "Container Services";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // servTypeDropdown
            // 
            _servTypeDropdown.Anchor = AnchorStyles.None;
            _servTypeDropdown.BackColor = Color.White;
            _servTypeDropdown.BorderRadius = 3;
            _servTypeDropdown.Color = Color.Teal;
            _servTypeDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _servTypeDropdown.DisabledColor = Color.Gray;
            _servTypeDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            _servTypeDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            _servTypeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            _servTypeDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _servTypeDropdown.FillDropDown = false;
            _servTypeDropdown.FillIndicator = true;
            _servTypeDropdown.FlatStyle = FlatStyle.Flat;
            _servTypeDropdown.Font = new Font("Arial", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _servTypeDropdown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _servTypeDropdown.FormattingEnabled = true;
            _servTypeDropdown.Icon = null;
            _servTypeDropdown.IndicatorColor = Color.Teal;
            _servTypeDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _servTypeDropdown.ItemBackColor = Color.White;
            _servTypeDropdown.ItemBorderColor = Color.White;
            _servTypeDropdown.ItemForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _servTypeDropdown.ItemHeight = 25;
            _servTypeDropdown.ItemHighLightColor = Color.Gray;
            _servTypeDropdown.Items.AddRange(new object[] { "Drayage", "FSC", "TEF" });
            _servTypeDropdown.Location = new Point(227, 161);
            _servTypeDropdown.MaxDropDownItems = 50;
            _servTypeDropdown.Name = "_servTypeDropdown";
            _servTypeDropdown.Size = new Size(182, 31);
            _servTypeDropdown.TabIndex = 127;
            _servTypeDropdown.Text = null;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.None;
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(106, 166);
            Label2.Margin = new Padding(0);
            Label2.Name = "Label2";
            Label2.Size = new Size(120, 25);
            Label2.TabIndex = 126;
            Label2.Text = "Service Type:";
            Label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            Label12.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Dock = DockStyle.Top;
            Label12.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Location = new Point(0, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(1248, 46);
            Label12.TabIndex = 134;
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editButton
            // 
            _editButton.AllowToggling = false;
            _editButton.AnimationSpeed = 200;
            _editButton.AutoGenerateColors = false;
            _editButton.BackColor = Color.Transparent;
            _editButton.BackColor1 = Color.Teal;
            _editButton.BackgroundImage = (Image)resources.GetObject("editButton.BackgroundImage");
            _editButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _editButton.ButtonText = "Edit";
            _editButton.ButtonTextMarginLeft = 0;
            _editButton.ColorContrastOnClick = 45;
            _editButton.ColorContrastOnHover = 45;
            _editButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _editButton.CustomizableEdges = BorderEdges1;
            _editButton.DialogResult = DialogResult.None;
            _editButton.DisabledBorderColor = Color.Empty;
            _editButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _editButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _editButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _editButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _editButton.ForeColor = Color.White;
            _editButton.IconLeftCursor = Cursors.Hand;
            _editButton.IconMarginLeft = 11;
            _editButton.IconPadding = 10;
            _editButton.IconRightCursor = Cursors.Hand;
            _editButton.IdleBorderColor = Color.Teal;
            _editButton.IdleBorderRadius = 3;
            _editButton.IdleBorderThickness = 1;
            _editButton.IdleFillColor = Color.Teal;
            _editButton.IdleIconLeftImage = null;
            _editButton.IdleIconRightImage = null;
            _editButton.IndicateFocus = true;
            _editButton.Location = new Point(985, 687);
            _editButton.Name = "_editButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _editButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _editButton.OnPressedState = StateProperties2;
            _editButton.Size = new Size(105, 41);
            _editButton.TabIndex = 139;
            _editButton.TextAlign = ContentAlignment.MiddleCenter;
            _editButton.TextMarginLeft = 0;
            _editButton.UseDefaultRadiusAndThickness = true;
            // 
            // deleteButton
            // 
            _deleteButton.AllowToggling = false;
            _deleteButton.AnimationSpeed = 200;
            _deleteButton.AutoGenerateColors = false;
            _deleteButton.BackColor = Color.Transparent;
            _deleteButton.BackColor1 = Color.IndianRed;
            _deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            _deleteButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _deleteButton.ButtonText = "Delete";
            _deleteButton.ButtonTextMarginLeft = 0;
            _deleteButton.ColorContrastOnClick = 45;
            _deleteButton.ColorContrastOnHover = 45;
            _deleteButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _deleteButton.CustomizableEdges = BorderEdges2;
            _deleteButton.DialogResult = DialogResult.None;
            _deleteButton.DisabledBorderColor = Color.Empty;
            _deleteButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _deleteButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _deleteButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _deleteButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _deleteButton.ForeColor = Color.White;
            _deleteButton.IconLeftCursor = Cursors.Hand;
            _deleteButton.IconMarginLeft = 11;
            _deleteButton.IconPadding = 10;
            _deleteButton.IconRightCursor = Cursors.Hand;
            _deleteButton.IdleBorderColor = Color.IndianRed;
            _deleteButton.IdleBorderRadius = 3;
            _deleteButton.IdleBorderThickness = 1;
            _deleteButton.IdleFillColor = Color.IndianRed;
            _deleteButton.IdleIconLeftImage = null;
            _deleteButton.IdleIconRightImage = null;
            _deleteButton.IndicateFocus = true;
            _deleteButton.Location = new Point(1110, 687);
            _deleteButton.Name = "_deleteButton";
            StateProperties3.BorderColor = Color.LightCoral;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.LightCoral;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _deleteButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.IndianRed;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.IndianRed;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _deleteButton.OnPressedState = StateProperties4;
            _deleteButton.Size = new Size(100, 41);
            _deleteButton.TabIndex = 141;
            _deleteButton.TextAlign = ContentAlignment.MiddleCenter;
            _deleteButton.TextMarginLeft = 0;
            _deleteButton.UseDefaultRadiusAndThickness = true;
            // 
            // truckNameDropdown
            // 
            _truckNameDropdown.Anchor = AnchorStyles.None;
            _truckNameDropdown.BackColor = Color.White;
            _truckNameDropdown.BorderRadius = 3;
            _truckNameDropdown.Color = Color.Teal;
            _truckNameDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _truckNameDropdown.DisabledColor = Color.Gray;
            _truckNameDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            _truckNameDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            _truckNameDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            _truckNameDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _truckNameDropdown.FillDropDown = false;
            _truckNameDropdown.FillIndicator = true;
            _truckNameDropdown.FlatStyle = FlatStyle.Flat;
            _truckNameDropdown.Font = new Font("Arial", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _truckNameDropdown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _truckNameDropdown.FormattingEnabled = true;
            _truckNameDropdown.Icon = null;
            _truckNameDropdown.IndicatorColor = Color.Teal;
            _truckNameDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _truckNameDropdown.ItemBackColor = Color.White;
            _truckNameDropdown.ItemBorderColor = Color.White;
            _truckNameDropdown.ItemForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _truckNameDropdown.ItemHeight = 25;
            _truckNameDropdown.ItemHighLightColor = Color.Gray;
            _truckNameDropdown.Items.AddRange(new object[] { "All" });
            _truckNameDropdown.Location = new Point(227, 124);
            _truckNameDropdown.MaxDropDownItems = 50;
            _truckNameDropdown.Name = "_truckNameDropdown";
            _truckNameDropdown.Size = new Size(477, 31);
            _truckNameDropdown.TabIndex = 143;
            _truckNameDropdown.Text = null;
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.None;
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label10.Location = new Point(54, 128);
            Label10.Margin = new Padding(0);
            Label10.Name = "Label10";
            Label10.Size = new Size(172, 25);
            Label10.TabIndex = 142;
            Label10.Text = "Trucking Company:";
            Label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addButton
            // 
            _addButton.AllowToggling = false;
            _addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _addButton.AnimationSpeed = 200;
            _addButton.AutoGenerateColors = false;
            _addButton.BackColor = Color.Transparent;
            _addButton.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _addButton.BackgroundImage = (Image)resources.GetObject("addButton.BackgroundImage");
            _addButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _addButton.ButtonText = "Add Service";
            _addButton.ButtonTextMarginLeft = 0;
            _addButton.ColorContrastOnClick = 45;
            _addButton.ColorContrastOnHover = 45;
            _addButton.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _addButton.CustomizableEdges = BorderEdges3;
            _addButton.DialogResult = DialogResult.None;
            _addButton.DisabledBorderColor = Color.Empty;
            _addButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _addButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _addButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _addButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _addButton.ForeColor = Color.White;
            _addButton.IconLeftCursor = Cursors.Hand;
            _addButton.IconMarginLeft = 11;
            _addButton.IconPadding = 10;
            _addButton.IconRightCursor = Cursors.Hand;
            _addButton.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _addButton.IdleBorderRadius = 35;
            _addButton.IdleBorderThickness = 1;
            _addButton.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _addButton.IdleIconLeftImage = null;
            _addButton.IdleIconRightImage = null;
            _addButton.IndicateFocus = true;
            _addButton.Location = new Point(920, 60);
            _addButton.Name = "_addButton";
            StateProperties5.BorderColor = Color.Coral;
            StateProperties5.BorderRadius = 35;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.Coral;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _addButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties6.BorderRadius = 35;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _addButton.OnPressedState = StateProperties6;
            _addButton.Size = new Size(113, 39);
            _addButton.TabIndex = 146;
            _addButton.TextAlign = ContentAlignment.MiddleCenter;
            _addButton.TextMarginLeft = 0;
            _addButton.UseDefaultRadiusAndThickness = true;
            // 
            // closeFlatButton
            // 
            _closeFlatButton.Active = false;
            _closeFlatButton.Activecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.BackgroundImageLayout = ImageLayout.Stretch;
            _closeFlatButton.BorderRadius = 0;
            _closeFlatButton.ButtonText = "🗙";
            _closeFlatButton.Cursor = Cursors.Hand;
            _closeFlatButton.DisabledColor = Color.Gray;
            _closeFlatButton.Font = new Font("Microsoft Sans Serif", 7.854546f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeFlatButton.Iconcolor = Color.Transparent;
            _closeFlatButton.Iconimage = null;
            _closeFlatButton.Iconimage_right = null;
            _closeFlatButton.Iconimage_right_Selected = null;
            _closeFlatButton.Iconimage_Selected = null;
            _closeFlatButton.IconMarginLeft = 0;
            _closeFlatButton.IconMarginRight = 0;
            _closeFlatButton.IconRightVisible = true;
            _closeFlatButton.IconRightZoom = 0d;
            _closeFlatButton.IconVisible = true;
            _closeFlatButton.IconZoom = 90.0d;
            _closeFlatButton.IsTab = false;
            _closeFlatButton.Location = new Point(1204, 0);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(44, 46);
            _closeFlatButton.TabIndex = 167;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 20.29091f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // fromDropdown
            // 
            _fromDropdown.Anchor = AnchorStyles.None;
            _fromDropdown.BackColor = Color.White;
            _fromDropdown.BorderRadius = 3;
            _fromDropdown.Color = Color.Teal;
            _fromDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _fromDropdown.DisabledColor = Color.Gray;
            _fromDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            _fromDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            _fromDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            _fromDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _fromDropdown.FillDropDown = false;
            _fromDropdown.FillIndicator = true;
            _fromDropdown.FlatStyle = FlatStyle.Flat;
            _fromDropdown.Font = new Font("Arial", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _fromDropdown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _fromDropdown.FormattingEnabled = true;
            _fromDropdown.Icon = null;
            _fromDropdown.IndicatorColor = Color.Teal;
            _fromDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _fromDropdown.ItemBackColor = Color.White;
            _fromDropdown.ItemBorderColor = Color.White;
            _fromDropdown.ItemForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _fromDropdown.ItemHeight = 25;
            _fromDropdown.ItemHighLightColor = Color.Gray;
            _fromDropdown.Items.AddRange(new object[] { "Drayage", "FSC TEF" });
            _fromDropdown.Location = new Point(866, 122);
            _fromDropdown.MaxDropDownItems = 50;
            _fromDropdown.Name = "_fromDropdown";
            _fromDropdown.Size = new Size(333, 31);
            _fromDropdown.TabIndex = 169;
            _fromDropdown.Text = null;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.None;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(809, 124);
            Label1.Margin = new Padding(0);
            Label1.Name = "Label1";
            Label1.Size = new Size(59, 25);
            Label1.TabIndex = 168;
            Label1.Text = "From:";
            Label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toDropdown
            // 
            _toDropdown.Anchor = AnchorStyles.None;
            _toDropdown.BackColor = Color.White;
            _toDropdown.BorderRadius = 3;
            _toDropdown.Color = Color.Teal;
            _toDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            _toDropdown.DisabledColor = Color.Gray;
            _toDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            _toDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            _toDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            _toDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            _toDropdown.FillDropDown = false;
            _toDropdown.FillIndicator = true;
            _toDropdown.FlatStyle = FlatStyle.Flat;
            _toDropdown.Font = new Font("Arial", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _toDropdown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _toDropdown.FormattingEnabled = true;
            _toDropdown.Icon = null;
            _toDropdown.IndicatorColor = Color.Teal;
            _toDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            _toDropdown.ItemBackColor = Color.White;
            _toDropdown.ItemBorderColor = Color.White;
            _toDropdown.ItemForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _toDropdown.ItemHeight = 25;
            _toDropdown.ItemHighLightColor = Color.Gray;
            _toDropdown.Items.AddRange(new object[] { "Drayage", "FSC TEF" });
            _toDropdown.Location = new Point(866, 161);
            _toDropdown.MaxDropDownItems = 50;
            _toDropdown.Name = "_toDropdown";
            _toDropdown.Size = new Size(333, 31);
            _toDropdown.TabIndex = 171;
            _toDropdown.Text = null;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.None;
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(828, 162);
            Label3.Margin = new Padding(0);
            Label3.Name = "Label3";
            Label3.Size = new Size(35, 25);
            Label3.TabIndex = 170;
            Label3.Text = "To:";
            Label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BunifuButton1
            // 
            _BunifuButton1.AllowToggling = false;
            _BunifuButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _BunifuButton1.AnimationSpeed = 200;
            _BunifuButton1.AutoGenerateColors = false;
            _BunifuButton1.BackColor = Color.Transparent;
            _BunifuButton1.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _BunifuButton1.BackgroundImage = (Image)resources.GetObject("BunifuButton1.BackgroundImage");
            _BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _BunifuButton1.ButtonText = "Manage Drayages";
            _BunifuButton1.ButtonTextMarginLeft = 0;
            _BunifuButton1.ColorContrastOnClick = 45;
            _BunifuButton1.ColorContrastOnHover = 45;
            _BunifuButton1.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _BunifuButton1.CustomizableEdges = BorderEdges4;
            _BunifuButton1.DialogResult = DialogResult.None;
            _BunifuButton1.DisabledBorderColor = Color.Empty;
            _BunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _BunifuButton1.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _BunifuButton1.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _BunifuButton1.ForeColor = Color.White;
            _BunifuButton1.IconLeftCursor = Cursors.Hand;
            _BunifuButton1.IconMarginLeft = 11;
            _BunifuButton1.IconPadding = 10;
            _BunifuButton1.IconRightCursor = Cursors.Hand;
            _BunifuButton1.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _BunifuButton1.IdleBorderRadius = 35;
            _BunifuButton1.IdleBorderThickness = 1;
            _BunifuButton1.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _BunifuButton1.IdleIconLeftImage = null;
            _BunifuButton1.IdleIconRightImage = null;
            _BunifuButton1.IndicateFocus = true;
            _BunifuButton1.Location = new Point(1039, 60);
            _BunifuButton1.Name = "_BunifuButton1";
            StateProperties7.BorderColor = Color.Coral;
            StateProperties7.BorderRadius = 35;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.Coral;
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _BunifuButton1.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties8.BorderRadius = 35;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _BunifuButton1.OnPressedState = StateProperties8;
            _BunifuButton1.Size = new Size(160, 39);
            _BunifuButton1.TabIndex = 172;
            _BunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            _BunifuButton1.TextMarginLeft = 0;
            _BunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // FrmServices
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1248, 754);
            Controls.Add(_BunifuButton1);
            Controls.Add(_toDropdown);
            Controls.Add(Label3);
            Controls.Add(_fromDropdown);
            Controls.Add(Label1);
            Controls.Add(_closeFlatButton);
            Controls.Add(_addButton);
            Controls.Add(Label10);
            Controls.Add(_deleteButton);
            Controls.Add(_editButton);
            Controls.Add(Label12);
            Controls.Add(_servTypeDropdown);
            Controls.Add(Label2);
            Controls.Add(titleLabel);
            Controls.Add(Panel4);
            Controls.Add(_truckNameDropdown);
            ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmServices";
            Text = "FrmEditServices";
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_servicesDataGridView).EndInit();
            Load += new EventHandler(FrmServices_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Panel Panel4;
        private Bunifu.UI.WinForms.BunifuDataGridView _servicesDataGridView;

        public Bunifu.UI.WinForms.BunifuDataGridView servicesDataGridView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _servicesDataGridView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_servicesDataGridView != null)
                {
                    _servicesDataGridView.RowPostPaint -= BunifuDataGridView1_RowPostPaint;
                }

                _servicesDataGridView = value;
                if (_servicesDataGridView != null)
                {
                    _servicesDataGridView.RowPostPaint += BunifuDataGridView1_RowPostPaint;
                }
            }
        }

        internal Label titleLabel;
        private Bunifu.UI.WinForms.BunifuDropdown _servTypeDropdown;

        internal Bunifu.UI.WinForms.BunifuDropdown servTypeDropdown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _servTypeDropdown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_servTypeDropdown != null)
                {
                    _servTypeDropdown.SelectedIndexChanged -= servTypeDropdown_SelectedIndexChanged;
                }

                _servTypeDropdown = value;
                if (_servTypeDropdown != null)
                {
                    _servTypeDropdown.SelectedIndexChanged += servTypeDropdown_SelectedIndexChanged;
                }
            }
        }

        internal Label Label2;
        internal Label Label12;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _editButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton editButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _editButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_editButton != null)
                {
                    _editButton.Click -= BunifuButton1_Click;
                }

                _editButton = value;
                if (_editButton != null)
                {
                    _editButton.Click += BunifuButton1_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _deleteButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _deleteButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_deleteButton != null)
                {
                    _deleteButton.Click -= deleteButton_Click;
                }

                _deleteButton = value;
                if (_deleteButton != null)
                {
                    _deleteButton.Click += deleteButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDropdown _truckNameDropdown;

        internal Bunifu.UI.WinForms.BunifuDropdown truckNameDropdown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _truckNameDropdown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_truckNameDropdown != null)
                {
                    _truckNameDropdown.SelectedIndexChanged -= compNameDropdown6_SelectedIndexChanged;
                }

                _truckNameDropdown = value;
                if (_truckNameDropdown != null)
                {
                    _truckNameDropdown.SelectedIndexChanged += compNameDropdown6_SelectedIndexChanged;
                }
            }
        }

        internal Label Label10;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _addButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton addButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _addButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_addButton != null)
                {
                    _addButton.Click -= addButton_Click;
                }

                _addButton = value;
                if (_addButton != null)
                {
                    _addButton.Click += addButton_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column6;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column4;
        private Bunifu.Framework.UI.BunifuFlatButton _closeFlatButton;

        internal Bunifu.Framework.UI.BunifuFlatButton closeFlatButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _closeFlatButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_closeFlatButton != null)
                {
                    _closeFlatButton.Click -= closeFlatButton_Click;
                }

                _closeFlatButton = value;
                if (_closeFlatButton != null)
                {
                    _closeFlatButton.Click += closeFlatButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuDropdown _fromDropdown;

        internal Bunifu.UI.WinForms.BunifuDropdown fromDropdown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _fromDropdown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_fromDropdown != null)
                {
                    _fromDropdown.SelectedIndexChanged -= fromDropdown_SelectedIndexChanged;
                }

                _fromDropdown = value;
                if (_fromDropdown != null)
                {
                    _fromDropdown.SelectedIndexChanged += fromDropdown_SelectedIndexChanged;
                }
            }
        }

        internal Label Label1;
        private Bunifu.UI.WinForms.BunifuDropdown _toDropdown;

        internal Bunifu.UI.WinForms.BunifuDropdown toDropdown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _toDropdown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_toDropdown != null)
                {
                    _toDropdown.SelectedIndexChanged -= toDropdown_SelectedIndexChanged;
                }

                _toDropdown = value;
                if (_toDropdown != null)
                {
                    _toDropdown.SelectedIndexChanged += toDropdown_SelectedIndexChanged;
                }
            }
        }

        internal Label Label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _BunifuButton1;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuButton1 != null)
                {
                    _BunifuButton1.Click -= BunifuButton1_Click_1;
                }

                _BunifuButton1 = value;
                if (_BunifuButton1 != null)
                {
                    _BunifuButton1.Click += BunifuButton1_Click_1;
                }
            }
        }
    }
}