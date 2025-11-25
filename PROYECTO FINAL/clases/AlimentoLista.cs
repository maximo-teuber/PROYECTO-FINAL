namespace PROYECTO_FINAL

{
    public class AlimentoLista
    {
        public int IdAlimento { get; set; }
        public string Nombre { get; set; }
        public string TipoAlimento { get; set; }
        public decimal PrecioKilo { get; set; }
        public decimal PrecioBolsa { get; set; }
        public decimal PesoBolsa { get; set; }
        public string Sabor { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public string Marca { get; set; }
    }
}
