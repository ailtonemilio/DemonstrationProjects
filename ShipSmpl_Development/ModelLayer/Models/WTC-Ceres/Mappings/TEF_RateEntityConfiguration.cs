using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class TEF_RateEntityConfiguration : EntityTypeConfiguration<TEF_Rate>
    {
        public TEF_RateEntityConfiguration()
        {
            this.Property(e => e.RateType)
            .IsUnicode(false);

            this.Property(e => e.WkDaydCutOffTime)
                .HasPrecision(0);

            this.Property(e => e.WkDaysDayRate)
                .HasPrecision(18, 0);

            this.Property(e => e.WkDaysNightRate)
                .HasPrecision(18, 0);

            this.Property(e => e.WkEndsCutOffTime)
                .HasPrecision(0);

            this.Property(e => e.WkEndsDayRate)
                .HasPrecision(18, 0);

            this.Property(e => e.WkEndsNightRate)
                .HasPrecision(18, 0);

            this.Property(e => e.Terminal)
                .IsUnicode(false);
        }
    }
}