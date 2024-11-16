using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.DTO
{
    internal class PuntajeDTO
    {
        public int IdPuntaje { get; set; }
        public UsuarioDTO Usuario { get; set; }
        public float ValorPuntaje { get; set; }
        public DateTime Fecha { get; set; }
        public int Tiempo { get; set; }

    }
}
