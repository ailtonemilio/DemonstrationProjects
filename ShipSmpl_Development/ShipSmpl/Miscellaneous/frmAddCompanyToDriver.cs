using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using ModelLayer.CustomModel;

namespace ShipSmpl
{
    public partial class frmAddCompanyToDriver
    {
        public frmAddCompanyToDriver()
        {
            InitializeComponent();
            _closeLabel.Name = "closeLabel";
            _ckbEdit.Name = "ckbEdit";
            _btnSave.Name = "btnSave";
            _btnDisconnect.Name = "btnDisconnect";
            _btnLink.Name = "btnLink";
            _dgvTruckDriverCompany.Name = "dgvTruckDriverCompany";
        }

        public int DriverId = 0;
        private int TruckDriverCompanyId = 0;
        private List<TruckDriverList> listTruckDriver;
        private List<TruckDriverList> listTruckDriverDropBox;
        private int Col, Index;


        private void frmAddCompanyToDriver_Load(object sender, EventArgs e)
        {
            LoadForm();
            ddlTruckCompany.BackColor = Color.White;
            VerifiCheckBox();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void ckbEdit_Click(object sender, EventArgs e)
        {
            VerifiCheckBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogSave;
            if (FieldIsEmpty())
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Check the empty fields.", "", this);
                return;
            }

            string msg = ReturnMessage(Conversions.ToInteger(ddlTruckCompany.SelectedValue), TruckDriverCompanyId);
            dialogSave = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Are you sure you want to make this change?", msg, My.Resources.Resources.caution, this);
            if (dialogSave == DialogResult.Yes)
            {
                if (TruckDriverCompanyService.Update(TruckDriverCompanyId, DriverId, Conversions.ToInteger(ddlTruckCompany.SelectedValue)))
                {
                    EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, TruckDriverCompanyId.ToString(), "UPDATE", "TRUCK DRIVER COMPANY", msg + "YES");
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Truck Driver information updated successfully!", "", this);
                    LoadDataGridView();
                    My.MyProject.Forms.FrmParentScreen.f.LoadForm();
                    ckbEdit.Checked = false;
                    VerifiCheckBox();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("ERROR", "An error has occurred, please try again. If the error persists, inform the IT department. #3422", this);
                }
            }
            else
            {
                ddlTruckCompany.Text = "";
                ckbEdit.Checked = false;
                btnSave.Enabled = true;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            Connect();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        public string ReturnMessage(int TruckCompanyId, int TruckDriverCompanyId)
        {
            bool chPortPass = false;
            bool chTruckNum = false;
            bool chTruckCom = false;
            string NameCompanyNew = ddlTruckCompany.Text;
            TruckDriverList td = (TruckDriverList)dgvTruckDriverCompany.CurrentRow.DataBoundItem;
            string MSG = "Items that have been changed: ";
            var L = TruckDriverCompanyService.GetById(TruckCompanyId);
            foreach (var item in L)
            {
                if (TruckCompanyId != item.CompanyId == true)
                {
                    MSG += "Company: " + td.CompanyName + " by Company: " + NameCompanyNew + " ? ";
                }
            }

            return MSG.Remove(MSG.Length - 2, 2);
        }

        public bool VerifyPortPassId(string PortPass, int TruckCompanyId)
        {
            bool isPort = false;
            string PortPassOld = "";
            var L = TruckDriverCompanyService.GetById(TruckCompanyId);
            foreach (var item in L)
            {
                var Li = TruckDriverService.GetByTruckId((int)item.TruckDriverId);
                foreach (var itemd in Li)
                    PortPassOld = itemd.PortPassId;
            }

            if ((PortPass ?? "") == (PortPassOld ?? ""))
            {
                isPort = true;
                return isPort;
            }

            return isPort;
        }

        private void VerifiCheckBox()
        {
            if (ckbEdit.Checked)
            {
                btnSave.Enabled = true;
                btnDisconnect.Enabled = false;
                btnLink.Enabled = false;
                LoadTruckDriverCompany();
            }
            else
            {
                btnSave.Enabled = false;
                btnDisconnect.Enabled = true;
                btnLink.Enabled = true;
                ddlTruckCompany.Text = "";
            }

            ddlTruckCompany.BackColor = Color.White;
        }

        public void LoadForm()
        {
            using (var db = new WTCCeresEntities())
            {
                CompaniesNameBindingSource.DataSource = CompanyService.GetCompaniesDropBoxByTypeId(6, db);
                listTruckDriver = TruckDriverService.GetDriverTruckDropBox(db);
            }

            if (DriverId != 0)
            {
                var List = (from b in listTruckDriver
                            where b.TruckDriverId.Equals(DriverId)
                            select b).ToList();
                foreach (var item in List)
                    lblNameDriver.Text = item.FirstName + " " + item.LastName;
                TruckDriverListBindingSourceGridView.DataSource = List.ToList();
            }
        }

        public bool FieldIsEmpty()
        {
            bool IsEmptyField = false;
            if (string.IsNullOrEmpty(ddlTruckCompany.Text) | string.IsNullOrWhiteSpace(ddlTruckCompany.Text))
            {
                ddlTruckCompany.BackColor = Color.LightCoral;
                IsEmptyField = true;
            }
            else
            {
                ddlTruckCompany.BackColor = Color.White;
            }

            return IsEmptyField;
        }

        private void Connect()
        {
            DialogResult dialogConnect;
            string MSG;
            int TDI = DriverId;
            int CID;
            bool IsEmptyField = false;
            if (FieldIsEmpty())
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Check the empty fields.", "", this);
                return;
            }

            CID = Convert.ToInt32(ddlTruckCompany.SelectedValue);
            var List = (from b in listTruckDriver
                        where b.TruckDriverId.Equals(TDI) & b.CompanyId.Equals(CID)
                        select b).ToList();
            if (List.Count > 0)
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("This Driver Truck is already connected to this company.", "", this);
                return;
            }

