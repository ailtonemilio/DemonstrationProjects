using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class RelDistChangeReqScheduleEntityConfiguration : EntityTypeConfiguration<RelDistChangeReqSchedule>
    {
        public RelDistChangeReqScheduleEntityConfiguration()
        {
            this.Property(e => e.CarrierMessage)
            .IsUnicode(false);

            this.Property(e => e.WTCNote)
            .IsUnicode(false);

            this.HasMany(e => e.RelDistChangeReqScheduleDeclinedQty)
            .WithRequired(e => e.RelDistChangeReqSchedule)
            .WillCascadeOnDelete(false);
        }
    }
}