using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ADMRH_API.Models
{
    public partial class Candidato
    {
        public int IdCandidato { get; set; }
        public int IdVacante { get; set; }
        public int IdArchivos { get; set; }
        public int IdUsuarioCreacion { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio...")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Apellido es obligatorio...")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "La cedula es obligatoria...")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "La direccion es obligatoria...")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio...")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio...")]
        public string Correo { get; set; }
        public string FechaCreacion { get; set; }
    }
}
