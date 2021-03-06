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
    
    public partial class Persona
    {
        public Persona()
        {
            this.Cliente = new HashSet<Cliente>();
            this.Empleado = new HashSet<Empleado>();
        }
    
        public int idpersona { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public System.DateTime fechaNac { get; set; }
        public Nullable<bool> estatus { get; set; }
        public string telefonoCasa { get; set; }
        public string telefonoMovil { get; set; }
        public int idDomicilio { get; set; }
    
        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual Domicilio Domicilio { get; set; }
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
