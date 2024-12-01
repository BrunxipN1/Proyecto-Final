using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Servicios;
using Proyecto.Servicios.DTO;

namespace Proyecto.Componentes
{
    /// <summary>
    /// Componente encargado de la lógica de los datos del Usuario
    /// </summary>
    internal class UsuarioComponente
    {
        private readonly UsuarioServicio _usuarioServicio;

        public UsuarioComponente()
        {
            _usuarioServicio = new UsuarioServicio();
        }

        /// <summary>
        /// Registrar un nuevo usuario
        /// </summary>
        /// <param name="nombreUsuario">nombre de usuario</param>
        /// <param name="password">contraseña</param>
        /// <returns>UsuarioDTO el usuario creado</returns>
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

        /// <summary>
        /// Autenticar los datos ingresados del usuario
        /// </summary>
        /// <param name="nombreUsuario">nombre del usuario</param>
        /// <param name="password">contraseña ingresada</param>
        /// <returns>UsuarioDTO el usuario autenticado</returns>
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
