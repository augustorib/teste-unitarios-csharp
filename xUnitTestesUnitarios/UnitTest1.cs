using Xunit;
using TestesUnitarios;
using System;

namespace xUnitTestesUnitarios
{
    public class UnitTest1
    {

        public Calculadora construirClasse()
        {
            string data = "02/02/2020";

            Calculadora calc = new Calculadora(data);

            return calc;
        }


        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int result)
        {
            Calculadora calc = construirClasse();

            int resultCalculadora = calc.somar(val1,val2);

            Assert.Equal(result, resultCalculadora);

        }


        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int result)
        {
            Calculadora calc = construirClasse();

            int resultCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(result, resultCalculadora);

        }


        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int result)
        {
            Calculadora calc = construirClasse();

            int resultCalculadora = calc.dividir(val1, val2);

            Assert.Equal(result, resultCalculadora);

        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 4, 1)]
        public void TesteSubtrair(int val1, int val2, int result)
        {
            Calculadora calc = construirClasse();

            int resultCalculadora = calc.subtrair(val1, val2);

            Assert.Equal(result, resultCalculadora);

        }

        [Fact]

        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3,0)
            );
        }
    }
}