namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contacts
    {
        public int ID { get; set; }

        [Column("Company ID")]
        public int? Company_ID { get; set; }

        [Column("First Name")]
        [StringLength(50)]
        public string First_Name { get; set; }

        [Column("Last Name")]
        [StringLength(50)]
        public string Last_Name { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(6)]
        public string Extension { get; set; }

        [Column("Second Address ID")]
        public int? Second_Address_ID { get; set; }

        [Column(TypeName = "text")]
        public string Notes { get; set; }
    }
}
