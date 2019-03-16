using System;

namespace Proyecto
{
    internal class Respuesta
    {
        private int iIdRespuesta;
        private string iLaRespuesta;
        private bool iCorrecta;

        public int IdRespuesta
        {
            get { return this.iIdRespuesta; }
            set { this.iIdRespuesta = value; }
        }

        public string LaRespuesta
        {
            get { return this.iLaRespuesta; }
            set { this.iLaRespuesta = value; }
        }

        public bool Correcta
        {
            get { return this.iCorrecta; }
            set { this.iCorrecta = value; }
        }
    }
}