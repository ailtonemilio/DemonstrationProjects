using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class DocumentsStoredGroupEntityConfiguration : EntityTypeConfiguration<DocumentsStoredGroup>
    {
        public DocumentsStoredGroupEntityConfiguration()
        {
            this.Property(e => e.DesDocumentsStoredGroup)
            .IsUnicode(false);
        }
    }
}