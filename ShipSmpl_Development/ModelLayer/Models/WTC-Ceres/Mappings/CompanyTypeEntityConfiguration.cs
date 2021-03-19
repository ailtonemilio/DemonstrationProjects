using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class CompanyTypeEntityConfiguration : EntityTypeConfiguration<CompanyType>
    {
        public CompanyTypeEntityConfiguration()
        {
            this.Property(e => e.DescCompanyType)
            .IsUnicode(false);

            this.HasMany(e => e.BookingCompany)
                .WithRequired(e => (CompanyType)e.CompanyType)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CompanyCompanyType)
                .WithRequired(e => e.CompanyType)
                .HasForeignKey(e => e.CompanyTypeId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CompanyCompanyType1)
                .WithRequired(e => e.CompanyType1)
                .HasForeignKey(e => e.CompanyTypeId)
                .WillCascadeOnDelete(false);
        }
    }
}