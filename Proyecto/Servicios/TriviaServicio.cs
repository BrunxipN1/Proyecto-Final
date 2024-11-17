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

        public async Task<List<CategoriaDTO>> ObtenerCategorias()
        {
            var response = await _httpClient.GetAsync("Trivia/obtenerCategorias");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<CategoriaDTO>>(responseBody);
        }

        public async Task<List<DificultadDTO>> ObtenerDificultades()
        {
            var response = await _httpClient.GetAsync("Trivia/obtenerDificultades");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<DificultadDTO>>(responseBody);
        }

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

        public async Task<bool> GuardarPreguntaManual(PreguntaDTO pregunta)
        {
            var json = JsonConvert.SerializeObject(pregunta);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Trivia/guardarPreguntaManual", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> AgregarPreguntasDesdeWeb(PreguntaWebRequestDTO request)
        {
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Trivia/obtenerPreguntasDesdeAPI", content);
            return response.IsSuccessStatusCode;
        }

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
