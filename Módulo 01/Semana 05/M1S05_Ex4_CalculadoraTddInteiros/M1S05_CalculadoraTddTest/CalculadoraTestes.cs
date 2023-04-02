using M1S05_CalculadoraTdd.Classes;

namespace M1S05_CalculadoraTddTest
{
    public class CalculadoraTestes
    {
        [Fact]
        [Trait("Categoria", "Somar")]
        public void TestarSomarComNumerosInteiros()
        {
            // receber o resultado
            int resultado = Calculadora.Somar(5, 5);

            // resultado a ser comparado
            int esperado = 10;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Subtrair")]
        public void TestarSubtrairComNumerosInteiros()
        {
            // receber o resultado
            int resultado = Calculadora.Subtrair(20, 5);

            // resultado a ser comparado
            int esperado = 15;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Multiplicar")]
        public void TestarMultiplicarComNumerosInteiros()
        {
            // receber o resultado
            int resultado = Calculadora.Multiplicar(4, 5);

            // resultado a ser comparado
            int esperado = 20;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Dividir")]
        public void TestarDividirComNumerosInteiros()
        {
            // receber o resultado
            int resultado = Calculadora.Dividir(30, 5);

            // resultado a ser comparado
            int esperado = 6;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }


    }
}