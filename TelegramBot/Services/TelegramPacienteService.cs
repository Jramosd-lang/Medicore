using System.Threading.Tasks;
using BLL;
using Entity;
using TelegramBot.Interfaces;

namespace TelegramBot.Services
{
    public class TelegramPacienteService : IPacienteService
    {
        private readonly PacienteService _pacienteService = new();

        public async Task<Paciente?> GetByDocumentoAsync(string documento)
        {
            // Busca por NumeroDocumento (string), no por ID
            var paciente = _pacienteService.BuscarPorNumeroDocumento(documento);
            return await Task.FromResult(paciente);
        }

    }
}
