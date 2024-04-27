using ADSProject.DB;
using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class MateriaRepository : IMateria
    {
        //private List<Materia> lstMaterias = new List<Materia>
        //{
        //    new Materia{ Id = 1, Nombre = "Desarrollo de Software"
        //    }
        //};

        private readonly ApplicationDbContext applicationDbContext;

        public MateriaRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public int ActualizarMateria(int idMateria, Materia materia)
        {
            try
            {
                //int indice = lstMaterias.FindIndex(tmp => tmp.Id == idMateria);

                //lstMaterias[indice] = Materia;

                //return idMateria;

                var item = applicationDbContext.Materias.SingleOrDefault(x => x.Id == idMateria);
                applicationDbContext.Entry(item).CurrentValues.SetValues(materia);
                applicationDbContext.SaveChanges();
                return idMateria;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AgregarMateria(Materia materia)
        {
            try
            {
                //if (lstMaterias.Count > 0)
                //{
                //    materia.Id = lstMaterias.Last().Id + 1;
                //}

                //lstMaterias.Add(materia);

                //return materia.Id;

                applicationDbContext.Materias.Add(materia);
                applicationDbContext.SaveChanges();

                return materia.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarMateria(int idMateria)
        {
            try
            {
                //int indice = lstMaterias.FindIndex(tmp => tmp.Id == idMateria);

                //lstMaterias.RemoveAt(indice);

                //return true;

                var item = applicationDbContext.Materias.SingleOrDefault(x => x.Id == idMateria);
                applicationDbContext.Materias.Remove(item);
                applicationDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Materia ObtenerMateriaPorID(int idMateria)
        {
            try
            {
                //Materia materia = lstMaterias.FirstOrDefault(tmp => tmp.Id == idMateria);
                //return materia;

                var materia = applicationDbContext.Materias.SingleOrDefault(x => x.Id == idMateria);
                return materia;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Materia> ObtenerTodosLasMaterias()
        {
            try
            {
                //return lstMaterias;

                return applicationDbContext.Materias.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    }
