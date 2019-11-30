using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Proyecto4_Diplomado_Web_MVC_UASD.Web.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        
        public void Regristrar(Persona persona)
        {
            StreamWriter archivo = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/persona.txt", true);
            archivo.WriteLine("<tr> <td>" + persona.Nombre + "</td>" + 
                "<td>" + persona.Cedula + "</td>" +
                "<td>"+ persona.Telefono + "</td>" +
                "<td>" + persona.Correo + "</td></tr>");
            archivo.Close();
        }

        public string LeerPersonas()
        {
            StreamReader archivo = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/persona.txt");
            string todo = archivo.ReadToEnd();
            archivo.Close();

            return todo;
           
        }
    }
}