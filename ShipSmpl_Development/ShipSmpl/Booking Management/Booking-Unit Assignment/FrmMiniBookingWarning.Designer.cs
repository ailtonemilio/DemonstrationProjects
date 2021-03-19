using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmMiniBookingWarning : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMiniBookingWarning));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label8 = new Label();
            buttonsPanel = new TableLayoutPanel();
            _proceedButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _proceedButton.Click += new EventHandler(proceedButton_Click);
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(cancelButton_Click);
            Label9 = new Label();
            Label3 = new Label();
            Panel4 = new Panel();
            _miniBkDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            _miniBkDataGridView.CellContentClick += new DataGridViewCellEventHandler(miniBkDataGridView_CellContentClick);
            VWBookingMinibooking = new BindingSource(components);
            Column1 = new DataGridViewCheckBoxColumn();
            BookingNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CustomerNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            NumberOfContainer = new DataGridViewTextBoxColumn();
            buttonsPanel.SuspendLayout();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_miniBkDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VWBookingMinibooking).BeginInit();
            SuspendLayout();
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
            _closeFlatButton.Location = new Point(555, 0);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(43, 41);
            _closeFlatButton.TabIndex = 168;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Label8
            // 
            Label8.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label8.Dock = DockStyle.Top;
            Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(0, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(598, 41);
            Label8.TabIndex = 167;
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.None;
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Controls.Add(_proceedButton, 0, 0);
            buttonsPanel.Controls.Add(_cancelButton, 1, 0);
            buttonsPanel.Location = new Point(185, 459);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(217, 39);
            buttonsPanel.TabIndex = 169;
            // 
            // proceedButton
            // 
            _proceedButton.AllowToggling = false;
            _proceedButton.AnimationSpeed = 200;
            _proceedButton.AutoGenerateColors = false;
            _proceedButton.BackColor = Color.Transparent;
            _proceedButton.BackColor1 = Color.Teal;
            _proceedButton.BackgroundImage = (Image)resources.GetObject("proceedButton.BackgroundImage");
            _proceedButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _proceedButton.ButtonText = "Proceed";
            _proceedButton.ButtonTextMarginLeft = 0;
            _proceedButton.ColorContrastOnClick = 45;
            _proceedButton.ColorContrastOnHover = 45;
            _proceedButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _proceedButton.CustomizableEdges = BorderEdges1;
            _proceedButton.DialogResult = DialogResult.None;
            _proceedButton.DisabledBorderColor = Color.Empty;
            _proceedButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _proceedButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _proceedButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _proceedButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _proceedButton.ForeColor = Color.White;
            _proceedButton.IconLeftCursor = Cursors.Hand;
            _proceedButton.IconMarginLeft = 11;
            _proceedButton.IconPadding = 10;
            _proceedButton.IconRightCursor = Cursors.Hand;
            _proceedButton.IdleBorderColor = Color.Teal;
            _proceedButton.IdleBorderRadius = 3;
            _proceedButton.IdleBorderThickness = 1;
            _proceedButton.IdleFillColor = Color.Teal;
            _proceedButton.IdleIconLeftImage = null;
            _proceedButton.IdleIconRightImage = null;
            _proceedButton.IndicateFocus = true;
            _proceedButton.Location = new Point(3, 3);
            _proceedButton.Name = "_proceedButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _proceedButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _proceedButton.OnPressedState = StateProperties2;
            _proceedButton.Size = new Size(102, 33);
            _proceedButton.TabIndex = 136;
            _proceedButton.TextAlign = ContentAlignment.MiddleCenter;
            _proceedButton.TextMarginLeft = 0;
            _proceedButton.UseDefaultRadiusAndThickness = true;
            // 
            // cancelButton
            // 
            _cancelButton.AllowToggling = false;
            _cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _cancelButton.CustomizableEdges = BorderEdges2;
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
            _cancelButton.Location = new Point(111, 3);
            _cancelButton.Name = "_cancelButton";
            StateProperties3.BorderColor = Color.DarkGray;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.DarkGray;
            StateProperties3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties4;
            _cancelButton.Size = new Size(103, 33);
            _cancelButton.TabIndex = 137;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // Label9
            // 
            Label9.Anchor = AnchorStyles.None;
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label9.Location = new Point(24, 54);
            Label9.Margin = new Padding(0);
            Label9.Name = "Label9";
            Label9.Size = new Size(280, 21);
            Label9.TabIndex = 170;
            Label9.Text = "Choose Minibookings to be assigned";
            Label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.None;
            Label3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(29, 79);
            Label3.Margin = new Padding(0);
            Label3.Name = "Label3";
            Label3.Size = new Size(560, 51);
            Label3.TabIndex = 171;
            Label3.Text = "The selected bookings has mini bookings. Please, select the mini bookings you wis" + "h to assign to the unit sources.";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Panel4
            // 
            Panel4.Anchor = AnchorStyles.None;
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(_miniBkDataGridView);
            Panel4.Location = new Point(24, 142);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(545, 301);
            Panel4.TabIndex = 172;
            // 
            // miniBkDataGridView
            // 
            _miniBkDataGridView.AllowCustomTheming = true;
            _miniBkDataGridView.AllowUserToAddRows = false;
            _miniBkDataGridView.AllowUserToDeleteRows = false;
            _miniBkDataGridView.AllowUserToOrderColumns = true;
            _miniBkDataGridView.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _miniBkDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            _miniBkDataGridView.AutoGenerateColumns = false;
            _miniBkDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _miniBkDataGridView.BackgroundColor = Color.White;
            _miniBkDataGridView.BorderStyle = BorderStyle.None;
            _miniBkDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _miniBkDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _miniBkDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _miniBkDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            _miniBkDataGridView.ColumnHeadersHeight = 30;
            _miniBkDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, BookingNumberDataGridViewTextBoxColumn, CustomerNameDataGridViewTextBoxColumn1, NumberOfContainer });
            _miniBkDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = Color.White;
            _miniBkDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _miniBkDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            _miniBkDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            _miniBkDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            _miniBkDataGridView.CurrentTheme.BackColor = Color.Snow;
            _miniBkDataGridView.CurrentTheme.GridColor = Color.Gray;
            _miniBkDataGridView.CurrentTheme.HeaderStyle.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _miniBkDataGridView.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75f, FontStyle.Bold);
            _miniBkDataGridView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            _miniBkDataGridView.CurrentTheme.Name = null;
            _miniBkDataGridView.CurrentTheme.RowsStyle.BackColor = Color.WhiteSmoke;
            _miniBkDataGridView.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            _miniBkDataGridView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            _miniBkDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = Color.Gray;
            _miniBkDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            _miniBkDataGridView.DataSource = VWBookingMinibooking;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _miniBkDataGridView.DefaultCellStyle = DataGridViewCellStyle3;
            _miniBkDataGridView.Dock = DockStyle.Fill;
            _miniBkDataGridView.EnableHeadersVisualStyles = false;
            _miniBkDataGridView.GridColor = Color.Gray;
            _miniBkDataGridView.HeaderBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _miniBkDataGridView.HeaderBgColor = Color.Empty;
            _miniBkDataGridView.HeaderForeColor = Color.White;
            _miniBkDataGridView.Location = new Point(0, 0);
            _miniBkDataGridView.MultiSelect = false;
            _miniBkDataGridView.Name = "_miniBkDataGridView";
            _miniBkDataGridView.ReadOnly = true;
            _miniBkDataGridView.RowHeadersVisible = false;
            _miniBkDataGridView.RowHeadersWidth = 51;
            _miniBkDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gray;
            _miniBkDataGridView.RowTemplate.Height = 30;
            _miniBkDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _miniBkDataGridView.Size = new Size(543, 299);
            _miniBkDataGridView.TabIndex = 175;
            _miniBkDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // VWBookingMinibooking
            // 
            VWBookingMinibooking.DataSource = typeof(ModelLayer.VW_BookingMinibooking);
            // 
            // Column1
            // 
            Column1.FillWeight = 36.33178f;
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // BookingNumberDataGridViewTextBoxColumn
            // 
            BookingNumberDataGridViewTextBoxColumn.DataPropertyName = "MinibookingNumber";
            BookingNumberDataGridViewTextBoxColumn.FillWeight = 145.4501f;
            BookingNumberDataGridViewTextBoxColumn.HeaderText = "Booking #";
            BookingNumberDataGridViewTextBoxColumn.Name = "BookingNumberDataGridViewTextBoxColumn";
            BookingNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomerNameDataGridViewTextBoxColumn1
            // 
            CustomerNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerName";
            CustomerNameDataGridViewTextBoxColumn1.FillWeight = 211.3493f;
            CustomerNameDataGridViewTextBoxColumn1.HeaderText = "Customer Name";
            CustomerNameDataGridViewTextBoxColumn1.Name = "CustomerNameDataGridViewTextBoxColumn1";
            CustomerNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // NumberOfContainer
            // 
            NumberOfContainer.DataPropertyName = "NumberOfContainer";
            NumberOfContainer.FillWeight = 84.02622f;
            NumberOfContainer.HeaderText = "# Cans";
            NumberOfContainer.Name = "NumberOfContainer";
            NumberOfContainer.ReadOnly = true;
            // 
            // FrmMiniBookingWarning
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(598, 510);
            Controls.Add(Panel4);
            Controls.Add(Label3);
            Controls.Add(Label9);
            Controls.Add(buttonsPanel);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMiniBookingWarning";
            Text = "FrmMiniUnitWarning";
            buttonsPanel.ResumeLayout(false);
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_miniBkDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)VWBookingMinibooking).EndInit();
            Load += new EventHandler(FrmMiniBookingWarning_Load);
            ResumeLayout(false);
            PerformLayout();
        }

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

        internal Label Label8;
        internal TableLayoutPanel buttonsPanel;
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
                    _cancelButton.Click -= cancelButton_Click;
                }

                _cancelButton = value;
                if (_cancelButton != null)
                {
                    _cancelButton.Click += cancelButton_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _proceedButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton proceedButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _proceedButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_proceedButton != null)
                {
                    _proceedButton.Click -= proceedButton_Click;
                }

                _proceedButton = value;
                if (_proceedButton != null)
                {
                    _proceedButton.Click += proceedButton_Click;
                }
            }
        }

        internal Label Label9;
        internal Label Label3;
        internal Panel Panel4;
        internal BindingSource VWBookingMinibooking;
        private Bunifu.UI.WinForms.BunifuDataGridView _miniBkDataGridView;

        public Bunifu.UI.WinForms.BunifuDataGridView miniBkDataGridView
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _miniBkDataGridView;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miniBkDataGridView != null)
                {
                    _miniBkDataGridView.CellContentClick -= miniBkDataGridView_CellContentClick;
                }

                _miniBkDataGridView = value;
                if (_miniBkDataGridView != null)
                {
                    _miniBkDataGridView.CellContentClick += miniBkDataGridView_CellContentClick;
                }
            }
        }

        internal DataGridViewCheckBoxColumn Column1;
        internal DataGridViewTextBoxColumn BookingNumberDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn CustomerNameDataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn NumberOfContainer;
    }
}