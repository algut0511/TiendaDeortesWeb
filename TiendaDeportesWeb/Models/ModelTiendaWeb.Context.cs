﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaDeportesWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tiendaEntities : DbContext
    {
        public tiendaEntities()
            : base("name=tiendaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categorias> categorias { get; set; }
        public virtual DbSet<dominios> dominios { get; set; }
        public virtual DbSet<fabricantes> fabricantes { get; set; }
        public virtual DbSet<personas> personas { get; set; }
        public virtual DbSet<productos> productos { get; set; }
        public virtual DbSet<venta_productos> venta_productos { get; set; }
        public virtual DbSet<ventas> ventas { get; set; }
    }
}
