using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.DTO
{
    /// <summary>
    /// DTO destinado a obtener la información del Puntaje
    /// </summary>
    internal class PuntajeDTO
    {
        /// <summary>
        /// Identificador del puntaje
        /// </summary>
        public int IdPuntaje { get; set; }

        /// <summary>
        /// DTO del usuario
        /// </summary>
        public UsuarioDTO Usuario { get; set; }

        /// <summary>
        /// Valor total del puntaje
        /// </summary>
        public float ValorPuntaje { get; set; }

        /// <summary>
        /// Fecha y Hora en la que se realizó
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Tiempo gastado
        /// </summary>
        public int Tiempo { get; set; }

        /// <summary>
        /// Cantidad de preguntas respondidas
        /// </summary>
        public int CantidadPreguntas { get; set; }

        /// <summary>
        /// Cantidad de preguntas correctas
        /// </summary>
        public int CantidadCorrectas { get; set; }

    }
}
