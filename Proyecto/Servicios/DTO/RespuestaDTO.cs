using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.DTO
{
    /// <summary>
    /// DTO destinado a obtener la información de la respuesta
    /// </summary>
    internal class RespuestaDTO
    {
        /// <summary>
        /// Identificador de la respuesta
        /// </summary>
        public int IdRespuesta { get; set; }

        /// <summary>
        /// String de la respuesta
        /// </summary>
        public string TextoRespuesta { get; set; }

        /// <summary>
        /// Es correcta
        /// </summary>
        public bool Correcta { get; set; }

        /// <summary>
        /// Fue seleccionada
        /// </summary>
        public bool Seleccionada { get; set; }

    }
}
