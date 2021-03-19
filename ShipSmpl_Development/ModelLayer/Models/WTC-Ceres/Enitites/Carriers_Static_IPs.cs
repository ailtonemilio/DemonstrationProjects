namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Carriers Static IPs")]
    public partial class Carriers_Static_IPs
    {
        [Key]
        [Column("Record ID")]
        public int Record_ID { get; set; }

        [Column("Carrier ID")]
        [StringLength(10)]
        public string Carrier_ID { get; set; }

        [Column("Static IP Address")]
        [StringLength(15)]
        public string Static_IP_Address { get; set; }
    }
}
