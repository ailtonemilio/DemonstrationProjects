using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class GrainInventoryTransactionEntityConfiguration : EntityTypeConfiguration<GrainInventoryTransaction>
    {
        public GrainInventoryTransactionEntityConfiguration()
        {
            this.HasMany(e => e.GrainInventoryTransfer)
            .WithRequired(e => e.GrainInventoryTransaction)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.GrainInvMinibookingTransaction)
                .WithRequired(e => e.GrainInventoryTransaction)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.GrainInvTransactionGrainStorageLocation)
                .WithRequired(e => e.GrainInventoryTransaction)
                .WillCascadeOnDelete(false);
        }
    }
}