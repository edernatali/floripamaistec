using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S05_CalculadoraTdd.Classes
{
    public static class Calculadora
    {
// --------------------- Resposta do exercício 04 da semana 5.  ----------------------------

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

// --------------------- Resposta do exercício 05 da semana 5.  ----------------------------

        /// <summary>
        /// Executa a soma de dois números do tipo double
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static double Somar(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Executa a soma de dois números do tipo float
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static float Somar(float a, float b)
        {
            return a + b;
        }

        /// <summary>
        /// Executa a soma de dois números decimais
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static decimal Somar(decimal a, decimal b)
        {
            return a + b;
        }

        /// <summary>
        /// Executa a soma de dois números do tipo long
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static long Somar(long a, long b)
        {
            return a + b;
        }
 
 // --------------------- Resposta do exercício 04 da semana 5.  ----------------------------

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
// --------------------- Resposta do exercício 05 da semana 5.  ----------------------------

        /// <summary>
        /// Executa a subtracao de dois números do tipo double
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static double Subtrair(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Executa a subtracao de dois números do tipo float
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static float Subtrair(float a, float b)
        {
            return a - b;
        }

        /// <summary>
        /// Executa a subtracao de dois números decimais
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static decimal Subtrair(decimal a, decimal b)
        {
            return a - b;
        }

        /// <summary>
        /// Executa a subtracao de dois números do tipo long
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static long Subtrair(long a, long b)
        {
            return a - b;
        }

// --------------------- Resposta do exercício 04 da semana 5.  ----------------------------

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

// --------------------- Resposta do exercício 05 da semana 5.  ----------------------------
        /// <summary>
        /// Executa a multiplicacao de dois números do tipo double
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Executa a multiplicacao de dois números do tipo float
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static float Multiplicar(float a, float b)
        {
            return a * b;
        }

        /// <summary>
        /// Executa a multiplicacao de dois números decimais
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static decimal Multiplicar(decimal a, decimal b)
        {
            return a * b;
        }

        /// <summary>
        /// Executa a multiplicacao de dois números do tipo long
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static long Multiplicar(long a, long b)
        {
            return a * b;
        }

// --------------------- Resposta do exercício 04 da semana 5.  ----------------------------

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

// --------------------- Resposta do exercício 05 da semana 5.  ----------------------------

        /// <summary>
        /// Executa a divisao de dois números do tipo double
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static double Dividir(double a, double b)
        {
            return a / b;
        }

        /// <summary>
        /// Executa a divisao de dois números do tipo float
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static float Dividir(float a, float b)
        {
            return a / b;
        }

        /// <summary>
        /// Executa a divisao de dois números decimais
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static decimal Dividir(decimal a, decimal b)
        {
            return a / b;
        }

        /// <summary>
        /// Executa a divisao de dois números do tipo long
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns></returns>
        public static long Dividir(long a, long b)
        {
            return a / b;
        }

    }
}
