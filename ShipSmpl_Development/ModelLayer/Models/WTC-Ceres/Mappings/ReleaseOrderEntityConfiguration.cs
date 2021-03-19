using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class ReleaseOrderEntityConfiguration : EntityTypeConfiguration<ReleaseOrder>
    {
        public ReleaseOrderEntityConfiguration()
        {
            this.HasMany(e => e.RelOrderPickUpDropOffLocation)
            .WithRequired(e => e.ReleaseOrder)
            .WillCascadeOnDelete(false);
        }
    }
}