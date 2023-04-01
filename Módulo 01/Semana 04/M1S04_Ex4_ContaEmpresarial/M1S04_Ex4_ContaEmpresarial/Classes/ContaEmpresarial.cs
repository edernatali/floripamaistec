using M1S04_Ex4_ContaEmpresarial.Classes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S04_Ex4_ContaEmpresarial.Classes
{
    public class ContaEmpresarial : ContaBancaria
    {

        public decimal LimiteEmprestimo { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public decimal ValorUsado { get; private set; }
        public bool PossuiEmprestimo { get; private set; }
        public string CNPJ { get; private set; }


        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal limiteEmprestimo, decimal taxaJuros, string cnpj) : base(numero, agencia, cliente)
        {
            // Resposta exercício 04
            LimiteEmprestimo = limiteEmprestimo;
            TaxaJuros = taxaJuros;
            CNPJ = cnpj;

            if (cliente.TipoPessoa != TipoPessoaEnum.JURIDICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo Jurídico!");
            }
        }
    }
}
