using SIstema_ClubDeportivo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Usuario
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 207, this.Height / 2 - 162);
            pnlLogin.Visible = true;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando llega el foco*/

            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando llega el foco*/

            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando se va el foco*/

            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando se va el foco*/

            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            LlamarLogin();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LlamarLogin();
            }
        }



        private void LlamarLogin()
        {
            if (txtUsuario.Text == "Usuario")
            {
                MessageBox.Show("Usuario Vacío");
                txtUsuario.Focus();
                return;
            }
            if (txtPass.Text == "Contraseña")
            {
                MessageBox.Show("Contraseña vacía");
                txtPass.Focus();
                return;
            }

            // CODIGO PARA LOGIN
            frmMenu form = new frmMenu();
            this.Hide();
            form.Show();
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 207, this.Height / 2 - 162);
        }
    }
}
