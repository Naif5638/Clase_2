using MVC_CRUD_DiplomadoCodeFirst.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_DiplomadoCodeFirst.Models.DAL
{
    public class CarreraContext : DbContext
    {
        public CarreraContext():base("CarreraContex")
        {            
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Courso> Coursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}
