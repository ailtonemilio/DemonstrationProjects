using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using YardTabletControls;

namespace ShipSmpl
{
    static class MdlOptionsManagement
    {
        private static DatabaseHelper db = new DatabaseHelper();

        public static void fillUpEmployeesStats()
        {
            string value = DateTime.Now.Date.AddMonths(-3).ToString("yyyy-MM-dd");
            string numberProbation = db.getAllActiveEmployees("and Start_Date >= '" + DateAndTime.Now.AddMonths(-3).ToShortDateString() + "'").Rows.Count.ToString();
            string numberBirthdays = db.getAllActiveEmployees(@"and DATEPART( Week, DATEADD( Year, DATEPART( Year, GETDATE()) - DATEPART( Year, birth_Date), birth_Date))
      = DATEPART( Week, GETDATE())").Rows.Count.ToString();
            My.MyProject.Forms.FrmHomePage.totalNumbEmployeesLabel.Text = db.getTotalemployees().ToString();
            My.MyProject.Forms.FrmHomePage.activeEmpNumbLabel.Text = "Active" + Environment.NewLine + db.getTotalActiveEmployees().ToString();
            My.MyProject.Forms.FrmHomePage.InactiveEmpNumberLabel.Text = "Inactive" + Environment.NewLine + (db.getTotalemployees() - db.getTotalActiveEmployees()).ToString();
            My.MyProject.Forms.FrmHomePage.probationPeriodNumberLabel.Text = numberProbation;
            My.MyProject.Forms.FrmHomePage.BirthdayCountLabel.Text = numberBirthdays;
            My.MyProject.Forms.FrmHomePage.BirthdayCountLabel.Update();
            My.MyProject.Forms.FrmHomePage.probationPeriodNumberLabel.Update();
        }

        private static TreeView clearanceTreeView = My.MyProject.Forms.FrmClearance.TreeView1;
        private static int userID = My.MyProject.Forms.FrmLoginWindow._userID;

        public static object notificationIsShown { get; set; } = true;

        private static SlideMenu sl;
        private static NotificationCenter NotificationCenter1 = My.MyProject.Forms.FrmHomePage.NotificationCenter1;

        public static void getClearedModels(FrmParentScreen parentForm)
        {
            sl = parentForm.SlideMenu1;
            My.MyProject.Forms.FrmEmployeeManagementHP.firstLoad = false;
            userID = My.MyProject.Forms.FrmLoginWindow._userID;
            {
                SlideMenu withBlock = (SlideMenu)sl;
                foreach (DataRow model in db.getClearance(userID, "Main_Menu_Clearance").Rows)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Home_Page"], true, false)))
                    {
                        withBlock.AddMainMenuOption("Home", "Home", parentForm.MainMenuIconsImageList.Images[0]);
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Bookings"], true, false)))
                    {
                        withBlock.AddMainMenuOption("Bookings", "Bookings", parentForm.MainMenuIconsImageList.Images[6]);
                        SetBookingModels();
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Containers"], true, false)))
                    {
                        withBlock.AddMainMenuOption("Containers", "Containers", parentForm.MainMenuIconsImageList.Images[1]);
                        setContainersAllowedModels();
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Contacts"], true, false)))
                    {
                        withBlock.AddMainMenuOption("Contacts", "Contacts", parentForm.MainMenuIconsImageList.Images[3]);
                        setContactsAllowedModels();
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Human_Resources"], true, false)))
                    {
                        withBlock.AddMainMenuOption("Human Resources", "HR", parentForm.MainMenuIconsImageList.Images[4]);
                        setHRAllowedModels();
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Inbound_Cargo"], true, false)))
                    {
                        withBlock.AddMainMenuOption("Inbound Cargo", "Inbound Cargo", parentForm.MainMenuIconsImageList.Images[5]);
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Truck_Dispatch"], true, false)))
                    {
                        withBlock.AddMainMenuOption("Truck Dispatch", "Dispatch", parentForm.MainMenuIconsImageList.Images[8]);
                        setDispatchAllowedModels();
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Billing"], true, false)))
                    {
                        withBlock.AddMainMenuOption("Billing", "Billing", parentForm.MainMenuIconsImageList.Images[7]);
                        setBillingModels();
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Miscellaneous"], true, false)))
                    {
                        withBlock.AddMainMenuOption("Miscellaneous", "Miscellaneous", parentForm.MainMenuIconsImageList.Images[9]);
                        setMiscellaneousAllowedModels();
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Inventory_Management"], true, false)))
                    {
                        withBlock.AddMainMenuOption("Inventory Management", "Inventory Management", parentForm.MainMenuIconsImageList.Images[11]);
                        SetInventoryMngAllowedModules();
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Time_Tracker"], true, false)))
                    {
                        withBlock.AddMainMenuOption("Clock In/Out", "Clock In/Out", parentForm.MainMenuIconsImageList.Images[10]);
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Notifications"], false, false)))
                    {
                        NotificationCenter1.Hide();
                        canSeeNotificationas = false;
                    }
                    else
                    {
                        My.MyProject.Forms.FrmHomePage.actionComboBox1.SelectedIndex = 0;
                        My.MyProject.Forms.FrmHomePage.typeComboBox.SelectedIndex = 0;
                        getNotifications(Conversions.ToString(My.MyProject.Forms.FrmHomePage.actionComboBox1.SelectedItem), Conversions.ToString(My.MyProject.Forms.FrmHomePage.typeComboBox.SelectedItem), My.MyProject.Forms.FrmHomePage);
                        firstLoad = false;
                        canSeeNotificationas = true;
                    }
                }

                withBlock.PublishSlideMenu();
            }
        }

        private static void SetInventoryMngAllowedModules()
        {
            userID = My.MyProject.Forms.FrmLoginWindow._userID;
            {
                SlideMenu withBlock = sl;
                foreach (DataRow model in (IEnumerable)db.getClearance(userID, "Inventory_Management_Clearance").Rows)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Empty_Bag_Inventory"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Inventory Management", "Empty Bag Inventory", "Epty Bag Inventory");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Grain_Inventory"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Inventory Management", "Grain Inventory", "Grain Inventory");
                    }
                }
            }
        }

        private static void SetBookingModels()
        {
            userID = My.MyProject.Forms.FrmLoginWindow._userID;
            {
                SlideMenu withBlock = sl;
                foreach (DataRow model in (IEnumerable)db.getClearance(userID, "BookingClearance").Rows)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["BookingReport"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Bookings", "Bookings Report", "Bookings Report");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["VesselList"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Bookings", "Vessel", "Vessel");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["VesselVoyageList"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Bookings", "Vessel Voyage", "Vessel Voyage");
                    }
                }
            }
        }

        public static void setMiscellaneousAllowedModels()
        {
            userID = My.MyProject.Forms.FrmLoginWindow._userID;
            {
                SlideMenu withBlock = sl;
                foreach (DataRow model in (IEnumerable)db.getClearance(userID, "Miscellaneous_Clearance").Rows)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Logs"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Miscellaneous", "Logs", "Logs");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Truck_Drivers"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Miscellaneous", "Truck Drivers", "TruckDrivers");
                    }
                }
            }
        }

        public static void setBillingModels()
        {
            userID = My.MyProject.Forms.FrmLoginWindow._userID;
            {
                SlideMenu withBlock = sl;
                foreach (DataRow model in (IEnumerable)db.getClearance(userID, "Billing_Clearance").Rows)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Trucking_Reconciliation"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Billing", "Trucking Reconciliation", "Trucking Reconciliation");
                    }
                }
            }
        }

