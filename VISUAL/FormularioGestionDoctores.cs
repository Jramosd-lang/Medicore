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
            string nombre = doctor.Nombre;
            txtPrimerNombre.Text = nombre.Split(' ')[0];
            txtSegundoNombre.Text = nombre.Split(' ')[1];
            string apellido = doctor.Apellido.Split(' ')[0];
            string segundoApellido = doctor.Apellido.Split(' ')[1];
            txtPrimerApellido.Text = apellido;
            txtSegundoApellido.Text = segundoApellido;
            dateNacimiento.Value = doctor.FechaNacimiento;
            txtNumDoc.Text = doctor.NumeroDocumento;
            ComboBoxTipoDoc.Text = doctor.TipoDocumento;
            txtEspecialidad.Text = doctor.Especialidad;
            txtNroLicencia.Text = doctor.NumeroLicencia;
            
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
            
            string nombre = txtPrimerNombre.Text + " " + txtSegundoNombre.Text;
            string apellido = txtPrimerApellido.Text + " " + txtSegundoApellido.Text;
            DateTime fechaNac = DateTime.Parse(dateNacimiento.Text);
            string numeroDoc = txtNumDoc.Text;
            string tipoDoc = ComboBoxTipoDoc.Text;
            string especialidad = txtEspecialidad.Text;

            string numeroLicencia = txtNroLicencia.Text;

            Doctor doctor = new Doctor(
                identificacion,
                nombre,
                apellido,
                fechaNac,
                numeroDoc,
                tipoDoc,
                especialidad,
                numeroLicencia);

            DoctorService doctorService = new DoctorService();

            doctorService.Guardar(doctor);

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

            Doctor doctor = new Doctor(
                identificacion,
                nombre,
                apellido,
                fechaNac,
                numeroDoc,
                tipoDoc,
                especialidad,
                numeroLicencia);

            DoctorService doctorService = new DoctorService();

            

            doctorService.Modificar(doctor);
            this.Close();


        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            
            modificar(sender, e);
            
        }
    }
}
