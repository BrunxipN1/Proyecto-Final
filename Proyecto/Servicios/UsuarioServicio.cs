using Proyecto.Servicios.DTO;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Proyecto.Servicios
{
    internal class UsuarioServicio
    {
        private readonly HttpClient _httpClient;

        public UsuarioServicio()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:43660/")
            };
        }

        public async Task<bool> AgregarUsuario(UsuarioDTO usuarioDTO)
        {
            try
            {
                var json = JsonSerializer.Serialize(usuarioDTO);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("Usuario/crear", content);
                response.EnsureSuccessStatusCode();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar el usuario: {ex.Message}");
                return false;
            }
        }
    }
}
