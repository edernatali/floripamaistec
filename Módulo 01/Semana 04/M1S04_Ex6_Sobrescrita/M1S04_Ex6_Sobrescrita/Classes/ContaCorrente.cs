﻿using M1S04_Ex6_Sobrescrita.Classes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S04_Ex6_Sobrescrita.Classes
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }

        // Resposta exercício 06
        public override void Sacar(decimal valor)
        {
            // Taxa de R$ 0,50 por saque
            valor += 0.50M;
            base.Sacar(valor);
        }

        // Resposta exercício 06
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            // Taxa de R$ 0,25 por transferência
            valor += 0.25M;
            base.Transferir(conta, valor);
        }
    }
}
