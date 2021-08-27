using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpt4
{
    class Cientifica : Calculadora
    {
        public double raiz { get; set; }
        public double potencia { get; set; }

        public double RaizNu(double nu1)
        {
            return Math.Sqrt(nu1);
        }
        public double PoteNu(double nu1, double nu2)
        {
            return Math.Pow(nu1, nu2);
        }
    }
}
