namespace VISUAL
{
    partial class FormularioCitacs
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            botonBuscarPaciente = new Button();
            botonBuscarDoctor = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            botonAgregarCita = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtMotivo = new TextBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            comboBoxHora = new ComboBox();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // botonBuscarPaciente
            // 
            botonBuscarPaciente.BackColor = Color.FromArgb(45, 91, 103);
            botonBuscarPaciente.FlatAppearance.BorderSize = 0;
            botonBuscarPaciente.FlatStyle = FlatStyle.Flat;
            botonBuscarPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonBuscarPaciente.ForeColor = Color.FromArgb(165, 197, 213);
            botonBuscarPaciente.Location = new Point(31, 90);
            botonBuscarPaciente.Margin = new Padding(0);
            botonBuscarPaciente.Name = "botonBuscarPaciente";
            botonBuscarPaciente.Size = new Size(310, 34);
            botonBuscarPaciente.TabIndex = 21;
            botonBuscarPaciente.Text = "Buscar paciente";
            botonBuscarPaciente.UseVisualStyleBackColor = false;
            botonBuscarPaciente.Click += botonBuscarPaciente_Click;
            // 
            // botonBuscarDoctor
            // 
            botonBuscarDoctor.BackColor = Color.FromArgb(45, 91, 103);
            botonBuscarDoctor.FlatAppearance.BorderSize = 0;
            botonBuscarDoctor.FlatStyle = FlatStyle.Flat;
            botonBuscarDoctor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonBuscarDoctor.ForeColor = Color.FromArgb(165, 197, 213);
            botonBuscarDoctor.Location = new Point(31, 134);
            botonBuscarDoctor.Margin = new Padding(0);
            botonBuscarDoctor.Name = "botonBuscarDoctor";
            botonBuscarDoctor.Size = new Size(310, 34);
            botonBuscarDoctor.TabIndex = 22;
            botonBuscarDoctor.Text = "Buscar doctor";
            botonBuscarDoctor.UseVisualStyleBackColor = false;
            botonBuscarDoctor.Click += botonBuscarDoctor_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 91, 103);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(185, 218, 233);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(45, 91, 103);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(45, 91, 103);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(185, 218, 233);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(364, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(45, 91, 103);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(185, 218, 233);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(45, 91, 103);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(416, 425);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 91, 103);
            label1.Location = new Point(31, 23);
            label1.Name = "label1";
            label1.Size = new Size(163, 19);
            label1.TabIndex = 24;
            label1.Text = "GESTION DE CITAS";
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 91, 103);
            label2.Location = new Point(42, 189);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 25;
            label2.Text = "Area:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(629, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 20);
            textBox1.TabIndex = 26;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // botonAgregarCita
            // 
            botonAgregarCita.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            botonAgregarCita.BackColor = Color.FromArgb(45, 91, 103);
            botonAgregarCita.FlatAppearance.BorderSize = 0;
            botonAgregarCita.FlatStyle = FlatStyle.Flat;
            botonAgregarCita.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonAgregarCita.ForeColor = Color.FromArgb(165, 197, 213);
            botonAgregarCita.Location = new Point(613, 542);
            botonAgregarCita.Margin = new Padding(0);
            botonAgregarCita.Name = "botonAgregarCita";
            botonAgregarCita.Size = new Size(167, 34);
            botonAgregarCita.TabIndex = 27;
            botonAgregarCita.Text = "Agregar cita";
            botonAgregarCita.UseVisualStyleBackColor = false;
            botonAgregarCita.Click += botonAgregarCita_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(185, 218, 233);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(102, 185);
            comboBox1.Margin = new Padding(0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 28);
            comboBox1.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 91, 103);
            label3.Location = new Point(427, 64);
            label3.Name = "label3";
            label3.Size = new Size(196, 19);
            label3.TabIndex = 29;
            label3.Text = "Buscar por documento:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(135, 228);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(206, 27);
            dateTimePicker1.TabIndex = 30;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(135, 329);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(206, 27);
            txtMotivo.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 91, 103);
            label4.Location = new Point(42, 236);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 34;
            label4.Text = "Fecha:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(42, 425);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(299, 120);
            richTextBox1.TabIndex = 35;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 91, 103);
            label5.Location = new Point(42, 337);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 36;
            label5.Text = "Motivos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(45, 91, 103);
            label6.Location = new Point(42, 382);
            label6.Name = "label6";
            label6.Size = new Size(132, 19);
            label6.TabIndex = 37;
            label6.Text = "Observaciones:";
            // 
            // comboBoxHora
            // 
            comboBoxHora.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHora.FormattingEnabled = true;
            comboBoxHora.Items.AddRange(new object[] { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00" });
            comboBoxHora.Location = new Point(135, 276);
            comboBoxHora.Name = "comboBoxHora";
            comboBoxHora.Size = new Size(206, 28);
            comboBoxHora.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(45, 91, 103);
            label7.Location = new Point(42, 285);
            label7.Name = "label7";
            label7.Size = new Size(53, 19);
            label7.TabIndex = 39;
            label7.Text = "Hora:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(45, 91, 103);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(165, 197, 213);
            button1.Location = new Point(364, 542);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(167, 34);
            button1.TabIndex = 40;
            button1.Text = "x Eliminar cita";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormularioCitacs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 620);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(comboBoxHora);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(txtMotivo);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(botonAgregarCita);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(botonBuscarDoctor);
            Controls.Add(botonBuscarPaciente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioCitacs";
            Text = "FormularioCitacs";
            Load += FormularioCitacs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonBuscarPaciente;
        private Button botonBuscarDoctor;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button botonAgregarCita;
        private ComboBox comboBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox txtMotivo;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxHora;
        private Label label7;
        private Button button1;
    }
}