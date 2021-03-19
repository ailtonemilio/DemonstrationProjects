using WebInvoiceApp.Common.Identity.Users;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace WebInvoiceApp.Common.Identity.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext()
           : base("webinvoiceConnectionString")
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<WebInvoiceApp.Common.Identity.Users.AspNetRegisterVM> RegisterViewModels { get; set; }
    }
}
