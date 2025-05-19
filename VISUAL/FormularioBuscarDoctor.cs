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
using DAL;
using Entity;

namespace VISUAL
{
    public partial class FormularioBuscarDoctor : Form
    {
        DoctorService doctorService = new DoctorService();
        public Doctor DoctorResult;
        public FormularioBuscarDoctor()
        {
            InitializeComponent();
            cargarEstilos();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Doctor doctor = seleccionarDoctor();
            if (doctor != null)
            {
                DoctorResult = doctor;

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



            // Evita que el usuario cambie el tamaño de las filas
            dataGridView1.AllowUserToResizeRows = false;
        }

        private Doctor seleccionarDoctor()
        {


            if (dataGridView1.SelectedRows.Count > 0)
            {
                var fila = dataGridView1.SelectedRows[0];

                int id = (int)fila.Cells[2].Value;

                Doctor doctor = doctorService.BuscarId(id);
                return doctor;


            }
            return null;
        }

        private void FormularioBuscarDoctor_Load(object sender, EventArgs e)
        {
            DoctorService doctorService = new DoctorService();
            dataGridView1.DataSource = doctorService.Consultar();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            var texto = textBox1.Text.Trim();


            var todos = doctorService.Consultar();


            var filtrados = string.IsNullOrEmpty(texto)
                ? todos
                : todos.Where(p => p.NumeroDocumento.Contains(texto))
                       .ToList();

            dataGridView1.DataSource = filtrados;
        }
    }
}
