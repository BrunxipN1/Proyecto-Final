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
    public partial class WPreguntaManual : Form
    {
        
        public WMain iVentanaMain;
        private Boolean aceptado;
        private Categoria iCategoriaSeleccionada;

        public WPreguntaManual()
        {
            InitializeComponent();
            aceptado = false;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WPreguntaManual_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Are you sure you want to close the form?", "Warning", MessageBoxButtons.YesNo);

            iVentanaMain.Visible = true;
        }

        private void WPreguntaManual_Load(object sender, EventArgs e)
        {

        }

        private void TCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
