using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShipSmpl
{
    public class DatabaseHelperCeres
    {
        public static string StrConnWTCCeres = ConfigurationManager.ConnectionStrings["WTCCeresEntities"].ConnectionString;

        public struct BagAsnMb
        {
            public int MinibookingId;
            public int BagInvenotryId;
            public int MinibookingTempId;
            public int BookingBagAssignmentId;
        }

        public object getAllCompanies(string conditions)
        {
            string query = @"Select C.CompanyID, CompanyCode, CompanyName, Email, Website, C.DescCompanyType,C.CompanyTypeId, Notes, Rating, Address, City,
		[Zip Code], Province, Country, Phone, Fax, [Main Address], Description, RateCode, CustomerRateTypeId
        From VW_CompanyCompanyType C left join (select *
		from [Addresses]  where [Main Address]=1 and Type = 'Company') as A on C.CompanyID = A.[Company ID] " + conditions;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public object getAllTypes()
        {
            string query = "Select distinct(DescCompanyType) from VW_CompanyCompanyType order by DescCompanyType";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        /// <summary>
        /// Get data from only one table in the database and bring a DataTable with the data
        /// </summary>
        /// <param name="tableName">Table</param>
        /// <param name="tableFiels">Fields</param>
        /// <param name="conditions">Where, order by, group by, etc.</param>
        /// <returns></returns>
        public DataTable getTableInfo(string tableName, string tableFiels, string conditions)
        {
            string query = "Select " + tableFiels + " from " + tableName + " " + conditions;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getDataByQuery(string query)
        {
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public object getUnitCommodities(string conditions)
        {
            string query = @"Select [Booking Number], [Commodities] from [dbo].[Bookings]
where [Active Booking] = 1 and Sources is not null and [Booking Number] =  '" + Strings.Trim(conditions) + "'";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (!Information.IsDBNull(dbDataTable.Rows[0]["Commodities"]))
            {
                return dbDataTable.Rows[0]["Commodities"];
            }
            else
            {
                return "";
            }
        }

        public void saveUpdateDrayage(int serviceID, string truckingComp, string rateType, string from_, string to_, decimal rate)
        {
            string query = "Select * from Drayage_Rate where ID = " + serviceID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                var dbRow = dbDataTable.Rows[0];
                dbRow["Trucking_Company"] = truckingComp;
                dbRow["Rate_Type"] = rateType;
                dbRow["From"] = from_;
                dbRow["To"] = to_;
                dbRow["Rate"] = rate;
            }
            else
            {
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow["Trucking_Company"] = truckingComp;
                dbNewRow["Rate_Type"] = rateType;
                dbNewRow["From"] = from_;
                dbNewRow["To"] = to_;
                dbNewRow["Rate"] = rate;
                dbDataTable.Rows.Add(dbNewRow);
            }

            dbAdapter.Update(dbDataTable);
        }

        public bool rejectContainer(int containerId)
        {
            string query = "Select * from [Containers In-Out] where [Unique ID] = " + containerId.ToString();
            var dbDataTable = new DataTable();
            bool containerRejected = true;
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                var dbRow = dbDataTable.Rows[0];

                // If Not IsDBNull(dbRow("Container Rejected")) AndAlso dbRow("Container Rejected") = True Then
                // containerRejected = False
                // Else
                // ' Reject Container
                dbRow["Container Rejected"] = true;
                dbAdapter.Update(dbDataTable);

                // Create new Record
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow["Container Number"] = dbRow["Container Number"];
                dbNewRow["WorkStation In"] = dbRow["WorkStation In"];
                dbNewRow["Condition In"] = dbRow["Condition In"];
                dbNewRow["Gate Date In"] = dbRow["Gate Date In"];
                dbNewRow["Yard Code In"] = dbRow["Yard Code In"];
                dbNewRow["Yard Name In"] = dbRow["Yard Name In"];
                dbNewRow["Terminal Code In"] = dbRow["Terminal Code In"];
                dbNewRow["Terminal Name In"] = dbRow["Terminal Name In"];
                dbNewRow["Street Turn"] = false;
                dbNewRow["Release Number"] = dbRow["Delivered Booking"]; // ' FIIIXX
                dbNewRow["Damage In"] = dbRow["Damage In"];
                dbNewRow["SS Line Code In"] = dbRow["SS Line Code In"];
                dbNewRow["SS Line Name In"] = dbRow["SS Line Name In"];
                dbNewRow["ContainerSize"] = dbRow["ContainerSize"];
                dbNewRow["GrossWeightIn"] = dbRow["GrossWeightIn"];
                dbNewRow["TareWeightIn"] = dbRow["TareWeightIn"];
                dbNewRow["Carrier Code In"] = dbRow["Carrier Code In"];
                dbNewRow["Carrier Name In"] = dbRow["Carrier Name In"];
                dbNewRow["Carrier Truck In"] = dbRow["Carrier Truck In"];
                dbNewRow["Carrier DriverID In"] = dbRow["Carrier DriverID In"];
                dbNewRow["Carrier DriverName In"] = dbRow["Carrier DriverName In"];
                dbNewRow["Comments In"] = dbRow["Comments In"];
                dbNewRow["In-Gate To Excel"] = false;
                dbNewRow["Assigned To Excel"] = true;
                dbNewRow["Assigned To Storage"] = false;
                dbNewRow["Assigned To Extra"] = false;
                dbNewRow["Excel Booking Number"] = dbRow["Excel Booking Number"];
                dbNewRow["Excel FileName In"] = dbRow["Excel FileName In"];
                dbNewRow["Container Out-Gated"] = false;
                dbDataTable.Rows.Add(dbNewRow);
                dbAdapter.Update(dbDataTable);
                containerRejected = true;
                // End If
                // End If
            }

            return containerRejected;
        }

        public void UpdatePreSendStatus(int containerId, bool preSendStatus)
        {
            string query = "Select * from [Containers In-Out] where [Unique ID] = " + containerId.ToString();
            var dbDataTable = new DataTable();
            bool containerRejected = true;
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                var dbRow = dbDataTable.Rows[0];
                dbRow["Pre Send EDI"] = preSendStatus;
                dbAdapter.Update(dbDataTable);
                dbAdapter.Update(dbDataTable);
            }
        }

        public void saveUpdateFSC(int serviceID, string truckingComp, DateTime fromDate, DateTime toDate, decimal rate, string rateName, bool shouldSaveToDate)
        {
            string query = "Select * from FSC_Rate where ID = " + serviceID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                var dbRow = dbDataTable.Rows[0];
                dbRow["Trucking_Company"] = truckingComp;
                dbRow["From_Date"] = fromDate;
                dbRow["Rate"] = rate;
                dbRow["Rate_Name"] = rateName;
                if (shouldSaveToDate)
                {
                    dbRow["To_Date"] = toDate;
                }
                else
                {
                    dbRow["To_Date"] = DBNull.Value;
                }
            }
            else
            {
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow["Trucking_Company"] = truckingComp;
                dbNewRow["From_Date"] = fromDate;
                dbNewRow["To_Date"] = toDate;
                dbNewRow["Rate"] = rate;
                dbNewRow["Rate_Name"] = rateName;
                if (shouldSaveToDate)
                {
                    dbNewRow["To_Date"] = toDate;
                }
                else
                {
                    dbNewRow["To_Date"] = DBNull.Value;
                }

                dbDataTable.Rows.Add(dbNewRow);
            }

            dbAdapter.Update(dbDataTable);
        }

        public void saveUpdateTEF(int serviceID, DateTime wkdaysCutOff, decimal wkDaysDayRate, decimal wkDaysNightRate, DateTime wkEndsCutOff, decimal wkendsDayRate, decimal wkEndsNightRate, string terminal, DateTime fromDate, DateTime toDate, string rateType)
        {
            string query = "Select * from TEF_Rate where ID = " + serviceID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            {
                var withBlock = My.MyProject.Forms.FrmAddEditServices;
                if (dbDataTable.Rows.Count > 0)
                {
                    var dbRow = dbDataTable.Rows[0];
                    dbRow["WkDaysDayRate"] = wkDaysDayRate;
                    dbRow["WkDaysNightRate"] = wkDaysNightRate;
                    dbRow["WkEndsDayRate"] = wkendsDayRate;
                    dbRow["WkEndsNightRate"] = wkEndsNightRate;
                    dbRow["Terminal"] = terminal;
                    dbRow["FromDate"] = fromDate;
                    dbRow["RateType"] = rateType;
                    if (withBlock.wkDayCutoffCheckbox.Checked == false)
                    {
                        dbRow["WkDaydCutOffTime"] = DBNull.Value;
                    }
                    else
                    {
                        dbRow["WkDaydCutOffTime"] = wkdaysCutOff.TimeOfDay;
                    }

                    if (withBlock.wkEndCutOffCheckbox.Checked == false)
                    {
                        dbRow["WkEndsCutOffTime"] = DBNull.Value;
                    }
                    else
                    {
                        dbRow["WkEndsCutOffTime"] = wkEndsCutOff.TimeOfDay;
                    }

                    if (withBlock.endDateCheckbox.Checked)
                    {
                        dbRow["ToDate"] = DBNull.Value;
                    }
                    else
                    {
                        dbRow["ToDate"] = toDate;
                    }
                }
                else
                {
                    var dbNewRow = dbDataTable.NewRow();
                    dbNewRow["WkDaysDayRate"] = wkDaysDayRate;
                    dbNewRow["WkDaysNightRate"] = wkDaysNightRate;
                    dbNewRow["WkEndsDayRate"] = wkendsDayRate;
                    dbNewRow["WkEndsNightRate"] = wkEndsNightRate;
                    dbNewRow["Terminal"] = terminal;
                    dbNewRow["FromDate"] = fromDate;
                    dbNewRow["ToDate"] = toDate;
                    dbNewRow["RateType"] = rateType;
                    if (withBlock.wkDayCutoffCheckbox.Checked == false)
                    {
                        dbNewRow["WkDaydCutOffTime"] = DBNull.Value;
                    }
                    else
                    {
                        dbNewRow["WkDaydCutOffTime"] = wkdaysCutOff.TimeOfDay;
                    }

                    if (withBlock.wkEndCutOffCheckbox.Checked == false)
                    {
                        dbNewRow["WkEndsCutOffTime"] = DBNull.Value;
                    }
                    else
                    {
                        dbNewRow["WkEndsCutOffTime"] = wkEndsCutOff.TimeOfDay;
                    }

                    if (withBlock.endDateCheckbox.Checked)
                    {
                        dbNewRow["ToDate"] = DBNull.Value;
                    }
                    else
                    {
                        dbNewRow["ToDate"] = toDate;
                    }

                    dbDataTable.Rows.Add(dbNewRow);
                }
            }

            dbAdapter.Update(dbDataTable);
        }

        public void insertInTable(string query)
        {
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
        }

        public void deleteMiniUnit(string query)
        {
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
        }

        // Public Function verifyMiniUnitByRecordKey(ByVal RecordKey As Integer) As Boolean
        // Dim IsTrue As Boolean = False
        // Dim query As String = "select Count(*) as Qty from MiniUnit where RecordKey =" + RecordKey.ToString()
        // Dim dbDataTable As New System.Data.DataTable
        // Dim dbAdapter = New System.Data.SqlClient.SqlDataAdapter(query, StrConnWTCCeres)
        // Dim dbCommand = New System.Data.SqlClient.SqlCommandBuilder(dbAdapter)
        // dbAdapter.Fill(dbDataTable)

        // For Each Unit In dbDataTable.Rows
        // If Unit("Qty") > 0 Then
        // IsTrue = True
        // End If
        // Next

        // Return IsTrue
        // End Function

        //public string getBookingService(int RecordKey)
        //{
        //    string tService = "N/A";
        //    string query = @"Select [Booking Service] as BS
        //                        from Bookings B
        //                        Inner Join [Booking Unit Sources] BUS on B.[Booking Number] = BUS.[Booking Number]
        //                        Inner Join [Rail List] RL on BUS.Unit = RL.[Unit Number]
        //                        where RL.[Record Key] = " + RecordKey.ToString();
        //    var dbDataTable = new DataTable();
        //    var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
        //    var dbCommand = new SqlCommandBuilder(dbAdapter);
        //    dbAdapter.Fill(dbDataTable);
        //    if (verifyBookingService(RecordKey) == true)
        //    {
        //        foreach (DataRow item in dbDataTable.Rows)
        //        {
        //            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(item("BS"), '\u0001', false)))
        //            {
        //                tService = "BAG";
        //            }
        //            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(item("BS"), '\u0002', false)))
        //            {
        //                tService = "BAGGER";
        //            }
        //            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(item("BS"), '\u0003', false)))
        //            {
        //                tService = "BULK";
        //            }
        //            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(item("BS"), '\u0004', false)))
        //            {
        //                tService = "PALETE";
        //            }
        //            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(item("BS"), '\u0005', false)))
        //            {
        //                tService = "TOTE";
        //            }
        //        }
        //    }

        //    return tService;
        //}

        //public bool verifyBookingService(int RecordKey)
        //{
        //    bool IsTrue = false;
        //    string query = @"Select Count([Booking Service]) As Qty
        //                        from Bookings B
        //                        Inner Join [Booking Unit Sources] BUS on B.[Booking Number] = BUS.[Booking Number]
        //                        Inner Join [Rail List] RL on BUS.Unit = RL.[Unit Number]
        //                        where RL.[Record Key] = " + RecordKey.ToString();
        //    var dbDataTable = new DataTable();
        //    var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
        //    var dbCommand = new SqlCommandBuilder(dbAdapter);
        //    dbAdapter.Fill(dbDataTable);
        //    foreach (var Unit in dbDataTable.Rows)
        //    {
        //        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(Unit("Qty"), 0, false)))
        //        {
        //            IsTrue = true;
        //        }
        //    }

        //    return IsTrue;
        //}

        public int LastInsertedCompanyId;

        public void saveCompanyInfo(string code, string name, string email, string webSite, int rating, int type, Dictionary<string, string> edi, string phone, string fax, Dictionary<string, string> address, decimal creditLimit, DateTime customerSince, int invoiceDue, string notes, int companyId)
        {
            string query = "Select * from Company where CompanyId = " + companyId.ToString();
            var dbDataTable = new DataTable();
            var dbAdapterr = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapterr);
            dbAdapterr.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                var data = dbDataTable.Rows[0];
                data["CompanyCode"] = code;
                data["CompanyName"] = name;
                data["Email"] = email;
                data["Website"] = webSite;
                data["CompanyTypeId"] = type;
                data["Rating"] = rating;
                data["Notes"] = notes;
            }
            else
            {
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow["CompanyCode"] = code;
                dbNewRow["CompanyName"] = name;
                dbNewRow["Email"] = email;
                dbNewRow["Website"] = webSite;
                dbNewRow["CompanyTypeId"] = type;
                dbNewRow["Rating"] = rating;
                dbNewRow["Notes"] = notes;
                dbDataTable.Rows.Add(dbNewRow);
            }

            LastInsertedCompanyId = getCompanyID(name, code, type.ToString());
            dbAdapterr.Update(dbDataTable);
            saveAddress(address, LastInsertedCompanyId, "Company", 0);
        }

        public void saveCompanyEDI(int companyID, Dictionary<string, string> edi)
        {
            string query1 = "Select * from [dbo].[Shipping Line EDI] where [Shipping Line ID] = " + companyID.ToString();
            var dbDataTable1 = new DataTable();
            var dbAdapter1 = new SqlDataAdapter(query1, StrConnWTCCeres);
            var dbCommand1 = new SqlCommandBuilder(dbAdapter1);
            dbAdapter1.Fill(dbDataTable1);
            if (dbDataTable1.Rows.Count > 0)
            {
                var data1 = dbDataTable1.Rows[0];
                data1["Shipping Line ID"] = companyID;
                data1["Client ID"] = edi["Client ID"];
                data1["Sender ID"] = edi["Sender ID"];
                data1["Client SCAC Code"] = edi["Client SCAC Code"];
                data1["Version"] = edi["Version"];
                data1["Security Code"] = edi["Security Code"];
                data1["Line Delimeter"] = edi["Line Delimeter"];
                data1["Require EDI"] = Convert.ToInt32(edi["Require EDI"]);
                data1["AllowPresend"] = Convert.ToInt32(edi["AllowPresend"]);
                data1["Use FTP"] = Convert.ToInt32(edi["Use FTP"]);
                data1["Use Email"] = Convert.ToInt32(edi["Client ID"]);
                data1["Email"] = edi["Use Email"];
                data1["Server Name"] = edi["Server Name"];
                data1["User Name"] = edi["Client ID"];
                data1["Password"] = edi["User Name"];
                data1["IP Address"] = edi["IP Address"];
                data1["Port Number"] = edi["Port Number"];
                data1["Folder Name"] = edi["Folder Name"];
                data1["Booking Prefix"] = edi["Booking Prefix"];
            }
            // dbDataTable1.Rows.Clear()
            else
            {
                var dbNewRow1 = dbDataTable1.NewRow();
                dbNewRow1["Shipping Line ID"] = companyID;
                dbNewRow1["Client ID"] = edi["Client ID"];
                dbNewRow1["Sender ID"] = edi["Sender ID"];
                dbNewRow1["Client SCAC Code"] = edi["Client SCAC Code"];
                dbNewRow1["Version"] = edi["Version"];
                dbNewRow1["Security Code"] = edi["Security Code"];
                dbNewRow1["Line Delimeter"] = edi["Line Delimiter"];
                dbNewRow1["Require EDI"] = Convert.ToInt32(edi["Require EDI"]);
                dbNewRow1["AllowPresend"] = Convert.ToInt32(edi["AllowPresend"]);
                dbNewRow1["Use FTP"] = Convert.ToInt32(edi["Use FTP"]);
                dbNewRow1["Use Email"] = Convert.ToInt32(edi["Client ID"]);
                dbNewRow1["Email"] = edi["Use Email"];
                dbNewRow1["Server Name"] = edi["Server Name"];
                dbNewRow1["User Name"] = edi["Client ID"];
                dbNewRow1["Password"] = edi["User Name"];
                dbNewRow1["IP Address"] = edi["IP Address"];
                dbNewRow1["Port Number"] = edi["Port Number"];
                dbNewRow1["Folder Name"] = edi["Folder Name"];
                dbNewRow1["Booking Prefix"] = edi["Booking Prefix"];
                dbDataTable1.Rows.Add(dbNewRow1);
                dbAdapter1.Update(dbDataTable1);
            }
        }

        public int getCompanyID(string name, string code, string type)
        {
            string query = "Select * from VW_CompanyCompanyType where CompanyCode = '" + code + "' and CompanyName = '" + name + "' and CompanyTypeId = '" + type + "'";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return Conversions.ToInteger(dbDataTable.Rows[0]["CompanyID"]);
        }

        public void deleteRows(string tableName, string condition)
        {
            string query = "delete from " + tableName + " " + condition;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
        }

        public void saveAddress(Dictionary<string, string> address, int companyID, string typeofAddress, int contactID)
        {
            var query = default(string);
            if (typeofAddress.Equals("Company"))
            {
                query = "Select * from [Addresses]  where type = 'Company' and [Company ID] = " + companyID.ToString();
            }
            else if (typeofAddress.Equals("Contact"))
            {
                if (contactID == 0)
                {
                    query = "Select * from [Addresses]  where type = 'Customer' and [ID] = 0 ";
                }
                else
                {
                    query = "Select * from [Addresses]  where type = 'Customer'  and [ID] = " + contactID.ToString();
                }
            }

            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (typeofAddress.Equals("Company"))
            {
                deleteRows("[Addresses]", "where type = 'Company' and [Company ID] = " + companyID.ToString());
            }

            dbAdapter.Update(dbDataTable);
            for (int i = 1, loopTo = (int)Math.Round(address.Count / 8d); i <= loopTo; i++)
            {
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow["Company ID"] = companyID;
                dbNewRow["Address"] = address["Address" + i.ToString()];
                dbNewRow["City"] = address["City" + i.ToString()];
                dbNewRow["Country"] = address["Country" + i.ToString()];
                dbNewRow["Province"] = address["Province" + i.ToString()];
                dbNewRow["Zip Code"] = address["Postal" + i.ToString()];
                dbNewRow["Phone"] = Strings.Trim(address["Phone" + i.ToString()]);
                dbNewRow["Fax"] = Strings.Trim(address["Fax" + i.ToString()]);
                dbNewRow["Description"] = address["Description" + i.ToString()];
                if (typeofAddress.Equals("Company"))
                {
                    dbNewRow["Type"] = "Company";
                }
                else
                {
                    dbNewRow["Type"] = "Contact";
                }

                if (i == 1)
                {
                    dbNewRow["Main Address"] = 1;
                }
                else
                {
                    dbNewRow["Main Address"] = 0;
                }

                dbDataTable.Rows.Add(dbNewRow);
                dbAdapter.Update(dbDataTable);
            }
        }

        public int getLastAddress(int companyID)
        {
            string query = "Select * from [Addresses] where [Company ID] = " + companyID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return Conversions.ToInteger(dbDataTable.Rows[dbDataTable.Rows.Count - 1]["ID"]);
        }

        public bool infoAvailable(string tableName, string condition)
        {
            string query = "Select * from " + tableName + " " + condition;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable.Rows.Count == 0;
        }

        public void saveContact(int contactID, int companyID, string firstName, string lastName, string companyPhone, string cellphone, string fax, string email, string extension, string department, int secondAddressID, string notes)
        {
            string query = "Select * from Contacts where ID = " + contactID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                var row = dbDataTable.Rows[0];
                row["Company ID"] = companyID;
                row["First Name"] = firstName;
                row["Last Name"] = lastName;
                row["Mobile"] = cellphone;
                row["Fax"] = Strings.Trim(fax);
                row["Phone"] = Strings.Trim(companyPhone);
                row["Extension"] = Strings.Trim(extension);
                row["Email"] = email;
                row["Department"] = department;
                row["Second Address ID"] = secondAddressID;
                row["Notes"] = notes;
            }
            else
            {
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow["Company ID"] = companyID;
                dbNewRow["First Name"] = firstName;
                dbNewRow["Last Name"] = lastName;
                dbNewRow["Fax"] = Strings.Trim(fax);
                dbNewRow["Phone"] = Strings.Trim(companyPhone);
                dbNewRow["Extension"] = extension;
                dbNewRow["Mobile"] = Strings.Trim(cellphone);
                dbNewRow["Email"] = email;
                dbNewRow["Department"] = department;
                dbNewRow["Second Address ID"] = secondAddressID;
                dbNewRow["Notes"] = notes;
                dbDataTable.Rows.Add(dbNewRow);
            }

            dbAdapter.Update(dbDataTable);
        }

        public void saveTemplate(int templateID, string title, string companyType, string departamnet, RichTextBox message)
        {
            string query = "Select * from [Message Templates] where ID = " + templateID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                var row = dbDataTable.Rows[0];
                row["Title"] = title;
                row["Company Type"] = companyType;
                row["Department"] = departamnet;
                row["Message"] = message.Rtf;
            }
            else
            {
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow["Title"] = title;
                dbNewRow["Company Type"] = companyType;
                dbNewRow["Department"] = departamnet;
                dbNewRow["Message"] = message.Rtf;
                dbDataTable.Rows.Add(dbNewRow);
            }

            dbAdapter.Update(dbDataTable);
        }

        public void saveRule(int ruleID, string tableName, string ruleTitle)
        {
            string query = "Select * from " + tableName + " where ID = " + ruleID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                var row = dbDataTable.Rows[0];
                row["Title"] = ruleTitle;
            }
            else
            {
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow["Title"] = ruleTitle;
                dbDataTable.Rows.Add(dbNewRow);
            }

            dbAdapter.Update(dbDataTable);
        }

        public void saveOrUpdateInGate(int ingateID, string terminalInCode, string terminalInName, string yardInCOde, string yardInName, DateTime InGateDate, DateTime InGateTime, bool streetTurn, string releaseNumber, string carrierCodeIn, string carrierNameIn, string truckNumber, string sSInLineCode, string sSInLineName, string containerNumber, string containerSize, char status, decimal grossWeight, decimal tareWeight, char damages, string comments, bool inGateEDI, bool trouble, bool shouldSendEdi)
        {
            string query = "Select * from [Containers In-Out]  where [Unique ID] = " + ingateID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            // InGateTime = New DateTime(InGateDate.ToShortDateString + " " + InGateTime.ToShortTimeString)
            if (dbDataTable.Rows.Count > 0)
            {
                var row = dbDataTable.Rows[0];
                row["Container Number"] = containerNumber;
                // row.Item("Workstation In") = ruleTitle
                row["Condition In"] = status;
                row["Gate Date In"] = InGateDate;
                row["Gate Time In"] = InGateTime;
                row["Yard Code In"] = yardInCOde;
                row["Yard Name In"] = yardInName;
                row["Terminal Code In"] = terminalInCode;
                row["Terminal Name In"] = terminalInName;
                row["Street Turn"] = streetTurn;
                row["Release Number"] = releaseNumber;
                row["Damage In"] = damages;
                row["SS Line Code In"] = sSInLineCode;
                row["SS Line Name In"] = sSInLineName;
                row["ContainerSIze"] = containerSize;
                row["GrossWeightIn"] = grossWeight;
                row["TareWeightIn"] = tareWeight;
                row["Gross Weight"] = MdlContainerManagement.DoFunctions.MKS((float)Conversion.Val(grossWeight));
                row["Tare Weight"] = MdlContainerManagement.DoFunctions.MKS((float)Conversion.Val(tareWeight));
                row["Carrier Code In"] = carrierCodeIn;
                row["Carrier Name In"] = carrierNameIn;
                row["Carrier Truck In"] = truckNumber;
                row["comments In"] = comments;
                // row.Item("In Gate EDI") = inGateEDI
                row["Trouble In-gate"] = trouble;
            }
            // row.Item("Should Send InGate EDI") = shouldSendEdi
            else
            {
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow["Container Number"] = containerNumber;
                dbNewRow["Workstation In"] = My.MyProject.Computer.Name;
                dbNewRow["Condition In"] = status;
                dbNewRow["Gate Date In"] = InGateDate;
                dbNewRow["Gate Time In"] = InGateTime;
                dbNewRow["Yard Code In"] = yardInCOde;
                dbNewRow["Yard Name In"] = yardInName;
                dbNewRow["Terminal Code In"] = terminalInCode;
                dbNewRow["Terminal Name In"] = terminalInName;
                dbNewRow["Street Turn"] = streetTurn;
                dbNewRow["Release Number"] = releaseNumber;
                dbNewRow["Damage In"] = damages;
                dbNewRow["SS Line Code In"] = sSInLineCode;
                dbNewRow["SS Line Name In"] = sSInLineName;
                dbNewRow["ContainerSize"] = containerSize;
                dbNewRow["GrossWeightIn"] = grossWeight;
                dbNewRow["TareWeightIn"] = tareWeight;
                dbNewRow["Gross Weight"] = MdlContainerManagement.DoFunctions.MKS((float)Conversion.Val(grossWeight));
                dbNewRow["Tare Weight"] = MdlContainerManagement.DoFunctions.MKS((float)Conversion.Val(tareWeight));
                dbNewRow["Carrier Code In"] = carrierCodeIn;
                dbNewRow["Carrier Name In"] = carrierNameIn;
                dbNewRow["Carrier Truck In"] = truckNumber;
                dbNewRow["comments In"] = comments;
                // dbNewRow.Item("In Gate EDI") = inGateEDI
                dbNewRow["Trouble In-gate"] = trouble;
                // dbNewRow.Item("Should Send InGate EDI") = shouldSendEdi
                dbDataTable.Rows.Add(dbNewRow);
            }

            dbAdapter.Update(dbDataTable);
            dbAdapter.Fill(dbDataTable);
            var testRow = dbDataTable.Rows[dbDataTable.Rows.Count - 1];

            // lastRecordInserted = getLastRecord("[Containers In-Out]", "[Unique ID]", )
            string condition = "where [Container Number] = '" + containerNumber + "' and [Gate Date In] = '" + InGateDate.ToString() + "'";
            lastRecordInserted = getLastRecord("[Containers In-Out]", "[Unique ID]", condition);
        }

        public object getLastRecord(string tableName, string columIDName, string condition)
        {
            string query = "select " + columIDName + " from " + tableName + " " + condition;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable.Rows[0][columIDName.Replace("[", "").Replace("]", "")];
        }

        public void saveOrUpdateOutGate(int ingateID, string terminalCodeTo, string terminalNameTo, string yardInCOdeFrom, string yardInNameFrom, DateTime OutGateDate, DateTime OutGateTime, string bookingNumber, string sealNumber, string carrierCode, string carrierName, string truckNumber, string sSLineCode, string sSLineName, string containerNumber, string containerSize, char status, decimal grossWeight, decimal tareWeight, decimal cargoWeight, char damages, string comments, bool outGateEDI, bool holdOutGate, bool shouldSendEdi, string workstation)
        {
            string query = "Select * from [Containers In-Out]  where [Unique ID] = " + ingateID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            // InGateTime = New DateTime(InGateDate.ToShortDateString + " " + InGateTime.ToShortTimeString)
            if (dbDataTable.Rows.Count > 0)
            {
                var row = dbDataTable.Rows[0];
                row["Container Number"] = containerNumber;
                row["Condition Out"] = status;
                row["Gate Date Out"] = OutGateDate;
                row["Gate Time Out"] = OutGateTime;
                row["Yard Code Out"] = yardInCOdeFrom;
                row["Yard Name Out"] = yardInNameFrom;
                row["Terminal Code Out"] = terminalCodeTo;
                row["Terminal Name Out"] = terminalNameTo;
                if (string.IsNullOrEmpty(sealNumber))
                {
                    row["Seal Number"] = DBNull.Value;
                }
                else
                {
                    row["Seal Number"] = sealNumber;
                }

                row["Booking Number"] = bookingNumber.Split('(')[0];
                row["Delivered Booking"] = bookingNumber;
                row["Excel Booking Number"] = bookingNumber.Split('(')[0];
                row["Damages Out"] = damages;
                row["SS Line Code Out"] = sSLineCode;
                row["SS Line Name Out"] = sSLineName;
                row["ContainerSize"] = containerSize;
                row["GrossWeightOut"] = grossWeight;
                row["TareWeightOut"] = tareWeight;
                row["CargoWeight"] = cargoWeight;
                row["Gross Weight Out"] = MdlContainerManagement.DoFunctions.MKS((float)Conversion.Val(grossWeight));
                row["Tare Weight Out"] = MdlContainerManagement.DoFunctions.MKS((float)Conversion.Val(tareWeight));
                row["Cargo Weight Out"] = MdlContainerManagement.DoFunctions.MKS((float)Conversion.Val(cargoWeight));
                row["Carrier Code Out"] = carrierCode;
                row["Carrier Name Out"] = carrierName;
                row["Carrier Truck Out"] = truckNumber;
                row["Comments Out"] = comments;
                // row.Item("Out Gate EDI") = outGateEDI

                row["Hold Out-gate"] = holdOutGate;
                // row.Item("Should Send OutGate EDI") = shouldSendEdi
                row["Container Out-Gated"] = true;
                if (My.MyProject.Forms.FrmInOutGate.isNewRecord)
                {
                    row["Workstation Out"] = workstation;
                }
            }

            try
            {
                dbAdapter.Update(dbDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured updating the container. Error: " + ex.Message);
            }
        }

        public object lastRecordInserted;

        public void clearOutGate(object outGateID)
        {
            string query = "Select * from [Containers In-Out]  where [Unique ID] = " + outGateID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            // InGateTime = New DateTime(InGateDate.ToShortDateString + " " + InGateTime.ToShortTimeString)
            if (dbDataTable.Rows.Count > 0)
            {
                var row = dbDataTable.Rows[0];
                row["Workstation Out"] = "";
                row["Gate Date Out"] = DBNull.Value;
                row["Gate Time Out"] = DBNull.Value;
                row["Yard Code Out"] = "";
                row["Yard Name Out"] = "";
                row["Carrier Code Out"] = "";
                row["Carrier Name Out"] = "";
                row["Carrier Truck Out"] = "";
                row["Carrier DriverID Out"] = "";
                row["Carrier DriverName Out"] = "";
                row["Comments Out"] = "";
                row["Hold Out-gate"] = DBNull.Value;
                row["Excel Filename Out"] = DBNull.Value;
                row["Container Out-Gated"] = DBNull.Value;
                row["Out Gate EDI"] = DBNull.Value;
                row["Out Gate EDI Date Time"] = DBNull.Value;
                row["Should Send InGate EDI"] = DBNull.Value;
            }

            dbAdapter.Update(dbDataTable);
        }

        public void saveContrAssignment(int recordID, string bookingNumber, int miniBookingId, bool ingateToExcl, bool assngToExcl, bool assngToStor, bool assgntoExtra, bool ischangeOfBooking, bool shouldHoldCont)
        {
            string query = "Select * from [Containers In-Out]  where [Unique ID] = " + recordID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                var row = dbDataTable.Rows[0];
                row["Booking Number"] = bookingNumber.Split('(')[0];
                row["Excel Booking Number"] = bookingNumber;
                row["Delivered Booking"] = bookingNumber;
                row["In-Gate To Excel"] = ingateToExcl;
                row["Assigned To Excel"] = assngToExcl;
                row["Assigned To Extra"] = assgntoExtra;
                row["Assigned To Storage"] = assngToStor;
                row["MiniBookingId"] = miniBookingId;
                row["Seal Number"] = DBNull.Value;
                if (!ischangeOfBooking)
                {
                    row["Seal Number"] = DBNull.Value;
                    row["Cargo Weight Out"] = DBNull.Value;
                    row["Gate Date Out"] = DBNull.Value;
                    row["Carrier Name Out"] = DBNull.Value;
                    row["Carrier Code Out"] = DBNull.Value;
                }

                if (shouldHoldCont)
                {
                    row["Hold Out-Gate"] = true;
                }
            }

            dbAdapter.Update(dbDataTable);
        }

        public void saveContrSplitReassignment(List<int> canIds, int newMiniBookingId, string bookingNumber)
        {
            string canIdsStr = "(" + string.Join(", ", canIds) + ")";
            string query = "Select * from [Containers In-Out]  where [Unique Id] In " + canIdsStr;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                for (int i = 0, loopTo = dbDataTable.Rows.Count - 1; i <= loopTo; i++)
                {
                    var row = dbDataTable.Rows[i];
                    row["Booking Number"] = bookingNumber.Split('(')[0];
                    row["Excel Booking Number"] = bookingNumber;
                    row["Delivered Booking"] = bookingNumber;
                    row["MiniBookingId"] = newMiniBookingId;
                }
            }

            dbAdapter.Update(dbDataTable);
        }

        public void unassignBooking(int recordID, bool isBookingChange)
        {
            string query = "Select * from [Containers In-Out]  where [Unique ID] = " + recordID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                var row = dbDataTable.Rows[0];
                if (isBookingChange)
                {
                    row["Booking Number"] = DBNull.Value;
                    row["Excel Booking Number"] = DBNull.Value;
                    row["In-Gate To Excel"] = false;
                    row["Assigned To Excel"] = false;
                    row["Assigned To Extra"] = false;
                    row["Assigned To Storage"] = false;
                    row["Hold Out-Gate"] = false;
                    row["MiniBookingId"] = DBNull.Value;
                }
                else
                {
                    row["Booking Number"] = DBNull.Value;
                    row["Excel Booking Number"] = DBNull.Value;
                    row["Carrier Name Out"] = DBNull.Value;
                    row["Carrier Code Out"] = DBNull.Value;
                    row["Seal Number"] = DBNull.Value;
                    row["Cargo Weight Out"] = DBNull.Value;
                    row["Gate Date Out"] = DBNull.Value;
                    row["MiniBookingId"] = DBNull.Value;
                    row["Hold Out-Gate"] = false;
                    row["In-Gate To Excel"] = false;
                    row["Assigned To Excel"] = false;
                    row["Assigned To Extra"] = false;
                    row["Assigned To Storage"] = false;
                }
            }

            dbAdapter.Update(dbDataTable);
        }

        public void holdContainer(int recordID, bool shouldHold)
        {
            string query = "Select * from [Containers In-Out]  where [Unique ID] = " + recordID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                var row = dbDataTable.Rows[0];
                if (shouldHold)
                {
                    row["Hold Out-Gate"] = true;
                }
                else
                {
                    row["Hold Out-Gate"] = false;
                }
            }

            dbAdapter.Update(dbDataTable);
        }

        public void saveMiniUnits(int MiniUnitId, DataRow miniUnitDataRow)
        {
            string query = "Select * from MiniUnit where MiniUnitId = " + MiniUnitId.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                var row = dbDataTable.Rows[0];
                row["MiniUnitOrder"] = miniUnitDataRow["MiniUnitOrder"];
                row["UnitSourceId"] = miniUnitDataRow["UnitSourceId"];
                row["TotalBilled"] = miniUnitDataRow["TotalBilled"];
                row["UnBilled"] = miniUnitDataRow["UnBilled"];
                row["MULocation"] = miniUnitDataRow["MULocation"];
                row["Comments"] = miniUnitDataRow["Comments"];
                row["BilledByUnit"] = miniUnitDataRow["BilledByUnit"];
                row["BilledByUnitUnitType"] = miniUnitDataRow["BilledByUnitUnitType"];
                row["UnBilledByUnit"] = miniUnitDataRow["UnBilledByUnit"];
                row["UnBilledByUnitUnitType"] = miniUnitDataRow["UnBilledByUnitUnitType"];
                row["MULocation"] = miniUnitDataRow["MULocation"];
                row["Comments"] = miniUnitDataRow["Comments"];
                row["CustomerId"] = miniUnitDataRow["CustomerId"];
                row["CommodityId"] = miniUnitDataRow["CommodityId"];
                row["GradeId"] = miniUnitDataRow["GradeId"];
            }
            else
            {
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow["MiniUnitOrder"] = miniUnitDataRow["MiniUnitOrder"];
                dbNewRow["UnitSourceId"] = miniUnitDataRow["UnitSourceId"];
                dbNewRow["TotalBilled"] = miniUnitDataRow["TotalBilled"];
                dbNewRow["UnBilled"] = miniUnitDataRow["UnBilled"];
                dbNewRow["MULocation"] = miniUnitDataRow["MULocation"];
                dbNewRow["Comments"] = miniUnitDataRow["Comments"];
                dbNewRow["BilledByUnit"] = miniUnitDataRow["BilledByUnit"];
                dbNewRow["BilledByUnitUnitType"] = miniUnitDataRow["BilledByUnitUnitType"];
                dbNewRow["UnBilledByUnit"] = miniUnitDataRow["UnBilledByUnit"];
                dbNewRow["UnBilledByUnitUnitType"] = miniUnitDataRow["UnBilledByUnitUnitType"];
                dbNewRow["MULocation"] = miniUnitDataRow["MULocation"];
                dbNewRow["Comments"] = miniUnitDataRow["Comments"];
                dbNewRow["CustomerId"] = miniUnitDataRow["CustomerId"];
                dbNewRow["CommodityId"] = miniUnitDataRow["CommodityId"];
                dbNewRow["GradeId"] = miniUnitDataRow["GradeId"];
                dbDataTable.Rows.Add(dbNewRow);
            }

            dbAdapter.Update(dbDataTable);
        }

        //public void saveUpdateMB(int BookignId, string bookingNumb, DataTable miniBookingDT, DataTable bkngCmdtyTable, List<BagAsnMb> BagAsnMbList)
        //{
        //    var bs = new BagInventoryService();
        //    string query = "Select * from [MiniBooking] where [BookingId] = '" + BookignId.ToString() + "'";
        //    var dbDataTable = new DataTable();
        //    var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
        //    var dbCommand = new SqlCommandBuilder(dbAdapter);
        //    int focusedIndex = 0;
        //    dbAdapter.Fill(dbDataTable);

        //    // if mb exists, check id and update rows with minibookingDT rows
        //    if (dbDataTable.Rows.Count > 0)
        //    {
        //        foreach (var originalMbRow in dbDataTable.Rows)
        //        {
        //            focusedIndex = 0;
        //            foreach (var updtedMBrow in miniBookingDT.Rows)
        //            {
        //                if (!Information.IsDBNull(updtedMBrow["MiniBookingId")))
        //                {
        //                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(originalMbRow("MiniBookingId"), updtedMBrow["MiniBookingId"), false)))
        //                    {
        //                        originalMbRow("BookingId") = BookignId;
        //                        originalMbRow("isMainBooking") = updtedMBrow["isMainBooking");
        //                        originalMbRow("MiniBookingOrder") = updtedMBrow["MiniBookingOrder");
        //                        originalMbRow("NumberOfContainer") = updtedMBrow["NumberOfContainer");
        //                        originalMbRow("ContainerSize") = updtedMBrow["ContainerSize");
        //                        originalMbRow("FreeTime") = updtedMBrow["FreeTime");
        //                        originalMbRow("BagProvider") = updtedMBrow["BagProvider");
        //                        originalMbRow("Tagging") = updtedMBrow["Tagging");
        //                        originalMbRow("BagType") = updtedMBrow["BagType");
        //                        originalMbRow("AmountRequested") = updtedMBrow["AmountRequested");
        //                        originalMbRow("SpecialMax") = updtedMBrow["SpecialMax");
        //                        originalMbRow("BagWeight") = updtedMBrow["BagWeight");
        //                        originalMbRow("BagWeightUnit") = updtedMBrow["BagWeightUnit");
        //                        originalMbRow("LotNumber") = updtedMBrow["LotNumber");
        //                        originalMbRow("SpecialInstrux") = updtedMBrow["SpecialInstrux");
        //                        originalMbRow("SpecialInstruxNote") = updtedMBrow["SpecialInstruxNote");
        //                        originalMbRow("GradeBy") = updtedMBrow["GradeBy");
        //                        originalMbRow("PhytosanitaryBy") = updtedMBrow["PhytosanitaryBy");
        //                        originalMbRow("InspectionBy") = updtedMBrow["InspectionBy");
        //                        originalMbRow("FumigationBy") = updtedMBrow["FumigationBy");
        //                        originalMbRow("Other") = updtedMBrow["Other");
        //                        originalMbRow("TerminalEffcFee") = updtedMBrow["TerminalEffcFee");
        //                        originalMbRow("CarrierInId") = updtedMBrow["CarrierInId");
        //                        originalMbRow("CarrierOutId") = updtedMBrow["CarrierOutId");
        //                        originalMbRow("TerminalId") = updtedMBrow["TerminalId");
        //                        originalMbRow("HoldBooking") = updtedMBrow["HoldMinibooking");
        //                        originalMbRow("isMultiMB") = miniBookingDT.Rows.Count > 1;
        //                        dbAdapter.Update(dbDataTable);
        //                        foreach (var newComdty in bkngCmdtyTable.Rows)
        //                        {
        //                            // if new commodity
        //                            if (Information.IsDBNull(newComdty("MinibookingCommodityId")))
        //                            {
        //                                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(newComdty("tempID"), updtedMBrow["tempID"), false)))
        //                                {
        //                                    saveUpdtCmdties(0, Conversions.ToInteger(originalMbRow("MiniBookingId")), (DataRow)newComdty);
        //                                }
        //                            }
        //                            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(newComdty("tempID"), updtedMBrow["tempID"), false)))
        //                            {
        //                                saveUpdtCmdties(Conversions.ToInteger(newComdty("MinibookingCommodityId")), Conversions.ToInteger(originalMbRow("MiniBookingId")), (DataRow)newComdty);
        //                            }
        //                        }

        //                        foreach (var bag in BagAsnMbList)
        //                        {
        //                            if (Information.IsNothing(bag.MinibookingId))
        //                            {
        //                                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(bag.MinibookingTempId, updtedMBrow["tempID"), false)))
        //                                {
        //                                    bs.InsertBookingBagAssignment(bag.BagInvenotryId, Conversions.ToInteger(originalMbRow("MiniBookingId")), DateAndTime.Now);
        //                                }
        //                            }
        //                            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(bag.MinibookingTempId, updtedMBrow["tempID"), false)))
        //                            {
        //                                bs.InsertBookingBagAssignment(bag.BagInvenotryId, Conversions.ToInteger(originalMbRow("MiniBookingId")), DateAndTime.Now);
        //                            }
        //                        }

        //                        focusedIndex += 1;
        //                    }
        //                }
        //            }

        //            // update comdties
        //        }
        //    }

        //    // if miniBookingDT(Record ID) is null, it is a new record, so add it to database
        //    foreach (var updtedMBrow in miniBookingDT.Rows)
        //    {
        //        if (Information.IsDBNull(updtedMBrow["MiniBookingId")))
        //        {
        //            var newRow = dbDataTable.NewRow();
        //            newRow["BookingId"] = BookignId;
        //            newRow["isMainBooking"] = updtedMBrow["isMainBooking");
        //            newRow["MiniBookingOrder"] = updtedMBrow["MiniBookingOrder");
        //            newRow["NumberOfContainer"] = updtedMBrow["NumberOfContainer");
        //            newRow["ContainerSize"] = updtedMBrow["ContainerSize");
        //            // newRow("CarrierCodeIn") = updtedMBrow["CarrierCodeIn")
        //            // newRow("CarrierNameIn") = updtedMBrow["CarrierNameIn")
        //            // newRow("CarrierCodeOut") = updtedMBrow["CarrierCodeOut")
        //            // newRow("CarrierNameOut") = updtedMBrow["CarrierNameOut")
        //            // newRow("ReleaseFromCode") = updtedMBrow["ReleaseFromCode")
        //            // newRow("ReleaseFromName") = updtedMBrow["ReleaseFromName")
        //            newRow["FreeTime"] = updtedMBrow["FreeTime");
        //            newRow["BagProvider"] = updtedMBrow["BagProvider");
        //            newRow["Tagging"] = updtedMBrow["Tagging");
        //            newRow["BagType"] = updtedMBrow["BagType");
        //            newRow["AmountRequested"] = updtedMBrow["AmountRequested");
        //            newRow["SpecialMax"] = updtedMBrow["SpecialMax");
        //            newRow["BagWeight"] = updtedMBrow["BagWeight");
        //            newRow["BagWeightUnit"] = updtedMBrow["BagWeightUnit");
        //            newRow["LotNumber"] = updtedMBrow["LotNumber");
        //            newRow["SpecialInstrux"] = updtedMBrow["SpecialInstrux");
        //            newRow["SpecialInstruxNote"] = updtedMBrow["SpecialInstruxNote");
        //            newRow["GradeBy"] = updtedMBrow["GradeBy");
        //            newRow["PhytosanitaryBy"] = updtedMBrow["PhytosanitaryBy");
        //            newRow["InspectionBy"] = updtedMBrow["InspectionBy");
        //            newRow["FumigationBy"] = updtedMBrow["FumigationBy");
        //            newRow["Other"] = updtedMBrow["Other");
        //            newRow["TerminalEffcFee"] = updtedMBrow["TerminalEffcFee");
        //            newRow["CarrierInId"] = updtedMBrow["CarrierInId");
        //            newRow["CarrierOutId"] = updtedMBrow["CarrierOutId");
        //            newRow["TerminalId"] = updtedMBrow["TerminalId");
        //            newRow["HoldBooking"] = updtedMBrow["HoldMinibooking");
        //            newRow["isMultiMB"] = miniBookingDT.Rows.Count > 1;
        //            dbDataTable.Rows.Add(newRow);
        //            dbAdapter.Update(dbDataTable);

        //            // if commodity doesn't exist in original dt, create new bkngCommodity record with mbID
        //            int mbID = Conversions.ToInteger(getTableInfo("VW_BookingMiniBooking", "[MiniBookingId]", "where [BookingNumber] = '" + bookingNumb + "' order by [MiniBookingId] DESC").Rows[0]["MiniBookingId"]);
        //            foreach (var newComdty in bkngCmdtyTable.Rows)
        //            {
        //                // if new commodity
        //                if (Information.IsDBNull(newComdty("MinibookingCommodityId")))
        //                {
        //                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(newComdty("tempID"), updtedMBrow["tempID"), false)))
        //                    {
        //                        saveUpdtCmdties(0, mbID, (DataRow)newComdty);
        //                    }

        //                    // Else
        //                    // If newComdty("Minibooking ID") = updtedMBrow["Record ID") Then
        //                    // saveUpdtCmdties(newComdty("Record ID"), bookingNumb, updtedMBrow["Record ID"), newComdty)
        //                    // End If
        //                }
        //            }

        //            foreach (var bag in BagAsnMbList)
        //            {
        //                if (Information.IsNothing(bag.MinibookingId))
        //                {
        //                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(bag.MinibookingTempId, updtedMBrow["tempID"), false)))
        //                    {
        //                        bs.InsertBookingBagAssignment(bag.BagInvenotryId, mbID, DateAndTime.Now);
        //                    }
        //                }
        //                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(bag.MinibookingTempId, updtedMBrow["tempID"), false)))
        //                {
        //                    bs.InsertBookingBagAssignment(bag.BagInvenotryId, mbID, DateAndTime.Now);
        //                }
        //            }
        //        }

        //        focusedIndex += 1;
        //    }
        //}

        //public void saveUpdtCmdties(int MinibookingCommodityId, int miniBkngID, DataRow newCmtyRow)
        //{
        //    string query = "Select * from [MinibookingCommodity] where [MinibookingCommodityId] = " + MinibookingCommodityId.ToString();
        //    var dbDataTable = new DataTable();
        //    var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
        //    var dbCommand = new SqlCommandBuilder(dbAdapter);
        //    dbAdapter.Fill(dbDataTable);
        //    // dbDataTable.Rows.Clear()

        //    if (dbDataTable.Rows.Count > 0)
        //    {
        //        foreach (var cmdtyRow in dbDataTable.Rows)
        //        {
        //            // if commodity exists in original dt, update it
        //            cmdtyRow("MiniBookingId") = miniBkngID;
        //            cmdtyRow("GradeId") = newCmtyRow["GradeId"];
        //            cmdtyRow("CommodityId") = newCmtyRow["CommodityId"];
        //        }
        //    }
        //    else
        //    {
        //        var newRowCmdty = dbDataTable.NewRow();
        //        newRowCmdty["MiniBookingId"] = miniBkngID;
        //        newRowCmdty["GradeId"] = newCmtyRow["GradeId"];
        //        newRowCmdty["CommodityId"] = newCmtyRow["CommodityId"];
        //        dbDataTable.Rows.Add(newRowCmdty);
        //    }

        //    dbAdapter.Update(dbDataTable);
        //}

        // Public Sub saveBkgCommodity(ByVal bkngNumb As String, ByVal miniBkngID As Integer, cmdyCode As String, cmdyName As String,
        // gradeCode As String, gradeName As String)

        // Dim query As String = "Select * from [Booking Commodities] where [Record ID] = 0"
        // Dim dbDataTable As New System.Data.DataTable
        // Dim dbAdapter = New System.Data.SqlClient.SqlDataAdapter(query, StrConnWTCCeres)
        // Dim dbCommand = New System.Data.SqlClient.SqlCommandBuilder(dbAdapter)

        // dbAdapter.Fill(dbDataTable)
        // ' dbDataTable.Rows.Clear()

        // Dim newRowCmdty = dbDataTable.NewRow

        // newRowCmdty("MiniBooking ID") = miniBkngID
        // newRowCmdty("Grade Code") = gradeCode
        // newRowCmdty("Grade Name") = gradeName
        // newRowCmdty("Commodity Code") = cmdyCode
        // newRowCmdty("Commodity Name") = cmdyName
        // newRowCmdty("Booking Number") = bkngNumb

        // dbDataTable.Rows.Add(newRowCmdty)
        // dbAdapter.Update(dbDataTable)
        // End Sub

        public object getGradesAndCommodities(string tableName, string condition)
        {
            string query = "Select * from [dbo].[" + tableName + @"]
                                where " + condition;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public void saveCommodity(string code, string name)
        {
            string query = " Select * from Commodity";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            // Select * from Models_Clearance where userID = 137

            var dbNewRow = dbDataTable.NewRow();
            dbNewRow["CommodityCode"] = code;
            dbNewRow["CommodityName"] = name;
            dbDataTable.Rows.Add(dbNewRow);
            dbAdapter.Update(dbDataTable);
        }

        public void saveGrade(string code, string name)
        {
            string query = " Select * from Grade";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            // Select * from Models_Clearance where userID = 137

            var dbNewRow = dbDataTable.NewRow();
            dbNewRow["GradeCode"] = code;
            dbNewRow["GradeName"] = name;
            dbDataTable.Rows.Add(dbNewRow);
            dbAdapter.Update(dbDataTable);
        }

        // Public Sub saveUpdateBooking(ByVal bkgNumb As String, ByVal newbkngNumb As String, bkgType As Char, service As Char, custCode As Integer, custId As Integer, custName As String, custRef As String, totCont As Integer, ssLineCode As String,
        // ssLineId As Integer, SSLineName As String, erd As DateTime, lrd As DateTime, shipperCode As Integer, shipperId As Integer, shipperName As String, shipperRef As String, forwarderCode As Integer,
        // forwarderId As Integer, forwarderName As String, forwarderRef As String, terminalCode As String, terminalId As Integer, terminalName As String, vessel As String, voyage As String, sailingDate As Date,
        // destCntryCode As String, destCntryName As String, destCityCode As String, destCityName As String, destAddress As String, numbOfMB As Integer, contSize As Char,
        // splitBooking As Integer, bkgTypeStr As String, bkgServiceStr As String, expCode As Integer,
        // expName As String, expRef As String, holdBooking As Boolean)

        // Dim query As String = " Select * from Bookings where [Booking Number] = '" + bkgNumb + "'"
        // Dim dbDataTable As New DataTable
        // Dim dbAdapter = New SqlDataAdapter(query, StrConnWTCCeres)
        // Dim dbCommand = New SqlCommandBuilder(dbAdapter)

        // dbAdapter.Fill(dbDataTable)

        // If FrmBookingList.formMode = "Edit" Then
        // Dim row = dbDataTable.Rows(0)

        // row.Item("Booking Number") = newbkngNumb
        // row.Item("Booking Type") = bkgType
        // row.Item("Booking Service") = service
        // row.Item("Customer Name") = custName
        // row.Item("Customer ID") = custCode

        // row.Item("Customer Reference") = custRef
        // row.Item("Number of Cans") = totCont
        // row.Item("Container Size") = contSize
        // row.Item("SS Line Name") = SSLineName
        // row.Item("SS Line Code") = ssLineCode

        // row.Item("LRD") = lrd
        // If FrmEditAddBooking.erdToggleSwitch.Value = True Then
        // row.Item("ERD") = erd
        // Else
        // row.Item("ERD") = DBNull.Value
        // End If
        // row.Item("Shipper Name") = shipperName
        // row.Item("Shipper ID") = shipperCode
        // row.Item("Shipper Reference") = shipperRef
        // row.Item("Forwarder Name") = forwarderName
        // row.Item("Forwarder ID") = forwarderCode
        // row.Item("Forwarder Reference") = forwarderRef

        // row.Item("Terminal Name") = terminalName
        // row.Item("Terminal Code") = terminalCode
        // row.Item("Vessel Name") = vessel
        // row.Item("Voyage #") = voyage
        // row.Item("Sailing Date") = sailingDate

        // row.Item("Destination City Code") = destCityCode
        // row.Item("Destination City Name") = destCityName
        // row.Item("Destination Country Code") = destCntryCode
        // row.Item("Destination Country Name") = destCntryName
        // row.Item("Destination Address") = destAddress

        // row.Item("Number of Mini Bookings") = numbOfMB
        // row.Item("Active Booking") = 1
        // row.Item("Split Booking") = splitBooking
        // row.Item("Sources") = ""
        // row.Item("Ceres Creation") = 1
        // row.Item("BookingType") = bkgTypeStr
        // row.Item("BookingService") = bkgServiceStr

        // row.Item("ExporterName") = expName
        // row.Item("ExporterReference") = expRef

        // row.Item("On Hold") = holdBooking

        // row.Item("ExporterID") = expCode

        // row.Item("CustomerId") = custId

        // row.Item("ShipperId") = shipperId

        // row.Item("ForwarderId") = forwarderId

        // row.Item("TerminalId") = terminalId

        // row.Item("SSLineId") = ssLineId

        // With FrmEditAddBooking
        // If (Not .previousPort.Equals(.deliverToBunifuDropdown.Text)) Or (Not .previousVessel.Equals(.vesselTextBox.Text)) Then
        // row.Item("Change Requested") = DBNull.Value
        // End If

        // End With
        // Else
        // Dim dbNewRow = dbDataTable.NewRow()

        // dbNewRow.Item("Booking Number") = newbkngNumb
        // dbNewRow.Item("Booking Type") = bkgType
        // dbNewRow.Item("Booking Service") = service
        // dbNewRow.Item("Customer Name") = custName
        // dbNewRow.Item("Customer ID") = custCode

        // dbNewRow.Item("Customer Reference") = custRef
        // dbNewRow.Item("Number of Cans") = totCont
        // dbNewRow.Item("Container Size") = contSize
        // dbNewRow.Item("SS Line Name") = SSLineName
        // dbNewRow.Item("SS Line Code") = ssLineCode

        // dbNewRow.Item("LRD") = lrd
        // If FrmEditAddBooking.erdToggleSwitch.Value = True Then
        // dbNewRow.Item("ERD") = erd
        // Else
        // dbNewRow.Item("ERD") = DBNull.Value
        // End If
        // dbNewRow.Item("Shipper Name") = shipperName
        // dbNewRow.Item("Shipper ID") = shipperCode
        // dbNewRow.Item("Shipper Reference") = shipperRef
        // dbNewRow.Item("Forwarder Name") = forwarderName
        // dbNewRow.Item("Forwarder ID") = 0
        // dbNewRow.Item("Forwarder Reference") = forwarderRef

        // dbNewRow.Item("Terminal Name") = terminalName
        // dbNewRow.Item("Terminal Code") = terminalCode
        // dbNewRow.Item("Vessel Name") = vessel
        // dbNewRow.Item("Voyage #") = voyage
        // dbNewRow.Item("Sailing Date") = sailingDate

        // dbNewRow.Item("Destination City Code") = destCityCode
        // dbNewRow.Item("Destination City Name") = destCityName
        // dbNewRow.Item("Destination Country Code") = destCntryCode
        // dbNewRow.Item("Destination Country Name") = destCntryName

        // dbNewRow.Item("Number of Mini Bookings") = numbOfMB
        // dbNewRow.Item("Active Booking") = 1
        // dbNewRow.Item("Split Booking") = splitBooking
        // dbNewRow.Item("Sources") = ""
        // dbNewRow.Item("Ceres Creation") = 1
        // dbNewRow.Item("BookingType") = bkgTypeStr
        // dbNewRow.Item("BookingService") = bkgServiceStr

        // dbNewRow.Item("ExporterName") = expName
        // dbNewRow.Item("ExporterReference") = expRef
        // dbNewRow.Item("DateTimeCreated") = Now

        // dbNewRow.Item("On Hold") = holdBooking

        // dbNewRow.Item("ExporterID") = expCode

        // dbNewRow.Item("CustomerId") = custId

        // dbNewRow.Item("ShipperId") = shipperId

        // dbNewRow.Item("ForwarderId") = forwarderId

        // dbNewRow.Item("TerminalId") = terminalId

        // dbNewRow.Item("SSLineId") = ssLineId

        // dbDataTable.Rows.Add(dbNewRow)
        // End If

        // dbAdapter.Update(dbDataTable)

        // End Sub

        public void saveEDIRecord(int inoutID, string gateMode, string inoutType, int userID, string userName)
        {
            string query = "Select * from [EDI Records] where EDIRecID = 0";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            var dbNewRow = dbDataTable.NewRow();
            dbNewRow["In-Out Unique ID"] = inoutID;
            dbNewRow["Gate Mode"] = gateMode;
            dbNewRow["date and Time"] = DateAndTime.Now;
            dbNewRow["User ID"] = userID;
            dbNewRow["User Name"] = userName;
            dbNewRow["Input Source"] = "MANUAL: " + inoutType;
            dbNewRow["Device Name"] = My.MyProject.Computer.Name;
            dbDataTable.Rows.Add(dbNewRow);
            dbAdapter.Update(dbDataTable);
        }

        public void saveEDIModifiedRecord(int ediRecordID, DateTime ediModDateTime)
        {
            string query = "Select * from [ManualEDILog] where ManEDIId = 0";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            var dbNewRow = dbDataTable.NewRow();
            dbNewRow["EDIRecordID"] = ediRecordID;
            dbNewRow["EDIModDateTime"] = ediModDateTime;
            // dbNewRow("EDIOriginalDateTime") = DBNull.Value
            dbDataTable.Rows.Add(dbNewRow);
            dbAdapter.Update(dbDataTable);
        }

        public void pushEDIRequest(int contRecordID, bool ediInGate, bool ediOutGate, int EDIRecID, DateTime EDIMOdDateTime)
        {
            string query = "Select * from [Push Container EDI]";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            var dbNewRow = dbDataTable.NewRow();
            dbNewRow["Container RecordID"] = contRecordID;
            dbNewRow["EDI In-Gate"] = ediInGate;
            dbNewRow["EDI Out-Gate"] = ediOutGate;
            dbNewRow["EDIRecID"] = EDIRecID;
            dbNewRow["UserRequest"] = 1;
            dbNewRow["EDIModDateTime"] = EDIMOdDateTime;
            dbDataTable.Rows.Add(dbNewRow);
            dbAdapter.Update(dbDataTable);
        }

        public void assignUnitsToMiniBkgs(int muID, int mbID, string bookingNumb, string unitNumb, int railListId)
        {
            string query = "Select * from [Booking Unit Sources] where [Record ID] = 0";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            var dbNewRow = dbDataTable.NewRow();
            dbNewRow["MiniBooking ID"] = mbID;
            dbNewRow["MiniUnitID"] = muID;
            dbNewRow["Booking Number"] = bookingNumb.Split('(')[0];
            dbNewRow["Unit"] = Strings.Trim(unitNumb.Split('(')[0]);
            if (railListId == 0)
            {
                dbNewRow["RailListId"] = DBNull.Value;
            }
            else
            {
                dbNewRow["RailListId"] = railListId;
            }

            dbDataTable.Rows.Add(dbNewRow);
            dbAdapter.Update(dbDataTable);
        }

        public void updateMUCustomer(int miniUnitID, int custumerID)
        {
            string query = "Select * from [MiniUnit] where [MiniUnitID] = " + miniUnitID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnWTCCeres);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            var dbRow = dbDataTable.Rows[0];
            dbRow["CustomerID"] = custumerID;
            dbAdapter.Update(dbDataTable);
        }

        public void AddEDILog(int InOutIDNum, string GateMode, string inputType)
        {
            var DbObjAdapter = new SqlDataAdapter("Select * From [EDI Records] where EDIRecID = 0", StrConnWTCCeres);
            var DbObjCommand = new SqlCommandBuilder(DbObjAdapter);
            var DbObjDataTable = new DataTable();
            DbObjAdapter.Fill(DbObjDataTable);
            var DBObj_NewRow = DbObjDataTable.NewRow();
            DBObj_NewRow["In-Out Unique ID"] = InOutIDNum; // DateTime.Now
            DBObj_NewRow["Gate Mode"] = GateMode;
            DBObj_NewRow["Input Source"] = "MANUAL - " + inputType;
            DBObj_NewRow["User ID"] = My.MyProject.Forms.FrmLoginWindow._userID;
            DBObj_NewRow["User Name"] = My.MyProject.Forms.FrmLoginWindow._employeeName;
            DBObj_NewRow["Date and Time"] = DateAndTime.Now;
            DbObjDataTable.Rows.Add(DBObj_NewRow);
            DbObjAdapter.Update(DbObjDataTable);
        }

        public int getLadstEDIadded()
        {
            var DbObjAdapter = new SqlDataAdapter("SELECT * FROM  [EDI Records] WHERE EDIRecID = (SELECT max(EDIRecID) FROM [EDI Records])", StrConnWTCCeres);
            var DbObjCommand = new SqlCommandBuilder(DbObjAdapter);
            var DbObjDataTable = new DataTable();
            DbObjAdapter.Fill(DbObjDataTable);
            return Conversions.ToInteger(DbObjDataTable.Rows[0]["EDIRecID"]);
        }
    }
}