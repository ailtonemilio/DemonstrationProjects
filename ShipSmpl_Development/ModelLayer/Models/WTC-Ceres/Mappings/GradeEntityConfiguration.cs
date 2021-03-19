using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class GradeEntityConfiguration : EntityTypeConfiguration<Grade>
    {
        public GradeEntityConfiguration()
        {
            this.Property(e => e.GradeCode)
            .IsUnicode(false);

            this.Property(e => e.GradeName)
            .IsUnicode(false);

            this.HasMany(e => e.MiniBookingCommodity)
            .WithRequired(e => e.Grade)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.MiniUnit)
             .WithRequired(e => e.Grade)
             .WillCascadeOnDelete(false);
        }
    }
}