using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.Interfaces
{
    public interface ICitaService
    {
        Task<string?> GetCitaByPacienteDocument(string documento);
    }
}
