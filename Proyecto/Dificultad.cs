using System;

namespace Proyecto
{
    internal class Dificultad
    {
        private int iIdDificultad;
        private string iNombreDificultad;
        private int iValor;

        public int IdPreguntas
        {
            get { return this.iIdDificultad; }
            set { this.iIdDificultad = value; }
        }

        public string NombreDificultad
        {
            get { return this.iNombreDificultad; }
            set { this.iNombreDificultad = value; }
        }

        public int Valor
        {
            get { return this.iValor; }
            set { this.iValor = value; }
        }
    }
}