using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Base
{
    public interface IOperaciones<T>
    {
        int Insertar(T dto);

        void Modificar(T dto);

        void Eliminar(int id);

        IEnumerable<T> Obtener(string buscar);

        T ObtenerPorId(int id);
    }
}
