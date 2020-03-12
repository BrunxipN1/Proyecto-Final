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
        private Boolean iAceptado;

        public WAgregarPreguntasWeb()
        {
            InitializeComponent();
            using (TriviaContext db = new TriviaContext())
            {
                TDificultad.DataSource = db.Dificultad.ToList();
                TDificultad.ValueMember = "IdDificultad";
                TDificultad.DisplayMember = "NombreDificultad";
                TCategoria.DataSource = db.Categoria.ToList();
                TCategoria.ValueMember = "IdCategoria";
                TCategoria.DisplayMember = "NombreCategoria";
            }
            iAceptado = false;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (TCantidad.Value != 0)
            {
                Categoria iCategoria = TCategoria.SelectedItem as Categoria;
                Dificultad iDificultad = TDificultad.SelectedItem as Dificultad;
                ControladorProyecto.AgregarPorUrl(iCategoria, iDificultad, Convert.ToInt32(TCantidad.Value));
                MessageBox.Show("All the questions have been added!", "Success!", MessageBoxButtons.OK);
                iAceptado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("The amount field must be greater than 0", "Warning", MessageBoxButtons.OK);
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
