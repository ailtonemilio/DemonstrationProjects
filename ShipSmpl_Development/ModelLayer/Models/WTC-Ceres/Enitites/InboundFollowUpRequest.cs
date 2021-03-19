namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InboundFollowUpRequest")]
    public partial class InboundFollowUpRequest
    {
        public int InboundFollowUpRequestId { get; set; }

        public int InboundRequestId { get; set; }

        public bool isOpenFollowUp { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedAt { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DueDate { get; set; }

        public virtual InboundRequest InboundRequest { get; set; }
    }
}
