using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace VISUAL
{
    public partial class FormularioHistorialMedico : Form
    {
        private HistorialMedico historialMedico;
        public FormularioHistorialMedico(HistorialMedico historialMedico)
        {
            InitializeComponent();
            this.historialMedico = historialMedico;
        }

        private void FormularioHistorialMedico_Load(object sender, EventArgs e)
        {
            mostrarDatos(historialMedico);
        }

        private void mostrarDatos(HistorialMedico historialMedico)
        {
            comboBoxTipoSangre.Items.Add(historialMedico.TipoSangre);
            comboBoxAlergias.Items.Add(historialMedico.Alergias);
            comboBoxEnfermedadesCronicas.Items.Add(historialMedico.EnfermedadesCronicas);
            comboBoxMedicamentosActuales.Items.Add(historialMedico.MedicamentosActuales);
            comboBoxAntecedentesFamiliares.Items.Add(historialMedico.AntecedentesFamiliares);
            comboBoxVacunas.Items.Add(historialMedico.Vacunas);

        }


    }
}
