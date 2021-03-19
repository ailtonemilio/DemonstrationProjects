namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InboundRequest")]
    public partial class InboundRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InboundRequest()
        {
            InboundFollowUpRequest = new HashSet<InboundFollowUpRequest>();
            InboundReqDeclinedQty = new HashSet<InboundReqDeclinedQty>();
            ReleaseOrder = new HashSet<ReleaseOrder>();
        }

        public int InboundRequestId { get; set; }

        public int ShippingLineId { get; set; }

        public int RequestStatusId { get; set; }

        public int ContainerSizeId { get; set; }

        public int QtyRequested { get; set; }

        public int BookingTypeId { get; set; }

        public bool IsOpenRequest { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateRequested { get; set; }

        [Required]
        [StringLength(15)]
        public string ContainerState { get; set; }

        public virtual BookingType BookingType { get; set; }

        public virtual Company Company { get; set; }

        public virtual ContainerSize ContainerSize { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InboundFollowUpRequest> InboundFollowUpRequest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InboundReqDeclinedQty> InboundReqDeclinedQty { get; set; }

        public virtual RequestStatus RequestStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReleaseOrder> ReleaseOrder { get; set; }
    }
}
