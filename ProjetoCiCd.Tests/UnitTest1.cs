using Xunit;

namespace ProjetoCiCd.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Teste_Soma_1()
        {
            int a = 2;
            int b = 3;
            int resultado = a + b;

            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Teste_Soma_2()
        {
            int a = 10;
            int b = 5;
            int resultado = a + b;

            Assert.Equal(15, resultado);
        }

        [Fact]
        public void Teste_Subtracao()
        {
            int a = 10;
            int b = 4;
            int resultado = a - b;

            Assert.Equal(6, resultado);
        }

        [Fact]
        public void Teste_Multiplicacao()
        {
            int a = 3;
            int b = 4;
            int resultado = a * b;

            Assert.Equal(12, resultado);
        }

        [Fact]
        public void Teste_Divisao()
        {
            int a = 10;
            int b = 2;
            int resultado = a / b;

            Assert.Equal(5, resultado);
        }
    }
}