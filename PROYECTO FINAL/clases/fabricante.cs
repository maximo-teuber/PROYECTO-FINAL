namespace PROYECTO_FINAL.Modelos
{
    public class ModeloFabricante
    {
        public int IdFabricante { get; set; }
        public string Nombre { get; set; }
        public string Origen { get; set; }

        public ModeloFabricante() { }

        public ModeloFabricante(string nombre, string origen)
        {
            Nombre = nombre;
            Origen = origen;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
