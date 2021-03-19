using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using ModelLayer;
using System;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmLoginWindow
    {
        public FrmLoginWindow()
        {
            InitializeComponent();
            _loginButton.Name = "loginButton";
            _BunifuButton2.Name = "BunifuButton2";
            _usernameTextBox.Name = "usernameTextBox";
            _passwordTextBox.Name = "passwordTextBox";
        }

        public string _employeeName;
        public int _userID;
        public string payMethod;
        private DatabaseHelper db = new DatabaseHelper();

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text) | string.IsNullOrEmpty(passwordTextBox.Text))
            {
                warningLabel.Text = "Fields cannot be empty";
            }
            else
            {
                db.checkLogin(Strings.Trim(usernameTextBox.Text), Strings.Trim(passwordTextBox.Text));
                if (db._userExists)
                {
                    var employee = EmployeeService.GetById(db._ID);
                    db.getClearanceLevel();
                    _employeeName = (employee.First_Name + " " + employee.Last_Name).ToUpper();
                    payMethod = employee.Pay_Method;
                    warningLabel.Text = "";
                    _userID = employee.ID;
                    Hide();
                    MdlOptionsManagement.checkProbationReminders();
                    MdlOptionsManagement.checkHolidayReminders();
                    MdlOptionsManagement.checkBlockedContainers();
                    My.MyProject.Forms.FrmParentScreen.Show();
                    My.MyProject.Forms.FrmParentScreen.employeeNameLabel.Text = _employeeName;
                    VesselVoyageService.UpdateIsActiveDateLRDLessThanYesterday();
                    // Dim newMstream As New System.IO.MemoryStream(CType(db.getEmployeePicture(_userID), Byte()))
                    // 'Create a new image from the bytes from the memory
                    // Dim ImageFromDB As New Bitmap(newMstream)
                    var ftpMdl = new MdlFtp();
                    var ImageFromDB = ftpMdl.GetFTPImage(employee.EmployeePicturePath);
                    My.MyProject.Forms.FrmParentScreen.profileShapedPictureBox1.Image = ImageFromDB;
                }
                else
                {
                    warningLabel.Text = "Wrong username or password";
                }
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        private void FrmLoginWindow_Load(object sender, EventArgs e)
        {
            // Vania Login
            //Employees employee = EmployeeService.GetById(124);

            // Emilio Login
            //Employees employee = EmployeeService.GetById(163);

            //_employeeName = (employee.First_Name + " " + employee.Last_Name).ToUpper();
            //payMethod = employee.Pay_Method;
            //warningLabel.Text = "";
            //_userID = employee.ID;

            //My.MyProject.Forms.FrmParentScreen.Show();
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLoginWindow_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}