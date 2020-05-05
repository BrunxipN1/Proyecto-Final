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
    public partial class WTriviaFinalizada : Form
    {
        internal WMain iVentanaMain;
        internal Usuario iUsuario;
        internal int iSegundos;
        internal int iCantPreguntas;
        internal int iCantCorrectas;
        private int iCantIncorrectas;
        private Puntaje iPuntaje;
        internal Dificultad iDificultad;

        public WTriviaFinalizada()
        {
            InitializeComponent();
        }

        public void ConstruirVentana()
        {
            TimeSpan mTiempo = TimeSpan.FromSeconds(iSegundos);
            LTiempoD.Text = mTiempo.ToString(@"mm\:ss");
            iCantIncorrectas = iCantPreguntas - iCantCorrectas;
            LCantCorrectas.Text = (iCantCorrectas.ToString("00") + "/" + iCantPreguntas.ToString("00")).ToString();
            LCantIncorrectas.Text = (iCantIncorrectas + "/" + iCantPreguntas).ToString();
            LDificultad.Text = iDificultad.NombreDificultad.ToString();
            float mValor = CalcularPuntuacion();
            LPuntuacion.Text = mValor.ToString("0.000");
            iPuntaje = new Puntaje(iUsuario, mValor, DateTime.Now, iSegundos);
            ControladorProyecto.AgregarPuntaje(iUsuario, iPuntaje);

        }

        public float CalcularPuntuacion()
        {
            float mFactorDificultad = (float)iDificultad.Valor;
            float mCalculoTiempo = ((float)iSegundos / iCantPreguntas);
            float mFactorTiempo = 0f;
            if (mCalculoTiempo < 5)
            {
                mFactorTiempo = 5f;
            }
            else if ((mCalculoTiempo > 5) & (mCalculoTiempo < 20))
            {
                mFactorTiempo = 3f;
            }
            else
            {
                mFactorTiempo = 1f;
            }

            float mPuntaje = ((float)iCantCorrectas /iCantPreguntas) * mFactorDificultad * mFactorTiempo;
            Console.WriteLine(mPuntaje);
            return(mPuntaje);
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
