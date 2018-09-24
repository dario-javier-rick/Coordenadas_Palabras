using System;
using System.Linq;

namespace CoordenadasPalabras.BLL
{
    public class EstrategiaBusqueda : BusquedaStrategy
    {
        public override int[,] Buscar(string[] secuencias, string palabra)
        {
            int[][] jaggedArray = new int[palabra.Length][];

            bool encontrado = false;
            bool busquedaHorizontal = false;
            bool busquedaVertical = false;
            bool busquedaDiagonal = false;

            #region Busqueda horizontal
            for (int i = 0; i < secuencias.Length; i++)
            {
                string fila = secuencias[i];
                if (fila.Contains(palabra.ToUpper()))
                {
                    int letrasEncontradas = 0;

                    for (int j = 0; j < fila.Length; j++)
                    {
                        if (string.Equals(fila[j].ToString(), palabra[letrasEncontradas].ToString()))
                        {
                            jaggedArray[letrasEncontradas] = new[] { i, j };
                            letrasEncontradas++;
                        }
                    }
                    encontrado = true;
                }
            }
            busquedaHorizontal = true;
            #endregion

            if (!encontrado)
            {
                #region Busqueda vertical
                for (int i = 0; i < secuencias.FirstOrDefault().Length; i++)
                {
                    string palabraVertical = string.Empty;

                    for (int j = 0; j < secuencias.Length; j++)
                    {
                        palabraVertical = palabraVertical + secuencias[j][i];
                    }

                    if (palabraVertical.ToUpper().Contains(palabra.ToUpper()))
                    {
                        int letrasEncontradas = 0;
                        for (int k = 0; k < palabraVertical.Length; k++)
                        {
                            if (letrasEncontradas < palabra.Length
                                && string.Equals(palabraVertical[k].ToString(), palabra[letrasEncontradas].ToString()))
                            {
                                jaggedArray[letrasEncontradas] = new[] { i, k };
                                letrasEncontradas++;
                            }
                        }
                        encontrado = true;
                    }
                }
                busquedaVertical = true;
                #endregion
            }

            if (!encontrado)
            {
                #region Busqueda diagonal
                //TODO...
                busquedaDiagonal = true;
                #endregion
            }

            return ConvertirA2D(jaggedArray);
        }

        private static T[,] ConvertirA2D<T>(T[][] jaggedArray)
        {
            try
            {
                int primerRegistro = jaggedArray.Length;
                int segundoRegistro = jaggedArray.GroupBy(row => row.Length).Single().Key;

                var result = new T[primerRegistro, segundoRegistro];
                for (int i = 0; i < primerRegistro; ++i)
                {
                    for (int j = 0; j < segundoRegistro; ++j)
                    {
                        result[i, j] = jaggedArray[i][j];
                    }
                }

                return result;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("El jagged array no es rectangular");
            }
        }
    }
}
