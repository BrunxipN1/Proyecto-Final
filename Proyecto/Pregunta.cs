using System;

namespace Proyecto
{
    internal class Pregunta
    {
        private int iIdPregunta;
        private string iLaPregunta;
        private string iReferencias;

        public int IdPregunta
        {
            get { return this.iIdPregunta; }
            set { this.iIdPregunta = value; }
        }

        public string LaPregunta
        {
            get { return this.iLaPregunta; }
            set { this.iLaPregunta = value; }
        }

        public string Referencias
        {
            get { return this.iReferencias; }
            set { this.iReferencias = value; }
        }
    }
}