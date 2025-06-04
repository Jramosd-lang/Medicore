namespace VISUAL
{
    partial class FormularioGestionPaciente
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
            LblDocumento = new Label();
            LblPrimerNombre = new Label();
            LblSegundoNombre = new Label();
            LblPrimerApellido = new Label();
            LblSegundoApellido = new Label();
            txtNumDoc = new TextBox();
            txtSegundoApellido = new TextBox();
            txtPrimerApellido = new TextBox();
            txtSegundoNombre = new TextBox();
            txtPrimerNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCorreo = new TextBox();
            LblCorreoElectronico = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ComboBoxTipoDoc = new ComboBox();
            label7 = new Label();
            GroupBoxDocumento = new GroupBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            label12 = new Label();
            ComboBoxSexo = new ComboBox();
            dateNacimiento = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label15 = new Label();
            lblParentesco = new Label();
            ComboBoxReligion = new ComboBox();
            txtOcupacion = new TextBox();
            label14 = new Label();
            label13 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            button5 = new Button();
            txtVacunas = new TextBox();
            label21 = new Label();
            button4 = new Button();
            txtAntecedentesFamiliares = new TextBox();
            label20 = new Label();
            button3 = new Button();
            txtMedicamentosActuales = new TextBox();
            label19 = new Label();
            button2 = new Button();
            txtEnfermedadesCronicas = new TextBox();
            label18 = new Label();
            button1 = new Button();
            txtAlergias = new TextBox();
            label17 = new Label();
            label16 = new Label();
            comboBox1 = new ComboBox();
            BotonModificar = new Button();
            BotonAgregar = new Button();
            GroupBoxDocumento.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LblDocumento
            // 
            LblDocumento.AutoSize = true;
            LblDocumento.Location = new Point(501, 53);
            LblDocumento.Name = "LblDocumento";
            LblDocumento.Size = new Size(164, 20);
            LblDocumento.TabIndex = 0;
            LblDocumento.Text = "Numero de documento";
            // 
            // LblPrimerNombre
            // 
            LblPrimerNombre.AutoSize = true;
            LblPrimerNombre.Location = new Point(17, 37);
            LblPrimerNombre.Name = "LblPrimerNombre";
            LblPrimerNombre.Size = new Size(108, 20);
            LblPrimerNombre.TabIndex = 1;
            LblPrimerNombre.Text = "Primer nombre";
            // 
            // LblSegundoNombre
            // 
            LblSegundoNombre.AutoSize = true;
            LblSegundoNombre.Font = new Font("Segoe UI", 9F);
            LblSegundoNombre.Location = new Point(17, 81);
            LblSegundoNombre.Name = "LblSegundoNombre";
            LblSegundoNombre.Size = new Size(124, 20);
            LblSegundoNombre.TabIndex = 2;
            LblSegundoNombre.Text = "Segundo nombre";
            // 
            // LblPrimerApellido
            // 
            LblPrimerApellido.AutoSize = true;
            LblPrimerApellido.Location = new Point(501, 37);
            LblPrimerApellido.Name = "LblPrimerApellido";
            LblPrimerApellido.Size = new Size(111, 20);
            LblPrimerApellido.TabIndex = 3;
            LblPrimerApellido.Text = "Primer apellido";
            // 
            // LblSegundoApellido
            // 
            LblSegundoApellido.AutoSize = true;
            LblSegundoApellido.Location = new Point(501, 81);
            LblSegundoApellido.Name = "LblSegundoApellido";
            LblSegundoApellido.Size = new Size(127, 20);
            LblSegundoApellido.TabIndex = 4;
            LblSegundoApellido.Text = "Segundo apellido";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(690, 47);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(157, 27);
            txtNumDoc.TabIndex = 5;
            txtNumDoc.KeyPress += txtNumDoc_KeyPress;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(690, 75);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(157, 27);
            txtSegundoApellido.TabIndex = 6;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(690, 31);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(157, 27);
            txtPrimerApellido.TabIndex = 7;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(203, 75);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(268, 27);
            txtSegundoNombre.TabIndex = 8;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(203, 31);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(268, 27);
            txtPrimerNombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(79, 127, 140);
            label1.Location = new Point(658, 53);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 10;
            label1.Text = "(*)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(79, 127, 140);
            label2.Location = new Point(119, 37);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 11;
            label2.Text = "(*)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(79, 127, 140);
            label3.Location = new Point(658, 41);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 12;
            label3.Text = "(*)";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(203, 27);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(268, 27);
            txtCorreo.TabIndex = 14;
            // 
            // LblCorreoElectronico
            // 
            LblCorreoElectronico.AutoSize = true;
            LblCorreoElectronico.Location = new Point(17, 33);
            LblCorreoElectronico.Name = "LblCorreoElectronico";
            LblCorreoElectronico.Size = new Size(132, 20);
            LblCorreoElectronico.TabIndex = 13;
            LblCorreoElectronico.Text = "Correo Electronico";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(690, 27);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(157, 27);
            txtTelefono.TabIndex = 16;
            txtTelefono.KeyPress += txtNumDoc_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 33);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 15;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(79, 127, 140);
            label5.Location = new Point(155, 33);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 17;
            label5.Text = "(*)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(79, 127, 140);
            label6.Location = new Point(658, 37);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 18;
            label6.Text = "(*)";
            // 
            // ComboBoxTipoDoc
            // 
            ComboBoxTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTipoDoc.FormattingEnabled = true;
            ComboBoxTipoDoc.Items.AddRange(new object[] { "- elija una opcion -", "CC", "TI", "RC", "CE", "PP", "DNI", "NUIP" });
            ComboBoxTipoDoc.Location = new Point(203, 51);
            ComboBoxTipoDoc.Name = "ComboBoxTipoDoc";
            ComboBoxTipoDoc.Size = new Size(268, 28);
            ComboBoxTipoDoc.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 51);
            label7.Name = "label7";
            label7.Size = new Size(140, 20);
            label7.TabIndex = 20;
            label7.Text = "Tipo de documento";
            // 
            // GroupBoxDocumento
            // 
            GroupBoxDocumento.Controls.Add(LblDocumento);
            GroupBoxDocumento.Controls.Add(label10);
            GroupBoxDocumento.Controls.Add(label7);
            GroupBoxDocumento.Controls.Add(ComboBoxTipoDoc);
            GroupBoxDocumento.Controls.Add(label1);
            GroupBoxDocumento.Controls.Add(txtNumDoc);
            GroupBoxDocumento.Dock = DockStyle.Top;
            GroupBoxDocumento.Location = new Point(0, 0);
            GroupBoxDocumento.Name = "GroupBoxDocumento";
            GroupBoxDocumento.Size = new Size(1250, 99);
            GroupBoxDocumento.TabIndex = 21;
            GroupBoxDocumento.TabStop = false;
            GroupBoxDocumento.Text = "Documento de identidad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(79, 127, 140);
            label10.Location = new Point(163, 51);
            label10.Name = "label10";
            label10.Size = new Size(25, 20);
            label10.TabIndex = 16;
            label10.Text = "(*)";
            label10.Click += label10_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(ComboBoxSexo);
            groupBox2.Controls.Add(dateNacimiento);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtPrimerNombre);
            groupBox2.Controls.Add(txtSegundoNombre);
            groupBox2.Controls.Add(txtPrimerApellido);
            groupBox2.Controls.Add(txtSegundoApellido);
            groupBox2.Controls.Add(LblSegundoApellido);
            groupBox2.Controls.Add(LblPrimerApellido);
            groupBox2.Controls.Add(LblSegundoNombre);
            groupBox2.Controls.Add(LblPrimerNombre);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1250, 229);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos generales";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(79, 127, 140);
            label11.Location = new Point(53, 179);
            label11.Name = "label11";
            label11.Size = new Size(25, 20);
            label11.TabIndex = 26;
            label11.Text = "(*)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 179);
            label12.Name = "label12";
            label12.Size = new Size(41, 20);
            label12.TabIndex = 28;
            label12.Text = "Sexo";
            // 
            // ComboBoxSexo
            // 
            ComboBoxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSexo.FormattingEnabled = true;
            ComboBoxSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            ComboBoxSexo.Location = new Point(203, 171);
            ComboBoxSexo.Name = "ComboBoxSexo";
            ComboBoxSexo.Size = new Size(268, 28);
            ComboBoxSexo.TabIndex = 27;
            ComboBoxSexo.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dateNacimiento
            // 
            dateNacimiento.Location = new Point(203, 127);
            dateNacimiento.Name = "dateNacimiento";
            dateNacimiento.Size = new Size(268, 27);
            dateNacimiento.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(79, 127, 140);
            label9.Location = new Point(160, 127);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 15;
            label9.Text = "(*)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 127);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 13;
            label8.Text = "Fecha de nacimiento";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtTelefono);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtCorreo);
            groupBox3.Controls.Add(LblCorreoElectronico);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 328);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1250, 260);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos de contacto";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(lblParentesco);
            groupBox4.Controls.Add(ComboBoxReligion);
            groupBox4.Controls.Add(txtOcupacion);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Location = new Point(17, 85);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1233, 141);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos extras";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.FromArgb(79, 127, 140);
            label15.Location = new Point(121, 92);
            label15.Name = "label15";
            label15.Size = new Size(25, 20);
            label15.TabIndex = 29;
            label15.Text = "(*)";
            // 
            // lblParentesco
            // 
            lblParentesco.AutoSize = true;
            lblParentesco.Location = new Point(37, 92);
            lblParentesco.Name = "lblParentesco";
            lblParentesco.Size = new Size(64, 20);
            lblParentesco.TabIndex = 31;
            lblParentesco.Text = "Religion";
            // 
            // ComboBoxReligion
            // 
            ComboBoxReligion.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxReligion.FormattingEnabled = true;
            ComboBoxReligion.Items.AddRange(new object[] { "Catolicismo", "Cristianismo", "Cristianismo Evangélico", "Cristianismo Protestante", "Protestante", "Testigos de Jehová", "Judaísmo", "Islam", "Hinduismo", "Budismo", "No especifico" });
            ComboBoxReligion.Location = new Point(186, 88);
            ComboBoxReligion.Name = "ComboBoxReligion";
            ComboBoxReligion.Size = new Size(268, 28);
            ComboBoxReligion.TabIndex = 30;
            // 
            // txtOcupacion
            // 
            txtOcupacion.Location = new Point(186, 44);
            txtOcupacion.Name = "txtOcupacion";
            txtOcupacion.Size = new Size(268, 27);
            txtOcupacion.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(79, 127, 140);
            label14.Location = new Point(121, 48);
            label14.Name = "label14";
            label14.Size = new Size(25, 20);
            label14.TabIndex = 18;
            label14.Text = "(*)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(37, 48);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 0;
            label13.Text = "Ocupacion";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(BotonModificar);
            panel1.Controls.Add(BotonAgregar);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(GroupBoxDocumento);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1250, 1174);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(txtVacunas);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(txtAntecedentesFamiliares);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txtMedicamentosActuales);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtEnfermedadesCronicas);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtAlergias);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 588);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1250, 255);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historial Medico";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(45, 91, 103);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(165, 197, 213);
            button5.Location = new Point(1008, 173);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(34, 32);
            button5.TabIndex = 53;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = false;
            // 
            // txtVacunas
            // 
            txtVacunas.Location = new Point(745, 173);
            txtVacunas.Margin = new Padding(3, 4, 3, 4);
            txtVacunas.Name = "txtVacunas";
            txtVacunas.Size = new Size(226, 27);
            txtVacunas.TabIndex = 52;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(667, 173);
            label21.Name = "label21";
            label21.Size = new Size(62, 20);
            label21.TabIndex = 51;
            label21.Text = "Vacunas";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(45, 91, 103);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(165, 197, 213);
            button4.Location = new Point(619, 169);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(34, 31);
            button4.TabIndex = 50;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // txtAntecedentesFamiliares
            // 
            txtAntecedentesFamiliares.Location = new Point(289, 169);
            txtAntecedentesFamiliares.Margin = new Padding(3, 4, 3, 4);
            txtAntecedentesFamiliares.Name = "txtAntecedentesFamiliares";
            txtAntecedentesFamiliares.Size = new Size(300, 27);
            txtAntecedentesFamiliares.TabIndex = 49;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(61, 179);
            label20.Name = "label20";
            label20.Size = new Size(168, 20);
            label20.TabIndex = 48;
            label20.Text = "Antecedentes familiares";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(45, 91, 103);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(165, 197, 213);
            button3.Location = new Point(976, 101);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(34, 33);
            button3.TabIndex = 47;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtMedicamentosActuales
            // 
            txtMedicamentosActuales.Location = new Point(718, 101);
            txtMedicamentosActuales.Margin = new Padding(3, 4, 3, 4);
            txtMedicamentosActuales.Name = "txtMedicamentosActuales";
            txtMedicamentosActuales.Size = new Size(226, 27);
            txtMedicamentosActuales.TabIndex = 46;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(518, 97);
            label19.Name = "label19";
            label19.Size = new Size(165, 20);
            label19.TabIndex = 45;
            label19.Text = "Medicamentos actuales";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(45, 91, 103);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(165, 197, 213);
            button2.Location = new Point(1043, 39);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(34, 39);
            button2.TabIndex = 44;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtEnfermedadesCronicas
            // 
            txtEnfermedadesCronicas.Location = new Point(718, 41);
            txtEnfermedadesCronicas.Margin = new Padding(3, 4, 3, 4);
            txtEnfermedadesCronicas.Name = "txtEnfermedadesCronicas";
            txtEnfermedadesCronicas.Size = new Size(287, 27);
            txtEnfermedadesCronicas.TabIndex = 43;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(518, 45);
            label18.Name = "label18";
            label18.Size = new Size(164, 20);
            label18.TabIndex = 42;
            label18.Text = "Enfermedades Cronicas";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(45, 91, 103);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(165, 197, 213);
            button1.Location = new Point(415, 99);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(34, 29);
            button1.TabIndex = 41;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(208, 97);
            txtAlergias.Margin = new Padding(3, 4, 3, 4);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(172, 27);
            txtAlergias.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(63, 101);
            label17.Name = "label17";
            label17.Size = new Size(63, 20);
            label17.TabIndex = 2;
            label17.Text = "Alergias";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(61, 39);
            label16.Name = "label16";
            label16.Size = new Size(108, 20);
            label16.TabIndex = 1;
            label16.Text = "Tipo de sangre";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "A +", "", "A –", "", "B +", "", "B –", "", "AB +", "", "AB –", "", "O +", "", "O –" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(208, 35);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 28);
            comboBox1.TabIndex = 0;
            // 
            // BotonModificar
            // 
            BotonModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonModificar.BackColor = Color.FromArgb(45, 91, 103);
            BotonModificar.FlatAppearance.BorderSize = 0;
            BotonModificar.FlatStyle = FlatStyle.Flat;
            BotonModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonModificar.ForeColor = Color.FromArgb(165, 197, 213);
            BotonModificar.Location = new Point(864, 967);
            BotonModificar.Margin = new Padding(0);
            BotonModificar.Name = "BotonModificar";
            BotonModificar.Size = new Size(191, 45);
            BotonModificar.TabIndex = 39;
            BotonModificar.Text = "+ modificar paciente";
            BotonModificar.UseVisualStyleBackColor = false;
            BotonModificar.Click += BotonModificar_Click;
            // 
            // BotonAgregar
            // 
            BotonAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonAgregar.BackColor = Color.FromArgb(45, 91, 103);
            BotonAgregar.FlatAppearance.BorderSize = 0;
            BotonAgregar.FlatStyle = FlatStyle.Flat;
            BotonAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonAgregar.ForeColor = Color.FromArgb(165, 197, 213);
            BotonAgregar.Location = new Point(875, 903);
            BotonAgregar.Margin = new Padding(0);
            BotonAgregar.Name = "BotonAgregar";
            BotonAgregar.Size = new Size(167, 35);
            BotonAgregar.TabIndex = 26;
            BotonAgregar.Text = "+ Registrar";
            BotonAgregar.UseVisualStyleBackColor = false;
            BotonAgregar.Click += BotonAgregar_Click;
            // 
            // FormularioGestionPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 1174);
            Controls.Add(panel1);
            Name = "FormularioGestionPaciente";
            Text = "Registro de Pacientes";
            Load += Form2_Load;
            GroupBoxDocumento.ResumeLayout(false);
            GroupBoxDocumento.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LblDocumento;
        private Label LblPrimerNombre;
        private Label LblSegundoNombre;
        private Label LblPrimerApellido;
        private Label LblSegundoApellido;
        private TextBox txtNumDoc;
        private TextBox txtSegundoApellido;
        private TextBox txtPrimerApellido;
        private TextBox txtSegundoNombre;
        private TextBox txtPrimerNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCorreo;
        private Label LblCorreoElectronico;
        private TextBox txtTelefono;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox ComboBoxTipoDoc;
        private Label label7;
        private GroupBox GroupBoxDocumento;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Panel panel1;
        private Label label10;
        private DateTimePicker dateNacimiento;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label12;
        private ComboBox ComboBoxSexo;
        private GroupBox groupBox4;
        private TextBox txtOcupacion;
        private Label label14;
        private Label label13;
        private Label label15;
        private Label lblParentesco;
        private ComboBox ComboBoxReligion;
        private Button BotonAgregar;
        private Button BotonModificar1;
        private Button BotonModificar;
        private GroupBox groupBox1;
        private Label label17;
        private Label label16;
        private ComboBox comboBox1;
        private TextBox txtEnfermedadesCronicas;
        private Label label18;
        private Button button1;
        private TextBox txtAlergias;
        private Button button3;
        private TextBox txtMedicamentosActuales;
        private Label label19;
        private Button button2;
        private TextBox txtVacunas;
        private Label label21;
        private Button button4;
        private TextBox txtAntecedentesFamiliares;
        private Label label20;
        private Button button5;
    }
}