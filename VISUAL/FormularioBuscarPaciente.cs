using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using Entity;

namespace VISUAL
{
    public partial class FormularioBuscarPaciente : Form
    {
        PacienteService pacienteService = new PacienteService();
        public Paciente PacienteResult { get; private set; }
        private List<Paciente> listaPacientes = new List<Paciente>();

        public FormularioBuscarPaciente()
        {
            InitializeComponent();
        }

        private void FormularioBuscarPaciente_Load(object sender, EventArgs e)
        {
            listaPacientes = pacienteService.Consultar();
            dataGridView1.DataSource = listaPacientes;
            ConfigurarTabla();
        }

        private void ConfigurarTabla()
        {
            // Oculta la columna Id
            if (dataGridView1.Columns.Contains("Id"))
                dataGridView1.Columns["Id"].Visible = false;

            // Encabezados personalizados
            dataGridView1.Columns["Ocupacion"].HeaderText = "Ocupación";
            dataGridView1.Columns["Religion"].HeaderText = "Religión";
            dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
            dataGridView1.Columns["Apellido"].HeaderText = "Apellido";
            dataGridView1.Columns["FechaNacimiento"].HeaderText = "Fecha de nacimiento";
            dataGridView1.Columns["NumeroDocumento"].HeaderText = "Número de documento";
            dataGridView1.Columns["TipoDocumento"].HeaderText = "Tipo de documento";
            dataGridView1.Columns["Correo"].HeaderText = "Correo";
            dataGridView1.Columns["Telefono"].HeaderText = "Teléfono";
            dataGridView1.Columns["Sexo"].HeaderText = "Sexo";

            // Ajuste visual moderno y proporcional
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataGridView1.Columns["Correo"].FillWeight = 160;
            dataGridView1.Columns["Nombre"].FillWeight = 110;
            dataGridView1.Columns["Apellido"].FillWeight = 110;
            dataGridView1.Columns["Ocupacion"].FillWeight = 90;
            dataGridView1.Columns["Religion"].FillWeight = 90;
            dataGridView1.Columns["FechaNacimiento"].FillWeight = 100;
            dataGridView1.Columns["NumeroDocumento"].FillWeight = 110;
            dataGridView1.Columns["TipoDocumento"].FillWeight = 100;
            dataGridView1.Columns["Telefono"].FillWeight = 100;
            dataGridView1.Columns["Sexo"].FillWeight = 80;

            // Alineación y formato
            dataGridView1.Columns["NumeroDocumento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["FechaNacimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["FechaNacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Solo lectura
            dataGridView1.ReadOnly = true;

            // Estilos visuales
            Color miColor = Color.FromArgb(185, 218, 233);
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(45, 91, 103);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = miColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 91, 103);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.ColumnHeadersHeight = 32;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var texto = textBox1.Text.Trim().ToLower();
            var filtrados = string.IsNullOrEmpty(texto)
                ? listaPacientes
                : listaPacientes.Where(p =>
                    (p.Ocupacion ?? "").ToLower().Contains(texto) ||
                    (p.Religion ?? "").ToLower().Contains(texto) ||
                    (p.Nombre ?? "").ToLower().Contains(texto) ||
                    (p.Apellido ?? "").ToLower().Contains(texto) ||
                    p.FechaNacimiento.ToString("dd/MM/yyyy").Contains(texto) ||
                    (p.NumeroDocumento ?? "").ToLower().Contains(texto) ||
                    (p.TipoDocumento ?? "").ToLower().Contains(texto) ||
                    (p.Correo ?? "").ToLower().Contains(texto) ||
                    (p.Telefono ?? "").ToLower().Contains(texto) ||
                    (p.Sexo ?? "").ToLower().Contains(texto)
                ).ToList();

            dataGridView1.DataSource = filtrados;
            ConfigurarTabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Paciente paciente = seleccionarPaciente();
            if (paciente != null)
            {
                PacienteResult = paciente;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un paciente", "Selección requerida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Paciente seleccionarPaciente()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Busca la columna Id aunque esté oculta
                int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                Paciente paciente = pacienteService.BuscarId(id);
                return paciente;
            }
            return null;
        }
    }
}