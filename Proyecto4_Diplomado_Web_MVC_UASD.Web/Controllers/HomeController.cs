using Proyecto4_Diplomado_Web_MVC_UASD.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto4_Diplomado_Web_MVC_UASD.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormularioVisita()
        {
            return View();
        }

        public ActionResult CargaDatos()
        {
            string nombre = "";
            string comentarios = "";

            nombre = Request.Form["nombre"].ToString();
            comentarios = Request.Form["comentarios"].ToString();

            LibroVisitas libro = new LibroVisitas();
            libro.Grabar(nombre, comentarios);
            return View();
        }

        public ActionResult ListadoVisitas()
        {
            LibroVisitas libro = new LibroVisitas();
            string todo = libro.Leer();
            ViewData["libro"] = todo;

            return View();
        }

        public ActionResult Persona(Persona model)
        {
            return View();   
        }

        public ActionResult RegistraPersona()
        {
            Persona persona = new Persona();
            persona.Nombre = Request.Form["Nombre"].ToString();
            persona.Cedula = Request.Form["Cedula"].ToString();
            persona.Telefono = Request.Form["Telefono"].ToString();
            persona.Correo = Request.Form["Correo"].ToString();

            persona.Regristrar(persona);
            return View();
        }

        public ActionResult ListarPersonas()
        {
            Persona persona = new Persona();
            string todo = persona.LeerPersonas();
            ViewData["lista"] = todo;

            return View();
        }
    }
}