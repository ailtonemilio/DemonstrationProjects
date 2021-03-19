using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;

namespace ShipSmpl
{
    public partial class FrmCarrierAssignment
    {
        public FrmCarrierAssignment()
        {
            InitializeComponent();
            _CarrierAssignments1.Name = "CarrierAssignments1";
        }

        private YardTabletControls.GeneralFunctions DoFunctions = new YardTabletControls.GeneralFunctions();
        private string StrConnWTCCeres = System.Configuration.ConfigurationManager.ConnectionStrings["WTCCeres"].ConnectionString;

        private void FrmCarrierAssignment_Load(object sender, EventArgs e)
        {
            CarrierAssignments1.AskForWeekDateRange(DateAndTime.Today.Date);

            // Dim StDate As Date, FnDate As Date

            // StDate = GiveStartOfWeek(Today.Date)

            // FnDate = DateAdd("d", 6, StDate)
            // Stop
        }

        private void CarrierAssignments1_RequestAssignmentForWeek(DateTime StartDate, DateTime EndDate)
        {
            int x = 0;
            string BlankCans = DoFunctions.MKI(0) + DoFunctions.MKI(0) + DoFunctions.MKI(0);
            string TempLine = "";
            string Terminals = "";
            string CanInfo = "";
            string TestLine = "";
            string DeliveredCans = FetchAllDeliveredCans();
            var DbObjDataTable = new DataTable();
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select * From [VW_ActiveCarrierBookings] Where LRD >=' " + StartDate + "' And LRD < = '" + EndDate + "'", StrConnWTCCeres);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            DbObjAdapter.Fill(DbObjDataTable);
            foreach (DataRow ThisRow in DbObjDataTable.Rows)
            {
                CanInfo = GiveCanInfo(DoFunctions.PadToString(Conversions.ToString(ThisRow["Booking Number"]), 40), Conversions.ToShort(ThisRow["Number Of Containers"]), DeliveredCans);
                var loopTo = Strings.Len(TempLine);
                for (x = 1; x <= loopTo; x += 26)
                {
                    if ((DoFunctions.PadToString(Conversions.ToString(ThisRow["Carrier ID"]), 10) + DoFunctions.PadToString(Conversions.ToString(ThisRow["Terminal Code"]), 10) ?? "") == (Strings.Mid(TempLine, x, 20) ?? "") & (Strings.Mid(TempLine, 20 + x, 6) ?? "") != (BlankCans ?? ""))
                    {
                        var midTmp = AddCanInfo(Strings.Mid(TempLine, x + 20, 6), CanInfo);
                        StringType.MidStmtStr(ref TempLine, x + 20, 6, midTmp);
                        goto MoveOn;
                    }
                }

                TempLine += DoFunctions.PadToString(Conversions.ToString(ThisRow["Carrier ID"]), 10) + DoFunctions.PadToString(Conversions.ToString(ThisRow["Terminal Code"]), 10) + CanInfo;
            MoveOn:
                ;
            }

            Terminals = GiveTerminals(TempLine);
            CarrierAssignments1.TakeCarrierAssignments(Terminals, TempLine);
        }

        private string GiveCanInfo(string BookNumber, short CansInBooking, string DeliveredCans)
        {
            int x = 0;
            short DeliverAmt = 0;
            var loopTo = Strings.Len(DeliveredCans);
            for (x = 1; x <= loopTo; x += 42)
            {
                if ((BookNumber ?? "") == (Strings.Mid(DeliveredCans, x, 40) ?? ""))
                {
                    DeliverAmt = (short)DoFunctions.CVI(Strings.Mid(DeliveredCans, x + 40, 2));
                    return DoFunctions.MKI(CansInBooking) + DoFunctions.MKI(DeliverAmt) + DoFunctions.MKI(CansInBooking - DeliverAmt);
                }
            }

            return DoFunctions.MKI(CansInBooking) + DoFunctions.MKI(0) + DoFunctions.MKI(0);
        }

        private string AddCanInfo(string CurrentInfo, string AddedInfo)
        {
            short x = 0;
            var loopTo = (short)Strings.Len(CurrentInfo);
            for (x = 1; x <= loopTo; x += 2)
            {
                var midTmp = DoFunctions.MKI(DoFunctions.CVI(Strings.Mid(CurrentInfo, x, 2)) + DoFunctions.CVI(Strings.Mid(AddedInfo, x, 2)));
                StringType.MidStmtStr(ref CurrentInfo, x, 2, midTmp);
            }

            return CurrentInfo;
        }

        private void CarrierAssignments1_ResizeControlWidth(int Width)
        {
            // Me.Width = Width + 10
        }

        private string GiveTerminals(string Assignments)
        {
            int x = 0;
            int y = 0;
            string TempLine = "";
            var loopTo = Strings.Len(Assignments);
            for (x = 1; x <= loopTo; x += 26)
            {
                var loopTo1 = Strings.Len(TempLine);
                for (y = 1; y <= loopTo1; y += 10)
                {
                    if ((Strings.Mid(Assignments, x + 10, 10) ?? "") == (Strings.Mid(TempLine, y, 10) ?? ""))
                    {
                        goto MoveOn;
                    }
                }

                TempLine += Strings.Mid(Assignments, x + 10, 10);
            MoveOn:
                ;
            }

            return TempLine;
        }

        private string FetchAllDeliveredCans()
        {
            string TempLine = "";
            var DbObjDataTable = new DataTable();
            var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select * From [Containers Ready Delivered] Order By [Delivered Booking]", DatabaseHelperCeres.StrConnWTCCeres);
            var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
            DbObjAdapter.Fill(DbObjDataTable);
            foreach (DataRow ReadyDeliverRow in DbObjDataTable.Rows)
                TempLine += DoFunctions.PadToString(Conversions.ToString(ReadyDeliverRow["Delivered Booking"]), 40) + DoFunctions.MKI(Conversions.ToInteger(ReadyDeliverRow["Delivered"]));
            return TempLine;
        }
    }
}