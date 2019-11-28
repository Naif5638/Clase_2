using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto1_Diplomado_Web_MVC_UASD.web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "<html> <body>" +
                "<h1>Universidad Autonoma de Santo Domingo (UASD)</h1>" +
                "<p>Diplomado Desarrollo Web C#, MVC </p>" +
                "</body></html>";
        }

        public string DiplomadoWeb()
        {
            return "<html> <body>" +
                "<h1>Estudiantes:</h1>" +
                "<p>Yorqui Montero Sanchez<br>" +
                "Junior Maria Araujo<br>" +
                "Marileidy Manzueta de la Rosa<p>" +
                "</body></html>";
        }
    }
}