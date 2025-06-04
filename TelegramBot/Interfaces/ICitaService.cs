using System.Collections.Generic;
using System.Threading.Tasks;
using TelegramBot.Models;

namespace TelegramBot.Interfaces
{
    public interface ICitaService
    {
        Task<List<CitaDto>> GetCitasPorPacienteAsync(string numeroDocumento);
    }
}
