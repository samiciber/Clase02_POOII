using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clase02.Models;

namespace Clase02.Controllers
{
    public class ConsultasController : Controller
    {
        public List<Alumno> Alumnos = new List<Alumno>()
        {
            new Alumno{IdAlumno = 101, Nombre = "Sofía", ApellidoPaterno = "García", ApellidoMaterno = "López", Email = "sofia.garcia@universidad.edu", Carrera = "Ingeniería de Sistemas", Ciclo = 4, Mensualidad = 550.00M},
            new Alumno{IdAlumno = 102, Nombre = "Andrés", ApellidoPaterno = "Martínez", ApellidoMaterno = "Vargas", Email = "andres.martinez@universidad.edu", Carrera = "Administración de Empresas", Ciclo = 7, Mensualidad = 480.50M},
            new Alumno{IdAlumno = 103, Nombre = "Elena", ApellidoPaterno = "Ramos", ApellidoMaterno = "Fuentes", Email = "elena.ramos@universidad.edu", Carrera = "Arquitectura", Ciclo = 2, Mensualidad = 520.00M},
            new Alumno{IdAlumno = 104, Nombre = "Ricardo", ApellidoPaterno = "Pérez", ApellidoMaterno = "Soto", Email = "ricardo.perez@universidad.edu", Carrera = "Derecho", Ciclo = 9, Mensualidad = 600.00M},
            new Alumno{IdAlumno = 105, Nombre = "Jimena", ApellidoPaterno = "Castro", ApellidoMaterno = "Vega", Email = "jimena.castro@universidad.edu", Carrera = "Medicina Humana", Ciclo = 1, Mensualidad = 850.00M},
            new Alumno{IdAlumno = 106, Nombre = "Javier", ApellidoPaterno = "Herrera", ApellidoMaterno = "Díaz", Email = "javier.herrera@universidad.edu", Carrera = "Comunicación Social", Ciclo = 6, Mensualidad = 450.00M},
            new Alumno{IdAlumno = 107, Nombre = "Lucía", ApellidoPaterno = "Molina", ApellidoMaterno = "Gil", Email = "lucia.molina@universidad.edu", Carrera = "Psicología", Ciclo = 3, Mensualidad = 510.00M},
            new Alumno{IdAlumno = 108, Nombre = "Daniel", ApellidoPaterno = "Navarro", ApellidoMaterno = "Ruiz", Email = "daniel.navarro@universidad.edu", Carrera = "Contabilidad", Ciclo = 8, Mensualidad = 475.50M},
            new Alumno{IdAlumno = 109, Nombre = "Valeria", ApellidoPaterno = "Flores", ApellidoMaterno = "León", Email = "valeria.flores@universidad.edu", Carrera = "Marketing", Ciclo = 5, Mensualidad = 490.00M},
            new Alumno{IdAlumno = 110, Nombre = "Mateo", ApellidoPaterno = "Blanco", ApellidoMaterno = "Rojas", Email = "mateo.blanco@universidad.edu", Carrera = "Diseño Gráfico", Ciclo = 10, Mensualidad = 420.00M}
        };
        public ActionResult Index(string nombre = "")
        {
            ViewBag.BusquedaNombre = nombre;
            List<Alumno> alumnosAMostrar;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                alumnosAMostrar = Alumnos;
            }
            else
            {
                alumnosAMostrar = Alumnos
                    .Where(c => c.Nombre.StartsWith(nombre, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            return View(alumnosAMostrar);
        }
    }
}