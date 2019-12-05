using MVC_CRUD_DiplomadoCodeFirst.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_DiplomadoCodeFirst.Models.DAL
{
    public class SeedDB : System.Data.Entity.DropCreateDatabaseAlways<CarreraContext>
    {
        protected override void Seed(CarreraContext context)
        {
            var coursos = new List<Courso>{
                new Courso {Descripcion = "Literatura"},
                new Courso {Descripcion = "Matematicas"}
            };
            coursos.ForEach(c => context.Coursos.Add(c));
            context.SaveChanges();

            var estudiantes = new List<Estudiante>
            {
                new Estudiante {Nombres= "Jonathan", Apellidos = "Lorenzo Contrera", Fecha_Inscripcion = DateTime.Parse("2019/01/01")},
                new Estudiante {Nombres= "Luis Alfredo", Apellidos = "Calderon Sanchez", Fecha_Inscripcion = DateTime.Parse("2019/01/01")}
            };

            estudiantes.ForEach(e => context.Estudiantes.Add(e));
            context.SaveChanges();

            var inscripciones = new List<Inscripcion>
            {
                new Inscripcion{EstudianteId = 1, CursoId = 1, Semestre = 1},
                new Inscripcion{EstudianteId = 2, CursoId = 2, Semestre = 2}
            };

            inscripciones.ForEach(i => context.Inscripciones.Add(i));
            context.SaveChanges();
        }
    }
}
