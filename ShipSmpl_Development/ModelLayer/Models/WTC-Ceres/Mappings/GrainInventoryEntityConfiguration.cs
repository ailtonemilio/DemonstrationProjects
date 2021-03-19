using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class GrainInventoryEntityConfiguration : EntityTypeConfiguration<GrainInventory>
    {
        public GrainInventoryEntityConfiguration()
        {
            this.HasMany(e => e.GrainInventoryTransaction)
            .WithRequired(e => e.GrainInventory)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.GrainInventoryTransfer)
                .WithRequired(e => e.GrainInventory)
                .HasForeignKey(e => e.GiverGrainInventoryId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.GrainInventoryTransfer1)
                .WithRequired(e => e.GrainInventory1)
                .HasForeignKey(e => e.ReceiverGrainInventoryId)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.GrainInvStorageLocation)
                .WithRequired(e => e.GrainInventory)
                .WillCascadeOnDelete(false);
        }
    }
}