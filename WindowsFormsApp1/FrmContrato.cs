using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmContrato : Form
    {
        public FrmContrato()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_rutCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp_horaIni_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_regContrato_Click(object sender, EventArgs e)
        {
            TContrato tcontraro = new TContrato();
            Contrato contrato = new Contrato();

            contrato.numeroContrato = (1);
            contrato.creacion = dtp_creacion.Value.ToString("yyyy-MM-dd HH:mm:ss");
            contrato.termino = dtp_termino.Value.ToString("yyyy-MM-dd HH:mm:ss");
            contrato.fechaHoraInicio = dtp_horaIni.Value;
            contrato.fechaHoraTermino = dtp_horaTerm.Value;
            contrato.direccionCon = txt_direccionContrato.Text;
            contrato.estaVigente = cbx_vigente.SelectedItem.ToString();
            contrato.observaciones = txt_observaciones.Text;
            contrato.rutCli = txt_rutCliente.Text;

            if (cbx_tipoContrato.SelectedItem.ToString() == "Matrimonio")
            {
                contrato.idTipo = 1;

            }
            else if (cbx_tipoContrato.SelectedItem.ToString() == "Bautizo")
            {
                contrato.idTipo = 2;
            }

            else if (cbx_tipoContrato.SelectedItem.ToString() == "Cumpleaños")
            {
                contrato.idTipo = 3;
            }

            else if (cbx_tipoContrato.SelectedItem.ToString() == "Aniversario")
            {
                contrato.idTipo = 4;
            }

            tcontraro.ingresarContrato(contrato);






        }
    }
}
