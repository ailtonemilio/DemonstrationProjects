namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyCustomerRateType")]
    public partial class CompanyCustomerRateType
    {
        public int CompanyCustomerRateTypeId { get; set; }

        public int CompanyId { get; set; }

        public int CustomerRateTypeId { get; set; }

        public virtual Company Company { get; set; }

        public virtual CustomerRateType CustomerRateType { get; set; }
    }
}
