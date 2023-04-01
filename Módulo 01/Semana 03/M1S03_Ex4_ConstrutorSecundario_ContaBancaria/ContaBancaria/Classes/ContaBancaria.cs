using System.ComponentModel.Design;
using M1S03_Exercicio_ContaBancaria.Classes.Enum;

namespace M1S03_Exercicio_ContaBancaria.Classes
{
    public class ContaBancaria
    {
     //-------------------- Resposta do Exercício 03 da Semana 03 -----------------------------------
    //--------------[M1S03] Ex 3 - Alteração de visibilidade da classe ContaBancaria ----------------
        private int _numero;
        private int _agencia;
        private string _nomeDoTitular;
        private decimal _saldo = 0;
        private TipoContaEnum _tipoConta;

     //-------------------- Resposta do Exercício 02 da Semana 03 -----------------------------------
     //---------------[M1S03] Ex 2 - Criação de construtor da classe ContaBancaria-------------------

        public ContaBancaria(int numero, int agencia, string nomeDoTitular, TipoContaEnum tipoConta)
        {
            _numero = numero;
            _agencia = agencia;
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }

     //-------------------- Resposta do Exercício 04 da Semana 03 -----------------------------------
     //--------[M1S03] Ex 4 - Criação de construtor secundário para a classe ContaBancaria-----------
        public ContaBancaria(string nomeDoTitular, TipoContaEnum tipoConta)
        {
            Random random = new Random();

            // gera um número aleatório entre 0000 e 9999
            _numero = random.Next(0000, 9999);
            _agencia = random.Next(0000, 9999);

            // atribui os valores do construtor
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }

        //Verificar dados da conta.
        public void dadosConta()
        {
            Console.WriteLine("Dados da conta: número: " + _numero + " agência: " + _agencia + " tipo de conta: " + _tipoConta);

        }

        //Verificar dados do usuário.
        public void dadosCliente()
        {
            Console.WriteLine("Dados do titular: " + _nomeDoTitular);

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
                _saldo = _saldo + valor;
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
                if (valor < _saldo)
                {
                    _saldo = _saldo - valor;
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
            Console.WriteLine("O Saldo da conta é: " + _saldo);
            
        }

    }
}
