﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenRecuperacion_Abraham
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class bdRutas : DbContext
    {
        public bdRutas()
            : base("name=bdRutas")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ventas> Ventas { get; set; }
    
        public virtual int CalcularMontosVenta(string tipoCliente, Nullable<int> cantidadPersonas, Nullable<int> tipoRuta, ObjectParameter importeBruto, ObjectParameter porcentajeDescuento, ObjectParameter montoDescuento, ObjectParameter importePago)
        {
            var tipoClienteParameter = tipoCliente != null ?
                new ObjectParameter("TipoCliente", tipoCliente) :
                new ObjectParameter("TipoCliente", typeof(string));
    
            var cantidadPersonasParameter = cantidadPersonas.HasValue ?
                new ObjectParameter("CantidadPersonas", cantidadPersonas) :
                new ObjectParameter("CantidadPersonas", typeof(int));
    
            var tipoRutaParameter = tipoRuta.HasValue ?
                new ObjectParameter("TipoRuta", tipoRuta) :
                new ObjectParameter("TipoRuta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CalcularMontosVenta", tipoClienteParameter, cantidadPersonasParameter, tipoRutaParameter, importeBruto, porcentajeDescuento, montoDescuento, importePago);
        }
    }
}
