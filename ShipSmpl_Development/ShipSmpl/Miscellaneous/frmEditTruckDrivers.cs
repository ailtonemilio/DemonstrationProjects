using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;

namespace ShipSmpl
{
    public partial class frmEditTruckDrivers
    {
        public frmEditTruckDrivers()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _btnCancel.Name = "btnCancel";
            _btnSave.Name = "btnSave";
        }

        public int TruckDriverId;

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditTruckDrivers_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        public void LoadForm()
        {
            if (TruckDriverId == 0)
            {
                tblTruckDriver.Visible = true;
                // tblPassCard.Visible = True
                CompaniesNameBindingSource.DataSource = CompanyService.GetCompaniesDropBoxByType("Drayage Provider", true);
                txtPassID.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtTruckNumber.Text = "";
                ddlTruckCompanie.Text = "";
                lblTitle.Text = "Add New Driver";
                ClearForm(true);
                txtPassID.Select();
            }
            else
            {
                tblTruckDriver.Visible = false;
                // tblPassCard.Visible = False
                var listDriver = TruckDriverService.GetByTruckId(TruckDriverId);
                foreach (TruckDriver item in listDriver)
                {
                    txtFirstName.Text = item.FirstName.TrimEnd();
                    txtLastName.Text = item.LastName.TrimEnd();
                    if (Information.IsNothing(item.SuspendTruckDriver))
                    {
                        ckbSuspend.Checked = false;
                    }
                    else
                    {
                        ckbSuspend.Checked = item.SuspendTruckDriver == true;
                    }

                    txtPassID.Text = item.PortPassId;
                    txtTruckNumber.Text = item.TruckNumber;
                }

                lblTitle.Text = "Update Info Driver";
                ClearForm(false);
            }
        }

        public bool VerifyPortPassId(string PortPass, int TruckDriverId)
        {
            bool isPort = false;
            string PortPassOld = "";
            var L = TruckDriverService.GetByTruckId(TruckDriverId);
            foreach (var item in L)
                PortPassOld = item.PortPassId;
            if ((PortPass ?? "") == (PortPassOld ?? ""))
            {
                isPort = true;
                return isPort;
                return default;
            }

            return isPort;
        }

        private void ClearForm(bool isClear)
        {
            if (isClear == true)
            {
                txtPassID.BackColor = Color.White;
                txtTruckNumber.BackColor = Color.White;
                txtFirstName.BackColor = Color.White;
                txtLastName.BackColor = Color.White;
                ddlTruckCompanie.BackColor = Color.White;
            }
            else
            {
                if (string.IsNullOrEmpty(txtPassID.Text))
                {
                    txtPassID.BackColor = Color.LightCoral;
                }
                else
                {
                    txtPassID.BackColor = Color.White;
                }

                if (string.IsNullOrEmpty(txtTruckNumber.Text))
                {
                    txtTruckNumber.BackColor = Color.LightCoral;
                }
                else
                {
                    txtTruckNumber.BackColor = Color.White;
                }

                if (string.IsNullOrEmpty(txtFirstName.Text))
                {
                    txtFirstName.BackColor = Color.LightCoral;
                }
                else
                {
                    txtFirstName.BackColor = Color.White;
                }

                if (string.IsNullOrEmpty(txtLastName.Text))
                {
                    txtLastName.BackColor = Color.LightCoral;
                }
                else
                {
                    txtLastName.BackColor = Color.White;
                }

                if (tblTruckDriver.Visible == true)
                {
                    if (string.IsNullOrEmpty(ddlTruckCompanie.Text))
                    {
                        ddlTruckCompanie.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        ddlTruckCompanie.BackColor = Color.White;
                    }
                }
            }
        }

