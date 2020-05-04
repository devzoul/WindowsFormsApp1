namespace WindowsFormsApp1
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_contratos = new System.Windows.Forms.Button();
            this.btn_ListarClientes = new System.Windows.Forms.Button();
            this.btn_ListarContratos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clientes.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dark_logo_transparent_background;
            this.btn_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_clientes.Location = new System.Drawing.Point(106, 100);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(291, 190);
            this.btn_clientes.TabIndex = 1;
            this.btn_clientes.Text = "Administrador de Clientes";
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_contratos
            // 
            this.btn_contratos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_contratos.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dark_logo_transparent_background;
            this.btn_contratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_contratos.Location = new System.Drawing.Point(480, 100);
            this.btn_contratos.Name = "btn_contratos";
            this.btn_contratos.Size = new System.Drawing.Size(291, 190);
            this.btn_contratos.TabIndex = 2;
            this.btn_contratos.Text = "Administrador de Contratos";
            this.btn_contratos.UseVisualStyleBackColor = false;
            this.btn_contratos.Click += new System.EventHandler(this.btn_contratos_Click);
            // 
            // btn_ListarClientes
            // 
            this.btn_ListarClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ListarClientes.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dark_logo_transparent_background;
            this.btn_ListarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_ListarClientes.Location = new System.Drawing.Point(106, 339);
            this.btn_ListarClientes.Name = "btn_ListarClientes";
            this.btn_ListarClientes.Size = new System.Drawing.Size(291, 190);
            this.btn_ListarClientes.TabIndex = 3;
            this.btn_ListarClientes.Text = "Listar Clientes";
            this.btn_ListarClientes.UseVisualStyleBackColor = false;
            this.btn_ListarClientes.Click += new System.EventHandler(this.btn_ListarClientes_Click);
            // 
            // btn_ListarContratos
            // 
            this.btn_ListarContratos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ListarContratos.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dark_logo_transparent_background;
            this.btn_ListarContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_ListarContratos.Location = new System.Drawing.Point(480, 339);
            this.btn_ListarContratos.Name = "btn_ListarContratos";
            this.btn_ListarContratos.Size = new System.Drawing.Size(291, 190);
            this.btn_ListarContratos.TabIndex = 4;
            this.btn_ListarContratos.Text = "Listar Contratos";
            this.btn_ListarContratos.UseVisualStyleBackColor = false;
            this.btn_ListarContratos.Click += new System.EventHandler(this.btn_ListarContratos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(873, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 171);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ListarContratos);
            this.Controls.Add(this.btn_ListarClientes);
            this.Controls.Add(this.btn_contratos);
            this.Controls.Add(this.btn_clientes);
            this.Name = "FrmPrincipal";
            this.Text = "OnBreak Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_contratos;
        private System.Windows.Forms.Button btn_ListarClientes;
        private System.Windows.Forms.Button btn_ListarContratos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

