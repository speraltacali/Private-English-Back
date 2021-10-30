using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Usuario.Dto
{
    public class UsuarioDto : EntidadBase
    {
        public string User { get; set; }

        public string Password { get; set; }

        public bool Bloqueado { get; set; }

        public bool Eliminado { get; set; }

        public int RolId { get; set; }
    }
}
