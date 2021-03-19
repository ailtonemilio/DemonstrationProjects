using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using System;

namespace ShipSmpl
{
    public partial class FrmAdjustBagsInventoryQty
    {
        public FrmAdjustBagsInventoryQty()
        {
            InitializeComponent();
            _closeFlatButton.Name = "closeFlatButton";
            _cboAjustmentTyoe.Name = "cboAjustmentTyoe";
            _nudQuantity.Name = "nudQuantity";
            _btnSave.Name = "btnSave";
            _rbDecrease.Name = "rbDecrease";
            _rbIncrease.Name = "rbIncrease";
            _cboBagLocation.Name = "cboBagLocation";
        }

        private VW_BagInventory focusedRow;
        private int quantityAdjusted;
        private int newTotalInventory;
        private int remainingInStorage;
        private VW_InventoryBagLocation bagLocationInfo;

        private void FrmAdjustBagsInventoryQty_Load(object sender, EventArgs e)
        {
            {
                var withBlock = cboAjustmentTyoe;
                withBlock.DataSource = BagInventoryService.GetAllTransactionsType(); // .Where(Function(b) ({"USE", "ADJUST", "SEND"}).Contains(b.TransactionTypeName)).ToList
                withBlock.DisplayMember = "TransactionTypeName";
                withBlock.ValueMember = "TransactionTypeId";
            }

            focusedRow = (VW_BagInventory)My.MyProject.Forms.FrmEmptyBagInvList.dgvInventory.Rows[My.MyProject.Forms.FrmEmptyBagInvList.dgvInventory.CurrentRow.Index].DataBoundItem;
            {
                var withBlock1 = cboBagLocation;
                withBlock1.DataSource = BagInventoryService.GetBagLocationsByInvId((int)focusedRow.BagInventoryId);
                withBlock1.DisplayMember = "LocationStorageName";
                withBlock1.ValueMember = "BagLocationId";
            }

            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var bs = new BagInventoryService();
            VW_BookingBagInventoryAssignment bagAsnRecord;
            int bagInvTransId;
            if (goodToGo())
            {
                CalculateRemaining();

                // Insert new Inventory transaction
                bs.InsertBagInventoryTransaction(Conversions.ToInteger(cboAjustmentTyoe.SelectedValue), quantityAdjusted, DateAndTime.Now, Conversions.ToInteger(cboBagLocation.SelectedValue));
                bagInvTransId = bs.GetLastBagInventoryTransactionId();
                if (cboAjustmentTyoe.Text.Equals("USE"))
                {
                    // Add record of bag usage for booking
                    bagAsnRecord = BagInventoryService.GetBookingBagInvAsnmtByMbBag(Conversions.ToInteger(cboBookingNumber.SelectedValue), (int)focusedRow.BagInventoryId);
                    bs.InsertBookingBagUsage(bagAsnRecord.BookingBagAssignmentId, bagInvTransId);
                }
                else if (cboAjustmentTyoe.Text.Equals("RECEIVE"))
                {
                    // Update Initial quantity in BagInventory (make it Remaining + new receive value)
                    bs.UpdateBagInventory((int)focusedRow.BagInventoryId, focusedRow.CustomerId, focusedRow.BagId, newTotalInventory, DateAndTime.Now, true);
                }

                // Update bag uantity in storage location
                bs.UpdateBagLocation(bagLocationInfo.BagLocationId, (int)bagLocationInfo.BagInventoryId, bagLocationInfo.LocationStorageName, bagLocationInfo.StorageTypeId, (int)bagLocationInfo.StorageId, remainingInStorage);

                // Refresh DataSource in data grids
                My.MyProject.Forms.FrmEmptyBagInvList.dgvInventory.DataSource = BagInventoryService.GetAllInventory(true);
                My.MyProject.Forms.FrmEmptyBagInvList.dgvDetails.DataSource = BagInventoryService.GetInventoryTransactionById((int)focusedRow.BagInventoryId);
                Close();
            }
        }

        private void closeFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateRemaining();
        }

