namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReleaseOrder")]
    public partial class ReleaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReleaseOrder()
        {
            ReleaseOrderMinibooking = new HashSet<ReleaseOrderMinibooking>();
            RelOrderPickUpDropOffLocation = new HashSet<RelOrderPickUpDropOffLocation>();
        }

        public int ReleaseOrderId { get; set; }

        public int ReleaseId { get; set; }

        public int InboundRequestId { get; set; }

        public int QtyAccepted { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateAccepted { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedAt { get; set; }

        public virtual InboundRequest InboundRequest { get; set; }

        public virtual Release Release { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReleaseOrderMinibooking> ReleaseOrderMinibooking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelOrderPickUpDropOffLocation> RelOrderPickUpDropOffLocation { get; set; }
    }
}
