﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CompanyEntities : DbContext
    {
        public CompanyEntities()
            : base("CompanyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<HistoryOfParcel> HistoryOfParcel { get; set; }
        public virtual DbSet<Localization> Localization { get; set; }
        public virtual DbSet<Parcel> Parcel { get; set; }
        public virtual DbSet<ParcelMoving> ParcelMoving { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeOfDocument> TypeOfDocument { get; set; }
        public virtual DbSet<TypeOfParcel> TypeOfParcel { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
    }
}
