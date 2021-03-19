using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmRelDistSchDeclined : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelDistSchDeclined));
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
            lblTitle = new Label();
            _btnComplete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnComplete.Click += new EventHandler(btnComplete_Click);
            btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            nudQtyCans = new NumericUpDown();
            buttonsPanel = new TableLayoutPanel();
            BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            lblWarning = new Label();
            tbNotes = new RichTextBox();
            Label3 = new Label();
            btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            Label1 = new Label();
            cboDelineStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudQtyCans).BeginInit();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(55, 119);
            Label2.Name = "Label2";
            Label2.Size = new Size(66, 18);
            Label2.TabIndex = 285;
            Label2.Text = "Quantity:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblTitle.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblTitle.Location = new Point(23, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(276, 25);
            lblTitle.TabIndex = 286;
            lblTitle.Text = "Distribution Schedule Declined";
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
            btnCancel.AllowToggling = false;
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.AnimationSpeed = 200;
            btnCancel.AutoGenerateColors = false;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackColor1 = Color.White;
            btnCancel.BackgroundImage = (Image)resources.GetObject("btnCancel.BackgroundImage");
            btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnCancel.ButtonText = "Cancel";
            btnCancel.ButtonTextMarginLeft = 0;
            btnCancel.ColorContrastOnClick = 45;
            btnCancel.ColorContrastOnHover = 45;
            btnCancel.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            btnCancel.CustomizableEdges = BorderEdges2;
            btnCancel.DialogResult = DialogResult.None;
            btnCancel.DisabledBorderColor = Color.Empty;
            btnCancel.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            btnCancel.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnCancel.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            btnCancel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            btnCancel.IconLeftCursor = Cursors.Hand;
            btnCancel.IconMarginLeft = 11;
            btnCancel.IconPadding = 10;
            btnCancel.IconRightCursor = Cursors.Hand;
            btnCancel.IdleBorderColor = Color.Gray;
            btnCancel.IdleBorderRadius = 3;
            btnCancel.IdleBorderThickness = 1;
            btnCancel.IdleFillColor = Color.White;
            btnCancel.IdleIconLeftImage = null;
            btnCancel.IdleIconRightImage = null;
            btnCancel.IndicateFocus = true;
            btnCancel.Location = new Point(77, 3);
            btnCancel.Name = "btnCancel";
            StateProperties3.BorderColor = Color.DarkGray;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.DarkGray;
            StateProperties3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            btnCancel.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.White;
            StateProperties4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            btnCancel.OnPressedState = StateProperties4;
            btnCancel.Size = new Size(70, 24);
            btnCancel.TabIndex = 137;
            btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            btnCancel.TextMarginLeft = 0;
            btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // nudQtyCans
            // 
            nudQtyCans.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            nudQtyCans.Location = new Point(127, 116);
            nudQtyCans.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQtyCans.Name = "nudQtyCans";
            nudQtyCans.Size = new Size(105, 27);
            nudQtyCans.TabIndex = 284;
            nudQtyCans.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.25373f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.74627f));
            buttonsPanel.Controls.Add(_btnComplete, 0, 0);
            buttonsPanel.Controls.Add(btnCancel, 1, 0);
            buttonsPanel.Location = new Point(222, 241);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(150, 31);
            buttonsPanel.TabIndex = 283;
            // 
            // BunifuElipse1
            // 
            BunifuElipse1.ElipseRadius = 20;
            BunifuElipse1.TargetControl = this;
            // 
            // lblWarning
            // 
            lblWarning.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblWarning.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            lblWarning.Location = new Point(137, 52);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(424, 18);
            lblWarning.TabIndex = 292;
            lblWarning.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbNotes
            // 
            tbNotes.Location = new Point(127, 149);
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(375, 69);
            tbNotes.TabIndex = 291;
            tbNotes.Text = "";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(69, 149);
            Label3.Name = "Label3";
            Label3.Size = new Size(52, 18);
            Label3.TabIndex = 290;
            Label3.Text = "Notes:";
            // 
            // btnClose
            // 
            btnClose.AllowToggling = false;
            btnClose.AnimationSpeed = 200;
            btnClose.AutoGenerateColors = false;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackColor1 = Color.White;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            btnClose.ButtonText = "🗙";
            btnClose.ButtonTextMarginLeft = 0;
            btnClose.ColorContrastOnClick = 45;
            btnClose.ColorContrastOnHover = 45;
            btnClose.Cursor = Cursors.Hand;
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            btnClose.CustomizableEdges = BorderEdges3;
            btnClose.DialogResult = DialogResult.None;
            btnClose.DisabledBorderColor = Color.Empty;
            btnClose.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            btnClose.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            btnClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            btnClose.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            btnClose.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            btnClose.IconLeftCursor = Cursors.Hand;
            btnClose.IconMarginLeft = 11;
            btnClose.IconPadding = 10;
            btnClose.IconRightCursor = Cursors.Hand;
            btnClose.IdleBorderColor = Color.White;
            btnClose.IdleBorderRadius = 20;
            btnClose.IdleBorderThickness = 1;
            btnClose.IdleFillColor = Color.White;
            btnClose.IdleIconLeftImage = null;
            btnClose.IdleIconRightImage = null;
            btnClose.IndicateFocus = true;
            btnClose.Location = new Point(542, 3);
            btnClose.Name = "btnClose";
            StateProperties5.BorderColor = Color.Silver;
            StateProperties5.BorderRadius = 20;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.Silver;
            StateProperties5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            btnClose.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Silver;
            StateProperties6.BorderRadius = 20;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Silver;
            StateProperties6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            btnClose.OnPressedState = StateProperties6;
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 289;
            btnClose.TextAlign = ContentAlignment.MiddleCenter;
            btnClose.TextMarginLeft = 0;
            btnClose.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(57, 85);
            Label1.Name = "Label1";
            Label1.Size = new Size(64, 18);
            Label1.TabIndex = 288;
            Label1.Text = "Reason:";
            // 
            // cboDelineStatus
            // 
            cboDelineStatus.AutoCompleteMode = AutoCompleteMode.Append;
            cboDelineStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboDelineStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDelineStatus.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboDelineStatus.FormattingEnabled = true;
            cboDelineStatus.Items.AddRange(new object[] { "DECLINED" });
            cboDelineStatus.Location = new Point(127, 81);
            cboDelineStatus.Name = "cboDelineStatus";
            cboDelineStatus.Size = new Size(269, 28);
            cboDelineStatus.TabIndex = 287;
            // 
            // FrmRelDistSchDeclined
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(577, 294);
            Controls.Add(Label2);
            Controls.Add(lblTitle);
            Controls.Add(nudQtyCans);
            Controls.Add(buttonsPanel);
            Controls.Add(lblWarning);
            Controls.Add(tbNotes);
            Controls.Add(Label3);
            Controls.Add(btnClose);
            Controls.Add(Label1);
            Controls.Add(cboDelineStatus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRelDistSchDeclined";
            Text = "FrmRelDistSchDeclined";
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

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        internal NumericUpDown nudQtyCans;
        internal TableLayoutPanel buttonsPanel;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        internal Label lblWarning;
        internal RichTextBox tbNotes;
        internal Label Label3;
        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        internal Label Label1;
        internal ComboBox cboDelineStatus;
    }
}