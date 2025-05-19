using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.Interfaces
{
    public interface IHistorialService
    {
        /// <summary>
        /// Devuelve la ruta o URL al PDF de historial del paciente.
        /// </summary>
        Task<string> GetHistorialPdfUrl(string documento);
    }
}
