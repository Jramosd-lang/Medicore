using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace VISUAL
{
    public partial class FormularioGestionDoctores : Form
    {
        private int identificacion;
        public FormularioGestionDoctores()
        {
            InitializeComponent();
            BotonModificar.Visible = false;

        }

        public FormularioGestionDoctores(Doctor doctor)
        {
            InitializeComponent();
            mostrarDatos(doctor);
            BotonAgregar.Visible = false;
            identificacion = doctor.Id;
        }


        private void mostrarDatos(Doctor doctor)
        {
            // Manejo seguro de nombres y apellidos con posibles espacios faltantes
            string[] nombres = doctor.Nombre?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
            string[] apellidos = doctor.Apellido?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

            txtPrimerNombre.Text = nombres.Length > 0 ? nombres[0] : string.Empty;
            txtSegundoNombre.Text = nombres.Length > 1 ? nombres[1] : string.Empty;
            txtPrimerApellido.Text = apellidos.Length > 0 ? apellidos[0] : string.Empty;
            txtSegundoApellido.Text = apellidos.Length > 1 ? apellidos[1] : string.Empty;
            dateNacimiento.Value = doctor.FechaNacimiento;
            txtNumDoc.Text = doctor.NumeroDocumento;
            ComboBoxTipoDoc.Text = doctor.TipoDocumento;
            txtEspecialidad.Text = doctor.Especialidad;
            txtNroLicencia.Text = doctor.NumeroLicencia;
            txtCorreo.Text = doctor.Correo;
            txtTelefono.Text = doctor.Telefono;
            ComboBoxSexo.Text = doctor.Sexo;
        }





        private void BotonAgregarDoctores_click(object sender, EventArgs e)
        {
            agregarDoctor();
            this.Close();
            GestionDoctores gestionDoctores = new GestionDoctores();
            gestionDoctores.CargarDoctores();

        }

        private void agregarDoctor()
        {
            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtPrimerNombre.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNumDoc.Text) ||
                string.IsNullOrWhiteSpace(ComboBoxTipoDoc.Text) ||
                string.IsNullOrWhiteSpace(txtEspecialidad.Text) ||
                string.IsNullOrWhiteSpace(txtNroLicencia.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(ComboBoxSexo.Text))
            {
                MessageBox.Show("Debe completar todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = 1;
            string nombre = txtPrimerNombre.Text + " " + txtSegundoNombre.Text;
            string apellido = txtPrimerApellido.Text + " " + txtSegundoApellido.Text;
            DateTime fechaNac = DateTime.Parse(dateNacimiento.Text);
            string numeroDoc = txtNumDoc.Text;
            string tipoDoc = ComboBoxTipoDoc.Text;
            string especialidad = txtEspecialidad.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string sexo = ComboBoxSexo.Text;
            string password = txtNumDoc.Text;
            string numeroLicencia = txtNroLicencia.Text;

            Doctor doctor = new Doctor(
                id,
                nombre,
                apellido,
                fechaNac,
                numeroDoc,
                tipoDoc,
                correo,
                telefono,
                especialidad,
                numeroLicencia,
                password,
                sexo);

            DoctorService doctorService = new DoctorService();

            MessageBox.Show(doctorService.Agregar(doctor));
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void modificar(object sender, EventArgs e)
        {

            string nombre = txtPrimerNombre.Text + " " + txtSegundoNombre.Text;
            string apellido = txtPrimerApellido.Text + " " + txtSegundoApellido.Text;
            DateTime fechaNac = DateTime.Parse(dateNacimiento.Text);
            string numeroDoc = txtNumDoc.Text;
            string tipoDoc = ComboBoxTipoDoc.Text;
            string especialidad = txtEspecialidad.Text;
            string numeroLicencia = txtNroLicencia.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string password = numeroDoc;
            string sexo = ComboBoxSexo.Text;



            Doctor doctor = new Doctor(
                identificacion,
                nombre,
                apellido,
                fechaNac,
                numeroDoc,
                tipoDoc,
                correo,
                telefono,
                especialidad,
                numeroLicencia,
                password,
                sexo);

            DoctorService doctorService = new DoctorService();



            doctorService.Modificar(doctor);
            this.Close();


        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {

            modificar(sender, e);

        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No se acepta la tecla
            }
        }

        private void LblDocumento_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxPreTelefono_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
