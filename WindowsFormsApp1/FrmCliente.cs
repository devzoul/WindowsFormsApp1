using Google.Protobuf.WellKnownTypes;
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
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public class ComboboxItem2
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public FrmCliente()
        {
            InitializeComponent();
            cargarCombo();
        }


        private void cargarCombo()
        {
            List<TipoEmpresa> tipoEmpresa;
            tipoEmpresa = TTipoEmpresa.ListarTipoEmpresa();
            
            foreach (var tipoEmpresas in tipoEmpresa)
             {
               // cbx_tipoCliente.DisplayMember = tipoEmpresas.Descripcion;
               // cbx_tipoCliente.ValueMember = tipoEmpresas.idTipoEmpresa.ToString();

                //cbx_tipoCliente.Items.Add(new { Text = tipoEmpresas.Descripcion, Value = tipoEmpresas.idTipoEmpresa });

                ComboboxItem itemEmpresa = new ComboboxItem();
                itemEmpresa.Text = tipoEmpresas.Descripcion;
                itemEmpresa.Value = tipoEmpresas.idTipoEmpresa;
                cbx_tipoCliente.Items.Add(itemEmpresa);
                cbx_tipoB.Items.Add(itemEmpresa);
            }
            cbx_tipoCliente.SelectedIndex = -1;
            cbx_tipoB.SelectedIndex = -1;

            List<ActividadEmpresa> actividadEmpresa;
            actividadEmpresa = TActividadEmpresa.ListarTipoActividadEmpresa();

            foreach (var actividadEmpresas in actividadEmpresa)
            {
                ComboboxItem2 itemActividad = new ComboboxItem2();
                itemActividad.Text = actividadEmpresas.Descripcion;
                itemActividad.Value = actividadEmpresas.IdActividadEmpresa;
                cbx_actividad.Items.Add(itemActividad);
                cbx_actividadB.Items.Add(itemActividad);
            }
            cbx_actividad.SelectedIndex = -1;
            cbx_actividadB.SelectedIndex = -1;




        }
        private void ActDes(Boolean estado)
        {
            txt_rut.Enabled = !estado;
            txt_razonSocial.Enabled = estado;
            txt_nombre.Enabled = estado;
            txt_mail.Enabled = estado;
            txt_direccionCliente.Enabled = estado;
            txt_telefono.Enabled = estado;
            cbx_actividad.Enabled = estado;
            cbx_tipoCliente.Enabled = estado;
            btn_regCliente.Enabled = estado;
            btn_limpiarDatos.Enabled = estado;
            btn_validar.Enabled = !estado;


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

            if (txt_rut.Text.Length ==0 || txt_nombre.Text.Length == 0 || txt_razonSocial.Text.Length ==0 ||txt_mail.Text.Length ==0||txt_direccionCliente.Text.Length==0|| txt_telefono.Text.Length==0||cbx_actividad.SelectedIndex==-1||cbx_tipoCliente.SelectedIndex==-1)
            {
                MessageBox.Show("No deben existir campos vacios","Error",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                Cliente cliente = new Cliente();
                TCliente tcliente = new TCliente();
                

                cliente.rutCli = txt_rut.Text;
                cliente.razon_social = txt_razonSocial.Text;
                cliente.nombreContactoCli = txt_nombre.Text;
                cliente.mailContacto = txt_mail.Text;
                cliente.direccionCli = txt_direccionCliente.Text;
                cliente.telefono = Int32.Parse(txt_telefono.Text);
                cliente.tipoCli = (cbx_tipoCliente.SelectedItem as ComboboxItem).Value.ToString();
                cliente.actividad = (cbx_actividad.SelectedItem as ComboboxItem2).Value.ToString();               
                
                if (tcliente.ingresarCliente(cliente))
                {
                    MessageBox.Show("Cliente ingresado con exito", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatosAgree();
                }
                
            }
            
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            TCliente tcliente = new TCliente();
            Cliente cliente = new Cliente();
            cliente = tcliente.buscarCliente(txt_rut.Text);

            if (txt_rut.Text !="")
            {
                if (txt_rut.Text != cliente.rutCli)
                {
                    MessageBox.Show("Cliente nuevo!, rellena los datos para el ingreso", "Cliente Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActDes(true);
                }
                else { MessageBox.Show("Cliente ya existe en nuestros registro, intenta con otro Rut", "Cliente Ya Existe", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Campo cliente vacío, Ingresa un cliente para Validar", "Campo cliente Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            
            
            

            


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

                foreach (ComboboxItem2 CmbItem in cbx_actividadB.Items)
                {
                    var tempMeasured = CmbItem.Value.ToString();
                    if (tempMeasured == cliente.actividad)
                    {
                        cbx_actividadB.SelectedIndex = cbx_actividadB.FindString(CmbItem.ToString());
                            break;
                    }


                }

                foreach (ComboboxItem CmbItem in cbx_tipoB.Items)
                {
                    var temp2 = CmbItem.Value.ToString();
                    if (temp2 == cliente.tipoCli)
                    {
                        cbx_tipoB.SelectedIndex = cbx_tipoB.FindString(CmbItem.ToString());
                        break;
                    }


                }


                //cbx_actividadB.SelectedIndex = cbx_actividadB.FindString(cliente.actividad);
                //cbx_tipoB.SelectedItem = cliente.tipoCli;

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
            TContrato tcontrato = new TContrato();

            

            cliente.rutCli = txt_rutB.Text;

            if (txt_rutB.Text != "")
            {
                if (!tcontrato.TieneContrato(cliente.rutCli))
                {
                    DialogResult eliminar = MessageBox.Show("Esta seguro que desea Eliminar el Cliente " + cliente.rutCli, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (eliminar == DialogResult.Yes)
                    {
                        if (tcliente.eliminarCliente(cliente))
                        {
                            MessageBox.Show("Eliminación realizada con exito", "Eliminacion de Dato", MessageBoxButtons.OK);
                            LimpiarDatosBS();

                        }
                        else
                        {
                            MessageBox.Show("Error al Eliminar Datos", "Eliminacion de Dato", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                        }
                    }
                }
                else { MessageBox.Show("Imposible Borrar este cliente debido a que tiene Contratos asociados", "Cliente con Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Rut vacío, busca o selecciona un rut Válido", "Rut Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information); }

           

            
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

        private void LimpiarDatosCliente()
        {
            txt_rut.Text = ("");
            txt_razonSocial.Text = ("");
            txt_nombre.Text = ("");
            txt_mail.Text = ("");
            txt_direccionCliente.Text = ("");
            txt_telefono.Text = ("");
            cbx_actividad.ResetText();
            cbx_actividad.SelectedIndex = -1;
            cbx_tipoCliente.ResetText();
            cbx_tipoCliente.SelectedIndex = -1;
            this.txt_rut.Focus();
            ActDes(false);


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

            if (txt_rutB.Text.Length == 0 || txt_nombreB.Text.Length == 0 || txt_razonSocialB.Text.Length == 0 || txt_mailB.Text.Length == 0 || txt_direccionCB.Text.Length == 0 || txt_telefonoB.Text.Length == 0 || cbx_actividadB.SelectedIndex == -1 || cbx_tipoB.SelectedIndex == -1)
            {
                MessageBox.Show("No deben existir campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cliente cliente = new Cliente();
                TCliente tcliente = new TCliente();

                cliente.rutCli = txt_rutB.Text;
                cliente.razon_social = txt_razonSocialB.Text;
                cliente.nombreContactoCli = txt_nombreB.Text;
                cliente.mailContacto = txt_mailB.Text;
                cliente.direccionCli = txt_direccionCB.Text;
                cliente.telefono = Int32.Parse(txt_telefonoB.Text);

                cliente.tipoCli = (cbx_tipoB.SelectedItem as ComboboxItem).Value.ToString();
                cliente.actividad = (cbx_actividadB.SelectedItem as ComboboxItem2).Value.ToString();
        
                if (tcliente.modificarCliente(cliente))
                {
                    LimpiarDatosBS();

                }
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

                    txt_rutB.Text = FrmListarClientes.rCliente.rutCli;
                    txt_nombreB.Text = FrmListarClientes.rCliente.nombreContactoCli;
                    txt_telefonoB.Text = FrmListarClientes.rCliente.telefono.ToString();
                    txt_direccionCB.Text = FrmListarClientes.rCliente.direccionCli;
                    txt_razonSocialB.Text = FrmListarClientes.rCliente.razon_social;
                    txt_mailB.Text = FrmListarClientes.rCliente.mailContacto;

                    foreach (ComboboxItem2 CmbItem in cbx_actividadB.Items)
                    {
                        var tempMeasured = CmbItem.Value.ToString();
                        if (tempMeasured == FrmListarClientes.rCliente.actividad)
                        {
                            cbx_actividadB.SelectedIndex = cbx_actividadB.FindString(CmbItem.ToString());
                            break;
                        }


                    }

                    foreach (ComboboxItem CmbItem in cbx_tipoB.Items)
                    {
                        var temp2 = CmbItem.Value.ToString();
                        if (temp2 == FrmListarClientes.rCliente.tipoCli)
                        {
                            cbx_tipoB.SelectedIndex = cbx_tipoB.FindString(CmbItem.ToString());
                            break;
                        }


                    }



                    //cbx_actividadB.SelectedItem = FrmListarClientes.rCliente.actividad;
                    //cbx_tipoB.SelectedItem = FrmListarClientes.rCliente.tipoCli;

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_telefonoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {

            LimpiarDatosBS();
        }

        private void btn_limpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarDatosCliente();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Visible = true;
            Visible = false;


        }

        private void btn_Salir2_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Visible = true;
            Visible = false;
        }

        private void cbx_tipoB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    