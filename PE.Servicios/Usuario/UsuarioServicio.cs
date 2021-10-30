using PE.Infraestructura.Context;
using PE.Servicios.Base;
using PE.Servicios.Usuario.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.Servicios.Usuario
{
    public class UsuarioServicio : IOperaciones<UsuarioDto>
    {
        public void Eliminar(int id)
        {
            using (var context = new ModelContextContainer())
            {
                var eliminar = ObtenerPorId(id);

                if (eliminar == null) throw new Exception("no se encontro a la Persona");

                eliminar.Eliminado = true;

                context.SaveChanges();
            }
        }

        public int Insertar(UsuarioDto dto)
        {
            using (var context = new ModelContextContainer())
            {
                var nuevo = new Infraestructura.Context.Usuario
                {
                    User = dto.User,
                    Password = dto.Password,
                    Bloqueado = dto.Bloqueado,
                    Eliminado = dto.Eliminado,
                    RolId = dto.RolId,
                };

                context.Usuarios.Add(nuevo);
                context.SaveChanges();

                return nuevo.Id;
            }
        }

        public void Modificar(UsuarioDto dto)
        {
            using (var context = new ModelContextContainer())
            {
                var modificar = ObtenerPorId(dto.Id);

                if (modificar == null) throw new Exception("no se encontro a la Persona");

                modificar.User = dto.User;
                modificar.Password = dto.Password;
                modificar.Bloqueado = dto.Bloqueado;
                modificar.Eliminado = dto.Eliminado;
                modificar.RolId = dto.RolId;

                context.SaveChanges();
            }
        }

        public IEnumerable<UsuarioDto> Obtener(string buscar)
        {
            using (var context = new ModelContextContainer())
            {
                return context.Usuarios
                    .AsNoTracking()
                    .Where(x => x.User.Contains(buscar) ||
                              x.Rol.Descripcion.Contains(buscar))
                    .Select(x => new UsuarioDto
                    {
                        Id = x.Id,
                        User = x.User,
                        Password = x.Password,
                        Bloqueado = x.Bloqueado,
                        Eliminado = x.Eliminado,
                        RolId = x.RolId,

                    }).ToList();

            }
        }

        public UsuarioDto ObtenerPorId(int id)
        {
            using (var context = new ModelContextContainer())
            {
                var data = context.Usuarios.FirstOrDefault(x => x.Id == id);

                if (data == null) throw new Exception("no se encontro a la Persona");


                return new UsuarioDto
                {
                    Id = data.Id,
                    User = data.User,
                    Password = data.Password,
                    Bloqueado = data.Bloqueado,
                    Eliminado = data.Eliminado,
                    RolId = data.RolId
                };

            }
        }
    }
}
