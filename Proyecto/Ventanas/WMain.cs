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
    public partial class WMain : Form
    {
        public UsuarioDTO iUsuario;
        public WIniciarSesion iVIniciarSesion;
        private bool iSalir;

        public WMain(UsuarioDTO pUsuario)
        {
            InitializeComponent();
            iUsuario = pUsuario;
            LNombreUsuario.Text = iUsuario.NombreUsuario;
            iSalir = true;
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


        private void BJugar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var vConfigurarTrivia = new WConfigurarTrivia
            {
                iUsuario = this.iUsuario,
                iVentanaMain = this
            };
            vConfigurarTrivia.Show();
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

        private void WMain_Load(object sender, EventArgs e)
        {

        }
    }
}
