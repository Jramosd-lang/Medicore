using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace TelegramBot.Interfaces
{
    public interface IPacienteService
    {
        /// <summary>
        /// Busca un paciente por su número de documento.
        /// Si no se encuentra, devuelve null.
        /// </summary>
        Task<Paciente?> GetByDocumentoAsync(string documento);
    }
}