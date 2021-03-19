namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Allowed Transfers")]
    public partial class Allowed_Transfers
    {
        public int ID { get; set; }

        [Column("Created By")]
        public int? Created_By { get; set; }

        [Column("Trucker Code")]
        [StringLength(8)]
        public string Trucker_Code { get; set; }

        [Column("Container Number")]
        [StringLength(11)]
        public string Container_Number { get; set; }

        public int? Size { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        [StringLength(10)]
        public string Weight { get; set; }

        [StringLength(15)]
        public string From { get; set; }

        [StringLength(15)]
        public string To { get; set; }

        [Column("Date of Creation", TypeName = "smalldatetime")]
        public DateTime? Date_of_Creation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Due { get; set; }

        [Column("Type of Transfer")]
        [StringLength(15)]
        public string Type_of_Transfer { get; set; }
    }
}
