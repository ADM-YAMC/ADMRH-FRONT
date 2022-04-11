﻿using System;

namespace ADMRH.Models
{
    public class UserClaims
    {
        public int IdUsuario { get; set; }
        public int? PCambio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rol { get; set; }
        public string Correo { get; set; }
        public DateTime LoginDate { get; set; }
    }
}
