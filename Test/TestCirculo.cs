using Xunit;
using Objetos;

namespace Test
{
    public class TestCirculo
    {
        [Fact]
        public void Area_Radio5()
        {
            decimal valorResultado = Cuadrado.Area(2);
            decimal valorEsperado = 4;

            Assert.Equal(valorEsperado, valorResultado);
        }
    }
}