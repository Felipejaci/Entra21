using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpt4
{
    class Empresa : Endereco
    {
        string nome;
        int quantFunc;


        public string Nome { get; set; }
        public int QuantFunc { get; set; }
    }
}
