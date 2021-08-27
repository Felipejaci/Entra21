using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms04
{
    class Func
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Salario { get; set; }

        public Func(string nome, string cpf, int salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
        }
    }
}
