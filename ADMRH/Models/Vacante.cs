using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ADMRH_API.Models
{
    public partial class Vacante
    {
        public int IdVacante { get; set; }
        public int IdUsuarioCreacion { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Departamento { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Salario { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string FechaCreacion { get; set; }
    }
}
