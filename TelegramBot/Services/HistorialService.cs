using System.Threading.Tasks;
using BLL;
using TelegramBot.Interfaces;

namespace TelegramBot.Services
{
    public class HistorialService : IHistorialService
    {
        private readonly PacienteService _pacienteService = new();

        public async Task<string> GetHistorialPdfUrl(string documento)
        {
            if (!int.TryParse(documento, out int id))
                return "ID inválido.";

            var paciente = _pacienteService.BuscarId(id);
            if (paciente == null)
                return "Paciente no encontrado.";

            // Si no existe la propiedad, puedes devolver "Sin historial" o agregar luego el campo.
            return await Task.FromResult(paciente.RutaHistorialPdf ?? "Sin historial disponible.");
        }
    }
}
