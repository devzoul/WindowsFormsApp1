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
        public FrmListarClientes()
        {
            InitializeComponent();
            dtg_Clientes.DataSource = TCliente.ListarCliente();


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

        }
    }
}
