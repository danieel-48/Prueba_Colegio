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
    
    public partial class MateriasProfesor
    {
        public long Id_materiaprofesor { get; set; }
        public Nullable<long> Identificacion_Profesor { get; set; }
        public string Nombre_Profesor { get; set; }
        public string Apellido_Profesor { get; set; }
        public Nullable<long> Codigo_Asignatura { get; set; }
        public string Nombre_Asignatura { get; set; }
    
        public virtual Asignaturas Asignaturas { get; set; }
        public virtual Profesores Profesores { get; set; }
    }
}
