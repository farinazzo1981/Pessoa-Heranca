using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_Herança
{
    public class Pessoa

    {

        public static int numeroPessoa;

        public Pessoa()
        {
            Pessoa.numeroPessoa++;

        }
        public string nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime nascimento { get; set; }

        protected int CalculoIdade()
        {
            int idade = DateTime.Today.Year - nascimento.Year;

            return idade;
        }

        public virtual string GetIdentificacao()
        {
            return CPF;
        }

        
    }
    

}

