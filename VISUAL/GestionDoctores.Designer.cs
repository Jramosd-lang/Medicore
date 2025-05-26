namespace VISUAL
{
    partial class GestionDoctores
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 91, 103);
            label2.Location = new Point(467, 111);
            label2.Name = "label2";
            label2.Size = new Size(60, 16);
            label2.TabIndex = 14;
            label2.Text = "Buscar:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(534, 111);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 16);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 91, 103);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(185, 218, 233);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(45, 91, 103);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 140);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(642, 252);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.BackColor = Color.FromArgb(165, 197, 213);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(45, 91, 103);
            button4.Location = new Point(24, 426);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(116, 26);
            button4.TabIndex = 17;
            button4.Text = "Modificar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += BotonModificar_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.BackColor = Color.FromArgb(165, 197, 213);
            button5.FlatAppearance.BorderColor = Color.FromArgb(45, 91, 103);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(45, 91, 103);
            button5.Location = new Point(186, 426);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(116, 26);
            button5.TabIndex = 18;
            button5.Text = "Eliminar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(45, 91, 103);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(165, 197, 213);
            button3.Location = new Point(520, 426);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(146, 26);
            button3.TabIndex = 20;
            button3.Text = "+ Nuevo doctor";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.FromArgb(45, 91, 103);
            label4.Location = new Point(24, 62);
            label4.Name = "label4";
            label4.Size = new Size(204, 19);
            label4.TabIndex = 21;
            label4.Text = "GESTION DE DOCTORES";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.FromArgb(45, 91, 103);
            label1.Location = new Point(24, 110);
            label1.Name = "label1";
            label1.Size = new Size(129, 16);
            label1.TabIndex = 22;
            label1.Text = "Lista de doctores";
            // 
            // GestionDoctores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 479);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GestionDoctores";
            Text = "GestionDoctores";
            Load += GestionDoctores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button5;
        private Button button3;
        private Label label4;
        private Label label1;
    }
}