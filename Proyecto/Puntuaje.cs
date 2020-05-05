using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto
{
    public class Puntaje
    {
        [Key]

        public int IdPuntaje { get; set; }

        public Usuario Usuario { get; set; }

        public float ValorPuntaje { get; set; }

        public DateTime Fecha { get; set; }

        public int Tiempo { get; set; }

        public Puntaje(Usuario pUsuario, float pValor, DateTime pFecha, int pTiempo)
        {
            this.Usuario = pUsuario;
            this.ValorPuntaje = pValor;
            this.Fecha = pFecha;
            this.Tiempo = pTiempo;

        }

        public Puntaje() { }
    }
}