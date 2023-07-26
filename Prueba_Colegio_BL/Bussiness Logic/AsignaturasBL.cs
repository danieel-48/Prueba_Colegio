using Prueba_Colegio_Datos.DataAccess;
using Prueba_Colegio_Entidades.EntityDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Colegio_BL.Bussiness_Logic
{
    public class AsignaturasBL
    {
        AsignaturasDA asignaturasDA;

        public List<Asignaturas> Registrar_Asignaturas(List<Asignaturas> asignaturas)
        {
            asignaturasDA = new AsignaturasDA();
            asignaturasDA.Registrar_Asignaturas(asignaturas);
            return asignaturas;
        }
        public List<vw_AlumnosProfesoresMaterias> ReporteAlumnos()
        {
            asignaturasDA = new AsignaturasDA();
            var consulta = asignaturasDA.ReporteAlumnos();
            return consulta;
        }
    }
}
