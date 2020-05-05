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

            
            contrato.creacion = dtp_creacion.Value.ToString("yyyy-MM-dd HH:mm:ss");
            contrato.termino = dtp_termino.Value.ToString("yyyy-MM-dd HH:mm:ss");
            contrato.fechaHoraInicio = dtp_horaIni.Value.ToString("yyyy-MM-dd HH:mm:ss");
            contrato.fechaHoraTermino = dtp_horaTerm.Value.ToString("yyyy-MM-dd HH:mm:ss");
            contrato.direccionCon = txt_direccionContrato.Text;
            contrato.estaVigente = cbx_vigente.SelectedItem.ToString();
            contrato.observaciones = txt_observaciones.Text;
            contrato.rutCli = txt_rutCliente.Text;
            String numeroid = (dtp_creacion.Value.ToString("yyyyMMdd") + dtp_horaIni.Value.ToString("HHmm"));
            contrato.numeroContrato = Int64.Parse(numeroid);

            

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

            
            if (tcontraro.ingresarContrato(contrato))
            {
                MessageBox.Show("Contrato ingresado con exito", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiardatosCt();
            }

        }

        private void LimpiardatosCt()
        {
            txt_rutCliente.Text = ("");
            txt_razonCliente.Text = ("");
            txt_direccionContrato.Text = ("");
            cbx_vigente.ResetText();
            cbx_vigente.SelectedIndex = -1;
            cbx_tipoContrato.ResetText();
            cbx_vigente.SelectedIndex = -1;
            txt_observaciones.Text = ("");
            txt_monto.Text = ("");

        }



        private void btn_buscarCC_Click(object sender, EventArgs e)
        {
            if (txt_rutCliente.Text == (""))
            {
                MessageBox.Show("Campo de Busqueda vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                TCliente tcliente = new TCliente();
                Cliente cliente = new Cliente();
                cliente = tcliente.buscarCliente(txt_rutCliente.Text);

                txt_rutCliente.Text = cliente.rutCli;
                txt_razonCliente.Text = cliente.razon_social;
                

                if (txt_razonCliente.Text == (""))
                {
                    MessageBox.Show("Registro no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_rutCliente.Text = ("");
                }
                else
                {
                    MessageBox.Show("Registro encontrado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TContrato tcontrato = new TContrato();
            Contrato contrato = new Contrato();



            contrato = tcontrato.buscarContrato(long.Parse(txt_buscacon.Text));


            txt_buscarut.Text = contrato.rutCli;
            
            dtp_buscacreacion.Value = DateTime.Parse(contrato.creacion);
            dtp_buscatermino.Value = DateTime.Parse(contrato.termino);
            dtp_buscahoraini.Value = DateTime.Parse(contrato.fechaHoraInicio);
            dtp_buscahorafin.Value = DateTime.Parse(contrato.fechaHoraTermino);
            txt_buscadir.Text = contrato.direccionCon;
            cbx_buscavig.Text=contrato.estaVigente;
            txt_buscaobs.Text = contrato.observaciones;


            if (contrato.idTipo ==1)
            {
                cbx_buscatipo.Text = "Matrimonio";
            }
            else if (contrato.idTipo == 2)
            {
                cbx_buscatipo.Text = "Bautizo";
            }
            else if (contrato.idTipo == 3)
            {
                cbx_buscatipo.Text = "Cumpleaños";
            }
            else if (contrato.idTipo == 4)
            {
                cbx_buscatipo.Text = "Aniversario";
            }

            TCliente tcliente = new TCliente();
            Cliente cliente = new Cliente();

            cliente = tcliente.buscarCliente(contrato.rutCli);

            txt_buscarz.Text = cliente.nombreContactoCli;




        }

        private void btn_limpiarCC_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiarC_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea Limpiar los Datos", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                txt_buscarut.Text = ("");
                txt_buscarz.Text = ("");
                txt_buscadir.Text = ("");
                cbx_buscavig.ResetText();
                cbx_buscavig.SelectedIndex = -1;
                cbx_buscatipo.ResetText();
                cbx_buscatipo.SelectedIndex = -1;
                txt_buscaobs.Text = ("");
                txt_buscacon.Text = ("");
                

            }
        }

        private void btn_buscListCon_Click(object sender, EventArgs e)
        {
            using (FrmListarContratos frmListarContratos = new FrmListarContratos())
            {
                if (frmListarContratos.ShowDialog() == DialogResult.OK)
                {

                    txt_numeroContrato.Text = frmListarContratos.rContrato.numeroContrato.ToString();
                    txt_buscarut.Text = frmListarContratos.rContrato.rutCli;
                    dtp_buscacreacion.Value = DateTime.Parse(frmListarContratos.rContrato.creacion);
                    dtp_buscatermino.Value = DateTime.Parse(frmListarContratos.rContrato.termino);
                    dtp_buscahoraini.Value = DateTime.Parse(frmListarContratos.rContrato.fechaHoraInicio);
                    dtp_buscahorafin.Value = DateTime.Parse(frmListarContratos.rContrato.fechaHoraTermino);
                    txt_buscadir.Text = frmListarContratos.rContrato.direccionCon;
                    cbx_buscavig.SelectedItem = frmListarContratos.rContrato.estaVigente;
                    cbx_buscatipo.SelectedItem = frmListarContratos.rContrato.nombreTipo;
                    txt_buscaobs.Text = frmListarContratos.rContrato.observaciones;

                    TCliente tcliente = new TCliente();
                    Cliente cliente = new Cliente();

                    cliente = tcliente.buscarCliente(txt_buscarut.Text);
                    txt_buscarz.Text = cliente.nombreContactoCli;

                }
            }
        }
    }
}
