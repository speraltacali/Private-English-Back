using PE.Servicios.Base;
using PE.Servicios.Tarea.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Tarea
{
    public class TareaServicio : IOperaciones<TareaDto>
    {
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(TareaDto dto)
        {
            throw new NotImplementedException();
        }

        public void Modificar(TareaDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TareaDto> Obtener(string buscar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TareaDto> ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
