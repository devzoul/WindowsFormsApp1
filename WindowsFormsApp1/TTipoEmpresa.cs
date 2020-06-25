using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class TTipoEmpresa
    {
        public TTipoEmpresa() { }

        public TipoEmpresa llenarCombo()
        {

            TipoEmpresa tipoEmpresa = new TipoEmpresa();
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM TIPOEMPRESA order by IdTipoEmpresa asc"), conexion);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                tipoEmpresa.idTipoEmpresa = lector.GetInt32(0);
                tipoEmpresa.Descripcion = lector.GetString(1);

            }
            return tipoEmpresa;
        }
        public static List<TipoEmpresa> ListarTipoEmpresa()
        {
            List<TipoEmpresa> lista = new List<TipoEmpresa>();
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM TIPOEMPRESA order by IdTipoEmpresa asc"), conexion);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                TipoEmpresa tipoEmpresa = new TipoEmpresa();
                tipoEmpresa.idTipoEmpresa = lector.GetInt32(0);
                tipoEmpresa.Descripcion = lector.GetString(1);
                

                lista.Add(tipoEmpresa);
            }

            return lista;
        }
    }
}
