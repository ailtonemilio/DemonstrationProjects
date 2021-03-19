using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class CompanyCategoryEntityConfiguration : EntityTypeConfiguration<CompanyCategory>
    {
        public CompanyCategoryEntityConfiguration()
        {
            this.Property(e => e.Category)
            .IsUnicode(false);

            this.HasMany(e => e.Company)
                .WithRequired(e => e.CompanyCategory)
                .HasForeignKey(e => e.CompanyCategoryId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Company1)
                .WithRequired(e => e.CompanyCategory1)
                .HasForeignKey(e => e.CompanyCategoryId)
                .WillCascadeOnDelete(false);
        }
    }
}