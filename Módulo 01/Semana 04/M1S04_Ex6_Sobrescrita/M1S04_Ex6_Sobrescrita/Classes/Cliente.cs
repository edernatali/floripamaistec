using M1S04_Ex6_Sobrescrita.Classes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S04_Ex6_Sobrescrita.Classes
{
    //[M1S04] Ex 1 - Criação de Classe Cliente
    public class Cliente
    {
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public string EstadoCivil { get; private set; }
        public TipoPessoaEnum TipoPessoa { get; private set; }

        public Cliente(string nome, DateTime nascimento, string profissao, string estadoCivil, TipoPessoaEnum tipoPessoa)
        {
            Nome = nome;
            Nascimento = nascimento;
            Profissao = profissao;
            EstadoCivil = estadoCivil;
            TipoPessoa = tipoPessoa;
        }
    }
}
