using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Aula.Dto
{
    public class AulaDto : EntidadBase
    {
        public string Descripcion { get; set; }
    
        public string Codigo { get; set; }    

        public bool Eliminado { get; set; }

        public int DocenteId { get; set; }

        public int CicloId { get; set; }

        public int MateriaId { get; set; }

    }
}
