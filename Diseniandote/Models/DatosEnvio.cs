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
    
    public partial class DatosEnvio
    {
        public int idDatosEnvio { get; set; }
        public int idCliente { get; set; }
        public int idDomicilio { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Domicilio Domicilio { get; set; }
    }
}