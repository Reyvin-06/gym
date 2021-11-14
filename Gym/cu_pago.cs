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

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C3FL76N;Initial Catalog=gym;Integrated Security=True");

        private void bn_confirmar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Bton_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmc = cn.CreateCommand();

                cmc.CommandType = CommandType.Text;
                cmc.CommandText = "INSERT INTO  registro_pago(nombre_cliente,descripcion,cantidad,fecha,fecha_renovacion) VALUES ('" +
                txt_nombrecliente.Text + "','" + nm_meses.Value + "','" + txt_pagar.Text + "'"+ ",GETDATE()" + ",GETDATE()"+")";

                int filasafectadas = cmc.ExecuteNonQuery();

                if (filasafectadas > 0)
                {
                    MessageBox.Show("se agrego");
                    txt_nombrecliente.Text = "";
                    nm_meses.Value =0;
                    txt_pagar.Text = "";
                    txt_pago.Text = "";
                    txt_cambio.Text = "";
                }
                else
                {
                    MessageBox.Show("no se agrego");
                }

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM registro_pago";
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

        private void txt_nombrecliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pagar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
