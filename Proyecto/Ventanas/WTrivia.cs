using Proyecto.Componentes;
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

namespace Proyecto
{
    public partial class WTrivia : Form
    {
        internal WMain iVentanaMain;
        internal UsuarioDTO iUsuario;
        internal List<PreguntaDTO> iLPreguntas;
        internal int iSegundos;
        internal int iContRespCorrectas;
        private int iIndex;
        private List<Label> iLLabels;
        private List<RespuestaDTO> iLResp;
        private bool iPararContador;
        private bool iFinalizado;
        private readonly TriviaComponente _triviaComponente;
        private readonly PuntajeComponente _puntajeComponente;

        public WTrivia()
        {   
            try { 
                InitializeComponent();
                iLLabels = new List<Label>
                {
                    LRespuesta1,
                    LRespuesta2,
                    LRespuesta3,
                    LRespuesta4
                };
                _triviaComponente = new TriviaComponente();
                _puntajeComponente = new PuntajeComponente();
                iFinalizado = false;
                iPararContador = false;
                iIndex = 0;
                LTimer.Text = "00:00";
                iContRespCorrectas = 0;
                iLResp = new List<RespuestaDTO>();
            }
            catch (Exception ex)
            {
                Log.Error("WTrivia - Constructor - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al iniciar la trivia. Vuelva a intentar más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        internal void ConstruirDatos()
        {
            try {
                // Construye la pantalla con pregunta y respuestas
                LResultado.Enabled = false;
                var preguntaActual = iLPreguntas[iIndex];
                LPregunta.Text = preguntaActual.LaPregunta;
                iLResp = preguntaActual.Respuestas.OrderBy(_ => Guid.NewGuid()).ToList();

                for (int i = 0; i < iLLabels.Count; i++)
                {
                    iLLabels[i].BackColor = Color.Black;
                    iLLabels[i].Text = iLResp[i].TextoRespuesta;
                }
            }
            catch (Exception ex)
            {
                Log.Error("WTrivia - ConstruirDatos - 1: {Message}", ex.Message);
                throw;
            }
        }

        private async void VerificarRespuesta(int respuestaIndex)
        {
            try
            {
                var preguntaActual = iLPreguntas[iIndex];
                var respuestaSeleccionada = iLResp[respuestaIndex];

                // Marca la respuesta seleccionada y verifica la pregunta, dando color verde o rojo dependiendo si es correcta
                preguntaActual = _triviaComponente.MarcarRespuestaSeleccionada(preguntaActual, respuestaSeleccionada.IdRespuesta);

                var resultado = await _triviaComponente.VerificarPregunta(preguntaActual);

                foreach (var respuesta in resultado.Respuestas)
                {
                    var labelIndex = iLResp.FindIndex(r => r.IdRespuesta == respuesta.IdRespuesta);
                    if (labelIndex >= 0)
                    {
                        iLLabels[labelIndex].BackColor = respuesta.Correcta
                            ? Color.Green
                            : respuesta.Seleccionada
                                ? Color.Red
                                : Color.Black;
                    }
                }

                LResultado.Enabled = true;
                LResultado.Text = resultado.Respuestas.Any(r => r.Correcta && r.Seleccionada) ? "¡Correct!" : "Incorrect";
                LResultado.ForeColor = resultado.Respuestas.Any(r => r.Correcta && r.Seleccionada) ? Color.LightGreen : Color.Tomato;

                BSiguiente.Enabled = true;
                foreach (var label in iLLabels)
                {
                    label.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Log.Error("WTrivia - VerificarRespuesta - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al verificar la respuesta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LRespuesta1_Click(object sender, EventArgs e) => VerificarRespuesta(0);
        private void LRespuesta2_Click(object sender, EventArgs e) => VerificarRespuesta(1);
        private void Respuesta3_Click(object sender, EventArgs e) => VerificarRespuesta(2);
        private void LRespuesta4_Click(object sender, EventArgs e) => VerificarRespuesta(3);


        private async void BSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                iIndex++;

                if (iIndex < iLPreguntas.Count)
                {
                    // pasa a la siguiente pregunta
                    foreach (var label in iLLabels)
                    {
                        label.Enabled = true;
                    }

                    ConstruirDatos();
                    iPararContador = false;
                    BSiguiente.Enabled = false;
                }
                else
                {
                    // terminan las preguntas y comienza el cálculo de puntaje
                    iFinalizado = true;

                    var preguntasEvaluadas = _triviaComponente.ObtenerPreguntasEvaluadas();
                    var puntaje = await _puntajeComponente.CalcularPuntaje(iUsuario, preguntasEvaluadas, iSegundos);
                    var vTriviaFinalizada = new WTriviaFinalizada
                    {
                        iVentanaMain = iVentanaMain,
                        iSegundos = puntaje.Tiempo,
                        iCantPreguntas = puntaje.CantidadPreguntas,
                        iCantCorrectas = puntaje.CantidadCorrectas,
                        iPuntaje = puntaje.ValorPuntaje.ToString("0.000"),
                        iDificultad = preguntasEvaluadas.First().Dificultad.NombreDificultad
                    };

                    vTriviaFinalizada.ConstruirVentana();
                    vTriviaFinalizada.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log.Error("WTrivia - BSiguiente_Click - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WTrivia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!iFinalizado)
            {
                e.Cancel = true;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            // contador en segundos
            if (!iPararContador)
            {
                iSegundos++;
                TimeSpan mTiempo = TimeSpan.FromSeconds(iSegundos);
                LTimer.Text = mTiempo.ToString(@"mm\:ss");
            }

        }
    }

     
}
