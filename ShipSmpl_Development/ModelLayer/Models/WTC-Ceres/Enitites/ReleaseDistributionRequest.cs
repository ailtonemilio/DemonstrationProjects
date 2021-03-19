namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReleaseDistributionRequest")]
    public partial class ReleaseDistributionRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReleaseDistributionRequest()
        {
            RelDistRequestSchedule = new HashSet<RelDistRequestSchedule>();
        }

        public int ReleaseDistributionRequestId { get; set; }

        public int RelOrderPickUpDropOffLocationId { get; set; }

        public int CarrierId { get; set; }

        public int RequestStatusId { get; set; }

        public int QtyRequested { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime RequestDate { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelDistRequestSchedule> RelDistRequestSchedule { get; set; }

        public virtual RelOrderPickUpDropOffLocation RelOrderPickUpDropOffLocation { get; set; }

        public virtual RequestStatus RequestStatus { get; set; }
    }
}
