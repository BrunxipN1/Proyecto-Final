using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Servicios.DTO;
using Proyecto.Servicios;
using static Proyecto.Utils.Enums;

namespace Proyecto.Componentes
{
    internal class TriviaComponente
    {
        private readonly TriviaServicio _triviaServicio;
        private readonly List<PreguntaDTO> _preguntasEvaluadas;

        public TriviaComponente()
        {
            _triviaServicio = new TriviaServicio();
            _preguntasEvaluadas = new List<PreguntaDTO>();
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

        public async Task<bool> AgregarPreguntasDesdeWeb(CategoriaDTO categoria, DificultadDTO dificultad, int cantidad, ApisElegiblesEnum api)
        {
            var request = new PreguntaWebRequestDTO
            {
                categoriaId = categoria.IdCategoria,
                dificultadId = dificultad.IdDificultad,
                cantidad = cantidad,
                api = ApisElegiblesEnum.OpenTDB
            };

            return await _triviaServicio.AgregarPreguntasDesdeWeb(request);
        }

        public PreguntaDTO MarcarRespuestaSeleccionada(PreguntaDTO pregunta, int idRespuestaSeleccionada)
        {
            foreach (var respuesta in pregunta.Respuestas)
            {
                respuesta.Seleccionada = respuesta.IdRespuesta == idRespuestaSeleccionada;
            }
            return pregunta;
        }

        public async Task<PreguntaDTO> VerificarPregunta(PreguntaDTO preguntaDTO)
        {
            var resultado = await _triviaServicio.VerificarPregunta(preguntaDTO);
            _preguntasEvaluadas.Add(resultado);
            return resultado;
        }

        public List<PreguntaDTO> ObtenerPreguntasEvaluadas()
        {
            return _preguntasEvaluadas;
        }
    }
}
