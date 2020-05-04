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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmCliente frmcliente = new FrmCliente();
            frmcliente.Show();
        }

        private void btn_contratos_Click(object sender, EventArgs e)
        {
            FrmContrato frmcontrato = new FrmContrato();
            frmcontrato.Show();
        }

        private void btn_ListarClientes_Click(object sender, EventArgs e)
        {
            FrmListarClientes frmListarClientes = new FrmListarClientes();
            frmListarClientes.Show();
        }
    }
}
