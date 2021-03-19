using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmMissingUnits : Form
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
            RichTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // RichTextBox1
            // 
            RichTextBox1.Font = new Font("Arial", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            RichTextBox1.Location = new Point(-8, 2);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            RichTextBox1.Size = new Size(817, 446);
            RichTextBox1.TabIndex = 1;
            RichTextBox1.Text = "";
            // 
            // FrmMissingUnits
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RichTextBox1);
            Name = "FrmMissingUnits";
            Text = "FrmMissingUnits";
            Load += new EventHandler(FrmMissingUnits_Load);
            ResumeLayout(false);
        }

        internal RichTextBox RichTextBox1;
    }
}