using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmConfirmPassword : Form
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
            titleLabel = new Label();
            Label1 = new Label();
            Label2 = new Label();
            TextBox1 = new TextBox();
            Label3 = new Label();
            Button1 = new Button();
            Label4 = new Label();
            Label5 = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.White;
            titleLabel.Enabled = false;
            titleLabel.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            titleLabel.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            titleLabel.Location = new Point(22, 60);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(535, 53);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Confirm password to proceed with operation";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(145, 167);
            Label1.Name = "Label1";
            Label1.Size = new Size(95, 25);
            Label1.TabIndex = 1;
            Label1.Text = "Password:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 11.78182f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(140, 125);
            Label2.Name = "Label2";
            Label2.Size = new Size(106, 25);
            Label2.TabIndex = 2;
            Label2.Text = "Username: ";
            // 
            // TextBox1
            // 
            TextBox1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox1.Location = new Point(246, 167);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(173, 32);
            TextBox1.TabIndex = 3;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.Green;
            Label3.Location = new Point(252, 125);
            Label3.Name = "Label3";
            Label3.Size = new Size(105, 26);
            Label3.TabIndex = 4;
            Label3.Text = "johnnyO1";
            // 
            // Button1
            // 
            Button1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button1.Location = new Point(230, 237);
            Button1.Name = "Button1";
            Button1.Size = new Size(147, 47);
            Button1.TabIndex = 5;
            Button1.Text = "Confirm";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label4.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label4.Font = new Font("Arial Narrow", 22.25455f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(546, 0);
            Label4.Margin = new Padding(0);
            Label4.Name = "Label4";
            Label4.Size = new Size(48, 49);
            Label4.TabIndex = 75;
            Label4.Text = "🗙";
            Label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            Label5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label5.Dock = DockStyle.Top;
            Label5.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label5.Location = new Point(0, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(594, 49);
            Label5.TabIndex = 74;
            Label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmConfirmPassword
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(594, 319);
            ControlBox = false;
            Controls.Add(Label4);
            Controls.Add(Label5);
            Controls.Add(Button1);
            Controls.Add(Label3);
            Controls.Add(TextBox1);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmConfirmPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label titleLabel;
        internal Label Label1;
        internal Label Label2;
        internal TextBox TextBox1;
        internal Label Label3;
        internal Button Button1;
        internal Label Label4;
        internal Label Label5;
    }
}