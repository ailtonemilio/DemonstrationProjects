namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingCompanyChangeLog")]
    public partial class BookingCompanyChangeLog
    {
        public int BookingCompanyChangeLogId { get; set; }

        public int BookingGroupId { get; set; }

        public int? GroupCounter { get; set; }

        public int? BookingId { get; set; }

        public int CompanyId { get; set; }

        public int CompanyTypeId { get; set; }

        public virtual Company Company { get; set; }

        public virtual CompanyType CompanyType { get; set; }
    }
}
