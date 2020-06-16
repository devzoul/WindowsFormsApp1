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
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ListarContratos = new System.Windows.Forms.Button();
            this.btn_ListarClientes = new System.Windows.Forms.Button();
            this.btn_contratos = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(850, 358);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(183, 137);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(836, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ListarContratos
            // 
            this.btn_ListarContratos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ListarContratos.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dark_logo_transparent_background;
            this.btn_ListarContratos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ListarContratos.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListarContratos.Image = global::WindowsFormsApp1.Properties.Resources.calendario;
            this.btn_ListarContratos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ListarContratos.Location = new System.Drawing.Point(480, 339);
            this.btn_ListarContratos.Name = "btn_ListarContratos";
            this.btn_ListarContratos.Size = new System.Drawing.Size(291, 190);
            this.btn_ListarContratos.TabIndex = 4;
            this.btn_ListarContratos.Text = "Listar Contratos";
            this.btn_ListarContratos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ListarContratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ListarContratos.UseVisualStyleBackColor = false;
            this.btn_ListarContratos.Click += new System.EventHandler(this.btn_ListarContratos_Click);
            // 
            // btn_ListarClientes
            // 
            this.btn_ListarClientes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_ListarClientes.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dark_logo_transparent_background;
            this.btn_ListarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ListarClientes.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListarClientes.Image = global::WindowsFormsApp1.Properties.Resources.junta_directiva;
            this.btn_ListarClientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ListarClientes.Location = new System.Drawing.Point(106, 339);
            this.btn_ListarClientes.Name = "btn_ListarClientes";
            this.btn_ListarClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ListarClientes.Size = new System.Drawing.Size(291, 190);
            this.btn_ListarClientes.TabIndex = 3;
            this.btn_ListarClientes.Text = "Listar Clientes";
            this.btn_ListarClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ListarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ListarClientes.UseVisualStyleBackColor = false;
            this.btn_ListarClientes.Click += new System.EventHandler(this.btn_ListarClientes_Click);
            // 
            // btn_contratos
            // 
            this.btn_contratos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_contratos.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dark_logo_transparent_background;
            this.btn_contratos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_contratos.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contratos.Image = global::WindowsFormsApp1.Properties.Resources.gestion_de_eventos;
            this.btn_contratos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_contratos.Location = new System.Drawing.Point(480, 100);
            this.btn_contratos.Name = "btn_contratos";
            this.btn_contratos.Size = new System.Drawing.Size(291, 190);
            this.btn_contratos.TabIndex = 2;
            this.btn_contratos.Text = "Administrador de Contratos";
            this.btn_contratos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_contratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_contratos.UseVisualStyleBackColor = false;
            this.btn_contratos.Click += new System.EventHandler(this.btn_contratos_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clientes.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.Image = global::WindowsFormsApp1.Properties.Resources.registro__1_;
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_clientes.Location = new System.Drawing.Point(106, 100);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(291, 190);
            this.btn_clientes.TabIndex = 1;
            this.btn_clientes.Text = "Administrador de Clientes";
            this.btn_clientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1111, 547);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ListarContratos);
            this.Controls.Add(this.btn_ListarClientes);
            this.Controls.Add(this.btn_contratos);
            this.Controls.Add(this.btn_clientes);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "OnBreak Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_contratos;
        private System.Windows.Forms.Button btn_ListarClientes;
        private System.Windows.Forms.Button btn_ListarContratos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_exit;
    }
}

