namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_Container
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContainerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(11)]
        public string ContainerNumber { get; set; }

        [StringLength(100)]
        public string ContainerOwner { get; set; }

        [StringLength(100)]
        public string SSLine { get; set; }

        [StringLength(10)]
        public string StressLevel { get; set; }

        [StringLength(15)]
        public string ContainerStatus { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CurrentYardLocationId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string ContainerSizeName { get; set; }

        [StringLength(50)]
        public string YardName { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool HasGrainDoor { get; set; }
    }
}
