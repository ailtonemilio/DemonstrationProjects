namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyCompanyType")]
    public partial class CompanyCompanyType
    {
        public int CompanyCompanyTypeId { get; set; }

        public int CompanyId { get; set; }

        public int CompanyTypeId { get; set; }

        public virtual Company Company { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual CompanyType CompanyType { get; set; }

        public virtual CompanyType CompanyType1 { get; set; }
    }
}
