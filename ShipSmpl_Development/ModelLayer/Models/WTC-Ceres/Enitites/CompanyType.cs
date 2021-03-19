namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyType")]
    public partial class CompanyType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyType()
        {
            BookingCompany = new HashSet<BookingCompany>();
            BookingCompanyChangeLog = new HashSet<BookingCompanyChangeLog>();
            CompanyCompanyType = new HashSet<CompanyCompanyType>();
            CompanyCompanyType1 = new HashSet<CompanyCompanyType>();
        }

        public int CompanyTypeId { get; set; }

        [StringLength(30)]
        public string DescCompanyType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingCompany> BookingCompany { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingCompanyChangeLog> BookingCompanyChangeLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyCompanyType> CompanyCompanyType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyCompanyType> CompanyCompanyType1 { get; set; }
    }
}
