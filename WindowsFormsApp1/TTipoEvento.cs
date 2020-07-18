using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TTipoEvento

    {

        public TTipoEvento() { }

        public TipoEvento buscarTipoEvento(int idTipo)
        {

            TipoEvento tipoEvento = new TipoEvento();
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM TIPOEVENTO WHERE idtipoevento =@idTipo"), conexion);
            orden.Parameters.AddWithValue("@idTipo", idTipo);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                tipoEvento.idTipo = lector.GetInt32(0);
                tipoEvento.nombreTipo = lector.GetString(1);
                                

            }
            return tipoEvento;
        }
    }
}