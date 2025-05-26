
namespace VISUAL
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            MenuLateral = new Panel();
            PanelSubMenuAgenda = new Panel();
            button2 = new Button();
            BotonRecepcion = new Button();
            BotonGestionarCItas = new Button();
            BotonAgendaYAtencion = new Button();
            PanelSubmenuGestion = new Panel();
            button1 = new Button();
            BotonGestionarDoctores = new Button();
            BotonGestionarPacientes = new Button();
            BotonGestionar = new Button();
            PanelLogo = new Panel();
            LblMedicore = new Label();
            pictureBox1 = new PictureBox();
            PanelContenedor = new Panel();
            pictureBox2 = new PictureBox();
            PanelTitleBar = new Panel();
            BotonMaximizar = new Button();
            BotonSalir = new Button();
            BotonMinimizar = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            MenuLateral.SuspendLayout();
            PanelSubMenuAgenda.SuspendLayout();
            PanelSubmenuGestion.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // MenuLateral
            // 
            MenuLateral.AutoScroll = true;
            MenuLateral.BackColor = Color.FromArgb(45, 91, 103);
            MenuLateral.BackgroundImageLayout = ImageLayout.Center;
            MenuLateral.Controls.Add(PanelSubMenuAgenda);
            MenuLateral.Controls.Add(BotonAgendaYAtencion);
            MenuLateral.Controls.Add(PanelSubmenuGestion);
            MenuLateral.Controls.Add(BotonGestionar);
            MenuLateral.Controls.Add(PanelLogo);
            MenuLateral.Dock = DockStyle.Left;
            MenuLateral.Location = new Point(0, 30);
            MenuLateral.Margin = new Padding(3, 2, 3, 2);
            MenuLateral.Name = "MenuLateral";
            MenuLateral.Size = new Size(262, 570);
            MenuLateral.TabIndex = 0;
            // 
            // PanelSubMenuAgenda
            // 
            PanelSubMenuAgenda.BackColor = Color.FromArgb(185, 218, 233);
            PanelSubMenuAgenda.Controls.Add(button2);
            PanelSubMenuAgenda.Controls.Add(BotonRecepcion);
            PanelSubMenuAgenda.Controls.Add(BotonGestionarCItas);
            PanelSubMenuAgenda.Dock = DockStyle.Top;
            PanelSubMenuAgenda.ForeColor = SystemColors.ControlDarkDark;
            PanelSubMenuAgenda.Location = new Point(0, 249);
            PanelSubMenuAgenda.Margin = new Padding(3, 2, 3, 2);
            PanelSubMenuAgenda.Name = "PanelSubMenuAgenda";
            PanelSubMenuAgenda.Size = new Size(262, 34);
            PanelSubMenuAgenda.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 30);
            button2.Margin = new Padding(0, 8, 0, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 0);
            button2.Size = new Size(262, 0);
            button2.TabIndex = 7;
            button2.Text = "Gestion de capital";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // BotonRecepcion
            // 
            BotonRecepcion.BackColor = Color.Transparent;
            BotonRecepcion.BackgroundImageLayout = ImageLayout.None;
            BotonRecepcion.Dock = DockStyle.Top;
            BotonRecepcion.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            BotonRecepcion.FlatAppearance.BorderSize = 0;
            BotonRecepcion.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 225, 231);
            BotonRecepcion.FlatStyle = FlatStyle.Flat;
            BotonRecepcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotonRecepcion.ForeColor = Color.FromArgb(45, 91, 103);
            BotonRecepcion.Location = new Point(0, 0);
            BotonRecepcion.Margin = new Padding(0, 8, 0, 0);
            BotonRecepcion.Name = "BotonRecepcion";
            BotonRecepcion.Padding = new Padding(35, 0, 0, 0);
            BotonRecepcion.Size = new Size(262, 30);
            BotonRecepcion.TabIndex = 5;
            BotonRecepcion.Text = "Recepcion de pacientes";
            BotonRecepcion.TextAlign = ContentAlignment.MiddleLeft;
            BotonRecepcion.UseVisualStyleBackColor = false;
            BotonRecepcion.Click += button4_Click;
            // 
            // BotonGestionarCItas
            // 
            BotonGestionarCItas.BackColor = Color.Transparent;
            BotonGestionarCItas.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            BotonGestionarCItas.FlatAppearance.BorderSize = 0;
            BotonGestionarCItas.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 225, 231);
            BotonGestionarCItas.FlatStyle = FlatStyle.Flat;
            BotonGestionarCItas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotonGestionarCItas.ForeColor = Color.FromArgb(45, 91, 103);
            BotonGestionarCItas.Location = new Point(0, 0);
            BotonGestionarCItas.Margin = new Padding(0, 8, 0, 0);
            BotonGestionarCItas.Name = "BotonGestionarCItas";
            BotonGestionarCItas.Padding = new Padding(35, 0, 0, 0);
            BotonGestionarCItas.Size = new Size(262, 30);
            BotonGestionarCItas.TabIndex = 4;
            BotonGestionarCItas.Text = "Gestion de citas";
            BotonGestionarCItas.TextAlign = ContentAlignment.MiddleLeft;
            BotonGestionarCItas.UseVisualStyleBackColor = false;
            BotonGestionarCItas.Click += button5_Click;
            // 
            // BotonAgendaYAtencion
            // 
            BotonAgendaYAtencion.BackColor = Color.Transparent;
            BotonAgendaYAtencion.Dock = DockStyle.Top;
            BotonAgendaYAtencion.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            BotonAgendaYAtencion.FlatAppearance.BorderSize = 0;
            BotonAgendaYAtencion.FlatAppearance.MouseOverBackColor = Color.FromArgb(91, 136, 150);
            BotonAgendaYAtencion.FlatStyle = FlatStyle.Flat;
            BotonAgendaYAtencion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotonAgendaYAtencion.ForeColor = Color.FromArgb(185, 218, 233);
            BotonAgendaYAtencion.Location = new Point(0, 219);
            BotonAgendaYAtencion.Margin = new Padding(0, 8, 0, 0);
            BotonAgendaYAtencion.Name = "BotonAgendaYAtencion";
            BotonAgendaYAtencion.Padding = new Padding(18, 0, 0, 0);
            BotonAgendaYAtencion.Size = new Size(262, 30);
            BotonAgendaYAtencion.TabIndex = 6;
            BotonAgendaYAtencion.Text = "Atencion";
            BotonAgendaYAtencion.TextAlign = ContentAlignment.MiddleLeft;
            BotonAgendaYAtencion.UseVisualStyleBackColor = false;
            BotonAgendaYAtencion.Click += button1_Click;
            // 
            // PanelSubmenuGestion
            // 
            PanelSubmenuGestion.BackColor = Color.FromArgb(185, 218, 233);
            PanelSubmenuGestion.Controls.Add(button1);
            PanelSubmenuGestion.Controls.Add(BotonGestionarDoctores);
            PanelSubmenuGestion.Controls.Add(BotonGestionarPacientes);
            PanelSubmenuGestion.Dock = DockStyle.Top;
            PanelSubmenuGestion.Location = new Point(0, 124);
            PanelSubmenuGestion.Margin = new Padding(3, 2, 3, 2);
            PanelSubmenuGestion.Name = "PanelSubmenuGestion";
            PanelSubmenuGestion.Size = new Size(262, 95);
            PanelSubmenuGestion.TabIndex = 5;
            PanelSubmenuGestion.Paint += PanelSubmenuRegistrarPacientes_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 225, 231);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(45, 91, 103);
            button1.Location = new Point(0, 60);
            button1.Margin = new Padding(0, 8, 0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(35, 0, 0, 0);
            button1.Size = new Size(262, 30);
            button1.TabIndex = 7;
            button1.Text = "Gestion de citas";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // BotonGestionarDoctores
            // 
            BotonGestionarDoctores.BackColor = Color.Transparent;
            BotonGestionarDoctores.Dock = DockStyle.Top;
            BotonGestionarDoctores.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            BotonGestionarDoctores.FlatAppearance.BorderSize = 0;
            BotonGestionarDoctores.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 225, 231);
            BotonGestionarDoctores.FlatStyle = FlatStyle.Flat;
            BotonGestionarDoctores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotonGestionarDoctores.ForeColor = Color.FromArgb(45, 91, 103);
            BotonGestionarDoctores.Location = new Point(0, 30);
            BotonGestionarDoctores.Margin = new Padding(0, 8, 0, 0);
            BotonGestionarDoctores.Name = "BotonGestionarDoctores";
            BotonGestionarDoctores.Padding = new Padding(35, 0, 0, 0);
            BotonGestionarDoctores.Size = new Size(262, 30);
            BotonGestionarDoctores.TabIndex = 1;
            BotonGestionarDoctores.Text = "Gestion de doctores";
            BotonGestionarDoctores.TextAlign = ContentAlignment.MiddleLeft;
            BotonGestionarDoctores.UseVisualStyleBackColor = false;
            BotonGestionarDoctores.Click += BotonGestionarTrabajador_Click;
            // 
            // BotonGestionarPacientes
            // 
            BotonGestionarPacientes.BackColor = Color.Transparent;
            BotonGestionarPacientes.Dock = DockStyle.Top;
            BotonGestionarPacientes.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            BotonGestionarPacientes.FlatAppearance.BorderSize = 0;
            BotonGestionarPacientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 225, 231);
            BotonGestionarPacientes.FlatStyle = FlatStyle.Flat;
            BotonGestionarPacientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotonGestionarPacientes.ForeColor = Color.FromArgb(45, 91, 103);
            BotonGestionarPacientes.Location = new Point(0, 0);
            BotonGestionarPacientes.Margin = new Padding(0, 8, 0, 0);
            BotonGestionarPacientes.Name = "BotonGestionarPacientes";
            BotonGestionarPacientes.Padding = new Padding(35, 0, 0, 0);
            BotonGestionarPacientes.Size = new Size(262, 30);
            BotonGestionarPacientes.TabIndex = 6;
            BotonGestionarPacientes.Text = "Gestion de pacientes";
            BotonGestionarPacientes.TextAlign = ContentAlignment.MiddleLeft;
            BotonGestionarPacientes.UseVisualStyleBackColor = false;
            BotonGestionarPacientes.Click += BotonGestionarPaciente_Click;
            // 
            // BotonGestionar
            // 
            BotonGestionar.BackColor = Color.Transparent;
            BotonGestionar.Dock = DockStyle.Top;
            BotonGestionar.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            BotonGestionar.FlatAppearance.BorderSize = 0;
            BotonGestionar.FlatAppearance.MouseOverBackColor = Color.FromArgb(91, 136, 150);
            BotonGestionar.FlatStyle = FlatStyle.Flat;
            BotonGestionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotonGestionar.ForeColor = Color.FromArgb(185, 218, 233);
            BotonGestionar.Location = new Point(0, 94);
            BotonGestionar.Margin = new Padding(0, 8, 0, 0);
            BotonGestionar.Name = "BotonGestionar";
            BotonGestionar.Padding = new Padding(18, 0, 0, 0);
            BotonGestionar.Size = new Size(262, 30);
            BotonGestionar.TabIndex = 1;
            BotonGestionar.Text = "Gestión ";
            BotonGestionar.TextAlign = ContentAlignment.MiddleLeft;
            BotonGestionar.UseVisualStyleBackColor = false;
            BotonGestionar.Click += BotonGestionar_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.Transparent;
            PanelLogo.Controls.Add(LblMedicore);
            PanelLogo.Controls.Add(pictureBox1);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Margin = new Padding(3, 2, 3, 2);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(262, 94);
            PanelLogo.TabIndex = 0;
            PanelLogo.Paint += panel1_Paint;
            // 
            // LblMedicore
            // 
            LblMedicore.AutoSize = true;
            LblMedicore.Font = new Font("Century", 18F, FontStyle.Bold);
            LblMedicore.ForeColor = Color.FromArgb(185, 218, 233);
            LblMedicore.Location = new Point(81, 58);
            LblMedicore.Name = "LblMedicore";
            LblMedicore.Size = new Size(129, 28);
            LblMedicore.TabIndex = 1;
            LblMedicore.Text = "MediCore";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 17);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.White;
            PanelContenedor.Controls.Add(pictureBox2);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.ForeColor = SystemColors.ControlLightLight;
            PanelContenedor.Location = new Point(262, 30);
            PanelContenedor.Margin = new Padding(3, 2, 3, 2);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(849, 570);
            PanelContenedor.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(258, 195);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(439, 273);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // PanelTitleBar
            // 
            PanelTitleBar.BackColor = Color.FromArgb(45, 91, 103);
            PanelTitleBar.Controls.Add(BotonMaximizar);
            PanelTitleBar.Controls.Add(BotonSalir);
            PanelTitleBar.Controls.Add(BotonMinimizar);
            PanelTitleBar.Controls.Add(pictureBox3);
            PanelTitleBar.Controls.Add(label1);
            PanelTitleBar.Dock = DockStyle.Top;
            PanelTitleBar.Location = new Point(0, 0);
            PanelTitleBar.Margin = new Padding(3, 2, 3, 2);
            PanelTitleBar.Name = "PanelTitleBar";
            PanelTitleBar.Size = new Size(1111, 30);
            PanelTitleBar.TabIndex = 3;
            PanelTitleBar.MouseDown += PanelTitleBar_MouseDown;
            // 
            // BotonMaximizar
            // 
            BotonMaximizar.Anchor = AnchorStyles.Right;
            BotonMaximizar.BackColor = Color.FromArgb(45, 91, 103);
            BotonMaximizar.BackgroundImageLayout = ImageLayout.Zoom;
            BotonMaximizar.FlatAppearance.BorderSize = 0;
            BotonMaximizar.FlatStyle = FlatStyle.Flat;
            BotonMaximizar.Image = (Image)resources.GetObject("BotonMaximizar.Image");
            BotonMaximizar.Location = new Point(1036, 4);
            BotonMaximizar.Margin = new Padding(3, 2, 3, 2);
            BotonMaximizar.Name = "BotonMaximizar";
            BotonMaximizar.Size = new Size(35, 22);
            BotonMaximizar.TabIndex = 4;
            BotonMaximizar.UseVisualStyleBackColor = false;
            BotonMaximizar.Click += button12_Click;
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
            BotonSalir.Location = new Point(1074, 4);
            BotonSalir.Margin = new Padding(3, 2, 3, 2);
            BotonSalir.Name = "BotonSalir";
            BotonSalir.Size = new Size(35, 22);
            BotonSalir.TabIndex = 3;
            BotonSalir.UseVisualStyleBackColor = false;
            BotonSalir.Click += BotonSalir_Click;
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
            BotonMinimizar.Location = new Point(996, 4);
            BotonMinimizar.Margin = new Padding(3, 2, 3, 2);
            BotonMinimizar.Name = "BotonMinimizar";
            BotonMinimizar.Padding = new Padding(0, 6, 0, 6);
            BotonMinimizar.Size = new Size(35, 22);
            BotonMinimizar.TabIndex = 2;
            BotonMinimizar.UseVisualStyleBackColor = false;
            BotonMinimizar.Click += button1_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(7, 4);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(18, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(124, 162, 177);
            label1.Location = new Point(31, 7);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Medicore";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1111, 600);
            Controls.Add(PanelContenedor);
            Controls.Add(MenuLateral);
            Controls.Add(PanelTitleBar);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(831, 450);
            Name = "FormMenu";
            Text = "A";
            WindowState = FormWindowState.Maximized;
            MenuLateral.ResumeLayout(false);
            PanelSubMenuAgenda.ResumeLayout(false);
            PanelSubmenuGestion.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelTitleBar.ResumeLayout(false);
            PanelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Panel MenuLateral;
        private Button BotonGestionar;
        private Panel PanelSubmenuGestion;
        private Button BotonGestionarDoctores;
        private Panel PanelSubMenuAgenda;
        private Button button2;
        private Button BotonGestionarPacientes;
        private Button BotonRecepcion;
        private Button BotonGestionarCItas;
        private Button BotonAgendaYAtencion;
        private Panel PanelContenedor;
        private Panel PanelLogo;
        private PictureBox pictureBox1;
        private Label LblMedicore;
        private Panel PanelTitleBar;
        private Label label1;
        private Button BotonMaximizar;
        private Button BotonMinimizar;
        private PictureBox pictureBox3;
        private Button BotonSalir;
        private PictureBox pictureBox2;
        private Button button1;
    }
}
