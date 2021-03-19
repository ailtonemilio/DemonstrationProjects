using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmLogs : Form
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
            Label2 = new Label();
            Label1 = new Label();
            ListView1 = new ListView();
            ColumnHeader1 = new ColumnHeader();
            ColumnHeader2 = new ColumnHeader();
            ColumnHeader3 = new ColumnHeader();
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel1 = new Panel();
            Panel5 = new Panel();
            Panel2 = new Panel();
            BunifuShadowPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            Panel5.SuspendLayout();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.Black;
            Label2.Location = new Point(57, 54);
            Label2.Name = "Label2";
            Label2.Size = new Size(68, 24);
            Label2.TabIndex = 4;
            Label2.Text = "Action:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(57, 91);
            Label1.Name = "Label1";
            Label1.Size = new Size(58, 24);
            Label1.TabIndex = 2;
            Label1.Text = "Type:";
            // 
            // ListView1
            // 
            ListView1.Columns.AddRange(new ColumnHeader[] { ColumnHeader1, ColumnHeader2, ColumnHeader3 });
            ListView1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ListView1.HideSelection = false;
            ListView1.Location = new Point(51, 156);
            ListView1.Name = "ListView1";
            ListView1.Size = new Size(599, 479);
            ListView1.TabIndex = 0;
            ListView1.UseCompatibleStateImageBehavior = false;
            ListView1.View = View.Details;
            // 
            // ColumnHeader1
            // 
            ColumnHeader1.Text = "Action";
            ColumnHeader1.Width = 442;
            // 
            // ColumnHeader2
            // 
            ColumnHeader2.Text = "Date";
            ColumnHeader2.Width = 146;
            // 
            // ColumnHeader3
            // 
            ColumnHeader3.Text = "";
            ColumnHeader3.Width = 0;
            // 
            // BunifuShadowPanel1
            // 
            BunifuShadowPanel1.BackColor = Color.White;
            BunifuShadowPanel1.BorderColor = Color.Transparent;
            BunifuShadowPanel1.Controls.Add(Panel1);
            BunifuShadowPanel1.Dock = DockStyle.Fill;
            BunifuShadowPanel1.ForeColor = Color.White;
            BunifuShadowPanel1.Location = new Point(0, 0);
            BunifuShadowPanel1.Margin = new Padding(0);
            BunifuShadowPanel1.Name = "BunifuShadowPanel1";
            BunifuShadowPanel1.Padding = new Padding(10, 6, 5, 5);
            BunifuShadowPanel1.PanelColor = Color.Empty;
            BunifuShadowPanel1.ShadowDept = 2;
            BunifuShadowPanel1.ShadowTopLeftVisible = true;
            BunifuShadowPanel1.Size = new Size(1179, 750);
            BunifuShadowPanel1.TabIndex = 5;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Controls.Add(Panel5);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(10, 6);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1164, 739);
            Panel1.TabIndex = 32;
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.DimGray;
            Panel5.Controls.Add(Panel2);
            Panel5.Dock = DockStyle.Fill;
            Panel5.Location = new Point(0, 0);
            Panel5.Name = "Panel5";
            Panel5.Padding = new Padding(0, 40, 0, 0);
            Panel5.Size = new Size(1164, 739);
            Panel5.TabIndex = 33;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.DimGray;
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(Label2);
            Panel2.Controls.Add(ListView1);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(0, 40);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1164, 699);
            Panel2.TabIndex = 0;
            // 
            // FrmLogs
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1179, 750);
            ControlBox = false;
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogs";
            BunifuShadowPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ResumeLayout(false);
        }

        internal Label Label2;
        internal Label Label1;
        internal ListView ListView1;
        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader ColumnHeader2;
        internal ColumnHeader ColumnHeader3;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel1;
        internal Panel Panel5;
        internal Panel Panel2;
    }
}