using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_Herança
{
    internal class Cadastro
    {
        private List<Pessoa> Pessoas;

        public Cadastro() { 
            Pessoas = new List<Pessoa>();
        }
        public void AddPessoa(Pessoa p) 
        { 
            Pessoas.Add(p);
        }
    }
}
