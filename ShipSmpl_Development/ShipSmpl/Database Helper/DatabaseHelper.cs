using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace ShipSmpl
{
    public class DatabaseHelper
    {
        private SqlConnection myConn;
        private SqlCommand myCmd;
        public static string StrConnWTCOperationsCers = ConfigurationManager.ConnectionStrings["WTCOperationsEntities"].ConnectionString;
        private SqlDataReader myReader;

        public int _ID { get; set; }

        private string _CardID;
        private string _driverCardID;
        public int _PunchID;

        // Public _employeeName As String
        public bool wrongPassword = false;

        public bool _userExists = false;
        private string _employeeType;
        public string _PayMehod;
        private int empID;
        private string StrConnection = StrConnWTCOperationsCers;
        private string StrConnection2 = DatabaseHelperCeres.StrConnWTCCeres;

        /// <summary>
        /// Returns a datatable with data
        /// </summary>
        /// <param name="query">Request a query</param>
        /// <returns>Returns a datatable with data</returns>
        public DataTable getDataTable(string query)
        {
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        /// <summary>
        /// Returns a sqlDataReader with data and one SqlCommand(to close the connection)
        /// </summary>
        /// <param name="query"></param>
        /// <param name="objCommand">SqlCommand</param>
        /// <returns>Returns a sqlDataReader and SqlCommand</returns>
        public SqlDataReader getDataReader(string query, SqlCommand objCommand)
        {
            objCommand.Connection = new SqlConnection(StrConnection);
            objCommand.Connection.Open();
            SqlDataReader objDataReader;
            objCommand.CommandText = query;
            objDataReader = objCommand.ExecuteReader();
            return objDataReader;
        }

        public object userExists(string firstName, string lastName, string aliaas)
        {
            bool userFound = false;
            string query = @"Select ID, Alias, First_Name, Last_Name, Address,Card_ID, Type, Yard, Status, Phone_Number,
                                Start_Date, End_Date, FirstName_Emerg_Contact, LastName_Emerg_Contact, Relationship_Emerg_Contact, PhoneNumber_Emerg_Contact,
                                Birth_Date, SIN_Number, Gender, Job_Description, Pay_Method, Supervisor,
                                Email From Employees order by Alias ASC";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            foreach (DataRow ListRow in dbDataTable.Rows)
            {
                if (ListRow["First_Name"].Equals(firstName) & ListRow["Last_Name"].Equals(lastName) & ListRow["Alias"].Equals(aliaas))
                {
                    _ID = Conversions.ToInteger(ListRow["ID"]);
                    empID = Conversions.ToInteger(ListRow["ID"]);
                    _employeeType = Conversions.ToString(ListRow["Type"]);
                    _PayMehod = Conversions.ToString(ListRow["Pay_Method"]);
                    userFound = true;
                }
            }

            return userFound;
        }

        public void createPunch(string startTime, string endTime, string punchType)
        {
            string query = "Select * from Time_Sheet";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            int recordCount = 0;
            string reason = Conversions.ToString(My.MyProject.Forms.FrmAddNewEntry.siteLocationComboBox.SelectedItem);
            dbAdapter.Fill(dbDataTable);
            var dbNewRow = dbDataTable.NewRow();
            dbNewRow["UserID"] = _ID;
            dbNewRow["Start_Time_Date"] = startTime;
            dbNewRow["Punch_Type"] = punchType;
            dbNewRow["Device_Name"] = Environment.MachineName;
            dbNewRow["Site_Location"] = My.MyProject.Forms.FrmAddNewEntry.siteLocationComboBox.SelectedItem;
            if (endTime.Equals(""))
            {
                dbNewRow["End_Time_Date"] = DBNull.Value;
            }
            else
            {
                dbNewRow["End_Time_Date"] = endTime;
            }

            dbDataTable.Rows.Add(dbNewRow);
            dbAdapter.Update(dbDataTable);
            string query1 = "Select * from Time_Sheet where UserID =" + _ID.ToString();
            var dbDataTable1 = new DataTable();
            var dbAdapter1 = new SqlDataAdapter(query1, StrConnection);
            var dbCommand1 = new SqlCommandBuilder(dbAdapter1);
            int recordCount1 = 0;
            dbAdapter1.Fill(dbDataTable1);
            _PunchID = Conversions.ToInteger(dbDataTable1.Rows[dbDataTable1.Rows.Count - 1]["ID"]);
        }

        public void createUsername(int userID, string username, string password)
        {
            string query = "Select * from Login where User_ID = " + userID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            int recordCount = 0;
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                dbDataTable.Rows[0]["Password"] = password;
                dbDataTable.Rows[0]["Username"] = username;
                dbAdapter.Update(dbDataTable);
            }
            else
            {
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow["User_ID"] = userID;
                dbNewRow["Username"] = username;
                dbNewRow["Password"] = password;
                dbDataTable.Rows.Add(dbNewRow);
            }

            dbAdapter.Update(dbDataTable);
        }

        public void suspendOrTerminateEmployee(int userID, string type, DateTime fromDate, string reason)
        {
            string query = "Select * from Suspensions_Reinstataments_And_Terminations where Suspended_ID = " + userID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            int recordCount = 0;
            dbAdapter.Fill(dbDataTable);
            var dbNewRow = dbDataTable.NewRow();
            dbNewRow["Suspended_ID"] = userID;
            dbNewRow["Date"] = fromDate;
            dbNewRow["Type"] = type;
            dbNewRow["By"] = My.MyProject.Forms.FrmLoginWindow._userID;
            dbNewRow["Suspension_Date"] = DateAndTime.Now.Date;
            dbNewRow["Reason"] = reason;
            dbDataTable.Rows.Add(dbNewRow);
            dbAdapter.Update(dbDataTable);
        }

        public void reinstateEmployee(int userID, string status)
        {
            string query = "Select ID, Status, End_Date from Employees where ID = " + userID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            int recordCount = 0;
            dbAdapter.Fill(dbDataTable);
            dbDataTable.Rows[0]["Status"] = status;
            dbDataTable.Rows[0]["End_Date"] = DBNull.Value;
            dbAdapter.Update(dbDataTable);
        }

        public void createHoliday(string name, DateTime dateH)
        {
            string query = "Select * from Statutory_Holidays";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            int recordCount = 0;
            dbAdapter.Fill(dbDataTable);
            var dbNewRow = dbDataTable.NewRow();
            dbNewRow["Holiday_Name"] = name;
            dbNewRow["Holiday_Date"] = dateH;
            dbDataTable.Rows.Add(dbNewRow);
            dbAdapter.Update(dbDataTable);
        }

        public bool employeeAlreadyGotHolPunch(string holidayDate)
        {
            string query = @"select ta.userID, COUNT(ta.UserID) as numbHolidayPunched  from
                (select * from Time_Sheet t where cast(t.Start_Time_Date as date)= '" + holidayDate + "' and t.UserID = " + _ID.ToString() + @") as ta, Holiday_Punches h
				where ta.ID= h.punchID
				group by ta.UserID";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            int recordCount = 0;
            bool alreadyGotPunch = false;
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                alreadyGotPunch = true;
            }

            return alreadyGotPunch;
        }

        public bool isStatPunch(string PunchID)
        {
            string query = @"select  * from Holiday_Punches
				where punchID = " + PunchID;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            bool isStatPucnh = false;
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                isStatPucnh = true;
            }

            return isStatPucnh;
        }

        public DataTable getHolidays(string condition)
        {
            string query = "Select * from Statutory_Holidays " + condition + " order by Holiday_Date";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            int recordCount = 0;
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getQualifiedEmployees(string dateWithin30Days, string pickedDate, string condition)
        {
            string query = @"select ID, alias, last_name, daysWorked, Pay_Method from employees, (select distinct( userID), count(distinct Start_Time_Date) as daysWorked from Time_Sheet where
				cast(Start_Time_Date as date) >= '" + dateWithin30Days + "' and cast(Start_Time_Date as date) <= '" + pickedDate + @"'
				group by UserID) as userAndDays where ID= userAndDays.UserID " + condition + "  order by alias";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public object getHolidayDate(string holidayName, string selectedYear)
        {
            string query = "Select Holiday_Date from Statutory_Holidays where Holiday_Name = '" + holidayName + @"' and
                                    year(Holiday_Date) = " + selectedYear + "";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable.Rows[0]["Holiday_Date"];
        }

        public object getHolidayName(string punchID)
        {
            int selectedEntry = My.MyProject.Forms.FrmTimeSheet.detailsBunifuDataGridView.CurrentCell.RowIndex;
            string query = "Select Holiday_Name from Holiday_Punches, Statutory_Holidays where punchID = " + punchID + "and Holiday_ID = Statutory_Holidays.ID";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            string hName = "";
            if (dbDataTable.Rows.Count > 0)
            {
                hName = dbDataTable.Rows[0]["Holiday_Name"].ToString();
            }

            return hName;
        }

        public void checkLogin(string username, string password)
        {
            string query = "Select * from Login where Username = '" + username + "'";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            foreach (DataRow user in dbDataTable.Rows)
            {
                if (MdlModifyData.base64Decode(Conversions.ToString(user["Password"])).Equals(password))
                {
                    _ID = Conversions.ToInteger(user["User_ID"]);
                    _userExists = true;
                }
                else
                {
                    wrongPassword = true;
                }
            }
        }

        public string getClearanceLevel()
        {
            string query = "Select ID, Type, Pay_Method, Alias, LAst_Name from Employees where ID = " + _ID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            // _employeeName = dbDataTable.Rows(0).Item("Alias") + " " + dbDataTable.Rows(0).Item("Last_Name")
            _ID = Conversions.ToInteger(dbDataTable.Rows[0]["ID"]);
            empID = Conversions.ToInteger(dbDataTable.Rows[0]["ID"]);
            _employeeType = Conversions.ToString(dbDataTable.Rows[0]["Type"]);
            _PayMehod = Conversions.ToString(dbDataTable.Rows[0]["Pay_Method"]);
            dbAdapter.Update(dbDataTable);
            return default;
        }

        public void saveModification(string modificationType, int modifieldFields)
        {
            string query = "Select * from Modified_Punch";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            var dbNewRow = dbDataTable.NewRow();
            dbAdapter.Fill(dbDataTable);
            if (modificationType.Equals("new"))
            {
                string reason = Conversions.ToString(My.MyProject.Forms.FrmAddNewEntry.reasonNewEntryComboBox.SelectedItem);
                dbAdapter.Fill(dbDataTable);
                if (reason.Equals("Other"))
                {
                    reason = reason + " - " + My.MyProject.Forms.FrmAddNewEntry.RichTextBox1.Text;
                }

                dbNewRow["Modified_By"] = My.MyProject.Forms.FrmAddNewEntry.newEntrymodifiedByTextBox.Text;
                dbNewRow["Reason"] = reason;
            }
            else
            {
                string reason = Conversions.ToString(My.MyProject.Forms.FrmEditEntry.reasonNewEntryComboBox.SelectedItem);
                reason = reason + " - " + My.MyProject.Forms.FrmEditEntry.RichTextBox1.Text;
                dbAdapter.Fill(dbDataTable);
                if (reason.Equals("Other"))
                {
                    reason = reason + " - " + My.MyProject.Forms.FrmEditEntry.RichTextBox1.Text;
                }

                dbNewRow["Modified_By"] = My.MyProject.Forms.FrmEditEntry.modifiedByTextBox.Text;
                dbNewRow["Reason"] = reason;
            }

            dbNewRow["Date_Time_Of_Modification"] = DateTime.Now.ToString();
            dbNewRow["Modified_Fields"] = modifieldFields;
            dbNewRow["Modification_Date"] = DateAndTime.Today.Date.ToShortDateString();
            dbNewRow["Modified_Punch_ID"] = _PunchID;
            dbDataTable.Rows.Add(dbNewRow);
            dbAdapter.Update(dbDataTable);
        }

        public void deleteEmployee(int employeeID)
        {
            string query = "delete From Employees where ID = " + employeeID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            int recordCount = 0;
            dbAdapter.Fill(dbDataTable);
        }

        public void deleteEntry(int punchID)
        {
            string query = "delete From Time_Sheet where ID = " + punchID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
        }

        public void deleteHoliday(string holidayID)
        {
            string query = "delete From Statutory_Holidays where ID = " + holidayID;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            int recordCount = 0;
            dbAdapter.Fill(dbDataTable);
        }

        public object updateCardID(string firstName, string aliaas, string lastName, string cardID)
        {
            string query = "Select ID, Card_ID, First_Name, Last_Name, Alias from Employees Order by First_Name";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            int recordCount = 0;
            bool cardUpdated = false;
            dbAdapter.Fill(dbDataTable);
            foreach (DataRow ListRow in dbDataTable.Rows)
            {
                if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.ConditionalCompareObjectEqual(ListRow["First_Name"], firstName, false), Operators.ConditionalCompareObjectEqual(ListRow["Last_Name"], lastName, false)), Operators.ConditionalCompareObjectEqual(ListRow["Alias"], aliaas, false))))
                {
                    dbDataTable.Rows[recordCount]["Card_ID"] = cardID;
                    dbAdapter.Update(dbDataTable);
                    cardUpdated = true;
                }

                recordCount += 1;
            }

            return cardUpdated;
        }

        public void reassignCard(string userID, string cardID)
        {
            string query = "Select ID, Card_ID, Phone_ID, First_Name, Last_Name, Alias from Employees where ID=" + userID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            foreach (var ListRow in dbDataTable.Rows)
            {
                if (My.MyProject.Forms.FrmCardAssignment.isPhoneID)
                {
                    dbDataTable.Rows[0]["Phone_ID"] = cardID;
                }
                else
                {
                    dbDataTable.Rows[0]["Card_ID"] = cardID;
                }

                dbAdapter.Update(dbDataTable);
            }
        }

        public void updatePunch(string modifiedClockIn, string modifieClockOut, int punchID)
        {
            string query = "Select * From Time_Sheet where ID = " + punchID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            int recordCount = 0;
            dbAdapter.Fill(dbDataTable);
            _PunchID = punchID;
            dbDataTable.Rows[0]["Start_Time_Date"] = modifiedClockIn;
            if (!Information.IsNothing(modifieClockOut))
            {
                dbDataTable.Rows[0]["End_Time_Date"] = modifieClockOut;
            }

            if (My.MyProject.Forms.FrmEditEntry.shiftTypeComboBox.SelectedIndex == 0)
            {
                dbDataTable.Rows[0]["Punch_Type"] = "H";
            }
            else if (My.MyProject.Forms.FrmEditEntry.shiftTypeComboBox.SelectedIndex == 1)
            {
                dbDataTable.Rows[0]["Punch_Type"] = "S";
            }
            else
            {
                dbDataTable.Rows[0]["Punch_Type"] = "PW";
            }

            dbAdapter.Update(dbDataTable);
        }

        public void dissociateCardID()
        {
            string query = " Select ID, Card_ID, Phone_ID From Employees where ID =" + _ID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (My.MyProject.Forms.FrmCardAssignment.isPhoneID)
            {
                dbDataTable.Rows[0]["Phone_ID"] = "N/A";
            }
            else
            {
                dbDataTable.Rows[0]["Card_ID"] = "Not assigned";
            }

            dbAdapter.Update(dbDataTable);
        }

        public object cardAlreadyAssigned(string Card_ID)
        {
            bool cardIsAssigned = false;
            string query;
            if (My.MyProject.Forms.FrmCardAssignment.isPhoneID)
            {
                query = "Select ID, Phone_ID, Card_ID, First_Name, Last_Name From Employees where Phone_ID = '" + Card_ID + "'";
            }
            else
            {
                query = "Select ID, Card_ID, First_Name, Last_Name From Employees where Card_ID = '" + Card_ID + "'";
            }

            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                cardIsAssigned = true;
                _ID = Conversions.ToInteger(dbDataTable.Rows[0]["ID"]);
                // _employeeName = dbDataTable.Rows(0).Item("First_Name") + " " + dbDataTable.Rows(0).Item("Last_Name")
            }

            return cardIsAssigned;
        }

        public object getAllEmployees(string condition)
        {
            string query = "Select ID, Alias, First_Name, Last_Name, Status, Yard, Phone_Number from Employees " + condition + "order by Alias";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public object getAllActiveEmployeesHourly()
        {
            string query = "Select * from Employees where Status = 'Active' AND Pay_Method <> 'Piece work' AND Pay_Method <> 'Salary' order by Alias";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getAllActiveEmployees(string condition)
        {
            string query = @"Select ID, Alias, First_Name, Last_Name, Address,Card_ID, Type, Yard, Status, Phone_Number,
                                Start_Date, End_Date, FirstName_Emerg_Contact, LastName_Emerg_Contact, Relationship_Emerg_Contact, PhoneNumber_Emerg_Contact,
                                Birth_Date, SIN_Number, Gender, Job_Description, Pay_Method, Supervisor,
                                Email from Employees where Status = 'Active' " + condition + " order by Alias";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getWorkingEmployees(string condition)
        {
            string query = "Select * from Time_Sheet " + condition;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getSpecificActiveEmployees(string conditions)
        {
            string query = "Select * from Employees where Status = 'Active' " + conditions + " order by Alias";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getEmployeesBetweenDates(DateTime startDate, DateTime endDate, string conditions)
        {
            string query = @"  select distinct(employees.ID) as ID, First_Name, Last_Name, Alias, Site_Location, yard from employees, time_sheet
  where  cast(start_time_date as date) >= '" + startDate.Date.ToString("yyyy-MM-dd") + @"'
  and cast(start_time_date as date) <= '" + endDate.Date.ToString("yyyy-MM-dd") + @"'
			and employees.ID = time_sheet.UserID " + conditions + " order by first_name";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public bool isWorkingToday(int userID)
        {
            string query = "Select * From time_sheet Where userID = " + userID.ToString() + @" And end_Time_Date Is null and
            cast(start_time_date as date) = '" + DateAndTime.Now.Date.ToString("yyyy-MM-dd") + "'";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable.Rows.Count > 0;
        }

        public DataTable getEmployee(int empID)
        {
            string query = @"Select ID, Alias, First_Name, Last_Name, Address,Card_ID, Type, Yard, Status, Phone_Number,
                                Start_Date, End_Date, FirstName_Emerg_Contact, LastName_Emerg_Contact, Relationship_Emerg_Contact, PhoneNumber_Emerg_Contact,
                                Birth_Date, SIN_Number, Gender, Job_Description, Pay_Method, Supervisor,EmployeePicturePath,
                                Email from Employees where ID = " + empID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getAllActiveEmployees1()
        {
            string query = "Select ID, Alias, First_Name, Last_Name, Status, Yard, Type, Phone_Number from Employees where Status = 'Active' or Status = 'Suspended' order by Alias";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getTableInfo(string tableName, string fields, string condition)
        {
            string query = "Select " + fields + " from " + tableName + " " + condition;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);

            return dbDataTable;
        }

        public void RemoveBlockedContainers()
        {
            string query = "Select * From [Blocked Containers] Where [Block End Date] <= dbo.GETLOCALDATE()";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection2);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);

            string toDeleteRecords = "";

            foreach (DataRow d in dbDataTable.Rows)
            {
                toDeleteRecords += d["ID"].ToString() + ",";
            }
            if (!toDeleteRecords.Equals(""))
            {
                toDeleteRecords = toDeleteRecords.Substring(0, toDeleteRecords.Length - 1);

                string delCommand = "Delete from [Blocked Containers] Where ID in (" + toDeleteRecords + ")";
                var dbDataTable2 = new DataTable();
                var dbAdapter2 = new SqlDataAdapter(delCommand, StrConnection2);
                var dbCommand2 = new SqlCommandBuilder(dbAdapter2);
                dbAdapter2.Fill(dbDataTable2);
            }
        }

        public DataTable getModifiedEntries(string modifiedPunchID)
        {
            string query = "Select * from Modified_Punch where Modified_Punch_ID =" + modifiedPunchID;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getNotificationDetail(int notificationID)
        {
            string query = @"Select Notification_ID, Action_Taken, Alias, Last_Name, Comments, Action_Date_Time from Notifications_Read, Employees
where Notification_ID = " + notificationID.ToString() + " and Read_By = Employees.ID";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public int getTotalemployees()
        {
            string query = "Select count(ID) as totalEmployees from Employees";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return Conversions.ToInteger(dbDataTable.Rows[0]["totalEmployees"]);
        }

        public int getTotalActiveEmployees()
        {
            string query = "Select count(ID) as totalEmployees from Employees where Status = 'Active'";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return Conversions.ToInteger(dbDataTable.Rows[0]["totalEmployees"]);
        }

        public object getAllEmpIdOfCurrentPeriod(DateTime currentStartPayPeriod, DateTime currentEndPayPeriod)
        {
            string query = @"SELECT distinct UserID, E.Alias
  FROM Time_Sheet, Employees E where Start_Time_Date > '" + Conversions.ToString(currentStartPayPeriod) + "' and Start_Time_Date <'" + Conversions.ToString(currentEndPayPeriod) + "' and UserID = E.ID order by E.Alias";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public object getHourlyEmpIdOfCurrentPeriod(DateTime currentStartPayPeriod, DateTime currentEndPayPeriod)
        {
            string punchType;
            if (My.MyProject.Forms.FrmTimeSheet.payMethodComboBox.SelectedIndex == 0)
            {
                punchType = "H";
            }
            else if (My.MyProject.Forms.FrmTimeSheet.payMethodComboBox.SelectedIndex == 1)
            {
                punchType = "S";
            }
            else if (My.MyProject.Forms.FrmTimeSheet.payMethodComboBox.SelectedIndex == 2)
            {
                punchType = "PW";
            }
            else
            {
                punchType = "HDay";
            }

            string query = @"SELECT distinct UserID, E.Alias
  FROM Time_Sheet, Employees E where Start_Time_Date >  '" + currentStartPayPeriod.ToString("yyyy-MM-dd HH:mm") + "' and Start_Time_Date < '" + currentEndPayPeriod.ToString("yyyy-MM-dd HH:mm") + "' and Punch_Type = '" + punchType + "' And UserID = E.ID order by Alias";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public object getAllTimeSheet(int empID, DateTime currentStartPayPeriod, DateTime currentEndPayPeriod)
        {
            string punchType;
            if (My.MyProject.Forms.FrmTimeSheet.payMethodComboBox.SelectedIndex == 0)
            {
                punchType = "And Punch_Type = 'H'";
            }
            else if (My.MyProject.Forms.FrmTimeSheet.payMethodComboBox.SelectedIndex == 1)
            {
                punchType = "And Punch_Type = 'S'";
            }
            else if (My.MyProject.Forms.FrmTimeSheet.payMethodComboBox.SelectedIndex == 2)
            {
                punchType = "And Punch_Type = 'PW'";
            }
            else
            {
                punchType = "And Punch_Type = 'HDay'";
            }

            string query = "Select * from Time_Sheet where Start_Time_Date > '" + Conversions.ToString(currentStartPayPeriod) + "' and Start_Time_Date <='" + Conversions.ToString(currentEndPayPeriod) + "' and UserID = " + empID.ToString() + " " + punchType + " Order by Start_Time_Date";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getSelectedEntry(int entryID)
        {
            string query = @"Select t.ID, t.UserID, t.Start_Time_Date, t.End_Time_Date, t.Punch_Type, t.Device_Name,
                                    t.Site_Location, e.Job_Description, e.Type
                    from Time_Sheet t, Employees e where t.ID = " + entryID.ToString() + " and T.UserID= e.ID  Order by Start_Time_Date";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getAllHourlyTimeSheet()
        {
            string query = "Select * from Time_Sheet, Employee E where Punch_Type = 'H' and UserID = E.ID order by E.Alias";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getAllSkillsAndCertificates(int ID)
        {
            string query = "Select * from Skills_And_Certifications where UserID =" + ID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public object saveEmployee()
        {
            Bitmap employeePic = (Bitmap)My.MyProject.Forms.FrmAddNewEmployee.employeePictureBox.BackgroundImage;
            var mStream = new System.IO.MemoryStream();
            string employeePicturePath = My.MyProject.Forms.FrmAddNewEmployee.remoteFtpPath;
            bool contactSaved = false;
            string query = "Select * From Employees where First_Name = '" + My.MyProject.Forms.FrmAddNewEmployee.firstNameTextBox.Text + "' AND Last_Name = '" + My.MyProject.Forms.FrmAddNewEmployee.lastNameTextBox.Text + "' AND alias = '" + My.MyProject.Forms.FrmAddNewEmployee.aliasTextBox.Text + "'";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                return contactSaved;
            }
            else
            {
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow["Card_ID"] = "Not assigned";
                dbNewRow["First_Name"] = My.MyProject.Forms.FrmAddNewEmployee.firstNameTextBox.Text;
                dbNewRow["Last_Name"] = My.MyProject.Forms.FrmAddNewEmployee.lastNameTextBox.Text;
                dbNewRow["Alias"] = My.MyProject.Forms.FrmAddNewEmployee.aliasTextBox.Text;
                dbNewRow["Address"] = My.MyProject.Forms.FrmAddNewEmployee.adressTextBox.Text;
                dbNewRow["Type"] = My.MyProject.Forms.FrmAddNewEmployee.typeComboBox.SelectedItem;
                dbNewRow["Yard"] = My.MyProject.Forms.FrmAddNewEmployee.yardComboBox.SelectedItem;
                dbNewRow["Phone_Number"] = My.MyProject.Forms.FrmAddNewEmployee.phoneNumberTextBox.Text;
                dbNewRow["EmployeePicturePath"] = employeePicturePath;
                dbNewRow["Status"] = "Active";
                dbNewRow["FirstName_Emerg_Contact"] = My.MyProject.Forms.FrmAddNewEmployee.emergencyFirstNameTextBox.Text;
                dbNewRow["LastName_Emerg_Contact"] = My.MyProject.Forms.FrmAddNewEmployee.emergencyLastNameTextBox.Text;
                dbNewRow["PhoneNumber_Emerg_Contact"] = My.MyProject.Forms.FrmAddNewEmployee.emergencyPhoneNumberTextBox.Text;
                dbNewRow["Relationship_Emerg_Contact"] = My.MyProject.Forms.FrmAddNewEmployee.relationshipTextBox.Text;
                dbNewRow["Start_Date"] = My.MyProject.Forms.FrmAddNewEmployee.startDateDateTimePicker.Value;
                dbNewRow["End_Date"] = DBNull.Value;
                dbNewRow["Email"] = My.MyProject.Forms.FrmAddNewEmployee.emailTextBox.Text;
                dbNewRow["Birth_Date"] = My.MyProject.Forms.FrmAddNewEmployee.birthdateDateTimePicker.Value.Date;
                if (string.IsNullOrEmpty(My.MyProject.Forms.FrmAddNewEmployee.SINumbTextBox.Text))
                {
                    dbNewRow["SIN_Number"] = 0;
                }
                else
                {
                    dbNewRow["SIN_Number"] = My.MyProject.Forms.FrmAddNewEmployee.SINumbTextBox.Text;
                }

                dbNewRow["Gender"] = My.MyProject.Forms.FrmAddNewEmployee.genderComboBox.SelectedItem;
                dbNewRow["Job_Description"] = My.MyProject.Forms.FrmAddNewEmployee.jobDescriptionComboBox.Text;
                dbNewRow["Pay_Method"] = My.MyProject.Forms.FrmAddNewEmployee.payMehodComboBox.SelectedItem;
                dbNewRow["Supervisor"] = My.MyProject.Forms.FrmAddNewEmployee.supervisorTextBox.Text;
                dbDataTable.Rows.Add(dbNewRow);
                dbAdapter.Update(dbDataTable);
                contactSaved = true;
            }

            return contactSaved;
        }

        public void saveHolidayPunch(int HolID)
        {
            string query = "Select * from Holiday_Punches";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            var dbNewRow = dbDataTable.NewRow();
            dbNewRow["PunchID"] = _PunchID;
            dbNewRow["Punch_Date"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            dbNewRow["Holiday_ID"] = HolID;
            dbDataTable.Rows.Add(dbNewRow);
            dbAdapter.Update(dbDataTable);
        }

        public void updateEmployeeInfo(int UserID)
        {
            bool contactSaved = false;
            string query = " Select * From Employees where ID = " + UserID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            Bitmap employeePic = (Bitmap)My.MyProject.Forms.FrmAddNewEmployee.employeePictureBox.BackgroundImage;
            var mStream = new System.IO.MemoryStream();
            string employeePicturePath = My.MyProject.Forms.FrmAddNewEmployee.remoteFtpPath;
            foreach (var employee in dbDataTable.Rows)
            {
                dbDataTable.Rows[0]["First_Name"] = My.MyProject.Forms.FrmAddNewEmployee.firstNameTextBox.Text;
                dbDataTable.Rows[0]["Last_Name"] = My.MyProject.Forms.FrmAddNewEmployee.lastNameTextBox.Text;
                dbDataTable.Rows[0]["Alias"] = My.MyProject.Forms.FrmAddNewEmployee.aliasTextBox.Text;
                dbDataTable.Rows[0]["Address"] = My.MyProject.Forms.FrmAddNewEmployee.adressTextBox.Text;
                dbDataTable.Rows[0]["Type"] = My.MyProject.Forms.FrmAddNewEmployee.typeComboBox.SelectedItem;
                dbDataTable.Rows[0]["Yard"] = My.MyProject.Forms.FrmAddNewEmployee.yardComboBox.SelectedItem;
                dbDataTable.Rows[0]["Phone_Number"] = My.MyProject.Forms.FrmAddNewEmployee.phoneNumberTextBox.Text;
                dbDataTable.Rows[0]["EmployeePicturePath"] = employeePicturePath;
                dbDataTable.Rows[0]["FirstName_Emerg_Contact"] = My.MyProject.Forms.FrmAddNewEmployee.emergencyFirstNameTextBox.Text;
                dbDataTable.Rows[0]["LastName_Emerg_Contact"] = My.MyProject.Forms.FrmAddNewEmployee.emergencyLastNameTextBox.Text;
                dbDataTable.Rows[0]["PhoneNumber_Emerg_Contact"] = My.MyProject.Forms.FrmAddNewEmployee.emergencyPhoneNumberTextBox.Text;
                dbDataTable.Rows[0]["Relationship_Emerg_Contact"] = My.MyProject.Forms.FrmAddNewEmployee.relationshipTextBox.Text;
                dbDataTable.Rows[0]["Start_Date"] = My.MyProject.Forms.FrmAddNewEmployee.startDateDateTimePicker.Value;
                dbDataTable.Rows[0]["Email"] = My.MyProject.Forms.FrmAddNewEmployee.emailTextBox.Text;
                dbDataTable.Rows[0]["Birth_Date"] = My.MyProject.Forms.FrmAddNewEmployee.birthdateDateTimePicker.Value.Date;
                dbDataTable.Rows[0]["SIN_Number"] = My.MyProject.Forms.FrmAddNewEmployee.SINumbTextBox.Text;
                dbDataTable.Rows[0]["Gender"] = My.MyProject.Forms.FrmAddNewEmployee.genderComboBox.SelectedItem;
                dbDataTable.Rows[0]["Job_Description"] = My.MyProject.Forms.FrmAddNewEmployee.jobDescriptionComboBox.Text;
                dbDataTable.Rows[0]["Pay_Method"] = My.MyProject.Forms.FrmAddNewEmployee.payMehodComboBox.SelectedItem;
                dbDataTable.Rows[0]["Supervisor"] = My.MyProject.Forms.FrmAddNewEmployee.supervisorTextBox.Text;
                dbAdapter.Update(dbDataTable);
            }
        }

        public void TerminateEmployee(int ID, DateTime terminationDate)
        {
            bool contactSaved = false;
            string query = "  update Employees Set End_Date = '" + Conversions.ToString(terminationDate.Date) + "', Status = 'Not Active', Card_ID = 'Not assigned' where ID =" + ID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            dbAdapter.Update(dbDataTable);
        }

        public DataTable getModifiedPunchInfo(int punchID)
        {
            string query = @"Select * From Employees E, Modified_Punch M, Time_Sheet T
                                      Where T.ID = M.Modified_Punch_ID And T.UserID = E.ID
                                      And M.Modified_Punch_ID = " + punchID.ToString();
            bool contactSaved = false;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getWorkDone(int workDoneID)
        {
            string query = "Select * from Work_Done where Punch_ID= " + workDoneID.ToString();
            bool contactSaved = false;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public void saveWorkDone(string values)
        {
            string query = "Select * From Work_Done where Punch_ID =" + _PunchID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                string query2 = "Delete From Work_Done where Punch_ID =" + _PunchID.ToString();
                var dbDataTable2 = new DataTable();
                var dbAdapter2 = new SqlDataAdapter(query2, StrConnection);
                var dbCommand2 = new SqlCommandBuilder(dbAdapter2);
                dbAdapter2.Fill(dbDataTable2);
                dbAdapter2.Update(dbDataTable2);
            }

            string query1 = "Insert into Work_Done values (" + _PunchID.ToString() + ", " + values + ")";
            var dbDataTable1 = new DataTable();
            var dbAdapter1 = new SqlDataAdapter(query1, StrConnection);
            var dbCommand1 = new SqlCommandBuilder(dbAdapter1);
            dbAdapter1.Fill(dbDataTable1);
            dbAdapter1.Update(dbDataTable1);
        }

        public void updateSkillsOrCertifications()
        {
            string query = " Select * From Skills_And_Certifications where UserID = " + _ID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                if (My.MyProject.Forms.FrmAddNewEmployee.bagCheckBox.Checked)
                {
                    dbDataTable.Rows[0]["Bag"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.baggerCheckBox.Checked)
                {
                    dbDataTable.Rows[0]["Bagger"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.bagTipperCheckBox.Checked)
                {
                    dbDataTable.Rows[0]["Bag_Tipper"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.BulkCheckBox.Checked)
                {
                    dbDataTable.Rows[0]["Bulk_"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.bulk_HeadsCheckBox.Checked)
                {
                    dbDataTable.Rows[0]["Bulk_Heads"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.warehouseCheckBox.Checked)
                {
                    dbDataTable.Rows[0]["Warehouse"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.yardManagerCheckBox.Checked)
                {
                    dbDataTable.Rows[0]["Yard_Manager"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.emptyMachineCheckBox.Checked)
                {
                    dbDataTable.Rows[0]["Empty_Machine"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee._700HysterCheckBox6.Checked)
                {
                    dbDataTable.Rows[0]["_700_Hyster"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.driverLicenseCheckBox.Checked)
                {
                    dbDataTable.Rows[0]["Driver_License"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.firstAidCheckBox.Checked)
                {
                    My.MyProject.Forms.FrmAddNewEmployee.firstAidComboBox.Show();
                    dbDataTable.Rows[0]["First_Aid"] = "yes";
                    dbDataTable.Rows[0]["First_Aid_Level"] = My.MyProject.Forms.FrmAddNewEmployee.firstAidComboBox.SelectedItem;
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.railcarMoverCheckBox8.Checked)
                {
                    dbDataTable.Rows[0]["Railcar_Mover"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.reachstacherCheckBox.Checked)
                {
                    dbDataTable.Rows[0]["Reachstacker"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.otherCheckBox.Checked)
                {
                    dbDataTable.Rows[0]["Other"] = My.MyProject.Forms.FrmAddNewEmployee.otherTextBox.Text;
                }
                else
                {
                    dbDataTable.Rows[0]["Other"] = null;
                }
            }
            else
            {
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow["UserID"] = _ID;
                if (My.MyProject.Forms.FrmAddNewEmployee.bagCheckBox.Checked)
                {
                    dbNewRow["Bag"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.baggerCheckBox.Checked)
                {
                    dbNewRow["Bagger"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.bagTipperCheckBox.Checked)
                {
                    dbNewRow["Bag_Tipper"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.BulkCheckBox.Checked)
                {
                    dbNewRow["Bulk_"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.bulk_HeadsCheckBox.Checked)
                {
                    dbNewRow["Bulk_Heads"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.warehouseCheckBox.Checked)
                {
                    dbNewRow["Warehouse"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.yardManagerCheckBox.Checked)
                {
                    dbNewRow["Yard_Manager"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee._700HysterCheckBox6.Checked)
                {
                    dbNewRow["_700_Hyster"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.emptyMachineCheckBox.Checked)
                {
                    dbNewRow["Empty_Machine"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.driverLicenseCheckBox.Checked)
                {
                    dbNewRow["Driver_License"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.firstAidCheckBox.Checked)
                {
                    My.MyProject.Forms.FrmAddNewEmployee.firstAidComboBox.Show();
                    dbNewRow["First_Aid"] = "yes";
                    dbNewRow["First_Aid_Level"] = My.MyProject.Forms.FrmAddNewEmployee.firstAidComboBox.SelectedItem;
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.railcarMoverCheckBox8.Checked)
                {
                    dbNewRow["Railcar_Mover"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.reachstacherCheckBox.Checked)
                {
                    dbNewRow["Reachstacker"] = "yes";
                }

                if (My.MyProject.Forms.FrmAddNewEmployee.otherCheckBox.Checked)
                {
                    dbNewRow["Other"] = My.MyProject.Forms.FrmAddNewEmployee.otherTextBox.Text;
                }

                dbDataTable.Rows.Add(dbNewRow);
            }

            dbAdapter.Update(dbDataTable);
        }

        public DataTable getNotifications(string conditions, string action)
        {
            if (conditions.Equals(""))
            {
                conditions = "where";
            }
            else
            {
                conditions += " and";
            }

            string query;
            if (action.Equals("New"))
            {
                query = "select * from notifications " + conditions + @" ID in
            (select ID from Notifications
            except
            select Notification_ID from Notifications_Read) ";
            }
            else
            {
                query = "select * from notifications " + conditions + @" ID in
            (select Notification_ID from Notifications_Read)";
            }

            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        // Public Function getBookings(ByVal customerName As String, ByVal bookingActive As String)

        // Dim query As String = "Select [Booking Number] from [dbo].[Bookings] where
        // [Active Booking] = " + bookingActive + " and Sources is not null and [Booking Number]<>'' and [Customer Name] = '" + customerName + "' order by [Booking Number]"

        // Dim dbDataTable As New DataTable
        // Dim dbAdapter = New SqlDataAdapter(query, StrConnection2)
        // Dim dbCommand = New SqlCommandBuilder(dbAdapter)

        // dbAdapter.Fill(dbDataTable)
        // Return dbDataTable
        // End Function

        public object getCustomers(string partialCustomer, bool firstLoad)
        {
            string query;
            if (firstLoad)
            {
                query = @"Select distinct([Customer Name]) from [dbo].[Container Bookings] where
            [Active Booking] = 1 and Sources is not null and [Booking Number]<>''";
            }
            else
            {
                query = @"SELECT
                     distinct([Customer Name]) from [dbo].[Container Bookings]
                    WHERE [Customer Name] LIKE '%" + partialCustomer + @"%' and
                    [Active Booking] = 1 and Sources is not null and [Booking Number]<>'' ";
            }

            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection2);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public object getGradesAndCommodities(string tableName, string condition)
        {
            string query = "Select * from [dbo].[" + tableName + @"]
                                where " + condition;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection2);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public void updateClearance(int userID, string tableName, string columnName, int value)
        {
            string query = " Select * from " + tableName + " where userID = " + userID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            // Select * from Models_Clearance where userID = 137

            if (dbDataTable.Rows.Count > 0)
            {
                dbDataTable.Rows[0][columnName] = value;
                dbAdapter.Update(dbDataTable);
            }
            else
            {
                var dbNewRow = dbDataTable.NewRow();
                dbNewRow[columnName] = value;
                addNewClearance(userID, tableName, columnName, value);
            }
        }

        public void addNewClearance(int userID, string tableName, string columnName, int value)
        {
            string query = "Insert into " + tableName + " (userID, " + columnName + ") values (" + userID.ToString() + ", " + value.ToString() + ")";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            dbAdapter.Update(dbDataTable);
        }

        public DataTable getClearance(int userID, string tableName)
        {
            string query = " Select * from " + tableName + " where userID = " + userID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public void saveNotification(int employeeID, string messageType, string messageTitle, string messageBody, string condition)
        {
            string query = " Select * from Notifications " + condition;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            var dbNewRow = dbDataTable.NewRow();

            // will only save the notification if it wasn't saved before
            if (dbDataTable.Rows.Count == 0)
            {
                dbNewRow["PunchID"] = 0;
                dbNewRow["UserID"] = employeeID;
                dbNewRow["Message_Type"] = messageType;
                dbNewRow["Message_Title"] = messageTitle;
                dbNewRow["Message_Body"] = messageBody;
                dbNewRow["DateTime"] = DateTime.Now;
                dbNewRow["Action_Taken"] = "None";
                dbNewRow["Critical"] = 0;
                dbDataTable.Rows.Add(dbNewRow);
                dbAdapter.Update(dbDataTable);

                // sendEmailNotification("vaniapsk@gmail.com", messageTitle, messageBody)
            }
        }

        public void saveActionTaken(int userID, int notificationID, string actionTaken, string comments)
        {
            string query2 = " Select * from Notifications_Read where ID = " + notificationID.ToString();
            var dbDataTable2 = new DataTable();
            var dbAdapter2 = new SqlDataAdapter(query2, StrConnection);
            var dbCommand2 = new SqlCommandBuilder(dbAdapter2);
            dbAdapter2.Fill(dbDataTable2);
            var dbNewRow = dbDataTable2.NewRow();
            dbNewRow["Notification_ID"] = notificationID;
            dbNewRow["Action_Taken"] = actionTaken;
            dbNewRow["Read_By"] = userID;
            dbNewRow["Comments"] = comments;
            dbNewRow["Action_Date_Time"] = DateTime.Now;
            dbDataTable2.Rows.Add(dbNewRow);
            dbAdapter2.Update(dbDataTable2);
            string query = "Select * from Notifications where ID = " + notificationID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            dbDataTable.Rows[0]["Action_Taken"] = actionTaken;
            dbAdapter.Update(dbDataTable);
        }

        public void updateNotesActionTaken(int notificationID, string comments)
        {
            string query = "Select * from Notifications_Read where Notification_ID = " + notificationID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            dbDataTable.Rows[0]["Comments"] = comments;
            dbAdapter.Update(dbDataTable);
        }

        public object updatePersonalInfo(int notificationID, string columnName, string updatedInfo)
        {
            string query = @"select N.userID, first_name, last_Name, alias, e.Address from Notifications N join Employees E
  on E.ID = UserID and N.ID = " + notificationID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            string message = "";
            dbAdapter.Fill(dbDataTable);
            int employeeID = Conversions.ToInteger(dbDataTable.Rows[0]["userID"]);
            string employeeName = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(dbDataTable.Rows[0]["first_Name"], " "), dbDataTable.Rows[0]["last_Name"]), " ("), dbDataTable.Rows[0]["alias"]), ")"));
            string query2 = "select ID, " + columnName + " from employees where ID = " + employeeID.ToString();
            var dbDataTable2 = new DataTable();
            var dbAdapter2 = new SqlDataAdapter(query2, StrConnection);
            var dbCommand2 = new SqlCommandBuilder(dbAdapter2);
            dbAdapter2.Fill(dbDataTable2);
            dbDataTable2.Rows[0][columnName] = updatedInfo;
            dbAdapter2.Update(dbDataTable2);
            message = "The adress for " + employeeName + " was updated to " + updatedInfo + " successfully.";

            // message = "Thre was a problem saving that address. Please go to employee management and save the information there."

            return message;
        }

        public object getReport(int employeeID, int selectedItem, string checkedWork, string condition)
        {
            string query = "";
            if (selectedItem == 1)
            {
                query = @"select EMPLOYEES.id, format(Start_Time_Date, 'yyyy-MM-dd HH:mm') as startTime , format(End_Time_Date, 'yyyy-MM-dd HH:mm') as endTime, alias, last_name, '', '',
'Salary', employees.ID from employees, Time_Sheet t
where Employees.id = t.UserID and UserID= " + employeeID.ToString() + @"
and cast(Start_Time_Date as date) >= '" + Conversions.ToString(My.MyProject.Forms.FrmTimeReport.fromDateTimePicker1.Value.Date) + @"' and
cast(Start_Time_Date as date) <= '" + Conversions.ToString(My.MyProject.Forms.FrmTimeReport.toDateTimePicker2.Value.Date) + "'" + condition;
            }
            else if (selectedItem == 2)
            {
                query = @"select format(Start_Time_Date, 'yyyy-MM-dd HH:mm') as startTime , format(End_Time_Date, 'yyyy-MM-dd HH:mm') as endTime, EMPLOYEES.id, alias, last_name, w.Forklift_Operator, w.Reach_Stacker,
 Punch_Type from employees, Work_Done w, Time_Sheet t
where w.Punch_ID = t.id and Employees.id = t.UserID and (" + checkedWork + @")
and cast(Start_Time_Date as date) >= '" + Conversions.ToString(My.MyProject.Forms.FrmTimeReport.fromDateTimePicker1.Value.Date) + @"' and
cast(Start_Time_Date as date) <= '" + Conversions.ToString(My.MyProject.Forms.FrmTimeReport.toDateTimePicker2.Value.Date) + "' and End_Time_Date is not null" + condition;
            }
            else if (selectedItem == 3)
            {
                query = @"select distinct(format(Start_Time_Date, 'yyyy-MM-dd')) as startTime from Time_Sheet t, employees , work_done w
where w.Punch_ID = t.id and Employees.id = t.UserID and (" + checkedWork + @")
and cast(Start_Time_Date as date) >= '" + Conversions.ToString(My.MyProject.Forms.FrmTimeReport.fromDateTimePicker1.Value.Date) + @"' and
cast(Start_Time_Date as date) <= '" + Conversions.ToString(My.MyProject.Forms.FrmTimeReport.toDateTimePicker2.Value.Date) + "' and End_Time_Date is not null" + condition;
            }

            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public object employeeWorked(int employeeID, DateTime dateSelected)
        {
            string query = "";
            query = @"select format(Start_Time_Date, 'yyyy-MM-dd HH:mm') as startTime , format(End_Time_Date, 'yyyy-MM-dd HH:mm') as endTime, alias, last_name
from employees, Time_Sheet t
where Employees.id = t.UserID and UserID= " + employeeID.ToString() + @"
and cast(Start_Time_Date as date) = '" + Conversions.ToString(dateSelected.Date) + "'";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        // -------------------------------------------  CONECT TO WTC-CERES ---------------------------------------------
        public object getShippingLines()
        {
            string query = "Select SLCODE, NAME from [Steamship Line] order by Name";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection2);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public DataTable getTableInfoCeres(string tableName, string columns, string conditions)
        {
            string query = "Select " + columns + " from " + tableName + " " + conditions;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection2);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable;
        }

        public bool isOnDatabase(string tableName, string condition)
        {
            string query = "Select [Container Number] from " + tableName + " " + condition;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection2);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            return dbDataTable.Rows.Count > 0;
        }

        public void saveBlockedContainers(string containerNumber, string lineCode, string lineName, DateTime blockedDate, DateTime blockedTillDate)
        {
            string query = "Select * from [Blocked Containers] ";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection2);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            var dbNewRow = dbDataTable.NewRow();
            dbNewRow["Container Number"] = containerNumber;
            dbNewRow["SS Line Code"] = lineCode;
            dbNewRow["SS Line Name"] = lineName;
            dbNewRow["Blocked Date"] = blockedDate;
            dbNewRow["Block End Date"] = blockedTillDate;
            dbDataTable.Rows.Add(dbNewRow);
            dbAdapter.Update(dbDataTable);
        }

        public void saveAlowedTransfer(int createdBy, string containerNumber, string truckerCode, string size, string status, string weight, string fromYard, string toYard, DateTime due, string typeOfTransfer, DateTime transDate)
        {
            string query = "Select * from [Allowed Transfers] ";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection2);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
            var dbNewRow = dbDataTable.NewRow();
            dbNewRow["Created By"] = My.MyProject.Forms.FrmLoginWindow._userID;
            dbNewRow["Trucker Code"] = truckerCode;
            dbNewRow["Container Number"] = containerNumber;
            dbNewRow["Size"] = size;
            dbNewRow["Status"] = status;
            dbNewRow["Weight"] = weight;
            dbNewRow["From"] = fromYard;
            dbNewRow["To"] = toYard;
            dbNewRow["Date of Creation"] = transDate;
            dbNewRow["Due"] = due;
            dbNewRow["Type of Transfer"] = typeOfTransfer;
            dbDataTable.Rows.Add(dbNewRow);
            dbAdapter.Update(dbDataTable);
        }

        public void deleteRows(string tableName, string condition)
        {
            string query = "delete from " + tableName + " " + condition;
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(dbDataTable);
        }

        public object punchtime(string punchType)
        {
            bool punchAccepted = false;
            string query = " Select * From Time_Sheet Where UserID =" + My.MyProject.Forms.FrmLoginWindow._userID.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            int index = 0;
            string shiftType = "";
            dbAdapter.Fill(dbDataTable);
            DateTime d1;
            if (punchType.Equals("clockin"))
            {
                DataRow dbNewRow = dbDataTable.NewRow();
                dbNewRow["UserID"] = My.MyProject.Forms.FrmLoginWindow._userID;
                dbNewRow["Start_Time_Date"] = DateAndTime.Now;
                if (My.MyProject.Forms.FrmLoginWindow.payMethod.Equals("Salary"))
                {
                    shiftType = "S";
                }
                else if (My.MyProject.Forms.FrmLoginWindow.payMethod.Equals("Hourly"))
                {
                    shiftType = "H";
                }
                else
                {
                    shiftType = "H";
                }

                dbNewRow["Punch_Type"] = shiftType;
                dbNewRow["Device_Name"] = My.MyProject.Computer.Name;
                dbNewRow["Site_Location"] = "Remote";
                string strHostName;
                strHostName = System.Net.Dns.GetHostName();
                dbNewRow["Device_IP_Address"] = System.Net.Dns.GetHostByName(strHostName).AddressList[0].ToString();
                dbDataTable.Rows.Add(dbNewRow);
                dbAdapter.Update(dbDataTable);
                punchAccepted = true;
            }
            else if (punchType.Equals("clockout"))
            {
                foreach (DataRow ListRow in dbDataTable.Rows)
                {
                    d1 = Convert.ToDateTime(ListRow["Start_Time_Date"]);
                    if (ListRow["End_Time_Date"] == DBNull.Value)
                    {
                        // ListRow["End_Time_Date") = punchDateTime

                        dbDataTable.Rows[index]["End_Time_Date"] = DateAndTime.Now;
                        dbAdapter.Update(dbDataTable);
                        punchAccepted = true;
                    }

                    index += 1;
                }
            }

            return punchAccepted;
        }

        public DateTime startTime;

        public bool needToclockedOutLastShift()
        {
            string query = "Select * From  Time_Sheet where userID = " + My.MyProject.Forms.FrmLoginWindow._userID.ToString() + " order by Start_Time_Date";
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            bool userNeedClockedOut = false;
            dbAdapter.Fill(dbDataTable);
            foreach (DataRow ListRow in dbDataTable.Rows)
            {
                if (Information.IsDBNull(ListRow["End_Time_Date"]))
                {
                    startTime = Conversions.ToDate(ListRow["Start_Time_Date"]);
                    userNeedClockedOut = true;
                    My.MyProject.Forms.FrmParentScreen._punchID = Conversions.ToInteger(ListRow["ID"]);
                    break;
                }
                else
                {
                    userNeedClockedOut = false;
                }
            }

            return userNeedClockedOut;
        }

        public void createUpdateIPSession(int sessionID, bool logIn)
        {
            var dateTimeSession = DateAndTime.Now;
            int id = 0;
            if (logIn)
            {
                id = 0;
            }
            else
            {
                id = sessionID;
            }

            string query = "Select * From  IP_Addess_Sessions where ID = " + id.ToString();
            var dbDataTable = new DataTable();
            var dbAdapter = new SqlDataAdapter(query, StrConnection);
            var dbCommand = new SqlCommandBuilder(dbAdapter);
            bool userNeedClockedOut = false;
            dbAdapter.Fill(dbDataTable);
            if (dbDataTable.Rows.Count > 0)
            {
                var row = dbDataTable.Rows[0];
                row["Logged_In"] = logIn;
            }
            else
            {
                var newRow = dbDataTable.NewRow();
                newRow["UserID"] = My.MyProject.Forms.FrmLoginWindow._userID;
                newRow["Punch_ID"] = My.MyProject.Forms.FrmParentScreen._punchID;
                string strHostName;
                strHostName = System.Net.Dns.GetHostName();
                newRow["IP_Address"] = System.Net.Dns.GetHostByName(strHostName).AddressList[0].ToString();
            }
        }
    }
}