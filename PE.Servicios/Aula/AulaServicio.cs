using PE.Servicios.Aula.Dto;
using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Aula
{
    public class AulaServicio : IOperaciones<AulaDto>
    {
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(AulaDto dto)
        {
            throw new NotImplementedException();
        }

        public void Modificar(AulaDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AulaDto> Obtener(string buscar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AulaDto> ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
