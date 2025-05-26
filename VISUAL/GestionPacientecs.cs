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

namespace VISUAL
{
    public partial class GestionPacientecs : Form
    {
        private IService<Paciente> ServicePaciente;
        private List<Paciente> listaPacientes = new List<Paciente>();

        public GestionPacientecs()
        {
            InitializeComponent();
            ServicePaciente = new PacienteService();
        }

        private int btnObtener_ClickId(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var fila = dataGridView1.SelectedRows[0];
                int id = (int)fila.Cells[2].Value;
                return id;
            }
            return 0;
        }

        private Paciente btnObtener_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var fila = dataGridView1.SelectedRows[0];
                int id = (int)fila.Cells[2].Value;
                Paciente paciente = ServicePaciente.BuscarId(id);
                return paciente;
            }
            return null;
        }

        private void GestionPacientecs_Load(object sender, EventArgs e)
        {
            cargarPacientes();
            cargarEstilos();
        }

        private void cargarPacientes()
        {
            listaPacientes = ServicePaciente.Consultar();
            dataGridView1.DataSource = listaPacientes;

            // Cambia los encabezados
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

            // Oculta la columna Id
            dataGridView1.Columns["Id"].Visible = false;

            // Ajuste visual moderno y proporcional
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            // Ajusta el peso relativo de columnas importantes
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

            // Alineación de columnas numéricas y de fecha
            dataGridView1.Columns["NumeroDocumento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["FechaNacimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["FechaNacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Solo lectura para evitar edición directa
            dataGridView1.ReadOnly = true;
        }

        private void cargarEstilos()
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
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.ColumnHeadersHeight = 32;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.RowHeadersVisible = false;

            // Evita que el usuario cambie el tamaño de las filas
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox1.Text.Trim().ToLower();

            var filtrados = listaPacientes.Where(p =>
                (p.Ocupacion ?? "").ToLower().Contains(filtro) ||
                (p.Religion ?? "").ToLower().Contains(filtro) ||
                (p.Nombre ?? "").ToLower().Contains(filtro) ||
                (p.Apellido ?? "").ToLower().Contains(filtro) ||
                p.FechaNacimiento.ToString("dd/MM/yyyy").Contains(filtro) ||
                (p.NumeroDocumento ?? "").ToLower().Contains(filtro) ||
                (p.TipoDocumento ?? "").ToLower().Contains(filtro) ||
                (p.Correo ?? "").ToLower().Contains(filtro) ||
                (p.Telefono ?? "").ToLower().Contains(filtro) ||
                (p.Sexo ?? "").ToLower().Contains(filtro)
            ).ToList();

            dataGridView1.DataSource = filtrados;
            // Vuelve a aplicar los estilos para mantener el formato
            if (filtrados.Count > 0)
                cargarEstilos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Paciente paciente = btnObtener_Click(sender, e);
            if (paciente != null)
            {
                FormularioGestionPaciente formulario = new FormularioGestionPaciente(paciente);
                formulario.ShowDialog();
                cargarPacientes();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun paciente");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormularioGestionPaciente().ShowDialog();
            cargarPacientes();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ServicePaciente.Eliminar(btnObtener_ClickId(sender, e));
            cargarPacientes();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string filtro = textBox1.Text.Trim().ToLower();

            var filtrados = listaPacientes.Where(p =>
                (p.Ocupacion ?? "").ToLower().Contains(filtro) ||
                (p.Religion ?? "").ToLower().Contains(filtro) ||
                (p.Nombre ?? "").ToLower().Contains(filtro) ||
                (p.Apellido ?? "").ToLower().Contains(filtro) ||
                p.FechaNacimiento.ToString("dd/MM/yyyy").Contains(filtro) ||
                (p.NumeroDocumento ?? "").ToLower().Contains(filtro) ||
                (p.TipoDocumento ?? "").ToLower().Contains(filtro) ||
                (p.Correo ?? "").ToLower().Contains(filtro) ||
                (p.Telefono ?? "").ToLower().Contains(filtro) ||
                (p.Sexo ?? "").ToLower().Contains(filtro)
            ).ToList();

            dataGridView1.DataSource = filtrados;
            // Vuelve a aplicar los estilos para mantener el formato
            if (filtrados.Count > 0)
                cargarEstilos();
        }
    }
}
