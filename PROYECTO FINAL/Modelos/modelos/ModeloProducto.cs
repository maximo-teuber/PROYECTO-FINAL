using MySql.Data.MySqlClient;
using System;
using System.Data; // 👈 necesario para DataTable
using System.Windows.Forms;
using PROYECTO_FINAL.clases;

namespace PROYECTO_FINAL.modelo
{
    public class ModeloProducto
    {
        // 👉 Método para insertar un alimento
        public bool InsertarAlimento(Alimento a)
        {
            Conexion c = new Conexion();

            using (MySqlConnection conn = c.getConexion())
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO alimento (marca, precio_kilo, precio_bolsa, stock, tipo_alimento) " +
                                 "VALUES (@marca, @precio_kilo, @precio_bolsa, @stock, @tipo_alimento)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@marca", a.Marca ?? "");
                        cmd.Parameters.AddWithValue("@precio_kilo", a.Precio_kilo);
                        cmd.Parameters.AddWithValue("@precio_bolsa", a.Precio_bolsa);
                        cmd.Parameters.AddWithValue("@stock", a.Stock);
                        cmd.Parameters.AddWithValue("@tipo_alimento", a.Tipo_alimento ?? "");

                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar alimento: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // 👉 Método para buscar alimentos con filtros (ej: tipo y precio)
        public DataTable BuscarConFiltros(string tipo, bool ordenarPorPrecioAsc)
        {
            Conexion c = new Conexion();
            DataTable tabla = new DataTable();

            using (MySqlConnection conn = c.getConexion())
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT id_alimento, marca, precio_kilo, precio_bolsa, stock, tipo_alimento 
                                   FROM alimento 
                                   WHERE (@tipo = 'Todos' OR tipo_alimento = @tipo)";

                    // Ordenar por precio
                    sql += ordenarPorPrecioAsc ? " ORDER BY precio_kilo ASC" : " ORDER BY precio_kilo DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return tabla;
        }
    }
}
