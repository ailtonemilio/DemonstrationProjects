namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RelDistScheduleAccepted")]
    public partial class RelDistScheduleAccepted
    {
        public int RelDistScheduleAcceptedId { get; set; }

        public int RelDistRequestScheduleId { get; set; }

        public int QtyAccepted { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FromDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ToDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateAccepted { get; set; }

        [StringLength(500)]
        public string WTCMessage { get; set; }

        public virtual RelDistRequestSchedule RelDistRequestSchedule { get; set; }
    }
}
