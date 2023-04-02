using M1S05_CalculadoraTdd.Classes;

namespace M1S05_CalculadoraTddTest
{
    public class CalculadoraTestes
    {

// ---------------- Teste com números do tipo inteiros ------------------------
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

// ---------------- Teste com números do tipo Double ------------------------

        [Fact]
        [Trait("Categoria", "Somar")]
        public void TestarSomarComNumerosDouble()
        {
            // receber o resultado
            double resultado = Calculadora.Somar(5.5, 5.5);

            // resultado a ser comparado
            double esperado = 11;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Subtrair")]
        public void TestarSubtrairComNumerosDouble()
        {
            // receber o resultado
            double resultado = Calculadora.Subtrair(20.5, 5.5);

            // resultado a ser comparado
            double esperado = 15;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Multiplicar")]
        public void TestarMultiplicarComNumerosDouble()
        {
            // receber o resultado
            double resultado = Calculadora.Multiplicar(4.5, 5.5);

            // resultado a ser comparado
            double esperado = 24.75;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Dividir")]
        public void TestarDividirComNumerosDouble()
        {
            // receber o resultado
            double resultado = Calculadora.Dividir(24.75, 5.5);

            // resultado a ser comparado
            double esperado = 4.5;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

// ---------------- Teste com números do tipo Float ------------------------

        [Fact]
        [Trait("Categoria", "Somar")]
        public void TestarSomarComNumerosFloat()
        {
            // receber o resultado
            float resultado = Calculadora.Somar(5.5F, 5.5F);

            // resultado a ser comparado
            float esperado = 11F;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Subtrair")]
        public void TestarSubtrairComNumerosFloat()
        {
            // receber o resultado
            float resultado = Calculadora.Subtrair(20.5F, 5.5F);

            // resultado a ser comparado
            float esperado = 15F;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Multiplicar")]
        public void TestarMultiplicarComNumerosFloat()
        {
            // receber o resultado
            float resultado = Calculadora.Multiplicar(4.5F, 5.5F);

            // resultado a ser comparado
            float esperado = 24.75F;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Dividir")]
        public void TestarDividirComNumerosFloat()
        {
            // receber o resultado
            float resultado = Calculadora.Dividir(24.75F, 5.5F);

            // resultado a ser comparado
            float esperado = 4.5F;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

// ---------------- Teste com números do tipo Decimal ------------------------

        [Fact]
        [Trait("Categoria", "Somar")]
        public void TestarSomarComNumerosDecimal()
        {
            // receber o resultado
            decimal resultado = Calculadora.Somar(5.5M, 5.5M);

            // resultado a ser comparado
            decimal esperado = 11M;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Subtrair")]
        public void TestarSubtrairComNumerosDecimal()
        {
            // receber o resultado
            decimal resultado = Calculadora.Subtrair(20.5M, 5.5M);

            // resultado a ser comparado
            decimal esperado = 15M;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Multiplicar")]
        public void TestarMultiplicarComNumerosDecimal()
        {
            // receber o resultado
            decimal resultado = Calculadora.Multiplicar(4.5M, 5.5M);

            // resultado a ser comparado
            decimal esperado = 24.75M;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Dividir")]
        public void TestarDividirComNumerosDecimal()
        {
            // receber o resultado
            decimal resultado = Calculadora.Dividir(24.75M, 5.5M);

            // resultado a ser comparado
            decimal esperado = 4.5M;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

// ---------------- Teste com números do tipo Long ------------------------

        [Fact]
        [Trait("Categoria", "Somar")]
        public void TestarSomarComNumerosLong()
        {
            // receber o resultado
            long resultado = Calculadora.Somar(250000L, 50000L);

            // resultado a ser comparado
            long esperado = 300000L;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Subtrair")]
        public void TestarSubtrairComNumerosLong()
        {
            // receber o resultado
            long resultado = Calculadora.Subtrair(250000L, 50000L);

            // resultado a ser comparado
            long esperado = 200000L;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Multiplicar")]
        public void TestarMultiplicarComNumerosLong()
        {
            // receber o resultado
            long resultado = Calculadora.Multiplicar(250000L, 2L);

            // resultado a ser comparado
            long esperado = 500000L;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Dividir")]
        public void TestarDividirComNumerosLong()
        {
            // receber o resultado
            long resultado = Calculadora.Dividir(500000L, 2L);

            // resultado a ser comparado
            long esperado = 250000L;

            // executa a comparação
            Assert.Equal(esperado, resultado);
        }
    }
}