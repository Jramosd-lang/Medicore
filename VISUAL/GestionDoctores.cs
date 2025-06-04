using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using Entity;

namespace VISUAL
{
    public partial class GestionDoctores : Form
    {
        private IService<Doctor> ServiceDoctor;
        private List<Doctor> listaDoctores = new List<Doctor>();

        public GestionDoctores()
        {
            InitializeComponent();
            ServiceDoctor = new DoctorService();
        }

        private Doctor btnObtener_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var fila = dataGridView1.SelectedRows[0];
                int id = (int)fila.Cells["Id"].Value;
                Doctor doctor = ServiceDoctor.BuscarId(id);
                return doctor;
            }
            return null;
        }

        private int btnObtener_ClickId(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var fila = dataGridView1.SelectedRows[0];
                int id = (int)fila.Cells["Id"].Value;
                return id;
            }
            return 0;
        }

        public void CargarDoctores()
        {
            listaDoctores = ServiceDoctor.Consultar();
            dataGridView1.DataSource = listaDoctores;
            ConfigurarTabla();
        }

        private void ConfigurarTabla()
        {
            // Encabezados personalizados
            dataGridView1.Columns["Especialidad"].HeaderText = "Especialidad";
            dataGridView1.Columns["NumeroLicencia"].HeaderText = "Número Licencia";
            dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
            dataGridView1.Columns["Apellido"].HeaderText = "Apellido";
            dataGridView1.Columns["FechaNacimiento"].HeaderText = "Fecha de nacimiento";
            dataGridView1.Columns["NumeroDocumento"].HeaderText = "Número de documento";
            dataGridView1.Columns["TipoDocumento"].HeaderText = "Tipo de documento";
            dataGridView1.Columns["Correo"].HeaderText = "Correo";
            dataGridView1.Columns["Telefono"].HeaderText = "Teléfono";
            dataGridView1.Columns["Sexo"].HeaderText = "Sexo";

            // Oculta columnas no deseadas
            if (dataGridView1.Columns.Contains("Id"))
                dataGridView1.Columns["Id"].Visible = false;
            if (dataGridView1.Columns.Contains("Password"))
                dataGridView1.Columns["Password"].Visible = false;

            // Ajuste visual moderno y proporcional
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataGridView1.Columns["Correo"].FillWeight = 160;
            dataGridView1.Columns["Nombre"].FillWeight = 110;
            dataGridView1.Columns["Apellido"].FillWeight = 110;
            dataGridView1.Columns["Especialidad"].FillWeight = 110;
            dataGridView1.Columns["NumeroLicencia"].FillWeight = 100;
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

        private void GestionDoctores_Load(object sender, EventArgs e)
        {
            CargarDoctores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void cargarFormulario()
        {
            new FormularioGestionDoctores().ShowDialog();
            CargarDoctores();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            Doctor doctor = btnObtener_Click(sender, e);
            if (doctor != null)
            {
                new FormularioGestionDoctores(doctor).ShowDialog();
                CargarDoctores();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eliminar(btnObtener_ClickId(sender, e));
        }

        private void eliminar(int id)
        {
            ServiceDoctor.Eliminar(id);
            CargarDoctores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox1.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filtro))
            {
                dataGridView1.DataSource = listaDoctores;
            }
            else
            {
                var doctoresFiltrados = listaDoctores.Where(d =>
                    (d.Nombre ?? "").ToLower().Contains(filtro) ||
                    (d.Apellido ?? "").ToLower().Contains(filtro) ||
                    (d.NumeroDocumento ?? "").ToLower().Contains(filtro) ||
                    (d.TipoDocumento ?? "").ToLower().Contains(filtro) ||
                    (d.Especialidad ?? "").ToLower().Contains(filtro) ||
                    (d.NumeroLicencia ?? "").ToLower().Contains(filtro) ||
                    (d.Correo ?? "").ToLower().Contains(filtro) ||
                    (d.Telefono ?? "").ToLower().Contains(filtro) ||
                    (d.Sexo ?? "").ToLower().Contains(filtro) ||
                    d.FechaNacimiento.ToString("dd/MM/yyyy").Contains(filtro)
                ).ToList();
                dataGridView1.DataSource = doctoresFiltrados;
            }
            ConfigurarTabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
