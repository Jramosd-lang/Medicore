
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
            ComboBoxSexo = new ComboBox();
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
            label6 = new Label();
            label5 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            LblCorreoElectronico = new Label();
            BotonAgregar = new Button();
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
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            GroupBoxDocumento.Size = new Size(913, 74);
            GroupBoxDocumento.TabIndex = 22;
            GroupBoxDocumento.TabStop = false;
            GroupBoxDocumento.Text = "Documento de identidad";
            // 
            // LblDocumento
            // 
            LblDocumento.AutoSize = true;
            LblDocumento.Location = new Point(460, 40);
            LblDocumento.Name = "LblDocumento";
            LblDocumento.Size = new Size(132, 15);
            LblDocumento.TabIndex = 0;
            LblDocumento.Text = "Numero de documento";
            LblDocumento.Click += LblDocumento_Click;
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
            // ComboBoxTipoDoc
            // 
            ComboBoxTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTipoDoc.FormattingEnabled = true;
            ComboBoxTipoDoc.Items.AddRange(new object[] { "CC", "TI", "RC", "CE", "PP", "DNI", "NUIP" });
            ComboBoxTipoDoc.Location = new Point(178, 38);
            ComboBoxTipoDoc.Margin = new Padding(3, 2, 3, 2);
            ComboBoxTipoDoc.Name = "ComboBoxTipoDoc";
            ComboBoxTipoDoc.Size = new Size(235, 23);
            ComboBoxTipoDoc.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(79, 127, 140);
            label1.Location = new Point(600, 40);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 10;
            label1.Text = "(*)";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(626, 35);
            txtNumDoc.Margin = new Padding(3, 2, 3, 2);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(138, 23);
            txtNumDoc.TabIndex = 5;
            txtNumDoc.KeyPress += txtNumDoc_KeyPress;
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
            groupBox2.Size = new Size(913, 172);
            groupBox2.TabIndex = 23;
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
            ComboBoxSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            ComboBoxSexo.Location = new Point(178, 128);
            ComboBoxSexo.Margin = new Padding(3, 2, 3, 2);
            ComboBoxSexo.Name = "ComboBoxSexo";
            ComboBoxSexo.Size = new Size(235, 23);
            ComboBoxSexo.TabIndex = 27;
            ComboBoxSexo.SelectedIndexChanged += ComboBoxSexo_SelectedIndexChanged;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(79, 127, 140);
            label3.Location = new Point(566, 28);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 12;
            label3.Text = "(*)";
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
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(178, 23);
            txtPrimerNombre.Margin = new Padding(3, 2, 3, 2);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(235, 23);
            txtPrimerNombre.TabIndex = 9;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(178, 56);
            txtSegundoNombre.Margin = new Padding(3, 2, 3, 2);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(235, 23);
            txtSegundoNombre.TabIndex = 8;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(626, 23);
            txtPrimerApellido.Margin = new Padding(3, 2, 3, 2);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(138, 23);
            txtPrimerApellido.TabIndex = 7;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(626, 56);
            txtSegundoApellido.Margin = new Padding(3, 2, 3, 2);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(138, 23);
            txtSegundoApellido.TabIndex = 6;
            txtSegundoApellido.TextChanged += textBox2_TextChanged;
            // 
            // LblSegundoApellido
            // 
            LblSegundoApellido.AutoSize = true;
            LblSegundoApellido.Location = new Point(464, 61);
            LblSegundoApellido.Name = "LblSegundoApellido";
            LblSegundoApellido.Size = new Size(99, 15);
            LblSegundoApellido.TabIndex = 4;
            LblSegundoApellido.Text = "Segundo apellido";
            // 
            // LblPrimerApellido
            // 
            LblPrimerApellido.AutoSize = true;
            LblPrimerApellido.Location = new Point(464, 28);
            LblPrimerApellido.Name = "LblPrimerApellido";
            LblPrimerApellido.Size = new Size(87, 15);
            LblPrimerApellido.TabIndex = 3;
            LblPrimerApellido.Text = "Primer apellido";
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
            // LblPrimerNombre
            // 
            LblPrimerNombre.AutoSize = true;
            LblPrimerNombre.Location = new Point(15, 28);
            LblPrimerNombre.Name = "LblPrimerNombre";
            LblPrimerNombre.Size = new Size(87, 15);
            LblPrimerNombre.TabIndex = 1;
            LblPrimerNombre.Text = "Primer nombre";
            // 
            // groupBox3
            // 
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
            groupBox3.Size = new Size(913, 98);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos de contacto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(79, 127, 140);
            label6.Location = new Point(566, 25);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 18;
            label6.Text = "(*)";
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
            // txtTelefono
            // 
            txtTelefono.Location = new Point(628, 25);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(136, 23);
            txtTelefono.TabIndex = 16;
            txtTelefono.KeyPress += txtNumDoc_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 25);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 15;
            label4.Text = "Telefono";
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
            // BotonAgregar
            // 
            BotonAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonAgregar.BackColor = Color.FromArgb(45, 91, 103);
            BotonAgregar.FlatAppearance.BorderSize = 0;
            BotonAgregar.FlatStyle = FlatStyle.Flat;
            BotonAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonAgregar.ForeColor = Color.FromArgb(165, 197, 213);
            BotonAgregar.Location = new Point(758, 441);
            BotonAgregar.Margin = new Padding(0);
            BotonAgregar.Name = "BotonAgregar";
            BotonAgregar.Size = new Size(146, 26);
            BotonAgregar.TabIndex = 25;
            BotonAgregar.Text = "+ Registrar";
            BotonAgregar.UseVisualStyleBackColor = false;
            BotonAgregar.Click += BotonAgregarDoctores_click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNroLicencia);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(txtEspecialidad);
            groupBox1.Controls.Add(label27);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 344);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(913, 81);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles del profesional";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtNroLicencia
            // 
            txtNroLicencia.Location = new Point(159, 51);
            txtNroLicencia.Margin = new Padding(3, 2, 3, 2);
            txtNroLicencia.Name = "txtNroLicencia";
            txtNroLicencia.Size = new Size(162, 23);
            txtNroLicencia.TabIndex = 21;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.FromArgb(79, 127, 140);
            label20.Location = new Point(133, 51);
            label20.Name = "label20";
            label20.Size = new Size(20, 15);
            label20.TabIndex = 20;
            label20.Text = "(*)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(24, 51);
            label19.Name = "label19";
            label19.Size = new Size(110, 15);
            label19.TabIndex = 19;
            label19.Text = "Numero de licencia";
            label19.Click += label19_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.FromArgb(79, 127, 140);
            label25.Location = new Point(133, 22);
            label25.Name = "label25";
            label25.Size = new Size(20, 15);
            label25.TabIndex = 18;
            label25.Text = "(*)";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(159, 22);
            txtEspecialidad.Margin = new Padding(3, 2, 3, 2);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(162, 23);
            txtEspecialidad.TabIndex = 16;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(23, 22);
            label27.Name = "label27";
            label27.Size = new Size(72, 15);
            label27.TabIndex = 15;
            label27.Text = "Especialidad";
            // 
            // BotonModificar
            // 
            BotonModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonModificar.BackColor = Color.FromArgb(45, 91, 103);
            BotonModificar.FlatAppearance.BorderSize = 0;
            BotonModificar.FlatStyle = FlatStyle.Flat;
            BotonModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonModificar.ForeColor = Color.FromArgb(165, 197, 213);
            BotonModificar.Location = new Point(758, 441);
            BotonModificar.Margin = new Padding(0);
            BotonModificar.Name = "BotonModificar";
            BotonModificar.Size = new Size(146, 26);
            BotonModificar.TabIndex = 38;
            BotonModificar.Text = "+ Modificar";
            BotonModificar.UseVisualStyleBackColor = false;
            BotonModificar.Click += BotonModificar_Click;
            // 
            // FormularioGestionDoctores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(913, 485);
            Controls.Add(BotonModificar);
            Controls.Add(groupBox1);
            Controls.Add(BotonAgregar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(GroupBoxDocumento);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormularioGestionDoctores";
            Text = "Registro de Doctores";
            GroupBoxDocumento.ResumeLayout(false);
            GroupBoxDocumento.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private ComboBox ComboBoxSexo;
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
        private Label label6;
        private Label label5;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtCorreo;
        private Label LblCorreoElectronico;
        private Button BotonAgregar;
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