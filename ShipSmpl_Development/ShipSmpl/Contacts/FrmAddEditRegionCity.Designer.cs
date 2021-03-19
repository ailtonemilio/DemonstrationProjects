using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmAddEditRegionCity : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditRegionCity));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _tbSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _tbSave.Click += new EventHandler(tbSave_Click);
            Label7 = new Label();
            tbCityName = new TextBox();
            Label3 = new Label();
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(cancelButton_Click);
            ImageList2 = new ImageList(components);
            BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ImageList1 = new ImageList(components);
            Label1 = new Label();
            Label2 = new Label();
            tbCityCode = new TextBox();
            Label4 = new Label();
            lblCountry = new Label();
            cboRegionCode = new ComboBox();
            SuspendLayout();
            // 
            // tbSave
            // 
            _tbSave.AllowToggling = false;
            _tbSave.AnimationSpeed = 200;
            _tbSave.AutoGenerateColors = false;
            _tbSave.BackColor = Color.Transparent;
            _tbSave.BackColor1 = Color.Teal;
            _tbSave.BackgroundImage = (Image)resources.GetObject("tbSave.BackgroundImage");
            _tbSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _tbSave.ButtonText = "Save";
            _tbSave.ButtonTextMarginLeft = 0;
            _tbSave.ColorContrastOnClick = 45;
            _tbSave.ColorContrastOnHover = 45;
            _tbSave.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _tbSave.CustomizableEdges = BorderEdges1;
            _tbSave.DialogResult = DialogResult.None;
            _tbSave.DisabledBorderColor = Color.Empty;
            _tbSave.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _tbSave.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _tbSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _tbSave.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _tbSave.ForeColor = Color.White;
            _tbSave.IconLeftCursor = Cursors.Hand;
            _tbSave.IconMarginLeft = 11;
            _tbSave.IconPadding = 10;
            _tbSave.IconRightCursor = Cursors.Hand;
            _tbSave.IdleBorderColor = Color.Teal;
            _tbSave.IdleBorderRadius = 3;
            _tbSave.IdleBorderThickness = 1;
            _tbSave.IdleFillColor = Color.Teal;
            _tbSave.IdleIconLeftImage = null;
            _tbSave.IdleIconRightImage = null;
            _tbSave.IndicateFocus = true;
            _tbSave.Location = new Point(176, 198);
            _tbSave.Name = "_tbSave";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _tbSave.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _tbSave.OnPressedState = StateProperties2;
            _tbSave.Size = new Size(90, 31);
            _tbSave.TabIndex = 74;
            _tbSave.TextAlign = ContentAlignment.MiddleCenter;
            _tbSave.TextMarginLeft = 0;
            _tbSave.UseDefaultRadiusAndThickness = true;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Semibold", 14.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label7.Location = new Point(20, 22);
            Label7.Name = "Label7";
            Label7.Size = new Size(118, 25);
            Label7.TabIndex = 72;
            Label7.Text = "Edit Address";
            // 
            // tbCityName
            // 
            tbCityName.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            tbCityName.Location = new Point(146, 118);
            tbCityName.Name = "tbCityName";
            tbCityName.Size = new Size(243, 26);
            tbCityName.TabIndex = 6;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(55, 121);
            Label3.Name = "Label3";
            Label3.Size = new Size(85, 20);
            Label3.TabIndex = 2;
            Label3.Text = "City Name:";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
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
            _cancelButton.ButtonText = "×";
            _cancelButton.ButtonTextMarginLeft = 0;
            _cancelButton.ColorContrastOnClick = 45;
            _cancelButton.ColorContrastOnHover = 45;
            _cancelButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _cancelButton.CustomizableEdges = BorderEdges2;
            _cancelButton.DialogResult = DialogResult.None;
            _cancelButton.DisabledBorderColor = Color.Empty;
            _cancelButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _cancelButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _cancelButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _cancelButton.Font = new Font("Adobe Fan Heiti Std B", 15.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _cancelButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _cancelButton.IconLeftCursor = Cursors.Hand;
            _cancelButton.IconMarginLeft = 11;
            _cancelButton.IconPadding = 10;
            _cancelButton.IconRightCursor = Cursors.Hand;
            _cancelButton.IdleBorderColor = Color.White;
            _cancelButton.IdleBorderRadius = 20;
            _cancelButton.IdleBorderThickness = 1;
            _cancelButton.IdleFillColor = Color.White;
            _cancelButton.IdleIconLeftImage = null;
            _cancelButton.IdleIconRightImage = null;
            _cancelButton.IndicateFocus = true;
            _cancelButton.Location = new Point(426, 2);
            _cancelButton.Name = "_cancelButton";
            StateProperties3.BorderColor = Color.DarkGray;
            StateProperties3.BorderRadius = 20;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.DarkGray;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _cancelButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.IndianRed;
            StateProperties4.BorderRadius = 20;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.IndianRed;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _cancelButton.OnPressedState = StateProperties4;
            _cancelButton.Size = new Size(26, 23);
            _cancelButton.TabIndex = 75;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // ImageList2
            // 
            ImageList2.ImageStream = (ImageListStreamer)resources.GetObject("ImageList2.ImageStream");
            ImageList2.TransparentColor = Color.Transparent;
            ImageList2.Images.SetKeyName(0, "redBall.png");
            // 
            // BunifuElipse1
            // 
            BunifuElipse1.ElipseRadius = 15;
            BunifuElipse1.TargetControl = this;
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "blueBall.png");
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(34, 90);
            Label1.Name = "Label1";
            Label1.Size = new Size(106, 20);
            Label1.TabIndex = 77;
            Label1.Text = "Provice Code:";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(59, 151);
            Label2.Name = "Label2";
            Label2.Size = new Size(81, 20);
            Label2.TabIndex = 78;
            Label2.Text = "City Code:";
            Label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbCityCode
            // 
            tbCityCode.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            tbCityCode.Location = new Point(146, 148);
            tbCityCode.MaxLength = 3;
            tbCityCode.Name = "tbCityCode";
            tbCityCode.Size = new Size(107, 26);
            tbCityCode.TabIndex = 79;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(70, 59);
            Label4.Name = "Label4";
            Label4.Size = new Size(68, 20);
            Label4.TabIndex = 80;
            Label4.Text = "Country:";
            Label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.BackColor = Color.SeaShell;
            lblCountry.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblCountry.Location = new Point(145, 57);
            lblCountry.Name = "lblCountry";
            lblCountry.Padding = new Padding(2);
            lblCountry.Size = new Size(121, 24);
            lblCountry.TabIndex = 81;
            lblCountry.Text = "CountryName";
            lblCountry.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboRegionCode
            // 
            cboRegionCode.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            cboRegionCode.FormattingEnabled = true;
            cboRegionCode.Items.AddRange(new object[] { "CUSTOMER", "VENDOR", "CUSTOMER | VENDOR" });
            cboRegionCode.Location = new Point(146, 84);
            cboRegionCode.Name = "cboRegionCode";
            cboRegionCode.Size = new Size(120, 28);
            cboRegionCode.TabIndex = 82;
            // 
            // FrmAddEditRegionCity
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(455, 254);
            Controls.Add(cboRegionCode);
            Controls.Add(lblCountry);
            Controls.Add(Label4);
            Controls.Add(tbCityCode);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(_tbSave);
            Controls.Add(Label7);
            Controls.Add(_cancelButton);
            Controls.Add(Label3);
            Controls.Add(tbCityName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddEditRegionCity";
            Text = "FrmAddEditRegionCity";
            ResumeLayout(false);
            PerformLayout();
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _tbSave;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton tbSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tbSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbSave != null)
                {
                    _tbSave.Click -= tbSave_Click;
                }

                _tbSave = value;
                if (_tbSave != null)
                {
                    _tbSave.Click += tbSave_Click;
                }
            }
        }

        internal Label Label7;
        internal TextBox tbCityName;
        internal Label Label3;
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

        internal ImageList ImageList2;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        internal ImageList ImageList1;
        internal TextBox tbCityCode;
        internal Label Label2;
        internal Label Label1;
        internal Label lblCountry;
        internal Label Label4;
        internal ComboBox cboRegionCode;
    }
}