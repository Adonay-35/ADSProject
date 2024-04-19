using ADSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ADSProject.DB
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        //Con un Dbsetr se uidica aEntityFramewoorkCore cuales van a ser las tablas que yo quiera tener en la BD
        //y tambien le diremos en base a que modelos o entidades vamos a basar dichas tablas, por ejemplo

        public DbSet<Estudiante> Estudiantes { get; set; } 
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Profesor> Profesores { get; set; }

    }
}
