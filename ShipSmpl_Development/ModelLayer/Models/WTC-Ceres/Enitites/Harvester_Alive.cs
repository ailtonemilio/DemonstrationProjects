namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Harvester Alive")]
    public partial class Harvester_Alive
    {
        [Key]
        [Column("Record ID")]
        public int Record_ID { get; set; }

        [Column("Last Alive")]
        public DateTime? Last_Alive { get; set; }
    }
}
