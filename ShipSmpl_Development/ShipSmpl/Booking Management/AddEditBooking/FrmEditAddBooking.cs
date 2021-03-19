using BusinessLayer;
using BusinessLayer.WTC_Ceres;
using DataLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using ModelLayer.CustomModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BookingService = BusinessLayer.WTC_Ceres.BookingService;

namespace ShipSmpl
{
    public partial class FrmEditAddBooking
    {
        public FrmEditAddBooking()
        {
            InitializeComponent();
            _exporterTextBox.Name = "exporterTextBox";
            _fowarderRefTextBox.Name = "fowarderRefTextBox";
            _shipperRefTextBox.Name = "shipperRefTextBox";
            _shipperDropdown.Name = "shipperDropdown";
            _forwarderDropdown19.Name = "forwarderDropdown19";
            _exporterDropdown.Name = "exporterDropdown";
            _btnPickVessel.Name = "btnPickVessel";
            _addDestination.Name = "addDestination";
            _bkgNumbTextBox1.Name = "bkgNumbTextBox1";
            _doNotsplitCheckBox.Name = "doNotsplitCheckBox";
            _cboCustomer.Name = "cboCustomer";
            _cboBkType.Name = "cboBkType";
            _cboBkService.Name = "cboBkService";
            _totalContainersNumericUpDown.Name = "totalContainersNumericUpDown";
            _shippingLineDropdown5.Name = "shippingLineDropdown5";
            _BunifuFlatButton2.Name = "BunifuFlatButton2";
            _tbSerachDestination.Name = "tbSerachDestination";
            _tbnNewDest.Name = "tbnNewDest";
            _dgvDestination.Name = "dgvDestination";
            _BunifuButton1.Name = "BunifuButton1";
            _cbHoldMb.Name = "cbHoldMb";
            _numContNumericUpDown.Name = "numContNumericUpDown";
            _contSizeDropdown.Name = "contSizeDropdown";
            _outCarrierDropdown.Name = "outCarrierDropdown";
            _freeTimeToggleSwitch2.Name = "freeTimeToggleSwitch2";
            _freeTimeNumericUpDown.Name = "freeTimeNumericUpDown";
            _bagTypeDropdown.Name = "bagTypeDropdown";
            _taggingDropdown.Name = "taggingDropdown";
            _bagProviderDropdown.Name = "bagProviderDropdown";
            _extraInstrucTextBox.Name = "extraInstrucTextBox";
            _BunifuButton5.Name = "BunifuButton5";
            _addCommdtyutton.Name = "addCommdtyutton";
            _rbOneByOne.Name = "rbOneByOne";
            _rbNormalAmt.Name = "rbNormalAmt";
            _rbMaxLoad.Name = "rbMaxLoad";
            _amtREquestedNumericUpDown.Name = "amtREquestedNumericUpDown";
            _custRefTextBox.Name = "custRefTextBox";
            _btnChooseLogo.Name = "btnChooseLogo";
            _specMaxuPDOWNnUMB.Name = "specMaxuPDOWNnUMB";
            _naSpecMaxCheckBox.Name = "naSpecMaxCheckBox";
            _weightUnitDropdown.Name = "weightUnitDropdown";
            _bagWeightNUpDown.Name = "bagWeightNUpDown";
            _specInstrucDropdown1.Name = "specInstrucDropdown1";
            _lotNumbTextBox.Name = "lotNumbTextBox";
            _lotNumbCheckBox.Name = "lotNumbCheckBox";
            _rmvcmdtyButton.Name = "rmvcmdtyButton";
            _btnshowAddCmdty.Name = "btnshowAddCmdty";
            _txtBother.Name = "txtBother";
            _InspectByTextBox.Name = "InspectByTextBox";
            _gradeByDropdown.Name = "gradeByDropdown";
            _phytosByDropdown14.Name = "phytosByDropdown14";
            _fumigatByDropdown.Name = "fumigatByDropdown";
            _nextButton.Name = "nextButton";
            _previousButton.Name = "previousButton";
            _addMIniBookingBunifuButton.Name = "addMIniBookingBunifuButton";
            _btnCancel.Name = "btnCancel";
            _saveButton.Name = "saveButton";
            _btnremoveMB.Name = "btnremoveMB";
            _btnContainers.Name = "btnContainers";
            _BunifuFlatButton1.Name = "BunifuFlatButton1";
            _tbBagName.Name = "tbBagName";
            _cboBagSize.Name = "cboBagSize";
            _btnAddBagInventory.Name = "btnAddBagInventory";
            _btnOkLogo.Name = "btnOkLogo";
            _dgvBagInv.Name = "dgvBagInv";
            _btnEraseMod.Name = "btnEraseMod";
            _rmvMultiBk.Name = "rmvMultiBk";
            _btnStartOver.Name = "btnStartOver";
            _AddNewVoyageToolStripMenuItem.Name = "AddNewVoyageToolStripMenuItem";
            _AddNewVoyageToolStripMenuItem1.Name = "AddNewVoyageToolStripMenuItem1";
            _BunifuFlatButton3.Name = "BunifuFlatButton3";
            _tbSearchVessel.Name = "tbSearchVessel";
            _BunifuButton4.Name = "BunifuButton4";
        }

        private Grade GradeObj;
        private Commodity CommodityObj;
        public bool troubledMiniUnit = false;
        private int numbOfCommdts = 0;
        private string commoditiesLabel = "";
        private string countryCode;
        private string cityCode;
        private int mbOrder = 1;
        private int numbOfMB = 1;
        public int focusedMB = 0;
        private Minibooking focusedRow;
        private bool firstLoad = true;
        public List<VW_MinibookingCommodity> MbCmdtyList = new List<VW_MinibookingCommodity>();
        public bool isNewRecod;
        public string oldBkNumb = "";
        public string previousPort = "";
        public string previousVessel = "";
        public bool isMultiEdit;
        public List<VW_Booking> originalMultiEditBkList = new List<VW_Booking>();
        public List<VW_Booking> modifiedMultiEditBkList = new List<VW_Booking>();
        private List<VW_CompanyCompanyType> CompanyList = new List<VW_CompanyCompanyType>();
        private VW_BookingDestination selectedDest;
        private VW_Booking SelBooking;
        private VW_BookingBagInventoryAssignment selectedBag;
        private SortableBindingList<VesselVoyageList> VesselVoyageList = new SortableBindingList<VesselVoyageList>();
        private VesselVoyageList SelectedVesselVoyage;
        private BookingCompany BkCompanyCustomer = new BookingCompany();
        private BookingCompany BkCompanySSLine = new BookingCompany();
        private BookingCompany BkCompanyShipper = new BookingCompany();
        private BookingCompany BkCompanyForwarder = new BookingCompany();
        private BookingCompany BkCompanyExporter = new BookingCompany();
        public List<Minibooking> originalMBTable = new List<Minibooking>();
        public List<VW_ContainersByBooking> selectedCans = new List<VW_ContainersByBooking>();
        private List<DatabaseHelperCeres.BagAsnMb> bagAsnMbList = new List<DatabaseHelperCeres.BagAsnMb>();
        private List<VW_BookingDestination> BookingDestinationList = new List<VW_BookingDestination>();
        private List<VW_BagInventory> BagAssignedList = new List<VW_BagInventory>();
        private BagInventoryService bs = new BagInventoryService();
        private MinibookingCommodityService mbCmdtyService = new MinibookingCommodityService();
        private MinibookingService mbService = new MinibookingService();
        private BookingCompanyService bkCompService = new BookingCompanyService();
        private List<VW_Booking> BkList;
        private bool mbDeleted;
        // ********************************( canId, mbTempId)****

        public Dictionary<int, int> asnCansMb = new Dictionary<int, int>();
        private DateTime YesterdayDate = new DateTime();

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void saveButton_Click(object sender, EventArgs e)
        {
            saveBooking();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmBookingList.resultNoInstrux = DialogResult.Cancel;
            Close();
        }

        private void splitCheckBox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (doNotsplitCheckBox.Checked)
            {
                splitLabel.ForeColor = Color.FromArgb(192, 64, 0);
            }
            else
            {
                splitLabel.ForeColor = Color.FromArgb(64, 64, 64);
            }

            if (isMultiEdit && !firstLoad)
            {
                foreach (var b in modifiedMultiEditBkList)
                {
                    if (doNotsplitCheckBox.Checked)
                    {
                        b.AllowSplitBooking = false;
                        b.SplitBooking = "DNS";
                    }
                    else
                    {
                        b.AllowSplitBooking = true;
                        b.SplitBooking = "OKAY";
                    }
                }

                VWBookingBindingSource.DataSource = null;
                VWBookingBindingSource.DataSource = modifiedMultiEditBkList;
            }
        }

        private void vwboo()
        {
            throw new NotImplementedException();
        }

        // Private Sub erdToggleSwitch_OnValuechange(sender As Object, e As EventArgs)
        // If erdToggleSwitch.Value = True Then
        // erdPanel.Show()
        // Else
        // erdPanel.Hide()
        // End If

        // If isMultiEdit AndAlso Not firstLoad Then

        // For Each b In modifiedMultiEditBkList
        // If erdToggleSwitch.Value = True Then
        // b.ERD = erdDateDateTimePicker6.Value
        // Else
        // b.ERD = Nothing
        // End If

        // Next
        // VWBookingBindingSource.DataSource = Nothing
        // VWBookingBindingSource.DataSource = modifiedMultiEditBkList
        // End If
        // End Sub

        private void bkgNumbTextBox1_TextChanged(object sender, EventArgs e)
        {
            mandatoryFieldsOK();
            updateMbNumbInAsnCans();
        }

