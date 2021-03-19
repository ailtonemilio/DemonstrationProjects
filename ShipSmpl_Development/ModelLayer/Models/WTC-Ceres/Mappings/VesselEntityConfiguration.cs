using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class VesselEntityConfiguration : EntityTypeConfiguration<Vessel>
    {
        public VesselEntityConfiguration()
        {
            this.Property(e => e.VesselName)
            .IsUnicode(false);

            this.Property(e => e.VesselOwner)
                .IsUnicode(false);

            this.Property(e => e.Manager)
                .IsUnicode(false);

            this.Property(e => e.Capacity)
                .HasPrecision(15, 3);

            this.Property(e => e.Flag)
                .IsUnicode(false);
        }
    }
}