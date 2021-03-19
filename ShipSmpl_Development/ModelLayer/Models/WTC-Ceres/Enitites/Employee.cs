namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            EmployeeActivityLog = new HashSet<EmployeeActivityLog>();
            TimeSheet = new HashSet<TimeSheet>();
        }

        public int EmployeeId { get; set; }

        [StringLength(30)]
        public string CardId { get; set; }

        [StringLength(20)]
        public string PhoneId { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(30)]
        public string AliasName { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(10)]
        public string WorkType { get; set; }

        [StringLength(10)]
        public string YardLocation { get; set; }

        [StringLength(10)]
        public string EmployeeStatus { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [StringLength(30)]
        public string FirstNameEmergContact { get; set; }

        [StringLength(30)]
        public string LastNameEmergContact { get; set; }

        [StringLength(20)]
        public string PhoneNumberEmergContact { get; set; }

        [StringLength(20)]
        public string RelationshipEmergContact { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        [StringLength(15)]
        public string SINNumber { get; set; }

        [StringLength(7)]
        public string Gender { get; set; }

        [StringLength(40)]
        public string JobDescription { get; set; }

        [StringLength(25)]
        public string PayMethod { get; set; }

        [StringLength(15)]
        public string Supervisor { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(300)]
        public string EmployeePicturePath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeActivityLog> EmployeeActivityLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeSheet> TimeSheet { get; set; }
    }
}
