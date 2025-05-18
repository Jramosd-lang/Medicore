using System.Threading.Tasks;
using BLL;
using Entity;
using TelegramBot.Interfaces;

namespace TelegramBot.Services
{
    public class TelegramPacienteService : IPacienteService
    {
        private readonly PacienteService _pacienteService = new(); // Ya conecta con DAL

        public async Task<Paciente?> GetByDocumentoAsync(string documento)
        {
            if (!int.TryParse(documento, out int id))
                return null;

            // Si tienes BuscarPorDocumento(string doc) en vez de BuscarId(int id), cámbialo aquí.
            var paciente = _pacienteService.BuscarId(id);
            return await Task.FromResult(paciente);
        }
    }
}
