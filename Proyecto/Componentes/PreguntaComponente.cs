using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Servicios.DTO;
using Proyecto.Servicios;

namespace Proyecto.Componentes
{
    internal class PreguntaComponente
    {
        private readonly PreguntaServicio _preguntaServicio;

        public PreguntaComponente()
        {
            _preguntaServicio = new PreguntaServicio();
        }

        public async Task<List<CategoriaDTO>> ObtenerCategorias()
        {
            return await _preguntaServicio.ObtenerCategorias();
        }

        public async Task<List<DificultadDTO>> ObtenerDificultades()
        {
            return await _preguntaServicio.ObtenerDificultades();
        }

        public async Task<List<PreguntaDTO>> ObtenerPreguntas(int categoriaId, int dificultadId, int cantidad)
        {
            var requestDTO = new PreguntaRequestDTO
            {
                CategoriaId = categoriaId,
                DificultadId = dificultadId,
                Cantidad = cantidad
            };

            return await _preguntaServicio.ObtenerPreguntas(requestDTO);
        }

        public async Task<bool> GuardarPreguntaManual(PreguntaDTO pregunta)
        {
            return await _preguntaServicio.GuardarPreguntaManual(pregunta);
        }

        public async Task<bool> AgregarPreguntasDesdeWeb(CategoriaDTO categoria, DificultadDTO dificultad, int cantidad)
        {
            var request = new PreguntaWebRequestDTO
            {
                CategoriaId = categoria.IdCategoria,
                DificultadId = dificultad.IdDificultad,
                Cantidad = cantidad
            };

            return await _preguntaServicio.AgregarPreguntasDesdeWeb(request);
        }
    }
}
