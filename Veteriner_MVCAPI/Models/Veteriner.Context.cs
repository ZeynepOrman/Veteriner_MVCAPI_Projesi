﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veteriner_MVCAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Veteriner_MVCAPI_ProjesiEntities : DbContext
    {
        public Veteriner_MVCAPI_ProjesiEntities()
            : base("name=Veteriner_MVCAPI_ProjesiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Veteriner_Calisan> Veteriner_Calisan { get; set; }
        public virtual DbSet<Veteriner_Hizmet> Veteriner_Hizmet { get; set; }
        public virtual DbSet<Veteriner_Sube> Veteriner_Sube { get; set; }
        public virtual DbSet<Veteriner_Urun> Veteriner_Urun { get; set; }
        public virtual DbSet<UserMaster> UserMasters { get; set; }
    }
}
