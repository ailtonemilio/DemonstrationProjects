using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class DocumentsStoredDepartmentEntityConfiguration : EntityTypeConfiguration<DocumentsStoredDepartment>
    {
        public DocumentsStoredDepartmentEntityConfiguration()
        {
            this.Property(e => e.DescDocumentsStoredDepartment)
            .IsUnicode(false);
        }
    }
}