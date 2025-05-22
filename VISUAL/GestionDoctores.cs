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
    public partial class GestionDoctores : Form
    {
        private IService<Doctor> ServiceDoctor;
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

                int id = (int)fila.Cells[3].Value;

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

                int id = (int)fila.Cells[3].Value;
                return id;


            }
            return 0;
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var fila = dataGridView1.SelectedRows[0];
                // …
            }
        }
        public void CargarDoctores()
        {

            dataGridView1.DataSource = ServiceDoctor.Consultar();
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

          
            
            
            dataGridView1.Columns[6].Visible = false;
            

            // Evita que el usuario cambie el tamaño de las filas
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
            Doctor doctor;
            doctor = btnObtener_Click(sender, e);
            new FormularioGestionDoctores(doctor).ShowDialog();
            CargarDoctores();
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
    }
}
