using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.CustomModel
{
    public class VW_InboundReqDeclinedQty
    {
        public int InboundReqDeclinedQty { get; set; }
        public int InboundRequestId { get; set; }
        public int QtyDeclined { get; set; }
        public string SSLineName { get; set; }
        public string DeclineStatus { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}