namespace CoordenadasPalabras.BLL
{
    public abstract class BusquedaStrategy
    {
        public abstract int[,] Buscar(string[] secuencias, string palabra);
    }
}
