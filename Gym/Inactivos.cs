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
    public partial class Inactivos : Form
    {
        public Inactivos()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-0EN1J76;Initial Catalog=gym;Integrated Security=True");

        private void Inactivos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gymDataSet5.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.gymDataSet5.clientes);
            SqlCommand cmd = new SqlCommand("Select * from clientes where estado = 'Inactivo'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_clientesinactivos.DataSource = dt;
            cn.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Clientes WHERE estado = 'Inactivo' AND nombre LIKE('" + txt_busqueda.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dgv_clientesinactivos.DataSource = dt;

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
