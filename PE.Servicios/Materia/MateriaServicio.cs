using PE.Servicios.Base;
using PE.Servicios.Materia.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Materia
{
    public class MateriaServicio : IOperaciones<MateriaDto>
    {
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(MateriaDto dto)
        {
            throw new NotImplementedException();
        }

        public void Modificar(MateriaDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MateriaDto> Obtener(string buscar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MateriaDto> ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
