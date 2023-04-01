using M1S03_Exercicio_ContaBancaria.Classes;
using M1S03_Exercicio_ContaBancaria.Classes.Enum;

ContaBancaria conta = new ContaBancaria(5555, 0178, "Eder", TipoContaEnum.POUPANCA);
conta.Depositar(50);
conta.Sacar(20);
conta.consultarSaldo();


