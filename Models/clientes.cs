//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clientes()
        {
            this.solicitudes = new HashSet<solicitudes>();
        }
    
        public int id_cliente { get; set; }
        public string identificacion { get; set; }
        public string nombre_completo { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public int id_departamento { get; set; }
        public int id_ciudad { get; set; }
        public int edad { get; set; }
    
        public virtual ciudades ciudades { get; set; }
        public virtual departamentos departamentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitudes> solicitudes { get; set; }
    }
}
