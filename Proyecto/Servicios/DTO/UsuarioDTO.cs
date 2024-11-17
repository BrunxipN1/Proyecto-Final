using System.ComponentModel.DataAnnotations;

namespace Proyecto.Servicios.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public bool EsAdmin { get; set; }

    }
}
