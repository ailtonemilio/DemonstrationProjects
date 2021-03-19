using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmManageReleaseBalance : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageReleaseBalance));
            var BorderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Label2 = new Label();
            lblTitle = new Label();
            _btnComplete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnComplete.Click += new EventHandler(btnComplete_Click);
            _btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnCancel.Click += new EventHandler(btnCancel_Click);
            nudQtyCans = new NumericUpDown();
            buttonsPanel = new TableLayoutPanel();
            BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            _btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnClose.Click += new EventHandler(btnCancel_Click);
            Label1 = new Label();
            _cboDelineStatus = new ComboBox();
            _cboDelineStatus.SelectedIndexChanged += new EventHandler(cboDelineStatus_SelectedIndexChanged);
            Label3 = new Label();
            _tbNotes = new RichTextBox();
            _tbNotes.TextChanged += new EventHandler(cboDelineStatus_SelectedIndexChanged);
            lblWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)nudQtyCans).BeginInit();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(66, 121);
            Label2.Name = "Label2";
            Label2.Size = new Size(66, 18);
            Label2.TabIndex = 273;
            Label2.Text = "Quantity:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTitle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblTitle.Location = new Point(34, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(298, 25);
            lblTitle.TabIndex = 274;
            lblTitle.Text = "Manage inbound request balance";
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
            BorderEdges7.BottomLeft = true;
            BorderEdges7.BottomRight = true;
            BorderEdges7.TopLeft = true;
            BorderEdges7.TopRight = true;
            _btnComplete.CustomizableEdges = BorderEdges7;
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
            StateProperties13.BorderColor = Color.MediumTurquoise;
            StateProperties13.BorderRadius = 3;
            StateProperties13.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties13.BorderThickness = 1;
            StateProperties13.FillColor = Color.MediumTurquoise;
            StateProperties13.ForeColor = Color.White;
            StateProperties13.IconLeftImage = null;
            StateProperties13.IconRightImage = null;
            _btnComplete.onHoverState = StateProperties13;
            StateProperties14.BorderColor = Color.Teal;
            StateProperties14.BorderRadius = 3;
            StateProperties14.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties14.BorderThickness = 1;
            StateProperties14.FillColor = Color.Teal;
            StateProperties14.ForeColor = Color.White;
            StateProperties14.IconLeftImage = null;
            StateProperties14.IconRightImage = null;
            _btnComplete.OnPressedState = StateProperties14;
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
            BorderEdges8.BottomLeft = true;
            BorderEdges8.BottomRight = true;
            BorderEdges8.TopLeft = true;
            BorderEdges8.TopRight = true;
            _btnCancel.CustomizableEdges = BorderEdges8;
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
            StateProperties15.BorderColor = Color.DarkGray;
            StateProperties15.BorderRadius = 3;
            StateProperties15.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties15.BorderThickness = 1;
            StateProperties15.FillColor = Color.DarkGray;
            StateProperties15.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties15.IconLeftImage = null;
            StateProperties15.IconRightImage = null;
            _btnCancel.onHoverState = StateProperties15;
            StateProperties16.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties16.BorderRadius = 3;
            StateProperties16.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties16.BorderThickness = 1;
            StateProperties16.FillColor = Color.White;
            StateProperties16.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties16.IconLeftImage = null;
            StateProperties16.IconRightImage = null;
            _btnCancel.OnPressedState = StateProperties16;
            _btnCancel.Size = new Size(70, 24);
            _btnCancel.TabIndex = 137;
            _btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancel.TextMarginLeft = 0;
            _btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // nudQtyCans
            // 
            nudQtyCans.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            nudQtyCans.Location = new Point(138, 118);
            nudQtyCans.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQtyCans.Name = "nudQtyCans";
            nudQtyCans.Size = new Size(105, 27);
            nudQtyCans.TabIndex = 272;
            nudQtyCans.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.25373f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.74627f));
            buttonsPanel.Controls.Add(_btnComplete, 0, 0);
            buttonsPanel.Controls.Add(_btnCancel, 1, 0);
            buttonsPanel.Location = new Point(233, 243);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(150, 31);
            buttonsPanel.TabIndex = 271;
            // 
            // BunifuElipse1
            // 
            BunifuElipse1.ElipseRadius = 20;
            BunifuElipse1.TargetControl = this;
            // 
            // btnClose
            // 
            _btnClose.AllowToggling = false;
            _btnClose.AnimationSpeed = 200;
            _btnClose.AutoGenerateColors = false;
            _btnClose.BackColor = Color.Transparent;
            _btnClose.BackColor1 = Color.White;
            _btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            _btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _btnClose.ButtonText = "🗙";
            _btnClose.ButtonTextMarginLeft = 0;
            _btnClose.ColorContrastOnClick = 45;
            _btnClose.ColorContrastOnHover = 45;
            _btnClose.Cursor = Cursors.Hand;
            BorderEdges9.BottomLeft = true;
            BorderEdges9.BottomRight = true;
            BorderEdges9.TopLeft = true;
            BorderEdges9.TopRight = true;
            _btnClose.CustomizableEdges = BorderEdges9;
            _btnClose.DialogResult = DialogResult.None;
            _btnClose.DisabledBorderColor = Color.Empty;
            _btnClose.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _btnClose.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _btnClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _btnClose.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnClose.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _btnClose.IconLeftCursor = Cursors.Hand;
            _btnClose.IconMarginLeft = 11;
            _btnClose.IconPadding = 10;
            _btnClose.IconRightCursor = Cursors.Hand;
            _btnClose.IdleBorderColor = Color.White;
            _btnClose.IdleBorderRadius = 20;
            _btnClose.IdleBorderThickness = 1;
            _btnClose.IdleFillColor = Color.White;
            _btnClose.IdleIconLeftImage = null;
            _btnClose.IdleIconRightImage = null;
            _btnClose.IndicateFocus = true;
            _btnClose.Location = new Point(584, 2);
            _btnClose.Name = "_btnClose";
            StateProperties17.BorderColor = Color.Silver;
            StateProperties17.BorderRadius = 20;
            StateProperties17.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties17.BorderThickness = 1;
            StateProperties17.FillColor = Color.Silver;
            StateProperties17.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties17.IconLeftImage = null;
            StateProperties17.IconRightImage = null;
            _btnClose.onHoverState = StateProperties17;
            StateProperties18.BorderColor = Color.Silver;
            StateProperties18.BorderRadius = 20;
            StateProperties18.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties18.BorderThickness = 1;
            StateProperties18.FillColor = Color.Silver;
            StateProperties18.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties18.IconLeftImage = null;
            StateProperties18.IconRightImage = null;
            _btnClose.OnPressedState = StateProperties18;
            _btnClose.Size = new Size(25, 25);
            _btnClose.TabIndex = 279;
            _btnClose.TextAlign = ContentAlignment.MiddleCenter;
            _btnClose.TextMarginLeft = 0;
            _btnClose.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(68, 87);
            Label1.Name = "Label1";
            Label1.Size = new Size(64, 18);
            Label1.TabIndex = 278;
            Label1.Text = "Reason:";
            // 
            // cboDelineStatus
            // 
            _cboDelineStatus.AutoCompleteMode = AutoCompleteMode.Append;
            _cboDelineStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
            _cboDelineStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            _cboDelineStatus.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _cboDelineStatus.FormattingEnabled = true;
            _cboDelineStatus.Location = new Point(138, 83);
            _cboDelineStatus.Name = "_cboDelineStatus";
            _cboDelineStatus.Size = new Size(307, 28);
            _cboDelineStatus.TabIndex = 277;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(80, 151);
            Label3.Name = "Label3";
            Label3.Size = new Size(52, 18);
            Label3.TabIndex = 280;
            Label3.Text = "Notes:";
            // 
            // tbNotes
            // 
            _tbNotes.Location = new Point(138, 151);
            _tbNotes.Name = "_tbNotes";
            _tbNotes.Size = new Size(375, 69);
            _tbNotes.TabIndex = 281;
            _tbNotes.Text = "";
            // 
            // lblWarning
            // 
            lblWarning.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWarning.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblWarning.Location = new Point(148, 54);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(424, 18);
            lblWarning.TabIndex = 282;
            lblWarning.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmManageReleaseBalance
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(612, 295);
            Controls.Add(lblWarning);
            Controls.Add(_tbNotes);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(lblTitle);
            Controls.Add(nudQtyCans);
            Controls.Add(buttonsPanel);
            Controls.Add(_btnClose);
            Controls.Add(Label1);
            Controls.Add(_cboDelineStatus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmManageReleaseBalance";
            Text = "FrmManageReleaseBalance";
            ((System.ComponentModel.ISupportInitialize)nudQtyCans).EndInit();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label2;
        internal Label lblTitle;
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
                    _btnCancel.Click -= btnCancel_Click;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += btnCancel_Click;
                }
            }
        }

        internal NumericUpDown nudQtyCans;
        internal TableLayoutPanel buttonsPanel;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _btnClose;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnClose;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnClose != null)
                {
                    _btnClose.Click -= btnCancel_Click;
                }

                _btnClose = value;
                if (_btnClose != null)
                {
                    _btnClose.Click += btnCancel_Click;
                }
            }
        }

        internal Label Label1;
        private ComboBox _cboDelineStatus;

        internal ComboBox cboDelineStatus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cboDelineStatus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cboDelineStatus != null)
                {
                    _cboDelineStatus.SelectedIndexChanged -= cboDelineStatus_SelectedIndexChanged;
                }

                _cboDelineStatus = value;
                if (_cboDelineStatus != null)
                {
                    _cboDelineStatus.SelectedIndexChanged += cboDelineStatus_SelectedIndexChanged;
                }
            }
        }

        private RichTextBox _tbNotes;

        internal RichTextBox tbNotes
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbNotes;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbNotes != null)
                {
                    _tbNotes.TextChanged -= cboDelineStatus_SelectedIndexChanged;
                }

                _tbNotes = value;
                if (_tbNotes != null)
                {
                    _tbNotes.TextChanged += cboDelineStatus_SelectedIndexChanged;
                }
            }
        }

        internal Label Label3;
        internal Label lblWarning;
    }
}