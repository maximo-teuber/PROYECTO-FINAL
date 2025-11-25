using System;
using MySql.Data.MySqlClient;
using PROYECTO_FINAL.clases;

namespace PROYECTO_FINAL.modelo
{
    public class ModeloProducto
    {
        private string connectionString = "server=localhost;database=tu_base;uid=tu_usuario;pwd=tu_contraseña;";

        public bool InsertarProducto(Alimento alimento)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = @"INSERT INTO alimento 
                (Nombre, IdMarca, TipoAlimento, PrecioKilo, PrecioBolsa, Stock, StockMinimo, StockMaximo, Peso, Sabor, IdFabricante) 
                VALUES (@Nombre, @IdMarca, @TipoAlimento, @PrecioKilo, @PrecioBolsa, @Stock, @StockMinimo, @StockMaximo, @Peso, @Sabor, @IdFabricante)";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Nombre", alimento.Nombre);
                cmd.Parameters.AddWithValue("@IdMarca", alimento.IdMarca);
                cmd.Parameters.AddWithValue("@TipoAlimento", alimento.TipoAlimento);
                cmd.Parameters.AddWithValue("@PrecioKilo", alimento.PrecioKilo);
                cmd.Parameters.AddWithValue("@PrecioBolsa", alimento.PrecioBolsa);
                cmd.Parameters.AddWithValue("@Stock", alimento.Stock);
                cmd.Parameters.AddWithValue("@StockMinimo", alimento.StockMinimo);
                cmd.Parameters.AddWithValue("@StockMaximo", alimento.StockMaximo);
                cmd.Parameters.AddWithValue("@Peso", alimento.Peso);
                cmd.Parameters.AddWithValue("@Sabor", alimento.Sabor);
                cmd.Parameters.AddWithValue("@IdFabricante", alimento.IdFabricante);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ActualizarProducto(Alimento alimento)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = @"UPDATE alimento SET 
                    Nombre=@Nombre, IdMarca=@IdMarca, TipoAlimento=@TipoAlimento, PrecioKilo=@PrecioKilo,
                    PrecioBolsa=@PrecioBolsa, Stock=@Stock, StockMinimo=@StockMinimo, StockMaximo=@StockMaximo,
                    Peso=@Peso, Sabor=@Sabor, IdFabricante=@IdFabricante 
                    WHERE IdAlimento=@IdAlimento";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@IdAlimento", alimento.IdAlimento);
                cmd.Parameters.AddWithValue("@Nombre", alimento.Nombre);
                cmd.Parameters.AddWithValue("@IdMarca", alimento.IdMarca);
                cmd.Parameters.AddWithValue("@TipoAlimento", alimento.TipoAlimento);
                cmd.Parameters.AddWithValue("@PrecioKilo", alimento.PrecioKilo);
                cmd.Parameters.AddWithValue("@PrecioBolsa", alimento.PrecioBolsa);
                cmd.Parameters.AddWithValue("@Stock", alimento.Stock);
                cmd.Parameters.AddWithValue("@StockMinimo", alimento.StockMinimo);
                cmd.Parameters.AddWithValue("@StockMaximo", alimento.StockMaximo);
                cmd.Parameters.AddWithValue("@Peso", alimento.Peso);
                cmd.Parameters.AddWithValue("@Sabor", alimento.Sabor);
                cmd.Parameters.AddWithValue("@IdFabricante", alimento.IdFabricante);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
