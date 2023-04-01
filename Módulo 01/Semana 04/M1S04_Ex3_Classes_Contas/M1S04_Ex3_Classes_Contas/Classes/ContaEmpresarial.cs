using M1S04_Ex3_Classes_Contas.Classes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S04_Ex3_Classes_Contas.Classes
{
    public class ContaEmpresarial : ContaBancaria
    { 
        public ContaEmpresarial(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoPessoaEnum.JURIDICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo Jurídico!");
            }
        }
    }
}
