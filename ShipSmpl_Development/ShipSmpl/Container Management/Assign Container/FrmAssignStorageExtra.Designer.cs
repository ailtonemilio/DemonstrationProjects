using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAssignStorageExtra : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssignStorageExtra));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Label4 = new Label();
            Label1 = new Label();
            Label2 = new Label();
            Label7 = new Label();
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(Label6_Click);
            _TouchAssignExtra = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _TouchAssignExtra.Click += new EventHandler(TouchAssignExtra_ButtonClick);
            _bookingComboBox = new ComboBox();
            _bookingComboBox.SelectedIndexChanged += new EventHandler(bookinbgComboBox_SelectedIndexChanged);
            _typeBunifuDropdown3 = new ComboBox();
            _typeBunifuDropdown3.SelectedIndexChanged += new EventHandler(typeBunifuDropdown3_SelectedIndexChanged);
            _closeFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            _closeFlatButton.Click += new EventHandler(closeFlatButton_Click);
            SuspendLayout();
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label4.Location = new Point(62, 165);
            Label4.Name = "Label4";
            Label4.Size = new Size(70, 21);
            Label4.TabIndex = 118;
            Label4.Text = "Booking:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(58, 79);
            Label1.Name = "Label1";
            Label1.Size = new Size(382, 25);
            Label1.TabIndex = 122;
            Label1.Text = "Select booking and the type of assignment:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label2.Location = new Point(92, 127);
            Label2.Name = "Label2";
            Label2.Size = new Size(45, 21);
            Label2.TabIndex = 123;
            Label2.Text = "Type:";
            // 
            // Label7
            // 
            Label7.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Dock = DockStyle.Top;
            Label7.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label7.Location = new Point(0, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(519, 46);
            Label7.TabIndex = 125;
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            _cancelButton.AllowToggling = false;
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
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _cancelButton.CustomizableEdges = BorderEdges1;
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
            _cancelButton.Location = new Point(264, 223);
            _cancelButton.Name = "_cancelButton";
            StateProperties1.BorderColor = Color.DarkGray;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.DarkGray;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.IndianRed;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.IndianRed;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties2;
            _cancelButton.Size = new Size(97, 45);
            _cancelButton.TabIndex = 128;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // TouchAssignExtra
            // 
            _TouchAssignExtra.AllowToggling = false;
            _TouchAssignExtra.AnimationSpeed = 200;
            _TouchAssignExtra.AutoGenerateColors = false;
            _TouchAssignExtra.BackColor = Color.Transparent;
            _TouchAssignExtra.BackColor1 = Color.Teal;
            _TouchAssignExtra.BackgroundImage = (Image)resources.GetObject("TouchAssignExtra.BackgroundImage");
            _TouchAssignExtra.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _TouchAssignExtra.ButtonText = "Assign";
            _TouchAssignExtra.ButtonTextMarginLeft = 0;
            _TouchAssignExtra.ColorContrastOnClick = 45;
            _TouchAssignExtra.ColorContrastOnHover = 45;
            _TouchAssignExtra.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _TouchAssignExtra.CustomizableEdges = BorderEdges2;
            _TouchAssignExtra.DialogResult = DialogResult.None;
            _TouchAssignExtra.DisabledBorderColor = Color.Empty;
            _TouchAssignExtra.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _TouchAssignExtra.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _TouchAssignExtra.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _TouchAssignExtra.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _TouchAssignExtra.ForeColor = Color.White;
            _TouchAssignExtra.IconLeftCursor = Cursors.Hand;
            _TouchAssignExtra.IconMarginLeft = 11;
            _TouchAssignExtra.IconPadding = 10;
            _TouchAssignExtra.IconRightCursor = Cursors.Hand;
            _TouchAssignExtra.IdleBorderColor = Color.Teal;
            _TouchAssignExtra.IdleBorderRadius = 3;
            _TouchAssignExtra.IdleBorderThickness = 1;
            _TouchAssignExtra.IdleFillColor = Color.Teal;
            _TouchAssignExtra.IdleIconLeftImage = null;
            _TouchAssignExtra.IdleIconRightImage = null;
            _TouchAssignExtra.IndicateFocus = true;
            _TouchAssignExtra.Location = new Point(138, 223);
            _TouchAssignExtra.Name = "_TouchAssignExtra";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _TouchAssignExtra.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _TouchAssignExtra.OnPressedState = StateProperties4;
            _TouchAssignExtra.Size = new Size(102, 45);
            _TouchAssignExtra.TabIndex = 127;
            _TouchAssignExtra.TextAlign = ContentAlignment.MiddleCenter;
            _TouchAssignExtra.TextMarginLeft = 0;
            _TouchAssignExtra.UseDefaultRadiusAndThickness = true;
            // 
            // bookingComboBox
            // 
            _bookingComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _bookingComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            _bookingComboBox.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _bookingComboBox.FormattingEnabled = true;
            _bookingComboBox.ItemHeight = 21;
            _bookingComboBox.Location = new Point(153, 162);
            _bookingComboBox.Name = "_bookingComboBox";
            _bookingComboBox.Size = new Size(287, 29);
            _bookingComboBox.TabIndex = 129;
            _bookingComboBox.ValueMember = "MiniBookingId";
            // 
            // typeBunifuDropdown3
            // 
            _typeBunifuDropdown3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _typeBunifuDropdown3.AutoCompleteSource = AutoCompleteSource.ListItems;
            _typeBunifuDropdown3.DropDownStyle = ComboBoxStyle.DropDownList;
            _typeBunifuDropdown3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _typeBunifuDropdown3.FormattingEnabled = true;
            _typeBunifuDropdown3.ItemHeight = 21;
            _typeBunifuDropdown3.Items.AddRange(new object[] { "Extra", "Storage" });
            _typeBunifuDropdown3.Location = new Point(153, 127);
            _typeBunifuDropdown3.Name = "_typeBunifuDropdown3";
            _typeBunifuDropdown3.Size = new Size(191, 29);
            _typeBunifuDropdown3.TabIndex = 131;
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
            _closeFlatButton.Font = new Font("Microsoft Sans Serif", 7.854546f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
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
            _closeFlatButton.Location = new Point(475, 0);
            _closeFlatButton.Name = "_closeFlatButton";
            _closeFlatButton.Normalcolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeFlatButton.OnHovercolor = Color.Gray;
            _closeFlatButton.OnHoverTextColor = Color.White;
            _closeFlatButton.selected = false;
            _closeFlatButton.Size = new Size(44, 46);
            _closeFlatButton.TabIndex = 168;
            _closeFlatButton.Text = "🗙";
            _closeFlatButton.TextAlign = ContentAlignment.MiddleCenter;
            _closeFlatButton.Textcolor = Color.White;
            _closeFlatButton.TextFont = new Font("Microsoft Sans Serif", 20.29091f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            // 
            // FrmAssignStorageExtra
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(519, 295);
            Controls.Add(_closeFlatButton);
            Controls.Add(_typeBunifuDropdown3);
            Controls.Add(_bookingComboBox);
            Controls.Add(_cancelButton);
            Controls.Add(_TouchAssignExtra);
            Controls.Add(Label7);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(Label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAssignStorageExtra";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAssignStorageExtra";
            Load += new EventHandler(FrmAssignStorageExtra_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label4;
        internal Label Label1;
        internal Label Label2;
        internal Label Label7;
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
                    _cancelButton.Click -= Label6_Click;
                }

                _cancelButton = value;
                if (_cancelButton != null)
                {
                    _cancelButton.Click += Label6_Click;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _TouchAssignExtra;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton TouchAssignExtra
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TouchAssignExtra;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TouchAssignExtra != null)
                {
                    _TouchAssignExtra.Click -= TouchAssignExtra_ButtonClick;
                }

                _TouchAssignExtra = value;
                if (_TouchAssignExtra != null)
                {
                    _TouchAssignExtra.Click += TouchAssignExtra_ButtonClick;
                }
            }
        }

        private ComboBox _bookingComboBox;

        internal ComboBox bookingComboBox
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _bookingComboBox;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_bookingComboBox != null)
                {
                    _bookingComboBox.SelectedIndexChanged -= bookinbgComboBox_SelectedIndexChanged;
                }

                _bookingComboBox = value;
                if (_bookingComboBox != null)
                {
                    _bookingComboBox.SelectedIndexChanged += bookinbgComboBox_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _typeBunifuDropdown3;

        internal ComboBox typeBunifuDropdown3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _typeBunifuDropdown3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_typeBunifuDropdown3 != null)
                {
                    _typeBunifuDropdown3.SelectedIndexChanged -= typeBunifuDropdown3_SelectedIndexChanged;
                }

                _typeBunifuDropdown3 = value;
                if (_typeBunifuDropdown3 != null)
                {
                    _typeBunifuDropdown3.SelectedIndexChanged += typeBunifuDropdown3_SelectedIndexChanged;
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
    }
}