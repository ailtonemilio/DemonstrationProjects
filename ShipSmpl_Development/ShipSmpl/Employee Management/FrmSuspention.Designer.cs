using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmSuspention : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuspention));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _closeLabel = new Label();
            _closeLabel.Click += new EventHandler(Label6_Click);
            _closeLabel.MouseHover += new EventHandler(closeLabel_MouseHover);
            _closeLabel.MouseLeave += new EventHandler(closeLabel_Click);
            _closeLabel.Click += new EventHandler(closeLabel_MouseLeave);
            _Label7 = new Label();
            _Label7.Click += new EventHandler(Label7_Click);
            _cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _cancelButton.Click += new EventHandler(Label6_Click);
            _saveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _saveButton.Click += new EventHandler(saveButton_Click);
            TabControl1 = new TabControl();
            TabPage2 = new TabPage();
            Label11 = new Label();
            senpensionReasonRichTextBox1 = new RichTextBox();
            Label4 = new Label();
            suspendLabel = new Label();
            fromDateTimePicker1 = new DateTimePicker();
            TabPage1 = new TabPage();
            Label12 = new Label();
            terminationREasonRichTextBox2 = new RichTextBox();
            terminateLabel = new Label();
            terminationDateTimePicker = new DateTimePicker();
            Label3 = new Label();
            TabPage3 = new TabPage();
            Label2 = new Label();
            reinstateNoteRichTextBox1 = new RichTextBox();
            Label8 = new Label();
            reinstateLabel = new Label();
            reinstateDateTimePicker3 = new DateTimePicker();
            TabControl1.SuspendLayout();
            TabPage2.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // closeLabel
            // 
            _closeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _closeLabel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _closeLabel.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _closeLabel.ForeColor = Color.White;
            _closeLabel.Location = new Point(557, 0);
            _closeLabel.Margin = new Padding(0);
            _closeLabel.Name = "_closeLabel";
            _closeLabel.Size = new Size(48, 46);
            _closeLabel.TabIndex = 77;
            _closeLabel.Text = "🗙";
            _closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            _Label7.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _Label7.Dock = DockStyle.Top;
            _Label7.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label7.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _Label7.Location = new Point(0, 0);
            _Label7.Name = "_Label7";
            _Label7.Size = new Size(605, 46);
            _Label7.TabIndex = 76;
            _Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            _cancelButton.AllowToggling = false;
            _cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            _cancelButton.Location = new Point(477, 350);
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
            _cancelButton.TabIndex = 75;
            _cancelButton.TextAlign = ContentAlignment.MiddleCenter;
            _cancelButton.TextMarginLeft = 0;
            _cancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // saveButton
            // 
            _saveButton.AllowToggling = false;
            _saveButton.AnimationSpeed = 200;
            _saveButton.AutoGenerateColors = false;
            _saveButton.BackColor = Color.Transparent;
            _saveButton.BackColor1 = Color.Teal;
            _saveButton.BackgroundImage = (Image)resources.GetObject("saveButton.BackgroundImage");
            _saveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _saveButton.ButtonText = "Save";
            _saveButton.ButtonTextMarginLeft = 0;
            _saveButton.ColorContrastOnClick = 45;
            _saveButton.ColorContrastOnHover = 45;
            _saveButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _saveButton.CustomizableEdges = BorderEdges2;
            _saveButton.DialogResult = DialogResult.None;
            _saveButton.DisabledBorderColor = Color.Empty;
            _saveButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _saveButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _saveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _saveButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _saveButton.ForeColor = Color.White;
            _saveButton.IconLeftCursor = Cursors.Hand;
            _saveButton.IconMarginLeft = 11;
            _saveButton.IconPadding = 10;
            _saveButton.IconRightCursor = Cursors.Hand;
            _saveButton.IdleBorderColor = Color.Teal;
            _saveButton.IdleBorderRadius = 3;
            _saveButton.IdleBorderThickness = 1;
            _saveButton.IdleFillColor = Color.Teal;
            _saveButton.IdleIconLeftImage = null;
            _saveButton.IdleIconRightImage = null;
            _saveButton.IndicateFocus = true;
            _saveButton.Location = new Point(351, 350);
            _saveButton.Name = "_saveButton";
            StateProperties3.BorderColor = Color.MediumTurquoise;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.MediumTurquoise;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _saveButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.Teal;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.Teal;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _saveButton.OnPressedState = StateProperties4;
            _saveButton.Size = new Size(102, 45);
            _saveButton.TabIndex = 74;
            _saveButton.TextAlign = ContentAlignment.MiddleCenter;
            _saveButton.TextMarginLeft = 0;
            _saveButton.UseDefaultRadiusAndThickness = true;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(TabPage3);
            TabControl1.Dock = DockStyle.Top;
            TabControl1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TabControl1.Location = new Point(0, 46);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(605, 295);
            TabControl1.TabIndex = 78;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(Label11);
            TabPage2.Controls.Add(senpensionReasonRichTextBox1);
            TabPage2.Controls.Add(Label4);
            TabPage2.Controls.Add(suspendLabel);
            TabPage2.Controls.Add(fromDateTimePicker1);
            TabPage2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            TabPage2.Location = new Point(4, 29);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(597, 262);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Suspend";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.Location = new Point(40, 131);
            Label11.Name = "Label11";
            Label11.Size = new Size(76, 25);
            Label11.TabIndex = 13;
            Label11.Text = "Reason:";
            // 
            // senpensionReasonRichTextBox1
            // 
            senpensionReasonRichTextBox1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            senpensionReasonRichTextBox1.Location = new Point(125, 130);
            senpensionReasonRichTextBox1.MaxLength = 200;
            senpensionReasonRichTextBox1.Name = "senpensionReasonRichTextBox1";
            senpensionReasonRichTextBox1.Size = new Size(429, 102);
            senpensionReasonRichTextBox1.TabIndex = 12;
            senpensionReasonRichTextBox1.Text = "";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(61, 85);
            Label4.Name = "Label4";
            Label4.Size = new Size(55, 25);
            Label4.TabIndex = 9;
            Label4.Text = "Date:";
            // 
            // suspendLabel
            // 
            suspendLabel.AutoSize = true;
            suspendLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            suspendLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            suspendLabel.Location = new Point(8, 24);
            suspendLabel.Name = "suspendLabel";
            suspendLabel.Size = new Size(244, 30);
            suspendLabel.TabIndex = 8;
            suspendLabel.Text = "Suspend employee: Bob";
            // 
            // fromDateTimePicker1
            // 
            fromDateTimePicker1.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            fromDateTimePicker1.Format = DateTimePickerFormat.Short;
            fromDateTimePicker1.Location = new Point(125, 79);
            fromDateTimePicker1.Name = "fromDateTimePicker1";
            fromDateTimePicker1.Size = new Size(161, 35);
            fromDateTimePicker1.TabIndex = 6;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(Label12);
            TabPage1.Controls.Add(terminationREasonRichTextBox2);
            TabPage1.Controls.Add(terminateLabel);
            TabPage1.Controls.Add(terminationDateTimePicker);
            TabPage1.Controls.Add(Label3);
            TabPage1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TabPage1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            TabPage1.Location = new Point(4, 29);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(597, 262);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Terminate";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.Location = new Point(50, 129);
            Label12.Name = "Label12";
            Label12.Size = new Size(76, 25);
            Label12.TabIndex = 15;
            Label12.Text = "Reason:";
            // 
            // terminationREasonRichTextBox2
            // 
            terminationREasonRichTextBox2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            terminationREasonRichTextBox2.Location = new Point(132, 128);
            terminationREasonRichTextBox2.MaxLength = 200;
            terminationREasonRichTextBox2.Name = "terminationREasonRichTextBox2";
            terminationREasonRichTextBox2.Size = new Size(401, 99);
            terminationREasonRichTextBox2.TabIndex = 14;
            terminationREasonRichTextBox2.Text = "";
            // 
            // terminateLabel
            // 
            terminateLabel.AutoSize = true;
            terminateLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            terminateLabel.Location = new Point(8, 30);
            terminateLabel.Name = "terminateLabel";
            terminateLabel.Size = new Size(258, 30);
            terminateLabel.TabIndex = 3;
            terminateLabel.Text = "Terminate employee: Bob";
            // 
            // terminationDateTimePicker
            // 
            terminationDateTimePicker.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            terminationDateTimePicker.Format = DateTimePickerFormat.Short;
            terminationDateTimePicker.Location = new Point(132, 80);
            terminationDateTimePicker.Name = "terminationDateTimePicker";
            terminationDateTimePicker.Size = new Size(168, 35);
            terminationDateTimePicker.TabIndex = 1;
            // 
            // Label3
            // 
            Label3.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(61, 82);
            Label3.Name = "Label3";
            Label3.Size = new Size(72, 31);
            Label3.TabIndex = 4;
            Label3.Text = "Date:";
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(Label2);
            TabPage3.Controls.Add(reinstateNoteRichTextBox1);
            TabPage3.Controls.Add(Label8);
            TabPage3.Controls.Add(reinstateLabel);
            TabPage3.Controls.Add(reinstateDateTimePicker3);
            TabPage3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            TabPage3.Location = new Point(4, 29);
            TabPage3.Name = "TabPage3";
            TabPage3.Size = new Size(597, 262);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Reinstate";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(42, 133);
            Label2.Name = "Label2";
            Label2.Size = new Size(65, 25);
            Label2.TabIndex = 17;
            Label2.Text = "Notes:";
            // 
            // reinstateNoteRichTextBox1
            // 
            reinstateNoteRichTextBox1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            reinstateNoteRichTextBox1.Location = new Point(116, 133);
            reinstateNoteRichTextBox1.MaxLength = 200;
            reinstateNoteRichTextBox1.Name = "reinstateNoteRichTextBox1";
            reinstateNoteRichTextBox1.Size = new Size(441, 100);
            reinstateNoteRichTextBox1.TabIndex = 16;
            reinstateNoteRichTextBox1.Text = "";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(52, 82);
            Label8.Name = "Label8";
            Label8.Size = new Size(55, 25);
            Label8.TabIndex = 9;
            Label8.Text = "Date:";
            // 
            // reinstateLabel
            // 
            reinstateLabel.AutoSize = true;
            reinstateLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            reinstateLabel.Location = new Point(8, 23);
            reinstateLabel.Name = "reinstateLabel";
            reinstateLabel.Size = new Size(250, 30);
            reinstateLabel.TabIndex = 8;
            reinstateLabel.Text = "Reinstate employee: Bob";
            // 
            // reinstateDateTimePicker3
            // 
            reinstateDateTimePicker3.Font = new Font("Segoe UI", 13.74545f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            reinstateDateTimePicker3.Format = DateTimePickerFormat.Short;
            reinstateDateTimePicker3.Location = new Point(116, 76);
            reinstateDateTimePicker3.Name = "reinstateDateTimePicker3";
            reinstateDateTimePicker3.Size = new Size(161, 35);
            reinstateDateTimePicker3.TabIndex = 6;
            // 
            // FrmSuspention
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(605, 407);
            Controls.Add(TabControl1);
            Controls.Add(_closeLabel);
            Controls.Add(_Label7);
            Controls.Add(_cancelButton);
            Controls.Add(_saveButton);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSuspention";
            StartPosition = FormStartPosition.CenterScreen;
            TabControl1.ResumeLayout(false);
            TabPage2.ResumeLayout(false);
            TabPage2.PerformLayout();
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            TabPage3.ResumeLayout(false);
            TabPage3.PerformLayout();
            Load += new EventHandler(FrmSuspention_Load);
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
                    _closeLabel.Click -= Label6_Click;
                    _closeLabel.MouseHover -= closeLabel_MouseHover;
                    _closeLabel.MouseLeave -= closeLabel_Click;
                    _closeLabel.Click -= closeLabel_MouseLeave;
                }

                _closeLabel = value;
                if (_closeLabel != null)
                {
                    _closeLabel.Click += Label6_Click;
                    _closeLabel.MouseHover += closeLabel_MouseHover;
                    _closeLabel.MouseLeave += closeLabel_Click;
                    _closeLabel.Click += closeLabel_MouseLeave;
                }
            }
        }

        private Label _Label7;

        internal Label Label7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label7 != null)
                {
                    _Label7.Click -= Label7_Click;
                }

                _Label7 = value;
                if (_Label7 != null)
                {
                    _Label7.Click += Label7_Click;
                }
            }
        }

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

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _saveButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton saveButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _saveButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_saveButton != null)
                {
                    _saveButton.Click -= saveButton_Click;
                }

                _saveButton = value;
                if (_saveButton != null)
                {
                    _saveButton.Click += saveButton_Click;
                }
            }
        }

        internal TabControl TabControl1;
        internal TabPage TabPage2;
        internal Label Label11;
        internal RichTextBox senpensionReasonRichTextBox1;
        internal Label Label4;
        internal Label suspendLabel;
        internal DateTimePicker fromDateTimePicker1;
        internal TabPage TabPage1;
        internal Label Label12;
        internal RichTextBox terminationREasonRichTextBox2;
        internal Label terminateLabel;
        internal DateTimePicker terminationDateTimePicker;
        internal Label Label3;
        internal TabPage TabPage3;
        internal Label Label2;
        internal RichTextBox reinstateNoteRichTextBox1;
        internal Label Label8;
        internal Label reinstateLabel;
        internal DateTimePicker reinstateDateTimePicker3;
    }
}