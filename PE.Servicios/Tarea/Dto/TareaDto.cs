using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Tarea.Dto
{
    public class TareaDto : EntidadBase
    {
        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public bool Eliminado { get; set; }

        public int DocenteId { get; set; }

        public int AulaId { get; set; }

        public int ArchivoId { get; set; }
    }
}
