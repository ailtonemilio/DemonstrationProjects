using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmListTransfers : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListTransfers));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel1 = new Panel();
            Panel2 = new Panel();
            TableLayoutPanel3 = new TableLayoutPanel();
            _deleteButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _deleteButton.Click += new EventHandler(DeleteCompanyButton_Click);
            titleLabel = new Label();
            Panel4 = new Panel();
            _transfersBunifuDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            _transfersBunifuDataGridView.CellContentClick += new DataGridViewCellEventHandler(transfersBunifuDataGridView_CellContentClick);
            Column1 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewCheckBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            _createTransfeRButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _createTransfeRButton.Click += new EventHandler(createTransfeRButton_Click);
            BunifuShadowPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_transfersBunifuDataGridView).BeginInit();
            SuspendLayout();
            // 
            // BunifuShadowPanel1
            // 
            BunifuShadowPanel1.BackColor = Color.White;
            BunifuShadowPanel1.BorderColor = Color.Transparent;
            BunifuShadowPanel1.Controls.Add(Panel1);
            BunifuShadowPanel1.Dock = DockStyle.Fill;
            BunifuShadowPanel1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            BunifuShadowPanel1.Location = new Point(0, 0);
            BunifuShadowPanel1.Margin = new Padding(0);
            BunifuShadowPanel1.Name = "BunifuShadowPanel1";
            BunifuShadowPanel1.Padding = new Padding(10, 10, 5, 5);
            BunifuShadowPanel1.PanelColor = Color.Empty;
            BunifuShadowPanel1.ShadowDept = 2;
            BunifuShadowPanel1.ShadowTopLeftVisible = true;
            BunifuShadowPanel1.Size = new Size(1506, 869);
            BunifuShadowPanel1.TabIndex = 76;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel1.Controls.Add(Panel2);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(10, 10);
            Panel1.Name = "Panel1";
            Panel1.Padding = new Padding(0, 40, 0, 0);
            Panel1.Size = new Size(1491, 854);
            Panel1.TabIndex = 33;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(TableLayoutPanel3);
            Panel2.Controls.Add(titleLabel);
            Panel2.Controls.Add(Panel4);
            Panel2.Controls.Add(_createTransfeRButton);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(0, 40);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1491, 814);
            Panel2.TabIndex = 1;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.Anchor = AnchorStyles.None;
            TableLayoutPanel3.ColumnCount = 2;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0f));
            TableLayoutPanel3.Controls.Add(_deleteButton, 1, 0);
            TableLayoutPanel3.Location = new Point(1154, 743);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel3.Size = new Size(257, 55);
            TableLayoutPanel3.TabIndex = 81;
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
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _deleteButton.CustomizableEdges = BorderEdges1;
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
            _deleteButton.Location = new Point(131, 3);
            _deleteButton.Name = "_deleteButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _deleteButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.LightCoral;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.LightCoral;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _deleteButton.OnPressedState = StateProperties2;
            _deleteButton.Size = new Size(123, 45);
            _deleteButton.TabIndex = 61;
            _deleteButton.TextAlign = ContentAlignment.MiddleCenter;
            _deleteButton.TextMarginLeft = 0;
            _deleteButton.UseDefaultRadiusAndThickness = true;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.None;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titleLabel.Location = new Point(55, 21);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(647, 36);
            titleLabel.TabIndex = 80;
            titleLabel.Text = "Current transfers";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Panel4
            // 
            Panel4.Anchor = AnchorStyles.None;
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(_transfersBunifuDataGridView);
            Panel4.Location = new Point(59, 60);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(1352, 678);
            Panel4.TabIndex = 79;
            // 
            // transfersBunifuDataGridView
            // 
            _transfersBunifuDataGridView.AllowCustomTheming = true;
            _transfersBunifuDataGridView.AllowUserToAddRows = false;
            _transfersBunifuDataGridView.AllowUserToDeleteRows = false;
            _transfersBunifuDataGridView.AllowUserToOrderColumns = true;
            _transfersBunifuDataGridView.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _transfersBunifuDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _transfersBunifuDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _transfersBunifuDataGridView.BackgroundColor = Color.White;
            _transfersBunifuDataGridView.BorderStyle = BorderStyle.None;
            _transfersBunifuDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _transfersBunifuDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _transfersBunifuDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _transfersBunifuDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _transfersBunifuDataGridView.ColumnHeadersHeight = 40;
            _transfersBunifuDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column15, Column4, Column5, Column6, Column7, Column10, Column3, Column8, Column9, Column11 });
            _transfersBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _transfersBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _transfersBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _transfersBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _transfersBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _transfersBunifuDataGridView.CurrentTheme.BackColor = Color.Snow;
            _transfersBunifuDataGridView.CurrentTheme.GridColor = Color.Gray;
            _transfersBunifuDataGridView.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _transfersBunifuDataGridView.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _transfersBunifuDataGridView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _transfersBunifuDataGridView.CurrentTheme.Name = null;
            _transfersBunifuDataGridView.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _transfersBunifuDataGridView.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _transfersBunifuDataGridView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _transfersBunifuDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _transfersBunifuDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _transfersBunifuDataGridView.DefaultCellStyle = DataGridViewCellStyle3;
            _transfersBunifuDataGridView.Dock = DockStyle.Fill;
            _transfersBunifuDataGridView.EnableHeadersVisualStyles = false;
            _transfersBunifuDataGridView.GridColor = Color.Gray;
            _transfersBunifuDataGridView.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _transfersBunifuDataGridView.HeaderBgColor = Color.Empty;
            _transfersBunifuDataGridView.HeaderForeColor = Color.White;
            _transfersBunifuDataGridView.Location = new Point(0, 0);
            _transfersBunifuDataGridView.Name = "_transfersBunifuDataGridView";
            _transfersBunifuDataGridView.ReadOnly = true;
            _transfersBunifuDataGridView.RowHeadersVisible = false;
            _transfersBunifuDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _transfersBunifuDataGridView.RowTemplate.Height = 30;
            _transfersBunifuDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _transfersBunifuDataGridView.Size = new Size(1350, 676);
            _transfersBunifuDataGridView.TabIndex = 57;
            _transfersBunifuDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column15
            // 
            Column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column15.FillWeight = 68.988f;
            Column15.HeaderText = "";
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            Column15.Resizable = DataGridViewTriState.True;
            Column15.SortMode = DataGridViewColumnSortMode.Automatic;
            Column15.Width = 30;
            // 
            // Column4
            // 
            Column4.FillWeight = 104.3427f;
            Column4.HeaderText = "Container #";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 54.72337f;
            Column5.HeaderText = "Size";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            Column6.FillWeight = 56.64131f;
            Column6.HeaderText = "Status";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            Column7.FillWeight = 58.57397f;
            Column7.HeaderText = "Weight";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.FillWeight = 91.41531f;
            Column10.HeaderText = "Due (days)";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 149.1011f;
            Column3.HeaderText = "Trucker";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            Column8.FillWeight = 154.5456f;
            Column8.HeaderText = "From";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Resizable = DataGridViewTriState.True;
            Column8.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            Column9.FillWeight = 149.8183f;
            Column9.HeaderText = "To";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Resizable = DataGridViewTriState.True;
            Column9.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column11
            // 
            Column11.FillWeight = 80.83832f;
            Column11.HeaderText = "";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // createTransfeRButton
            // 
            _createTransfeRButton.AllowToggling = false;
            _createTransfeRButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _createTransfeRButton.AnimationSpeed = 200;
            _createTransfeRButton.AutoGenerateColors = false;
            _createTransfeRButton.BackColor = Color.Transparent;
            _createTransfeRButton.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _createTransfeRButton.BackgroundImage = (Image)resources.GetObject("createTransfeRButton.BackgroundImage");
            _createTransfeRButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _createTransfeRButton.ButtonText = "Create Transfer";
            _createTransfeRButton.ButtonTextMarginLeft = 0;
            _createTransfeRButton.ColorContrastOnClick = 45;
            _createTransfeRButton.ColorContrastOnHover = 45;
            _createTransfeRButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _createTransfeRButton.CustomizableEdges = BorderEdges2;
            _createTransfeRButton.DialogResult = DialogResult.None;
            _createTransfeRButton.DisabledBorderColor = Color.Empty;
            _createTransfeRButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _createTransfeRButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _createTransfeRButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _createTransfeRButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _createTransfeRButton.ForeColor = Color.White;
            _createTransfeRButton.IconLeftCursor = Cursors.Hand;
            _createTransfeRButton.IconMarginLeft = 11;
            _createTransfeRButton.IconPadding = 10;
            _createTransfeRButton.IconRightCursor = Cursors.Hand;
            _createTransfeRButton.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _createTransfeRButton.IdleBorderRadius = 40;
            _createTransfeRButton.IdleBorderThickness = 1;
            _createTransfeRButton.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _createTransfeRButton.IdleIconLeftImage = null;
            _createTransfeRButton.IdleIconRightImage = null;
            _createTransfeRButton.IndicateFocus = true;
            _createTransfeRButton.Location = new Point(1308, 12);
            _createTransfeRButton.Name = "_createTransfeRButton";
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties3.BorderRadius = 40;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _createTransfeRButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties4.BorderRadius = 40;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _createTransfeRButton.OnPressedState = StateProperties4;
            _createTransfeRButton.Size = new Size(165, 45);
            _createTransfeRButton.TabIndex = 68;
            _createTransfeRButton.TextAlign = ContentAlignment.MiddleCenter;
            _createTransfeRButton.TextMarginLeft = 0;
            _createTransfeRButton.UseDefaultRadiusAndThickness = true;
            // 
            // FrmListTransfers
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1506, 869);
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListTransfers";
            Text = "FrmListTransfers";
            BunifuShadowPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            TableLayoutPanel3.ResumeLayout(false);
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_transfersBunifuDataGridView).EndInit();
            Load += new EventHandler(FrmListTransfers_Load);
            ResumeLayout(false);
        }

        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel1;
        internal Panel Panel2;
        internal Panel Panel4;
        private Bunifu.UI.WinForms.BunifuDataGridView _transfersBunifuDataGridView;

        public Bunifu.UI.WinForms.BunifuDataGridView transfersBunifuDataGridView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _transfersBunifuDataGridView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_transfersBunifuDataGridView != null)
                {
                    _transfersBunifuDataGridView.CellContentClick -= transfersBunifuDataGridView_CellContentClick;
                }

                _transfersBunifuDataGridView = value;
                if (_transfersBunifuDataGridView != null)
                {
                    _transfersBunifuDataGridView.CellContentClick += transfersBunifuDataGridView_CellContentClick;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _createTransfeRButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton createTransfeRButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _createTransfeRButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_createTransfeRButton != null)
                {
                    _createTransfeRButton.Click -= createTransfeRButton_Click;
                }

                _createTransfeRButton = value;
                if (_createTransfeRButton != null)
                {
                    _createTransfeRButton.Click += createTransfeRButton_Click;
                }
            }
        }

        internal Label titleLabel;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewCheckBoxColumn Column15;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column6;
        internal DataGridViewTextBoxColumn Column7;
        internal DataGridViewTextBoxColumn Column10;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column8;
        internal DataGridViewTextBoxColumn Column9;
        internal DataGridViewTextBoxColumn Column11;
        internal TableLayoutPanel TableLayoutPanel3;
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
                    _deleteButton.Click -= DeleteCompanyButton_Click;
                }

                _deleteButton = value;
                if (_deleteButton != null)
                {
                    _deleteButton.Click += DeleteCompanyButton_Click;
                }
            }
        }
    }
}