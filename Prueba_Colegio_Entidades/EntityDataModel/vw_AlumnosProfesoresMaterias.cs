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
    
    public partial class vw_AlumnosProfesoresMaterias
    {
        public Nullable<int> Año_academico { get; set; }
        public long Identificacion_Alumno { get; set; }
        public string Nombre_Alumno { get; set; }
        public Nullable<long> Codigo_Materia { get; set; }
        public string Nombre_Materia { get; set; }
        public Nullable<long> Identificacion_Profesor { get; set; }
        public string Nombre_Profesor { get; set; }
        public Nullable<decimal> Calificacion_Final { get; set; }
        public string Aprobo { get; set; }
    }
}
