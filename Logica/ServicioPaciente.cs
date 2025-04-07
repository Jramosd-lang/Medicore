


using Entity;
using Datos;

namespace Logica
{
    public class ServicioPaciente
    {
        public void AddPatient(Paciente paciente)
        {
            if (paciente == null)
            {
                throw new ArgumentNullException(nameof(paciente), "El paciente no puede ser nulo.");
            }

            DatosPaciente datosPaciente = new DatosPaciente();

            paciente.Id = datosPaciente.GenerarNuevoId();
            datosPaciente.GuardarPaciente(paciente);
         

        }

        public List<Paciente> ShowPatients()
        {
            DatosPaciente datosPaciente = new DatosPaciente();
            List<Paciente> pacientes = datosPaciente.mostrarPacientes();
            return pacientes;
        }

        public void DeletePatient(int id)
        {
            DatosPaciente datosPaciente = new DatosPaciente();
            datosPaciente.eliminarPaciente(id);
        }

        public int GenerarId()
        {
            DatosPaciente datosPaciente = new DatosPaciente();
            return datosPaciente.GenerarNuevoId();
        }

        public void modificarPaciente(Paciente paciente)
        {
            if (paciente == null)
            {
                throw new ArgumentNullException(nameof(paciente), "El paciente no puede ser nulo.");
            }
            DatosPaciente datosPaciente = new DatosPaciente();
            datosPaciente.modificarPaciente(paciente);
        }
    }
}
