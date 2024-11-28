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
    /// <summary>
    /// Componente encargado de la lógica de la Trivia, Preguntas y Respuestas
    /// </summary>
    internal class TriviaComponente
    {
        private readonly TriviaServicio _triviaServicio;
        private readonly List<PreguntaDTO> _preguntasEvaluadas;

        public TriviaComponente()
        {
            _triviaServicio = new TriviaServicio();
            _preguntasEvaluadas = new List<PreguntaDTO>();
        }

        /// <summary>
        /// Obtiene el listado de categorias
        /// </summary>
        /// <returns>Lista de CategoriaDTO</returns>
        public async Task<List<CategoriaDTO>> ObtenerCategorias()
        {
            return await _triviaServicio.ObtenerCategorias();
        }

        /// <summary>
        /// Obtiene el listado de dificultades
        /// </summary>
        /// <returns>Lista de DificultadDTO</returns>
        public async Task<List<DificultadDTO>> ObtenerDificultades()
        {
            return await _triviaServicio.ObtenerDificultades();
        }

        /// <summary>
        /// Obtiene listado de preguntas filtrando por los parametros de búsqueda
        /// </summary>
        /// <param name="categoriaId">categoria de pregunta</param>
        /// <param name="dificultadId">dificultad</param>
        /// <param name="cantidad">cantidad de preguntas a responder</param>
        /// <returns>Lista de PreguntaDTO</returns>
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

        /// <summary>
        /// Guarda una pregunta con sus parametros y respuestas
        /// </summary>
        /// <param name="pregunta">pregunta con sus respuestas</param>
        /// <returns>bool indicando si pudo guardarse correctamente</returns>
        public async Task<bool> GuardarPreguntaManual(PreguntaDTO pregunta)
        {
            return await _triviaServicio.GuardarPreguntaManual(pregunta);
        }

        /// <summary>
        /// Solicitar descarga de preguntas desde la web, buscando por los parametros de búsqueda
        /// </summary>
        /// <param name="categoria">CategoriaDTO</param>
        /// <param name="dificultad">DificultadDTO</param>
        /// <param name="cantidad">int</param>
        /// <param name="api">ApisElegiblesEnum</param>
        /// <returns>bool que indica si fue posible descargar las preguntas</returns>
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

        /// <summary>
        /// Agregar el valor de seleccionada o no a cada respuesta de la respuesta
        /// </summary>
        /// <param name="pregunta">PreguntaDTO</param>
        /// <param name="idRespuestaSeleccionada">int</param>
        /// <returns>PreguntaDTO</returns>
        public PreguntaDTO MarcarRespuestaSeleccionada(PreguntaDTO pregunta, int idRespuestaSeleccionada)
        {
            foreach (var respuesta in pregunta.Respuestas)
            {
                respuesta.Seleccionada = respuesta.IdRespuesta == idRespuestaSeleccionada;
            }
            return pregunta;
        }

        /// <summary>
        /// Solicita verificar si la respuesta seleccionada es la correcta y la almacena en _preguntasEvaluadas
        /// </summary>
        /// <param name="preguntaDTO">PreguntaDTO sin información de respuesta correcta</param>
        /// <returns>PreguntaDTO con información de respuesta correcta</returns>
        public async Task<PreguntaDTO> VerificarPregunta(PreguntaDTO preguntaDTO)
        {
            var resultado = await _triviaServicio.VerificarPregunta(preguntaDTO);
            _preguntasEvaluadas.Add(resultado);
            return resultado;
        }

        /// <summary>
        /// Obtiene el listado de _preguntasEvaluadas
        /// </summary>
        /// <returns>Lista de PreguntaDTO</returns>
        public List<PreguntaDTO> ObtenerPreguntasEvaluadas()
        {
            return _preguntasEvaluadas;
        }
    }
}
