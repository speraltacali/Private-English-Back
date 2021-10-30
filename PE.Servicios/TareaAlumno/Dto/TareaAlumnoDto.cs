using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.TareaAlumno.Dto
{
    public class TareaAlumnoDto : EntidadBase
    {
        public DateTime FechaPresentacion { get; set; }

        public bool Eliminado { get; set; }

        public int AulaAlumnoId { get; set; }

        public int TareaId { get; set; }

        public int ArchivoId { get; set; }

        public decimal Nota { get; set; }
    }
}
