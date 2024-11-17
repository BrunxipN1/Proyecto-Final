using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proyecto.Utils.Enums;

namespace Proyecto.Servicios.DTO
{
    internal class PreguntaWebRequestDTO
    {
        public int categoriaId { get; set; }
        public int dificultadId { get; set; }
        public int cantidad { get; set; }

        public ApisElegiblesEnum api { get; set; }
    }
}
