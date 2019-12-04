﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_DiplomadoCodeFirst.Models.Models
{
    public class Inscripcion
    {
        public int InscripcionId { get; set; }
        public int CursoId { get; set; }
        public int EstudianteId { get; set; }
        public int Semestre { get; set; }
        public virtual Estudiante Estudiante { get; set; }
        public virtual Courso Courso { get; set; }
    }
}
