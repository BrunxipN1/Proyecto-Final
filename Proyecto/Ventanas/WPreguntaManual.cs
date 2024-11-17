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
    public partial class WPreguntaManual : Form
    {

        public WMain iVentanaMain;
        private bool iAceptado;
        private readonly TriviaComponente _triviaComponente;

        public WPreguntaManual()
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
                Log.Error("WPreguntaManual - Constructor - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al inicializar los datos de la ventana.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async void CargarDificultadesYCategorias()
        {
            try
            {
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
                Log.Error("WPreguntaManual - CargarDificultadesYCategorias - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al cargar las dificultades y categorías.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(TPregunta.Text) &&
                    !string.IsNullOrWhiteSpace(TRespuestaCorrecta.Text) &&
                    !string.IsNullOrWhiteSpace(TRespIncorrecta1.Text) &&
                    !string.IsNullOrWhiteSpace(TRespIncorrecta2.Text) &&
                    !string.IsNullOrWhiteSpace(TRespIncorrecta3.Text))
                {
                    var nuevaPregunta = new PreguntaDTO
                    {
                        LaPregunta = TPregunta.Text,
                        Categoria = (CategoriaDTO)TCategoria.SelectedItem,
                        Dificultad = (DificultadDTO)TDificultad.SelectedItem,
                        Respuestas = new List<RespuestaDTO>
                            {
                                new RespuestaDTO { TextoRespuesta = TRespuestaCorrecta.Text, Correcta = true },
                                new RespuestaDTO { TextoRespuesta = TRespIncorrecta1.Text, Correcta = false },
                                new RespuestaDTO { TextoRespuesta = TRespIncorrecta2.Text, Correcta = false },
                                new RespuestaDTO { TextoRespuesta = TRespIncorrecta3.Text, Correcta = false },
                            }
                    };

                    var resultado = await _triviaComponente.GuardarPreguntaManual(nuevaPregunta);

                    if (resultado)
                    {
                        MessageBox.Show("La pregunta ha sido agregada exitosamente.", "Éxito", MessageBoxButtons.OK);
                        iAceptado = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la pregunta. Intente nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Uno o más campos están vacíos.", "Advertencia", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                Log.Error("WPreguntaManual - Aceptar_Click - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al agregar la pregunta. Intente nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
