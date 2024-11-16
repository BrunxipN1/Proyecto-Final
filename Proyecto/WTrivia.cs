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
                LResultado.Enabled = false;
                var preguntaActual = iLPreguntas[iIndex];
                LPregunta.Text = preguntaActual.LaPregunta;
                iLResp = preguntaActual.Respuestas.OrderBy(_ => Guid.NewGuid()).ToList();

                for (int i = 0; i < iLLabels.Count; i++)
                {
                    iLLabels[i].BackColor = Color.Black;
                    iLLabels[i].Text = iLResp[i].SRespuesta;
                }
            }
            catch (Exception ex)
            {
                Log.Error("WTrivia - ConstruirDatos - 1: {Message}", ex.Message);
                throw;
            }
        }

        private void VerificarRespuesta(int pI)
        {
            iPararContador = true;

            if (iLResp[pI].Correcta)
            {
                iLLabels[pI].BackColor = Color.Green;
                LResultado.Text = "¡Correcto!";
                LResultado.ForeColor = Color.LightGreen;
                iContRespCorrectas++;
            }
            else
            {
                LResultado.Text = "Incorrecto";
                LResultado.ForeColor = Color.Tomato;
                iLLabels[pI].BackColor = Color.Red;

                // Mostrar la respuesta correcta
                for (int i = 0; i < iLResp.Count; i++)
                {
                    if (iLResp[i].Correcta)
                    {
                        iLLabels[i].BackColor = Color.Green;
                        break;
                    }
                }
            }

            LResultado.Enabled = true;
            BSiguiente.Enabled = true;

            // Deshabilitar los labels
            foreach (var label in iLLabels)
            {
                label.Enabled = false;
            }
        }

        private void LRespuesta1_Click(object sender, EventArgs e) => VerificarRespuesta(0);
        private void LRespuesta2_Click(object sender, EventArgs e) => VerificarRespuesta(1);
        private void Respuesta3_Click(object sender, EventArgs e) => VerificarRespuesta(2);
        private void LRespuesta4_Click(object sender, EventArgs e) => VerificarRespuesta(3);


        private void BSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                iIndex++;

                if (iIndex < iLPreguntas.Count)
                {
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
                    iFinalizado = true;

                    // Abrir ventana de resultados
                    var vTriviaFinalizada = new WTriviaFinalizada
                    {
                        iUsuario = iUsuario,
                        iVentanaMain = iVentanaMain,
                        iSegundos = iSegundos,
                        iCantCorrectas = iContRespCorrectas,
                        iCantPreguntas = iLPreguntas.Count,
                        iDificultad = iLPreguntas.First().Dificultad
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
            if (!iPararContador)
            {
                iSegundos++;
                TimeSpan mTiempo = TimeSpan.FromSeconds(iSegundos);
                LTimer.Text = mTiempo.ToString(@"mm\:ss");
            }

        }
    }

     
}
