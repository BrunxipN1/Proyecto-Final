using Newtonsoft.Json;
using Proyecto.Servicios.DTO;
using System;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Proyecto.Servicios
{
    /// <summary>
    /// Servicio encargado de realizar las transacciones de datos referentes al Usuario con el servidor
    /// </summary>
    internal class UsuarioServicio
    {
        private readonly HttpClient _httpClient;

        public UsuarioServicio()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiBaseUrl"])
            };
        }

        /// <summary>
        /// Registrar un nuevo usuario
        /// </summary>
        /// <param name="usuarioDTO">Entidad de Usuario DTO</param>
        /// <returns>UsuarioDTO el usuario creado</returns>
        public async Task<UsuarioDTO> AgregarUsuario(UsuarioDTO usuarioDTO)
        {
            try
            {
                var json = JsonConvert.SerializeObject(usuarioDTO);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("Usuario/crear", content);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<UsuarioDTO>(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar el usuario: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Autenticar los datos ingresados del usuario
        /// </summary>
        /// <param name="usuarioDTO">Entidad de Usuario DTO</param>
        /// <returns>UsuarioDTO el usuario autenticado</returns>
        public async Task<UsuarioDTO> AutenticarUsuario(UsuarioDTO usuarioDTO)
        {
            try
            {
                var json = JsonConvert.SerializeObject(usuarioDTO);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("Usuario/autenticar", content);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<UsuarioDTO>(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al autenticar el usuario: {ex.Message}");
                return null;
            }
        }
    }
}
