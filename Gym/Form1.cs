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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            cu_inicio1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fechahora_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();
            Fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            cu_inicio1.BringToFront();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            clientes1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //cu_Asistencia1.BringToFront();
        }

        private void btn_registros_Click(object sender, EventArgs e)
        {
            //cu_registros1.BringToFront();
        }

        private void btn_pagos_Click(object sender, EventArgs e)
        {
            cu_pago1.BringToFront();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientes1_Load(object sender, EventArgs e)
        {

        }
    }
}
