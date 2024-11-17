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
    public partial class WIniciarSesion : Form
    {
        public WIniciarSesion()
        {
            InitializeComponent();
        }

        private async void BLogin_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TUsername.Text) && !string.IsNullOrWhiteSpace(TPass.Text))
                {
                    var usuarioComponente = new UsuarioComponente();
                    this.Enabled = false;
                    var usuarioDTO = await usuarioComponente.AutenticarUsuario(TUsername.Text, TPass.Text);

                    if (usuarioDTO != null)
                    {
                        WMain vMain = new WMain(usuarioDTO);
                        vMain.iVIniciarSesion = this;
                        vMain.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Advertencia", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Uno o más campos están vacíos", "Advertencia", MessageBoxButtons.OK);
                }
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                Log.Error("WIniciarSesion - BLogin_ClickAsync - 1: {Message}", ex.Message);
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

        private void TPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
