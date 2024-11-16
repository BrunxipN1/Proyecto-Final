using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.DTO
{
    internal class PreguntaDTO
    {
        public int IdPregunta { get; set; }
        public string LaPregunta { get; set; }
        public CategoriaDTO Categoria { get; set; }
        public DificultadDTO Dificultad { get; set; }
        public List<RespuestaDTO> Respuestas { get; set; }

    }
}
