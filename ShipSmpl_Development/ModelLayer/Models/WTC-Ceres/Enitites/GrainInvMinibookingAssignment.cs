namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrainInvMinibookingAssignment")]
    public partial class GrainInvMinibookingAssignment
    {
        public int GrainInvMinibookingAssignmentId { get; set; }

        public int MinibookingId { get; set; }

        public int GrainInvStorageLocationId { get; set; }

        public double QuantityAssigned { get; set; }

        public DateTime? AssignedAt { get; set; }

        public virtual GrainInvStorageLocation GrainInvStorageLocation { get; set; }

        public virtual Minibooking Minibooking { get; set; }
    }
}
