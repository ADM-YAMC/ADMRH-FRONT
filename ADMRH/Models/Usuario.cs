using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ADMRH_API.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
       
        public int? IdCreacionUser { get; set; }
        [Required(ErrorMessage = "El nombre es requerido...")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es requerido...")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El cedula es requerido...")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "El telefono es requerido...")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El departamento es requerido...")]
        public string Departamento { get; set; }
        [Required(ErrorMessage = "La direccion es requerida...")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El rol es requerido...")]
        public string Rol { get; set; }
        [Required(ErrorMessage = "El correo es requerido...")]
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string? Token { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int? PCambio { get; set; }
    }
}
