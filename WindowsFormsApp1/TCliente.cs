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
                MySqlCommand orden = new MySqlCommand(string.Format("INSERT INTO CLIENTE (rutcliente, razonsocial, nombrecontacto, mailContacto, direccion, telefono, IdActividadEmpresa , IdTipoEmpresa) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    cliente.rutCli, cliente.razon_social, cliente.nombreContactoCli, cliente.mailContacto, cliente.direccionCli, cliente.telefono, cliente.actividad, cliente.tipoCli), conexion);
                MySqlDataReader lector = orden.ExecuteReader();
                lector.Close();
                conexion.Close();
                return true;

            }
            
            catch (Exception e)
            {
                MessageBox.Show("Problema con el Ingreso de Nuevo Cliente " +e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public Cliente buscarCliente(String rutCli)
        {

            Cliente cliente = new Cliente();
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM CLIENTE WHERE RutCliente =@rutCli"), conexion);
            orden.Parameters.AddWithValue("@rutCli", rutCli);
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

        public Boolean eliminarCliente(Cliente cliente)
        {
            try
            {
                MySqlConnection conexion = Conexion.abrirURL();
                MySqlCommand orden = new MySqlCommand(string.Format("DELETE FROM CLIENTE WHERE RutCliente ='{0}'", cliente.rutCli), conexion);
                MySqlDataReader lector = orden.ExecuteReader();
                lector.Close();
                conexion.Close();
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Problema al Eliminar Cliente "+e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




        }

        public static List<Cliente> ListarCliente()
        {
            List<Cliente> lista = new List<Cliente>();
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format(
                "SELECT CLIENTE.*, A.DESCRIPCION, T.DESCRIPCION FROM CLIENTE JOIN ACTIVIDADEMPRESA A ON A.IDACTIVIDADEMPRESA = CLIENTE.IDACTIVIDADEMPRESA JOIN TIPOEMPRESA T ON T.IDTIPOEMPRESA = CLIENTE.IDTIPOEMPRESA"), conexion);
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
                cliente.nom_actividad = lector.GetString(8);
                cliente.nom_tipo = lector.GetString(9);

                lista.Add(cliente);
            }

            return lista;
        }

        public Boolean modificarCliente(Cliente cliente)
        {
            try
            {
                MySqlConnection conexion = Conexion.abrirURL();
                MySqlCommand orden = new MySqlCommand(string.Format("UPDATE CLIENTE SET RazonSocial='{0}', NombreContacto= '{1}', mailContacto='{2}', Direccion='{3}',  telefono='{4}', IdActividadEmpresa ='{5}' , IdTipoEmpresa ='{6}'WHERE RutCliente  ='{7}'",
                cliente.razon_social, cliente.nombreContactoCli, cliente.mailContacto, cliente.direccionCli, cliente.telefono, cliente.actividad, cliente.tipoCli, cliente.rutCli), conexion);
                MySqlDataReader lector = orden.ExecuteReader();
                lector.Close();
                conexion.Close();
                MessageBox.Show("Modificacion realizada con exito", "Edicion de Datos de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return true;


            }
            
            catch (Exception e)
            {
                MessageBox.Show("Problema al Modificar Cliente "+e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
