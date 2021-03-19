using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models.WTC_Ceres.Mappings
{
    public class EmployeeEntityConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeEntityConfiguration()
        {
            this.Property(e => e.CardId)
            .IsUnicode(false);

            this.Property(e => e.PhoneId)
            .IsUnicode(false);

            this.Property(e => e.FirstName)
            .IsUnicode(false);

            this.Property(e => e.LastName)
            .IsUnicode(false);

            this.Property(e => e.AliasName)
            .IsUnicode(false);

            this.Property(e => e.Address)
            .IsUnicode(false);

            this.Property(e => e.WorkType)
            .IsUnicode(false);

            this.Property(e => e.YardLocation)
            .IsUnicode(false);

            this.Property(e => e.EmployeeStatus)
            .IsUnicode(false);

            this.Property(e => e.PhoneNumber)
            .IsUnicode(false);

            this.Property(e => e.FirstNameEmergContact)
            .IsUnicode(false);

            this.Property(e => e.LastNameEmergContact)
            .IsUnicode(false);

            this.Property(e => e.PhoneNumberEmergContact)
            .IsUnicode(false);

            this.Property(e => e.RelationshipEmergContact)
            .IsUnicode(false);

            this.Property(e => e.SINNumber)
            .IsUnicode(false);

            this.Property(e => e.Gender)
            .IsUnicode(false);

            this.Property(e => e.JobDescription)
            .IsUnicode(false);

            this.Property(e => e.PayMethod)
            .IsUnicode(false);

            this.Property(e => e.Supervisor)
            .IsUnicode(false);

            this.Property(e => e.Email)
            .IsUnicode(false);

            this.Property(e => e.EmployeePicturePath)
            .IsUnicode(false);

            this.HasMany(e => e.EmployeeActivityLog)
            .WithRequired(e => e.Employee)
            .WillCascadeOnDelete(false);
        }
    }
}