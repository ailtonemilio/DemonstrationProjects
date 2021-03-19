using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class frmEDIPerformanceAuditReport : Form
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
            _crvEDIPerformanceAudit = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            _crvEDIPerformanceAudit.Load += new EventHandler(crvEDIPerformanceAudit_Load);
            BindingSourceContainers_In_Out = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)BindingSourceContainers_In_Out).BeginInit();
            SuspendLayout();
            // 
            // crvEDIPerformanceAudit
            // 
            _crvEDIPerformanceAudit.ActiveViewIndex = -1;
            _crvEDIPerformanceAudit.BorderStyle = BorderStyle.FixedSingle;
            _crvEDIPerformanceAudit.Cursor = Cursors.Default;
            _crvEDIPerformanceAudit.Dock = DockStyle.Fill;
            _crvEDIPerformanceAudit.Location = new Point(0, 0);
            _crvEDIPerformanceAudit.Name = "_crvEDIPerformanceAudit";
            _crvEDIPerformanceAudit.Size = new Size(800, 450);
            _crvEDIPerformanceAudit.TabIndex = 0;
            // 
            // frmEDIPerformanceAuditReport
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_crvEDIPerformanceAudit);
            Name = "frmEDIPerformanceAuditReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEDIPerformanceAuditReport";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)BindingSourceContainers_In_Out).EndInit();
            ResumeLayout(false);
        }

        private CrystalDecisions.Windows.Forms.CrystalReportViewer _crvEDIPerformanceAudit;

        internal CrystalDecisions.Windows.Forms.CrystalReportViewer crvEDIPerformanceAudit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _crvEDIPerformanceAudit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_crvEDIPerformanceAudit != null)
                {
                    _crvEDIPerformanceAudit.Load -= crvEDIPerformanceAudit_Load;
                }

                _crvEDIPerformanceAudit = value;
                if (_crvEDIPerformanceAudit != null)
                {
                    _crvEDIPerformanceAudit.Load += crvEDIPerformanceAudit_Load;
                }
            }
        }

        internal BindingSource BindingSourceContainers_In_Out;
    }
}