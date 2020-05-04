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
            dt.Columns.Add("Rut");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Actividad");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Razon Social");    
            dt.Columns.Add("Mail");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Telefono");
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
                    contrato.idTipo,
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
    }
}
