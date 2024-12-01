using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.DTO
{   
    /// <summary>
    /// DTO destinado a obtener la información de la categoría
    /// </summary>
    internal class CategoriaDTO
    {
        /// <summary>
        /// identificador de Categoría
        /// </summary>
        public int IdCategoria { get; set; }

        /// <summary>
        /// Nombre de la categoría
        /// </summary>
        public string NombreCategoria { get; set; }

        /// <summary>
        /// Identificativo de la web de donde se obtuvo
        /// </summary>
        public int IdWeb { get; set; }

    }
}
