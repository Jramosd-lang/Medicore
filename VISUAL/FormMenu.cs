
using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace VISUAL
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            EsconderMenu();
        }

        private Form formulario;

        public void volver(Form formularioHijo)
        {
            if (formulario != null)
            {
                formulario.Close();
            }
            formulario = new FormMenu();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Clear();
            PanelContenedor.Controls.Add(formulario);
            PanelContenedor.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }

        private void seleccionarBoton(Button botonSeleccionado)
        {
            
            Color colorSeleccionado = Color.FromArgb(79,127,140);
            Color colorNormal = Color.FromArgb(185,218,233);

        
            Button[] botones = { BotonGestionarDoctores,
                BotonGestionarImplementos,
                BotonGestionarDinero,
                BotonGestionarCItas,
                BotonRecepcion,
                BotonGestionarPacientes,
                BotonProveedores,
                BotonComunicados};

            
            foreach (Button btn in botones)
            {
                btn.BackColor = (btn == botonSeleccionado) ? colorSeleccionado : colorNormal;
            }
        }
        
        
        private void cambiarPanel(Form formularioHijo)
        {

            if (formulario != null)
            {
                formulario.Close();
            }
            formulario = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Clear();
            PanelContenedor.Controls.Add(formularioHijo);
            PanelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();



        }
        private void EsconderMenu()
        {
            PanelSubMenuApoyo.Visible = false;
            PanelSubmenuGestion.Visible = false;
            PanelSubMenuAgenda.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotonGestionar_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubmenuGestion);
        }

        private void MenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelSubmenuRegistrarPacientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenuAgenda);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotonGestionarPaciente_Click(object sender, EventArgs e)
        {
            cambiarPanel(new GestionPacientecs());
            seleccionarBoton(BotonGestionarPacientes);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cambiarPanel(new RecepcionDePaciente());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cambiarPanel(new FormularioCitacs());
        }

        


        private void BotonGestionarPacientes_Click(object sender, EventArgs e)
        {
            seleccionarBoton(BotonGestionarPacientes);
        }

        private void BotonGestionarTrabajador_Click(object sender, EventArgs e)
        {
            cambiarPanel(new GestionDoctores());
            seleccionarBoton(BotonGestionarDoctores);

        }

        private void BotonGestionarImplementos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no funciona");
            seleccionarBoton(BotonGestionarImplementos);
        }

        private void BotonGestionarDinero_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton aun no funciona");
            seleccionarBoton(BotonGestionarDinero);
        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenuApoyo);
            
        }

        private void PanelSubMenuAgenda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }
    }
}