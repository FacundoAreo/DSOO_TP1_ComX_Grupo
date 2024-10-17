﻿using System;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

            if(txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.UseSystemPasswordChar = false;  
            }
        }
    }
}
