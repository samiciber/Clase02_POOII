using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clase02.Models
{
    public class Alumno
    {
        [Display(Name = "Id Alumno")] public int IdAlumno { get; set; }
        [Display(Name = "Nombre")] public string Nombre { get; set; }
        [Display(Name = "Apellido Materno")] public string ApellidoMaterno { get; set; }
        [Display(Name = "Apellido Paterno")] public string ApellidoPaterno { get; set; }
        [Display(Name = "Email")] public string Email { get; set; }
        [Display(Name = "Carrera")] public string Carrera { get; set; }
        [Display(Name = "Ciclo")] public int Ciclo { get; set; }
        [Display(Name = "Mensualidad")] public decimal Mensualidad { get; set; }
    }
}