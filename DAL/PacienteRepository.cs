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
                int ordId = reader.GetOrdinal("id_paciente");
                int ordNombre = reader.GetOrdinal("nombre");
                int ordApellido = reader.GetOrdinal("apellido");
                int ordFecha = reader.GetOrdinal("fecha_nacimiento");
                int ordNumDoc = reader.GetOrdinal("numero_documento");
                int ordTipDOc = reader.GetOrdinal("tipo_documento");
                int ordCor = reader.GetOrdinal("correo");
                int ordTel = reader.GetOrdinal("telefono");
                int ordOcupacion = reader.GetOrdinal("ocupacion");
                int ordReligion = reader.GetOrdinal("religion");
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

                string correo = !reader.IsDBNull(ordCor)
                    ? reader.GetString(ordCor)
                    : string.Empty;

                string telefono = !reader.IsDBNull(ordTel)
                    ? reader.GetString(ordTel)
                    : string.Empty;

                string ocupacion = !reader.IsDBNull(ordOcupacion)
                    ? reader.GetString(ordOcupacion)
                    : string.Empty;

                string religion = !reader.IsDBNull(ordReligion)
                    ? reader.GetString(ordReligion)
                    : string.Empty;
                string sexo = !reader.IsDBNull(ordSex)
                    ? reader.GetString(ordSex)
                    : string.Empty;
    





            return new Paciente(
                    id: id,
                    nombre: nombre,
                    apellido: apellido,
                    fechaNacimiento: fechaNac,
                    numeroDocumento: numeroDoc,
                    tipoDocumento: tipoDoc,
                    correo:correo,
                    telefono:telefono,
                    ocupacion: ocupacion,
                    religion: religion,
                    sexo: sexo
                );
            }

            public string Eliminar(int id)
            {
                if (id <= 0)
                    return "ID inválido";

                string sentencia = "DELETE FROM pacientes WHERE id_paciente = @Id";

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

                string sentencia = "INSERT INTO pacientes (nombre, apellido, fecha_nacimiento, tipo_documento, numero_documento,correo,telefono, ocupacion, religion, sexo) VALUES (@nombre, @apellido, @fecha_nacimiento, @tipo_documento, @numero_documento, @correo, @telefono, @ocupacion, @religion, @sexo)";

                using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", entity.Apellido);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", entity.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@tipo_documento", entity.TipoDocumento);
                    cmd.Parameters.AddWithValue("@numero_documento", entity.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@correo", entity.Correo);
                    cmd.Parameters.AddWithValue("@telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@ocupacion", entity.Ocupacion);
                    cmd.Parameters.AddWithValue("@religion", entity.Religion);
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

         public string Modificar(Paciente paciente)
        {
            if (paciente == null || paciente.Id <= 0)
                return "Datos inválidos o ID no válido";

            const string sql = @"UPDATE pacientes
               SET nombre        = @nombre,
               apellido          = @apellido,
               fecha_nacimiento  = @fecha_nacimiento,
               tipo_documento    = @tipo_documento,
               numero_documento  = @numero_documento,
               correo            = @correo,
               telefono          = @telefono,
               ocupacion         = @ocupacion,
               religion          = @religion
               WHERE id_paciente      = @id;
               ";

            using var cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@id", paciente.Id);
            cmd.Parameters.AddWithValue("@nombre", paciente.Nombre);
            cmd.Parameters.AddWithValue("@apellido", paciente.Apellido);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", paciente.FechaNacimiento);
            cmd.Parameters.AddWithValue("@tipo_documento", paciente.TipoDocumento);
            cmd.Parameters.AddWithValue("@numero_documento", paciente.NumeroDocumento);
            cmd.Parameters.AddWithValue("@correo", paciente.Correo);
            cmd.Parameters.AddWithValue("@telefono", paciente.Telefono);
            cmd.Parameters.AddWithValue("@ocupacion", paciente.Ocupacion);
            cmd.Parameters.AddWithValue("@religion", paciente.Religion);


            try
            {
                AbrirConexion();
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0
                    ? "Registro actualizado correctamente"
                    : "No se encontró el registro para actualizar";
            }
            catch (MySqlException ex)
            {
                return $"Error de MySQL #{ex.Number}: {ex.Message}";
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


             public Paciente BuscarPorId(int id)
            {

                return Consultar().FirstOrDefault(x => x.Id == id);

            }

            public Paciente BuscarPorNumeroDocumento(string numeroDocumento)
            {

                return Consultar().FirstOrDefault(p => p.NumeroDocumento == numeroDocumento);

            }


        



    }
    
}
