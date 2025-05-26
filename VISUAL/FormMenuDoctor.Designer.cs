namespace VISUAL
{
    partial class FormMenuDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuDoctor));
            panel1 = new Panel();
            BotonSalir = new Button();
            panel2 = new Panel();
            LblMedicore = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            botonChat = new Button();
            button3 = new Button();
            button2 = new Button();
            SubMenuPaciente = new Button();
            pictureBox1 = new PictureBox();
            PanelContenedor = new Panel();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 91, 103);
            panel1.Controls.Add(BotonSalir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 39);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown_1;
            // 
            // BotonSalir
            // 
            BotonSalir.Anchor = AnchorStyles.Right;
            BotonSalir.BackColor = Color.FromArgb(185, 218, 233);
            BotonSalir.BackgroundImageLayout = ImageLayout.Zoom;
            BotonSalir.Cursor = Cursors.Hand;
            BotonSalir.FlatAppearance.BorderSize = 0;
            BotonSalir.FlatStyle = FlatStyle.Flat;
            BotonSalir.Image = (Image)resources.GetObject("BotonSalir.Image");
            BotonSalir.Location = new Point(1218, 7);
            BotonSalir.Name = "BotonSalir";
            BotonSalir.Size = new Size(40, 29);
            BotonSalir.TabIndex = 7;
            BotonSalir.UseVisualStyleBackColor = false;
            BotonSalir.Click += BotonSalir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 91, 103);
            panel2.Controls.Add(LblMedicore);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(SubMenuPaciente);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 761);
            panel2.TabIndex = 1;
            // 
            // LblMedicore
            // 
            LblMedicore.AutoSize = true;
            LblMedicore.Font = new Font("Century", 18F, FontStyle.Bold);
            LblMedicore.ForeColor = Color.FromArgb(185, 218, 233);
            LblMedicore.Location = new Point(96, 82);
            LblMedicore.Name = "LblMedicore";
            LblMedicore.Size = new Size(157, 35);
            LblMedicore.TabIndex = 1;
            LblMedicore.Text = "MediCore";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(185, 218, 233);
            panel3.Controls.Add(botonChat);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 87);
            panel3.TabIndex = 3;
            // 
            // botonChat
            // 
            botonChat.Dock = DockStyle.Top;
            botonChat.FlatAppearance.BorderSize = 0;
            botonChat.FlatStyle = FlatStyle.Flat;
            botonChat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            botonChat.ForeColor = Color.FromArgb(45, 91, 103);
            botonChat.Location = new Point(0, 55);
            botonChat.Margin = new Padding(0);
            botonChat.Name = "botonChat";
            botonChat.Padding = new Padding(40, 0, 0, 0);
            botonChat.Size = new Size(278, 26);
            botonChat.TabIndex = 2;
            botonChat.Text = "Chat";
            botonChat.TextAlign = ContentAlignment.MiddleLeft;
            botonChat.UseVisualStyleBackColor = true;
            botonChat.Click += botonChat_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(45, 91, 103);
            button3.Location = new Point(0, 29);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Padding = new Padding(40, 0, 0, 0);
            button3.Size = new Size(278, 26);
            button3.TabIndex = 1;
            button3.Text = "Cita";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(45, 91, 103);
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Padding = new Padding(40, 0, 0, 0);
            button2.Size = new Size(278, 29);
            button2.TabIndex = 0;
            button2.Text = "Historial";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SubMenuPaciente
            // 
            SubMenuPaciente.BackColor = Color.Transparent;
            SubMenuPaciente.Dock = DockStyle.Top;
            SubMenuPaciente.FlatAppearance.BorderSize = 0;
            SubMenuPaciente.FlatStyle = FlatStyle.Flat;
            SubMenuPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubMenuPaciente.ForeColor = Color.FromArgb(185, 218, 233);
            SubMenuPaciente.Location = new Point(0, 144);
            SubMenuPaciente.Name = "SubMenuPaciente";
            SubMenuPaciente.Size = new Size(278, 39);
            SubMenuPaciente.TabIndex = 2;
            SubMenuPaciente.Text = "Gestion paciente";
            SubMenuPaciente.TextAlign = ContentAlignment.MiddleLeft;
            SubMenuPaciente.UseVisualStyleBackColor = false;
            SubMenuPaciente.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 144);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.White;
            PanelContenedor.Controls.Add(pictureBox3);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(278, 39);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(992, 761);
            PanelContenedor.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(323, 238);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(411, 275);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // FormMenuDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 800);
            Controls.Add(PanelContenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuDoctor";
            Text = "FormMenuDoctor";
            Load += FormMenuDoctor_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button SubMenuPaciente;
        private PictureBox pictureBox1;
        private Button BotonSalir;
        private Button button3;
        private Button button2;
        private Label LblMedicore;
        private PictureBox pictureBox2;
        private Panel PanelContenedor;
        private PictureBox pictureBox3;
        private Button botonChat;
    }
}