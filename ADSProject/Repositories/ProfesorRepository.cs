﻿using ADSProject.DB;
using ADSProject.Interfaces;
using ADSProject.Migrations;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class ProfesorRepository : IProfesor
    {
        //private List<Profesor> lstProfesores = new List<Profesor>
        //{
        //    new Profesor{ IdProfesor = 1, NombresProfesor = "Karen Johanna",
        //    ApellidosProfesor = "Garcia Alvares",
        //    CorreoProfesor = "Profe@usonsonate.edu.sv"
        //    }
        //};

        private readonly ApplicationDbContext applicationDbContext;

        public ProfesorRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;

        }
        public int ActualizarProfesor(int idProfesor, Profesor profesor)
        {
            try
            {
                //int indice = lstProfesores.FindIndex(tmp => tmp.IdProfesor == idProfesor);

                //lstProfesores[indice] = profesor;

                //return idProfesor;

                var item = applicationDbContext.Profesores.SingleOrDefault(x => x.IdProfesor == idProfesor);
                applicationDbContext.Entry(item).CurrentValues.SetValues(profesor);
                applicationDbContext.SaveChanges();
                return idProfesor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AgregarProfesor(Profesor profesor)
        {
            try
            {
                //if (lstProfesores.Count > 0)
                //{
                //    profesor.IdProfesor = lstProfesores.Last().IdProfesor + 1;
                //}

                //lstProfesores.Add(profesor);

                //return profesor.IdProfesor;

                applicationDbContext.Profesores.Add(profesor);
                applicationDbContext.SaveChanges();

                return profesor.IdProfesor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarProfesor(int idProfesor)
        {
            try
            {
                //int indice = lstProfesores.FindIndex(tmp => tmp.IdProfesor == idProfesor);

                //lstProfesores.RemoveAt(indice);

                //return true;

                var item = applicationDbContext.Profesores.SingleOrDefault(x => x.IdProfesor == idProfesor);
                applicationDbContext.Profesores.Remove(item);
                applicationDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Profesor ObtenerProfesorPorID(int idProfesor)
        {
            try
            {
                //Profesor profesor = lstProfesores.FirstOrDefault(tmp => tmp.IdProfesor == idProfesor);
                //return profesor;


                var profesor = applicationDbContext.Profesores.SingleOrDefault(x => x.IdProfesor == idProfesor);
                return profesor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Profesor> ObtenerTodosLosProfesores()
        {
            try
            {
                //return lstProfesores;
                return applicationDbContext.Profesores.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