        public static void setDispatchAllowedModels()
        {
            {
                SlideMenu withBlock = sl;
                foreach (DataRow model in (IEnumerable)db.getClearance(userID, "Truck_Dispatch_Clearance").Rows)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Inbound"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Dispatch", "Inbound", "Inbound");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Outbound"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Dispatch", "Outbound", "Outbound");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Requests"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Dispatch", "Requests", "Requests");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Carrier_Assignment"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Dispatch", "Carrier Assignment", "Carrier Assignment");
                    }
                }
            }
        }

        public static void setContainersAllowedModels()
        {
            userID = My.MyProject.Forms.FrmLoginWindow._userID;
            {
                SlideMenu withBlock = sl;
                foreach (DataRow model in (IEnumerable)db.getClearance(userID, "Containers_Clearance").Rows)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["MAnage_Container"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Containers", "Container Management", "Container Management");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Assign_Container"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Containers", "Assign Container", "Assign Container");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Block_Container"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Containers", "Blocked Containers", "Block Container");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["CFIA_Labels"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Containers", "Labels", "CFIA Labels");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["EDI"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Containers", "EDI", "EDI");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["EDI_Performance_Audit"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Containers", "EDI Performance Audit", "EDI Performance Audit");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["In/Out_Gate"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Containers", "In/Out Gate", "In/Out Gate");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Transfer_Container"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Containers", "Transfer Container", "Transfer Container");
                    }
                }
            }
        }

        public static bool canSeeNotificationas;
        public static bool canSeeMessages;

        public static void setHRAllowedModels()
        {
            userID = My.MyProject.Forms.FrmLoginWindow._userID;
            {
                SlideMenu withBlock = sl;
                foreach (DataRow model in (IEnumerable)db.getClearance(userID, "Human_Resources_Clearance").Rows)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Employee_Management"], true, false)))
                    {
                        withBlock.AddSubMenuOption("HR", "Employee Management", "Employee Management");
                        getEmployeeManagementAllowedFunctionalities();
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Time_Management_and_Reports"], true, false)))
                    {
                        getTimeManagAndReportsAllowedodels();
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Shift_Management"], true, false)))
                    {
                        withBlock.AddSubMenuOption("HR", "Shift Management", "Shift Management");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Safety_and_Risk_Management"], true, false)))
                    {
                        withBlock.AddSubMenuOption("HR", "Safety/Risk Management", "Safety/Risk Management");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Message_Employee"], false, false)))
                    {
                        My.MyProject.Forms.FrmHomePage.messageEmployeeeTableLayoutPanel.Hide();
                        canSeeMessages = false;
                    }
                    else
                    {
                        canSeeMessages = true;
                    }
                }
            }
        }

        public static void getEmployeeManagementAllowedFunctionalities()
        {
            foreach (DataRow model in (IEnumerable)db.getClearance(userID, "Employee_Management_Clearance").Rows)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Add_Employee"], false, false)))
                {
                    My.MyProject.Forms.FrmEmployeeManagement.addEntryButton.Hide();
                    // FrmAddNewEmployee.EmployeeOptionsTabControl.TabPages.Remove(FrmAddNewEmployee.addEmployeeTab)
                    // populateEmployeeList(FrmEmployeeManagement.BunifuDataGridView1, FrmEmployeeManagement.employeeStatus)
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Suspend_Employee"], false, false)))
                {
                    My.MyProject.Forms.FrmEmployeeManagement.terminateButton.Hide();
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Set_Clearance"], false, false)))
                {
                    My.MyProject.Forms.FrmEmployeeManagement.clearanceButton.Hide();
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Delete_Employee"], false, false)))
                {
                    My.MyProject.Forms.FrmEmployeeManagement.deleteButton.Hide();
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Modify_Employee"], false, false)))
                {
                    My.MyProject.Forms.FrmEmployeeManagement.modifyButton.Hide();
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Create_Login"], false, false)))
                {
                    My.MyProject.Forms.FrmEmployeeManagement.createUsernameButton.Hide();
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Assign_CardID"], false, false)))
                {
                    My.MyProject.Forms.FrmEmployeeManagement.cardIDButton.Hide();
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["See_Employee_Details"], false, false)))
                {
                    allowedToSeeDetails = false;
                }
                else
                {
                    allowedToSeeDetails = true;
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["See_sensitive_information"], false, false)))
                {
                    allowedToSensitiveInformation = false;
                }
                else
                {
                    allowedToSensitiveInformation = true;
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Print_Card"], false, false)))
                {
                    My.MyProject.Forms.FrmEmployeeManagement.printCardButton.Visible = false;
                }
            }
        }

        public static void getTimeManagAndReportsAllowedodels()
        {
            foreach (DataRow model in (IEnumerable)db.getClearance(userID, "Time_Management_and_Reports_Clearance").Rows)
            {
                {
                    SlideMenu withBlock = sl;
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Time_Management"], true, false)))
                    {
                        withBlock.AddSubMenuOption("HR", "Time Management", "Time Management");
                        getTimeManagementAllowedFunctionalities();
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Time_Reports"], true, false)))
                    {
                    }
                }
            }
        }

        public static bool canSeeEntryDetail = true;
        public static bool allowedToSensitiveInformation = true;

        public static void getTimeManagementAllowedFunctionalities()
        {
            foreach (DataRow model in (IEnumerable)db.getClearance(userID, "Time_Management_Clearance").Rows)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Add_New_Entry"], false, false)))
                {
                    My.MyProject.Forms.FrmTimeSheet.addEntryButton.Visible = false;
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["See_Entry_Details"], false, false)))
                {
                    canSeeEntryDetail = false;
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Edit_Entry"], false, false)))
                {
                    My.MyProject.Forms.FrmTimeSheet.editEntryButton.Visible = false;
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Delete_Entry"], false, false)))
                {
                    My.MyProject.Forms.FrmTimeSheet.deleteEntryButton.Visible = false;
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Print_TimeSheet"], false, false)))
                {
                    My.MyProject.Forms.FrmTimeSheet.printButton.Visible = false;
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Export_TimeSheet"], false, false)))
                {
                    My.MyProject.Forms.FrmTimeSheet.exportCSVButton.Visible = false;
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Add_Holidays"], false, false)))
                {
                    My.MyProject.Forms.FrmTimeSheet.holidaysButton.Visible = false;
                }
            }
        }

        public static void getCFIALabelFunctionalities(Form focusedForm)
        {
            foreach (DataRow model in (IEnumerable)db.getClearance(userID, "CFIA_Labels_Clearance").Rows)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Edit_Sample_Type"], false, false)))
                {
                    My.MyProject.Forms.FrmCFIALabel.sampletitlecombobox.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                // If model["Edit_Customer") = False Then
                // FrmCFIALabel.customerComboBox.DropDownStyle = ComboBoxStyle.DropDownList

                // End If
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Edit_Booking"], false, false)))
                {
                    My.MyProject.Forms.FrmCFIALabel.cboBooking.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Edit_Unit"], true, false)))
                {
                    My.MyProject.Forms.FrmCFIALabel.BunifuToggleSwitch1.Visible = true;
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Print_Label"], false, false)))
                {
                    My.MyProject.Forms.FrmCFIALabel.printButton.Visible = false;
                }
            }
        }

        public static void setContactsAllowedModels()
        {
            foreach (DataRow model in (IEnumerable)db.getClearance(userID, "Contacts_Clearance").Rows)
            {
                {
                    SlideMenu withBlock = sl;
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Companies"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Contacts", "Companies", "Companies");
                    }

                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(model["Pre_Scripts"], true, false)))
                    {
                        withBlock.AddSubMenuOption("Contacts", "Pre Scripts", "Pre Scripts");
                    }
                }
            }
        }

        public static object allowedToSeeDetails { get; set; } = true;

        private static List<int> messagesOnDisplay = new List<int>();
        private static bool firstLoad = true;

        public static void getNotifications(string selectedAction, string selectedMessageType, FrmHomePage selectedForm)
        {
            string condition = "where Action_Taken = ";
            if (selectedAction.Equals("Approved"))
            {
                condition += "'Approved'";
            }
            else if (selectedAction.Equals("Declined"))
            {
                condition += "'Declined'";
            }
            else if (selectedAction.Equals("Dismissed"))
            {
                condition += "'Dismissed'";
            }
            else if (selectedAction.Equals("Solved"))
            {
                condition += "'Solved'";
            }
            else if (selectedAction.Equals("New"))
            {
                condition += "'None'";
            }

            if (!condition.Equals(""))
            {
                if (!selectedMessageType.Equals("All"))
                {
                    condition += " and Message_Type = ";
                }
            }
            else
            {
                condition += "where Message_Type = ";
            }

            if (selectedMessageType.Equals("Requests"))
            {
                condition += "'Request'";
            }
            else if (selectedMessageType.Equals("Reminders"))
            {
                condition += "'Reminder'";
            }
            else if (selectedMessageType.Equals("Warnings"))
            {
                condition += "'Warning' ";
            }

            // FrmOptionsManagement.NotificationCenter1.AddNotification(2, Chr(100) + Chr(1), Now,
            // "Send Message", "Second Message blabla blabla", Chr(2) + Chr(3), Color.CadetBlue)
            string word;
            if (selectedForm.isNewNotification == false)
            {
                selectedForm.NotificationCenter1.NotificationAlert = false;
                selectedForm.NotificationCenter1.ClearAllNotification();
            }

            string buttonsfailedPunchCNA = "";
            string buttonsfailedPunch = "";
            string buttonsProbRem1Month = "";
            string buttonsProbationRemDue = "";
            string buttonsStatHoliday = "";
            string buttonsRequestsGeneral = "";
            string buttonsActionTaken = Conversions.ToString('\a') + Conversions.ToString('\u0003');
            string buttonsAddressChange = "";
            if (selectedAction.Equals("New"))
            {
                buttonsfailedPunchCNA = Conversions.ToString('\u0005');
                buttonsfailedPunch = Conversions.ToString('\u0004');
                buttonsProbRem1Month = Conversions.ToString('\u0005');
                buttonsProbationRemDue = Conversions.ToString('\u0006') + Conversions.ToString('\u0005');
                buttonsStatHoliday = Conversions.ToString('\u0004');
                buttonsRequestsGeneral = Conversions.ToString('\u0001') + Conversions.ToString('\u0002') + Conversions.ToString('\u0006');
                buttonsAddressChange = Conversions.ToString('\t') + Conversions.ToString('\u0002') + Conversions.ToString('\u0006');
            }
            else
            {
                buttonsfailedPunchCNA = Conversions.ToString('\a') + Conversions.ToString('\u0003');
                buttonsfailedPunch = Conversions.ToString('\a') + Conversions.ToString('\u0003');
                buttonsProbRem1Month = Conversions.ToString('\a') + Conversions.ToString('\u0003');
                buttonsProbationRemDue = Conversions.ToString('\a') + Conversions.ToString('\u0003');
                buttonsStatHoliday = Conversions.ToString('\a') + Conversions.ToString('\u0003');
                buttonsRequestsGeneral = Conversions.ToString('\a') + Conversions.ToString('\u0003');
                buttonsAddressChange = Conversions.ToString('\a') + Conversions.ToString('\u0003');
            }

            foreach (DataRow notification in db.getNotifications(condition, selectedAction).Rows)
            {
                word = Conversions.ToString(notification["Message_Title"].ToString().Split('-')[0]);
                word = Strings.Trim(word);
                if (!messagesOnDisplay.Contains(Conversions.ToInteger(notification["ID"])) & firstLoad == false)
                {
                    // FrmOptionsManagement.NotificationCenter1.ClearAllNotification()
                    selectedForm.NotificationCenter1.NotificationAlert = true;
                }
                else
                {
                    selectedForm.NotificationCenter1.NotificationAlert = false;
                }

                if (selectedForm.isNewNotification == false)
                {
                    selectedForm.NotificationCenter1.NotificationAlert = false;
                }

                userID = 124;
                foreach (DataRow item in (IEnumerable)db.getClearance(userID, "Employee_Management_Notifications_Clearance").Rows)
                {
                    if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(item["Failed_Punch_Attempt_Warning"], true, false), word.Equals("FAILED PUNCH ATTEMPT").ToString().ToUpper())))
                    {
                        if (notification["Message_Title"].ToString().ToUpper().Equals("Failed Punch Attempt - Card not assigned".ToString().ToUpper())) // if failed punch is a not recognized card then show dissmiss button
                        {
                            selectedForm.NotificationCenter1.AddNotification(Conversions.ToInteger(notification["ID"]), Conversions.ToString('d') + Conversions.ToString('\u0003'), Conversions.ToDate(notification["DateTime"]), Conversions.ToString(notification["Message_Title"]), Conversions.ToString(notification["Message_Body"]), buttonsfailedPunchCNA, Color.IndianRed);
                        }
                        else
                        {
                            selectedForm.NotificationCenter1.AddNotification(Conversions.ToInteger(notification["ID"]), Conversions.ToString('d') + Conversions.ToString('\u0003'), Conversions.ToDate(notification["DateTime"]), Conversions.ToString(notification["Message_Title"]), Conversions.ToString(notification["Message_Body"]), buttonsfailedPunch, Color.FromArgb(192, 64, 0));
                        }
                    }
                    else if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(item["Probation_Due_Reminder"], true, false), word.Equals("1 MONTH PROBATION LEFT"))))
                    {
                        selectedForm.NotificationCenter1.AddNotification(Conversions.ToInteger(notification["ID"]), Conversions.ToString('d') + Conversions.ToString('\u0003'), Conversions.ToDate(notification["DateTime"]), Conversions.ToString(notification["Message_Title"]), Conversions.ToString(notification["Message_Body"]), buttonsProbRem1Month, Color.Peru);
                    }
                    else if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(item["Probation_Due_Reminder"], true, false), word.Equals("PROBATION PERIOD DUE"))))
                    {
                        selectedForm.NotificationCenter1.AddNotification(Conversions.ToInteger(notification["ID"]), Conversions.ToString('d') + Conversions.ToString('\u0003'), Conversions.ToDate(notification["DateTime"]), Conversions.ToString(notification["Message_Title"]), Conversions.ToString(notification["Message_Body"]), buttonsProbationRemDue, Color.Sienna);
                    }
                    else if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(item["Statutory_Holiday_Reminder"], true, false), word.Equals("ADD STATUTORY HOLIDAY PUNCH"))))
                    {
                        selectedForm.NotificationCenter1.AddNotification(Conversions.ToInteger(notification["ID"]), Conversions.ToString('d') + Conversions.ToString('\u0003'), Conversions.ToDate(notification["DateTime"]), Conversions.ToString(notification["Message_Title"]), Conversions.ToString(notification["Message_Body"]), buttonsStatHoliday, Color.CadetBlue);
                    }
                    else if (Conversions.ToBoolean(Operators.AndObject(notification["Message_Type"].Equals("Request"), Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.ConditionalCompareObjectEqual(item["Benefit_Claim_Request"], true, false), Operators.ConditionalCompareObjectEqual(item["Job_Letter_Request"], true, false)), Operators.ConditionalCompareObjectEqual(item["Time_Off_Request"], true, false)), Operators.ConditionalCompareObjectEqual(item["Vacation_Pay_Request"], true, false)))))
                    {
                        if (word.Equals("ADDRESS CHANGE REQUEST"))
                        {
                            selectedForm.NotificationCenter1.AddNotification(Conversions.ToInteger(notification["ID"]), Conversions.ToString('d') + Conversions.ToString('\u0003'), Conversions.ToDate(notification["DateTime"]), Conversions.ToString(notification["Message_Title"]), Conversions.ToString(notification["Message_Body"]), buttonsAddressChange, Color.Tomato);
                        }
                        else
                        {
                            selectedForm.NotificationCenter1.AddNotification(Conversions.ToInteger(notification["ID"]), Conversions.ToString('d') + Conversions.ToString('\u0003'), Conversions.ToDate(notification["DateTime"]), Conversions.ToString(notification["Message_Title"]), Conversions.ToString(notification["Message_Body"]), buttonsRequestsGeneral, Color.Tomato);
                        }
                    }
                }

                if (!messagesOnDisplay.Contains(Conversions.ToInteger(notification["ID"])))
                {
                    messagesOnDisplay.Add(Conversions.ToInteger(notification["ID"]));
                }
            }

            firstLoad = false;
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(db.getNotifications(condition, selectedAction).Rows.Count, 0, false)))
            {
                selectedForm.NotificationCenter1.AddNotification(0, Conversions.ToString('d') + Conversions.ToString('\u0003'), DateTime.Now, "Nothing here", "", Conversions.ToString('\u0003'), Color.FromKnownColor(KnownColor.ButtonShadow));
            }

            // .NotifyButtonDefinitions(Chr(1), "Approve", Color.Green)
            // .NotifyButtonDefinitions(Chr(2), "Decline", Color.Firebrick)
            // .NotifyButtonDefinitions(Chr(3), "Cancel", Color.OrangeRed)
            // .NotifyButtonDefinitions(Chr(4), "Solved", Color.Teal)
            // .NotifyButtonDefinitions(Chr(5), "Dismiss", Color.Firebrick)
            // .NotifyButtonDefinitions(Chr(6), "Message", Color.DarkSlateGray)
            // .NotifyButtonDefinitions(Chr(8), "Confirm", Color.Green)
        }

        public static void checkProbationReminders()
        {
            DateTime starDate;
            DateTime twoMonthsDate;
            DateTime dueDate;
            string messageType = "Reminder";
            string messageTitle = "";
            string messageBody = "";
            string condition = "";
            foreach (DataRow employee in db.getAllActiveEmployees("and Start_Date >= '" + DateAndTime.Today.AddMonths(-3).ToString("yyyy/MM/dd") + "'").Rows)
            {
                starDate = Conversions.ToDate(employee["Start_Date"]);
                twoMonthsDate = starDate.AddMonths(2);
                dueDate = starDate.AddMonths(3);
                int daysRemaining = (dueDate.Date - DateTime.Now.Date).Days;

                // if the due date is a month away
                if (DateTime.Now.Date.AddMonths(-1) <= twoMonthsDate & daysRemaining <= DateTime.DaysInMonth(DateAndTime.Today.Year, DateAndTime.Today.Month))
                {

                    // if due date is coming
                    if (dueDate.Date > DateTime.Now.Date)
                    {
                        messageTitle = Conversions.ToString(Operators.AddObject("1 MONTH PROBATION LEFT  - ", employee["Alias"]));
                        if (DateTime.Now.Date.AddMonths(-1) == dueDate)
                        {
                            messageBody = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("The probation period for ", employee["Alias"]), " "), employee["Last_Name"]), " is due in one month ("), dueDate.Date.ToString("MMM dd, yyyy")), ")."));
                        }
                        else
                        {
                            messageBody = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("The probation period for ", employee["Alias"]), " "), employee["Last_Name"]), " is due on "), dueDate.Date.ToString("MMM dd, yyyy")), "."));
                        }

                        condition = "where Message_Body ='" + messageBody + "'";
                        db.saveNotification(Conversions.ToInteger(employee["ID"]), messageType, messageTitle, messageBody, condition);
                    }
                    else
                    {
                        messageTitle = Conversions.ToString(Operators.AddObject("PROBATION PERIOD DUE - ", employee["Alias"]));
                        // if it's due date
                        if (dueDate.Date == DateTime.Now.Date)
                        {
                            messageBody = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("The probation period for ", employee["Alias"]), " "), employee["Last_Name"]), " is due today ("), dueDate.Date.ToString("MMM dd, yyyy")), ")."));
                            condition = "where Message_Body ='" + messageBody + "'";
                        }
                        else // if due date has passed
                        {
                            messageBody = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("The probation period for ", employee["Alias"]), " "), employee["Last_Name"]), " was due on "), dueDate.Date.ToString("MMM dd, yyyy")), "."));
                            condition = "where Message_Body ='" + messageBody + "'";
                        }

                        db.saveNotification(Conversions.ToInteger(employee["ID"]), messageType, messageTitle, messageBody, condition);
                    }
                }
            }
        }

        public static void checkBlockedContainers()
        {
            var db = new DatabaseHelper();

            db.RemoveBlockedContainers();
        }

        public static void checkHolidayReminders()
        {
            DateTime holidayDate;
            string holidayName = "";
            string messageType = "Reminder";
            string messageTitle = "";
            string messageBody = "";
            string condition = "";
            foreach (DataRow holiday in (IEnumerable)db.getHolidays("where Holiday_Date < '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + @"' and
                                                Holiday_Date > '" + DateTime.Now.Date.AddMonths(-1).ToString("yyy-MM-dd") + "'").Rows)
            {
                holidayDate = Conversions.ToDate(holiday["Holiday_Date"]);
                holidayName = Conversions.ToString(holiday["Holiday_Name"]);
                if (DateTime.Now.Date >= holidayDate)
                {
                    messageTitle = "ADD STATUTORY HOLIDAY PUNCH";
                    messageBody = "Reminder to update employee`s Time sheet. Statutory holiday punch to be added: " + holidayName + " (" + holidayDate.Date.ToString("MMM dd, yyyy") + ")";
                    condition = "where Message_Body ='" + messageBody + "'";
                    db.saveNotification(Conversions.ToInteger(holiday["ID"]), messageType, messageTitle, messageBody, condition);
                }
            }
        }

        // Public Sub getNotifications()

        // End Sub
        public static void sendEmailNotification(string receiver, string sender, string messageTitle, string messageBody)
        {
            try
            {
                var Smtp_Server = new SmtpClient();
                var email = new MailMessage();
                Smtp_Server.UseDefaultCredentials = false;
                Smtp_Server.Credentials = new System.Net.NetworkCredential("WesternTransloadingIT@gmail.com", "W3$t3rnTr@n$");
                Smtp_Server.Port = 587;
                Smtp_Server.EnableSsl = true;
                Smtp_Server.Host = "smtp.gmail.com";
                email.From = new MailAddress(sender);
                email.To.Add(receiver);
                email.Subject = messageTitle;
                email.IsBodyHtml = false;
                email.Body = messageBody;
                Smtp_Server.Send(email);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        public static void getNotificationDetail(int actionID)
        {
            foreach (DataRow notification in (IEnumerable)db.getNotificationDetail(actionID).Rows)
            {
                DateTime actionDateTime = Conversions.ToDate(notification["Action_Date_Time"]);
                My.MyProject.Forms.FrmActionDetails.actionTakenLabel.Text = Conversions.ToString(notification["Action_Taken"]);
                My.MyProject.Forms.FrmActionDetails.byLabel.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(notification["Alias"], " "), notification["Last_Name"]));
                My.MyProject.Forms.FrmActionDetails.commentsRichTextBox.Text = Conversions.ToString(notification["Comments"]);
                My.MyProject.Forms.FrmActionDetails.dateLabel.Text = actionDateTime.ToString("MMM dd, yyyy hh:mm tt");
            }
        }
    }
}