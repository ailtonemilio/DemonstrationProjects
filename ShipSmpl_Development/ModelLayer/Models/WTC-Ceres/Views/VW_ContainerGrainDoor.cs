namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_ContainerGrainDoor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrainDoorID { get; set; }

        public int? ContainerID { get; set; }

        public bool? ExteriorInteriorCheck { get; set; }

        public bool? DirtCheck { get; set; }

        public bool? ObjectionableOdorCheck { get; set; }

        public bool? OilStainCheck { get; set; }

        public bool? InsectRodentCheck { get; set; }

        public bool? DampnessCheck { get; set; }

        public bool? VisibleLightCheck { get; set; }

        public bool? ObjectionableConditionCheck { get; set; }

        public bool? GrainDoorComplete { get; set; }

        public DateTime? LastUpdate { get; set; }
    }
}
