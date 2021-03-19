using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class RequestStatusEntityConfiguration : EntityTypeConfiguration<RequestStatus>
    {
        public RequestStatusEntityConfiguration()
        {
            this.Property(e => e.StatusName)
            .IsUnicode(false);

            this.Property(e => e.FlowType)
                .IsUnicode(false);

            this.HasMany(e => e.InboundRequest)
                .WithRequired(e => e.RequestStatus)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.RelDistChangeReqSchedule)
                .WithRequired(e => e.RequestStatus)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.RelDistRequestSchedule)
                .WithRequired(e => e.RequestStatus)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.ReleaseDistributionRequest)
            .WithRequired(e => e.RequestStatus)
            .WillCascadeOnDelete(false);
        }
    }
}