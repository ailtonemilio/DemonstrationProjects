using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmUseInvQty : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUseInvQty));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            Label17 = new Label();
            Label7 = new Label();
            Label10 = new Label();
            cboBagLocation = new ComboBox();
            GroupBox1 = new GroupBox();
            lblRemaining = new Label();
            lblQtyUsed = new Label();
            Label4 = new Label();
            Label5 = new Label();
            lblPlusMinus = new Label();
            lblTotal = new Label();
            BunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            Label3 = new Label();
            nudQuantity = new NumericUpDown();
            Label1 = new Label();
            Label6 = new Label();
            cboAjustmentTyoe = new ComboBox();
            pnlBooking = new Panel();
            Label2 = new Label();
            cboBookingNumber = new ComboBox();
            pnlAdjust = new Panel();
            Label9 = new Label();
            rbDecrease = new Bunifu.UI.WinForms.BunifuRadioButton();
            Label8 = new Label();
            rbIncrease = new Bunifu.UI.WinForms.BunifuRadioButton();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            pnlBooking.SuspendLayout();
            pnlAdjust.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.AllowToggling = false;
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.AnimationSpeed = 200;
            btnSave.AutoGenerateColors = false;
            btnSave.BackColor = Color.Transparent;
            btnSave.BackColor1 = Color.Teal;
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnSave.ButtonText = "Save";
            btnSave.ButtonTextMarginLeft = 0;
            btnSave.ColorContrastOnClick = 45;
            btnSave.ColorContrastOnHover = 45;
            btnSave.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            btnSave.CustomizableEdges = BorderEdges1;
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledBorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)), Conversions.ToInteger(Conversions.ToByte(191)));
            btnSave.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            btnSave.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            btnSave.Enabled = false;
            btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75f);
            btnSave.ForeColor = Color.White;
            btnSave.IconLeftCursor = Cursors.Hand;
            btnSave.IconMarginLeft = 11;
            btnSave.IconPadding = 10;
            btnSave.IconRightCursor = Cursors.Hand;
            btnSave.IdleBorderColor = Color.Teal;
            btnSave.IdleBorderRadius = 3;
            btnSave.IdleBorderThickness = 1;
            btnSave.IdleFillColor = Color.Teal;
            btnSave.IdleIconLeftImage = null;
            btnSave.IdleIconRightImage = null;
            btnSave.IndicateFocus = false;
            btnSave.Location = new Point(273, 264);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            StateProperties1.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(181)), Conversions.ToInteger(Conversions.ToByte(255)));
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            btnSave.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(40)), Conversions.ToInteger(Conversions.ToByte(96)), Conversions.ToInteger(Conversions.ToByte(144)));
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            btnSave.OnPressedState = StateProperties2;
            btnSave.Size = new Size(89, 42);
            btnSave.TabIndex = 182;
            btnSave.TextAlign = ContentAlignment.MiddleCenter;
            btnSave.TextMarginLeft = 0;
            btnSave.UseDefaultRadiusAndThickness = true;
            // 
            // closeFlatButton
            // 
            closeFlatButton.Active = false;
            closeFlatButton.Activecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            closeFlatButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeFlatButton.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            closeFlatButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeFlatButton.BorderRadius = 0;
            closeFlatButton.ButtonText = "🗙";
            closeFlatButton.Cursor = Cursors.Hand;
            closeFlatButton.DisabledColor = Color.Gray;
            closeFlatButton.Font = new Font("Segoe UI", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            closeFlatButton.Iconcolor = Color.Transparent;
            closeFlatButton.Iconimage = null;
            closeFlatButton.Iconimage_right = null;
            closeFlatButton.Iconimage_right_Selected = null;
            closeFlatButton.Iconimage_Selected = null;
            closeFlatButton.IconMarginLeft = 0;
            closeFlatButton.IconMarginRight = 0;
            closeFlatButton.IconRightVisible = true;
            closeFlatButton.IconRightZoom = 0d;
            closeFlatButton.IconVisible = true;
            closeFlatButton.IconZoom = 90.0d;
            closeFlatButton.IsTab = false;
            closeFlatButton.Location = new Point(595, 0);
            closeFlatButton.Margin = new Padding(9, 11, 9, 11);
            closeFlatButton.Name = "closeFlatButton";
            closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            closeFlatButton.OnHovercolor = Color.Gray;
            closeFlatButton.OnHoverTextColor = Color.White;
            closeFlatButton.selected = false;
            closeFlatButton.Size = new Size(43, 35);
            closeFlatButton.TabIndex = 181;
            closeFlatButton.Text = "🗙";
            closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            closeFlatButton.Textcolor = Color.White;
            closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Label17
            // 
            Label17.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label17.Dock = DockStyle.Top;
            Label17.Font = new Font("Segoe UI", 10.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label17.ForeColor = Color.White;
            Label17.Location = new Point(0, 0);
            Label17.Margin = new Padding(5, 0, 5, 0);
            Label17.Name = "Label17";
            Label17.Size = new Size(638, 35);
            Label17.TabIndex = 180;
            Label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label7.Location = new Point(16, 53);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(185, 25);
            Label7.TabIndex = 183;
            Label7.Text = "Adjust grain storage";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(30, 131);
            Label10.Margin = new Padding(4, 0, 4, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(105, 17);
            Label10.TabIndex = 200;
            Label10.Text = "Grain Location:";
            // 
            // cboBagLocation
            // 
            cboBagLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBagLocation.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboBagLocation.FormattingEnabled = true;
            cboBagLocation.Location = new Point(144, 126);
            cboBagLocation.Margin = new Padding(5, 6, 5, 6);
            cboBagLocation.Name = "cboBagLocation";
            cboBagLocation.Size = new Size(172, 26);
            cboBagLocation.TabIndex = 199;
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
            GroupBox1.Location = new Point(361, 81);
            GroupBox1.Margin = new Padding(4, 4, 4, 4);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4, 4, 4, 4);
            GroupBox1.Size = new Size(261, 128);
            GroupBox1.TabIndex = 198;
            GroupBox1.TabStop = false;
            // 
            // lblRemaining
            // 
            lblRemaining.Font = new Font("Segoe UI", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblRemaining.Location = new Point(157, 16);
            lblRemaining.Margin = new Padding(4, 0, 4, 0);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(97, 31);
            lblRemaining.TabIndex = 182;
            lblRemaining.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQtyUsed
            // 
            lblQtyUsed.Font = new Font("Segoe UI", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblQtyUsed.ForeColor = Color.DarkRed;
            lblQtyUsed.Location = new Point(157, 46);
            lblQtyUsed.Margin = new Padding(4, 0, 4, 0);
            lblQtyUsed.Name = "lblQtyUsed";
            lblQtyUsed.Size = new Size(97, 31);
            lblQtyUsed.TabIndex = 183;
            lblQtyUsed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            Label4.Location = new Point(6, 12);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(109, 33);
            Label4.TabIndex = 185;
            Label4.Text = "Remaining:";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            Label5.Location = new Point(6, 85);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(109, 33);
            Label5.TabIndex = 187;
            Label5.Text = "Total:";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlusMinus
            // 
            lblPlusMinus.AutoSize = true;
            lblPlusMinus.Font = new Font("Segoe UI", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblPlusMinus.Location = new Point(123, 43);
            lblPlusMinus.Margin = new Padding(4, 0, 4, 0);
            lblPlusMinus.Name = "lblPlusMinus";
            lblPlusMinus.Size = new Size(19, 25);
            lblPlusMinus.TabIndex = 180;
            lblPlusMinus.Text = "-";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 13.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTotal.Location = new Point(157, 88);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(97, 31);
            lblTotal.TabIndex = 186;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuSeparator1
            // 
            BunifuSeparator1.BackColor = Color.Transparent;
            BunifuSeparator1.LineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)), Conversions.ToInteger(Conversions.ToByte(105)));
            BunifuSeparator1.LineThickness = 13;
            BunifuSeparator1.Location = new Point(157, 77);
            BunifuSeparator1.Margin = new Padding(5, 6, 5, 6);
            BunifuSeparator1.Name = "BunifuSeparator1";
            BunifuSeparator1.Size = new Size(97, 10);
            BunifuSeparator1.TabIndex = 181;
            BunifuSeparator1.Transparency = 255;
            BunifuSeparator1.Vertical = false;
            // 
            // Label3
            // 
            Label3.Location = new Point(6, 44);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(109, 33);
            Label3.TabIndex = 184;
            Label3.Text = "Quantity used:";
            Label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            nudQuantity.Location = new Point(145, 91);
            nudQuantity.Margin = new Padding(4, 4, 4, 4);
            nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 29);
            nudQuantity.TabIndex = 197;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(37, 97);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(100, 17);
            Label1.TabIndex = 196;
            Label1.Text = "Quantity used:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(22, 164);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(113, 17);
            Label6.TabIndex = 195;
            Label6.Text = "Adjustment type:";
            // 
            // cboAjustmentTyoe
            // 
            cboAjustmentTyoe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAjustmentTyoe.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboAjustmentTyoe.FormattingEnabled = true;
            cboAjustmentTyoe.Location = new Point(144, 159);
            cboAjustmentTyoe.Margin = new Padding(5, 6, 5, 6);
            cboAjustmentTyoe.Name = "cboAjustmentTyoe";
            cboAjustmentTyoe.Size = new Size(172, 26);
            cboAjustmentTyoe.TabIndex = 194;
            // 
            // pnlBooking
            // 
            pnlBooking.Controls.Add(Label2);
            pnlBooking.Controls.Add(cboBookingNumber);
            pnlBooking.Location = new Point(13, 194);
            pnlBooking.Name = "pnlBooking";
            pnlBooking.Size = new Size(303, 58);
            pnlBooking.TabIndex = 202;
            pnlBooking.Visible = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(4, 3);
            Label2.Name = "Label2";
            Label2.Size = new Size(117, 17);
            Label2.TabIndex = 177;
            Label2.Text = "Booking Number:";
            // 
            // cboBookingNumber
            // 
            cboBookingNumber.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboBookingNumber.FormattingEnabled = true;
            cboBookingNumber.Location = new Point(130, 1);
            cboBookingNumber.Margin = new Padding(4, 5, 4, 5);
            cboBookingNumber.Name = "cboBookingNumber";
            cboBookingNumber.Size = new Size(173, 26);
            cboBookingNumber.TabIndex = 175;
            // 
            // pnlAdjust
            // 
            pnlAdjust.Controls.Add(Label9);
            pnlAdjust.Controls.Add(rbDecrease);
            pnlAdjust.Controls.Add(Label8);
            pnlAdjust.Controls.Add(rbIncrease);
            pnlAdjust.Location = new Point(65, 192);
            pnlAdjust.Name = "pnlAdjust";
            pnlAdjust.Size = new Size(246, 58);
            pnlAdjust.TabIndex = 201;
            pnlAdjust.Visible = false;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(30, 29);
            Label9.Name = "Label9";
            Label9.Size = new Size(166, 17);
            Label9.TabIndex = 179;
            Label9.Text = "DECREASE INVENTORY";
            // 
            // rbDecrease
            // 
            rbDecrease.Checked = false;
            rbDecrease.Location = new Point(3, 28);
            rbDecrease.Name = "rbDecrease";
            rbDecrease.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            rbDecrease.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            rbDecrease.Size = new Size(21, 21);
            rbDecrease.TabIndex = 178;
            rbDecrease.Text = null;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(30, 4);
            Label8.Name = "Label8";
            Label8.Size = new Size(160, 17);
            Label8.TabIndex = 177;
            Label8.Text = "INCREASE INVENTORY";
            // 
            // rbIncrease
            // 
            rbIncrease.Checked = true;
            rbIncrease.Location = new Point(3, 3);
            rbIncrease.Name = "rbIncrease";
            rbIncrease.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            rbIncrease.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            rbIncrease.Size = new Size(21, 21);
            rbIncrease.TabIndex = 0;
            rbIncrease.Text = null;
            // 
            // FrmUseInvQty
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(638, 317);
            Controls.Add(pnlBooking);
            Controls.Add(pnlAdjust);
            Controls.Add(Label10);
            Controls.Add(cboBagLocation);
            Controls.Add(GroupBox1);
            Controls.Add(nudQuantity);
            Controls.Add(Label1);
            Controls.Add(Label6);
            Controls.Add(cboAjustmentTyoe);
            Controls.Add(Label7);
            Controls.Add(btnSave);
            Controls.Add(closeFlatButton);
            Controls.Add(Label17);
            Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmUseInvQty";
            Text = "FrmUseInvQty";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            pnlBooking.ResumeLayout(false);
            pnlBooking.PerformLayout();
            pnlAdjust.ResumeLayout(false);
            pnlAdjust.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        internal Bunifu.Framework.UI.BunifuFlatButton closeFlatButton;
        internal Label Label17;
        internal Label Label7;
        internal Label Label10;
        internal ComboBox cboBagLocation;
        internal GroupBox GroupBox1;
        internal Label lblRemaining;
        internal Label lblQtyUsed;
        internal Label Label4;
        internal Label Label5;
        internal Label lblPlusMinus;
        internal Label lblTotal;
        internal Bunifu.Framework.UI.BunifuSeparator BunifuSeparator1;
        internal Label Label3;
        internal NumericUpDown nudQuantity;
        internal Label Label1;
        internal Label Label6;
        internal ComboBox cboAjustmentTyoe;
        internal Panel pnlBooking;
        internal Label Label2;
        internal ComboBox cboBookingNumber;
        internal Panel pnlAdjust;
        internal Label Label9;
        internal Bunifu.UI.WinForms.BunifuRadioButton rbDecrease;
        internal Label Label8;
        internal Bunifu.UI.WinForms.BunifuRadioButton rbIncrease;
    }
}