﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample_Linq_Code
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class vtdi_gate_log_dbEntities : DbContext
    {
        public vtdi_gate_log_dbEntities()
            : base("name=vtdi_gate_log_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GateInOut> GateInOuts { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<ItemsToDeclare> ItemsToDeclares { get; set; }
        public virtual DbSet<PurposeOfVisit> PurposeOfVisits { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VehicleType> VehicleTypes { get; set; }
    }
}