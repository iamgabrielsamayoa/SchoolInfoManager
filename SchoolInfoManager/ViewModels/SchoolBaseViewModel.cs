using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolInfoShared.Models;

namespace SchoolInfoManager.ViewModels
{
    public class SchoolBaseViewModel
    {
        public Alumno Alumno { get; set; } = new Alumno();

        public SelectList MaestrosSelectListItems { get; set; }

        
    }
}