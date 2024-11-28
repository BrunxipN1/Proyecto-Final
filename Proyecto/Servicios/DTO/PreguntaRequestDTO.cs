using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.DTO
{
    /// <summary>
    /// DTO destinado a obtener cierta cantidad de Preguntas por los parametros pasados
    /// </summary>
    internal class PreguntaRequestDTO
    {
        /// <summary>
        /// Identificador de la categoria
        /// </summary>
        public int CategoriaId { get; set; }

        /// <summary>
        /// Identificador de la dificultad
        /// </summary>
        public int DificultadId { get; set; }

        /// <summary>
        /// Cantidad de preguntas a obtener
        /// </summary>
        public int Cantidad { get; set; }

    }
}
