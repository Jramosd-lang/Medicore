using BLL;
using Entity;

namespace VISUAL
{


    public partial class FormularioGestionPaciente : Form
    {
        private int identificacion;

        public FormularioGestionPaciente(Paciente paciente)
        {
            InitializeComponent();
            this.identificacion = paciente.Id;
            BotonAgregar.Visible = false;
            mostrarDatos(paciente);

        }

        public FormularioGestionPaciente()
        {
            InitializeComponent();
            BotonModificar1.Visible = false;

        }

        private void mostrarDatos(Paciente paciente)
        {
            string nombre = paciente.Nombre;
            txtPrimerNombre.Text = nombre.Split(' ')[0];
            if (nombre.Split(' ').Length > 2)
            {
                txtSegundoNombre.Text = nombre.Split(' ')[1];
            }
            else
            {
                txtSegundoNombre.Text = "";
            }

            string apellido = paciente.Apellido.Split(' ')[0];

            if (paciente.Apellido.Split(' ').Length > 2)
            {
                txtSegundoApellido.Text = paciente.Apellido.Split(' ')[1];
            }
            else
            {
                txtSegundoApellido.Text = "";
            }

            txtPrimerApellido.Text = apellido;
            dateNacimiento.Value = paciente.FechaNacimiento;
            txtNumDoc.Text = paciente.NumeroDocumento;
            ComboBoxTipoDoc.Text = paciente.TipoDocumento;
            txtCorreo.Text = paciente.Correo;
            txtTelefono.Text = paciente.Telefono;
            ComboBoxSexo.Text = paciente.Sexo;
            txtOcupacion.Text = paciente.Ocupacion;
            ComboBoxReligion.Text = paciente.Religion;

        }

        private void modificar(object sender, EventArgs e)
        {

            string nombre = txtPrimerNombre.Text + " " + txtSegundoNombre.Text;
            string apellido = txtPrimerApellido.Text + " " + txtSegundoApellido.Text;
            DateTime fechaNac = DateTime.Parse(dateNacimiento.Text);
            string numeroDoc = txtNumDoc.Text;
            string tipoDoc = ComboBoxTipoDoc.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string ocupacion = txtOcupacion.Text;
            string religion = ComboBoxReligion.Text;
            string sexo = ComboBoxSexo.Text;

            if(nombre == "" || apellido == "" || fechaNac == null || numeroDoc == "" || tipoDoc == "" || correo == "" || telefono == "" || ocupacion == "" || religion == "" || sexo == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Paciente doctor = new Paciente(
                identificacion,
                nombre,
                apellido,
                fechaNac,
                numeroDoc,
                tipoDoc,
                correo,
                telefono,
                ocupacion,
                religion,
                sexo
                );

            PacienteService pacienteService = new PacienteService();



            MessageBox.Show(pacienteService.Modificar(doctor));
            this.Close();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }



        private void BotonSalir_Click(object sender, EventArgs e)
        {

        }

        private void GroupBoxHistorial_Enter(object sender, EventArgs e)
        {

        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            agregarPaciente();
            this.Close();
        }

        private void agregarPaciente()
        {
            int id = 1;
            string nombre = txtPrimerNombre.Text + " " + txtSegundoNombre.Text;
            string apellido = txtPrimerApellido.Text + " " + txtSegundoApellido.Text;
            DateTime fechaNac = DateTime.Parse(dateNacimiento.Text);
            string numeroDoc = txtNumDoc.Text;
            string tipoDoc = ComboBoxTipoDoc.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string religion = ComboBoxReligion.Text;
            string ocupacion = txtOcupacion.Text;
            string sexo = ComboBoxSexo.Text;

            if(nombre == "" || apellido == "" || fechaNac == null || numeroDoc == "" || tipoDoc == "" || correo == "" || telefono == "" || ocupacion == "" || religion == "" || sexo == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Paciente paciente = new Paciente(
                id,
                nombre,
                apellido,
                fechaNac,
                numeroDoc,
                tipoDoc,
                correo,
                telefono,
                ocupacion,
                religion,
                sexo);

            PacienteService pacienteService = new PacienteService();

            MessageBox.Show(pacienteService.Agregar(paciente));
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            modificar(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No se acepta la tecla
            }
        }
    }
}
