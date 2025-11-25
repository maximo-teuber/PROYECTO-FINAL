using MySql.Data.MySqlClient;

namespace PROYECTO_FINAL.clases
{
    public class Conexion
    {
        private MySqlConnection con;

        public Conexion()
        {
            // Base de datos correcta
            con = new MySqlConnection("server=localhost;database=forraje;uid=root;pwd=;");
        }

        public MySqlConnection getConexion()
        {
            return con;
        }

        public void abrir()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public void cerrar()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
