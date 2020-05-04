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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_limpiarCC = new System.Windows.Forms.Button();
            this.txt_razonCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_rutCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_horaTerm = new System.Windows.Forms.DateTimePicker();
            this.dtp_horaIni = new System.Windows.Forms.DateTimePicker();
            this.dtp_termino = new System.Windows.Forms.DateTimePicker();
            this.dtp_creacion = new System.Windows.Forms.DateTimePicker();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.txt_vigente = new System.Windows.Forms.TextBox();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.btn_limpiarC = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(48, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 390);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Contrato";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_limpiarCC);
            this.groupBox1.Controls.Add(this.txt_razonCliente);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_monto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_rutCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_horaTerm);
            this.groupBox1.Controls.Add(this.dtp_horaIni);
            this.groupBox1.Controls.Add(this.dtp_termino);
            this.groupBox1.Controls.Add(this.dtp_creacion);
            this.groupBox1.Controls.Add(this.txt_observaciones);
            this.groupBox1.Controls.Add(this.txt_vigente);
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
            this.groupBox1.Size = new System.Drawing.Size(417, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Contrato";
            // 
            // btn_limpiarCC
            // 
            this.btn_limpiarCC.Location = new System.Drawing.Point(318, 73);
            this.btn_limpiarCC.Name = "btn_limpiarCC";
            this.btn_limpiarCC.Size = new System.Drawing.Size(78, 27);
            this.btn_limpiarCC.TabIndex = 32;
            this.btn_limpiarCC.Text = "Limpiar";
            this.btn_limpiarCC.UseVisualStyleBackColor = true;
            // 
            // txt_razonCliente
            // 
            this.txt_razonCliente.Enabled = false;
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
            // txt_monto
            // 
            this.txt_monto.Enabled = false;
            this.txt_monto.Location = new System.Drawing.Point(132, 311);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(100, 20);
            this.txt_monto.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Monto";
            // 
            // txt_rutCliente
            // 
            this.txt_rutCliente.Enabled = false;
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
            this.dtp_termino.Size = new System.Drawing.Size(147, 20);
            this.dtp_termino.TabIndex = 23;
            // 
            // dtp_creacion
            // 
            this.dtp_creacion.Location = new System.Drawing.Point(132, 87);
            this.dtp_creacion.Name = "dtp_creacion";
            this.dtp_creacion.Size = new System.Drawing.Size(147, 20);
            this.dtp_creacion.TabIndex = 22;
            this.dtp_creacion.Value = new System.DateTime(2020, 4, 30, 21, 6, 27, 0);
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Enabled = false;
            this.txt_observaciones.Location = new System.Drawing.Point(132, 280);
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(100, 20);
            this.txt_observaciones.TabIndex = 21;
            // 
            // txt_vigente
            // 
            this.txt_vigente.Enabled = false;
            this.txt_vigente.Location = new System.Drawing.Point(132, 217);
            this.txt_vigente.Name = "txt_vigente";
            this.txt_vigente.Size = new System.Drawing.Size(100, 20);
            this.txt_vigente.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Observaciones";
            // 
            // btn_buscarCC
            // 
            this.btn_buscarCC.Location = new System.Drawing.Point(318, 22);
            this.btn_buscarCC.Name = "btn_buscarCC";
            this.btn_buscarCC.Size = new System.Drawing.Size(78, 27);
            this.btn_buscarCC.TabIndex = 18;
            this.btn_buscarCC.Text = "Buscar";
            this.btn_buscarCC.UseVisualStyleBackColor = true;
            // 
            // btn_regContrato
            // 
            this.btn_regContrato.Enabled = false;
            this.btn_regContrato.Location = new System.Drawing.Point(318, 145);
            this.btn_regContrato.Name = "btn_regContrato";
            this.btn_regContrato.Size = new System.Drawing.Size(93, 53);
            this.btn_regContrato.TabIndex = 17;
            this.btn_regContrato.Text = "Registrar Contrato";
            this.btn_regContrato.UseVisualStyleBackColor = true;
            // 
            // cbx_tipoContrato
            // 
            this.cbx_tipoContrato.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbx_tipoContrato.Enabled = false;
            this.cbx_tipoContrato.FormattingEnabled = true;
            this.cbx_tipoContrato.Items.AddRange(new object[] {
            "SPA",
            "EIRL",
            "Limitada",
            "Sociedad Anónima"});
            this.cbx_tipoContrato.Location = new System.Drawing.Point(132, 250);
            this.cbx_tipoContrato.Name = "cbx_tipoContrato";
            this.cbx_tipoContrato.Size = new System.Drawing.Size(121, 21);
            this.cbx_tipoContrato.TabIndex = 15;
            // 
            // txt_direccionContrato
            // 
            this.txt_direccionContrato.Enabled = false;
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
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Esta Vigente?";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar Contrato";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker5);
            this.groupBox2.Controls.Add(this.btn_limpiarC);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.dateTimePicker4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(20, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 341);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Contrato";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(383, 285);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker5.TabIndex = 33;
            // 
            // btn_limpiarC
            // 
            this.btn_limpiarC.Location = new System.Drawing.Point(318, 73);
            this.btn_limpiarC.Name = "btn_limpiarC";
            this.btn_limpiarC.Size = new System.Drawing.Size(78, 27);
            this.btn_limpiarC.TabIndex = 32;
            this.btn_limpiarC.Text = "Limpiar";
            this.btn_limpiarC.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(132, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Razon Cliente";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(132, 311);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Monto";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Rut Cliente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(132, 139);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker2.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Location = new System.Drawing.Point(132, 113);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker3.TabIndex = 23;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Enabled = false;
            this.dateTimePicker4.Location = new System.Drawing.Point(132, 87);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker4.TabIndex = 22;
            this.dateTimePicker4.Value = new System.DateTime(2020, 4, 30, 21, 6, 27, 0);
            this.dateTimePicker4.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(132, 280);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(132, 217);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 283);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Observaciones";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 27);
            this.button2.TabIndex = 18;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(318, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 53);
            this.button3.TabIndex = 17;
            this.button3.Text = "Registrar Contrato";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SPA",
            "EIRL",
            "Limitada",
            "Sociedad Anónima"});
            this.comboBox1.Location = new System.Drawing.Point(132, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(132, 191);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Tipo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 220);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Esta Vigente?";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 194);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Direccion";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 165);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Fecha/Hora Termino";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 139);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Fecha/Hora Inicio";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 113);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Termino";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Creacion";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(673, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Actualizar Contrato";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage4.Size = new System.Drawing.Size(673, 364);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Terminar Contrato";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(673, 364);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Listado Contratos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // FrmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmContrato";
            this.Text = "FrmContrato";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_buscarCC;
        private System.Windows.Forms.Button btn_regContrato;
        private System.Windows.Forms.ComboBox cbx_tipoContrato;
        private System.Windows.Forms.TextBox txt_direccionContrato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.TextBox txt_vigente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_horaTerm;
        private System.Windows.Forms.DateTimePicker dtp_horaIni;
        private System.Windows.Forms.DateTimePicker dtp_termino;
        private System.Windows.Forms.DateTimePicker dtp_creacion;
        private System.Windows.Forms.TextBox txt_rutCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_razonCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_limpiarCC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpiarC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        

    }
}