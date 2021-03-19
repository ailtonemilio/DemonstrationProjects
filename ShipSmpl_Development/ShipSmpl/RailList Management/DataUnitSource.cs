using Microsoft.VisualBasic.CompilerServices;
using System.Data;
using System.Data.SqlClient;

namespace ShipSmpl
{
    public class DataUnitSource
    {
        private string StrConnection = DatabaseHelperCeres.StrConnWTCCeres;

        public DataUnitSource()
        {
        }

        public enum UnitType
        {
            Test = 0
        }

        public void CRUDInTable(string query)
        {
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
        }

        public DataSet getDataSet(string tableName, string tableFiels, string conditions)
        {
            string query = "Select " + tableFiels + " from " + tableName + " " + conditions;
            var dbDataSet = new DataSet();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataSet, tableFiels);
            return dbDataSet;
        }

        public DataTable getDataTable(string tableName, string tableFiels, string conditions)
        {
            string query = "Select " + tableFiels + " from " + tableName + " " + conditions;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbDataTable.Clear();
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public bool verifyUnitSourceActiveUpdate(string Field, int UnitSourceId, int MiniUnitId)
        {
            bool IsTrue = false;
            string query = "select Count(*) as Qty from UnitSourceActiveUpdate where Field = ";
            if (Field == "Customer")
            {
                query = query + "'" + Field + "' and UnitSourceId = " + UnitSourceId.ToString() + " and MiniUnitId = " + MiniUnitId.ToString();
            }
            else
            {
                query = query + "'" + Field + "' and UnitSourceId = " + UnitSourceId.ToString();
            }

            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            foreach (DataRow Unit in dbDataTable.Rows)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(Unit["Qty"], 0, false)))
                {
                    IsTrue = true;
                }
            }

            return IsTrue;
        }

        public bool verifyTable(string Table, string Field, int Id)
        {
            bool IsTrue = false;
            string query = "select Count(*) as Qty from " + Table + " where " + Field + " =" + Id.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            foreach (DataRow Unit in dbDataTable.Rows)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(Unit["Qty"], 0, false)))
                {
                    IsTrue = true;
                }
            }

            return IsTrue;
        }

        public bool verifyMiniUnitByUnitSourceId(int UnitSourceId)
        {
            bool IsTrue = false;
            string query = "select Count(*) as Qty from MiniUnit where UnitSourceId = " + UnitSourceId.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            foreach (DataRow Unit in dbDataTable.Rows)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(Unit["Qty"], 0, false)))
                {
                    IsTrue = true;
                }
            }

            return IsTrue;
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        // Public Function VerifyUnitSource(ByVal UnitSourceId As Integer) As Boolean
        // Dim IsTrue As Boolean = False
        // Dim query As String = "select Count(*) as Qty from MiniUnit where RecordKey =" + UnitSourceId.ToString()
        // Dim dbDataTable As New System.Data.DataTable
        // Dim dbAdapter = New System.Data.SqlClient.SqlDataAdapter(query, StrConnection)
        // Dim dbCommand = New System.Data.SqlClient.SqlCommandBuilder(dbAdapter)
        // dbAdapter.Fill(dbDataTable)

        // For Each Unit In dbDataTable.Rows
        // If Unit("Qty") > 0 Then
        // IsTrue = True
        // End If
        // Next

        // Return IsTrue
        // End Function

        public int LastUnitSourceId()
        {
            var LastId = default(int);
            string query = "select Max(UnitSourceId) As LastId from UnitSource";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            foreach (DataRow Unit in dbDataTable.Rows)
                LastId = Conversions.ToInteger(Unit["LastId"]);
            return LastId;
        }

        public int LastMiniUnitId()
        {
            var LastId = default(int);
            string query = "select Max(MiniUnitId) As LastId from MiniUnit";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            foreach (DataRow Unit in dbDataTable.Rows)
                LastId = Conversions.ToInteger(Unit["LastId"]);
            return LastId;
        }

        public string VerifyField(string Field)
        {
            string a = Field;
            if (string.IsNullOrEmpty(Field))
            {
                a = "Null";
            }
            else if (string.IsNullOrWhiteSpace(Field))
            {
                a = "Null";
            }
            else
            {
                a = "'" + Field + "'";
            }

            return a;
        }

        /// <summary>
        /// Insert and Update Table UnitSource. Note for Insert put UnitSourceId = 0
        /// </summary>
        public void SaveUnitSource(string UnitNumber, string UnitStatus, string UnitType, string CargoType, string OriginLocation, string CarrierId, int ShipperId, string ETADate, string ETALocation, string LastTraced, string LastLocation, string Sequence, string Track, string DemurageDays, string InTansitDays, string BillDate, string CallDate, string ArrivalDate, string AvailableDate, string ReleaseDate, string TotalBilledWeight, string TotalBilledPieces, string LastUpdate, string ActiveUpdates, string Active, int RecordKey, int UnitSourceId)
        {

            // Tratar Field empty
            ETADate = VerifyField(ETADate);
            LastTraced = VerifyField(LastTraced);
            BillDate = VerifyField(BillDate);
            CallDate = VerifyField(CallDate);
            ArrivalDate = VerifyField(ArrivalDate);
            AvailableDate = VerifyField(AvailableDate);
            ReleaseDate = VerifyField(ReleaseDate);
            LastUpdate = VerifyField(LastUpdate);
            UnitStatus = VerifyField(UnitStatus);
            UnitType = VerifyField(UnitType);
            CargoType = VerifyField(CargoType);
            string query;
            if (UnitSourceId == 0)
            {
                query = (Conversions.ToDouble(@"INSERT INTO UnitSource (UnitNumber, UnitStatus, UnitType, CargoType, OriginLocation, CarrierId,
                                         ETADate, ETALocation, LastTraced, LastLocation, [Sequence], Track, DemurageDays, InTransitDays,
                                         BillDate, CallDate, ArrivalDate, AvailableDate, ReleaseDate, TotalBilledWeight, TotalBilledPieces,
                                         LastUpdate, ActiveUpdates, Active, RecordKey, ShipperId)
                                VALUES('" + UnitNumber + "'," + UnitStatus + "," + UnitType + "," + CargoType + ",'" + OriginLocation + "','" + CarrierId + @"',
                                        " + ETADate + ",'" + ETALocation + "'," + LastTraced + ",'" + LastLocation + "','" + Sequence + "','" + Track + "'," + DemurageDays + "," + InTansitDays + @",
                                        " + BillDate + "," + CallDate + "," + ArrivalDate + "," + AvailableDate + "," + ReleaseDate + ",'" + TotalBilledWeight + "' ,'" + TotalBilledPieces + @"',
                                        " + LastUpdate + "," + ActiveUpdates + "," + Active + "," + RecordKey.ToString() + ",") + ShipperId + Conversions.ToDouble(")")).ToString();
            }
            else
            {
                query = (Conversions.ToDouble(@"UPDATE UnitSource
                       SET UnitNumber = '" + UnitNumber + @"'
                          ,UnitStatus = " + UnitStatus + @"
                          ,UnitType = " + UnitType + @"
                          ,CargoType = " + CargoType + @"
                          ,OriginLocation = '" + OriginLocation + @"'
                          ,CarrierId = '" + CarrierId + @"'
                          ,ETADate = " + ETADate + @"
                          ,ETALocation = '" + ETALocation + @"'
                          ,LastTraced = " + LastTraced + @"
                          ,LastLocation = '" + LastLocation + @"'
                          ,[Sequence] = '" + Sequence + @"'
                          ,Track = '" + Track + @"'
                          ,DemurageDays = " + DemurageDays + @"
                          ,InTransitDays = " + InTansitDays + @"
                          ,BillDate = " + BillDate + @"
                          ,CallDate = " + CallDate + @"
                          ,ArrivalDate = " + ArrivalDate + @"
                          ,AvailableDate = " + AvailableDate + @"
                          ,ReleaseDate = " + ReleaseDate + @"
                          ,TotalBilledWeight = " + TotalBilledWeight + @"
                          ,TotalBilledPieces = " + TotalBilledPieces + @"
                          ,LastUpdate = " + LastUpdate + @"
                          ,ActiveUpdates = " + ActiveUpdates + @"
                          ,Active = " + Active + @"
                          ,RecordKey = " + RecordKey.ToString() + @"
                          ,ShipperId = ") + ShipperId + Conversions.ToDouble(@"
                     WHERE UnitSourceId = ") + Conversions.ToDouble(UnitSourceId.ToString())).ToString();
            }

            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public bool VerifyUnitSourceActiveUpdateFromMU(string Field, int UnitSourceId, int MiniUnitId)
        {
            bool IsTrue = false;
            string query = "select Count(*) as Qty from UnitSourceActiveUpdate where Field = '" + Field + "' and UnitSourceId =" + UnitSourceId.ToString() + " and MiniUnitId = " + MiniUnitId.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            foreach (DataRow Unit in dbDataTable.Rows)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(Unit["Qty"], 0, false)))
                {
                    IsTrue = true;
                }
            }

            return IsTrue;
        }

        public bool VerifyUnitSourceActiveUpdate(string Field, int UnitSourceId)
        {
            bool IsTrue = false;
            string query = "select Count(*) as Qty from UnitSourceActiveUpdate where Field = '" + Field + "' and UnitSourceId =" + UnitSourceId.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            foreach (DataRow Unit in dbDataTable.Rows)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(Unit["Qty"], 0, false)))
                {
                    IsTrue = true;
                }
            }

            return IsTrue;
        }

        public void DeleteUnitSourceActiveUpdate(string Field, string MiniUnitId, string UnitSourceId)
        {
            string query;
            if (MiniUnitId == "0")
            {
                query = "Delete From UnitSourceActiveUpdate Where Field = '" + Field + @"' and
                                UnitSourceId = " + UnitSourceId;
            }
            else
            {
                query = "Delete From UnitSourceActiveUpdate Where Field = '" + Field + @"' and
                                UnitSourceId = " + UnitSourceId + @" and
                                MiniUnitId = " + MiniUnitId;
            }

            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
        }

        public void SaveUnitSourceActiveUpdate(string Field, string MiniUnitId, string UnitSourceId)
        {
            string query = @"INSERT INTO UnitSourceActiveUpdate
                                           (Field, MiniUnitId, UnitSourceId)
                                     VALUES ('" + Field + "'," + MiniUnitId + "," + UnitSourceId + ")";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}