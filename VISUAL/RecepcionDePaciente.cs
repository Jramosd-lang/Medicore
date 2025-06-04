using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using Entity;

namespace VISUAL
{
    public partial class RecepcionDePaciente : Form
    {
        PacienteService pacienteService = new PacienteService();
        CitaService citaService = new CitaService();
        DoctorService doctorService = new DoctorService();

        public RecepcionDePaciente()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            cargarCitas();
        }

        private int seleccionarPaciente()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["IdCita"].Value;
                return id;
            }
            return -1;
        }

        private void cargarCitas()
        {
            var listaPacientes = pacienteService.Consultar();
            var listaCitas = citaService.Consultar();
            var listaDoctores = doctorService.Consultar();

            var datos = listaCitas
                .Join(listaPacientes, c => c.PacienteId, p => p.Id, (c, p) => new { c, p })
                .Join(listaDoctores, cp => cp.c.DoctorId, d => d.Id, (cp, d) => new
                {
                    IdCita = cp.c.IdCita,
                    Paciente = cp.p.Nombre + " " + cp.p.Apellido,
                    NumeroDocumento = cp.p.NumeroDocumento,
                    Doctor = d.Nombre + " " + d.Apellido,
                    Fecha = cp.c.FechaCita,
                    Hora = cp.c.HoraCita,
                    Estado = cp.c.EstadoCita
                })
                .ToList();

            dataGridView1.DataSource = datos;

            if (dataGridView1.Columns.Contains("IdCita"))
                dataGridView1.Columns["IdCita"].Visible = false;

            // Encabezados y formato
            if (dataGridView1.Columns.Contains("Paciente"))
                dataGridView1.Columns["Paciente"].HeaderText = "Paciente";
            if (dataGridView1.Columns.Contains("NumeroDocumento"))
                dataGridView1.Columns["NumeroDocumento"].HeaderText = "N° Documento";
            if (dataGridView1.Columns.Contains("Doctor"))
                dataGridView1.Columns["Doctor"].HeaderText = "Doctor";
            if (dataGridView1.Columns.Contains("Fecha"))
            {
                dataGridView1.Columns["Fecha"].HeaderText = "Fecha";
                dataGridView1.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dataGridView1.Columns.Contains("Hora"))
            {
                dataGridView1.Columns["Hora"].HeaderText = "Hora";
                dataGridView1.Columns["Hora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dataGridView1.Columns.Contains("Estado"))
                dataGridView1.Columns["Estado"].HeaderText = "Estado";

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            estiloTabla();
        }

        private void estiloTabla()
        {
            Color miColor = Color.FromArgb(185, 218, 233);

            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(45, 91, 103);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = miColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 91, 103);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.ColumnHeadersHeight = 32;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var texto = textBox1.Text.Trim().ToLower();

            var listaPacientes = pacienteService.Consultar();
            var listaCitas = citaService.Consultar();
            var listaDoctores = doctorService.Consultar();

            var datos = listaCitas
                .Join(listaPacientes, c => c.PacienteId, p => p.Id, (c, p) => new { c, p })
                .Join(listaDoctores, cp => cp.c.DoctorId, d => d.Id, (cp, d) => new
                {
                    IdCita = cp.c.IdCita,
                    Paciente = cp.p.Nombre + " " + cp.p.Apellido,
                    NumeroDocumento = cp.p.NumeroDocumento,
                    Doctor = d.Nombre + " " + d.Apellido,
                    Fecha = cp.c.FechaCita,
                    Hora = cp.c.HoraCita,
                    Estado = cp.c.EstadoCita
                })
                .Where(x =>
                    (x.Paciente ?? "").ToLower().Contains(texto) ||
                    (x.NumeroDocumento ?? "").ToLower().Contains(texto) ||
                    (x.Doctor ?? "").ToLower().Contains(texto) ||
                    x.Fecha.ToString("dd/MM/yyyy").Contains(texto) ||
                    (x.Hora ?? "").ToLower().Contains(texto) ||
                    (x.Estado ?? "").ToLower().Contains(texto)
                )
                .ToList();

            dataGridView1.DataSource = datos;

            if (dataGridView1.Columns.Contains("IdCita"))
                dataGridView1.Columns["IdCita"].Visible = false;

            // Encabezados y formato (igual que en cargarCitas)
            if (dataGridView1.Columns.Contains("Paciente"))
                dataGridView1.Columns["Paciente"].HeaderText = "Paciente";
            if (dataGridView1.Columns.Contains("NumeroDocumento"))
                dataGridView1.Columns["NumeroDocumento"].HeaderText = "N° Documento";
            if (dataGridView1.Columns.Contains("Doctor"))
                dataGridView1.Columns["Doctor"].HeaderText = "Doctor";
            if (dataGridView1.Columns.Contains("Fecha"))
            {
                dataGridView1.Columns["Fecha"].HeaderText = "Fecha";
                dataGridView1.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dataGridView1.Columns.Contains("Hora"))
            {
                dataGridView1.Columns["Hora"].HeaderText = "Hora";
                dataGridView1.Columns["Hora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dataGridView1.Columns.Contains("Estado"))
                dataGridView1.Columns["Estado"].HeaderText = "Estado";

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            estiloTabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = seleccionarPaciente();
            citaService.modificarEstado(id);
            MessageBox.Show("Cita confirmada", "Confirmación",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargarCitas();
        }
    }
}