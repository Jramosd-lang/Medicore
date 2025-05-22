using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class HistorialMedicoRepository : BaseDatos, IRepository<HistorialMedico>
    {
        public List<HistorialMedico> Consultar()
        {
            string sentencia = "SELECT * FROM historial_medico";

            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
            AbrirConexion();
            MySqlDataReader reader = cmd.ExecuteReader();

            List<HistorialMedico> lista = new List<HistorialMedico>();
            while (reader.Read())
            {
                lista.Add(Mappear(reader));
            }
            CerrarConexion();
            return lista;
        }

        private HistorialMedico Mappear(MySqlDataReader reader)
        {
            // Obtén los ordinales una sola vez
            int ordId = reader.GetOrdinal("id_historial");
            int oirIdP = reader.GetOrdinal("id_paciente");
            int ordTipoSangre = reader.GetOrdinal("tipo_sangre");
            int ordAlergias = reader.GetOrdinal("alergias");
            int ordEnfermedadesCronicas = reader.GetOrdinal("enfermedades_cronicas");
            int ordMedicamentosActuales = reader.GetOrdinal("medicamentos_actuales");
            int ordAntecedentesFamiliares = reader.GetOrdinal("antecedentes_familiares");
            int ordVacunas = reader.GetOrdinal("vacunas");



            int id = !reader.IsDBNull(ordId)
                ? reader.GetInt32(ordId)
                : throw new InvalidOperationException("id_doctor no puede ser nulo");

            int idP = !reader.IsDBNull(oirIdP)
                ? reader.GetInt32(oirIdP)
                : throw new InvalidOperationException("id_paciente no puede ser nulo");
            string tipoSangre = !reader.IsDBNull(ordTipoSangre)
                ? reader.GetString(ordTipoSangre)
                : throw new InvalidOperationException("tipo_sangre no puede ser nulo");
            string alergias = !reader.IsDBNull(ordAlergias)
                ? reader.GetString(ordAlergias)
                : throw new InvalidOperationException("alergias no puede ser nulo");
            string enfermedadesCronicas = !reader.IsDBNull(ordEnfermedadesCronicas)
                ? reader.GetString(ordEnfermedadesCronicas)
                : throw new InvalidOperationException("enfermedades_cronicas no puede ser nulo");
            string medicamentosActuales = !reader.IsDBNull(ordMedicamentosActuales)
                ? reader.GetString(ordMedicamentosActuales)
                : throw new InvalidOperationException("medicamentos_actuales no puede ser nulo");
            string antecedentesFamiliares = !reader.IsDBNull(ordAntecedentesFamiliares)
                ? reader.GetString(ordAntecedentesFamiliares)
                : throw new InvalidOperationException("antecedentes_familiares no puede ser nulo");
            string vacunas = !reader.IsDBNull(ordVacunas)
                ? reader.GetString(ordVacunas)
                : throw new InvalidOperationException("vacunas no puede ser nulo");



            return new HistorialMedico(
                id,
                idP,
                tipoSangre,
                alergias,
                enfermedadesCronicas,
                medicamentosActuales,
                antecedentesFamiliares,
                vacunas
            );
        }

        public HistorialMedico BuscarId(int id)
        {
            string sentencia = "SELECT * FROM historial_medico WHERE id_historial = @Id";
            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
            cmd.Parameters.AddWithValue("@Id", id);
            AbrirConexion();
            MySqlDataReader reader = cmd.ExecuteReader();
            HistorialMedico historialMedico = null;
            if (reader.Read())
            {
                historialMedico = Mappear(reader);
            }
            CerrarConexion();
            return historialMedico;
        }
        public List<HistorialMedico> ConsultarPorPaciente(int idPaciente)
        {
            string sentencia = "SELECT * FROM historial_medico WHERE id_paciente = @IdPaciente";
            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
            cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
            AbrirConexion();
            MySqlDataReader reader = cmd.ExecuteReader();
            List<HistorialMedico> lista = new List<HistorialMedico>();
            while (reader.Read())
            {
                lista.Add(Mappear(reader));
            }
            CerrarConexion();
            return lista;
        }
        public string Eliminar(int id)
        {
            if (id <= 0)
                return "ID inválido";

            string sentencia = "DELETE FROM historial_medico WHERE id_historial = @Id";

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

        public string Guardar(HistorialMedico entity)
        {

            if (entity == null)
                return "Datos inválidos";

            string sentencia = "INSERT INTO historial_medico (" +
                "id_paciente," +
                "tipo_sangre," +
                "alergias," +
                "enfermedades_cronicas," +
                "medicamentos_actuales," +
                "antecedentes_familiares," +
                "vacunas" +
                ") " +
                "VALUES (" +
                "@id_paciente," +
                "@tipo_sangre," +
                "@alergias," +
                "@enfermedades_cronicas," +
                "@medicamentos_actuales," +
                "@antecedentes_familiares," +
                "@vacunas)";

            using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@id_paciente", entity.Id_paciente);
                cmd.Parameters.AddWithValue("@tipo_sangre", entity.TipoSangre);
                cmd.Parameters.AddWithValue("@alergias", entity.Alergias);
                cmd.Parameters.AddWithValue("@enfermedades_cronicas", entity.EnfermedadesCronicas);
                cmd.Parameters.AddWithValue("@medicamentos_actuales", entity.MedicamentosActuales);
                cmd.Parameters.AddWithValue("@antecedentes_familiares", entity.AntecedentesFamiliares);
                cmd.Parameters.AddWithValue("@vacunas", entity.Vacunas);



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

        public string Modificar(HistorialMedico entity)
        {
            if (entity == null || entity.Id_paciente <= 0)
                return "Datos inválidos o ID no válido";

            string sentencia = "UPDATE historial_medico SET " +
                               ", tipo_sangre = @tipo_sangre" +
                               ", alergias = @alergias" +
                               ", enfermedades_cronicas = @enfermedades_cronicas" +
                               ", medicamentos_actuales = @medicamentos_actuales" +
                               ", antecedentes_familiares = @antecedentes_familiares" +
                               ", vacunas = @vacunas" +
                               "WHERE id_historial = @id_historial";
           
            using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@tipo_sangre", entity.TipoSangre);
                cmd.Parameters.AddWithValue("@alergias", entity.Alergias);
                cmd.Parameters.AddWithValue("@enfermedades_cronicas", entity.EnfermedadesCronicas);
                cmd.Parameters.AddWithValue("@medicamentos_actuales", entity.MedicamentosActuales);
                cmd.Parameters.AddWithValue("@antecedentes_familiares", entity.AntecedentesFamiliares);
                cmd.Parameters.AddWithValue("@vacunas", entity.Vacunas);




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
    }
}
