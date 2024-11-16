using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Servicios.DTO;
using Proyecto.Servicios;

namespace Proyecto.Componentes
{
    internal class PuntajeComponente
    {
        private readonly PuntajeServicio _puntajeServicio;

        public PuntajeComponente()
        {
            _puntajeServicio = new PuntajeServicio();
        }

        public async Task<PuntajeDTO> CalcularPuntaje(PuntajeRequestDTO puntajeRequest)
        {
            return await _puntajeServicio.CalcularPuntaje(puntajeRequest);
        }

        public async Task<List<PuntajeDTO>> ObtenerPuntajes()
        {
            return await _puntajeServicio.ObtenerPuntajes();
        }
    }
}
