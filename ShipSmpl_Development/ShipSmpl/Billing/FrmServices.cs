using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    public partial class FrmServices
    {
        public FrmServices()
        {
            InitializeComponent();
            _servicesDataGridView.Name = "servicesDataGridView";
            _servTypeDropdown.Name = "servTypeDropdown";
            _editButton.Name = "editButton";
            _deleteButton.Name = "deleteButton";
            _truckNameDropdown.Name = "truckNameDropdown";
            _addButton.Name = "addButton";
            _closeFlatButton.Name = "closeFlatButton";
            _fromDropdown.Name = "fromDropdown";
            _toDropdown.Name = "toDropdown";
            _BunifuButton1.Name = "BunifuButton1";
        }

        private DatabaseHelper db = new DatabaseHelper();
        private DatabaseHelperCeres dbCeres = new DatabaseHelperCeres();
        public DataTable companiesDT = new DataTable();
        private bool firstLoad;

        private void FrmServices_Load(object sender, EventArgs e)
        {
            var companiesDT = new DataTable();
            companiesDT = dbCeres.getTableInfo("VW_CompanyCompanyType", "*", "order by CompanyName");
            firstLoad = true;
            truckNameDropdown.Items.Clear();
            fromDropdown.Items.Clear();
            toDropdown.Items.Clear();
            fromDropdown.Items.Add("All");
            toDropdown.Items.Add("All");
            foreach (DataRow company in companiesDT.Rows)
            {
                if (company["DescCompanyType"].Equals("Trucking Company"))
                {
                    truckNameDropdown.Items.Add("(" + Strings.Trim(Conversions.ToString(company["CompanyCode"])) + ") " + Strings.Trim(Conversions.ToString(company["CompanyName"])).ToUpper());
                }
                else if (company["DescCompanyType"].Equals("Terminal"))
                {
                    fromDropdown.Items.Add("(" + Strings.Trim(Conversions.ToString(company["CompanyCode"])) + ") " + Strings.Trim(Conversions.ToString(company["CompanyName"])).ToUpper());
                    toDropdown.Items.Add("(" + Strings.Trim(Conversions.ToString(company["CompanyCode"])) + ") " + Strings.Trim(Conversions.ToString(company["CompanyName"])).ToUpper());
                }
            }

            truckNameDropdown.Items.Add("All");
            truckNameDropdown.SelectedIndex = 0;
            servTypeDropdown.SelectedIndex = 0;
            fromDropdown.SelectedIndex = 0;
            toDropdown.SelectedIndex = 0;
            truckNameDropdown.DropDownHeight = Height - 200;
            firstLoad = false;
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAddEditServices.typeOfUpdate = "new";
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditServices, this);
        }

        public void populateServices()
        {
            servicesDataGridView.Rows.Clear();
            string condition = "";
            string compName = "";
            string tableName = "";
            string fromLoc;
            string toLoc;
            if (truckNameDropdown.SelectedItem.Equals("All"))
            {
                compName = " ";
            }
            else
            {
                compName = Conversions.ToString(Operators.AddObject(Operators.AddObject("and Trucking_Company ='", truckNameDropdown.SelectedItem), "' "));
            }

            if (fromDropdown.SelectedItem.Equals("All"))
            {
                fromLoc = " ";
            }
            else
            {
                fromLoc = Conversions.ToString(Operators.AddObject(Operators.AddObject("and [From] = '", fromDropdown.SelectedItem), "'"));
            }

            if (toDropdown.SelectedItem.Equals("All"))
            {
                toLoc = " ";
            }
            else
            {
                toLoc = Conversions.ToString(Operators.AddObject(Operators.AddObject("and [To] = '", toDropdown.SelectedItem), "'"));
            }

            tableName = Conversions.ToString(Operators.AddObject(servTypeDropdown.SelectedItem, "_Rate"));
            if (servTypeDropdown.SelectedItem.Equals("Drayage"))
            {
                condition = "where ID > 0 " + compName + fromLoc + toLoc + " order by [From], [To]";
            }
            else if (servTypeDropdown.SelectedItem.Equals("FSC"))
            {
                condition = " order by From_Date";
            }
            else
            {
                condition = " order by Terminal";
            }

            string servRate = "";
            string toDateStr;
            foreach (DataRow service in db.getTableInfo(tableName, "*", condition).Rows)
            {
                if (servTypeDropdown.SelectedItem.Equals("Drayage"))
                {
                    decimal rate = Conversions.ToDecimal(service["Rate"]);
                    decimal rvFee = 0m;
                    var dueTime = DateAndTime.Now;
                    string dueTimeStr = "";
                    servicesDataGridView.Rows.Add(service["ID"], service["From"], service["To"], service["Rate_Type"], "$" + rate.ToString("F2"), "$" + rvFee.ToString("F2"), dueTimeStr);
                }
                else if (servTypeDropdown.SelectedItem.Equals("FSC"))
                {
                    DateTime fromDate = Conversions.ToDate(service["From_Date"]);
                    if (!Information.IsDBNull(service["To_Date"]))
                    {
                        DateTime toDate = Conversions.ToDate(service["To_Date"]);
                        toDateStr = toDate.ToShortDateString();
                    }
                    else
                    {
                        toDateStr = "";
                    }

                    servicesDataGridView.Rows.Add(service["ID"], fromDate.ToString("MMM-dd-yyyy"), toDateStr, service["Rate"].ToString() + "%");
                }
                else
                {
                    decimal wkDayrateDay;
                    decimal wkDayrateNight;
                    decimal wkEndrateDay;
                    decimal wkEndrateNight;
                    TimeSpan wkDayCutOff;
                    TimeSpan wkEndCutOff;
                    string wkDayCutOffStr;
                    string wkEndCutOffStr;
                    DateTime fromDate;
                    DateTime toDate;
                    if (!Information.IsDBNull(service["WkDaydCutOffTime"]))
                    {
                        wkDayCutOff = (TimeSpan)service["WkDaydCutOffTime"];
                        wkDayCutOffStr = wkDayCutOff.ToString();
                    }
                    else
                    {
                        wkDayCutOffStr = "";
                    }

                    if (!Information.IsDBNull(service["WkEndsCutOffTime"]))
                    {
                        wkEndCutOff = (TimeSpan)service["WkEndsCutOffTime"];
                        wkEndCutOffStr = wkEndCutOff.ToString();
                    }
                    else
                    {
                        wkEndCutOffStr = "";
                    }

                    wkDayrateDay = Conversions.ToDecimal(service["WkDaysDayRate"]);
                    wkDayrateNight = Conversions.ToDecimal(service["WkDaysNightRate"]);
                    wkEndrateDay = Conversions.ToDecimal(service["WkEndsDayRate"]);
                    wkEndrateNight = Conversions.ToDecimal(service["WkEndsNightRate"]);
                    fromDate = Conversions.ToDate(service["FromDate"]);
                    if (!Information.IsDBNull(service["toDate"]))
                    {
                        toDate = Conversions.ToDate(service["To_Date"]);
                        toDateStr = toDate.ToString("dd-MMM-yyyy");
                    }
                    else
                    {
                        toDateStr = "";
                    }

                    servicesDataGridView.Rows.Add(service["ID"], service["RateType"], wkDayCutOffStr, "$" + wkDayrateDay.ToString("F2"), "$" + wkDayrateNight.ToString("F2"), wkEndCutOffStr, "$" + wkEndrateDay.ToString("F2"), "$" + wkEndrateNight.ToString("F2"), service["Terminal"], fromDate.ToString("dd-MMM-yyyy"), toDateStr);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedRow = servicesDataGridView.CurrentRow.Index;
            {
                var withBlock = My.MyProject.Forms.FrmdeleteWarning;
                withBlock.yesBunifuButton.Enabled = true;
                withBlock.ButtonPanel.Show();
                withBlock.confirmationPanel.Hide();
                withBlock.mainMessageLabel.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject("Are you sure you want to delete the service: '", servicesDataGridView.Rows[selectedRow].Cells[1].Value), "'? This can not be undone."));
            }

            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmdeleteWarning, this);
            if (My.MyProject.Forms.FrmdeleteWarning.buttonPressed.Equals("Yes"))
            {
                db.deleteRows("Drayage_Rate", "where ID = " + servicesDataGridView.Rows[selectedRow].Cells[0].Value.ToString());
            }

            if (!firstLoad)
            {
                populateServices();
            }
        }

        private void servTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            servicesDataGridView.Rows.Clear();
            servicesDataGridView.Columns.Clear();
            if (servTypeDropdown.SelectedItem.Equals("Drayage"))
            {
                servicesDataGridView.Columns.Add("ID", "ID");
                servicesDataGridView.Columns.Add("From", "From");
                servicesDataGridView.Columns.Add("To", "To");
                servicesDataGridView.Columns.Add("Rate_Type", "Rate Type");
                servicesDataGridView.Columns.Add("Rate", "Rate");
                servicesDataGridView.Columns.Add("RV Fee", "RV Fee");
                servicesDataGridView.Columns.Add("Due Time", "Due Time");
                servicesDataGridView.Columns["ID"].Visible = false;
                servicesDataGridView.Columns["From"].Width = 250;
                servicesDataGridView.Columns["To"].Width = 250;
                fromDropdown.Enabled = true;
                toDropdown.Enabled = true;
            }
            else if (servTypeDropdown.SelectedItem.Equals("FSC"))
            {
                servicesDataGridView.Columns.Add("ID", "ID");
                servicesDataGridView.Columns.Add("From Date", "From Date");
                servicesDataGridView.Columns.Add("To Date", "To Date");
                servicesDataGridView.Columns.Add("Rate", "Rate");
                servicesDataGridView.Columns["ID"].Visible = false;
                fromDropdown.Enabled = false;
                toDropdown.Enabled = false;
            }
            else
            {
                servicesDataGridView.Columns.Add("ID", "ID");
                servicesDataGridView.Columns.Add("Rate_Type", "Type");
                servicesDataGridView.Columns.Add("WK_Day_Cut_off", "WKDay Cut Off");
                servicesDataGridView.Columns.Add("WK_Day_Day_Rate", "WKDay Day Rate");
                servicesDataGridView.Columns.Add("WK_Day_Night_Rate", "WKDay Night Rate");
                servicesDataGridView.Columns.Add("WK_End_Cut_off", "WKEnd Cut Off");
                servicesDataGridView.Columns.Add("WK_End_Day_Rate", "WKEnd Day Rate");
                servicesDataGridView.Columns.Add("WK_End_Night_Rate", "WKEnd Night Rate");
                servicesDataGridView.Columns.Add("Terminal", "Terminal");
                servicesDataGridView.Columns.Add("From", "From");
                servicesDataGridView.Columns.Add("To", "To");
                servicesDataGridView.Columns["ID"].Visible = false;
                servicesDataGridView.Columns["Rate_Type"].Width = 60;
                servicesDataGridView.Columns["WK_Day_Cut_off"].Width = 150;
                servicesDataGridView.Columns["WK_End_Cut_off"].Width = 150;
                servicesDataGridView.Columns["To"].Width = 100;
                servicesDataGridView.Columns["From"].Width = 100;
                fromDropdown.Enabled = false;
                toDropdown.Enabled = false;
            }

            if (!firstLoad)
            {
                populateServices();
            }
        }

        private void compNameDropdown6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                populateServices();
            }
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAddEditServices.typeOfUpdate = "update";
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditServices, this);
        }

        private void fromDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                populateServices();
            }
        }

        private void toDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                populateServices();
            }
        }

        private void BunifuDataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewCell serviceName;
            try
            {
                for (int i = 0, loopTo = servicesDataGridView.Rows.Count - 1; i <= loopTo; i++)
                {
                    if (servTypeDropdown.SelectedIndex == 0)
                    {
                        serviceName = servicesDataGridView.Rows[i].Cells[3];
                    }
                    else
                    {
                        serviceName = servicesDataGridView.Rows[i].Cells[1];
                    }

                    if (servTypeDropdown.SelectedIndex == 0)
                    {
                        if (serviceName.Value.Equals("Single Empty"))
                        {
                            serviceName.Style.BackColor = Color.Goldenrod;
                            serviceName.Style.SelectionBackColor = Color.Goldenrod;
                        }
                        else if (serviceName.Value.Equals("Single Load"))
                        {
                            serviceName.Style.BackColor = Color.DarkOliveGreen;
                            serviceName.Style.SelectionBackColor = Color.DarkOliveGreen;
                        }
                        else if (serviceName.Value.Equals("Multiple Empty"))
                        {
                            serviceName.Style.BackColor = Color.DarkOrange;
                            serviceName.Style.SelectionBackColor = Color.DarkOrange;
                        }
                        else if (serviceName.Value.Equals("Multiple Load"))
                        {
                            serviceName.Style.BackColor = Color.Olive;
                            serviceName.Style.SelectionBackColor = Color.Olive;
                        }

                        serviceName.Style.ForeColor = Color.White;
                    }
                    else
                    {
                        serviceName.Style.ForeColor = Color.Black;
                    }
                }
            }
            catch
            {
            }
        }

        private void BunifuButton1_Click_1(object sender, EventArgs e)
        {
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmEditDrayage, My.MyProject.Forms.FrmParentScreen);
        }
    }
}