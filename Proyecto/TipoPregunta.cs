using System;

namespace Proyecto
{
    internal class TipoPregunta
    {
        private int iIdTipoPregunta;
        private string iNombrePregunta;

        public int IdTipoPregunta
        {
            get { return this.iIdTipoPregunta; }
            set { this.iIdTipoPregunta = value; }
        }

        public string NombreTipoPregunta
        {
            get { return this.iNombrePregunta; }
            set { this.iNombrePregunta = value; }
        }
    }
}