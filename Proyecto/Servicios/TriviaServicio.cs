using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Servicios.DTO;
using System.Text.Json;

namespace Proyecto.Servicios
{
    internal class TriviaServicio
    {
        private readonly HttpClient _httpClient;

        public TriviaServicio()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:43660/")
            };
        }

        public async Task<List<CategoriaDTO>> ObtenerCategorias()
        {
            var response = await _httpClient.GetAsync("Trivia/obtenerCategorias");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<CategoriaDTO>>(responseBody);
        }

        public async Task<List<DificultadDTO>> ObtenerDificultades()
        {
            var response = await _httpClient.GetAsync("Trivia/obtenerDificultades");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<DificultadDTO>>(responseBody);
        }

        public async Task<List<PreguntaDTO>> ObtenerPreguntas(PreguntaRequestDTO requestDTO)
        {
            try
            {
                var json = JsonSerializer.Serialize(requestDTO);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("Trivia/obtenerPreguntas", content);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<PreguntaDTO>>(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener preguntas: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> GuardarPreguntaManual(PreguntaDTO pregunta)
        {
            var json = JsonSerializer.Serialize(pregunta);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Trivia/guardarPreguntaManual", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> AgregarPreguntasDesdeWeb(PreguntaWebRequestDTO request)
        {
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Trivia/agregarPreguntasDesdeWeb", content);
            return response.IsSuccessStatusCode;
        }
    }
}
