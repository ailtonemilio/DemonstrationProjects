using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmTypeInfoForDeletion : Form
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
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            mainMessageLabel = new Label();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.BackColor = Color.IndianRed;
            Label1.Dock = DockStyle.Top;
            Label1.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.IndianRed;
            Label1.Location = new Point(0, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(709, 49);
            Label1.TabIndex = 4;
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label2.BackColor = Color.IndianRed;
            Label2.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(661, 0);
            Label2.Margin = new Padding(0);
            Label2.Name = "Label2";
            Label2.Size = new Size(48, 49);
            Label2.TabIndex = 8;
            Label2.Text = "🗙";
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.BackColor = Color.White;
            Label3.Dock = DockStyle.Top;
            Label3.Font = new Font("Segoe UI Semibold", 11.78182f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.ImageAlign = ContentAlignment.MiddleLeft;
            Label3.Location = new Point(0, 49);
            Label3.Name = "Label3";
            Label3.Size = new Size(709, 54);
            Label3.TabIndex = 9;
            Label3.Text = "Are you absolutely sure?";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mainMessageLabel
            // 
            mainMessageLabel.BackColor = Color.White;
            mainMessageLabel.Dock = DockStyle.Top;
            mainMessageLabel.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            mainMessageLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            mainMessageLabel.ImageAlign = ContentAlignment.MiddleLeft;
            mainMessageLabel.Location = new Point(0, 103);
            mainMessageLabel.Name = "mainMessageLabel";
            mainMessageLabel.Size = new Size(709, 54);
            mainMessageLabel.TabIndex = 10;
            mainMessageLabel.Text = "Are you absolutely sure?";
            mainMessageLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmTypeInfoForDeletion
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(709, 391);
            ControlBox = false;
            Controls.Add(mainMessageLabel);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTypeInfoForDeletion";
            ResumeLayout(false);
        }

        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label mainMessageLabel;
    }
}