using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmEDIPerformanceAuditMain : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEDIPerformanceAuditMain));
            Panel1 = new Panel();
            MenuStrip1 = new MenuStrip();
            ToolStripMenuItem = new ToolStripMenuItem();
            menuWorkedHours = new ToolStripMenuItem();
            menuDocumentStorage = new ToolStripMenuItem();
            BunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            Label1 = new Label();
            PictureBox1 = new PictureBox();
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel2 = new Panel();
            Panel5 = new Panel();
            Panel3 = new Panel();
            Label3 = new Label();
            PictureBox2 = new PictureBox();
            Panel1.SuspendLayout();
            MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            BunifuShadowPanel1.SuspendLayout();
            Panel2.SuspendLayout();
            Panel5.SuspendLayout();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel1.Controls.Add(MenuStrip1);
            Panel1.Location = new Point(1411, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(98, 40);
            Panel1.TabIndex = 36;
            // 
            // MenuStrip1
            // 
            MenuStrip1.AutoSize = false;
            MenuStrip1.BackColor = Color.Transparent;
            MenuStrip1.BackgroundImageLayout = ImageLayout.Zoom;
            MenuStrip1.Dock = DockStyle.None;
            MenuStrip1.Font = new Font("Segoe UI", 11.12727f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            MenuStrip1.ImageScalingSize = new Size(20, 20);
            MenuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem });
            MenuStrip1.Location = new Point(51, -3);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(43, 47);
            MenuStrip1.TabIndex = 111;
            MenuStrip1.Text = "kj";
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            ToolStripMenuItem.AutoSize = false;
            ToolStripMenuItem.BackColor = Color.Transparent;
            ToolStripMenuItem.BackgroundImage = My.Resources.Resources.copy_file_White;
            ToolStripMenuItem.BackgroundImageLayout = ImageLayout.Zoom;
            ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuWorkedHours, menuDocumentStorage });
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.RightToLeft = RightToLeft.No;
            ToolStripMenuItem.Size = new Size(29, 28);
            ToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            ToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // menuWorkedHours
            // 
            menuWorkedHours.BackColor = SystemColors.Control;
            menuWorkedHours.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            menuWorkedHours.Name = "menuWorkedHours";
            menuWorkedHours.Size = new Size(242, 30);
            menuWorkedHours.Text = "Worked Hours";
            // 
            // menuDocumentStorage
            // 
            menuDocumentStorage.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            menuDocumentStorage.Name = "menuDocumentStorage";
            menuDocumentStorage.Size = new Size(242, 30);
            menuDocumentStorage.Text = "Document Storage";
            // 
            // BunifuLabel1
            // 
            BunifuLabel1.AutoEllipsis = false;
            BunifuLabel1.CursorType = null;
            BunifuLabel1.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            BunifuLabel1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            BunifuLabel1.Location = new Point(30, 26);
            BunifuLabel1.Name = "BunifuLabel1";
            BunifuLabel1.RightToLeft = RightToLeft.No;
            BunifuLabel1.Size = new Size(154, 27);
            BunifuLabel1.TabIndex = 37;
            BunifuLabel1.Text = "Safety and Risk";
            BunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.None;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 24.21818f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(620, 631);
            Label1.Name = "Label1";
            Label1.Size = new Size(292, 50);
            Label1.TabIndex = 39;
            Label1.Text = "In construction...";
            // 
            // PictureBox1
            // 
            PictureBox1.Anchor = AnchorStyles.None;
            PictureBox1.Image = My.Resources.Resources.dinConstruction;
            PictureBox1.Location = new Point(614, 281);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(288, 311);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 38;
            PictureBox1.TabStop = false;
            // 
            // BunifuShadowPanel1
            // 
            BunifuShadowPanel1.BackColor = Color.White;
            BunifuShadowPanel1.BorderColor = Color.Transparent;
            BunifuShadowPanel1.Controls.Add(Panel2);
            BunifuShadowPanel1.Dock = DockStyle.Fill;
            BunifuShadowPanel1.ForeColor = Color.White;
            BunifuShadowPanel1.Location = new Point(0, 0);
            BunifuShadowPanel1.Margin = new Padding(0);
            BunifuShadowPanel1.Name = "BunifuShadowPanel1";
            BunifuShadowPanel1.Padding = new Padding(10, 6, 5, 5);
            BunifuShadowPanel1.PanelColor = Color.Empty;
            BunifuShadowPanel1.ShadowDept = 2;
            BunifuShadowPanel1.ShadowTopLeftVisible = true;
            BunifuShadowPanel1.Size = new Size(1533, 965);
            BunifuShadowPanel1.TabIndex = 40;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(Panel5);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(10, 6);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1518, 954);
            Panel2.TabIndex = 32;
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel5.Controls.Add(Panel3);
            Panel5.Controls.Add(Panel1);
            Panel5.Dock = DockStyle.Fill;
            Panel5.Location = new Point(0, 0);
            Panel5.Name = "Panel5";
            Panel5.Padding = new Padding(0, 40, 0, 0);
            Panel5.Size = new Size(1518, 954);
            Panel5.TabIndex = 33;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.White;
            Panel3.Controls.Add(Label3);
            Panel3.Controls.Add(PictureBox2);
            Panel3.Controls.Add(BunifuLabel1);
            Panel3.Dock = DockStyle.Fill;
            Panel3.Location = new Point(0, 40);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1518, 914);
            Panel3.TabIndex = 0;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.None;
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 24.21818f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label3.Location = new Point(644, 558);
            Label3.Name = "Label3";
            Label3.Size = new Size(292, 50);
            Label3.TabIndex = 1;
            Label3.Text = "In construction...";
            // 
            // PictureBox2
            // 
            PictureBox2.Anchor = AnchorStyles.None;
            PictureBox2.Image = My.Resources.Resources.dinConstruction;
            PictureBox2.Location = new Point(638, 208);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(288, 311);
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox2.TabIndex = 0;
            PictureBox2.TabStop = false;
            // 
            // FrmSafetyRiskMain
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1533, 965);
            Controls.Add(BunifuShadowPanel1);
            Controls.Add(Label1);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSafetyRiskMain";
            StartPosition = FormStartPosition.CenterScreen;
            Panel1.ResumeLayout(false);
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            BunifuShadowPanel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            Load += new EventHandler(FrmSafetyRiskManagement_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Panel Panel1;
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem ToolStripMenuItem;
        internal ToolStripMenuItem menuWorkedHours;
        internal ToolStripMenuItem menuDocumentStorage;
        internal Bunifu.UI.WinForms.BunifuLabel BunifuLabel1;
        internal Label Label1;
        internal PictureBox PictureBox1;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel2;
        internal Panel Panel5;
        internal Panel Panel3;
        internal Label Label3;
        internal PictureBox PictureBox2;
    }
}