using BusinessLayer;
using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ShipSmpl
{
    public partial class FrmAddEditRequest
    {
        public FrmAddEditRequest()
        {
            InitializeComponent();
            _btnComplete.Name = "btnComplete";
            _btnCancel.Name = "btnCancel";
            _closeFlatButton.Name = "closeFlatButton";
            _cboReleaseType.Name = "cboReleaseType";
            _cboBooking.Name = "cboBooking";
        }

        public bool isNewRequest;
        private InboundRequest inRequest;
        private InboundRequestService inReqServ = new InboundRequestService();
        private bool isExportRelease;
        private Release rel = new Release();
        private ReleaseOrder relOrder = new ReleaseOrder();
        private ReleaseOrderMinibooking relOrderMb = new ReleaseOrderMinibooking();
        private List<ReleaseOrderMinibooking> RelOrderMbList = new List<ReleaseOrderMinibooking>();
        private bool isChangeOfExportBooking;
        private bool firstLoad;
        private List<Booking> BookingList = new List<Booking>();
        private List<VW_ReleaseOrder> OrderList = new List<VW_ReleaseOrder>();

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (GoodToGo())
            {
                var relOrderService = new ReleaseOrderService();
                var relService = new ReleaseService();
                bool isInserted;
                int relReqId;
                if (isNewRequest)
                {
                    inRequest = new InboundRequest();
                    inRequest.RequestStatusId = (int)MdlEnum.RequestStatus.PENDING_REPLY;
                    inRequest.DateRequested = DateAndTime.Now;
                    inRequest.IsOpenRequest = true;
                }

                inRequest.ShippingLineId = Conversions.ToInteger(cboSSLine.SelectedValue);
                inRequest.QtyRequested = (int)Math.Round(nudQtyCans.Value);
                inRequest.ContainerSizeId = Conversions.ToInteger(cboCanSize.SelectedValue);
                inRequest.ContainerState = Conversions.ToString(cboCanState.SelectedItem);
                inRequest.BookingTypeId = Conversions.ToInteger(cboReleaseType.SelectedValue);
                isInserted = inReqServ.AddOrUpdate(inRequest);
                relReqId = inReqServ.GetLastInboundRequestId();
                if (isInserted)
                {
                    if (isExportRelease)
                    {
                        if (isNewRequest)
                        {
                            rel = new Release();
                            isChangeOfExportBooking = false;
                            relOrder = new ReleaseOrder();
                        }

                        rel.ReleaseNumber = Strings.Trim(cboBooking.Text);
                        if (relService.AddOrUpdate(rel))
                        {
                            relOrder.ReleaseId = relService.GetLastReleaseId();
                            relOrder.DateAccepted = default;
                            relOrder.CreatedAt = DateAndTime.Now;
                            relOrder.InboundRequestId = inReqServ.GetLastInboundRequestId();
                            relOrder.QtyAccepted = 0;
                            if (relOrderService.AddOrUpdate(relOrder))
                            {
                                if (isChangeOfExportBooking)
                                {
                                    ReplaceExportBookingNumber();
                                }
                                else
                                {
                                    var newRelMb = new ReleaseOrderMinibooking();
                                    var relOrdService = new ReleaseOrderMinibookingService();
                                    newRelMb.ReleaseOrderId = relOrderService.GetLastReleaseOrderId();
                                    newRelMb.MinibookingId = MinibookingService.GetByBookingAndMbOrder(Strings.Trim(cboBooking.Text), 1).MiniBookingId;
                                    newRelMb.CreatedAt = DateAndTime.Now;
                                    newRelMb.QtyRequested = inRequest.QtyRequested;
                                    newRelMb.AssignmentOrder = 1;
                                    relOrdService.AddOrUpdate(newRelMb);
                                }

                                Close();
                            }
                            else
                            {
                                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Booking export not saved", "Something went wrong and the export booking request was not saved." + Constants.vbNewLine + "Please try again.", this);
                            }
                        }
                        else
                        {
                            My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Booking export not saved", "Something went wrong and the export booking request was not saved." + Constants.vbNewLine + "Please try again.", this);
                        }
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Request not saved", "Something went wrong and the request was not saved." + Constants.vbNewLine + "Please try again.", this);
                }
            }
        }

        public void loadForm()
        {
            firstLoad = true;
            {
                var withBlock = cboSSLine;
                withBlock.DataSource = CompanyService.GetAllByCompanyTypeId((int)MdlEnum.CompanyType.Steamship_Line, new WTCCeresEntities());
                withBlock.DisplayMember = "CompanyName";
                withBlock.ValueMember = "CompanyId";
                withBlock.SelectedValue = 0;
            }

            {
                var withBlock1 = cboBooking;
                var NewRowBooking = new Booking();
                BookingList = BusinessLayer.WTC_Ceres.BookingService.GetAllByActiveStatus(true);
                NewRowBooking.BookingId = 0;
                NewRowBooking.BookingNumber = "";
                BookingList.Insert(0, NewRowBooking);
                if (cboReleaseType.Text.Equals("IMPORT"))
                {
                    withBlock1.DataSource = BookingList.Where(b => b.BookingTypeId == (int)MdlEnum.BookingType.IMPORT).ToList();
                }
                else
                {
                    withBlock1.DataSource = BookingList.Where(b => b.BookingTypeId != (int)MdlEnum.BookingType.IMPORT).ToList();
                }

                withBlock1.DisplayMember = "BookingNumber";
                withBlock1.ValueMember = "BookingId";
                withBlock1.SelectedValue = 0;
            }

            {
                var withBlock2 = cboReleaseType;
                withBlock2.DataSource = BookingTypeService.GetAll();
                withBlock2.DisplayMember = "TypeName";
                withBlock2.ValueMember = "BookingTypeId";
                withBlock2.SelectedValue = 0;
            }

            {
                var withBlock3 = cboCanState;
                withBlock3.Items.Clear();
                withBlock3.Items.Add("EMPTY");
                withBlock3.Items.Add("LOADED");
                withBlock3.SelectedIndex = 0;
            }

            {
                var withBlock4 = cboCanSize;
                withBlock4.DataSource = ContainerSizeService.GetAll();
                withBlock4.DisplayMember = "ContainerSizeName";
                withBlock4.ValueMember = "ContainerSizeId";
                withBlock4.SelectedValue = 1;
            }

            nudQtyCans.Value = 0m;
            lblWarning.Text = "";
            lblTitle.Text = "Create Request";
            relOrder = null;
            rel = null;
            firstLoad = false;
        }

        public void LoadInfo(VW_InboundRequest inReq)
        {
            loadForm();
            firstLoad = true;
            inRequest = InboundRequestService.GetById(inReq.InboundRequestId);
            cboSSLine.SelectedValue = inRequest.ShippingLineId;
            nudQtyCans.Value = inRequest.QtyRequested;
            cboReleaseType.SelectedValue = inRequest.BookingTypeId;
            cboCanState.SelectedItem = inRequest.ContainerState;
            cboCanSize.SelectedValue = inRequest.ContainerSizeId;
            lblTitle.Text = "Update Request";
            if (!inReq.ReleaseType.Equals("REPO"))
            {
                relOrder = ReleaseOrderService.GetAllByInboundRequestId(inReq.InboundRequestId).ToList()[0];
                rel = ReleaseService.GetByReleaseId(relOrder.ReleaseId);

                // RelOrderMbList = ReleaseOrderMinibookingService.GetAllByReleaseOrderId(relOrder.ReleaseOrderId)
                // relOrderMb = RelOrderMbList.Where(Function(r) r.AssignmentOrder = 1).ToList(0)

                cboBooking.SelectedText = rel.ReleaseNumber;
            }

            firstLoad = false;
        }

        private bool GoodToGo()
        {
            bool isGood = true;
            lblWarning.Text = "";
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboSSLine.SelectedValue, 0, false)))
            {
                isGood = false;
                lblWarning.Text = "Shipping Line can not be empty.";
            }
            else if (nudQtyCans.Value == 0m)
            {
                isGood = false;
                lblWarning.Text = "Quantity of cans can not be zero.";
            }
            else if (Conversions.ToBoolean(Operators.AndObject(isExportRelease, Operators.ConditionalCompareObjectEqual(cboBooking.SelectedValue, 0, false))))
            {
                isGood = false;
                lblWarning.Text = "Booking is required for EXPORT release.";
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cboReleaseType.SelectedValue, 0, false)))
            {
                isGood = false;
                lblWarning.Text = "Release type can not be empty.";
            }

            return isGood;
        }

        private void cboReleaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad && !cboReleaseType.Text.Equals("REPO") && !cboReleaseType.Text.Equals(""))
            {

                // If user is changing from REPO to EXPORT, check if release Order already exists
                if (!isNewRequest && inRequest.BookingTypeId == (int)MdlEnum.BookingType.REPO)
                {
                    bool existPreviousReleaseOrders;
                    existPreviousReleaseOrders = ReleaseOrderService.GetAllVWByInboundRequestId(inRequest.InboundRequestId).Count > 0;

                    // Stop user from changing release type, if there are repo releases under this request
                    if (existPreviousReleaseOrders)
                    {
                        My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Operation not allowed.", "Can not change REPO to EXPORT release." + Constants.vbNewLine + "It seems like REPO release(s) already exist under this request." + Constants.vbNewLine + " To proceed, delete the release(s) of this request or create a new request.", this);
                        cboReleaseType.SelectedItem = "REPO";
                    }
                    else
                    {
                        if (cboReleaseType.Text.Equals("IMPORT"))
                        {
                            cboBooking.DataSource = BookingList.Where(b => b.BookingTypeId == (int)MdlEnum.BookingType.IMPORT).ToList();
                        }
                        else
                        {
                            cboBooking.DataSource = BookingList.Where(b => b.BookingTypeId != (int)MdlEnum.BookingType.IMPORT).ToList();
                        }

                        isExportRelease = true;
                        pnlBooking.Show();
                    }
                }
                else
                {
                    if (cboReleaseType.Text.Equals("IMPORT"))
                    {
                        cboBooking.DataSource = BookingList.Where(b => b.BookingTypeId == (int)MdlEnum.BookingType.IMPORT).ToList();
                    }
                    else
                    {
                        cboBooking.DataSource = BookingList.Where(b => b.BookingTypeId != (int)MdlEnum.BookingType.IMPORT).ToList();
                    }

                    isExportRelease = true;
                    pnlBooking.Show();
                }
            }
            else
            {
                isExportRelease = false;
                pnlBooking.Hide();
            }
        }

        private void cboBooking_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Check if old release number is being changed
            if (!firstLoad && !isNewRequest && Information.IsNothing(rel.ReleaseNumber) && !((rel.ReleaseNumber ?? "") == (cboBooking.Text ?? "")) && Convert.ToInt32(cboBooking.SelectedValue) != 0)
            {
                bool existPrevConfReleaseOrders;
                OrderList = ReleaseOrderService.GetAllVWByInboundRequestId(inRequest.InboundRequestId);
                if (OrderList.Count > 0)
                {
                    existPrevConfReleaseOrders = OrderList.Where(o => o.QtyAcceptedInOrder > 0).Count() > 0;
                    if (existPrevConfReleaseOrders)
                    {
                        My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Operation not allowed.", "Can not change the EXPORT Release Number." + Constants.vbNewLine + "It seems like there are confirmed containers under this release number." + Constants.vbNewLine + "Create a new request to proceed.", this);
                        cboBooking.SelectedText = rel.ReleaseNumber;
                        isChangeOfExportBooking = false;
                    }
                    else
                    {
                        isChangeOfExportBooking = true;
                    }
                }
            }
        }

        private void ReplaceExportBookingNumber()
        {
            var RelOrderMbService = new ReleaseOrderMinibookingService();
            var RelOrderMbList = ReleaseOrderMinibookingService.GetAllByReleaseOrderId(OrderList[0].ReleaseOrderId);
            ReleaseOrderMinibooking FirstRelOrderMb = (ReleaseOrderMinibooking)RelOrderMbList.Where(r => r.AssignmentOrder == 1);
            if (!Information.IsNothing(FirstRelOrderMb))
            {
                // Delete first ReleaseMb and add new one
                if (RelOrderMbService.Delete(FirstRelOrderMb.ReleaseOrderMinibookingId))
                {
                    var newRelMb = new ReleaseOrderMinibooking();
                    try
                    {
                        newRelMb.ReleaseOrderId = OrderList[0].ReleaseOrderId;
                        newRelMb.MinibookingId = MinibookingService.GetByBookingAndMbOrder(Strings.Trim(cboBooking.Text), 1).MiniBookingId;
                        newRelMb.CreatedAt = DateAndTime.Now;
                        newRelMb.QtyRequested = inRequest.QtyRequested;
                        newRelMb.AssignmentOrder = 1;
                        RelOrderMbService.AddOrUpdate(newRelMb);
                    }
                    catch (Exception ex)
                    {
                        My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Something went wrong.", "Could not change EXPORT Release: " + Constants.vbNewLine + ex.Message, this);
                        cboBooking.SelectedText = rel.ReleaseNumber;
                    }
                }
            }
        }
    }
}