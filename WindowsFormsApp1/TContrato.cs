using Microsoft.SqlServer.Server;
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
    public class TContrato
    {
        public TContrato() { }

        public Boolean ingresarContrato(Contrato contrato)
        {
            try
            {

                MySqlConnection conexion = Conexion.abrirURL();
                MySqlCommand orden = new MySqlCommand(string.Format("INSERT INTO CONTRATO (numeroContrato, creacion, termino, fechaHoraInicio, fechaHoraTermino, direccionCon, estaVigente, id_tipo, observaciones, asistentes, participantes, monto_total, rutCli  ) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}', '{8}', '{9}', '{10}', '{11}','{12}')",
                    contrato.numeroContrato, contrato.creacion, contrato.termino, contrato.fechaHoraInicio, contrato.fechaHoraTermino, contrato.direccionCon, contrato.estaVigente, contrato.idTipo, contrato.observaciones, contrato.asistentes, contrato.participantes, contrato.monto_total, contrato.rutCli), conexion);
                MySqlDataReader lector = orden.ExecuteReader();
                lector.Close();
                conexion.Close();
                return true;
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Problema con el Ingreso de Nuevo Contrato (SqlException) " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema con el Ingreso de Nuevo Contrato (Exception)" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Contrato buscarContrato(long numeroContrato)
        {

            Contrato contrato = new Contrato();
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM CONTRATO WHERE numeroContrato =@numeroContrato"), conexion);
            orden.Parameters.AddWithValue("@numeroContrato", numeroContrato);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                contrato.numeroContrato = lector.GetInt64(0);
                contrato.creacion = lector.GetString(1);
                contrato.termino = lector.GetString(2);
                contrato.fechaHoraInicio = lector.GetString(3);
                contrato.fechaHoraTermino = lector.GetString(4);
                contrato.direccionCon = lector.GetString(5);
                contrato.estaVigente = lector.GetString(6);
                contrato.idTipo = lector.GetInt32(7);
                contrato.observaciones = lector.GetString(8);
                contrato.asistentes = lector.GetInt32(9);
                contrato.participantes = lector.GetInt32(10);
                contrato.monto_total = lector.GetInt32(11);
                contrato.rutCli = lector.GetString(12);


            }
            lector.Close();
            conexion.Close();

            return contrato;
        }

        public static List<Contrato> ListarContrato()
        {
            List<Contrato> lista = new List<Contrato>();
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT contrato.numeroContrato, DATE_FORMAT(contrato.creacion, '%Y-%m-%d'), DATE_FORMAT(contrato.termino, '%Y-%m-%d'), DATE_FORMAT(contrato.fechaHoraInicio, '%H:%i'), DATE_FORMAT(contrato.fechaHoraTermino, '%H:%i'), contrato.direccionCon, contrato.estaVigente, contrato.id_tipo, contrato.observaciones, contrato.asistentes, contrato.participantes, contrato.monto_total, rutCli,TIPOEVENTO.NOMBRE FROM contrato join TIPOEVENTO ON TIPOEVENTO.id_tipo = contrato.id_tipo"), conexion);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {

                Contrato contrato = new Contrato();
                contrato.numeroContrato = lector.GetInt64(0);
                contrato.creacion = lector.GetString(1);
                contrato.termino = lector.GetString(2);
                contrato.fechaHoraInicio = lector.GetString(3);
                contrato.fechaHoraTermino = lector.GetString(4);
                contrato.direccionCon = lector.GetString(5);
                contrato.estaVigente = lector.GetString(6);
                contrato.idTipo = lector.GetInt32(7);
                contrato.observaciones = lector.GetString(8);
                contrato.asistentes = lector.GetInt32(9);
                contrato.participantes = lector.GetInt32(10);
                contrato.monto_total = lector.GetInt32(11);
                contrato.rutCli = lector.GetString(12);
                contrato.nombreTipo = lector.GetString(13);

                lista.Add(contrato);
            }
            lector.Close();
            conexion.Close();

            return lista;
        }

        public Boolean TerminoContrato(long numeroContrato)
        {   
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("UPDATE CONTRATO SET termino = CURDATE() ,estaVigente = ('No') WHERE numeroContrato =@numeroContrato"), conexion);
            orden.Parameters.AddWithValue("@numeroContrato", numeroContrato);
            MySqlDataReader lector = orden.ExecuteReader();
            lector.Close();
            conexion.Close();

            return true;
        }

    }
}
