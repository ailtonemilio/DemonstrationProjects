using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class InboundRequestEntityConfiguration : EntityTypeConfiguration<InboundRequest>
    {
        public InboundRequestEntityConfiguration()
        {
            this.Property(e => e.ContainerState)
                .IsUnicode(false);

            this.HasMany(e => e.InboundFollowUpRequest)
                .WithRequired(e => e.InboundRequest)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.InboundReqDeclinedQty)
                .WithRequired(e => e.InboundRequest)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.ReleaseOrder)
                .WithRequired(e => e.InboundRequest)
                .WillCascadeOnDelete(false);
        }
    }
}