namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerRateType")]
    public partial class CustomerRateType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerRateType()
        {
            CompanyCustomerRateType = new HashSet<CompanyCustomerRateType>();
        }

        public int CustomerRateTypeId { get; set; }

        [StringLength(10)]
        public string RateCode { get; set; }

        [StringLength(100)]
        public string RateDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyCustomerRateType> CompanyCustomerRateType { get; set; }
    }
}
