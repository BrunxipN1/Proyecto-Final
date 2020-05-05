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
        internal Usuario iUsuario;

        public WConfigurarTrivia()
        {
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
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (TCantidad.Value != 0) 
            {
                Categoria iCategoria = TCategoria.SelectedItem as Categoria;
                Dificultad iDificultad = TDificultad.SelectedItem as Dificultad;
                WTrivia vTrivia = new WTrivia();
                List<Pregunta> mLPreguntas = ControladorProyecto.ObtenerListaPregunta(iCategoria, iDificultad, Convert.ToInt32(TCantidad.Value));
                vTrivia.iVentanaMain = iVentanaMain;
                vTrivia.iLPreguntas = mLPreguntas;
                vTrivia.iUsuario = this.iUsuario;
                vTrivia.ConstruirDatos();
                vTrivia.Show();
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