            MSG = "Do you really want to connect the company " + ddlTruckCompany.Text + " to this driver truck " + lblNameDriver.Text + " ?";
            dialogConnect = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Connect Driver Truck", MSG, My.Resources.Resources.caution, this);
            if (dialogConnect == DialogResult.Yes)
            {
                if (TruckDriverCompanyService.Insert(TDI, CID))
                {
                    EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, TruckDriverCompanyService.LastTruckDriverCompanyId().ToString(), "INSERT", "TRUCK DRIVER", "New Truck Driver Company Id: " + CID.ToString() + " Connect with TruckDriverId: " + DriverId.ToString());
                    LoadDataGridView();
                    My.MyProject.Forms.FrmParentScreen.f.LoadForm();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("ERROR", "An error has occurred, please try again. If the error persists, inform the IT department. #3421", this);
                }
            }
        }

        private void Disconnect()
        {
            DialogResult dialogTruckDriver;
            string MSG = "";
            MSG = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("Do you really want to disconnect the company ", dgvTruckDriverCompany.SelectedRows[0].Cells[2].Value), " to this driver truck "), lblNameDriver.Text), " ?"));
            dialogTruckDriver = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Disconnect Driver Truck", MSG, My.Resources.Resources.caution, this);
            if (dialogTruckDriver == DialogResult.Yes)
            {
                string MSGLog = "";
                int Id = Conversions.ToInteger(dgvTruckDriverCompany.SelectedRows[0].Cells[0].Value);
                var L = TruckDriverCompanyService.GetById(Id);
                foreach (var item in L)
                    MSGLog = "Items that have been deleted: CompanyId: #" + item.CompanyId.ToString() + " TruckDriverId: " + item.TruckDriverId.ToString();
                if (TruckDriverCompanyService.Delete(Id))
                {
                    EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, Id.ToString(), "DELETE", "TRUCK DRIVER", MSGLog);
                    LoadDataGridView();
                    My.MyProject.Forms.FrmParentScreen.f.LoadForm();
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Error in disconnect the company our this truck driver", "", this);
                }
            }
        }

        private void LoadDataGridView()
        {
            using (var db = new WTCCeresEntities())
            {
                listTruckDriver = TruckDriverService.GetDriverTruckDropBox(db);
            }

            var L = (from b in listTruckDriver
                     where b.TruckDriverId.Equals(DriverId)
                     select b).ToList();
            TruckDriverListBindingSourceGridView.DataSource = L.ToList();
        }

        private void LoadTruckDriverCompany()
        {
            TruckDriverList td = (TruckDriverList)dgvTruckDriverCompany.CurrentRow.DataBoundItem;
            TruckDriverCompanyId = td.TruckDriverCompanyId;
            ddlTruckCompany.SelectedValue = td.CompanyId;
            ddlTruckCompany.Text = td.CompanyName;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void dgvTruckDriverCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ckbEdit.Checked)
            {
                LoadTruckDriverCompany();
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}