        private void cboAjustmentTyoe_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlAdjust.Hide();
            pnlBooking.Hide();
            CalculateRemaining();
        }

        private void CalculateRemaining()
        {
            if (!Information.IsNothing(focusedRow))
            {
                switch (cboAjustmentTyoe.Text ?? "")
                {
                    case "ADJUST":
                        {
                            pnlAdjust.Show();
                            pnlAdjust.BringToFront();
                            if (rbIncrease.Checked)
                            {
                                lblPlusMinus.Text = "+";
                                lblTotal.Text = (bagLocationInfo.BagQuantity + nudQuantity.Value).ToString();
                                quantityAdjusted = (int)Math.Round(nudQuantity.Value);
                                newTotalInventory = (int)(focusedRow.Remaining + nudQuantity.Value);
                                remainingInStorage = (int)Math.Round(bagLocationInfo.BagQuantity + nudQuantity.Value);
                            }
                            else if (rbDecrease.Checked)
                            {
                                lblPlusMinus.Text = "-";
                                lblTotal.Text = (bagLocationInfo.BagQuantity - nudQuantity.Value).ToString();
                                quantityAdjusted = (int)Math.Round(-nudQuantity.Value);
                                newTotalInventory = (int)(focusedRow.Remaining - nudQuantity.Value);
                                remainingInStorage = (int)Math.Round(bagLocationInfo.BagQuantity - nudQuantity.Value);
                            }

                            break;
                        }

                    case "USE":
                        {
                            pnlBooking.Show();
                            pnlBooking.BringToFront();
                            {
                                var withBlock = cboBookingNumber;
                                withBlock.DataSource = BagInventoryService.GetBookingBagInvAsnmtByBag((int)focusedRow.BagInventoryId);
                                withBlock.DisplayMember = "BookingNumber";
                                withBlock.ValueMember = "MinibookingId";
                            }

                            lblPlusMinus.Text = "-";
                            lblTotal.Text = (bagLocationInfo.BagQuantity - nudQuantity.Value).ToString();
                            quantityAdjusted = (int)Math.Round(-nudQuantity.Value);
                            newTotalInventory = (int)(focusedRow.Remaining - nudQuantity.Value);
                            remainingInStorage = (int)Math.Round(bagLocationInfo.BagQuantity - nudQuantity.Value);
                            break;
                        }

                    case var @case when @case == "SEND":
                        {
                            lblPlusMinus.Text = "-";
                            lblTotal.Text = (bagLocationInfo.BagQuantity - nudQuantity.Value).ToString();
                            quantityAdjusted = (int)Math.Round(-nudQuantity.Value);
                            newTotalInventory = (int)(focusedRow.Remaining - nudQuantity.Value);
                            remainingInStorage = (int)Math.Round(bagLocationInfo.BagQuantity - nudQuantity.Value);
                            break;
                        }

                    case "RECEIVE":
                        {
                            lblPlusMinus.Text = "+";
                            lblTotal.Text = (bagLocationInfo.BagQuantity + nudQuantity.Value).ToString();
                            quantityAdjusted = (int)Math.Round(nudQuantity.Value);
                            newTotalInventory = (int)(focusedRow.Remaining + nudQuantity.Value);
                            remainingInStorage = (int)Math.Round(bagLocationInfo.BagQuantity + nudQuantity.Value);
                            break;
                        }
                }

                lblQtyUsed.Text = nudQuantity.Value.ToString();
                if ((focusedRow.Remaining - nudQuantity.Value >= 0 & nudQuantity.Value > 0m) == true)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
            }
        }

        private bool goodToGo()
        {
            if (cboAjustmentTyoe.Text.Equals("USE"))
            {
                if (string.IsNullOrEmpty(cboBookingNumber.Text))
                {
                    return false;
                }
            }

            return true;
        }

        private void rbIncrease_Click(object sender, EventArgs e)
        {
            if (cboAjustmentTyoe.Text.Equals("ADJUST"))
            {
                if (rbIncrease.Checked)
                {
                    lblPlusMinus.Text = "+";
                    lblTotal.Text = (bagLocationInfo.BagQuantity + nudQuantity.Value).ToString();
                    quantityAdjusted = (int)Math.Round(nudQuantity.Value);
                    newTotalInventory = (int)(focusedRow.Remaining + nudQuantity.Value);
                    remainingInStorage = (int)Math.Round(bagLocationInfo.BagQuantity + nudQuantity.Value);
                }
                else if (rbDecrease.Checked)
                {
                    lblPlusMinus.Text = "-";
                    lblTotal.Text = (bagLocationInfo.BagQuantity - nudQuantity.Value).ToString();
                    quantityAdjusted = (int)Math.Round(nudQuantity.Value);
                    newTotalInventory = (int)(focusedRow.Remaining + nudQuantity.Value);
                    remainingInStorage = (int)Math.Round(bagLocationInfo.BagQuantity + nudQuantity.Value);
                }
            }
        }

        private void cboBagLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            bagLocationInfo = (VW_InventoryBagLocation)cboBagLocation.SelectedItem;
            lblRemaining.Text = bagLocationInfo.BagQuantity.ToString();
            lblQtyUsed.Text = nudQuantity.Value.ToString();
            if ((focusedRow.Remaining - nudQuantity.Value >= 0 & nudQuantity.Value > 0m) == true)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }
    }
}