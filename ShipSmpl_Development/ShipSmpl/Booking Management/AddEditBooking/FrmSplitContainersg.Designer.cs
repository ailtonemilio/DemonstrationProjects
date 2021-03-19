using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmSplitContainersg : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplitContainersg));
            var BorderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeLabel = new Label();
            _closeLabel.MouseHover += new EventHandler(closeLabel_MouseHover);
            _closeLabel.MouseLeave += new EventHandler(closeLabel_MouseLeave);
            _closeLabel.Click += new EventHandler(closeLabel_Click);
            Label12 = new Label();
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(cancelButton_Click);
            _addButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _addButton.Click += new EventHandler(splitButton_Click);
            Label1 = new Label();
            Label2 = new Label();
            _numMBNumericUpDown = new NumericUpDown();
            _numMBNumericUpDown.ValueChanged += new EventHandler(numMBNumericUpDown_ValueChanged);
            warningLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)_numMBNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(472, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 46);
            _closeLabel.TabIndex = 137;
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
            Label12.Size = new Size(520, 46);
            Label12.TabIndex = 136;
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            _cancelButton.AllowToggling = false;
            _cancelButton.Anchor = AnchorStyles.Right;
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
            BorderEdges3.BottomLeft = true;
            BorderEdges3.BottomRight = true;
            BorderEdges3.TopLeft = true;
            BorderEdges3.TopRight = true;
            _cancelButton.CustomizableEdges = BorderEdges3;
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
            _cancelButton.Location = new Point(421, 211);
            _cancelButton.Name = "_cancelButton";
            StateProperties5.BorderColor = Color.DarkGray;
            StateProperties5.BorderRadius = 3;
            StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties5.BorderThickness = 1;
            StateProperties5.FillColor = Color.DarkGray;
            StateProperties5.ForeColor = Color.White;
            StateProperties5.IconLeftImage = null;
            StateProperties5.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties5;
            StateProperties6.BorderColor = Color.IndianRed;
            StateProperties6.BorderRadius = 3;
            StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties6.BorderThickness = 1;
            StateProperties6.FillColor = Color.IndianRed;
            StateProperties6.ForeColor = Color.White;
            StateProperties6.IconLeftImage = null;
            StateProperties6.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties6;
            _cancelButton.Size = new Size(86, 34);
            _cancelButton.TabIndex = 135;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // addButton
            // 
            _addButton.AllowToggling = false;
            _addButton.Anchor = AnchorStyles.Right;
            _addButton.AnimationSpeed = 200;
            _addButton.AutoGenerateColors = false;
            _addButton.BackColor = Color.Transparent;
            _addButton.BackColor1 = Color.Teal;
            _addButton.BackgroundImage = (Image)resources.GetObject("addButton.BackgroundImage");
            _addButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _addButton.ButtonText = "Add Minibooking";
            _addButton.ButtonTextMarginLeft = 0;
            _addButton.ColorContrastOnClick = 45;
            _addButton.ColorContrastOnHover = 45;
            _addButton.Cursor = Cursors.Hand;
            BorderEdges4.BottomLeft = true;
            BorderEdges4.BottomRight = true;
            BorderEdges4.TopLeft = true;
            BorderEdges4.TopRight = true;
            _addButton.CustomizableEdges = BorderEdges4;
            _addButton.DialogResult = DialogResult.None;
            _addButton.DisabledBorderColor = Color.Empty;
            _addButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _addButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _addButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _addButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _addButton.ForeColor = Color.White;
            _addButton.IconLeftCursor = Cursors.Hand;
            _addButton.IconMarginLeft = 11;
            _addButton.IconPadding = 10;
            _addButton.IconRightCursor = Cursors.Hand;
            _addButton.IdleBorderColor = Color.Teal;
            _addButton.IdleBorderRadius = 3;
            _addButton.IdleBorderThickness = 1;
            _addButton.IdleFillColor = Color.Teal;
            _addButton.IdleIconLeftImage = null;
            _addButton.IdleIconRightImage = null;
            _addButton.IndicateFocus = true;
            _addButton.Location = new Point(254, 211);
            _addButton.Name = "_addButton";
            StateProperties7.BorderColor = Color.MediumTurquoise;
            StateProperties7.BorderRadius = 3;
            StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties7.BorderThickness = 1;
            StateProperties7.FillColor = Color.MediumTurquoise;
            StateProperties7.ForeColor = Color.White;
            StateProperties7.IconLeftImage = null;
            StateProperties7.IconRightImage = null;
            _addButton.onHoverState = StateProperties7;
            StateProperties8.BorderColor = Color.Teal;
            StateProperties8.BorderRadius = 3;
            StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties8.BorderThickness = 1;
            StateProperties8.FillColor = Color.Teal;
            StateProperties8.ForeColor = Color.White;
            StateProperties8.IconLeftImage = null;
            StateProperties8.IconRightImage = null;
            _addButton.OnPressedState = StateProperties8;
            _addButton.Size = new Size(161, 34);
            _addButton.TabIndex = 134;
            _addButton.TextAlign = ContentAlignment.MiddleCenter;
            _addButton.TextMarginLeft = 0;
            _addButton.UseDefaultRadiusAndThickness = true;
            // 
            // Label1
            // 
            Label1.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(7, 53);
            Label1.Name = "Label1";
            Label1.Size = new Size(501, 58);
            Label1.TabIndex = 138;
            Label1.Text = "Set the number of containers that will split to the new Mini Booking";
            // 
            // Label2
            // 
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(47, 114);
            Label2.Name = "Label2";
            Label2.Size = new Size(201, 34);
            Label2.TabIndex = 139;
            Label2.Text = "Number of containers:";
            // 
            // numMBNumericUpDown
            // 
            _numMBNumericUpDown.Anchor = AnchorStyles.Left;
            _numMBNumericUpDown.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _numMBNumericUpDown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _numMBNumericUpDown.Location = new Point(245, 108);
            _numMBNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            _numMBNumericUpDown.Name = "_numMBNumericUpDown";
            _numMBNumericUpDown.Size = new Size(111, 35);
            _numMBNumericUpDown.TabIndex = 140;
            _numMBNumericUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // warningLabel
            // 
            warningLabel.Font = new Font("Segoe UI Semibold", 9.818182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            warningLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            warningLabel.Location = new Point(32, 145);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(449, 50);
            warningLabel.TabIndex = 141;
            warningLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmSplitContainersg
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(520, 257);
            Controls.Add(warningLabel);
            Controls.Add(_numMBNumericUpDown);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(_closeLabel);
            Controls.Add(Label12);
            Controls.Add(_cancelButton);
            Controls.Add(_addButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSplitContainersg";
            Text = "FrmSplitBooking";
            ((System.ComponentModel.ISupportInitialize)_numMBNumericUpDown).EndInit();
            Load += new EventHandler(FrmSplitBooking_Load);
            ResumeLayout(false);
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
                    _closeLabel.MouseHover -= closeLabel_MouseHover;
                    _closeLabel.MouseLeave -= closeLabel_MouseLeave;
                    _closeLabel.Click -= closeLabel_Click;
                }

                _closeLabel = value;
                if (_closeLabel != null)
                {
                    _closeLabel.MouseHover += closeLabel_MouseHover;
                    _closeLabel.MouseLeave += closeLabel_MouseLeave;
                    _closeLabel.Click += closeLabel_Click;
                }
            }
        }

        internal Label Label12;
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

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _addButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton addButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _addButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_addButton != null)
                {
                    _addButton.Click -= splitButton_Click;
                }

                _addButton = value;
                if (_addButton != null)
                {
                    _addButton.Click += splitButton_Click;
                }
            }
        }

        internal Label Label1;
        internal Label Label2;
        private NumericUpDown _numMBNumericUpDown;

        internal NumericUpDown numMBNumericUpDown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _numMBNumericUpDown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_numMBNumericUpDown != null)
                {
                    _numMBNumericUpDown.ValueChanged -= numMBNumericUpDown_ValueChanged;
                }

                _numMBNumericUpDown = value;
                if (_numMBNumericUpDown != null)
                {
                    _numMBNumericUpDown.ValueChanged += numMBNumericUpDown_ValueChanged;
                }
            }
        }

        internal Label warningLabel;
    }
}