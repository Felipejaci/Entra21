using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Hotel : IHotel
    {
        public string Nome { get; set; }
        public int QtdQuartos { get; set; }
        public int QtdQuartosOcupados { get; set; }
    }
}
