namespace WindowsFormsApp1
{
    partial class FrmCliente
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
        /// 

        
        
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_regCliente = new System.Windows.Forms.Button();
            this.cbx_actividad = new System.Windows.Forms.ComboBox();
            this.cbx_tipoCliente = new System.Windows.Forms.ComboBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_direccionCliente = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_razonSocial = new System.Windows.Forms.TextBox();
            this.txt_rut = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_raz = new System.Windows.Forms.GroupBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbx_actividadB = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbx_tipoB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_telefonoB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_direccionCB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_mailB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nombreB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_razonSocialB = new System.Windows.Forms.TextBox();
            this.txt_rutB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.data_clientes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_rutBusc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_busc = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_listarb = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.txt_raz.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_clientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(50, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.btn_regCliente);
            this.groupBox1.Controls.Add(this.cbx_actividad);
            this.groupBox1.Controls.Add(this.cbx_tipoCliente);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.txt_direccionCliente);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_razonSocial);
            this.groupBox1.Controls.Add(this.txt_rut);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(236, 13);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(78, 27);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_regCliente
            // 
            this.btn_regCliente.Location = new System.Drawing.Point(290, 176);
            this.btn_regCliente.Name = "btn_regCliente";
            this.btn_regCliente.Size = new System.Drawing.Size(93, 53);
            this.btn_regCliente.TabIndex = 17;
            this.btn_regCliente.Text = "Registrar Cliente";
            this.btn_regCliente.UseVisualStyleBackColor = true;
            this.btn_regCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_actividad
            // 
            this.cbx_actividad.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbx_actividad.FormattingEnabled = true;
            this.cbx_actividad.Items.AddRange(new object[] {
            "Agropecuaria",
            "Minería",
            "Manufactura",
            "Comercio",
            "Hoteleria",
            "Alimentos",
            "Transporte",
            "Servicios"});
            this.cbx_actividad.Location = new System.Drawing.Point(105, 176);
            this.cbx_actividad.Name = "cbx_actividad";
            this.cbx_actividad.Size = new System.Drawing.Size(121, 21);
            this.cbx_actividad.TabIndex = 16;
            this.cbx_actividad.SelectedIndexChanged += new System.EventHandler(this.cbx_actividad_SelectedIndexChanged);
            // 
            // cbx_tipoCliente
            // 
            this.cbx_tipoCliente.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbx_tipoCliente.FormattingEnabled = true;
            this.cbx_tipoCliente.Items.AddRange(new object[] {
            "SPA",
            "EIRL",
            "Limitada",
            "Sociedad Anónima"});
            this.cbx_tipoCliente.Location = new System.Drawing.Point(105, 209);
            this.cbx_tipoCliente.Name = "cbx_tipoCliente";
            this.cbx_tipoCliente.Size = new System.Drawing.Size(121, 21);
            this.cbx_tipoCliente.TabIndex = 15;
            this.cbx_tipoCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(105, 150);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 13;
            // 
            // txt_direccionCliente
            // 
            this.txt_direccionCliente.Location = new System.Drawing.Point(105, 121);
            this.txt_direccionCliente.Name = "txt_direccionCliente";
            this.txt_direccionCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_direccionCliente.TabIndex = 12;
            this.txt_direccionCliente.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(105, 95);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 11;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(105, 69);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 10;
            // 
            // txt_razonSocial
            // 
            this.txt_razonSocial.Location = new System.Drawing.Point(105, 43);
            this.txt_razonSocial.Name = "txt_razonSocial";
            this.txt_razonSocial.Size = new System.Drawing.Size(100, 20);
            this.txt_razonSocial.TabIndex = 9;
            // 
            // txt_rut
            // 
            this.txt_rut.Location = new System.Drawing.Point(105, 17);
            this.txt_rut.Name = "txt_rut";
            this.txt_rut.Size = new System.Drawing.Size(100, 20);
            this.txt_rut.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Actividad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razón Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_raz);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_raz
            // 
            this.txt_raz.Controls.Add(this.btn_del);
            this.txt_raz.Controls.Add(this.btn_mod);
            this.txt_raz.Controls.Add(this.label16);
            this.txt_raz.Controls.Add(this.label15);
            this.txt_raz.Controls.Add(this.cbx_actividadB);
            this.txt_raz.Controls.Add(this.label14);
            this.txt_raz.Controls.Add(this.cbx_tipoB);
            this.txt_raz.Controls.Add(this.label13);
            this.txt_raz.Controls.Add(this.txt_telefonoB);
            this.txt_raz.Controls.Add(this.label12);
            this.txt_raz.Controls.Add(this.txt_direccionCB);
            this.txt_raz.Controls.Add(this.label11);
            this.txt_raz.Controls.Add(this.txt_mailB);
            this.txt_raz.Controls.Add(this.label10);
            this.txt_raz.Controls.Add(this.txt_nombreB);
            this.txt_raz.Controls.Add(this.label9);
            this.txt_raz.Controls.Add(this.txt_razonSocialB);
            this.txt_raz.Controls.Add(this.txt_rutB);
            this.txt_raz.Location = new System.Drawing.Point(20, 137);
            this.txt_raz.Name = "txt_raz";
            this.txt_raz.Size = new System.Drawing.Size(326, 245);
            this.txt_raz.TabIndex = 1;
            this.txt_raz.TabStop = false;
            this.txt_raz.Text = "Información";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(227, 61);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(78, 27);
            this.btn_del.TabIndex = 38;
            this.btn_del.Text = "Eliminar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(227, 19);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(78, 27);
            this.btn_mod.TabIndex = 37;
            this.btn_mod.Text = "Modificar";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Rut";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Razón Social";
            // 
            // cbx_actividadB
            // 
            this.cbx_actividadB.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbx_actividadB.FormattingEnabled = true;
            this.cbx_actividadB.Items.AddRange(new object[] {
            "Agropecuaria",
            "Minería",
            "Manufactura",
            "Comercio",
            "Hoteleria",
            "Alimentos",
            "Transporte",
            "Servicios"});
            this.cbx_actividadB.Location = new System.Drawing.Point(93, 172);
            this.cbx_actividadB.Name = "cbx_actividadB";
            this.cbx_actividadB.Size = new System.Drawing.Size(121, 21);
            this.cbx_actividadB.TabIndex = 34;
            this.cbx_actividadB.SelectedIndexChanged += new System.EventHandler(this.cbx_actividadB_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Nombre";
            // 
            // cbx_tipoB
            // 
            this.cbx_tipoB.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbx_tipoB.FormattingEnabled = true;
            this.cbx_tipoB.Items.AddRange(new object[] {
            "SPA",
            "EIRL",
            "Limitada",
            "Sociedad Anónima"});
            this.cbx_tipoB.Location = new System.Drawing.Point(93, 205);
            this.cbx_tipoB.Name = "cbx_tipoB";
            this.cbx_tipoB.Size = new System.Drawing.Size(121, 21);
            this.cbx_tipoB.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Mail";
            // 
            // txt_telefonoB
            // 
            this.txt_telefonoB.Location = new System.Drawing.Point(93, 146);
            this.txt_telefonoB.Name = "txt_telefonoB";
            this.txt_telefonoB.Size = new System.Drawing.Size(100, 20);
            this.txt_telefonoB.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Direccion";
            // 
            // txt_direccionCB
            // 
            this.txt_direccionCB.Location = new System.Drawing.Point(93, 117);
            this.txt_direccionCB.Name = "txt_direccionCB";
            this.txt_direccionCB.Size = new System.Drawing.Size(100, 20);
            this.txt_direccionCB.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Teléfono";
            // 
            // txt_mailB
            // 
            this.txt_mailB.Location = new System.Drawing.Point(93, 91);
            this.txt_mailB.Name = "txt_mailB";
            this.txt_mailB.Size = new System.Drawing.Size(100, 20);
            this.txt_mailB.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Actividad";
            // 
            // txt_nombreB
            // 
            this.txt_nombreB.Location = new System.Drawing.Point(93, 65);
            this.txt_nombreB.Name = "txt_nombreB";
            this.txt_nombreB.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreB.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tipo";
            // 
            // txt_razonSocialB
            // 
            this.txt_razonSocialB.Location = new System.Drawing.Point(93, 39);
            this.txt_razonSocialB.Name = "txt_razonSocialB";
            this.txt_razonSocialB.Size = new System.Drawing.Size(100, 20);
            this.txt_razonSocialB.TabIndex = 28;
            // 
            // txt_rutB
            // 
            this.txt_rutB.Enabled = false;
            this.txt_rutB.Location = new System.Drawing.Point(93, 13);
            this.txt_rutB.Name = "txt_rutB";
            this.txt_rutB.Size = new System.Drawing.Size(100, 20);
            this.txt_rutB.TabIndex = 27;
            this.txt_rutB.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_listarb);
            this.groupBox3.Controls.Add(this.data_clientes);
            this.groupBox3.Location = new System.Drawing.Point(352, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 363);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Clientes";
            // 
            // data_clientes
            // 
            this.data_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_clientes.Location = new System.Drawing.Point(7, 64);
            this.data_clientes.Name = "data_clientes";
            this.data_clientes.Size = new System.Drawing.Size(326, 293);
            this.data_clientes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_rutBusc);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btn_busc);
            this.groupBox2.Location = new System.Drawing.Point(20, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 112);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // txt_rutBusc
            // 
            this.txt_rutBusc.Location = new System.Drawing.Point(71, 24);
            this.txt_rutBusc.Name = "txt_rutBusc";
            this.txt_rutBusc.Size = new System.Drawing.Size(100, 20);
            this.txt_rutBusc.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Rut";
            // 
            // btn_busc
            // 
            this.btn_busc.Location = new System.Drawing.Point(71, 64);
            this.btn_busc.Name = "btn_busc";
            this.btn_busc.Size = new System.Drawing.Size(78, 27);
            this.btn_busc.TabIndex = 36;
            this.btn_busc.Text = "Buscar";
            this.btn_busc.UseVisualStyleBackColor = true;
            this.btn_busc.Click += new System.EventHandler(this.btn_busc_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(710, 388);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Actualizar Cliente";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(710, 388);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar Cliente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(710, 388);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Listado Clientes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_listarb
            // 
            this.btn_listarb.Location = new System.Drawing.Point(101, 19);
            this.btn_listarb.Name = "btn_listarb";
            this.btn_listarb.Size = new System.Drawing.Size(135, 27);
            this.btn_listarb.TabIndex = 37;
            this.btn_listarb.Text = "Listar Clientes";
            this.btn_listarb.UseVisualStyleBackColor = true;
            this.btn_listarb.Click += new System.EventHandler(this.btn_listarb_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 490);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.txt_raz.ResumeLayout(false);
            this.txt_raz.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_clientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_direccionCliente;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_razonSocial;
        private System.Windows.Forms.TextBox txt_rut;
        private System.Windows.Forms.ComboBox cbx_tipoCliente;
        private System.Windows.Forms.ComboBox cbx_actividad;
        private System.Windows.Forms.Button btn_regCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox txt_raz;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbx_tipoB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_telefonoB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_direccionCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_mailB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nombreB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_razonSocialB;
        private System.Windows.Forms.TextBox txt_rutB;
        private System.Windows.Forms.TextBox txt_rutBusc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_busc;
        private System.Windows.Forms.DataGridView data_clientes;
        private System.Windows.Forms.ComboBox cbx_actividadB;
        private System.Windows.Forms.Button btn_listarb;
    }
    
}