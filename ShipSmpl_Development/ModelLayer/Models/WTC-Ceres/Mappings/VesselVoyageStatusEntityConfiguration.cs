using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class VesselVoyageStatusEntityConfiguration : EntityTypeConfiguration<VesselVoyageStatus>
    {
        public VesselVoyageStatusEntityConfiguration()
        {
            this.Property(e => e.StatusName)
            .IsUnicode(false);
        }
    }
}