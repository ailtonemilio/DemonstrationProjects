//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebInvoiceApp.UI.Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class webinvoiceEntities : DbContext
    {
        public webinvoiceEntities()
            : base("name=webinvoiceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACCESS> ACCESS { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Issuer> Issuer { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<StatusInvoice> StatusInvoice { get; set; }
        public virtual DbSet<TypeTaxProd> TypeTaxProd { get; set; }
        public virtual DbSet<TypeTaxServ> TypeTaxServ { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
    }
}
