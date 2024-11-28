using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Servicios.DTO;
using Proyecto.Servicios;

namespace Proyecto.Componentes
{
    /// <summary>
    /// Componente encargado de la lógica del Puntaje
    /// </summary>
    internal class PuntajeComponente
    {
        private readonly PuntajeServicio _puntajeServicio;

        public PuntajeComponente()
        {
            _puntajeServicio = new PuntajeServicio();
        }

        /// <summary>
        /// Calcular el puntaje obtenido mediante las preguntas evaluadas y el tiempo, y guardar el puntaje para el usuario actual
        /// </summary>
        /// <param name="usuario">UsuarioDTO datos del usuario actual</param>
        /// <param name="preguntasEvaluadas">Lista de PreguntaDTO con las preguntas evaluadas</param>
        /// <param name="tiempo">int tiempo transcurrido</param>
        /// <returns>PuntajeDTO</returns>
        public async Task<PuntajeDTO> CalcularPuntaje(UsuarioDTO usuario, List<PreguntaDTO> preguntasEvaluadas, int tiempo)
        {
            var calculoPuntajeDTO = new CalculoPuntajeDTO
            {
                Usuario = usuario,
                PreguntasEvaluadas = preguntasEvaluadas,
                Tiempo = tiempo
            };

            return await _puntajeServicio.CalcularPuntaje(calculoPuntajeDTO);
        }

        /// <summary>
        /// Obtiene el listado de puntajes
        /// </summary>
        /// <returns>Lista de PuntajeDTO</returns>
        public async Task<List<PuntajeDTO>> ObtenerPuntajes()
        {
            return await _puntajeServicio.ObtenerPuntajes();
        }
    }
}