        private void bkngTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var b in modifiedMultiEditBkList)
                {
                    b.BookingTypeId = Conversions.ToInteger(cboBkType.SelectedValue);
                    b.BookingType = cboBkType.Text;
                }

                VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList();
            }
            else
            {
                mandatoryFieldsOK();
            }
        }

        // Private Sub deliverToBunifuDropdown_SelectedIndexChanged(sender As Object, e As EventArgs)
        // If isMultiEdit AndAlso Not firstLoad Then
        // Dim company As VW_CompanyCompanyType = deliverToBunifuDropdown.SelectedItem

        // For Each b In modifiedMultiEditBkList
        // b.TerminalId = company.CompanyId
        // b.TerminalName = company.CompanyName
        // Next
        // VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList()
        // Else
        // mandatoryFieldsOK()
        // End If

        // End Sub

        private void bkngServiceDropdown20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                ModelLayer.BookingService service = (ModelLayer.BookingService)cboBkService.SelectedItem;
                foreach (var b in modifiedMultiEditBkList)
                {
                    b.BookingServiceId = service.BookingServiceId;
                    b.ServiceCode = service.ServiceCode;
                }

                // modifiedMultiEditBkList.Select(Function(b) ())
                VWBookingBindingSource.DataSource = null;
                VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList();
            }
            else
            {
                mandatoryFieldsOK();
                btnChooseLogo.Enabled = false;
                if (cboBkService.Text.Equals("BLK"))
                {
                    mtmaxLabel.Text = "MT";
                    amtREquestedNumericUpDown.DecimalPlaces = 3;
                    bagWeightNUpDown.Enabled = false;
                    weightUnitDropdown.Enabled = false;
                    bagWeightNUpDown.BackColor = Color.FromArgb(224, 224, 224);
                    bagWeightNUpDown.ForeColor = Color.Silver;
                }
                else
                {
                    mtmaxLabel.Text = "PC";
                    amtREquestedNumericUpDown.DecimalPlaces = 0;
                    bagWeightNUpDown.Enabled = true;
                    weightUnitDropdown.Enabled = true;
                    bagWeightNUpDown.BackColor = Color.White;
                    bagWeightNUpDown.ForeColor = Color.FromArgb(64, 64, 64);
                    btnChooseLogo.Enabled = true;
                }
            }
        }

        private void totalContainersNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (getTotalContInMB() != totalContainersNumericUpDown.Value & firstLoad == false)
            {
                My.MyProject.Forms.FrmModifyTotalNumbCont.loadForm(false);
                if (originalMBTable.Count == 1)
                {
                    focusedRow.NumberOfContainer = (int?)totalContainersNumericUpDown.Value;
                    numContNumericUpDown.Value = totalContainersNumericUpDown.Value;
                }
                else if (troubledMiniUnit == true)
                {
                    focusedRow.NumberOfContainer = (int?)totalContainersNumericUpDown.Value;
                    numContNumericUpDown.Value = totalContainersNumericUpDown.Value;
                }
                else
                {
                    MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmModifyTotalNumbCont, this);
                }
            }
            else if (isNewRecod & originalMBTable.Count == 1 & !firstLoad)
            {
                focusedRow.NumberOfContainer = (int?)totalContainersNumericUpDown.Value;
                numContNumericUpDown.Value = totalContainersNumericUpDown.Value;
            }
            else if (troubledMiniUnit == true)
            {
                focusedRow.NumberOfContainer = (int?)totalContainersNumericUpDown.Value;
                numContNumericUpDown.Value = totalContainersNumericUpDown.Value;
            }

            mandatoryFieldsOK();
        }

        private void addMIniBookingBunifuButton_Click(object sender, EventArgs e)
        {
            // numbOfMB += 1
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmSplitContainersg, this);
            if (My.MyProject.Forms.FrmSplitContainersg.numbOfMB > 0)
            {
                focusedMB = originalMBTable.Count;
                numContNumericUpDown.Value = My.MyProject.Forms.FrmSplitContainersg.numbOfMB;
                addMBToDataTable();

                // addCmdtyGrade()
                populateMB();
                focusedRow = originalMBTable[focusedMB];
                checkArrowButtons();
                updateMbNumbInAsnCans();
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            focusedMB -= 1;
            focusedRow = originalMBTable[focusedMB];
            populateMB();
            checkArrowButtons();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            focusedMB += 1;
            focusedRow = originalMBTable[focusedMB];
            populateMB();
            checkArrowButtons();
        }

        private void closeAddressButton_Click(object sender, EventArgs e)
        {
            addressPanel.Hide();
        }

        private void numContNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (numContNumericUpDown.Value > 0m)
            {
                numContNumericUpDown.BackColor = Color.White;
                numContNumericUpDown.ForeColor = Color.Black;
                addMIniBookingBunifuButton.Enabled = true;
                addMIniBookingBunifuButton.IdleFillColor = Color.FromArgb(192, 64, 0);
                addMIniBookingBunifuButton.IdleBorderColor = Color.FromArgb(192, 64, 0);
                addMIniBookingBunifuButton.OnIdleState.FillColor = Color.FromArgb(192, 64, 0);
                addMIniBookingBunifuButton.OnIdleState.BorderColor = Color.FromArgb(192, 64, 0);
            }
            else
            {
                numContNumericUpDown.BackColor = Color.Red;
                numContNumericUpDown.ForeColor = Color.White;
                addMIniBookingBunifuButton.Enabled = false;
                addMIniBookingBunifuButton.IdleFillColor = Color.LightGray;
                addMIniBookingBunifuButton.IdleBorderColor = Color.LightGray;
            }

            if (firstLoad == false | troubledMiniUnit == true)
            {
                try
                {
                    focusedRow = originalMBTable[focusedMB];
                    focusedRow.NumberOfContainer = (int?)numContNumericUpDown.Value;
                }
                catch
                {
                }
            }

            mandatoryFieldsOK();
        }

        private void contSizeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.ContainerSizeId = Conversions.ToInteger(contSizeDropdown.SelectedValue);
            }
        }

        // Private Sub InCarrierDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InCarrierDropdown.SelectedIndexChanged
        // If firstLoad = False Then

        // focusedRow = originalMBTable(focusedMB)
        // Dim CompanyObj As VW_CompanyCompanyType = InCarrierDropdown.SelectedItem

        // focusedRow.CarrierInId = CompanyObj.CompanyId

        // End If
        // End Sub

        private void outCarrierDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                VW_CompanyCompanyType CompanyObj = (VW_CompanyCompanyType)outCarrierDropdown.SelectedItem;
                focusedRow.CarrierOutId = CompanyObj.CompanyId;
            }

            mandatoryFieldsOK();
        }

        // Private Sub relFromDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles relFromDropDown.SelectedIndexChanged
        // If firstLoad = False Then
        // focusedRow = originalMBTable(focusedMB)

        // Dim CompanyObj As VW_CompanyCompanyType = relFromDropDown.SelectedItem

        // focusedRow.TerminalId = CompanyObj.CompanyId

        // End If
        // End Sub

        private void freeTimeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                if (focusedRow.FreeTime.Equals("N/A"))
                {
                    freeTimeToggleSwitch2.Value = false;
                }
                else
                {
                    focusedRow.FreeTime = freeTimeNumericUpDown.Value.ToString();
                }
            }
        }

        private void freeTimeToggleSwitch2_OnValuechange(object sender, EventArgs e)
        {
            if (freeTimeToggleSwitch2.Value == true)
            {
                freeTimePanel.Show();
            }
            else
            {
                freeTimePanel.Hide();
            }

            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                if (freeTimeToggleSwitch2.Value == false)
                {
                    focusedRow.FreeTime = "N/A";
                }
                // focusedRow.FreeTime") = freeTimeNumericUpDown.Value

                else if (focusedRow.FreeTime.Equals("N/A"))
                {
                    freeTimeNumericUpDown.Value = 0m;
                    focusedRow.FreeTime = freeTimeNumericUpDown.Value.ToString();
                }
                else
                {
                    freeTimeNumericUpDown.Value = Conversions.ToDecimal(focusedRow.FreeTime);
                }
            }
        }

        private void bagProviderDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.BagProvider = Conversions.ToString(bagProviderDropdown.SelectedItem);
                if (bagProviderDropdown.SelectedItem.Equals("WTC"))
                {
                    dgvBagInv.DataSource = BagInventoryService.GetAllInventory(true).Where(b => b.CustomerName == "WTC GROUP").ToList();
                }
                else
                {
                    dgvBagInv.DataSource = BagInventoryService.GetInventoryByFilters(cboCustomer.Text, "", "", "");
                }
            }
        }

        private void taggingDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.Tagging = Conversions.ToString(taggingDropdown.SelectedItem);
            }
        }

        private void bagTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.Bagtype = Conversions.ToString(bagTypeDropdown.SelectedItem);
            }
        }

        private void addCommdtyutton_Click(object sender, EventArgs e)
        {
            // addMBToDataTable()
            numbOfCommdts += 1;
            focusedRow = originalMBTable[focusedMB];
            using (var db = new WTCCeresEntities())
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(commodityDropdown1.SelectedValue, 0, false)))
                {
                    lblWarningCmdty.Text = "";
                    if (isNewRecod && SelBooking.BookingId == 0)
                    {
                        saveBookingMainInfo(SelBooking, db);
                    }
                    // If focusedRow.MiniBookingId = 0 Then
                    // SaveMinibookings()

                    // End If
                    addCmdtyGrade(db);
                    commodityPanel.Hide();
                }
                else
                {
                    lblWarningCmdty.Text = "Commodity can not be empty";
                }
            }

            mandatoryFieldsOK();
        }

        private void btnshowAddCmdty_Click(object sender, EventArgs e)
        {
            if (commodityPanel.Visible == false)
            {
                commodityPanel.Show();
            }
            else
            {
                commodityPanel.Hide();
            }
        }

        private void rmvcmdtyButton_Click(object sender, EventArgs e)
        {
            if (MbCmdtyList.Count > 0)
            {
                focusedRow = originalMBTable[focusedMB];
                VW_MinibookingCommodity cmdtyToRemove = (VW_MinibookingCommodity)dgvCommodity.CurrentRow.DataBoundItem;
                mbCmdtyService.Delete(cmdtyToRemove.MiniBookingCommodityId);
                MbCmdtyList = MinibookingCommodityService.GetMinibookingCommodityByBkId(focusedRow.BookingId);
                VWMinibookingCommodityBindingSource.DataSource = MbCmdtyList.Where(c => c.MiniBookingId == focusedRow.MiniBookingId).ToList();
            }

            mandatoryFieldsOK();
        }

        private void amtREquestedNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                if (focusedRow.AmountRequested.Equals("MAX LOAD"))
                {
                    focusedRow.AmountRequested = "MAX LOAD";
                }
                else
                {
                    focusedRow.AmountRequested = amtREquestedNumericUpDown.Value.ToString();
                }
            }
        }

        private void specMaxuPDOWNnUMB_ValueChanged(object sender, EventArgs e)
        {
            // If maxLoadCheckBox.Checked Then
            // amtREquestedNumericUpDown.Hide()
            // Else
            // amtREquestedNumericUpDown.Show()
            // End If

            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                if (focusedRow.SpecialMax.Equals("N/A"))
                {
                    naSpecMaxCheckBox.Checked = true;
                    focusedRow.SpecialMax = "N/A";
                }
                else
                {
                    focusedRow.SpecialMax = specMaxuPDOWNnUMB.Value.ToString();
                }
            }
        }

        private void naSpecMaxCheckBox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (naSpecMaxCheckBox.Checked)
            {
                specMaxuPDOWNnUMB.Hide();
                mtspecLabel.Hide();
            }
            else
            {
                specMaxuPDOWNnUMB.Show();
                mtspecLabel.Show();
            }

            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                if (naSpecMaxCheckBox.Checked)
                {
                    focusedRow.SpecialMax = "N/A";
                }
                else if (focusedRow.SpecialMax.Equals("N/A"))
                {
                    specMaxuPDOWNnUMB.Value = 0m;
                    focusedRow.SpecialMax = specMaxuPDOWNnUMB.Value.ToString();
                }
                else
                {
                    specMaxuPDOWNnUMB.Value = Conversions.ToDecimal(focusedRow.SpecialMax);
                }
            }
        }

        private void lotNumbTextBox_TextChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.LotNumber = lotNumbTextBox.Text;
            }
        }

        private void lotNumbCheckBox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (lotNumbCheckBox.Checked)
            {
                lotNumbTextBox.Hide();
            }
            else
            {
                lotNumbTextBox.Show();
            }

            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                if (lotNumbCheckBox.Checked)
                {
                    focusedRow.LotNumber = "N/A";
                }
                else if (focusedRow.LotNumber.Equals("N/A"))
                {
                    lotNumbTextBox.Text = "";
                    focusedRow.LotNumber = lotNumbTextBox.Text;
                }
                else
                {
                    lotNumbTextBox.Text = focusedRow.LotNumber;
                    // focusedRow.Special Max") = specMaxuPDOWNnUMB.Value
                }
            }
        }

        private void specInstrucDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.SpecialInstrux = Conversions.ToString(specInstrucDropdown1.SelectedItem);
            }
        }

        private void extraInstrucTextBox_TextChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.SpecialInstruxNote = extraInstrucTextBox.Text;
            }
        }

        private void gradeByDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.GradeBy = Conversions.ToString(gradeByDropdown.SelectedItem);
            }
        }

        private void phytosByDropdown14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.PhytosanitaryBy = Conversions.ToString(phytosByDropdown14.SelectedItem);
            }
        }

        private void InspectByTextBox_TextChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.InspectionBy = InspectByTextBox.Text;
            }
        }

        private void fumigatByDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.FumigationBy = Conversions.ToString(fumigatByDropdown.SelectedItem);
            }
        }

        private void otherTextBox_TextChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.Other = txtBother.Text;
            }
        }

        private void btnremoveMB_Click(object sender, EventArgs e)
        {
            var focusedRow = originalMBTable[focusedMB];
            DialogResult dialogResult;
            string message = "Are you sure you want to delete the MiniBooking: " + bkgNumbTextBox1.Text + "(" + MdlBookingManagement.digitToLetter(focusedRow.MiniBookingOrder).ToUpper() + ")" + "? This can not be undone.";
            dialogResult = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Delete Mini Booking:", message, My.Resources.Resources.caution, this);
            if (dialogResult == DialogResult.Yes)
            {
                {
                    var withBlock = My.MyProject.Forms.FrmModifyTotalNumbCont;
                    var newList = new List<Minibooking>(originalMBTable);
                    newList.RemoveAt(focusedMB);
                    withBlock.tempDeletedMBDT = newList;
                    withBlock.loadForm(true);
                    MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmModifyTotalNumbCont, this);
                }
            }

            updateMbNumbInAsnCans();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public void loadForm(List<VW_Booking> selectedBookings)
        {
            // Dim db As WTCCeresEntities

            using (var db = new WTCCeresEntities())
            {
                firstLoad = true;
                YesterdayDate = DateAndTime.Now.AddDays(-1);
                timer.Interval = 500;
                troubledMiniUnit = false;
                BkList = My.MyProject.Forms.FrmBookingList.BKListAll;
                if (BkList.Count == 0)
                {
                    BookingService.GetAllVW();
                }

                clearFields();
                saveButton.Text = "Finish";
                populateComboBoxes(db);
                Size = new Size(1730, 810);
                pnlMultiEdit.Visible = false;
                if (!isNewRecod)
                {
                    lblTitle.Text = "Update Booking";
                    saveButton.Text = "Finish";

                    // If it is not edition of many bookings...
                    if (!isMultiEdit)
                    {
                        bkgNumbTextBox1.Text = "";
                        SelBooking = selectedBookings[0];
                        oldBkNumb = selectedBookings[0].BookingNumber;
                        populateBookingInfo(selectedBookings[0], db);

                        // Get Booking and commodity info

                        originalMBTable = MinibookingService.GetAllByBookingId(selectedBookings[0].BookingId, db);
                        focusedRow = originalMBTable[0];
                        MbCmdtyList = MinibookingCommodityService.GetMinibookingCommodityByBkId(originalMBTable[0].BookingId, db);
                        VWMinibookingCommodityBindingSource.DataSource = MbCmdtyList.Where(c => c.MiniBookingId == focusedRow.MiniBookingId).ToList();
                        // numContNumericUpDown.Value = totalContainersNumericUpDown.Value
                        focusedRow = originalMBTable[0];
                        populateMB();
                    }
                    else
                    {
                        try
                        {
                            Size = new Size(1730, 978);
                            pnlMultiEdit.Visible = true;
                            CreateBksCopy(selectedBookings, ref originalMultiEditBkList);
                            CreateBksCopy(selectedBookings, ref modifiedMultiEditBkList);
                            bkgNumbTextBox1.Text = "MULTI EDIT";
                            VWBookingBindingSource.DataSource = modifiedMultiEditBkList;
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
                else
                {
                    saveButton.Enabled = false;
                    // If new Booking, get table scheme of MB and Bookings
                    var bkmb = new VW_BookingMinibooking();
                    SelBooking = new VW_Booking();
                    BkCompanyCustomer = new BookingCompany();
                    BkCompanySSLine = new BookingCompany();
                    BkCompanyShipper = new BookingCompany();
                    BkCompanyForwarder = new BookingCompany();
                    BkCompanyExporter = new BookingCompany();
                    addMBToDataTable();
                    focusedRow = originalMBTable[0];
                    // MbCmdtyList = MinibookingCommodityService.GetMinibookingCommodityByMbId(originalMBTable(0).MiniBookingId)
                    // Add temporary ID to match commodities and grades do MB

                }
            }

            checkArrowButtons();
            firstLoad = false;
            mandatoryFieldsOK();
        }

        private List<VW_CompanyCompanyType> GetCompanyByType(List<VW_CompanyCompanyType> CompanyList, int CompanyTypeId)
        {
            var NewList = new List<VW_CompanyCompanyType>();
            var FilteredList = CompanyList.Where(c => c.CompanyTypeId == CompanyTypeId | c.CompanyTypeId == 0).ToList();
            NewList.AddRange(FilteredList);
            return NewList;
        }

        private void populateComboBoxes(WTCCeresEntities db)
        {
            BagAssignedList.Clear();
            CompanyList = CompanyService.GetAll(db);
            var CustomerCompanies = new List<VW_CompanyCompanyType>();
            CustomerCompanies = CompanyList.Where(c => c.CompanyCategoryId == (int)MdlEnum.CompanyCategory.CUSTOMER | c.CompanyCategoryId == (int)MdlEnum.CompanyCategory.CUSTOMER_VENDOR).ToList();
            {
                var withBlock = shipperDropdown;
                withBlock.DataSource = GetCompanyByType(CompanyList, (int)MdlEnum.CompanyType.Shipper);
                withBlock.DisplayMember = "CompanyName";
                withBlock.ValueMember = "CompanyId";
            }

            {
                var withBlock1 = forwarderDropdown19;
                withBlock1.DataSource = GetCompanyByType(CompanyList, (int)MdlEnum.CompanyType.Freight_Forwarder);
                withBlock1.DisplayMember = "CompanyName";
                withBlock1.ValueMember = "CompanyId";
            }

            {
                var withBlock2 = cboCustomer;
                withBlock2.DataSource = CustomerCompanies;
                withBlock2.DisplayMember = "CompanyName";
                withBlock2.ValueMember = "CompanyId";
            }

            {
                var withBlock3 = exporterDropdown;
                withBlock3.DataSource = GetCompanyByType(CompanyList, (int)MdlEnum.CompanyType.Exporter);
                withBlock3.DisplayMember = "CompanyName";
                withBlock3.ValueMember = "CompanyId";
            }

            {
                var withBlock4 = outCarrierDropdown;
                withBlock4.DataSource = GetCompanyByType(CompanyList, (int)MdlEnum.CompanyType.Drayage_Provider);
                withBlock4.DisplayMember = "CompanyName";
                withBlock4.ValueMember = "CompanyId";
                withBlock4.SelectedValue = 1;
            }

            {
                var withBlock5 = shippingLineDropdown5;
                withBlock5.DataSource = GetCompanyByType(CompanyList, (int)MdlEnum.CompanyType.Steamship_Line);
                withBlock5.DisplayMember = "CompanyName";
                withBlock5.ValueMember = "CompanyId";
            }

            {
                var withBlock6 = commodityDropdown1;
                withBlock6.DataSource = CommodityService.GetAll(db);
                withBlock6.DisplayMember = "CommodityName";
                withBlock6.ValueMember = "CommodityId";
            }

            {
                var withBlock7 = gradeDropDown;
                withBlock7.DataSource = GradeService.GetAll(db);
                withBlock7.DisplayMember = "GradeName";
                withBlock7.ValueMember = "GradeId";
            }

            {
                var withBlock8 = contSizeDropdown;
                withBlock8.DataSource = ContainerSizeService.GetAll(db).Where(c => c.ContainerSizeId != 0).ToList();
                withBlock8.DisplayMember = "ContainerSizeName";
                withBlock8.ValueMember = "ContainerSizeId";
            }

            // With cboBagSize
            // Dim bagSizes = BagInventoryService.GetAllBagSize()
            // .DataSource = bagSizes
            // .DisplayMember = "BagSizeName"
            // .ValueMember = "BagSizeId"
            // .SelectedValue = 0

            // End With

            // With cboBagColor
            // .DataSource = BagInventoryService.GetAllColors()
            // .DisplayMember = "ColorName"
            // .ValueMember = "ColorId"
            // .SelectedValue = 0

            // End With
            {
                var withBlock9 = cboCustomerBag;
                withBlock9.DataSource = CustomerCompanies;
                withBlock9.DisplayMember = "CompanyName";
                withBlock9.ValueMember = "CompanyId";
            }

            {
                var withBlock10 = cboBkService;
                withBlock10.DataSource = BookingServiceService.GetAll(db);
                withBlock10.DisplayMember = "ServiceName";
                withBlock10.ValueMember = "BookingServiceId";
            }

            {
                var withBlock11 = cboBkType;
                withBlock11.DataSource = BookingTypeService.GetAll(db);
                withBlock11.DisplayMember = "TypeName";
                withBlock11.ValueMember = "BookingTypeId";
            }

            contSizeDropdown.SelectedIndex = 0;
            cboBkService.SelectedValue = 0;
            cboBkType.SelectedValue = 0;
            shipperDropdown.SelectedIndex = 0;
            forwarderDropdown19.SelectedIndex = 0;
            cboCustomer.SelectedIndex = 0;
            // deliverToBunifuDropdown.SelectedIndex = 0

            outCarrierDropdown.SelectedIndex = 0;
            shippingLineDropdown5.SelectedIndex = 0;
            commodityDropdown1.SelectedIndex = 0;
            gradeDropDown.SelectedIndex = 0;
            exporterDropdown.SelectedIndex = 0;
            // cboDestination.SelectedValue = 0
        }

        private void clearFields()
        {
            lblBagName.Text = "";
            bagAsnMbList.Clear();
            MbCmdtyList.Clear();
            mbDeleted = false;
            selectedDest = null;
            lblDestination.Text = "Select Destination...";
            VWMinibookingCommodityBindingSource.DataSource = null;
            VWBookingBindingSource.DataSource = null;
            SelectedVesselVoyage = null;
            VesselVoyageList.Clear();
            originalMBTable.Clear();
            rbOneByOne.Checked = false;
            rbNormalAmt.Checked = true;
            pnlNormalAmt.Show();
            tbSerachDestination.Text = "";
            focusedMB = 0;

            // 
            bagProviderDropdown.SelectedIndex = 0;
            weightUnitDropdown.SelectedIndex = 0;
            taggingDropdown.SelectedIndex = 0;
            bagTypeDropdown.SelectedIndex = 2;
            specInstrucDropdown1.SelectedIndex = 0;
            gradeByDropdown.SelectedIndex = 0;
            phytosByDropdown14.SelectedIndex = 0;
            fumigatByDropdown.SelectedIndex = 0;
            numContNumericUpDown.Value = 0m;
            totalContainersNumericUpDown.Value = 0m;
            specMaxuPDOWNnUMB.Value = 0m;
            amtREquestedNumericUpDown.Value = 0m;
            bagWeightNUpDown.Value = 0m;
            freeTimeNumericUpDown.Value = 0m;
            bkgNumbTextBox1.Text = "";
            shipperRefTextBox.Text = "";
            lblDeliverTo.Text = "";
            lblVessel.Text = "";
            lblVoyage.Text = "";
            lblETD.Text = "";
            lblErd.Text = "";
            lblLrd.Text = "";
            commoditiesLabel = "";
            custRefTextBox.Text = "";
            fowarderRefTextBox.Text = "";
            lotNumbTextBox.Text = "";
            extraInstrucTextBox.Text = "";
            InspectByTextBox.Text = "";
            txtBother.Text = "";
            previousButton.Enabled = false;
            previousButton.IdleIconRightImage = My.Resources.Resources.previousDisabled;
            nextButton.Enabled = false;
            nextButton.IdleIconLeftImage = My.Resources.Resources.nextDisabled;
            cbHoldMb.Checked = false;
            mbTitleLabel.Text = "Minibooking 1 | Total MB: 1";
            // mbTitleLabel.BackColor = Color.DarkGreen

            doNotsplitCheckBox.Checked = false;
            naSpecMaxCheckBox.Checked = false;
            lotNumbCheckBox.Checked = false;
            rbMaxLoad.Checked = false;
            freeTimeToggleSwitch2.Value = true;
            saveButton.Enabled = true;
            btnCancel.Enabled = true;
            numContNumericUpDown.BackColor = Color.Red;
            numContNumericUpDown.ForeColor = Color.White;
            addMIniBookingBunifuButton.Enabled = false;
            addMIniBookingBunifuButton.IdleFillColor = Color.LightGray;
            addMIniBookingBunifuButton.IdleBorderColor = Color.LightGray;
            MbCmdtyList.Clear();
            splitLabel.ForeColor = Color.FromArgb(64, 64, 64);
            shipperDropdown.DropDownHeight = Height - 400;
            forwarderDropdown19.DropDownHeight = Height - 400;
            cboCustomer.DropDownHeight = Height - 400;
            outCarrierDropdown.DropDownHeight = Height - 400;
            shippingLineDropdown5.DropDownHeight = Height - 400;
            commodityDropdown1.DropDownHeight = Height - 400;
            gradeDropDown.DropDownHeight = Height - 400;
            exporterDropdown.DropDownHeight = Height - 400;
        }

        private void addCmdtyGrade(WTCCeresEntities db)
        {
            // Add grades and commodities to dataTable
            var mbCmdtyService = new MinibookingCommodityService();
            var newMBCmdty = new MiniBookingCommodity();
            newMBCmdty.CommodityId = Conversions.ToInteger(commodityDropdown1.SelectedValue);
            newMBCmdty.GradeId = Conversions.ToInteger(gradeDropDown.SelectedValue);
            newMBCmdty.MiniBookingId = focusedRow.MiniBookingId;
            if (mbCmdtyService.AddOrUpdate(newMBCmdty))
            {
                MbCmdtyList = MinibookingCommodityService.GetMinibookingCommodityByBkId(focusedRow.BookingId);
                VWMinibookingCommodityBindingSource.DataSource = MbCmdtyList.Where(c => c.MiniBookingId == focusedRow.MiniBookingId).ToList();
            }
        }

        private void saveBookingMainInfo(VW_Booking booking, WTCCeresEntities db)
        {
            Booking b;
            var BkService = new BookingService();
            if (booking.BookingId == 0)
            {
                b = new Booking();
                b.BookingId = default;
                b.BookingStatusId = (int)MdlEnum.BookingStatus.ACTIVE;
                b.ActiveBooking = true;
                b.OnERD = false;
                b.CreatedAt = DateAndTime.Now;
            }
            else
            {
                b = BookingService.GetById(booking.BookingId, db);
            }

            if (!isMultiEdit)
            {
                b.BookingNumber = Strings.Trim(bkgNumbTextBox1.Text);
                b.BookingTypeId = Conversions.ToInteger(cboBkType.SelectedValue);
                b.BookingServiceId = Conversions.ToInteger(cboBkService.SelectedValue);
                b.TotalQtyOfCans = (int)Math.Round(totalContainersNumericUpDown.Value);
                b.LastUpdated = DateAndTime.Now;
                b.ShipperReference = Strings.Trim(shipperRefTextBox.Text);
                b.ForwarderReference = Strings.Trim(fowarderRefTextBox.Text);
                b.ExporterReference = Strings.Trim(exporterTextBox.Text);
                b.VesselVoyageId = SelectedVesselVoyage.VesselVoyageId;
                if (!Information.IsNothing(selectedDest))
                {
                    b.BookingDestinationId = selectedDest.BookingDestinationId;
                }
                else
                {
                    b.BookingDestinationId = 0;
                }

                if (doNotsplitCheckBox.Checked == false)
                {
                    b.AllowSplitBooking = true;
                }
                else
                {
                    b.AllowSplitBooking = false;
                }

                BkService.AddOrUpdate(b, db);
                SelBooking.BookingId = b.BookingId;
                SaveCompaniesInBooking(db);
                SaveMinibookings(db);
            }
            else
            {
                b.BookingTypeId = booking.BookingTypeId;
                b.BookingServiceId = booking.BookingServiceId;
                b.VesselVoyageId = booking.VesselVoyageId;
                b.ShipperReference = booking.ShipperReference;
                b.ForwarderReference = booking.ForwarderReference;
                b.ExporterReference = booking.ExporterReference;
                b.BookingDestinationId = booking.BookingDestinationId;
                b.LastUpdated = DateAndTime.Now;
                b.AllowSplitBooking = booking.AllowSplitBooking;
                BkService.AddOrUpdate(b, db);
                SaveMultiCompaniesInBooking(booking, db);
            }
        }

        private void SaveCompaniesInBooking(WTCCeresEntities db)
        {
            BkCompanyCustomer.CompanyId = Conversions.ToInteger(cboCustomer.SelectedValue);
            BkCompanyCustomer.CompanyTypeId = (int)MdlEnum.CompanyType.Customer;
            BkCompanyCustomer.BookingId = SelBooking.BookingId;
            BkCompanyShipper.CompanyId = Conversions.ToInteger(shipperDropdown.SelectedValue);
            BkCompanyShipper.CompanyTypeId = (int)MdlEnum.CompanyType.Shipper;
            BkCompanyShipper.BookingId = SelBooking.BookingId;
            BkCompanyForwarder.CompanyId = Conversions.ToInteger(forwarderDropdown19.SelectedValue);
            BkCompanyForwarder.CompanyTypeId = (int)MdlEnum.CompanyType.Freight_Forwarder;
            BkCompanyForwarder.BookingId = SelBooking.BookingId;
            BkCompanyExporter.CompanyId = Conversions.ToInteger(exporterDropdown.SelectedValue);
            BkCompanyExporter.CompanyTypeId = (int)MdlEnum.CompanyType.Exporter;
            BkCompanyExporter.BookingId = SelBooking.BookingId;
            BkCompanySSLine.CompanyId = Conversions.ToInteger(shippingLineDropdown5.SelectedValue);
            BkCompanySSLine.CompanyTypeId = (int)MdlEnum.CompanyType.Steamship_Line;
            BkCompanySSLine.BookingId = SelBooking.BookingId;
            bkCompService.AddOrUpdate(BkCompanyCustomer, db);
            bkCompService.AddOrUpdate(BkCompanyShipper, db);
            bkCompService.AddOrUpdate(BkCompanyForwarder, db);
            bkCompService.AddOrUpdate(BkCompanyExporter, db);
            bkCompService.AddOrUpdate(BkCompanySSLine, db);
        }

        private void SaveMultiCompaniesInBooking(VW_Booking bk, WTCCeresEntities db)
        {
            BkCompanyCustomer = BookingCompanyService.GetByFiltersId(bk.BookingId, (int)MdlEnum.CompanyType.Customer, db);
            BkCompanyCustomer.CompanyId = bk.CustomerId;
            BkCompanyCustomer.CompanyTypeId = (int)MdlEnum.CompanyType.Customer;
            BkCompanyCustomer.BookingId = bk.BookingId;
            BkCompanyShipper = BookingCompanyService.GetByFiltersId(bk.BookingId, (int)MdlEnum.CompanyType.Shipper, db);
            BkCompanyShipper.CompanyId = bk.ShipperId;
            BkCompanyShipper.CompanyTypeId = (int)MdlEnum.CompanyType.Shipper;
            BkCompanyShipper.BookingId = bk.BookingId;
            BkCompanyForwarder = BookingCompanyService.GetByFiltersId(bk.BookingId, (int)MdlEnum.CompanyType.Freight_Forwarder, db);
            BkCompanyForwarder.CompanyId = bk.ForwarderId;
            BkCompanyForwarder.CompanyTypeId = (int)MdlEnum.CompanyType.Freight_Forwarder;
            BkCompanyForwarder.BookingId = bk.BookingId;
            BkCompanyExporter = BookingCompanyService.GetByFiltersId(bk.BookingId, (int)MdlEnum.CompanyType.Exporter, db);
            BkCompanyExporter.CompanyId = bk.ExporterId;
            BkCompanyExporter.CompanyTypeId = (int)MdlEnum.CompanyType.Exporter;
            BkCompanyExporter.BookingId = bk.BookingId;
            BkCompanySSLine = BookingCompanyService.GetByFiltersId(bk.BookingId, (int)MdlEnum.CompanyType.Steamship_Line, db);
            BkCompanySSLine.CompanyId = bk.SSLineId;
            BkCompanySSLine.CompanyTypeId = (int)MdlEnum.CompanyType.Steamship_Line;
            BkCompanySSLine.BookingId = bk.BookingId;
            bkCompService.AddOrUpdate(BkCompanyCustomer, db);
            bkCompService.AddOrUpdate(BkCompanyShipper, db);
            bkCompService.AddOrUpdate(BkCompanyForwarder, db);
            bkCompService.AddOrUpdate(BkCompanyExporter, db);
            bkCompService.AddOrUpdate(BkCompanySSLine, db);
        }

        public List<VW_Booking> CreateBksCopy(List<VW_Booking> originaList, ref List<VW_Booking> targetList)
        {
            targetList.Clear();
            VW_Booking b;
            foreach (var booking in originaList)
            {
                b = new VW_Booking();
                b.BookingId = booking.BookingId;
                b.BookingTypeId = booking.BookingTypeId;
                b.BookingType = booking.BookingType;
                b.BookingServiceId = booking.BookingServiceId;
                b.ServiceCode = booking.ServiceCode;
                b.CustomerId = booking.CustomerId;
                b.CustomerName = booking.CustomerName;
                b.TerminalId = booking.TerminalId;
                b.TerminalName = booking.TerminalName;
                b.ShipperId = booking.ShipperId;
                b.ShipperName = booking.ShipperName;
                b.ForwarderId = booking.ForwarderId;
                b.ForwarderName = booking.ForwarderName;
                b.ExporterId = booking.ExporterId;
                b.ExporterName = booking.ExporterName;
                b.BookingNumber = booking.BookingNumber;
                b.SSLineId = booking.SSLineId;
                b.SSLineCode = booking.SSLineCode;
                b.ShipperReference = booking.ShipperReference;
                b.ForwarderReference = booking.ForwarderReference;
                b.ExporterReference = booking.ExporterReference;
                b.VesselName = booking.VesselName;
                b.VoyageNumber = booking.VoyageNumber;
                b.SailingDate = booking.SailingDate;
                b.BookingDestinationId = booking.BookingDestinationId;
                b.DestAddrStr = booking.DestAddrStr;
                b.ERD = booking.ERD;
                b.LRD = booking.LRD;
                b.AllowSplitBooking = booking.AllowSplitBooking;
                b.SplitBooking = booking.SplitBooking;
                b.VesselVoyageId = booking.VesselVoyageId;
                targetList.Add(b);
            }

            return default;
        }

        private void updateMbNumbInAsnCans()
        {
            string bkLetter = "";
            var tempList = new List<MdlBookingManagement.SplitedCanInfo>();
            int digit;
            // If FrmBookingList.formMode.Equals("Split") Then

            // For Each canInfo In SplitedCansList
            // With canInfo

            // If originalMBTable.Count = 1 Then
            // bkLetter = ""
            // Else
            // digit = .MinibookingTempId + 1
            // bkLetter = "(" + digitToLetter(digit) + ")"
            // End If
            // .MinibookingNumber = Trim(bkgNumbTextBox1.Text) + bkLetter
            // tempList.Add(canInfo)

            // End With
            // Next
            // SplitedCansList = tempList
            // End If
        }

        private void checkArrowButtons()
        {
            // if more than one mb
            if (originalMBTable.Count > 1)
            {
                if (focusedMB == 0)
                {
                    nextButton.Enabled = true;
                    previousButton.Enabled = false;
                    nextButton.IdleIconLeftImage = My.Resources.Resources.nextEnabled;
                    previousButton.IdleIconRightImage = My.Resources.Resources.previousDisabled;
                    string stringmb = "";
                    if (originalMBTable.Count - 1 > 1)
                    {
                        stringmb = "Minibookings";
                    }
                    else
                    {
                        stringmb = "Minibooking";
                    }

                    mbTitleLabel.Text = "Minibooking 1 | Total MB: " + originalMBTable.Count.ToString();
                }
                // mbTitleLabel.BackColor = Color.DarkGreen
                else
                {
                    nextButton.Enabled = true;
                    if (focusedMB + 1 == originalMBTable.Count)
                    {
                        nextButton.IdleIconLeftImage = My.Resources.Resources.nextDisabled;
                        nextButton.Enabled = false;
                    }
                    else
                    {
                        nextButton.IdleIconLeftImage = My.Resources.Resources.nextEnabled;
                    }

                    previousButton.Enabled = true;
                    previousButton.IdleIconRightImage = My.Resources.Resources.previousEnabled;
                    mbTitleLabel.Text = "Minibooking " + (focusedMB + 1).ToString() + " | Total MB: " + originalMBTable.Count.ToString();
                    // mbTitleLabel.BackColor = Color.FromArgb(192, 64, 0)
                }
            }
            else
            {
                nextButton.Enabled = false;
                previousButton.Enabled = false;
                nextButton.IdleIconLeftImage = My.Resources.Resources.nextDisabled;
                previousButton.IdleIconRightImage = My.Resources.Resources.previousDisabled;
                if (!isMultiEdit)
                {
                    // mbTitleLabel.Text = "Minibooking 1 | Total MB: " + focusedRow.MiniBookingOrder.ToString
                }
            }
        }

        public void populateMB()
        {
            if (focusedMB == -1)
            {
                focusedMB = 0;
            }

            var mbInfo = originalMBTable[focusedMB];
            if (mbInfo.MiniBookingId != 0)
            {
                if (!Information.IsNothing(mbInfo.NumberOfContainer))
                {
                    numContNumericUpDown.Value = (decimal)mbInfo.NumberOfContainer;
                }
                else
                {
                    numContNumericUpDown.Value = 0m;
                }

                if (originalMBTable.Count == 1)
                {
                    numContNumericUpDown.Value = totalContainersNumericUpDown.Value;
                }

                contSizeDropdown.SelectedValue = mbInfo.ContainerSizeId;
                try
                {
                    selectedBag = BagInventoryService.GetBookingBagInvAsnmByMbId(mbInfo.MiniBookingId)[0];
                    lblBagName.Text = selectedBag.BagDescription;
                    var bagAsnMb = new DatabaseHelperCeres.BagAsnMb();
                    focusedRow = originalMBTable[focusedMB];
                    bagAsnMb.MinibookingId = focusedRow.MiniBookingId;
                    bagAsnMb.BagInvenotryId = selectedBag.BagInventoryId;
                    bagAsnMb.BookingBagAssignmentId = selectedBag.BookingBagAssignmentId;
                    bagAsnMbList.Add(bagAsnMb);
                }
                catch (Exception ex)
                {
                    selectedBag = null;
                }

                outCarrierDropdown.SelectedValue = mbInfo.CarrierOutId;
                bagProviderDropdown.SelectedItem = mbInfo.BagProvider;
                taggingDropdown.SelectedItem = mbInfo.Tagging;
                if (mbInfo.HoldBooking == true)
                {
                    cbHoldMb.Checked = true;
                }
                else
                {
                    cbHoldMb.Checked = false;
                }

                bagTypeDropdown.SelectedItem = mbInfo.Bagtype;
                weightUnitDropdown.SelectedItem = mbInfo.BagWeightUnit;
                bagWeightNUpDown.Value = Conversions.ToDecimal(mbInfo.BagWeight);
                if (mbInfo.FreeTime.Equals("N/A"))
                {
                    freeTimeToggleSwitch2.Value = false;
                }
                else if (Information.IsNothing(mbInfo.FreeTime))
                {
                    freeTimeToggleSwitch2.Value = false;
                }
                else
                {
                    freeTimeToggleSwitch2.Value = true;
                    freeTimeNumericUpDown.Value = Conversions.ToDecimal(mbInfo.FreeTime);
                }

                if (mbInfo.SpecialMax.Equals("N/A"))
                {
                    naSpecMaxCheckBox.Checked = true;
                }
                else if (Information.IsNothing(mbInfo.SpecialMax))
                {
                    naSpecMaxCheckBox.Checked = true;
                }
                else
                {
                    naSpecMaxCheckBox.Checked = false;
                    specMaxuPDOWNnUMB.Value = Conversions.ToDecimal(mbInfo.SpecialMax);
                }

                if (mbInfo.AmountRequested.Equals("MAX LOAD") | mbInfo.AmountRequested.Equals("MAX"))
                {
                    rbMaxLoad.Checked = true;
                }
                else if (mbInfo.AmountRequested.Equals("1:1"))
                {
                    rbOneByOne.Checked = true;
                }
                else if (Information.IsDBNull(mbInfo.AmountRequested))
                {
                    rbNormalAmt.Checked = true;
                }
                else
                {
                    rbNormalAmt.Checked = true;
                    amtREquestedNumericUpDown.Value = Conversions.ToDecimal(mbInfo.AmountRequested);
                }

                if (mbInfo.LotNumber.Equals("N/A"))
                {
                    lotNumbCheckBox.Checked = true;
                }
                else if (Information.IsNothing(mbInfo.LotNumber))
                {
                    lotNumbCheckBox.Checked = true;
                }
                else
                {
                    lotNumbCheckBox.Checked = false;
                    lotNumbTextBox.Text = mbInfo.LotNumber;
                }

                specInstrucDropdown1.SelectedItem = mbInfo.SpecialInstrux;
                extraInstrucTextBox.Text = mbInfo.SpecialInstruxNote;
                custRefTextBox.Text = mbInfo.CustomerReference;
                gradeByDropdown.SelectedItem = mbInfo.GradeBy;
                phytosByDropdown14.SelectedItem = mbInfo.PhytosanitaryBy;
                InspectByTextBox.Text = mbInfo.InspectionBy;
                fumigatByDropdown.SelectedItem = mbInfo.FumigationBy;
                txtBother.Text = mbInfo.Other;
                VWMinibookingCommodityBindingSource.DataSource = MbCmdtyList.Where(c => c.MiniBookingId == mbInfo.MiniBookingId).ToList();
                if (originalMBTable.Count > 1)
                {
                    btnremoveMB.Show();
                    btnremoveMB.Enabled = true;
                }
                else
                {
                    btnremoveMB.Hide();
                    btnremoveMB.Enabled = false;
                }

                updateMbNumbInAsnCans();
            }
        }

        private void saveBooking()
        {
            MdlLoadingSetting.waitForm.Show();
            if (mandatoryFieldsOK())
            {
                string newBkNumb;
                string synctype;
                using (var db = new WTCCeresEntities())
                {
                    if (!isMultiEdit)
                    {
                        var mbService = new MinibookingService();
                        var CansOutGated = new List<VW_ContainersByBooking>();
                        var cansToOutgate = new List<VW_ContainersByBooking>();
                        newBkNumb = Strings.Trim(bkgNumbTextBox1.Text).Replace(Constants.vbTab, "");
                        // 'If is a split and user didn't select cans to transfer
                        if (NeedToSplit(newBkNumb, ref CansOutGated, cansToOutgate, db) & MdlBookingManagement.SplitedCansList.Count == 0 & !isNewRecod)
                        {
                            MdlLoadingSetting.waitForm.Close();
                            GetSplitBookingOptions(cansToOutgate);
                        }
                        else
                        {
                            saveBookingMainInfo(SelBooking, db);
                            if ((oldBkNumb ?? "") != (newBkNumb ?? "") && !isNewRecod)
                            {
                                EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, oldBkNumb, "EDIT", "BOOKING", "Edition of booking information. BOOKING NUMBER CHANGED FROM: " + oldBkNumb + " TO: " + newBkNumb + ". Qty of MBs: " + originalMBTable.Count.ToString(), db);
                            }

                            SaveEmployeeLog(newBkNumb, db);
                            if (isNewRecod)
                            {
                                synctype = "NEW BOOKING";
                            }
                            else if (mbDeleted == false)
                            {
                                synctype = "UPDATE BOOKING";
                            }
                            else
                            {
                                synctype = "UPDATE BOOKING - MB DELETED";
                            }

                            MdlBookingManagement.SaveCeresExcelLog(SelBooking.BookingId, synctype, oldBkNumb, db);
                        }
                    }
                    else
                    {
                        foreach (var bk in modifiedMultiEditBkList)
                        {
                            saveBookingMainInfo(bk, db);
                            SaveEmployeeLog(bk.BookingNumber, db);
                            VW_Booking oldBookingInfo;
                            try
                            {
                                oldBookingInfo = originalMultiEditBkList.Where(b => b.BookingId == bk.BookingId).ToList()[0];
                                if (oldBookingInfo.VesselVoyageId != SelectedVesselVoyage.VesselVoyageId)
                                {
                                    EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, bk.BookingNumber, "EDIT", "BOOKING", "VesselVoyage info changed. From VesselVoyageId: " + oldBookingInfo.VesselVoyageId.ToString() + " (" + oldBookingInfo.VesselName + " " + oldBookingInfo.VoyageNumber + ") to VesselVoyageId: " + SelectedVesselVoyage.VesselVoyageId.ToString() + " (" + bk.VesselName + " " + bk.VoyageNumber + ")", db);
                                }
                            }
                            catch (Exception ex)
                            {
                            }

                            if (isNewRecod)
                            {
                                synctype = "NEW BOOKING";
                            }
                            else
                            {
                                synctype = "UPDATE BOOKING";
                            }

                            MdlBookingManagement.SaveCeresExcelLog(bk.BookingId, synctype + " - Multi Edit", oldBkNumb, db);
                        }
                    }

                    List<VW_Booking> vb = BookingService.GetAllVW();

                    My.MyProject.Forms.FrmBookingList.BKListAll = vb;

                    My.MyProject.Forms.FrmBookingList.BKList = vb.Where(b => b.ActiveBooking == true).ToList();
                    My.MyProject.Forms.FrmBookingList.VWBookingBindingSource.DataSource = BkList;
                    MdlLoadingSetting.waitForm.Close();
                    Close();
                }
            }
            // End If
            // End If

        }

        private void GetSplitBookingOptions(List<VW_ContainersByBooking> cansToOutgate)
        {
            var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Cannot rename booking.", "There are containers under the old booking that were already outgated, so renaming the booking is not allowed." + Constants.vbNewLine + "Would you Like to split booking instead?", My.Resources.Resources.warning, this);
            if (result == DialogResult.Yes)
            {
                DialogResult dResult;
                My.MyProject.Forms.FrmSplitbooking.reasignCans = false;
                My.MyProject.Forms.FrmSplitbooking.dgvCansToTransfer.DataSource = cansToOutgate;
                My.MyProject.Forms.FrmBookingList.formMode = "Split";
                dResult = My.MyProject.Forms.FrmSplitbooking.ShowDialog(this);
                if (dResult == DialogResult.Yes)
                {
                    selectedCans = My.MyProject.Forms.FrmSplitbooking.SelectedCans;
                    var bkList = new List<VW_Booking>();
                    bkList.Add(SelBooking);
                    loadForm(bkList);
                }
            }
        }

        private void SaveEmployeeLog(string newBkNumb, WTCCeresEntities db)
        {
            string msg;
            if (isNewRecod)
            {
                EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, newBkNumb, "CREATE", "BOOKING", "Creation of new booking. Qty of MBs: " + originalMBTable.Count.ToString(), db);
            }
            else if (My.MyProject.Forms.FrmBookingList.shouldRefresh == true)
            {
                if (isMultiEdit)
                {
                    msg = "Edition of booking information. MULTI EDIT";
                }
                else if (oldBkNumb.Equals(newBkNumb) & !isMultiEdit)
                {
                    msg = "Edition of booking information. Qty of MBs: " + originalMBTable.Count.ToString();
                }
                else if (!oldBkNumb.Equals(newBkNumb))
                {
                    msg = "Edition of booking information - BOOKING NUMBER WAS CHANGED FROM: " + oldBkNumb + " TO: " + newBkNumb + ". Qty of MBs: " + originalMBTable.Count.ToString();
                }
                else
                {
                    msg = "Edition of booking information";
                }

                EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, newBkNumb, "EDIT", "BOOKING", msg, db);
            }
        }

        public void SaveMinibookings(WTCCeresEntities db)
        {
            object issaved;
            if (SelBooking.BookingId == 0)
            {
                saveBookingMainInfo(SelBooking, db);
            }
            else
            {
                foreach (var mb in originalMBTable)
                {
                    mb.BookingId = SelBooking.BookingId;
                    mb.isMultiMB = originalMBTable.Count > 1;
                    issaved = mbService.AddOrUpdate(mb, db);
                }
            }

            originalMBTable = MinibookingService.GetAllByBookingId(SelBooking.BookingId);
            focusedRow = originalMBTable[focusedMB];
        }

        private bool NeedToSplit(string newBkNumb, ref List<VW_ContainersByBooking> cansOutgated, List<VW_ContainersByBooking> cansToOutgate, WTCCeresEntities db)
        {
            if (!isNewRecod && (oldBkNumb ?? "") != (newBkNumb ?? ""))
            {
                var ContainersInBooking = new List<VW_ContainersByBooking>();
                ContainersInBooking = Containers_In_OutService.GetContainersByBookingNumber(SelBooking.BookingNumber, db);
                cansToOutgate = ContainersInBooking.Where(c => c.Container_Out_Gated.HasValue == false || c.Container_Out_Gated == false).ToList();
                cansOutgated = ContainersInBooking.Where(c => c.Container_Out_Gated.HasValue == true && c.Container_Out_Gated == true).ToList();
                if (cansOutgated.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // Public Sub assignSplitCans()
        // If selectedCans.Count > 0 And originalMBTable.Count > 1 Then

        // End If
        // End Sub

        private void addMBToDataTable()
        {
            int numCont;
            int contSizeId;
            int freeTime;
            string bagProvider;
            string tagging;
            string bagType;
            string amtReq;
            string specMax;
            string bagWeight;
            string weightUnit;
            string lotNumber;
            string specInstruc;
            string specInstrucNotes;
            string gradeBy;
            string phytosBy;
            string inspecBy;
            string furmBy;
            string other;
            VW_CompanyCompanyType InCarrierObj, OutCarrierObj, ReleaseFromObj;
            var mbService = new MinibookingService();
            // **** MINI BOOKING VARIABLES ****
            numCont = (int)Math.Round(numContNumericUpDown.Value);
            contSizeId = Conversions.ToInteger(contSizeDropdown.SelectedValue);
            freeTime = (int)Math.Round(freeTimeNumericUpDown.Value);
            bagProvider = Conversions.ToString(bagProviderDropdown.SelectedItem);
            tagging = Conversions.ToString(taggingDropdown.SelectedItem);
            bagType = Conversions.ToString(bagTypeDropdown.SelectedItem);
            bagWeight = bagWeightNUpDown.Value.ToString();
            weightUnit = Conversions.ToString(weightUnitDropdown.SelectedItem);
            if (rbMaxLoad.Checked)
            {
                amtReq = "MAX LOAD";
            }
            else if (rbOneByOne.Checked)
            {
                amtReq = "1:1";
            }
            else
            {
                amtReq = amtREquestedNumericUpDown.Value.ToString();
            }

            if (naSpecMaxCheckBox.Checked)
            {
                specMax = "N/A";
            }
            else
            {
                specMax = specMaxuPDOWNnUMB.Value.ToString();
            }

            if (lotNumbCheckBox.Checked)
            {
                lotNumber = "N/A";
            }
            else
            {
                lotNumber = lotNumbTextBox.Text;
            }

            specInstruc = Conversions.ToString(specInstrucDropdown1.SelectedItem);
            specInstrucNotes = extraInstrucTextBox.Text;
            gradeBy = Conversions.ToString(gradeByDropdown.SelectedItem);
            phytosBy = Conversions.ToString(phytosByDropdown14.SelectedItem);
            inspecBy = InspectByTextBox.Text;
            furmBy = Conversions.ToString(fumigatByDropdown.SelectedItem);
            other = txtBother.Text;
            OutCarrierObj = (VW_CompanyCompanyType)outCarrierDropdown.SelectedItem;

            // dbCeres.save

            var newRow = new Minibooking();
            if (originalMBTable.Count == 0)
            {
                newRow.isMainBooking = true;
                newRow.MiniBookingOrder = 1;
            }
            else
            {
                int count = 1;
                foreach (var m in originalMBTable)
                {
                    m.MiniBookingOrder = count;
                    count += 1;
                }

                mbOrder = originalMBTable.Count + 1;
                newRow.isMainBooking = false;
                newRow.MiniBookingOrder = mbOrder;
            }

            newRow.NumberOfContainer = numCont;
            newRow.ContainerSizeId = contSizeId;
            if (cbHoldMb.Checked)
            {
                newRow.HoldBooking = true;
            }
            else
            {
                newRow.HoldBooking = false;
            }

            newRow.CarrierOutId = OutCarrierObj.CompanyId;
            newRow.CustomerReference = Strings.Trim(custRefTextBox.Text);
            newRow.FreeTime = freeTime.ToString();
            newRow.BagProvider = bagProvider;
            newRow.Tagging = tagging;
            newRow.Bagtype = bagType;
            newRow.AmountRequested = amtReq;
            newRow.SpecialMax = specMax;
            newRow.BagWeight = bagWeight;
            newRow.BagWeightUnit = weightUnit;
            newRow.LotNumber = lotNumber;
            newRow.SpecialInstrux = specInstruc;
            newRow.SpecialInstruxNote = specInstrucNotes;
            newRow.GradeBy = gradeBy;
            newRow.PhytosanitaryBy = phytosBy;
            newRow.InspectionBy = inspecBy;
            newRow.FumigationBy = furmBy;
            newRow.Other = other;
            originalMBTable.Add(newRow);
            if (!firstLoad)
            {
                using (var db = new WTCCeresEntities())
                {
                    SaveMinibookings(db);
                }

                originalMBTable.Clear();
                originalMBTable = MinibookingService.GetAllByBookingId(SelBooking.BookingId);
            }

            mandatoryFieldsOK();
        }

        private bool mandatoryFieldsOK()
        {
            bool goodToGo = true;
            pnlMb.Enabled = false;
            bkgNumbTextBox1.Enabled = true;
            totalContainersNumericUpDown.Enabled = true;
            if (!firstLoad && !isMultiEdit)
            {
                bool bookingNumberExists;
                string originalBooking;
                saveButton.Enabled = true;
                if (!isNewRecod)
                {
                    originalBooking = My.MyProject.Forms.FrmBookingList.FocusedBookingObj.BookingNumber;
                }
                else
                {
                    originalBooking = "";
                }

                // Chack if bk number is valid
                if (string.IsNullOrEmpty(bkgNumbTextBox1.Text))
                {
                    saveButton.Enabled = false;
                    goodToGo = false;
                    warningLabel.Text = "The booking number can not be empty.";
                    return goodToGo;
                }
                else
                {
                    bookingNumberExists = BkList.Where(b => (b.BookingNumber ?? "") == (Strings.Trim(bkgNumbTextBox1.Text) ?? "")).Count() > 0;
                    if (bookingNumberExists)
                    {
                        if (isNewRecod & !originalBooking.Equals(Strings.Trim(bkgNumbTextBox1.Text)) | isNewRecod)
                        {
                            goodToGo = false;
                            saveButton.Enabled = false;
                            warningLabel.Text = "This booking already exists";
                            return goodToGo;
                        }
                        else
                        {
                            // goodToGo = True
                            warningLabel.Text = "";
                            // saveButton.Enabled = True
                        }
                    }
                    else
                    {
                        goodToGo = true;
                        warningLabel.Text = "";
                        saveButton.Enabled = true;
                    }
                }

                // check bk service
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboBkService.SelectedValue, 0, false)))
                {
                    goodToGo = false;
                    // bkngServiceDropdown20.Color = Color.Red
                    warningLabel.Text = "Service field can not be empty'";
                    saveButton.Enabled = false;
                }

                // check bk type
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboBkType.SelectedValue, 0, false)))
                {
                    goodToGo = false;
                    // bkngTypeComboBox.Color = Color.Red
                    warningLabel.Text = "Booking type can not be empty";
                    saveButton.Enabled = false;
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboCustomer.SelectedValue, 0, false)))
                {
                    warningLabel.Text = "Customer can not be empty";
                    saveButton.Enabled = false;
                    goodToGo = false;
                }
                else if (totalContainersNumericUpDown.Value.ToString().Equals("0"))
                {
                    goodToGo = false;
                    warningLabel.Text = "Containtar quantity can not be 0";
                    saveButton.Enabled = false;
                }

                // ElseIf bkngServiceDropdown20.SelectedItem.Equals("BGR") Then

                // If BagAssignedList.Count = 0 Then
                // warningLabel.Text = "Select the bag this booking will be using."
                // saveButton.Enabled = False
                // End If

                else if (Information.IsNothing(SelectedVesselVoyage) || SelectedVesselVoyage.VesselVoyageId == 0)
                {
                    warningLabel.Text = "'Vessel' can not be UNASSIGNED";
                    saveButton.Enabled = false;
                    goodToGo = false;
                }
                // ElseIf outCarrierDropdown.SelectedValue = 0 Then
                // warningLabel.Text = "'Carrier Out' can not be empty"
                // saveButton.Enabled = False
                // goodToGo = False
                else if (Information.IsNothing(selectedDest) || selectedDest.BookingDestinationId == 0)
                {
                    warningLabel.Text = "'Booking Destination' can not be empty";
                    saveButton.Enabled = false;
                    goodToGo = false;
                }
                else if (NeedRateTier() == true)
                {
                    saveButton.Enabled = false;
                    goodToGo = false;
                }
                else if (numContNumericUpDown.Value > 45m)
                {
                    pnlMb.Enabled = true;
                    goodToGo = false;
                    saveButton.Enabled = false;
                    warningLabel.Text = "Minibooking can not have more than 45 containers. Create another Minibooking.";
                }
                else if (MbCmdtyList.Count == 0)
                {
                    pnlMb.Enabled = true;
                    goodToGo = false;
                    warningLabel.Text = "Booking commodity can not be empty";
                    saveButton.Enabled = false;
                    return goodToGo;
                }
                else if (MbCmdtyList.Count > 0)
                {
                    pnlMb.Enabled = true;
                    foreach (var mb in originalMBTable)
                    {
                        if (MbCmdtyList.Where(c => c.MiniBookingId == mb.MiniBookingId).Count() == 0)
                        {
                            goodToGo = false;
                            warningLabel.Text = "Booking commodity  can not be empty";
                            saveButton.Enabled = false;
                            return goodToGo;
                        }
                    }
                }
                else
                {
                    // If multiEdit, then disable minibooking panel

                    pnlMb.Enabled = true;
                    goodToGo = true;
                    warningLabel.Text = "";
                    saveButton.Enabled = true;
                }
            }
            else if (isMultiEdit)
            {
                try
                {
                    warningLabel.Text = "";
                    totalContainersNumericUpDown.Enabled = false;
                    bkgNumbTextBox1.Enabled = false;
                }
                catch (Exception ex)
                {
                }
            }

            return goodToGo;
        }

        public int getTotalContInMB()
        {
            int total = 0;
            foreach (var mb in originalMBTable)
                total = (int)(total + mb.NumberOfContainer);
            return total;
        }

        public void deleteMB()
        {
            string bkLetter = "";
            var focusedRow = originalMBTable[focusedMB];
            if (!Information.IsNothing(focusedRow.MiniBookingId))
            {
                using (var db = new WTCCeresEntities())
                {
                    var mbService = new MinibookingService();
                    string minibookingNumber = SelBooking.BookingNumber + "(" + MdlBookingManagement.digitToLetter(focusedRow.MiniBookingOrder).ToUpper() + ")";
                    mbService.Delete(focusedRow.MiniBookingId, db);
                    mbDeleted = true;
                    EmployeeActivityLogService.Insert(My.MyProject.Forms.FrmLoginWindow._userID, SelBooking.BookingNumber, "DELETE", "BOOKING", "Deletion of Minibooking " + minibookingNumber, db);
                    string synctype = "DELETE MINIBOOKING";
                    MdlBookingManagement.SaveCeresExcelLog(focusedRow.BookingId, synctype, minibookingNumber, db);
                    if (originalMBTable.Count > 1)
                    {
                        bkLetter = "(" + MdlBookingManagement.digitToLetter(focusedRow.MiniBookingOrder).ToUpper() + ")";
                    }
                    else
                    {
                        bkLetter = "";
                    }
                }
            }

            originalMBTable.Remove(focusedRow);
            int count = 1;
            foreach (var m in originalMBTable)
            {
                m.MiniBookingOrder = count;
                count += 1;
            }

            focusedMB -= 1;
            populateMB();
            checkArrowButtons();
        }

        private void bagWeightNUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.BagWeight = bagWeightNUpDown.Value.ToString();
            }
        }

        private void weightUnitDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.BagWeightUnit = Conversions.ToString(weightUnitDropdown.SelectedItem);
            }
        }

        private void btnContainers_Click(object sender, EventArgs e)
        {
            {
                var withBlock = My.MyProject.Forms.FrmSplitbooking;
                if (!string.IsNullOrEmpty(bkgNumbTextBox1.Text))
                {
                    withBlock.Size = new Size(983, 494);
                    withBlock.dgvCansToTransfer.DataSource = selectedCans.ToList();
                    withBlock.reasignCans = true;
                    withBlock.populateMbGrid(originalMBTable);
                    withBlock.ShowDialog(this);
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Missing info.", "Booking number cannot be empty.", this);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                if (addressPanel.Visible)
                {
                    addressPanel.Hide();
                }
                else
                {
                    // cboCountry.DropDownHeight = Me.Height - 400
                    addressPanel.Show();
                    // getCountries()
                    if (BookingDestinationList.Count == 0)
                    {
                        BookingDestinationList = BookingDestinationService.GetByFilters("");
                        VWBookingDestinationBindingSource.DataSource = BookingDestinationList;
                    }
                    else
                    {
                        VWBookingDestinationBindingSource.DataSource = BookingDestinationList;
                    }
                }
            }
        }

        // Private Async Sub countryDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCountry.SelectedIndexChanged
        // '    Dim country As Countries.Country
        // '    country = cboCountry.SelectedItem
        // '    Await CountrAPI.GetAllRegions(country.code)

        // '    With cboRegion
        // '        .DataSource = CountrAPI.AllRegions
        // '        .DisplayMember = "region"
        // '    End With

        // End Sub

        // Private Async Sub cityDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRegion.SelectedIndexChanged
        // Try
        // Dim region As Countries.Region
        // region = cboRegion.SelectedItem
        // Await CountrAPI.GetAllCities(region)

        // With cboCity
        // .DataSource = CountrAPI.AllCities
        // .DisplayMember = "city"
        // End With
        // Catch
        // cboCity.Text = ""
        // End Try
        // End Sub

        private void btnChooseLogo_Click(object sender, EventArgs e)
        {
            int companyid = 0;
            if (panelBagsList.Visible == false)
            {
                panelBagsList.Show();
            }
            // companyid = companiesTable.Select("CompanyName = '" + Trim(cboCustomer.SelectedItem) + "'").CopyToDataTable.Rows(0).Item("CompanyId")
            // dgvBagInv.DataSource = BagInventoryService.GetInventoryByCustomerId(companyid)
            else
            {
                panelBagsList.Hide();
            }
        }

        private void cboBagWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                dgvBagInv.DataSource = BagInventoryService.GetInventoryByFilters(cboCustomerBag.Text, tbBagName.Text, "", cboBagSize.Text);
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelBagsList.Hide();
        }

        private void btnOkLogo_Click(object sender, EventArgs e)
        {
            VW_BagInventory bag = (VW_BagInventory)dgvBagInv.CurrentRow.DataBoundItem;
            var result = default(DialogResult);
            Company customerOfBooking = (Company)cboCustomer.SelectedItem;
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(customerOfBooking.CompanyId, bag.CustomerId, false)))
            {
                result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Warning:", "You have selected a bag that belogs to another customer (" + bag.CustomerName + ")." + Constants.vbNewLine + Constants.vbNewLine + "Is this the right bag?", My.Resources.Resources.warning, this);
            }

            if (Conversions.ToBoolean(Operators.OrObject(result == DialogResult.Yes, Operators.ConditionalCompareObjectEqual(customerOfBooking, bag.CustomerName, false))))
            {
                panelBagsList.Hide();
                lblBagName.Text = bag.BagDescription;
                bagAsnMbList.Clear();
                var bagAsnMb = new DatabaseHelperCeres.BagAsnMb();
                var bs = new BagInventoryService();
                focusedRow = originalMBTable[focusedMB];
                if (Information.IsDBNull(focusedRow.MiniBookingId))
                {
                    bagAsnMb.MinibookingId = default;
                }
                else
                {
                    bagAsnMb.MinibookingId = focusedRow.MiniBookingId;
                }

                // bagAsnMb.MinibookingTempId = focusedRow("tempId")
                bagAsnMb.BagInvenotryId = (int)bag.BagInventoryId;
                try
                {
                    bagAsnMb.BookingBagAssignmentId = BagInventoryService.GetBookingBagInvAsnmByMbId(focusedRow.MiniBookingId)[0].BookingBagAssignmentId;
                }
                catch
                {
                    bagAsnMb.BookingBagAssignmentId = 0;
                }

                if (!Information.IsNothing(selectedBag))
                {
                    bs.DeleteBookingBagAssignment(selectedBag.BookingBagAssignmentId);
                }

                bagAsnMbList.Add(bagAsnMb);
            }
        }

        private void dgvBagInv_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBagInv.Rows.Count > 0)
            {
                VW_BagInventory bag = (VW_BagInventory)dgvBagInv.CurrentRow.DataBoundItem;
                My.MyProject.Forms.FrmInvenotryDetail.PopulateInventoryInfo(bag);
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmInvenotryDetail, this);
            }
        }

        private void btnAddBagInventory_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAddEditInventory.loadForm();
            My.MyProject.Forms.FrmAddEditInventory.isNewInventory = true;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditInventory, this);
            dgvBagInv.DataSource = BagInventoryService.GetAllInventory(true);
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                VW_CompanyCompanyType company = (VW_CompanyCompanyType)cboCustomer.SelectedItem;
                foreach (var b in modifiedMultiEditBkList)
                {
                    b.CustomerId = company.CompanyId;
                    b.CustomerName = company.CompanyName;
                }

                VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList();
            }
            else
            {
                mandatoryFieldsOK();
            }
        }

        public void populateBookingInfo(VW_Booking selectedBooking, WTCCeresEntities db)
        {
            DateTime erd;
            DateTime lrd;
            DateTime sailingDate;
            bkgNumbTextBox1.Text = Strings.Trim(selectedBooking.BookingNumber);
            cboBkType.SelectedItem = selectedBooking.BookingType;
            if (selectedBooking.AllowSplitBooking == true)
            {
                // 'Do not split is false when split booking is true
                doNotsplitCheckBox.Checked = false;
            }
            else
            {
                // 'Do not split is true when split booking is false
                doNotsplitCheckBox.Checked = true;
            }

            cboBkService.SelectedValue = selectedBooking.BookingServiceId;
            cboBkType.SelectedValue = selectedBooking.BookingTypeId;
            cboCustomer.SelectedValue = selectedBooking.CustomerId;
            totalContainersNumericUpDown.Value = selectedBooking.TotalQtyOfCans;
            BkCompanyCustomer = BookingCompanyService.GetByFiltersId(selectedBooking.BookingId, (int)MdlEnum.CompanyType.Customer, db);
            BkCompanyExporter = BookingCompanyService.GetByFiltersId(selectedBooking.BookingId, (int)MdlEnum.CompanyType.Exporter, db);
            BkCompanyForwarder = BookingCompanyService.GetByFiltersId(selectedBooking.BookingId, (int)MdlEnum.CompanyType.Freight_Forwarder, db);
            BkCompanyShipper = BookingCompanyService.GetByFiltersId(selectedBooking.BookingId, (int)MdlEnum.CompanyType.Shipper, db);
            BkCompanySSLine = BookingCompanyService.GetByFiltersId(selectedBooking.BookingId, (int)MdlEnum.CompanyType.Steamship_Line, db);
            if (!Information.IsNothing(selectedBooking.SSLineId))
            {
                shippingLineDropdown5.SelectedValue = selectedBooking.SSLineId;
            }
            else
            {
                shippingLineDropdown5.SelectedValue = 0;
            }

            if (Information.IsNothing(selectedBooking.ShipperReference))
            {
                shipperRefTextBox.Text = "";
            }
            else
            {
                shipperRefTextBox.Text = selectedBooking.ShipperReference;
            }

            if (Information.IsNothing(selectedBooking.ShipperId))
            {
                shipperDropdown.SelectedValue = 0;
            }
            else
            {
                shipperDropdown.SelectedValue = selectedBooking.ShipperId;
            }

            if (Information.IsNothing(selectedBooking.ExporterId))
            {
                exporterDropdown.SelectedValue = 0;
            }
            else
            {
                exporterDropdown.SelectedValue = selectedBooking.ExporterId;
            }

            if (Information.IsNothing(selectedBooking.ExporterReference))
            {
                exporterTextBox.Text = "";
            }
            else
            {
                exporterTextBox.Text = Strings.Trim(selectedBooking.ExporterReference);
            }

            if (Information.IsNothing(selectedBooking.ForwarderId))
            {
                forwarderDropdown19.SelectedValue = 0;
            }
            else
            {
                forwarderDropdown19.SelectedValue = selectedBooking.ForwarderId;
            }

            if (!Information.IsNothing(selectedBooking.ForwarderReference))
            {
                fowarderRefTextBox.Text = selectedBooking.ForwarderReference;
            }
            else
            {
                fowarderRefTextBox.Text = "";
            }

            var vv = VesselVoyageService.GetVesselVoyageVWById(selectedBooking.VesselVoyageId, db);
            if (!Information.IsNothing(vv))
            {
                SelectedVesselVoyage = vv;
                lblDeliverTo.Text = SelectedVesselVoyage.CompanyName;
                lblVessel.Text = SelectedVesselVoyage.VesselName;
                lblVoyage.Text = SelectedVesselVoyage.VoyageNumber;
                lblETD.Text = Conversions.ToString(SelectedVesselVoyage.ETD);
                lblErd.Text = Conversions.ToString(SelectedVesselVoyage.ERD);
                lblLrd.Text = Conversions.ToString(SelectedVesselVoyage.LRD);
            }
            else
            {
                SelectedVesselVoyage = null;
                lblDeliverTo.Text = "";
                lblVessel.Text = "";
                lblVoyage.Text = "";
                lblETD.Text = "";
            }

            previousVessel = selectedBooking.VesselName;
            previousPort = selectedBooking.TerminalName;
            lblDestination.Text = selectedBooking.DestAddrStr;
            selectedDest = BookingDestinationService.GetVWById((int)selectedBooking.BookingDestinationId, db);
            lblDestination.Text = selectedDest.DestAddrStr;
        }

        private void rbNormalAmt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormalAmt.Checked)
            {
                pnlNormalAmt.Show();
            }
            else
            {
                pnlNormalAmt.Hide();
            }

            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                if (rbMaxLoad.Checked)
                {
                    focusedRow.AmountRequested = "MAX LOAD";
                }
                else if (rbOneByOne.Checked)
                {
                    focusedRow.AmountRequested = "1:1";
                }
                else
                {
                    focusedRow.AmountRequested = amtREquestedNumericUpDown.Value.ToString();
                }      // 
            }
        }

        private bool NeedRateTier()
        {
            VW_CompanyCompanyType CustomerObj = (VW_CompanyCompanyType)cboCustomer.SelectedItem;
            bool needrate = false;
            if (CustomerObj.CompanyId != 0 & Information.IsNothing(CustomerObj.RateCode))
            {
                needrate = true;
                var result = My.MyProject.Forms.MessageBoxCeresYesNo.ShowDialog("Attention:", "This customer has no rate tier yet And booking can Not be completed without that information." + Constants.vbNewLine + "Would you Like to add it now?", My.Resources.Resources.warning, this);
                if (result == DialogResult.Yes)
                {
                    {
                        var withBlock = My.MyProject.Forms.FrmDisplayContacts;
                        withBlock.isAnUpdate = true;
                        My.MyProject.Forms.FrmAddOrganization.loadForm();
                        My.MyProject.Forms.FrmAddOrganization.PopulateInfo(CustomerObj.CompanyId);
                        My.MyProject.Forms.FrmAddOrganization.availableCodePictureBox.Hide();
                        withBlock.isContact = false;
                        withBlock.focusedForm = My.MyProject.Forms.FrmAddOrganization;
                        My.MyProject.Forms.FrmAddOrganization.titleLabel.Text = "Edit " + CustomerObj.CompanyName;
                        MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddOrganization, My.MyProject.Forms.FrmParentScreen);
                        NeedRateTier();
                    }
                }
            }

            return needrate;
        }

        private void BunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            selectedDest = (VW_BookingDestination)dgvDestination.CurrentRow.DataBoundItem;
            if (isMultiEdit && !firstLoad)
            {
                foreach (var b in modifiedMultiEditBkList)
                {
                    b.BookingDestinationId = selectedDest.BookingDestinationId;
                    b.DestAddrStr = selectedDest.DestAddrStr;
                }

                VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList();
            }

            lblDestination.Text = selectedDest.DestAddrStr;
            addressPanel.Hide();
            mandatoryFieldsOK();
        }

        private void BunifuCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.HoldBooking = cbHoldMb.Checked;
            }
        }

        private void dgvDestination_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDestination.Rows.Count > 0)
            {
                var bkDestRow = dgvDestination.CurrentRow.DataBoundItem;
                My.MyProject.Forms.FrmAddEditDestination.populateDestInfo((VW_BookingDestination)bkDestRow);
                My.MyProject.Forms.FrmAddEditDestination.isNewDest = false;
                MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditDestination, this);
                BookingDestinationList = BookingDestinationService.GetByFilters(tbSerachDestination.Text);
                VWBookingDestinationBindingSource.DataSource = BookingDestinationList;
            }
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            addressPanel.Hide();
        }

        private void tbnNewDest_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmAddEditDestination.isNewDest = true;
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.FrmAddEditDestination, this);
            BookingDestinationList = BookingDestinationService.GetByFilters(tbSerachDestination.Text);
            VWBookingDestinationBindingSource.DataSource = BookingDestinationList;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timer.Interval >= 500 & timer.Interval < 600 && !firstLoad)
            {
                timer.Stop();
                if (pnlVessel.Visible == true)
                {

                    // VesselVoyageList = VesselVoyageService.GetVesselVoyageListByFilters(tbSearchVessel.Text.ToUpper())
                    VesselVoyageList = new SortableBindingList<VesselVoyageList>(VesselVoyageService.GetVesselVoyageListByFilters(tbSearchVessel.Text.ToUpper()));
                    VesselVoyageListBindingSource.DataSource = VesselVoyageList;
                }
                else
                {
                    var list = BookingDestinationService.GetByFilters(tbSerachDestination.Text);
                    VWBookingDestinationBindingSource.DataSource = list;
                }
            }
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            // modifiedMultiEditBkList.Clear()
            // modifiedMultiEditBkList.AddRange(originalMultiEditBkList)
            modifiedMultiEditBkList = new List<VW_Booking>();
            CreateBksCopy(originalMultiEditBkList, ref modifiedMultiEditBkList);
            VWBookingBindingSource.DataSource = null;
            VWBookingBindingSource.DataSource = modifiedMultiEditBkList;
        }

        private void custRefTextBox_TextChanged(object sender, EventArgs e)
        {
            if (firstLoad == false)
            {
                focusedRow = originalMBTable[focusedMB];
                focusedRow.CustomerReference = custRefTextBox.Text;
            }
        }

        private void shippingLineDropdown5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                VW_CompanyCompanyType company = (VW_CompanyCompanyType)shippingLineDropdown5.SelectedItem;
                foreach (var b in modifiedMultiEditBkList)
                {
                    b.SSLineId = company.CompanyId;
                    b.SSLineCode = company.CompanyCode;
                }

                VWBookingBindingSource.DataSource = null;
                VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList();
            }
        }

        private void shipperDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                VW_CompanyCompanyType company = (VW_CompanyCompanyType)shipperDropdown.SelectedItem;
                foreach (var b in modifiedMultiEditBkList)
                {
                    b.ShipperId = company.CompanyId;
                    b.ShipperName = company.CompanyName;
                }

                VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList();
            }
        }

        private void forwarderDropdown19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                VW_CompanyCompanyType company = (VW_CompanyCompanyType)forwarderDropdown19.SelectedItem;
                foreach (var b in modifiedMultiEditBkList)
                {
                    b.ForwarderId = company.CompanyId;
                    b.ForwarderName = company.CompanyName;
                }

                VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList();
            }
        }

        private void exporterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                VW_CompanyCompanyType company = (VW_CompanyCompanyType)exporterDropdown.SelectedItem;
                foreach (var b in modifiedMultiEditBkList)
                {
                    b.ForwarderId = company.CompanyId;
                    b.ExporterName = company.CompanyName;
                }

                VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList();
            }
        }

        private void shipperRefTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var b in modifiedMultiEditBkList)
                    b.ShipperReference = shipperRefTextBox.Text;
                VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList();
            }
        }

        private void fowarderRefTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var b in modifiedMultiEditBkList)
                    b.ForwarderReference = fowarderRefTextBox.Text;
                VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList();
            }
        }

        private void exporterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isMultiEdit && !firstLoad)
            {
                foreach (var b in modifiedMultiEditBkList)
                    b.ExporterReference = exporterTextBox.Text;
                VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList();
            }
        }

        // Private Sub vesselTextBox_TextChanged(sender As Object, e As EventArgs)
        // If isMultiEdit AndAlso Not firstLoad Then
        // For Each b In modifiedMultiEditBkList
        // b.VesselName = vesselTextBox.Text
        // Next
        // VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList()
        // End If
        // End Sub

        // Private Sub erdDateDateTimePicker6_ValueChanged(sender As Object, e As EventArgs)
        // If isMultiEdit AndAlso Not firstLoad Then
        // For Each b In modifiedMultiEditBkList
        // b.ERD = erdDateDateTimePicker6.Value
        // Next
        // VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList()
        // End If
        // End Sub

        // Private Sub lrdDateDateTimePicker_ValueChanged(sender As Object, e As EventArgs)
        // If isMultiEdit AndAlso Not firstLoad Then
        // For Each b In modifiedMultiEditBkList
        // b.LRD = lrdDateDateTimePicker.Value
        // Next
        // VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList()
        // End If
        // End Sub

        private void rmvMultiBk_Click(object sender, EventArgs e)
        {
            if (dgvMultiBk.Rows.Count > 0)
            {
                VW_Booking selectedBk = (VW_Booking)dgvMultiBk.CurrentRow.DataBoundItem;
                modifiedMultiEditBkList.Remove(selectedBk);
                VWBookingBindingSource.DataSource = modifiedMultiEditBkList;
                rmvMultiBk.Enabled = true;
                btnEraseMod.Enabled = true;
            }
            else
            {
                rmvMultiBk.Enabled = false;
                btnEraseMod.Enabled = false;
            }
        }

        private void btnEraseMod_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvMultiBk.CurrentRow.Index;
            VW_Booking selectedBk = (VW_Booking)dgvMultiBk.CurrentRow.DataBoundItem;

            // Create clone from original list
            var clonedOrigList = new List<VW_Booking>();
            CreateBksCopy(originalMultiEditBkList, ref clonedOrigList);

            // Replace information for original
            var originalBkInfo = clonedOrigList.Where(b => b.BookingId == selectedBk.BookingId).ElementAtOrDefault(0);
            modifiedMultiEditBkList[selectedIndex] = originalBkInfo;
            VWBookingBindingSource.DataSource = modifiedMultiEditBkList;
        }

        private void btnPickVessel_Click(object sender, EventArgs e)
        {
            if (pnlVessel.Visible == true)
            {
                pnlVessel.Hide();
            }
            else
            {
                pnlVessel.Show();
                if (VesselVoyageList.Count == 0)
                {
                    //    My.MyProject.Forms.FrmParentScreen.showLOadForm();
                    VesselVoyageList = new SortableBindingList<VesselVoyageList>(VesselVoyageService.GetVesselVoyageListByFilters(""));
                    VesselVoyageListBindingSource.DataSource = VesselVoyageList;
                    //  My.MyProject.Forms.FrmParentScreen.HideLoadForm();
                }
            }
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            pnlVessel.Hide();
        }

        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            SelectedVesselVoyage = (VesselVoyageList)dgvVessel.CurrentRow.DataBoundItem;
            populateVesselVoyageLabels();
            if (isMultiEdit && !firstLoad)
            {
                VW_CompanyCompanyType company = (VW_CompanyCompanyType)shipperDropdown.SelectedItem;
                foreach (var b in modifiedMultiEditBkList)
                {
                    b.VesselVoyageId = SelectedVesselVoyage.VesselVoyageId;
                    b.VesselName = lblVessel.Text;
                    b.VoyageNumber = SelectedVesselVoyage.VoyageNumber;
                    b.TerminalName = SelectedVesselVoyage.CompanyName;
                    if (!Information.IsNothing(SelectedVesselVoyage.ERD))
                    {
                        b.ERD = SelectedVesselVoyage.ERD;
                    }
                    else
                    {
                        b.ERD = default;
                    }

                    if (!Information.IsNothing(SelectedVesselVoyage.LRD))
                    {
                        b.LRD = SelectedVesselVoyage.LRD;
                    }
                    else
                    {
                        b.LRD = default;
                    }

                    if (!Information.IsNothing(SelectedVesselVoyage.ETD))
                    {
                        b.SailingDate = SelectedVesselVoyage.ETD;
                    }
                    else
                    {
                        b.SailingDate = default;
                    }

                    b.ShipperName = company.CompanyName;
                }

                VWBookingBindingSource.DataSource = modifiedMultiEditBkList.ToList();
            }

            mandatoryFieldsOK();
            pnlVessel.Hide();
        }

        private void BunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
            // Dim list = VesselVoyageList.Where(Function(v) v.VesselName.ToUpper.Contains(tbSearchVessel.Text.ToUpper) Or
            // v.VoyageNumber.ToUpper.Contains(tbSearchVessel.Text.ToUpper) Or
            // v.ERD.ToUpper.Contains(tbSearchVessel.Text.ToUpper) Or
            // v.LRD.ToUpper.Contains(tbSearchVessel.Text.ToUpper) Or
            // v.ETA.ToUpper.Contains(tbSearchVessel.Text.ToUpper) Or
            // v.ETD.ToUpper.Contains(tbSearchVessel.Text.ToUpper) Or
            // v.CompanyName.ToUpper.Contains(tbSearchVessel.Text.ToUpper) Or
            // v.StatusName.ToUpper.Contains(tbSearchVessel.Text.ToUpper)
            // ).ToList

            // VesselVoyageListBindingSource.DataSource = list
        }

        private void populateVesselVoyageLabels()
        {
            lblVessel.Text = SelectedVesselVoyage.VesselName;
            lblVoyage.Text = SelectedVesselVoyage.VoyageNumber;
            lblDeliverTo.Text = SelectedVesselVoyage.CompanyName;
            if (!Information.IsNothing(SelectedVesselVoyage.ERD))
            {
                lblErd.Text = Conversions.ToString(SelectedVesselVoyage.ERD);
            }
            else
            {
                lblErd.Text = "";
            }

            if (!Information.IsNothing(SelectedVesselVoyage.LRD))
            {
                lblLrd.Text = Conversions.ToString(SelectedVesselVoyage.LRD);
            }
            else
            {
                lblLrd.Text = "";
            }

            if (!Information.IsNothing(SelectedVesselVoyage.ETD))
            {
                lblETD.Text = Conversions.ToString(SelectedVesselVoyage.ETD);
            }
            else
            {
                lblETD.Text = "";
            }
        }

        private void btnAddNewVessel_Click(object sender, EventArgs e)
        {
        }

        private void AddNewVesselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmVesselAddEdit.LoadVessel(0);
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmVesselAddEdit, this);
            // FrmParentScreen.showLOadForm()
            // VesselVoyageList = VesselVoyageService.GetVesselVoyageAllList(True).Where(Function(v) v.LRDDateTime.Value.Date < Now.Date).ToList()
            // VesselVoyageListBindingSource.DataSource = VesselVoyageList
            // FrmParentScreen.HideLoadForm()
        }

        private void AddNewVoyageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmVesselVoyageList.LoadForm();
            My.MyProject.Forms.frmVesselVoyageAddEdit.LoadVesselVoyage();
            MdlLoadingSetting.showDialogForm(My.MyProject.Forms.frmVesselVoyageAddEdit, this);
            //   My.MyProject.Forms.FrmParentScreen.showLOadForm();
            // VesselVoyageList = VesselVoyageService.GetVesselVoyageListByFilters(tbSearchVessel.Text.ToUpper())
            VesselVoyageList = new SortableBindingList<VesselVoyageList>(VesselVoyageService.GetVesselVoyageListByFilters(tbSearchVessel.Text.ToUpper()));
            VesselVoyageListBindingSource.DataSource = VesselVoyageList;
            // My.MyProject.Forms.FrmParentScreen.HideLoadForm();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}