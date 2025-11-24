using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ProyectoVistas_MVC.Models
{
    public class Carrera
    {
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Display(Name = "Nombre de Carrera")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Imagen")]
        public string ImagenUrl { get; set; }

        [Display(Name = "Duración (años)")]
        public int Duracion { get; set; }

        [Display(Name = "Modalidad")]
        public string Modalidad { get; set; }

        public List<string> Caracteristicas { get; set; }

        public Carrera()
        {
            Caracteristicas = new List<string>();
        }
    }
}