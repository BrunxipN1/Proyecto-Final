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

        public WRegistrarse()
        {
            InitializeComponent();
        }

        private void BCreateAccount_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TUser.Text) & !string.IsNullOrWhiteSpace(TPass.Text) & !string.IsNullOrWhiteSpace(TConfirm.Text))
            {
                if (!ControladorProyecto.NombreUsuarioExistente(TUser.Text))
                {
                    if (TPass.Text == TConfirm.Text)
                    {
                        Usuario mUsuario = new Usuario(TUser.Text, TPass.Text);
                        ControladorProyecto.AgregarUsuario(mUsuario);
                        WMain VMain = new WMain(mUsuario);
                        VMain.iVIniciarSesion = iVIniciarSesion;
                        VMain.Show();
                        this.Close();
                    }
                    else
                    {
                        LPassMatch.Visible = true;
                    }
                }
                else
                {
                    LUsernameTaken.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("One or more fields are empty", "Warning", MessageBoxButtons.OK);
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
