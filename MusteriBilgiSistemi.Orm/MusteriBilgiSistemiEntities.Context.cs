﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusteriBilgiSistemi.Orm
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MusteriBilgiSistemiEntities : DbContext
    {
        public MusteriBilgiSistemiEntities()
            : base("name=MusteriBilgiSistemiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cariler> Cariler { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Licence> Licence { get; set; }
        public DbSet<Musteriler> Musteriler { get; set; }
        public DbSet<OdemeTuru> OdemeTuru { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Sepet> Sepet { get; set; }
        public DbSet<SepetDetay> SepetDetay { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<urunler> urunler { get; set; }
    }
}
