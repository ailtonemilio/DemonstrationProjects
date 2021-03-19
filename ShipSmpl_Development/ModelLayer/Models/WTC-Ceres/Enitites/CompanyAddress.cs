namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyAddress")]
    public partial class CompanyAddress
    {
        public int CompanyAddressId { get; set; }

        [StringLength(200)]
        public string StreetAddress { get; set; }

        [StringLength(20)]
        public string ZipCode { get; set; }

        [StringLength(30)]
        public string Phone { get; set; }

        [StringLength(30)]
        public string Fax { get; set; }

        public bool? MainAddress { get; set; }

        public string AddressDescription { get; set; }

        public int? CompanyId { get; set; }

        public int? RegionCityId { get; set; }

        public virtual Company Company { get; set; }

        public virtual RegionCity RegionCity { get; set; }
    }
}
