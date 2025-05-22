using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class CitaRepository : BaseDatos, IRepository<Cita>
    {
        public List<Cita> Consultar()
        {
            string sentencia = "SELECT id_cita," +
                "id_paciente," +
                "id_doctor," +
                "fecha_cita, " +
                "id_especialidad, " +
                "ruta_cita, " +
                "fecha_cita, " +
                "hora_cita," +
                "estado_cita, " +
                "motivo_cita, " +
                "observaciones FROM citas";

            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
            AbrirConexion();
            MySqlDataReader reader = cmd.ExecuteReader();

            List<Cita> lista = new List<Cita>();
            while (reader.Read())
            {
                lista.Add(Mappear(reader));
            }
            CerrarConexion();
            return lista;
        }

        private Cita Mappear(MySqlDataReader reader)
        {
            // Obtén los ordinales una sola vez
            int ordId = reader.GetOrdinal("id_cita");
            int ordIdPaciente = reader.GetOrdinal("id_paciente");
            int ordIdDoctor = reader.GetOrdinal("id_doctor");
            int ordIdEsp = reader.GetOrdinal("id_especialidad");
            int ordFecha = reader.GetOrdinal("fecha_cita");
            int ordRuta = reader.GetOrdinal("ruta_cita");
            int ordHora = reader.GetOrdinal("hora_Cita");
            int ordEst = reader.GetOrdinal("estado_cita");
            int ordMot = reader.GetOrdinal("motivo_cita");
            int ordObs = reader.GetOrdinal("observaciones");
       



            int id = !reader.IsDBNull(ordId)
                ? reader.GetInt32(ordId)
                : throw new InvalidOperationException("id no puede ser nulo");

            int id_paciente = !reader.IsDBNull(ordIdPaciente)
                ? reader.GetInt32(ordIdPaciente)
                : throw new InvalidOperationException("id_paciente no puede ser nulo");

            int id_doctor = !reader.IsDBNull(ordIdDoctor)
                ? reader.GetInt32(ordIdDoctor)
                : throw new InvalidOperationException("id_doctor no puede ser nulo");
            int id_especialidad = !reader.IsDBNull(ordIdEsp)
                ? reader.GetInt32(ordIdEsp)
                : throw new InvalidOperationException("id_especialidad no puede ser nulo");

            DateTime fechaNac = !reader.IsDBNull(ordFecha)
                ? reader.GetDateTime(ordFecha)
                : DateTime.MinValue;

            string numeroDoc = !reader.IsDBNull(ordRuta)
                ? reader.GetString(ordRuta)
                : string.Empty;

            string tipoDoc = !reader.IsDBNull(ordHora)
                ? reader.GetString(ordHora)
                : string.Empty;

            string especialidad = !reader.IsDBNull(ordEst)
                ? reader.GetString(ordEst)
                : string.Empty;

            string numeroLicencia = !reader.IsDBNull(ordMot)
                ? reader.GetString(ordMot)
                : string.Empty;
            string correo = !reader.IsDBNull(ordObs)
                ? reader.GetString(ordObs)
                : string.Empty;
           ;

            return new Cita(id,
                id_paciente,
                id_doctor,
                id_especialidad,
                numeroDoc, 
                fechaNac,
                tipoDoc, 
                especialidad,
                numeroLicencia,
                correo);
        }

        public string Eliminar(int id)
        {
            if (id <= 0)
                return "ID inválido";

            string sentencia = "DELETE FROM citas WHERE id_cita = @Id";

            using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    AbrirConexion();
                    int i = cmd.ExecuteNonQuery();
                    return i > 0 ? "Registro eliminado correctamente" : "No se encontró el registro...";
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
                finally
                {
                    CerrarConexion();
                }
            }
        }

        public string Guardar(Cita entity)
        {
            if (entity == null)
                return "Datos inválidos";

            string sentencia = "INSERT INTO citas (id_paciente, id_doctor, id_especialidad, ruta_cita, fecha_cita, hora_cita, estado_cita, motivo_cita,observaciones) VALUES (@id_paciente, @id_doctor, @id_especialidad, @ruta_cita, @fecha_cita, @hora_cita, @estado_cita, @motivo_cita, @observaciones)";

            using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@id_paciente", entity.PacienteId);
                cmd.Parameters.AddWithValue("@id_doctor", entity.DoctorId);
                cmd.Parameters.AddWithValue("@id_especialidad", entity.IdEspecialidad);
                cmd.Parameters.AddWithValue("@ruta_cita", entity.RutaCita);
                cmd.Parameters.AddWithValue("@fecha_cita", entity.FechaCita);
                cmd.Parameters.AddWithValue("@hora_cita", entity.HoraCita);
                cmd.Parameters.AddWithValue("@estado_cita", entity.EstadoCita);
                cmd.Parameters.AddWithValue("@motivo_cita", entity.MotivoCita);
                cmd.Parameters.AddWithValue("@observaciones", entity.Observaciones);
               

                try
                {
                    AbrirConexion();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        // Obtener el ID generado automáticamente
                        cmd.CommandText = "SELECT LAST_INSERT_ID()";
                        long id = Convert.ToInt64(cmd.ExecuteScalar());
                        return id +"";
                    }
                    else
                    {
                        return "No se ha insertado el registro";
                    }
                }
                catch (MySqlException ex)
                {
                    return $"Error de MySQL: {ex.Message}";
                }
                catch (Exception ex)
                {
                    return $"Error general: {ex.Message}";
                }
                finally
                {
                    CerrarConexion();
                }
            }
        }

        public string Modificar(Cita entity)
        {
            if (entity == null || entity.IdCita <= 0)
                return "Datos inválidos o ID no válido";

            string sentencia = "UPDATE citas SET " +
                              "id_paciente = @id_paciente, " +
                              "id_doctor = @id_doctor, " +
                              "id_especialidad = @id_especialidad," +
                              "ruta_cita = @ruta_cita, " +
                              "fecha_cita = @fecha_cita, " +
                              "hora_cita = @hora_cita, " +
                              "estado_cita = @estado_cita, " +
                              "motivo_cita = @motivo_cita, " +
                              "observaciones = @observaciones, " +
                              "WHERE id_cita = @id";

            using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@id", entity.IdCita);
                cmd.Parameters.AddWithValue("@id_paciente", entity.PacienteId);
                cmd.Parameters.AddWithValue("@id_doctor", entity.DoctorId);
                cmd.Parameters.AddWithValue("@id_especialidad", entity.IdEspecialidad);
                cmd.Parameters.AddWithValue("@ruta_cita", entity.RutaCita);
                cmd.Parameters.AddWithValue("@fecha_cita", entity.FechaCita);
                cmd.Parameters.AddWithValue("@hora_cita", entity.HoraCita);
                cmd.Parameters.AddWithValue("@estado_cita", entity.EstadoCita);
                cmd.Parameters.AddWithValue("@motivo_cita", entity.MotivoCita);
                cmd.Parameters.AddWithValue("@observaciones", entity.Observaciones);

                try
                {
                    AbrirConexion();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0 ? "Registro actualizado correctamente" : "No se encontró el registro para actualizar";
                }
                catch (MySqlException ex)
                {
                    return $"Error de MySQL: {ex.Message}";
                }
                catch (Exception ex)
                {
                    return $"Error general: {ex.Message}";
                }
                finally
                {
                    CerrarConexion();
                }
            }
        }

        public Cita BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(x => x.IdCita == id);
        }


        public void ModificarEstado(int idCita)
        {
            string sentencia = "UPDATE citas SET estado_cita = 'CONFIRMADA' WHERE id_cita = @idCita";
            using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@idCita", idCita);
                try
                {
                    AbrirConexion();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                }
                finally
                {
                    CerrarConexion();
                }
            }
        }
    }
}
