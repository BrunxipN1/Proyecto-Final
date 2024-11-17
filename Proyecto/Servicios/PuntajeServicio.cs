using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Servicios.DTO;
using System.Text.Json;
using Newtonsoft.Json;

namespace Proyecto.Servicios
{
    internal class PuntajeServicio
    {
        private readonly HttpClient _httpClient;

        public PuntajeServicio()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5001/")
            };
        }

        public async Task<PuntajeDTO> CalcularPuntaje(PuntajeRequestDTO puntajeRequest)
        {
            var json = JsonConvert.SerializeObject(puntajeRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Puntaje/calcular", content);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject < PuntajeDTO >(responseBody);
        }

        public async Task<List<PuntajeDTO>> ObtenerPuntajes()
        {
            var response = await _httpClient.GetAsync("Puntaje/obtener");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<PuntajeDTO>>(responseBody);
        }
    }
}
