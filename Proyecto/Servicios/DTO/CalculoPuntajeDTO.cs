using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.DTO
{
    /// <summary>
    /// DTO destinado a verificar el puntaje obtenido luego de finalizar la trivia
    /// </summary>
    internal class CalculoPuntajeDTO
    {
        /// <summary>
        /// DTO de usuario
        /// </summary>
        public UsuarioDTO Usuario { get; set; }

        /// <summary>
        /// Lista de PreguntaDTO
        /// </summary>
        public List<PreguntaDTO> PreguntasEvaluadas { get; set; }

        /// <summary>
        /// valor en segundos del tiempo
        /// </summary>
        public int Tiempo { get; set; }
    }
}
