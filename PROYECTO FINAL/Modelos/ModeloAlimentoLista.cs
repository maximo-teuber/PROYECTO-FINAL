using System;
using System.Data;
using MySql.Data.MySqlClient;
using PROYECTO_FINAL.clases;

namespace PROYECTO_FINAL.modelo
{
    public class ModeloAlimentoLista
    {
        private Conexion conexion = new Conexion();

        public DataTable ObtenerAlimentosConFiltros(string nombre = "", string sabor = "", string tipo = "", string precioFiltro = "")
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM alimento WHERE 1=1";

            if (!string.IsNullOrEmpty(nombre))
                sql += " AND Nombre LIKE @nombre";
            if (!string.IsNullOrEmpty(sabor))
                sql += " AND Sabor LIKE @sabor";
            if (!string.IsNullOrEmpty(tipo))
                sql += " AND tipo_alimento=@tipo";

            if (precioFiltro == "Mayor")
                sql += " ORDER BY Precio_kilo DESC";
            else if (precioFiltro == "Menor")
                sql += " ORDER BY Precio_kilo ASC";
            else if (precioFiltro == "BolsaMayor")
                sql += " ORDER BY Precio_bolsa DESC";
            else if (precioFiltro == "BolsaMenor")
                sql += " ORDER BY Precio_bolsa ASC";

            try
            {
                conexion.abrir();
                using (MySqlCommand cmd = new MySqlCommand(sql, conexion.getConexion()))
                {
                    if (!string.IsNullOrEmpty(nombre))
                        cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    if (!string.IsNullOrEmpty(sabor))
                        cmd.Parameters.AddWithValue("@sabor", "%" + sabor + "%");
                    if (!string.IsNullOrEmpty(tipo))
                        cmd.Parameters.AddWithValue("@tipo", tipo);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            finally { conexion.cerrar(); }

            return dt;
        }

        public void ActualizarAlimento(int id, string nombre, string tipo, decimal precioKilo, decimal precioBolsa, decimal peso,
            string sabor, int stock, int stockMin, int stockMax, int idMarca)
        {
            string sql = "UPDATE alimento SET Nombre=@nombre, tipo_alimento=@tipo, Precio_kilo=@precioKilo, Precio_bolsa=@precioBolsa, peso=@peso, " +
                         "Sabor=@sabor, Stock=@stock, Stock_minimo=@stockMin, Stock_maximo=@stockMax, idmarca=@idMarca WHERE Id_alimento=@id";
            conexion.abrir();
            using (MySqlCommand cmd = new MySqlCommand(sql, conexion.getConexion()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@precioKilo", precioKilo);
                cmd.Parameters.AddWithValue("@precioBolsa", precioBolsa);
                cmd.Parameters.AddWithValue("@peso", peso);
                cmd.Parameters.AddWithValue("@sabor", sabor);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@stockMin", stockMin);
                cmd.Parameters.AddWithValue("@stockMax", stockMax);
                cmd.Parameters.AddWithValue("@idMarca", idMarca);
                cmd.ExecuteNonQuery();
            }
            conexion.cerrar();
        }

        public void BorrarAlimento(int id)
        {
            string sql = "DELETE FROM alimento WHERE Id_alimento=@id";
            conexion.abrir();
            using (MySqlCommand cmd = new MySqlCommand(sql, conexion.getConexion()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            conexion.cerrar();
        }
    }
}
