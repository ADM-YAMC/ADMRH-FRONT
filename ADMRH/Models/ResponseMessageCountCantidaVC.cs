using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADMRH.Models
{
    public class ResponseMessageCountCantidaVC
    {
        public bool ok { get; set; }
        public int cantidadVacantes { get; set; }
        public int CantidadCandidatos { get; set; }
    }
}
