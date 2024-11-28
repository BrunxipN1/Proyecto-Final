using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.DTO
{
    /// <summary>
    /// DTO destinado a obtener la información de la dificultad
    /// </summary>
    internal class DificultadDTO
    {
        /// <summary>
        /// Identificativo de la dificultad
        /// </summary>
        public int IdDificultad { get; set; }

        /// <summary>
        /// Nombre de la dificultad
        /// </summary>
        public string NombreDificultad { get; set; }

        /// <summary>
        /// Valor de la dificultad
        /// </summary>
        public int Valor { get; set; }

    }
}
