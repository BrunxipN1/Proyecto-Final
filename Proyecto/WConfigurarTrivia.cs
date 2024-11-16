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
    public partial class WConfigurarTrivia : Form
    {

        public WMain iVentanaMain;
        internal UsuarioDTO iUsuario;
        private readonly PreguntaComponente _preguntaComponente;

        public WConfigurarTrivia()
        {
            try {
                InitializeComponent();
                _preguntaComponente = new PreguntaComponente();
                CargarCategoriasYDificultades();
            }
            catch (Exception ex)
            {
                Log.Error("WConfigurarTrivia - Constructor - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al inicializar la ventana. Vuelva a intentarlo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async void CargarCategoriasYDificultades()
        {
            try
            {
                var categorias = await _preguntaComponente.ObtenerCategorias();
                var dificultades = await _preguntaComponente.ObtenerDificultades();

                TCategoria.DataSource = categorias;
                TCategoria.ValueMember = "IdCategoria";
                TCategoria.DisplayMember = "NombreCategoria";

                TDificultad.DataSource = dificultades;
                TDificultad.ValueMember = "IdDificultad";
                TDificultad.DisplayMember = "NombreDificultad";
            }
            catch (Exception ex)
            {
                Log.Error("WConfigurarTrivia - CargarCategoriasYDificultades - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al cargar los datos. Vuelva a intentarlo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TCantidad.Value != 0)
                {
                    var categoriaId = (int)TCategoria.SelectedValue;
                    var dificultadId = (int)TDificultad.SelectedValue;
                    var cantidad = (int)TCantidad.Value;

                    var preguntas = await _preguntaComponente.ObtenerPreguntas(categoriaId, dificultadId, cantidad);

                    if (preguntas == null || preguntas.Count == 0)
                    {
                        MessageBox.Show("No se encontraron preguntas con los criterios seleccionados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var vTrivia = new WTrivia
                    {
                        iVentanaMain = iVentanaMain,
                        iUsuario = iUsuario,
                        iLPreguntas = preguntas
                    };

                    vTrivia.ConstruirDatos();
                    vTrivia.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El campo de cantidad debe ser mayor a 0.", "Advertencia", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                Log.Error("WConfigurarTrivia - Aceptar_Click - 1: {Message}", ex.Message);
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            iVentanaMain.Visible = true;
        }
       

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
