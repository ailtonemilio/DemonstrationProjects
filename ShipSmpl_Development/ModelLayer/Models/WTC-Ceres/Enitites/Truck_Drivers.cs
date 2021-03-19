namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Truck Drivers")]
    public partial class Truck_Drivers
    {
        [Key]
        [Column("Port Pass ID")]
        [StringLength(15)]
        public string Port_Pass_ID { get; set; }

        [Column("First Name")]
        [StringLength(20)]
        public string First_Name { get; set; }

        [Column("Last Name")]
        [StringLength(20)]
        public string Last_Name { get; set; }

        [Column("Truck Company ID")]
        [StringLength(10)]
        public string Truck_Company_ID { get; set; }

        [Column("Truck Company Name")]
        [StringLength(40)]
        public string Truck_Company_Name { get; set; }

        [Column("Truck Number")]
        [StringLength(10)]
        public string Truck_Number { get; set; }

        [Column("Suspend Truck Driver")]
        public bool? Suspend_Truck_Driver { get; set; }
    }
}
