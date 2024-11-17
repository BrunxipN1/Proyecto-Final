using Proyecto.Componentes;
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
        private readonly PuntajeComponente _puntajeComponente;

        public WPuntajes()
        {
            try
            {
                InitializeComponent();
                _puntajeComponente = new PuntajeComponente();
                CargarPuntajes();
            }
            catch (Exception ex)
            {
                Log.Error("WPuntajes - Constructor - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al inicializar la ventana de puntajes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async void CargarPuntajes()
        {
            try
            {
                // Obtener la lista de puntajes desde el componente
                var puntajes = await _puntajeComponente.ObtenerPuntajes();

                int i = 1;
                foreach (var puntaje in puntajes)
                {
                    LView.Items.Add(new ListViewItem(new[]
                    {
                        i.ToString(),
                        puntaje.Usuario.NombreUsuario,
                        puntaje.ValorPuntaje.ToString("0.000"),
                        puntaje.Tiempo.ToString(),
                        puntaje.Fecha.ToString("dd/MM/yyyy")
                    }));
                    i++;
                }
            }
            catch (Exception ex)
            {
                Log.Error("WPuntajes - CargarPuntajes - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al cargar los puntajes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
