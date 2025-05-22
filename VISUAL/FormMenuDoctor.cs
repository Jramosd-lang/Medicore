using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace VISUAL
{
    public partial class FormMenuDoctor : Form
    {
        public FormMenuDoctor(Doctor doctor)
        {
            InitializeComponent();
            id = doctor.Id;
        }

        private Form formulario;

        public int id;

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panel3);
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

        private void EsconderMenu()
        {
            panel3.Visible = false;
        }

        private void FormMenuDoctor_Load(object sender, EventArgs e)
        {
            EsconderMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cambiarPanel(new FormularioHistorial(id));
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

        private void button4_Click(object sender, EventArgs e)
        {
            cambiarPanel(new FormularioCitaDoctor());
        }
    }
}
