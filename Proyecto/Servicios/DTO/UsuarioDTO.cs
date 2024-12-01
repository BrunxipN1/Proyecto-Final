using System.ComponentModel.DataAnnotations;

namespace Proyecto.Servicios.DTO
{
    /// <summary>
    /// DTO destinado a obtener la información del Usuario
    /// </summary>
    public class UsuarioDTO
    {
        /// <summary>
        /// Identificador del Usuario
        /// </summary>
        public int IdUsuario { get; set; }

        /// <summary>
        /// Nombre del usuario
        /// </summary>
        public string NombreUsuario { get; set; }

        /// <summary>
        /// Contraseña del usuario
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Valor que indica si tiene acceso de admin
        /// </summary>
        public bool EsAdmin { get; set; }

    }
}
