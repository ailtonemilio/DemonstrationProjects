namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DrayageSchemeRate")]
    public partial class DrayageSchemeRate
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrayageRateId { get; set; }

        public int? DrayageSchemeId { get; set; }

        [StringLength(10)]
        public string TruckingCompany { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TruckingCompanyId { get; set; }

        [StringLength(10)]
        public string FromDock { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FromDockId { get; set; }

        [StringLength(10)]
        public string ToDock { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ToDockId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FromDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; }

        public decimal? Rate { get; set; }

        [StringLength(15)]
        public string RateType { get; set; }
    }
}
