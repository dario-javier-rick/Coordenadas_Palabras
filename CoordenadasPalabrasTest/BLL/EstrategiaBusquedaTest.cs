using CoordenadasPalabras.BLL;
using Xunit;

namespace CoordenadasPalabrasTest.BLL
{
    public class EstrategiaBusquedaTest
    {
        private readonly string[] _secuencias = { "AGVNFT", "XJILSB", "CHAOHD", "ERCVTQ", "ASOYAO", "ERMYUA", "TELEFE" };

        public EstrategiaBusquedaTest()
        {
            _secuencias.ConfigurarEstrategiaBusqueda(new EstrategiaBusqueda());
        }

        [Fact]
        public void Test1()
        {
            var palabraBuscada = "AGVNFT";
            var resultado = _secuencias.Buscar(palabraBuscada);
            var resEsperado = new int[palabraBuscada.Length, 2];
            resEsperado[0, 0] = 0;
            resEsperado[0, 1] = 0;
            resEsperado[1, 0] = 0;
            resEsperado[1, 1] = 1;
            resEsperado[2, 0] = 0;
            resEsperado[2, 1] = 2;
            resEsperado[3, 0] = 0;
            resEsperado[3, 1] = 3;
            resEsperado[4, 0] = 0;
            resEsperado[4, 1] = 4;
            resEsperado[5, 0] = 0;
            resEsperado[5, 1] = 5;

            Assert.Equal(resultado, resEsperado);
        }

        [Fact]
        public void Test2()
        {
            var palabraBuscada = "TELEFE";
            var resultado = _secuencias.Buscar(palabraBuscada);
            var resEsperado = new int[palabraBuscada.Length, 2];
            resEsperado[0, 0] = 6;
            resEsperado[0, 1] = 0;
            resEsperado[1, 0] = 6;
            resEsperado[1, 1] = 1;
            resEsperado[2, 0] = 6;
            resEsperado[2, 1] = 2;
            resEsperado[3, 0] = 6;
            resEsperado[3, 1] = 3;
            resEsperado[4, 0] = 6;
            resEsperado[4, 1] = 4;
            resEsperado[5, 0] = 6;
            resEsperado[5, 1] = 5;

            Assert.Equal(resultado, resEsperado);
        }

        [Fact]
        public void Test3()
        {
            var palabraBuscada = "VIACOM";
            var resultado = _secuencias.Buscar(palabraBuscada);
            var resEsperado = new int[palabraBuscada.Length, 2];
            resEsperado[0, 0] = 2;
            resEsperado[0, 1] = 0;
            resEsperado[1, 0] = 2;
            resEsperado[1, 1] = 1;
            resEsperado[2, 0] = 2;
            resEsperado[2, 1] = 2;
            resEsperado[3, 0] = 2;
            resEsperado[3, 1] = 3;
            resEsperado[4, 0] = 2;
            resEsperado[4, 1] = 4;
            resEsperado[5, 0] = 2;
            resEsperado[5, 1] = 5;

            Assert.Equal(resultado, resEsperado);
        }

        [Fact]
        public void Test4()
        {
            var palabraBuscada = "JAVA";
            var resultado = _secuencias.Buscar(palabraBuscada);
            var resEsperado = new int[palabraBuscada.Length, 2];
            resEsperado[0, 0] = 1;
            resEsperado[0, 1] = 2;
            resEsperado[1, 0] = 2;
            resEsperado[1, 1] = 3;
            resEsperado[2, 0] = 3;
            resEsperado[2, 1] = 4;
            resEsperado[3, 0] = 4;
            resEsperado[3, 1] = 5;

            Assert.Equal(resultado, resEsperado);
        }
    }
}
