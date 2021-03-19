namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentsStoredDepartment")]
    public partial class DocumentsStoredDepartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentsStoredDepartment()
        {
            DocumentsStored = new HashSet<DocumentsStored>();
            DocumentsStoredGroup = new HashSet<DocumentsStoredGroup>();
            DocumentsStoredType = new HashSet<DocumentsStoredType>();
        }

        public int DocumentsStoredDepartmentId { get; set; }

        [StringLength(150)]
        public string DescDocumentsStoredDepartment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentsStored> DocumentsStored { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentsStoredGroup> DocumentsStoredGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentsStoredType> DocumentsStoredType { get; set; }
    }
}
