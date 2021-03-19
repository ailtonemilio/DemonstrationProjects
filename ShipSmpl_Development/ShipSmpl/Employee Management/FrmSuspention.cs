using Bunifu.UI.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;

namespace ShipSmpl
{
    public partial class FrmSuspention
    {
        public FrmSuspention()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _Label7.Name = "Label7";
            _cancelButton.Name = "cancelButton";
            _saveButton.Name = "saveButton";
        }

        private DatabaseHelper db = new DatabaseHelper();
        private int selectedRow = 0;
        private BunifuDataGridView employeDataGridView;
        private int employeeID = 0;

        private void FrmSuspention_Load(object sender, EventArgs e)
        {
            employeDataGridView = My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1;
            fromDateTimePicker1.Value = DateAndTime.Now;
            reinstateDateTimePicker3.Value = DateAndTime.Now;
            terminationDateTimePicker.Value = DateAndTime.Now;
            selectedRow = employeDataGridView.CurrentRow.Index;
            string firstName = Conversions.ToString(employeDataGridView.Rows[selectedRow].Cells[1].Value);
            string lastName = Conversions.ToString(employeDataGridView.Rows[selectedRow].Cells[2].Value);
            suspendLabel.Text = "Suspend employee: " + firstName + " " + lastName;
            terminateLabel.Text = "Terminate employee: " + firstName + " " + lastName;
            reinstateLabel.Text = "Reinstate employee: " + firstName + " " + lastName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // if suspend is selected
            selectedRow = employeDataGridView.CurrentRow.Index;
            employeeID = Conversions.ToInteger(employeDataGridView.Rows[selectedRow].Cells[6].Value);
            if (TabControl1.SelectedIndex == 0)
            {
                db.suspendOrTerminateEmployee(employeeID, "Suspension", fromDateTimePicker1.Value.Date, senpensionReasonRichTextBox1.Text);
                db.reinstateEmployee(employeeID, "Suspended");
            }

            // if terminate is selected
            else if (TabControl1.SelectedIndex == 1)
            {
                MdlModifyData.terminateEmployee(terminationDateTimePicker.Value);
                terminationDateTimePicker.Value = DateAndTime.Today.Date;
                db.suspendOrTerminateEmployee(employeeID, "Termination", terminationDateTimePicker.Value.Date, terminationREasonRichTextBox2.Text);
            }

            // if reinstate is selected
            else if (TabControl1.SelectedIndex == 2)
            {
                db.reinstateEmployee(employeeID, "Active");
                db.suspendOrTerminateEmployee(employeeID, "Reinstatement", reinstateDateTimePicker3.Value.Date, reinstateNoteRichTextBox1.Text);
            }

            MdlEmpManagement.populateEmployeeList(My.MyProject.Forms.FrmEmployeeManagement.BunifuDataGridView1, My.MyProject.Forms.FrmEmployeeManagement.employeeStatus);
            Close();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeLabel_MouseHover(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Gray;
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            Close();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
        }
    }
}