using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class GrainInvStorageLocationEntityConfiguration : EntityTypeConfiguration<GrainInvStorageLocation>
    {
        public GrainInvStorageLocationEntityConfiguration()
        {
            this.HasMany(e => e.GrainInvMinibookingAssignment)
            .WithRequired(e => e.GrainInvStorageLocation)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.GrainInvTransactionGrainStorageLocation)
            .WithRequired(e => e.GrainInvStorageLocation)
            .WillCascadeOnDelete(false);
        }
    }
}