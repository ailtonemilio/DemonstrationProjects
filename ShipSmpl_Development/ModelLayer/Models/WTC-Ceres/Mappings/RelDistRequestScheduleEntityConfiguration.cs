using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class RelDistRequestScheduleEntityConfiguration : EntityTypeConfiguration<RelDistRequestSchedule>
    {
        public RelDistRequestScheduleEntityConfiguration()
        {
            this.HasMany(e => e.RelDistChangeReqSchedule)
            .WithRequired(e => e.RelDistRequestSchedule)
            .WillCascadeOnDelete(false);

            this.HasMany(e => e.RelDistScheduleAccepted)
            .WithRequired(e => e.RelDistRequestSchedule)
            .WillCascadeOnDelete(false);
        }
    }
}