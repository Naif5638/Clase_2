using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto5_Diplomado_Web_MVC_UASD.Web.Models
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string AutorPrincipal { get; set; }
        public int NumeroActores { get; set; }
        public int Duracion { get; set; }
        public int AnoEstreno { get; set; }
    }
}