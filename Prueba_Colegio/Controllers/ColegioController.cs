using Prueba_Colegio_BL.Bussiness_Logic;
using Prueba_Colegio_Entidades.EntityDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Prueba_Colegio.Controllers
{

    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class ColegioController : ApiController
    {
        ProfesoresBL profesoresBL;
        Profesores pf;

        [HttpPost]

        [Route("api/profesor")]

        public IHttpActionResult profesor([FromBody] Profesores item)
        {
            profesoresBL = new ProfesoresBL();

            var consulta = profesoresBL.Consultar_Existencia(item.Identificacion);

            if(consulta == null)
            {
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
            else
            {
                return BadRequest("Ya hay un registro existente");
            }
        }
    }
}