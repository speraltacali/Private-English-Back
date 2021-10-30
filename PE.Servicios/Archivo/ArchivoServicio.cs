using PE.Servicios.Archivo.Dto;
using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Archivo
{
    public class ArchivoServicio : IOperaciones<ArchivoDto>
    {
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(ArchivoDto dto)
        {
            throw new NotImplementedException();
        }

        public void Modificar(ArchivoDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ArchivoDto> Obtener(string buscar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ArchivoDto> ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
