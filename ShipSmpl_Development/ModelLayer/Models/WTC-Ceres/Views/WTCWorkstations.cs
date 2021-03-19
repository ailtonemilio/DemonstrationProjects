namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WTCWorkstations
    {
        [Key]
        [Column("WorkStation ID")]
        public int WorkStation_ID { get; set; }

        [Column("WorkStation Name")]
        [StringLength(15)]
        public string WorkStation_Name { get; set; }

        [Column("Workstation Type")]
        [StringLength(15)]
        public string Workstation_Type { get; set; }

        public bool? PrintFSDLoadPlan { get; set; }
    }
}
