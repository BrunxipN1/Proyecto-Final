using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.DTO
{
    internal class RespuestaDTO
    {
        public int IdRespuesta { get; set; }
        public string TextoRespuesta { get; set; }
        public bool Correcta { get; set; }

    }
}
