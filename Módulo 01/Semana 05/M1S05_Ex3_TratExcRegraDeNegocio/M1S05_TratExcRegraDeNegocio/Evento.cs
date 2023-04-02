using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S05_TratExcRegraDeNegocio
{
    internal class Evento
    {
        int qtdLugares;
        int qtdIngressosVendidos;

        public Evento()
        {

        }

        public int QtdLugares { get; set; }
        public int QtdIngressosVendidos { get; set; }

        public void ingressoVendido()
        {
            Console.WriteLine("Ingresso vendido com sucesso!");
        }


    }
}
