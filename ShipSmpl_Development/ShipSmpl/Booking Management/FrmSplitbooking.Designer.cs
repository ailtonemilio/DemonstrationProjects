using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmSplitbooking : Form
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
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplitbooking));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            titleLabel = new Label();
            BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            _dgvCansToTransfer = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvCansToTransfer.CellContentClick += new DataGridViewCellEventHandler(dgvCansToTransfer_CellContentClick);
            UniqueIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewCheckBoxColumn();
            ContainerNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ContainerSizeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            GateDateInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            MiniBookingNumber = new DataGridViewTextBoxColumn();
            MiniBookingId = new DataGridViewTextBoxColumn();
            VWContainersByBookingBindingSource = new BindingSource(components);
            buttonsPanel = new TableLayoutPanel();
            _transferButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _transferButton.Click += new EventHandler(yesButton_Click);
            _btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancel.Click += new EventHandler(noButton_Click);
            BunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            _dgvCansAsnMb = new Bunifu.UI.WinForms.BunifuDataGridView();
            _dgvCansAsnMb.CellContentClick += new DataGridViewCellEventHandler(dgvCansAsnMb_CellContentClick);
            CanId = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            cboMinibooking = new ComboBox();
            _btnAsnToMb = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnAsnToMb.Click += new EventHandler(btnAsnToMb_Click);
            _btnRmvFromMb = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnRmvFromMb.Click += new EventHandler(btnRmvFromMb_Click);
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)_dgvCansToTransfer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWContainersByBookingBindingSource).BeginInit();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvCansAsnMb).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titleLabel.Location = new Point(12, 17);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(453, 29);
            titleLabel.TabIndex = 176;
            titleLabel.Text = "Select the containers to be transferred to the new booking";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BunifuElipse1
            // 
            BunifuElipse1.ElipseRadius = 30;
            BunifuElipse1.TargetControl = this;
            // 
            // dgvCansToTransfer
            // 
            _dgvCansToTransfer.AllowCustomTheming = true;
            _dgvCansToTransfer.AllowUserToAddRows = false;
            _dgvCansToTransfer.AllowUserToDeleteRows = false;
            _dgvCansToTransfer.AllowUserToOrderColumns = true;
            _dgvCansToTransfer.AllowUserToResizeRows = false;
            DataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewCellStyle4.ForeColor = Color.Black;
            DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvCansToTransfer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
            _dgvCansToTransfer.AutoGenerateColumns = false;
            _dgvCansToTransfer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvCansToTransfer.BackgroundColor = Color.White;
            _dgvCansToTransfer.BorderStyle = BorderStyle.None;
            _dgvCansToTransfer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvCansToTransfer.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            _dgvCansToTransfer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            DataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            _dgvCansToTransfer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            _dgvCansToTransfer.ColumnHeadersHeight = 30;
            _dgvCansToTransfer.Columns.AddRange(new DataGridViewColumn[] { UniqueIDDataGridViewTextBoxColumn, Column1, ContainerNumberDataGridViewTextBoxColumn, ContainerSizeDataGridViewTextBoxColumn1, GateDateInDataGridViewTextBoxColumn, MiniBookingNumber, MiniBookingId });
            _dgvCansToTransfer.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvCansToTransfer.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvCansToTransfer.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvCansToTransfer.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.LightGray;
            _dgvCansToTransfer.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvCansToTransfer.CurrentTheme.BackColor = Color.Snow;
            _dgvCansToTransfer.CurrentTheme.GridColor = Color.Gainsboro;
            _dgvCansToTransfer.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvCansToTransfer.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _dgvCansToTransfer.CurrentTheme.HeaderStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvCansToTransfer.CurrentTheme.Name = null;
            _dgvCansToTransfer.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvCansToTransfer.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvCansToTransfer.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvCansToTransfer.CurrentTheme.RowsStyle.SelectionBackColor = SystemColors.MenuBar;
            _dgvCansToTransfer.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _dgvCansToTransfer.DataSource = VWContainersByBookingBindingSource;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle6.ForeColor = Color.Black;
            DataGridViewCellStyle6.SelectionBackColor = SystemColors.MenuBar;
            DataGridViewCellStyle6.SelectionForeColor = Color.Black;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            _dgvCansToTransfer.DefaultCellStyle = DataGridViewCellStyle6;
            _dgvCansToTransfer.EnableHeadersVisualStyles = false;
            _dgvCansToTransfer.GridColor = Color.Gainsboro;
            _dgvCansToTransfer.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvCansToTransfer.HeaderBgColor = Color.Empty;
            _dgvCansToTransfer.HeaderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvCansToTransfer.Location = new Point(28, 49);
            _dgvCansToTransfer.Name = "_dgvCansToTransfer";
            _dgvCansToTransfer.ReadOnly = true;
            _dgvCansToTransfer.RowHeadersVisible = false;
            _dgvCansToTransfer.RowHeadersWidth = 30;
            _dgvCansToTransfer.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            _dgvCansToTransfer.RowTemplate.Height = 30;
            _dgvCansToTransfer.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _dgvCansToTransfer.Size = new Size(430, 356);
            _dgvCansToTransfer.TabIndex = 57;
            _dgvCansToTransfer.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // UniqueIDDataGridViewTextBoxColumn
            // 
            UniqueIDDataGridViewTextBoxColumn.DataPropertyName = "Unique_ID";
            UniqueIDDataGridViewTextBoxColumn.HeaderText = "Unique_ID";
            UniqueIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            UniqueIDDataGridViewTextBoxColumn.Name = "UniqueIDDataGridViewTextBoxColumn";
            UniqueIDDataGridViewTextBoxColumn.ReadOnly = true;
            UniqueIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            Column1.FillWeight = 34.78053f;
            Column1.HeaderText = "";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            Column1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ContainerNumberDataGridViewTextBoxColumn
            // 
            ContainerNumberDataGridViewTextBoxColumn.DataPropertyName = "Container_Number";
            ContainerNumberDataGridViewTextBoxColumn.FillWeight = 117.3843f;
            ContainerNumberDataGridViewTextBoxColumn.HeaderText = "Container #";
            ContainerNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            ContainerNumberDataGridViewTextBoxColumn.Name = "ContainerNumberDataGridViewTextBoxColumn";
            ContainerNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ContainerSizeDataGridViewTextBoxColumn1
            // 
            ContainerSizeDataGridViewTextBoxColumn1.DataPropertyName = "ContainerSize";
            ContainerSizeDataGridViewTextBoxColumn1.FillWeight = 60.9137f;
            ContainerSizeDataGridViewTextBoxColumn1.HeaderText = "Size";
            ContainerSizeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            ContainerSizeDataGridViewTextBoxColumn1.Name = "ContainerSizeDataGridViewTextBoxColumn1";
            ContainerSizeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // GateDateInDataGridViewTextBoxColumn
            // 
            GateDateInDataGridViewTextBoxColumn.DataPropertyName = "Gate_Date_In";
            GateDateInDataGridViewTextBoxColumn.FillWeight = 117.3843f;
            GateDateInDataGridViewTextBoxColumn.HeaderText = "Gate Date";
            GateDateInDataGridViewTextBoxColumn.MinimumWidth = 6;
            GateDateInDataGridViewTextBoxColumn.Name = "GateDateInDataGridViewTextBoxColumn";
            GateDateInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MiniBookingNumber
            // 
            MiniBookingNumber.DataPropertyName = "MiniBookingNumber";
            MiniBookingNumber.FillWeight = 117.3843f;
            MiniBookingNumber.HeaderText = "MB Number";
            MiniBookingNumber.MinimumWidth = 6;
            MiniBookingNumber.Name = "MiniBookingNumber";
            MiniBookingNumber.ReadOnly = true;
            // 
            // MiniBookingId
            // 
            MiniBookingId.DataPropertyName = "MiniBookingId";
            MiniBookingId.HeaderText = "MiniBookingId";
            MiniBookingId.MinimumWidth = 6;
            MiniBookingId.Name = "MiniBookingId";
            MiniBookingId.ReadOnly = true;
            MiniBookingId.Visible = false;
            // 
            // VWContainersByBookingBindingSource
            // 
            VWContainersByBookingBindingSource.DataSource = typeof(ModelLayer.VW_ContainersByBooking);
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.None;
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.33929f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.66071f));
            buttonsPanel.Controls.Add(_transferButton, 0, 0);
            buttonsPanel.Controls.Add(_btnCancel, 1, 0);
            buttonsPanel.Location = new Point(135, 427);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(202, 39);
            buttonsPanel.TabIndex = 180;
            // 
            // transferButton
            // 
            _transferButton.AllowToggling = false;
            _transferButton.AnimationSpeed = 200;
            _transferButton.AutoGenerateColors = false;
            _transferButton.BackColor = Color.Transparent;
            _transferButton.BackColor1 = Color.Teal;
            _transferButton.BackgroundImage = (Image)resources.GetObject("transferButton.BackgroundImage");
            _transferButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _transferButton.ButtonText = "OK";
            _transferButton.ButtonTextMarginLeft = 0;
            _transferButton.ColorContrastOnClick = 45;
            _transferButton.ColorContrastOnHover = 45;
            _transferButton.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _transferButton.CustomizableEdges = BorderEdges3;
            _transferButton.DialogResult = DialogResult.None;
            _transferButton.DisabledBorderColor = Color.Empty;
            _transferButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _transferButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _transferButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _transferButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _transferButton.ForeColor = Color.White;
            _transferButton.IconLeftCursor = Cursors.Hand;
            _transferButton.IconMarginLeft = 11;
            _transferButton.IconPadding = 10;
            _transferButton.IconRightCursor = Cursors.Hand;
            _transferButton.IdleBorderColor = Color.Teal;
            _transferButton.IdleBorderRadius = 3;
            _transferButton.IdleBorderThickness = 1;
            _transferButton.IdleFillColor = Color.Teal;
            _transferButton.IdleIconLeftImage = null;
            _transferButton.IdleIconRightImage = null;
            _transferButton.IndicateFocus = true;
            _transferButton.Location = new Point(3, 3);
            _transferButton.Name = "_transferButton";
            StateProperties5.BorderColor = Color.MediumTurquoise;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.MediumTurquoise;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _transferButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Teal;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Teal;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _transferButton.OnPressedState = StateProperties6;
            _transferButton.Size = new Size(97, 32);
            _transferButton.TabIndex = 136;
            _transferButton.TextAlign = ContentAlignment.MiddleCenter;
            _transferButton.TextMarginLeft = 0;
            _transferButton.UseDefaultRadiusAndThickness = true;
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
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _btnCancel.CustomizableEdges = BorderEdges4;
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
            _btnCancel.Location = new Point(107, 3);
            _btnCancel.Name = "_btnCancel";
            StateProperties7.BorderColor = Color.DarkGray;
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.DarkGray;
            StateProperties7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _btnCancel.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.White;
            StateProperties8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _btnCancel.OnPressedState = StateProperties8;
            _btnCancel.Size = new Size(92, 32);
            _btnCancel.TabIndex = 137;
            _btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancel.TextMarginLeft = 0;
            _btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuSeparator1
            // 
            BunifuSeparator1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BunifuSeparator1.BackColor = Color.Transparent;
            BunifuSeparator1.LineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(80)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)));
            BunifuSeparator1.LineThickness = 1;
            BunifuSeparator1.Location = new Point(26, 396);
            BunifuSeparator1.Margin = new Padding(4);
            BunifuSeparator1.Name = "BunifuSeparator1";
            BunifuSeparator1.Size = new Size(419, 35);
            BunifuSeparator1.TabIndex = 181;
            BunifuSeparator1.Transparency = 80;
            BunifuSeparator1.Vertical = false;
            // 
            // dgvCansAsnMb
            // 
            _dgvCansAsnMb.AllowCustomTheming = true;
            _dgvCansAsnMb.AllowUserToAddRows = false;
            _dgvCansAsnMb.AllowUserToDeleteRows = false;
            _dgvCansAsnMb.AllowUserToOrderColumns = true;
            _dgvCansAsnMb.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvCansAsnMb.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _dgvCansAsnMb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvCansAsnMb.BackgroundColor = Color.White;
            _dgvCansAsnMb.BorderStyle = BorderStyle.None;
            _dgvCansAsnMb.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgvCansAsnMb.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            _dgvCansAsnMb.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvCansAsnMb.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _dgvCansAsnMb.ColumnHeadersHeight = 30;
            _dgvCansAsnMb.Columns.AddRange(new DataGridViewColumn[] { CanId, DataGridViewCheckBoxColumn1, Column4, Column2, Column3 });
            _dgvCansAsnMb.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _dgvCansAsnMb.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvCansAsnMb.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _dgvCansAsnMb.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.LightGray;
            _dgvCansAsnMb.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _dgvCansAsnMb.CurrentTheme.BackColor = Color.Snow;
            _dgvCansAsnMb.CurrentTheme.GridColor = Color.Gainsboro;
            _dgvCansAsnMb.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvCansAsnMb.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _dgvCansAsnMb.CurrentTheme.HeaderStyle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvCansAsnMb.CurrentTheme.Name = null;
            _dgvCansAsnMb.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _dgvCansAsnMb.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _dgvCansAsnMb.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _dgvCansAsnMb.CurrentTheme.RowsStyle.SelectionBackColor = SystemColors.MenuBar;
            _dgvCansAsnMb.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.MenuBar;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvCansAsnMb.DefaultCellStyle = DataGridViewCellStyle3;
            _dgvCansAsnMb.EnableHeadersVisualStyles = false;
            _dgvCansAsnMb.GridColor = Color.Gainsboro;
            _dgvCansAsnMb.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _dgvCansAsnMb.HeaderBgColor = Color.Empty;
            _dgvCansAsnMb.HeaderForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _dgvCansAsnMb.Location = new Point(685, 46);
            _dgvCansAsnMb.Name = "_dgvCansAsnMb";
            _dgvCansAsnMb.ReadOnly = true;
            _dgvCansAsnMb.RowHeadersVisible = false;
            _dgvCansAsnMb.RowHeadersWidth = 30;
            _dgvCansAsnMb.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            _dgvCansAsnMb.RowTemplate.Height = 30;
            _dgvCansAsnMb.SelectionMode = DataGridViewSelectionMode.CellSelect;
            _dgvCansAsnMb.Size = new Size(264, 344);
            _dgvCansAsnMb.TabIndex = 182;
            _dgvCansAsnMb.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // CanId
            // 
            CanId.HeaderText = "CanId";
            CanId.Name = "CanId";
            CanId.ReadOnly = true;
            CanId.Visible = false;
            // 
            // DataGridViewCheckBoxColumn1
            // 
            DataGridViewCheckBoxColumn1.FillWeight = 37.80931f;
            DataGridViewCheckBoxColumn1.HeaderText = "";
            DataGridViewCheckBoxColumn1.MinimumWidth = 8;
            DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            DataGridViewCheckBoxColumn1.ReadOnly = true;
            DataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.True;
            DataGridViewCheckBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            Column4.HeaderText = "Container #";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 115.2022f;
            Column2.HeaderText = "Minibooking #";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "tempMBId";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // cboMinibooking
            // 
            cboMinibooking.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMinibooking.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboMinibooking.FormattingEnabled = true;
            cboMinibooking.Location = new Point(490, 75);
            cboMinibooking.Margin = new Padding(2);
            cboMinibooking.Name = "cboMinibooking";
            cboMinibooking.Size = new Size(184, 28);
            cboMinibooking.TabIndex = 183;
            // 
            // btnAsnToMb
            // 
            _btnAsnToMb.AllowToggling = false;
            _btnAsnToMb.AnimationSpeed = 200;
            _btnAsnToMb.AutoGenerateColors = false;
            _btnAsnToMb.BackColor = Color.Transparent;
            _btnAsnToMb.BackColor1 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAsnToMb.BackgroundImage = (Image)resources.GetObject("btnAsnToMb.BackgroundImage");
            _btnAsnToMb.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnAsnToMb.ButtonText = "";
            _btnAsnToMb.ButtonTextMarginLeft = 0;
            _btnAsnToMb.ColorContrastOnClick = 45;
            _btnAsnToMb.ColorContrastOnHover = 45;
            _btnAsnToMb.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnAsnToMb.CustomizableEdges = BorderEdges2;
            _btnAsnToMb.DialogResult = DialogResult.None;
            _btnAsnToMb.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnAsnToMb.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnAsnToMb.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnAsnToMb.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnAsnToMb.Font = new Font("Agency FB", 36.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAsnToMb.ForeColor = Color.White;
            _btnAsnToMb.IconLeftCursor = Cursors.Hand;
            _btnAsnToMb.IconMarginLeft = 8;
            _btnAsnToMb.IconPadding = 8;
            _btnAsnToMb.IconRightCursor = Cursors.Hand;
            _btnAsnToMb.IdleBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAsnToMb.IdleBorderRadius = 30;
            _btnAsnToMb.IdleBorderThickness = 1;
            _btnAsnToMb.IdleFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btnAsnToMb.IdleIconLeftImage = My.Resources.Resources.arrowRight;
            _btnAsnToMb.IdleIconRightImage = null;
            _btnAsnToMb.IndicateFocus = false;
            _btnAsnToMb.Location = new Point(547, 146);
            _btnAsnToMb.Name = "_btnAsnToMb";
            StateProperties3.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties3.BorderRadius = 30;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _btnAsnToMb.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties4.BorderRadius = 30;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _btnAsnToMb.OnPressedState = StateProperties4;
            _btnAsnToMb.Size = new Size(41, 42);
            _btnAsnToMb.TabIndex = 184;
            _btnAsnToMb.TextAlign = ContentAlignment.MiddleCenter;
            _btnAsnToMb.TextMarginLeft = 0;
            _btnAsnToMb.UseDefaultRadiusAndThickness = true;
            // 
            // btnRmvFromMb
            // 
            _btnRmvFromMb.AllowToggling = false;
            _btnRmvFromMb.AnimationSpeed = 200;
            _btnRmvFromMb.AutoGenerateColors = false;
            _btnRmvFromMb.BackColor = Color.Transparent;
            _btnRmvFromMb.BackColor1 = Color.SaddleBrown;
            _btnRmvFromMb.BackgroundImage = (Image)resources.GetObject("btnRmvFromMb.BackgroundImage");
            _btnRmvFromMb.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnRmvFromMb.ButtonText = "";
            _btnRmvFromMb.ButtonTextMarginLeft = 0;
            _btnRmvFromMb.ColorContrastOnClick = 45;
            _btnRmvFromMb.ColorContrastOnHover = 45;
            _btnRmvFromMb.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnRmvFromMb.CustomizableEdges = BorderEdges1;
            _btnRmvFromMb.DialogResult = DialogResult.None;
            _btnRmvFromMb.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnRmvFromMb.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnRmvFromMb.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnRmvFromMb.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnRmvFromMb.Font = new Font("Agency FB", 36.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnRmvFromMb.ForeColor = Color.White;
            _btnRmvFromMb.IconLeftCursor = Cursors.Hand;
            _btnRmvFromMb.IconMarginLeft = 8;
            _btnRmvFromMb.IconPadding = 8;
            _btnRmvFromMb.IconRightCursor = Cursors.Hand;
            _btnRmvFromMb.IdleBorderColor = Color.SaddleBrown;
            _btnRmvFromMb.IdleBorderRadius = 30;
            _btnRmvFromMb.IdleBorderThickness = 1;
            _btnRmvFromMb.IdleFillColor = Color.SaddleBrown;
            _btnRmvFromMb.IdleIconLeftImage = My.Resources.Resources.arrowLeft;
            _btnRmvFromMb.IdleIconRightImage = null;
            _btnRmvFromMb.IndicateFocus = false;
            _btnRmvFromMb.Location = new Point(547, 206);
            _btnRmvFromMb.Name = "_btnRmvFromMb";
            StateProperties1.BorderColor = Color.SaddleBrown;
            StateProperties1.BorderRadius = 30;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.Chocolate;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnRmvFromMb.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.SaddleBrown;
            StateProperties2.BorderRadius = 30;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.SaddleBrown;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnRmvFromMb.OnPressedState = StateProperties2;
            _btnRmvFromMb.Size = new Size(41, 42);
            _btnRmvFromMb.TabIndex = 185;
            _btnRmvFromMb.TextAlign = ContentAlignment.MiddleCenter;
            _btnRmvFromMb.TextMarginLeft = 0;
            _btnRmvFromMb.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.Font = new Font("Segoe UI", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(664, 14);
            Label1.Name = "Label1";
            Label1.Size = new Size(301, 29);
            Label1.TabIndex = 186;
            Label1.Text = "Containers assigned to new booking";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmSplitbooking
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(472, 494);
            Controls.Add(Label1);
            Controls.Add(_btnRmvFromMb);
            Controls.Add(_btnAsnToMb);
            Controls.Add(cboMinibooking);
            Controls.Add(_dgvCansAsnMb);
            Controls.Add(buttonsPanel);
            Controls.Add(_dgvCansToTransfer);
            Controls.Add(BunifuSeparator1);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSplitbooking";
            Text = "FrmSplitbooking";
            ((System.ComponentModel.ISupportInitialize)_dgvCansToTransfer).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWContainersByBookingBindingSource).EndInit();
            buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvCansAsnMb).EndInit();
            ResumeLayout(false);
        }

        internal Label titleLabel;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvCansToTransfer;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvCansToTransfer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvCansToTransfer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvCansToTransfer != null)
                {
                    _dgvCansToTransfer.CellContentClick -= dgvCansToTransfer_CellContentClick;
                }

                _dgvCansToTransfer = value;
                if (_dgvCansToTransfer != null)
                {
                    _dgvCansToTransfer.CellContentClick += dgvCansToTransfer_CellContentClick;
                }
            }
        }

        internal BindingSource VWContainersByBookingBindingSource;
        internal TableLayoutPanel buttonsPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _transferButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton transferButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _transferButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_transferButton != null)
                {
                    _transferButton.Click -= yesButton_Click;
                }

                _transferButton = value;
                if (_transferButton != null)
                {
                    _transferButton.Click += yesButton_Click;
                }
            }
        }

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
                    _btnCancel.Click -= noButton_Click;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += noButton_Click;
                }
            }
        }

        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator1;
        internal DataGridViewTextBoxColumn UniqueIDDataGridViewTextBoxColumn;
        internal DataGridViewCheckBoxColumn Column1;
        internal DataGridViewTextBoxColumn ContainerNumberDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ContainerSizeDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn GateDateInDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn MiniBookingNumber;
        internal DataGridViewTextBoxColumn MiniBookingId;
        internal ComboBox cboMinibooking;
        private Bunifu.UI.WinForms.BunifuDataGridView _dgvCansAsnMb;

        public Bunifu.UI.WinForms.BunifuDataGridView dgvCansAsnMb
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvCansAsnMb;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvCansAsnMb != null)
                {
                    _dgvCansAsnMb.CellContentClick -= dgvCansAsnMb_CellContentClick;
                }

                _dgvCansAsnMb = value;
                if (_dgvCansAsnMb != null)
                {
                    _dgvCansAsnMb.CellContentClick += dgvCansAsnMb_CellContentClick;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnRmvFromMb;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRmvFromMb
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRmvFromMb;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnRmvFromMb != null)
                {
                    _btnRmvFromMb.Click -= btnRmvFromMb_Click;
                }

                _btnRmvFromMb = value;
                if (_btnRmvFromMb != null)
                {
                    _btnRmvFromMb.Click += btnRmvFromMb_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnAsnToMb;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAsnToMb
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAsnToMb;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAsnToMb != null)
                {
                    _btnAsnToMb.Click -= btnAsnToMb_Click;
                }

                _btnAsnToMb = value;
                if (_btnAsnToMb != null)
                {
                    _btnAsnToMb.Click += btnAsnToMb_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn CanId;
        internal DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal Label Label1;
    }
}