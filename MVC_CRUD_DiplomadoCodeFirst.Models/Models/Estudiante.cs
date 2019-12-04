using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_DiplomadoCodeFirst.Models.Models
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime Fecha_Inscripcion { get; set; }
        public virtual ICollection<Inscripcion> Inscripciones { get; set; }
    }
}
