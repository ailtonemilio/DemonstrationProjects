using System;
using System.Diagnostics;
using System.Drawing;
using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Runtime.CompilerServices; using Bunifu.UI.WinForms.BunifuTextbox; using static Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox; 
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmManageServices : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageServices));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            var StateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(Label6_Click);
            _closeLabel.MouseHover += new EventHandler(closeLabel_MouseHover);
            _closeLabel.MouseLeave += new EventHandler(closeLabel_Click);
            _closeLabel.Click += new EventHandler(closeLabel_MouseLeave);
            Label7 = new Label();
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(Label6_Click);
            saveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            Panel4 = new Panel();
            blockContBunifuDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            MenuStrip1 = new MenuStrip();
            CompanyToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            ruleActionLabel = new Label();
            Label1 = new Label();
            subTitleLabel = new Label();
            searchBunifuTextBox1 = new BunifuTextBox();
            BunifuTextBox1 = new BunifuTextBox();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blockContBunifuDataGridView).BeginInit();
            MenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(918, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 46);
            _closeLabel.TabIndex = 81;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            Label7.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Dock = DockStyle.Top;
            Label7.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Location = new Point(0, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(966, 46);
            Label7.TabIndex = 80;
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            _cancelButton.AllowToggling = false;
            _cancelButton.Anchor = AnchorStyles.None;
            _cancelButton.AnimationSpeed = 200;
            _cancelButton.AutoGenerateColors = false;
            _cancelButton.BackColor = Color.Transparent;
            _cancelButton.BackColor1 = Color.White;
            _cancelButton.BackgroundImage = (Image)resources.GetObject("cancelButton.BackgroundImage");
            _cancelButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _cancelButton.ButtonText = "Cancel";
            _cancelButton.ButtonTextMarginLeft = 0;
            _cancelButton.ColorContrastOnClick = 45;
            _cancelButton.ColorContrastOnHover = 45;
            _cancelButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _cancelButton.CustomizableEdges = BorderEdges1;
            _cancelButton.DialogResult = DialogResult.None;
            _cancelButton.DisabledBorderColor = Color.Empty;
            _cancelButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _cancelButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _cancelButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _cancelButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _cancelButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _cancelButton.IconLeftCursor = Cursors.Hand;
            _cancelButton.IconMarginLeft = 11;
            _cancelButton.IconPadding = 10;
            _cancelButton.IconRightCursor = Cursors.Hand;
            _cancelButton.IdleBorderColor = Color.Gray;
            _cancelButton.IdleBorderRadius = 3;
            _cancelButton.IdleBorderThickness = 1;
            _cancelButton.IdleFillColor = Color.White;
            _cancelButton.IdleIconLeftImage = null;
            _cancelButton.IdleIconRightImage = null;
            _cancelButton.IndicateFocus = true;
            _cancelButton.Location = new Point(847, 491);
            _cancelButton.Name = "_cancelButton";
            StateProperties1.BorderColor = Color.DarkGray;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.DarkGray;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.IndianRed;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.IndianRed;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties2;
            _cancelButton.Size = new Size(97, 45);
            _cancelButton.TabIndex = 79;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // saveButton
            // 
            saveButton.AllowToggling = false;
            saveButton.Anchor = AnchorStyles.None;
            saveButton.AnimationSpeed = 200;
            saveButton.AutoGenerateColors = false;
            saveButton.BackColor = Color.Transparent;
            saveButton.BackColor1 = Color.Teal;
            saveButton.BackgroundImage = (Image)resources.GetObject("saveButton.BackgroundImage");
            saveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            saveButton.ButtonText = "Save";
            saveButton.ButtonTextMarginLeft = 0;
            saveButton.ColorContrastOnClick = 45;
            saveButton.ColorContrastOnHover = 45;
            saveButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            saveButton.CustomizableEdges = BorderEdges2;
            saveButton.DialogResult = DialogResult.None;
            saveButton.DisabledBorderColor = Color.Empty;
            saveButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            saveButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            saveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            saveButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            saveButton.ForeColor = Color.White;
            saveButton.IconLeftCursor = Cursors.Hand;
            saveButton.IconMarginLeft = 11;
            saveButton.IconPadding = 10;
            saveButton.IconRightCursor = Cursors.Hand;
            saveButton.IdleBorderColor = Color.Teal;
            saveButton.IdleBorderRadius = 3;
            saveButton.IdleBorderThickness = 1;
            saveButton.IdleFillColor = Color.Teal;
            saveButton.IdleIconLeftImage = null;
            saveButton.IdleIconRightImage = null;
            saveButton.IndicateFocus = true;
            saveButton.Location = new Point(725, 491);
            saveButton.Name = "saveButton";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            saveButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            saveButton.OnPressedState = StateProperties4;
            saveButton.Size = new Size(100, 45);
            saveButton.TabIndex = 78;
            saveButton.TextAlign = ContentAlignment.MiddleCenter;
            saveButton.TextMarginLeft = 0;
            saveButton.UseDefaultRadiusAndThickness = true;
            // 
            // Panel4
            // 
            Panel4.Anchor = AnchorStyles.None;
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(blockContBunifuDataGridView);
            Panel4.Location = new Point(31, 148);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(403, 364);
            Panel4.TabIndex = 113;
            // 
            // blockContBunifuDataGridView
            // 
            blockContBunifuDataGridView.AllowCustomTheming = true;
            blockContBunifuDataGridView.AllowUserToAddRows = false;
            blockContBunifuDataGridView.AllowUserToDeleteRows = false;
            blockContBunifuDataGridView.AllowUserToOrderColumns = true;
            blockContBunifuDataGridView.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            blockContBunifuDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            blockContBunifuDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            blockContBunifuDataGridView.BackgroundColor = Color.White;
            blockContBunifuDataGridView.BorderStyle = BorderStyle.None;
            blockContBunifuDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            blockContBunifuDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            blockContBunifuDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            blockContBunifuDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            blockContBunifuDataGridView.ColumnHeadersHeight = 40;
            blockContBunifuDataGridView.ColumnHeadersVisible = false;
            blockContBunifuDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column5 });
            blockContBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            blockContBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            blockContBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            blockContBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            blockContBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            blockContBunifuDataGridView.CurrentTheme.BackColor = Color.Snow;
            blockContBunifuDataGridView.CurrentTheme.GridColor = Color.Gray;
            blockContBunifuDataGridView.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            blockContBunifuDataGridView.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            blockContBunifuDataGridView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            blockContBunifuDataGridView.CurrentTheme.Name = null;
            blockContBunifuDataGridView.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            blockContBunifuDataGridView.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            blockContBunifuDataGridView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            blockContBunifuDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            blockContBunifuDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            blockContBunifuDataGridView.DefaultCellStyle = DataGridViewCellStyle3;
            blockContBunifuDataGridView.Dock = DockStyle.Fill;
            blockContBunifuDataGridView.EnableHeadersVisualStyles = false;
            blockContBunifuDataGridView.GridColor = Color.Gray;
            blockContBunifuDataGridView.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            blockContBunifuDataGridView.HeaderBgColor = Color.Empty;
            blockContBunifuDataGridView.HeaderForeColor = Color.White;
            blockContBunifuDataGridView.Location = new Point(0, 0);
            blockContBunifuDataGridView.Name = "blockContBunifuDataGridView";
            blockContBunifuDataGridView.ReadOnly = true;
            blockContBunifuDataGridView.RowHeadersVisible = false;
            blockContBunifuDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            blockContBunifuDataGridView.RowTemplate.Height = 30;
            blockContBunifuDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            blockContBunifuDataGridView.Size = new Size(401, 362);
            blockContBunifuDataGridView.TabIndex = 57;
            blockContBunifuDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column4
            // 
            Column4.FillWeight = 93.73149f;
            Column4.HeaderText = "Service Name";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 10.59113f;
            Column5.HeaderText = "Rate";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // MenuStrip1
            // 
            MenuStrip1.Anchor = AnchorStyles.None;
            MenuStrip1.BackColor = Color.Transparent;
            MenuStrip1.Dock = DockStyle.None;
            MenuStrip1.GripMargin = new Padding(2);
            MenuStrip1.GripStyle = ToolStripGripStyle.Visible;
            MenuStrip1.ImageScalingSize = new Size(18, 18);
            MenuStrip1.Items.AddRange(new ToolStripItem[] { CompanyToolStripMenuItem, EditToolStripMenuItem, DeleteToolStripMenuItem });
            MenuStrip1.Location = new Point(31, 108);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Padding = new Padding(2);
            MenuStrip1.Size = new Size(422, 37);
            MenuStrip1.TabIndex = 114;
            MenuStrip1.Text = "MenuStrip1";
            // 
            // CompanyToolStripMenuItem
            // 
            CompanyToolStripMenuItem.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            CompanyToolStripMenuItem.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            CompanyToolStripMenuItem.Image = (Image)resources.GetObject("CompanyToolStripMenuItem.Image");
            CompanyToolStripMenuItem.Name = "CompanyToolStripMenuItem";
            CompanyToolStripMenuItem.Padding = new Padding(2, 2, 35, 2);
            CompanyToolStripMenuItem.Size = new Size(109, 33);
            CompanyToolStripMenuItem.Text = "New";
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Enabled = false;
            EditToolStripMenuItem.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            EditToolStripMenuItem.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            EditToolStripMenuItem.Image = (Image)resources.GetObject("EditToolStripMenuItem.Image");
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Padding = new Padding(2, 2, 70, 2);
            EditToolStripMenuItem.Size = new Size(138, 33);
            EditToolStripMenuItem.Text = "Edit";
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Enabled = false;
            DeleteToolStripMenuItem.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DeleteToolStripMenuItem.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DeleteToolStripMenuItem.Image = (Image)resources.GetObject("DeleteToolStripMenuItem.Image");
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Padding = new Padding(2, 2, 70, 2);
            DeleteToolStripMenuItem.Size = new Size(160, 33);
            DeleteToolStripMenuItem.Text = "Delete";
            // 
            // ruleActionLabel
            // 
            ruleActionLabel.Anchor = AnchorStyles.None;
            ruleActionLabel.AutoSize = true;
            ruleActionLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ruleActionLabel.Location = new Point(467, 197);
            ruleActionLabel.Name = "ruleActionLabel";
            ruleActionLabel.Size = new Size(131, 25);
            ruleActionLabel.TabIndex = 116;
            ruleActionLabel.Text = "Service Name:";
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.None;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(480, 244);
            Label1.Name = "Label1";
            Label1.Size = new Size(118, 25);
            Label1.TabIndex = 118;
            Label1.Text = "Service Rate:";
            // 
            // subTitleLabel
            // 
            subTitleLabel.AutoSize = true;
            subTitleLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            subTitleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            subTitleLabel.Location = new Point(26, 61);
            subTitleLabel.Name = "subTitleLabel";
            subTitleLabel.Size = new Size(370, 30);
            subTitleLabel.TabIndex = 119;
            subTitleLabel.Text = "Select existing rule to edit or delete";
            // 
            // searchBunifuTextBox1
            // 
            searchBunifuTextBox1.AcceptsReturn = false;
            searchBunifuTextBox1.AcceptsTab = false;
            searchBunifuTextBox1.Anchor = AnchorStyles.Top;
            searchBunifuTextBox1.AnimationSpeed = 200;
            searchBunifuTextBox1.AutoCompleteMode = AutoCompleteMode.None;
            searchBunifuTextBox1.AutoCompleteSource = AutoCompleteSource.None;
            searchBunifuTextBox1.BackColor = Color.Transparent;
            searchBunifuTextBox1.BackgroundImage = (Image)resources.GetObject("searchBunifuTextBox1.BackgroundImage");
            searchBunifuTextBox1.BorderColorActive = Color.DodgerBlue;
            searchBunifuTextBox1.BorderColorDisabled = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)), Conversions.ToInteger(Conversions.ToByte(161)));
            searchBunifuTextBox1.BorderColorHover = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            searchBunifuTextBox1.BorderColorIdle = Color.Silver;
            searchBunifuTextBox1.BorderRadius = 1;
            searchBunifuTextBox1.BorderThickness = 1;
            searchBunifuTextBox1.CharacterCasing = CharacterCasing.Normal;
            searchBunifuTextBox1.Cursor = Cursors.IBeam;
            searchBunifuTextBox1.DefaultFont = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            searchBunifuTextBox1.DefaultText = "";
            searchBunifuTextBox1.FillColor = Color.White;
            searchBunifuTextBox1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            searchBunifuTextBox1.HideSelection = true;
            searchBunifuTextBox1.IconLeft = null;
            searchBunifuTextBox1.IconLeftCursor = Cursors.IBeam;
            searchBunifuTextBox1.IconPadding = 10;
            searchBunifuTextBox1.IconRight = null;
            searchBunifuTextBox1.IconRightCursor = Cursors.IBeam;
            searchBunifuTextBox1.Lines = new string[0];
            searchBunifuTextBox1.Location = new Point(594, 189);
            searchBunifuTextBox1.MaxLength = 32767;
            searchBunifuTextBox1.MinimumSize = new Size(100, 35);
            searchBunifuTextBox1.Modified = false;
            searchBunifuTextBox1.Multiline = false;
            searchBunifuTextBox1.Name = "searchBunifuTextBox1";
            StateProperties5.BorderColor = Color.DodgerBlue;
            StateProperties5.FillColor = Color.Empty;
            StateProperties5.ForeColor = Color.Empty;
            StateProperties5.PlaceholderForeColor = Color.Empty;
            searchBunifuTextBox1.OnActiveState = StateProperties5;
            StateProperties6.BorderColor = Color.Empty;
            StateProperties6.FillColor = Color.White;
            StateProperties6.ForeColor = Color.Empty;
            StateProperties6.PlaceholderForeColor = Color.Silver;
            searchBunifuTextBox1.OnDisabledState = StateProperties6;
            StateProperties7.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties7.FillColor = Color.Empty;
            StateProperties7.ForeColor = Color.Empty;
            StateProperties7.PlaceholderForeColor = Color.Empty;
            searchBunifuTextBox1.OnHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Silver;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties8.PlaceholderForeColor = Color.Empty;
            searchBunifuTextBox1.OnIdleState = StateProperties8;
            searchBunifuTextBox1.PasswordChar = '\0';
            searchBunifuTextBox1.PlaceholderForeColor = Color.Silver;
            searchBunifuTextBox1.PlaceholderText = "";
            searchBunifuTextBox1.ReadOnly = false;
            searchBunifuTextBox1.ScrollBars = ScrollBars.None;
            searchBunifuTextBox1.SelectedText = "";
            searchBunifuTextBox1.SelectionLength = 0;
            searchBunifuTextBox1.SelectionStart = 0;
            searchBunifuTextBox1.ShortcutsEnabled = true;
            searchBunifuTextBox1.Size = new Size(350, 35);
            searchBunifuTextBox1.Style = _Style.Bunifu;
            searchBunifuTextBox1.TabIndex = 120;
            searchBunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            searchBunifuTextBox1.TextMarginBottom = 0;
            searchBunifuTextBox1.TextMarginLeft = 5;
            searchBunifuTextBox1.TextMarginTop = 0;
            searchBunifuTextBox1.TextPlaceholder = "";
            searchBunifuTextBox1.UseSystemPasswordChar = false;
            searchBunifuTextBox1.WordWrap = true;
            // 
            // BunifuTextBox1
            // 
            BunifuTextBox1.AcceptsReturn = false;
            BunifuTextBox1.AcceptsTab = false;
            BunifuTextBox1.Anchor = AnchorStyles.Top;
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
            BunifuTextBox1.CharacterCasing = CharacterCasing.Normal;
            BunifuTextBox1.Cursor = Cursors.IBeam;
            BunifuTextBox1.DefaultFont = new Font("Segoe UI", 11.78182f);
            BunifuTextBox1.DefaultText = "";
            BunifuTextBox1.FillColor = Color.White;
            BunifuTextBox1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuTextBox1.HideSelection = true;
            BunifuTextBox1.IconLeft = null;
            BunifuTextBox1.IconLeftCursor = Cursors.IBeam;
            BunifuTextBox1.IconPadding = 10;
            BunifuTextBox1.IconRight = null;
            BunifuTextBox1.IconRightCursor = Cursors.IBeam;
            BunifuTextBox1.Lines = new string[0];
            BunifuTextBox1.Location = new Point(594, 236);
            BunifuTextBox1.MaxLength = 32767;
            BunifuTextBox1.MinimumSize = new Size(100, 35);
            BunifuTextBox1.Modified = false;
            BunifuTextBox1.Multiline = false;
            BunifuTextBox1.Name = "BunifuTextBox1";
            StateProperties9.BorderColor = Color.DodgerBlue;
            StateProperties9.FillColor = Color.Empty;
            StateProperties9.ForeColor = Color.Empty;
            StateProperties9.PlaceholderForeColor = Color.Empty;
            BunifuTextBox1.OnActiveState = StateProperties9;
            StateProperties10.BorderColor = Color.Empty;
            StateProperties10.FillColor = Color.White;
            StateProperties10.ForeColor = Color.Empty;
            StateProperties10.PlaceholderForeColor = Color.Silver;
            BunifuTextBox1.OnDisabledState = StateProperties10;
            StateProperties11.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties11.FillColor = Color.Empty;
            StateProperties11.ForeColor = Color.Empty;
            StateProperties11.PlaceholderForeColor = Color.Empty;
            BunifuTextBox1.OnHoverState = StateProperties11;
            StateProperties12.BorderColor = Color.Silver;
            StateProperties12.FillColor = Color.White;
            StateProperties12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties12.PlaceholderForeColor = Color.Empty;
            BunifuTextBox1.OnIdleState = StateProperties12;
            BunifuTextBox1.PasswordChar = '\0';
            BunifuTextBox1.PlaceholderForeColor = Color.Silver;
            BunifuTextBox1.PlaceholderText = "$";
            BunifuTextBox1.ReadOnly = false;
            BunifuTextBox1.ScrollBars = ScrollBars.None;
            BunifuTextBox1.SelectedText = "";
            BunifuTextBox1.SelectionLength = 0;
            BunifuTextBox1.SelectionStart = 0;
            BunifuTextBox1.ShortcutsEnabled = true;
            BunifuTextBox1.Size = new Size(100, 35);
            BunifuTextBox1.Style = _Style.Bunifu;
            BunifuTextBox1.TabIndex = 121;
            BunifuTextBox1.TextAlign = HorizontalAlignment.Left;
            BunifuTextBox1.TextMarginBottom = 0;
            BunifuTextBox1.TextMarginLeft = 5;
            BunifuTextBox1.TextMarginTop = 0;
            BunifuTextBox1.TextPlaceholder = "$";
            BunifuTextBox1.UseSystemPasswordChar = false;
            BunifuTextBox1.WordWrap = true;
            // 
            // FrmManageServices
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(966, 570);
            Controls.Add(BunifuTextBox1);
            Controls.Add(searchBunifuTextBox1);
            Controls.Add(subTitleLabel);
            Controls.Add(Label1);
            Controls.Add(ruleActionLabel);
            Controls.Add(MenuStrip1);
            Controls.Add(Panel4);
            Controls.Add(_closeLabel);
            Controls.Add(Label7);
            Controls.Add(_cancelButton);
            Controls.Add(saveButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmManageServices";
            Text = "FrmManageServices";
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)blockContBunifuDataGridView).EndInit();
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
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
                    _closeLabel.Click -= Label6_Click;
                    _closeLabel.MouseHover -= closeLabel_MouseHover;
                    _closeLabel.MouseLeave -= closeLabel_Click;
                    _closeLabel.Click -= closeLabel_MouseLeave;
                }

                _closeLabel = value;
                if (_closeLabel != null)
                {
                    _closeLabel.Click += Label6_Click;
                    _closeLabel.MouseHover += closeLabel_MouseHover;
                    _closeLabel.MouseLeave += closeLabel_Click;
                    _closeLabel.Click += closeLabel_MouseLeave;
                }
            }
        }

        internal Label Label7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _cancelButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton cancelButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cancelButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cancelButton != null)
                {
                    _cancelButton.Click -= Label6_Click;
                }

                _cancelButton = value;
                if (_cancelButton != null)
                {
                    _cancelButton.Click += Label6_Click;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton saveButton;
        internal Panel Panel4;
        public Bunifu.UI.WinForms.BunifuDataGridView blockContBunifuDataGridView;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column5;
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem CompanyToolStripMenuItem;
        internal ToolStripMenuItem EditToolStripMenuItem;
        internal ToolStripMenuItem DeleteToolStripMenuItem;
        internal Label ruleActionLabel;
        internal Label Label1;
        internal Label subTitleLabel;
        internal BunifuTextBox searchBunifuTextBox1;
        internal BunifuTextBox BunifuTextBox1;
    }
}