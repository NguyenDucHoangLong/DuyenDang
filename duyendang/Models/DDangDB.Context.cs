﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace duyendang.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DUYENDANGDBEntities : DbContext
    {
        public DUYENDANGDBEntities()
            : base("name=DUYENDANGDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<album> albums { get; set; }
        public virtual DbSet<cataloge> cataloges { get; set; }
        public virtual DbSet<information> information { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
