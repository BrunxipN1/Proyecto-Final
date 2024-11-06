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
    public partial class WPuntajes : Form
    {
        private List<Puntaje> iLPuntajes;

        public WPuntajes()
        {
            try { 
                InitializeComponent();
                iLPuntajes = ControladorProyecto.ObtenerListaPuntajes();
                int i = 1;
                foreach  (Puntaje mPunt in iLPuntajes)
                {
                    LView.Items.Add(new ListViewItem(new[]{ i.ToString(), mPunt.Usuario.NombreUsuario.ToString(), mPunt.ValorPuntaje.ToString("0.000"), mPunt.Tiempo.ToString(), mPunt.Fecha.ToString()}));
                    i++;
                }
            }
            catch (Exception ex)
            {
                Log.Error("WPuntajes - Constructor - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al obtener la lista de los puntajes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
