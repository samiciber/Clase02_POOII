using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoVistas_MVC.Models;

namespace ProyectoVistas_MVC.Controllers
{
    public class CarrerasController : Controller
    {
        // GET: Carreras
        public ActionResult Index()
        {
            var carreras = ObtenerCarreras();
            return View(carreras);
        }
        // GET: Carreras/Details/5
        public ActionResult Details(int id)
        {
            var carreras = ObtenerCarreras();
            var carrera = carreras.Find(c => c.Id == id);

            if (carrera == null)
            {
                return HttpNotFound();
            }

            return View(carrera);
        }

        // Método privado para obtener las carreras
        private List<Carrera> ObtenerCarreras()
        {
            return new List<Carrera>
            {
                new Carrera
                {
                    Id = 1,
                    Nombre = "REDES Y COMUNICACIONES",
                    Descripcion = "La carrera de Redes y Comunicaciones forma profesionales capaces de diseñar, implementar y administrar infraestructuras de redes de datos y telecomunicaciones.",
                    ImagenUrl = "~/imagenes/redes.jpg",
                    Duracion = 3,
                    Modalidad = "Presencial / Online",
                    Caracteristicas = new List<string>
                    {
                        "Diseño de infraestructura de redes",
                        "Seguridad informática y ciberseguridad",
                        "Administración de servidores",
                        "Cloud Computing y virtualización",
                        "Certificaciones internacionales (Cisco, CompTIA)"
                    }
                },
                new Carrera
                {
                    Id = 2,
                    Nombre = "DESARROLLO DE SOFTWARE",
                    Descripcion = "La carrera de Desarrollo de Software prepara profesionales para crear soluciones tecnológicas innovadoras utilizando las últimas metodologías y tecnologías de programación.",
                    ImagenUrl = "~/imagenes/desarrollo.jpg",
                    Duracion = 3,
                    Modalidad = "Presencial / Online",
                    Caracteristicas = new List<string>
                    {
                        "Programación en múltiples lenguajes",
                        "Desarrollo web y móvil",
                        "Base de datos y arquitectura de software",
                        "Metodologías ágiles (Scrum, Kanban)",
                        "DevOps y CI/CD"
                    }
                },
                new Carrera
                {
                    Id = 3,
                    Nombre = "DISEÑO GRÁFICO DIGITAL",
                    Descripcion = "La carrera de Diseño Gráfico Digital forma creativos capaces de desarrollar piezas visuales innovadoras para medios digitales e impresos.",
                    ImagenUrl = "~/imagenes/diseño.jpg",
                    Duracion = 3,
                    Modalidad = "Presencial",
                    Caracteristicas = new List<string>
                    {
                        "Diseño para medios digitales",
                        "Ilustración y animación",
                        "UI/UX Design",
                        "Marketing visual",
                        "Fotografía y edición digital"
                    }
                },
                new Carrera
                {
                    Id = 4,
                    Nombre = "ADMINISTRACIÓN DE NEGOCIOS",
                    Descripcion = "La carrera de Administración de Negocios forma líderes empresariales con visión estratégica y capacidad para gestionar organizaciones modernas.",
                    ImagenUrl = "~/imagenes/administracion.jpg",
                    Duracion = 3,
                    Modalidad = "Presencial / Online",
                    Caracteristicas = new List<string>
                    {
                        "Gestión empresarial y estratégica",
                        "Marketing y ventas",
                        "Finanzas corporativas",
                        "Recursos humanos",
                        "Emprendimiento e innovación"
                    }
                }
            };
        }
        // GET: Carreras/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Carreras/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Carrera carrera)
        {
            if (ModelState.IsValid)
            {
                // Aquí normalmente guardarías en BD
                // Por ahora solo redirigimos
                TempData["Mensaje"] = $"Carrera '{carrera.Nombre}' creada exitosamente";
                return RedirectToAction("Index");
            }

            return View(carrera);
        }

        // GET: Carreras/Buscar
        public ActionResult Buscar(string termino)
        {
            var carreras = ObtenerCarreras();

            if (!string.IsNullOrEmpty(termino))
            {
                carreras = carreras.Where(c =>
                    c.Nombre.ToLower().Contains(termino.ToLower()) ||
                    c.Descripcion.ToLower().Contains(termino.ToLower())
                ).ToList();

                ViewBag.Termino = termino;
                ViewBag.Resultados = carreras.Count;
            }

            return View("Index", carreras);
        }

    }
}