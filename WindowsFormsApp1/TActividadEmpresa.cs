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
    public class TActividadEmpresa
    {
        public TActividadEmpresa() { }

        
        public static List<ActividadEmpresa> ListarTipoActividadEmpresa()
        {
            List<ActividadEmpresa> lista = new List<ActividadEmpresa>();
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM actividadempresa order by IdActividadEmpresa  asc"), conexion);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                ActividadEmpresa actividadEmpresa = new ActividadEmpresa();
                actividadEmpresa.IdActividadEmpresa = lector.GetInt32(0);
                actividadEmpresa.Descripcion = lector.GetString(1);


                lista.Add(actividadEmpresa);
            }

            return lista;
        }
    }
}
