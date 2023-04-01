using M1S04_Ex4_ContaEmpresarial.Classes;
using M1S04_Ex4_ContaEmpresarial.Classes.Enum;

Cliente pessoaJuridica = new Cliente("Tratus Engenharia", DateTime.Parse("1990-08-30"), "Desenvolvedor", "Casado", TipoPessoaEnum.JURIDICA);

ContaEmpresarial contaEmpresarial = new ContaEmpresarial(1234, 1234, pessoaJuridica, 30000, 10, "0415065240001153");
contaEmpresarial.Depositar(500);
contaEmpresarial.consultarSaldo();

Cliente pessoaFisica = new Cliente("Eder Natali", DateTime.Parse("1990-08-30"), "Desenvolvedor", "Casado", TipoPessoaEnum.FISICA);
ContaPoupanca contaPoupanca = new ContaPoupanca(1542, 1234, pessoaFisica);

contaPoupanca.Depositar(200);
contaPoupanca.consultarSaldo();