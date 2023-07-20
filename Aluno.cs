using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_Herança
{
    public class Aluno : Pessoa
    {
        public string RA{get; set;}
        public string curso{get; set;}
        private double mensalidade{get; set;}

        public override string GetIdentificacao()
        {
            return "RA do aluno: " + RA;
        }


    }
}
