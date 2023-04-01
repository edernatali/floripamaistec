using M1S04_Ex2_base_ContaBancaria.Classes.Enum;
using M1S04_Ex2_base_ContaBancaria.Classes;

Cliente pessoaFisica = new Cliente("Eder Natali", DateTime.Parse("1990-08-30"), "Desenvolvedor", "Casado", TipoPessoaEnum.FISICA);

Console.WriteLine(pessoaFisica.Nome);