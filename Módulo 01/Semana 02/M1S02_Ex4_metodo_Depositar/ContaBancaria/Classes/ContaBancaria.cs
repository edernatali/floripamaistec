using System.ComponentModel.Design;

namespace M1S02_Exercicio_ContaBancaria.Classes
{
    public class ContaBancaria
    {
        //Resposta Exercício 03
        public int numero;
        public int agencia;
        public string nomeDoTitular;
        public decimal saldo = 0;
        public TipoContaEnum tipoConta;

        //Reposta Exercício 04
        public void Depositar (decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O Valor de depositado precisa ser maior do que zero");
            }else
            {
                saldo = saldo + valor;
                Console.WriteLine("Depósito no valor: " + valor + " confirmado");
            }
        }

    }
}
