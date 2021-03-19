using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAddMultipleUnits : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddMultipleUnits));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            ShapedPanel3 = new CustomizedControlsLibrary.ShapedPanel();
            _dgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgv.SelectionChanged += new EventHandler(dgvUnits_SelectionChanged);
            _dgv.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dgv_RowPostPaint);
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            UnitId = new DataGridViewTextBoxColumn();
            OrgUnitNumb = new DataGridViewTextBoxColumn();
            Label2 = new Label();
            Label5 = new Label();
            Label15 = new Label();
            _cboCustomer = new ComboBox();
            _cboCustomer.SelectedIndexChanged += new EventHandler(cboCustomer_SelectedIndexChanged);
            _nudTotalBilledWeight = new NumericUpDown();
            _nudTotalBilledWeight.KeyDown += new KeyEventHandler(nudTotalBilledWeight_KeyDown);
            Label56 = new Label();
            lblWeightUni = new Label();
            Label1 = new Label();
            _updateButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _updateButton.Click += new EventHandler(updateButton_Click);
            pnltotalBilled = new Panel();
            tblSelectedUnit = new Label();
            _cboCargoType = new ComboBox();
            _cboCargoType.SelectedIndexChanged += new EventHandler(cboCustomer_SelectedIndexChanged);
            _cboType = new ComboBox();
            _cboType.SelectedIndexChanged += new EventHandler(cboCustomer_SelectedIndexChanged);
            _tbCreateUnits = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _tbCreateUnits.Click += new EventHandler(tbCreateUnits_Click);
            _tbUnits = new RichTextBox();
            _tbUnits.TextChanged += new EventHandler(tbUnits_TextChanged);
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label12 = new Label();
            _cboCommodity = new ComboBox();
            _cboCommodity.TextChanged += new EventHandler(cboCustomer_SelectedIndexChanged);
            Label3 = new Label();
            _cboGrade = new ComboBox();
            _cboGrade.TextChanged += new EventHandler(cboCustomer_SelectedIndexChanged);
            Label6 = new Label();
            cboWeightUnit = new ComboBox();
            Label7 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            lblPasteUnits = new Label();
            lblWarning = new Label();
            lblFormat = new Label();
            TableLayoutPanel1 = new TableLayoutPanel();
            Label11 = new Label();
            Label4 = new Label();
            Label13 = new Label();
            VWUnitSourceMiniUnitBindingSource = new BindingSource(components);
            ShapedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_nudTotalBilledWeight).BeginInit();
            pnltotalBilled.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VWUnitSourceMiniUnitBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ShapedPanel3
            // 
            ShapedPanel3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            ShapedPanel3.BorderColor = Color.Gray;
            ShapedPanel3.Controls.Add(_dgv);
            ShapedPanel3.Edge = 2;
            ShapedPanel3.Location = new Point(451, 109);
            ShapedPanel3.Name = "ShapedPanel3";
            ShapedPanel3.Padding = new Padding(1);
            ShapedPanel3.Size = new Size(887, 485);
            ShapedPanel3.TabIndex = 140;
            // 
            // dgv
            // 
            _dgv.AllowCustomTheming = true;
            _dgv.AllowUserToAddRows = false;
            _dgv.AllowUserToDeleteRows = false;
            _dgv.AllowUserToOrderColumns = true;
            _dgv.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgv.BackgroundColor = Color.White;
            _dgv.BorderStyle = BorderStyle.None;
            _dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            _dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            _dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgv.ColumnHeadersHeight = 30;
            _dgv.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, UnitId, OrgUnitNumb });
            _dgv.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgv.CurrentTheme.AlternatingRowsStyle.Font = new Font("Arial", 9.5f);
            _dgv.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            _dgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgv.CurrentTheme.BackColor = Color.White;
            _dgv.CurrentTheme.GridColor = Color.Gainsboro;
            _dgv.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgv.CurrentTheme.HeaderStyle.Font = new Font("Arial", 11.0f, FontStyle.Bold);
            _dgv.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _dgv.CurrentTheme.Name = null;
            _dgv.CurrentTheme.RowsStyle.BackColor = Color.White;
            _dgv.CurrentTheme.RowsStyle.Font = new Font("Arial", 9.5f);
            _dgv.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgv.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            _dgv.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.White;
            DataGridViewCellStyle3.Font = new Font("Arial", 9.5f);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(192)));
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgv.DefaultCellStyle = DataGridViewCellStyle3;
            _dgv.Dock = DockStyle.Fill;
            _dgv.EnableHeadersVisualStyles = false;
            _dgv.GridColor = Color.Gainsboro;
            _dgv.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgv.HeaderBgColor = Color.Empty;
            _dgv.HeaderForeColor = Color.White;
            _dgv.Location = new Point(1, 1);
            _dgv.Name = "_dgv";
            _dgv.ReadOnly = true;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            _dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
            _dgv.RowHeadersVisible = false;
            _dgv.RowHeadersWidth = 29;
            DataGridViewCellStyle5.Font = new Font("Arial", 9.0f);
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgv.RowsDefaultCellStyle = DataGridViewCellStyle5;
            _dgv.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.0f);
            _dgv.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            _dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _dgv.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            _dgv.RowTemplate.Height = 27;
            _dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgv.Size = new Size(885, 483);
            _dgv.TabIndex = 229;
            _dgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn1.DataPropertyName = "UnitNumber";
            DataGridViewTextBoxColumn1.FillWeight = 99.49241f;
            DataGridViewTextBoxColumn1.HeaderText = "Unit Number";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn2.DataPropertyName = "CustomerName";
            DataGridViewTextBoxColumn2.FillWeight = 140.6067f;
            DataGridViewTextBoxColumn2.HeaderText = "Customer";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn3.DataPropertyName = "CommodityGrade";
            DataGridViewTextBoxColumn3.FillWeight = 91.98019f;
            DataGridViewTextBoxColumn3.HeaderText = "Commodity";
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn4.DataPropertyName = "CargoType";
            DataGridViewTextBoxColumn4.FillWeight = 91.98019f;
            DataGridViewTextBoxColumn4.HeaderText = "Cargo Type";
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn5.DataPropertyName = "UnitStatus";
            DataGridViewTextBoxColumn5.FillWeight = 91.98019f;
            DataGridViewTextBoxColumn5.HeaderText = "Unit Status";
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn6.DataPropertyName = "UnitType";
            DataGridViewTextBoxColumn6.FillWeight = 91.98019f;
            DataGridViewTextBoxColumn6.HeaderText = "Unit Type";
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            DataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn7
            // 
            DataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn7.DataPropertyName = "TotalBilled";
            DataGridViewTextBoxColumn7.FillWeight = 91.98019f;
            DataGridViewTextBoxColumn7.HeaderText = "Total Billed";
            DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            DataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // UnitId
            // 
            UnitId.HeaderText = "UnitId";
            UnitId.Name = "UnitId";
            UnitId.ReadOnly = true;
            UnitId.Visible = false;
            // 
            // OrgUnitNumb
            // 
            OrgUnitNumb.HeaderText = "OriginalUnitNumber";
            OrgUnitNumb.Name = "OrgUnitNumb";
            OrgUnitNumb.ReadOnly = true;
            OrgUnitNumb.Visible = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(13, 318);
            Label2.Name = "Label2";
            Label2.Size = new Size(122, 21);
            Label2.TabIndex = 211;
            Label2.Text = "Unit Numbers: *";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label5.Location = new Point(34, 145);
            Label5.Name = "Label5";
            Label5.Size = new Size(101, 21);
            Label5.TabIndex = 212;
            Label5.Text = "Unit Type:    *";
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label15.Location = new Point(33, 179);
            Label15.Name = "Label15";
            Label15.Size = new Size(102, 21);
            Label15.TabIndex = 214;
            Label15.Text = "Cargo Type: *";
            // 
            // cboCustomer
            // 
            _cboCustomer.AutoCompleteMode = AutoCompleteMode.Append;
            _cboCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboCustomer.DisplayMember = "CompanyName";
            _cboCustomer.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboCustomer.FormattingEnabled = true;
            _cboCustomer.Location = new Point(141, 109);
            _cboCustomer.Name = "_cboCustomer";
            _cboCustomer.Size = new Size(292, 28);
            _cboCustomer.TabIndex = 218;
            _cboCustomer.ValueMember = "CompanyId";
            // 
            // nudTotalBilledWeight
            // 
            _nudTotalBilledWeight.Anchor = AnchorStyles.Left;
            _nudTotalBilledWeight.DecimalPlaces = 3;
            _nudTotalBilledWeight.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _nudTotalBilledWeight.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _nudTotalBilledWeight.Location = new Point(17, 57);
            _nudTotalBilledWeight.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            _nudTotalBilledWeight.Name = "_nudTotalBilledWeight";
            _nudTotalBilledWeight.Size = new Size(117, 29);
            _nudTotalBilledWeight.TabIndex = 207;
            _nudTotalBilledWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // Label56
            // 
            Label56.AutoSize = true;
            Label56.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label56.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label56.Location = new Point(13, 26);
            Label56.Name = "Label56";
            Label56.Size = new Size(140, 21);
            Label56.TabIndex = 215;
            Label56.Text = "Total Billed Weight:";
            Label56.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWeightUni
            // 
            lblWeightUni.Anchor = AnchorStyles.Left;
            lblWeightUni.AutoSize = true;
            lblWeightUni.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWeightUni.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblWeightUni.Location = new Point(135, 59);
            lblWeightUni.Name = "lblWeightUni";
            lblWeightUni.Size = new Size(32, 21);
            lblWeightUni.TabIndex = 217;
            lblWeightUni.Text = "MT";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(43, 111);
            Label1.Name = "Label1";
            Label1.Size = new Size(92, 21);
            Label1.TabIndex = 219;
            Label1.Text = "Customer: *";
            // 
            // updateButton
            // 
            _updateButton.AllowToggling = false;
            _updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _updateButton.AnimationSpeed = 200;
            _updateButton.AutoGenerateColors = false;
            _updateButton.BackColor = Color.Transparent;
            _updateButton.BackColor1 = Color.Teal;
            _updateButton.BackgroundImage = (Image)resources.GetObject("updateButton.BackgroundImage");
            _updateButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _updateButton.ButtonText = "Update " + '\r' + '\n' + "Info";
            _updateButton.ButtonTextMarginLeft = 0;
            _updateButton.ColorContrastOnClick = 45;
            _updateButton.ColorContrastOnHover = 45;
            _updateButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _updateButton.CustomizableEdges = BorderEdges1;
            _updateButton.DialogResult = DialogResult.None;
            _updateButton.DisabledBorderColor = Color.Empty;
            _updateButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _updateButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _updateButton.Enabled = false;
            _updateButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _updateButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _updateButton.ForeColor = Color.White;
            _updateButton.IconLeftCursor = Cursors.Hand;
            _updateButton.IconMarginLeft = 11;
            _updateButton.IconPadding = 10;
            _updateButton.IconRightCursor = Cursors.Hand;
            _updateButton.IdleBorderColor = Color.Teal;
            _updateButton.IdleBorderRadius = 3;
            _updateButton.IdleBorderThickness = 1;
            _updateButton.IdleFillColor = Color.Teal;
            _updateButton.IdleIconLeftImage = null;
            _updateButton.IdleIconRightImage = null;
            _updateButton.IndicateFocus = true;
            _updateButton.Location = new Point(25, 113);
            _updateButton.Name = "_updateButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _updateButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _updateButton.OnPressedState = StateProperties2;
            _updateButton.Size = new Size(115, 49);
            _updateButton.TabIndex = 220;
            _updateButton.TextAlign = ContentAlignment.MiddleCenter;
            _updateButton.TextMarginLeft = 0;
            _updateButton.UseDefaultRadiusAndThickness = true;
            // 
            // pnltotalBilled
            // 
            pnltotalBilled.BorderStyle = BorderStyle.FixedSingle;
            pnltotalBilled.Controls.Add(tblSelectedUnit);
            pnltotalBilled.Controls.Add(Label56);
            pnltotalBilled.Controls.Add(_updateButton);
            pnltotalBilled.Controls.Add(_nudTotalBilledWeight);
            pnltotalBilled.Controls.Add(lblWeightUni);
            pnltotalBilled.Location = new Point(1344, 216);
            pnltotalBilled.Name = "pnltotalBilled";
            pnltotalBilled.Size = new Size(177, 178);
            pnltotalBilled.TabIndex = 221;
            // 
            // tblSelectedUnit
            // 
            tblSelectedUnit.AutoSize = true;
            tblSelectedUnit.Font = new Font("Segoe UI", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            tblSelectedUnit.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            tblSelectedUnit.Location = new Point(21, 29);
            tblSelectedUnit.Name = "tblSelectedUnit";
            tblSelectedUnit.Size = new Size(0, 21);
            tblSelectedUnit.TabIndex = 221;
            tblSelectedUnit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboCargoType
            // 
            _cboCargoType.AutoCompleteMode = AutoCompleteMode.Append;
            _cboCargoType.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboCargoType.DisplayMember = "CompanyName";
            _cboCargoType.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboCargoType.FormattingEnabled = true;
            _cboCargoType.Location = new Point(141, 177);
            _cboCargoType.Name = "_cboCargoType";
            _cboCargoType.Size = new Size(194, 28);
            _cboCargoType.TabIndex = 223;
            _cboCargoType.ValueMember = "CompanyId";
            // 
            // cboType
            // 
            _cboType.AutoCompleteMode = AutoCompleteMode.Append;
            _cboType.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboType.DisplayMember = "CompanyName";
            _cboType.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboType.FormattingEnabled = true;
            _cboType.Location = new Point(141, 143);
            _cboType.Name = "_cboType";
            _cboType.Size = new Size(194, 28);
            _cboType.TabIndex = 224;
            _cboType.ValueMember = "CompanyId";
            // 
            // tbCreateUnits
            // 
            _tbCreateUnits.AllowToggling = false;
            _tbCreateUnits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _tbCreateUnits.AnimationSpeed = 200;
            _tbCreateUnits.AutoGenerateColors = false;
            _tbCreateUnits.BackColor = Color.Transparent;
            _tbCreateUnits.BackColor1 = Color.Teal;
            _tbCreateUnits.BackgroundImage = (Image)resources.GetObject("tbCreateUnits.BackgroundImage");
            _tbCreateUnits.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _tbCreateUnits.ButtonText = "Update Units";
            _tbCreateUnits.ButtonTextMarginLeft = 0;
            _tbCreateUnits.ColorContrastOnClick = 45;
            _tbCreateUnits.ColorContrastOnHover = 45;
            _tbCreateUnits.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _tbCreateUnits.CustomizableEdges = BorderEdges2;
            _tbCreateUnits.DialogResult = DialogResult.None;
            _tbCreateUnits.DisabledBorderColor = Color.Empty;
            _tbCreateUnits.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _tbCreateUnits.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _tbCreateUnits.Enabled = false;
            _tbCreateUnits.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _tbCreateUnits.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _tbCreateUnits.ForeColor = Color.White;
            _tbCreateUnits.IconLeftCursor = Cursors.Hand;
            _tbCreateUnits.IconMarginLeft = 11;
            _tbCreateUnits.IconPadding = 10;
            _tbCreateUnits.IconRightCursor = Cursors.Hand;
            _tbCreateUnits.IdleBorderColor = Color.Teal;
            _tbCreateUnits.IdleBorderRadius = 3;
            _tbCreateUnits.IdleBorderThickness = 1;
            _tbCreateUnits.IdleFillColor = Color.Teal;
            _tbCreateUnits.IdleIconLeftImage = null;
            _tbCreateUnits.IdleIconRightImage = null;
            _tbCreateUnits.IndicateFocus = true;
            _tbCreateUnits.Location = new Point(703, 654);
            _tbCreateUnits.Name = "_tbCreateUnits";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _tbCreateUnits.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _tbCreateUnits.OnPressedState = StateProperties4;
            _tbCreateUnits.Size = new Size(113, 35);
            _tbCreateUnits.TabIndex = 225;
            _tbCreateUnits.TextAlign = ContentAlignment.MiddleCenter;
            _tbCreateUnits.TextMarginLeft = 0;
            _tbCreateUnits.UseDefaultRadiusAndThickness = true;
            // 
            // tbUnits
            // 
            _tbUnits.BackColor = Color.White;
            _tbUnits.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _tbUnits.Location = new Point(131, 318);
            _tbUnits.Name = "_tbUnits";
            _tbUnits.Size = new Size(266, 276);
            _tbUnits.TabIndex = 226;
            _tbUnits.Text = "";
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(1496, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 37);
            _closeLabel.TabIndex = 228;
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
            Label12.Size = new Size(1544, 37);
            Label12.TabIndex = 227;
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboCommodity
            // 
            _cboCommodity.AutoCompleteMode = AutoCompleteMode.Append;
            _cboCommodity.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboCommodity.DisplayMember = "CompanyName";
            _cboCommodity.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboCommodity.FormattingEnabled = true;
            _cboCommodity.Location = new Point(141, 244);
            _cboCommodity.Name = "_cboCommodity";
            _cboCommodity.Size = new Size(194, 28);
            _cboCommodity.TabIndex = 230;
            _cboCommodity.ValueMember = "CompanyId";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(25, 251);
            Label3.Name = "Label3";
            Label3.Size = new Size(110, 21);
            Label3.TabIndex = 229;
            Label3.Text = "Commodity:  *";
            // 
            // cboGrade
            // 
            _cboGrade.AutoCompleteMode = AutoCompleteMode.Append;
            _cboGrade.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboGrade.DisplayMember = "CompanyName";
            _cboGrade.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboGrade.FormattingEnabled = true;
            _cboGrade.Location = new Point(141, 278);
            _cboGrade.Name = "_cboGrade";
            _cboGrade.Size = new Size(194, 28);
            _cboGrade.TabIndex = 232;
            _cboGrade.ValueMember = "CompanyId";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label6.Location = new Point(65, 283);
            Label6.Name = "Label6";
            Label6.Size = new Size(59, 21);
            Label6.TabIndex = 231;
            Label6.Text = "Grade: ";
            // 
            // cboWeightUnit
            // 
            cboWeightUnit.AutoCompleteMode = AutoCompleteMode.Append;
            cboWeightUnit.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboWeightUnit.DisplayMember = "CompanyName";
            cboWeightUnit.Font = new Font("Microsoft Sans Serif", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboWeightUnit.FormattingEnabled = true;
            cboWeightUnit.Location = new Point(141, 211);
            cboWeightUnit.Name = "cboWeightUnit";
            cboWeightUnit.Size = new Size(194, 28);
            cboWeightUnit.TabIndex = 234;
            cboWeightUnit.ValueMember = "CompanyId";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Location = new Point(29, 213);
            Label7.Name = "Label7";
            Label7.Size = new Size(106, 21);
            Label7.TabIndex = 233;
            Label7.Text = "Weight Unit: *";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI", 14.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label8.Location = new Point(24, 63);
            Label8.Name = "Label8";
            Label8.Size = new Size(199, 25);
            Label8.TabIndex = 235;
            Label8.Text = "Create Multiple Units";
            Label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label9.Location = new Point(1347, 188);
            Label9.Name = "Label9";
            Label9.Size = new Size(165, 25);
            Label9.TabIndex = 236;
            Label9.Text = "Edit Billed Weight";
            Label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label10.Location = new Point(457, 597);
            Label10.Name = "Label10";
            Label10.Size = new Size(447, 19);
            Label10.TabIndex = 237;
            Label10.Text = "Press Ctrl and click units to select and edit billed values of multiple units";
            // 
            // lblPasteUnits
            // 
            lblPasteUnits.AutoSize = true;
            lblPasteUnits.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblPasteUnits.ForeColor = Color.DarkGray;
            lblPasteUnits.Location = new Point(175, 444);
            lblPasteUnits.Name = "lblPasteUnits";
            lblPasteUnits.Size = new Size(178, 21);
            lblPasteUnits.TabIndex = 238;
            lblPasteUnits.Text = "Paste unit numbers here";
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWarning.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblWarning.Location = new Point(702, 67);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 21);
            lblWarning.TabIndex = 239;
            // 
            // lblFormat
            // 
            lblFormat.AutoSize = true;
            lblFormat.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblFormat.ForeColor = Color.DarkGray;
            lblFormat.Location = new Point(144, 465);
            lblFormat.Name = "lblFormat";
            lblFormat.Size = new Size(235, 21);
            lblFormat.TabIndex = 240;
            lblFormat.Text = "Format: UNITNUMBER | WEIGHT";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.250825f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.74918f));
            TableLayoutPanel1.Controls.Add(Label11, 0, 0);
            TableLayoutPanel1.Controls.Add(Label4, 0, 0);
            TableLayoutPanel1.Controls.Add(Label13, 1, 1);
            TableLayoutPanel1.Location = new Point(975, 597);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62.0f));
            TableLayoutPanel1.Size = new Size(362, 82);
            TableLayoutPanel1.TabIndex = 241;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Segoe UI", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label11.Location = new Point(32, 0);
            Label11.Name = "Label11";
            Label11.Size = new Size(323, 19);
            Label11.TabIndex = 239;
            Label11.Text = "- Unit already exist and information will be updated";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Goldenrod;
            Label4.Dock = DockStyle.Fill;
            Label4.Font = new Font("Segoe UI", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label4.Location = new Point(3, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(23, 20);
            Label4.TabIndex = 238;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Segoe UI", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label13.Location = new Point(32, 20);
            Label13.Name = "Label13";
            Label13.Size = new Size(324, 57);
            Label13.TabIndex = 240;
            Label13.Text = "Attention: If more than one mini unit exists for the unit, you might need to upda" + "te the miniunit billing balance";
            // 
            // VWUnitSourceMiniUnitBindingSource
            // 
            VWUnitSourceMiniUnitBindingSource.DataSource = typeof(ModelLayer.VW_UnitSourceMiniUnit);
            // 
            // FrmAddMultipleUnits
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.White;
            ClientSize = new Size(1544, 701);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(lblFormat);
            Controls.Add(lblWarning);
            Controls.Add(lblPasteUnits);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(cboWeightUnit);
            Controls.Add(Label7);
            Controls.Add(_cboGrade);
            Controls.Add(Label6);
            Controls.Add(_cboCommodity);
            Controls.Add(Label3);
            Controls.Add(_closeLabel);
            Controls.Add(Label12);
            Controls.Add(_tbUnits);
            Controls.Add(_tbCreateUnits);
            Controls.Add(_cboType);
            Controls.Add(_cboCargoType);
            Controls.Add(pnltotalBilled);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Controls.Add(Label5);
            Controls.Add(Label15);
            Controls.Add(_cboCustomer);
            Controls.Add(ShapedPanel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddMultipleUnits";
            Text = "AddMultipleUnits";
            ShapedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)_nudTotalBilledWeight).EndInit();
            pnltotalBilled.ResumeLayout(false);
            pnltotalBilled.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VWUnitSourceMiniUnitBindingSource).EndInit();
            Load += new EventHandler(FrmAddMultipleUnits_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal CustomizedControlsLibrary.ShapedPanel ShapedPanel3;
        internal Label Label2;
        internal Label Label5;
        internal Label Label15;
        private ComboBox _cboCustomer;

        internal ComboBox cboCustomer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboCustomer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboCustomer != null)
                {
                    _cboCustomer.SelectedIndexChanged -= cboCustomer_SelectedIndexChanged;
                }

                _cboCustomer = value;
                if (_cboCustomer != null)
                {
                    _cboCustomer.SelectedIndexChanged += cboCustomer_SelectedIndexChanged;
                }
            }
        }

        private NumericUpDown _nudTotalBilledWeight;

        internal NumericUpDown nudTotalBilledWeight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _nudTotalBilledWeight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudTotalBilledWeight != null)
                {
                    _nudTotalBilledWeight.KeyDown -= nudTotalBilledWeight_KeyDown;
                }

                _nudTotalBilledWeight = value;
                if (_nudTotalBilledWeight != null)
                {
                    _nudTotalBilledWeight.KeyDown += nudTotalBilledWeight_KeyDown;
                }
            }
        }

        internal Label Label56;
        internal Label lblWeightUni;
        internal Label Label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _updateButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton updateButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _updateButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_updateButton != null)
                {
                    _updateButton.Click -= updateButton_Click;
                }

                _updateButton = value;
                if (_updateButton != null)
                {
                    _updateButton.Click += updateButton_Click;
                }
            }
        }

        internal Panel pnltotalBilled;
        internal Label tblSelectedUnit;
        private ComboBox _cboCargoType;

        internal ComboBox cboCargoType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboCargoType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboCargoType != null)
                {
                    _cboCargoType.SelectedIndexChanged -= cboCustomer_SelectedIndexChanged;
                }

                _cboCargoType = value;
                if (_cboCargoType != null)
                {
                    _cboCargoType.SelectedIndexChanged += cboCustomer_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _cboType;

        internal ComboBox cboType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboType != null)
                {
                    _cboType.SelectedIndexChanged -= cboCustomer_SelectedIndexChanged;
                }

                _cboType = value;
                if (_cboType != null)
                {
                    _cboType.SelectedIndexChanged += cboCustomer_SelectedIndexChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _tbCreateUnits;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton tbCreateUnits
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbCreateUnits;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbCreateUnits != null)
                {
                    _tbCreateUnits.Click -= tbCreateUnits_Click;
                }

                _tbCreateUnits = value;
                if (_tbCreateUnits != null)
                {
                    _tbCreateUnits.Click += tbCreateUnits_Click;
                }
            }
        }

        private RichTextBox _tbUnits;

        internal RichTextBox tbUnits
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbUnits;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbUnits != null)
                {
                    _tbUnits.TextChanged -= tbUnits_TextChanged;
                }

                _tbUnits = value;
                if (_tbUnits != null)
                {
                    _tbUnits.TextChanged += tbUnits_TextChanged;
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
        private Bunifu.UI.WinForms.BunifuDataGridView _dgv;

        public Bunifu.UI.WinForms.BunifuDataGridView dgv
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgv;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgv != null)
                {
                    _dgv.SelectionChanged -= dgvUnits_SelectionChanged;
                    _dgv.RowPostPaint -= dgv_RowPostPaint;
                }

                _dgv = value;
                if (_dgv != null)
                {
                    _dgv.SelectionChanged += dgvUnits_SelectionChanged;
                    _dgv.RowPostPaint += dgv_RowPostPaint;
                }
            }
        }

        internal BindingSource VWUnitSourceMiniUnitBindingSource;
        private ComboBox _cboCommodity;

        internal ComboBox cboCommodity
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboCommodity;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboCommodity != null)
                {
                    _cboCommodity.TextChanged -= cboCustomer_SelectedIndexChanged;
                }

                _cboCommodity = value;
                if (_cboCommodity != null)
                {
                    _cboCommodity.TextChanged += cboCustomer_SelectedIndexChanged;
                }
            }
        }

        internal Label Label3;
        private ComboBox _cboGrade;

        internal ComboBox cboGrade
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboGrade;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboGrade != null)
                {
                    _cboGrade.TextChanged -= cboCustomer_SelectedIndexChanged;
                }

                _cboGrade = value;
                if (_cboGrade != null)
                {
                    _cboGrade.TextChanged += cboCustomer_SelectedIndexChanged;
                }
            }
        }

        internal Label Label6;
        internal ComboBox cboWeightUnit;
        internal Label Label7;
        internal Label Label8;
        internal Label Label9;
        internal Label Label10;
        internal Label lblPasteUnits;
        internal Label lblWarning;
        internal Label lblFormat;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Label Label11;
        internal Label Label4;
        internal Label Label13;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal DataGridViewTextBoxColumn UnitId;
        internal DataGridViewTextBoxColumn OrgUnitNumb;
    }
}