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
    public partial class Clientes : UserControl
    {
        public Clientes()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-0EN1J76;Initial Catalog=gym;Integrated Security=True");
        //Data Source=DESKTOP-0EN1J76;Initial Catalog=gym;Integrated Security=True


        private void Clientes_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from clientes where estado = 'Activo'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_clientes.DataSource = dt;
            cn.Close();

            int clientes =  dgv_clientes.RowCount;
            lb_personasregistradas.Text = clientes.ToString();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmc = cn.CreateCommand();


                cmc.CommandType = CommandType.Text;
                cmc.CommandText = "INSERT INTO clientes(nombre,edad,celular,correo,estado) VALUES ('" + txtnombre.Text + "','" + txtedad.Text + "','" + txtcelular.Text + "','" + txtcorreo.Text + "','" + "Activo" + "')";

                int filasafectadas = cmc.ExecuteNonQuery();

                if (filasafectadas > 0)
                {
                    MessageBox.Show("se agrego");
                    txtcorreo.Text = "";
                    txtnombre.Text = "";
                    txtedad.Text = "";
                    txtcelular.Text = "";
                }
                else
                {
                    MessageBox.Show("no se agrego");
                }

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from clientes where estado = 'Activo'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dgv_clientes.DataSource = dt;

                cn.Close();

                int clientes = dgv_clientes.RowCount;
                lb_personasregistradas.Text = clientes.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_inactivos_Click(object sender, EventArgs e)
        {
            Inactivos inactivos = new Inactivos();
            inactivos.Show();
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Clientes WHERE estado = 'Activo' AND nombre LIKE('" + txt_busqueda.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dgv_clientes.DataSource = dt;

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lb_personasregistradas_Click(object sender, EventArgs e)
        {
            
        }
    }
}
