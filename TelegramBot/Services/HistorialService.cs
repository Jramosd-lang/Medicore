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

            // Retorna la ruta real al PDF (puede ser una URL o una ruta local)
            return await Task.FromResult(paciente.RutaHistorialPdf);
        }
    }
}
