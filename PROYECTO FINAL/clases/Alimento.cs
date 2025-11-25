namespace PROYECTO_FINAL.clases
{
    public class Alimento
    {
        public int IdAlimento { get; set; }
        public string Nombre { get; set; }

        // Ajuste: el modelo y la tabla usan IdMarca (entero)
        public int IdMarca { get; set; }

        // Ajuste: el modelo usa TipoAlimento, no "Tipo"
        public string TipoAlimento { get; set; }

        public decimal PrecioKilo { get; set; }
        public decimal PrecioBolsa { get; set; }

        // Ajuste: el modelo usa "Peso", no "PesoBolsa"
        public decimal Peso { get; set; }

        public string Sabor { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }

        // Ajuste: el modelo usa IdFabricante
        public int IdFabricante { get; set; }
    }
}
