namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WTC Containers")]
    public partial class WTC_Containers
    {
        public int ID { get; set; }

        [Column("Container Number")]
        [StringLength(16)]
        public string Container_Number { get; set; }

        public int? Size { get; set; }

        [Column("Possession Date", TypeName = "date")]
        public DateTime? Possession_Date { get; set; }

        [Column("Current Location")]
        [StringLength(20)]
        public string Current_Location { get; set; }

        [Column(TypeName = "text")]
        public string Comments { get; set; }
    }
}
