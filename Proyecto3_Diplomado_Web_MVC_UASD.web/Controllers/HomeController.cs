using Proyecto3_Diplomado_Web_MVC_UASD.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto3_Diplomado_Web_MVC_UASD.web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    var coches = new List<Coche>
        //    {
        //        new Coche{Tipo = "Jeep", Marca = "BMW", Modelo = "XS", Color = "Azul"},
        //        new Coche{Tipo = "Auto", Marca = "Mercedez", Modelo = "A200", Color = "Blanco"},
        //        new Coche{Tipo = "Jeep", Marca = "Porshe", Modelo = "Cayanne", Color = "Negro"},
        //        new Coche{Tipo = "Auto", Marca = "Ford", Modelo = "Mustang", Color = "Rojo"},
        //        new Coche{Tipo = "Sedan", Marca = "Honda", Modelo = "Civic Turbo", Color = "Gris"},
        //    };

        //    return View(coches);
        //}

        public ActionResult Index()
        {
            var personas = new List<Persona>
            {
                new Persona{Nombre="Jonathan", Apellidos ="Lorenzo Contrera", FechaNacimiento = DateTime.Parse("1992/02/17")},
                new Persona{Nombre = "Luis Alfredo", Apellidos = "Calderon Sanchez", FechaNacimiento = DateTime.Parse("1993/05/15")}
            };

            return View(personas);
        }
    }
}