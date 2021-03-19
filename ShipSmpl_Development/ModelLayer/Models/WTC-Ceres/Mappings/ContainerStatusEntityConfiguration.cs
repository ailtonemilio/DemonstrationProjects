using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class ContainerStatusEntityConfiguration : EntityTypeConfiguration<ContainerStatus>
    {
        public ContainerStatusEntityConfiguration()
        {
            this.Property(e => e.StatusName)
            .IsUnicode(false);

            this.HasMany(e => e.Container)
            .WithRequired(e => e.ContainerStatus)
            .WillCascadeOnDelete(false);
        }
    }
}