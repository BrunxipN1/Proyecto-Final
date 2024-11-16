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
    public partial class WRegistrarse : Form
    {
        public WIniciarSesion iVIniciarSesion;
        private readonly UsuarioComponente _usuarioComponente;

        public WRegistrarse()
        {
            InitializeComponent();
            _usuarioComponente = new UsuarioComponente();
        }

        private async void BCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(TUser.Text) && !string.IsNullOrWhiteSpace(TPass.Text) && !string.IsNullOrWhiteSpace(TConfirm.Text))
                {
                    if (TPass.Text != TConfirm.Text)
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var usuarioDTO = await _usuarioComponente.RegistrarUsuario(TUser.Text, TPass.Text);

                    if (usuarioDTO != null)
                    {
                        MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK);

                        // Abre WMain con el usuario recién registrado
                        WMain vMain = new WMain(usuarioDTO);
                        vMain.iVIniciarSesion = iVIniciarSesion;
                        vMain.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el usuario. Intente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Uno o más campos están vacíos", "Advertencia", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TUser_TextChanged(object sender, EventArgs e)
        {
            LUsernameTaken.Visible = false;
        }

        private void TConfirm_TextChanged(object sender, EventArgs e)
        {
            LPassMatch.Visible = false;
        }

        private void WRegistrarse_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
