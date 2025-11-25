namespace PROYECTO_FINAL.modelo
{
    public class MarcaEntidad
    {
        public int IdMarca { get; set; }
        public string Nombre { get; set; }
        public int IdFabricante { get; set; }

        public MarcaEntidad() { }

        public MarcaEntidad(string nombre, int idFabricante)
        {
            Nombre = nombre;
            IdFabricante = idFabricante;
        }
    }
}
