using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class DocumentsStoredEntityConfiguration : EntityTypeConfiguration<DocumentsStored>
    {
        public DocumentsStoredEntityConfiguration()
        {
            this.Property(e => e.FileTitle)
            .IsUnicode(false);

            this.Property(e => e.FileDescription)
                .IsUnicode(false);

            this.Property(e => e.ServerPath)
                .IsUnicode(false);

            this.Property(e => e.FileName)
                .IsUnicode(false);
        }
    }
}