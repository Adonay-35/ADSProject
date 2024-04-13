using ADSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ADSProject.DB
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        //Con un Dbsetr se undica aEntityFramewoorkCore cuales van a ser las tablas que yo quiera tener en la BD
        //y tambien le diremos enbase aque modelos o entidades vamos a basar dichas tablas, por ejemplo

        public DbSet<Estudiante> Estudiantes { get; set; }

    }
}
