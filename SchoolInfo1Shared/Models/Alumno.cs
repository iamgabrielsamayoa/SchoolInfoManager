using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInfoShared.Models
{
    public class Alumno
    {
        //public Alumno()
        //{
        //    cursos = new List<Curso>();
        //}

        public int Id { get; set; }

        public string Nombre { get; set; }


        public string Email { get; set; }

        public string Carne { get; set; }

        public ICollection<Curso> cursos { get; set; }

    }
}
