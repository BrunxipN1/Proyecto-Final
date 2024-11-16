using Proyecto.Servicios.DTO;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Componentes;

namespace Proyecto
{
    public partial class WTriviaFinalizada : Form
    {
        internal WMain iVentanaMain;
        internal UsuarioDTO iUsuario;
        internal int iSegundos;
        internal int iCantPreguntas;
        internal int iCantCorrectas;
        private int iCantIncorrectas;
        private PuntajeDTO iPuntaje;
        internal DificultadDTO iDificultad;
        private readonly PuntajeComponente _puntajeComponente;

        public WTriviaFinalizada()
        {
            InitializeComponent();
            _puntajeComponente = new PuntajeComponente();
        }

        public async void ConstruirVentana()
        {
            try
            {
                TimeSpan tiempo = TimeSpan.FromSeconds(iSegundos);
                LTiempoD.Text = tiempo.ToString(@"mm\:ss");

                iCantIncorrectas = iCantPreguntas - iCantCorrectas;
                LCantCorrectas.Text = $"{iCantCorrectas:00}/{iCantPreguntas:00}";
                LCantIncorrectas.Text = $"{iCantIncorrectas:00}/{iCantPreguntas:00}";
                LDificultad.Text = iDificultad.NombreDificultad;

                var puntajeRequest = new PuntajeRequestDTO
                {
                    Usuario = iUsuario,
                    CantCorrectas = iCantCorrectas,
                    CantPreguntas = iCantPreguntas,
                    Tiempo = iSegundos,
                    Dificultad = iDificultad
                };

                iPuntaje = await _puntajeComponente.CalcularPuntaje(puntajeRequest);

                LPuntuacion.Text = iPuntaje.ValorPuntaje.ToString("0.000");
            }
            catch (Exception ex)
            {
                Log.Error("WTriviaFinalizada - ConstruirVentana - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al calcular el puntaje. Vuelva a intentar más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void WTriviaFinalizada_FormClosing(object sender, FormClosingEventArgs e)
        {

            iVentanaMain.Visible = true;
        }
    }
}
