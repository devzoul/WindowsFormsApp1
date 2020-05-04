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
        public FrmListarContratos()
        {
            InitializeComponent();
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
