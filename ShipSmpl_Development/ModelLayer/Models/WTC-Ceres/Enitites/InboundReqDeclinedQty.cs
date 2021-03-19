namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InboundReqDeclinedQty")]
    public partial class InboundReqDeclinedQty
    {
        public int InboundReqDeclinedQtyId { get; set; }

        public int InboundRequestId { get; set; }

        public int QtyDeclined { get; set; }

        [StringLength(30)]
        public string DeclineStatus { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedAt { get; set; }

        public virtual InboundRequest InboundRequest { get; set; }
    }
}
