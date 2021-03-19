using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAdjustBagsInventoryQty : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdjustBagsInventoryQty));
            var BorderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label17 = new Label();
            _cboAjustmentTyoe = new ComboBox();
            _cboAjustmentTyoe.SelectedIndexChanged += new EventHandler(cboAjustmentTyoe_SelectedIndexChanged);
            Label7 = new Label();
            Label1 = new Label();
            _nudQuantity = new NumericUpDown();
            _nudQuantity.ValueChanged += new EventHandler(nudQuantity_ValueChanged);
            _btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnSave.Click += new EventHandler(btnSave_Click);
            lblPlusMinus = new Label();
            BunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            lblRemaining = new Label();
            lblQtyUsed = new Label();
            Label3 = new Label();
            Label4 = new Label();
            lblTotal = new Label();
            Label5 = new Label();
            GroupBox1 = new GroupBox();
            pnlAdjust = new Panel();
            Label9 = new Label();
            _rbDecrease = new Bunifu.UI.WinForms.BunifuRadioButton();
            _rbDecrease.Click += new EventHandler(rbIncrease_Click);
            Label8 = new Label();
            _rbIncrease = new Bunifu.UI.WinForms.BunifuRadioButton();
            _rbIncrease.Click += new EventHandler(rbIncrease_Click);
            pnlBooking = new Panel();
            Label2 = new Label();
            cboBookingNumber = new ComboBox();
            Label6 = new Label();
            lblWarning = new Label();
            Label10 = new Label();
            _cboBagLocation = new ComboBox();
            _cboBagLocation.SelectedIndexChanged += new EventHandler(cboBagLocation_SelectedIndexChanged);
            ((System.ComponentModel.ISupportInitialize)_nudQuantity).BeginInit();
            GroupBox1.SuspendLayout();
            pnlAdjust.SuspendLayout();
            pnlBooking.SuspendLayout();
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
            _closeFlatButton.Font = new Font("Segoe UI", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
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
            _closeFlatButton.Location = new Point(567, 0);
            _closeFlatButton.Margin = new Padding(7, 9, 7, 9);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(39, 33);
            _closeFlatButton.TabIndex = 173;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Label17
            // 
            Label17.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label17.Dock = DockStyle.Top;
            Label17.Font = new Font("Segoe UI", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = Color.White;
            Label17.Location = new Point(0, 0);
            Label17.Margin = new Padding(4, 0, 4, 0);
            Label17.Name = "Label17";
            Label17.Size = new Size(606, 33);
            Label17.TabIndex = 172;
            Label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboAjustmentTyoe
            // 
            _cboAjustmentTyoe.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboAjustmentTyoe.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboAjustmentTyoe.FormattingEnabled = true;
            _cboAjustmentTyoe.Location = new Point(162, 164);
            _cboAjustmentTyoe.Margin = new Padding(4, 5, 4, 5);
            _cboAjustmentTyoe.Name = "_cboAjustmentTyoe";
            _cboAjustmentTyoe.Size = new Size(164, 26);
            _cboAjustmentTyoe.TabIndex = 174;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label7.Location = new Point(21, 42);
            Label7.Name = "Label7";
            Label7.Size = new Size(232, 25);
            Label7.TabIndex = 175;
            Label7.Text = "Adjust inventory quantity";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(53, 99);
            Label1.Name = "Label1";
            Label1.Size = new Size(103, 20);
            Label1.TabIndex = 177;
            Label1.Text = "Quantity used:";
            // 
            // nudQuantity
            // 
            _nudQuantity.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _nudQuantity.Location = new Point(162, 92);
            _nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            _nudQuantity.Name = "_nudQuantity";
            _nudQuantity.Size = new Size(96, 29);
            _nudQuantity.TabIndex = 178;
            // 
            // btnSave
            // 
            _btnSave.AllowToggling = false;
            _btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _btnSave.AnimationSpeed = 200;
            _btnSave.AutoGenerateColors = false;
            _btnSave.BackColor = Color.Transparent;
            _btnSave.BackColor1 = Color.Teal;
            _btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            _btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnSave.ButtonText = "Save";
            _btnSave.ButtonTextMarginLeft = 0;
            _btnSave.ColorContrastOnClick = 45;
            _btnSave.ColorContrastOnHover = 45;
            _btnSave.Cursor = Cursors.Hand;
            BorderEdges5.BottomLeft = true;
            BorderEdges5.BottomRight = true;
            BorderEdges5.TopLeft = true;
            BorderEdges5.TopRight = true;
            _btnSave.CustomizableEdges = BorderEdges5;
            _btnSave.DialogResult = DialogResult.None;
            _btnSave.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            _btnSave.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnSave.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnSave.Enabled = false;
            _btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnSave.Font = new Font("Segoe UI Semibold", 9.75f);
            _btnSave.ForeColor = Color.White;
            _btnSave.IconLeftCursor = Cursors.Hand;
            _btnSave.IconMarginLeft = 11;
            _btnSave.IconPadding = 10;
            _btnSave.IconRightCursor = Cursors.Hand;
            _btnSave.IdleBorderColor = Color.Teal;
            _btnSave.IdleBorderRadius = 3;
            _btnSave.IdleBorderThickness = 1;
            _btnSave.IdleFillColor = Color.Teal;
            _btnSave.IdleIconLeftImage = null;
            _btnSave.IdleIconRightImage = null;
            _btnSave.IndicateFocus = false;
            _btnSave.Location = new Point(252, 264);
            _btnSave.Margin = new Padding(2);
            _btnSave.Name = "_btnSave";
            StateProperties9.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties9.BorderRadius = 3;
            StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties9.BorderThickness = 1;
            StateProperties9.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties9.ForeColor = Color.White;
            StateProperties9.IconLeftImage = null;
            StateProperties9.IconRightImage = null;
            _btnSave.onHoverState = StateProperties9;
            StateProperties10.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties10.BorderRadius = 3;
            StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties10.BorderThickness = 1;
            StateProperties10.FillColor = Color.Teal;
            StateProperties10.ForeColor = Color.White;
            StateProperties10.IconLeftImage = null;
            StateProperties10.IconRightImage = null;
            _btnSave.OnPressedState = StateProperties10;
            _btnSave.Size = new Size(99, 34);
            _btnSave.TabIndex = 179;
            _btnSave.TextAlign = ContentAlignment.MiddleCenter;
            _btnSave.TextMarginLeft = 0;
            _btnSave.UseDefaultRadiusAndThickness = true;
            // 
            // lblPlusMinus
            // 
            lblPlusMinus.AutoSize = true;
            lblPlusMinus.Font = new Font("Segoe UI", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblPlusMinus.Location = new Point(116, 38);
            lblPlusMinus.Name = "lblPlusMinus";
            lblPlusMinus.Size = new Size(19, 25);
            lblPlusMinus.TabIndex = 180;
            lblPlusMinus.Text = "-";
            // 
            // BunifuSeparator1
            // 
            BunifuSeparator1.BackColor = Color.Transparent;
            BunifuSeparator1.LineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)));
            BunifuSeparator1.LineThickness = 3;
            BunifuSeparator1.Location = new Point(144, 60);
            BunifuSeparator1.Margin = new Padding(4, 5, 4, 5);
            BunifuSeparator1.Name = "BunifuSeparator1";
            BunifuSeparator1.Size = new Size(73, 12);
            BunifuSeparator1.TabIndex = 181;
            BunifuSeparator1.Transparency = 255;
            BunifuSeparator1.Vertical = false;
            // 
            // lblRemaining
            // 
            lblRemaining.Font = new Font("Segoe UI", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblRemaining.Location = new Point(142, 16);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(73, 24);
            lblRemaining.TabIndex = 182;
            lblRemaining.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQtyUsed
            // 
            lblQtyUsed.Font = new Font("Segoe UI", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblQtyUsed.ForeColor = Color.DarkRed;
            lblQtyUsed.Location = new Point(142, 40);
            lblQtyUsed.Name = "lblQtyUsed";
            lblQtyUsed.Size = new Size(73, 26);
            lblQtyUsed.TabIndex = 183;
            lblQtyUsed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.Location = new Point(6, 39);
            Label3.Name = "Label3";
            Label3.Size = new Size(104, 27);
            Label3.TabIndex = 184;
            Label3.Text = "Quantity used:";
            Label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            Label4.Location = new Point(6, 13);
            Label4.Name = "Label4";
            Label4.Size = new Size(104, 27);
            Label4.TabIndex = 185;
            Label4.Text = "Remaining:";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotal.Location = new Point(142, 75);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(73, 20);
            lblTotal.TabIndex = 186;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            Label5.Location = new Point(6, 72);
            Label5.Name = "Label5";
            Label5.Size = new Size(104, 27);
            Label5.TabIndex = 187;
            Label5.Text = "Total:";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(lblRemaining);
            GroupBox1.Controls.Add(lblQtyUsed);
            GroupBox1.Controls.Add(Label4);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(lblPlusMinus);
            GroupBox1.Controls.Add(lblTotal);
            GroupBox1.Controls.Add(BunifuSeparator1);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Location = new Point(354, 95);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(240, 109);
            GroupBox1.TabIndex = 188;
            GroupBox1.TabStop = false;
            // 
            // pnlAdjust
            // 
            pnlAdjust.Controls.Add(Label9);
            pnlAdjust.Controls.Add(_rbDecrease);
            pnlAdjust.Controls.Add(Label8);
            pnlAdjust.Controls.Add(_rbIncrease);
            pnlAdjust.Location = new Point(80, 193);
            pnlAdjust.Name = "pnlAdjust";
            pnlAdjust.Size = new Size(246, 58);
            pnlAdjust.TabIndex = 189;
            pnlAdjust.Visible = false;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(30, 29);
            Label9.Name = "Label9";
            Label9.Size = new Size(162, 20);
            Label9.TabIndex = 179;
            Label9.Text = "DECREASE INVENTORY";
            // 
            // rbDecrease
            // 
            _rbDecrease.Checked = false;
            _rbDecrease.Location = new Point(3, 28);
            _rbDecrease.Name = "_rbDecrease";
            _rbDecrease.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _rbDecrease.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _rbDecrease.Size = new Size(21, 21);
            _rbDecrease.TabIndex = 178;
            _rbDecrease.Text = null;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(30, 4);
            Label8.Name = "Label8";
            Label8.Size = new Size(158, 20);
            Label8.TabIndex = 177;
            Label8.Text = "INCREASE INVENTORY";
            // 
            // rbIncrease
            // 
            _rbIncrease.Checked = true;
            _rbIncrease.Location = new Point(3, 3);
            _rbIncrease.Name = "_rbIncrease";
            _rbIncrease.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _rbIncrease.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _rbIncrease.Size = new Size(21, 21);
            _rbIncrease.TabIndex = 0;
            _rbIncrease.Text = null;
            // 
            // pnlBooking
            // 
            pnlBooking.Controls.Add(Label2);
            pnlBooking.Controls.Add(cboBookingNumber);
            pnlBooking.Location = new Point(28, 194);
            pnlBooking.Name = "pnlBooking";
            pnlBooking.Size = new Size(303, 58);
            pnlBooking.TabIndex = 190;
            pnlBooking.Visible = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(3, 3);
            Label2.Name = "Label2";
            Label2.Size = new Size(125, 20);
            Label2.TabIndex = 177;
            Label2.Text = "Booking Number:";
            // 
            // cboBookingNumber
            // 
            cboBookingNumber.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboBookingNumber.FormattingEnabled = true;
            cboBookingNumber.Location = new Point(134, 1);
            cboBookingNumber.Margin = new Padding(4, 5, 4, 5);
            cboBookingNumber.Name = "cboBookingNumber";
            cboBookingNumber.Size = new Size(169, 26);
            cboBookingNumber.TabIndex = 175;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(34, 167);
            Label6.Name = "Label6";
            Label6.Size = new Size(121, 20);
            Label6.TabIndex = 176;
            Label6.Text = "Adjustment type:";
            // 
            // lblWarning
            // 
            lblWarning.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWarning.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblWarning.Location = new Point(178, 67);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(378, 20);
            lblWarning.TabIndex = 191;
            lblWarning.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(53, 134);
            Label10.Name = "Label10";
            Label10.Size = new Size(99, 20);
            Label10.TabIndex = 193;
            Label10.Text = "Bag Location:";
            // 
            // cboBagLocation
            // 
            _cboBagLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboBagLocation.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboBagLocation.FormattingEnabled = true;
            _cboBagLocation.Location = new Point(162, 129);
            _cboBagLocation.Margin = new Padding(4, 5, 4, 5);
            _cboBagLocation.Name = "_cboBagLocation";
            _cboBagLocation.Size = new Size(164, 26);
            _cboBagLocation.TabIndex = 192;
            // 
            // FrmAdjustBagsInventoryQty
            // 
            AutoScaleDimensions = new SizeF(8.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(606, 309);
            Controls.Add(Label7);
            Controls.Add(Label10);
            Controls.Add(_cboBagLocation);
            Controls.Add(lblWarning);
            Controls.Add(pnlBooking);
            Controls.Add(pnlAdjust);
            Controls.Add(GroupBox1);
            Controls.Add(_btnSave);
            Controls.Add(_nudQuantity);
            Controls.Add(Label1);
            Controls.Add(Label6);
            Controls.Add(_cboAjustmentTyoe);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label17);
            Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmAdjustBagsInventoryQty";
            Text = "FrmAdjustBagsInventoryQty";
            ((System.ComponentModel.ISupportInitialize)_nudQuantity).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            pnlAdjust.ResumeLayout(false);
            pnlAdjust.PerformLayout();
            pnlBooking.ResumeLayout(false);
            pnlBooking.PerformLayout();
            Load += new EventHandler(FrmAdjustBagsInventoryQty_Load);
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

        internal Label Label17;
        private ComboBox _cboAjustmentTyoe;

        internal ComboBox cboAjustmentTyoe
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboAjustmentTyoe;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboAjustmentTyoe != null)
                {
                    _cboAjustmentTyoe.SelectedIndexChanged -= cboAjustmentTyoe_SelectedIndexChanged;
                }

                _cboAjustmentTyoe = value;
                if (_cboAjustmentTyoe != null)
                {
                    _cboAjustmentTyoe.SelectedIndexChanged += cboAjustmentTyoe_SelectedIndexChanged;
                }
            }
        }

        internal Label Label7;
        internal Label Label1;
        private NumericUpDown _nudQuantity;

        internal NumericUpDown nudQuantity
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _nudQuantity;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudQuantity != null)
                {
                    _nudQuantity.ValueChanged -= nudQuantity_ValueChanged;
                }

                _nudQuantity = value;
                if (_nudQuantity != null)
                {
                    _nudQuantity.ValueChanged += nudQuantity_ValueChanged;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnSave;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSave != null)
                {
                    _btnSave.Click -= btnSave_Click;
                }

                _btnSave = value;
                if (_btnSave != null)
                {
                    _btnSave.Click += btnSave_Click;
                }
            }
        }

        internal Label lblPlusMinus;
        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator1;
        internal Label lblRemaining;
        internal Label lblQtyUsed;
        internal Label Label3;
        internal Label Label4;
        internal Label lblTotal;
        internal Label Label5;
        internal GroupBox GroupBox1;
        internal Panel pnlAdjust;
        internal Label Label9;
        private Bunifu.UI.WinForms.BunifuRadioButton _rbDecrease;

        internal Bunifu.UI.WinForms.BunifuRadioButton rbDecrease
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _rbDecrease;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbDecrease != null)
                {
                    _rbDecrease.Click -= rbIncrease_Click;
                }

                _rbDecrease = value;
                if (_rbDecrease != null)
                {
                    _rbDecrease.Click += rbIncrease_Click;
                }
            }
        }

        internal Label Label8;
        private Bunifu.UI.WinForms.BunifuRadioButton _rbIncrease;

        internal Bunifu.UI.WinForms.BunifuRadioButton rbIncrease
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _rbIncrease;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbIncrease != null)
                {
                    _rbIncrease.Click -= rbIncrease_Click;
                }

                _rbIncrease = value;
                if (_rbIncrease != null)
                {
                    _rbIncrease.Click += rbIncrease_Click;
                }
            }
        }

        internal Panel pnlBooking;
        internal Label Label2;
        internal ComboBox cboBookingNumber;
        internal Label Label6;
        internal Label lblWarning;
        internal Label Label10;
        private ComboBox _cboBagLocation;

        internal ComboBox cboBagLocation
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboBagLocation;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboBagLocation != null)
                {
                    _cboBagLocation.SelectedIndexChanged -= cboBagLocation_SelectedIndexChanged;
                }

                _cboBagLocation = value;
                if (_cboBagLocation != null)
                {
                    _cboBagLocation.SelectedIndexChanged += cboBagLocation_SelectedIndexChanged;
                }
            }
        }
    }
}