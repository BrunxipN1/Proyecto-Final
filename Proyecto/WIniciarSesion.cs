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
    public partial class WIniciarSesion : Form
    {
        public WIniciarSesion()
        {
            InitializeComponent();
        }

        private void BLogin_ClickAsync(object sender, EventArgs e)
        {
            try {
                if (!string.IsNullOrEmpty(TUsername.Text) & !string.IsNullOrWhiteSpace(TPass.Text))
                {
                    Usuario mUsuario = ControladorProyecto.ObtenerUsuario(TUsername.Text, TPass.Text);

                    if (mUsuario != null)
                    {
                        WMain VMain = new WMain(mUsuario);
                        VMain.iVIniciarSesion = this;
                        VMain.AgregarCategoria.Visible = mUsuario.EsAdmin;
                    
                        this.Visible = false;
                        VMain.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password", "Warning", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("One or more fields are empty", "Warning", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                Log.Error("WIniciarSesion - BLogin_Click - 1: {Message}", ex.Message);
                MessageBox.Show("Ha ocurrido un error al iniciar sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LCreate_Click(object sender, EventArgs e)
        {
            WRegistrarse vRegistrarse = new WRegistrarse();
            vRegistrarse.iVIniciarSesion = this;
            this.Visible = false;
            vRegistrarse.Show();
        }

        private void BQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
