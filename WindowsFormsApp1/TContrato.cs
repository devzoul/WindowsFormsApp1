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
                MySqlCommand orden = new MySqlCommand(string.Format("INSERT INTO CONTRATO (Numero, creacion, termino, fechaHoraInicio, fechaHoraTermino, Vigente, IdModalidad, IdTipoEvento, observaciones, asistentes, PersonalAdicional, valortotalcontrato, rutCliente  ) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}', '{8}', '{9}', '{10}', '{11}','{12}')",
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
                contrato.id_modalidad = lector.GetString(5);
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
                contrato.id_modalidad = lector.GetString(5);
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

        
        public int valorBase(String id_modalidad)
        {
            Contrato contrato = new Contrato();
            int valorBase =0;

            try
            {

                MySqlConnection conexion = Conexion.abrirURL();
                MySqlCommand orden = new MySqlCommand(string.Format("SELECT m.ValorBase from modalidadservicio m JOIN TIPOEVENTO TP ON M.IDTIPOEVENTO = TP.IDTIPOEVENTO WHERE idModalidad=@idModalidad"), conexion);
                orden.Parameters.AddWithValue("@idModalidad",id_modalidad);
                object result = orden.ExecuteScalar();
                valorBase = Convert.ToInt32(result);
                                
                conexion.Close();

                return valorBase;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema obtener Valor Base de Contrato " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
                                   
        }

        public int valorAsistente(int IdTipoEvento, int asistentes)
        {
            Contrato contrato = new Contrato();
            int valorAsistente = 0;

            try
            {

                MySqlConnection conexion = Conexion.abrirURL();
                MySqlCommand orden = new MySqlCommand(string.Format("select CASE WHEN IdTipoEvento = 30  THEN @asistentes * a.Recargo WHEN @asistentes > 50 then a.recargo * TRUNCATE(@asistentes / 20, 0) else a.Recargo end as Recargo from rango_asistentes a where @asistentes BETWEEN a.minasist and a.maxasist and IdTipoEvento = @IdTipoEvento"), conexion);
                orden.Parameters.AddWithValue("@IdTipoEvento", IdTipoEvento);
                orden.Parameters.AddWithValue("@asistentes", asistentes);
                object result = orden.ExecuteScalar();
                valorAsistente = Convert.ToInt32(result);

                conexion.Close();

                return valorAsistente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema obtener Valor Asistentes " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

        public int valorParticipante(int IdTipoEvento, int participantes)
        {
            Contrato contrato = new Contrato();
            int valorParticipantes = 0;

            try
            {

                MySqlConnection conexion = Conexion.abrirURL();
                MySqlCommand orden = new MySqlCommand(string.Format("select a.Recargo + a.rec_adic * (@participantes - (a.minper-1)) as recargo from rango_personal a where a.IdTipoEvento = @IdTipoEvento and @participantes BETWEEN a.minper and a.maxper"), conexion);
                orden.Parameters.AddWithValue("@IdTipoEvento", IdTipoEvento);
                orden.Parameters.AddWithValue("@participantes", participantes);
                object result = orden.ExecuteScalar();
                valorParticipantes = Convert.ToInt32(result);

                conexion.Close();

                return valorParticipantes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema obtener Valor  Participantes " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

    }
}
