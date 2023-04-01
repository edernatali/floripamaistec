using M1S03_Exercicio_ContaBancaria.Classes;
using M1S03_Exercicio_ContaBancaria.Classes.Enum;

ContaBancaria conta = new ContaBancaria("Eder Natali", TipoContaEnum.POUPANCA);
conta.dadosConta();
conta.dadosCliente();
conta.Depositar(50);
conta.Sacar(20);
conta.consultarSaldo();


