﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diseniandote.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class diseniandoteEntities : DbContext
    {
        public diseniandoteEntities()
            : base("name=diseniandoteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Almacen> Almacen { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<DatosEnvio> DatosEnvio { get; set; }
        public DbSet<DatosFacturacion> DatosFacturacion { get; set; }
        public DbSet<DetallePedido> DetallePedido { get; set; }
        public DbSet<DetalleProduccion> DetalleProduccion { get; set; }
        public DbSet<Domicilio> Domicilio { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<inventario> inventario { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Medida> Medida { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Produccion> Produccion { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Tarjeta> Tarjeta { get; set; }
        public DbSet<TipoEmpleado> TipoEmpleado { get; set; }
        public DbSet<TipoProduccion> TipoProduccion { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}