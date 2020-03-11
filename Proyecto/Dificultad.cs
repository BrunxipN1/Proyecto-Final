using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto
{
    internal class Dificultad
    {
        /// <summary>
        /// Identificador de la dificultad
        /// </summary>
        [Key]
        public int IdDificultad { get; set; }
        /// <summary>
        /// Nombre de la dificultad
        /// </summary>
        public string NombreDificultad { get; set; }
        /// <summary>
        /// Valor de la dificultad en puntos
        /// </summary>
        public int Valor { get; set; }
        /// <summary>
        /// Dificultad de la pregunta
        /// </summary>
        /// <param name="pNombre">Nombre de la dificultad</param>
        /// <param name="pValor">Valor de la dificultad en puntos</param>
        public Dificultad (string pNombre, int pValor)
        {
            this.NombreDificultad = pNombre;
            this.Valor = pValor;
        }
    }
}