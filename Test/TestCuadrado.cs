using Xunit;
using Objetos;

namespace Test
{
    public class TestCuadrado
    {
        [Fact]
        public void Area_Lado2()
        {
            decimal valorResultado = Cuadrado.Area(2);
            decimal valorEsperado = 4;

            Assert.Equal(valorEsperado, valorResultado);
        }

        [Fact]
        public void Area_Lado3()
        {
            decimal valorResultado = Cuadrado.Area(3);
            decimal valorEsperado = 9;

            Assert.Equal(valorEsperado, valorResultado);
        }

        [Fact]
        public void Area_Lado10()
        {
            decimal valorResultado = Cuadrado.Area(10);
            decimal valorEsperado = 100;

            Assert.Equal(valorEsperado, valorResultado);
        }
    }
}