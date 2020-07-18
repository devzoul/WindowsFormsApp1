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
            dt.Columns.Add("Tipo_Evento");
            dt.Columns.Add("Modalidad");
            dt.Columns.Add("Fecha Creacion");
            dt.Columns.Add("Fecha Termino");    
            dt.Columns.Add("Hora Inicio");
            dt.Columns.Add("Hora Termino");
            dt.Columns.Add("Está Vigente");
            dt.Columns.Add("Observaciones");
            dt.Columns.Add("Participantes");
            dt.Columns.Add("Asistentes");
            dt.Columns.Add("Valor Total");
            dt.Columns.Add("ID Modalidad");
            dt.Columns.Add("ID Tipo Evento");





            dv = new DataView(dt);
            fillDataTable(contratos);
            dtg_Contratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Contratos.DataSource = dv;

            dtg_Contratos.Columns["ID Tipo Evento"].Visible = false;
            dtg_Contratos.Columns["ID Modalidad"].Visible = false;

            dtg_Contratos.Columns["N°_Contrato"].ReadOnly = true;
            dtg_Contratos.Columns["Rut_Cliente"].ReadOnly = true;
            dtg_Contratos.Columns["Tipo_Evento"].ReadOnly = true;
            dtg_Contratos.Columns["Modalidad"].ReadOnly = true;
            dtg_Contratos.Columns["Fecha Creacion"].ReadOnly = true;
            dtg_Contratos.Columns["Fecha Termino"].ReadOnly = true;
            dtg_Contratos.Columns["Hora Inicio"].ReadOnly = true;
            dtg_Contratos.Columns["Hora Termino"].ReadOnly = true;
            dtg_Contratos.Columns["Está Vigente"].ReadOnly = true;
            dtg_Contratos.Columns["Observaciones"].ReadOnly = true;
            dtg_Contratos.Columns["Participantes"].ReadOnly = true;
            dtg_Contratos.Columns["Asistentes"].ReadOnly = true;
            dtg_Contratos.Columns["Valor Total"].ReadOnly = true;
            dtg_Contratos.Columns["ID Modalidad"].ReadOnly = true;
            dtg_Contratos.Columns["ID Tipo Evento"].ReadOnly = true;



        }
        private void fillDataTable(List<Contrato> contratos)
        {
            foreach (var contrato in contratos)
            {
                dt.Rows.Add(
                    contrato.numeroContrato,
                    contrato.rutCliente,
                    contrato.tipoevent_nombre,
                    contrato.modalidad_nombre,
                    contrato.creacion,
                    contrato.termino,
                    contrato.fechaHoraInicio,
                    contrato.fechaHoraTermino,
                    contrato.estaVigente,                   
                    contrato.observaciones,
                    contrato.participantes,
                    contrato.asistentes,
                    contrato.valortotalcontrato,
                    contrato.id_modalidad,
                    contrato.id_tipoevento
                    );
            }
        
        }

        private void btn_cancelarLc_Click(object sender, EventArgs e)
        {

            if (btn_cancelarLc.Text == "Volver")
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Visible = true;
                Visible = false;
            }
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
            dv.RowFilter = string.Format("Tipo_Evento Like '%{0}%'", txt_tipoCbusc.Text);
            dtg_Contratos.DataSource = dv;
        }

        
        private void dtg_Contratos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                txt_sContrato.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["N°_Contrato"].Value.ToString();
                txt_sRutC.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Rut_Cliente"].Value.ToString();
                txt_sTipoC.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["ID Tipo Evento"].Value.ToString();
                txt_sFechaCreacion.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Fecha Creacion"].Value.ToString();
                txt_sFechaTermino.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Fecha Termino"].Value.ToString();
                txt_sHoraIni.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Hora Inicio"].Value.ToString();
                txt_sHoraFin.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Hora Termino"].Value.ToString();
                //txt_sDireccionC.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                txt_sVigente.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Está Vigente"].Value.ToString();
                txt_sObservaciones.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Observaciones"].Value.ToString();
                txt_sParticipantes.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Participantes"].Value.ToString();
                txt_sAsistentes.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Asistentes"].Value.ToString();
                txt_sMontoTotal.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Valor Total"].Value.ToString();
                txt_sTipoModalidad.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["ID Modalidad"].Value.ToString();
                
                txt_sNomTipoE.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Tipo_Evento"].Value.ToString();
                txt_sNomModalidad.Text = this.dtg_Contratos.Rows[e.RowIndex].Cells["Modalidad"].Value.ToString();



            }
        }

        private void btn_listc_ok_Click(object sender, EventArgs e)
        {
            if (txt_sContrato.Text != "")
            {
                rContrato = new Contrato();
                rContrato.numeroContrato = Int64.Parse(txt_sContrato.Text);
                rContrato.rutCliente = txt_sRutC.Text;
                
                rContrato.creacion = txt_sFechaCreacion.Text;
                rContrato.termino = txt_sFechaTermino.Text;
                rContrato.fechaHoraInicio = txt_sHoraIni.Text;
                rContrato.fechaHoraTermino = txt_sHoraFin.Text;
                
                rContrato.estaVigente = txt_sVigente.Text;
                rContrato.observaciones = txt_sObservaciones.Text;
                rContrato.participantes = Int32.Parse(txt_sParticipantes.Text) ;
                rContrato.asistentes = Int32.Parse(txt_sAsistentes.Text);
                rContrato.valortotalcontrato = Int32.Parse(txt_sMontoTotal.Text);
                rContrato.id_modalidad = txt_sTipoModalidad.Text;
                rContrato.id_tipoevento =  Int32.Parse(txt_sTipoC.Text);
                rContrato.tipoevent_nombre = txt_sNomTipoE.Text;
                rContrato.modalidad_nombre = txt_sNomModalidad.Text;


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
