namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentsStoredGroup")]
    public partial class DocumentsStoredGroup
    {
        public int DocumentsStoredGroupId { get; set; }

        [StringLength(25)]
        public string DesDocumentsStoredGroup { get; set; }

        public int? DocumentsStoredDepartmentId { get; set; }

        public int? DocumentsStoredTypeId { get; set; }

        public virtual DocumentsStoredDepartment DocumentsStoredDepartment { get; set; }

        public virtual DocumentsStoredType DocumentsStoredType { get; set; }
    }
}
