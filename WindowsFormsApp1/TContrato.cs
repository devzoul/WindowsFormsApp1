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
    public class TContrato
    {
        public TContrato() { }

        public Boolean ingresarContrato(Contrato contrato)
        {
            try
            {

                MySqlConnection conexion = Conexion.abrirURL();
                MySqlCommand orden = new MySqlCommand(string.Format("INSERT INTO CONTRATO (numeroContrato, creacion, termino, fechaHoraInicio, fechaHoraTermino, estaVigente, id_modalidad, id_tipoevento, observaciones, asistentes, participantes, valortotalcontrato, rutCliente  ) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}', '{8}', '{9}', '{10}', '{11}','{12}')",
                    contrato.numeroContrato, contrato.creacion, contrato.termino, contrato.fechaHoraInicio, contrato.fechaHoraTermino, contrato.estaVigente, contrato.id_modalidad,contrato.id_tipoevento, contrato.observaciones, contrato.asistentes, contrato.participantes, contrato.valortotalcontrato, contrato.rutCliente), conexion);
                MySqlDataReader lector = orden.ExecuteReader();
                lector.Close();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema con el Ingreso de Nuevo Contrato" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                contrato.id_modalidad = lector.GetInt32(5);
                contrato.estaVigente = lector.GetString(6);
                contrato.id_tipoevento = lector.GetInt32(7);
                contrato.observaciones = lector.GetString(8);
                contrato.asistentes = lector.GetInt32(9);
                contrato.participantes = lector.GetInt32(10);
                contrato.valortotalcontrato = lector.GetInt32(11);
                contrato.rutCliente = lector.GetString(12);


            }
            lector.Close();
            conexion.Close();

            return contrato;
        }

        public  Boolean TieneContrato(String Rutcontrato)
        {
            Boolean contratoval;
            long cantContratos;
            cantContratos = 0;
            contratoval = false;
            Contrato contrato = new Contrato();
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT count(*) FROM CONTRATO WHERE rutCli =@Rutcontrato"), conexion);
            orden.Parameters.AddWithValue("@Rutcontrato", Rutcontrato);
            MySqlDataReader lector = orden.ExecuteReader();

            if (lector.Read())
            {
                cantContratos = lector.GetInt64(0);
               
            }


            if (cantContratos > 0)
            {
                contratoval = true;
            }

            return contratoval;
        }

        public static List<Contrato> ListarContrato()
        {
            List<Contrato> lista = new List<Contrato>();
            MySqlConnection conexion = Conexion.abrirURL();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT contrato.numeroContrato, DATE_FORMAT(contrato.creacion, '%Y-%m-%d'), DATE_FORMAT(contrato.termino, '%Y-%m-%d'), DATE_FORMAT(contrato.fechaHoraInicio, '%H:%i'), DATE_FORMAT(contrato.fechaHoraTermino, '%H:%i'), contrato.IdModalidad,contrato.Idtipoevento, contrato.estaVigente,  contrato.observaciones, contrato.asistentes, contrato.participantes, contrato.valortotalcontrato, contrato.rutCliente,TIPOEVENTO.Descripcion FROM contrato join TIPOEVENTO ON TIPOEVENTO.IdTipoEvento = contrato.IdTipoEvento"), conexion);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {

                Contrato contrato = new Contrato();
                contrato.numeroContrato = lector.GetInt64(0);
                contrato.creacion = lector.GetString(1);
                contrato.termino = lector.GetString(2);
                contrato.fechaHoraInicio = lector.GetString(3);
                contrato.fechaHoraTermino = lector.GetString(4);
                contrato.id_modalidad = lector.GetInt16(5);
                contrato.id_tipoevento = lector.GetInt16(6);
                contrato.estaVigente = lector.GetString(7);
                contrato.observaciones = lector.GetString(8);
                contrato.asistentes = lector.GetInt32(9);
                contrato.participantes = lector.GetInt32(10);
                contrato.valortotalcontrato = lector.GetInt32(11);
                contrato.rutCliente = lector.GetString(12);
                

                lista.Add(contrato);
            }
            lector.Close();
            conexion.Close();

            return lista;
        }

        public Boolean TerminoContrato(long numeroContrato)
        {   
            

            try
            {

                MySqlConnection conexion = Conexion.abrirURL();
                MySqlCommand orden = new MySqlCommand(string.Format("UPDATE CONTRATO SET termino = CURDATE() ,estaVigente = ('No') WHERE numeroContrato =@numeroContrato"), conexion);
                orden.Parameters.AddWithValue("@numeroContrato", numeroContrato);
                MySqlDataReader lector = orden.ExecuteReader();
                lector.Close();
                conexion.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al dar termino al contrato" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

    }
}
