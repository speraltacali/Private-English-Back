using PE.Servicios.Alumno.Dto;
using PE.Servicios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Alumno
{
    public class AlumnoServicio : IOperaciones<AlumnoDto>
    {
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(AlumnoDto dto)
        {
            throw new NotImplementedException();
        }

        public void Modificar(AlumnoDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AlumnoDto> Obtener(string buscar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AlumnoDto> ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
