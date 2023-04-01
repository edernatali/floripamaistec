using M1S03_Exercicio_ContaBancaria.Classes;
using M1S03_Exercicio_ContaBancaria.Classes.Enum;

ContaBancaria conta1 = new ContaBancaria(1658, 5674, "Eder Natali", TipoContaEnum.POUPANCA);
ContaBancaria conta2 = new ContaBancaria(5264, 5986, "Luana Natali", TipoContaEnum.POUPANCA);

Console.WriteLine("------------------------------------------");
Console.WriteLine("Conta origem: ");
conta1.dadosConta();
conta1.dadosCliente();
conta1.Depositar(50);
//conta1.Sacar(20);
conta1.consultarSaldo();

Console.WriteLine("------------------------------------------");
Console.WriteLine("Conta destino: ");
conta2.dadosConta();
conta2.dadosCliente();
conta2.consultarSaldo();

conta1.Transferir(conta2, 20);
Console.WriteLine("------------------------------------------");
Console.WriteLine("Conta origem: ");
conta1.consultarSaldo();
Console.WriteLine("Conta destino: ");
conta2.consultarSaldo();


