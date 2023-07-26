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
    public class EstudiantesBL
    {
        EstudiantesDA estudiantesDA;

        public List<Estudiantes> Registrar_Estudiantes(List<Estudiantes> estudiantes)
        {
            estudiantesDA = new EstudiantesDA();
            estudiantesDA.Registrar_Estudiante(estudiantes);
            return estudiantes;
        }
        public Estudiantes Actualizar_Estudiante(int id, Estudiantes item)
        {
            estudiantesDA = new EstudiantesDA();
            estudiantesDA.Actualizar_Estudiante(id, item);
            return item;
        }
        public List<Calificaciones> Registrar_Calificacion(List<Calificaciones> calificaciones)
        {
            estudiantesDA = new EstudiantesDA();
            estudiantesDA.Registrar_Calificacion(calificaciones);
            return calificaciones;
        }
        public Calificaciones Consultar_Asignatura(long cod, long year)
        {
            estudiantesDA = new EstudiantesDA();
            var consulta = estudiantesDA.Consultar_Asignatura(cod, year);
            return consulta;
        }
        public List<vw_Alumnos> Consultar_Estudiante()
        {
            estudiantesDA = new EstudiantesDA();
            var consulta = estudiantesDA.Consultar_Estudiante();
            return consulta;
        }
        public void Eliminar_Estudiante(long id)
        {
            estudiantesDA = new EstudiantesDA();
            estudiantesDA.Eliminar_Estudiante(id);

        }
        public Calificaciones Consultar_EstudianteAsignatura(long id)
        {
            estudiantesDA = new EstudiantesDA();
            var consulta = estudiantesDA.Consultar_EstudianteAsignatura(id);
            return consulta;
        }
    }
}
