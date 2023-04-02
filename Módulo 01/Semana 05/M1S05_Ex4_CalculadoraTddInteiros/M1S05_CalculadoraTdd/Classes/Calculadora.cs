using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S05_CalculadoraTdd.Classes
{
    public static class Calculadora
    {
        /// <summary>
        /// Executa a soma de dois números inteiros
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Executa a subtracao de dois números inteiros
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static int Subtrair(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Executa a multiplicacao de dois números inteiros
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Executa a divisao de dois números inteiros
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static int Dividir(int a, int b)
        {
            return a / b;
        }

    }
}
