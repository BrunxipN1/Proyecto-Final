using System.ComponentModel.DataAnnotations;

namespace Proyecto.Servicios.DTO
{
    public class UsuarioDTO
    {
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public bool EsAdmin { get; set; }

    }
}
