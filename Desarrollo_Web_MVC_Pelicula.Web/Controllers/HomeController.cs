using Desarrollo_Web_MVC_Pelicula.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desarrollo_Web_MVC_Pelicula.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            RegistroPelicula rp = new RegistroPelicula();

            return View(rp.ListarPeliculas());
        }

        public ActionResult Grabar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Grabar(Pelicula pelicula)
        {
            RegistroPelicula rg = new RegistroPelicula();
            rg.GrabarPelicula(pelicula);
            return RedirectToAction("Index");
        }

        public ActionResult Borrar(int cod)
        {
            RegistroPelicula registroPelicula = new RegistroPelicula();
            registroPelicula.Borrar(cod);
            return RedirectToAction("Index");
        }

        public ActionResult Modificar(int cod)
        {
            RegistroPelicula registroPelicula = new RegistroPelicula();
            Pelicula pelicula = registroPelicula.Detail(cod);
            return View(pelicula);
        }

        [HttpPost]
        public ActionResult Modificar(Pelicula pelicula)
        {
            if (ModelState.IsValid)
            {
                RegistroPelicula registroPelicula = new RegistroPelicula();

                registroPelicula.Modificar(pelicula);

                return this.RedirectToAction("Index");
            }

            return this.View();
        }
    }
}