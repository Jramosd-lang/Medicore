using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Color = System.Drawing.Color;

namespace VISUAL
{
    public partial class FormularioCitacs : Form
    {
        public FormularioCitacs()
        {
            InitializeComponent();
            QuestPDF.Settings.License = LicenseType.Community;
        }

        EspecialidadCitaService especialidadCitaService = new EspecialidadCitaService();
        CitaService citaService = new CitaService();
        public Paciente PacienteResult { get; private set; }
        public Doctor DoctorResult { get; private set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormularioCitacs_Load(object sender, EventArgs e)
        {
            cargarCitas();
            comboBox1.DataSource = especialidadCitaService.ConsultarNombre();
            estiloTabla();
        }

        private void cargarCitas()
        {
            var pacientes = new PacienteService().Consultar();
            var doctores = new DoctorService().Consultar();
            var especialidades = especialidadCitaService.Consultar();

            var citas = citaService.Consultar()
                .Select(c => new
                {
                    Paciente = pacientes.FirstOrDefault(p => p.Id == c.PacienteId) is Paciente p ? $"{p.Nombre} {p.Apellido}" : "Desconocido",
                    Doctor = doctores.FirstOrDefault(d => d.Id == c.DoctorId) is Doctor d ? $"{d.Nombre} {d.Apellido}" : "Desconocido",
                    Area = especialidades.FirstOrDefault(e => e.id == c.IdEspecialidad)?.nombre ?? "Desconocida",
                    Fecha = c.FechaCita,
                    Hora = c.HoraCita,
                    Estado = c.EstadoCita
                })
                .ToList();

            dataGridView1.DataSource = citas;

            // Personaliza encabezados y formato
            dataGridView1.Columns["Paciente"].HeaderText = "Paciente";
            dataGridView1.Columns["Doctor"].HeaderText = "Doctor";
            dataGridView1.Columns["Area"].HeaderText = "Área";
            dataGridView1.Columns["Fecha"].HeaderText = "Fecha";
            dataGridView1.Columns["Hora"].HeaderText = "Hora";
            dataGridView1.Columns["Estado"].HeaderText = "Estado";

            dataGridView1.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Hora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Doctor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Area"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void botonBuscarPaciente_Click(object sender, EventArgs e)
        {
            using (var form = new FormularioBuscarPaciente())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Paciente paciente = form.PacienteResult;
                    PacienteResult = paciente;
                    MessageBox.Show(paciente.Id + "");
                }
            }
        }

