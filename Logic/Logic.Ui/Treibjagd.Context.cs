﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JaegerMeister.MvvmSample.Logic.Ui
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TreibjagdTestEntities : DbContext
    {
        public TreibjagdTestEntities()
            : base("name=TreibjagdTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Abfrage> tbl_Abfrage { get; set; }
        public virtual DbSet<tbl_Abschussliste> tbl_Abschussliste { get; set; }
        public virtual DbSet<tbl_Dokumente> tbl_Dokumente { get; set; }
        public virtual DbSet<tbl_Jaeger> tbl_Jaeger { get; set; }
        public virtual DbSet<tbl_Jagderfolge> tbl_Jagderfolge { get; set; }
        public virtual DbSet<tbl_Login> tbl_Login { get; set; }
        public virtual DbSet<tbl_Passwoerter> tbl_Passwoerter { get; set; }
        public virtual DbSet<tbl_Postausgang> tbl_Postausgang { get; set; }
        public virtual DbSet<tbl_Rueckmeldung> tbl_Rueckmeldung { get; set; }
        public virtual DbSet<tbl_Sicherheitsfragen> tbl_Sicherheitsfragen { get; set; }
        public virtual DbSet<tbl_Termine> tbl_Termine { get; set; }
        public virtual DbSet<tbl_Tiere> tbl_Tiere { get; set; }
    }
}