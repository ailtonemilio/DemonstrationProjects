using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class TransactionTypeEntityConfiguration : EntityTypeConfiguration<TransactionType>
    {
        public TransactionTypeEntityConfiguration()
        {
            this.Property(e => e.TransactionTypeName)
             .IsUnicode(false);

            this.HasMany(e => e.BagInventoryTransaction)
             .WithRequired(e => e.TransactionType)
             .WillCascadeOnDelete(false);

            this.HasMany(e => e.GrainInventoryTransaction)
            .WithRequired(e => e.TransactionType)
            .WillCascadeOnDelete(false);
        }
    }
}