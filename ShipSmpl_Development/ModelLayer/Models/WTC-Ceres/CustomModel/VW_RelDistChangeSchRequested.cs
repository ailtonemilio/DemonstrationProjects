using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.CustomModel
{
    public class VW_RelDistChangeSchRequested
    {
        public int RelDistRequestScheduleId { get; set; }
        public DateTime OrigFromDate { get; set; }
        public DateTime OrigToDate { get; set; }
        public int OrigQtyRequested { get; set; }

        public int RelDistChangeReqScheduleId { get; set; }
        public DateTime FromDateChange { get; set; }
        public DateTime ToDateChange { get; set; }
        public int QtyRequestdChange { get; set; }
        public string CarrierMessage { get; set; }
        public string WTCMessage { get; set; }
        public bool isRead { get; set; }
        public int ChangeReqStatusId { get; set; }
        public string ChangeReqStatus { get; set; }
    }
}