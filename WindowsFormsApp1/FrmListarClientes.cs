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
        public FrmListarClientes()
        {
            InitializeComponent();
            clientes = TCliente.ListarCliente();
            dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Rut");
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
                dt.Rows.Add(cliente.nombreContactoCli, cliente.rutCli,cliente.actividad,cliente.tipoCli,cliente.razon_social,cliente.mailContacto,cliente.direccionCli,cliente.telefono);
            }
        }
        public string SetValueForText1 { get; set; }
        //public static string SetValueForText1 = "";

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = txt_test.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Clientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_test.Text = dtg_Clientes.Rows[e.RowIndex].Cells["rutCli"].FormattedValue.ToString();
                txt_test3.Text= dtg_Clientes.Rows[e.RowIndex].Cells["razon_social"].FormattedValue.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Rut Like '%{0}%'", txt_test.Text);
            dtg_Clientes.DataSource = dv;
        }
    }
}
