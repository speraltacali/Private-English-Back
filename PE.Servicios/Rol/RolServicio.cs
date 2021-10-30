using PE.Servicios.Base;
using PE.Servicios.Rol.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Rol
{
    public class RolServicio : IOperaciones<RolDto>
    {
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(RolDto dto)
        {
            throw new NotImplementedException();
        }

        public void Modificar(RolDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RolDto> Obtener(string buscar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RolDto> ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
