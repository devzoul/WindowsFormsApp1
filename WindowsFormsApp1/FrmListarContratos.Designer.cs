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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarContratos));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sDireccionC = new System.Windows.Forms.TextBox();
            this.txt_sHoraFin = new System.Windows.Forms.TextBox();
            this.txt_sHoraIni = new System.Windows.Forms.TextBox();
            this.txt_sFechaTermino = new System.Windows.Forms.TextBox();
            this.txt_sFechaCreacion = new System.Windows.Forms.TextBox();
            this.txt_sTipoC = new System.Windows.Forms.TextBox();
            this.txt_sRutC = new System.Windows.Forms.TextBox();
            this.txt_sContrato = new System.Windows.Forms.TextBox();
            this.txt_tipoCbusc = new System.Windows.Forms.TextBox();
            this.txt_rutCbusc = new System.Windows.Forms.TextBox();
            this.txt_contratoBusc = new System.Windows.Forms.TextBox();
            this.btn_cancelarLc = new System.Windows.Forms.Button();
            this.dtg_Contratos = new System.Windows.Forms.DataGridView();
            this.btn_listc_ok = new System.Windows.Forms.Button();
            this.txt_sVigente = new System.Windows.Forms.TextBox();
            this.txt_sObservaciones = new System.Windows.Forms.TextBox();
            this.txt_sMontoTotal = new System.Windows.Forms.TextBox();
            this.txt_sParticipantes = new System.Windows.Forms.TextBox();
            this.txt_sAsistentes = new System.Windows.Forms.TextBox();
            this.txt_sTipoModalidad = new System.Windows.Forms.TextBox();
            this.txt_sNomModalidad = new System.Windows.Forms.TextBox();
            this.txt_sNomTipoE = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Contratos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tipo Evento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // txt_sDireccionC
            // 
            this.txt_sDireccionC.Enabled = false;
            this.txt_sDireccionC.Location = new System.Drawing.Point(661, 482);
            this.txt_sDireccionC.Name = "txt_sDireccionC";
            this.txt_sDireccionC.Size = new System.Drawing.Size(223, 20);
            this.txt_sDireccionC.TabIndex = 32;
            this.txt_sDireccionC.Visible = false;
            // 
            // txt_sHoraFin
            // 
            this.txt_sHoraFin.Enabled = false;
            this.txt_sHoraFin.Location = new System.Drawing.Point(661, 456);
            this.txt_sHoraFin.Name = "txt_sHoraFin";
            this.txt_sHoraFin.Size = new System.Drawing.Size(223, 20);
            this.txt_sHoraFin.TabIndex = 31;
            this.txt_sHoraFin.Visible = false;
            // 
            // txt_sHoraIni
            // 
            this.txt_sHoraIni.Enabled = false;
            this.txt_sHoraIni.Location = new System.Drawing.Point(661, 430);
            this.txt_sHoraIni.Name = "txt_sHoraIni";
            this.txt_sHoraIni.Size = new System.Drawing.Size(223, 20);
            this.txt_sHoraIni.TabIndex = 30;
            this.txt_sHoraIni.Visible = false;
            // 
            // txt_sFechaTermino
            // 
            this.txt_sFechaTermino.Enabled = false;
            this.txt_sFechaTermino.Location = new System.Drawing.Point(661, 404);
            this.txt_sFechaTermino.Name = "txt_sFechaTermino";
            this.txt_sFechaTermino.Size = new System.Drawing.Size(223, 20);
            this.txt_sFechaTermino.TabIndex = 29;
            this.txt_sFechaTermino.Visible = false;
            // 
            // txt_sFechaCreacion
            // 
            this.txt_sFechaCreacion.Enabled = false;
            this.txt_sFechaCreacion.Location = new System.Drawing.Point(552, 482);
            this.txt_sFechaCreacion.Name = "txt_sFechaCreacion";
            this.txt_sFechaCreacion.Size = new System.Drawing.Size(223, 20);
            this.txt_sFechaCreacion.TabIndex = 28;
            this.txt_sFechaCreacion.Visible = false;
            // 
            // txt_sTipoC
            // 
            this.txt_sTipoC.Enabled = false;
            this.txt_sTipoC.Location = new System.Drawing.Point(552, 456);
            this.txt_sTipoC.Name = "txt_sTipoC";
            this.txt_sTipoC.Size = new System.Drawing.Size(223, 20);
            this.txt_sTipoC.TabIndex = 27;
            this.txt_sTipoC.Visible = false;
            // 
            // txt_sRutC
            // 
            this.txt_sRutC.Enabled = false;
            this.txt_sRutC.Location = new System.Drawing.Point(552, 430);
            this.txt_sRutC.Name = "txt_sRutC";
            this.txt_sRutC.Size = new System.Drawing.Size(223, 20);
            this.txt_sRutC.TabIndex = 26;
            this.txt_sRutC.Visible = false;
            // 
            // txt_sContrato
            // 
            this.txt_sContrato.Location = new System.Drawing.Point(552, 404);
            this.txt_sContrato.Name = "txt_sContrato";
            this.txt_sContrato.Size = new System.Drawing.Size(223, 20);
            this.txt_sContrato.TabIndex = 25;
            this.txt_sContrato.Visible = false;
            // 
            // txt_tipoCbusc
            // 
            this.txt_tipoCbusc.Location = new System.Drawing.Point(261, 36);
            this.txt_tipoCbusc.Name = "txt_tipoCbusc";
            this.txt_tipoCbusc.Size = new System.Drawing.Size(81, 20);
            this.txt_tipoCbusc.TabIndex = 24;
            this.txt_tipoCbusc.TextChanged += new System.EventHandler(this.txt_tipoCbusc_TextChanged);
            // 
            // txt_rutCbusc
            // 
            this.txt_rutCbusc.Location = new System.Drawing.Point(168, 36);
            this.txt_rutCbusc.Name = "txt_rutCbusc";
            this.txt_rutCbusc.Size = new System.Drawing.Size(70, 20);
            this.txt_rutCbusc.TabIndex = 23;
            this.txt_rutCbusc.TextChanged += new System.EventHandler(this.txt_rutCbusc_TextChanged);
            // 
            // txt_contratoBusc
            // 
            this.txt_contratoBusc.Location = new System.Drawing.Point(60, 36);
            this.txt_contratoBusc.Name = "txt_contratoBusc";
            this.txt_contratoBusc.Size = new System.Drawing.Size(79, 20);
            this.txt_contratoBusc.TabIndex = 22;
            this.txt_contratoBusc.TextChanged += new System.EventHandler(this.txt_contratoBusc_TextChanged);
            // 
            // btn_cancelarLc
            // 
            this.btn_cancelarLc.Location = new System.Drawing.Point(624, 360);
            this.btn_cancelarLc.Name = "btn_cancelarLc";
            this.btn_cancelarLc.Size = new System.Drawing.Size(151, 23);
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
            this.dtg_Contratos.Size = new System.Drawing.Size(1063, 281);
            this.dtg_Contratos.TabIndex = 20;
            this.dtg_Contratos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Contratos_CellClick);
            this.dtg_Contratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Contratos_CellContentClick);
            // 
            // btn_listc_ok
            // 
            this.btn_listc_ok.Enabled = false;
            this.btn_listc_ok.Location = new System.Drawing.Point(340, 360);
            this.btn_listc_ok.Name = "btn_listc_ok";
            this.btn_listc_ok.Size = new System.Drawing.Size(151, 23);
            this.btn_listc_ok.TabIndex = 19;
            this.btn_listc_ok.Text = "Ok";
            this.btn_listc_ok.UseVisualStyleBackColor = true;
            this.btn_listc_ok.Click += new System.EventHandler(this.btn_listc_ok_Click);
            // 
            // txt_sVigente
            // 
            this.txt_sVigente.Enabled = false;
            this.txt_sVigente.Location = new System.Drawing.Point(446, 404);
            this.txt_sVigente.Name = "txt_sVigente";
            this.txt_sVigente.Size = new System.Drawing.Size(223, 20);
            this.txt_sVigente.TabIndex = 36;
            this.txt_sVigente.Visible = false;
            // 
            // txt_sObservaciones
            // 
            this.txt_sObservaciones.Enabled = false;
            this.txt_sObservaciones.Location = new System.Drawing.Point(446, 430);
            this.txt_sObservaciones.Name = "txt_sObservaciones";
            this.txt_sObservaciones.Size = new System.Drawing.Size(223, 20);
            this.txt_sObservaciones.TabIndex = 37;
            this.txt_sObservaciones.Visible = false;
            // 
            // txt_sMontoTotal
            // 
            this.txt_sMontoTotal.Enabled = false;
            this.txt_sMontoTotal.Location = new System.Drawing.Point(340, 456);
            this.txt_sMontoTotal.Name = "txt_sMontoTotal";
            this.txt_sMontoTotal.Size = new System.Drawing.Size(223, 20);
            this.txt_sMontoTotal.TabIndex = 38;
            this.txt_sMontoTotal.Visible = false;
            // 
            // txt_sParticipantes
            // 
            this.txt_sParticipantes.Enabled = false;
            this.txt_sParticipantes.Location = new System.Drawing.Point(340, 404);
            this.txt_sParticipantes.Name = "txt_sParticipantes";
            this.txt_sParticipantes.Size = new System.Drawing.Size(223, 20);
            this.txt_sParticipantes.TabIndex = 39;
            this.txt_sParticipantes.Visible = false;
            // 
            // txt_sAsistentes
            // 
            this.txt_sAsistentes.Enabled = false;
            this.txt_sAsistentes.Location = new System.Drawing.Point(340, 430);
            this.txt_sAsistentes.Name = "txt_sAsistentes";
            this.txt_sAsistentes.Size = new System.Drawing.Size(223, 20);
            this.txt_sAsistentes.TabIndex = 40;
            this.txt_sAsistentes.Visible = false;
            // 
            // txt_sTipoModalidad
            // 
            this.txt_sTipoModalidad.Enabled = false;
            this.txt_sTipoModalidad.Location = new System.Drawing.Point(340, 482);
            this.txt_sTipoModalidad.Name = "txt_sTipoModalidad";
            this.txt_sTipoModalidad.Size = new System.Drawing.Size(223, 20);
            this.txt_sTipoModalidad.TabIndex = 41;
            this.txt_sTipoModalidad.Visible = false;
            // 
            // txt_sNomModalidad
            // 
            this.txt_sNomModalidad.Enabled = false;
            this.txt_sNomModalidad.Location = new System.Drawing.Point(106, 404);
            this.txt_sNomModalidad.Name = "txt_sNomModalidad";
            this.txt_sNomModalidad.Size = new System.Drawing.Size(223, 20);
            this.txt_sNomModalidad.TabIndex = 42;
            this.txt_sNomModalidad.Visible = false;
            // 
            // txt_sNomTipoE
            // 
            this.txt_sNomTipoE.Enabled = false;
            this.txt_sNomTipoE.Location = new System.Drawing.Point(106, 430);
            this.txt_sNomTipoE.Name = "txt_sNomTipoE";
            this.txt_sNomTipoE.Size = new System.Drawing.Size(223, 20);
            this.txt_sNomTipoE.TabIndex = 43;
            this.txt_sNomTipoE.Visible = false;
            // 
            // FrmListarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 590);
            this.ControlBox = false;
            this.Controls.Add(this.txt_sNomTipoE);
            this.Controls.Add(this.txt_sNomModalidad);
            this.Controls.Add(this.txt_sTipoModalidad);
            this.Controls.Add(this.txt_sAsistentes);
            this.Controls.Add(this.txt_sParticipantes);
            this.Controls.Add(this.txt_sMontoTotal);
            this.Controls.Add(this.txt_sObservaciones);
            this.Controls.Add(this.txt_sVigente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sDireccionC);
            this.Controls.Add(this.txt_sHoraFin);
            this.Controls.Add(this.txt_sHoraIni);
            this.Controls.Add(this.txt_sFechaTermino);
            this.Controls.Add(this.txt_sFechaCreacion);
            this.Controls.Add(this.txt_sTipoC);
            this.Controls.Add(this.txt_sRutC);
            this.Controls.Add(this.txt_sContrato);
            this.Controls.Add(this.txt_tipoCbusc);
            this.Controls.Add(this.txt_rutCbusc);
            this.Controls.Add(this.txt_contratoBusc);
            this.Controls.Add(this.btn_cancelarLc);
            this.Controls.Add(this.dtg_Contratos);
            this.Controls.Add(this.btn_listc_ok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListarContratos";
            this.Text = "OnBreak Listar Contrato";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Contratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sDireccionC;
        private System.Windows.Forms.TextBox txt_sHoraFin;
        private System.Windows.Forms.TextBox txt_sHoraIni;
        private System.Windows.Forms.TextBox txt_sFechaTermino;
        private System.Windows.Forms.TextBox txt_sFechaCreacion;
        private System.Windows.Forms.TextBox txt_sTipoC;
        private System.Windows.Forms.TextBox txt_sRutC;
        private System.Windows.Forms.TextBox txt_sContrato;
        private System.Windows.Forms.TextBox txt_tipoCbusc;
        private System.Windows.Forms.TextBox txt_rutCbusc;
        private System.Windows.Forms.TextBox txt_contratoBusc;
        public System.Windows.Forms.Button btn_cancelarLc;
        private System.Windows.Forms.DataGridView dtg_Contratos;
        public System.Windows.Forms.Button btn_listc_ok;
        private System.Windows.Forms.TextBox txt_sVigente;
        private System.Windows.Forms.TextBox txt_sObservaciones;
        private System.Windows.Forms.TextBox txt_sMontoTotal;
        private System.Windows.Forms.TextBox txt_sParticipantes;
        private System.Windows.Forms.TextBox txt_sAsistentes;
        private System.Windows.Forms.TextBox txt_sTipoModalidad;
        private System.Windows.Forms.TextBox txt_sNomModalidad;
        private System.Windows.Forms.TextBox txt_sNomTipoE;
    }
}