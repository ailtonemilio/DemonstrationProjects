namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RelDistChangeReqSchedule")]
    public partial class RelDistChangeReqSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RelDistChangeReqSchedule()
        {
            RelDistChangeReqScheduleDeclinedQty = new HashSet<RelDistChangeReqScheduleDeclinedQty>();
        }

        public int RelDistChangeReqScheduleId { get; set; }

        public int RelDistRequestScheduleId { get; set; }

        public int RequestStatusId { get; set; }

        public int QtyProposed { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FromDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ToDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateRequested { get; set; }

        public bool isRead { get; set; }

        [StringLength(500)]
        public string CarrierMessage { get; set; }

        [StringLength(500)]
        public string WTCNote { get; set; }

        public virtual RelDistRequestSchedule RelDistRequestSchedule { get; set; }

        public virtual RequestStatus RequestStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelDistChangeReqScheduleDeclinedQty> RelDistChangeReqScheduleDeclinedQty { get; set; }
    }
}
