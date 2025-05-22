using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace VISUAL
{
    public partial class FormJoin : Form
    {
        DoctorService doctorService = new DoctorService();  
        public FormJoin()
        {
            InitializeComponent();
        }

        public int id;



        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void BotonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comprobarInicioSesion();
        }

        private void comprobarInicioSesion()
        {

            if (txtUserName.Text == "admin" && txtPassword.Text == "admin123")
            {
                Form formMenu = new FormMenu();
                formMenu.Show();
                this.Hide();
            }
            else
            {
                if (doctorService.ValidarCredenciales(txtUserName.Text, txtPassword.Text))
                {
                    Doctor doctor = doctorService.BuscarPorNumeroDoc(txtUserName.Text);
                    Form formMenuDoctor = new FormMenuDoctor(doctor);
                    formMenuDoctor.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            
          
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                comprobarInicioSesion();

            }
        }
    }
}
