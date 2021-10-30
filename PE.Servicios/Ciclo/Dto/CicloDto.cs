using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Ciclo.Dto
{
    public class CicloDto : EntidadBase
    {
        public string Descripcion { get; set; }

        public bool Eliminado { get; set; }
    }
}
