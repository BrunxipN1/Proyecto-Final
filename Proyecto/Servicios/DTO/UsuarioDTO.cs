using System.ComponentModel.DataAnnotations;

namespace Proyecto.Servicios.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre de usuario no puede tener más de 50 caracteres")]
        public string NombreUsuario { get; set; }

        public bool EsAdmin { get; set; }

    }
}
