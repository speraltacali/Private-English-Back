using PE.Servicios.Base;
using PE.Servicios.Nivel.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Nivel
{
    public class NivelServicio : IOperaciones<NivelDto>
    {
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(NivelDto dto)
        {
            throw new NotImplementedException();
        }

        public void Modificar(NivelDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NivelDto> Obtener(string buscar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NivelDto> ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
