using System;
using CoordenadasPalabras.Controllers;
using Xunit;

namespace CoordenadasPalabrasTest
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
            var resultado = _controller.Get();
            Assert.NotNull(resultado); //TODO
        }
    }
}
