namespace CoordenadasPalabras.BLL
{
    public class EstrategiaBusqueda : BusquedaStrategy
    {
        public override int[,] Buscar(string[] secuencias, string palabra)
        {
            int[][] jaggedArray = new int[palabra.Length][];
            jaggedArray[0] = new[] { 3, 0 };
            jaggedArray[1] = new[] { 3, 1 };
            jaggedArray[2] = new[] { 3, 2 };
            jaggedArray[3] = new[] { 3, 3 };

            //Matriz con las
            int[,] resultado = new int[palabra.Length, 2];
            int letrasEncontradas = 0;

            for (int i = 0; i < secuencias.Length; i++)
            {
                string fila = secuencias[i];
                for (int j = 0; j < fila.Length; j++)
                {
                    if (fila[j].ToString().ToUpper() == palabra[letrasEncontradas].ToString().ToUpper())
                    {
                        resultado[i, j] = 1; //Marco con un 1 si encuentro el dato
                        letrasEncontradas++;
                    }
                }
            }

            return resultado;
        }
    }
}
