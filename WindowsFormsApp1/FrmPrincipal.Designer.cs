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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_contratos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1196, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.archivoToolStripMenuItem.Text = "Administracion de Clientes";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.salirToolStripMenuItem.Text = "Administracion de Contratos";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clientes.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dark_logo_transparent_background;
            this.btn_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_clientes.Location = new System.Drawing.Point(100, 192);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(291, 190);
            this.btn_clientes.TabIndex = 1;
            this.btn_clientes.Text = "Administrador de Clientes";
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_contratos
            // 
            this.btn_contratos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_contratos.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dark_logo_transparent_background;
            this.btn_contratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_contratos.Location = new System.Drawing.Point(449, 192);
            this.btn_contratos.Name = "btn_contratos";
            this.btn_contratos.Size = new System.Drawing.Size(291, 190);
            this.btn_contratos.TabIndex = 2;
            this.btn_contratos.Text = "Administrador de Contratos";
            this.btn_contratos.UseVisualStyleBackColor = false;
            this.btn_contratos.Click += new System.EventHandler(this.btn_contratos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 612);
            this.Controls.Add(this.btn_contratos);
            this.Controls.Add(this.btn_clientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_contratos;
    }
}

