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
    public partial class FrmListarContratos : Form
    {
        private DataTable dt;
        private List<Contrato> contratos;
        private DataView dv;
        public Contrato rContrato;
        public FrmListarContratos()
        {
            InitializeComponent();
            contratos = TContrato.ListarContrato();
            dt = new DataTable();            
            dt.Columns.Add("N°_Contrato");
            dt.Columns.Add("Rut_Cliente");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Fecha Creacion");
            dt.Columns.Add("Fecha Termino");    
            dt.Columns.Add("Hora Inicio");
            dt.Columns.Add("Hora Termino");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Está Vigente");
            dt.Columns.Add("Observaciones");

           




            dv = new DataView(dt);
            fillDataTable(contratos);
            dtg_Contratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Contratos.DataSource = dv;
           
            


        }        
        private void fillDataTable(List<Contrato> contratos)
        {
            foreach (var contrato in contratos)
            {
                dt.Rows.Add(
                    contrato.numeroContrato,
                    contrato.rutCli,
                    contrato.nombreTipo,
                    contrato.creacion,
                    contrato.termino,
                    contrato.fechaHoraInicio,
                    contrato.fechaHoraTermino,
                    contrato.direccionCon,
                    contrato.estaVigente,                   
                    contrato.observaciones
                    );
            }
        
        }

        private void btn_cancelarLc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_Contratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_contratoBusc_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("N°_Contrato Like '%{0}%'", txt_contratoBusc.Text);
            dtg_Contratos.DataSource = dv;

        }

        private void txt_rutCbusc_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Rut_Cliente Like '%{0}%'", txt_rutCbusc.Text);
            dtg_Contratos.DataSource = dv;
        }

        private void txt_tipoCbusc_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Tipo Like '%{0}%'", txt_tipoCbusc.Text);
            dtg_Contratos.DataSource = dv;
        }

        
        private void dtg_Contratos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                txt_sContrato.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["N°_Contrato"].Value.ToString();
                txt_sRutC.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Rut_Cliente"].Value.ToString();
                txt_sTipoC.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
                txt_sFechaCreacion.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Fecha Creacion"].Value.ToString();
                txt_sFechaTermino.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Fecha Termino"].Value.ToString();
                txt_sHoraIni.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Hora Inicio"].Value.ToString();
                txt_sHoraFin.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Hora Termino"].Value.ToString();
                txt_sDireccionC.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                txt_sVigente.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Está Vigente"].Value.ToString();
                txt_sObservaciones.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Observaciones"].Value.ToString();

                

            }
        }

        private void btn_listc_ok_Click(object sender, EventArgs e)
        {
            if (txt_sContrato.Text != "")
            {
                rContrato = new Contrato();
                rContrato.numeroContrato = Int64.Parse(txt_sContrato.Text);
                rContrato.rutCli = txt_sRutC.Text;
                rContrato.nombreTipo = txt_sTipoC.Text;
                rContrato.creacion = txt_sFechaCreacion.Text;
                rContrato.termino = txt_sFechaTermino.Text;
                rContrato.fechaHoraInicio = txt_sHoraIni.Text;
                rContrato.fechaHoraTermino = txt_sHoraFin.Text;
                rContrato.direccionCon = txt_sDireccionC.Text;
                rContrato.estaVigente = txt_sVigente.Text;
                rContrato.observaciones = txt_sObservaciones.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
