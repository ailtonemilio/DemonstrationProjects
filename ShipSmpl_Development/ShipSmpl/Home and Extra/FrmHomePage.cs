using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ShipSmpl
{
    public partial class FrmHomePage
    {
        public FrmHomePage()
        {
            InitializeComponent();
            _Label24.Name = "Label24";
            _probationPeriodNumberLabel.Name = "probationPeriodNumberLabel";
            _messageEmployeeLabel.Name = "messageEmployeeLabel";
            _Label28.Name = "Label28";
            _BirthdayCountLabel.Name = "BirthdayCountLabel";
            _actionComboBox1.Name = "actionComboBox1";
            _typeComboBox.Name = "typeComboBox";
            _NotificationCenter1.Name = "NotificationCenter1";
        }

        [DllImport("User32.Dll", CharSet = CharSet.Auto)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("User32.Dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0x200;
        private DatabaseHelper db = new DatabaseHelper();

        public int notificationID { get; set; } = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            MdlOptionsManagement.fillUpEmployeesStats();
            firstLoad = true;
            {
                var withBlock = NotificationCenter1;
                withBlock.NotifyButtonDefinitions('\u0001', "Approve", Color.Green);
                withBlock.NotifyButtonDefinitions('\u0002', "Decline", Color.Firebrick);
                withBlock.NotifyButtonDefinitions('\u0003', "Hide", Color.FromKnownColor(KnownColor.ControlDarkDark));
                withBlock.NotifyButtonDefinitions('\u0004', "Solved", Color.Teal);
                withBlock.NotifyButtonDefinitions('\u0005', "Dismiss", Color.Firebrick);
                withBlock.NotifyButtonDefinitions('\u0006', "Message", Color.DarkSlateGray, true);
                withBlock.NotifyButtonDefinitions('\a', "Details", Color.FromKnownColor(KnownColor.SteelBlue), true);
                withBlock.NotifyButtonDefinitions('\b', "Confirm", Color.Green);
                withBlock.NotifyButtonDefinitions('\t', "Update Address", Color.Green);
            }

            if (MdlOptionsManagement.canSeeNotificationas == false)
            {
                NotificationCenter1.Hide();
            }
            else
            {
                actionComboBox1.SelectedIndex = 0;
                typeComboBox.SelectedIndex = 0;
                MdlOptionsManagement.getNotifications(Conversions.ToString(actionComboBox1.SelectedItem), Conversions.ToString(typeComboBox.SelectedItem), this);
                firstLoad = false;
            }

            if (MdlOptionsManagement.canSeeMessages == false)
            {
                messageEmployeeeTableLayoutPanel.Hide();
            }
            else
            {
                messageEmployeeeTableLayoutPanel.Show();
            }
        }

        private void FrmHomeScreen_Resize(object sender, EventArgs e)
        {
            {
                var withBlock = NotificationCenter1;
                withBlock.Left = Width - (withBlock.Width + 20);
                withBlock.Top = Height - Height;
                withBlock.Height = Height - 40;
                withBlock.SetNotificationIcon((Bitmap)panelmageList.Images[0]);
            }
        }

        public bool firstLoad = true;

        private void typeMessageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MdlOptionsManagement.getNotifications(Conversions.ToString(actionComboBox1.SelectedItem), Conversions.ToString(typeComboBox.SelectedItem), this);
        }

        private void actiongeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                MdlOptionsManagement.getNotifications(Conversions.ToString(actionComboBox1.SelectedItem), Conversions.ToString(typeComboBox.SelectedItem), this);
            }
        }

        public bool isNewNotification = false;

        private void NotificationCenter1_FetchNewNotifications()
        {
            // NotificationCenter1.NotificationAlert = True
            isNewNotification = true;
            MdlOptionsManagement.getNotifications(Conversions.ToString(actionComboBox1.SelectedItem), Conversions.ToString(typeComboBox.SelectedItem), this);
            isNewNotification = false;
        }

        // if button in notification centre is clicked...
        private void NotificationCenter1_NotifyButtonPressed(char ButtonValue, int NotifyRecord, string NotifyType, string NotifyDetails)
        {
            var db = new DatabaseHelper();
            if (ButtonValue.Equals('\u0005'))
            {
                db.saveActionTaken(My.MyProject.Forms.FrmLoginWindow._userID, NotifyRecord, "Dismissed", "N/A");
            }
            else if (ButtonValue.Equals('\u0006'))
            {
                My.MyProject.Forms.FrmMessage.Show();
            }
            else if (ButtonValue.Equals('\u0004'))
            {
                db.saveActionTaken(My.MyProject.Forms.FrmLoginWindow._userID, NotifyRecord, "Solved", "N/A");
            }
            else if (ButtonValue.Equals('\u0001'))
            {
                db.saveActionTaken(My.MyProject.Forms.FrmLoginWindow._userID, NotifyRecord, "Approved", "N/A");
            }
            else if (ButtonValue.Equals('\u0002'))
            {
                db.saveActionTaken(My.MyProject.Forms.FrmLoginWindow._userID, NotifyRecord, "Declined", "N/A");
            }
            else if (ButtonValue.Equals('\a'))
            {
                notificationID = NotifyRecord;
                MdlOptionsManagement.getNotificationDetail(NotifyRecord);
                My.MyProject.Forms.FrmActionDetails.Show();
            }
            else if (ButtonValue.Equals('\t')) // change adress
            {
                string newAddress = "";
                newAddress = NotifyDetails.Substring(100, NotifyDetails.Length - 101);
                newAddress = newAddress.Replace("New Address:", "~");
                newAddress = newAddress.Replace(". Old Address:", "~");
                newAddress = newAddress.Split(')')[0];
                newAddress = Strings.Trim(newAddress.Split('~')[1]);
                My.MyProject.Forms.FrmdeleteWarning.noBunifuButton.Text = "OK";
                My.MyProject.Forms.FrmdeleteWarning.confirmationPanel.Hide();
                My.MyProject.Forms.FrmdeleteWarning.ButtonPanel.Show();
                My.MyProject.Forms.FrmdeleteWarning.imageWarningLabel.ImageIndex = 1;
                My.MyProject.Forms.FrmdeleteWarning.mainMessageLabel.Text = Conversions.ToString(db.updatePersonalInfo(NotifyRecord, "Address", newAddress));
                db.saveActionTaken(My.MyProject.Forms.FrmLoginWindow._userID, NotifyRecord, "Solved", "N/A");
                My.MyProject.Forms.FrmdeleteWarning.Show();
            }
        }

        private void NotificationCenter1_ExpandNotifications(bool Expand)
        {
            if (Expand)
            {
                StatasContainerFlowLayoutPanel.SendToBack();
            }
            else
            {
                StatasContainerFlowLayoutPanel.BringToFront();
            }
        }

        public string typeOfReminder;

        private void Label15_Click(object sender, EventArgs e)
        {
            typeOfReminder = "Birthday";
            My.MyProject.Forms.FrmReminderDetails.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            typeOfReminder = "Probation";
            My.MyProject.Forms.FrmReminderDetails.Show();
        }

        private void messageEmployeeLabel_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmMessage.Show();
        }
    }
}