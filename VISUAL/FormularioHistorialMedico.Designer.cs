namespace VISUAL
{
    partial class FormularioHistorialMedico
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxTipoSangre = new ComboBox();
            groupBox1 = new GroupBox();
            comboBoxVacunas = new ComboBox();
            comboBoxAntecedentesFamiliares = new ComboBox();
            comboBoxMedicamentosActuales = new ComboBox();
            comboBoxEnfermedadesCronicas = new ComboBox();
            comboBoxAlergias = new ComboBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Grupo sanguineo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 75);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Alergias:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 122);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 2;
            label3.Text = "Enfermedades cronicas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 161);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 3;
            label4.Text = "Medicamentos actuales:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 199);
            label5.Name = "label5";
            label5.Size = new Size(171, 20);
            label5.TabIndex = 4;
            label5.Text = "Antecedentes familiares:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 248);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 5;
            label6.Text = "Vacunas:";
            // 
            // comboBoxTipoSangre
            // 
            comboBoxTipoSangre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxTipoSangre.FormattingEnabled = true;
            comboBoxTipoSangre.Location = new Point(723, 36);
            comboBoxTipoSangre.Name = "comboBoxTipoSangre";
            comboBoxTipoSangre.Size = new Size(73, 28);
            comboBoxTipoSangre.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxVacunas);
            groupBox1.Controls.Add(comboBoxAntecedentesFamiliares);
            groupBox1.Controls.Add(comboBoxMedicamentosActuales);
            groupBox1.Controls.Add(comboBoxEnfermedadesCronicas);
            groupBox1.Controls.Add(comboBoxAlergias);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxTipoSangre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(818, 304);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historial medico estatico";
            // 
            // comboBoxVacunas
            // 
            comboBoxVacunas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxVacunas.FormattingEnabled = true;
            comboBoxVacunas.Location = new Point(526, 240);
            comboBoxVacunas.Name = "comboBoxVacunas";
            comboBoxVacunas.Size = new Size(270, 28);
            comboBoxVacunas.TabIndex = 16;
            // 
            // comboBoxAntecedentesFamiliares
            // 
            comboBoxAntecedentesFamiliares.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxAntecedentesFamiliares.FormattingEnabled = true;
            comboBoxAntecedentesFamiliares.Location = new Point(526, 199);
            comboBoxAntecedentesFamiliares.Name = "comboBoxAntecedentesFamiliares";
            comboBoxAntecedentesFamiliares.Size = new Size(270, 28);
            comboBoxAntecedentesFamiliares.TabIndex = 15;
            // 
            // comboBoxMedicamentosActuales
            // 
            comboBoxMedicamentosActuales.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxMedicamentosActuales.FormattingEnabled = true;
            comboBoxMedicamentosActuales.Location = new Point(526, 153);
            comboBoxMedicamentosActuales.Name = "comboBoxMedicamentosActuales";
            comboBoxMedicamentosActuales.Size = new Size(270, 28);
            comboBoxMedicamentosActuales.TabIndex = 14;
            // 
            // comboBoxEnfermedadesCronicas
            // 
            comboBoxEnfermedadesCronicas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxEnfermedadesCronicas.FormattingEnabled = true;
            comboBoxEnfermedadesCronicas.Location = new Point(526, 114);
            comboBoxEnfermedadesCronicas.Name = "comboBoxEnfermedadesCronicas";
            comboBoxEnfermedadesCronicas.Size = new Size(270, 28);
            comboBoxEnfermedadesCronicas.TabIndex = 13;
            // 
            // comboBoxAlergias
            // 
            comboBoxAlergias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxAlergias.FormattingEnabled = true;
            comboBoxAlergias.Location = new Point(458, 72);
            comboBoxAlergias.Name = "comboBoxAlergias";
            comboBoxAlergias.Size = new Size(338, 28);
            comboBoxAlergias.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 322);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(818, 310);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(807, 278);
            dataGridView1.TabIndex = 0;
            // 
            // FormularioHistorialMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 644);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormularioHistorialMedico";
            Text = "Form1";
            Load += FormularioHistorialMedico_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxTipoSangre;
        private GroupBox groupBox1;
        private ComboBox comboBoxVacunas;
        private ComboBox comboBoxAntecedentesFamiliares;
        private ComboBox comboBoxMedicamentosActuales;
        private ComboBox comboBoxEnfermedadesCronicas;
        private ComboBox comboBoxAlergias;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
    }
}