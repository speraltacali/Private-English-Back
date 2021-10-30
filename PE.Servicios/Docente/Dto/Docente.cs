using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Docente.Dto
{
    public class Docente : EntidadBase
    {
        public string Legajo { get; set; }

        public bool Eliminado { get; set; }

        public int PersonaId { get; set; }
    }
}
