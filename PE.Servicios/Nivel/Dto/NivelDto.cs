using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Nivel.Dto
{
    public class NivelDto : EntidadBase
    {
        public string Descipcion { get; set; }

        public bool Eliminado { get; set; }
    }
}
