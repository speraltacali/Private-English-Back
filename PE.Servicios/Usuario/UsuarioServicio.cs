using PE.Servicios.Base;
using PE.Servicios.Usuario.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Usuario
{
    public class UsuarioServicio : IOperaciones<UsuarioDto>
    {
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(UsuarioDto dto)
        {
            throw new NotImplementedException();
        }

        public void Modificar(UsuarioDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioDto> Obtener(string buscar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioDto> ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
