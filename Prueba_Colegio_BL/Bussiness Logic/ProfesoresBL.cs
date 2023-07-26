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
    public class ProfesoresBL
    {
        ProfesoresDA profesoresDA;

        public List<Profesores> Registrar_Profesores(List<Profesores> profesores)
        {
            profesoresDA = new ProfesoresDA();
            profesoresDA.Registrar_Profesor(profesores);
            return profesores;
        }
        public List<Profesores> Consultar()
        {
            profesoresDA = new ProfesoresDA();
            var consulta = profesoresDA.Consultar();
            return consulta;
        }
        public Profesores Actualizar_Profesor(int id, Profesores item)
        {
            profesoresDA = new ProfesoresDA();
            profesoresDA.Actualizar_Profesor(id, item);
            return item;
        }
        public List<MateriasProfesor> Registrar_MateriaProfesores(List<MateriasProfesor> mprofesores)
        {
            profesoresDA = new ProfesoresDA();
            profesoresDA.Registrar_MateriaProfesor(mprofesores);
            return mprofesores;
        }
        public MateriasProfesor Consultar_Materia(long identificacion)
        {
            profesoresDA = new ProfesoresDA();
            var consulta = profesoresDA.Consultar_Materia(identificacion);
            return consulta;
        }
        public MateriasProfesor Consultar_Asignatura(long cod)
        {
            profesoresDA = new ProfesoresDA();
            var consulta = profesoresDA.Consultar_Asignatura(cod);
            return consulta;
        }
    }
}
