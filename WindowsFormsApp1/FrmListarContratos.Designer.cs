namespace WindowsFormsApp1
{
    partial class FrmListarContratos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sNombre = new System.Windows.Forms.TextBox();
            this.txt_sTipo = new System.Windows.Forms.TextBox();
            this.txt_sActividad = new System.Windows.Forms.TextBox();
            this.txt_sMail = new System.Windows.Forms.TextBox();
            this.txt_sTelefono = new System.Windows.Forms.TextBox();
            this.txt_sDireccion = new System.Windows.Forms.TextBox();
            this.txt_sRazon = new System.Windows.Forms.TextBox();
            this.txt_sRut = new System.Windows.Forms.TextBox();
            this.txt_tipoCbusc = new System.Windows.Forms.TextBox();
            this.txt_rutCbusc = new System.Windows.Forms.TextBox();
            this.txt_contratoBusc = new System.Windows.Forms.TextBox();
            this.btn_cancelarLc = new System.Windows.Forms.Button();
            this.dtg_Contratos = new System.Windows.Forms.DataGridView();
            this.btn_listc_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Contratos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tipo Contrato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Rut Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "N° Contrato";
            // 
            // txt_sNombre
            // 
            this.txt_sNombre.Enabled = false;
            this.txt_sNombre.Location = new System.Drawing.Point(661, 430);
            this.txt_sNombre.Name = "txt_sNombre";
            this.txt_sNombre.Size = new System.Drawing.Size(100, 20);
            this.txt_sNombre.TabIndex = 32;
            this.txt_sNombre.Visible = false;
            // 
            // txt_sTipo
            // 
            this.txt_sTipo.Enabled = false;
            this.txt_sTipo.Location = new System.Drawing.Point(661, 404);
            this.txt_sTipo.Name = "txt_sTipo";
            this.txt_sTipo.Size = new System.Drawing.Size(100, 20);
            this.txt_sTipo.TabIndex = 31;
            this.txt_sTipo.Visible = false;
            // 
            // txt_sActividad
            // 
            this.txt_sActividad.Enabled = false;
            this.txt_sActividad.Location = new System.Drawing.Point(661, 378);
            this.txt_sActividad.Name = "txt_sActividad";
            this.txt_sActividad.Size = new System.Drawing.Size(100, 20);
            this.txt_sActividad.TabIndex = 30;
            this.txt_sActividad.Visible = false;
            // 
            // txt_sMail
            // 
            this.txt_sMail.Enabled = false;
            this.txt_sMail.Location = new System.Drawing.Point(661, 352);
            this.txt_sMail.Name = "txt_sMail";
            this.txt_sMail.Size = new System.Drawing.Size(100, 20);
            this.txt_sMail.TabIndex = 29;
            this.txt_sMail.Visible = false;
            // 
            // txt_sTelefono
            // 
            this.txt_sTelefono.Enabled = false;
            this.txt_sTelefono.Location = new System.Drawing.Point(552, 430);
            this.txt_sTelefono.Name = "txt_sTelefono";
            this.txt_sTelefono.Size = new System.Drawing.Size(100, 20);
            this.txt_sTelefono.TabIndex = 28;
            this.txt_sTelefono.Visible = false;
            // 
            // txt_sDireccion
            // 
            this.txt_sDireccion.Enabled = false;
            this.txt_sDireccion.Location = new System.Drawing.Point(552, 404);
            this.txt_sDireccion.Name = "txt_sDireccion";
            this.txt_sDireccion.Size = new System.Drawing.Size(100, 20);
            this.txt_sDireccion.TabIndex = 27;
            this.txt_sDireccion.Visible = false;
            // 
            // txt_sRazon
            // 
            this.txt_sRazon.Enabled = false;
            this.txt_sRazon.Location = new System.Drawing.Point(552, 378);
            this.txt_sRazon.Name = "txt_sRazon";
            this.txt_sRazon.Size = new System.Drawing.Size(100, 20);
            this.txt_sRazon.TabIndex = 26;
            this.txt_sRazon.Visible = false;
            // 
            // txt_sRut
            // 
            this.txt_sRut.Location = new System.Drawing.Point(552, 352);
            this.txt_sRut.Name = "txt_sRut";
            this.txt_sRut.Size = new System.Drawing.Size(100, 20);
            this.txt_sRut.TabIndex = 25;
            this.txt_sRut.Visible = false;
            // 
            // txt_tipoCbusc
            // 
            this.txt_tipoCbusc.Location = new System.Drawing.Point(261, 36);
            this.txt_tipoCbusc.Name = "txt_tipoCbusc";
            this.txt_tipoCbusc.Size = new System.Drawing.Size(81, 20);
            this.txt_tipoCbusc.TabIndex = 24;
            // 
            // txt_rutCbusc
            // 
            this.txt_rutCbusc.Location = new System.Drawing.Point(168, 36);
            this.txt_rutCbusc.Name = "txt_rutCbusc";
            this.txt_rutCbusc.Size = new System.Drawing.Size(70, 20);
            this.txt_rutCbusc.TabIndex = 23;
            // 
            // txt_contratoBusc
            // 
            this.txt_contratoBusc.Location = new System.Drawing.Point(60, 36);
            this.txt_contratoBusc.Name = "txt_contratoBusc";
            this.txt_contratoBusc.Size = new System.Drawing.Size(79, 20);
            this.txt_contratoBusc.TabIndex = 22;
            // 
            // btn_cancelarLc
            // 
            this.btn_cancelarLc.Location = new System.Drawing.Point(212, 360);
            this.btn_cancelarLc.Name = "btn_cancelarLc";
            this.btn_cancelarLc.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelarLc.TabIndex = 21;
            this.btn_cancelarLc.Text = "Cancelar";
            this.btn_cancelarLc.UseVisualStyleBackColor = true;
            this.btn_cancelarLc.Click += new System.EventHandler(this.btn_cancelarLc_Click);
            // 
            // dtg_Contratos
            // 
            this.dtg_Contratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Contratos.Location = new System.Drawing.Point(19, 62);
            this.dtg_Contratos.Name = "dtg_Contratos";
            this.dtg_Contratos.Size = new System.Drawing.Size(742, 280);
            this.dtg_Contratos.TabIndex = 20;
            this.dtg_Contratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Contratos_CellContentClick);
            // 
            // btn_listc_ok
            // 
            this.btn_listc_ok.Location = new System.Drawing.Point(102, 360);
            this.btn_listc_ok.Name = "btn_listc_ok";
            this.btn_listc_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_listc_ok.TabIndex = 19;
            this.btn_listc_ok.Text = "Ok";
            this.btn_listc_ok.UseVisualStyleBackColor = true;
            // 
            // FrmListarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.txt_tipoCbusc);
            this.Controls.Add(this.txt_rutCbusc);
            this.Controls.Add(this.txt_contratoBusc);
            this.Controls.Add(this.btn_cancelarLc);
            this.Controls.Add(this.dtg_Contratos);
            this.Controls.Add(this.btn_listc_ok);
            this.Name = "FrmListarContratos";
            this.Text = "FrmListarContratos";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Contratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sNombre;
        private System.Windows.Forms.TextBox txt_sTipo;
        private System.Windows.Forms.TextBox txt_sActividad;
        private System.Windows.Forms.TextBox txt_sMail;
        private System.Windows.Forms.TextBox txt_sTelefono;
        private System.Windows.Forms.TextBox txt_sDireccion;
        private System.Windows.Forms.TextBox txt_sRazon;
        private System.Windows.Forms.TextBox txt_sRut;
        private System.Windows.Forms.TextBox txt_tipoCbusc;
        private System.Windows.Forms.TextBox txt_rutCbusc;
        private System.Windows.Forms.TextBox txt_contratoBusc;
        private System.Windows.Forms.Button btn_cancelarLc;
        private System.Windows.Forms.DataGridView dtg_Contratos;
        private System.Windows.Forms.Button btn_listc_ok;
    }
}