using System.Threading.Tasks;
using BLL;
using TelegramBot.Interfaces;

namespace TelegramBot.Services
{
    public class TelegramDoctorService : IDoctorService
    {
        private readonly DoctorService _doctorService = new();

        public async Task<string?> GetDoctorByPacienteDocumento(string documento)
        {
            // Tu sistema trabaja con ID numérico igual que en PacienteService
            if (!int.TryParse(documento, out int id))
                return null;

            // Busca al doctor usando el ID proporcionado
            var doctor = _doctorService.BuscarId(id);

            if (doctor == null)
                return null;

            // Retorna el nombre y apellido concatenados
            return await Task.FromResult($"{doctor.Nombre} {doctor.Apellido}");
        }
    }
}
