using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmChangeEDI : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangeEDI));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            Label12 = new Label();
            Label1 = new Label();
            currentEDILabel = new Label();
            _changeEDIButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _changeEDIButton.Click += new EventHandler(changeEDIButton_Click);
            changeLabel = new Label();
            _systemEDIRadioButton = new Bunifu.UI.WinForms.BunifuRadioButton();
            _systemEDIRadioButton.CheckedChanged += new EventHandler(currentEDIRadioButton_Click);
            Label2 = new Label();
            _changeEDIRadioButton = new Bunifu.UI.WinForms.BunifuRadioButton();
            _changeEDIRadioButton.CheckedChanged += new EventHandler(changeEDIRadioButton_Click);
            EDIDateTimePicker = new DateTimePicker();
            EdiTimePicker = new DateTimePicker();
            atLabel = new Label();
            SuspendLayout();
            // 
            // closeFlatButton
            // 
            _closeFlatButton.Active = false;
            _closeFlatButton.Activecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
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
            _closeFlatButton.Location = new Point(585, 0);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(44, 42);
            _closeFlatButton.TabIndex = 169;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 18.32727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // Label12
            // 
            Label12.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Dock = DockStyle.Top;
            Label12.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label12.Location = new Point(0, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(629, 42);
            Label12.TabIndex = 168;
            Label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(27, 52);
            Label1.Name = "Label1";
            Label1.Size = new Size(72, 21);
            Label1.TabIndex = 170;
            Label1.Text = "EDI Date";
            // 
            // currentEDILabel
            // 
            currentEDILabel.AutoSize = true;
            currentEDILabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            currentEDILabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            currentEDILabel.Location = new Point(104, 119);
            currentEDILabel.Name = "currentEDILabel";
            currentEDILabel.Size = new Size(360, 21);
            currentEDILabel.TabIndex = 171;
            currentEDILabel.Text = "System EDI Date/Time ( 01-JAN-1999 @ 11:11 AM)";
            // 
            // changeEDIButton
            // 
            _changeEDIButton.AllowToggling = false;
            _changeEDIButton.AnimationSpeed = 200;
            _changeEDIButton.AutoGenerateColors = false;
            _changeEDIButton.BackColor = Color.Transparent;
            _changeEDIButton.BackColor1 = Color.Teal;
            _changeEDIButton.BackgroundImage = (Image)resources.GetObject("changeEDIButton.BackgroundImage");
            _changeEDIButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _changeEDIButton.ButtonText = "OK";
            _changeEDIButton.ButtonTextMarginLeft = 0;
            _changeEDIButton.ColorContrastOnClick = 45;
            _changeEDIButton.ColorContrastOnHover = 45;
            _changeEDIButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _changeEDIButton.CustomizableEdges = BorderEdges1;
            _changeEDIButton.DialogResult = DialogResult.None;
            _changeEDIButton.DisabledBorderColor = Color.Empty;
            _changeEDIButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _changeEDIButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _changeEDIButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _changeEDIButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _changeEDIButton.ForeColor = Color.White;
            _changeEDIButton.IconLeftCursor = Cursors.Hand;
            _changeEDIButton.IconMarginLeft = 11;
            _changeEDIButton.IconPadding = 10;
            _changeEDIButton.IconRightCursor = Cursors.Hand;
            _changeEDIButton.IdleBorderColor = Color.Teal;
            _changeEDIButton.IdleBorderRadius = 3;
            _changeEDIButton.IdleBorderThickness = 1;
            _changeEDIButton.IdleFillColor = Color.Teal;
            _changeEDIButton.IdleIconLeftImage = null;
            _changeEDIButton.IdleIconRightImage = null;
            _changeEDIButton.IndicateFocus = true;
            _changeEDIButton.Location = new Point(266, 237);
            _changeEDIButton.Name = "_changeEDIButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _changeEDIButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _changeEDIButton.OnPressedState = StateProperties2;
            _changeEDIButton.Size = new Size(111, 34);
            _changeEDIButton.TabIndex = 172;
            _changeEDIButton.TextAlign = ContentAlignment.MiddleCenter;
            _changeEDIButton.TextMarginLeft = 0;
            _changeEDIButton.UseDefaultRadiusAndThickness = true;
            // 
            // changeLabel
            // 
            changeLabel.AutoSize = true;
            changeLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            changeLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            changeLabel.Location = new Point(104, 162);
            changeLabel.Name = "changeLabel";
            changeLabel.Size = new Size(178, 21);
            changeLabel.TabIndex = 173;
            changeLabel.Text = "Change EDI Date/Time:";
            // 
            // systemEDIRadioButton
            // 
            _systemEDIRadioButton.Checked = true;
            _systemEDIRadioButton.Location = new Point(75, 121);
            _systemEDIRadioButton.Name = "_systemEDIRadioButton";
            _systemEDIRadioButton.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _systemEDIRadioButton.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _systemEDIRadioButton.Size = new Size(25, 25);
            _systemEDIRadioButton.TabIndex = 174;
            _systemEDIRadioButton.Text = null;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(54, 79);
            Label2.Name = "Label2";
            Label2.Size = new Size(345, 21);
            Label2.TabIndex = 175;
            Label2.Text = "What EDI Date and Time would you like to send?";
            // 
            // changeEDIRadioButton
            // 
            _changeEDIRadioButton.Checked = false;
            _changeEDIRadioButton.Location = new Point(75, 163);
            _changeEDIRadioButton.Name = "_changeEDIRadioButton";
            _changeEDIRadioButton.OutlineColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _changeEDIRadioButton.RadioColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            _changeEDIRadioButton.Size = new Size(25, 25);
            _changeEDIRadioButton.TabIndex = 176;
            _changeEDIRadioButton.Text = null;
            // 
            // EDIDateTimePicker
            // 
            EDIDateTimePicker.CustomFormat = "dd-MMM-yyyy";
            EDIDateTimePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            EDIDateTimePicker.Format = DateTimePickerFormat.Custom;
            EDIDateTimePicker.Location = new Point(326, 159);
            EDIDateTimePicker.Name = "EDIDateTimePicker";
            EDIDateTimePicker.Size = new Size(158, 28);
            EDIDateTimePicker.TabIndex = 177;
            // 
            // EdiTimePicker
            // 
            EdiTimePicker.CustomFormat = "hh:mm tt";
            EdiTimePicker.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            EdiTimePicker.Format = DateTimePickerFormat.Custom;
            EdiTimePicker.Location = new Point(512, 159);
            EdiTimePicker.Name = "EdiTimePicker";
            EdiTimePicker.ShowUpDown = true;
            EdiTimePicker.Size = new Size(103, 28);
            EdiTimePicker.TabIndex = 178;
            // 
            // atLabel
            // 
            atLabel.AutoSize = true;
            atLabel.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            atLabel.Location = new Point(483, 162);
            atLabel.Name = "atLabel";
            atLabel.Size = new Size(25, 21);
            atLabel.TabIndex = 179;
            atLabel.Text = "@";
            // 
            // FrmChangeEDI
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(629, 283);
            Controls.Add(EdiTimePicker);
            Controls.Add(EDIDateTimePicker);
            Controls.Add(_changeEDIRadioButton);
            Controls.Add(Label2);
            Controls.Add(_systemEDIRadioButton);
            Controls.Add(changeLabel);
            Controls.Add(_changeEDIButton);
            Controls.Add(currentEDILabel);
            Controls.Add(Label1);
            Controls.Add(_closeFlatButton);
            Controls.Add(Label12);
            Controls.Add(atLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmChangeEDI";
            Text = "FrmChangeEDI";
            Load += new EventHandler(FrmChangeEDI_Load);
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

        internal Label Label12;
        internal Label Label1;
        internal Label currentEDILabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _changeEDIButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton changeEDIButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _changeEDIButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_changeEDIButton != null)
                {
                    _changeEDIButton.Click -= changeEDIButton_Click;
                }

                _changeEDIButton = value;
                if (_changeEDIButton != null)
                {
                    _changeEDIButton.Click += changeEDIButton_Click;
                }
            }
        }

        internal Label changeLabel;
        private Bunifu.UI.WinForms.BunifuRadioButton _systemEDIRadioButton;

        internal Bunifu.UI.WinForms.BunifuRadioButton systemEDIRadioButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _systemEDIRadioButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_systemEDIRadioButton != null)
                {
                    _systemEDIRadioButton.CheckedChanged -= currentEDIRadioButton_Click;
                }

                _systemEDIRadioButton = value;
                if (_systemEDIRadioButton != null)
                {
                    _systemEDIRadioButton.CheckedChanged += currentEDIRadioButton_Click;
                }
            }
        }

        internal Label Label2;
        private Bunifu.UI.WinForms.BunifuRadioButton _changeEDIRadioButton;

        internal Bunifu.UI.WinForms.BunifuRadioButton changeEDIRadioButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _changeEDIRadioButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_changeEDIRadioButton != null)
                {
                    _changeEDIRadioButton.CheckedChanged -= changeEDIRadioButton_Click;
                }

                _changeEDIRadioButton = value;
                if (_changeEDIRadioButton != null)
                {
                    _changeEDIRadioButton.CheckedChanged += changeEDIRadioButton_Click;
                }
            }
        }

        internal DateTimePicker EDIDateTimePicker;
        internal DateTimePicker EdiTimePicker;
        internal Label atLabel;
    }
}