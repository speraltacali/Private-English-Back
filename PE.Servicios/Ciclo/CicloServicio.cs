using PE.Servicios.Base;
using PE.Servicios.Ciclo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Ciclo
{
    public class CicloServicio : IOperaciones<CicloDto>
    {
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(CicloDto dto)
        {
            throw new NotImplementedException();
        }

        public void Modificar(CicloDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CicloDto> Obtener(string buscar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CicloDto> ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
