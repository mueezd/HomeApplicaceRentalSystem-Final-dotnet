﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeApplicaceRentalSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HomeApplicaceRentalSystemDbEntities : DbContext
    {
        public HomeApplicaceRentalSystemDbEntities()
            : base("name=HomeApplicaceRentalSystemDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tblCustomer> tblCustomers { get; set; }
        public DbSet<tblItem> tblItems { get; set; }
        public DbSet<tblUser> tblUsers { get; set; }
    }
}
