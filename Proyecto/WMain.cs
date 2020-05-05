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
    public partial class WMain : Form
    {
        public Usuario iUsuario;
        public WIniciarSesion iVIniciarSesion;
        private bool iSalir;

        public WMain(Usuario pUsuario)
        {
            InitializeComponent();
            iUsuario = pUsuario;
            LNombreUsuario.Text = iUsuario.NombreUsuario;
            iSalir = true;
        }


        private void VerPreguntas_Click(object sender, EventArgs e)
        {
            //ControladorProyecto.HardcodeamelasCategoriasmaestro();
            //ControladorProyecto.Hardcodeameladificultadmaestro();

            //WIniciarSesion vIniciarSesion = new WIniciarSesion();
            //vIniciarSesion.Show();
            //vIniciarSesion.iVentanaMain = this;
        }

        private void PreguntaManual_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            WPreguntaManual vPregManual = new WPreguntaManual();
            vPregManual.Show();
            vPregManual.iVentanaMain = this;
        }

        private void PreguntaWeb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            WAgregarPreguntasWeb vAddPregWeb = new WAgregarPreguntasWeb();
            vAddPregWeb.Show();
            vAddPregWeb.iVentanaMain = this;
        }

        private void AgregarCategoria_Click(object sender, EventArgs e)
        {
            List<Puntaje> mPunt = ControladorProyecto.ObtenerListaPuntajes();
            foreach (Puntaje bPunt in mPunt)
            {
                Console.WriteLine("{0} -- {1}",bPunt.ValorPuntaje.ToString(), bPunt.Usuario.NombreUsuario);
            }
        }

        private void BJugar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            WConfigurarTrivia vConfigurarTrivia = new WConfigurarTrivia();
            vConfigurarTrivia.iUsuario = this.iUsuario;
            vConfigurarTrivia.Show();
            vConfigurarTrivia.iVentanaMain = this;
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            this.iVIniciarSesion.Visible = true;
            iSalir = false;
            this.Close();
        }

        private void WMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (iSalir)
            {
                Application.Exit();
            }
        }

        private void BQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerPuntajes_Click(object sender, EventArgs e)
        {
            WPuntajes vPuntajes = new WPuntajes();
            vPuntajes.Show();
        }
    }
}
