namespace WindowsFormsApp1
{
    partial class FrmListarClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarClientes));
            this.button1 = new System.Windows.Forms.Button();
            this.dtg_Clientes = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txtRutbusc = new System.Windows.Forms.TextBox();
            this.txtActividadbusc = new System.Windows.Forms.TextBox();
            this.txtTipobusc = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.txt_sRut = new System.Windows.Forms.TextBox();
            this.txt_sRazon = new System.Windows.Forms.TextBox();
            this.txt_sDireccion = new System.Windows.Forms.TextBox();
            this.txt_sTelefono = new System.Windows.Forms.TextBox();
            this.txt_sMail = new System.Windows.Forms.TextBox();
            this.txt_sActividad = new System.Windows.Forms.TextBox();
            this.txt_sTipo = new System.Windows.Forms.TextBox();
            this.txt_sNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(109, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtg_Clientes
            // 
            this.dtg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Clientes.Location = new System.Drawing.Point(26, 80);
            this.dtg_Clientes.Name = "dtg_Clientes";
            this.dtg_Clientes.Size = new System.Drawing.Size(742, 280);
            this.dtg_Clientes.TabIndex = 2;
            this.dtg_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Clientes_CellClick);
            this.dtg_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Clientes_CellContentClick);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(218, 378);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRutbusc
            // 
            this.txtRutbusc.Location = new System.Drawing.Point(67, 54);
            this.txtRutbusc.Name = "txtRutbusc";
            this.txtRutbusc.Size = new System.Drawing.Size(79, 20);
            this.txtRutbusc.TabIndex = 5;
            this.txtRutbusc.TextChanged += new System.EventHandler(this.txtRutbusc_TextChanged);
            // 
            // txtActividadbusc
            // 
            this.txtActividadbusc.Location = new System.Drawing.Point(175, 54);
            this.txtActividadbusc.Name = "txtActividadbusc";
            this.txtActividadbusc.Size = new System.Drawing.Size(70, 20);
            this.txtActividadbusc.TabIndex = 6;
            this.txtActividadbusc.TextChanged += new System.EventHandler(this.txtActividadbusc_TextChanged);
            // 
            // txtTipobusc
            // 
            this.txtTipobusc.Location = new System.Drawing.Point(268, 54);
            this.txtTipobusc.Name = "txtTipobusc";
            this.txtTipobusc.Size = new System.Drawing.Size(81, 20);
            this.txtTipobusc.TabIndex = 7;
            this.txtTipobusc.TextChanged += new System.EventHandler(this.txtTipobusc_TextChanged);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // txt_sRut
            // 
            this.txt_sRut.Location = new System.Drawing.Point(579, 354);
            this.txt_sRut.Name = "txt_sRut";
            this.txt_sRut.Size = new System.Drawing.Size(100, 20);
            this.txt_sRut.TabIndex = 8;
            this.txt_sRut.Visible = false;
            // 
            // txt_sRazon
            // 
            this.txt_sRazon.Enabled = false;
            this.txt_sRazon.Location = new System.Drawing.Point(579, 380);
            this.txt_sRazon.Name = "txt_sRazon";
            this.txt_sRazon.Size = new System.Drawing.Size(100, 20);
            this.txt_sRazon.TabIndex = 9;
            this.txt_sRazon.Visible = false;
            // 
            // txt_sDireccion
            // 
            this.txt_sDireccion.Enabled = false;
            this.txt_sDireccion.Location = new System.Drawing.Point(579, 406);
            this.txt_sDireccion.Name = "txt_sDireccion";
            this.txt_sDireccion.Size = new System.Drawing.Size(100, 20);
            this.txt_sDireccion.TabIndex = 10;
            this.txt_sDireccion.Visible = false;
            // 
            // txt_sTelefono
            // 
            this.txt_sTelefono.Enabled = false;
            this.txt_sTelefono.Location = new System.Drawing.Point(579, 432);
            this.txt_sTelefono.Name = "txt_sTelefono";
            this.txt_sTelefono.Size = new System.Drawing.Size(100, 20);
            this.txt_sTelefono.TabIndex = 11;
            this.txt_sTelefono.Visible = false;
            // 
            // txt_sMail
            // 
            this.txt_sMail.Enabled = false;
            this.txt_sMail.Location = new System.Drawing.Point(688, 354);
            this.txt_sMail.Name = "txt_sMail";
            this.txt_sMail.Size = new System.Drawing.Size(100, 20);
            this.txt_sMail.TabIndex = 12;
            this.txt_sMail.Visible = false;
            // 
            // txt_sActividad
            // 
            this.txt_sActividad.Enabled = false;
            this.txt_sActividad.Location = new System.Drawing.Point(688, 380);
            this.txt_sActividad.Name = "txt_sActividad";
            this.txt_sActividad.Size = new System.Drawing.Size(100, 20);
            this.txt_sActividad.TabIndex = 13;
            this.txt_sActividad.Visible = false;
            // 
            // txt_sTipo
            // 
            this.txt_sTipo.Enabled = false;
            this.txt_sTipo.Location = new System.Drawing.Point(688, 406);
            this.txt_sTipo.Name = "txt_sTipo";
            this.txt_sTipo.Size = new System.Drawing.Size(100, 20);
            this.txt_sTipo.TabIndex = 14;
            this.txt_sTipo.Visible = false;
            // 
            // txt_sNombre
            // 
            this.txt_sNombre.Enabled = false;
            this.txt_sNombre.Location = new System.Drawing.Point(688, 432);
            this.txt_sNombre.Name = "txt_sNombre";
            this.txt_sNombre.Size = new System.Drawing.Size(100, 20);
            this.txt_sNombre.TabIndex = 15;
            this.txt_sNombre.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Actividad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tipo";
            // 
            // FrmListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sNombre);
            this.Controls.Add(this.txt_sTipo);
            this.Controls.Add(this.txt_sActividad);
            this.Controls.Add(this.txt_sMail);
            this.Controls.Add(this.txt_sTelefono);
            this.Controls.Add(this.txt_sDireccion);
            this.Controls.Add(this.txt_sRazon);
            this.Controls.Add(this.txt_sRut);
            this.Controls.Add(this.txtTipobusc);
            this.Controls.Add(this.txtActividadbusc);
            this.Controls.Add(this.txtRutbusc);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dtg_Clientes);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnBreak Listar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtg_Clientes;
        public System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txtRutbusc;
        private System.Windows.Forms.TextBox txtActividadbusc;
        private System.Windows.Forms.TextBox txtTipobusc;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TextBox txt_sRut;
        private System.Windows.Forms.TextBox txt_sRazon;
        private System.Windows.Forms.TextBox txt_sDireccion;
        private System.Windows.Forms.TextBox txt_sTelefono;
        private System.Windows.Forms.TextBox txt_sMail;
        private System.Windows.Forms.TextBox txt_sActividad;
        private System.Windows.Forms.TextBox txt_sTipo;
        private System.Windows.Forms.TextBox txt_sNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}