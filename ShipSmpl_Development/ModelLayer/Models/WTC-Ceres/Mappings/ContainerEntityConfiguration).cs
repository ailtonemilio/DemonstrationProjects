using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class ContainerEntityConfiguration : EntityTypeConfiguration<Container>
    {
        public ContainerEntityConfiguration()
        {
            this.Property(e => e.ContainerNumber)
            .IsUnicode(false);

            this.Property(e => e.StressLevel)
            .IsUnicode(false);
        }
    }
}