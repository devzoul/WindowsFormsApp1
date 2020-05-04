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
            LimpiarDatosAgree();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {

            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_busc_Click(object sender, EventArgs e)
        {
            if (txt_rutBusc.Text == (""))
            {
                MessageBox.Show("Campo de Busqueda vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                TCliente tcliente = new TCliente();
                Cliente cliente = new Cliente();
                cliente = tcliente.buscarCliente(txt_rutBusc.Text);

                txt_rutB.Text = cliente.rutCli;
                txt_razonSocialB.Text = cliente.razon_social;
                txt_nombreB.Text = cliente.nombreContactoCli;
                txt_mailB.Text = cliente.mailContacto;
                txt_direccionCB.Text = cliente.direccionCli;
                txt_telefonoB.Text = cliente.telefono.ToString();
                cbx_actividadB.SelectedItem = cliente.actividad;
                cbx_tipoB.SelectedItem = cliente.tipoCli;

                if (txt_rutB.Text == (""))
                {
                    MessageBox.Show("Registro no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarDatosBS();
                }
                else
                {
                    MessageBox.Show("Registro encontrado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }


        private void btn_del_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            TCliente tcliente = new TCliente();
            cliente.rutCli = txt_rutB.Text;
           
            if (tcliente.eliminarCliente(cliente))
            {
                MessageBox.Show("Eliminación realizada con exito", "Eliminacion de Dato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatosBS();
                
            }
            else
            {
                MessageBox.Show("Error al Eliminar Datos", "Eliminacion de Dato", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDatosBS()
        {
            txt_rutBusc.Text = ("");
            txt_rutB.Text = ("");
            txt_razonSocialB.Text = ("");
            txt_nombreB.Text = ("");
            txt_mailB.Text = ("");
            txt_direccionCB.Text = ("");
            txt_telefonoB.Text = ("");
            cbx_actividadB.ResetText();
            cbx_actividadB.SelectedIndex = -1;
            cbx_tipoB.ResetText();
            cbx_tipoB.SelectedIndex = -1;

            this.txt_rutBusc.Focus();


        }
        private void LimpiarDatosAgree()
        {
            txt_rut.Text = ("");
            txt_razonSocial.Text = ("");
            txt_nombre.Text= ("");
            txt_mail.Text= ("");
            txt_direccionCliente.Text = ("");
            txt_telefono.Text= ("");
            cbx_actividad.ResetText();
            cbx_tipoCliente.ResetText();

            this.txt_rut.Focus();


        }

        private void cbx_actividadB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            TCliente tcliente = new TCliente();

            cliente.rutCli = txt_rutB.Text;
            cliente.razon_social = txt_razonSocialB.Text;
            cliente.nombreContactoCli = txt_nombreB.Text;
            cliente.mailContacto = txt_mailB.Text;
            cliente.direccionCli = txt_direccionCB.Text;
            cliente.telefono = Int32.Parse(txt_telefonoB.Text);
            cliente.actividad = cbx_actividadB.Text;
            cliente.tipoCli = cbx_tipoB.Text;
            if (tcliente.modificarCliente(cliente))
            {
                LimpiarDatosBS();

            }

            

        }

        private void btn_listarb_Click(object sender, EventArgs e)
        {
            data_clientes.DataSource = TCliente.ListarCliente();
        }

        private void data_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_clientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_rutBusc.Text = data_clientes.Rows[e.RowIndex].Cells["rutCli"].FormattedValue.ToString();
            }

            
            
        }

        private void btn_listado_Click(object sender, EventArgs e)
        {
            using (FrmListarClientes FrmListarClientes = new FrmListarClientes())
            {
                if (FrmListarClientes.ShowDialog() == DialogResult.OK)
                {

                    txt_test1.Text = FrmListarClientes.SetValueForText1;

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    