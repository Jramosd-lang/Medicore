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
        EventoHistorialService repoHisto = new EventoHistorialService();  // Added instance of EventoHistorialRepository  
        public int id = 2;
        public FormularioHistorial()
        {
            InitializeComponent();
        }

        private void FormularioHistorial_Load(object sender, EventArgs e)
        {
            cargarHistorialMedico();
        }

        private void cargarHistorialMedico()
        {
        
        }
    }
}
