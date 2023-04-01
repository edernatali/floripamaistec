using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S04_Ex5_Metodos.Classes
{
    public class ContaBancaria
    {
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public decimal Saldo { get; protected set; }
        public Cliente Cliente { get; protected set; }

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            Saldo = 0;
            Cliente = cliente;
        }

        public virtual void Transferir(ContaBancaria conta, decimal valor)
        {
            // Verifica se o valor a ser transferido é maior do que 0
            if (valor <= 0)
            {
                Console.WriteLine("O valor transferido precisa ser maior do que 0!");
                return;
            }

            // Verifica se há saldo suficiente para realizar a transferência
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente. Não foi possível realizar a transferência.");
                return;
            }

            Saldo = Saldo - valor;
            conta.Depositar(valor);
            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");
        }

        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O Valor depositado precisa ser maior do que zero");
            }
            else
            {
                Saldo = Saldo + valor;
                // Console.WriteLine("Operação realizada com sucesso!");
            }
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor que de saque precisa ser maior do que 0");
            }
            else if (valor > 0)
            {
                if (valor < Saldo)
                {
                    Saldo = Saldo - valor;
                    Console.WriteLine("Saque no valor: " + valor + " confirmado");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente. Não foi possível realizar o saque.");
                }
            }
        }

        public virtual void consultarSaldo()
        {
            Console.WriteLine("O Saldo da conta é: " + Saldo);

        }
    }
}
