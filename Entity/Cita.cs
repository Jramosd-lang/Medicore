using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int PacienteId { get; set; }
        public int DoctorId { get; set; }
        public int IdEspecialidad { get; set; }
        public string RutaCita { get; set; }
        public DateTime FechaCita { get; set; }
        public string HoraCita { get; set; }
        public string EstadoCita { get; set; }
        public string MotivoCita { get; set; }
        public string Observaciones { get; set; }


        public Cita(int idCita, int pacienteId, int doctorId, int idEspecialidad,string rutaCita, DateTime fechaCita, string horaCita, string estadoCita, string motivoCita, string observaciones)
        {
            if (string.IsNullOrWhiteSpace(rutaCita))
                throw new ArgumentException("La ruta del PDF no puede estar vacía.", nameof(rutaCita));
            if (string.IsNullOrWhiteSpace(horaCita))
                throw new ArgumentException("La hora de la cita no puede estar vacía.", nameof(horaCita));
            if (string.IsNullOrWhiteSpace(estadoCita))
                throw new ArgumentException("El estado de la cita no puede estar vacío.", nameof(estadoCita));
            if (string.IsNullOrWhiteSpace(motivoCita))
                throw new ArgumentException("El motivo de la cita no puede estar vacío.", nameof(motivoCita));
            if (fechaCita == default)
                throw new ArgumentException("La fecha de la cita no puede ser la predeterminada.", nameof(fechaCita));

            IdCita = idCita;
            PacienteId = pacienteId;
            DoctorId = doctorId;
            IdEspecialidad = idEspecialidad;
            RutaCita = rutaCita;
            FechaCita = fechaCita;
            HoraCita = horaCita;
            EstadoCita = estadoCita;
            MotivoCita = motivoCita;
            Observaciones = observaciones;
        }

        
       
    }
}
