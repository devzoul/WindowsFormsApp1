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
    }
}
