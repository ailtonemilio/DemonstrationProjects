using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class pictureViwer : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(pictureViwer));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            PictureBox1 = new PictureBox();
            _DirListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            _DirListBox1.Click += new EventHandler(DirListBox1_Click);
            DirectorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            _FileListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
            _FileListBox1.SelectedIndexChanged += new EventHandler(FileListBox1_SelectedIndexChanged);
            _DriveListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            _DriveListBox1.SelectedIndexChanged += new EventHandler(DriveListBox1_SelectedIndexChanged);
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            _saveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _saveButton.Click += new EventHandler(Button1_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.BorderStyle = BorderStyle.Fixed3D;
            PictureBox1.Location = new Point(330, 54);
            PictureBox1.Margin = new Padding(2);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(141, 161);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 1;
            PictureBox1.TabStop = false;
            // 
            // DirListBox1
            // 
            _DirListBox1.FormattingEnabled = true;
            _DirListBox1.IntegralHeight = false;
            _DirListBox1.Location = new Point(13, 45);
            _DirListBox1.Margin = new Padding(2);
            _DirListBox1.Name = "_DirListBox1";
            _DirListBox1.Size = new Size(262, 122);
            _DirListBox1.TabIndex = 3;
            // 
            // DirectorySearcher1
            // 
            DirectorySearcher1.ClientTimeout = TimeSpan.Parse("-00:00:01");
            DirectorySearcher1.ServerPageTimeLimit = TimeSpan.Parse("-00:00:01");
            DirectorySearcher1.ServerTimeLimit = TimeSpan.Parse("-00:00:01");
            // 
            // FileListBox1
            // 
            _FileListBox1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _FileListBox1.FormattingEnabled = true;
            _FileListBox1.Location = new Point(11, 203);
            _FileListBox1.Margin = new Padding(2);
            _FileListBox1.Name = "_FileListBox1";
            _FileListBox1.Pattern = "*.*";
            _FileListBox1.Size = new Size(264, 180);
            _FileListBox1.TabIndex = 4;
            // 
            // DriveListBox1
            // 
            _DriveListBox1.FormattingEnabled = true;
            _DriveListBox1.Location = new Point(161, 20);
            _DriveListBox1.Margin = new Padding(2);
            _DriveListBox1.Name = "_DriveListBox1";
            _DriveListBox1.Size = new Size(75, 21);
            _DriveListBox1.TabIndex = 5;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.White;
            Label1.Font = new Font("Microsoft Sans Serif", 9.857143f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label1.Location = new Point(13, 21);
            Label1.Margin = new Padding(2, 0, 2, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(142, 20);
            Label1.TabIndex = 6;
            Label1.Text = "Select the folder";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.White;
            Label2.Font = new Font("Microsoft Sans Serif", 9.857143f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label2.Location = new Point(11, 179);
            Label2.Margin = new Padding(2, 0, 2, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(144, 20);
            Label2.TabIndex = 7;
            Label2.Text = "Select the image";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.White;
            Label3.Font = new Font("Microsoft Sans Serif", 9.857143f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label3.Location = new Point(361, 30);
            Label3.Margin = new Padding(2, 0, 2, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(70, 20);
            Label3.TabIndex = 8;
            Label3.Text = "Preview";
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
            _saveButton.ButtonText = "Use image";
            _saveButton.ButtonTextMarginLeft = 0;
            _saveButton.ColorContrastOnClick = 45;
            _saveButton.ColorContrastOnHover = 45;
            _saveButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _saveButton.CustomizableEdges = BorderEdges1;
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
            _saveButton.Location = new Point(347, 231);
            _saveButton.Name = "_saveButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _saveButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _saveButton.OnPressedState = StateProperties2;
            _saveButton.Size = new Size(102, 33);
            _saveButton.TabIndex = 9;
            _saveButton.TextAlign = ContentAlignment.MiddleCenter;
            _saveButton.TextMarginLeft = 0;
            _saveButton.UseDefaultRadiusAndThickness = true;
            // 
            // pictureViwer
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(485, 395);
            Controls.Add(_saveButton);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(_DriveListBox1);
            Controls.Add(_FileListBox1);
            Controls.Add(_DirListBox1);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "pictureViwer";
            StartPosition = FormStartPosition.Manual;
            Text = "Employee Photo";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal PictureBox PictureBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.FileListBox _FileListBox1;

        internal Microsoft.VisualBasic.Compatibility.VB6.FileListBox FileListBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FileListBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FileListBox1 != null)
                {
                    _FileListBox1.SelectedIndexChanged -= FileListBox1_SelectedIndexChanged;
                }

                _FileListBox1 = value;
                if (_FileListBox1 != null)
                {
                    _FileListBox1.SelectedIndexChanged += FileListBox1_SelectedIndexChanged;
                }
            }
        }

        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox _DriveListBox1;

        internal Microsoft.VisualBasic.Compatibility.VB6.DriveListBox DriveListBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DriveListBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DriveListBox1 != null)
                {
                    _DriveListBox1.SelectedIndexChanged -= DriveListBox1_SelectedIndexChanged;
                }

                _DriveListBox1 = value;
                if (_DriveListBox1 != null)
                {
                    _DriveListBox1.SelectedIndexChanged += DriveListBox1_SelectedIndexChanged;
                }
            }
        }

        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox _DirListBox1;

        internal Microsoft.VisualBasic.Compatibility.VB6.DirListBox DirListBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DirListBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DirListBox1 != null)
                {
                    _DirListBox1.Click -= DirListBox1_Click;
                }

                _DirListBox1 = value;
                if (_DirListBox1 != null)
                {
                    _DirListBox1.Click += DirListBox1_Click;
                }
            }
        }

        internal System.DirectoryServices.DirectorySearcher DirectorySearcher1;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
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
                    _saveButton.Click -= Button1_Click;
                }

                _saveButton = value;
                if (_saveButton != null)
                {
                    _saveButton.Click += Button1_Click;
                }
            }
        }
    }
}