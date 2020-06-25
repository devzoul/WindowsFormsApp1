
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    class Conexion
    {
        public static MySqlConnection abrirURL()
        {
            MySqlConnection conector = new MySqlConnection("server = localhost; database = onbreak; Uid = root; pwd= ");
            conector.Open();
            return conector;

        }
    }
}
