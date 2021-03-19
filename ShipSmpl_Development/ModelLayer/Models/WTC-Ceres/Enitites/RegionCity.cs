namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegionCity")]
    public partial class RegionCity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegionCity()
        {
            CompanyAddress = new HashSet<CompanyAddress>();
        }

        public int RegionCityId { get; set; }

        public int CountryRegionId { get; set; }

        [Required]
        [StringLength(100)]
        public string CityName { get; set; }

        [Required]
        [StringLength(3)]
        public string CityCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyAddress> CompanyAddress { get; set; }

        public virtual CountryRegion CountryRegion { get; set; }
    }
}
