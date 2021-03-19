namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_RegionCity
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string CountryName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string CountryCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string RegionCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string CityName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryRegionId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionCityId { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(3)]
        public string CityCode { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(105)]
        public string CityAndRegion { get; set; }
    }
}
