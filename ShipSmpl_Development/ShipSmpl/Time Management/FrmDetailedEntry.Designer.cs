using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmDetailedEntry : Form
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
            var DataGridViewCellStyle13 = new DataGridViewCellStyle();
            var DataGridViewCellStyle14 = new DataGridViewCellStyle();
            var DataGridViewCellStyle16 = new DataGridViewCellStyle();
            var DataGridViewCellStyle15 = new DataGridViewCellStyle();
            employeeNameLabel = new Label();
            dateLabel = new Label();
            Label9 = new Label();
            TableLayoutPanel3 = new TableLayoutPanel();
            Label11 = new Label();
            deviceNameLabel = new Label();
            siteLocationLabel = new Label();
            Label10 = new Label();
            Label1 = new Label();
            modifiedOnLabel = new Label();
            TableLayoutPanel4 = new TableLayoutPanel();
            Label6 = new Label();
            workDoneLabel = new Label();
            Panel4 = new Panel();
            _entryDetailsDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            _entryDetailsDataGrid.SelectionChanged += new EventHandler(entryDetailsDataGrid_SelectionChanged);
            reasonLabel = new CustomizedControlsLibrary.ShapedLabel();
            _closeLabel = new Label();
            _closeLabel.MouseHover += new EventHandler(closeLabel_MouseHover);
            _closeLabel.MouseLeave += new EventHandler(closeLabel_MouseLeave);
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label12 = new Label();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            TableLayoutPanel3.SuspendLayout();
            TableLayoutPanel4.SuspendLayout();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_entryDetailsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.BackColor = Color.White;
            employeeNameLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            employeeNameLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            employeeNameLabel.Location = new Point(45, 49);
            employeeNameLabel.Margin = new Padding(1, 0, 1, 0);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new Size(319, 39);
            employeeNameLabel.TabIndex = 11;
            employeeNameLabel.Text = "John Doe";
            employeeNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateLabel
            // 
            dateLabel.BackColor = Color.White;
            dateLabel.BorderStyle = BorderStyle.FixedSingle;
            dateLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            dateLabel.ForeColor = Color.DimGray;
            dateLabel.Location = new Point(225, 89);
            dateLabel.Margin = new Padding(1, 0, 1, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(165, 33);
            dateLabel.TabIndex = 16;
            dateLabel.Text = "Jan 9, 2019";
            dateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold);
            Label9.Location = new Point(59, 359);
            Label9.Margin = new Padding(1, 0, 1, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(63, 25);
            Label9.TabIndex = 14;
            Label9.Text = "Notes";
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.ColumnCount = 2;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.71844f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.28156f));
            TableLayoutPanel3.Controls.Add(Label11, 0, 0);
            TableLayoutPanel3.Controls.Add(deviceNameLabel, 1, 1);
            TableLayoutPanel3.Controls.Add(siteLocationLabel, 1, 0);
            TableLayoutPanel3.Controls.Add(Label10, 0, 1);
            TableLayoutPanel3.Controls.Add(Label1, 0, 2);
            TableLayoutPanel3.Controls.Add(modifiedOnLabel, 1, 2);
            TableLayoutPanel3.Location = new Point(590, 120);
            TableLayoutPanel3.Margin = new Padding(1);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 3;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35.10638f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 31.91489f));
            TableLayoutPanel3.Size = new Size(412, 94);
            TableLayoutPanel3.TabIndex = 18;
            // 
            // Label11
            // 
            Label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label11.AutoSize = true;
            Label11.BackColor = Color.White;
            Label11.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label11.Location = new Point(47, 0);
            Label11.Margin = new Padding(1, 0, 1, 0);
            Label11.Name = "Label11";
            Label11.Size = new Size(127, 25);
            Label11.TabIndex = 1;
            Label11.Text = "Site Location:";
            Label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deviceNameLabel
            // 
            deviceNameLabel.AutoSize = true;
            deviceNameLabel.BackColor = Color.White;
            deviceNameLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            deviceNameLabel.Location = new Point(176, 31);
            deviceNameLabel.Margin = new Padding(1, 0, 1, 0);
            deviceNameLabel.Name = "deviceNameLabel";
            deviceNameLabel.Size = new Size(45, 25);
            deviceNameLabel.TabIndex = 13;
            deviceNameLabel.Text = "N/A";
            deviceNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // siteLocationLabel
            // 
            siteLocationLabel.AutoSize = true;
            siteLocationLabel.BackColor = Color.White;
            siteLocationLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            siteLocationLabel.Location = new Point(176, 0);
            siteLocationLabel.Margin = new Padding(1, 0, 1, 0);
            siteLocationLabel.Name = "siteLocationLabel";
            siteLocationLabel.Size = new Size(45, 25);
            siteLocationLabel.TabIndex = 11;
            siteLocationLabel.Text = "N/A";
            siteLocationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label10
            // 
            Label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label10.BackColor = Color.White;
            Label10.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label10.Location = new Point(1, 31);
            Label10.Margin = new Padding(1, 0, 1, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(173, 27);
            Label10.TabIndex = 12;
            Label10.Text = "Device Name:";
            Label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label1.BackColor = Color.White;
            Label1.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(1, 63);
            Label1.Margin = new Padding(1, 0, 1, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(173, 27);
            Label1.TabIndex = 14;
            Label1.Text = "Modification Date:";
            Label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // modifiedOnLabel
            // 
            modifiedOnLabel.AutoSize = true;
            modifiedOnLabel.BackColor = Color.White;
            modifiedOnLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            modifiedOnLabel.Location = new Point(176, 63);
            modifiedOnLabel.Margin = new Padding(1, 0, 1, 0);
            modifiedOnLabel.Name = "modifiedOnLabel";
            modifiedOnLabel.Size = new Size(45, 25);
            modifiedOnLabel.TabIndex = 15;
            modifiedOnLabel.Text = "N/A";
            modifiedOnLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel4
            // 
            TableLayoutPanel4.ColumnCount = 2;
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2994f));
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 234.0f));
            TableLayoutPanel4.Controls.Add(Label6, 0, 0);
            TableLayoutPanel4.Controls.Add(workDoneLabel, 1, 0);
            TableLayoutPanel4.Location = new Point(590, 230);
            TableLayoutPanel4.Margin = new Padding(1);
            TableLayoutPanel4.Name = "TableLayoutPanel4";
            TableLayoutPanel4.RowCount = 1;
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.625f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 130.0f));
            TableLayoutPanel4.Size = new Size(412, 130);
            TableLayoutPanel4.TabIndex = 19;
            // 
            // Label6
            // 
            Label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label6.AutoSize = true;
            Label6.BackColor = Color.White;
            Label6.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(19, 0);
            Label6.Margin = new Padding(1, 0, 1, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(158, 25);
            Label6.TabIndex = 1;
            Label6.Text = "Work Performed:";
            Label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // workDoneLabel
            // 
            workDoneLabel.AutoSize = true;
            workDoneLabel.BackColor = Color.White;
            workDoneLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            workDoneLabel.Location = new Point(179, 0);
            workDoneLabel.Margin = new Padding(1, 0, 1, 0);
            workDoneLabel.Name = "workDoneLabel";
            workDoneLabel.Size = new Size(45, 25);
            workDoneLabel.TabIndex = 12;
            workDoneLabel.Text = "N/A";
            workDoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel4
            // 
            Panel4.Anchor = AnchorStyles.Top;
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(_entryDetailsDataGrid);
            Panel4.Location = new Point(42, 120);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(543, 218);
            Panel4.TabIndex = 111;
            // 
            // entryDetailsDataGrid
            // 
            _entryDetailsDataGrid.AllowCustomTheming = true;
            _entryDetailsDataGrid.AllowUserToAddRows = false;
            _entryDetailsDataGrid.AllowUserToDeleteRows = false;
            _entryDetailsDataGrid.AllowUserToResizeRows = false;
            DataGridViewCellStyle13.BackColor = Color.White;
            DataGridViewCellStyle13.ForeColor = Color.Black;
            DataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _entryDetailsDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13;
            _entryDetailsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _entryDetailsDataGrid.BackgroundColor = Color.White;
            _entryDetailsDataGrid.BorderStyle = BorderStyle.None;
            _entryDetailsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _entryDetailsDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle14.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle14.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle14.ForeColor = Color.White;
            DataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            _entryDetailsDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14;
            _entryDetailsDataGrid.ColumnHeadersHeight = 40;
            _entryDetailsDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column4, Column3, Column5, Column7, Column8, Column9, Column10, Column11 });
            _entryDetailsDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _entryDetailsDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _entryDetailsDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _entryDetailsDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _entryDetailsDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _entryDetailsDataGrid.CurrentTheme.BackColor = Color.Snow;
            _entryDetailsDataGrid.CurrentTheme.GridColor = Color.Gray;
            _entryDetailsDataGrid.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _entryDetailsDataGrid.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _entryDetailsDataGrid.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _entryDetailsDataGrid.CurrentTheme.Name = null;
            _entryDetailsDataGrid.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _entryDetailsDataGrid.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _entryDetailsDataGrid.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _entryDetailsDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _entryDetailsDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle16.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle16.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle16.ForeColor = Color.Black;
            DataGridViewCellStyle16.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle16.SelectionForeColor = Color.Black;
            DataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            _entryDetailsDataGrid.DefaultCellStyle = DataGridViewCellStyle16;
            _entryDetailsDataGrid.Dock = DockStyle.Fill;
            _entryDetailsDataGrid.EnableHeadersVisualStyles = false;
            _entryDetailsDataGrid.GridColor = Color.Gray;
            _entryDetailsDataGrid.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _entryDetailsDataGrid.HeaderBgColor = Color.Empty;
            _entryDetailsDataGrid.HeaderForeColor = Color.White;
            _entryDetailsDataGrid.Location = new Point(0, 0);
            _entryDetailsDataGrid.Name = "_entryDetailsDataGrid";
            _entryDetailsDataGrid.ReadOnly = true;
            _entryDetailsDataGrid.RowHeadersVisible = false;
            _entryDetailsDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _entryDetailsDataGrid.RowTemplate.Height = 40;
            _entryDetailsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _entryDetailsDataGrid.Size = new Size(541, 216);
            _entryDetailsDataGrid.TabIndex = 57;
            _entryDetailsDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // reasonLabel
            // 
            reasonLabel.BackColor = Color.PapayaWhip;
            reasonLabel.BorderColor = Color.White;
            reasonLabel.Edge = 50;
            reasonLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            reasonLabel.Location = new Point(59, 387);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Padding = new Padding(5);
            reasonLabel.Size = new Size(686, 105);
            reasonLabel.TabIndex = 112;
            reasonLabel.Text = "N/A";
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(981, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 46);
            _closeLabel.TabIndex = 114;
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
            Label12.Size = new Size(1029, 46);
            Label12.TabIndex = 113;
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Column6
            // 
            DataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            Column6.DefaultCellStyle = DataGridViewCellStyle15;
            Column6.FillWeight = 60.9197f;
            Column6.HeaderText = "Clock In";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.True;
            // 
            // Column1
            // 
            Column1.FillWeight = 71.14038f;
            Column1.HeaderText = "Clock Out";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 137.7865f;
            Column2.HeaderText = "Punched By";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 118.181f;
            Column4.HeaderText = "Modified Field";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 127.3232f;
            Column3.HeaderText = "Notes";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // Column5
            // 
            Column5.FillWeight = 75.70589f;
            Column5.HeaderText = "Site Location";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            // 
            // Column7
            // 
            Column7.FillWeight = 69.87342f;
            Column7.HeaderText = "Device Name";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Visible = false;
            // 
            // Column8
            // 
            Column8.FillWeight = 127.3232f;
            Column8.HeaderText = "Modification Date";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Visible = false;
            // 
            // Column9
            // 
            Column9.HeaderText = "type";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Visible = false;
            // 
            // Column10
            // 
            Column10.HeaderText = "punchType";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Visible = false;
            // 
            // Column11
            // 
            Column11.HeaderText = "jobDescription";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Visible = false;
            // 
            // FrmDetailedEntry
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 555);
            ControlBox = false;
            Controls.Add(_closeLabel);
            Controls.Add(Label12);
            Controls.Add(reasonLabel);
            Controls.Add(Panel4);
            Controls.Add(TableLayoutPanel4);
            Controls.Add(TableLayoutPanel3);
            Controls.Add(employeeNameLabel);
            Controls.Add(dateLabel);
            Controls.Add(Label9);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "FrmDetailedEntry";
            StartPosition = FormStartPosition.CenterParent;
            TableLayoutPanel3.ResumeLayout(false);
            TableLayoutPanel3.PerformLayout();
            TableLayoutPanel4.ResumeLayout(false);
            TableLayoutPanel4.PerformLayout();
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_entryDetailsDataGrid).EndInit();
            Load += new EventHandler(FrmDetailedEntry_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label employeeNameLabel;
        internal Label dateLabel;
        internal Label Label9;
        internal TableLayoutPanel TableLayoutPanel3;
        internal Label deviceNameLabel;
        internal Label siteLocationLabel;
        internal Label Label11;
        internal Label Label10;
        internal Label modifiedOnLabel;
        internal Label Label1;
        internal TableLayoutPanel TableLayoutPanel4;
        internal Label Label6;
        internal Panel Panel4;
        private Bunifu.UI.WinForms.BunifuDataGridView _entryDetailsDataGrid;

        public Bunifu.UI.WinForms.BunifuDataGridView entryDetailsDataGrid
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _entryDetailsDataGrid;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_entryDetailsDataGrid != null)
                {
                    _entryDetailsDataGrid.SelectionChanged -= entryDetailsDataGrid_SelectionChanged;
                }

                _entryDetailsDataGrid = value;
                if (_entryDetailsDataGrid != null)
                {
                    _entryDetailsDataGrid.SelectionChanged += entryDetailsDataGrid_SelectionChanged;
                }
            }
        }

        internal Label workDoneLabel;
        internal CustomizedControlsLibrary.ShapedLabel reasonLabel;
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
                    _closeLabel.MouseHover -= closeLabel_MouseHover;
                    _closeLabel.MouseLeave -= closeLabel_MouseLeave;
                    _closeLabel.Click -= closeLabel_Click;
                }

                _closeLabel = value;
                if (_closeLabel != null)
                {
                    _closeLabel.MouseHover += closeLabel_MouseHover;
                    _closeLabel.MouseLeave += closeLabel_MouseLeave;
                    _closeLabel.Click += closeLabel_Click;
                }
            }
        }

        internal Label Label12;
        internal DataGridViewTextBoxColumn Column6;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column7;
        internal DataGridViewTextBoxColumn Column8;
        internal DataGridViewTextBoxColumn Column9;
        internal DataGridViewTextBoxColumn Column10;
        internal DataGridViewTextBoxColumn Column11;
    }
}