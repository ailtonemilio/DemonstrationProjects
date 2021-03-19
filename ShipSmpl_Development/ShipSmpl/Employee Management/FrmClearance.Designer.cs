using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ShipSmpl
{
    [DesignerGenerated()]
    public partial class FrmClearance : Form
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
            var TreeNode1 = new TreeNode("Home Page");
            var TreeNode2 = new TreeNode("Bookings");
            var TreeNode3 = new TreeNode("Assign Container");
            var TreeNode4 = new TreeNode("Block Container");
            var TreeNode5 = new TreeNode("Edit Sample Type");
            var TreeNode6 = new TreeNode("Edit Customer");
            var TreeNode7 = new TreeNode("Edit Booking");
            var TreeNode8 = new TreeNode("Edit Unit");
            var TreeNode9 = new TreeNode("Edit Commodity");
            var TreeNode10 = new TreeNode("Print Label");
            var TreeNode11 = new TreeNode("CFIA Labels", new TreeNode[] { TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10 });
            var TreeNode12 = new TreeNode("EDI");
            var TreeNode13 = new TreeNode("In/Out Gate");
            var TreeNode14 = new TreeNode("Transfer Container");
            var TreeNode15 = new TreeNode("Manage Container");
            var TreeNode16 = new TreeNode("Containers", new TreeNode[] { TreeNode3, TreeNode4, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15 });
            var TreeNode17 = new TreeNode("Add New Entry");
            var TreeNode18 = new TreeNode("See Entry Details");
            var TreeNode19 = new TreeNode("Edit Entry");
            var TreeNode20 = new TreeNode("Delete Entry");
            var TreeNode21 = new TreeNode("Print TimeSheet");
            var TreeNode22 = new TreeNode("Export TimeSheet");
            var TreeNode23 = new TreeNode("Add Holidays");
            var TreeNode24 = new TreeNode("Time Management", new TreeNode[] { TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23 });
            var TreeNode25 = new TreeNode("Time Reports");
            var TreeNode26 = new TreeNode("Time Management and Reports", new TreeNode[] { TreeNode24, TreeNode25 });
            var TreeNode27 = new TreeNode("Add Employee");
            var TreeNode28 = new TreeNode("Assign CardID");
            var TreeNode29 = new TreeNode("Create Login");
            var TreeNode30 = new TreeNode("Delete Employee");
            var TreeNode31 = new TreeNode("See sensitive information");
            var TreeNode32 = new TreeNode("See Employee Details", new TreeNode[] { TreeNode31 });
            var TreeNode33 = new TreeNode("Suspend Employee");
            var TreeNode34 = new TreeNode("Modify Employee");
            var TreeNode35 = new TreeNode("Print Card");
            var TreeNode36 = new TreeNode("Set Clearance");
            var TreeNode37 = new TreeNode("Employee Management", new TreeNode[] { TreeNode27, TreeNode28, TreeNode29, TreeNode30, TreeNode32, TreeNode33, TreeNode34, TreeNode35, TreeNode36 });
            var TreeNode38 = new TreeNode("Shift Management");
            var TreeNode39 = new TreeNode("Worked Hours");
            var TreeNode40 = new TreeNode("Document Storage");
            var TreeNode41 = new TreeNode("Safety and Risk Management", new TreeNode[] { TreeNode39, TreeNode40 });
            var TreeNode42 = new TreeNode("Message Employee");
            var TreeNode43 = new TreeNode("Human Resources", new TreeNode[] { TreeNode26, TreeNode37, TreeNode38, TreeNode41, TreeNode42 });
            var TreeNode44 = new TreeNode("Probation Due Reminder");
            var TreeNode45 = new TreeNode("Statutory Holiday Reminder");
            var TreeNode46 = new TreeNode("Year Follow Up Reminder");
            var TreeNode47 = new TreeNode("Benefit Reminder");
            var TreeNode48 = new TreeNode("Email Reminder");
            var TreeNode49 = new TreeNode("Job Letter Request");
            var TreeNode50 = new TreeNode("Time Off Request");
            var TreeNode51 = new TreeNode("Vacation Pay Request");
            var TreeNode52 = new TreeNode("Benefit Claim Request");
            var TreeNode53 = new TreeNode("Failed Punch Attempt Warning");
            var TreeNode54 = new TreeNode("Employee Management Notifications", new TreeNode[] { TreeNode44, TreeNode45, TreeNode46, TreeNode47, TreeNode48, TreeNode49, TreeNode50, TreeNode51, TreeNode52, TreeNode53 });
            var TreeNode55 = new TreeNode("Document Expiration Reminder");
            var TreeNode56 = new TreeNode("Safety Committee Meeting Reminder");
            var TreeNode57 = new TreeNode("Safety Committee Inspection Reminder");
            var TreeNode58 = new TreeNode("Training Reminder");
            var TreeNode59 = new TreeNode("Email Reminder");
            var TreeNode60 = new TreeNode("Safety and Risk Notifications", new TreeNode[] { TreeNode55, TreeNode56, TreeNode57, TreeNode58, TreeNode59 });
            var TreeNode61 = new TreeNode("Notifications", new TreeNode[] { TreeNode54, TreeNode60 });
            var TreeNode62 = new TreeNode("Companies");
            var TreeNode63 = new TreeNode("Pre Scripts");
            var TreeNode64 = new TreeNode("Contacts", new TreeNode[] { TreeNode62, TreeNode63 });
            var TreeNode65 = new TreeNode("Inbound Cargo");
            var TreeNode66 = new TreeNode("Carrier Assignment");
            var TreeNode67 = new TreeNode("Requests");
            var TreeNode68 = new TreeNode("Inbound");
            var TreeNode69 = new TreeNode("Outbound");
            var TreeNode70 = new TreeNode("Truck Dispatch", new TreeNode[] { TreeNode66, TreeNode67, TreeNode68, TreeNode69 });
            var TreeNode71 = new TreeNode("Trucking Reconciliation");
            var TreeNode72 = new TreeNode("Billing", new TreeNode[] { TreeNode71 });
            var TreeNode73 = new TreeNode("Truck Drivers");
            var TreeNode74 = new TreeNode("Logs");
            var TreeNode75 = new TreeNode("Miscellaneous", new TreeNode[] { TreeNode73, TreeNode74 });
            var TreeNode76 = new TreeNode("Time Tracker");
            var TreeNode77 = new TreeNode("Empty Bag Inventory");
            var TreeNode78 = new TreeNode("Grain Inventory");
            var TreeNode79 = new TreeNode("Inventory Management", new TreeNode[] { TreeNode77, TreeNode78 });
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClearance));
            var BorderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var BorderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            var StateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            var StateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            _TreeView1 = new TreeView();
            _TreeView1.AfterCheck += new TreeViewEventHandler(TreeView1_AfterCheck);
            Label1 = new Label();
            _saveBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _saveBunifuButton.Click += new EventHandler(TouchButton1_Load);
            _noBunifuButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            _noBunifuButton.Click += new EventHandler(finishButton_Click);
            SuspendLayout();
            // 
            // TreeView1
            // 
            _TreeView1.CheckBoxes = true;
            _TreeView1.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _TreeView1.Location = new Point(80, 128);
            _TreeView1.Margin = new Padding(4, 4, 4, 4);
            _TreeView1.Name = "_TreeView1";
            TreeNode1.Name = "Node0";
            TreeNode1.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode1.Text = "Home Page";
            TreeNode2.Name = "Node0";
            TreeNode2.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode2.Text = "Bookings";
            TreeNode3.Name = "Node3";
            TreeNode3.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode3.Text = "Assign Container";
            TreeNode4.Name = "Node1";
            TreeNode4.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode4.Text = "Block Container";
            TreeNode5.Name = "editSampleType";
            TreeNode5.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TreeNode5.Text = "Edit Sample Type";
            TreeNode6.Name = "editCustomer";
            TreeNode6.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode6.Text = "Edit Customer";
            TreeNode7.Name = "editBooking";
            TreeNode7.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode7.Text = "Edit Booking";
            TreeNode8.Name = "editUnit";
            TreeNode8.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode8.Text = "Edit Unit";
            TreeNode9.Name = "editCommodity";
            TreeNode9.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode9.Text = "Edit Commodity";
            TreeNode10.Name = "printButton";
            TreeNode10.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode10.Text = "Print Label";
            TreeNode11.Name = "CFIALabelsNode";
            TreeNode11.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TreeNode11.Text = "CFIA Labels";
            TreeNode12.Name = "Node7";
            TreeNode12.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode12.Text = "EDI";
            TreeNode13.Name = "Node5";
            TreeNode13.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode13.Text = "In/Out Gate";
            TreeNode14.Name = "Node5";
            TreeNode14.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode14.Text = "Transfer Container";
            TreeNode15.Name = "Node0";
            TreeNode15.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode15.Text = "Manage Container";
            TreeNode16.Name = "Node0";
            TreeNode16.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode16.Text = "Containers";
            TreeNode17.BackColor = Color.Transparent;
            TreeNode17.Name = "addEntry";
            TreeNode17.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode17.Text = "Add New Entry";
            TreeNode18.Name = "entryDetails";
            TreeNode18.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode18.Text = "See Entry Details";
            TreeNode19.Name = "Node1";
            TreeNode19.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode19.Text = "Edit Entry";
            TreeNode20.Name = "deleteEntry";
            TreeNode20.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode20.Text = "Delete Entry";
            TreeNode21.Name = "Node2";
            TreeNode21.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode21.Text = "Print TimeSheet";
            TreeNode22.Name = "Node3";
            TreeNode22.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode22.Text = "Export TimeSheet";
            TreeNode23.Name = "addHoliday";
            TreeNode23.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode23.Text = "Add Holidays";
            TreeNode24.Name = "Node1";
            TreeNode24.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TreeNode24.Text = "Time Management";
            TreeNode24.ToolTipText = "Read, Edit, Create, Add, Delete time entries";
            TreeNode25.Name = "node1";
            TreeNode25.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode25.Text = "Time Reports";
            TreeNode26.Name = "Node0";
            TreeNode26.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode26.Text = "Time Management and Reports";
            TreeNode27.Name = "addEmployee";
            TreeNode27.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode27.Text = "Add Employee";
            TreeNode28.Name = "assignCardID";
            TreeNode28.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode28.Text = "Assign CardID";
            TreeNode29.Name = "createLogin";
            TreeNode29.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode29.Text = "Create Login";
            TreeNode30.Name = "deleteEmployee";
            TreeNode30.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode30.Text = "Delete Employee";
            TreeNode31.Name = "Node5";
            TreeNode31.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode31.Text = "See sensitive information";
            TreeNode31.ToolTipText = "Give user access to sensitive information such as SIN, Birthday, Address...";
            TreeNode32.Name = "employeeDetails";
            TreeNode32.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode32.Text = "See Employee Details";
            TreeNode33.Name = "suspendEmployee";
            TreeNode33.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode33.Text = "Suspend Employee";
            TreeNode34.Name = "modifyEployee";
            TreeNode34.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode34.Text = "Modify Employee";
            TreeNode35.Name = "Node0";
            TreeNode35.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode35.Text = "Print Card";
            TreeNode36.Name = "setClearance";
            TreeNode36.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode36.Text = "Set Clearance";
            TreeNode37.Name = "Node8";
            TreeNode37.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode37.Text = "Employee Management";
            TreeNode38.Name = "Node9";
            TreeNode38.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode38.Text = "Shift Management";
            TreeNode39.Name = "WorkedHours";
            TreeNode39.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode39.Text = "Worked Hours";
            TreeNode40.Name = "Node1";
            TreeNode40.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode40.Text = "Document Storage";
            TreeNode41.Name = "Node10";
            TreeNode41.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode41.Text = "Safety and Risk Management";
            TreeNode42.Name = "Node0";
            TreeNode42.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode42.Text = "Message Employee";
            TreeNode43.Name = "EmployeeManagementNode";
            TreeNode43.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TreeNode43.Text = "Human Resources";
            TreeNode44.Name = "Node1";
            TreeNode44.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode44.Text = "Probation Due Reminder";
            TreeNode45.Name = "Node2";
            TreeNode45.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode45.Text = "Statutory Holiday Reminder";
            TreeNode46.Name = "Node3";
            TreeNode46.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode46.Text = "Year Follow Up Reminder";
            TreeNode47.Name = "Node12";
            TreeNode47.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode47.Text = "Benefit Reminder";
            TreeNode47.ToolTipText = "Remind to update benefits after the probation period";
            TreeNode48.Name = "Node0";
            TreeNode48.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode48.Text = "Email Reminder";
            TreeNode48.ToolTipText = "Sends a email with reminders about probation due, year follow up, and benefit rem" + "inder";
            TreeNode49.Name = "Node8";
            TreeNode49.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode49.Text = "Job Letter Request";
            TreeNode49.ToolTipText = "Receive job letter requests";
            TreeNode50.Name = "Node9";
            TreeNode50.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode50.Text = "Time Off Request";
            TreeNode50.ToolTipText = "Receive time off requests";
            TreeNode51.Name = "Node10";
            TreeNode51.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode51.Text = "Vacation Pay Request";
            TreeNode51.ToolTipText = "Receive vacation pay requests";
            TreeNode52.Name = "Node11";
            TreeNode52.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode52.Text = "Benefit Claim Request";
            TreeNode53.Name = "Node2";
            TreeNode53.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode53.Text = "Failed Punch Attempt Warning";
            TreeNode54.Name = "Node13";
            TreeNode54.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode54.Text = "Employee Management Notifications";
            TreeNode55.Name = "Node5";
            TreeNode55.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode55.Text = "Document Expiration Reminder";
            TreeNode56.Name = "Node6";
            TreeNode56.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode56.Text = "Safety Committee Meeting Reminder";
            TreeNode57.Name = "Node7";
            TreeNode57.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode57.Text = "Safety Committee Inspection Reminder";
            TreeNode58.Name = "Node4";
            TreeNode58.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode58.Text = "Training Reminder";
            TreeNode59.Name = "Node1";
            TreeNode59.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode59.Text = "Email Reminder";
            TreeNode59.ToolTipText = "Sends email reminder about Committee Meetings, Inspections, and Document expirati" + "ons";
            TreeNode60.Name = "Node14";
            TreeNode60.NodeFont = new Font("Microsoft Sans Serif", 14.25f);
            TreeNode60.Text = "Safety and Risk Notifications";
            TreeNode61.Name = "Node0";
            TreeNode61.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode61.Text = "Notifications";
            TreeNode61.ToolTipText = "Check the type of requests the selected employee will receive";
            TreeNode62.Name = "Node1";
            TreeNode62.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode62.Text = "Companies";
            TreeNode63.Name = "Node2";
            TreeNode63.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode63.Text = "Pre Scripts";
            TreeNode64.Name = "Node0";
            TreeNode64.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode64.Text = "Contacts";
            TreeNode64.ToolTipText = "Add Companies information and its contacts. Create and modify Message Templates";
            TreeNode65.Name = "Node11";
            TreeNode65.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode65.Text = "Inbound Cargo";
            TreeNode66.Name = "Node2";
            TreeNode66.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode66.Text = "Carrier Assignment";
            TreeNode67.Name = "Node13";
            TreeNode67.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode67.Text = "Requests";
            TreeNode68.Name = "Node0";
            TreeNode68.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode68.Text = "Inbound";
            TreeNode69.Name = "Node1";
            TreeNode69.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode69.Text = "Outbound";
            TreeNode70.Name = "Node12";
            TreeNode70.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode70.Text = "Truck Dispatch";
            TreeNode71.Name = "Node1";
            TreeNode71.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode71.Text = "Trucking Reconciliation";
            TreeNode72.Name = "Node0";
            TreeNode72.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode72.Text = "Billing";
            TreeNode73.Name = "Node1";
            TreeNode73.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode73.Text = "Truck Drivers";
            TreeNode74.Name = "Node2";
            TreeNode74.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode74.Text = "Logs";
            TreeNode75.Name = "Node0";
            TreeNode75.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode75.Text = "Miscellaneous";
            TreeNode76.Name = "Node0";
            TreeNode76.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode76.Text = "Time Tracker";
            TreeNode77.Name = "Node1";
            TreeNode77.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode77.Text = "Empty Bag Inventory";
            TreeNode78.Name = "Node2";
            TreeNode78.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode78.Text = "Grain Inventory";
            TreeNode79.Name = "Node0";
            TreeNode79.NodeFont = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
            TreeNode79.Text = "Inventory Management";
            _TreeView1.Nodes.AddRange(new TreeNode[] { TreeNode1, TreeNode2, TreeNode16, TreeNode43, TreeNode61, TreeNode64, TreeNode65, TreeNode70, TreeNode72, TreeNode75, TreeNode76, TreeNode79 });
            _TreeView1.ShowNodeToolTips = true;
            _TreeView1.Size = new Size(773, 415);
            _TreeView1.TabIndex = 2;
            // 
            // Label1
            // 
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Segoe UI Semibold", 13.74545f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            Label1.Location = new Point(73, 44);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(781, 80);
            Label1.TabIndex = 3;
            Label1.Text = "Check all functionalities you wish to grant to Bob Singer";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // saveBunifuButton
            // 
            _saveBunifuButton.AllowToggling = false;
            _saveBunifuButton.AnimationSpeed = 200;
            _saveBunifuButton.AutoGenerateColors = false;
            _saveBunifuButton.BackColor = Color.Transparent;
            _saveBunifuButton.BackColor1 = Color.Teal;
            _saveBunifuButton.BackgroundImage = (Image)resources.GetObject("saveBunifuButton.BackgroundImage");
            _saveBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _saveBunifuButton.ButtonText = "Save";
            _saveBunifuButton.ButtonTextMarginLeft = 0;
            _saveBunifuButton.ColorContrastOnClick = 45;
            _saveBunifuButton.ColorContrastOnHover = 45;
            _saveBunifuButton.Cursor = Cursors.Hand;
            BorderEdges1.BottomLeft = true;
            BorderEdges1.BottomRight = true;
            BorderEdges1.TopLeft = true;
            BorderEdges1.TopRight = true;
            _saveBunifuButton.CustomizableEdges = BorderEdges1;
            _saveBunifuButton.DialogResult = DialogResult.None;
            _saveBunifuButton.DisabledBorderColor = Color.Empty;
            _saveBunifuButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _saveBunifuButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _saveBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _saveBunifuButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _saveBunifuButton.ForeColor = Color.White;
            _saveBunifuButton.IconLeftCursor = Cursors.Hand;
            _saveBunifuButton.IconMarginLeft = 11;
            _saveBunifuButton.IconPadding = 10;
            _saveBunifuButton.IconRightCursor = Cursors.Hand;
            _saveBunifuButton.IdleBorderColor = Color.Teal;
            _saveBunifuButton.IdleBorderRadius = 3;
            _saveBunifuButton.IdleBorderThickness = 1;
            _saveBunifuButton.IdleFillColor = Color.Teal;
            _saveBunifuButton.IdleIconLeftImage = null;
            _saveBunifuButton.IdleIconRightImage = null;
            _saveBunifuButton.IndicateFocus = true;
            _saveBunifuButton.Location = new Point(509, 598);
            _saveBunifuButton.Margin = new Padding(4, 4, 4, 4);
            _saveBunifuButton.Name = "_saveBunifuButton";
            StateProperties1.BorderColor = Color.MediumTurquoise;
            StateProperties1.BorderRadius = 3;
            StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties1.BorderThickness = 1;
            StateProperties1.FillColor = Color.MediumTurquoise;
            StateProperties1.ForeColor = Color.White;
            StateProperties1.IconLeftImage = null;
            StateProperties1.IconRightImage = null;
            _saveBunifuButton.onHoverState = StateProperties1;
            StateProperties2.BorderColor = Color.Teal;
            StateProperties2.BorderRadius = 3;
            StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties2.BorderThickness = 1;
            StateProperties2.FillColor = Color.Teal;
            StateProperties2.ForeColor = Color.White;
            StateProperties2.IconLeftImage = null;
            StateProperties2.IconRightImage = null;
            _saveBunifuButton.OnPressedState = StateProperties2;
            _saveBunifuButton.Size = new Size(176, 55);
            _saveBunifuButton.TabIndex = 74;
            _saveBunifuButton.TextAlign = ContentAlignment.MiddleCenter;
            _saveBunifuButton.TextMarginLeft = 0;
            _saveBunifuButton.UseDefaultRadiusAndThickness = true;
            // 
            // noBunifuButton
            // 
            _noBunifuButton.AllowToggling = false;
            _noBunifuButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _noBunifuButton.AnimationSpeed = 200;
            _noBunifuButton.AutoGenerateColors = false;
            _noBunifuButton.BackColor = Color.Transparent;
            _noBunifuButton.BackColor1 = Color.White;
            _noBunifuButton.BackgroundImage = (Image)resources.GetObject("noBunifuButton.BackgroundImage");
            _noBunifuButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            _noBunifuButton.ButtonText = "Cancel";
            _noBunifuButton.ButtonTextMarginLeft = 0;
            _noBunifuButton.ColorContrastOnClick = 45;
            _noBunifuButton.ColorContrastOnHover = 45;
            _noBunifuButton.Cursor = Cursors.Hand;
            BorderEdges2.BottomLeft = true;
            BorderEdges2.BottomRight = true;
            BorderEdges2.TopLeft = true;
            BorderEdges2.TopRight = true;
            _noBunifuButton.CustomizableEdges = BorderEdges2;
            _noBunifuButton.DialogResult = DialogResult.None;
            _noBunifuButton.DisabledBorderColor = Color.Empty;
            _noBunifuButton.DisabledFillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)), Conversions.ToInteger(Conversions.ToByte(204)));
            _noBunifuButton.DisabledForecolor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(168)), Conversions.ToInteger(Conversions.ToByte(160)), Conversions.ToInteger(Conversions.ToByte(168)));
            _noBunifuButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            _noBunifuButton.Font = new Font("Segoe UI Semibold", 11.12727f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _noBunifuButton.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _noBunifuButton.IconLeftCursor = Cursors.Hand;
            _noBunifuButton.IconMarginLeft = 11;
            _noBunifuButton.IconPadding = 10;
            _noBunifuButton.IconRightCursor = Cursors.Hand;
            _noBunifuButton.IdleBorderColor = Color.Gray;
            _noBunifuButton.IdleBorderRadius = 3;
            _noBunifuButton.IdleBorderThickness = 1;
            _noBunifuButton.IdleFillColor = Color.White;
            _noBunifuButton.IdleIconLeftImage = null;
            _noBunifuButton.IdleIconRightImage = null;
            _noBunifuButton.IndicateFocus = true;
            _noBunifuButton.Location = new Point(713, 599);
            _noBunifuButton.Margin = new Padding(4, 4, 4, 4);
            _noBunifuButton.Name = "_noBunifuButton";
            StateProperties3.BorderColor = Color.DarkGray;
            StateProperties3.BorderRadius = 3;
            StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties3.BorderThickness = 1;
            StateProperties3.FillColor = Color.DarkGray;
            StateProperties3.ForeColor = Color.White;
            StateProperties3.IconLeftImage = null;
            StateProperties3.IconRightImage = null;
            _noBunifuButton.onHoverState = StateProperties3;
            StateProperties4.BorderColor = Color.IndianRed;
            StateProperties4.BorderRadius = 3;
            StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            StateProperties4.BorderThickness = 1;
            StateProperties4.FillColor = Color.IndianRed;
            StateProperties4.ForeColor = Color.White;
            StateProperties4.IconLeftImage = null;
            StateProperties4.IconRightImage = null;
            _noBunifuButton.OnPressedState = StateProperties4;
            _noBunifuButton.Size = new Size(141, 54);
            _noBunifuButton.TabIndex = 75;
            _noBunifuButton.TextAlign = ContentAlignment.MiddleCenter;
            _noBunifuButton.TextMarginLeft = 0;
            _noBunifuButton.UseDefaultRadiusAndThickness = true;
            // 
            // FrmClearance
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 695);
            ControlBox = false;
            Controls.Add(_noBunifuButton);
            Controls.Add(_saveBunifuButton);
            Controls.Add(Label1);
            Controls.Add(_TreeView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmClearance";
            StartPosition = FormStartPosition.CenterScreen;
            Load += new EventHandler(FrmClearance_Load);
            ResumeLayout(false);
        }

        private TreeView _TreeView1;

        internal TreeView TreeView1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TreeView1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TreeView1 != null)
                {
                    _TreeView1.AfterCheck -= TreeView1_AfterCheck;
                }

                _TreeView1 = value;
                if (_TreeView1 != null)
                {
                    _TreeView1.AfterCheck += TreeView1_AfterCheck;
                }
            }
        }

        internal Label Label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _saveBunifuButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton saveBunifuButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _saveBunifuButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_saveBunifuButton != null)
                {
                    _saveBunifuButton.Click -= TouchButton1_Load;
                }

                _saveBunifuButton = value;
                if (_saveBunifuButton != null)
                {
                    _saveBunifuButton.Click += TouchButton1_Load;
                }
            }
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton _noBunifuButton;

        internal Bunifu.UI.WinForms.BunifuButton.BunifuButton noBunifuButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _noBunifuButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_noBunifuButton != null)
                {
                    _noBunifuButton.Click -= finishButton_Click;
                }

                _noBunifuButton = value;
                if (_noBunifuButton != null)
                {
                    _noBunifuButton.Click += finishButton_Click;
                }
            }
        }
    }
}