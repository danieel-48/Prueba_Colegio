using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Prueba_Colegio
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //CORS
            var corsAttr = new EnableCorsAttribute("http://localhost:3000", "*", "*");
            config.EnableCors(corsAttr);

            // Configuración y servicios de Web API

            // Rutas de Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
