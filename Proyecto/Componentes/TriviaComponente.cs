using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Servicios.DTO;
using Proyecto.Servicios;

namespace Proyecto.Componentes
{
    internal class TriviaComponente
    {
        private readonly TriviaServicio _triviaServicio;

        public TriviaComponente()
        {
            _triviaServicio = new TriviaServicio();
        }

        public async Task<List<CategoriaDTO>> ObtenerCategorias()
        {
            return await _triviaServicio.ObtenerCategorias();
        }

        public async Task<List<DificultadDTO>> ObtenerDificultades()
        {
            return await _triviaServicio.ObtenerDificultades();
        }

        public async Task<List<PreguntaDTO>> ObtenerPreguntas(int categoriaId, int dificultadId, int cantidad)
        {
            var requestDTO = new PreguntaRequestDTO
            {
                CategoriaId = categoriaId,
                DificultadId = dificultadId,
                Cantidad = cantidad
            };

            return await _triviaServicio.ObtenerPreguntas(requestDTO);
        }

        public async Task<bool> GuardarPreguntaManual(PreguntaDTO pregunta)
        {
            return await _triviaServicio.GuardarPreguntaManual(pregunta);
        }

        public async Task<bool> AgregarPreguntasDesdeWeb(CategoriaDTO categoria, DificultadDTO dificultad, int cantidad)
        {
            var request = new PreguntaWebRequestDTO
            {
                CategoriaId = categoria.IdCategoria,
                DificultadId = dificultad.IdDificultad,
                Cantidad = cantidad
            };

            return await _triviaServicio.AgregarPreguntasDesdeWeb(request);
        }
    }
}
