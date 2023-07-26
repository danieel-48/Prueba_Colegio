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

        public Profesores Actualizar_Profesor(int id, Profesores item)
        {
            context = new PruebaColegioEntities();

            context.Configuration.AutoDetectChangesEnabled = false;
            context.Configuration.ValidateOnSaveEnabled = false;

            context.sp_ActualizarProfesor(id, item.Nombre, item.Apellido, item.Edad, item.Direccion, item.Telefono);
            context.SaveChanges();

            return item;
            
        }
        public List<Profesores> Consultar()
        {
            context = new PruebaColegioEntities();

            var consulta = (from db in context.Profesores
                            select db).ToList();

            return consulta;
        }
        public List<MateriasProfesor> Registrar_MateriaProfesor(List<MateriasProfesor> mprofesores)
        {
            context = new PruebaColegioEntities();
            context.Configuration.AutoDetectChangesEnabled = false;
            context.Configuration.ValidateOnSaveEnabled = false;

            foreach (var item in mprofesores)
            {
                context.MateriasProfesor.Add(item);
                context.SaveChanges();
            }
            return mprofesores;

        }
        public MateriasProfesor Consultar_Materia(long identificacion)
        {
            context = new PruebaColegioEntities();

            var consulta = (from db in context.MateriasProfesor
                            where db.Identificacion_Profesor == identificacion
                            select db).FirstOrDefault();

            return consulta;
        }
        public MateriasProfesor Consultar_Asignatura(long cod)
        {
            context = new PruebaColegioEntities();

            var consulta = (from db in context.MateriasProfesor
                            where db.Codigo_Asignatura == cod
                            select db).FirstOrDefault();

            return consulta;
        }
    }
}
