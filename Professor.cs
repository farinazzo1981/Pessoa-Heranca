using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_Herança
{

    public interface IPessoa 
    { string GetIdentificacao(); }

    public class Professor : Pessoa, IPessoa
    {
        public string funcional{get; set;}
        public string disciplina{get; set;}
        private double salario{get; set;}

        public override string GetIdentificacao()
        {
            return "Funcional do professor: " + funcional;
        }

        
    }
}
