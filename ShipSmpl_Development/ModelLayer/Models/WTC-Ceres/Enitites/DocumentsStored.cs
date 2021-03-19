namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentsStored")]
    public partial class DocumentsStored
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentsStored()
        {
            DocumentsStoredBooking = new HashSet<DocumentsStoredBooking>();
        }

        public int DocumentsStoredId { get; set; }

        [StringLength(50)]
        public string FileTitle { get; set; }

        [StringLength(250)]
        public string FileDescription { get; set; }

        public string ServerPath { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IssueDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpireDate { get; set; }

        [StringLength(250)]
        public string FileName { get; set; }

        public int? EmployeeId { get; set; }

        public int? DocumentsStoredTypeId { get; set; }

        public int? DocumentsStoredDepartmentId { get; set; }

        public virtual DocumentsStoredDepartment DocumentsStoredDepartment { get; set; }

        public virtual DocumentsStoredType DocumentsStoredType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentsStoredBooking> DocumentsStoredBooking { get; set; }
    }
}
