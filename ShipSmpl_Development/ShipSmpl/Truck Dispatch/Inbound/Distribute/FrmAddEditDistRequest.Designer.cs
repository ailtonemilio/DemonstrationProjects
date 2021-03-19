using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAddEditDistRequest : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditDistRequest));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Label2 = new Label();
            nudQtyCans = new NumericUpDown();
            buttonsPanel = new TableLayoutPanel();
            _btnComplete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnComplete.Click += new EventHandler(btnComplete_Click);
            _btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancel.Click += new EventHandler(BunifuButton1_Click);
            _BunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _BunifuButton1.Click += new EventHandler(BunifuButton1_Click);
            Label15 = new Label();
            Label1 = new Label();
            BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            dtpFromDate = new DateTimePicker();
            Label3 = new Label();
            dtpToDate = new DateTimePicker();
            Label4 = new Label();
            Label5 = new Label();
            Label7 = new Label();
            Label6 = new Label();
            lblPickUpCode = new Label();
            lblDropOff = new Label();
            lblReleaseNumb = new Label();
            lblCarrierCode = new Label();
            ((System.ComponentModel.ISupportInitialize)nudQtyCans).BeginInit();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(37, 197);
            Label2.Name = "Label2";
            Label2.Size = new Size(90, 18);
            Label2.TabIndex = 234;
            Label2.Text = "Qty Needed:";
            // 
            // nudQtyCans
            // 
            nudQtyCans.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            nudQtyCans.Location = new Point(133, 193);
            nudQtyCans.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQtyCans.Name = "nudQtyCans";
            nudQtyCans.Size = new Size(105, 27);
            nudQtyCans.TabIndex = 233;
            nudQtyCans.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.25373f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.74627f));
            buttonsPanel.Controls.Add(_btnComplete, 0, 0);
            buttonsPanel.Controls.Add(_btnCancel, 1, 0);
            buttonsPanel.Location = new Point(214, 235);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(150, 31);
            buttonsPanel.TabIndex = 232;
            // 
            // btnComplete
            // 
            _btnComplete.AllowToggling = false;
            _btnComplete.AnimationSpeed = 200;
            _btnComplete.AutoGenerateColors = false;
            _btnComplete.BackColor = Color.Transparent;
            _btnComplete.BackColor1 = Color.Teal;
            _btnComplete.BackgroundImage = (Image)resources.GetObject("btnComplete.BackgroundImage");
            _btnComplete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnComplete.ButtonText = "OK";
            _btnComplete.ButtonTextMarginLeft = 0;
            _btnComplete.ColorContrastOnClick = 45;
            _btnComplete.ColorContrastOnHover = 45;
            _btnComplete.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _btnComplete.CustomizableEdges = BorderEdges1;
            _btnComplete.DialogResult = DialogResult.None;
            _btnComplete.DisabledBorderColor = Color.Empty;
            _btnComplete.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnComplete.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnComplete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnComplete.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnComplete.ForeColor = Color.White;
            _btnComplete.IconLeftCursor = Cursors.Hand;
            _btnComplete.IconMarginLeft = 11;
            _btnComplete.IconPadding = 10;
            _btnComplete.IconRightCursor = Cursors.Hand;
            _btnComplete.IdleBorderColor = Color.Teal;
            _btnComplete.IdleBorderRadius = 3;
            _btnComplete.IdleBorderThickness = 1;
            _btnComplete.IdleFillColor = Color.Teal;
            _btnComplete.IdleIconLeftImage = null;
            _btnComplete.IdleIconRightImage = null;
            _btnComplete.IndicateFocus = true;
            _btnComplete.Location = new Point(3, 3);
            _btnComplete.Name = "_btnComplete";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _btnComplete.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _btnComplete.OnPressedState = StateProperties2;
            _btnComplete.Size = new Size(66, 24);
            _btnComplete.TabIndex = 136;
            _btnComplete.TextAlign = ContentAlignment.MiddleCenter;
            _btnComplete.TextMarginLeft = 0;
            _btnComplete.UseDefaultRadiusAndThickness = true;
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
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _btnCancel.CustomizableEdges = BorderEdges2;
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
            _btnCancel.Location = new Point(77, 3);
            _btnCancel.Name = "_btnCancel";
            StateProperties3.BorderColor = Color.DarkGray;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.DarkGray;
            StateProperties3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _btnCancel.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _btnCancel.OnPressedState = StateProperties4;
            _btnCancel.Size = new Size(70, 24);
            _btnCancel.TabIndex = 137;
            _btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancel.TextMarginLeft = 0;
            _btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // BunifuButton1
            // 
            _BunifuButton1.AllowToggling = false;
            _BunifuButton1.AnimationSpeed = 200;
            _BunifuButton1.AutoGenerateColors = false;
            _BunifuButton1.BackColor = Color.Transparent;
            _BunifuButton1.BackColor1 = Color.White;
            _BunifuButton1.BackgroundImage = (Image)resources.GetObject("BunifuButton1.BackgroundImage");
            _BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _BunifuButton1.ButtonText = "🗙";
            _BunifuButton1.ButtonTextMarginLeft = 0;
            _BunifuButton1.ColorContrastOnClick = 45;
            _BunifuButton1.ColorContrastOnHover = 45;
            _BunifuButton1.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _BunifuButton1.CustomizableEdges = BorderEdges3;
            _BunifuButton1.DialogResult = DialogResult.None;
            _BunifuButton1.DisabledBorderColor = Color.Empty;
            _BunifuButton1.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _BunifuButton1.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _BunifuButton1.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _BunifuButton1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _BunifuButton1.IconLeftCursor = Cursors.Hand;
            _BunifuButton1.IconMarginLeft = 11;
            _BunifuButton1.IconPadding = 10;
            _BunifuButton1.IconRightCursor = Cursors.Hand;
            _BunifuButton1.IdleBorderColor = Color.White;
            _BunifuButton1.IdleBorderRadius = 20;
            _BunifuButton1.IdleBorderThickness = 1;
            _BunifuButton1.IdleFillColor = Color.White;
            _BunifuButton1.IdleIconLeftImage = null;
            _BunifuButton1.IdleIconRightImage = null;
            _BunifuButton1.IndicateFocus = true;
            _BunifuButton1.Location = new Point(523, 0);
            _BunifuButton1.Name = "_BunifuButton1";
            StateProperties5.BorderColor = Color.Silver;
            StateProperties5.BorderRadius = 20;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.Silver;
            StateProperties5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _BunifuButton1.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Silver;
            StateProperties6.BorderRadius = 20;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Silver;
            StateProperties6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _BunifuButton1.OnPressedState = StateProperties6;
            _BunifuButton1.Size = new Size(25, 25);
            _BunifuButton1.TabIndex = 237;
            _BunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            _BunifuButton1.TextMarginLeft = 0;
            _BunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Font = new Font("Segoe UI Semibold", 14.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label15.Location = new Point(12, 18);
            Label15.Name = "Label15";
            Label15.Size = new Size(154, 25);
            Label15.TabIndex = 236;
            Label15.Text = "Add Distribution";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(44, 135);
            Label1.Name = "Label1";
            Label1.Size = new Size(83, 18);
            Label1.TabIndex = 235;
            Label1.Text = "From Date:";
            // 
            // BunifuElipse1
            // 
            BunifuElipse1.ElipseRadius = 20;
            BunifuElipse1.TargetControl = this;
            // 
            // dtpFromDate
            // 
            dtpFromDate.CalendarTrailingForeColor = Color.Teal;
            dtpFromDate.CustomFormat = "   dd-MMM-yyyy     hh:mm tt";
            dtpFromDate.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.Location = new Point(133, 129);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.RightToLeft = RightToLeft.No;
            dtpFromDate.Size = new Size(234, 26);
            dtpFromDate.TabIndex = 238;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(44, 164);
            Label3.Name = "Label3";
            Label3.Size = new Size(65, 18);
            Label3.TabIndex = 239;
            Label3.Text = "To Date:";
            // 
            // dtpToDate
            // 
            dtpToDate.CalendarTrailingForeColor = Color.Teal;
            dtpToDate.CustomFormat = "   dd-MMM-yyyy     hh:mm tt";
            dtpToDate.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Location = new Point(133, 161);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.RightToLeft = RightToLeft.No;
            dtpToDate.Size = new Size(234, 26);
            dtpToDate.TabIndex = 240;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(70, 92);
            Label4.Name = "Label4";
            Label4.Size = new Size(57, 18);
            Label4.TabIndex = 242;
            Label4.Text = "Carrier:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(49, 58);
            Label5.Name = "Label5";
            Label5.Size = new Size(78, 18);
            Label5.TabIndex = 243;
            Label5.Text = "Release #:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(323, 60);
            Label7.Name = "Label7";
            Label7.Size = new Size(61, 18);
            Label7.TabIndex = 245;
            Label7.Text = "Pick up:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.Location = new Point(323, 95);
            Label6.Name = "Label6";
            Label6.Size = new Size(66, 18);
            Label6.TabIndex = 246;
            Label6.Text = "Drop off:";
            // 
            // lblPickUpCode
            // 
            lblPickUpCode.BackColor = Color.Linen;
            lblPickUpCode.BorderStyle = BorderStyle.Fixed3D;
            lblPickUpCode.FlatStyle = FlatStyle.Flat;
            lblPickUpCode.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblPickUpCode.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblPickUpCode.Location = new Point(390, 54);
            lblPickUpCode.Name = "lblPickUpCode";
            lblPickUpCode.Size = new Size(125, 27);
            lblPickUpCode.TabIndex = 247;
            lblPickUpCode.Text = "Pick up:";
            lblPickUpCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDropOff
            // 
            lblDropOff.BackColor = Color.Linen;
            lblDropOff.BorderStyle = BorderStyle.Fixed3D;
            lblDropOff.FlatStyle = FlatStyle.Flat;
            lblDropOff.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblDropOff.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblDropOff.Location = new Point(390, 87);
            lblDropOff.Name = "lblDropOff";
            lblDropOff.Size = new Size(125, 27);
            lblDropOff.TabIndex = 248;
            lblDropOff.Text = "Drop off";
            lblDropOff.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblReleaseNumb
            // 
            lblReleaseNumb.BackColor = Color.Linen;
            lblReleaseNumb.BorderStyle = BorderStyle.Fixed3D;
            lblReleaseNumb.FlatStyle = FlatStyle.Flat;
            lblReleaseNumb.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblReleaseNumb.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblReleaseNumb.Location = new Point(133, 54);
            lblReleaseNumb.Name = "lblReleaseNumb";
            lblReleaseNumb.Size = new Size(176, 27);
            lblReleaseNumb.TabIndex = 249;
            lblReleaseNumb.Text = "Drop off";
            lblReleaseNumb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCarrierCode
            // 
            lblCarrierCode.BackColor = Color.Linen;
            lblCarrierCode.BorderStyle = BorderStyle.Fixed3D;
            lblCarrierCode.FlatStyle = FlatStyle.Flat;
            lblCarrierCode.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCarrierCode.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblCarrierCode.Location = new Point(133, 88);
            lblCarrierCode.Name = "lblCarrierCode";
            lblCarrierCode.Size = new Size(176, 27);
            lblCarrierCode.TabIndex = 250;
            lblCarrierCode.Text = "Carrier Code";
            lblCarrierCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmAddEditDistRequest
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 289);
            Controls.Add(lblCarrierCode);
            Controls.Add(lblReleaseNumb);
            Controls.Add(lblDropOff);
            Controls.Add(lblPickUpCode);
            Controls.Add(Label6);
            Controls.Add(Label7);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(dtpToDate);
            Controls.Add(Label2);
            Controls.Add(nudQtyCans);
            Controls.Add(buttonsPanel);
            Controls.Add(_BunifuButton1);
            Controls.Add(Label15);
            Controls.Add(Label1);
            Controls.Add(dtpFromDate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddEditDistRequest";
            Text = "FrmAddEditDistRequest";
            ((System.ComponentModel.ISupportInitialize)nudQtyCans).EndInit();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label2;
        internal NumericUpDown nudQtyCans;
        internal TableLayoutPanel buttonsPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnComplete;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnComplete
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnComplete;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnComplete != null)
                {
                    _btnComplete.Click -= btnComplete_Click;
                }

                _btnComplete = value;
                if (_btnComplete != null)
                {
                    _btnComplete.Click += btnComplete_Click;
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
                    _btnCancel.Click -= BunifuButton1_Click;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += BunifuButton1_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _BunifuButton1;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton BunifuButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BunifuButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BunifuButton1 != null)
                {
                    _BunifuButton1.Click -= BunifuButton1_Click;
                }

                _BunifuButton1 = value;
                if (_BunifuButton1 != null)
                {
                    _BunifuButton1.Click += BunifuButton1_Click;
                }
            }
        }

        internal Label Label15;
        internal Label Label1;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        internal DateTimePicker dtpFromDate;
        internal Label Label3;
        internal DateTimePicker dtpToDate;
        internal Label Label4;
        internal Label Label5;
        internal Label lblReleaseNumb;
        internal Label lblDropOff;
        internal Label lblPickUpCode;
        internal Label Label6;
        internal Label Label7;
        internal Label lblCarrierCode;
    }
}