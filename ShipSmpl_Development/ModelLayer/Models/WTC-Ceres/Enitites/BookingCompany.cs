namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingCompany")]
    public partial class BookingCompany
    {
        public int BookingCompanyId { get; set; }

        public int BookingId { get; set; }

        public int CompanyId { get; set; }

        public int CompanyTypeId { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual Company Company { get; set; }

        public virtual CompanyType CompanyType { get; set; }
    }
}
