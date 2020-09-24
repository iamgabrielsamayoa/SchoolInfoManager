using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInfoShared.Models
{
    public class Profesor
    {
        public Profesor()
        {
            Cursos = new List<Curso>();
        }

        public int Id { get; set; }

        public string Nombre { get; set; }
       
        public ICollection<Curso> Cursos { get; set; }

    }
}
