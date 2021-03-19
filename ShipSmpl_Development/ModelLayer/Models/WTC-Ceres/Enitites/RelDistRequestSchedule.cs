namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RelDistRequestSchedule")]
    public partial class RelDistRequestSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RelDistRequestSchedule()
        {
            RelDistChangeReqSchedule = new HashSet<RelDistChangeReqSchedule>();
            RelDistScheduleAccepted = new HashSet<RelDistScheduleAccepted>();
        }

        public int RelDistRequestScheduleId { get; set; }

        public int ReleaseDistributionRequestId { get; set; }

        public int RequestStatusId { get; set; }

        public int QtyRequested { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FromDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ToDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateRequested { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelDistChangeReqSchedule> RelDistChangeReqSchedule { get; set; }

        public virtual ReleaseDistributionRequest ReleaseDistributionRequest { get; set; }

        public virtual RequestStatus RequestStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelDistScheduleAccepted> RelDistScheduleAccepted { get; set; }
    }
}
