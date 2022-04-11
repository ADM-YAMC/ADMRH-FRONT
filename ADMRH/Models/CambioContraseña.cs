using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADMRH.Models
{
    public class CambioContraseña
    {
        public int Estado { get; set; }
        public int idUsuario { get; set; }
        [Required(ErrorMessage ="Debes ingresar la antigua contraseña...")]
        public string viejaContraseña { get; set; }
        [Required(ErrorMessage = "Debes ingresar la nueva contraseña...")]
        public string nuevaContraseña { get; set; }
        [Required(ErrorMessage = "Debes respetir la antigua contraseña...")]
        public string rnuevaContraseña { get; set; }

    }
}
