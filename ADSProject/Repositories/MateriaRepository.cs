using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class MateriaRepository : IMateria
    {
        private List<Materia> lstMaterias = new List<Materia>
        {
            new Materia{ Id = 1, Nombre = "Desarrollo de Software"
            }
        };

        public int ActualizarMateria(int idMateria, Materia Materia)
        {
            try
            {
                int indice = lstMaterias.FindIndex(tmp => tmp.Id == idMateria);

                lstMaterias[indice] = Materia;

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
                if (lstMaterias.Count > 0)
                {
                    materia.Id = lstMaterias.Last().Id + 1;
                }

                lstMaterias.Add(materia);

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
                int indice = lstMaterias.FindIndex(tmp => tmp.Id == idMateria);

                lstMaterias.RemoveAt(indice);

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
                Materia materia = lstMaterias.FirstOrDefault(tmp => tmp.Id == idMateria);
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
                return lstMaterias;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    }
