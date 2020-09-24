using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolInfoShared.Models;

namespace SchoolInfoManager.ViewModels
{
    public class SchoolAlumnosAddViewModel
    {
        public IEnumerable<Curso> Materias { get; set; }

        public Alumno Alumno { get; set; }

    }
}