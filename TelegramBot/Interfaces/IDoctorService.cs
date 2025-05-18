using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.Interfaces
{
    public interface IDoctorService
    {
        /// <summary>
        /// Obtiene el nombre completo del doctor asignado al paciente.
        /// </summary>
        Task<string?> GetDoctorByPacienteDocumento(string documento);
    }
}
