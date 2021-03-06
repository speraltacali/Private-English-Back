using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Alumno.Dto
{
    public class AlumnoDto : EntidadBase
    {   
        public string Legajo { get; set; }

        public DateTime FechaInscripcion { get; set; }

        public bool Eliminado { get; set; }

        public int PersonaId { get; set; }
    }
}
