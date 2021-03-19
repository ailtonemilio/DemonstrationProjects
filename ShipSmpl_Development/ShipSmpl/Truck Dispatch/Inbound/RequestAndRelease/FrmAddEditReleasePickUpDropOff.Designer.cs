using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAddEditReleasePickUpDropOff : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditReleasePickUpDropOff));
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
            _btnCancel.Click += new EventHandler(btnCancel_Click);
            _btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _btnClose.Click += new EventHandler(btnCancel_Click);
            Label15 = new Label();
            Label1 = new Label();
            BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            Label3 = new Label();
            cbPickUp = new ComboBox();
            cbDropOff = new ComboBox();
            Label4 = new Label();
            lblRelOrder = new Label();
            ((System.ComponentModel.ISupportInitialize)nudQtyCans).BeginInit();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(62, 169);
            Label2.Name = "Label2";
            Label2.Size = new Size(66, 18);
            Label2.TabIndex = 234;
            Label2.Text = "Quantity:";
            // 
            // nudQtyCans
            // 
            nudQtyCans.Font = new Font("Microsoft Sans Serif", 13.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            nudQtyCans.Location = new Point(132, 166);
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
            buttonsPanel.Location = new Point(320, 204);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            buttonsPanel.Size = new Size(134, 31);
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
            _btnComplete.Size = new Size(59, 25);
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
            _btnCancel.Location = new Point(68, 3);
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
            _btnCancel.Size = new Size(63, 25);
            _btnCancel.TabIndex = 137;
            _btnCancel.TextAlign = ContentAlignment.MiddleCenter;
            _btnCancel.TextMarginLeft = 0;
            _btnCancel.UseDefaultRadiusAndThickness = true;
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
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _btnClose.CustomizableEdges = BorderEdges3;
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
            _btnClose.Location = new Point(454, -1);
            _btnClose.Name = "_btnClose";
            StateProperties5.BorderColor = Color.Silver;
            StateProperties5.BorderRadius = 20;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.Silver;
            StateProperties5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _btnClose.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.Silver;
            StateProperties6.BorderRadius = 20;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.Silver;
            StateProperties6.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _btnClose.OnPressedState = StateProperties6;
            _btnClose.Size = new Size(25, 25);
            _btnClose.TabIndex = 237;
            _btnClose.TextAlign = ContentAlignment.MiddleCenter;
            _btnClose.TextMarginLeft = 0;
            _btnClose.UseDefaultRadiusAndThickness = true;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Font = new Font("Segoe UI Semibold", 14.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label15.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label15.Location = new Point(25, 20);
            Label15.Name = "Label15";
            Label15.Size = new Size(404, 25);
            Label15.TabIndex = 236;
            Label15.Text = "Add Containers Pick up/Drop off information ";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(62, 96);
            Label1.Name = "Label1";
            Label1.Size = new Size(64, 18);
            Label1.TabIndex = 235;
            Label1.Text = "Pick Up:";
            // 
            // BunifuElipse1
            // 
            BunifuElipse1.ElipseRadius = 20;
            BunifuElipse1.TargetControl = this;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(57, 135);
            Label3.Name = "Label3";
            Label3.Size = new Size(69, 18);
            Label3.TabIndex = 238;
            Label3.Text = "Drop Off:";
            // 
            // cbPickUp
            // 
            cbPickUp.AutoCompleteMode = AutoCompleteMode.Append;
            cbPickUp.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbPickUp.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cbPickUp.FormattingEnabled = true;
            cbPickUp.Location = new Point(132, 93);
            cbPickUp.Name = "cbPickUp";
            cbPickUp.Size = new Size(318, 26);
            cbPickUp.TabIndex = 239;
            // 
            // cbDropOff
            // 
            cbDropOff.AutoCompleteMode = AutoCompleteMode.Append;
            cbDropOff.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbDropOff.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cbDropOff.FormattingEnabled = true;
            cbDropOff.Location = new Point(132, 132);
            cbDropOff.Name = "cbDropOff";
            cbDropOff.Size = new Size(186, 26);
            cbDropOff.TabIndex = 240;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(18, 62);
            Label4.Name = "Label4";
            Label4.Size = new Size(108, 18);
            Label4.TabIndex = 241;
            Label4.Text = "Release Order:";
            // 
            // lblRelOrder
            // 
            lblRelOrder.AutoSize = true;
            lblRelOrder.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblRelOrder.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            lblRelOrder.Location = new Point(132, 62);
            lblRelOrder.Name = "lblRelOrder";
            lblRelOrder.Size = new Size(72, 18);
            lblRelOrder.TabIndex = 242;
            lblRelOrder.Text = "Pick Up:";
            // 
            // FrmAddEditReleasePickUpDropOff
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(480, 253);
            Controls.Add(lblRelOrder);
            Controls.Add(Label4);
            Controls.Add(cbDropOff);
            Controls.Add(cbPickUp);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(nudQtyCans);
            Controls.Add(buttonsPanel);
            Controls.Add(_btnClose);
            Controls.Add(Label15);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddEditReleasePickUpDropOff";
            Text = "FrmAddReleasePickUpDropOff";
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
                    _btnCancel.Click -= btnCancel_Click;
                }

                _btnCancel = value;
                if (_btnCancel != null)
                {
                    _btnCancel.Click += btnCancel_Click;
                }
            }
        }

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

        internal Label Label15;
        internal Label Label1;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        internal Label Label3;
        internal ComboBox cbDropOff;
        internal ComboBox cbPickUp;
        internal Label lblRelOrder;
        internal Label Label4;
    }
}