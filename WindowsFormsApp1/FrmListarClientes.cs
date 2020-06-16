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
    public partial class FrmListarClientes : Form
    {
        private DataTable dt;
        private List<Cliente> clientes;
        private DataView dv;
        public Cliente rCliente;
        public FrmListarClientes()
        {
            InitializeComponent();
            clientes = TCliente.ListarCliente();
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
            fillDataTable(clientes);
            dtg_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Clientes.DataSource = dv;
           
            


        }        
        private void fillDataTable(List<Cliente> clientes)
        {
            foreach (var cliente in clientes)
            {
                dt.Rows.Add(cliente.rutCli, cliente.nombreContactoCli, cliente.actividad,cliente.tipoCli,cliente.razon_social,cliente.mailContacto,cliente.direccionCli,cliente.telefono);
            }
        }
        public string SetValueForText1 { get; set; }
        //public static string SetValueForText1 = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_sRut.Text != "")
            {
                rCliente = new Cliente();
                rCliente.nombreContactoCli = txt_sNombre.Text;
                rCliente.mailContacto = txt_sMail.Text;
                rCliente.razon_social = txt_sRazon.Text;
                rCliente.rutCli = txt_sRut.Text;
                rCliente.telefono = Int32.Parse(txt_sTelefono.Text);
                rCliente.tipoCli = txt_sTipo.Text;
                rCliente.actividad = txt_sActividad.Text;
                rCliente.direccionCli = txt_sDireccion.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Visible = true;
            Visible = false;
        }

        private void dtg_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dtg_Clientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            /*if (e.RowIndex !=-1)
            {
                
                txt_sRut.Text = this.dtg_Clientes.Rows[e.RowIndex].Cells["Rut"].Value.ToString();                
                txt_sRazon.Text= this.dtg_Clientes.Rows[e.RowIndex].Cells["Razon Social"].Value.ToString();
                txt_sActividad.Text = this.dtg_Clientes.Rows[e.RowIndex].Cells["Actividad"].Value.ToString();
                txt_sTipo.Text = dtg_Clientes.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
                txt_sMail.Text = dtg_Clientes.Rows[e.RowIndex].Cells["Mail"].Value.ToString();
                txt_sDireccion.Text = dtg_Clientes.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                txt_sTelefono.Text = dtg_Clientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txt_sNombre.Text = dtg_Clientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            }*/
        }

        private void txtRutbusc_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Rut Like '%{0}%'", txtRutbusc.Text);
            dtg_Clientes.DataSource = dv;
        }

        private void txtActividadbusc_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Actividad Like '%{0}%'", txtActividadbusc.Text);
            dtg_Clientes.DataSource = dv;
        }

        private void txtTipobusc_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Tipo Like '%{0}%'", txtTipobusc.Text);
            dtg_Clientes.DataSource = dv;
        }

        private void dtg_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                txt_sRut.Text = this.dtg_Clientes.Rows[e.RowIndex].Cells["Rut"].Value.ToString();
                txt_sRazon.Text = this.dtg_Clientes.Rows[e.RowIndex].Cells["Razon Social"].Value.ToString();
                txt_sActividad.Text = this.dtg_Clientes.Rows[e.RowIndex].Cells["Actividad"].Value.ToString();
                txt_sTipo.Text = this.dtg_Clientes.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
                txt_sMail.Text = this.dtg_Clientes.Rows[e.RowIndex].Cells["Mail"].Value.ToString();
                txt_sDireccion.Text = this.dtg_Clientes.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                txt_sTelefono.Text = this.dtg_Clientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txt_sNombre.Text = this.dtg_Clientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            }
        }
    }
}
