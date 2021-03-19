namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yard Static IPs")]
    public partial class Yard_Static_IPs
    {
        [Key]
        [Column("Record ID")]
        public int Record_ID { get; set; }

        [Column("Yard Code")]
        [StringLength(10)]
        public string Yard_Code { get; set; }

        [Column("Static IP Address")]
        [StringLength(15)]
        public string Static_IP_Address { get; set; }
    }
}
