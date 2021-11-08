using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gym
{
    class Conexiones
    {
        public SqlConnection Cn (){
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-0EN1J76;Initial Catalog=gym;Integrated Security=True");
        return cn;
        }

        //prueba para el commit
        //Hola Camacho
    }
        
}
