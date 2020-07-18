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
            frmcliente.Visible=true;
            Visible = false;
        }

        private void btn_contratos_Click(object sender, EventArgs e)
        {
            FrmContrato frmcontrato = new FrmContrato();
            frmcontrato.Visible = true;
            Visible = false;
        }

        private void btn_ListarClientes_Click(object sender, EventArgs e)
        {
            FrmListarClientes frmListarClientes = new FrmListarClientes();
            frmListarClientes.Visible = true;
            frmListarClientes.btn_cancelar.Text = "Volver";
            Visible = false;
        }

        private void btn_ListarContratos_Click(object sender, EventArgs e)
        {
            FrmListarContratos frmListarContratos = new FrmListarContratos();
            frmListarContratos.Visible = true;
            frmListarContratos.btn_cancelarLc.Text = "Volver";
            Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult salir =  MessageBox.Show("Esta seguro que desea salir de la aplicacion?","Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
