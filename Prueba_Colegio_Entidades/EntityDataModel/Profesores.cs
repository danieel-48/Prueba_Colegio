//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prueba_Colegio_Entidades.EntityDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profesores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profesores()
        {
            this.MateriasProfesor = new HashSet<MateriasProfesor>();
        }
    
        public long Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<short> Edad { get; set; }
        public string Direccion { get; set; }
        public Nullable<long> Telefono { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MateriasProfesor> MateriasProfesor { get; set; }
    }
}
