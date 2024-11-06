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
        private Boolean iAceptado;

        public WPreguntaManual()
        {
            try {
                InitializeComponent();
                using (TriviaContext db = new TriviaContext())
                {
                    TDificultad.DataSource = db.Dificultades.ToList();
                    TDificultad.ValueMember = "IdDificultad";
                    TDificultad.DisplayMember = "NombreDificultad";
                    TCategoria.DataSource = db.Categorias.ToList();
                    TCategoria.ValueMember = "IdCategoria";
                    TCategoria.DisplayMember = "NombreCategoria";
                }
                iAceptado = false;
            }
            catch (Exception ex)
            {
                Log.Error("WPreguntaManual - Constructor - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al inicializar los datos de la ventana.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try {
                if (!string.IsNullOrWhiteSpace(TPregunta.Text) & !string.IsNullOrWhiteSpace(TRespuestaCorrecta.Text) & !string.IsNullOrWhiteSpace(TRespIncorrecta1.Text) & !string.IsNullOrWhiteSpace(TRespIncorrecta2.Text) & !string.IsNullOrWhiteSpace(TRespIncorrecta3.Text))
                {
                    Categoria iCategoria = TCategoria.SelectedItem as Categoria;
                    Dificultad iDificultad = TDificultad.SelectedItem as Dificultad;
                
                    List<Respuesta> iRespuestas = new List<Respuesta>
                    {
                        new Respuesta(TRespuestaCorrecta.Text, true),
                        new Respuesta(TRespIncorrecta1.Text, false),
                        new Respuesta(TRespIncorrecta2.Text, false),
                        new Respuesta(TRespIncorrecta3.Text, false),
                    };
                    Pregunta iPregunta = new Pregunta(TPregunta.Text, iCategoria, iDificultad, iRespuestas);
                    List<Pregunta> lPregunta = new List<Pregunta> { iPregunta };
                    ControladorProyecto.AgregarPreguntas(lPregunta);
                    MessageBox.Show("The question has been added!", "Success!", MessageBoxButtons.OK);
                    iAceptado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("One or more fields are empty", "Warning", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                Log.Error("WPreguntaManual - Aceptar_Click - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al agregar la pregunta. Vuelva a intentar más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
