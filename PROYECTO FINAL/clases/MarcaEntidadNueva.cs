namespace PROYECTO_FINAL.clases
{
    public class MarcaEntidadNueva
    {
        public int IdMarca { get; set; }
        public string Nombre { get; set; }
        public int IdFabricante { get; set; }

        public MarcaEntidadNueva() { }

        public MarcaEntidadNueva(int idMarca, string nombre, int idFabricante)
        {
            IdMarca = idMarca;
            Nombre = nombre;
            IdFabricante = idFabricante;
        }

        public MarcaEntidadNueva(string nombre, int idFabricante)
        {
            Nombre = nombre;
            IdFabricante = idFabricante;
        }
    }
}
