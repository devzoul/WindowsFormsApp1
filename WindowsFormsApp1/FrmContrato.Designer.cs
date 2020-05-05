using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class FrmContrato
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_buscListCon = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_buscacon = new System.Windows.Forms.TextBox();
            this.btn_limpiarC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_buscaparti = new System.Windows.Forms.TextBox();
            this.txt_buscaasis = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cbx_buscavig = new System.Windows.Forms.ComboBox();
            this.txt_buscarz = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_buscamonto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_buscarut = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp_buscahorafin = new System.Windows.Forms.DateTimePicker();
            this.dtp_buscahoraini = new System.Windows.Forms.DateTimePicker();
            this.dtp_buscatermino = new System.Windows.Forms.DateTimePicker();
            this.dtp_buscacreacion = new System.Windows.Forms.DateTimePicker();
            this.txt_buscaobs = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbx_buscatipo = new System.Windows.Forms.ComboBox();
            this.txt_buscadir = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.txt_participantes = new System.Windows.Forms.TextBox();
            this.txt_numeroContrato = new System.Windows.Forms.TextBox();
            this.cbx_vigente = new System.Windows.Forms.ComboBox();
            this.btn_limpiarCC = new System.Windows.Forms.Button();
            this.txt_razonCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_rutCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_horaTerm = new System.Windows.Forms.DateTimePicker();
            this.dtp_horaIni = new System.Windows.Forms.DateTimePicker();
            this.dtp_termino = new System.Windows.Forms.DateTimePicker();
            this.dtp_creacion = new System.Windows.Forms.DateTimePicker();
            this.txt_asistentes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_buscarCC = new System.Windows.Forms.Button();
            this.btn_regContrato = new System.Windows.Forms.Button();
            this.cbx_tipoContrato = new System.Windows.Forms.ComboBox();
            this.txt_direccionContrato = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_buscListCon);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.txt_buscacon);
            this.tabPage2.Controls.Add(this.btn_limpiarC);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar Contrato";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_buscListCon
            // 
            this.btn_buscListCon.Location = new System.Drawing.Point(515, 126);
            this.btn_buscListCon.Name = "btn_buscListCon";
            this.btn_buscListCon.Size = new System.Drawing.Size(90, 50);
            this.btn_buscListCon.TabIndex = 34;
            this.btn_buscListCon.Text = "Buscar de Lista";
            this.btn_buscListCon.UseVisualStyleBackColor = true;
            this.btn_buscListCon.Click += new System.EventHandler(this.btn_buscListCon_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(502, 93);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(115, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "Ingrese N° de Contrato";
            // 
            // txt_buscacon
            // 
            this.txt_buscacon.Location = new System.Drawing.Point(505, 64);
            this.txt_buscacon.Name = "txt_buscacon";
            this.txt_buscacon.Size = new System.Drawing.Size(100, 20);
            this.txt_buscacon.TabIndex = 32;
            // 
            // btn_limpiarC
            // 
            this.btn_limpiarC.Location = new System.Drawing.Point(515, 212);
            this.btn_limpiarC.Name = "btn_limpiarC";
            this.btn_limpiarC.Size = new System.Drawing.Size(90, 27);
            this.btn_limpiarC.TabIndex = 32;
            this.btn_limpiarC.Text = "Limpiar";
            this.btn_limpiarC.UseVisualStyleBackColor = true;
            this.btn_limpiarC.Click += new System.EventHandler(this.btn_limpiarC_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_buscaparti);
            this.groupBox2.Controls.Add(this.txt_buscaasis);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.cbx_buscavig);
            this.groupBox2.Controls.Add(this.txt_buscarz);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_buscamonto);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_buscarut);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtp_buscahorafin);
            this.groupBox2.Controls.Add(this.dtp_buscahoraini);
            this.groupBox2.Controls.Add(this.dtp_buscatermino);
            this.groupBox2.Controls.Add(this.dtp_buscacreacion);
            this.groupBox2.Controls.Add(this.txt_buscaobs);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbx_buscatipo);
            this.groupBox2.Controls.Add(this.txt_buscadir);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(20, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 412);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Contrato";
            // 
            // txt_buscaparti
            // 
            this.txt_buscaparti.Enabled = false;
            this.txt_buscaparti.Location = new System.Drawing.Point(130, 303);
            this.txt_buscaparti.Name = "txt_buscaparti";
            this.txt_buscaparti.Size = new System.Drawing.Size(100, 20);
            this.txt_buscaparti.TabIndex = 36;
            this.txt_buscaparti.TextChanged += new System.EventHandler(this.txt_buscaparti_TextChanged);
            this.txt_buscaparti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscaparti_KeyPress);
            // 
            // txt_buscaasis
            // 
            this.txt_buscaasis.Enabled = false;
            this.txt_buscaasis.Location = new System.Drawing.Point(130, 277);
            this.txt_buscaasis.Name = "txt_buscaasis";
            this.txt_buscaasis.Size = new System.Drawing.Size(100, 20);
            this.txt_buscaasis.TabIndex = 35;
            this.txt_buscaasis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscaasis_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 310);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 13);
            this.label27.TabIndex = 34;
            this.label27.Text = "Participantes";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 284);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 13);
            this.label26.TabIndex = 33;
            this.label26.Text = "Asistentes";
            // 
            // cbx_buscavig
            // 
            this.cbx_buscavig.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbx_buscavig.Enabled = false;
            this.cbx_buscavig.FormattingEnabled = true;
            this.cbx_buscavig.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbx_buscavig.Location = new System.Drawing.Point(130, 217);
            this.cbx_buscavig.Name = "cbx_buscavig";
            this.cbx_buscavig.Size = new System.Drawing.Size(123, 21);
            this.cbx_buscavig.TabIndex = 32;
            // 
            // txt_buscarz
            // 
            this.txt_buscarz.Enabled = false;
            this.txt_buscarz.Location = new System.Drawing.Point(130, 55);
            this.txt_buscarz.Name = "txt_buscarz";
            this.txt_buscarz.Size = new System.Drawing.Size(100, 20);
            this.txt_buscarz.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Razon Cliente";
            // 
            // txt_buscamonto
            // 
            this.txt_buscamonto.Enabled = false;
            this.txt_buscamonto.Location = new System.Drawing.Point(130, 329);
            this.txt_buscamonto.Name = "txt_buscamonto";
            this.txt_buscamonto.Size = new System.Drawing.Size(100, 20);
            this.txt_buscamonto.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Monto Total Contrato";
            // 
            // txt_buscarut
            // 
            this.txt_buscarut.Enabled = false;
            this.txt_buscarut.Location = new System.Drawing.Point(130, 29);
            this.txt_buscarut.Name = "txt_buscarut";
            this.txt_buscarut.Size = new System.Drawing.Size(100, 20);
            this.txt_buscarut.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Rut Cliente";
            // 
            // dtp_buscahorafin
            // 
            this.dtp_buscahorafin.CustomFormat = "HH:mm";
            this.dtp_buscahorafin.Enabled = false;
            this.dtp_buscahorafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_buscahorafin.Location = new System.Drawing.Point(130, 165);
            this.dtp_buscahorafin.Name = "dtp_buscahorafin";
            this.dtp_buscahorafin.Size = new System.Drawing.Size(149, 20);
            this.dtp_buscahorafin.TabIndex = 25;
            // 
            // dtp_buscahoraini
            // 
            this.dtp_buscahoraini.CustomFormat = "HH:mm";
            this.dtp_buscahoraini.Enabled = false;
            this.dtp_buscahoraini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_buscahoraini.Location = new System.Drawing.Point(130, 139);
            this.dtp_buscahoraini.Name = "dtp_buscahoraini";
            this.dtp_buscahoraini.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_buscahoraini.Size = new System.Drawing.Size(147, 20);
            this.dtp_buscahoraini.TabIndex = 24;
            // 
            // dtp_buscatermino
            // 
            this.dtp_buscatermino.Enabled = false;
            this.dtp_buscatermino.Location = new System.Drawing.Point(130, 113);
            this.dtp_buscatermino.Name = "dtp_buscatermino";
            this.dtp_buscatermino.Size = new System.Drawing.Size(213, 20);
            this.dtp_buscatermino.TabIndex = 23;
            // 
            // dtp_buscacreacion
            // 
            this.dtp_buscacreacion.Enabled = false;
            this.dtp_buscacreacion.Location = new System.Drawing.Point(130, 87);
            this.dtp_buscacreacion.Name = "dtp_buscacreacion";
            this.dtp_buscacreacion.Size = new System.Drawing.Size(213, 20);
            this.dtp_buscacreacion.TabIndex = 22;
            this.dtp_buscacreacion.Value = new System.DateTime(2020, 4, 30, 21, 6, 27, 0);
            this.dtp_buscacreacion.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // txt_buscaobs
            // 
            this.txt_buscaobs.Enabled = false;
            this.txt_buscaobs.Location = new System.Drawing.Point(130, 370);
            this.txt_buscaobs.Name = "txt_buscaobs";
            this.txt_buscaobs.Size = new System.Drawing.Size(303, 20);
            this.txt_buscaobs.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 377);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Observaciones";
            // 
            // cbx_buscatipo
            // 
            this.cbx_buscatipo.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbx_buscatipo.Enabled = false;
            this.cbx_buscatipo.FormattingEnabled = true;
            this.cbx_buscatipo.Items.AddRange(new object[] {
            "Matrimonio",
            "Bautizo",
            "Cumpleaños",
            "Aniversario"});
            this.cbx_buscatipo.Location = new System.Drawing.Point(130, 250);
            this.cbx_buscatipo.Name = "cbx_buscatipo";
            this.cbx_buscatipo.Size = new System.Drawing.Size(121, 21);
            this.cbx_buscatipo.TabIndex = 15;
            // 
            // txt_buscadir
            // 
            this.txt_buscadir.Enabled = false;
            this.txt_buscadir.Location = new System.Drawing.Point(130, 191);
            this.txt_buscadir.Name = "txt_buscadir";
            this.txt_buscadir.Size = new System.Drawing.Size(303, 20);
            this.txt_buscadir.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Tipo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 225);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Vigente";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Direccion";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Fecha/Hora Termino";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 146);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Fecha/Hora Inicio";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Termino";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Creacion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 27);
            this.button2.TabIndex = 18;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Contrato";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txt_observaciones);
            this.groupBox1.Controls.Add(this.txt_participantes);
            this.groupBox1.Controls.Add(this.txt_numeroContrato);
            this.groupBox1.Controls.Add(this.cbx_vigente);
            this.groupBox1.Controls.Add(this.btn_limpiarCC);
            this.groupBox1.Controls.Add(this.txt_razonCliente);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_rutCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_horaTerm);
            this.groupBox1.Controls.Add(this.dtp_horaIni);
            this.groupBox1.Controls.Add(this.dtp_termino);
            this.groupBox1.Controls.Add(this.dtp_creacion);
            this.groupBox1.Controls.Add(this.txt_asistentes);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_buscarCC);
            this.groupBox1.Controls.Add(this.btn_regContrato);
            this.groupBox1.Controls.Add(this.cbx_tipoContrato);
            this.groupBox1.Controls.Add(this.txt_direccionContrato);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 412);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Contrato";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(23, 310);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 13);
            this.label25.TabIndex = 38;
            this.label25.Text = "Participantes";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 280);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 37;
            this.label24.Text = "Asistentes";
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Location = new System.Drawing.Point(132, 337);
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(358, 20);
            this.txt_observaciones.TabIndex = 36;
            // 
            // txt_participantes
            // 
            this.txt_participantes.Location = new System.Drawing.Point(132, 303);
            this.txt_participantes.Name = "txt_participantes";
            this.txt_participantes.Size = new System.Drawing.Size(100, 20);
            this.txt_participantes.TabIndex = 35;
            this.txt_participantes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_participantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_participantes_KeyPress);
            // 
            // txt_numeroContrato
            // 
            this.txt_numeroContrato.Location = new System.Drawing.Point(249, 29);
            this.txt_numeroContrato.Name = "txt_numeroContrato";
            this.txt_numeroContrato.Size = new System.Drawing.Size(100, 20);
            this.txt_numeroContrato.TabIndex = 34;
            this.txt_numeroContrato.Visible = false;
            // 
            // cbx_vigente
            // 
            this.cbx_vigente.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbx_vigente.FormattingEnabled = true;
            this.cbx_vigente.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbx_vigente.Location = new System.Drawing.Point(132, 217);
            this.cbx_vigente.Name = "cbx_vigente";
            this.cbx_vigente.Size = new System.Drawing.Size(121, 21);
            this.cbx_vigente.TabIndex = 33;
            // 
            // btn_limpiarCC
            // 
            this.btn_limpiarCC.Location = new System.Drawing.Point(364, 80);
            this.btn_limpiarCC.Name = "btn_limpiarCC";
            this.btn_limpiarCC.Size = new System.Drawing.Size(78, 27);
            this.btn_limpiarCC.TabIndex = 32;
            this.btn_limpiarCC.Text = "Limpiar";
            this.btn_limpiarCC.UseVisualStyleBackColor = true;
            this.btn_limpiarCC.Click += new System.EventHandler(this.btn_limpiarCC_Click);
            // 
            // txt_razonCliente
            // 
            this.txt_razonCliente.Location = new System.Drawing.Point(132, 58);
            this.txt_razonCliente.Name = "txt_razonCliente";
            this.txt_razonCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_razonCliente.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Razon Cliente";
            // 
            // txt_rutCliente
            // 
            this.txt_rutCliente.Location = new System.Drawing.Point(132, 29);
            this.txt_rutCliente.Name = "txt_rutCliente";
            this.txt_rutCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_rutCliente.TabIndex = 27;
            this.txt_rutCliente.TextChanged += new System.EventHandler(this.txt_rutCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Rut Cliente";
            // 
            // dtp_horaTerm
            // 
            this.dtp_horaTerm.CustomFormat = "HH:mm";
            this.dtp_horaTerm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_horaTerm.Location = new System.Drawing.Point(130, 165);
            this.dtp_horaTerm.Name = "dtp_horaTerm";
            this.dtp_horaTerm.ShowUpDown = true;
            this.dtp_horaTerm.Size = new System.Drawing.Size(149, 20);
            this.dtp_horaTerm.TabIndex = 25;
            // 
            // dtp_horaIni
            // 
            this.dtp_horaIni.CustomFormat = "HH:mm";
            this.dtp_horaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_horaIni.Location = new System.Drawing.Point(132, 139);
            this.dtp_horaIni.Name = "dtp_horaIni";
            this.dtp_horaIni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_horaIni.ShowUpDown = true;
            this.dtp_horaIni.Size = new System.Drawing.Size(147, 20);
            this.dtp_horaIni.TabIndex = 24;
            this.dtp_horaIni.ValueChanged += new System.EventHandler(this.dtp_horaIni_ValueChanged);
            // 
            // dtp_termino
            // 
            this.dtp_termino.Location = new System.Drawing.Point(132, 113);
            this.dtp_termino.Name = "dtp_termino";
            this.dtp_termino.Size = new System.Drawing.Size(194, 20);
            this.dtp_termino.TabIndex = 23;
            // 
            // dtp_creacion
            // 
            this.dtp_creacion.Location = new System.Drawing.Point(132, 87);
            this.dtp_creacion.Name = "dtp_creacion";
            this.dtp_creacion.Size = new System.Drawing.Size(194, 20);
            this.dtp_creacion.TabIndex = 22;
            this.dtp_creacion.Value = new System.DateTime(2020, 4, 30, 21, 6, 27, 0);
            // 
            // txt_asistentes
            // 
            this.txt_asistentes.Location = new System.Drawing.Point(132, 277);
            this.txt_asistentes.Name = "txt_asistentes";
            this.txt_asistentes.Size = new System.Drawing.Size(100, 20);
            this.txt_asistentes.TabIndex = 21;
            this.txt_asistentes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_asistentes_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Observaciones";
            // 
            // btn_buscarCC
            // 
            this.btn_buscarCC.Location = new System.Drawing.Point(364, 22);
            this.btn_buscarCC.Name = "btn_buscarCC";
            this.btn_buscarCC.Size = new System.Drawing.Size(78, 27);
            this.btn_buscarCC.TabIndex = 18;
            this.btn_buscarCC.Text = "Buscar";
            this.btn_buscarCC.UseVisualStyleBackColor = true;
            this.btn_buscarCC.Click += new System.EventHandler(this.btn_buscarCC_Click);
            // 
            // btn_regContrato
            // 
            this.btn_regContrato.Location = new System.Drawing.Point(364, 132);
            this.btn_regContrato.Name = "btn_regContrato";
            this.btn_regContrato.Size = new System.Drawing.Size(93, 53);
            this.btn_regContrato.TabIndex = 17;
            this.btn_regContrato.Text = "Registrar Contrato";
            this.btn_regContrato.UseVisualStyleBackColor = true;
            this.btn_regContrato.Click += new System.EventHandler(this.btn_regContrato_Click);
            // 
            // cbx_tipoContrato
            // 
            this.cbx_tipoContrato.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbx_tipoContrato.FormattingEnabled = true;
            this.cbx_tipoContrato.Items.AddRange(new object[] {
            "Matrimonio",
            "Bautizo",
            "Cumpleaños",
            "Aniversario"});
            this.cbx_tipoContrato.Location = new System.Drawing.Point(132, 250);
            this.cbx_tipoContrato.Name = "cbx_tipoContrato";
            this.cbx_tipoContrato.Size = new System.Drawing.Size(121, 21);
            this.cbx_tipoContrato.TabIndex = 15;
            // 
            // txt_direccionContrato
            // 
            this.txt_direccionContrato.Location = new System.Drawing.Point(132, 191);
            this.txt_direccionContrato.Name = "txt_direccionContrato";
            this.txt_direccionContrato.Size = new System.Drawing.Size(100, 20);
            this.txt_direccionContrato.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vigente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha/Hora Termino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha/Hora Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Termino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Creacion";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(48, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 451);
            this.tabControl1.TabIndex = 1;
            // 
            // FrmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmContrato";
            this.Text = "FrmContrato";
            this.Load += new System.EventHandler(this.FrmContrato_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage2;
        private Label label23;
        private TextBox txt_buscacon;
        private Button btn_limpiarC;
        private GroupBox groupBox2;
        private ComboBox cbx_buscavig;
        private TextBox txt_buscarz;
        private Label label12;
        private TextBox txt_buscamonto;
        private Label label13;
        private TextBox txt_buscarut;
        private Label label14;
        private DateTimePicker dtp_buscahorafin;
        private DateTimePicker dtp_buscahoraini;
        private DateTimePicker dtp_buscatermino;
        private DateTimePicker dtp_buscacreacion;
        private TextBox txt_buscaobs;
        private Label label15;
        private ComboBox cbx_buscatipo;
        private TextBox txt_buscadir;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Button button2;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private ComboBox cbx_vigente;
        private Button btn_limpiarCC;
        private TextBox txt_razonCliente;
        private Label label11;
        private TextBox txt_rutCliente;
        private Label label1;
        private DateTimePicker dtp_horaTerm;
        private DateTimePicker dtp_horaIni;
        private DateTimePicker dtp_termino;
        private DateTimePicker dtp_creacion;
        private TextBox txt_asistentes;
        private Label label9;
        private Button btn_buscarCC;
        private Button btn_regContrato;
        private ComboBox cbx_tipoContrato;
        private TextBox txt_direccionContrato;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabControl tabControl1;
        private TextBox txt_numeroContrato;
        private Button btn_buscListCon;
        private TextBox txt_participantes;
        private TextBox txt_observaciones;
        private Label label24;
        private TextBox txt_buscaparti;
        private TextBox txt_buscaasis;
        private Label label27;
        private Label label26;
        private Label label25;
    }
}