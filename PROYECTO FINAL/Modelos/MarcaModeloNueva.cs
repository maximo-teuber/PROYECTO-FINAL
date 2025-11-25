using System;
using System.Data;
using MySql.Data.MySqlClient;
using PROYECTO_FINAL.clases;

namespace PROYECTO_FINAL.modelo
{
    public class MarcaModeloNueva
    {
        private Conexion conexion = new Conexion();

        // Obtener fabricantes para comboBox
        public DataTable ObtenerFabricantes()
        {
            DataTable dt = new DataTable();
            try
            {
                conexion.abrir();
                string query = "SELECT Idfabricante AS Id, Nombre FROM fabricante";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion()))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            finally
            {
                conexion.cerrar();
            }
            return dt;
        }

        // Insertar marca
        public bool InsertarMarca(MarcaEntidadNueva marca)
        {
            try
            {
                conexion.abrir();
                string query = "INSERT INTO marca (nombre, Idfabricante) VALUES (@nombre, @idFabricante)";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@nombre", marca.Nombre);
                    cmd.Parameters.AddWithValue("@idFabricante", marca.IdFabricante);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            finally
            {
                conexion.cerrar();
            }
        }

        // Actualizar marca
        public bool ActualizarMarca(MarcaEntidadNueva marca)
        {
            try
            {
                conexion.abrir();
                string query = "UPDATE marca SET nombre=@nombre, Idfabricante=@idFabricante WHERE idmarca=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@nombre", marca.Nombre);
                    cmd.Parameters.AddWithValue("@idFabricante", marca.IdFabricante);
                    cmd.Parameters.AddWithValue("@id", marca.IdMarca);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            finally
            {
                conexion.cerrar();
            }
        }

        // Eliminar marca
        public bool EliminarMarca(int idMarca)
        {
            try
            {
                conexion.abrir();
                string query = "DELETE FROM marca WHERE idmarca=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion()))
                {
                    cmd.Parameters.AddWithValue("@id", idMarca);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            finally
            {
                conexion.cerrar();
            }
        }

        // Obtener todas las marcas
        public DataTable ObtenerMarcas()
        {
            DataTable dt = new DataTable();
            try
            {
                conexion.abrir();
                string query = @"
                    SELECT 
                        m.idmarca AS Id, 
                        m.nombre AS Nombre, 
                        f.Idfabricante AS IdFabricante,
                        f.Nombre AS Fabricante
                    FROM marca m
                    LEFT JOIN fabricante f ON m.Idfabricante = f.Idfabricante";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion()))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            finally
            {
                conexion.cerrar();
            }
            return dt;
        }
    }
}
