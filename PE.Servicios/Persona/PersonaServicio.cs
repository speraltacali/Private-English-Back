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
            using(var context = new ModelContextContainer())
            {
                var eliminar = ObtenerPorId(id);

                if (eliminar == null) throw new Exception("no se encontro a la Persona");

                eliminar.Eliminado = true;


                context.SaveChanges();
            }
        }

        public int Insertar(PersonaDto dto)
        {
            using (var context = new ModelContextContainer())
            {
                var nuevo = new Infraestructura.Context.Persona
                {
                    Nombre = dto.Nombre,
                    Apellido = dto.Apellido,
                    Dni = dto.Dni,
                    FechaNacimiento = dto.FechaNacimiento,
                    Eliminado = dto.Eliminado,
                    Domicilio = dto.Domicilio,
                    UsuarioId = dto.UsuarioId
                };

                context.Personas.Add(nuevo);
                context.SaveChanges();

                return nuevo.Id;
            }
        }

        public void Modificar(PersonaDto dto) 
        {
            using(var context = new ModelContextContainer())
            {
                var modificar = ObtenerPorId(dto.Id);

                if(modificar == null) throw new Exception("no se encontro a la Persona");

                modificar.Nombre = dto.Nombre;
                modificar.Apellido = dto.Apellido;
                modificar.Dni = dto.Dni;
                modificar.FechaNacimiento = dto.FechaNacimiento;
                modificar.Eliminado = dto.Eliminado;
                modificar.Domicilio = dto.Domicilio;
                modificar.UsuarioId = dto.UsuarioId;

                context.SaveChanges();
            }
        }

        public IEnumerable<PersonaDto> Obtener(string buscar)
        {
            using (var context = new ModelContextContainer())
            {
                return context.Personas
                    .AsNoTracking()
                    .Where(x => x.Nombre.Contains(buscar) ||
                              x.Apellido.Contains(buscar) ||
                              x.Dni.Contains(buscar))
                    .Select(x => new PersonaDto
                    {
                        Id = x.Id,
                        Nombre = x.Nombre,
                        Apellido = x.Apellido,
                        Dni = x.Dni,
                        FechaNacimiento = x.FechaNacimiento,
                        Eliminado = x.Eliminado,
                        Domicilio = x.Domicilio,
                        UsuarioId = x.UsuarioId

                    }).ToList();
                    
            }
        }

        public PersonaDto ObtenerPorId(int id)
        {
            using (var context = new ModelContextContainer())
            {
                var data = context.Personas.FirstOrDefault(x => x.Id == id);

                if (data == null) throw new Exception("no se encontro a la Persona");


                return new PersonaDto
                {
                    Id = data.Id,
                    Nombre = data.Nombre,
                    Apellido = data.Apellido,
                    Dni = data.Dni,
                    FechaNacimiento = data.FechaNacimiento,
                    Eliminado = data.Eliminado,
                    Domicilio = data.Domicilio,
                    UsuarioId = data.UsuarioId
                };

            }
        }
    }
}
