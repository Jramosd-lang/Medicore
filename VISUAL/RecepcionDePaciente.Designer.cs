namespace VISUAL
{
    partial class RecepcionDePaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecepcionDePaciente));
            panel1 = new Panel();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            comboBoxTipoDocumento = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(comboBoxTipoDocumento);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 581);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(45, 91, 103);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(165, 197, 213);
            button3.Location = new Point(552, 494);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(167, 34);
            button3.TabIndex = 15;
            button3.Text = "Confirmar cita";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 231);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(680, 240);
            dataGridView1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(552, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // comboBoxTipoDocumento
            // 
            comboBoxTipoDocumento.AutoCompleteCustomSource.AddRange(new string[] { "CC", "TI", "CE", "PP" });
            comboBoxTipoDocumento.BackColor = Color.FromArgb(185, 218, 233);
            comboBoxTipoDocumento.FlatStyle = FlatStyle.Flat;
            comboBoxTipoDocumento.FormattingEnabled = true;
            comboBoxTipoDocumento.Items.AddRange(new object[] { "- elija una opcion -", "CC", "TI", "RC", "CE", "PP", "DNI", "NUIP" });
            comboBoxTipoDocumento.Location = new Point(262, 88);
            comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            comboBoxTipoDocumento.Size = new Size(182, 28);
            comboBoxTipoDocumento.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 91, 103);
            label3.Location = new Point(74, 88);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 9;
            label3.Text = "Tipo de documento:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(262, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 20);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 91, 103);
            label2.Location = new Point(74, 141);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 7;
            label2.Text = "Numero de documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.FromArgb(45, 91, 103);
            label1.Location = new Point(39, 27);
            label1.Name = "label1";
            label1.Size = new Size(235, 24);
            label1.TabIndex = 6;
            label1.Text = "Recepcion de pacientes";
            // 
            // RecepcionDePaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 581);
            Controls.Add(panel1);
            Name = "RecepcionDePaciente";
            Text = "RecepcionDePaciente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private ComboBox comboBoxTipoDocumento;
        private DataGridView dataGridView1;
        private Button button3;
    }
}