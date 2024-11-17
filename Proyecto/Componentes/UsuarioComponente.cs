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

        public async Task<UsuarioDTO> RegistrarUsuario(string nombreUsuario, string password)
        {
            var usuarioDTO = new UsuarioDTO
            {
                NombreUsuario = nombreUsuario,
                Password = password,
                EsAdmin = false
            };

            return await _usuarioServicio.AgregarUsuario(usuarioDTO);
        }

        public async Task<UsuarioDTO> AutenticarUsuario(string nombreUsuario, string password)
        {
            var usuarioDTO = new UsuarioDTO
            {
                NombreUsuario = nombreUsuario,
                Password = password
            };

            return await _usuarioServicio.AutenticarUsuario(usuarioDTO);
        }
    }
}
