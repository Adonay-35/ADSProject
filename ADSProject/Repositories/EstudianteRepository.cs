using ADSProject.Models;
using ADSProject.Interfaces;
using ADSProject.DB;

namespace ADSProject.Repositories
{
    public class EstudianteRepository : IEstudiante
    {
        /*private List<Estudiante> lstEstudiantes = new List<Estudiante>
        {
            new Estudiante{ IdEstudiante = 1, NombresEstudiante = "ERICK ADONAY",
            ApellidosEstudiante = "SALAZAR HERNANDEZ", CodigoEstudiante = "SH21I04001",
            CorreoEstudiante = "SH21I04001@usonsonate.edu.sv"
            }
        };*/

        private readonly ApplicationDbContext applicationDbContext; 

        public EstudianteRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public int ActualizarEstudiante(int idEstudiante, Estudiante estudiante)
        {
            try 
            {
                //int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

                //lstEstudiantes[indice] = estudiante;

                //return idEstudiante;
                //ACTUALIZACION DEL METODO
                var item = applicationDbContext.Estudiantes.SingleOrDefault(x => x.IdEstudiante == idEstudiante);
                applicationDbContext.Entry(item).CurrentValues.SetValues(estudiante);
                applicationDbContext.SaveChanges();
                return idEstudiante;
            }
            catch(Exception) 
            {
                throw;
            }
            //throw new NotImplementedException();
        }

        public int AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                /*if(lstEstudiantes.Count > 0) 
                {
                    estudiante.IdEstudiante = lstEstudiantes.Last().IdEstudiante + 1;
                }

                lstEstudiantes.Add(estudiante);

                return estudiante.IdEstudiante;*/

                applicationDbContext.Estudiantes.Add(estudiante);
                applicationDbContext.SaveChanges();

                return estudiante.IdEstudiante;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool EliminarEstudiante(int idEstudiante)
        {
            try
            {
                //Obtenemos el indice para eliminar estudiantes 
                /*
                int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

                lstEstudiantes.RemoveAt(indice);

                return true;*/

                var item = applicationDbContext.Estudiantes.SingleOrDefault(x => x.IdEstudiante == idEstudiante);
                applicationDbContext.Estudiantes.Remove(item);  
                applicationDbContext.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public Estudiante ObtenerEstudiantePorID(int idEstudiante)
        {
            try
            {
                //Buscamos y asignamos el objeto estudiante
                //Estudiante estudiante = lstEstudiantes.FirstOrDefault(tmp => tmp.IdEstudiante == idEstudiante);
                //return estudiante;

                var estudiante = applicationDbContext.Estudiantes.SingleOrDefault(x => x.IdEstudiante == idEstudiante);
                return estudiante;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<Estudiante> ObtenerTodosLosEstudiantes()
        {
            try
            {
                //return lstEstudiantes;

                return applicationDbContext.Estudiantes.ToList();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
