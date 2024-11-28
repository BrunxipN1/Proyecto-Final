using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proyecto.Utils.Enums;

namespace Proyecto.Servicios.DTO
{
    /// <summary>
    /// DTO destinado a obtener Preguntas desde la web indicada
    /// </summary>
    internal class PreguntaWebRequestDTO
    {
        /// <summary>
        /// Identificador de categoría
        /// </summary>
        public int categoriaId { get; set; }

        /// <summary>
        /// Identificador de la dificultad
        /// </summary>
        public int dificultadId { get; set; }

        /// <summary>
        /// cantidad de preguntas
        /// </summary>
        public int cantidad { get; set; }

        /// <summary>
        /// Identificador de API de donde se consumirá
        /// </summary>
        public ApisElegiblesEnum api { get; set; }
    }
}
