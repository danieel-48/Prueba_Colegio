using Prueba_Colegio_BL.Bussiness_Logic;
using Prueba_Colegio_Entidades.EntityDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Prueba_Colegio.Controllers
{

    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class ColegioController : ApiController
    {
        ProfesoresBL profesoresBL;
        Profesores pf;
        MateriasProfesor mpf;

        EstudiantesBL estudiantesBL;
        Estudiantes est;

        AsignaturasBL asignaturasBL;
        Asignaturas asg;
        Calificaciones cf;


        [HttpGet]
        [Route("api/consultaprofesor/{identificacion}")]
        public IHttpActionResult ConsultarAsignaturaProfesor(long identificacion)
        {
            profesoresBL = new ProfesoresBL();
            var asignaturaProfesor = profesoresBL.Consultar_Materia(identificacion);

            if (asignaturaProfesor != null)
            {
                return Ok(true); // El profesor tiene una asignatura asignada
            }
            else
            {
                return Ok(false); // El profesor no tiene una asignatura asignada
            }
        }

        [HttpGet]
        [Route("api/materiapf/{cod}")]
        public IHttpActionResult ConsultarProfesorAsignatura(long cod)
       {
            profesoresBL = new ProfesoresBL();
            var asignaturaProfesor = profesoresBL.Consultar_Asignatura(cod);

            if (asignaturaProfesor != null)
            {
                return Ok(true); // asignatura ya tiene un profesor asignado
            }
            else
            {
                return Ok(false); // asignatura no tiene un profesor asignado
            }
        }

        [HttpPost]

        [Route("api/profesor")]

        public IHttpActionResult profesor([FromBody] Profesores item)
        {
            profesoresBL = new ProfesoresBL();

            List<Profesores> profesores = new List<Profesores>();
            pf = new Profesores();

            pf.Identificacion = item.Identificacion;
            pf.Nombre = item.Nombre;
            pf.Apellido = item.Apellido;
            pf.Edad = item.Edad;
            pf.Direccion = item.Direccion;
            pf.Telefono = item.Telefono;

            profesores.Add(pf);

            profesoresBL.Registrar_Profesores(profesores);
            return Ok();
        }

        [HttpPost]

        [Route("api/asignaturaprofesor")]

        public IHttpActionResult materiaprofesor([FromBody] MateriasProfesor item)
        {
            profesoresBL = new ProfesoresBL();

            List<MateriasProfesor> mprofesores = new List<MateriasProfesor>();
            mpf = new MateriasProfesor();

            mpf.Identificacion_Profesor = item.Identificacion_Profesor;
            mpf.Nombre_Profesor = item.Nombre_Profesor;
            mpf.Apellido_Profesor = item.Apellido_Profesor;
            mpf.Codigo_Asignatura = item.Codigo_Asignatura;
            mpf.Nombre_Asignatura = item.Nombre_Asignatura;

            mprofesores.Add(mpf);

            profesoresBL.Registrar_MateriaProfesores(mprofesores);
            return Ok();
        }

        [HttpPut]
        [Route("api/editarprofesor/{id}")]
        public IHttpActionResult editarprofesor(int id, [FromBody] Profesores item)
        {
            profesoresBL = new ProfesoresBL();


            profesoresBL.Actualizar_Profesor(id, item);
            return Ok("Profesor actualizado exitosamente");

        }

        [HttpPost]

        [Route("api/estudiante")]
        public IHttpActionResult estudiante([FromBody] Estudiantes item)
        {
            estudiantesBL = new EstudiantesBL();

            List<Estudiantes> estudiantes = new List<Estudiantes>();
            est = new Estudiantes();

            est.Identificacion = item.Identificacion;
            est.Nombre = item.Nombre;
            est.Apellido = item.Apellido;
            est.Edad = item.Edad;
            est.Direccion = item.Direccion;
            est.Telefono = item.Telefono;

            estudiantes.Add(est);

            estudiantesBL.Registrar_Estudiantes(estudiantes);
            return Ok();
        }

        [HttpPut]
        [Route("api/editaralumno/{id}")]
        public IHttpActionResult editarestudiantes(int id, [FromBody] Estudiantes item)
        { 
            estudiantesBL = new EstudiantesBL();

            estudiantesBL.Actualizar_Estudiante(id, item);
            return Ok("Estudiante actualizado exitosamente");
        }

        [HttpPost]

        [Route("api/asignatura")]
        public IHttpActionResult asignatura([FromBody] Asignaturas item)
        {
            asignaturasBL = new AsignaturasBL();
            List<Asignaturas> asignaturas = new List<Asignaturas>();

            asg = new Asignaturas();
            asg.Codigo = item.Codigo;
            asg.Nombre = item.Nombre;

            asignaturas.Add(asg);

            asignaturasBL.Registrar_Asignaturas(asignaturas);
            return Ok();

        }


        [HttpPost]

        [Route("api/calificaciones")]
        public IHttpActionResult calificaciones([FromBody] Calificaciones item)
        {
            estudiantesBL = new EstudiantesBL();

            List<Calificaciones> calificaciones = new List<Calificaciones>();
            cf = new Calificaciones();

            cf.Año_academico = item.Año_academico;
            cf.Identificación_Alumno = item.Identificación_Alumno;
            cf.Nombre_Alumno = item.Nombre_Alumno;
            cf.Codigo_Asignatura = item.Codigo_Asignatura;
            cf.Nombre_Asignatura = item.Nombre_Asignatura;
            cf.Calificacion = item.Calificacion;

            calificaciones.Add(cf);

            estudiantesBL.Registrar_Calificacion(calificaciones);
            return Ok();

        }
        [HttpGet]
        [Route("api/asigcalif/{cod}/{year}")]
        public IHttpActionResult ConsultarEstudianteAsignatura(long cod, long year)
        {
            estudiantesBL = new EstudiantesBL();
            var asignaturaEstudiante = estudiantesBL.Consultar_Asignatura(cod, year);

            if (asignaturaEstudiante != null)
            {
                return Ok(true); // asignatura ya tiene un profesor asignado
            }
            else
            {
                return Ok(false); // asignatura no tiene un profesor asignado
            }
        }
        [HttpGet]
        [Route("api/consultaestudiante")]

        public IHttpActionResult consultaestudiante()
        {
            estudiantesBL = new EstudiantesBL();
            var consulta = estudiantesBL.Consultar_Estudiante();

            return Ok(consulta);
        }

        [HttpDelete]
        [Route("api/eliminar/{codigo}")]
        public IHttpActionResult EliminarEstudiante(int codigo)
        {
            estudiantesBL = new EstudiantesBL();
            estudiantesBL.Eliminar_Estudiante(codigo);
            return Ok();
        }

        [HttpGet]
        [Route("api/estasig/{codigoAlumno}")]

        public IHttpActionResult consultaestudiante_asignatura(long codigoAlumno)
        {
            estudiantesBL = new EstudiantesBL();
            var asignaturaEstudiante = estudiantesBL.Consultar_EstudianteAsignatura(codigoAlumno);

            if (asignaturaEstudiante != null)
            {
                // Si el alumno tiene una materia asignada, devolver true
                return Ok(new { tieneAsignaturaAsignada = true });
            }
            else
            {
                // Si el alumno no tiene una materia asignada, devolver false
                return Ok(new { tieneAsignaturaAsignada = false });
            }
        }

        [HttpGet]
        [Route("api/reporte")]

        public IHttpActionResult profesor()
        {
            asignaturasBL = new AsignaturasBL();
            var consulta = asignaturasBL.ReporteAlumnos();

            return Ok(consulta);
        }
    }
}