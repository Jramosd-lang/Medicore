namespace VISUAL
{
    partial class FormJoin
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
            MessageBox.Show("FormJoin disposed.");
            Console.WriteLine("viva la vida gente");
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJoin));
            panel1 = new Panel();
            BotonMinimizar = new Button();
            BotonSalir = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            panel6 = new Panel();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 91, 103);
            panel1.Controls.Add(BotonMinimizar);
            panel1.Controls.Add(BotonSalir);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 35);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // BotonMinimizar
            // 
            BotonMinimizar.AccessibleRole = AccessibleRole.TitleBar;
            BotonMinimizar.Anchor = AnchorStyles.Right;
            BotonMinimizar.BackColor = Color.FromArgb(45, 91, 103);
            BotonMinimizar.BackgroundImageLayout = ImageLayout.Zoom;
            BotonMinimizar.FlatAppearance.BorderSize = 0;
            BotonMinimizar.FlatStyle = FlatStyle.Flat;
            BotonMinimizar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonMinimizar.Image = (Image)resources.GetObject("BotonMinimizar.Image");
            BotonMinimizar.Location = new Point(711, 3);
            BotonMinimizar.Name = "BotonMinimizar";
            BotonMinimizar.Padding = new Padding(0, 8, 0, 8);
            BotonMinimizar.Size = new Size(40, 29);
            BotonMinimizar.TabIndex = 7;
            BotonMinimizar.UseVisualStyleBackColor = false;
            BotonMinimizar.Click += BotonMinimizar_Click;
            // 
            // BotonSalir
            // 
            BotonSalir.Anchor = AnchorStyles.Right;
            BotonSalir.BackColor = Color.FromArgb(45, 91, 103);
            BotonSalir.BackgroundImageLayout = ImageLayout.Zoom;
            BotonSalir.Cursor = Cursors.Hand;
            BotonSalir.FlatAppearance.BorderSize = 0;
            BotonSalir.FlatStyle = FlatStyle.Flat;
            BotonSalir.Image = (Image)resources.GetObject("BotonSalir.Image");
            BotonSalir.Location = new Point(757, 3);
            BotonSalir.Name = "BotonSalir";
            BotonSalir.Size = new Size(40, 29);
            BotonSalir.TabIndex = 6;
            BotonSalir.UseVisualStyleBackColor = false;
            BotonSalir.Click += BotonSalir_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(124, 162, 177);
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Medicore";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(79, 127, 140);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 415);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(45, 91, 103);
            label4.Location = new Point(54, 265);
            label4.Name = "label4";
            label4.Size = new Size(77, 81);
            label4.TabIndex = 4;
            label4.Text = "+";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(124, 162, 177);
            label2.Location = new Point(122, 279);
            label2.Name = "label2";
            label2.Size = new Size(141, 67);
            label2.TabIndex = 3;
            label2.Text = "MED";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario__2_;
            pictureBox1.Location = new Point(39, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 91, 103);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(312, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 415);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 91, 103);
            label3.Location = new Point(456, 97);
            label3.Name = "label3";
            label3.Size = new Size(222, 46);
            label3.TabIndex = 4;
            label3.Text = "|Bienvenido|";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(45, 91, 103);
            label5.Location = new Point(388, 180);
            label5.Name = "label5";
            label5.Size = new Size(84, 28);
            label5.TabIndex = 6;
            label5.Text = "usuario:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(45, 91, 103);
            panel5.ForeColor = SystemColors.ControlText;
            panel5.Location = new Point(478, 205);
            panel5.Name = "panel5";
            panel5.Size = new Size(261, 2);
            panel5.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(45, 91, 103);
            label6.Location = new Point(385, 253);
            label6.Name = "label6";
            label6.Size = new Size(116, 28);
            label6.TabIndex = 7;
            label6.Text = "contraseña:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(45, 91, 103);
            panel6.ForeColor = SystemColors.ControlText;
            panel6.Location = new Point(507, 278);
            panel6.Name = "panel6";
            panel6.Size = new Size(231, 2);
            panel6.TabIndex = 7;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.FromArgb(45, 91, 103);
            txtUserName.Location = new Point(481, 178);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(258, 27);
            txtUserName.TabIndex = 8;
            txtUserName.TextAlign = HorizontalAlignment.Center;
         
            txtUserName.KeyDown += txtUserName_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(507, 251);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(232, 27);
            txtPassword.TabIndex = 9;
            txtPassword.TextAlign = HorizontalAlignment.Center;
     
            txtPassword.KeyDown += txtUserName_KeyDown;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(45, 91, 103);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(165, 197, 213);
            button3.Location = new Point(498, 347);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(167, 34);
            button3.TabIndex = 21;
            button3.Text = "Iniciar Sesion";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FormJoin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(panel6);
            Controls.Add(label6);
            Controls.Add(panel5);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormJoin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button BotonSalir;
        private Button BotonMinimizar;
        private Label label4;
        private Label label5;
        private Panel panel5;
        private Label label6;
        private Panel panel6;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button button3;
    }
}