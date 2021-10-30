using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.AulaAlumno.Dto
{
    public class AulaAlumnoDto : EntidadBase
    {
        public int AulaId { get; set; }

        public int AlumnoId { get; set; }

        public bool Eliminado { get; set; }
    }
}
