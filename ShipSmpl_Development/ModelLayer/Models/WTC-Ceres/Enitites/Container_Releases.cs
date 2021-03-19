namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Container Releases")]
    public partial class Container_Releases
    {
        [Key]
        [Column("Release ID")]
        public int Release_ID { get; set; }

        [Column("Date Created", TypeName = "date")]
        public DateTime? Date_Created { get; set; }

        [Column("User Created")]
        public bool? User_Created { get; set; }

        public int? MiniBookingID { get; set; }

        [Column("Ship Line Code")]
        [StringLength(10)]
        public string Ship_Line_Code { get; set; }

        [Column("Ship Line Name")]
        [StringLength(50)]
        public string Ship_Line_Name { get; set; }

        [Column("Release Number")]
        [StringLength(40)]
        public string Release_Number { get; set; }

        [Column("Release Type")]
        [StringLength(1)]
        public string Release_Type { get; set; }

        [Column("Terminal Code")]
        [StringLength(10)]
        public string Terminal_Code { get; set; }

        [Column("Terminal Name")]
        [StringLength(50)]
        public string Terminal_Name { get; set; }

        [StringLength(2)]
        public string Quantity { get; set; }

        [Column("Container Size")]
        [StringLength(1)]
        public string Container_Size { get; set; }

        [Column("Amount Received")]
        [StringLength(2)]
        public string Amount_Received { get; set; }

        [Column("Excel File Name")]
        [StringLength(50)]
        public string Excel_File_Name { get; set; }

        [Column("Last Released", TypeName = "date")]
        public DateTime? Last_Released { get; set; }

        public bool? ActiveRelease { get; set; }
    }
}
