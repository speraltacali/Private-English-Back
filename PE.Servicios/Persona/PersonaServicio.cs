using PE.Servicios.Persona.Dto;
using PE.Infraestructura.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE.Servicios.Base;

namespace PE.Servicios.Persona
{
    public class PersonaServicio : IOperaciones<PersonaDto>
    {
        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Insertar(PersonaDto dto)
        {
            using (var context = new ModelContextContainer())
            {
                var nuevaPersona = new Infraestructura.Context.Persona
                {
                    Nombre = dto.Nombre,
                    Apellido = dto.Apellido,
                    Dni = dto.Dni,
                    FechaNacimiento = dto.FechaNacimiento,
                    Eliminado = dto.Eliminado,
                    Domicilio = dto.Domicilio

                };

                context.Personas.Add(nuevaPersona);
                context.SaveChanges();

                return nuevaPersona.Id;
            }
        }

        public void Modificar(PersonaDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonaDto> Obtener(string buscar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonaDto> ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
