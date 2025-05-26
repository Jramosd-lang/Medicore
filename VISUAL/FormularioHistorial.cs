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
    public partial class FormularioHistorial : Form
    {
        EventoHistorialService eventoHistorialMedico = new EventoHistorialService();
        CitaService citaService = new CitaService();
        PacienteService pacienteService = new PacienteService();
        EventoHistorialService repoHisto = new EventoHistorialService();  // Added instance of EventoHistorialRepository  
        public int id;
        public FormularioHistorial(int id)
        {
            InitializeComponent();
            this.id = id;
        }


        private void FormularioHistorial_Load(object sender, EventArgs e)
        {
            cargarHistorialMedico();
        }

        private void cargarHistorialMedico()
        {
            DataTable datos = citaService.obtenerCitasConfirmadasHoy(id);
            dataGridView1.DataSource = datos;
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            int id = seleccionarPaciente().IdCita;
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


    }
}
