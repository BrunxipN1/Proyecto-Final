using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Servicios.DTO;
using System.Text.Json;
using Newtonsoft.Json;
using System.Configuration;

namespace Proyecto.Servicios
{
    /// <summary>
    /// Servicio encargado de realizar las transacciones de datos referentes al Puntaje con el servidor
    /// </summary>
    internal class PuntajeServicio
    {
        private readonly HttpClient _httpClient;

        public PuntajeServicio()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiBaseUrl"])
            };
        }

        /// <summary>
        /// Calcula el puntaje obtenido en la partida actual y lo guarda para el usuario actual
        /// </summary>
        /// <param name="calculoPuntaje">CalculoPuntajeDTO con los valores para realizar el cálculo</param>
        /// <returns>PuntajeDTO el resultado obtenido</returns>
        public async Task<PuntajeDTO> CalcularPuntaje(CalculoPuntajeDTO calculoPuntaje)
        {
            var json = JsonConvert.SerializeObject(calculoPuntaje);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Puntaje/calcular", content);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject < PuntajeDTO >(responseBody);
        }

        /// <summary>
        /// Obtener listado de puntajes del juego ordenados
        /// </summary>
        /// <returns>List<PuntajeDTO></returns>
        public async Task<List<PuntajeDTO>> ObtenerPuntajes()
        {
            var response = await _httpClient.GetAsync("Puntaje/obtener");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<PuntajeDTO>>(responseBody);
        }
    }
}
