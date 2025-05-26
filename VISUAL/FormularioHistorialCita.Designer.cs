namespace VISUAL
{
    partial class FormularioHistorialCita
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            textExamenes = new TextBox();
            textRecomendaciones = new TextBox();
            textMedicamentos = new TextBox();
            textTratamientos = new TextBox();
            textDiagnosticos = new TextBox();
            textObservaciones = new TextBox();
            textDescripion = new TextBox();
            dateTimeFecha = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BotonAgregar = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 613);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(BotonAgregar);
            groupBox1.Controls.Add(textExamenes);
            groupBox1.Controls.Add(textRecomendaciones);
            groupBox1.Controls.Add(textMedicamentos);
            groupBox1.Controls.Add(textTratamientos);
            groupBox1.Controls.Add(textDiagnosticos);
            groupBox1.Controls.Add(textObservaciones);
            groupBox1.Controls.Add(textDescripion);
            groupBox1.Controls.Add(dateTimeFecha);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 607);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historial Cita";
            // 
            // textExamenes
            // 
            textExamenes.Location = new Point(181, 477);
            textExamenes.Multiline = true;
            textExamenes.Name = "textExamenes";
            textExamenes.Size = new Size(469, 27);
            textExamenes.TabIndex = 14;
            // 
            // textRecomendaciones
            // 
            textRecomendaciones.Location = new Point(181, 415);
            textRecomendaciones.Multiline = true;
            textRecomendaciones.Name = "textRecomendaciones";
            textRecomendaciones.Size = new Size(469, 27);
            textRecomendaciones.TabIndex = 13;
            // 
            // textMedicamentos
            // 
            textMedicamentos.Location = new Point(181, 347);
            textMedicamentos.Multiline = true;
            textMedicamentos.Name = "textMedicamentos";
            textMedicamentos.Size = new Size(469, 27);
            textMedicamentos.TabIndex = 12;
            // 
            // textTratamientos
            // 
            textTratamientos.Location = new Point(181, 280);
            textTratamientos.Multiline = true;
            textTratamientos.Name = "textTratamientos";
            textTratamientos.Size = new Size(469, 27);
            textTratamientos.TabIndex = 11;
            // 
            // textDiagnosticos
            // 
            textDiagnosticos.Location = new Point(181, 218);
            textDiagnosticos.Multiline = true;
            textDiagnosticos.Name = "textDiagnosticos";
            textDiagnosticos.Size = new Size(469, 27);
            textDiagnosticos.TabIndex = 10;
            // 
            // textObservaciones
            // 
            textObservaciones.Location = new Point(181, 162);
            textObservaciones.Multiline = true;
            textObservaciones.Name = "textObservaciones";
            textObservaciones.Size = new Size(469, 27);
            textObservaciones.TabIndex = 9;
            // 
            // textDescripion
            // 
            textDescripion.Location = new Point(181, 104);
            textDescripion.Multiline = true;
            textDescripion.Name = "textDescripion";
            textDescripion.Size = new Size(469, 34);
            textDescripion.TabIndex = 8;
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Location = new Point(181, 51);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(295, 27);
            dateTimeFecha.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 484);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 1;
            label8.Text = "Examenes:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 418);
            label7.Name = "label7";
            label7.Size = new Size(133, 20);
            label7.TabIndex = 6;
            label7.Text = "Recomendaciones:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 350);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 5;
            label6.Text = "Medicamentos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 287);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 4;
            label5.Text = "Tratamientos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 221);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 3;
            label4.Text = "Diagnosticos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 165);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Observaciones:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 107);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 56);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            label1.Click += label1_Click_2;
            // 
            // BotonAgregar
            // 
            BotonAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonAgregar.BackColor = Color.FromArgb(45, 91, 103);
            BotonAgregar.FlatAppearance.BorderSize = 0;
            BotonAgregar.FlatStyle = FlatStyle.Flat;
            BotonAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonAgregar.ForeColor = Color.FromArgb(165, 197, 213);
            BotonAgregar.Location = new Point(181, 551);
            BotonAgregar.Margin = new Padding(0);
            BotonAgregar.Name = "BotonAgregar";
            BotonAgregar.Size = new Size(121, 34);
            BotonAgregar.TabIndex = 27;
            BotonAgregar.Text = "Guardar";
            BotonAgregar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(45, 91, 103);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(165, 197, 213);
            button1.Location = new Point(529, 551);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(121, 34);
            button1.TabIndex = 28;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormularioHistorialCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 637);
            Controls.Add(panel1);
            Name = "FormularioHistorialCita";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textExamenes;
        private TextBox textRecomendaciones;
        private TextBox textMedicamentos;
        private TextBox textTratamientos;
        private TextBox textDiagnosticos;
        private TextBox textObservaciones;
        private TextBox textDescripion;
        private DateTimePicker dateTimeFecha;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button1;
        private Button BotonAgregar;
    }
}