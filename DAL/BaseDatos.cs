using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class BaseDatos
    {

        protected string cadenaConexion = "Server=localhost;Port=3306;Database=medicore;Uid=root;Pwd=123456*;Charset=utf8mb4;"
;



        public MySqlConnection conexion;

        public BaseDatos()
        {
            conexion = new MySqlConnection(cadenaConexion);
        }

        public ConnectionState AbrirConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();

            }
            conexion.Open();
            return conexion.State;
        }
        public void CerrarConexion()
        {
            conexion.Close();
        }
    }
}
