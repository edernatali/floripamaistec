using M1S04_Ex6_Sobrescrita.Classes;
using M1S04_Ex6_Sobrescrita.Classes.Enum;

Cliente pessoaJuridica = new Cliente("Tratus Engenharia", DateTime.Parse("1990-08-30"), "Desenvolvedor", "Casado", TipoPessoaEnum.JURIDICA);

ContaEmpresarial contaEmpresarial = new ContaEmpresarial(1234, 1234, pessoaJuridica, 30000, 10, "0415065240001153");

contaEmpresarial.FazerEmprestimo(1500);
contaEmpresarial.Depositar(200);
contaEmpresarial.consultarSaldo();
contaEmpresarial.PagarEmprestimo();
contaEmpresarial.consultarSaldo();

Cliente pessoaFisica = new Cliente("Eder Natali", DateTime.Parse("1990-08-30"), "Desenvolvedor", "Casado", TipoPessoaEnum.FISICA);

ContaCorrente contaCorrente = new ContaCorrente(6574, 1234, pessoaFisica);
contaCorrente.Depositar(200);
contaCorrente.Sacar(50);
contaCorrente.consultarSaldo();

ContaPoupanca contaPoupanca = new ContaPoupanca(9874, 1234, pessoaFisica);
contaPoupanca.Depositar(200);
contaPoupanca.Transferir(contaCorrente, 50);
contaPoupanca.consultarSaldo();
