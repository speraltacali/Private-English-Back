using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Asistencia.Dto
{
    public class AsistenciaDto : EntidadBase
    {
        public bool Presente { get; set; }

        public DateTime Fecha { get; set; }

        public bool Eliminado { get; set; }

        public int AulaAlumnoId { get; set; }
    }
}
