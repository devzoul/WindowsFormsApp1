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
                MySqlCommand orden = new MySqlCommand(string.Format("INSERT INTO CONTRATO (numeroContrato, creacion, termino, fechaHoraInicio, fechaHoraTermino, direccionCon, estaVigente, id_tipo, observaciones, rutCli  ) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}', '{8}','{9}')",
                    contrato.numeroContrato, contrato.creacion, contrato.termino, contrato.fechaHoraInicio, contrato.fechaHoraTermino, contrato.direccionCon, contrato.estaVigente, contrato.idTipo, contrato.observaciones, contrato.rutCli), conexion);
                MySqlDataReader lector = orden.ExecuteReader();
                lector.Close();
                conexion.Close();
                return true;
            }
            catch (SqlException)
            {

                MessageBox.Show("Problema con el Ingreso de Nuevo Cliente (SqlException) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            catch (Exception )
            {
                MessageBox.Show("Problema con el Ingreso de Nuevo Cliente (Exception)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



    }
}
