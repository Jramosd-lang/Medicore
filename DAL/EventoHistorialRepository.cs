using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class EventoHistorialRepository : BaseDatos, IRepository<EventoHistorialMedico>
    {
        public List<EventoHistorialMedico> Consultar()
        {
            string sentencia = "SELECT * FROM evento_historial_medico";

            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
            AbrirConexion();
            MySqlDataReader reader = cmd.ExecuteReader();

            List<EventoHistorialMedico> lista = new List<EventoHistorialMedico>();
            while (reader.Read())
            {
                lista.Add(Mappear(reader));
            }
            CerrarConexion();
            return lista;
        }

        private EventoHistorialMedico Mappear(MySqlDataReader reader)
        {
            // Obtén los ordinales una sola vez
            int ordId = reader.GetOrdinal("id_evento_historial_medico");
            int ordHm = reader.GetOrdinal("id_historial_medico");
            int ordFec = reader.GetOrdinal("fecha");
            int ordDes = reader.GetOrdinal("descripcion");
            int ordOb = reader.GetOrdinal("observaciones");
            int ordDiag = reader.GetOrdinal("diagnosticos");
            int ordTra = reader.GetOrdinal("tratamientos");
            int ordMedi = reader.GetOrdinal("medicamentos");
            int ordRec = reader.GetOrdinal("recomendaciones");
            int ordEx = reader.GetOrdinal("examenes");




            int id = !reader.IsDBNull(ordId)
                ? reader.GetInt32(ordId)
                : throw new InvalidOperationException("id_doctor no puede ser nulo");
            int id_historial =!reader.IsDBNull(ordHm)
                ? reader.GetInt32(ordHm)
                : throw new InvalidOperationException("id_historial_medico no puede ser nulo");
            DateTime fecha = !reader.IsDBNull(ordFec)
                ? reader.GetDateTime(ordFec)
                : throw new InvalidOperationException("fecha no puede ser nulo");
            string descripcion = !reader.IsDBNull(ordDes)
                ? reader.GetString(ordDes)
                : string.Empty;
            string observaciones = !reader.IsDBNull(ordOb)
                ? reader.GetString(ordOb)
                : string.Empty;
            string diagnosticos = !reader.IsDBNull(ordDiag)
                ? reader.GetString(ordDiag)
                : string.Empty;
            string tratamientos = !reader.IsDBNull(ordTra)
                ? reader.GetString(ordTra)
                : string.Empty;
            string medicamentos = !reader.IsDBNull(ordMedi)
                ? reader.GetString(ordMedi)
                : string.Empty;
            string recomendaciones = !reader.IsDBNull(ordRec)
                ? reader.GetString(ordRec)
                : string.Empty;
            string examenes = !reader.IsDBNull(ordEx)
                ? reader.GetString(ordEx)
                : string.Empty;




            return new EventoHistorialMedico(
                id,
                id_historial,
                fecha,
                descripcion,
                observaciones,
                diagnosticos,
                tratamientos,
                medicamentos,
                recomendaciones,
                examenes
            );
        }

        public string Eliminar(int id)
        {
            if (id <= 0)
                return "ID inválido";

            string sentencia = "DELETE FROM evento_historial_medico WHERE id_evento = @Id";

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

        public string Guardar(EventoHistorialMedico entity)
        {
            if (entity == null)
                return "Datos inválidos";

            string sentencia = "INSERT INTO evento_historial_medico " +
                "(id_historial_medico," +
                " fecha," +
                " descripcion," +
                " observaciones," +
                " diagnosticos," +
                " tratamientos," +
                " medicamentos," +
                " recomendaciones," +
                "examenes) " +
                "VALUES (" +
                " @id_historial_medico," +
                " @fecha," +
                " @descripcion," +
                " @observaciones," +
                " @diagnosticos," +
                " @tratamientos," +
                " @medicamentos," +
                " @recomendaciones," +
                " @examenes)";

            using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@id_historial_medico", entity.Id_historial_medico);
                cmd.Parameters.AddWithValue("@fecha", entity.Fecha);
                cmd.Parameters.AddWithValue("@descripcion", entity.Descripcion);
                cmd.Parameters.AddWithValue("@observaciones", entity.Observaciones);
                cmd.Parameters.AddWithValue("@diagnosticos", entity.Diagnostico);
                cmd.Parameters.AddWithValue("@tratamientos", entity.Tratamiento);
                cmd.Parameters.AddWithValue("@medicamentos", entity.Medicamentos);
                cmd.Parameters.AddWithValue("@recomendaciones", entity.Recomendaciones);
                cmd.Parameters.AddWithValue("@examenes", entity.Examenes);


                try
                {
                    AbrirConexion();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        // Obtener el ID generado automáticamente
                        cmd.CommandText = "SELECT LAST_INSERT_ID()";
                        long id = Convert.ToInt64(cmd.ExecuteScalar());
                        return $"Registro insertado correctamente con ID {id}";
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

        public string Modificar(EventoHistorialMedico entity)
        {
            if (entity == null || entity.Id_historial_medico <= 0)
                return "Datos inválidos o ID no válido";

            string sentencia = "UPDATE evento_historial_medico SET " +
                               ", fecha = @fecha" +
                               ", descripcion = @descripcion" +
                               ", observaciones = @observaciones" +
                               ", diagnosticos= @diagnosticos" +
                               ", tratamientos = @tratamientos" +
                               ", medicamentos = @medicamentos" +
                               ", recomendaciones = @recomendaciones" +
                               ", examenes = @examenes" +
                               "WHERE id_historial = @id_historial";

            using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@fecha", entity.Fecha);
                cmd.Parameters.AddWithValue("@descripcion", entity.Descripcion);
                cmd.Parameters.AddWithValue("@observaciones", entity.Observaciones);
                cmd.Parameters.AddWithValue("@diagnosticos", entity.Diagnostico);
                cmd.Parameters.AddWithValue("@tratamientos", entity.Tratamiento);
                cmd.Parameters.AddWithValue("@medicamentos", entity.Medicamentos);
                cmd.Parameters.AddWithValue("@recomendaciones", entity.Recomendaciones);
                cmd.Parameters.AddWithValue("@examenes", entity.Examenes);




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

        public EventoHistorialMedico BuscarId(int id)
        {
            string sentencia = "SELECT * FROM evento_historial_medico WHERE id_evento = @Id";
            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
            cmd.Parameters.AddWithValue("@Id", id);
            AbrirConexion();
            MySqlDataReader reader = cmd.ExecuteReader();
            EventoHistorialMedico evento = null;
            if (reader.Read())
            {
                evento = Mappear(reader);
            }
            CerrarConexion();
            return evento;
        }
    }
}
