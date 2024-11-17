using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.DTO
{
    internal class CalculoPuntajeDTO
    {
        public UsuarioDTO Usuario { get; set; }
        public List<PreguntaDTO> PreguntasEvaluadas { get; set; }
        public int Tiempo { get; set; }
    }
}
