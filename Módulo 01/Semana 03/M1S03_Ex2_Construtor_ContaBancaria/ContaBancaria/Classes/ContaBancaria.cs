using System.ComponentModel.Design;
using M1S03_Exercicio_ContaBancaria.Classes.Enum;

namespace M1S03_Exercicio_ContaBancaria.Classes
{
    public class ContaBancaria
    {
        //Resposta Exercício 03 Semana 02
        public int numero;
        public int agencia;
        public string nomeDoTitular;
        public decimal saldo = 0;
        public TipoContaEnum tipoConta;

     //-------------------- Resposta do Exercício 02 da Semana 03 -----------------------------------
        public ContaBancaria(int numero, int agencia, string nomeDoTitular, TipoContaEnum tipoConta)
        {
            this.numero = numero;
            this.agencia = agencia;
            this.nomeDoTitular = nomeDoTitular;
            this.tipoConta = tipoConta;
        }

    //---------------------- Exercícios abaixo são da semana 02 -------------------------------------

        //Reposta Exercício 04 Semana 02
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

        //Resposta do exercício 05 Semana 02
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

        //Resposta do exercício 06 Semana 02
        public void consultarSaldo()
        {
            Console.WriteLine("O Saldo da conta é: " + saldo);
            
        }

    }
}
