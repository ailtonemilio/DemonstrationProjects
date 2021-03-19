namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContainerMinibooking")]
    public partial class ContainerMinibooking
    {
        public int ContainerMinibookingId { get; set; }

        public int ContainerInOutId { get; set; }

        public int MinibookingId { get; set; }

        public DateTime? AssignedAt { get; set; }
    }
}