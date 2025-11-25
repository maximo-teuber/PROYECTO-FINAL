using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PROYECTO_FINAL.clases;

namespace PROYECTO_FINAL.modelo
{
    public class ModeloMarca
    {
        Conexion c = new Conexion();

        // 🔹 Insertar marca
        public bool InsertarMarca(MarcaEntidad marca)
        {
            try
            {
                MySqlConnection conn = c.getConexion();
                c.abrir();

                string sql = "INSERT INTO marca (nombre, Idfabricante) VALUES (@nombre, @Idfabricante)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nombre", marca.Nombre);
                cmd.Parameters.AddWithValue("@Idfabricante", marca.IdFabricante);
                cmd.ExecuteNonQuery();

                c.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar marca: " + ex.Message);
                return false;
            }
        }

        // 🔹 Obtener todos los fabricantes
        public DataTable ObtenerFabricantes()
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlConnection conn = c.getConexion();
                c.abrir();

                string sql = "SELECT Idfabricante, Nombre FROM fabricante";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);

                c.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener fabricantes: " + ex.Message);
            }

            return dt;
        }

        // 🔹 Obtener todas las marcas
        public DataTable ObtenerMarcas()
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlConnection conn = c.getConexion();
                c.abrir();

                string sql = "SELECT idmarca, nombre, Idfabricante FROM marca";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);

                c.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener marcas: " + ex.Message);
            }

            return dt;
        }

        // 🔹 Obtener el Idfabricante de una marca
        public int ObtenerIdFabricantePorMarca(int idMarca)
        {
            int idFabricante = 0;
            try
            {
                MySqlConnection conn = c.getConexion();
                c.abrir();

                string sql = "SELECT Idfabricante FROM marca WHERE idmarca = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idMarca);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    idFabricante = Convert.ToInt32(result);

                c.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener fabricante: " + ex.Message);
            }
            return idFabricante;
        }
    }
}
