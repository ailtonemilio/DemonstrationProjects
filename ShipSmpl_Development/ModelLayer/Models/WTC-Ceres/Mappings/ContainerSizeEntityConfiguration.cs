using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class ContainerSizeEntityConfiguration : EntityTypeConfiguration<ContainerSize>
    {
        public ContainerSizeEntityConfiguration()
        {
            this.Property(e => e.ContainerSizeName)
            .IsUnicode(false);

            this.HasMany(e => e.Container)
                .WithRequired(e => e.ContainerSize)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.InboundRequest)
                .WithRequired(e => e.ContainerSize)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Minibooking)
                .WithRequired(e => (ContainerSize)e.ContainerSize)
                .WillCascadeOnDelete(false);
        }
    }
}