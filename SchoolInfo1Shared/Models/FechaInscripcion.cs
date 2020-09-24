using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInfoShared.Models
{
    public class FechaInscripcion
    {
        public int FechaInscripcionID { get; set; }

        public int CursoID { get; set; }

        public int AlumnoID { get; set; }

        public virtual Curso Curso { get; set; }
        public virtual Alumno Alumno { get; set; }
    }
}
