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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            TUsuario tusuario = new TUsuario();
            Usuario usuario = new Usuario();
            usuario = tusuario.valLogin(txt_usuario.Text,txt_contraseña.Text);

            if (txt_usuario.Text != "" && txt_contraseña.Text != "")
            {
                if (txt_usuario.Text.ToUpper() == usuario.usuario.ToUpper())
                {
                    if (txt_contraseña.Text == usuario.contraseña)
                    {
                        FrmPrincipal frmPrincipal = new FrmPrincipal();
                        frmPrincipal.Visible = true;
                        Visible = false;
                    }
                    else { MessageBox.Show("Contraseña incorrecta", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information); }


                }
                else { MessageBox.Show("El Usuario ingresado no existe", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
            else { MessageBox.Show("Favor ingresa Usuario y contraseña", "Datos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            



        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            {
                DialogResult salir = MessageBox.Show("Esta seguro que desea salir de la aplicacion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (salir == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
        }
    }
}
