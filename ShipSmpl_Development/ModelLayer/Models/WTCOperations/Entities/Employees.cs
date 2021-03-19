namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string Card_ID { get; set; }

        [StringLength(20)]
        public string Phone_ID { get; set; }

        [StringLength(30)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Last_Name { get; set; }

        [StringLength(30)]
        public string Alias { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(10)]
        public string Type { get; set; }

        [StringLength(10)]
        public string Yard { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        [StringLength(20)]
        public string Phone_Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Start_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? End_Date { get; set; }

        [StringLength(30)]
        public string FirstName_Emerg_Contact { get; set; }

        [StringLength(30)]
        public string LastName_Emerg_Contact { get; set; }

        [StringLength(20)]
        public string PhoneNumber_Emerg_Contact { get; set; }

        [StringLength(20)]
        public string Relationship_Emerg_Contact { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birth_Date { get; set; }

        [StringLength(15)]
        public string SIN_Number { get; set; }

        [StringLength(7)]
        public string Gender { get; set; }

        [StringLength(40)]
        public string Job_Description { get; set; }

        [StringLength(25)]
        public string Pay_Method { get; set; }

        [StringLength(15)]
        public string Supervisor { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(300)]
        public string EmployeePicturePath { get; set; }
    }
}
