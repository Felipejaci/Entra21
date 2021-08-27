using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpt4
{
    class Cachorro : Comportamento
    {
        public string Nome { get; set; }
        public static double Dopamina { get; set; }
        public static double Conforto { get; set; }

        public static double Gula(double Comer)
        {
            Dopamina = Comer * 250;
            return Dopamina;
        }
        public static double Conf(double tempo)
        {
            Conforto = tempo * 100;
            return Conforto;
        }
    }
}
