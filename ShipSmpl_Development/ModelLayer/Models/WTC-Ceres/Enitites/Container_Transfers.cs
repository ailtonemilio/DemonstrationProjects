namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Container Transfers")]
    public partial class Container_Transfers
    {
        public int ID { get; set; }

        [Column("Transferred By")]
        [StringLength(20)]
        public string Transferred_By { get; set; }

        [Column("Transferred To")]
        [StringLength(8)]
        public string Transferred_To { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Departure { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Arrive { get; set; }

        [Column("Container Number")]
        [StringLength(15)]
        public string Container_Number { get; set; }
    }
}
