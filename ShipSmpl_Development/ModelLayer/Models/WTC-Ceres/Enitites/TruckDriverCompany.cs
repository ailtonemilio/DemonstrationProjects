namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TruckDriverCompany")]
    public partial class TruckDriverCompany
    {
        public int TruckDriverCompanyId { get; set; }

        [Required]
        [StringLength(15)]
        public string PortPassId { get; set; }

        [StringLength(10)]
        public string TruckNumber { get; set; }

        public int? TruckDriverId { get; set; }

        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public virtual TruckDriver TruckDriver { get; set; }
    }
}
