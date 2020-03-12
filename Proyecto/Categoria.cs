using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto
{
    public class Categoria
    {
        /// <summary>
        /// Identificador de la categoría
        /// </summary>
        [Key]
        public int IdCategoria { get; set; }
        /// <summary>
        /// Nombre de la categoría
        /// </summary>
        public string NombreCategoria { get; set; }
        /// <summary>
        /// Categoría para las preguntas
        /// </summary>
        /// <param name="pNombre">Nombre de la categoría</param>
        public int IdWeb { get; set; }
        public Categoria(string pNombre, int pIdWeb)
        {
            this.NombreCategoria = pNombre;
            this.IdWeb = pIdWeb;
        }

        public Categoria(string pNombre)
        {
            this.NombreCategoria = pNombre;
            this.IdWeb = 0;
        }
        public Categoria() { }
    }
}