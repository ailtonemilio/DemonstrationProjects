using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmCarrierAssignment : Form
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
            Panel2 = new Panel();
            Label1 = new Label();
            BunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            Panel1 = new Panel();
            Panel5 = new Panel();
            _CarrierAssignments1 = new YardTabletControls.CarrierAssignments();
            _CarrierAssignments1.RequestAssignmentForWeek += new YardTabletControls.CarrierAssignments.RequestAssignmentForWeekEventHandler(CarrierAssignments1_RequestAssignmentForWeek);
            _CarrierAssignments1.ResizeControlWidth += new YardTabletControls.CarrierAssignments.ResizeControlWidthEventHandler(CarrierAssignments1_ResizeControlWidth);
            Panel2.SuspendLayout();
            BunifuShadowPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            Panel5.SuspendLayout();
            SuspendLayout();
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(_CarrierAssignments1);
            Panel2.Controls.Add(Label1);
            Panel2.Dock = DockStyle.Fill;
            Panel2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel2.Location = new Point(0, 40);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1338, 813);
            Panel2.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(0)));
            Label1.Location = new Point(31, 28);
            Label1.Name = "Label1";
            Label1.Size = new Size(209, 30);
            Label1.TabIndex = 0;
            Label1.Text = "Carrier Assignments:";
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
            BunifuShadowPanel1.Size = new Size(1353, 864);
            BunifuShadowPanel1.TabIndex = 5;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Controls.Add(Panel5);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(10, 6);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1338, 853);
            Panel1.TabIndex = 32;
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Panel5.Controls.Add(Panel2);
            Panel5.Dock = DockStyle.Fill;
            Panel5.Location = new Point(0, 0);
            Panel5.Name = "Panel5";
            Panel5.Padding = new Padding(0, 40, 0, 0);
            Panel5.Size = new Size(1338, 853);
            Panel5.TabIndex = 33;
            // 
            // CarrierAssignments1
            // 
            _CarrierAssignments1.ControlColour = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _CarrierAssignments1.Location = new Point(505, 128);
            _CarrierAssignments1.Margin = new Padding(2, 2, 2, 2);
            _CarrierAssignments1.Name = "_CarrierAssignments1";
            _CarrierAssignments1.Size = new Size(367, 513);
            _CarrierAssignments1.TabIndex = 1;
            // 
            // FrmCarrierAssignment
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 864);
            Controls.Add(BunifuShadowPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCarrierAssignment";
            Text = "FrmCarrierAssignment";
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            BunifuShadowPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Load += new EventHandler(FrmCarrierAssignment_Load);
            ResumeLayout(false);
        }

        internal Panel Panel2;
        internal Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BunifuShadowPanel1;
        internal Panel Panel1;
        internal Panel Panel5;
        internal Label Label1;
        private YardTabletControls.CarrierAssignments _CarrierAssignments1;

        internal YardTabletControls.CarrierAssignments CarrierAssignments1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CarrierAssignments1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CarrierAssignments1 != null)
                {
                    _CarrierAssignments1.RequestAssignmentForWeek -= CarrierAssignments1_RequestAssignmentForWeek;
                    _CarrierAssignments1.ResizeControlWidth -= CarrierAssignments1_ResizeControlWidth;
                }

                _CarrierAssignments1 = value;
                if (_CarrierAssignments1 != null)
                {
                    _CarrierAssignments1.RequestAssignmentForWeek += CarrierAssignments1_RequestAssignmentForWeek;
                    _CarrierAssignments1.ResizeControlWidth += CarrierAssignments1_ResizeControlWidth;
                }
            }
        }
    }
}