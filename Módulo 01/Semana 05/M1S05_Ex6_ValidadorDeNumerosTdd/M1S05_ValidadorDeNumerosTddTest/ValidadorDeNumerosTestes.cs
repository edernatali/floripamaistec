using M1S05_ValidadorDeNumerosTdd.Classes;

namespace M1S05_ValidadorDeNumerosTddTest
{
    public class ValidadorDeNumerosTestes
    {

        [Theory]
        [Trait("Categoria", "EhNumeroPrimo")]
        [InlineData(7)]
        [InlineData(5)]
        [InlineData(12)]
        public void TestarEhNumeroPrimo(int numero)
        {
            bool resultado = ValidadorDeNumeros.EhNumeroPrimo(numero);
            Assert.True(resultado);
        }

        [Theory]
        [Trait("Categoria", "ParOuImpar")]
        [InlineData(10)]
        [InlineData(5)]
        [InlineData(12)]
        public void TestarParOuImpar(int numero)
        {
            string resultado = ValidadorDeNumeros.ParOuImpar(numero);
            string esperado = "Par";

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [Trait("Categoria", "EhDivisivelPor")]
        [InlineData(9, 3)]
        [InlineData(25, 5)]
        [InlineData(27, 2)]
        public void TestarDivisivelPor(int dividendo, int divisor)
        {
            bool resultado = ValidadorDeNumeros.EhDivisivelPor(dividendo, divisor);
            Assert.True(resultado);
        }
    }
}