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
            List<Cita> citas = citaService.Consultar();
            MessageBox.Show("Total de citas: " + citas.Count);

            var citasDoctor = citas.Where(c => c.DoctorId == 1).ToList();
            MessageBox.Show("Citas del doctor: " + citasDoctor.Count);

            var pacientesIds = citasDoctor.Select(c => c.PacienteId).Distinct().ToList();
            var listaPacientes = citasDoctor
                .Where(c => pacientesIds.Contains(c.PacienteId))
                .Select(c => new
                {
                    c.PacienteId,
                    c.IdCita,
                    c.FechaCita,
                    c.HoraCita,
                    c.EstadoCita,
                    c.MotivoCita,
                    c.Observaciones
                })
                .ToList();

            MessageBox.Show("Lista para mostrar: " + listaPacientes.Count);
            dataGridView1.DataSource = listaPacientes;
        }



    }
}
