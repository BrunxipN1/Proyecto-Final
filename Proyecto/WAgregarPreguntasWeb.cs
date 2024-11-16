using Proyecto.Componentes;
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
    public partial class WAgregarPreguntasWeb : Form
    {

        public WMain iVentanaMain;
        private bool iAceptado;
        private readonly TriviaComponente _triviaComponente;

        public WAgregarPreguntasWeb()
        {
            try
            {
                InitializeComponent();
                _triviaComponente = new TriviaComponente();
                CargarDificultadesYCategorias();
                iAceptado = false;
            }
            catch (Exception ex)
            {
                Log.Error("WAgregarPreguntasWeb - Constructor - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al inicializar los datos de la ventana.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async void CargarDificultadesYCategorias()
        {
            try
            {
                // Obtener dificultades y categorías desde el componente
                var dificultades = await _triviaComponente.ObtenerDificultades();
                var categorias = await _triviaComponente.ObtenerCategorias();

                TDificultad.DataSource = dificultades;
                TDificultad.ValueMember = "IdDificultad";
                TDificultad.DisplayMember = "NombreDificultad";

                TCategoria.DataSource = categorias;
                TCategoria.ValueMember = "IdCategoria";
                TCategoria.DisplayMember = "NombreCategoria";
            }
            catch (Exception ex)
            {
                Log.Error("WAgregarPreguntasWeb - CargarDificultadesYCategorias - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al cargar las dificultades y categorías.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TCantidad.Value > 0)
                {
                    var categoria = (CategoriaDTO)TCategoria.SelectedItem;
                    var dificultad = (DificultadDTO)TDificultad.SelectedItem;

                    var resultado = await _triviaComponente.AgregarPreguntasDesdeWeb(categoria, dificultad, (int)TCantidad.Value);

                    if (resultado)
                    {
                        MessageBox.Show("Todas las preguntas han sido agregadas exitosamente.", "Éxito", MessageBoxButtons.OK);
                        iAceptado = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron agregar las preguntas. Intente nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad debe ser mayor a 0.", "Advertencia", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                Log.Error("WAgregarPreguntasWeb - Aceptar_Click - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al importar las preguntas desde la web.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WPreguntaManual_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!iAceptado) {
                DialogResult iDialogResult = MessageBox.Show("Are you sure you want to close the form?", "Warning", MessageBoxButtons.YesNo);
                if (iDialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    iVentanaMain.Visible = true;
                }

            }
            else
            {
                iVentanaMain.Visible = true;
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
