using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInfoShared.Models
{
    class ProfesorCurso
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public int ProfesorId { get; set; }
        public Curso curso { get; set; }

        public Profesor profesor { get; set; }
    }
}
