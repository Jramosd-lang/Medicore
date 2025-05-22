using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HistorialMedico
    {
        public int Id_historial { get; set; }
        public int Id_paciente { get; set; }

        public string TipoSangre { get; set; }
        public string Alergias { get; set; }
        public string EnfermedadesCronicas { get; set; }
        public string MedicamentosActuales { get; set; }
        public string AntecedentesFamiliares { get; set; }
        public string Vacunas { get; set; }

        public HistorialMedico(
            int historialId, 
            int pacienteId,
            string tipoSangre,
            string alergias,
            string enfermedadesCronicas,
            string medicamentosActuales,
            string antecedentesFamiliares,
            string vacunas
            )
        {
            Id_historial = historialId;
            Id_paciente = pacienteId;
            TipoSangre = tipoSangre;
            Alergias = alergias;
            EnfermedadesCronicas = enfermedadesCronicas;
            MedicamentosActuales = medicamentosActuales;
            AntecedentesFamiliares = antecedentesFamiliares;
            Vacunas = vacunas;
        }
    }

}
