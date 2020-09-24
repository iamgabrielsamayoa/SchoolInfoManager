using SchoolInfoShared.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInfoShared.Data
{
    public class Context : DbContext
    {
        //Conn to DB
        public Context() : base("Context")
        {
        }


        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<FechaInscripcion> FechaInscripcion { get; set; }

        public DbSet<Profesor> Profesor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Removing the pluralizing table name convention 
            // so our table names will use our entity class singular names.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           
        }
    }
}
