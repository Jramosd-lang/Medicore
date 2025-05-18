
namespace VISUAL
{
    partial class FormularioGestionDoctores
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
            GroupBoxDocumento = new GroupBox();
            LblDocumento = new Label();
            label10 = new Label();
            label7 = new Label();
            ComboBoxTipoDoc = new ComboBox();
            label1 = new Label();
            txtNumDoc = new TextBox();
            groupBox2 = new GroupBox();
            label11 = new Label();
            label12 = new Label();
            ComboBoxSex = new ComboBox();
            dateNacimiento = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPrimerNombre = new TextBox();
            txtSegundoNombre = new TextBox();
            txtPrimerApellido = new TextBox();
            txtSegundoApellido = new TextBox();
            LblSegundoApellido = new Label();
            LblPrimerApellido = new Label();
            LblSegundoNombre = new Label();
            LblPrimerNombre = new Label();
            groupBox3 = new GroupBox();
            ComboBoxPreTelefono = new ComboBox();
            groupBox4 = new GroupBox();
            ComboBoxPreTelefonoEmergencia = new ComboBox();
            label16 = new Label();
            txtTelefonoEmergencia = new TextBox();
            label17 = new Label();
            label15 = new Label();
            lblParentesco = new Label();
            ComboBoxParentesco = new ComboBox();
            txtNombreEmergencia = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            LblCorreoElectronico = new Label();
            BotonAgregar = new Button();
            label18 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            txtNroLicencia = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label25 = new Label();
            txtEspecialidad = new TextBox();
            label27 = new Label();
            BotonModificar = new Button();
            GroupBoxDocumento.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxDocumento
            // 
            GroupBoxDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GroupBoxDocumento.Controls.Add(LblDocumento);
            GroupBoxDocumento.Controls.Add(label10);
            GroupBoxDocumento.Controls.Add(label7);
            GroupBoxDocumento.Controls.Add(ComboBoxTipoDoc);
            GroupBoxDocumento.Controls.Add(label1);
            GroupBoxDocumento.Controls.Add(txtNumDoc);
            GroupBoxDocumento.Location = new Point(12, 12);
            GroupBoxDocumento.Name = "GroupBoxDocumento";
            GroupBoxDocumento.Size = new Size(998, 98);
            GroupBoxDocumento.TabIndex = 22;
            GroupBoxDocumento.TabStop = false;
            GroupBoxDocumento.Text = "Documento de identidad";
            // 
            // LblDocumento
            // 
            LblDocumento.AutoSize = true;
            LblDocumento.Location = new Point(501, 54);
            LblDocumento.Name = "LblDocumento";
            LblDocumento.Size = new Size(127, 20);
            LblDocumento.TabIndex = 0;
            LblDocumento.Text = "N° de documento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(79, 127, 140);
            label10.Location = new Point(163, 50);
            label10.Name = "label10";
            label10.Size = new Size(25, 20);
            label10.TabIndex = 16;
            label10.Text = "(*)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 50);
            label7.Name = "label7";
            label7.Size = new Size(140, 20);
            label7.TabIndex = 20;
            label7.Text = "Tipo de documento";
            // 
            // ComboBoxTipoDoc
            // 
            ComboBoxTipoDoc.FormattingEnabled = true;
            ComboBoxTipoDoc.Items.AddRange(new object[] { "CC", "TI", "RC", "CE", "PP", "DNI", "NUIP" });
            ComboBoxTipoDoc.Location = new Point(203, 42);
            ComboBoxTipoDoc.Name = "ComboBoxTipoDoc";
            ComboBoxTipoDoc.Size = new Size(268, 28);
            ComboBoxTipoDoc.TabIndex = 19;
            ComboBoxTipoDoc.Text = "         -elija su tipo de documento-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(79, 127, 140);
            label1.Location = new Point(628, 54);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 10;
            label1.Text = "(*)";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(690, 47);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(157, 27);
            txtNumDoc.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(ComboBoxSex);
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
            groupBox2.Location = new Point(12, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(998, 229);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos generales";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(79, 127, 140);
            label11.Location = new Point(53, 178);
            label11.Name = "label11";
            label11.Size = new Size(25, 20);
            label11.TabIndex = 26;
            label11.Text = "(*)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 178);
            label12.Name = "label12";
            label12.Size = new Size(41, 20);
            label12.TabIndex = 28;
            label12.Text = "Sexo";
            // 
            // ComboBoxSex
            // 
            ComboBoxSex.FormattingEnabled = true;
            ComboBoxSex.Items.AddRange(new object[] { "Femenino", "Masculino" });
            ComboBoxSex.Location = new Point(203, 170);
            ComboBoxSex.Name = "ComboBoxSex";
            ComboBoxSex.Size = new Size(268, 28);
            ComboBoxSex.TabIndex = 27;
            ComboBoxSex.Text = "                     -elija su sexo-";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(79, 127, 140);
            label3.Location = new Point(647, 38);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 12;
            label3.Text = "(*)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(79, 127, 140);
            label2.Location = new Point(119, 38);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 11;
            label2.Text = "(*)";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(203, 31);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(268, 27);
            txtPrimerNombre.TabIndex = 9;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(203, 74);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(268, 27);
            txtSegundoNombre.TabIndex = 8;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(716, 31);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(157, 27);
            txtPrimerApellido.TabIndex = 7;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(716, 74);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(157, 27);
            txtSegundoApellido.TabIndex = 6;
            txtSegundoApellido.TextChanged += textBox2_TextChanged;
            // 
            // LblSegundoApellido
            // 
            LblSegundoApellido.AutoSize = true;
            LblSegundoApellido.Location = new Point(530, 81);
            LblSegundoApellido.Name = "LblSegundoApellido";
            LblSegundoApellido.Size = new Size(127, 20);
            LblSegundoApellido.TabIndex = 4;
            LblSegundoApellido.Text = "Segundo apellido";
            // 
            // LblPrimerApellido
            // 
            LblPrimerApellido.AutoSize = true;
            LblPrimerApellido.Location = new Point(530, 38);
            LblPrimerApellido.Name = "LblPrimerApellido";
            LblPrimerApellido.Size = new Size(111, 20);
            LblPrimerApellido.TabIndex = 3;
            LblPrimerApellido.Text = "Primer apellido";
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
            // LblPrimerNombre
            // 
            LblPrimerNombre.AutoSize = true;
            LblPrimerNombre.Location = new Point(17, 38);
            LblPrimerNombre.Name = "LblPrimerNombre";
            LblPrimerNombre.Size = new Size(108, 20);
            LblPrimerNombre.TabIndex = 1;
            LblPrimerNombre.Text = "Primer nombre";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(ComboBoxPreTelefono);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtTelefono);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtCorreo);
            groupBox3.Controls.Add(LblCorreoElectronico);
            groupBox3.Location = new Point(12, 351);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(998, 289);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos de contacto";
            // 
            // ComboBoxPreTelefono
            // 
            ComboBoxPreTelefono.FormattingEnabled = true;
            ComboBoxPreTelefono.Items.AddRange(new object[] { "- elija una opcion -", "CC", "TI", "RC", "CE", "PP", "DNI", "NUIP" });
            ComboBoxPreTelefono.Location = new Point(632, 33);
            ComboBoxPreTelefono.Name = "ComboBoxPreTelefono";
            ComboBoxPreTelefono.Size = new Size(78, 28);
            ComboBoxPreTelefono.TabIndex = 36;
            ComboBoxPreTelefono.Text = "   +57";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(ComboBoxPreTelefonoEmergencia);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(txtTelefonoEmergencia);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(lblParentesco);
            groupBox4.Controls.Add(ComboBoxParentesco);
            groupBox4.Controls.Add(txtNombreEmergencia);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Location = new Point(17, 92);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(975, 175);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos de contacto de emergencia";
            // 
            // ComboBoxPreTelefonoEmergencia
            // 
            ComboBoxPreTelefonoEmergencia.FormattingEnabled = true;
            ComboBoxPreTelefonoEmergencia.Items.AddRange(new object[] { "- elija una opcion -", "CC", "TI", "RC", "CE", "PP", "DNI", "NUIP" });
            ComboBoxPreTelefonoEmergencia.Location = new Point(212, 134);
            ComboBoxPreTelefonoEmergencia.Name = "ComboBoxPreTelefonoEmergencia";
            ComboBoxPreTelefonoEmergencia.Size = new Size(78, 28);
            ComboBoxPreTelefonoEmergencia.TabIndex = 35;
            ComboBoxPreTelefonoEmergencia.Text = "   +57";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(79, 127, 140);
            label16.Location = new Point(112, 138);
            label16.Name = "label16";
            label16.Size = new Size(25, 20);
            label16.TabIndex = 34;
            label16.Text = "(*)";
            // 
            // txtTelefonoEmergencia
            // 
            txtTelefonoEmergencia.Location = new Point(296, 135);
            txtTelefonoEmergencia.Name = "txtTelefonoEmergencia";
            txtTelefonoEmergencia.Size = new Size(219, 27);
            txtTelefonoEmergencia.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(36, 138);
            label17.Name = "label17";
            label17.Size = new Size(67, 20);
            label17.TabIndex = 32;
            label17.Text = "Telefono";
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
            lblParentesco.Location = new Point(36, 92);
            lblParentesco.Name = "lblParentesco";
            lblParentesco.Size = new Size(80, 20);
            lblParentesco.TabIndex = 31;
            lblParentesco.Text = "Parentesco";
            // 
            // ComboBoxParentesco
            // 
            ComboBoxParentesco.FormattingEnabled = true;
            ComboBoxParentesco.Items.AddRange(new object[] { "hermano/a", "padre", "abuelo", "conyuge" });
            ComboBoxParentesco.Location = new Point(212, 84);
            ComboBoxParentesco.Name = "ComboBoxParentesco";
            ComboBoxParentesco.Size = new Size(303, 28);
            ComboBoxParentesco.TabIndex = 30;
            // 
            // txtNombreEmergencia
            // 
            txtNombreEmergencia.Location = new Point(212, 41);
            txtNombreEmergencia.Name = "txtNombreEmergencia";
            txtNombreEmergencia.Size = new Size(303, 27);
            txtNombreEmergencia.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(79, 127, 140);
            label14.Location = new Point(165, 48);
            label14.Name = "label14";
            label14.Size = new Size(25, 20);
            label14.TabIndex = 18;
            label14.Text = "(*)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(36, 48);
            label13.Name = "label13";
            label13.Size = new Size(132, 20);
            label13.TabIndex = 0;
            label13.Text = "Nombre completo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(79, 127, 140);
            label6.Location = new Point(603, 33);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 18;
            label6.Text = "(*)";
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
            // txtTelefono
            // 
            txtTelefono.Location = new Point(716, 33);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(157, 27);
            txtTelefono.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(530, 33);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 15;
            label4.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(203, 26);
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
            // BotonAgregar
            // 
            BotonAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BotonAgregar.BackColor = Color.FromArgb(45, 91, 103);
            BotonAgregar.FlatAppearance.BorderSize = 0;
            BotonAgregar.FlatStyle = FlatStyle.Flat;
            BotonAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonAgregar.ForeColor = Color.FromArgb(165, 197, 213);
            BotonAgregar.Location = new Point(843, 800);
            BotonAgregar.Margin = new Padding(0);
            BotonAgregar.Name = "BotonAgregar";
            BotonAgregar.Size = new Size(167, 34);
            BotonAgregar.TabIndex = 25;
            BotonAgregar.Text = "+ Nuevo doctor";
            BotonAgregar.UseVisualStyleBackColor = false;
            BotonAgregar.Click += BotonAgregarDoctores_click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(65, 671);
            label18.Name = "label18";
            label18.Size = new Size(93, 20);
            label18.TabIndex = 36;
            label18.Text = "Especialidad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 668);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 27);
            textBox1.TabIndex = 36;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtNroLicencia);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(txtEspecialidad);
            groupBox1.Controls.Add(label27);
            groupBox1.Location = new Point(12, 671);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(998, 108);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles del profesional";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtNroLicencia
            // 
            txtNroLicencia.Location = new Point(182, 68);
            txtNroLicencia.Name = "txtNroLicencia";
            txtNroLicencia.Size = new Size(185, 27);
            txtNroLicencia.TabIndex = 21;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.FromArgb(79, 127, 140);
            label20.Location = new Point(132, 68);
            label20.Name = "label20";
            label20.Size = new Size(25, 20);
            label20.TabIndex = 20;
            label20.Text = "(*)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(27, 68);
            label19.Name = "label19";
            label19.Size = new Size(109, 20);
            label19.TabIndex = 19;
            label19.Text = "Nro de licencia";
            label19.Click += label19_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.FromArgb(79, 127, 140);
            label25.Location = new Point(115, 30);
            label25.Name = "label25";
            label25.Size = new Size(25, 20);
            label25.TabIndex = 18;
            label25.Text = "(*)";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(182, 30);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(185, 27);
            txtEspecialidad.TabIndex = 16;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(26, 30);
            label27.Name = "label27";
            label27.Size = new Size(93, 20);
            label27.TabIndex = 15;
            label27.Text = "Especialidad";
            // 
            // BotonModificar
            // 
            BotonModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BotonModificar.BackColor = Color.FromArgb(45, 91, 103);
            BotonModificar.FlatAppearance.BorderSize = 0;
            BotonModificar.FlatStyle = FlatStyle.Flat;
            BotonModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonModificar.ForeColor = Color.FromArgb(165, 197, 213);
            BotonModificar.Location = new Point(843, 846);
            BotonModificar.Margin = new Padding(0);
            BotonModificar.Name = "BotonModificar";
            BotonModificar.Size = new Size(167, 34);
            BotonModificar.TabIndex = 38;
            BotonModificar.Text = "+ modificar doctor";
            BotonModificar.UseVisualStyleBackColor = false;
            BotonModificar.Click += BotonModificar_Click;
            // 
            // FormularioGestionDoctores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1043, 1012);
            Controls.Add(BotonModificar);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label18);
            Controls.Add(BotonAgregar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(GroupBoxDocumento);
            Name = "FormularioGestionDoctores";
            Text = "FormularioGestionDoctores";
            GroupBoxDocumento.ResumeLayout(false);
            GroupBoxDocumento.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private GroupBox GroupBoxDocumento;
        private Label LblDocumento;
        private Label label10;
        private Label label7;
        private ComboBox ComboBoxTipoDoc;
        private Label label1;
        private TextBox txtNumDoc;
        private GroupBox groupBox2;
        private Label label11;
        private Label label12;
        private ComboBox ComboBoxSex;
        private DateTimePicker dateNacimiento;
        private Label label9;
        private Label label8;
        private Label label3;
        private Label label2;
        private TextBox txtPrimerNombre;
        private TextBox txtSegundoNombre;
        private TextBox txtPrimerApellido;
        private TextBox txtSegundoApellido;
        private Label LblSegundoApellido;
        private Label LblPrimerApellido;
        private Label LblSegundoNombre;
        private Label LblPrimerNombre;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox ComboBoxPreTelefonoEmergencia;
        private Label label16;
        private TextBox txtTelefonoEmergencia;
        private Label label17;
        private Label label15;
        private Label lblParentesco;
        private ComboBox ComboBoxParentesco;
        private TextBox txtNombreEmergencia;
        private Label label14;
        private Label label13;
        private Label label6;
        private Label label5;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtCorreo;
        private Label LblCorreoElectronico;
        private Button BotonAgregar;
        private ComboBox ComboBoxPreTelefono;
        private Label label18;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label label25;
        private TextBox txtEspecialidad;
        private Label label27;
        private Label label19;
        private TextBox txtNroLicencia;
        private Label label20;
        private Button BotonModificar;
    }
}