namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReleaseOrderMinibooking")]
    public partial class ReleaseOrderMinibooking
    {
        public int ReleaseOrderMinibookingId { get; set; }

        public int ReleaseOrderId { get; set; }

        public int MinibookingId { get; set; }

        public int AssignmentOrder { get; set; }

        public int QtyRequested { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedAt { get; set; }

        public virtual Minibooking Minibooking { get; set; }

        public virtual ReleaseOrder ReleaseOrder { get; set; }
    }
}
