using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmLoadingPDF : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadingPDF));
            ProgressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            Label1 = new Label();
            _Timer1 = new Timer(components);
            _Timer1.Tick += new EventHandler(Timer1_Tick);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ProgressBar1
            // 
            ProgressBar1.Location = new Point(12, 97);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(580, 28);
            ProgressBar1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(255, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(243, 141);
            Label1.Name = "Label1";
            Label1.Size = new Size(134, 20);
            Label1.TabIndex = 4;
            Label1.Text = "Loading PDF .......";
            // 
            // Timer1
            // 
            _Timer1.Enabled = true;
            // 
            // frmLoadingPDF
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 189);
            Controls.Add(Label1);
            Controls.Add(pictureBox1);
            Controls.Add(ProgressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLoadingPDF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoadingPDF";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Load += new EventHandler(frmLoadingPDF_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal ProgressBar ProgressBar1;
        private PictureBox pictureBox1;
        internal Label Label1;
        private Timer _Timer1;

        internal Timer Timer1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Timer1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Timer1 != null)
                {
                    _Timer1.Tick -= Timer1_Tick;
                }

                _Timer1 = value;
                if (_Timer1 != null)
                {
                    _Timer1.Tick += Timer1_Tick;
                }
            }
        }
    }
}