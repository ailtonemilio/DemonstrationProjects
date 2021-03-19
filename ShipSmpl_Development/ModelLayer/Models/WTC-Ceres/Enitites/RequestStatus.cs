namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RequestStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RequestStatus()
        {
            InboundRequest = new HashSet<InboundRequest>();
            RelDistChangeReqSchedule = new HashSet<RelDistChangeReqSchedule>();
            RelDistRequestSchedule = new HashSet<RelDistRequestSchedule>();
            ReleaseDistributionRequest = new HashSet<ReleaseDistributionRequest>();
        }

        public int RequestStatusId { get; set; }

        [Required]
        [StringLength(20)]
        public string StatusName { get; set; }

        [Required]
        [StringLength(15)]
        public string FlowType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InboundRequest> InboundRequest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelDistChangeReqSchedule> RelDistChangeReqSchedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelDistRequestSchedule> RelDistRequestSchedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReleaseDistributionRequest> ReleaseDistributionRequest { get; set; }
    }
}
