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
            dataGridView1.DataSource = citaService.Consultar();

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
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
                string ruta = "C:\\Users\\danie\\source\\repos\\Medicore\\PDF-citas\\" +
                    "" + PacienteResult.Id + "-" + fechaSeleccionada.ToString("dd_MM_yyyy") + ".pdf";
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var fila = dataGridView1.SelectedRows[0];
                int id = (int)fila.Cells[0].Value;
                Cita cita = citaService.BuscarId(id);
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
            dataGridView1.Columns[0].FillWeight = 90;
            dataGridView1.Columns[1].FillWeight = 90;
            dataGridView1.Columns[2].FillWeight = 20;


            // Evita que el usuario cambie el tamaño de las filas
            dataGridView1.AllowUserToResizeRows = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            citaService.Eliminar(seleccionarPaciente().IdCita);
            cargarCitas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
            string texto = textBox1.Text.Trim();
            // Obtén la lista completa de citas
            var todasLasCitas = citaService.Consultar();

            // Filtra solo las citas cuyo paciente tiene un número de documento que contiene el texto
            var citasFiltradas = string.IsNullOrEmpty(texto)
                ? todasLasCitas
                : todasLasCitas.Where(cita =>
                {
                    PacienteService pacienteService = new PacienteService();
                    var paciente = pacienteService.BuscarId(cita.PacienteId);
                    return paciente != null && paciente.NumeroDocumento.Contains(texto, StringComparison.OrdinalIgnoreCase);
                }).ToList();

            dataGridView1.DataSource = citasFiltradas;
        
        }
   
    }
}
