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
    public partial class WAgregarCategoria : Form
    {
        public WMain iVentanaMain;
        private bool iAceptar;
        public WAgregarCategoria()
        {
            InitializeComponent();
            iAceptar = false;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (TCategoria.TextLength > 5)
            {
              
                Categoria categoria = new Categoria(TCategoria.Text);
                ControladorProyecto.AgregarCategoria(categoria);
                string mensaje = $"The category: '{categoria.NombreCategoria}' has been added";
                MessageBox.Show(mensaje, "Success", MessageBoxButtons.OK);
                iAceptar = true;
                this.Close();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void WAgregarCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!iAceptar)
            {
                if (TCategoria.TextLength > 0)
                {
                   DialogResult respuesta=  MessageBox.Show("Are you sure you want to close?", "Warning", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.No)
                    {
                        e.Cancel= true;
                    }
                }
            }
        }

        private void WAgregarCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            iVentanaMain.Visible = true;
        }
    }
}
