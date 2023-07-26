using Prueba_Colegio_Entidades.EntityDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Colegio_Datos.DataAccess
{
    public class EstudiantesDA
    {
        PruebaColegioEntities context;
        public List<Estudiantes> Registrar_Estudiante(List<Estudiantes> estudiantes)
        {
            context = new PruebaColegioEntities();
            context.Configuration.AutoDetectChangesEnabled = false;
            context.Configuration.ValidateOnSaveEnabled = false;

            foreach (var item in estudiantes)
            {
                context.Estudiantes.Add(item);
                context.SaveChanges();
            }
            return estudiantes;

        }
        public Estudiantes Actualizar_Estudiante(int id, Estudiantes item)
        {
            context = new PruebaColegioEntities();

            context.Configuration.AutoDetectChangesEnabled = false;
            context.Configuration.ValidateOnSaveEnabled = false;

            context.sp_ActualizarAlumno(id, item.Nombre, item.Apellido, item.Edad, item.Direccion, item.Telefono);
            context.SaveChanges();

            return item;
        }
        public List<Calificaciones> Registrar_Calificacion(List<Calificaciones> calificaciones)
        {
            context = new PruebaColegioEntities();
            context.Configuration.AutoDetectChangesEnabled = false;
            context.Configuration.ValidateOnSaveEnabled = false;

            foreach (var item in calificaciones)
            {
                context.Calificaciones.Add(item);
                context.SaveChanges();
            }
            return calificaciones;

        }
        public Calificaciones Consultar_Asignatura(long cod, long year)
        {
            context = new PruebaColegioEntities();

            var consulta = (from db in context.Calificaciones
                            where db.Codigo_Asignatura == cod && db.Año_academico == year
                            select db).FirstOrDefault();

            return consulta;
        }
        public List<vw_Alumnos> Consultar_Estudiante()
        {
            context = new PruebaColegioEntities();

            var consulta = (from db in context.vw_Alumnos
                            select db).ToList();

            return consulta;
        }

        public void Eliminar_Estudiante(long id)
        {
            context = new PruebaColegioEntities();
            context.sp_EliminarAlumno(id);
            context.SaveChanges();

        }
        public Calificaciones Consultar_EstudianteAsignatura(long id)
        {
            context = new PruebaColegioEntities();

            var consulta = (from db in context.Calificaciones
                            where db.Identificación_Alumno == id
                            select db).FirstOrDefault();

            return consulta;
        }
    }
}
