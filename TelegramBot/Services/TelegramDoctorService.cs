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
            if (!int.TryParse(documento, out int id))
                return null;

            // Si aún no tienes la relación paciente-doctor, puedes dejarlo como "No asignado"
            // Si la creas luego, aquí la implementas. Por ahora, busca un doctor con el mismo ID (ejemplo).
            var doctor = _doctorService.BuscarId(id);

            if (doctor == null)
                return null;

            return await Task.FromResult($"{doctor.Nombre} {doctor.Apellido}");
        }
    }
}
