using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpt4
{
    class Calculadora
    {
        public double Soma { get; set; }
        public double Subtracao { get; set; }
        public double Multipli { get; set; }
        public double Divisao { get; set; }

        public double SomaNu(double n1, double n2)
        {
            n1 = n1 + n2;
            return n1;
        }
        public double SubNu(double n1, double n2)
        {
            return n1 - n2;
        }
        public double MultNu(double n1, double n2)
        {
            return n1 * n2;
        }
        public double DiviNu(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
