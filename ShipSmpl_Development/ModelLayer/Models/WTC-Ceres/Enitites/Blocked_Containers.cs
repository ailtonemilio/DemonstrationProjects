namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Blocked Containers")]
    public partial class Blocked_Containers
    {
        public int ID { get; set; }

        [Column("Container Number")]
        [Required]
        [StringLength(11)]
        public string Container_Number { get; set; }

        [Column("SS LIne Code")]
        [StringLength(10)]
        public string SS_LIne_Code { get; set; }

        [Column("SS Line Name")]
        [StringLength(50)]
        public string SS_Line_Name { get; set; }

        [Column("Blocked Date", TypeName = "date")]
        public DateTime? Blocked_Date { get; set; }

        [Column("Block End Date", TypeName = "date")]
        public DateTime? Block_End_Date { get; set; }
    }
}
