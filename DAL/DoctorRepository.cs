using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;
using Mysqlx.Sql;

namespace DAL
{
    public class DoctorRepository : BaseDatos, IRepository<Doctor>
    {
        public List<Doctor> Consultar()
        {
            string sentencia = "SELECT * FROM doctores";

            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
            AbrirConexion();
            MySqlDataReader reader = cmd.ExecuteReader();

            List<Doctor> lista = new List<Doctor>();
            while (reader.Read())
            {
                lista.Add(Mappear(reader));
            }
            CerrarConexion();
            return lista;
        }

        public bool ValidarCredenciales(string documento, string contrasena)
        {
            string sql = @"SELECT 1 
                           FROM doctores 
                           WHERE numero_documento = @documento AND password_ = @clave 
                           LIMIT 1";

            try
            {
                AbrirConexion();
                using (var cmd = new MySqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.Parameters.AddWithValue("@clave", contrasena);

                    var resultado = cmd.ExecuteScalar();
                    return resultado != null;
                }
            }
            catch (Exception)
            {
                // Manejo de errores si es necesario
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }


        private Doctor Mappear(MySqlDataReader reader)
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
            int ordCor = reader.GetOrdinal("correo");
            int ordTel = reader.GetOrdinal("telefono");
            int ordPas = reader.GetOrdinal("password_");
            int ordSex = reader.GetOrdinal("sexo"); 

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

            string especialidad = !reader.IsDBNull(ordEsp)
                ? reader.GetString(ordEsp)
                : string.Empty;

            string numeroLicencia = !reader.IsDBNull(ordLic)
                ? reader.GetString(ordLic)
                : string.Empty;
            string correo = !reader.IsDBNull(ordCor)
                ? reader.GetString(ordCor)
                : string.Empty;
            string telefono = !reader.IsDBNull(ordTel)
                ? reader.GetString(ordTel)
                : string.Empty;
            string contrasena = !reader.IsDBNull(ordPas)
                ? reader.GetString(ordPas)
                : string.Empty;

            string ordSexo = !reader.IsDBNull(ordSex)
                ? reader.GetString(ordSex)
                : string.Empty;

            return new Doctor(
                id: id,
                nombre: nombre,
                apellido: apellido,
                fechaNacimiento: fechaNac,
                numeroDocumento: numeroDoc,
                tipoDocumento: tipoDoc,
                especialidad: especialidad,
                numeroLicencia: numeroLicencia,
                correo: correo,
                telefono: telefono,
                password: contrasena,
                sexo: ordSexo

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

        public string Guardar(Doctor entity)
        {
            if (entity == null || string.IsNullOrWhiteSpace(entity.Nombre))
                return "Datos inválidos";

            string sentencia = "INSERT INTO doctores (nombre, apellido, fecha_nacimiento, tipo_documento, numero_documento, especialidad, numero_licencia,correo,telefono,password_,sexo) VALUES (@nombre, @apellido, @fecha_nacimiento, @tipo_documento, @numero_documento, @especialidad, @numero_licencia, @correo, @telefono,@password,@sexo)";

            using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@nombre", entity.Nombre);
                cmd.Parameters.AddWithValue("@apellido", entity.Apellido);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", entity.FechaNacimiento);
                cmd.Parameters.AddWithValue("@tipo_documento", entity.TipoDocumento);
                cmd.Parameters.AddWithValue("@numero_documento", entity.NumeroDocumento);
                cmd.Parameters.AddWithValue("@especialidad", entity.Especialidad);
                cmd.Parameters.AddWithValue("@numero_licencia", entity.NumeroLicencia);
                cmd.Parameters.AddWithValue("@correo", entity.Correo);
                cmd.Parameters.AddWithValue("@telefono", entity.Telefono);
                cmd.Parameters.AddWithValue("@password", entity.Password);
                cmd.Parameters.AddWithValue("@sexo", entity.Sexo);

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

        public string Modificar(Doctor entity)
        {
            if (entity == null || entity.Id <= 0)
                return "Datos inválidos o ID no válido";

            string sentencia = "UPDATE doctores SET " +
                              "nombre = @nombre, " +
                              "apellido = @apellido, " +
                              "fecha_nacimiento = @fecha_nacimiento, " +
                              "tipo_documento = @tipo_documento, " +
                              "numero_documento = @numero_documento, " +
                              "correo = @correo, " +
                              "telefono = @telefono, " +
                              "especialidad = @especialidad, " +
                              "numero_licencia = @numero_licencia, "+
                              "sexo = @sexo " +
                              "WHERE id_doctor = @id";

            using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@id", entity.Id);
                cmd.Parameters.AddWithValue("@nombre", entity.Nombre);
                cmd.Parameters.AddWithValue("@apellido", entity.Apellido);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", entity.FechaNacimiento);
                cmd.Parameters.AddWithValue("@tipo_documento", entity.TipoDocumento);
                cmd.Parameters.AddWithValue("@numero_documento", entity.NumeroDocumento);
                cmd.Parameters.AddWithValue("@especialidad", entity.Especialidad);
                cmd.Parameters.AddWithValue("@numero_licencia", entity.NumeroLicencia);
                cmd.Parameters.AddWithValue("@correo", entity.Correo);
                cmd.Parameters.AddWithValue("@telefono", entity.Telefono);
                cmd.Parameters.AddWithValue("@password", entity.Password);
                cmd.Parameters.AddWithValue("@sexo", entity.Sexo);


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

        public Doctor BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(x => x.Id == id);
        }


        public Doctor BuscarPorNumeroDocumento(string numeroDocumento)
        {
            if (string.IsNullOrWhiteSpace(numeroDocumento))
                throw new ArgumentException("El número de documento no puede ser nulo o vacío.", nameof(numeroDocumento));

            string sentencia = "SELECT * FROM doctores WHERE numero_documento = @numeroDocumento LIMIT 1";
            try
            {
                AbrirConexion();
                using (var cmd = new MySqlCommand(sentencia, conexion))
                {
                    cmd.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Mappear(reader);
                        }
                        else
                        {
                            throw new InvalidOperationException("No se encontró un doctor con el número de documento proporcionado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el doctor por número de documento.", ex);
            }
            finally
            {
                CerrarConexion();
            }
        }




    }
}