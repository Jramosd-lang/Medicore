using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using TelegramBot.Interfaces;
using TelegramBot.Models;

namespace TelegramBot.Services
{
    public class TelegramCitaService : ICitaService
    {
        private readonly CitaService _citaService = new();
        private readonly DoctorService _doctorService = new();
        private readonly PacienteService _pacienteService = new();

        public async Task<List<CitaDto>> GetCitasPorPacienteAsync(string numeroDocumento)
        {
            var paciente = _pacienteService.BuscarPorNumeroDocumento(numeroDocumento);
            if (paciente == null) return new List<CitaDto>();

            var citas = _citaService.ConsultarPorPacienteId(paciente.Id); // método explicado abajo

            var result = citas.Select(c =>
            {
                var doctor = _doctorService.BuscarId(c.DoctorId);
                return new CitaDto
                {
                    Fecha = c.FechaCita,
                    Hora = c.HoraCita,
                    NombreDoctor = doctor != null ? $"{doctor.Nombre} {doctor.Apellido}" : "No asignado",
                    Motivo = c.MotivoCita,
                    Estado = c.EstadoCita
                };
            }).ToList();

            return await Task.FromResult(result);
        }
    }
}
