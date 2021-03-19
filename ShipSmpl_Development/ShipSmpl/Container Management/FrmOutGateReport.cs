using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ShipSmpl.Container_Management;
using ShipSmpl.Reports;
using System;
using System.Data;

namespace ShipSmpl
{
    public partial class FrmOutGateReport
    {
        public FrmOutGateReport()
        {
            InitializeComponent();
            _closeFlatButton.Name = "closeFlatButton";
            _refreshInShapedButton.Name = "refreshInShapedButton";
        }

        private DataSetOutGate.OutgatedContainersDataTable outGateSummary = new DataSetOutGate.OutgatedContainersDataTable();
        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeFlatButton_Load(object sender, EventArgs e)
        {
        }

        private void getReport()
        {
            var outGateDT = new DataTable();
            string condition;
            DateTime dateOut;
            string dateOutStr;
            outGateSummary.Rows.Clear();
            condition = "where [Booking Number] <> '' and [Gate Date Out] >= '" + Conversions.ToString(fromInBunifuDatePicker.Value.Date) + "' and " + " [Gate Date Out] <= '" + Conversions.ToString(toInBunifuDatePicker.Value.Date) + "' and ([Container Rejected] is null or [Container Rejected] = 0)  order by [Gate Date Out], [Gate Time Out]";
            outGateDT = dbCeres.getTableInfo("[Containers In-Out]", "*", condition);
            foreach (DataRow row in outGateDT.Rows)
            {
                if (row["Gate Date Out"] != DBNull.Value)
                {
                    dateOut = Conversions.ToDate(row["Gate Date Out"]);
                    dateOutStr = dateOut.ToString("dd-MMM-yyyy @ hh:mm tt");
                }
                else
                {
                    dateOutStr = "";
                }

                var newRow = outGateSummary.NewOutgatedContainersRow();

                if (row["ContainerSize"] != DBNull.Value)
                {
                    newRow.Size = Conversions.ToString(row["ContainerSize"]);
                }
                else
                {
                    newRow.Size = "";
                }

                newRow.Container_Number = Strings.Trim(Conversions.ToString(row["Container Number"]));
                newRow.Booking_Number = Strings.Trim(Conversions.ToString(row["Booking Number"]));
                newRow.Tare = MdlContainerManagement.DoFunctions.CVS(Conversions.ToString(row["TARE Weight Out"]));
                newRow._Date_Time = dateOutStr;
                newRow.Outgoing_Carrier = Strings.Trim(Conversions.ToString(row["carrier name out"]));
                newRow.ssLine = Strings.Trim(Conversions.ToString(row["SS Line Name Out"]));

                outGateSummary.AddOutgatedContainersRow(newRow);
            }

            try
            {
                var reportSource = new CrystalReportOuGate();
                reportSource.Database.Tables[0].SetDataSource(outGateSummary.CopyToDataTable());
                CrystalReportViewer1.ReportSource = reportSource;
            }
            catch
            {
            }
        }

        private void refreshInShapedButton_Click(object sender, EventArgs e)
        {
            getReport();
        }

        private void FrmOutGateReport_Load(object sender, EventArgs e)
        {
            try
            {
                fromInBunifuDatePicker.Value = DateAndTime.Now;
                // fromInBunifuDatePicker.Value.AddDays(-7)
                toInBunifuDatePicker.Value = DateAndTime.Now;
                getReport();
            }
            catch
            {
            }
        }
    }
}