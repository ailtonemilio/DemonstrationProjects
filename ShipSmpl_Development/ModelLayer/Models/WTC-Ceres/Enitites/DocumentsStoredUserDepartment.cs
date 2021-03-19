namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentsStoredUserDepartment")]
    public partial class DocumentsStoredUserDepartment
    {
        public int DocumentsStoredUserDepartmentId { get; set; }

        public int? DocumentsStoredDepartmentId { get; set; }

        public int? UserId { get; set; }
    }
}
