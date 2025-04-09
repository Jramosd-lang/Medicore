
namespace VistaForm
{
    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label6 = new Label();
            btnModificar = new Button();
            BotonRegistro = new Button();
            TablaPacientes = new DataGridView();
            comboBoxTipoDoc = new ComboBox();
            label10 = new Label();
            comboBoxGrupoS = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            comboSexo = new ComboBox();
            dateTimeFechaN = new DateTimePicker();
            label7 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtDoc = new TextBox();
            txtApe = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaPacientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Location = new Point(27, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(1732, 452);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(645, 29);
            label6.Name = "label6";
            label6.Size = new Size(176, 20);
            label6.TabIndex = 10;
            label6.Text = "REGISTRO DE PACIENTES";
            label6.Click += label6_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(197, 285);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 22;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += button1_Click;
            // 
            // BotonRegistro
            // 
            BotonRegistro.Location = new Point(45, 285);
            BotonRegistro.Name = "BotonRegistro";
            BotonRegistro.Size = new Size(103, 29);
            BotonRegistro.TabIndex = 21;
            BotonRegistro.Text = "Registrar";
            BotonRegistro.UseVisualStyleBackColor = true;
            BotonRegistro.Click += BotonRegistro_Click;
            // 
            // TablaPacientes
            // 
            TablaPacientes.AllowUserToAddRows = false;
            TablaPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TablaPacientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TablaPacientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            TablaPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaPacientes.Location = new Point(811, 60);
            TablaPacientes.Name = "TablaPacientes";
            TablaPacientes.RowHeadersWidth = 5;
            TablaPacientes.ScrollBars = ScrollBars.Vertical;
            TablaPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaPacientes.Size = new Size(856, 194);
            TablaPacientes.TabIndex = 20;
            TablaPacientes.CellContentClick += dataGridView2_CellContentClick;
            // 
            // comboBoxTipoDoc
            // 
            comboBoxTipoDoc.ForeColor = SystemColors.InfoText;
            comboBoxTipoDoc.FormattingEnabled = true;
            comboBoxTipoDoc.Items.AddRange(new object[] { "Cédula de ciudadanía  ", "Tarjeta de identidad  ", "Registro civil de nacimiento  ", "Cédula de extranjería  ", "Pasaporte  ", "Permiso por Protección Temporal PPT  ", "Documento Nacional de Identidad DNI extranjero  ", "Salvoconducto de permanencia  ", "Carné diplomático  ", "Número de Identificación Tributaria NIT  ", "Número de Identificación de Extranjeros NIE" });
            comboBoxTipoDoc.Location = new Point(540, 197);
            comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            comboBoxTipoDoc.Size = new Size(250, 28);
            comboBoxTipoDoc.TabIndex = 18;
            comboBoxTipoDoc.Text = "   -elija su tipo de documento-";
            comboBoxTipoDoc.SelectedIndexChanged += comboBoxTipoDoc_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(372, 200);
            label10.Name = "label10";
            label10.Size = new Size(140, 20);
            label10.TabIndex = 17;
            label10.Text = "Tipo de documento";
            label10.Click += label10_Click;
            // 
            // comboBoxGrupoS
            // 
            comboBoxGrupoS.ForeColor = SystemColors.InfoText;
            comboBoxGrupoS.FormattingEnabled = true;
            comboBoxGrupoS.Items.AddRange(new object[] { "A+  ", "A-  ", "B+  ", "B-  ", "AB+  ", "AB-  ", "O+  ", "O-" });
            comboBoxGrupoS.Location = new Point(540, 153);
            comboBoxGrupoS.Name = "comboBoxGrupoS";
            comboBoxGrupoS.Size = new Size(250, 28);
            comboBoxGrupoS.TabIndex = 16;
            comboBoxGrupoS.Text = "   -elija su grupo sanguineo-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(372, 161);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 15;
            label9.Text = "Grupo sanguineo";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(372, 119);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 14;
            label8.Text = "Fecha de nacimiento";
            // 
            // comboSexo
            // 
            comboSexo.ForeColor = SystemColors.InfoText;
            comboSexo.FormattingEnabled = true;
            comboSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboSexo.Location = new Point(540, 64);
            comboSexo.Name = "comboSexo";
            comboSexo.Size = new Size(250, 28);
            comboSexo.TabIndex = 13;
            comboSexo.Text = "     -elija su sexo-";
            comboSexo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimeFechaN
            // 
            dateTimeFechaN.Format = DateTimePickerFormat.Short;
            dateTimeFechaN.Location = new Point(540, 112);
            dateTimeFechaN.Name = "dateTimeFechaN";
            dateTimeFechaN.Size = new Size(250, 27);
            dateTimeFechaN.TabIndex = 12;
            dateTimeFechaN.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(372, 72);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 11;
            label7.Text = "Sexo";
            label7.Click += label7_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(197, 190);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(153, 27);
            txtDireccion.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 234);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 3;
            label4.Text = "Numero de telefono";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 193);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Direccion";
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(197, 150);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(153, 27);
            txtDoc.TabIndex = 8;
            // 
            // txtApe
            // 
            txtApe.Location = new Point(197, 112);
            txtApe.Name = "txtApe";
            txtApe.Size = new Size(153, 27);
            txtApe.TabIndex = 7;
            txtApe.TextChanged += txtApe_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(197, 223);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(153, 27);
            txtTelefono.TabIndex = 6;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(197, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(153, 27);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 153);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "N° Documento";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 115);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 72);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TablaPacientes);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxTipoDoc);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(BotonRegistro);
            groupBox1.Controls.Add(comboBoxGrupoS);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtApe);
            groupBox1.Controls.Add(dateTimeFechaN);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboSexo);
            groupBox1.Controls.Add(txtDoc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Location = new Point(27, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1739, 541);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Pacientes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 631);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TablaPacientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modificar(sender, e);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private TextBox txtDireccion;
        private TextBox txtDoc;
        private TextBox txtApe;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label label6;
        private Label label7;
        private ComboBox comboSexo;
        private DateTimePicker dateTimeFechaN;
        private Label label8;
        private Label label9;
        private ComboBox comboBoxGrupoS;
        private Label label10;
        private ComboBox comboBoxTipoDoc;
        private DataGridView TablaPacientes;
        private Button BotonRegistro;
        private Button btnModificar;
        private GroupBox groupBox1;
    }
}
