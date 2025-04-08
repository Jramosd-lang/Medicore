


using System.Runtime.CompilerServices;

using Entity;
using Microsoft.VisualBasic;

namespace Datos
{
    public class DatosPaciente
    {
        private string filePath = "pacientes.txt";
        

        public void GuardarPaciente(Paciente paciente)
        {
            
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                { 
                    writer.WriteLine($"{paciente.Id},{paciente.Name},{paciente.Surname},{paciente.Address},{paciente.typeDocument},{paciente.Document},{paciente.Phone},{paciente.DateOfBirth},{paciente.Sex},{paciente.allergies},{paciente.medicalHistory},{paciente.bloodType}");
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar incapacidad: {ex.Message}");
            }
        }

        public List<Paciente> mostrarPacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();
            try
            {

                if (!File.Exists(filePath))
                {
                    // Crear el archivo vacío
                    using (File.Create(filePath)) { }
                    return pacientes; // Devolver lista vacía
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        Paciente paciente = new Paciente(
                            int.Parse(data[0]),
                            data[1],
                            data[2],
                            data[3],
                            data[4],
                            int.Parse(data[5]),
                            data[6],
                            DateOnly.Parse(data[7]),
                            data[8],
                            data[9],
                            data[10],
                            data[11]
                        );
                        pacientes.Add(paciente);
                        

                    }
                }

                return pacientes;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al mostrar pacientes: {ex.Message}");
            }
            
        }

        public void eliminarPaciente(int id)
        {
            try
            {
                List<string> lines = new List<string>(File.ReadAllLines(filePath));
                lines.RemoveAll(line => line.StartsWith(id.ToString() + ","));
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar paciente: {ex.Message}");
            }
        }
        public int GenerarNuevoId()
        {
            List<Paciente> pacientes = mostrarPacientes();
            if (pacientes.Count == 0)
            {
                return 1; // Si no hay pacientes, el primer ID será 1
            }
            else
            {
                return pacientes.Max(p => p.Id) + 1; // Generar un nuevo ID basado en el máximo existente
            }
        }

        public void cargarPacientes(List<Paciente> pacientes)
        {
            
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var paciente in pacientes)
                {
                    
                   writer.WriteLine($"{paciente.Id},{paciente.Name},{paciente.Surname},{paciente.Address},{paciente.typeDocument},{paciente.Document},{paciente.Phone},{paciente.DateOfBirth},{paciente.Sex},{paciente.allergies},{paciente.medicalHistory},{paciente.bloodType}");
                    
                }
            }
        }

        public void modificarPaciente(Paciente paciente) 
        {
            List<Paciente> pacientes = mostrarPacientes();

            // Buscar el índice del paciente que quieres modificar
            int index = pacientes.FindIndex(p => p.Id == paciente.Id);

            if (index != -1)
            {
                // Reemplazar el objeto existente con el modificado
                pacientes[index] = paciente;

                // Guardar la lista modificada
                cargarPacientes(pacientes);
            }

        }

        

    }


}
