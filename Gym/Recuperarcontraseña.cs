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
    public partial class Recuperarcontraseña : Form
    {
        public Recuperarcontraseña()
        {
            InitializeComponent();
        }

        private void btn_iniciosesion_Click(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "sistema.gimnasiosanangel@gmail.com")
            {
                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

                //sistema.gimnasiosanangel@gmail.com
                //gymsanangel247
                //Prueba cambiando correo
                //mmsg.To.Add("omaribarra25@hotmail.com");
                mmsg.To.Add("ing.oaio99@gmail.com");
                mmsg.Subject = "Recuperación de contraseña";
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                //mmsg.Bcc.Add("estebandk.111@gmail.com");

                mmsg.Body = "Su contraseña es 1234";
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                mmsg.IsBodyHtml = true;
                mmsg.From = new System.Net.Mail.MailAddress("sistema.gimnasiosanangel@gmail.com");

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                cliente.Credentials = new System.Net.NetworkCredential("sistema.gimnasiosanangel@gmail.com", "gymsanangel247");

                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Host = "smtp.gmail.com";

                try
                {
                    cliente.Send(mmsg);
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                lb_correoincorrecto.Text = "El correo no coincide";
            }
           

        }
    }
}
