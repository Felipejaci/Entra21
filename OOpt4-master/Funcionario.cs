using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpt4
{
    class Funcionario : Comportamento
    {
        public string Nome { get; set; }
        public static double DinheBolso { get; set; }

        public static double Escravo(double QuantDinhe)
        {
            DinheBolso = QuantDinhe / 24.52;
            DinheBolso = 62 - DinheBolso;
            return DinheBolso;
        }

    }
}
