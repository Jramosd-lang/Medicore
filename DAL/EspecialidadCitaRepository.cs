using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class EspecialidadCitaRepository: BaseDatos, IRepository<EspecialidadCita>
    {
        public List<EspecialidadCita> Consultar()
        {
            string sentencia = "SELECT * FROM especialidades";

            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
            AbrirConexion();
            MySqlDataReader reader = cmd.ExecuteReader();

            List<EspecialidadCita> lista = new List<EspecialidadCita>();
            while (reader.Read())
            {
                lista.Add(Mappear(reader));
            }
            CerrarConexion();
            return lista;
        }

        public List<string> consultarNombre()
        {
            string sentencia = "SELECT nombre FROM especialidades";
            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
            AbrirConexion();
            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> lista = new List<string>();
            while (reader.Read())
            {
                lista.Add(reader.GetString("nombre"));
            }
            CerrarConexion();
            return lista;
        }

        public int consultarPorNombre(string nombre)
        {
            string sentencia = "SELECT id_especialidad FROM especialidades WHERE nombre = @nombre";
            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            AbrirConexion();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            CerrarConexion();
            return id;
        }

        private EspecialidadCita Mappear(MySqlDataReader reader)
        {
            // Obtén los ordinales una sola vez
            int ordId = reader.GetOrdinal("id_especialidad");
            int ordNombre = reader.GetOrdinal("nombre");


            int id = !reader.IsDBNull(ordId)
                ? reader.GetInt32(ordId)
                : throw new InvalidOperationException("id_doctor no puede ser nulo");

            string nombre = !reader.IsDBNull(ordNombre)
                ? reader.GetString(ordNombre)
                : string.Empty;



            return new EspecialidadCita(
                id: id,
                nombre: nombre
     
            );
        }

        public string Guardar(EspecialidadCita entity)
        {
            if (entity == null || string.IsNullOrWhiteSpace(entity.nombre))
                return "Datos inválidos";

            string sentencia = "INSERT INTO especialidades (nombre) VALUES (@nombre)";

            using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@nombre", entity.nombre);


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

        public string Modificar(EspecialidadCita entity)
        {
            if (entity == null || entity.id <= 0)
                return "Datos inválidos o ID no válido";

            string sentencia = "UPDATE especialidades SET " +
                              "nombre = @nombre " +
                              "WHERE id_especialidad = @id";

            using (MySqlCommand cmd = new MySqlCommand(sentencia, conexion))
            {
                cmd.Parameters.AddWithValue("@id", entity.id);
                cmd.Parameters.AddWithValue("@nombre", entity.nombre);

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

        public string Eliminar(int id)
        {
            if (id <= 0)
                return "ID inválido";

            string sentencia = "DELETE FROM especialidades WHERE id_especialidad = @Id";

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


        public EspecialidadCita BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(x => x.id == id);
        }
    }
    
}
