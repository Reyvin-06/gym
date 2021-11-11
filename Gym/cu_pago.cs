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

        private void bn_confirmar_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
