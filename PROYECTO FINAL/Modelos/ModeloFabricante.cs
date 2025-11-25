using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using PROYECTO_FINAL.clases; // contiene la clase Conexion

namespace PROYECTO_FINAL.Modelos
{
    public class FabricanteDAO
    {
        Conexion c = new Conexion();

        // Insertar un nuevo fabricante
        public bool InsertarFabricante(ModeloFabricante fabricante)
        {
            try
            {
                using (MySqlConnection conn = c.getConexion())
                {
                    conn.Open();
                    string sql = "INSERT INTO fabricante (nombre, origen) VALUES (@nombre, @origen)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nombre", fabricante.Nombre);
                    cmd.Parameters.AddWithValue("@origen", fabricante.Origen);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar fabricante: " + ex.Message);
                return false;
            }
        }

        // Obtener todos los fabricantes
        public DataTable ObtenerFabricantes()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = c.getConexion())
                {
                    conn.Open();
                    string sql = "SELECT idfabricante, nombre, origen FROM fabricante";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener fabricantes: " + ex.Message);
            }
            return dt;
        }
    }
}