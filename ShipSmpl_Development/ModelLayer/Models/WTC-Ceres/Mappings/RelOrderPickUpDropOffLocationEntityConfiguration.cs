using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class RelOrderPickUpDropOffLocationEntityConfiguration : EntityTypeConfiguration<RelOrderPickUpDropOffLocation>
    {
        public RelOrderPickUpDropOffLocationEntityConfiguration()
        {
            this.HasMany(e => e.ReleaseDistributionRequest)
            .WithRequired(e => e.RelOrderPickUpDropOffLocation)
            .WillCascadeOnDelete(false);
        }
    }
}