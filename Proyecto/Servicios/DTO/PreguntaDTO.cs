using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.DTO
{
    /// <summary>
    /// DTO destinado a obtener la información de la Pregunta
    /// </summary>
    internal class PreguntaDTO
    {
        /// <summary>
        /// Identificativo de la pregunta
        /// </summary>
        public int IdPregunta { get; set; }

        /// <summary>
        /// String de la pregunta
        /// </summary>
        public string LaPregunta { get; set; }

        /// <summary>
        /// DTO de la categoría
        /// </summary>
        public CategoriaDTO Categoria { get; set; }

        /// <summary>
        /// DTO de la Dificultad
        /// </summary>
        public DificultadDTO Dificultad { get; set; }

        /// <summary>
        /// Lista de DTO de Respuesta
        /// </summary>
        public List<RespuestaDTO> Respuestas { get; set; }

    }
}
