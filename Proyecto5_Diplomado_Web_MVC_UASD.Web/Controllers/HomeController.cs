using Proyecto5_Diplomado_Web_MVC_UASD.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto5_Diplomado_Web_MVC_UASD.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var peliculas = new List<Pelicula>
            {
                new Pelicula {Titulo="The Godfather", Director = "Francis Ford Coppola", AutorPrincipal="Al Pacino", NumeroActores = 30, Duracion = 2, AnoEstreno = 1994},
                new Pelicula {Titulo = "The Shawshark", Director = "Frank Darabont", AutorPrincipal = "Morgan Freeman", NumeroActores = 15, Duracion = 3, AnoEstreno = 1972 },
                new Pelicula {Titulo = "The Matrix", Director = "Lana Wachowski", AutorPrincipal = "Keanu Reeves", NumeroActores = 15, Duracion = 2,AnoEstreno = 1999 },
                new Pelicula {Titulo = "City of God", Director = "Fernando Meirelles", AutorPrincipal = "Alexandre Rodriguez", NumeroActores = 10, Duracion = 3, AnoEstreno = 2002 },
                new Pelicula {Titulo = "Star Wars: Episode IV", Director = "George Lucas", AutorPrincipal = "Harrison Ford", NumeroActores = 20, Duracion = 3, AnoEstreno = 2007}
            };

            var result = from Pelicula in peliculas
                         where Pelicula.Titulo.Contains("The")
                         select Pelicula;

            return View(result);
        }

        public ActionResult ListarProductos()
        {
            var productos = new List<Producto>
            {
                new Producto {Id = 1, Descripcion = "Boligrafo", Precio = 8.35},
                new Producto {Id = 2, Descripcion = "Cuaderno Grande", Precio = 21.5},
                new Producto {Id = 3, Descripcion = "Cuaderno Pequeño", Precio = 10},
                new Producto {Id = 4, Descripcion = "Folios 500 uds", Precio = 550.55},
                new Producto {Id = 5, Descripcion = "Grapadora", Precio = 85.25},
                new Producto {Id = 6, Descripcion = "Tijeras", Precio = 62},
                new Producto {Id = 7, Descripcion = "Cinta Adhesiva", Precio = 45.10},
                new Producto {Id = 8, Descripcion = "Rotulador", Precio = 20.75},
                new Producto {Id = 9, Descripcion = "Mochila Escolar", Precio = 800.90},
                new Producto {Id = 10, Descripcion = "Pegamento Barra", Precio = 30.15},
                new Producto {Id = 11, Descripcion = "Lapicero", Precio = 15.55},
                new Producto {Id = 12, Descripcion = "Grapas", Precio = 40.90}
            };

            var result = from Producto in productos
                         where Producto.Precio < 70
                         select Producto;
            return View(result);
        }
    }
}