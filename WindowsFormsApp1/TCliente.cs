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

        public Cliente buscarCliente(String rutCli)
        {

            Cliente cliente = new Cliente();
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM CABANA WHERE CODIGO =@codigo"), conexion);
            orden.Parameters.AddWithValue("@codigo", rutCli);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                cliente.rutCli = lector.GetString(0);
                cliente.razon_social = lector.GetString(1);
                cliente.nombreContactoCli = lector.GetString(2);
                cliente.mailContacto = lector.GetString(3);
                cliente.direccionCli = lector.GetString(4);
                cliente.telefono = lector.GetInt32(5);
                cliente.actividad = lector.GetString(6);
                cliente.tipoCli = lector.GetString(7);
            }
            return cliente;
        }

        public int eliminarCliente(Cliente cliente)
        {
            int resp = 0;
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("DELETE FROM CLIENTE WHERE CODIGO ='{0}'", cliente.rutCli), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();


            return resp;
        }

        public static List<Cliente> ListarCliente()
        {
            List<Cliente> lista = new List<Cliente>();
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM CLIENTE"), conexion);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Cliente cliente = new Cliente();
                cliente.rutCli = lector.GetString(0);
                cliente.razon_social = lector.GetString(1);
                cliente.nombreContactoCli = lector.GetString(2);
                cliente.mailContacto = lector.GetString(3);
                cliente.direccionCli = lector.GetString(4);
                cliente.telefono = lector.GetInt32(5);
                cliente.actividad = lector.GetString(6);
                cliente.tipoCli = lector.GetString(7);
                lista.Add(cliente);
            }

            return lista;
        }
    }
}
