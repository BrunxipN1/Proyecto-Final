using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Servicios.DTO;
using Newtonsoft.Json;
using System.Configuration;

namespace Proyecto.Servicios
{
    /// <summary>
    /// Servicio encargado de realizar las transacciones de datos con el servidor, referentes a la Trivia, Preguntas, Respuestas
    /// </summary>
    internal class TriviaServicio
    {
        private readonly HttpClient _httpClient;

        public TriviaServicio()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiBaseUrl"])
            };
        }

        /// <summary>
        /// Obtiene el listado de Categorias
        /// </summary>
        /// <returns>Lista de CategoriaDTO</returns>
        public async Task<List<CategoriaDTO>> ObtenerCategorias()
        {
            var response = await _httpClient.GetAsync("Trivia/obtenerCategorias");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<CategoriaDTO>>(responseBody);
        }

        /// <summary>
        /// Obtiene el listado de Dificultades
        /// </summary>
        /// <returns>Lista de DificultadDTO</returns>
        public async Task<List<DificultadDTO>> ObtenerDificultades()
        {
            var response = await _httpClient.GetAsync("Trivia/obtenerDificultades");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<DificultadDTO>>(responseBody);
        }

        /// <summary>
        /// Obtiene listado de preguntas
        /// </summary>
        /// <param name="requestDTO">PreguntaRequestDTO que contiene los parametros de preguntas buscadas</param>
        /// <returns>Lista de PreguntaDTO</returns>
        public async Task<List<PreguntaDTO>> ObtenerPreguntas(PreguntaRequestDTO requestDTO)
        {
            try
            {
                var urlString = $"Trivia/obtenerPreguntas?cantidad={requestDTO.Cantidad}&categoriaId={requestDTO.CategoriaId}&dificultadId={requestDTO.DificultadId}";
                var response = await _httpClient.GetAsync(urlString);
                Console.WriteLine("ObtenerPreguntas response: ", response);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<PreguntaDTO>>(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener preguntas: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Guarda una nueva pregunta con sus parametros y respuestas
        /// </summary>
        /// <param name="pregunta">PreguntaDTO que posee las propiedades de una pregunta con su lista de respuestas</param>
        /// <returns>bool indicando si pudo guardarse correctamente</returns>
        public async Task<bool> GuardarPreguntaManual(PreguntaDTO pregunta)
        {
            var json = JsonConvert.SerializeObject(pregunta);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Trivia/agregarPreguntaManual", content);
            return response.IsSuccessStatusCode;
        }

        /// <summary>
        /// Descargar listado de preguntas desde API
        /// </summary>
        /// <param name="request">PreguntaWebRequestDTO que posee los parametros de búsqueda de preguntas</param>
        /// <returns>bool indicando si pudieron descargarse las preguntas correctamente</returns>
        public async Task<bool> AgregarPreguntasDesdeWeb(PreguntaWebRequestDTO request)
        {
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Trivia/obtenerPreguntasDesdeAPI", content);
            return response.IsSuccessStatusCode;
        }

        /// <summary>
        /// Verificar respuesta selecciona para esta pregunta
        /// </summary>
        /// <param name="preguntaDTO">PreguntaDTO que contiene la información de la pregunta y la respuesta seleccionada</param>
        /// <returns>PreguntaDTO con la información actualizada y el valor correcto</returns>
        public async Task<PreguntaDTO> VerificarPregunta(PreguntaDTO preguntaDTO)
        {
            var json = JsonConvert.SerializeObject(preguntaDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Trivia/verificarPregunta", content);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PreguntaDTO>(responseBody);
        }
    }
}
