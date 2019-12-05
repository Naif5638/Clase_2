using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_DiplomadoCodeFirst.Models.Models
{
    public class Inscripcion
    {
        [Key]
        public int InscripcionId { get; set; }

        public int CursoId { get; set; }
        public int EstudianteId { get; set; }
        public int Semestre { get; set; }
        public virtual Estudiante Estudiantes { get; set; }
        public virtual Courso Coursos { get; set; }
    }
}