        private void Save()
        {
            bool isEmpty = false;
            string PortPassId = "";
            if (TruckDriverId == 0)
            {
                if (string.IsNullOrEmpty(txtPassID.Text))
                {
                    txtPassID.BackColor = Color.LightCoral;
                    isEmpty = true;
                }
                else
                {
                    txtPassID.BackColor = Color.White;
                    PortPassId = txtPassID.Text.Remove(0, 1);
                    PortPassId = PortPassId.Remove(PortPassId.Length - 1, 1);
                }

                if (string.IsNullOrEmpty(txtTruckNumber.Text))
                {
                    txtTruckNumber.BackColor = Color.LightCoral;
                    isEmpty = true;
                }
                else
                {
                    txtTruckNumber.BackColor = Color.White;
                }

                if (string.IsNullOrEmpty(txtFirstName.Text))
                {
                    txtFirstName.BackColor = Color.LightCoral;
                    isEmpty = true;
                }
                else
                {
                    txtFirstName.BackColor = Color.White;
                }

                if (string.IsNullOrEmpty(txtLastName.Text))
                {
                    txtLastName.BackColor = Color.LightCoral;
                    isEmpty = true;
                }
                else
                {
                    txtLastName.BackColor = Color.White;
                }

                if (tblTruckDriver.Visible == true)
                {
                    if (string.IsNullOrEmpty(ddlTruckCompanie.Text))
                    {
                        ddlTruckCompanie.BackColor = Color.LightCoral;
                        isEmpty = true;
                    }
                    else
                    {
                        ddlTruckCompanie.BackColor = Color.White;
                    }
                }

                if (isEmpty == true)
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Check the fields that are empty.", "", this);
                    return;
                }

                if (TruckDriverService.Insert(PortPassId, txtTruckNumber.Text, txtFirstName.Text, txtLastName.Text, ckbSuspend.Checked, Conversions.ToInteger(ddlTruckCompanie.SelectedValue)))
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Message", "Driver Information successfully inserted!", this);
                    EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, TruckDriverService.LastTruckDriverId().ToString(), "INSERT", "Truck Driver", "Insert of truck driver information");
                    My.MyProject.Forms.FrmParentScreen.f.LoadForm();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error", "Error updating driver data! If the problem persists, contact the IT Department.", this);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtFirstName.Text))
                {
                    txtFirstName.BackColor = Color.LightCoral;
                    isEmpty = true;
                }
                else
                {
                    txtFirstName.BackColor = Color.White;
                }

                if (string.IsNullOrEmpty(txtLastName.Text))
                {
                    txtLastName.BackColor = Color.LightCoral;
                    isEmpty = true;
                }
                else
                {
                    txtLastName.BackColor = Color.White;
                }

                if (string.IsNullOrEmpty(txtTruckNumber.Text))
                {
                    txtTruckNumber.BackColor = Color.LightCoral;
                    isEmpty = true;
                }
                else
                {
                    txtTruckNumber.BackColor = Color.White;
                }

                if (string.IsNullOrEmpty(txtPassID.Text))
                {
                    txtPassID.BackColor = Color.LightCoral;
                    isEmpty = true;
                }
                else
                {
                    txtPassID.BackColor = Color.White;
                }

                if (isEmpty == true)
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Check the fields that are empty.", "", this);
                    return;
                }

                if (this.VerifyPortPassId(txtPassID.Text, TruckDriverId))
                {
                    PortPassId = txtPassID.Text;
                }
                else
                {
                    PortPassId = txtPassID.Text.Remove(0, 1);
                    PortPassId = PortPassId.Remove(PortPassId.Length - 1, 1);
                }

                if (TruckDriverService.Update(TruckDriverId, PortPassId, txtTruckNumber.Text, txtFirstName.Text, txtLastName.Text, ckbSuspend.Checked))
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Message", "Driver Information successfully updated!", this);
                    EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, TruckDriverId.ToString(), "UPDATE", "Truck Driver", "Update of truck driver information");
                    My.MyProject.Forms.FrmParentScreen.f.LoadForm();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error", "Error updating driver data! If the problem persists, contact the IT Department.", this);
                }
            }

            Close();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}