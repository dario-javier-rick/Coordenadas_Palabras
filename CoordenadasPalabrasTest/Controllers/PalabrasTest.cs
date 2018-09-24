using CoordenadasPalabras.Controllers;
using Xunit;

namespace CoordenadasPalabrasTest.Controllers
{
    public class PalabrasTest
    {
        private readonly PalabrasController _controller;

        public PalabrasTest()
        {
            _controller = new PalabrasController();
        }

        [Fact]
        public void Test1()
        {
            var resultado = _controller.GetPosiciones("TELEFE");
            Assert.NotNull(resultado); //TODO
        }
    }
}
