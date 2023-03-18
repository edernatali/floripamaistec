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
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O Valor depositado precisa ser maior do que zero");
            }
            else
            {
                saldo = saldo + valor;
                Console.WriteLine("Depósito no valor: " + valor + " confirmado");
            }
        }

        //Resposta do exercício 05
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor que de saque precisa ser maior do que 0");
            }
            else if (valor > 0)
            {
                if (valor < saldo)
                {
                    saldo = saldo - valor;
                    Console.WriteLine("Saque no valor: " + valor + " confirmado");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente. Não foi possível realizar o saque.");
                }
            }
        }

        //Resposta do exercício 06
        public void consultarSaldo()
        {
            Console.WriteLine("O Saldo da conta é: " + saldo);
            
        }

    }
}
