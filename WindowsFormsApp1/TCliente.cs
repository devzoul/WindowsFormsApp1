using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class TCliente
    {
        public TCliente() { }

        public Boolean ingresarCliente(Cliente cliente)
        {
            try
            {
                MySqlConnection conexion = Conexion.abrirURL();
                MySqlCommand orden = new MySqlCommand(string.Format("INSERT INTO CLIENTE (rutCli, razon_social, nombreContactoCli, mailContacto, direccionCli, telefono, actividad, tipoCli  ) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}')",
                    cliente.rutCli, cliente.razon_social, cliente.nombreContactoCli, cliente.mailContacto, cliente.direccionCli, cliente.telefono, cliente.actividad, cliente.tipoCli), conexion);
                MySqlDataReader lector = orden.ExecuteReader();
                lector.Close();
                conexion.Close();
                return true;

            }
            catch (SqlException e)
            {

                MessageBox.Show("Problema con el Ingreso de Nuevo Cliente (SqlException) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            catch (Exception e)
            {
                MessageBox.Show("Problema con el Ingreso de Nuevo Cliente (Exception)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
