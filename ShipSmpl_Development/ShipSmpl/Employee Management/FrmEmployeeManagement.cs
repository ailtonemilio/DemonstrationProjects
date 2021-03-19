using Bunifu.ToggleSwitch;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmEmployeeManagement
    {
        public FrmEmployeeManagement()
        {
            InitializeComponent();
            _printCardButton.Name = "printCardButton";
            _searchBunifuTextBox1.Name = "searchBunifuTextBox1";
            _addEntryButton.Name = "addEntryButton";
            _BunifuToggleSwitch1.Name = "BunifuToggleSwitch1";
            _clearanceButton.Name = "clearanceButton";
            _modifyButton.Name = "modifyButton";
            _terminateButton.Name = "terminateButton";
            _cardIDButton.Name = "cardIDButton";
            _createUsernameButton.Name = "createUsernameButton";
            _deleteButton.Name = "deleteButton";
            _BunifuDataGridView1.Name = "BunifuDataGridView1";
        }

        private object _cardID { get; set; } = "";

        private DatabaseHelper db = new DatabaseHelper();
        private string _employeeFirstName;
        private string _employeeLasttName;
        private int _employeeID;
        private string _alias;
        private int selectedRow = 0;

        private void Button1_Click_1(object sender, EventArgs e)
        {
            MdlLoadingSetting.adjustScreen(My.MyProject.Forms.FrmParentScreen.PanelWindows, My.MyProject.Forms.FrmParentScreen.menuIsExpanded);
            MdlLoadingSetting.adjustScreen(My.MyProject.Forms.FrmAddNewEmployee, My.MyProject.Forms.FrmParentScreen.menuIsExpanded);
            if (My.MyProject.Forms.FrmParentScreen.FormsTab1.FormExists(My.MyProject.Forms.FrmAddNewEmployee.Name))
            {
                MdlLoadingSetting.waitForm.Close();
                return;
            }
            else
            {
                My.MyProject.Forms.FrmParentScreen.AddFormToPanel(My.MyProject.Forms.FrmAddNewEmployee);
                My.MyProject.Forms.FrmParentScreen.FormsTab1.AddFormTab("Edit Employee", My.MyProject.Forms.FrmAddNewEmployee.Name);
                MdlLoadingSetting.waitForm.Close();
            }

            MdlModifyData.fillTextBoxes();
            My.MyProject.Forms.FrmAddNewEmployee.personalInfoButton.Text = "Update and Continue";
            My.MyProject.Forms.FrmAddNewEmployee.skillsCertificationButton.Text = "Update and Continue";
            My.MyProject.Forms.FrmAddNewEmployee.newEmployeeTabControl.SelectTab(0);
        }

        private void Button2_Click_2(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmSuspention, this);
        }

        public string employeeStatus = "";
        private bool firstLoad = true;

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            MdlOptionsManagement.getEmployeeManagementAllowedFunctionalities();
            MdlControllerModifier.clearFields();
            MdlEmpManagement.populateEmployeeList(BunifuDataGridView1, employeeStatus);
            firstLoad = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedRow = BunifuDataGridView1.CurrentCell.RowIndex;
            string firstName = Conversions.ToString(BunifuDataGridView1.Rows[selectedRow].Cells[1].Value);
            string lastName = Conversions.ToString(BunifuDataGridView1.Rows[selectedRow].Cells[2].Value);
            employeeID = Conversions.ToInteger(BunifuDataGridView1.Rows[selectedRow].Cells[6].Value);
            int result = (int)MessageBox.Show("Confirm deletion of " + firstName + " " + lastName + "?", "Delete employee", MessageBoxButtons.YesNo);
            if (result == (int)DialogResult.Yes)
            {
                db.deleteEmployee(employeeID);
                MdlEmpManagement.populateEmployeeList(BunifuDataGridView1, employeeStatus);
            }
        }

        private void createUsernameButton_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmCreateUsernameAndPassword, ParentForm);
        }

        private void clearanceButton_Click(object sender, EventArgs e)
        {
            selectedRow = BunifuDataGridView1.CurrentCell.RowIndex;
            string firstName = Conversions.ToString(BunifuDataGridView1.Rows[selectedRow].Cells[1].Value);
            string lastName = Conversions.ToString(BunifuDataGridView1.Rows[selectedRow].Cells[2].Value);
            My.MyProject.Forms.FrmClearance.Label1.Text = "Check all functionalities you wish to grant to " + firstName + " " + lastName;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmClearance, this);
        }

        private void printCardButton_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmPrintCard.Show();
        }

        private void BunifuDataGridView1_CellContentClick(object sender, EventArgs e)
        {
            selectedRow = BunifuDataGridView1.CurrentCell.RowIndex;
            employeeID = Conversions.ToInteger(BunifuDataGridView1.Rows[selectedRow].Cells[6].Value);
            if (Conversions.ToBoolean(MdlOptionsManagement.allowedToSeeDetails))
            {
                MdlModifyData.fillEmployeeDetails(employeeID);
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEmployeeDetails, this);
            }
            else
            {
                My.MyProject.Forms.FrmdeleteWarning.mainMessageLabel.Text = "You are not allowed to see employees personal information";
                My.MyProject.Forms.FrmdeleteWarning.ButtonPanel.Visible = true;
                My.MyProject.Forms.FrmdeleteWarning.Show();
            }
        }

        private int employeeID;

        private void BunifuToggleSwitch1_OnValuechange(object sender, EventArgs e)
        {
            BunifuToggleSwitch b = (BunifuToggleSwitch)sender;
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(b.Value, true, false)))
            {
                employeeStatus = "";
            }
            else
            {
                employeeStatus = "where status = 'Active'";
            }

            if (firstLoad == false)
            {
                MdlEmpManagement.populateEmployeeList(BunifuDataGridView1, employeeStatus);
            }
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.adjustScreen(My.MyProject.Forms.FrmParentScreen.PanelWindows, My.MyProject.Forms.FrmParentScreen.menuIsExpanded);
            MdlLoadingSetting.adjustScreen(My.MyProject.Forms.FrmAddNewEmployee, My.MyProject.Forms.FrmParentScreen.menuIsExpanded);
            if (My.MyProject.Forms.FrmParentScreen.FormsTab1.FormExists(My.MyProject.Forms.FrmAddNewEmployee.Name))
            {
                MdlLoadingSetting.waitForm.Close();
                return;
            }
            else
            {
                My.MyProject.Forms.FrmParentScreen.AddFormToPanel(My.MyProject.Forms.FrmAddNewEmployee);
                My.MyProject.Forms.FrmParentScreen.FormsTab1.AddFormTab("Add Employee", My.MyProject.Forms.FrmAddNewEmployee.Name);
                MdlLoadingSetting.waitForm.Close();
            }
        }

        private void cardIDButton_Click(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmCardAssignment, this);
        }

        private void findText()
        {
            for (int i = 0, loopTo = BunifuDataGridView1.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.OrObject(BunifuDataGridView1.Rows[i].Cells[0].Value.ToString().Contains(searchBunifuTextBox1.Text.ToUpper()), BunifuDataGridView1.Rows[i].Cells[1].Value.ToString().Contains(searchBunifuTextBox1.Text.ToUpper()))))
                {
                    // cell.Style.BackColor = Color.Yellow

                    BunifuDataGridView1.CurrentCell = BunifuDataGridView1.Rows[i].Cells[0];
                    return;
                }
            }
        }

        private void searchBunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            findText();
        }
    }
}