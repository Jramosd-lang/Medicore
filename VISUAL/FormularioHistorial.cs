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
        HistorialMedicoService historialMedicoService = new HistorialMedicoService();
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
            var citaSeleccionada = seleccionarPaciente();
            if (citaSeleccionada != null)
            {
                int id = citaSeleccionada;
                Cita cita = citaService.Consultar().FirstOrDefault(c => c.PacienteId == id);
                HistorialMedico historialMedico = historialMedicoService.BuscarId(cita.PacienteId);
                Form form = new FormularioHistorialMedico(historialMedico);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una cita.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int seleccionarPaciente()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var fila = dataGridView1.SelectedRows[0];
                int id = (int)fila.Cells[0].Value;
                return id;
            }
            return 0;
        }


    }
}
