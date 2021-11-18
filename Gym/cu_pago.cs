using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gym
{
    public partial class cu_pago : UserControl
    {
        public cu_pago()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-0EN1J76;Initial Catalog=gym;Integrated Security=True");
        Conexiones conexiones = new Conexiones();


        private void bn_confirmar_Click(object sender, EventArgs e)
        {
            
        }

        private void Bton_confirmar_Click(object sender, EventArgs e)
        {

            try
            {
                if (cbx_clientes.Text == null || nm_meses.Value == 0 || lb_pagar.Text == "" || txt_pago.Text == "")
                {
                    MessageBox.Show("Favor de llenar los campos vacios");
                }
                else
                {
                    SqlCommand cmc = new SqlCommand("INSERT INTO registro_pago(nombre_cliente,descripcion,cantidad,fecha,fecha_renovacion) VALUES " +
                   "('" + cbx_clientes.Text + "','" + nm_meses.Value + "'," + Convert.ToDouble(lb_pagar.Text) + ",CONVERT(date,GETDATE())" + ",CONVERT(date,GETDATE()))", cn);

                    decimal aux = Convert.ToDecimal(lb_pagar.Text);
                    cn.Open();
                    int filasafectadas = cmc.ExecuteNonQuery();
                    cn.Close();

                    if (filasafectadas > 0)
                    {
                        MessageBox.Show("se agrego");
                        cbx_clientes.Text = "";
                        nm_meses.Value = 0;
                        txt_pago.Text = "";
                        lb_pagar.Text = "0";
                        lb_cambio.Text = "0";

                    }
                    else
                    {
                        MessageBox.Show("no se agrego");
                    }
                    cn.Open();
                    SqlCommand cmg = new SqlCommand("select nombre,estado from clientes where nombre = '"+cbx_clientes.Text+"' AND estado = 'Inactivo'",cn);
                    SqlDataReader rdr = cmg.ExecuteReader();
                    string estadoaux = "";
                    string nombreaux = "";
                    if (rdr.Read())
                    {
                        estadoaux = Convert.ToString(rdr["estado"]);
                        nombreaux = Convert.ToString(rdr["nombre"]);
                    }
                    cn.Close();
                    //lb_aux.Text = estadoaux;

                    if (nombreaux == cbx_clientes.Text && estadoaux == "Inactivo")
                    {
                        SqlCommand cmt = new SqlCommand("update clientes set estado = 'Activo' where nombre = '"+cbx_clientes.Text+"'", cn);
                        cn.Open();
                        cmt.ExecuteNonQuery();
                        cn.Close();
                    }

                    
                }
               
                SqlCommand cmd = new SqlCommand("select * from registro_pago", cn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgv_pagos.DataSource = dt;
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           


        }

        private void txt_nombrecliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cu_pago_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from registro_pago", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_pagos.DataSource = dt;
                cn.Close();

                cbx_clientes.DataSource = conexiones.Cargarclientes();
                cbx_clientes.DisplayMember = "nombre";
                cbx_clientes.ValueMember = "nombre";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            

        }

        private void nm_meses_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string query = "select mensualidad from datos";
                double mensualidad=0, aux=0;
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    mensualidad = Convert.ToDouble(dr["mensualidad"]);
                }
                

                aux = Convert.ToDouble(nm_meses.Value);

                lb_pagar.Text = Convert.ToString(mensualidad * aux);

                cn.Close();

            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
            cn.Close();
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_pago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_pago.Text != "")
                {
                    lb_cambio.Text = Convert.ToString((Convert.ToDouble(txt_pago.Text)) - (Convert.ToDouble(lb_pagar.Text)));
                }
                else
                {
                    lb_cambio.Text = "";
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txt_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from registro_pago", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_pagos.DataSource = dt;
                cn.Close();

                cbx_clientes.DataSource = conexiones.Cargarclientes();
                cbx_clientes.DisplayMember = "nombre";
                cbx_clientes.ValueMember = "nombre";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
