﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SALONES.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SALONESEntities : DbContext
    {
        public SALONESEntities()
            : base("name=SALONESEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ciudades> ciudades { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<departamentos> departamentos { get; set; }
        public virtual DbSet<estado> estado { get; set; }
        public virtual DbSet<motivo> motivo { get; set; }
        public virtual DbSet<solicitudes> solicitudes { get; set; }
    }
}