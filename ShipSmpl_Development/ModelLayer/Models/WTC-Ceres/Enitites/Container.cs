namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Container")]
    public partial class Container
    {
        public int ContainerId { get; set; }

        public int ContainerStatusId { get; set; }

        public int ContainerSizeId { get; set; }

        [Required]
        [StringLength(11)]
        public string ContainerNumber { get; set; }

        public int OwnerId { get; set; }

        public int SSLineId { get; set; }

        [StringLength(10)]
        public string StressLevel { get; set; }

        public int CurrentYardLocationId { get; set; }

        public bool HasGrainDoor { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }

        public virtual Company Company { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual ContainerSize ContainerSize { get; set; }

        public virtual ContainerStatus ContainerStatus { get; set; }

        public virtual YardLocation YardLocation { get; set; }
    }
}
