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
        public Profesores Consultar_Existencia(long identificacion)
        {
            profesoresDA = new ProfesoresDA();
            var consulta = profesoresDA.Consultar_Existencia(identificacion);
            return consulta;
        }
    }
}
