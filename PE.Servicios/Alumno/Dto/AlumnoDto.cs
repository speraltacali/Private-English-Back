using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Alumno.Dto
{
    public class AlumnoDto
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Dni { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public bool Eliminado { get; set; }

        public string Domicilio { get; set; }
    }
}
