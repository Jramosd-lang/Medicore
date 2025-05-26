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
            BotonModificar1 = new Button();
            BotonAgregar = new Button();
            GroupBoxDocumento.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LblDocumento
            // 
            LblDocumento.AutoSize = true;
            LblDocumento.Location = new Point(438, 40);
            LblDocumento.Name = "LblDocumento";
            LblDocumento.Size = new Size(132, 15);
            LblDocumento.TabIndex = 0;
            LblDocumento.Text = "Numero de documento";
            // 
            // LblPrimerNombre
            // 
            LblPrimerNombre.AutoSize = true;
            LblPrimerNombre.Location = new Point(15, 28);
            LblPrimerNombre.Name = "LblPrimerNombre";
            LblPrimerNombre.Size = new Size(87, 15);
            LblPrimerNombre.TabIndex = 1;
            LblPrimerNombre.Text = "Primer nombre";
            // 
            // LblSegundoNombre
            // 
            LblSegundoNombre.AutoSize = true;
            LblSegundoNombre.Font = new Font("Segoe UI", 9F);
            LblSegundoNombre.Location = new Point(15, 61);
            LblSegundoNombre.Name = "LblSegundoNombre";
            LblSegundoNombre.Size = new Size(99, 15);
            LblSegundoNombre.TabIndex = 2;
            LblSegundoNombre.Text = "Segundo nombre";
            // 
            // LblPrimerApellido
            // 
            LblPrimerApellido.AutoSize = true;
            LblPrimerApellido.Location = new Point(438, 28);
            LblPrimerApellido.Name = "LblPrimerApellido";
            LblPrimerApellido.Size = new Size(87, 15);
            LblPrimerApellido.TabIndex = 3;
            LblPrimerApellido.Text = "Primer apellido";
            // 
            // LblSegundoApellido
            // 
            LblSegundoApellido.AutoSize = true;
            LblSegundoApellido.Location = new Point(438, 61);
            LblSegundoApellido.Name = "LblSegundoApellido";
            LblSegundoApellido.Size = new Size(99, 15);
            LblSegundoApellido.TabIndex = 4;
            LblSegundoApellido.Text = "Segundo apellido";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(604, 35);
            txtNumDoc.Margin = new Padding(3, 2, 3, 2);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(138, 23);
            txtNumDoc.TabIndex = 5;
            txtNumDoc.KeyPress += txtNumDoc_KeyPress;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(604, 56);
            txtSegundoApellido.Margin = new Padding(3, 2, 3, 2);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(138, 23);
            txtSegundoApellido.TabIndex = 6;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(604, 23);
            txtPrimerApellido.Margin = new Padding(3, 2, 3, 2);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(138, 23);
            txtPrimerApellido.TabIndex = 7;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(178, 56);
            txtSegundoNombre.Margin = new Padding(3, 2, 3, 2);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(235, 23);
            txtSegundoNombre.TabIndex = 8;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(178, 23);
            txtPrimerNombre.Margin = new Padding(3, 2, 3, 2);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(235, 23);
            txtPrimerNombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(79, 127, 140);
            label1.Location = new Point(576, 40);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 10;
            label1.Text = "(*)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(79, 127, 140);
            label2.Location = new Point(104, 28);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 11;
            label2.Text = "(*)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(79, 127, 140);
            label3.Location = new Point(576, 31);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 12;
            label3.Text = "(*)";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(178, 20);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(235, 23);
            txtCorreo.TabIndex = 14;
            // 
            // LblCorreoElectronico
            // 
            LblCorreoElectronico.AutoSize = true;
            LblCorreoElectronico.Location = new Point(15, 25);
            LblCorreoElectronico.Name = "LblCorreoElectronico";
            LblCorreoElectronico.Size = new Size(105, 15);
            LblCorreoElectronico.TabIndex = 13;
            LblCorreoElectronico.Text = "Correo Electronico";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(604, 20);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(138, 23);
            txtTelefono.TabIndex = 16;
            txtTelefono.KeyPress += txtNumDoc_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(438, 25);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 15;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(79, 127, 140);
            label5.Location = new Point(136, 25);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 17;
            label5.Text = "(*)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(79, 127, 140);
            label6.Location = new Point(576, 28);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 18;
            label6.Text = "(*)";
            // 
            // ComboBoxTipoDoc
            // 
            ComboBoxTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTipoDoc.FormattingEnabled = true;
            ComboBoxTipoDoc.Items.AddRange(new object[] { "- elija una opcion -", "CC", "TI", "RC", "CE", "PP", "DNI", "NUIP" });
            ComboBoxTipoDoc.Location = new Point(178, 38);
            ComboBoxTipoDoc.Margin = new Padding(3, 2, 3, 2);
            ComboBoxTipoDoc.Name = "ComboBoxTipoDoc";
            ComboBoxTipoDoc.Size = new Size(235, 23);
            ComboBoxTipoDoc.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 38);
            label7.Name = "label7";
            label7.Size = new Size(112, 15);
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
            GroupBoxDocumento.Margin = new Padding(3, 2, 3, 2);
            GroupBoxDocumento.Name = "GroupBoxDocumento";
            GroupBoxDocumento.Padding = new Padding(3, 2, 3, 2);
            GroupBoxDocumento.Size = new Size(881, 74);
            GroupBoxDocumento.TabIndex = 21;
            GroupBoxDocumento.TabStop = false;
            GroupBoxDocumento.Text = "Documento de identidad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(79, 127, 140);
            label10.Location = new Point(143, 38);
            label10.Name = "label10";
            label10.Size = new Size(20, 15);
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
            groupBox2.Location = new Point(0, 74);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(881, 172);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos generales";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(79, 127, 140);
            label11.Location = new Point(46, 134);
            label11.Name = "label11";
            label11.Size = new Size(20, 15);
            label11.TabIndex = 26;
            label11.Text = "(*)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 134);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 28;
            label12.Text = "Sexo";
            // 
            // ComboBoxSexo
            // 
            ComboBoxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSexo.FormattingEnabled = true;
            ComboBoxSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            ComboBoxSexo.Location = new Point(178, 128);
            ComboBoxSexo.Margin = new Padding(3, 2, 3, 2);
            ComboBoxSexo.Name = "ComboBoxSexo";
            ComboBoxSexo.Size = new Size(235, 23);
            ComboBoxSexo.TabIndex = 27;
            ComboBoxSexo.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dateNacimiento
            // 
            dateNacimiento.Location = new Point(178, 95);
            dateNacimiento.Margin = new Padding(3, 2, 3, 2);
            dateNacimiento.Name = "dateNacimiento";
            dateNacimiento.Size = new Size(235, 23);
            dateNacimiento.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(79, 127, 140);
            label9.Location = new Point(140, 95);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 15;
            label9.Text = "(*)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 95);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
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
            groupBox3.Location = new Point(0, 246);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(881, 195);
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
            groupBox4.Location = new Point(15, 64);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(866, 106);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos extras";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.FromArgb(79, 127, 140);
            label15.Location = new Point(106, 69);
            label15.Name = "label15";
            label15.Size = new Size(20, 15);
            label15.TabIndex = 29;
            label15.Text = "(*)";
            // 
            // lblParentesco
            // 
            lblParentesco.AutoSize = true;
            lblParentesco.Location = new Point(32, 69);
            lblParentesco.Name = "lblParentesco";
            lblParentesco.Size = new Size(50, 15);
            lblParentesco.TabIndex = 31;
            lblParentesco.Text = "Religion";
            // 
            // ComboBoxReligion
            // 
            ComboBoxReligion.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxReligion.FormattingEnabled = true;
            ComboBoxReligion.Items.AddRange(new object[] { "Catolicismo", "Cristianismo", "Cristianismo Evangélico", "Cristianismo Protestante", "Protestante", "Testigos de Jehová", "Judaísmo", "Islam", "Hinduismo", "Budismo", "No especifico" });
            ComboBoxReligion.Location = new Point(163, 66);
            ComboBoxReligion.Margin = new Padding(3, 2, 3, 2);
            ComboBoxReligion.Name = "ComboBoxReligion";
            ComboBoxReligion.Size = new Size(235, 23);
            ComboBoxReligion.TabIndex = 30;
            // 
            // txtOcupacion
            // 
            txtOcupacion.Location = new Point(163, 33);
            txtOcupacion.Margin = new Padding(3, 2, 3, 2);
            txtOcupacion.Name = "txtOcupacion";
            txtOcupacion.Size = new Size(235, 23);
            txtOcupacion.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(79, 127, 140);
            label14.Location = new Point(106, 36);
            label14.Name = "label14";
            label14.Size = new Size(20, 15);
            label14.TabIndex = 18;
            label14.Text = "(*)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(32, 36);
            label13.Name = "label13";
            label13.Size = new Size(65, 15);
            label13.TabIndex = 0;
            label13.Text = "Ocupacion";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BotonModificar1);
            panel1.Controls.Add(BotonAgregar);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(GroupBoxDocumento);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(881, 514);
            panel1.TabIndex = 24;
            panel1.Paint += panel1_Paint;
            // 
            // BotonModificar1
            // 
            BotonModificar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonModificar1.BackColor = Color.FromArgb(45, 91, 103);
            BotonModificar1.FlatAppearance.BorderSize = 0;
            BotonModificar1.FlatStyle = FlatStyle.Flat;
            BotonModificar1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonModificar1.ForeColor = Color.FromArgb(165, 197, 213);
            BotonModificar1.Location = new Point(726, 463);
            BotonModificar1.Margin = new Padding(0);
            BotonModificar1.Name = "BotonModificar1";
            BotonModificar1.Size = new Size(146, 26);
            BotonModificar1.TabIndex = 39;
            BotonModificar1.Text = "+ Modificar";
            BotonModificar1.UseVisualStyleBackColor = false;
            BotonModificar1.Click += BotonModificar_Click;
            // 
            // BotonAgregar
            // 
            BotonAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonAgregar.BackColor = Color.FromArgb(45, 91, 103);
            BotonAgregar.FlatAppearance.BorderSize = 0;
            BotonAgregar.FlatStyle = FlatStyle.Flat;
            BotonAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonAgregar.ForeColor = Color.FromArgb(165, 197, 213);
            BotonAgregar.Location = new Point(726, 463);
            BotonAgregar.Margin = new Padding(0);
            BotonAgregar.Name = "BotonAgregar";
            BotonAgregar.Size = new Size(146, 26);
            BotonAgregar.TabIndex = 26;
            BotonAgregar.Text = "+ Registrar";
            BotonAgregar.UseVisualStyleBackColor = false;
            BotonAgregar.Click += BotonAgregar_Click;
            // 
            // FormularioGestionPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 514);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}