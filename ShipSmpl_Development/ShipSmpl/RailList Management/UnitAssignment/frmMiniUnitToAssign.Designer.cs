using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmMiniUnitToAssign : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMiniUnitToAssign));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            Label12 = new Label();
            buttonsPanel = new TableLayoutPanel();
            _btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancel.Click += new EventHandler(btnCancel_Click_1);
            _btnAssignBooking = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAssignBooking.Click += new EventHandler(btnAssignBooking_Click);
            Label9 = new Label();
            Label3 = new Label();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            VWUnitSourceMiniUnitBindingSource = new BindingSource(components);
            dgvMiniUnit = new Bunifu.UI.WinForms.BunifuDataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            MiniUnitNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            CommodityGradeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            NumberOfContainer = new DataGridViewTextBoxColumn();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VWUnitSourceMiniUnitBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMiniUnit).BeginInit();
            SuspendLayout();
            // 
            // Label12
            // 
            Label12.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Dock = DockStyle.Top;
            Label12.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Location = new Point(0, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(677, 41);
            Label12.TabIndex = 142;
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.None;
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Controls.Add(_btnCancel, 1, 0);
            buttonsPanel.Controls.Add(_btnAssignBooking, 0, 0);
            buttonsPanel.Location = new Point(238, 457);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(217, 39);
            buttonsPanel.TabIndex = 170;
            // 
            // btnCancel
            // 
            _btnCancel.AllowToggling = false;
            _btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnCancel.AnimationSpeed = 200;
            _btnCancel.AutoGenerateColors = false;
            _btnCancel.BackColor = Color.Transparent;
            _btnCancel.BackColor1 = Color.White;
            _btnCancel.BackgroundImage = (Image)resources.GetObject("btnCancel.BackgroundImage");
            _btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnCancel.ButtonText = "Cancel";
            _btnCancel.ButtonTextMarginLeft = 0;
            _btnCancel.ColorContrastOnClick = 45;
            _btnCancel.ColorContrastOnHover = 45;
            _btnCancel.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnCancel.CustomizableEdges = BorderEdges1;
            _btnCancel.DialogResult = DialogResult.None;
            _btnCancel.DisabledBorderColor = Color.Empty;
            _btnCancel.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnCancel.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnCancel.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCancel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _btnCancel.IconLeftCursor = Cursors.Hand;
            _btnCancel.IconMarginLeft = 11;
            _btnCancel.IconPadding = 10;
            _btnCancel.IconRightCursor = Cursors.Hand;
            _btnCancel.IdleBorderColor = Color.Gray;
            _btnCancel.IdleBorderRadius = 3;
            _btnCancel.IdleBorderThickness = 1;
            _btnCancel.IdleFillColor = Color.White;
            _btnCancel.IdleIconLeftImage = null;
            _btnCancel.IdleIconRightImage = null;
            _btnCancel.IndicateFocus = true;
            _btnCancel.Location = new Point(111, 3);
            _btnCancel.Name = "_btnCancel";
            StateProperties1.BorderColor = Color.DarkGray;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.DarkGray;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnCancel.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.White;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnCancel.OnPressedState = StateProperties2;
            _btnCancel.Size = new Size(103, 33);
            _btnCancel.TabIndex = 137;
            _btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancel.TextMarginLeft = 0;
            _btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // btnAssignBooking
            // 
            _btnAssignBooking.AllowToggling = false;
            _btnAssignBooking.AnimationSpeed = 200;
            _btnAssignBooking.AutoGenerateColors = false;
            _btnAssignBooking.BackColor = Color.Transparent;
            _btnAssignBooking.BackColor1 = Color.Teal;
            _btnAssignBooking.BackgroundImage = (Image)resources.GetObject("btnAssignBooking.BackgroundImage");
            _btnAssignBooking.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAssignBooking.ButtonText = "Proceed";
            _btnAssignBooking.ButtonTextMarginLeft = 0;
            _btnAssignBooking.ColorContrastOnClick = 45;
            _btnAssignBooking.ColorContrastOnHover = 45;
            _btnAssignBooking.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnAssignBooking.CustomizableEdges = BorderEdges2;
            _btnAssignBooking.DialogResult = DialogResult.None;
            _btnAssignBooking.DisabledBorderColor = Color.Empty;
            _btnAssignBooking.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAssignBooking.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAssignBooking.Enabled = false;
            _btnAssignBooking.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAssignBooking.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAssignBooking.ForeColor = Color.White;
            _btnAssignBooking.IconLeftCursor = Cursors.Hand;
            _btnAssignBooking.IconMarginLeft = 11;
            _btnAssignBooking.IconPadding = 10;
            _btnAssignBooking.IconRightCursor = Cursors.Hand;
            _btnAssignBooking.IdleBorderColor = Color.Teal;
            _btnAssignBooking.IdleBorderRadius = 3;
            _btnAssignBooking.IdleBorderThickness = 1;
            _btnAssignBooking.IdleFillColor = Color.Teal;
            _btnAssignBooking.IdleIconLeftImage = null;
            _btnAssignBooking.IdleIconRightImage = null;
            _btnAssignBooking.IndicateFocus = true;
            _btnAssignBooking.Location = new Point(3, 3);
            _btnAssignBooking.Name = "_btnAssignBooking";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _btnAssignBooking.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _btnAssignBooking.OnPressedState = StateProperties4;
            _btnAssignBooking.Size = new Size(102, 33);
            _btnAssignBooking.TabIndex = 136;
            _btnAssignBooking.TextAlign = ContentAlignment.MiddleCenter;
            _btnAssignBooking.TextMarginLeft = 0;
            _btnAssignBooking.UseDefaultRadiusAndThickness = true;
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.None;
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label9.Location = new Point(9, 57);
            Label9.Margin = new Padding(0);
            Label9.Name = "Label9";
            Label9.Size = new Size(249, 21);
            Label9.TabIndex = 171;
            Label9.Text = "Choose MiniUnits to be assigned";
            Label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.None;
            Label3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(26, 78);
            Label3.Margin = new Padding(0);
            Label3.Name = "Label3";
            Label3.Size = new Size(626, 51);
            Label3.TabIndex = 172;
            Label3.Text = "The selected Units has mini units. Please, select the mini units you wish to assi" + "gn to the bookings.";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // closeFlatButton
            // 
            _closeFlatButton.Active = false;
            _closeFlatButton.Activecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeFlatButton.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.BackgroundImageLayout = ImageLayout.Stretch;
            _closeFlatButton.BorderRadius = 0;
            _closeFlatButton.ButtonText = "🗙";
            _closeFlatButton.Cursor = Cursors.Hand;
            _closeFlatButton.DisabledColor = Color.Gray;
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
            _closeFlatButton.Location = new Point(634, 0);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(43, 41);
            _closeFlatButton.TabIndex = 173;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // VWUnitSourceMiniUnitBindingSource
            // 
            VWUnitSourceMiniUnitBindingSource.DataSource = typeof(ModelLayer.VW_UnitSourceMiniUnit);
            // 
            // dgvMiniUnit
            // 
            dgvMiniUnit.AllowCustomTheming = true;
            dgvMiniUnit.AllowUserToAddRows = false;
            dgvMiniUnit.AllowUserToDeleteRows = false;
            dgvMiniUnit.AllowUserToOrderColumns = true;
            dgvMiniUnit.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvMiniUnit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dgvMiniUnit.AutoGenerateColumns = false;
            dgvMiniUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMiniUnit.BackgroundColor = Color.White;
            dgvMiniUnit.BorderStyle = BorderStyle.None;
            dgvMiniUnit.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMiniUnit.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvMiniUnit.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMiniUnit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dgvMiniUnit.ColumnHeadersHeight = 30;
            dgvMiniUnit.Columns.AddRange(new DataGridViewColumn[] { Column1, MiniUnitNumberDataGridViewTextBoxColumn, CustomerName, CommodityGradeDataGridViewTextBoxColumn, NumberOfContainer });
            dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            dgvMiniUnit.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvMiniUnit.CurrentTheme.BackColor = Color.Snow;
            dgvMiniUnit.CurrentTheme.GridColor = Color.Gray;
            dgvMiniUnit.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvMiniUnit.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            dgvMiniUnit.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            dgvMiniUnit.CurrentTheme.Name = null;
            dgvMiniUnit.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            dgvMiniUnit.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            dgvMiniUnit.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            dgvMiniUnit.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            dgvMiniUnit.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dgvMiniUnit.DataSource = VWUnitSourceMiniUnitBindingSource;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMiniUnit.DefaultCellStyle = DataGridViewCellStyle3;
            dgvMiniUnit.EnableHeadersVisualStyles = false;
            dgvMiniUnit.GridColor = Color.Gray;
            dgvMiniUnit.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            dgvMiniUnit.HeaderBgColor = Color.Empty;
            dgvMiniUnit.HeaderForeColor = Color.White;
            dgvMiniUnit.Location = new Point(19, 132);
            dgvMiniUnit.MultiSelect = false;
            dgvMiniUnit.Name = "dgvMiniUnit";
            dgvMiniUnit.ReadOnly = true;
            dgvMiniUnit.RowHeadersVisible = false;
            dgvMiniUnit.RowHeadersWidth = 51;
            dgvMiniUnit.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgvMiniUnit.RowTemplate.Height = 30;
            dgvMiniUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMiniUnit.Size = new Size(646, 304);
            dgvMiniUnit.TabIndex = 175;
            dgvMiniUnit.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column1
            // 
            Column1.FillWeight = 17.07038f;
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // MiniUnitNumberDataGridViewTextBoxColumn
            // 
            MiniUnitNumberDataGridViewTextBoxColumn.DataPropertyName = "MiniUnitNumber";
            MiniUnitNumberDataGridViewTextBoxColumn.FillWeight = 105.0156f;
            MiniUnitNumberDataGridViewTextBoxColumn.HeaderText = "Unit Number";
            MiniUnitNumberDataGridViewTextBoxColumn.Name = "MiniUnitNumberDataGridViewTextBoxColumn";
            MiniUnitNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomerName
            // 
            CustomerName.DataPropertyName = "CustomerName";
            CustomerName.FillWeight = 105.0156f;
            CustomerName.HeaderText = "Customer Name";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // CommodityGradeDataGridViewTextBoxColumn
            // 
            CommodityGradeDataGridViewTextBoxColumn.DataPropertyName = "CommodityGrade";
            CommodityGradeDataGridViewTextBoxColumn.FillWeight = 105.0156f;
            CommodityGradeDataGridViewTextBoxColumn.HeaderText = "Grade/Commodity";
            CommodityGradeDataGridViewTextBoxColumn.Name = "CommodityGradeDataGridViewTextBoxColumn";
            CommodityGradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NumberOfContainer
            // 
            NumberOfContainer.DataPropertyName = "TotalBilledMU";
            NumberOfContainer.FillWeight = 88.24068f;
            NumberOfContainer.HeaderText = "Billed";
            NumberOfContainer.Name = "NumberOfContainer";
            NumberOfContainer.ReadOnly = true;
            // 
            // frmMiniUnitToAssign
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(677, 510);
            Controls.Add(dgvMiniUnit);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label3);
            Controls.Add(Label9);
            Controls.Add(buttonsPanel);
            Controls.Add(Label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMiniUnitToAssign";
            Text = "frmMiniUnitToAssign";
            buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VWUnitSourceMiniUnitBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMiniUnit).EndInit();
            Load += new EventHandler(frmMiniUnitToAssign_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label12;
        internal TableLayoutPanel buttonsPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnCancel;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCancel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCancel != null)
                {
                    _btnCancel.Click -= btnCancel_Click_1;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += btnCancel_Click_1;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAssignBooking;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAssignBooking
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAssignBooking;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAssignBooking != null)
                {
                    _btnAssignBooking.Click -= btnAssignBooking_Click;
                }

                _btnAssignBooking = value;
                if (_btnAssignBooking != null)
                {
                    _btnAssignBooking.Click += btnAssignBooking_Click;
                }
            }
        }

        internal Label Label9;
        internal Label Label3;
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

        internal BindingSource VWUnitSourceMiniUnitBindingSource;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvMiniUnit;
        internal DataGridViewCheckBoxColumn Column1;
        internal DataGridViewTextBoxColumn MiniUnitNumberDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CustomerName;
        internal DataGridViewTextBoxColumn CommodityGradeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn NumberOfContainer;
    }
}