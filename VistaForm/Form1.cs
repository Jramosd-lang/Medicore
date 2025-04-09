using System.Windows.Forms.VisualStyles;
using Entity;
using Logica;

namespace VistaForm
{

    public partial class Form1 : Form
    {

        // En Form1.cs, modifica el constructor:
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            panel1.Dock = DockStyle.Fill;

            // Verifica si el archivo existe y llama a CargarPacientes solo si existe
            if (File.Exists("pacientes.txt"))
            {
                CargarPacientes();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int ObtenerFilaSeleccionada()
        {
            if (TablaPacientes.SelectedRows.Count > 0)
            {
                return TablaPacientes.SelectedRows[0].Index;
            }
            return -1;
        }



        private void BotonRegistro_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApe.Text;
            string direccion = txtDireccion.Text;
            string tipoDocumento = comboBoxTipoDoc.SelectedItem.ToString();
            int documento = int.Parse(txtDoc.Text);
            string telefono = txtTelefono.Text;
            DateTime fechaNacimiento = dateTimeFechaN.Value.Date;
            string sexo = comboSexo.Text;
            string alergias = "ninguna";

            string historiaClinica = "n/a";
            string grupoSanguineo = comboBoxGrupoS.SelectedItem.ToString();
            ServicioPaciente servicioPaciente = new ServicioPaciente();
            int id = servicioPaciente.GenerarId(); // Generar un nuevo ID para el paciente


            Entity.Paciente paciente = new Entity.Paciente(id, nombre, apellido, direccion, tipoDocumento, documento, telefono, DateOnly.FromDateTime(fechaNacimiento), sexo, alergias, historiaClinica, grupoSanguineo);





            servicioPaciente.AddPatient(paciente);

            // Aquí puedes agregar el código para guardar el paciente en la base de datos o en un archivo

            // Limpiar los campos después de agregar el paciente

            limpiarCampos();

            MessageBox.Show("Paciente registrado exitosamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarPacientes();


        }

        private void CargarPacientes()
        {
            try
            {
                // Obtenemos los pacientes
                ServicioPaciente servicioPaciente = new ServicioPaciente();
                List<Entity.Paciente> pacientes = servicioPaciente.ShowPatients();

                // Verificamos que la lista no esté vacía
                if (pacientes == null || pacientes.Count == 0)
                {
                    MessageBox.Show("No hay pacientes registrados.", "Información",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Filtramos solo los campos que queremos mostrar
                var pacientesFiltrados = pacientes.Select(p => new
                {
                    ID = p.Id,
                    Nombre = p.Name,
                    Apellido = p.Surname,
                    Documento = p.Document,
                    Teléfono = p.Phone,
                    FechaNacimiento = p.DateOfBirth,
                    Sexo = p.Sex,
                    GrupoSanguíneo = p.bloodType
                }).ToList();

                // Limpiamos cualquier origen de datos previo
                TablaPacientes.DataSource = null;


                TablaPacientes.DataSource = pacientesFiltrados;


                if (TablaPacientes.Columns.Contains("FechaNacimiento"))
                {
                    TablaPacientes.Columns["FechaNacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                // Refrescamos la vista
                TablaPacientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificar(object sender, EventArgs e)
        {
            string nombreModificado = txtNombre.Text;
            string apellidoModificado = txtApe.Text;
            string direccionModificada = txtDireccion.Text;
            string tipoDocumentoModificado = comboBoxTipoDoc.SelectedItem?.ToString() ?? string.Empty;
            int documentoModificado = int.Parse(txtDoc.Text);
            string telefonoModificado = txtTelefono.Text;
            DateTime fechaNacimientoModificada = dateTimeFechaN.Value.Date;
            string sexoModificado = comboSexo.Text;
            string alergiasModificadas = "ninguna";
            string historiaClinicaModificada = "n/a";
            string grupoSanguineoModificado = comboBoxGrupoS.SelectedItem?.ToString() ?? string.Empty;

            int filaSeleccionada = ObtenerFilaSeleccionada(); // ? Corregido aquí

            if (filaSeleccionada != -1)
            {
                int idPaciente = (int)TablaPacientes.Rows[filaSeleccionada].Cells["ID"].Value;

                Paciente pacienteModificado = new Paciente(
                    idPaciente, nombreModificado, apellidoModificado, direccionModificada,
                    tipoDocumentoModificado, documentoModificado, telefonoModificado,
                    DateOnly.FromDateTime(fechaNacimientoModificada), sexoModificado,
                    alergiasModificadas, historiaClinicaModificada, grupoSanguineoModificado
                );

                ServicioPaciente servicioPaciente = new ServicioPaciente();
                servicioPaciente.modificarPaciente(pacienteModificado);

                MessageBox.Show("Paciente modificado exitosamente.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPacientes();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un paciente para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void limpiarCampos()
        {
            txtNombre.Clear();
            txtApe.Clear();
            txtDireccion.Clear();
            txtDoc.Clear();
            txtTelefono.Clear();
            comboBoxTipoDoc.SelectedIndex = -1;
            comboSexo.SelectedIndex = -1;
            comboBoxGrupoS.SelectedIndex = -1;
            dateTimeFechaN.Value = DateTime.Now;
        }

        private void txtApe_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {               
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }

}
