using Bunifu.UI.WinForms;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmParentScreen
    {
        public FrmParentScreen()
        {
            InitializeComponent();
            _SlideMenu1.Name = "SlideMenu1";
            _shirnkExpandPictureBox.Name = "shirnkExpandPictureBox";
            _upperBunifuShadowPanel1.Name = "upperBunifuShadowPanel1";
            _btnChanges.Name = "btnChanges";
            _minimizePictureBox.Name = "minimizePictureBox";
            _exitPictureBox.Name = "exitPictureBox";
            _FormsTab1.Name = "FormsTab1";
            _dgvPendingChanges.Name = "dgvPendingChanges";
        }

        [DllImport("User32.Dll", CharSet = CharSet.Auto)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("User32.Dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0x200;
        private int originbalPanelWidth = 219;

        private DatabaseHelper db = new DatabaseHelper();
        public int _punchID = 0;
        private bool pnlPendingVisible;

        public int notificationID { get; set; } = 0;
        public frmTruckDriverList f;

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlPendingVisible = false;
            Timer1.Interval = (int)Math.Round(TimeSpan.FromSeconds(2d).TotalMilliseconds);
            Timer1.Start();

            _punchID = 0;
            pnlPendingVisible = false;

            // db.needToclockedOutLastShift()
            // db.createIPSession()
            IsMdiContainer = true;
            My.MyProject.Forms.FrmHomePage.MdiParent = this;
            decimal heigt = (decimal)(My.MyProject.Computer.Screen.Bounds.Size.Height / 1.04d);
            Size = (Size)new Point(My.MyProject.Computer.Screen.Bounds.Size.Width, (int)Math.Round(heigt));
            var tip = new ToolTip();
            tip.SetToolTip(exitPictureBox, "Exit");
            tip.SetToolTip(minimizePictureBox, "Minimize");

            // to ignore border od Parent form
            foreach (Control c in Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = BackColor;
                    int windowLong = GetWindowLong(c.Handle, GWL_EXSTYLE);
                    windowLong = windowLong & ~WS_EX_CLIENTEDGE;
                    SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong);
                    c.Width = c.Width + 1;
                    break;
                }
            }

            MdlOptionsManagement.getClearedModels(this);
            My.MyProject.Forms.FrmHomePage.WindowState = FormWindowState.Maximized;
            if (FormsTab1.FormExists(My.MyProject.Forms.FrmHomePage.Name))
            {
                return;
            }
            else
            {
                AddFormToPanel(My.MyProject.Forms.FrmHomePage);
                FormsTab1.AddFormTab("Home Page", My.MyProject.Forms.FrmHomePage.Name);
            }

            selectedOption = My.MyProject.Forms.FrmHomePage;
            MdlLoadingSetting.adjustScreen(selectedOption, menuIsExpanded);
            MdlLoadingSetting.adjustScreen(PanelWindows, menuIsExpanded);
            // FrmHomePage.Show()
            // HarvesterAlive1.Enabled = True

            //  HideLoadForm();
        }

        private Form selectedOption;

        private void SlideMenu1_SubMenuKeySelected(string MainMenuKey, string SubMenuKey)
        {
            // showLOadForm();
            string tabName = "";
            // Human Resources
            if (SubMenuKey.Equals("Employee Management"))
            {
                selectedOption = My.MyProject.Forms.FrmEmployeeManagement;
                tabName = "Employee Management";
            }
            else if (SubMenuKey.Equals("Time Management"))
            {
                selectedOption = My.MyProject.Forms.FrmTimeSheet;
                tabName = "Time Management";
            }
            else if (SubMenuKey.Equals("Shift Management"))
            {
                selectedOption = My.MyProject.Forms.FrmShiftScheduling;
                tabName = "Shift Management";
            }
            else if (SubMenuKey.Equals("Safety/Risk Manageme"))
            {
                selectedOption = My.MyProject.Forms.FrmSafetyRiskMain;
                // Containers - In Construction
                tabName = "Risk Management";
            }
            else if (SubMenuKey.Equals("Assign Container"))
            {
                selectedOption = My.MyProject.Forms.FrmAssignContainer;
                tabName = "Assign Container";
            }
            else if (SubMenuKey.Equals("EDI"))
            {
                selectedOption = My.MyProject.Forms.FrmEDIManagement;
                tabName = "EDI";
            }
            else if (SubMenuKey.Equals("EDI Performance Audi"))
            {
                selectedOption = My.MyProject.Forms.frmEDIPerformanceAudit;
                tabName = "EDI Performance Audit";
            }
            else if (SubMenuKey.Equals("In/Out Gate"))
            {
                selectedOption = My.MyProject.Forms.FrmInOutGate;
                tabName = "In/Out Gate";
            }
            else if (SubMenuKey.Equals("Container Management"))
            {
                selectedOption = My.MyProject.Forms.FrmListContainers;
                tabName = "Container Management";
            }
            // Containers - Ready
            else if (SubMenuKey.Equals("Block Container"))
            {
                selectedOption = My.MyProject.Forms.FrmListBlockedContainers;
                tabName = "Blocked Containers";
            }
            else if (SubMenuKey.Equals("Transfer Container"))
            {
                selectedOption = My.MyProject.Forms.FrmListTransfers;
                tabName = "Transfer Container";
            }
            else if (SubMenuKey.Equals("CFIA Labels"))
            {
                selectedOption = My.MyProject.Forms.FrmCFIALabel;
                tabName = "Labels";
            }
            else if (SubMenuKey.Equals("Companies"))
            {
                selectedOption = My.MyProject.Forms.FrmDisplayContacts;
                tabName = "Companies";
            }
            else if (SubMenuKey.Equals("Pre Scripts"))
            {
                selectedOption = My.MyProject.Forms.FrmDisplayTemplates;
                tabName = "Pre Scripts";
            }

            // Bookings - In Construction
            else if (SubMenuKey.Equals("Bookings Report"))
            {
                selectedOption = My.MyProject.Forms.FrmBookingReport;
                tabName = "Bookings Report";
            }
            else if (SubMenuKey.Equals("Vessel"))
            {
                selectedOption = My.MyProject.Forms.frmVesselList;
                tabName = "Vessel";
            }
            else if (SubMenuKey.Equals("Vessel Voyage"))
            {
                selectedOption = My.MyProject.Forms.frmVesselVoyageList;
                tabName = "Vessel Voyage";
            }

            // Dispatch - In construction
            else if (SubMenuKey.Equals("Logs"))
            {
                selectedOption = My.MyProject.Forms.FrmLogs;
                tabName = "Logs";
            }
            else if (SubMenuKey.Equals("TruckDrivers"))
            {
                f = new frmTruckDriverList();
                selectedOption = f;
                tabName = "Truck Drivers";
            }
            else if (SubMenuKey.Equals("Requests"))
            {
                selectedOption = My.MyProject.Forms.FrmInConstruction;
                tabName = "Requests";
            }
            else if (SubMenuKey.Equals("Trucking Reconciliat"))
            {
                selectedOption = My.MyProject.Forms.FrmTruckingRecon;
                tabName = "Trucking Reconciliation";
            }
            else if (SubMenuKey.Equals("Carrier Assignment"))
            {
                selectedOption = My.MyProject.Forms.FrmCarrierAssignment;
                tabName = "Carrier Assignment";
            }
            else if (SubMenuKey.Equals("Epty Bag Inventory"))
            {
                selectedOption = My.MyProject.Forms.FrmEmptyBagInvList;
                tabName = "Empty Bag Inventory";
            }
            else if (SubMenuKey.Equals("Grain Inventory"))
            {
                selectedOption = My.MyProject.Forms.FrmGrainInvList;
                tabName = "Grain Inventory";
            }
            else if (SubMenuKey.Equals("Inbound"))
            {
                selectedOption = My.MyProject.Forms.FrmListRequests;
                tabName = "Inbound";
            }
            else if (SubMenuKey.Equals("Outbound"))
            {
                selectedOption = My.MyProject.Forms.FrmInConstruction;
                tabName = "Outbound";
            }

            MdlLoadingSetting.adjustScreen(PanelWindows, menuIsExpanded);
            MdlLoadingSetting.adjustScreen(selectedOption, menuIsExpanded);
            if (FormsTab1.FormExists(selectedOption.Name))
            {
                // HideLoadForm();
                return;
            }
            else
            {
                AddFormToPanel(selectedOption);
                FormsTab1.AddFormTab(tabName, selectedOption.Name);
                // HideLoadForm();
            }
        }

        public bool isTabEvent;

        private void FormsTab1_FormTabSelected(string FormName)
        {
            short x;
            short PanIndex = 0;
            isTabEvent = true;
            var loopTo = (short)(PanelWindows.Controls.Count - 1);
            for (x = 0; x <= loopTo; x++)
            {
                if ((PanelWindows.Controls[x].Name ?? "") == (FormName ?? ""))
                {
                    // Try
                    PanelWindows.Controls[x].Show();
                }
                // Catch ex As Exception

                // End Try
                else
                {
                    PanelWindows.Controls[x].Hide();
                }
            }

            isTabEvent = false;
        }

        private void FormsTab1_DeleteTabForm(string FormName)
        {
            short x;
            short PanIndex = 0;
            var loopTo = (short)(PanelWindows.Controls.Count - 1);
            for (x = 0; x <= loopTo; x++)
            {
                if ((PanelWindows.Controls[x].Name ?? "") == (FormName ?? ""))
                {
                    // PanelWindows.Controls.Remove(PanelWindows.Controls(x))
                    PanelWindows.Controls[x].Dispose();
                    return;
                }
            }
        }

        public void AddFormToPanel(Form ThisForm)
        {
            ThisForm.TopLevel = false;
            ThisForm.FormBorderStyle = FormBorderStyle.None;
            ThisForm.Location = new Point(0, 0);
            ThisForm.WindowState = FormWindowState.Normal;
            ThisForm.Visible = false;
            PanelWindows.Controls.Add(ThisForm);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmLoginWindow.Close();
        }

        private FormCollection myForms = Application.OpenForms;

        private void SlideMenu1_MainMenuKeySelected(string MainMenyKey)
        {
            string tabName = "";
            Form selectedOption2 = My.MyProject.Forms.FrmInConstruction;
            if (MainMenyKey.Equals("Home"))
            {
                selectedOption = My.MyProject.Forms.FrmHomePage;
                tabName = "Home Page";
            }
            else if (MainMenyKey.Equals("Inbound Cargo"))
            {
                selectedOption = My.MyProject.Forms.FrmRailList;
                tabName = "Inbound Cargo";
            }
            else if (MainMenyKey.Equals("Bookings"))
            {
                selectedOption = My.MyProject.Forms.FrmBookingList;
                tabName = "Bookings";
            }
            else if (MainMenyKey.Equals("Clock In/Out"))
            {
                selectedOption = My.MyProject.Forms.FrmTimeTracker;
                tabName = "Clock In/Out";
            }

            if (tabName.Equals(""))
            {
                // HideLoadForm();
                return;
            }
            else if (FormsTab1.FormExists(selectedOption.Name))
            {
                // HideLoadForm();
                return;
            }
            else
            {
                // showLOadForm();
                MdlLoadingSetting.adjustScreen(PanelWindows, menuIsExpanded);
                MdlLoadingSetting.adjustScreen(selectedOption, menuIsExpanded);
                AddFormToPanel(selectedOption);
                FormsTab1.AddFormTab(tabName, selectedOption.Name);
                // HideLoadForm();
            }
        }

        public bool menuIsExpanded = true;
        private int originalUpperMenuWidth = 1502;

        private void shirnkExpandPictureBox_Click(object sender, EventArgs e)
        {
            if (menuIsExpanded)
            {
                menuPanel.Width = (int)Math.Round(menuPanel.Width * 0.2d);
                menuIsExpanded = false;
                shirnkExpandPictureBox.Image = My.Resources.Resources.expandArrow;
                SlideMenu1.Visible = false;
            }
            else
            {
                menuPanel.Width = originbalPanelWidth;
                menuIsExpanded = true;
                shirnkExpandPictureBox.Image = My.Resources.Resources.shrinkArrow;
                SlideMenu1.Visible = true;
            }

            MdlLoadingSetting.adjustScreen(PanelWindows, menuIsExpanded);
            MdlLoadingSetting.adjustScreen(selectedOption, menuIsExpanded);
        }

        //public void runLoadForm()
        //{
        //    form2.Location = new Point((int)Math.Round(My.MyProject.Computer.Screen.Bounds.Size.Width / 2d + 10d), (int)Math.Round(My.MyProject.Computer.Screen.Bounds.Size.Height / 2d - 70d));
        //    Application.Run(form2);
        //}

        //public void HideLoadForm()
        //{
        //    try
        //    {
        //        if (form2.PictureBox1.InvokeRequired)
        //        {
        //            form2.PictureBox1.Hide();
        //        }
        //        else
        //        {
        //            form2.Hide();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}

        //public void showLOadForm()
        //{
        //    if (form2.PictureBox1.InvokeRequired)
        //    {
        //        form2.PictureBox1.Show();
        //    }
        //    else
        //    {
        //        try
        //        {
        //            form2.PictureBox1.Visible = true;
        //            form2.Show();
        //        }
        //        catch
        //        {
        //        }
        //    }
        //}

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void minimizePictureBox_MouseHover(object sender, EventArgs e)
        {
            minimizePictureBox.BackColor = Color.LightGray;
        }

        private void minimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            minimizePictureBox.BackColor = Color.White;
        }

        private void exitPictureBox_Leave(object sender, EventArgs e)
        {
            exitPictureBox.BackColor = Color.White;
        }

        private void exitPictureBox_Mouse_Hover(object sender, EventArgs e)
        {
            exitPictureBox.BackColor = Color.LightGray;
        }

        private bool Panel1Captured;
        private Point Panel1Grabbed;
        private bool IsFormBeingDragged = false;
        private int MouseDownX;
        private int MouseDownY;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsFormBeingDragged = true;
                MouseDownX = e.X;
                MouseDownY = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsFormBeingDragged = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsFormBeingDragged)
            {
                var temp = new Point();
                temp.X = Location.X + (e.X - MouseDownX);
                temp.Y = Location.Y + (e.Y - MouseDownY);
                Location = temp;
                temp = default;
            }
        }

        // Private Sub HarvesterAlive1_FetchHarvesterStatus()
        // HarvesterAlive1.TakeLastActive(FetchLastActive(DatabaseHelperCeres.StrConnWTCCeres))
        // End Sub

        private DateTime FetchLastActive(string DBConnect)
        {
            try
            {
                var DbObjDataTable = new DataTable();
                var DbObjAdapter = new System.Data.SqlClient.SqlDataAdapter("Select * From [Harvester Alive]", DBConnect);
                var DbObjCommand = new System.Data.SqlClient.SqlCommandBuilder(DbObjAdapter);
                DbObjAdapter.Fill(DbObjDataTable);
                if (DbObjDataTable.Rows.Count == 1)
                {
                    return Conversions.ToDate(DbObjDataTable.Rows[0]["Last Alive"]);
                }
                else
                {
                    return default;
                }
            }
            catch
            {
            }

            return default;
        }

        private void HarvesterAlive1_Load(object sender, EventArgs e)
        {
        }

        // Private Sub HarvesterAlive1_NotifyDisconnectState(LastAlive As DateTime)
        // '**** Red to Green *****
        // statusLabel.Text = "Harvester Offline. Last fetch: " + LastAlive.ToString("dd-MMM-yyyy HH:mm")
        // statusLabel.ForeColor = Color.Red
        // End Sub

        // Private Sub HarvesterAlive1_DisplayLastAlive(LastAlive As DateTime)
        // statusLabel.Text = "Harvester Online. Last fetch: " + LastAlive.ToString("dd-MMM-yyyy HH:mm")
        // statusLabel.ForeColor = Color.Green
        // End Sub

        private void FrmParentScreen_Resize(object sender, EventArgs e)
        {
            decimal heigt = My.MyProject.Computer.Screen.WorkingArea.Height - 50;
            decimal width = 0m;
            if (menuIsExpanded)
            {
                width = My.MyProject.Computer.Screen.WorkingArea.Width - 225;
                PanelWindows.SetBounds(220, 50, (int)Math.Round(width), (int)Math.Round(heigt));
            }
            else
            {
                width = My.MyProject.Computer.Screen.WorkingArea.Width - 50;
                PanelWindows.SetBounds(45, 50, (int)Math.Round(width), (int)Math.Round(heigt));
            }
            // focusedForm.Location = New Point(0, 0)
            // focusedForm.Size = New Point(width, heigt)

            SlideMenu1.Visible = true;

            // If Me.WindowState <> FormWindowState.Maximized Then
            // Me.FormBorderStyle = FormBorderStyle.None
            // Else
            // Me.FormBorderStyle = FormBorderStyle.Sizable
            // End If
        }

        private void BunifuFormDock1_DockChanged(object sender, BunifuFormDock.DockChangedEventArgs e)
        {
            if (e.DockPosition == BunifuFormDock.DockPositions.FullScreen)
            {
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void btnAddBagInventory_Click(object sender, EventArgs e)
        {
            if (pnlPendingVisible == false)
            {
                pnlQueueChanges.Visible = true;
                pnlPendingVisible = true;
            }
            else
            {
                pnlQueueChanges.Visible = false;
                pnlPendingVisible = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            dgvPendingChanges.DataSource = CeresExcelPendingSyncService.GetAllVW();
            btnChanges.Text = dgvPendingChanges.Rows.Count.ToString();
            btnChanges.Refresh();
            dgvPendingChanges.Refresh();
        }

        private void dgvPendingChanges_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var bkNumb = dgvPendingChanges.Rows[e.RowIndex].Cells["MinibookingNumberCol"];
            var status = dgvPendingChanges.Rows[e.RowIndex].Cells["CurrentStatus"];
            var msg = dgvPendingChanges.Rows[e.RowIndex].Cells["SyncMessage"];
            status.Style.Font = new Font("Arial", 8.25f, FontStyle.Bold);
            bkNumb.Style.Font = new Font("Arial", 8.25f, FontStyle.Bold);
            msg.Style.Font = new Font("Arial", 7f, FontStyle.Regular);
            bkNumb.Style.ForeColor = Color.Black;
            bkNumb.Style.SelectionForeColor = Color.Black;
            status.Style.ForeColor = Color.White;
            status.Style.SelectionForeColor = Color.White;
            switch (status.Value)
            {
                case "QUEUE":
                    {
                        status.Style.BackColor = Color.Gray;
                        status.Style.SelectionBackColor = Color.Gray;
                        break;
                    }

                case "NOT SYNCING":
                    {
                        status.Style.BackColor = Color.Red;
                        status.Style.SelectionBackColor = Color.Red;
                        break;
                    }

                case "SYNCING":
                    {
                        status.Style.BackColor = Color.Green;
                        status.Style.SelectionBackColor = Color.Green;
                        break;
                    }
            }
        }

        // Private Sub upperBunifuShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles upperBunifuShadowPanel1.Paint
        // Me.RectangleToScreen()
    }
}