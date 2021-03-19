using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmBlockContainer : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBlockContainer));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Label1 = new Label();
            Label2 = new Label();
            _RichTextBox1 = new RichTextBox();
            _RichTextBox1.TextChanged += new EventHandler(RichTextBox1_TextChanged);
            warningLabel = new Label();
            titleLabel = new Label();
            _blockContainerButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _blockContainerButton.Click += new EventHandler(blockContainerButton_ButtonClick);
            goodContDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            badContDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Panel1 = new Panel();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(Label6_Click);
            _closeLabel.MouseHover += new EventHandler(closeLabel_MouseHover);
            _closeLabel.MouseLeave += new EventHandler(closeLabel_Click);
            _closeLabel.Click += new EventHandler(closeLabel_MouseLeave);
            Panel2 = new Panel();
            _noBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _noBunifuButton.Click += new EventHandler(Label6_Click);
            NumericUpDown1 = new NumericUpDown();
            Label4 = new Label();
            Label3 = new Label();
            cboShippingLine = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)goodContDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)badContDataGrid).BeginInit();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.None;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(115, 95);
            Label1.Name = "Label1";
            Label1.Size = new Size(108, 21);
            Label1.TabIndex = 10;
            Label1.Text = "Shipping Line:";
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.None;
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(137, 182);
            Label2.Name = "Label2";
            Label2.Size = new Size(88, 21);
            Label2.TabIndex = 13;
            Label2.Text = "Containers:";
            // 
            // RichTextBox1
            // 
            _RichTextBox1.Anchor = AnchorStyles.None;
            _RichTextBox1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _RichTextBox1.Location = new Point(142, 210);
            _RichTextBox1.Name = "_RichTextBox1";
            _RichTextBox1.Size = new Size(297, 371);
            _RichTextBox1.TabIndex = 12;
            _RichTextBox1.Text = "";
            // 
            // warningLabel
            // 
            warningLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            warningLabel.AutoSize = true;
            warningLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            warningLabel.ForeColor = Color.Firebrick;
            warningLabel.Location = new Point(882, 584);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(208, 21);
            warningLabel.TabIndex = 17;
            warningLabel.Text = "* Container  Already Blocked";
            warningLabel.Visible = false;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.None;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titleLabel.Location = new Point(86, 26);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(727, 42);
            titleLabel.TabIndex = 16;
            titleLabel.Text = "Block Container";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // blockContainerButton
            // 
            _blockContainerButton.AllowToggling = false;
            _blockContainerButton.Anchor = AnchorStyles.Bottom;
            _blockContainerButton.AnimationSpeed = 200;
            _blockContainerButton.AutoGenerateColors = false;
            _blockContainerButton.BackColor = Color.Transparent;
            _blockContainerButton.BackColor1 = Color.Teal;
            _blockContainerButton.BackgroundImage = (Image)resources.GetObject("blockContainerButton.BackgroundImage");
            _blockContainerButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _blockContainerButton.ButtonText = "Block Containers";
            _blockContainerButton.ButtonTextMarginLeft = 0;
            _blockContainerButton.ColorContrastOnClick = 45;
            _blockContainerButton.ColorContrastOnHover = 45;
            _blockContainerButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _blockContainerButton.CustomizableEdges = BorderEdges1;
            _blockContainerButton.DialogResult = DialogResult.None;
            _blockContainerButton.DisabledBorderColor = Color.Empty;
            _blockContainerButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _blockContainerButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _blockContainerButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _blockContainerButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _blockContainerButton.ForeColor = Color.White;
            _blockContainerButton.IconLeftCursor = Cursors.Hand;
            _blockContainerButton.IconMarginLeft = 11;
            _blockContainerButton.IconPadding = 10;
            _blockContainerButton.IconRightCursor = Cursors.Hand;
            _blockContainerButton.IdleBorderColor = Color.Teal;
            _blockContainerButton.IdleBorderRadius = 3;
            _blockContainerButton.IdleBorderThickness = 1;
            _blockContainerButton.IdleFillColor = Color.Teal;
            _blockContainerButton.IdleIconLeftImage = null;
            _blockContainerButton.IdleIconRightImage = null;
            _blockContainerButton.IndicateFocus = true;
            _blockContainerButton.Location = new Point(869, 705);
            _blockContainerButton.Name = "_blockContainerButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _blockContainerButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _blockContainerButton.OnPressedState = StateProperties2;
            _blockContainerButton.Size = new Size(159, 45);
            _blockContainerButton.TabIndex = 68;
            _blockContainerButton.TextAlign = ContentAlignment.MiddleCenter;
            _blockContainerButton.TextMarginLeft = 0;
            _blockContainerButton.UseDefaultRadiusAndThickness = true;
            // 
            // goodContDataGrid
            // 
            goodContDataGrid.AllowCustomTheming = false;
            goodContDataGrid.AllowUserToAddRows = false;
            goodContDataGrid.AllowUserToDeleteRows = false;
            goodContDataGrid.AllowUserToResizeColumns = false;
            goodContDataGrid.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(199)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(199)));
            DataGridViewCellStyle1.ForeColor = Color.Black;
            goodContDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            goodContDataGrid.Anchor = AnchorStyles.None;
            goodContDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            goodContDataGrid.BackgroundColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            goodContDataGrid.BorderStyle = BorderStyle.None;
            goodContDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            goodContDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.ForestGreen;
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            goodContDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            goodContDataGrid.ColumnHeadersHeight = 40;
            goodContDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column2 });
            goodContDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(199)), Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(199)));
            goodContDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            goodContDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            goodContDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(122)), Conversions.ToInteger(Conversions.ToByte(185)), Conversions.ToInteger(Conversions.ToByte(122)));
            goodContDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            goodContDataGrid.CurrentTheme.BackColor = Color.ForestGreen;
            goodContDataGrid.CurrentTheme.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(188)), Conversions.ToInteger(Conversions.ToByte(220)), Conversions.ToInteger(Conversions.ToByte(188)));
            goodContDataGrid.CurrentTheme.HeaderStyle.BackColor = Color.ForestGreen;
            goodContDataGrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            goodContDataGrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            goodContDataGrid.CurrentTheme.Name = null;
            goodContDataGrid.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(210)));
            goodContDataGrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            goodContDataGrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            goodContDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(122)), Conversions.ToInteger(Conversions.ToByte(185)), Conversions.ToInteger(Conversions.ToByte(122)));
            goodContDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(210)), Conversions.ToInteger(Conversions.ToByte(231)), Conversions.ToInteger(Conversions.ToByte(210)));
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(122)), Conversions.ToInteger(Conversions.ToByte(185)), Conversions.ToInteger(Conversions.ToByte(122)));
            DataGridViewCellStyle3.SelectionForeColor = Color.White;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            goodContDataGrid.DefaultCellStyle = DataGridViewCellStyle3;
            goodContDataGrid.EnableHeadersVisualStyles = false;
            goodContDataGrid.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(188)), Conversions.ToInteger(Conversions.ToByte(220)), Conversions.ToInteger(Conversions.ToByte(188)));
            goodContDataGrid.HeaderBackColor = Color.ForestGreen;
            goodContDataGrid.HeaderBgColor = Color.Empty;
            goodContDataGrid.HeaderForeColor = Color.White;
            goodContDataGrid.Location = new Point(585, 208);
            goodContDataGrid.Name = "goodContDataGrid";
            goodContDataGrid.RowHeadersVisible = false;
            goodContDataGrid.RowTemplate.Height = 40;
            goodContDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            goodContDataGrid.Size = new Size(264, 373);
            goodContDataGrid.TabIndex = 72;
            goodContDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.ForestGreen;
            // 
            // Column2
            // 
            Column2.HeaderText = "GOOD ENTRIES";
            Column2.Name = "Column2";
            // 
            // badContDataGrid
            // 
            badContDataGrid.AllowCustomTheming = false;
            badContDataGrid.AllowUserToAddRows = false;
            badContDataGrid.AllowUserToDeleteRows = false;
            badContDataGrid.AllowUserToResizeColumns = false;
            badContDataGrid.AllowUserToResizeRows = false;
            DataGridViewCellStyle4.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(223)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            DataGridViewCellStyle4.ForeColor = Color.Black;
            badContDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
            badContDataGrid.Anchor = AnchorStyles.None;
            badContDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            badContDataGrid.BackgroundColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            badContDataGrid.BorderStyle = BorderStyle.None;
            badContDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            badContDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.Maroon;
            DataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            badContDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            badContDataGrid.ColumnHeadersHeight = 40;
            badContDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            badContDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(223)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            badContDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            badContDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            badContDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(178)), Conversions.ToInteger(Conversions.ToByte(102)), Conversions.ToInteger(Conversions.ToByte(102)));
            badContDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.White;
            badContDataGrid.CurrentTheme.BackColor = Color.Maroon;
            badContDataGrid.CurrentTheme.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(216)), Conversions.ToInteger(Conversions.ToByte(178)), Conversions.ToInteger(Conversions.ToByte(178)));
            badContDataGrid.CurrentTheme.HeaderStyle.BackColor = Color.Maroon;
            badContDataGrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            badContDataGrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            badContDataGrid.CurrentTheme.Name = null;
            badContDataGrid.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            badContDataGrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            badContDataGrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            badContDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(178)), Conversions.ToInteger(Conversions.ToByte(102)), Conversions.ToInteger(Conversions.ToByte(102)));
            badContDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.White;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(229)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            DataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle6.ForeColor = Color.Black;
            DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(178)), Conversions.ToInteger(Conversions.ToByte(102)), Conversions.ToInteger(Conversions.ToByte(102)));
            DataGridViewCellStyle6.SelectionForeColor = Color.White;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            badContDataGrid.DefaultCellStyle = DataGridViewCellStyle6;
            badContDataGrid.EnableHeadersVisualStyles = false;
            badContDataGrid.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(216)), Conversions.ToInteger(Conversions.ToByte(178)), Conversions.ToInteger(Conversions.ToByte(178)));
            badContDataGrid.HeaderBackColor = Color.Maroon;
            badContDataGrid.HeaderBgColor = Color.Empty;
            badContDataGrid.HeaderForeColor = Color.White;
            badContDataGrid.Location = new Point(886, 208);
            badContDataGrid.Name = "badContDataGrid";
            badContDataGrid.RowHeadersVisible = false;
            badContDataGrid.RowTemplate.Height = 40;
            badContDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            badContDataGrid.Size = new Size(249, 373);
            badContDataGrid.TabIndex = 73;
            badContDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            // 
            // Column1
            // 
            Column1.HeaderText = "BAD ENTRIES";
            Column1.Name = "Column1";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel1.Controls.Add(_closeLabel);
            Panel1.Controls.Add(Panel2);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Padding = new Padding(0, 40, 0, 0);
            Panel1.Size = new Size(1253, 821);
            Panel1.TabIndex = 33;
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(1205, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 37);
            _closeLabel.TabIndex = 78;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(cboShippingLine);
            Panel2.Controls.Add(_noBunifuButton);
            Panel2.Controls.Add(NumericUpDown1);
            Panel2.Controls.Add(Label4);
            Panel2.Controls.Add(Label3);
            Panel2.Controls.Add(titleLabel);
            Panel2.Controls.Add(warningLabel);
            Panel2.Controls.Add(badContDataGrid);
            Panel2.Controls.Add(_RichTextBox1);
            Panel2.Controls.Add(goodContDataGrid);
            Panel2.Controls.Add(Label2);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(_blockContainerButton);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(0, 40);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1253, 781);
            Panel2.TabIndex = 1;
            // 
            // noBunifuButton
            // 
            _noBunifuButton.AllowToggling = false;
            _noBunifuButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _noBunifuButton.AnimationSpeed = 200;
            _noBunifuButton.AutoGenerateColors = false;
            _noBunifuButton.BackColor = Color.Transparent;
            _noBunifuButton.BackColor1 = Color.White;
            _noBunifuButton.BackgroundImage = (Image)resources.GetObject("noBunifuButton.BackgroundImage");
            _noBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _noBunifuButton.ButtonText = "CANCEL";
            _noBunifuButton.ButtonTextMarginLeft = 0;
            _noBunifuButton.ColorContrastOnClick = 45;
            _noBunifuButton.ColorContrastOnHover = 45;
            _noBunifuButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _noBunifuButton.CustomizableEdges = BorderEdges2;
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
            _noBunifuButton.Location = new Point(1053, 705);
            _noBunifuButton.Name = "_noBunifuButton";
            StateProperties3.BorderColor = Color.DarkGray;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.DarkGray;
            StateProperties3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _noBunifuButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Gray;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _noBunifuButton.OnPressedState = StateProperties4;
            _noBunifuButton.Size = new Size(135, 44);
            _noBunifuButton.TabIndex = 77;
            _noBunifuButton.TextAlign = ContentAlignment.MiddleCenter;
            _noBunifuButton.TextMarginLeft = 0;
            _noBunifuButton.UseDefaultRadiusAndThickness = true;
            // 
            // NumericUpDown1
            // 
            NumericUpDown1.Anchor = AnchorStyles.None;
            NumericUpDown1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            NumericUpDown1.Location = new Point(296, 134);
            NumericUpDown1.Name = "NumericUpDown1";
            NumericUpDown1.Size = new Size(60, 28);
            NumericUpDown1.TabIndex = 75;
            NumericUpDown1.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.None;
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label4.Location = new Point(357, 136);
            Label4.Name = "Label4";
            Label4.Size = new Size(42, 21);
            Label4.TabIndex = 76;
            Label4.Text = "days";
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.None;
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(115, 136);
            Label3.Name = "Label3";
            Label3.Size = new Size(147, 21);
            Label3.TabIndex = 74;
            Label3.Text = "Block containers for";
            // 
            // cboShippingLine
            // 
            cboShippingLine.AutoCompleteMode = AutoCompleteMode.Append;
            cboShippingLine.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboShippingLine.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboShippingLine.FormattingEnabled = true;
            cboShippingLine.Location = new Point(229, 88);
            cboShippingLine.Name = "cboShippingLine";
            cboShippingLine.Size = new Size(415, 28);
            cboShippingLine.TabIndex = 78;
            // 
            // FrmBlockContainer
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1253, 821);
            ControlBox = false;
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBlockContainer";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)goodContDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)badContDataGrid).EndInit();
            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).EndInit();
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
        }

        internal Label Label1;
        internal Label Label2;
        private RichTextBox _RichTextBox1;

        internal RichTextBox RichTextBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RichTextBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RichTextBox1 != null)
                {
                    _RichTextBox1.TextChanged -= RichTextBox1_TextChanged;
                }

                _RichTextBox1 = value;
                if (_RichTextBox1 != null)
                {
                    _RichTextBox1.TextChanged += RichTextBox1_TextChanged;
                }
            }
        }

        internal Label warningLabel;
        internal Label titleLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _blockContainerButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton blockContainerButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _blockContainerButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_blockContainerButton != null)
                {
                    _blockContainerButton.Click -= blockContainerButton_ButtonClick;
                }

                _blockContainerButton = value;
                if (_blockContainerButton != null)
                {
                    _blockContainerButton.Click += blockContainerButton_ButtonClick;
                }
            }
        }

        internal Bunifu.UI.WinForms.BunifuDataGridView goodContDataGrid;
        internal Bunifu.UI.WinForms.BunifuDataGridView badContDataGrid;
        internal DataGridViewTextBoxColumn Column1;
        internal Panel Panel1;
        internal Panel Panel2;
        internal DataGridViewTextBoxColumn Column2;
        internal NumericUpDown NumericUpDown1;
        internal Label Label4;
        internal Label Label3;
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
                    _noBunifuButton.Click -= Label6_Click;
                }

                _noBunifuButton = value;
                if (_noBunifuButton != null)
                {
                    _noBunifuButton.Click += Label6_Click;
                }
            }
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

        internal ComboBox cboShippingLine;
    }
}