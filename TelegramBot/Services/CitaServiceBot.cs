using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entity;
using TelegramBot.Interfaces;

namespace TelegramBot.Services
{
    public class CitaServiceBot : ICitaService
    {
        private readonly CitaService _citaService = new CitaService(); // Ensure correct namespace for BLL.CitaService
        private readonly PacienteService pacienteService = new PacienteService();

        public async Task<string?> GetCitaByPacienteDocument(string documento)
        {
            // Buscar el paciente por documento
            Paciente paciente = pacienteService.BuscarPorNumeroDocumento(documento);

            if (paciente == null)
                return null;

            // Consultar todas las citas
            var citas = _citaService.Consultar(); // Ensure BLL.CitaService has a Consultar method

            // Filtrar las citas que correspondan al paciente
            var citasPaciente = citas.Where(c => c.PacienteId == paciente.Id); // Use paciente.Id instead of pacienteId

            if (!citasPaciente.Any())
                return null;

            // Construir una cadena con la información de las citas
            var sb = new StringBuilder();
            foreach (var cita in citasPaciente)
            {
                sb.AppendLine($"Fecha: {cita.FechaCita:dd/MM/yyyy}");
                sb.AppendLine($"Hora: {cita.HoraCita}");
                sb.AppendLine($"Motivo: {cita.MotivoCita}");
                sb.AppendLine($"Estado: {cita.EstadoCita}");
                sb.AppendLine("-------------------------");
            }

            return await Task.FromResult(sb.ToString().Trim());
        }
    }
}
