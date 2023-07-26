using Prueba_Colegio_Entidades.EntityDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Colegio_Datos.DataAccess
{
    public class ProfesoresDA
    {
        PruebaColegioEntities context;
        public List<Profesores> Registrar_Profesor(List<Profesores> profesores)
        {
            context = new PruebaColegioEntities();
            context.Configuration.AutoDetectChangesEnabled = false;
            context.Configuration.ValidateOnSaveEnabled = false;

            foreach (var item in profesores)
            {
                context.Profesores.Add(item);
                context.SaveChanges();
            }
            return profesores;

        }

        public Profesores Consultar_Existencia(long identificacion)
        {
            context = new PruebaColegioEntities();

            var consulta = (from db in context.Profesores
                            where db.Identificacion == identificacion
                            select db).FirstOrDefault();

            return consulta;

        }
    }
}
