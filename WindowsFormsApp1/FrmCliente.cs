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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_actividad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            TCliente tcliente = new TCliente();


            cliente.rutCli = txt_rut.Text;
            cliente.razon_social = txt_razonSocial.Text;
            cliente.nombreContactoCli = txt_nombre.Text;
            cliente.mailContacto = txt_mail.Text;
            cliente.direccionCli = txt_direccionCliente.Text;
            cliente.telefono = Int32.Parse(txt_telefono.Text);
            cliente.actividad = cbx_actividad.SelectedItem.ToString();
            cliente.tipoCli = cbx_tipoCliente.SelectedItem.ToString();
            tcliente.ingresarCliente(cliente);
            MessageBox.Show("Cliente ingresado con exito", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            Boolean existe;
            existe = true;
            if (existe)
            {
                txt_rut.Enabled = false;
                txt_nombre.Enabled = true;
                txt_direccionCliente.Enabled = true;
                txt_mail.Enabled = true;
                txt_razonSocial.Enabled = true;
                txt_telefono.Enabled = true;
                cbx_actividad.Enabled = true;
                cbx_tipoCliente.Enabled = true;
                btn_regCliente.Enabled = true;
            }
            else
            {
                txt_rut.Enabled = true;
                txt_nombre.Enabled = false;
                txt_direccionCliente.Enabled = false;
                txt_mail.Enabled = false;
                txt_razonSocial.Enabled = false;
                txt_telefono.Enabled = false;
                cbx_actividad.Enabled = false;
                cbx_tipoCliente.Enabled = false;
                btn_regCliente.Enabled = false;
            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
