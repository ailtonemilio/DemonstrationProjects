namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentsStoredType")]
    public partial class DocumentsStoredType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentsStoredType()
        {
            DocumentsStored = new HashSet<DocumentsStored>();
            DocumentsStoredGroup = new HashSet<DocumentsStoredGroup>();
        }

        public int DocumentsStoredTypeId { get; set; }

        [StringLength(150)]
        public string DescDocumentsStoredType { get; set; }

        public int? DocumentsStoredDepartmentId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentsStored> DocumentsStored { get; set; }

        public virtual DocumentsStoredDepartment DocumentsStoredDepartment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentsStoredGroup> DocumentsStoredGroup { get; set; }
    }
}
