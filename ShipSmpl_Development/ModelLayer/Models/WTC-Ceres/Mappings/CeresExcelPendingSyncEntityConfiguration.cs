using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class CeresExcelPendingSyncEntityConfiguration : EntityTypeConfiguration<CeresExcelPendingSync>
    {
        public CeresExcelPendingSyncEntityConfiguration()
        {
            this.Property(e => e.SyncType)
            .IsUnicode(false);

            this.Property(e => e.ExtraInfo)
                .IsUnicode(false);

            this.Property(e => e.CurrentStatus)
                .IsUnicode(false);

            this.Property(e => e.SyncMessage)
                .IsUnicode(false);
        }
    }
}