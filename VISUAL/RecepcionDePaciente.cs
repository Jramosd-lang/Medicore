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
    public partial class RecepcionDePaciente : Form
    {
        PacienteService pacienteService = new PacienteService();
        CitaService citaService = new CitaService();
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
                var fila = dataGridView1.SelectedRows[0];

                int id = (int)fila.Cells[0].Value;

               
                return id;


            }
            return -1;
        }

        private void cargarCitas()
        {
            dataGridView1.DataSource = citaService.Consultar();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var texto = textBox1.Text.Trim();
            var tipoSeleccionado = comboBoxTipoDocumento.SelectedItem?.ToString() ?? string.Empty;

            var listaPacientes = pacienteService.Consultar();
            var todos = citaService.Consultar();

            var citasFiltradas = todos
                .Join(
                    listaPacientes,
                    cita => cita.PacienteId,
                    paciente => paciente.Id,
                    (cita, paciente) => new { cita, paciente }
                )
                .Where(x =>
                    x.paciente.NumeroDocumento.Contains(texto) &&
                    (string.IsNullOrEmpty(tipoSeleccionado) || x.paciente.TipoDocumento == tipoSeleccionado)
                )
                .Select(x => x.cita)
                .ToList();

            dataGridView1.DataSource = citasFiltradas;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = seleccionarPaciente();
            CitaService citaService = new CitaService();
            citaService.modificarEstado(id);
            MessageBox.Show("Cita confirmada", "Confirmación",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargarCitas();
        }
    }
}
