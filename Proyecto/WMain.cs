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

        public WMain()
        {
            InitializeComponent();
        }


        private void VerPreguntas_Click(object sender, EventArgs e)
        {
            //ControladorProyecto.HardcodeamelasCategoriasmaestro();
            //ControladorProyecto.Hardcodeameladificultadmaestro();
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

        }
    }
}
