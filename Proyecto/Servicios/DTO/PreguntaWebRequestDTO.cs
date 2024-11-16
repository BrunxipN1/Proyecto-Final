using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.DTO
{
    internal class PreguntaWebRequestDTO
    {
        public int CategoriaId { get; set; }
        public int DificultadId { get; set; }
        public int Cantidad { get; set; }
    }
}
