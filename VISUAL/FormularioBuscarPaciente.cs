using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace VISUAL
{

    public partial class FormularioBuscarPaciente : Form
    {
        PacienteService pacienteService = new PacienteService();
        public Paciente PacienteResult { get; private set; } 
        public FormularioBuscarPaciente()
        {
            InitializeComponent();
        }

        private void FormularioBuscarPaciente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pacienteService.Consultar();
            cargarEstilos();
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
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dataGridView1.Columns[0].FillWeight = 90;
            dataGridView1.Columns[1].FillWeight = 20;
            dataGridView1.Columns[2].FillWeight = 90;


            // Evita que el usuario cambie el tamaño de las filas
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var texto = textBox1.Text.Trim();

            // Obtén la lista completa una sola vez, no en cada pulsación
            var todos = pacienteService.Consultar();

            // Si no hay filtro, muestro todo; si no, filtro y materializo
            var filtrados = string.IsNullOrEmpty(texto)
                ? todos
                : todos.Where(p => p.NumeroDocumento.Contains(texto))
                       .ToList();

            dataGridView1.DataSource = filtrados;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Paciente paciente = seleccionarPaciente();
            if (paciente != null)
            {
                PacienteResult = paciente;

                // Establece el DialogResult aquí
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un doctor", "Selección requerida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Paciente seleccionarPaciente()
        {


            if (dataGridView1.SelectedRows.Count > 0)
            {
                var fila = dataGridView1.SelectedRows[0];

                int id = (int)fila.Cells[2].Value;

                Paciente paciente = pacienteService.BuscarId(id);
                return paciente;


            }
            return null;
        }
        

    }
}

