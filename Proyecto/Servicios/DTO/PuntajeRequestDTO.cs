using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.DTO
{
    internal class PuntajeRequestDTO
    {
        public UsuarioDTO Usuario { get; set; }
        public int CantCorrectas { get; set; }
        public int CantPreguntas { get; set; }
        public int Tiempo { get; set; }
        public DificultadDTO Dificultad { get; set; }

    }
}
