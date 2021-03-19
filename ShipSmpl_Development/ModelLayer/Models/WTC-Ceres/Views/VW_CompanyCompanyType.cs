namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_CompanyCompanyType
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CompanyId { get; set; }

        [StringLength(10)]
        public string CompanyCode { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        [Column(TypeName = "text")]
        public string Notes { get; set; }

        public int? Rating { get; set; }

        public bool? EDIRequired { get; set; }

        public int? CustomerRateTypeId { get; set; }

        [StringLength(100)]
        public string RateDescription { get; set; }

        [StringLength(200)]
        public string Attention { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CompanyTypeId { get; set; }

        [StringLength(30)]
        public string DescCompanyType { get; set; }

        [StringLength(10)]
        public string RateCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CompanyCategoryId { get; set; }

        [StringLength(20)]
        public string Category { get; set; }
    }
}
