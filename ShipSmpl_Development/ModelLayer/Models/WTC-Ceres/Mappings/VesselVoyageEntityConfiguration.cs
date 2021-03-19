using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class VesselVoyageEntityConfiguration : EntityTypeConfiguration<VesselVoyage>
    {
        public VesselVoyageEntityConfiguration()
        {
            this.Property(e => e.VoyageNumber)
            .IsUnicode(false);

            this.Property(e => e.PortCity)
                .IsUnicode(false);

            this.Property(e => e.PortCountry)
                .IsUnicode(false);

            this.HasMany(e => e.Booking)
                .WithRequired(e => (VesselVoyage)e.VesselVoyage)
                .WillCascadeOnDelete(false);
        }
    }
}