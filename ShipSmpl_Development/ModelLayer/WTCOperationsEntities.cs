using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ModelLayer
{
    public partial class WTCOperationsEntities : DbContext
    {
        public WTCOperationsEntities()
            : base("name=WTCOperationsEntities")
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Safety_and_Risk_Management_Clearance> Safety_and_Risk_Management_Clearance { get; set; }
        public virtual DbSet<Time_Sheet> Time_Sheet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>()
                .Property(e => e.Card_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Phone_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Yard)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Phone_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.FirstName_Emerg_Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.LastName_Emerg_Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.PhoneNumber_Emerg_Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Relationship_Emerg_Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.SIN_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Job_Description)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Pay_Method)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Supervisor)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.EmployeePicturePath)
                .IsUnicode(false);

            modelBuilder.Entity<Time_Sheet>()
                .Property(e => e.Punch_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Time_Sheet>()
                .Property(e => e.Site_Location)
                .IsUnicode(false);

            modelBuilder.Entity<Time_Sheet>()
                .Property(e => e.Device_IP_Address)
                .IsUnicode(false);
        }
    }
}
