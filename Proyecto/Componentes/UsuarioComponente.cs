using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Servicios;
using Proyecto.Servicios.DTO;

namespace Proyecto.Componentes
{
    internal class UsuarioComponente
    {
        private readonly UsuarioServicio _usuarioServicio;

        public UsuarioComponente()
        {
            _usuarioServicio = new UsuarioServicio();
        }

        public async Task<bool> RegistrarUsuario(string nombreUsuario, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                throw new Exception("Las contraseñas no coinciden");
            }

            var usuarioDTO = new UsuarioDTO
            {
                NombreUsuario = nombreUsuario,
                EsAdmin = false
            };

            return await _usuarioServicio.AgregarUsuario(usuarioDTO);
        }
    }
}
