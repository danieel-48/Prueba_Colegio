using Prueba_Colegio_Entidades.EntityDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Colegio_Datos.DataAccess
{
    public class AsignaturasDA
    {
        PruebaColegioEntities context;
        public List<Asignaturas> Registrar_Asignaturas(List<Asignaturas> asignaturas)
        {
            context = new PruebaColegioEntities();
            context.Configuration.AutoDetectChangesEnabled = false;
            context.Configuration.ValidateOnSaveEnabled = false;

            foreach (var item in asignaturas)
            {
                context.Asignaturas.Add(item);
                context.SaveChanges();
            }
            return asignaturas;

        }

        public List<vw_AlumnosProfesoresMaterias> ReporteAlumnos()
        {
            context = new PruebaColegioEntities();

            var consulta = (from db in context.vw_AlumnosProfesoresMaterias
                            select db).ToList();

            return consulta;

        }
    }
}
