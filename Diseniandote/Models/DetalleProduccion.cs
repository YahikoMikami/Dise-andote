//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DetalleProduccion
    {
        public int idDetalleProduccion { get; set; }
        public int idMaterial { get; set; }
        public int idProduccion { get; set; }
        public double cantidad { get; set; }
        public double subCosto { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Produccion Produccion { get; set; }
    }
}
