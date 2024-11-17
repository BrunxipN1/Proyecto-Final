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
        internal int iSegundos;
        internal int iCantPreguntas;
        internal int iCantCorrectas;
        private int iCantIncorrectas;
        internal string iPuntaje;
        internal string iDificultad;

        public WTriviaFinalizada()
        {
            InitializeComponent();
        }

        public void ConstruirVentana()
        {
            try
            {
                TimeSpan tiempo = TimeSpan.FromSeconds(iSegundos);
                LTiempoD.Text = tiempo.ToString(@"mm\:ss");

                iCantIncorrectas = iCantPreguntas - iCantCorrectas;
                LCantCorrectas.Text = $"{iCantCorrectas:00}/{iCantPreguntas:00}";
                LCantIncorrectas.Text = $"{iCantIncorrectas:00}/{iCantPreguntas:00}";
                LDificultad.Text = iDificultad;
                LPuntuacion.Text = iPuntaje;
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
