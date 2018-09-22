using System;

namespace CoordenadasPalabras.BLL
{
    public static class StringArrayExtensions
    {
        private static BusquedaStrategy _estrategia;

        public static void ConfigurarEstrategiaBusqueda(this string[] secuencias, BusquedaStrategy estrategia)
        {
            _estrategia = estrategia;
        }

        public static int[,] Buscar(this string[] secuencias, string palabra)
        {
            if (_estrategia == null)
            {
                throw new Exception("Estrategia no configurada.");
            }
            return _estrategia.Buscar(secuencias, palabra);
        }
    }

}
