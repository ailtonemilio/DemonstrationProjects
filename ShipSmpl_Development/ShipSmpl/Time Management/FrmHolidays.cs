using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmHolidays
    {
        public FrmHolidays()
        {
            InitializeComponent();
            _Button1.Name = "Button1";
            _ListView1.Name = "ListView1";
            _saveTouchButton.Name = "saveTouchButton";
            _deleteTouchButton.Name = "deleteTouchButton";
            _holidayYearComboBox.Name = "holidayYearComboBox";
            _yearComboBox.Name = "yearComboBox";
            _showEmployeesComboBox.Name = "showEmployeesComboBox";
            _CheckBox1.Name = "CheckBox1";
            _Button2.Name = "Button2";
            _ComboBox1.Name = "ComboBox1";
        }

        private DatabaseHelper db = new DatabaseHelper();
        private string condition;
        private bool firstLoad = true;

        private void FrmHolidays_Load(object sender, EventArgs e)
        {
            DateTimePicker1.Value = DateAndTime.Today.Date;
            populatComboBoxes();
            populatHolidayListView();
            ComboBox1.SelectedIndex = 0;
            showEmployeesComboBox.SelectedIndex = 0;
            firstLoad = false;
        }

        private void saveTouchButton_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                TextBox1.Text = TextBox1.Text.Replace("'", "`");
                db.createHoliday(TextBox1.Text, DateTimePicker1.Value.Date);
                populatComboBoxes();
                populatHolidayListView();
                Label5.Text = "";
            }
            else
            {
                Label5.Text = "Missing information";
            }

            TextBox1.Text = "";
        }

        private void populatComboBoxes()
        {
            if (firstLoad == true)
            {
                if (yearComboBox.Items.Count == 0)
                {
                    condition = "";
                }
                else
                {
                    condition = Conversions.ToString(Operators.AddObject("where year(Holiday_Date) = ", yearComboBox.SelectedItem));
                    yearComboBox.Items.Clear();
                    holidayYearComboBox.Items.Clear();
                }

                DateTime year;
                foreach (DataRow holidayRow in db.getHolidays(condition).Rows)
                {
                    ComboBox1.Items.Add(holidayRow["Holiday_Name"]);
                    year = Convert.ToDateTime(holidayRow["Holiday_Date"]);
                    if (!yearComboBox.Items.Contains(year.Year.ToString()))
                    {
                        yearComboBox.Items.Add(year.Year.ToString());
                    }

                    if (!holidayYearComboBox.Items.Contains(year.Year.ToString()))
                    {
                        holidayYearComboBox.Items.Add(year.Year.ToString());
                    }
                }

                yearComboBox.SelectedIndex = 0;
                holidayYearComboBox.SelectedIndex = 0;
            }
            else
            {
                if (yearComboBox.Items.Count == 0)
                {
                    condition = "";
                }
                else
                {
                    condition = Conversions.ToString(Operators.AddObject("where year(Holiday_Date) = ", yearComboBox.SelectedItem));
                }

                ComboBox1.Items.Clear();
                foreach (DataRow holidayRow in (IEnumerable)db.getHolidays(condition).Rows)
                    ComboBox1.Items.Add(holidayRow["Holiday_Name"]);
            }
        }

        private void populatHolidayListView()
        {
            ListView1.Items.Clear();
            condition = Conversions.ToString(Operators.AddObject("where year(Holiday_Date) = ", holidayYearComboBox.SelectedItem));
            foreach (DataRow holidayRow in (IEnumerable)db.getHolidays(condition).Rows)
            {
                var dateH = Convert.ToDateTime(holidayRow["Holiday_Date"]);
                ListView1.Items.Add(new ListViewItem(new[] { Conversions.ToString(holidayRow["Holiday_Name"]), dateH.Date.ToString("MMM dd, yyyy"), Conversions.ToString(holidayRow["ID"]) }));
            }

            ListView1.Update();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListView1.FocusedItem.Index > -1)
            {
                deleteTouchButton.Visible = true;
            }
        }

        private void deleteTouchButton_Load(object sender, EventArgs e)
        {
            db.deleteHoliday(ListView1.Items[ListView1.FocusedItem.Index].SubItems[2].Text.ToString());
            populatHolidayListView();
            deleteTouchButton.Visible = false;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                qualifiedEmployeesListView.Items.OfType<ListViewItem>().All(c =>
                {
                    c.Checked = true;
                    return true;
                });
            }
            else
            {
                qualifiedEmployeesListView.Items.OfType<ListViewItem>().All(c =>
                {
                    c.Checked = false;
                    return true;
                });
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string employeeID;
            var selectedDate = Convert.ToDateTime(db.getHolidayDate(Conversions.ToString(ComboBox1.SelectedItem), Conversions.ToString(yearComboBox.SelectedItem)));
            datePickedLabel.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(ComboBox1.SelectedItem, Environment.NewLine), selectedDate.Date.ToString("MMM dd, yyyy")));
            var pickedDate = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 8, 0, 0, 0, 0);
            foreach (ListView employee in qualifiedEmployeesListView.CheckedItems)
            {
                employeeID = employee.Items[4].Text;
                db._ID = Convert.ToInt32(employee.Items[4].Text);
                My.MyProject.Forms.FrmAddNewEntry.siteLocationComboBox.SelectedItem = "Lindsey";
                string st = Conversions.ToString(employee.Items[3].Text);
                if (employee.Items[3].Text.Equals("Salary"))
                {
                    db.createPunch(pickedDate.ToString("yyyy-MM-dd HH:mm"), pickedDate.AddHours(8d).ToString("yyyy-MM-dd HH:mm"), "S");
                }
                else
                {
                    db.createPunch(pickedDate.ToString("yyyy-MM-dd HH:mm"), pickedDate.AddHours(8d).ToString("yyyy-MM-dd HH:mm"), "H");
                }

                My.MyProject.Forms.FrmAddNewEntry.reasonNewEntryComboBox.SelectedItem = "Other";
                My.MyProject.Forms.FrmAddNewEntry.RichTextBox1.Text = "Holiday";
                My.MyProject.Forms.FrmAddNewEntry.newEntrymodifiedByTextBox.Text = My.MyProject.Forms.FrmLoginWindow._employeeName;
                db.saveModification("new", 3);
                object year;
                condition = Conversions.ToString(Operators.AddObject(Operators.AddObject("where year(Holiday_Date) = " + holidayYearComboBox.SelectedItem.ToString() + " And Holiday_Name = '", ComboBox1.SelectedItem), "'"));
                int holidayId = Conversions.ToInteger(db.getHolidays(condition).Rows[0]["ID"]);
                foreach (DataRow holidayRow in (IEnumerable)db.getHolidays(condition).Rows)
                {
                    ComboBox1.Items.Add(holidayRow["Holiday_Name"]);
                    year = Convert.ToDateTime(holidayRow["Holiday_Date"]);
                    db.saveHolidayPunch(holidayId);
                }
            }

            updatequalifiedEmployeesList();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                updatequalifiedEmployeesList();
            }
        }

        private void showEmployeesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                updatequalifiedEmployeesList();
            }
        }

        private void updatequalifiedEmployeesList()
        {
            qualifiedEmployeesListView.Items.Clear();
            var selectedDate = Convert.ToDateTime(db.getHolidayDate(Conversions.ToString(ComboBox1.SelectedItem), Conversions.ToString(yearComboBox.SelectedItem)));
            datePickedLabel.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(ComboBox1.SelectedItem, Environment.NewLine), selectedDate.Date.ToString("MMM dd, yyyy")));
            string pickedDate = selectedDate.Date.ToString("yyyy-MM-dd");
            selectedDate = selectedDate.AddDays(-30);
            int count = 0;
            if (showEmployeesComboBox.SelectedIndex == 0)
            {
                condition = "and daysWorked >=15 ";
            }
            else
            {
                condition = "";
            }

            foreach (DataRow employee in (IEnumerable)db.getQualifiedEmployees(selectedDate.Date.ToString("yyyy-MM-dd"), pickedDate, condition).Rows)
            {
                qualifiedEmployeesListView.Items.Add(new ListViewItem(new[] { Conversions.ToString(employee["Alias"]), Conversions.ToString(employee["Last_Name"]), Conversions.ToString(employee["daysWorked"]), Conversions.ToString(employee["Pay_Method"]), Conversions.ToString(employee["ID"]) }));
                db._ID = Conversions.ToInteger(employee["ID"]);
                if (db.employeeAlreadyGotHolPunch(pickedDate))
                {
                    if (showEmployeesComboBox.SelectedIndex == 0)
                    {
                        qualifiedEmployeesListView.Items[count].Remove();
                        count -= 1;
                    }
                    else
                    {
                        qualifiedEmployeesListView.Items[count].UseItemStyleForSubItems = false;
                        qualifiedEmployeesListView.Items[count].BackColor = Color.Orange;
                    }
                }

                count += 1;
            }

            qualifiedEmployeesListView.Update();
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                populatComboBoxes();
                ComboBox1.SelectedIndex = 0;
            }
        }

        private void holidayYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                populatHolidayListView();
            }
        }
    }
}