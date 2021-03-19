using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class StorageTypeEntityConfiguration : EntityTypeConfiguration<StorageType>
    {
        public StorageTypeEntityConfiguration()
        {
            this.Property(e => e.StorageTypeName)
            .IsUnicode(false);

            this.HasMany(e => e.BagLocation)
                .WithRequired(e => e.StorageType)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.GrainInvStorageLocation)
                .WithRequired(e => e.StorageType)
                .WillCascadeOnDelete(false);
        }
    }
}