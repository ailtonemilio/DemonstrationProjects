using CrystalDecisions.CrystalReports.Engine;
using ModelLayer.CustomModel;
using ShipSmpl.Container_Management.EDIPerformanceAudit;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class frmEDIPerformanceAuditReport
    {
        public frmEDIPerformanceAuditReport()
        {
            InitializeComponent();
            _crvEDIPerformanceAudit.Name = "crvEDIPerformanceAudit";
        }

        // Public StartDate As Date
        // Public EndDate As Date

        private List<Containers_In_OutReport> listReport;

        public void crvEDIPerformanceAudit_Load(object sender, EventArgs e)
        {
        }

        public void LoadForm(DateTime StartDate, DateTime EndDate, string TotalAVG, List<Containers_In_OutReport> List)
        {
            var bs = new BindingSource();
            bs.DataSource = List;
            ReportDocument reportDocument;
            reportDocument = new rptEDIPerformanceAudit();
            reportDocument.SetDataSource(bs);
            crvEDIPerformanceAudit.ReportSource = reportDocument;
            TextObject txtDateTitle = (TextObject)reportDocument.ReportDefinition.ReportObjects["txtTitleDates"];
            txtDateTitle.Text = string.Format("{0:dd-MMM-yyyy}", StartDate) + " to " + string.Format("{0:dd-MMM-yyyy}", EndDate);
            TextObject txtObj = (TextObject)reportDocument.ReportDefinition.ReportObjects["txtEDIDelay"];
            txtObj.Text = TotalAVG;
            crvEDIPerformanceAudit.ReportSource = reportDocument;
            crvEDIPerformanceAudit.RefreshReport();
        }
    }
}