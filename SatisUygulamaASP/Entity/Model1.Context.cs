﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SatisUygulamaASP.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbSatisASPEntities : DbContext
    {
        public dbSatisASPEntities()
            : base("name=dbSatisASPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblKategori> tblKategoris { get; set; }
        public virtual DbSet<tblMusteri> tblMusteris { get; set; }
        public virtual DbSet<tblPersonel> tblPersonels { get; set; }
        public virtual DbSet<tblSati> tblSatis { get; set; }
        public virtual DbSet<tblUrun> tblUruns { get; set; }
        public virtual DbSet<tblKullanici> tblKullanicis { get; set; }
    }
}