        private void botonBuscarDoctor_Click(object sender, EventArgs e)
        {
            using (var form = new FormularioBuscarDoctor())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Doctor doctor = form.DoctorResult;
                    DoctorResult = doctor;
                    MessageBox.Show(doctor.Id + "");
                }
            }
        }

        private void botonAgregarCita_Click(object sender, EventArgs e)
        {
            AgregarCita();
            citaService.Consultar();
            cargarCitas();
        }

        private void AgregarCita()
        {
            try
            {
                // Validar que PacienteResult y DoctorResult no sean nulos
                if (PacienteResult == null || DoctorResult == null ||
                    string.IsNullOrWhiteSpace(comboBox1.Text) ||
                    string.IsNullOrWhiteSpace(comboBoxHora.Text) ||
                    string.IsNullOrWhiteSpace(txtMotivo.Text) ||
                    string.IsNullOrWhiteSpace(richTextBox1.Text))
                {
                    MessageBox.Show("No se han completado todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fechaSeleccionada = dateTimePicker1.Value;
                string ruta = "C:\\Users\\jr10p\\source\\repos\\Medicore\\PDF-citas" + PacienteResult.Id + "-" + fechaSeleccionada.ToString("dd_MM_yyyy") + ".pdf";
                string especialidad = comboBox1.Text;
                // Buscar la especialidad por nombre y obtener el primer id
                var especialidades = especialidadCitaService.Consultar().Where(e => e.nombre == especialidad).ToList();
                int idEspecialidad = especialidades.Any() ? especialidades.First().id : 0;

                Cita cita = new Cita(
                    0,
                    PacienteResult.Id,
                    DoctorResult.Id,
                    idEspecialidad,
                    ruta,
                    dateTimePicker1.Value,
                    comboBoxHora.Text,
                    "pendiente",
                    txtMotivo.Text,
                    richTextBox1.Text
                );
                PacienteService pacienteService = new PacienteService();
                Paciente paciente = pacienteService.BuscarId(PacienteResult.Id);

                int idPdf = int.Parse(citaService.Agregar(cita));
                Cita? citaPdf = citaService.Consultar().FirstOrDefault(c => c.IdCita == idPdf);
                if (citaPdf == null)
                {
                    MessageBox.Show("No se pudo encontrar la cita recién agregada para generar el PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                EspecialidadCita? especialidadPdf = especialidadCitaService.Consultar().FirstOrDefault(e => e.id == citaPdf.IdEspecialidad);
                if (especialidadPdf == null)
                {
                    MessageBox.Show("No se pudo encontrar la especialidad para la cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var documento = new CitaPdf(citaPdf, paciente, DoctorResult, especialidadPdf);
                documento.GeneratePdf(ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la cita, asegúrese de llenar todos los datos");
            }
        }

        private Cita seleccionarPaciente()
        {
            // Como ya no tienes el IdCita en la grilla, puedes buscar por los datos únicos de la fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var fila = dataGridView1.SelectedRows[0];
                string pacienteNombre = fila.Cells["Paciente"].Value?.ToString();
                string doctorNombre = fila.Cells["Doctor"].Value?.ToString();
                string area = fila.Cells["Area"].Value?.ToString();
                DateTime fecha = (DateTime)fila.Cells["Fecha"].Value;
                string hora = fila.Cells["Hora"].Value?.ToString();

                // Buscar la cita original por coincidencia de datos
                var pacientes = new PacienteService().Consultar();
                var doctores = new DoctorService().Consultar();
                var especialidades = especialidadCitaService.Consultar();

                var cita = citaService.Consultar().FirstOrDefault(c =>
                    $"{pacientes.FirstOrDefault(p => p.Id == c.PacienteId)?.Nombre} {pacientes.FirstOrDefault(p => p.Id == c.PacienteId)?.Apellido}" == pacienteNombre &&
                    $"{doctores.FirstOrDefault(d => d.Id == c.DoctorId)?.Nombre} {doctores.FirstOrDefault(d => d.Id == c.DoctorId)?.Apellido}" == doctorNombre &&
                    especialidades.FirstOrDefault(e => e.id == c.IdEspecialidad)?.nombre == area &&
                    c.FechaCita == fecha &&
                    c.HoraCita == hora
                );
                return cita;
            }
            return null;
        }

        private void estiloTabla()
        {
            Color miColor = Color.FromArgb(185, 218, 233);

            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(45, 91, 103);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = miColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.EnableHeadersVisualStyles = false; // obligatorio para usar colores personalizados
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 91, 103);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // Ajusta el ancho de las columnas principales
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Evita que el usuario cambie el tamaño de las filas
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cita = seleccionarPaciente();
            if (cita != null)
            {
                citaService.Eliminar(cita.IdCita);
                cargarCitas();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string texto = textBox1.Text.Trim().ToLower();

            var pacientes = new PacienteService().Consultar();
            var doctores = new DoctorService().Consultar();
            var especialidades = especialidadCitaService.Consultar();

            var citas = citaService.Consultar()
                .Select(c => new
                {
                    Paciente = pacientes.FirstOrDefault(p => p.Id == c.PacienteId) is Paciente p ? $"{p.Nombre} {p.Apellido}" : "Desconocido",
                    Doctor = doctores.FirstOrDefault(d => d.Id == c.DoctorId) is Doctor d ? $"{d.Nombre} {d.Apellido}" : "Desconocido",
                    Area = especialidades.FirstOrDefault(e => e.id == c.IdEspecialidad)?.nombre ?? "Desconocida",
                    Fecha = c.FechaCita,
                    Hora = c.HoraCita,
                    Estado = c.EstadoCita
                })
                .Where(c =>
                    (c.Paciente ?? "").ToLower().Contains(texto) ||
                    (c.Doctor ?? "").ToLower().Contains(texto) ||
                    (c.Area ?? "").ToLower().Contains(texto) ||
                    c.Fecha.ToString("dd/MM/yyyy").Contains(texto) ||
                    (c.Hora ?? "").ToLower().Contains(texto) ||
                    (c.Estado ?? "").ToLower().Contains(texto)
                )
                .ToList();

            dataGridView1.DataSource = citas;
            estiloTabla();
        }
    }
}
