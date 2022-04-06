using System;
using System.Collections.Generic;

#nullable disable

namespace ADMRH.Models
{
    public class Root
    {
        public bool ok { get; set; }
        public List<Archivo> archivos { get; set; }
    }

    public class Archivo
    {
        public int IdArchivos { get; set; }
        public string FotoFrente { get; set; }
        public string? FotoPerfil { get; set; }
        public string Cv { get; set; }
    }

    public class ArchivoTemp
    {
        public int IdArchivos { get; set; }
        public string FotoFrente { get; set; }
        public string? FotoPerfil { get; set; }
        public string Cv { get; set; }
    }
}
