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
using Org.BouncyCastle.Asn1.Ocsp;

namespace VISUAL
{
    public partial class GestionPacientecs : Form
    {
        private IService<Paciente> ServicePaciente;
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

                int id = (int)fila.Cells[1].Value;
                return id;


            }
            return 0;
        }

        private Paciente btnObtener_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var fila = dataGridView1.SelectedRows[0];

                int id = (int)fila.Cells[1].Value;

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
            dataGridView1.DataSource = ServicePaciente.Consultar();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
}
