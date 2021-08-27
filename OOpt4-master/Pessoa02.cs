using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpt4
{
    class Pessoa02 : Comportamento
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public static double Dopamina { get; set; }
        public static double QuantDinhe { get; set; }
        public static double Gula(double Comer)
        {
            Dopamina = Comer * 250;
            return Dopamina;

        }
        public static double Escravo(int Trabalhar)
        {
            QuantDinhe = Trabalhar * 24.52;
            return QuantDinhe;
        }
    }
}
