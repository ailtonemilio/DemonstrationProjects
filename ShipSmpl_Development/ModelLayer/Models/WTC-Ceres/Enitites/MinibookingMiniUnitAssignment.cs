namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MinibookingMiniUnitAssignment")]
    public partial class MinibookingMiniUnitAssignment
    {
        public int MinibookingMiniUnitAssignmentId { get; set; }

        public int MinibookingId { get; set; }

        public int MiniUnitId { get; set; }

        public DateTime? AssignedAt { get; set; }

        public virtual Minibooking Minibooking { get; set; }

        public virtual MiniUnit MiniUnit { get; set; }
    }
}
