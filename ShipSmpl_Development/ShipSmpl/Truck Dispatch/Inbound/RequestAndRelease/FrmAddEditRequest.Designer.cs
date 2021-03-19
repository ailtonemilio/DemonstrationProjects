using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAddEditRequest : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditRequest));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            buttonsPanel = new TableLayoutPanel();
            _btnComplete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnComplete.Click += new EventHandler(btnComplete_Click);
            _btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancel.Click += new EventHandler(closeFlatButton_Click);
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label8 = new Label();
            cboCanState = new ComboBox();
            nudQtyCans = new NumericUpDown();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            lblWarning = new Label();
            Label6 = new Label();
            cboCanSize = new ComboBox();
            cboSSLine = new ComboBox();
            _cboReleaseType = new ComboBox();
            _cboReleaseType.SelectedIndexChanged += new EventHandler(cboReleaseType_SelectedIndexChanged);
            lblTitle = new Label();
            _cboBooking = new ComboBox();
            _cboBooking.SelectedIndexChanged += new EventHandler(cboBooking_SelectedIndexChanged);
            Label5 = new Label();
            pnlBooking = new Panel();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQtyCans).BeginInit();
            pnlBooking.SuspendLayout();
            SuspendLayout();
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.None;
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Controls.Add(_btnComplete, 0, 0);
            buttonsPanel.Controls.Add(_btnCancel, 1, 0);
            buttonsPanel.Location = new Point(157, 310);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(210, 39);
            buttonsPanel.TabIndex = 181;
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
            _btnComplete.Size = new Size(99, 33);
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
            _btnCancel.Location = new Point(112, 3);
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
            _btnCancel.Size = new Size(95, 33);
            _btnCancel.TabIndex = 137;
            _btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancel.TextMarginLeft = 0;
            _btnCancel.UseDefaultRadiusAndThickness = true;
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
            _closeFlatButton.Location = new Point(467, 0);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(43, 41);
            _closeFlatButton.TabIndex = 180;
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
            Label8.Size = new Size(510, 41);
            Label8.TabIndex = 179;
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboCanState
            // 
            cboCanState.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCanState.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboCanState.FormattingEnabled = true;
            cboCanState.Location = new Point(126, 196);
            cboCanState.Name = "cboCanState";
            cboCanState.Size = new Size(136, 26);
            cboCanState.TabIndex = 182;
            // 
            // nudQtyCans
            // 
            nudQtyCans.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            nudQtyCans.Location = new Point(126, 132);
            nudQtyCans.Name = "nudQtyCans";
            nudQtyCans.Size = new Size(105, 26);
            nudQtyCans.TabIndex = 183;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(21, 108);
            Label1.Name = "Label1";
            Label1.Size = new Size(99, 18);
            Label1.TabIndex = 184;
            Label1.Text = "Shipping Line:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(46, 140);
            Label2.Name = "Label2";
            Label2.Size = new Size(74, 18);
            Label2.TabIndex = 185;
            Label2.Text = "Qty Cans:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(74, 204);
            Label3.Name = "Label3";
            Label3.Size = new Size(46, 18);
            Label3.TabIndex = 186;
            Label3.Text = "State:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(79, 172);
            Label4.Name = "Label4";
            Label4.Size = new Size(41, 18);
            Label4.TabIndex = 187;
            Label4.Text = "Size:";
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWarning.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblWarning.Location = new Point(196, 79);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(51, 18);
            lblWarning.TabIndex = 188;
            lblWarning.Text = "Label5";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.Location = new Point(20, 236);
            Label6.Name = "Label6";
            Label6.Size = new Size(102, 18);
            Label6.TabIndex = 189;
            Label6.Text = "Release Type:";
            // 
            // cboCanSize
            // 
            cboCanSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCanSize.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboCanSize.FormattingEnabled = true;
            cboCanSize.Location = new Point(126, 164);
            cboCanSize.Name = "cboCanSize";
            cboCanSize.Size = new Size(121, 26);
            cboCanSize.TabIndex = 190;
            // 
            // cboSSLine
            // 
            cboSSLine.AutoCompleteMode = AutoCompleteMode.Append;
            cboSSLine.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboSSLine.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboSSLine.FormattingEnabled = true;
            cboSSLine.Location = new Point(126, 100);
            cboSSLine.Name = "cboSSLine";
            cboSSLine.Size = new Size(344, 26);
            cboSSLine.TabIndex = 191;
            // 
            // cboReleaseType
            // 
            _cboReleaseType.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboReleaseType.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboReleaseType.FormattingEnabled = true;
            _cboReleaseType.Location = new Point(126, 228);
            _cboReleaseType.Name = "_cboReleaseType";
            _cboReleaseType.Size = new Size(136, 26);
            _cboReleaseType.TabIndex = 192;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTitle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblTitle.Location = new Point(20, 61);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 24);
            lblTitle.TabIndex = 193;
            lblTitle.Text = "Create Request";
            // 
            // cboBooking
            // 
            _cboBooking.AutoCompleteMode = AutoCompleteMode.Append;
            _cboBooking.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboBooking.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboBooking.FormattingEnabled = true;
            _cboBooking.Location = new Point(113, 3);
            _cboBooking.Name = "_cboBooking";
            _cboBooking.Size = new Size(188, 26);
            _cboBooking.TabIndex = 195;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(28, 6);
            Label5.Name = "Label5";
            Label5.Size = new Size(79, 18);
            Label5.TabIndex = 194;
            Label5.Text = "Booking #:";
            // 
            // pnlBooking
            // 
            pnlBooking.Controls.Add(_cboBooking);
            pnlBooking.Controls.Add(Label5);
            pnlBooking.Location = new Point(12, 258);
            pnlBooking.Name = "pnlBooking";
            pnlBooking.Size = new Size(320, 38);
            pnlBooking.TabIndex = 196;
            // 
            // FrmAddEditRequest
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(510, 373);
            Controls.Add(pnlBooking);
            Controls.Add(lblTitle);
            Controls.Add(_cboReleaseType);
            Controls.Add(cboSSLine);
            Controls.Add(cboCanSize);
            Controls.Add(Label6);
            Controls.Add(lblWarning);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(nudQtyCans);
            Controls.Add(cboCanState);
            Controls.Add(buttonsPanel);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddEditRequest";
            Text = "FrmAddRequest";
            buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudQtyCans).EndInit();
            pnlBooking.ResumeLayout(false);
            pnlBooking.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

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
                    _btnCancel.Click -= closeFlatButton_Click;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += closeFlatButton_Click;
                }
            }
        }

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
        internal ComboBox cboCanState;
        internal NumericUpDown nudQtyCans;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label lblWarning;
        internal Label Label6;
        internal ComboBox cboCanSize;
        internal ComboBox cboSSLine;
        private ComboBox _cboReleaseType;

        internal ComboBox cboReleaseType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboReleaseType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboReleaseType != null)
                {
                    _cboReleaseType.SelectedIndexChanged -= cboReleaseType_SelectedIndexChanged;
                }

                _cboReleaseType = value;
                if (_cboReleaseType != null)
                {
                    _cboReleaseType.SelectedIndexChanged += cboReleaseType_SelectedIndexChanged;
                }
            }
        }

        internal Label lblTitle;
        private ComboBox _cboBooking;

        internal ComboBox cboBooking
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboBooking;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboBooking != null)
                {
                    _cboBooking.SelectedIndexChanged -= cboBooking_SelectedIndexChanged;
                }

                _cboBooking = value;
                if (_cboBooking != null)
                {
                    _cboBooking.SelectedIndexChanged += cboBooking_SelectedIndexChanged;
                }
            }
        }

        internal Label Label5;
        internal Panel pnlBooking;
    }
}