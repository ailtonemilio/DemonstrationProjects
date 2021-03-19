namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EDI Records")]
    public partial class EDI_Records
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EDI_Records()
        {
            ManualEDILog = new HashSet<ManualEDILog>();
        }

        [Key]
        public int EDIRecID { get; set; }

        [Column("In-Out Unique ID")]
        public int? In_Out_Unique_ID { get; set; }

        [Column("Gate Mode")]
        [StringLength(10)]
        public string Gate_Mode { get; set; }

        [Column("Input Source")]
        [StringLength(80)]
        public string Input_Source { get; set; }

        [Column("User ID")]
        public int? User_ID { get; set; }

        [Column("Device Name")]
        [StringLength(20)]
        public string Device_Name { get; set; }

        [Column("Date and Time")]
        public DateTime? Date_and_Time { get; set; }

        [Column("User Name")]
        [StringLength(100)]
        public string User_Name { get; set; }

        public DateTime? ConfHandShakeDateTime { get; set; }

        [StringLength(50)]
        public string EDIFileName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManualEDILog> ManualEDILog { get; set; }
    }
}