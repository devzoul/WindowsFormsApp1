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
    public class TUsuario
    {
        public TUsuario() { }
        public Usuario valLogin(string Tusuario, string Tcontraseña)
        {

            Usuario usuario = new Usuario();
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM usuario WHERE usuario =@Tusuario"), conexion);
            orden.Parameters.AddWithValue("@Tusuario", Tusuario);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                usuario.idUsuario = lector.GetInt32(0);
                usuario.usuario = lector.GetString(1);
                usuario.contraseña = lector.GetString(2);

            }
            return usuario;
        }


    }
}
