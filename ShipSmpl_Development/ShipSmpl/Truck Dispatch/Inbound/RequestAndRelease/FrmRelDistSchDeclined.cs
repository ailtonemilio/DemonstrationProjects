using BusinessLayer.WTC_Ceres;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModelLayer;
using ModelLayer.CustomModel;
using System;

namespace ShipSmpl
{
    public partial class FrmRelDistSchDeclined
    {
        public FrmRelDistSchDeclined()
        {
            InitializeComponent();
            _btnComplete.Name = "btnComplete";
        }

        private RelDistChangeReqScheduleDeclinedQtyService rservice = new RelDistChangeReqScheduleDeclinedQtyService();
        private RelDistChangeReqScheduleDeclinedQty rdclined;

        public void PopulateInfo(VW_RelDistChangeSchRequested r)
        {
            nudQtyCans.Value = r.QtyRequestdChange;
            nudQtyCans.Maximum = r.QtyRequestdChange;
            nudQtyCans.Enabled = false;
            rdclined = RelDistChangeReqScheduleDeclinedQtyService.GetByRelDistChangeReqScheduleIdId(r.RelDistChangeReqScheduleId);
            cboDelineStatus.SelectedIndex = 0;
            if (!Information.IsNothing(rdclined) && rdclined.RelDistChangeReqScheduleDeclinedQtyId != 0)
            {
                cboDelineStatus.SelectedItem = rdclined.DeclineStatus;
                nudQtyCans.Value = rdclined.QtyDeclined;
                tbNotes.Text = rdclined.Notes;
                nudQtyCans.Value = r.QtyRequestdChange;
            }
            else
            {
                rdclined = new RelDistChangeReqScheduleDeclinedQty();
                rdclined.RelDistChangeReqScheduleId = r.RelDistChangeReqScheduleId;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (rdclined.RelDistChangeReqScheduleDeclinedQtyId == 0)
            {
                rdclined.CreatedAt = DateAndTime.Now;
            }

            rdclined.DeclineStatus = Conversions.ToString(cboDelineStatus.SelectedItem);
            rdclined.QtyDeclined = (int)Math.Round(nudQtyCans.Value);
            if (Conversions.ToBoolean(rservice.AddOrUpdate(rdclined)))
            {
                Close();
            }
            else
            {
                My.MyProject.Forms.MessageBoxCeresOK.ShowDialog("Information not saved", "There was an error and the information was not saved", this);
            }
        }
    }
}