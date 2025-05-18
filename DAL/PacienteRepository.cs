using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;

namespace DAL
{
   
       
        public class PacienteRepository : BaseDatos, IRepository<Paciente>
        {
            public List<Paciente> Consultar()
            {
                string sentencia = "SELECT * FROM pacientes";

                MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
                AbrirConexion();
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Paciente> lista = new List<Paciente>();
                while (reader.Read())
                {
                    lista.Add(Mappear(reader));
              
                }
                reader.Close();
                CerrarConexion();
                return lista;
            }

            private Paciente Mappear(MySqlDataReader reader)
            {
                // Obtén los ordinales una sola vez
                int ordId = reader.GetOrdinal("id_doctor");
                int ordNombre = reader.GetOrdinal("nombre");
                int ordApellido = reader.GetOrdinal("apellido");
                int ordFecha = reader.GetOrdinal("fecha_nacimiento");
                int ordNumDoc = reader.GetOrdinal("numero_documento");
                int ordTipDOc = reader.GetOrdinal("tipo_documento");
                int ordEsp = reader.GetOrdinal("especialidad");
                int ordLic = reader.GetOrdinal("numero_licencia");

                int id = !reader.IsDBNull(ordId)
                    ? reader.GetInt32(ordId)
                    : throw new InvalidOperationException("id_doctor no puede ser nulo");

                string nombre = !reader.IsDBNull(ordNombre)
                    ? reader.GetString(ordNombre)
                    : string.Empty;

                string apellido = !reader.IsDBNull(ordApellido)
                    ? reader.GetString(ordApellido)
                    : string.Empty;

                DateTime fechaNac = !reader.IsDBNull(ordFecha)
                    ? reader.GetDateTime(ordFecha)
                    : DateTime.MinValue;

                string numeroDoc = !reader.IsDBNull(ordNumDoc)
                    ? reader.GetString(ordNumDoc)
                    : string.Empty;

                string tipoDoc = !reader.IsDBNull(ordTipDOc)
                    ? reader.GetString(ordTipDOc)
                    : string.Empty;

                string rutaHistorialPdf = !reader.IsDBNull(ordEsp)
                    ? reader.GetString(ordEsp)
                    : string.Empty;

                

                return new Paciente(
                    id: id,
                    nombre: nombre,
                    apellido: apellido,
                    fechaNacimiento: fechaNac,
                    numeroDocumento: numeroDoc,
                    tipoDocumento: tipoDoc,
                    rutaHistorialPdf: rutaHistorialPdf
                    
                );
            }

            public string Eliminar(int id)
            {
                if (id <= 0)
                    return "ID inválido";

                string sentencia = "DELETE FROM doctores WHERE id_doctor = @Id";

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

            public string Guardar(Paciente entity)
            {
                if (entity == null || string.IsNullOrWhiteSpace(entity.Nombre))
                    return "Datos inválidos";

                string sentencia = "INSERT INTO doctores (nombre, apellido, fecha_nacimiento, tipo_documento, numero_documento, especialidad, numero_licencia) VALUES (@nombre, @apellido, @fecha_nacimiento, @tipo_documento, @numero_documento, @especialidad, @numero_licencia)";

                using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", entity.Apellido);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", entity.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@tipo_documento", entity.TipoDocumento);
                    cmd.Parameters.AddWithValue("@numero_documento", entity.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@especialidad", entity.RutaHistorialPdf);
                    

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

            public string Modificar(Paciente entity)
            {
                if (entity == null || entity.Id <= 0)
                    return "Datos inválidos o ID no válido";

                string sentencia = "UPDATE doctores SET " +
                                  "nombre = @nombre, " +
                                  "apellido = @apellido, " +
                                  "fecha_nacimiento = @fecha_nacimiento, " +
                                  "tipo_documento = @tipo_documento, " +
                                  "numero_documento = @numero_documento, " +
                                  "especialidad = @especialidad, " +
                                  "numero_licencia = @numero_licencia " +
                                  "WHERE id_doctor = @id";

                using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", entity.Id);
                    cmd.Parameters.AddWithValue("@nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", entity.Apellido);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", entity.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@tipo_documento", entity.TipoDocumento);
                    cmd.Parameters.AddWithValue("@numero_documento", entity.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@especialidad", entity.RutaHistorialPdf);
                    

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

            public Paciente BuscarPorId(int id)
            {
                return Consultar().FirstOrDefault(x => x.Id == id);
            }

            
        }
    
}
