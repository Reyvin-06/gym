using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_iniciosesion_Click(object sender, EventArgs e)
        {
            iniciarsesion(this.txtusuario.Text, this.txtcontraseña.Text);
        }

        private void iniciarsesion(string usuario, string contraseña)
        {
            try
            {
                if (usuario == "gerente" && contraseña == "1234")
                {
                    this.Hide();
                    Principal principal = new Principal();
                    principal.Show();
                }
                else
                {
                    lb_loginincorrecto.Text = "Usuario y/o contraseña incorrectos";
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperarcontraseña recuperarcontraseña = new Recuperarcontraseña();
            recuperarcontraseña.Show();
        }
    }
}
