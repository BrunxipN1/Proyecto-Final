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
        internal Usuario iUsuario;
        internal List<Pregunta> iLPreguntas;
        internal int iSegundos;
        internal int iContRespCorrectas;
        private int iIndex;
        private List<Label> iLLabels;
        private List<Respuesta> iLResp;
        private bool iPararContador;
        private bool iFinalizado;
        public WTrivia()
        {           
            InitializeComponent();
            iLLabels = new List<Label> {
            this.LRespuesta1,
            this.LRespuesta2,
            this.LRespuesta3,
            this.LRespuesta4
            };
            iFinalizado = false;
            iPararContador = false;
            iIndex = 0;
            LTimer.Text = "00:00";
            iContRespCorrectas = 0;
            List<Respuesta> iLResp = new List<Respuesta>();            
        }

        internal void ConstruirDatos()
        {
            LResultado.Enabled = false;
            this.LPregunta.Text = iLPreguntas[iIndex].LaPregunta.ToString();
            iLResp = ControladorProyecto.ObtenerListaRandomRespuestas(iLPreguntas[iIndex]);
            for (int i = 0; i < 4; i++)
            {
                iLLabels[i].BackColor = Color.Black;
                iLLabels[i].Text = iLResp[i].SRespuesta.ToString();
            }
        }

        private void LRespuesta1_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(0);
        }

        private void LRespuesta2_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(1);
        }

        internal void Respuesta3_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(2);
        }

        private void LRespuesta4_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(3);
        }

        private void VerificarRespuesta(int pI)
        {
            iPararContador = true;
            if (iLResp[pI].Correcta)
            {
                iLLabels[pI].BackColor = Color.Green;
                LResultado.Text = "Correct!";
                LResultado.ForeColor = Color.LightGreen;
                iContRespCorrectas++;
            }
            else
            {
                LResultado.Text = "Incorrect";
                LResultado.ForeColor = Color.Tomato;
                iLLabels[pI].BackColor = Color.Red;
                for (int i = 0; i < 4; i++)
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
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            iIndex++;
            if (iIndex < iLPreguntas.Count)
            {
                ConstruirDatos();
                iPararContador = false;
                BSiguiente.Enabled = false;
            }
            else
            {
                iFinalizado = true;
                WTriviaFinalizada vTriviaFinalizada = new WTriviaFinalizada();
                vTriviaFinalizada.iUsuario = this.iUsuario;
                vTriviaFinalizada.iVentanaMain = iVentanaMain;
                vTriviaFinalizada.iSegundos = iSegundos;
                vTriviaFinalizada.iCantCorrectas = iContRespCorrectas;
                vTriviaFinalizada.iCantPreguntas = iLPreguntas.Count;
                vTriviaFinalizada.iDificultad = iLPreguntas.First().Dificultad;
                vTriviaFinalizada.ConstruirVentana();
                vTriviaFinalizada.Show();
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
