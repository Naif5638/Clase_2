using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_DiplomadoCodeFirst.Models.Models
{
    public class Courso
    {
        public int CursoId { get; set; }
        public string Descripcion { get; set; }
        public virtual  ICollection<Inscripcion> Inscripciones { get; set; }
    }
}
