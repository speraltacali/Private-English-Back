using PE.Servicios.Base;
using PE.Servicios.Docente.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Docente
{
    public class DocenteServicio : IOperaciones<DocenteDto>
    {
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(DocenteDto dto)
        {
            throw new NotImplementedException();
        }

        public void Modificar(DocenteDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DocenteDto> Obtener(string buscar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DocenteDto> ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
