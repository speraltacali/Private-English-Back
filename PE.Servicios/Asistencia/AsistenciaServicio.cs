using PE.Servicios.Asistencia.Dto;
using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Asistencia
{
    public class AsistenciaServicio : IOperaciones<AsistenciaDto>
    {
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(AsistenciaDto dto)
        {
            throw new NotImplementedException();
        }

        public void Modificar(AsistenciaDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AsistenciaDto> Obtener(string buscar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AsistenciaDto> ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
